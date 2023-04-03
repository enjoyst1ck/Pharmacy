using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace BogumilWojcik_OnlinePharmacy
{
    public partial class FormBrowseList : Form
    {
        int currentIndex = -1; //indeks aktualnie wyświetlanego obiektu (osoby) z listy

        //public static List<Medicament> listDrug = new List<Medicament>(); //lista przeznaczona na obiekty klas pochodnych

        //Konstruktor
        public FormBrowseList()
        {
            InitializeComponent();
            currentIndex = -1;
            labelIndex.Text = "Nie wyświetlamy żadnego obiektu";
            UpdateButtons();
            Check();
        }
        private void UpdateButtons()
        {

            Check();

            if (currentIndex == 0) //jeżeli wyświetlamy pierwszy element na liście
            {
                buttonPrevious.Enabled = false;
                labelIndex.Visible = true;
                labelIndex.Text = Convert.ToString(currentIndex + 1);
            }
            else
            {
                buttonPrevious.Enabled = true;
                labelIndex.Visible = true;
                labelIndex.Text = Convert.ToString(currentIndex + 1);
            }
            if (currentIndex >= FormMain.listDrug.Count - 1) //jeżeli wyświetlamy ostatni element na liście
            {
                buttonNext.Enabled = false;
                labelIndex.Visible = true;
                labelIndex.Text = Convert.ToString(currentIndex + 1);
            }
            else
            {
                buttonNext.Enabled = true;
                labelIndex.Visible = true;
                labelIndex.Text = Convert.ToString(currentIndex + 1);
            }

            if (currentIndex < 0) //nic nie wyświetlamy
            {
                labelIndex.Visible = false;
                buttonNext.Enabled = false;
                buttonPrevious.Enabled = false;
            }
        }
        private void Check()
        {
            comboBoxObject.Text = "";
            comboBoxObject.Items.Clear();
            if (FormMain.listDrug.Count > 0) //jeżeli lista nie jest pusta
            {
                for (int i = 0; i < FormMain.listDrug.Count; i++)
                {
                    comboBoxObject.Items.Add(i + 1);
                }
            }
        }
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            listBoxList.Items.Clear();
            if (FormMain.listDrug.Count > 0) //jeżeli lista nie jest pusta
            {
                currentIndex = 0; //wyświetlamy pierwszy obiekt
                listBoxList.Items.Clear();
                FormMain.listDrug[currentIndex].Write(listBoxList, pictureBox1);
                UpdateButtons();
            }
            else
                MessageBox.Show("Lista jest pusta!");

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            currentIndex--;
            listBoxList.Items.Clear();
            FormMain.listDrug[currentIndex].Write(listBoxList, pictureBox1);
            UpdateButtons();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            currentIndex++;
            listBoxList.Items.Clear();
            FormMain.listDrug[currentIndex].Write(listBoxList, pictureBox1);
            UpdateButtons();
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter dw = new StreamWriter(saveFileDialog1.FileName))
                    foreach (Medicament rw in FormMain.listDrug)
                        rw.Serialize(dw);
            }
        }

        private void buttonReadFile_Click(object sender, EventArgs e)
        //Definicja metody wywoływanej po kliknięciu przycisku buttonReadP - wWybranie/podanie źródłowego
        //pliku tekstowego do odczytu, odczytanie z niego danych obiektów i dodanie obiektów do listy listP
        {//
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    //FormMain.listDrug.Clear();
                    using (StreamReader drugRead = new StreamReader(openFileDialog1.FileName))
                        while (!drugRead.EndOfStream)
                        {
                            string header = drugRead.ReadLine();
                            if (header == "Antybiotyk")
                                new Antibiotic(drugRead);
                            else if (header == "Suplement")
                                new Supplement(drugRead);
                        }
                foreach (Medicament pom in FormMain.listDrug)
                    pom.Write(listBoxList, pictureBox1);

                listBoxList.Items.Clear();
                pictureBox1.Image = null;
                buttonNext.Enabled = false;
                buttonPrevious.Enabled = false;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Wystąpił wyjątek: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił wyjątek: " + ex.Message);
            }
        }

        private void comboBoxObject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelate_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxList.Items.Clear();
                pictureBox1.Image = null;
                int i = comboBoxObject.SelectedIndex;
                FormMain.listDrug.RemoveAt(i);
                UpdateButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            if (FormMain.listDrug.Count > 0) //jeżeli lista nie jest pusta
                labelSum.Text = "Suma wszystkich produktów: " + CalculateSum(FormMain.listDrug.Count) + "zł";
        }
        private double CalculateSum(int lenght)
        {
            currentIndex = 0;
            double sum = 0;
            for (int i = 0; i < lenght; i++)
            {
                sum += Convert.ToDouble(FormMain.listDrug[currentIndex].netPrice);
            }
            return sum;
        }

        private void buttonDelate_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Usuwa wybrany obiekt", buttonDelate);
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            FormMain.listDrug.Sort();

            listBoxList.Items.Clear();
            currentIndex = -1;
            UpdateButtons();

        }
    }
}

