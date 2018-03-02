﻿namespace ConsoleApplication2
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MyModel : DbContext
    {
        // Контекст настроен для использования строки подключения "MyModel" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "ConsoleApplication2.MyModel" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "MyModel" 
        // в файле конфигурации приложения.
        public MyModel()
            : base("name=MyModel")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Person> PersonsInfo { get; set; }
    }

    public class Person
    {
        public int A { get; set; }
        public string B { get; set; }
    }
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}