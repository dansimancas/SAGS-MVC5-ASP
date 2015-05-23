using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class DocumentType
    {
        #region Atributes

        private int id;
        private string name;
   
        #endregion

        #region Properties

        public int Id
        {
            get { return id; }
            set { id = value; }
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
            this.name = "";
        }

        public DocumentType(string name)
        {
            this.name = name;
        }

        #endregion

        #region Overridden methods

        public override string ToString()
        {
            return "\nDocument type:\nId: " + this.id +
                "\nName: " + this.name;
        }

        #endregion
    }
}
