using PolymorphicRelations.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
namespace PolymorphicRelations.Mappings
{
    public class GenericDocumentMap : EntityTypeConfiguration<GenericDocument>
    {
        public GenericDocumentMap()
        {
            HasKey(i => i.Id);
            ToTable("GenericDocument");
            Property(i => i.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(i => i.DocumentTypeId);
            Property(i => i.DocumentName);
            HasRequired(i=> i.DocumentType)
                .WithMany(i=> i.Documents)
                .HasForeignKey(i=>i.DocumentTypeId);
        }
    }
}
