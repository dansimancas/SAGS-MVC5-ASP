using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class DocumentType
    {
        #region Atributes
<<<<<<< HEAD

=======
        
>>>>>>> origin/master
        private int id;
        private string name;
        private static int val = 0;
   
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
<<<<<<< HEAD
            this.id = ++val;
        }

        public DocumentType(string name)
        {
            this.id = ++val;
            this.name = name;
        }
=======

            this.id = 0;
            this.name = "";
        }        
>>>>>>> origin/master

        #endregion
    }
}
