﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace EcodexIntegrationSample.Controllers
{
    class frmGetStatusTimbradoController
    {
        private View.IfrmGetStatusTimbrado _view;
        private Random _random;

        //private const string INTEGRATOR_ID = "4606d3fc-056e-4ee1-8b01-d7b000064503";

        public frmGetStatusTimbradoController(View.IfrmGetStatusTimbrado view)
        {
            _view = view;
            _view.onGetStatusTimbrado += _view_onGetStatusTimbrado;
            _random = new Random();
        }

        void _view_onGetStatusTimbrado(object sender, EventArgs e)
        {
            String rfc = _view.RFC;
            String UUID = _view.UUID;
            Int64 transactionNueva = _random.Next();
            Int64 transactionID = _view.transactionID;
            string token = string.Empty;
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
                #region Token
                //using (var securitySrv = new SrvSecurity.SeguridadClient())
                //{
                //    var serviceToken = securitySrv.ObtenerToken(rfc, ref transactionID);
                //    var toHash = String.Format("{0}|{1}", INTEGRATOR_ID, serviceToken);
                //    token = Security.Hash(toHash);
                //}
                #endregion
                #region Status Timbrado
                using (var srvTimbrado = new SrvTimbrado.TimbradoClient())
                {
                    var respuesta = srvTimbrado.EstatusTimbrado(rfc, token, ref transactionNueva, transactionID, UUID);
                    _view.code = respuesta.Codigo;
                    _view.description = respuesta.Descripcion;
                }
                #endregion
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
            #endregion
            catch (Exception ex)
            {
                _view.ShowUnknownError(ex.Message);
            }
        }
    }
}
