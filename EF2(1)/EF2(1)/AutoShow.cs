namespace EF2_1_
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AutoShow : DbContext
    {
        // Контекст настроен для использования строки подключения "AutoShow" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "EF2_1_.AutoShow" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "AutoShow" 
        // в файле конфигурации приложения.
        public AutoShow()
            : base("name=AutoShow")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Car> CarTable { get; set; }
        public virtual DbSet<Order> OrderTable { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}