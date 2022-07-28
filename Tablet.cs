using System;
namespace observador {
        public class Tablet:Dispositivos{
        public Tablet(int imei, string marca, string modelo, string sistema, string fabricacion, string hardware, string funcionalidad1, string funcionalidad2, string funcionalidad3):base(imei, marca,  modelo, sistema, fabricacion, hardware, funcionalidad1, funcionalidad2, funcionalidad3){}

        public void imprimir(){
            Console.WriteLine("-----------------");
            Console.WriteLine("Dispositivo a reparar:");
            Console.WriteLine("------------------");
            Console.WriteLine("marca: "+marca);
            Console.WriteLine("modelo: "+modelo);
            Console.WriteLine("imei: "+imei);
            Console.WriteLine("sistema operativo: "+sistema);
            Console.WriteLine("hardware adicional: "+hardware);
            Console.WriteLine("------------------");
        }

        public void funcionalidades(){
            Console.WriteLine("------------");
            Console.WriteLine("Funcionalidades: ");
            Console.WriteLine("1. "+funcionalidad1);
            Console.WriteLine("2. "+funcionalidad2);
            Console.WriteLine("3. "+funcionalidad3);
        }

        public void mostrarChip(){
            Console.WriteLine("chip: si");
        }
    }
}