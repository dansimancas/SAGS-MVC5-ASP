using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    class DocumentType
    {
        #region Atributes

        private int id;
        private string name;
        private static int val = 0;
   
        #endregion

        #region Properties

        public int Id
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
            this.id = ++val;
        }

        public DocumentType(string name)
        {
            this.id = ++val;
            this.name = name;
        }

        #endregion
    }
}
