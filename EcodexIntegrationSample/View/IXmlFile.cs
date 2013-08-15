using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcodexIntegrationSample.View
{
    interface IXmlFile : IInterface
    {
        String[] SelectedSourceFiles { get; }
        String SelectedResultFile { get; }

        event EventHandler OnInvoicesProcessStart;
        event EventHandler OnSelectResultFile;
        event EventHandler OnGetToken;
        event EventHandler OnSealandStampandStamp;

        Boolean AddResultFile(String fileName);
    }
}
