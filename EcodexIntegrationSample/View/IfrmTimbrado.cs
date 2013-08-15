using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EcodexIntegrationSample.View
{
    interface IfrmTimbrado : IInterface
    {
        string ResultStr { set; }
        Bitmap BarcodeQR { set; }

        event EventHandler UniTestDummyXMLString;
        event EventHandler CancelaTimbrado;
        event EventHandler TimbraXML;

        #region
        event EventHandler GetStatus;
        event EventHandler GetTimbrado;
        #endregion

    }
}
