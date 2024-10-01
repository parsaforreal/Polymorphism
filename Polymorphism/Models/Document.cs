using Polymorphism.enums;
using Polymorphism.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class Document
    {
        public Document(int id, string title, string aBstract, DocumentType type, DocumentDetail detail)
        {
            Id = id;
            Title = title;
            Abstract = aBstract;
            DocumentType = type;
            Detail = detail;
        }
        [Key]
        public int Id { get; set; }       
        public string? Title { get; set; }
        public string? Abstract { get; set; }
        public DocumentType DocumentType { get; set; }
        public DocumentDetail? Detail { get; set; }

    }
}
