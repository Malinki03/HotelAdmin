using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M13TipusHab.Model
{
    internal class Repository
    {
        hotelEntities db;

        public Repository()
        {
            DbConnect();
        }

        public void DbConnect()
        {
            db = new hotelEntities();
        }


        public List<tipusBalco> GetTipusBalco()
        {
            List<tipusBalco> lt = new List<tipusBalco>();
            try
            {
                return db.tipusBalcoes.OrderBy(a => a.nomTipusBalco).ToList();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();
            }
            return lt;
        }

        public List<tipusHab> GetTipusHabs()
        {
            return db.tipusHabs.OrderBy(a => a.codi).ToList();
        }
    }
}
