using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcodexIntegrationSample.View
{
    interface IfrmObtenerTimbrado : IInterface
    {
        string UUID { get; }
        string RFC { get; }
        Int64 transactionID { get; }
        string stringTimbrado { set; }

        event EventHandler onObtenerTimbrado;

    }
}
