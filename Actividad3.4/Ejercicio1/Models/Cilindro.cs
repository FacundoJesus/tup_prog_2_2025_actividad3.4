using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Cilindro : Figura
    {
        public double Radio {  get; set; }

        public Cilindro(double radio,double altura):base(altura)
        {
            this.Radio = radio;
        }
        public override double CalcularVolumen()
        {
            return (Math.PI * Math.Pow(this.Radio,2)) * this.Altura;
        }
        public override string Describir()
        {
            return $"Cilindro - Radio:{this.Radio:f2} - Alto: {this.Altura:f2} - Volumen: {CalcularVolumen():f2} ";
        }
    }
}
