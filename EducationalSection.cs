using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class EducationalSection
    {
        #region Atributes

        private string id;
        private string name;
        private string initialAge;
        private string finalAge;
        private string observations;

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
        public string InitialAge
        {
          get { return initialAge; }
          set { initialAge = value; }
        }
        public string FinalAge
        {
          get { return finalAge; }
          set { finalAge = value; }
        }
        public string Observations
        {
          get { return observations; }
          set { observations = value; }
        }

        #endregion

        #region Constructors

        public EducationalSection(string id, string name, string initialAge, string finalAge, string observations)
        {
            this.id = id;
            this.name = name;
            this.initialAge = initialAge;
            this.finalAge = finalAge;
            this.observations = observations;
        }

        #endregion

        #region Methods
        
        
        #endregion
    }
}
