using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ServiceModel;
using System.Xml.Linq;

namespace EcodexIntegrationSample.Controllers
{
    class frmTimbradoController
    {
        private View.IfrmTimbrado _view;
        private Random _random;

        //private const string INTEGRATOR_ID = "4606d3fc-056e-4ee1-8b01-d7b000064503";

        public frmTimbradoController(View.IfrmTimbrado view)
        {
            _view = view;
            _view.UniTestDummyXMLString += _view_UniTestDummyXMLString;
            _view.CancelaTimbrado += _view_CancelaTimbrado;
            _view.GetStatus += _view_GetStatus;
            _view.GetTimbrado += _view_GetTimbrado;
            _view.TimbraXML += _view_TimbraXML;
            _random = new Random();

        }

        void _view_UniTestDummyXMLString(object sender, EventArgs e)
        {

            long transactionID = _random.Next();
            var token = string.Empty;
            string CadenaXML = string.Empty;
            var UUID = "16BF252B-D32E-4651-BBA5-8ED3BF232F2A";

            string Error;
            Utils.Utilerias Util = new Utils.Utilerias();
            Error = Util.CreateToken(Util.RFC, transactionID, ref token);
            if (!string.IsNullOrEmpty(Error))
            {
                _view.ShowUnknownError(Error);
                return;
            }
            try
            {
                #region Token
                //using (var securitySrv = new SrvSecurity.SeguridadClient())
                //{
                //    var serviceToken = securitySrv.ObtenerToken(rfc, ref transactionID);
                //    var toHash = String.Format("{0}|{1}", INTEGRATOR_ID, serviceToken);
                //    token = Security.Hash(toHash);
                //}
                #endregion
                transactionID = _random.Next();
                #region ContenidoXML
                //var contenidoArchivoXML = String.Empty;
                //string fileName = "C:\\XML_timbrado\\xml.XML";
                //using (StreamReader archivo = new StreamReader(fileName, Encoding.Default))
                //{
                //    CadenaXML = archivo.ReadToEnd();
                //}
                #endregion

                //CadenaXML = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<cfdi:Comprobante xmlns:cfdi=\"http://www.sat.gob.mx/cfd/3\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" sello=\"RQWhPzqms3atxBircnOFbjfAI95TuYSBx5nKmia1M4O/q+IjzpJE86AYlbEcUsxG3oFLD2Q5nulOWSApWXvgI1E2/JIfcCRErNz/hGaW4IZnjxxhZAf/5rhsAHBgrG/4DAizmonu7zVQU4MwxfQTIq0rSDM3nDXaTUL9SZS/TVE=\" certificado=\"MIIFITCCBAmgAwIBAgIUMjAwMDEwMDAwMDAxMDAwMDE3NjIwDQYJKoZIhvcNAQEFBQAwggFvMRgwFgYDVQQDDA9BLkMuIGRlIHBydWViYXMxLzAtBgNVBAoMJlNlcnZpY2lvIGRlIEFkbWluaXN0cmFjacOzbiBUcmlidXRhcmlhMTgwNgYDVQQLDC9BZG1pbmlzdHJhY2nDs24gZGUgU2VndXJpZGFkIGRlIGxhIEluZm9ybWFjacOzbjEpMCcGCSqGSIb3DQEJARYaYXNpc25ldEBwcnVlYmFzLnNhdC5nb2IubXgxJjAkBgNVBAkMHUF2LiBIaWRhbGdvIDc3LCBDb2wuIEd1ZXJyZXJvMQ4wDAYDVQQRDAUwNjMwMDELMAkGA1UEBhMCTVgxGTAXBgNVBAgMEERpc3RyaXRvIEZlZGVyYWwxEjAQBgNVBAcMCUNveW9hY8OhbjEVMBMGA1UELRMMU0FUOTcwNzAxTk4zMTIwMAYJKoZIhvcNAQkCDCNSZXNwb25zYWJsZTogSMOpY3RvciBPcm5lbGFzIEFyY2lnYTAeFw0xMDExMTkyMzQzMjBaFw0xMjExMTgyMzQzMjBaMIG6MSMwIQYDVQQDExpTRVZFUklBTk8gVkFaUVVFWiBDQVJERU5BUzEjMCEGA1UEKRMaU0VWRVJJQU5PIFZBWlFVRVogQ0FSREVOQVMxIzAhBgNVBAoTGlNFVkVSSUFOTyBWQVpRVUVaIENBUkRFTkFTMRYwFAYDVQQtEw1WQUNTNzQwMjIxUVc2MRswGQYDVQQFExJWQUNTNzQwMjIxTURGTlNSMDgxFDASBgNVBAsTC1N1Y3Vyc2FsQVZMMIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC58rlf+7tqgIqQiqUqJPPcT2m7OH0rG8KS0NjxkeCh9x9b88ltC84yO2/e0Lac78d2imGDeJvDwfb4ESscXm13EGNXNh5NMAGt5OHaDf8G9v4sTh+dLMzJ5bOHuHj3jc/Nk3B8LgyJUczLaFWSuFN8fWV92DJb63jjCSRe3/JfHQIDAQABo4HqMIHnMAwGA1UdEwEB/wQCMAAwCwYDVR0PBAQDAgbAMB0GA1UdDgQWBBQN4S2YNhEmJFqyl4ro3TgCeB1ouTAuBgNVHR8EJzAlMCOgIaAfhh1odHRwOi8vcGtpLnNhdC5nb2IubXgvc2F0LmNybDAzBggrBgEFBQcBAQQnMCUwIwYIKwYBBQUHMAGGF2h0dHA6Ly9vY3NwLnNhdC5nb2IubXgvMB8GA1UdIwQYMBaAFOtZfQQimlONnnEaoFiWKfU54KDFMBAGA1UdIAQJMAcwBQYDKgMEMBMGA1UdJQQMMAoGCCsGAQUFBwMCMA0GCSqGSIb3DQEBBQUAA4IBAQDEf31ayJJ5fU5VFJ4oxaSYtoz06PDbEpHSDAf5vG5JCAzYBZtEpcxFpmcabVE+70Tztn7ys6zdAT2f8h5uLF706I6Zfes7CsgllHf9C6Aldt66+Kqwauiw0jUGJAGJlJbo8S3xaFXI/TWP4NrOL9wCkG02YzYSUEeHrr7rbAshXqJXmxRU9nCxHtAvfNatNbLRAEHNcfwa6txUJ+6MHWs+2xDnkCxj/WkkKqzkKnhIrJ8l39+wH+kFFviOmyIdts5Mc6j2Yp9zB3+oEcuG96fQ1xVCEmIjcYE8zDbZRXA381iM7ZIxAfV3ht9jVXlslJictJsNCYPVQYlNhnMtCt12\" fecha=\"2011-09-01T16:17:50\" version=\"3.0\" xsi:schemaLocation=\"http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv3.xsd\" formaDePago=\"Pago en una sola Exhibici&#243;n\" noCertificado=\"20001000000100001762\" condicionesDePago=\"Contado\" subTotal=\"140.00\" TipoCambio=\"1.00\" Moneda=\"MXN\" total=\"162.40\" metodoDePago=\"Efectivo\" tipoDeComprobante=\"ingreso\"><cfdi:Emisor rfc=\"VACS740221QW6\" nombre=\"Tienda de Abarrotes del Centro\"><cfdi:DomicilioFiscal calle=\"Calle altamirano\" noExterior=\"1200\" noInterior=\"9\" colonia=\"centro\" localidad=\"Manzanillo\" referencia=\"edificio\" municipio=\"Manzanillo\" estado=\"Colima\" pais=\"M&#233;xico\" codigoPostal=\"28200\"/></cfdi:Emisor><cfdi:Receptor rfc=\"RAGG901017PP7\" nombre=\"Usuario Prueba\"/><cfdi:Conceptos><cfdi:Concepto cantidad=\"20\" unidad=\"pieza\" descripcion=\"m&amp;m's\" valorUnitario=\"7\" importe=\"140\"/></cfdi:Conceptos><cfdi:Impuestos totalImpuestosTrasladados=\"22.40\"><cfdi:Traslados><cfdi:Traslado impuesto=\"IVA\" tasa=\"16.00\" importe=\"22.40\"/></cfdi:Traslados></cfdi:Impuestos></cfdi:Comprobante>";
                //CadenaXML = "<?xml version=\"1.0\" encoding=\"utf-8\"?><cfdi:Comprobante xmlns:cfdi=\"http://www.sat.gob.mx/cfd/3\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" sello=\"EVI3fkUuKhy1OijgXqldf5KvIJj+Sn13YG0BNN6+J0Hp1g7Aq3sqX/Nac3BEQDseExsTy6Ar3oNE1R+zyBkq0hTZ17Da2UwdVl+gX5kaDnFijZAg2J5yLCLYmvj0gTh1HTI2eoJJTOmYz4dKB4kUSXk6rFj4Mpn2gtRlJyQGsVc=\" certificado=\"MIIFFjCCA/6gAwIBAgIUMjAwMDEwMDAwMDAxMDAwMDQwMjcwDQYJKoZIhvcNAQEFBQAwggFvMRgwFgYDVQQDDA9BLkMuIGRlIHBydWViYXMxLzAtBgNVBAoMJlNlcnZpY2lvIGRlIEFkbWluaXN0cmFjacOzbiBUcmlidXRhcmlhMTgwNgYDVQQLDC9BZG1pbmlzdHJhY2nDs24gZGUgU2VndXJpZGFkIGRlIGxhIEluZm9ybWFjacOzbjEpMCcGCSqGSIb3DQEJARYaYXNpc25ldEBwcnVlYmFzLnNhdC5nb2IubXgxJjAkBgNVBAkMHUF2LiBIaWRhbGdvIDc3LCBDb2wuIEd1ZXJyZXJvMQ4wDAYDVQQRDAUwNjMwMDELMAkGA1UEBhMCTVgxGTAXBgNVBAgMEERpc3RyaXRvIEZlZGVyYWwxEjAQBgNVBAcMCUNveW9hY8OhbjEVMBMGA1UELRMMU0FUOTcwNzAxTk4zMTIwMAYJKoZIhvcNAQkCDCNSZXNwb25zYWJsZTogSMOpY3RvciBPcm5lbGFzIEFyY2lnYTAeFw0xMTExMjkyMjM1MjJaFw0xMzExMjgyMjM1MjJaMIGvMRowGAYDVQQDExFQQUMgTlVNMjkgUyBFTiBOQzEaMBgGA1UEKRMRUEFDIE5VTTI5IFMgRU4gTkMxGjAYBgNVBAoTEVBBQyBOVU0yOSBTIEVOIE5DMSUwIwYDVQQtExxQTlUxMTExMjUxRjMgLyBOVU1aNzMwNzMwNjczMR4wHAYDVQQFExUgLyBOVU1aNzMwNzMwSERGVFlUMDQxEjAQBgNVBAsTCXN1Y3Vyc2FsMTCBnzANBgkqhkiG9w0BAQEFAAOBjQAwgYkCgYEA3QlDcGtT+3XibzUxRn2/yXz/u2ZeSF05HAUx1NDLGMQymXQ+AGqo+xBtm3C055G7q56eIDBwu0qUsavhitTkjIbMhSKka7Yq5HtoNEQ3bimJuaMASWO3nqI50twodfWPJpy88vTmLWp7zNt+5INboZbnTPOg+AkGYE/s0hjFqh8CAwEAAaOB6jCB5zAMBgNVHRMBAf8EAjAAMAsGA1UdDwQEAwIGwDAdBgNVHQ4EFgQUjpZUcwEdxAOBKVsWrrrEMmRLmDwwLgYDVR0fBCcwJTAjoCGgH4YdaHR0cDovL3BraS5zYXQuZ29iLm14L3NhdC5jcmwwMwYIKwYBBQUHAQEEJzAlMCMGCCsGAQUFBzABhhdodHRwOi8vb2NzcC5zYXQuZ29iLm14LzAfBgNVHSMEGDAWgBTrWX0EIppTjZ5xGqBYlin1OeCgxTAQBgNVHSAECTAHMAUGAyoDBDATBgNVHSUEDDAKBggrBgEFBQcDAjANBgkqhkiG9w0BAQUFAAOCAQEARKmu4SN0MKq/UkFz2XWFLziz9np1nyuOKCwNK1zzmT58d8e+gi3hLNu92kL7SBtUKvRu9KCNkxcfJ2t9dL32dlkk19YnWkQzK4ibiad66kGYwuJPUzxKhGNcCfwvpcrJbpEvSozs+2F99L+v1ldenqBbCrKfQKUmOSHoyz689A/9sEyYKiXVnK/2j6lT5tTZoEJX795uxVu82+xFFWVT7VX64XX9A3DSrszdBYo70k8AxdAzmFBoGIkfYbOVE26OpEpVElcAf1MHu/fnUvBx6paT4GQKcw36di7T2vAS0WvYW7S7Y3owu1XP7I7ZtR+7yi2AXm6PihiXdhxC6BOvBA==\" fecha=\"2012-01-08T19:05:09\" version=\"3.2\" xsi:schemaLocation=\"http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv32.xsd\" serie=\"8\" folio=\"3\" formaDePago=\"PAGO EN UNA SOLA EXHIBICION\" metodoDePago=\"Efectivo\" noCertificado=\"20001000000100004027\" subTotal=\"7069.00\" TipoCambio=\"1\" Moneda=\"PESO\" total=\"8200.04\" tipoDeComprobante=\"ingreso\" NumCtaPago=\"123456\" LugarExpedicion=\"manzanillo\" FolioFiscalOrig=\"23480727-43C3-40C4-A866-356152786D86\" SerieFolioFiscalOrig=\"A\" FechaFolioFiscalOrig=\"2011-12-18T00:00:00\" MontoFolioFiscalOrig=\"125.21\"><cfdi:Emisor rfc=\"PNU1111251F3\" nombre=\"INTEGRADORA ADUANAL Y DE SERVICIOS WOODWARD S.C.\"><cfdi:DomicilioFiscal calle=\"AV. TENIENTE AZUETA\" noExterior=\"25-1\" colonia=\"BUROCRATA\" localidad=\"MANZANILLO\" municipio=\"MANZANILLO\" estado=\"COLIMA\" pais=\"MEXICO\" codigoPostal=\"28250\"/><cfdi:RegimenFiscal Regimen=\"regimen 1\"/><cfdi:RegimenFiscal Regimen=\"regimen 2\"/></cfdi:Emisor><cfdi:Receptor rfc=\"XEXX010101000\" nombre=\"TRADING SERVICES CORPORATION.\"><cfdi:Domicilio calle=\"1705 E HILLSIDE RD STE.\" noExterior=\"1\" localidad=\"LAREDO\" referencia=\"LAREDO\" municipio=\"LAREDO\" estado=\"TEXAS\" pais=\"USA\" codigoPostal=\"78041\"/></cfdi:Receptor><cfdi:Conceptos><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"inicio SERVICIOS COMPLEMENTARIOS\" valorUnitario=\"2000.00\" importe=\"2000.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"PREVIO\" valorUnitario=\"500.00\" importe=\"500.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"HONORARIOS\" valorUnitario=\"4569.00\" importe=\"4569.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"SERVICIOS COMPLEMENTARIOS\" valorUnitario=\"2000.00\" importe=\"2000.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"PREVIO\" valorUnitario=\"500.00\" importe=\"500.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"HONORARIOS\" valorUnitario=\"4569.00\" importe=\"4569.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"SERVICIOS COMPLEMENTARIOS\" valorUnitario=\"2000.00\" importe=\"2000.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"PREVIO\" valorUnitario=\"500.00\" importe=\"500.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"HONORARIOS\" valorUnitario=\"4569.00\" importe=\"4569.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"SERVICIOS COMPLEMENTARIOS\" valorUnitario=\"2000.00\" importe=\"2000.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"PREVIO\" valorUnitario=\"500.00\" importe=\"500.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"ultimo HONORARIOS\" valorUnitario=\"4569.00\" importe=\"4569.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"SERVICIOS COMPLEMENTARIOS\" valorUnitario=\"2000.00\" importe=\"2000.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"PREVIO\" valorUnitario=\"500.00\" importe=\"500.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"HONORARIOS\" valorUnitario=\"4569.00\" importe=\"4569.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"SERVICIOS COMPLEMENTARIOS\" valorUnitario=\"2000.00\" importe=\"2000.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"PREVIO\" valorUnitario=\"500.00\" importe=\"500.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"ultimo HONORARIOS\" valorUnitario=\"4569.00\" importe=\"4569.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"SERVICIOS COMPLEMENTARIOS\" valorUnitario=\"2000.00\" importe=\"2000.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"PREVIO\" valorUnitario=\"500.00\" importe=\"500.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"HONORARIOS\" valorUnitario=\"4569.00\" importe=\"4569.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"SERVICIOS COMPLEMENTARIOS\" valorUnitario=\"2000.00\" importe=\"2000.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"PREVIO\" valorUnitario=\"500.00\" importe=\"500.00\"/><cfdi:Concepto cantidad=\"1\" unidad=\"SERVICIO\" descripcion=\"ultimo HONORARIOS\" valorUnitario=\"4569.00\" importe=\"4569.00\"/></cfdi:Conceptos><cfdi:Impuestos totalImpuestosTrasladados=\"1131.04\"><cfdi:Traslados><cfdi:Traslado impuesto=\"IVA\" tasa=\"16\" importe=\"1131.04\"/></cfdi:Traslados></cfdi:Impuestos></cfdi:Comprobante>";
                //#region Timbrado
                //var comprobanteXML = new SrvTimbrado.ComprobanteXML { DatosXML = CadenaXML };
                //using (var timbradoSrv = new SrvTimbrado.TimbradoClient())
                //{
                //    var advetencias = timbradoSrv.TimbraXML(ref comprobanteXML, Util.RFC, token, ref transactionID);
                //    _view.ResultStr = comprobanteXML.DatosXML;
                //}
                //#endregion
                #region Optional steep to get the QR barcode image
                //transactionID = _random.Next();
                //XDocument doc = new XDocument();
                //doc = XDocument.Parse(comprobanteXML.DatosXML);
                //XElement singature = new XElement("{http://www.sat.gob.mx/TimbreFiscalDigital}TimbreFiscalDigital");
                //string uuid = doc.Root.Descendants(singature.Name).ToArray()[0].Attribute("UUID").Value;
                string uuid = UUID;
                //using (var timbradoSrv = new SrvTimbrado.TimbradoClient())
                //{

                     using (var timbradoSrv = new SrvRepository.RepositorioClient())
                {

                    var infoQR = timbradoSrv.ObtenerQR(Util.RFC, token, ref transactionID, uuid);
                    var ms = new System.IO.MemoryStream(infoQR.Imagen);
                    _view.BarcodeQR = new System.Drawing.Bitmap(ms);
                    FileStream fs = File.OpenWrite(string.Format(@"C:\{0}.png",UUID));
                    ms.WriteTo(fs);
                    fs.Flush();
                    fs.Close();

                }
                #endregion
            }
            #region Timbrado service exceptions
            catch (FaultException<SrvTimbrado.FallaServicio> serviceFault)
            {
                _view.ShowUnknownError(serviceFault.Detail.Descripcion);
                //using (var errorForm = new Forms.Error(TranslateFault.ToServiceError(serviceFault.Detail)))
                //{
                //    errorForm.ShowDialog();
                //}
            }
            catch (FaultException<SrvTimbrado.FallaSesion> sessionFauld)
            {
                _view.ShowUnknownError(sessionFauld.Detail.Descripcion);
                //_view.ShowSessionError(TranslateFault.ToSessionError(sessionFauld.Detail));
            }
            catch (FaultException<SrvTimbrado.FallaValidacion> validationFault)
            {
                //using (var errorForm = new Forms.Error(TranslateFault.ToValidationError(validationFault.Detail)))
                //{
                //    errorForm.ShowDialog();
                //}
                _view.ShowUnknownError(validationFault.Detail.Descripcion);
            }
            catch (Exception ex)
            {
                _view.ShowUnknownError(ex.Message);
            }
            #endregion
        }

        void _view_CancelaTimbrado(object sender, EventArgs e)
        {
            using (var ioForm = new Forms.frmCancelaTimbrado())
            {
                ioForm.ShowDialog();
            }
        }

        void _view_GetStatus(object sender, EventArgs e)
        {
            using (var ioForm = new Forms.frmGetStatusTimbrado())
            {
                ioForm.ShowDialog();
            }
        }

        void _view_GetTimbrado(object sender, EventArgs e)
        {
            using (var ioForm = new Forms.frmObtenerTimbrado())
            {
                ioForm.ShowDialog();
            }
        }
        void _view_TimbraXML(object sender, EventArgs e)
        {
            using (var ioForm = new Forms.frmTimbradoXMLFile())
            {
                ioForm.ShowDialog();
            }
        }




    }
}
