using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class TeenToScouterAdapter : Scouter
    {
        #region Atributes

        private Teen teenInstance;

        #endregion

        #region Constructors

        public TeenToScouterAdapter(Teen t)
        {
            teenInstance = t;
        }

        #endregion

        #region Methods



        #endregion

    }
}
