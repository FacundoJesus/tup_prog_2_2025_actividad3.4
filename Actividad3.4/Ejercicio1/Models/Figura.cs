using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public abstract class Figura:IComparable
    {
        public double Altura { get; set; }

        public Figura (double Altura)
        {
            this.Altura = Altura;
        }

        public abstract string Describir();

        public virtual double CalcularVolumen()
        {
            return 0;
        }

        public override string ToString()
        {
            return Describir();
        }

        public int CompareTo(object obj)
        {
            Figura nuevaFigura = obj as Figura;
            if(nuevaFigura != null)
            {
                return this.CalcularVolumen().CompareTo(nuevaFigura.CalcularVolumen());
            }
            return 1;
        }
    }
}
