using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_V_2
{
    public class Modelo
    {
        public int num_Registro { get; set; }
        public int capacidad { get; set; }
        public double peso { get; set; }

        public Modelo() { }

        public Modelo(int Pnum_Regitro, int Pcapacidad, double Ppeso) {
            this.num_Registro = Pnum_Regitro;
            this.capacidad = Pcapacidad;
            this.peso = Ppeso;
        }
    }
}
