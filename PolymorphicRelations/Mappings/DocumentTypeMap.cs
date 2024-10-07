using PolymorphicRelations.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
namespace PolymorphicRelations.Mappings
{
    public class DocumentTypeMap : EntityTypeConfiguration<DocumentType>
    {
        public DocumentTypeMap() 
        {
            HasKey(i => i.Id);
            ToTable("DocumentType");
            Property(i=> i.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
