using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EF4_1_.Configurations
{
  public  class DepartmentStoreConfig: EntityTypeConfiguration<Departmantstore>
    {
        public DepartmentStoreConfig()
        {
            ToTable("DepartmentInfo");
            HasKey(r => r.Name);
            Property(f => f.Name).HasMaxLength(20).IsRequired();
        }
        

    }
}
