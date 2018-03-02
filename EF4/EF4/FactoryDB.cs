namespace EF4
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class FactoryDB : DbContext
    {
        // Контекст настроен для использования строки подключения "FactoryDB" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "EF4.FactoryDB" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "FactoryDB" 
        // в файле конфигурации приложения.
        public FactoryDB()
            : base("name=FactoryDB")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Factory> factories { get; set; }
        public virtual DbSet<Person> persons { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}