using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serpintes_y_escaleras
{
    class jugador : dado
    {
        protected int posicion;
        protected int num_jug;

        public jugador(int numero)
        {
            num_jug = numero;
            posicion = 0;
        }

        public int avanzar(int rand)
        {
            posicion = posicion + rand;

            if (posicion == 15) //E
                posicion += 10;
            else if (posicion == 24) //S
                posicion -= 10;
            else if (posicion == 56) //E
                posicion += 10;
            else if (posicion == 11) //S
                posicion -= 7;
            else if (posicion == 63) //E
                posicion += 15;
            else if (posicion == 18) //S
                posicion -= 8;
            else if (posicion == 20) //E
                posicion += 10;
            else if (posicion == 40) //S
                posicion -= 30;
            else if (posicion == 78) //E
                posicion += 10;
            else if (posicion == 91) //S
                posicion -= 30;
            else if (posicion == 13) //E
                posicion += 21;
            else if (posicion == 19) //S
                posicion -= 18;
            else if (posicion == 81) //E
                posicion += 10;
            else if (posicion == 33) //S
                posicion -= 10;
            else if (posicion == 77) //E
                posicion += 10; 
            else if (posicion == 99) //S
                posicion -= 98;

            return posicion;
        }

    }
}
