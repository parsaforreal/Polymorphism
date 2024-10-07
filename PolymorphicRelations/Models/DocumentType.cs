using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PolymorphicRelations.Models
{
    public abstract class DocumentType
    {
        public int Id { get; set; }
        private string? name;
        public string Name
        {
            get => name ?? string.Empty;
            set => name = value;
        }
        public abstract string Get();
        public virtual ICollection<GenericDocument>? Documents { get; set; } 

    }
}
