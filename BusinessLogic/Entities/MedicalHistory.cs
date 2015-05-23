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
        private static int val = 0;
        
        #endregion

        #region Properties

        public int Id { 
            get { return id; }
        }

        public List<string> Diseases
        {
            get { return diseases; }
            set { diseases = value; }
        }

        public List<string> MedicineIntolerances
        {
            get { return medicineIntolerances; }
            set { medicineIntolerances = value; }
        }

        public List<string> Allergies
        {
            get { return allergies; }
            set { allergies = value; }
        }

        public List<string> MedicalInterventions
        {
            get { return medicalInterventions; }
            set { medicalInterventions = value; }
        }

        public string Observations
        {
            get { return observations; }
            set { observations = value; }
        }

        public int MemberId
        {
            get { return memberId; }
        }

        #endregion

        #region Constructors

        public MedicalHistory()
        {
            this.id = ++val;
            this.memberId = 1234;
            this.diseases = new List<string>();
            this.medicineIntolerances = new List<string>();
            this.allergies = new List<string>();
            this.medicalInterventions = new List<string>();
            this.observations = "";
        }

        public MedicalHistory(int memberId)
        {
            this.id = ++val;
            this.memberId = memberId;
            this.medicineIntolerances = new List<string>();
            this.diseases = new List<string>();
            this.medicineIntolerances = new List<string>();
            this.allergies = new List<string>();
            this.medicalInterventions = new List<string>();
            this.observations = "";
        }

        #endregion

        #region Methods

        public void addDisease(string disease)
        {
            if (Diseases != null)
            {
                this.Diseases.Add(disease);
            }
            else
            {
                this.Diseases = new List<string>();
                this.Diseases.Add(disease);
            }
            
        }

        public void addMedicineIntolerance(string medicine)
        {
            if (this.MedicineIntolerances != null)
            {
                this.MedicineIntolerances.Add(medicine);
            }
            else
            {
                this.MedicineIntolerances = new List<string>();
                this.MedicineIntolerances.Add(medicine);
            }
            
        }

        public void addAllergie(string allergie)
        {
            if (this.Allergies != null)
            {
                this.Allergies.Add(allergie);
            }
            else
            {
                this.Allergies = new List<string>();
                this.Allergies.Add(allergie);
            }
            
        }

        public void addMedicalIntervention(string intervention)
        {
            if (this.MedicalInterventions != null)
            {
                this.MedicalInterventions.Add(intervention);
            }
            else
            {
                this.MedicalInterventions = new List<string>();
                this.MedicalInterventions.Add(intervention);
            }
            
        }

        public void setObservations(string obs)
        {
            this.Observations = obs;
        }

        public void addObservations(string obs)
        {
            this.Observations = (this.Observations == "") ? obs : ". " + obs;
        }

        protected string printStringList(List<string> mylist)
        {
            if (mylist != null && mylist.Count > 0)
            {
                string value = "";
                foreach (string s in mylist)
                {
                    value += s + ", ";
                }
                return value.Substring(0, value.Length - 2);
            }
            else return "There are no elements asigned yet.";
        }

        #endregion

        #region Overridden methods

        public override string ToString()
        {
            return "\nMedical history:\nId: " + this.Id +
                "\nMember id: " + this.MemberId +
                "\nDiseases: " + printStringList(this.Diseases) +
                "\nMedicine intolerances: " + printStringList(this.MedicineIntolerances) +
                "\nAllergies: " + printStringList(this.Allergies) +
                "\nMedical interventions: " + printStringList(this.MedicalInterventions) +
                "\nObservations: " + this.Observations;
        }
        
        #endregion
    }
}
