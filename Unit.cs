using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Unit
    {
        #region Atributes

        private string id;
        private string name;
        private string description;
        private string sectionId;
        
        #endregion

        #region Properties

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string SectionId
        {
            get { return sectionId; }
            set { sectionId = value; }
        }

        #endregion

        #region Constructors

        public Unit(string id, string name, string description, string sectionId)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.sectionId = sectionId;
        }

        #endregion

        #region Methods
        
        
        #endregion
    }
}
