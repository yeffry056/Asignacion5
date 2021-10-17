using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion5
{
    public class cap12
    {
		public static void factorial()
        {
			int numero = 5, factorial = 1;
			if (numero >= 0)
			{
				for (int i = numero; i >= 2; i--)
				{

					factorial *= i;

				}

			}
		}
		
    }
}
