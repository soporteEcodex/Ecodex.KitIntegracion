using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcodexIntegrationSample.View
{
    interface IfrmGetStatusClient : IInterface
    {
        string RFC { get; }

        string InvoicesAsigned { set; }
        string InvoicesRemaining { set; }
        string InvoicesUsed { set; }
        DateTime DateStart { set; }
        DateTime DateEnd { set; }
        string Description { set; }

        event EventHandler onGetStatusClient;

    }
}
