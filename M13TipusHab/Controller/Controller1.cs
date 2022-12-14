using M13TipusHab.Model;
using M13TipusHab.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace M13TipusHab.Controller
{
    // Clase controladora principal
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

        // Método que carga todos los datos de la aplicación
        void LoadData()
        {
            f.persCombo.DataSource = new List<int>() { 0, 1, 2, 3 };
            LoadComboBox2(null, null);
            f.balcCombo.DataSource = r.GetTipusBalco();
            f.balcCombo.DisplayMember = "nomTipusBalco";
            f.habDGV.DataSource = r.GetTipusHabs();
        }

        void reloadDataGridView()
        {
            f.habDGV.DataSource = r.GetTipusHabs();
        }

        // Evento que carga el contenido del combo box de tipos de combinaciones de cama, cambiando cuando se altere la combo box de número de personas
        void LoadComboBox2(object sender, EventArgs e)
        {
            List<String> lLlits = new List<String>() { "1 llit individual", "2 llits individuals", "1 llit matrimonial", "3 llits individuals", "1 llit matrimonial i 1 llit individual" }; ;
            f.llitCombo.DataSource = LlistaLlits(lLlits, f.persCombo.SelectedIndex);
        }

        // Método que inicializa los listeners
        void InitListener()
        {
            f.persCombo.SelectedIndexChanged += LoadComboBox2;
            f.addButton.Click += AddButton_Click;
            f.delButton.Click += DelButton_Click;
        }

        // Método que numeraliza 
        short? ComboBox2Index(String comboBoxIndex)
        {
            if (comboBoxIndex.Equals("1 llit individual")) return 0;
            else if (comboBoxIndex.Equals("2 llits individuals")) return 1;
            else if (comboBoxIndex.Equals("1 llit matrimonial")) return 2;
            else if (comboBoxIndex.Equals("3 llits individuals")) return 3;
            else if (comboBoxIndex.Equals("1 llit matrimonial i 1 llit individual")) return 4;
            else return null;
        }

        String formatTipusBalco(int tipusBalco)
        {
            if (tipusBalco == 0)
            {
                return "bal0";
            }
            else if (tipusBalco == 1)
            {
                return "balN";
            }
            else
            {
                return "balP";
            }
        }

        // Evento que añade el tipo de habitación a la base de datos
        private void AddButton_Click(object sender, EventArgs e)
        {
            r.addTipusHab(new tipusHab(
                new TipusLlits(ComboBox2Index(f.llitCombo.Text)),
                ((short)f.persCombo.SelectedIndex),
                formatTipusBalco(f.balcCombo.SelectedIndex),
                f.banyCheck.Checked));
            LoadData();
        }

            private void DelButton_Click(object sender, EventArgs e)
            {
                r.DelTipusHab((f.habDGV.SelectedRows[0].DataBoundItem as tipusHab));
                reloadDataGridView();
            }

            // Método que elige que opciones expone en el combo box de tipos de combinaciones de camas
            private List<string> LlistaLlits(List<String> lL, int n)
            {
                switch (n)
                {
                    case 0:
                        return lL;
                    case 1:
                        return new List<string>() { "1 llit individual" };
                    case 2:
                        return new List<string>() { "2 llits individuals", "1 llit matrimonial" };
                    case 3:
                        return new List<string>() { "3 llits individuals", "1 llit matrimonial i 1 llit individual" };
                    default: return lL;
                }
            }
        }
    }
