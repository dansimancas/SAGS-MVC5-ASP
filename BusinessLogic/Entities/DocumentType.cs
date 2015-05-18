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

            this.id = 0;
            this.name = "";
        }        

        #endregion
    }
}
