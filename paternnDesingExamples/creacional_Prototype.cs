namespace paternnDesingExamples
{
    public class creacional_Prototype:ICloneable               // patron de diseño creacional  prototype es cuando se crea el objeto clonacion superficial
    {                                                          // sirve para clonar un objeto  
        public  int      Patas      { get; set; }
        public  string?  Nombre     { get; set; }
        public detalles? Rasgos     { get; set; }

        public object Clone()
        {

            return this.MemberwiseClone();
        }
    }
     
    public class detalles                                     // patron de diseño creacional prototype es cuando se crea el objeto clonacion deep profundo
    {
        public string? color{ get; set; }
        public string? raza { get; set; }
    }
}

