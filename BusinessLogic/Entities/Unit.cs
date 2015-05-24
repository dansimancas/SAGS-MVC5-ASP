using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogic
{
    public class Unit
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
        public string Description { get; set; }

        [Required]
        public string SectionId { get; set; }

        #endregion

        #region Constructors

        public Unit(string name, string description, string sectionId)
        {
            this.Id = ++val;
            this.Name = name;
            this.Description = description;
            this.SectionId = sectionId;
        }

        #endregion

        #region Methods


        #endregion
    }
}
