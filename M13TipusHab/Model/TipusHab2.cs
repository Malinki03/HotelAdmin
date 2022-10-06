using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace M13TipusHab.Model
{
    public partial class tipusHab
    {

        public tipusHab(TipusLlits tLlits, short? qntPersones, string tipusBalco, short? teBanyera)
        {
            this.nom = tLlits.ToString()+"."+tipusBalco+"."+teBanyera;
            this.llitsInd = llitsInd;
            this.llitsDob = llitsDob;
            this.qntPersones = qntPersones;
            this.tipusBalco = tipusBalco;
            this.teBanyera = teBanyera;
        }
    }
}
