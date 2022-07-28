using System;
namespace observador{
    public class Cliente{
        public string nombre{get; set;}
        public string dispositivo2{get; set;}
        public string funcionalidadr{get; set;}

        public Cliente(string nombre, string dispositivo2, string funcionalidadr){
            this.nombre = nombre;
            this.dispositivo2 = dispositivo2;
            this.funcionalidadr = funcionalidadr;
        }

        public void ordenReparacion(){
            Console.WriteLine("nombre del cliente: "+nombre);
            Console.WriteLine("dispositivo a reparar: "+dispositivo2);
            Console.WriteLine("funcionalidad a reparar: "+funcionalidadr);
        }
    }
}