using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EcodexIntegrationSample.View
{
    interface IMain : IInterface
    {
        string ResultStr { set; }
        Bitmap BarcodeQR { set; }

        event EventHandler UniTestDunnyInvoice;
        event EventHandler UniTestDummyXMLString;
        event EventHandler GenerateXMLFile;
        event EventHandler CancelUUID;
        event EventHandler StampService;

        #region
        event EventHandler GetInvoice;
        event EventHandler GetStatus;
        event EventHandler GetStatusClient;
        event EventHandler GetAdvices;
        #endregion

    }
}
