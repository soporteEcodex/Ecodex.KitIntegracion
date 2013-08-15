using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;
using System.ServiceModel;

namespace EcodexIntegrationSample
{
    class MainController
    {
        private View.IMain _view;
        private Random _random;

        /// <summary>
        /// This id can come from a database or be hard coded 
        /// by each service integrator or service reseller.
        /// </summary>
        //private const String INTEGRATOR_ID = "123";


        public MainController(View.IMain view)
        {
            _view = view;
            _view.UniTestDunnyInvoice += _view_UniTestDunnyInvoice;
            _view.UniTestDummyXMLString += _view_UniTestDummyXMLString;
            _view.GenerateXMLFile += _view_GenerateXMLFile;
            _view.CancelUUID += _view_CancelUUID;
            _view.GetInvoice += _view_GetInvoice;
            _view.GetStatus += _view_GetStatus;
            _view.GetStatusClient += _view_GetStatusClient;
            _view.GetAdvices += _view_GetAdvices;
            _view.StampService += _view_StampService;
            _view.AsignarTimbres += _view_AsignarTimbres;
            _view.AltaEmisor += _view_AltaEmisor;

            _random = new Random();
        }
        void _view_StampService(object sender, EventArgs e)
        {
            using (var ioForm = new Forms.frmTimbrado())
            {
                ioForm.ShowDialog();
            }
        }

        void _view_AsignarTimbres(object sender, EventArgs e)
        {
            using (var ioForm = new Forms.frmAsignarTimbresEmisor())
            {
                ioForm.ShowDialog();
            }
        }

        void _view_AltaEmisor(object sender, EventArgs e)
        {
            using (var ioForm = new Forms.frmAltaEmisor())
            {
                ioForm.ShowDialog();
            }
        }

        void _view_CancelUUID(object sender, EventArgs e)
        {
            using (var ioForm = new Forms.Cancel())
            {
                ioForm.ShowDialog();
            }
        }
        void _view_GenerateXMLFile(object sender, EventArgs e)
        {
            using (var ioForm = new Forms.IOXMLFile())
            {
                ioForm.ShowDialog();
            }
        }

        void _view_UniTestDummyXMLString(object sender, EventArgs e)
        {
            //var rfc = "VACS740221QW6";
            long transactionID = _random.Next();
            var token = String.Empty;
            string Error;
            Utils.Utilerias Util = new Utils.Utilerias(_view);
            Error = Util.CreateToken(Util.RFC, transactionID, ref token);
            if (!string.IsNullOrEmpty(Error))
            {
                _view.ShowUnknownError(Error);
                return;
            }
            try
            {
                #region Build Token
                //using (var securitySrv = new SrvSecurity.SeguridadClient())
                //{
                //    var serviceToken = securitySrv.ObtenerToken(rfc, ref transactionID);
                //    var toHash = String.Format("{0}|{1}", INTEGRATOR_ID, serviceToken);
                //    token = Security.Hash(toHash);
                //}
                #endregion
                transactionID = _random.Next();
                var invoiceXML = new SrvInvoices.ComprobanteXML
                {
                    DatosXML = "<?xml version=\"1.0\" encoding=\"utf-8\"?><cfdi:Comprobante xmlns:cfdi=\"http://www.sat.gob.mx/cfd/3\" xmlns:donat=\"http://www.sat.gob.mx/donat\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" sello=\"oJ3DHNsd+OmVObTITGKKExJn1T/KZl3HxovXk5cXPUSCpb0s3b2eCyoFy3Ko/l0Ni58eUq95Do5w2GjEaLUce++1WGl+s8DOb4XAYI+u+aa9m8lR6Ij22hfx8crFPeWe5knbKvXcN2XONZn/v6vZXmnSreA2nIRV9W2RkPWVLL8=\" certificado=\"MIIEZDCCA0ygAwIBAgIUMDAwMDEwMDAwMDAxMDIyMzIyMjIwDQYJKoZIhvcNAQEFBQAwggE2MTgwNgYDVQQDDC9BLkMuIGRlbCBTZXJ2aWNpbyBkZSBBZG1pbmlzdHJhY2nDs24gVHJpYnV0YXJpYTEvMC0GA1UECgwmU2VydmljaW8gZGUgQWRtaW5pc3RyYWNpw7NuIFRyaWJ1dGFyaWExHzAdBgkqhkiG9w0BCQEWEGFjb2RzQHNhdC5nb2IubXgxJjAkBgNVBAkMHUF2LiBIaWRhbGdvIDc3LCBDb2wuIEd1ZXJyZXJvMQ4wDAYDVQQRDAUwNjMwMDELMAkGA1UEBhMCTVgxGTAXBgNVBAgMEERpc3RyaXRvIEZlZGVyYWwxEzARBgNVBAcMCkN1YXVodGVtb2MxMzAxBgkqhkiG9w0BCQIMJFJlc3BvbnNhYmxlOiBGZXJuYW5kbyBNYXJ0w61uZXogQ29zczAeFw0xMDExMjMyMzMyNDJaFw0xMjExMjIyMzMyNDJaMIIBAzE3MDUGA1UEAxMuSU5URUdSQURPUkEgQURVQU5BTCBZIERFIFNFUlZJQ0lPUyBXT09EV0FSRCBTQzE3MDUGA1UEKRMuSU5URUdSQURPUkEgQURVQU5BTCBZIERFIFNFUlZJQ0lPUyBXT09EV0FSRCBTQzE3MDUGA1UEChMuSU5URUdSQURPUkEgQURVQU5BTCBZIERFIFNFUlZJQ0lPUyBXT09EV0FSRCBTQzElMCMGA1UELRMcSUFTMDMxMTA0R0NBIC8gUkFSTzgyMDUxMVJZODEeMBwGA1UEBRMVIC8gUkFSTzgyMDUxMU1DTU1CRjAwMQ8wDQYDVQQLEwZVTklEQUQwgZ8wDQYJKoZIhvcNAQEBBQADgY0AMIGJAoGBAMfKk6D8zQ/YC43iBOWsda6l3O65EmG0nWzmeDP0lzQba9QwzK0oxPDdzGXB4RNIr6ek3Ln83/j8r4wDA9kZOdIp6RXtyjzLs+4YMlsPmjkG61It+EKBwoqdrbAB/cSx3E1mlX4BgZ7ERA8d64hQtiORsRPOqLrbrH7tlhcsXfMbAgMBAAGjHTAbMAwGA1UdEwEB/wQCMAAwCwYDVR0PBAQDAgbAMA0GCSqGSIb3DQEBBQUAA4IBAQA9vNpPgwQ5qmgK4/XtfxSmvz21N4Hxx50FTCA8j7g2vJa/I7kqAotXx2xqMs6QKD8KxnWvA2lkgKckv5nHy95jw1/X2mCESw/1dq0K9Oa5dZX/5o5pTRLk/KIpXfCYkGxsR+K/TLyRunRAZEOJbyXcfs6OQ/fLbtkO+abEQhw62nx6fY4E9NSYvcyEd3SFgyxE4hBDjLEqMkKpW6SZkrN/NvsjCmwHghInjQd+17vBjVdcQ5GdpNE8+CUc5cAkIdbRWq+O3M1yqkYTIJAtdtIylmuvu73N6B+4vG7KFpInpHBfSIsUY/ccmKzvzgGoiwe6p3XkPPv4CRktMSJGz6gr\" fecha=\"2011-06-28T18:24:09\" version=\"3.2\" xsi:schemaLocation=\"http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv32.xsd\" serie=\"8\" folio=\"3\" formaDePago=\"PAGO EN UNA SOLA EXHIBICION\" metodoDePago=\"Efectivo\" noCertificado=\"20001000000100005867\" subTotal=\"7069.00\" TipoCambio=\"1\" Moneda=\"PESO\" total=\"8200.04\" tipoDeComprobante=\"ingreso\" NumCtaPago=\"123456\"  LugarExpedicion=\"manzanillo\"  FolioFiscalOrig=\"23480727-43C3-40C4-A866-356152786D86\" SerieFolioFiscalOrig=\"A\" FechaFolioFiscalOrig=\"2011-12-18T00:00:00\" MontoFolioFiscalOrig=\"125.21\"><cfdi:Emisor rfc=\"AAA010101AAA\" nombre=\"INTEGRADORA ADUANAL Y DE SERVICIOS WOODWARD S.C.\">  <cfdi:DomicilioFiscal calle=\"AV. TENIENTE AZUETA\" noExterior=\"25-1\" colonia=\"BUROCRATA\" localidad=\"MANZANILLO\" municipio=\"MANZANILLO\" estado=\"COLIMA\" pais=\"MEXICO\" codigoPostal=\"28250\"/><cfdi:RegimenFiscal Regimen=\"regimen 1\" /><cfdi:RegimenFiscal Regimen=\"regimen 2\" /></cfdi:Emisor><cfdi:Receptor rfc=\"XEXX010101000\" nombre=\"TRADING SERVICES CORPORATION.\">  <cfdi:Domicilio calle=\"1705 E HILLSIDE RD STE.\" noExterior=\"1\" localidad=\"LAREDO\" referencia=\"LAREDO\" municipio=\"LAREDO\" estado=\"TEXAS\" pais=\"USA\" codigoPostal=\"78041\"/></cfdi:Receptor><cfdi:Conceptos>  <cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"inicio SERVICIOS COMPLEMENTARIOS\" valorUnitario=\"2000.00\" importe=\"2000.00\"/></cfdi:Conceptos><cfdi:Impuestos totalImpuestosTrasladados=\"1131.04\">  <cfdi:Traslados>    <cfdi:Traslado impuesto=\"IVA\" tasa=\"16\" importe=\"1131.04\"/>  </cfdi:Traslados></cfdi:Impuestos></cfdi:Comprobante>"
                };
                using (var invoiceSrv = new SrvInvoices.ComprobantesClient())
                {
                    var advertencias = invoiceSrv.SellaTimbraXML(ref invoiceXML, Util.RFC, token, ref transactionID);
                    _view.ResultStr = invoiceXML.DatosXML;
                }
                #region Optional steep to get the QR barcode image
                transactionID = _random.Next();
                XDocument doc = new XDocument();
                doc = XDocument.Parse(invoiceXML.DatosXML);
                XElement singature = new XElement("{http://www.sat.gob.mx/TimbreFiscalDigital}TimbreFiscalDigital");
                string uuid = doc.Root.Descendants(singature.Name).ToArray()[0].Attribute("UUID").Value;
                using (var repositorySrv = new SrvRepository.RepositorioClient())
                {
                    var infoQR = repositorySrv.ObtenerQR(Util.RFC, token, ref transactionID, uuid);
                    var ms = new System.IO.MemoryStream(infoQR.Imagen);
                    _view.BarcodeQR = new System.Drawing.Bitmap(ms);
                }
                #endregion
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
                _view.ShowSessionError(TranslateFault.ToSessionError(sessionFauld.Detail));
            }
            catch (FaultException<SrvInvoices.FallaValidacion> validationFault)
            {
                using (var errorForm = new Forms.Error(TranslateFault.ToValidationError(validationFault.Detail)))
                {
                    errorForm.ShowDialog();
                }
            }
            #endregion
            catch (Exception ex)
            {
                _view.ShowUnknownError(ex.Message);
            }
        }

        void _view_UniTestDunnyInvoice(object sender, EventArgs e)
        {
            //var rfc = "VACS740221QW6";
            long transactionID = _random.Next();
            var token = String.Empty;
            string Error;
            Utils.Utilerias Util = new Utils.Utilerias(_view);
            Error = Util.CreateToken(Util.RFC, transactionID, ref token);
            if (!string.IsNullOrEmpty(Error))
            {
                _view.ShowUnknownError(Error);
                return;
            }
            try
            {
                #region Build Token
                //using (var securitySrv = new SrvSecurity.SeguridadClient())
                //{
                //    var serviceToken = securitySrv.ObtenerToken(rfc, ref transactionID);
                //    var toHash = String.Format("{0}|{1}", INTEGRATOR_ID, serviceToken);
                //    token = Security.Hash(toHash);
                //}
                #endregion
                transactionID = _random.Next();
                #region Generate Dummy Invoice with the service class
                var invoice = new SrvInvoices.Comprobante
                {
                    TipoDeComprobante = SrvInvoices.TipoDeComprobante.Ingreso,
                    Total = 488.50m,
                    SubTotal = 466.43m,
                    CondicionesDePago = "Contado",
                    Certificado = "MIIEdDCCA1ygAwIBAgIUMjAwMDEwMDAwMDAxMDAwMDU4NjcwDQYJKoZIhvcNAQEFBQAwggFvMRgwFgYDVQQDDA9BLkMuIGRlIHBydWViYXMxLzAtBgNVBAoMJlNlcnZpY2lvIGRlIEFkbWluaXN0cmFjacOzbiBUcmlidXRhcmlhMTgwNgYDVQQLDC9BZG1pbmlzdHJhY2nDs24gZGUgU2VndXJpZGFkIGRlIGxhIEluZm9ybWFjacOzbjEpMCcGCSqGSIb3DQEJARYaYXNpc25ldEBwcnVlYmFzLnNhdC5nb2IubXgxJjAkBgNVBAkMHUF2LiBIaWRhbGdvIDc3LCBDb2wuIEd1ZXJyZXJvMQ4wDAYDVQQRDAUwNjMwMDELMAkGA1UEBhMCTVgxGTAXBgNVBAgMEERpc3RyaXRvIEZlZGVyYWwxEjAQBgNVBAcMCUNveW9hY8OhbjEVMBMGA1UELRMMU0FUOTcwNzAxTk4zMTIwMAYJKoZIhvcNAQkCDCNSZXNwb25zYWJsZTogSMOpY3RvciBPcm5lbGFzIEFyY2lnYTAeFw0xMjA3MjcxNzAyMDBaFw0xNjA3MjcxNzAyMDBaMIHbMSkwJwYDVQQDEyBBQ0NFTSBTRVJWSUNJT1MgRU1QUkVTQVJJQUxFUyBTQzEpMCcGA1UEKRMgQUNDRU0gU0VSVklDSU9TIEVNUFJFU0FSSUFMRVMgU0MxKTAnBgNVBAoTIEFDQ0VNIFNFUlZJQ0lPUyBFTVBSRVNBUklBTEVTIFNDMSUwIwYDVQQtExxBQUEwMTAxMDFBQUEgLyBIRUdUNzYxMDAzNFMyMR4wHAYDVQQFExUgLyBIRUdUNzYxMDAzTURGUk5OMDkxETAPBgNVBAsTCFVuaWRhZCAxMIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC2TTQSPONBOVxpXv9wLYo8jezBrb34i/tLx8jGdtyy27BcesOav2c1NS/Gdv10u9SkWtwdy34uRAVe7H0a3VMRLHAkvp2qMCHaZc4T8k47Jtb9wrOEh/XFS8LgT4y5OQYo6civfXXdlvxWU/gdM/e6I2lg6FGorP8H4GPAJ/qCNwIDAQABox0wGzAMBgNVHRMBAf8EAjAAMAsGA1UdDwQEAwIGwDANBgkqhkiG9w0BAQUFAAOCAQEATxMecTpMbdhSHo6KVUg4QVF4Op2IBhiMaOrtrXBdJgzGotUFcJgdBCMjtTZXSlq1S4DG1jr8p4NzQlzxsdTxaB8nSKJ4KEMgIT7E62xRUj15jI49qFz7f2uMttZLNThipunsN/NF1XtvESMTDwQFvas/Ugig6qwEfSZc0MDxMpKLEkEePmQwtZD+zXFSMVa6hmOu4M+FzGiRXbj4YJXn9Myjd8xbL/c+9UIcrYoZskxDvMxc6/6M3rNNDY3OFhBK+V/sPMzWWGt8S1yjmtPfXgFs1t65AZ2hcTwTAuHrKwDatJ1ZPfa482ZBROAAX1waz7WwXp0gso7sDCm2/yUVww==",
                    NoCertificado = "20001000000100005867",
                    FormaDePago = "EN UNA SOLA EXHIBICIÓN",
                    Fecha = DateTime.Now,
                    Folio = "523",
                    Serie = "C",
                    Version = "3.2",
                    Sello = ""
                };

                // ISSUER
                //var emisor = new SrvInvoices.Emisor { Nombre = "PHARMA PLUS SA DE CV", RFC = "AAQM610917QJA" };
                var emisor = new SrvInvoices.Emisor { Nombre = "PHARMA PLUS SA DE CV", RFC = Util.RFC };
                var emisorDomicilio = new SrvInvoices.UbicacionFiscal
                {
                    CodigoPostal = "03240",
                    Pais = "México",
                    Estado = "MEXICO, D.F.",
                    Municipio = "Benito Juárez",
                    Localidad = "Distrito Federal",
                    Colonia = "ACACIAS",
                    Calle = "AV. RIO MIXCOAC",
                    NoExterior = "24"
                };
                emisor.DomicilioFiscal = emisorDomicilio;
                invoice.Emisor = emisor;

                // RECEIVER
                var receptor = new SrvInvoices.Receptor { Nombre = "JUAN PEREZ PEREZ", RFC = "PEPJ8001019Q8" };
                var receptorDomicilio = new SrvInvoices.Ubicacion
                {
                    CodigoPostal = "04360",
                    Pais = "México",
                    Estado = "DISTRITO FEDERAL",
                    Municipio = "COYOACAN",
                    Colonia = "COPILCO UNIVERSIDAD",
                    Calle = "AV UNIVERSIDAD",
                    Localidad = "COYACAN",
                    NoExterior = "724"
                };
                receptor.Domicilio = receptorDomicilio;
                invoice.Receptor = receptor;

                // CONCEPTS
                var concepto1 = new SrvInvoices.Concepto { Importe = 244.00m, ValorUnitario = 244.00m, Descripcion = "VIBRAMICINA 100MG 10", Cantidad = 1 };
                var concepto2 = new SrvInvoices.Concepto { Importe = 137.93m, ValorUnitario = 137.93m, Descripcion = "CLORUTO 500M", Cantidad = 1 };
                var concepto3 = new SrvInvoices.Concepto { Importe = 84.50m, ValorUnitario = 84.50m, Descripcion = "SEDEPRON 250MG 10", Cantidad = 1 };
                invoice.Conceptos = new SrvInvoices.Concepto[3] { concepto1, concepto2, concepto3 };

                // TAXES
                var impuestos = new SrvInvoices.Impuestos();
                var impuestoTransladado1 = new SrvInvoices.ImpuestosTraslado { Impuesto = SrvInvoices.TipoDeImpuestoTraslado.IVA, Importe = 0.0m, Tasa = 0.00m };
                var impuestoTransladado2 = new SrvInvoices.ImpuestosTraslado { Impuesto = SrvInvoices.TipoDeImpuestoTraslado.IVA, Importe = 22.07m, Tasa = 16m };
                impuestos.Traslados = new SrvInvoices.ImpuestosTraslado[2] { impuestoTransladado1, impuestoTransladado2 };
                impuestos.TotalImpuestosTrasladados = 22.07m;
                invoice.Impuestos = impuestos;
                #endregion
                var invoiceXML = new SrvInvoices.ComprobanteXML();
                using (var invoiceSrv = new SrvInvoices.ComprobantesClient())
                {
                    var advertencias = invoiceSrv.SellaTimbra(invoice, Util.RFC, token, ref transactionID, out invoiceXML);
                    _view.ResultStr = invoiceXML.DatosXML;
                }
                #region Optional steep to get the QR barcode image
                transactionID = _random.Next();
                XDocument doc = new XDocument();
                doc = XDocument.Parse(invoiceXML.DatosXML);
                XElement singature = new XElement("{http://www.sat.gob.mx/TimbreFiscalDigital}TimbreFiscalDigital");
                string uuid = doc.Root.Descendants(singature.Name).ToArray()[0].Attribute("UUID").Value;
                using (var repositorySrv = new SrvRepository.RepositorioClient())
                {
                    var infoQR = repositorySrv.ObtenerQR(Util.RFC, token, ref transactionID, uuid);
                    var ms = new System.IO.MemoryStream(infoQR.Imagen);
                    _view.BarcodeQR = new System.Drawing.Bitmap(ms);
                }
                #endregion
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
                _view.ShowSessionError(TranslateFault.ToSessionError(sessionFauld.Detail));
            }
            catch (FaultException<SrvInvoices.FallaValidacion> validationFault)
            {
                using (var errorForm = new Forms.Error(TranslateFault.ToValidationError(validationFault.Detail)))
                {
                    errorForm.ShowDialog();
                }
            }
            #endregion
            catch (Exception ex)
            {
                _view.ShowUnknownError(ex.Message);
            }
        }

        void _view_GetInvoice(object sender, EventArgs e)
        {
            using (var ioForm = new Forms.frmComprobante())
            {
                ioForm.ShowDialog();
            }
        }
        void _view_GetStatus(object sender, EventArgs e)
        {
            using (var ioForm = new Forms.GetStatus())
            {
                ioForm.ShowDialog();
            }
        }
        void _view_GetStatusClient(object sender, EventArgs e)
        {
            using (var ioForm = new Forms.frmGetStatusClient())
            {
                ioForm.ShowDialog();
            }
        }
        void _view_GetAdvices(object sender, EventArgs e)
        {
            using (var ioForm = new Forms.frmGetAvisos())
            {
                ioForm.ShowDialog();
            }
        }
    }
}
