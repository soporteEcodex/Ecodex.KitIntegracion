using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcodexIntegrationSample.View
{
    interface IfrmRecuperaAcuseCancelacion : IInterface
    {
        string RFCEmisor { get; }
        string RFCReceptor { get; }
        long TransaccionId { get; }
        Guid UUID { get; set; }

        string Estatus { set; }
        string AcuseXML { set; }

        event EventHandler onRecuperaAcuseCancelacion;
    }
}
