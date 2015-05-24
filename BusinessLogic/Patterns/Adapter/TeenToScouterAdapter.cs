using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class TeenToScouterAdapter : Scouter
    {
        #region Atributes

        private Teen teenInstance;

        #endregion

        #region Constructors

        public TeenToScouterAdapter(Teen t) : base(t.Name, t.Lastname, t.Gender, t.Address, t.City, t.Telephones, t.EmailAddresses,
            t.DocumentTypeID, t.Identification, t.GuardiansId, t.TeenMedicalHistory, new EducationHistory(), "")
        {
            teenInstance = t;
        }

        #endregion

    }
}
