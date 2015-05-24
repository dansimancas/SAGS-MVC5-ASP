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
        public string Name { get; set; }

        [Required]
        public string InitialAge { get; set; }

        [Required]
        public string FinalAge { get; set; }

        [Required]
        [StringLength(200)]
        public string Observations { get; set; }

        #endregion

        #region Constructors

        public EducationalSection(string name, string initialAge, string finalAge, string observations)
        {
            this.Id = ++val;
            this.Name = name;
            this.InitialAge = initialAge;
            this.FinalAge = finalAge;
            this.Observations = observations;
        }

        #endregion

        #region Methods

        public void addObservation(string obs)
        {
            this.Observations = (this.Observations == "") ? obs : ". " + obs;
        }

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
