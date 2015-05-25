using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogic
{
    [Table("Educational sections")]
    public class EducationalSection
    {
        #region Properties
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string InitialAge { get; set; }

        [Required]
        public string FinalAge { get; set; }

        [Required]
        [StringLength(200)]
        public string Observations { get; set; }

        #endregion

        #region Overridden methods

        public override string ToString()
        {
            return "\nEducational section: \nId: " + this.Id +
                "\nName: " + this.Name +
                "\nInitial age: " + this.InitialAge +
                "\nFinal age: " + this.FinalAge +
                "\nObservations: " + this.Observations;
        }

        #endregion
    }
}
