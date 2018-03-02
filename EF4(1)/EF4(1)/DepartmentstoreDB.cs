namespace EF4_1_
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using EF4_1_.Configurations;
    public class DepartmentstoreDB : DbContext
    {
        // Контекст настроен для использования строки подключения "DepartmentstoreDB" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "EF4_1_.DepartmentstoreDB" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "DepartmentstoreDB" 
        // в файле конфигурации приложения.
        public DepartmentstoreDB()
            : base("name=DepartmentstoreDB")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Departmantstore> departmets { get; set; }
        public virtual DbSet<Product> products { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new DepartmentStoreConfig());
            modelBuilder.Configurations.Add(new ProductsConfig());
        }
    }
    
}