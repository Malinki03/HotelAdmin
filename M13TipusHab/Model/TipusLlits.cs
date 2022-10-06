using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M13TipusHab.Model
{
    public class TipusLlits
    {
        String nom;

        public TipusLlits(short? llitsInd, short? llitsDob)
        {
            String prefix = llitsInd.ToString() + llitsDob.ToString();
            if (prefix == "10") this.nom = "1I";
            if (prefix == "20") this.nom = "2I";
            if (prefix == "01") this.nom = "2D";
            if (prefix == "30") this.nom = "3I";
            if (prefix == "11") this.nom = "3D";
        }
    }
}
