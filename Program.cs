using System.ComponentModel.DataAnnotations;

internal class Program
{

    private static void Main(string[] args)
    {
        Atleta roger = new Atleta();
        roger.Greet();
        Dipendente francesco = new Dipendente();
        francesco.Greet();
        Animale ray = new Animale();
        ray.Greet();
        Veicolo punto = new Veicolo();
        punto.Greet();


    }

    class Atleta
    {
        public string name = "Roger";
        public string surname = "Federer";
        public int age = 42;
        public string sport = "Tennis";

        public void Greet()
        {
            Console.WriteLine("Hello, I am " + name + " " + surname + " I am " + age + " years old " + "and I played " + sport);
        }
    }

    class Dipendente
    {
        public string name = "Francesco";
        public string surname = "Caputo";

        public string role = "Full Stack Developer";

        public void Greet()
        {
            Console.WriteLine("Hello, I am " + name + " " + surname + " I am " + role);
        }
    }

    class Animale
    {
        public string type = "Dog";
        public string name = "Ray";
        public int age = 12;

        public void Greet()

        {
            Console.WriteLine("Hello, I am a " + type + " my name is " + name + " I am " + age + " years old");
        }
    }

    public class Veicolo
    {
        public string car = "Fiat Punto";

        public int speedMax = 180;

        public string weightMax = "1T";


        public void Greet()

        {
            Console.WriteLine("Hello, I am a " + car + " and my speed is " + speedMax + " and my weight is " + weightMax);
        }

    }

}