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

        // Teen teenInstance;

        #endregion

        #region Constructors

        public TeenToScouterAdapter()
        {

        }

        public TeenToScouterAdapter(Teen t)
        {
           // teenInstance = t;
            Name = t.Name;
            Lastname = t.Lastname;
            GenderMember = t.GenderMember;
            Address = t.Address;
            City = t.City;
            Telephones = t.Telephones;
            EmailAddresses = t.EmailAddresses;
            Document = t.Document;
            Identification = t.Identification;
            GuardiansId = t.GuardiansId;
            ScouterMedicalHistory = t.TeenMedicalHistory;
            ScouterEducation = new EducationHistory();
            WorkExperience = "No experience";
        }


        #endregion
    }
}
