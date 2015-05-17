using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    class DocumentType
    {
        #region Atributes

        private string id;
        private string name;
   
        #endregion

        #region Properties

        public string Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        #endregion

        #region Constructors

        public DocumentType()
        {
            this.id = Guid.NewGuid().ToString();
        }

        public DocumentType(string name)
        {
            this.id = Guid.NewGuid().ToString();
            this.name = name;
        }

        #endregion
    }
}
