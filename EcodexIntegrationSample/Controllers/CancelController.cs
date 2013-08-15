using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Diagnostics;

namespace EcodexIntegrationSample
{
    class CancelController
    {
        private View.ICancel _view;
        private Random _random;


        //private const String INTEGRATOR_ID = "123";

        public CancelController(View.ICancel view)
        {
            _view = view;
            _view.OnCancelProcessStart += _view_OnCancelProcessStart;

            _random = new Random();
        }

        void _view_OnCancelProcessStart(object sender, EventArgs e)
        {
            var rfc = _view.SourceRFC;
            long transactionID = _random.Next();
            var token = string.Empty;
            /*if (_view.SelectedSourceUUID.Length == 0 && string.IsNullOrEmpty(_view.SourceUUID))
            {
                _view.ShowUnknownError("No se ha seleccionado ningún UUID para cancelar.");
                return;
            }*/
            if (string.IsNullOrEmpty(_view.SourceUUID))
            {
                _view.ShowUnknownError("No se ha indicado ningún UUID para cancelar.");
                return;
            }
            string Error;
            Utils.Utilerias Util = new Utils.Utilerias(_view);
            Error = Util.CreateToken(rfc, transactionID, ref token);
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
                //foreach (string UUID in _view.SelectedSourceUUID)
                //{
                //    transactionID = _random.Next();
                //    var cancelInvoice = new SrvRepository.RepositorioClient();
                //    var Result = cancelInvoice.CancelaComprobante(rfc, token, ref transactionID, UUID);
                //    if (Result)
                //    {
                //        _view.ShowResult(String.Format("The UUID:{0} has been canceled.", UUID));
                //    }
                //    else
                //    {
                //        _view.ShowUnknownError(String.Format("Can not cancel de UUID: {0}", UUID));
                //    }
                //}
                if (!string.IsNullOrEmpty(_view.SourceUUID))
                {
                    transactionID = _random.Next();
                    var cancelInvoice = new SrvRepository.RepositorioClient();
                    var Result = cancelInvoice.CancelaComprobante(rfc, token, ref transactionID, _view.SourceUUID);
                    if (Result)
                    {
                        _view.ShowResult(String.Format("The UUID:{0} has canceled.", _view.SourceUUID));
                    }
                    else
                    {
                        _view.ShowUnknownError(String.Format("Cannot cancel de UUID: {0}", _view.SourceUUID));
                    }
                }
            }
            #region Security service exceptions
            catch (FaultException<SrvSecurity.FallaServicio> serviceFault)
            {
                using (var errorForm = new Forms.Error(TranslateFault.ToServiceError(serviceFault.Detail)))
                {
                    errorForm.ShowDialog();
                }
            }
            catch (FaultException<SrvSecurity.FallaSesion> sessionFauld)
            {
                _view.ShowSessionError(TranslateFault.ToSessionError(sessionFauld.Detail));
            }
            #endregion
            #region Invoice service exceptions
            catch (FaultException<SrvRepository.FallaServicio> serviceFault)
            {
                using (var errorForm = new Forms.Error(TranslateFault.ToServiceError(serviceFault.Detail)))
                {
                    errorForm.ShowDialog();
                }
            }
            catch (FaultException<SrvRepository.FallaSesion> sessionFauld)
            {
                _view.ShowSessionError(TranslateFault.ToSessionError(sessionFauld.Detail));
            }
            #endregion
            catch (Exception ex)
            {
                _view.ShowUnknownError(ex.Message);
            }
        }
    }
}
