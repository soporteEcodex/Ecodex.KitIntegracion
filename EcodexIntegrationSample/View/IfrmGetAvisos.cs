using System;
using System.Windows.Forms;

namespace EcodexIntegrationSample.View
{
    interface IfrmGetAvisos : IInterface
    {
        string RFC { get; }

        ListViewItem[] itemsAdvices { set; }

        event EventHandler onGetAdvices;

    }
}
