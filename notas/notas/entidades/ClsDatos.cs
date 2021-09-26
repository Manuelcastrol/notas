using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notas.entidades
{
    class ClsDatos
    {

        private double labo1;
        private double labo2;
        private double labo3;
        private double parc1;
        private double parc2;
        private double parc3;
        private double per1;
        private double per2;
        private double per3;
        private double final;

        public double Labo1 { get => labo1; set => labo1 = value; }
        public double Labo2 { get => labo2; set => labo2 = value; }
        public double Labo3 { get => labo3; set => labo3 = value; }
        public double Parc1 { get => parc1; set => parc1 = value; }
        public double Parc2 { get => parc2; set => parc2 = value; }
        public double Parc3 { get => parc3; set => parc3 = value; }
        public double Per1 { get => per1; set => per1 = value; }
        public double Per2 { get => per2; set => per2 = value; }
        public double Per3 { get => per3; set => per3 = value; }
        public double Final { get => final; set => final = value; }
    }
}
