namespace EF5
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BuildDB : DbContext
    {
        // Контекст настроен для использования строки подключения "BuildDB" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "EF5.BuildDB" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "BuildDB" 
        // в файле конфигурации приложения.
        public BuildDB()
            : base("name=BuildDB")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Building> Buildings { get; set; }
         public virtual DbSet<House> Houses { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}