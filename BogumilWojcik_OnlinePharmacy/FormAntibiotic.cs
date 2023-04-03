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
using System.Runtime;



namespace BogumilWojcik_OnlinePharmacy
{
    public partial class FormAntibiotic : Form
    {
        //public static List<Antibiotic> listAntibiotic = new List<Antibiotic>();

        public FormAntibiotic()
        {
            InitializeComponent();

            dateTimePickerExpirationDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerExpirationDate.CustomFormat = "dd-MM-yyyy";
            pictureBoxPhoto1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPhoto2.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "ABAKTAL";
            textBoxVat.Text = "0";
            numericUpDownNetPrice.Text = "32,10";
            dateTimePickerExpirationDate.Value = new DateTime(2024, 05, 10); ;
            numericUpDownAmount.Text = "50";

            textBoxDescription.Text = "Lek przeciwbakteryjny stosowany ogólnie. Chemioterapeutyk stosowany w leczeniu zakażeń bakteryjnych.";
            comboBoxType.Text = "Antybiotyk";
            comboBoxForm.Text = "Tabletka";
            textBoxPurpose.Text = "Preparat ma zastosowanie w leczeniu wielu zakażeń oraz infekcji mających miejsce w oponach mózgowo-rdzeniowych, kościach i stawach, układzie oddechowym, układzie moczowym i drogach żółciowych, układzie pokarmowym, a także stosowany w zapaleniu ucha i gardła, zakażeniach skóry, posocznicy i zapaleniach wsierdzia.";
            comboBoxUse.Text = "Doustnie";
            numericUpDownContent.Text = "10";
            textBoxProducer.Text = "Sandoz";
            textBoxLicense.Text = "R/0617";

            checkBoxPrescription.Checked = true;
            numericUpDownNumberOfDoses.Text = "2";
            textBoxComponent.Text = "Pefloksacyna";
            textBoxAdverseEffects.Text = "Bezsenność, Zawroty głowy, Ból głowy";
            textBoxAdditionalInformation.Text = "Brak";
            textBoxChemicalStructure.Text = "Fluorochinolon";

            pictureBoxPhoto1.Image = null;
            pictureBoxPhoto2.Image = null;
        }

        //Metoda czyszcząca pola tekstowe i inne obiekty do wprowadzania danych
        public void ClearTextBoxes()
        {
            textBoxName.Clear();
            textBoxVat.Text = "0";
            numericUpDownNetPrice.Text = "0";
            dateTimePickerExpirationDate.Value = DateTime.Now;
            numericUpDownAmount.Text = "0";

            textBoxDescription.Clear();


            textBoxPurpose.Clear();

            numericUpDownContent.Text = "0";
            textBoxProducer.Clear();
            textBoxLicense.Clear();

            checkBoxPrescription.Checked = false;
            numericUpDownNumberOfDoses.Value = 1;
            textBoxComponent.Clear();
            textBoxAdverseEffects.Clear();
            textBoxAdditionalInformation.Clear();
            textBoxChemicalStructure.Clear();
            pictureBoxPhoto1.Image = null;
        }

        public void buttonAddAntibiotic_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxVat.Text) < 0 || Convert.ToInt32(textBoxVat.Text) > 100)
                {
                    throw new MedicamentException("Wartość VAT musi byc liczbą całkowitą z przedziału [0;100].");
                }

                if (pictureBoxPhoto1.Image == null)
                    MessageBox.Show("Dodaj zdjęcie!");
                else
                {
                    Antibiotic drug1 = new Antibiotic(textBoxName.Text, Convert.ToInt32(textBoxVat.Text), Convert.ToDouble(numericUpDownNetPrice.Text),
                        dateTimePickerExpirationDate.Value, Convert.ToInt32(numericUpDownAmount.Text), textBoxDescription.Text, comboBoxType.Text,
                        comboBoxForm.Text, textBoxPurpose.Text, comboBoxUse.Text, Convert.ToInt32(numericUpDownContent.Text), textBoxProducer.Text, textBoxLicense.Text,
                        checkBoxPrescription.Checked, Convert.ToInt32(numericUpDownNumberOfDoses.Value),
                        textBoxComponent.Text, textBoxAdverseEffects.Text, textBoxAdditionalInformation.Text,
                        textBoxChemicalStructure.Text, (Bitmap)pictureBoxPhoto1.Image); ;

                    FormMain.listDrug.Add(drug1);        //dodanie obiektu do listy
                    FormMain.listAntibiotic.Add(drug1);  //dodanie obiektu do listy
                    listBoxAntibiotic.Items.Clear();  //wyczyszczenie listBoxa
                    listBoxAntibiotic.Items.Add("NOWY ANTYBIOTYK ZOSTAŁ DODANY DO LISTY");
                    FormMain.listDrug[FormMain.listDrug.Count - 1].Write(listBoxAntibiotic, pictureBoxPhoto2);
                    ClearTextBoxes();           //wyczyszczenie pól tekstowych i innych elementów

                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Wystąpił wyjątek: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił wyjątek: " + ex.Message);
            }
            finally
            {
                MessageBox.Show("Komunikat o zakończeniu obliczeń.");
            }

        }



        private void textBoxContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonReadPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        Bitmap pic = new Bitmap(openFileDialog1.OpenFile());
                        pictureBoxPhoto1.Image = pic;
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Niepoprawny format Bitmapy. " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Niepoprawny format Bitmapy. " + ex.Message);
            }
        }
        private void FormStudent_Shown(object sender, EventArgs e)
        {
            ClearTextBoxes();
            listBoxAntibiotic.Items.Clear();
            pictureBoxPhoto2 = null;
        }

        private void maskedTextBoxLicense_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void buttonSaveAntibiotic_Click(object sender, EventArgs e)
        {
            //    SaveFileDialog sfd = new SaveFileDialog(); //okno dialogowe do wyboru pliku do zapisu
            //    sfd.Filter = "Plik tekstowy|*.txt";
            //    sfd.Title = "Podaj nazwę pliku do zapisu danych osób";
            //    sfd.ShowDialog();
            //    if (sfd.FileName != "")
            //    {
            //        StreamWriter sw = new StreamWriter(sfd.FileName);
            //        foreach (Medicament p in FormMain.listAntibiotic) //dla każdego obiektu na liście listP
            //            p.WriteToFile(sw); //wywołaj odpowiednią wersję metody (wirtualnej)
            //                               //zapisującej do pliku
            //        sw.Close();
            //    }
        }
        private void buttonReadText_Click(object sender, EventArgs e)
        {
            //    listBoxAntibiotic.Items.Clear();

            //    OpenFileDialog ofd = new OpenFileDialog(); //okno dialogowe do wyboru pliku do odczytu danych
            //    ofd.Filter = "Plik tekstowy|*.txt";
            //    if (ofd.ShowDialog() == DialogResult.OK)
            //    {
            //        StreamReader sr = new StreamReader(ofd.FileName); //otwarcie pliku do odczytu

            //            foreach (Medicament p in FormMain.listAntibiotic)
            //                p.Write(listBoxAntibiotic);





            //        sr.Close();
            //    }
        }

        private void textBoxName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxName.Text = "Abaktal";
        }

        private void textBoxName_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show("fff");
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {

        }

        private void numericUpDownNetPrice_Leave(object sender, EventArgs e)
        {
            if (numericUpDownNetPrice.Value == 0)
                MessageBox.Show("Cena netto nie może wynosić 0!");
        }

        private void FormAntibiotic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            buttonFill_Click(sender, e);
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                buttonAddAntibiotic_Click(sender, e);
            }
        }

        private void FormAntibiotic_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
