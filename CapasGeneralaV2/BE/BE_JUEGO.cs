using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_JUEGO
    {
        private List<BE_DADO> dADOs = new List<BE_DADO>();
        public List<BE_DADO> ListaDeDados
        {
            get { return dADOs; }
        }

        public BE_JUEGO()
        {
            for (int i = 0; i < 5; i++)
            {
                BE_DADO dADO = new BE_DADO();
                dADOs.Add(dADO);
            }
        }
    }
}
