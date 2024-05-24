using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadoEstudo.controller {
     class Materia {
        public string NomeMateria { get; set; } 
        public string Day {  get; set; }  
        public double Hours { get; set; } 
        public string Mouth { get; set; }
        public string Plataforma {  get; set; }
        public string Detalhes { get; set; }

        public Materia(string nomeMateria,string day, double hours, string mouth, string plataforma, string detalhes) {
            NomeMateria = nomeMateria;
            Day = day;
            Hours = hours;
            Mouth = mouth;
            Plataforma = plataforma;
            Detalhes = detalhes;
        }
    }
}
