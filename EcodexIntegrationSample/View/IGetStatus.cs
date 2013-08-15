using System;

namespace EcodexIntegrationSample.View
{
    interface IGetStatus : IInterface
    {
        string UUID { get; }
        string RFC { get; }
        Int64 transactionID { get; }
        string description { set; }
        string code { set; }

        event EventHandler onGetStatus;

    }
}
