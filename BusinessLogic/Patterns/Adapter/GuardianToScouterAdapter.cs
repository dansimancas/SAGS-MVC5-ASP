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
            : base(g.Name, g.Lastname, g.Gender, g.Address, g.City, g.Telephones, g.EmailAddresses,
            g.DocumentTypeID, g.Identification, null, new MedicalHistory(), new Education(), "")
        {
            guardianInstance = g;
        }


        #endregion

        #region Methods

        public override Education ScouterEducation
        {
            get { return this.ScouterEducation; }
            set { ScouterEducation = value; }
        }
        public override string WorkExperience
        {
            get { return WorkExperience; }
            set { WorkExperience = value; }
        }

        public override void addGuardian(string guardianId)
        {
            this.GuardiansId.Add(guardianId);
        }

        public override void setEducation(string level, string type, string obtainedTitle, string institution, int year, string city)
        {
            Education temp = new Education(level, type, obtainedTitle, institution, year, city);
        }

        public override void addWorkExperience(string ex)
        {
            WorkExperience = (WorkExperience == "") ? ex : ". " + ex;  
        }

        #endregion
    }
}
