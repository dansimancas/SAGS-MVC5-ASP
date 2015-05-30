using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class GuardianToScouterAdapter : Scouter
    {
        #region Atributes

        //private Guardian guardianInstance;

        #endregion

        #region Constructors

        public GuardianToScouterAdapter()
        {

        }

        public GuardianToScouterAdapter(Guardian g)
        {
           // guardianInstance = g;
            Name = g.Name;
            Lastname = g.Lastname;
            GenderMember = g.GenderMember;
            Address = g.Address;
            City = g.City;
            Telephones = g.Telephones;
            EmailAddresses = g.EmailAddresses;
            Document = g.Document;
            Identification = g.Identification;
            GuardiansId = new List<string>();
            ScouterMedicalHistory = new MedicalHistory();
            ScouterEducation = new EducationHistory();
            WorkExperience = "No experience ";
        }


        #endregion
    }
}
