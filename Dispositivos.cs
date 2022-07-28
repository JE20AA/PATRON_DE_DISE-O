using System;
namespace observador{
    public class Dispositivos{
        public int imei{get; set;}
        public string marca {get; set;}
        public string modelo {get; set; }
        public string sistema{get; set; }
        public string fabricacion{get; set; }
        public string hardware{get; set; }
        public string funcionalidad1{get; set; }
        public string funcionalidad2{get; set; }
        public string funcionalidad3{get; set; }

        public Dispositivos(int imei, string marca, string modelo, string sistema, string fabricacion, string hardware, string funcionalidad1, string funcionalidad2, string funcionalidad3  ){
            this.imei = imei;
            this.marca = marca;
            this.modelo = modelo;
            this.sistema = sistema;
            this.fabricacion = fabricacion;
            this.hardware = hardware;
            this.funcionalidad1 = funcionalidad1;
            this.funcionalidad2 = funcionalidad2;
            this.funcionalidad3 = funcionalidad3;
        }

        public void imprimir(){}

        public void funcionalidades(){}
    }
}