using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class DocumentTypeRepository
    {
        static List<DocumentType> documentTypeList = new List<DocumentType>();

        public void addDocumentType(DocumentType type)
        {
            documentTypeList.Add(type);
        }

        public IEnumerable<DocumentType> getDocumentTypeList()
        {
            return documentTypeList;
        }

        public bool contains(string name)
        {
            bool e = documentTypeList.Exists(x => x.Name == name);
            return e;
        }

        public string getDocumentTypeName(int id)
        {
            foreach (DocumentType doc in documentTypeList)
            {
                if (doc.Id == id) return doc.Name;
            }
            return "This document type has not been created yet.";
        }
    }
}
