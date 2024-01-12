namespace paternnDesingExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Ejemplo patron singleton 
            //Console.WriteLine($"Singleton {creacional_Singleton.getInstance.nombre}");
            //creacional_Singleton.getInstance.nombre = "Hola de nuevo";
            //Console.WriteLine($"Singleton {creacional_Singleton.getInstance.nombre}");
            //Console.Read();
            #endregion


            #region Ejemplo patron Prototype superficial 
            creacional_Prototype? prototype = new() { Nombre="Lolita" , Patas = 4};

            creacional_Prototype? prototypeClonado = prototype.Clone() as creacional_Prototype;
            prototypeClonado.Patas = 5;

            Console.WriteLine($"{prototype.Patas} paticas");

            Console.WriteLine($"{prototypeClonado.Patas} paticas");


            Console.Read();

            #endregion


        }
    }
}