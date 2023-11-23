using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generala
{
    public class JUEGO
    {
        private List<DADO> dADOs = new List<DADO>();
        public List<DADO> ListaDeDados
        {
            get { return dADOs; }
        }

        public JUEGO()
        {
            for (int i = 0; i < 5; i++)
            {
                DADO dADO = new DADO();
                dADOs.Add(dADO);
            }
        }
    }
}