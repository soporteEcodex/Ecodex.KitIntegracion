using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcodexIntegrationSample.View
{
    interface ICancel : IInterface
    {
        String[] SelectedSourceUUID { get; }
        string SourceUUID { get; }
        String SourceRFC { get; }

        event EventHandler OnCancelProcessStart;

        void ShowResult(string message);
    }
}

