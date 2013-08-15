using System;
using System.Text;
using System.Diagnostics;
using System.ServiceModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Linq;
using System.Linq;

namespace EcodexIntegrationSample
{
    class frmTimbradoXMLFileController
    {
        private View.IXmlFile _view;
        private Random _random;
        string token = String.Empty;

        public frmTimbradoXMLFileController(View.IXmlFile view)
        {
            _random = new Random();
            _view = view;
            _view.OnInvoicesProcessStart += _view_OnInvoicesProcessStart;
            _view.OnSelectResultFile += _view_OnSelectResultFile;
            _view.OnGetToken += _view_OnGetToken;
            _view.OnSealandStampandStamp += _view_OnSealandStampandStamp;
        }
        void _view_OnInvoicesProcessStart(object sender, EventArgs e)
        {
            long transactionID = _random.Next();

            Int16 contador = 0;
            Utils.Utilerias Util = new Utils.Utilerias(_view);

            foreach (String fileName in _view.SelectedSourceFiles)
            {
                transactionID = _random.Next();

                //transactionID = 15778284;

                bool bError = false;
                do
                {
                    if (contador > 2)
                    {
                        bError = true;
                    }
                    else
                    {
                        var invoiceXML = new SrvTimbrado.ComprobanteXML();
                        using (StreamReader myFile = new StreamReader(fileName))
                        {
                            invoiceXML.DatosXML = myFile.ReadToEnd();
                        }
                        try
                        {
                            using (var TimbradoSrv = new SrvTimbrado.TimbradoClient())
                            {
                                var advertencias = TimbradoSrv.TimbraXML(ref invoiceXML, Util.RFC, token, ref transactionID);

                                StringBuilder lsName = new StringBuilder(Path.GetFileName(fileName));
                                StringBuilder lsDir = new StringBuilder(Path.GetDirectoryName(fileName));
                                StringBuilder lsExt = new StringBuilder(Path.GetExtension(fileName).ToUpper());
                                StringBuilder lsOutputFile = new StringBuilder(string.Format(@"{0}\{1}{2}{3}", lsDir, lsName, transactionID, lsExt.ToString()));
                                StringBuilder loXML = new StringBuilder();
                                //loXML.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                                loXML.Append(invoiceXML.DatosXML);
                                using (StreamWriter loSW = new StreamWriter(lsOutputFile.ToString(), false, Encoding.UTF8))
                                {
                                    loSW.Write(loXML.ToString());
                                }
                                contador = 0;
                                bError = false;
                                if (!_view.AddResultFile(lsOutputFile.ToString()))
                                    throw new Exception("Can't add output file to the list");
                            }
                        }
                        #region Security service exceptions
                        catch (FaultException<SrvSecurity.FallaServicio> serviceFault)
                        {
                            using (var errorForm = new Forms.Error(TranslateFault.ToServiceError(serviceFault.Detail)))
                            {
                                errorForm.ShowDialog();
                            }
                            bError = true;
                        }
                        catch (FaultException<SrvSecurity.FallaSesion> sessionFauld)
                        {
                            _view.ShowSessionError(TranslateFault.ToSessionError(sessionFauld.Detail));
                            bError = true;
                        }
                        #endregion
                        #region Invoice service exceptions
                        catch (FaultException<SrvTimbrado.FallaServicio> serviceFault)
                        {
                            using (var errorForm = new Forms.Error(TranslateFault.ToServiceError(serviceFault.Detail)))
                            {
                                errorForm.ShowDialog();
                            }
                            bError = true;
                        }
                        catch (FaultException<SrvTimbrado.FallaSesion> sessionFauld)
                        {
                            //_view.ShowSessionError(TranslateFault.ToSessionError(sessionFauld.Detail));
                            if (sessionFauld.Detail.Descripcion.Contains("El Token no es valido o ya expiro"))
                            {
                                Util.CreateToken(Util.RFC, transactionID, ref token);
                                contador++;
                            }
                            _view.ShowSessionError(TranslateFault.ToSessionError(sessionFauld.Detail));
                        }
                        catch (FaultException<SrvTimbrado.FallaValidacion> validationFault)
                        {
                            using (var errorForm = new Forms.Error(TranslateFault.ToValidationError(validationFault.Detail)))
                            {
                                errorForm.ShowDialog();
                            }
                            bError = true;
                        }
                        #endregion
                    }

                    if (bError)
                        contador = 0;
                } while (contador > 0);
            }
        }

        void _view_OnSealandStampandStamp(object sender, EventArgs e)
        {
            long transactionID = _random.Next();

            Int16 contador = 0;
            Utils.Utilerias Util = new Utils.Utilerias();

            foreach (String fileName in _view.SelectedSourceFiles)
            {
                transactionID = _random.Next();
                StringBuilder loXML = new StringBuilder();
                bool bError = false;
                #region sellado y timbrado
                do
                {
                    var invoiceXML = new SrvInvoices.ComprobanteXML();
                    using (StreamReader myFile = new StreamReader(fileName))
                    {
                        invoiceXML.DatosXML = myFile.ReadToEnd();
                    }
                    if (contador > 3)
                    {
                        _view.ShowUnknownError("Error con el token, se hicieron 3 intentos y fallo.");
                        bError = true;
                    }
                    else
                    {
                        try
                        {
                            using (var invoiceSrv = new SrvInvoices.ComprobantesClient())
                            {

                                var advertencias = invoiceSrv.SellaTimbraXML(ref invoiceXML, Util.RFC, token, ref transactionID);
                                contador = 0;
                               // loXML.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                                loXML.Append(invoiceXML.DatosXML);
                                XDocument doc = new XDocument();
                                byte[] byteArray = Encoding.ASCII.GetBytes(loXML.ToString());
                                MemoryStream stream = new MemoryStream(byteArray);
                                doc = System.Xml.Linq.XDocument.Load(stream);
                                //var record = from item in doc.Root.Elements("Complemento") select item;
                                //XElement singature = new XElement("{http://www.sat.gob.mx/TimbreFiscalDigital}TimbreFiscalDigital");
                                //doc.Root.Descendants(singature.Name).Remove();
                                loXML = new StringBuilder();
                                loXML.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                                loXML.AppendLine(doc.ToString());
                                bError = false;

                                //doc.Descendants("Complemento").Where(p => p.Attribute("") != null).Remove();
                                StringBuilder lsName = new StringBuilder(Path.GetFileName(fileName));
                                StringBuilder lsDir = new StringBuilder(Path.GetDirectoryName(fileName));
                                StringBuilder lsExt = new StringBuilder(Path.GetExtension(fileName).ToUpper());
                                StringBuilder lsOutputFile = new StringBuilder(string.Format(@"{0}\{1}{2}{3}", lsDir, lsName, transactionID, lsExt.ToString()));
                                using (StreamWriter loSW = new StreamWriter(lsOutputFile.ToString(), false, Encoding.UTF8))
                                {
                                    loSW.Write(loXML.ToString());
                                }

                                if (!_view.AddResultFile(lsOutputFile.ToString()))
                                    throw new Exception("Can't add output file to the list");
                            }
                        }
                        #region Invoice service exceptions
                        catch (FaultException<SrvInvoices.FallaServicio> serviceFault)
                        {
                            using (var errorForm = new Forms.Error(TranslateFault.ToServiceError(serviceFault.Detail)))
                            {
                                errorForm.ShowDialog();
                            }
                            guardarLog(fileName, string.Format("Error #: {0}\nDescription:{1}", serviceFault.Detail.Numero, serviceFault.Detail.Descripcion));
                            bError = true;
                        }
                        catch (FaultException<SrvInvoices.FallaSesion> sessionFauld)
                        {
                            //_view.ShowSessionError(TranslateFault.ToSessionError(sessionFauld.Detail));
                            if (sessionFauld.Detail.Descripcion.Contains("El Token no es valido o ya expiro"))
                            {
                                Util.CreateToken(Util.RFC, transactionID, ref token);
                                contador++;
                            }
                        }
                        catch (FaultException<SrvInvoices.FallaValidacion> validationFault)
                        {
                            using (var errorForm = new Forms.Error(TranslateFault.ToValidationError(validationFault.Detail)))
                            {
                                errorForm.ShowDialog();
                            }
                            guardarLog(fileName, string.Format("Error #: {0}\nDescription:{1}", validationFault.Detail.Numero, validationFault.Detail.Descripcion));
                            bError = true;
                        }
                        #endregion
                    }

                    if (bError == true)
                        contador = 0;
                } while (contador > 0);
                #endregion

            }
        }
        void _view_OnGetToken(object sender, EventArgs e)
        {
            long transactionID = _random.Next();
            string Error;
            Utils.Utilerias Util = new Utils.Utilerias(_view);
            Error = Util.CreateToken(Util.RFC, transactionID, ref token);
            if (!string.IsNullOrEmpty(Error))
            {
                _view.ShowUnknownError(Error);
                return;
            }
            _view.ShowUnknownError(string.Format("Token: {0}", token));
        }
        void _view_OnSelectResultFile(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo { FileName = _view.SelectedResultFile };
            using (Process process = new Process { StartInfo = psi })
            {
                process.Start();
            }

        }

        void guardarLog(string fileName, string error)
        {
            StringBuilder lsName = new StringBuilder(Path.GetFileName(fileName));
            StringBuilder lsDir = new StringBuilder(Path.GetDirectoryName(fileName));
            StringBuilder lsExt = new StringBuilder(Path.GetExtension(fileName).ToUpper());
            StringBuilder lsOutputFile = new StringBuilder(string.Format(@"{0}\{1}{2}{3}", lsDir, lsName, "_error", ".txt"));

            using (StreamWriter loSW = new StreamWriter(lsOutputFile.ToString(), true, Encoding.UTF8))
            {
                loSW.Write(error);
            }
            _view.AddResultFile(lsOutputFile.ToString());
        }
    }
}
