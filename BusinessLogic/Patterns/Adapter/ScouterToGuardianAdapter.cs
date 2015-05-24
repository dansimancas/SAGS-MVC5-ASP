using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class ScouterToGuardianAdapter : Guardian
    {
        #region Atributes

        private Scouter scouterInstance;

        #endregion

        #region Constructors

        public ScouterToGuardianAdapter(Scouter s) : base(s.Name, s.Lastname, s.Gender, s.Address, s.City, s.Telephones, s.EmailAddresses,
            s.Document, s.Identification)
        {
            scouterInstance = s;
        }

        #endregion
    }
}
