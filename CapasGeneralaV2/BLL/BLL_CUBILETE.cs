using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_CUBILETE
    {
        public void LanzarDados(BE.BE_CUBILETE cubilete)
        {
            Random random = new Random();
            foreach (BE.BE_DADO dADO in cubilete.ListaDeDados)
            {
                dADO.Valor = random.Next(1, 7);
            }
        }
    }
}
