namespace EF3_1_
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class FacultDB : DbContext
    {
        // Контекст настроен для использования строки подключения "FacultDB" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "EF3_1_.FacultDB" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "FacultDB" 
        // в файле конфигурации приложения.
        public FacultDB()
            : base("name=FacultDB")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Faculty> FacultyTable { get; set; }
         public virtual DbSet<Person> StudentTable { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}