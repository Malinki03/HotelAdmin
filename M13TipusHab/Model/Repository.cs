using System;
using System.Collections.Generic;
using System.Linq;
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

        // Método que conecta a la base de datos
        public void DbConnect()
        {
            db = new hotelEntities();
        }

        // Lista los tipos de balcón por orden de nombre
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

        // Lista los tipos de habitación por orden de código
        public List<tipusHab> GetTipusHabs()
        {
            return db.tipusHabs.OrderBy(a => a.codi).ToList();
        }
    }
}
