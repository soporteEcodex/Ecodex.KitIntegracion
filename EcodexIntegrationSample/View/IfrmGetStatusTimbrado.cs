using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcodexIntegrationSample.View
{
    interface IfrmGetStatusTimbrado : IInterface
    {
        string UUID { get; }
        string RFC { get; }
        Int64 transactionID { get; }
        string description { set; }
        string code { set; }

        event EventHandler onGetStatusTimbrado;

    }
}
