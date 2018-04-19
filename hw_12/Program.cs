using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_12
{
    class Program
    {
        static void Main(string[] args)
        {
            using(Context context = new Context())
            {
                Person person1 = new Person() { Id = 1, Name = "AAA",Age=11 };
                context.Persons.Add(person1);
                
                Car car1 = new Car() { Id = 1, Name = "BMW" };
                context.Cars.Add(car1);

                context.SaveChanges();
            }
        }
    }
}
