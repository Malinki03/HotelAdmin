using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAdmin.Controlador
{
    internal class TipusHabController
    {
        CRUDTipusHab tipusHabForm;

        public TipusHabController()
        {
            this.tipusHabForm = new CRUDTipusHab();
            Application.Run(this.tipusHabForm);
        }
    }
}
