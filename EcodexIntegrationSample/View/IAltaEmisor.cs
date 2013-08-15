using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcodexIntegrationSample.View
{
    interface IAltaEmisor :IInterface
    {
        string RFCIntegrador { get; }
        string RFCEmisor { get; set; }
        string RazonSocial { get; }
        string CorreoElectronico { get; }
        long TransaccionId { get; }

        string ClaveCertificado { set; }
        string Estatus { set; }

        event EventHandler onAltaEmisor;
    }
}
