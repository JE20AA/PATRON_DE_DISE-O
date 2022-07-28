using System;
namespace observador  {
    class Program{
            
        public static void main(string[] args){
            Celular celular = new Celular(00000,"huawei", "y221", "android", "japon","cargador","pantalla", "reproductor de musica", "camara de fotos");
            Tablet tablet = new Tablet(05648420,"Samsung", "y221", "android", "japon","cargador","pantalla", "reproductor de musica", "camara de fotos");
            Cliente cliente = new Cliente("Mario Guerrero", "Tablet", "camara");
            Cliente cliente2 = new Cliente("Mario Guerrero", "Tablet", "pantalla");
            
            List<Cliente> lista3 = new List<Cliente>();
            lista3.Add(cliente);
            lista3.Add(cliente2);

            foreach(Cliente lista4 in lista3){
                lista4.ordenReparacion();
            }



            List<Dispositivos> lista1 = new List<Dispositivos>();
            lista1.Add(celular);
            lista1.Add(tablet);

            foreach(Dispositivos lista2 in lista1){
                lista2.imprimir();
                lista2.funcionalidades();
            }

            foreach(Ichip lista5 in lista1){
                lista5.mostrarChip();
            }
        }
    }
}
