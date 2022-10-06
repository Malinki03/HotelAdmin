using M13TipusHab.Model;
using M13TipusHab.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M13TipusHab.Controller
{
    internal class Controller1
    {
        Form1 f;
        Repository r;

        public Controller1()
        {
            f = new Form1();
            r = new Repository();
            LoadData();
            InitListener();
            Application.Run(f);

        }

        void LoadData()
        {
            f.comboBox1.DataSource = new List<int>() {1,2,3};
            LoadComboBox2(null,null);
            f.comboBox3.DataSource = r.GetTipusBalco();
            f.comboBox3.DisplayMember = "nomTipusBalco";
            f.habDGV.DataSource = r.GetTipusHabs();
        }

        void LoadComboBox2(object sender, EventArgs e)
        {
            List<String> lLlits = new List<String>() { "1 llit individual", "2 llits individuals", "1 llit matrimonial", "3 llits individuals", "1 llit matrimonial i 1 llit individual" }; ;
            f.comboBox2.DataSource = LlistaLlits(lLlits, f.comboBox1.SelectedIndex);
        }

        void InitListener()
        {
            f.comboBox1.SelectedIndexChanged += LoadComboBox2;
            f.addButton.Click += AddButton_Click;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
        }

        private List<string> LlistaLlits(List<String> lL, int n)
        {
            switch (n)
            {
                case 0:
                    return new List<string>() { "1 llit individual" };
                case 1:
                    return new List<string>() { "2 llits individuals", "1 llit matrimonial" };
                case 2:
                    return new List<string>() { "3 llits individuals", "1 llit matrimonial i 1 llit individual" };
                default: return lL;
            }
        }
    }
}
