using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WinFormsApp2.Resources.Class2;

namespace WinFormsApp2.Resources
{
    internal class Class2
    {


        public class Personelmaasİslemleri
        {

            public int id { get; set; }
            public int prsId { get; set; }
            public int maas { get; set; }
            public DateTime personeldonem { get; set; }
            public string prshesapno { get; set; }
            public int hesapbakiye { get; set; }
            public string ibanno { get; set; }
            public DateTime isgiristarih { get; set; }
            public DateTime odemetarih { get; set; }
            public string odemekurum { get; set; }
            public decimal kesintiler { get; set; }
            public decimal vergiler { get; set; }
            public decimal sigortaPrimleri { get; set; }
            public decimal brütmaas { get; set; }
            public decimal netMaas { get; set; }
           
           
        }
       
    }
}
