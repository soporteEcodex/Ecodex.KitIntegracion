using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcodexIntegrationSample.View
{
    interface IfrmAsignarTimbreEmisor : IInterface
    {
        string RFCAsignar { get; }
        int TimbresAsignar { get; }
        long trsID { get; }

        int SaldoNuevo { set; }
        long SaldoAnterior { set; }

        event EventHandler onAsignarTimbreEmisor;
    }
}
