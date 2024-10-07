using System.ComponentModel.DataAnnotations;

namespace Polymorphism.Models
{
    public class Document
    {
        public Document(int id, string title, string aBstract, object details)
        {
            Id = id;
            Title = title;
            Abstract = aBstract;
            Details = details;
        }
        [Key]
        public int Id { get; set; }       
        public string? Title { get; set; }
        public string? Abstract { get; set; }
        public object? Details { get; set; }

    }
}
