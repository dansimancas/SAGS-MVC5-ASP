using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogic
{
    [Table("Medical histories")]
    public class MedicalHistory
    {
        #region Atributes

        private int id;
        private static int val = 0;
        
        #endregion

        #region Properties

        [Key]
        public int Id
        {
            get { return id; }
            set { id = ++val; }
        }

        [Required]
        public int MemberId { get; set; }

        [Required]
        public List<string> Diseases { get; set; }

        [Required]
        public List<string> MedicineIntolerances { get; set; }

        [Required]
        public List<string> Allergies { get; set; }

        [Required]
        public List<string> MedicalInterventions { get; set; }

        [Required]
        [StringLength(200)]
        public string Observations { get; set; }

        #endregion

        #region Constructors

        public MedicalHistory()
        {
            this.Id = ++val;
            this.MemberId = 1234;
            this.Diseases = new List<string>();
            this.MedicineIntolerances = new List<string>();
            this.Allergies = new List<string>();
            this.MedicalInterventions = new List<string>();
            this.Observations = "";
        }

        public MedicalHistory(int memberId)
        {
            this.Id = ++val;
            this.MemberId = memberId;
            this.MedicineIntolerances = new List<string>();
            this.Diseases = new List<string>();
            this.MedicineIntolerances = new List<string>();
            this.Allergies = new List<string>();
            this.MedicalInterventions = new List<string>();
            this.Observations = "";
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
