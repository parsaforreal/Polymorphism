using PolymorphicRelations.Models;
using System.Data.Entity.ModelConfiguration;
namespace PolymorphicRelations.Mappings
{
    public class ThesisMap : EntityTypeConfiguration<Thesis>
    {
        public ThesisMap()
        {
            HasKey(i => i.Id);
            ToTable("Thesis");
            Property(i => i.Text);
        }
    }
}
