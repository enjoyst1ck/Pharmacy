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
    internal class Supplement : Medicament
    {
        string activeSubstance; //składnik czynny witaminy
        bool gluten; //czy zawiera gluten
        bool lactose; //czy zawiera laktoze
        public double weight; //waga pojedynczej sztuki
        public double weightAll; //waga pojedynczej sztuki
        public int numberOfDoses;      //liczba dawek - ile razy dziennie brac 
        string tip; //wskazowki dotyczace suplementu

        string vitamine;
        //Bitmap bmp;

        //Konstruktor bezargumentowy wywołujący odpowiedni konstruktor klasy
        //bazowej (Medicament)
        public Supplement() : base()
        {
            activeSubstance = "-";
            gluten = false;
            lactose = false;
            weight = 0;
            weightAll = 0;
            numberOfDoses = 0;
            vitamine = "B2";
            tip = "-";
        }

        //Konstruktor wieloargumentowy wywolujacy odpowiedni konstruktor klasy bazowej()
        public Supplement(string name, int vat, double netPrice, DateTime expirationDate, int amount,
                          string description, string type, string form, string purpose,
                          string use, int content, string producer, string license, string activeSubstance,
                          bool gluten, bool lactose, double weight, int numberOfDoses, string vitamine, string tip, Bitmap photo) :
                          base(name, vat, netPrice, expirationDate, amount, description, type, form, purpose,
                          use, content, producer, license, photo)
        {
            this.activeSubstance = activeSubstance;
            this.gluten = gluten;
            this.lactose = lactose;
            this.weight = weight;
            weightAll = CalculateWeight(content, weight);
            this.numberOfDoses = numberOfDoses;
            this.vitamine = vitamine;
            this.tip = tip;
        }

        //Konstruktor kopiujący wywołujący odpowiedni konstruktor klasy bazowej
        public Supplement(Supplement drug) : base(drug)
        {
            this.activeSubstance = drug.activeSubstance;
            this.gluten = drug.gluten;
            this.lactose = drug.lactose;
            this.weight = drug.weight;
            this.weightAll = drug.CalculateWeight(content, weight);
            this.numberOfDoses = drug.numberOfDoses;
            this.vitamine = drug.vitamine;
            this.tip = drug.tip;
        }

        public override bool Equals(object o)
        {
            return true;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public static bool operator ==(Supplement drug1, Supplement drug2)
        {
            return drug1.weightAll == drug2.weightAll;
        }

        public static bool operator !=(Supplement drug1, Supplement drug2)
        {
            return drug1.weightAll != drug2.weightAll;
        }

        //Oblicza która ogólna waga produktu jest większa
        //Funkcja OPERATOROWA realizująca mnożenie dwóch liczb, aby uzyskać wage ogolna produktu
        public static double operator +(Supplement drug1, Supplement drug2)
        {
            return drug1.weightAll + drug2.weightAll;
        }

        public override void Write(ListBox medicine)
        {
            base.Write(medicine);
            medicine.Items.Add("------------------------");
            medicine.Items.Add("Składnik czynny:\t\t" + activeSubstance);
            medicine.Items.Add("Gluten:\t" + gluten);
            medicine.Items.Add("Gluten:\t" + CheckGluten(gluten));

            medicine.Items.Add("Laktoza:\t\t" + lactose);
            medicine.Items.Add("Laktoza:\t\t" + CheckLactose(lactose));
            medicine.Items.Add("Ile dziennego spożycia:\t\t" + numberOfDoses + " dziennie.");
            medicine.Items.Add("Witaminy, które zawiera:\t\t");
            for (int i = 0; i < vitamine.Length; i++)
            {
                medicine.Items.Add("\t\t\t" + (i + 1) + ". " + vitamine[i]);
            }
            medicine.Items.Add("Wskazówki:\t\t" + tip);
            medicine.Items.Add("Masa jednej sztuki:\t\t" + weight + " g.");
            medicine.Items.Add("Masa netto pudełka:\t\t" + weightAll + " g.");
            medicine.Items.Add("------------------------");
            medicine.Items.Add("");

        }
        public override void Write(ListBox medicine, PictureBox pic)
        {
            base.Write(medicine, pic);
            medicine.Items.Add("Składnik czynny:\t\t" + activeSubstance);
            medicine.Items.Add("Gluten:\t\t\t" + gluten);
            medicine.Items.Add("Gluten:\t\t\t" + CheckGluten(gluten));

            medicine.Items.Add("Laktoza:\t\t\t" + lactose);
            medicine.Items.Add("Laktoza:\t\t\t" + CheckLactose(lactose));

            medicine.Items.Add("Ile dziennego spożycia:\t" + numberOfDoses + " dziennie.");
            medicine.Items.Add("Witaminy, które zawiera:\t\t");
            medicine.Items.Add("\t\t\t" + vitamine);
            medicine.Items.Add("Wskazówki:\t\t" + tip);
            medicine.Items.Add("Masa jednej sztuki:\t\t" + weight + " g.");
            medicine.Items.Add("Masa netto pudełka:\t" + weightAll + " g."); //tutaj
            medicine.Items.Add("Ile jeszcze ważności:\t" + expirationDays().Days + " dni.");  //tutaj
            medicine.Items.Add("------------------------");
            medicine.Items.Add("");
        }

        //Oblicza ogólną wage produktu
        protected double CalculateWeight(int content, double weight)
        {
            return content * weight;
        }
        
        //zwraca roznice pomiedzy data waznosci a dzis
        protected TimeSpan expirationDays()
        {
            return expirationDate - DateTime.Now;
        }
        protected string CheckGluten(bool gluten)
        {
            if (gluten)
            {
                return "Tak";
            }
            else
            {
                return "Nie";
            }
        }
        protected string CheckLactose(bool lactose)
        {
            if (lactose)
            {
                return "Tak";
            }
            else
            {
                return "Nie";
            }
        }

        public Supplement(StreamReader sr) // nowy konstruktor - tworzenie obiektu na podstawie fragmentu pliku
        {
            Deserialize(sr);
            FormMain.listDrug.Add(this);
        }
        private void SaveBmp(StreamWriter sw)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, ImageFormat.Bmp);
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
            drugWrite.WriteLine("Suplement");
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
            drugWrite.WriteLine(activeSubstance);
            drugWrite.WriteLine(gluten);
            drugWrite.WriteLine(lactose);
            drugWrite.WriteLine(weight);
            drugWrite.WriteLine(numberOfDoses);
            drugWrite.WriteLine(vitamine);
            drugWrite.WriteLine(tip);
            SaveBmp(drugWrite);
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
            activeSubstance = drugRead.ReadLine();
            gluten = Convert.ToBoolean(drugRead.ReadLine());
            lactose = Convert.ToBoolean(drugRead.ReadLine());
            weight = Convert.ToDouble(drugRead.ReadLine());
            numberOfDoses = Convert.ToInt32(drugRead.ReadLine());

            vitamine = drugRead.ReadLine();
            
            tip = drugRead.ReadLine();
            bmp = LoadBmp(drugRead);
        }


        //Definicja wirtualnej funkcji zapisującej wartości pól obiektu klasy Suplement do pliku tekstowego
        public override void WriteToFile(StreamWriter drugWrite)
        {
        }
        //Definicja wirtualnej funkcji wczytującej wartości pól obiektu klasy Student z pliku tekstowego
        public override void ReadFromFile(StreamReader drugRead)
        {
        }

    }
}
