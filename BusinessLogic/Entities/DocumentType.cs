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

        public int Val
        {
            get { return val; }
        }

        #endregion

        #region Constructors

        public DocumentType()
        {
            this.id = ++val;
            this.name = "";
        }

        public DocumentType(string name)
        {
            this.id = ++val;
            this.name = name;
        }

        #endregion

        #region Overwritten constructors

        public override string ToString()
        {
            return "\nDocument type:\nId: " + this.id +
                "\nName: " + this.name;
        }

        #endregion
    }
}
