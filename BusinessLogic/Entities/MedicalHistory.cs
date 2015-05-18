using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class MedicalHistory
    {
        #region Atributes

        private int id;
        private List<string> diseases;
        private List<string> medicineIntolerances;
        private List<string> allergies;
        private List<string> medicalInterventions;
        private string observations;
        private int memberId;
        
        #endregion

        #region Properties

        public int Id { get; set; }
        public List<string> Diseases { get; set; }
        public List<string> MedicineIntolerances { get; set; }
        public List<string> Alergies { get; set; }
        public List<string> MedicalInterventions { get; set; }
        public string Observations { get; set; }
        public int MemberId { get; set; }

        #endregion

        #region Constructors

        public MedicalHistory(int id, int memberId)
        {
            this.id = id;
            this.memberId = memberId;
            this.medicineIntolerances = new List<string>();
            this.diseases = new List<string>();
            this.medicalInterventions = new List<string>();
            this.allergies = new List<string>();
            this.medicalInterventions = new List<string>();
            this.observations = "";
        }

        #endregion

        #region Methods

        public void addDisease(string disease)
        {
            this.diseases.Add(disease);
        }

        public void addMedicineIntolerance(string medicine)
        {
            this.medicineIntolerances.Add(medicine);
        }

        public void addAllergie(string allergie)
        {
            this.allergies.Add(allergie);
        }

        public void addMedicalIntervention(string intervention)
        {
            this.medicalInterventions.Add(intervention);
        }

        public void setObservations(string obs)
        {
            this.observations = obs;
        }

        public void addObservations(string obs)
        {
            this.observations += " " + obs;
        }

        #endregion
    }
}
