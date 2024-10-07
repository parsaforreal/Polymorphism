using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicRelations.Models
{
    public class GenericDocument
    {
        // this is a gitlab comment!
        public int Id { get; set; }
        public int DocumentTypeId { get; set; }
        public string DocumentName { get; set; } = string.Empty;
        public virtual required DocumentType DocumentType { get; set; }
        public string Get()
        {
            return DocumentType.Get();
        }
    }
}
