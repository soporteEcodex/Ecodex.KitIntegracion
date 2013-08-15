using System;

namespace EcodexIntegrationSample.View
{
    interface IfrmComprobante : IInterface
    {
        string UUID { get; }
        string RFC { get; }
        Int64 transactionID { get; }
        string Invoice { set; }

        event EventHandler onGetInvoice;

    }
}
