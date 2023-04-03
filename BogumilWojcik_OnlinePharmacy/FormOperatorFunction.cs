using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BogumilWojcik_OnlinePharmacy
{
    public partial class FormOperatorFunction : Form
    {
        public FormOperatorFunction()
        {
            InitializeComponent();
            Check();

        }

        private void Check()
        {
            if (FormMain.listSupplement.Count > 0) //jeżeli lista nie jest pusta
            {
                for (int i = 0; i < FormMain.listSupplement.Count; i++)
                {
                    comboBoxObject1.Items.Add(i);
                    comboBoxObject2.Items.Add(i);
                }
            }
            else
                MessageBox.Show("Lista Suplementów jest pusta! Nie masz co porównywać!");
        }
        //przycisk do przeciazania operatora ==
        private void buttonCompare1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(comboBoxObject1.Text);
            int j = Convert.ToInt32(comboBoxObject2.Text);

            Supplement drug1 = FormMain.listSupplement[i];
            Supplement drug2 = FormMain.listSupplement[j];


            labelHelp1.Text = "Waga zawartości pudełka obiektu " + i + " wynosi: " + Convert.ToString(drug1.weightAll) + "g.";
            labelHelp2.Text = "Waga zawartości pudełka obiektu " + j + " wynosi: " + Convert.ToString(drug2.weightAll) + "g.";
            if (drug1 == drug2)
            {
                labelResults1.Text = "Waga zawartości pudełka obiektu " + i + " i obiektu " + j + " jest taka sama";
            }
            else
            {
                labelResults1.Text = "Waga zawartości pudełka obu obiektów nie jest taka sama.";
            }
        }
        //przycisk do przeciazania operatora != 
        private void buttonCompare2_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(comboBoxObject1.Text);
            int j = Convert.ToInt32(comboBoxObject2.Text);

            Supplement drug1 = FormMain.listSupplement[Convert.ToInt32(comboBoxObject1.Text)];
            Supplement drug2 = FormMain.listSupplement[Convert.ToInt32(comboBoxObject2.Text)];

            labelHelp1.Text = "Waga zawartości pudełka obiektu " + i + " wynosi: " + Convert.ToString(drug1.weightAll) + "g.";
            labelHelp2.Text = "Waga zawartości pudełka obiektu " + j + " wynosi: " + Convert.ToString(drug2.weightAll) + "g.";
            if (drug1 != drug2)
            {
                labelResults2.Text = "Waga zawartości pudełka obiektu " + i + " i obiektu " + j + " jest różna.";
            }
            else
            {
                labelResults2.Text = "Waga zawartości pudełka obu obiektów nie jest różna.";
            }
        }

        //przycisk do przeciazania operatora += (dodaj wagi)
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(comboBoxObject1.Text);
            int j = Convert.ToInt32(comboBoxObject2.Text);

            Supplement drug1 = FormMain.listSupplement[i];
            Supplement drug2 = FormMain.listSupplement[j];

            labelHelp1.Text = "Waga zawartości pudełka obiektu " + i + " wynosi: " + Convert.ToString(drug1.weightAll) + "g.";
            labelHelp2.Text = "Waga zawartości pudełka obiektu " + j + " wynosi: " + Convert.ToString(drug2.weightAll) + "g.";

            labelResults3.Text = "Łączna waga zawartości pudełek obu obiektow po dodaniu wynosi: " + Convert.ToString(drug1 + drug2) + "g.";
        }
    }
}
