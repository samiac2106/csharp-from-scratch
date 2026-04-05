namespace Helloworld
{
    class Program
    {
        static void Main()
        {
            
           DateOnly datecoverted= new DateOnly();
           string nameImput;
           string birthdayImput;
           Console.WriteLine("Hola, bienvenido al calculador de años");
           Console.WriteLine("Escribe tu nombre:  ");
           nameImput = Console.ReadLine();
           Console.WriteLine($"Es un gusto conocerte, {nameImput}");
           Console.WriteLine("Escribe tu fecha de nacimiento en formato (dd/mm/yyyy):  ");
           birthdayImput = Console.ReadLine();
           bool isDateValid = DateOnly.TryParse(birthdayImput, out datecoverted);
           if(isDateValid==false) Console.WriteLine($"La fecha de nacimiento es invalida, {birthdayImput}");
           else
           {
            Person person1 = new Person();
            person1.Name = nameImput;
            person1.BirthDate = datecoverted;
            person1.Age = DateTime.Now.Year - person1.BirthDate.Year;
            Console.WriteLine($"Tu edad es: {person1.Age} años");
           }
           Console.WriteLine();
        }
    }
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}