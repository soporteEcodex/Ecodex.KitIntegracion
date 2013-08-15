using System;
using System.IO;
using System.Text;
using System.ServiceModel;
using System.Diagnostics;

namespace EcodexIntegrationSample
{
    class XmlFileController
    {
        private View.IXmlFile _view;
        private Random _random;

        /// <summary>
        /// This id can come from a database or be hard coded 
        /// by each service integrator or service reseller.
        /// </summary>
        //private const String INTEGRATOR_ID = "123";

        public XmlFileController(View.IXmlFile view)
        {
            _view = view;
            _view.OnInvoicesProcessStart += _view_OnInvoicesProcessStart;
            _view.OnSelectResultFile += _view_OnSelectResultFile;

            _random = new Random();
        }

        void _view_OnSelectResultFile(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo { FileName = _view.SelectedResultFile };
            using (Process process = new Process { StartInfo = psi })
            {
                process.Start();
            }
        }

        void _view_OnInvoicesProcessStart(object sender, EventArgs e)
        {
            //var rfc = "AAA701117I84";
            long transactionID = _random.Next();
            var token = String.Empty;
            Int16 contador = 0;


            string Error;
            Utils.Utilerias Util = new Utils.Utilerias(_view);
            Error = Util.CreateToken(Util.RFC, transactionID, ref token);
            if (!string.IsNullOrEmpty(Error))
            {
                _view.ShowUnknownError(Error);
                return;
            }
            foreach (String fileName in _view.SelectedSourceFiles)
            {
                transactionID = _random.Next();
                do
                {
                    var invoiceXML = new SrvInvoices.ComprobanteXML();
                    using (StreamReader myFile = new StreamReader(fileName))
                    {
                        invoiceXML.DatosXML = myFile.ReadToEnd();
                    }
                    try
                    {
                        using (var invoiceSrv = new SrvInvoices.ComprobantesClient())
                        {
                            var advertencias = invoiceSrv.SellaTimbraXML(ref invoiceXML, Util.RFC, token, ref transactionID);

                            StringBuilder lsName = new StringBuilder(Path.GetFileName(fileName));
                            StringBuilder lsDir = new StringBuilder(Path.GetDirectoryName(fileName));
                            StringBuilder lsExt = new StringBuilder(Path.GetExtension(fileName).ToUpper());
                            StringBuilder lsOutputFile = new StringBuilder(string.Format(@"{0}\{1}{2}{3}", lsDir, lsName, transactionID, lsExt.ToString()));
                            StringBuilder loXML = new StringBuilder();
                            loXML.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                            loXML.Append(invoiceXML.DatosXML);
                            using (StreamWriter loSW = new StreamWriter(lsOutputFile.ToString(), false, Encoding.UTF8))
                            {
                                loSW.Write(loXML.ToString());
                            }
                            contador = 0;
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
                    }
                    catch (FaultException<SrvInvoices.FallaSesion> sessionFauld)
                    {
                        //_view.ShowSessionError(TranslateFault.ToSessionError(sessionFauld.Detail));
                        if (sessionFauld.Detail.Descripcion.Contains("El Token no es valido o ya expiro"))
                        {
                            //CreateToken(rfc, transactionID, ref token);
                            Error = Util.CreateToken(Util.RFC, transactionID, ref token);
                            contador++;
                        }
                    }
                    catch (FaultException<SrvInvoices.FallaValidacion> validationFault)
                    {
                        using (var errorForm = new Forms.Error(TranslateFault.ToValidationError(validationFault.Detail)))
                        {
                            errorForm.ShowDialog();
                        }
                    }
                    #endregion
                } while (contador == 1);
            }
        }
    }
}
