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
    public partial class FormSupplement : Form
    {

        public FormSupplement()
        {
            InitializeComponent();
            dateTimePickerExpirationDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerExpirationDate.CustomFormat = "dd-MM-yyyy";
            pictureBoxPhoto1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPhoto2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "SEMA Lab Tymianek i Podbiał";
            textBoxVat.Text = "8";
            numericUpDownNetPrice.Text = "32,10";
            dateTimePickerExpirationDate.Value = new DateTime(2024, 05, 10); ;
            numericUpDownAmount.Text = "150";
            textBoxDescription.Text = "SEMA Lab Tymianek i Podbiał + Ekstrakt z 20 Ziół to suplement diety będący połączeniem ekstraktu z tymianku (Thymus vulgaris L.) i podbiału (Tussilago farfara L.).";
            comboBoxType.Text = "Suplement diety";
            comboBoxForm.Text = "Pastylka";
            textBoxPurpose.Text = "Wspiera wydzielanie śluzu w górnych drogach oddechowych, ułatwiając odkrztuszanie.";
            comboBoxUse.Text = "Doustnie";
            numericUpDownContent.Text = "24";
            textBoxProducer.Text = "Laboratoria Gemini";
            textBoxLicense.Text = "14329";

            textBoxActiveSubstance.Text = "Izomalt";

            checkBoxGluten.Checked = true;
            checkBoxLactose.Checked = true;
            numericUpDownWeight.Text = "0,3";
            numericUpDownNumberOfDoses.Text = "1";
            textBoxAddVitamine.Text = "B2";
            textBoxTip.Text = "Produkt nie jest odpowiedni do stosowania jako jedyne źródło pożywienia.";

            pictureBoxPhoto1.Image = null;
            pictureBoxPhoto2.Image = null;
        }

        public void ClearTextBoxes()
        {
            textBoxName.Clear();
            textBoxVat.Text = "0";
            numericUpDownNetPrice.Text = "0";
            dateTimePickerExpirationDate.Value = DateTime.Now;
            numericUpDownAmount.Text = "0";

            textBoxDescription.Clear();
            //  comboBoxType.Clear();
            //  comboBoxForm.Clear();   
            textBoxPurpose.Clear();
            //  comboBoxUse.Clear();
            //textBoxContent.Clear();
            numericUpDownContent.Text = "0";
            textBoxProducer.Clear();
            textBoxLicense.Clear();

            textBoxActiveSubstance.Clear();
            checkBoxGluten.Checked = false;
            checkBoxLactose.Checked = false;
            numericUpDownWeight.Value = 0;
            numericUpDownNumberOfDoses.Value = 1;
            textBoxAddVitamine.Clear();
            textBoxTip.Clear();

            pictureBoxPhoto1.Image = null;

        }
        private void buttonAddSupplement_Click(object sender, EventArgs e)
        {   try
            {
                if (Convert.ToInt32(textBoxVat.Text) < 0 || Convert.ToInt32(textBoxVat.Text) > 100)
                {
                    throw new MedicamentException("Wartość VAT musi byc liczbą całkowitą z przedziału [0;100].");
                }
                if (pictureBoxPhoto1.Image == null)
                    MessageBox.Show("Dodaj zdjęcie!");
                else
                {
                    Supplement drug1 = new Supplement(textBoxName.Text, Convert.ToInt32(textBoxVat.Text), Convert.ToDouble(numericUpDownNetPrice.Text),
        dateTimePickerExpirationDate.Value, Convert.ToInt32(numericUpDownAmount.Text), textBoxDescription.Text, comboBoxType.Text,
        comboBoxForm.Text, textBoxPurpose.Text, comboBoxUse.Text, Convert.ToInt32(numericUpDownContent.Text), textBoxProducer.Text, textBoxLicense.Text,
        textBoxActiveSubstance.Text, checkBoxGluten.Checked, checkBoxLactose.Checked, Convert.ToDouble(numericUpDownWeight.Value),
        Convert.ToInt32(numericUpDownNumberOfDoses.Value), textBoxAddVitamine.Text, textBoxTip.Text, (Bitmap)pictureBoxPhoto1.Image);

                    FormMain.listDrug.Add(drug1);        //dodanie obiektu do listy
                    FormMain.listSupplement.Add(drug1);        //dodanie obiektu do listy

                    listBoxSupplement.Items.Clear();  //wyczyszczenie listBoxa
                    listBoxSupplement.Items.Add("NOWY SUPLEMENT ZOSTAŁ DODANY DO LISTY");
                    FormMain.listDrug[FormMain.listDrug.Count - 1].Write(listBoxSupplement, pictureBoxPhoto2);
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


        private void FormStudent_Shown(object sender, EventArgs e)
        {
            ClearTextBoxes();
            listBoxSupplement.Items.Clear();
            pictureBoxPhoto2 = null;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
