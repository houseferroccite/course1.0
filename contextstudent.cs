namespace course1._0
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class contextstudent : DbContext
    {
        // Контекст настроен для использования строки подключения "contextstudent" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "course1._0.contextstudent" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "contextstudent" 
        // в файле конфигурации приложения.
        public contextstudent()
            : base("name=contextstudent")
        {

        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Student> Студенты { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}