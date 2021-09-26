using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notas.negocio
{
    class NClsnotas
    {

        public string calculo(entidades.ClsDatos datos)
        {
            datos.Per1 = datos.Labo1 * 0.40 + datos.Parc1 * 0.60;
            datos.Per2 = datos.Labo2 * 0.40 + datos.Parc2 * 0.60;
            datos.Per3 = datos.Labo3 * 0.40 + datos.Parc3 * 0.60;
            datos.Final = (datos.Per1 + datos.Per2 + datos.Per3) / 3;
            datos.Final = Convert.ToDouble(datos.Final);
            return ("periodo 1: " + datos.Per1 + "\nperiodo 2: " + datos.Per2 + "\nperiodo 3: " + datos.Per3 + "\n!su nota final de ciclo es: " + datos.Final + "¡");

        }




    }

}
