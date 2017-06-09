using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FoodProg.Data
{
    [Table("Pizza")]
    public class Pizza
    {
        int pizzaId = 0;
        string pizzaName = "";
        int cena = 1 ;
        DateTime data = DateTime.Today.AddMonths(6);
        string numer = "";
        string sklad = "";
        string opis;

        [Key]
        public int PizzaId
        {
            get { return pizzaId; }
            set { pizzaId = value; }
        }

        [XmlElement("nazwa-pizzy")]
        public string PizzaName
        {
            get { return pizzaName; }
            set { pizzaName = value; }
        }

        [XmlElement("cena")]
        public int Cena
        {
            get { return cena; }
            set { cena = value; }
        }

        [XmlElement("data")]
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        [XmlElement("numer-seryjny")]
        public string Numer
        {
            get { return numer; }
            set { numer = value; }
        }

        [XmlElement("skladnik")]
        public string Sklad
        {
            get { return sklad; }
            set { sklad = value; }
        }
        [XmlElement("opis")]
        public string Opis
        {
            get { return opis; }
            set { opis = value; }

        }
    }
}