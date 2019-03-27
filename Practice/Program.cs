using Practice.HR;

namespace Practice
{
    /// <summary>
    ///     Цели работы:
    ///     1. на практике познакомиться с механизмом наследования;
    ///     2. научиться использовать полиморфизм;
    ///     3. научиться разделять контексты;
    ///     4. научиться использовать инкапсуляцию на уровне библиотеки;
    ///     5. научиться использовать абстрактные типы данных.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IClient client = Builders.ClientBuilder()
                .Name("Иванов", "Иван", "Иванович") 
                .Discount(.1f)
                .Build();

            IEmployee employee = Builders.EmployeeBuilder()
                .Name("Сидоров", "Григорий", "Петрович")
                .Department("Бухгалтерия")
                .Build();

            /*
             * TODO #8: Собрать приложение. 👌
             */

            /*
             * TODO #9: При помощи отладчика проверить типы и структуру объектов, адресованных переменными client и employee.
             */

             /*
                Структура и типы объектов:

                client {Practice.HR.Client}
                  .Discount: 0.1 {float}
                  .Name {Practice.Common.Name}
                    .FirstName:  "Иван"                 {string}
                    .FullName:   "Иванов Иван Иванович" {string}
                    .Patronymic: "Иванович"             {string}
                    .ShortName:  "И.И.Иванов"           {string}
                    .Surname:    "Иванов"               {string}

                employee {Practice.HR.Employee}
                  .Department {Practice.Organization.Department}
                    .Name: "Бухгалтерия" {string}
                  .Name {Practice.Common.Name}
                    .FirstName:  "Григорий"                  {string}
                    .FullName:   "Сидоров Григорий Петрович" {string}
                    .Patronymic: "Петрович"                  {string}
                    .ShortName:  "С.Г.Сидоров"               {string}
                    .Surname:    "Сидоров"                   {string}
             */
        }
    }
}
