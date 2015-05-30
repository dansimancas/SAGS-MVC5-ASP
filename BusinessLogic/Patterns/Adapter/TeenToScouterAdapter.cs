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

        public TeenToScouterAdapter()
        {

        }

        public TeenToScouterAdapter(Teen t)
        {
           // teenInstance = t;
            base.Name = t.Name;
            base.Lastname = t.Lastname;
            base.GenderMember = t.GenderMember;
            base.Address = t.Address;
            base.City = t.City;
            base.Telephones = t.Telephones;
            base.EmailAddresses = t.EmailAddresses;
            base.Document = t.Document;
            base.Identification = t.Identification;
            base.GuardiansId = t.GuardiansId;
            base.ScouterMedicalHistory = t.TeenMedicalHistory;
            base.ScouterEducation = new EducationHistory();
            base.WorkExperience = "No experience";
        }


        #endregion
    }
}
