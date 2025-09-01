using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Ortoedro : Figura
    {
        public double Ancho { get; set; }
        public double Largo { get; set; }

        public Ortoedro(double ancho, double largo,double alto) : base(alto)
        {
            this.Ancho = ancho;
            this.Largo = largo;
        }

        public override double CalcularVolumen()
        {
            return Ancho * Largo * Altura;
        }

        public override string Describir()
        {
            return $"Ortoedro - Ancho:{this.Ancho:f2} - Largo:{this.Largo:f2} - Alto: {this.Altura:f2} - Volumen: {CalcularVolumen():f2} ";
        }
    }
}
