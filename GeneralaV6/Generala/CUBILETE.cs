using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generala
{
    public class CUBILETE
    {
        private List<DADO> listaDeDados = new List<DADO>();
        public List<DADO> ListaDeDados
        {
            get { return listaDeDados; }

        }

        public List<DADO> LanzarDados()
        {
            Random random = new Random();
            foreach (DADO dADO in ListaDeDados)
            {
                dADO.Valor = random.Next(1, 7);
            }
            return ListaDeDados;
        }
    }
}