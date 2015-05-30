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
        #region Properties

        [Key]
        public int Id { get; set; }

        [Required]
        public int MemberId { get; set; }

        [Required]
        public string Diseases { get; set; }

        [Required]
        public string MedicineIntolerances { get; set; }

        [Required]
        public string Allergies { get; set; }

        [Required]
        public string MedicalInterventions { get; set; }

        [Required]
        [StringLength(200)]
        public string Observations { get; set; }

        #endregion

        #region Methods

        #endregion

        #region Overridden methods

        public override string ToString()
        {
<<<<<<< HEAD
            return "\nMedical history:\nId: " + this.id +
                "\nMember id: " + this.memberId +
                "\nDiseases: " + printStringList(this.diseases) +
                "\nMedicine intolerances: " + printStringList(this.medicineIntolerances) +
                "\nAllergies: " + printStringList(this.allergies) +
                "\nMedical interventions: " + printStringList(this.medicalInterventions) +
                "\nObservations: " + this.observations;
=======
            return "\nMedical history:\nId: " + this.Id +
                "\nMember id: " + this.MemberId +
                "\nDiseases: " + this.Diseases +
                "\nMedicine intolerances: " + this.MedicineIntolerances +
                "\nAllergies: " + this.Allergies +
                "\nMedical interventions: " + this.MedicalInterventions +
                "\nObservations: " + this.Observations;
>>>>>>> 3921ed54cdf0fbe670a3eb656a1286ea6ea2b493
        }
        
        #endregion
    }
}
