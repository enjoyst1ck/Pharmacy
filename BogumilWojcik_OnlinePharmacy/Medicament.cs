using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime;
using System.Windows.Forms;
using System.IO;

namespace BogumilWojcik_OnlinePharmacy
{
    public abstract class Medicament: IComparable<Medicament>
    {
        public int id;                     //identyfikator leku
        protected string name;                //nazwa leku
        protected int vat;                    //vat nalozony na produkt
        public double netPrice;           //cena netto - regularna cena leku, bez podatku

        protected int amount;                 //ilosc produktow

        protected string description;         //opis produktu, 
        protected string type;                //Typ - Antybiotyk czy suplement? Na recepte czy bez?
        protected string form;                //postac, np. - Tabletka, Krople, Syrop, zel 
        protected string purpose;             //przeznacznie - np. na dany rodzaj bólu, niedobór witaminy D, 
        protected string use;                 //aplikacja - np. doustnie, podjęzykowo, domięśniowo, dożylnie, 
        protected int content;                //zawartosc - np. 10 tabletek w opakowaniu
        protected string producer;            //Producent leku
        protected string license;             //nr pozwolenia(mozliwe litery)

        protected DateTime expirationDate;    //data waznosci
        public Bitmap bmp;               //zdjecie



        protected static int add_idDrug = 0;  //zmienna statyczna, wspólna dla wszystkich obiektów klasy Medicament
        //private double netPrice;


        //METODY KLASY (FUNKCJE SKŁADOWE)
        public int CompareTo(Medicament medicament)
        {
            if (medicament == null)
                return 1;

            //Będziemy chcieli posortować obiekty według nazwy
            if (String.Compare(this.name, medicament.name) == 1)
                return 1;
            else if (String.Compare(this.name, medicament.name) == -1)
                return -1;
            else
            {
                //Obiekty o takich samych nazwach bedziemy chcieli sortowac dodatkowo według cena_netto
                if (this.netPrice > medicament.netPrice)
                    return 1;
                else if(this.netPrice < medicament.netPrice)
                    return -1;
                else
                {
                    //obiekty o takich samych nazwach i cenach posortujemy według daty ważności
                    if (this.expirationDate > medicament.expirationDate)
                        return 1;
                    else if (this.expirationDate < medicament.expirationDate)
                        return -1;
                    return 0;
                }
            }
            
        }






        //Konstruktor bezargumentowy
        //Inicjalizuje pola wartościami domyślnymi
        public Medicament()
        {
            add_idDrug += 1;        //inkrementacja pola statycznego o 1
            this.id = add_idDrug;
            this.name = "-";
            this.vat = 0;
            this.netPrice = 0;
            this.expirationDate = new DateTime(2024,06,08);
            this.amount = 0;
            this.description = "-";
            this.type = "-";
            this.form = "-";
            this.purpose = "-";
            this.use = "-";
            this.content = 0;
            this.producer = "-";
            this.license = "-";
        }

        //Konstruktor wieloargumentowy
        //Inicjalizuje pola wartościami przekazanych argumentów
        public Medicament(string name, int vat, double netPrice, DateTime expirationDate, int amount,
                          string description, string type, string form, string purpose,
                          string use, int content, string producer, string license, Bitmap bmp)
        {
            add_idDrug += 1;
            this.id = add_idDrug;
            this.name = name;
            this.vat = vat;
            this.netPrice = netPrice;
            this.expirationDate = expirationDate;
            this.amount = amount;
            this.description = description;
            this.type = type;
            this.form = form;
            this.purpose = purpose;
            this.use = use;
            this.content = content;
            this.producer = producer;
            this.license = license;
            this.bmp = bmp;

        }

        //Konstruktor kopiujący
        //Inicjalizuje pola wartościmi skopiowanymi z argumentu - obiektu klasy Medicament;
        //jedynie identyfikator jest inny (czyli każdy obiekt będzie miał unikalne id)
        public Medicament(Medicament drug)
        {
            add_idDrug += 1;
            this.id = add_idDrug;
            this.name = drug.name;
            this.vat = drug.vat;
            this.netPrice = drug.netPrice;
            this.expirationDate = drug.expirationDate;
            this.amount = drug.amount;
            this.description = drug.description;
            this.type = drug.type;
            this.form = drug.form;
            this.purpose = drug.purpose;
            this.use = drug.use;
            this.content = drug.content;
            this.producer = drug.producer;
            this.license = drug.license;
            this.bmp = drug.bmp;
        }

        //Destruktor klasy Medicament
        ~Medicament()
        {
            //MessageBox.Show("Likwidacja obiektu klasy Medicament.");
        }

        //Definicja publicznej metody Write
        //Wypisuje opis i wartości pól obiektu w kontrolce ListBox
        //Nie zwraca żadnej wartości (void)
        public virtual void Write(ListBox medicine)
        {
            medicine.Items.Add("Id:\t\t\t" + id);
            medicine.Items.Add("Nazwa:\t\t\t" + name);
            medicine.Items.Add("Vat:\t\t\t" + vat + "%");
            medicine.Items.Add("Cena netto:\t\t" + netPrice + "zł");
            medicine.Items.Add("Cena brutto:\t\t" + CalculateGrossPrice(netPrice, vat) + "zł"); //wywołanie metody prywatnej CalculateGrossPrice
            medicine.Items.Add("Termin waznosci:\t\t" + expirationDate + "r.");
            medicine.Items.Add("Ilość produktów:\t\t" + amount);
            medicine.Items.Add("Dostepność:\t\t" + CheckAvailability(amount));                   //wywołanie metody prywatnej CheckAvailability
            medicine.Items.Add("Opis produktu:\t\t" + description);
            medicine.Items.Add("Typ produktu:\t\t" + type);
            medicine.Items.Add("Postać:\t\t\t" + form);
            medicine.Items.Add("Przeznacznie:\t\t" + purpose);
            medicine.Items.Add("Aplikacja:\t\t" + use);
            medicine.Items.Add("Ilość sztuk w opakowaniu:\t\t" + content);
            medicine.Items.Add("Producent\t\t" + producer);
            medicine.Items.Add("Pozwolenie:\t\t" + license);
            medicine.Items.Add("");
        }
        
        public virtual void Write(ListBox medicine, PictureBox pic)
        {
            medicine.Items.Add("Id:\t\t\t" + id);
            medicine.Items.Add("Nazwa:\t\t\t" + name);
            medicine.Items.Add("Vat:\t\t\t" + vat + "%");
            medicine.Items.Add("Cena netto:\t\t" + netPrice + "zł");
            medicine.Items.Add("Cena brutto:\t\t" + CalculateGrossPrice(netPrice, vat) + "zł"); //wywołanie metody prywatnej CalculateGrossPrice
            medicine.Items.Add("Termin waznosci:\t\t" + expirationDate.ToString("d"));

            medicine.Items.Add("Ilość produktów:\t\t" + amount);
            medicine.Items.Add("Dostepność:\t\t" + CheckAvailability(amount));                   //wywołanie metody prywatnej CheckAvailability
            medicine.Items.Add("Opis produktu:\t\t" + description);
            medicine.Items.Add("Typ produktu:\t\t" + type);
            medicine.Items.Add("Postać:\t\t\t" + form);
            medicine.Items.Add("Przeznacznie:\t\t" + purpose);
            medicine.Items.Add("Aplikacja:\t\t" + use);
            medicine.Items.Add("Ilość sztuk w opakowaniu:\t" + content);
            medicine.Items.Add("Producent\t\t" + producer);
            medicine.Items.Add("Pozwolenie:\t\t" + license);
            if (bmp != null) pic.Image = bmp;
            medicine.Items.Add("---------------------------");
        }

        //Oblicza roznice daty waznosci od dnia dzisiejszego, oblicza ile dni zostalo
        protected TimeSpan HowLongExpiration()
        {
            return expirationDate - DateTime.Now;
        }

        //Definicja prywatnej metody CalculateGrossPrice
        //zwraca cene brutto danego produktu, z zaokrągleniem do 2 miejsc po przecinku
        protected double CalculateGrossPrice(double net_price, int percent_vat)
        {
            double vat = percent_vat * 0.01;
            double gross_price = net_price * (1 + vat);
            gross_price = Math.Round(gross_price, 2);
            return gross_price;
        }

        //Definicja prywatnej metody CheckAvailability
        //sprawdza czy produkt jest dostepny (w zaleznosci od ilosci produktu)
        //zwraca true - produkt dostepny, false - produkt niedostepny
        protected string CheckAvailability(int amount)
        {
            if (amount <= 0)
            {
                return "Niedostepny";
            }
            else
            {
                return "Dostepny";
            }
        
        }
        virtual public void Serialize(StreamWriter sw) { }
        virtual public void Deserialize(StreamReader sr) { }

        //virtual public void WriteList(Label lname, Label lsurname, Label lce, PictureBox pb) { }

        //Definicja wirtualnej funkcji zapisującej wartości pól do pliku tekstowego
        //Ciało funkcji jest zdefiniowane w odpowiednich funkcjach klas pochodnych
        public virtual void WriteToFile(StreamWriter drugWrite)
        {
        }
        //Definicja wirtualnej funkcji wczytującej wartości pól z pliku tekstowego
        //Ciało funkcji jest zdefiniowane w odpowiednich funkcjach klas pochodnych
        public virtual void ReadFromFile(StreamReader drugRead)
        {
        }
    }


    internal class DataTime
    {
        public static DateTime Now { get; internal set; }
    }
}
