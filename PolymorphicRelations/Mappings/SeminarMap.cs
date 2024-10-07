using PolymorphicRelations.Models;
using System.Data.Entity.ModelConfiguration;
namespace PolymorphicRelations.Mappings
{
    public class SeminarMap : EntityTypeConfiguration<Seminar>
    {
        public SeminarMap()
        {
            HasKey(i => i.Id);
            ToTable("Seminar");
            Property(i => i.Subject);
        }
    }
}
