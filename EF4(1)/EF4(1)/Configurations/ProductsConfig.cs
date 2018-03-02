using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EF4_1_.Configurations
{
  public  class ProductsConfig:EntityTypeConfiguration<Product>
    {
        public ProductsConfig()
        {
            ToTable("ProductsInfo");
            HasKey(f=>f.Name);
            Property(f=>f.Name).HasMaxLength(20).IsRequired();
        }
    }
}
