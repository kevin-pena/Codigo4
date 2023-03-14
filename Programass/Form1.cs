namespace kevin
{
    //Clase base
    public class Animal
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public void Comer()
        {
            Console.WriteLine("Estoy comiendo");
        }
    }

    //Clase derivada
    public class Perro : Animal
    {
        public void Ladrar()
        {
            Console.WriteLine("Guau guau!");
        }
    }

    //Código principal
    static void Main(string[] args)
    {
        //Instanciando la clase derivada
        Perro miPerro = new Perro();

        //Asignando valores a las propiedades heredadas de la clase base
        miPerro.Nombre = "Firulais";
        miPerro.Edad = 5;

        //Llamando al método de la clase base
        miPerro.Comer();

        //Llamando al método de la clase derivada
        miPerro.Ladrar();
    }

}
