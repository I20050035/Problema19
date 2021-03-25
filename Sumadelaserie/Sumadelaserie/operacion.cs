using System;
using System.Collections.Generic;
using System.Text;

namespace Sumadelaserie
{

    class operacion
    {
        // declaracion de propiedad
        private int numero;

        public int Numero
        { get => numero; 
          set => numero = value;
        }

        public void op(int _numero)
        {
            double resultado = 0;

            for (int i = 1; i <= _numero; i++)
            {
                resultado = resultado + (1 / i);

                
            }
            
        }

    }
}
