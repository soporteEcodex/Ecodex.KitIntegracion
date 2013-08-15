using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcodexIntegrationSample.View
{
    interface IInterface
    {
        void ShowSessionError(Entity.SessionError error);
        void ShowUnknownError(String message);
    }
}
