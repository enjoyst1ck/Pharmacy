using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Runtime;
using System.IO;
using System.Drawing.Imaging;

namespace BogumilWojcik_OnlinePharmacy
{
    class Antibiotic : Medicament
    {
        bool prescription;      //czy antybiotyk na recepta
        int numberOfDoses;      //liczba dawek - ile razy dziennie brac antybiotyk
        string component;       //składniki antybiotyku
        string adverseEffects;  //skutki uboczne, dzialania nieporządane
        string chemicalStructure;       //budowa chemiczna, np. beta-laktamowe, makrolidy itd...
        string additionalInformation;   //np. dla jakiej plci
        //Bitmap bmp;
        //

        //Konstruktor bezargumentowy wywołujący odpowiedni konstruktor klasy
        //bazowej (Medicament)
        public Antibiotic() : base()
        {
            prescription = false;
            numberOfDoses = 0;
            component = "-";
            adverseEffects = "-";
            chemicalStructure = "-";
            additionalInformation = "-";
            expirationDate = DateTime.Now;
        }

        //Konstruktor wieloargumentowy wywolujacy odpowiedni konstruktor klasy bazowej()
        public Antibiotic(string name, int vat, double netPrice, DateTime expirationDate, int amount,
                          string description, string type, string form, string purpose,
                          string use, int content, string producer, string license, bool prescription,
                          int numberOfDoses, string component, string adverseEffects, string additionalInformation,
                          string chemicalStructure, Bitmap photo) :
                          base(name, vat, netPrice, expirationDate, amount, description, type, form, purpose,
                          use, content, producer, license, photo)
        {
            this.prescription = prescription;
            this.numberOfDoses = numberOfDoses;
            this.component = component;
            this.adverseEffects = adverseEffects;
            this.additionalInformation = additionalInformation;
            this.chemicalStructure = chemicalStructure;
        }

        //Konstruktor kopiujący wywołujący odpowiedni konstruktor klasy bazowej
        public Antibiotic(Antibiotic drug) : base(drug)
        {
            this.prescription = drug.prescription;
            this.numberOfDoses = drug.numberOfDoses;
            this.component = drug.component;
            this.adverseEffects = drug.adverseEffects;
            this.additionalInformation = drug.additionalInformation;
            this.chemicalStructure = drug.chemicalStructure;
        }

        public override void Write(ListBox medicine)
        {
            base.Write(medicine);
            medicine.Items.Add("Czy lek na recepte?:\t" + CheckPrescription(prescription));

            medicine.Items.Add("Ile razy dziennie:\t\t" + numberOfDoses);
            medicine.Items.Add("Co ile godzin:\t\t" + HowManyTimesOfDay(numberOfDoses));
            medicine.Items.Add("Na ile dni starczy:\t\t" + HowManyDays(content, numberOfDoses));

            medicine.Items.Add("Glowny skladnik:\t\t" + component);
            medicine.Items.Add("Skutki uboczne:\t\t" + adverseEffects);
            medicine.Items.Add("Dodatkowe informacje:\t" + additionalInformation);
            medicine.Items.Add("Budowa chemiczna:\t" + chemicalStructure);
            medicine.Items.Add("------------------------");
            medicine.Items.Add("");
        }

        public override void Write(ListBox medicine, PictureBox pic)
        {
            base.Write(medicine, pic);
            medicine.Items.Add("Czy lek na recepte?:\t" + CheckPrescription(prescription));

            medicine.Items.Add("Ile razy dziennie:\t\t" + numberOfDoses);
            medicine.Items.Add("Co ile godzin:\t\t" + HowManyTimesOfDay(numberOfDoses));
            medicine.Items.Add("Na ile dni starczy:\t\t" + HowManyDays(content, numberOfDoses));

            medicine.Items.Add("Glowny skladnik:\t\t" + component);
            medicine.Items.Add("Skutki uboczne:\t\t" + adverseEffects);
            medicine.Items.Add("Dodatkowe informacje:\t" + additionalInformation);
            medicine.Items.Add("Budowa chemiczna:\t" + chemicalStructure);
            //if (bmp != null) pic.Image = bmp;
            medicine.Items.Add("------------------------");
            medicine.Items.Add("");
        }

        protected string CheckPrescription(bool prescription)
        {
            if (prescription)
            {
                return "Tak";
            }
            else
            {
                return "Nie";
            }
        }
        //zwraca ile razy dziennie trzeba brac tabletke
        protected int HowManyTimesOfDay(int numberOfDoses)
        {
            return 24 / numberOfDoses;
        }
        //zwraca liczbe ile dni trzeba brac antybiotyk
        protected int HowManyDays(int content, int numberOfDoses)
        {
            return content / numberOfDoses;
        }
        public Antibiotic(StreamReader sr) // nowy konstruktor - tworzenie obiektu na podstawie fragmentu pliku
        {
            Deserialize(sr);
            FormMain.listDrug.Add(this);
        }
        private void SaveBmp(StreamWriter sw)
        {

            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, ImageFormat.Bmp);
                //GC.KeepAlive(ms);
                byte[] bytes = ms.ToArray();
                sw.WriteLine(Convert.ToBase64String(bytes, 0, bytes.Length));
            }
        }

        private Bitmap LoadBmp(StreamReader sr)
        {
            byte[] bytes = Convert.FromBase64String(sr.ReadLine());
            using (MemoryStream ms = new MemoryStream(bytes))
                return new Bitmap(ms);
        }
        override public void Serialize(StreamWriter drugWrite)
        {
            drugWrite.WriteLine("Antybiotyk");
            drugWrite.WriteLine(id);
            drugWrite.WriteLine(name);
            drugWrite.WriteLine(vat);
            drugWrite.WriteLine(netPrice);
            drugWrite.WriteLine(expirationDate);
            drugWrite.WriteLine(amount);
            drugWrite.WriteLine(description);
            drugWrite.WriteLine(type);
            drugWrite.WriteLine(form);
            drugWrite.WriteLine(purpose);
            drugWrite.WriteLine(use);
            drugWrite.WriteLine(content);
            drugWrite.WriteLine(producer);
            drugWrite.WriteLine(license);
            drugWrite.WriteLine(prescription);
            drugWrite.WriteLine(numberOfDoses);
            drugWrite.WriteLine(component);
            drugWrite.WriteLine(adverseEffects);
            drugWrite.WriteLine(additionalInformation);
            drugWrite.WriteLine(chemicalStructure);
            if (bmp != null) SaveBmp(drugWrite);
        }
        override public void Deserialize(StreamReader drugRead)
        {
            id = Convert.ToInt32(drugRead.ReadLine());
            name = drugRead.ReadLine();
            vat = Convert.ToInt32(drugRead.ReadLine());
            netPrice = Convert.ToDouble(drugRead.ReadLine());
            expirationDate = Convert.ToDateTime(drugRead.ReadLine());

            amount = Convert.ToInt32(drugRead.ReadLine());
            description = drugRead.ReadLine();
            type = drugRead.ReadLine();
            form = drugRead.ReadLine();
            purpose = drugRead.ReadLine();
            use = drugRead.ReadLine();
            content = Convert.ToInt32(drugRead.ReadLine());
            producer = drugRead.ReadLine();
            license = drugRead.ReadLine();
            prescription = Convert.ToBoolean(drugRead.ReadLine());
            numberOfDoses = Convert.ToInt32(drugRead.ReadLine());
            component = drugRead.ReadLine();
            adverseEffects = drugRead.ReadLine();
            additionalInformation = drugRead.ReadLine();
            chemicalStructure = drugRead.ReadLine();
            bmp = LoadBmp(drugRead);
        }


        //Definicja wirtualnej funkcji zapisującej wartości pól obiektu klasy Lek do pliku tekstowego
        public override void WriteToFile(StreamWriter drugWrite)
        {
        }
        //Definicja wirtualnej funkcji wczytującej wartości pól obiektu klasy Antybiotyk z pliku tekstowego
        public override void ReadFromFile(StreamReader drugRead)
        {
        }
    }
}
