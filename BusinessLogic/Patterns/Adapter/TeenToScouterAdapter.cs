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

        public TeenToScouterAdapter(Teen t) : base(t.Name, t.Lastname, t.Gender, t.Address, t.City, t.Telephones,
            t.DocumentTypeID, t.Identification, t.GuardiansId, t.MedicalHistoryId, new Education(), "")
        {
            teenInstance = t;
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

        public override void addTelephone(long t)
        {
            Telephones.Add(t);
        }

        #endregion

    }
}
