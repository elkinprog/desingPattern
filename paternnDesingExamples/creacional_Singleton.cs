namespace paternnDesingExamples
{
    public  class creacional_Singleton                          // para crear una instancia de la clase : cuando se crea ya no se crea otra instancia 
    {                                                           // singleton funciona con una instancia interna de si misma
                                                                // implementaciones singleton son:  ansioso, peresoza, segura para subprocesos

        private static creacional_Singleton? instance = null;   // Una variable estática, que contiene la única instancia de la clase

        private   creacional_Singleton(){ }                     // Un constructor privado, para que así no se pueda instanciar en ningún otro lado

        public string nombre = "Hola singleton";
       
        public static creacional_Singleton getInstance          // Un método publico estático, para retornar la única instancia de la clase.
        {
            get
            {
                if (instance== null)
                {
                    instance = new creacional_Singleton();
                }
                return instance;
            }
        }

    }
}
