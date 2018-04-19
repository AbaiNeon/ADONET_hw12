namespace hw_12
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {
        // Контекст настроен для использования строки подключения "Context" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "hw_12.Context" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "Context" 
        // в файле конфигурации приложения.
        public Context()
            : base("name=Context")
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Car> Cars { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}