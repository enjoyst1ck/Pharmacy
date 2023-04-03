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
    internal partial class FormMain : Form
    {
        FormAntibiotic formAntibiotic = new FormAntibiotic();
        FormSupplement formSupplement = new FormSupplement();
        

        //Lista obiektów klas pochodnych
        public static List<Medicament> listDrug = new List<Medicament>();  //lista przeznaczona na obiekty klasy pochodnych
        public static List<Medicament> listDrug1 = new List<Medicament>();  //lista przeznaczona na obiekty klasy pochodnych


        public static List<Antibiotic> listAntibiotic = new List<Antibiotic>();
        //Lista obiektów jednej klasy pochodnej - suplement
        public static List<Supplement> listSupplement = new List<Supplement>();  //lista przeznaczona na obiekty klasy pochodnej Supplement

        //Konstruktor klasy FormMain
        public FormMain()
        {
            InitializeComponent();
        }

        //Dodaj antybiotyk
        public void buttonAddAntibiotic_Click(object sender, EventArgs e)
        {
            formAntibiotic.ShowDialog();
        }

        //Dodaj suplement
        private void buttonAddSupplement_Click(object sender, EventArgs e)
        {
            formSupplement.ShowDialog();
        }
        //Przeglądaj obiekty
        private void buttonBrowseList_Click(object sender, EventArgs e)
        {
            FormBrowseList formBrowseList = new FormBrowseList();
            formBrowseList.ShowDialog();
        }

        //Przejdz do formatki funkcje operatorowe
        private void buttonFunctionOperator_Click(object sender, EventArgs e)
        {
            FormOperatorFunction formOperatorFunction = new FormOperatorFunction();
            formOperatorFunction.ShowDialog();
        }
    }
}
