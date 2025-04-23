using System;
using System.Collections.Generic;

namespace Tp
{
    class Program
    {

        static Random random = new Random();
        
        static void Main(string[] args)
        {
            /*Ejercicio 9
            Pila p = new Pila();
            Llenar(p,2);
            Informar(p,2);*/
            
            Profesor profesor = (Profesor)FabricaDeComparables.CrearAleatorio(3);
            for (int i = 0; i < 20; i++){
            	IObservador alumno = (IObservador)FabricaDeComparables.CrearAleatorio(2);
            	profesor.agregarObservador(alumno);
            }
            dictadoDeClases(profesor);

            Console.ReadKey(true);
        }
        static void Llenar(Coleccionable c, int opcion)
        {
            for (int i = 0; i < 20; i++)
            {
            	Comparable com = FabricaDeComparables.CrearAleatorio(opcion);
                c.Agregar(com);
            }
        }
        
        static int GenerarNumRandom(int min, int max){
        	return random.Next(min, max + 1);
        }
        
        static void Informar(Coleccionable c, int opcion){
        	
        	Console.WriteLine("Cantidad de elementos: " + c.Cuantos());
        	Console.WriteLine("Minimo: " + c.Minimo().ToString());
        	Console.WriteLine("Maximo: " + c.Maximo().ToString());
        	Comparable com = FabricaDeComparables.CrearPorTeclado(opcion);
        	if(c.Contiene(com)){
        		Console.WriteLine("El elemento leído está en la colección");
        	}
        	else
        		Console.WriteLine("El elemento leído no está en la colección");
        }
        
        static string GenerarNombreRandom()
        {
            List<string> nombres = new List<string>
            {
                "Mateo", "Martina", "Juan", "Sofía", "Santiago",
                "Valentina", "Tomás", "Delfina", "Facundo", "Lucía",
                "Agustín", "Emilia", "Benjamín", "Camila", "Joaquín",
                "Julieta", "Bautista", "Milagros", "Franco", "Antonella"
            };

            return nombres[random.Next(0, 20)];
        }
        
        static void ImprimirElementos(Iterable c){
        	IteradorDeLista ite = c.CrearIterador();
        	while(!ite.Fin()){
        		Console.WriteLine(ite.Actual().ToString());
        		ite.Siguiente();
        	}
        }
        
        static void CambiarEstrategia(Iterable c, EstrategiaComparacion es){
        	IteradorDeLista ite = c.CrearIterador();
        	while(!ite.Fin()){
        		((Alumno)ite.Actual()).SetEstrategia(es);
        		ite.Siguiente();
        	}
        }
        
        public static void dictadoDeClases(Profesor p){
        	for (int i = 0; i < 5; i++){
        		p.hablarALaClase();
        		Console.WriteLine("");
        		p.escribirEnElPizarron();
        		Console.WriteLine("");
        	}
        }
    }
}
