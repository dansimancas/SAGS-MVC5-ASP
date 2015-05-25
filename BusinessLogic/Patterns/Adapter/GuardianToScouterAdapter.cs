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

        private Guardian guardianInstance;

        #endregion

        #region Constructors

        public GuardianToScouterAdapter(Guardian g)
        {
            guardianInstance = g;
            base.Name = g.Name;
            base.Lastname = g.Lastname;
            base.Gender = g.Gender;
            base.Address = g.Address;
            base.City = g.City;
            base.Telephones = g.Telephones;
            base.EmailAddresses = g.EmailAddresses;
            base.Document = g.Document;
            base.Identification = g.Identification;
            base.GuardiansId = new List<string>();
            base.ScouterMedicalHistory = new MedicalHistory();
            base.ScouterEducation = new EducationHistory();
            base.WorkExperience = "";
        }


        #endregion
    }
}
