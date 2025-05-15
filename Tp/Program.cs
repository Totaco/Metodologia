using System;
using System.Collections.Generic;

namespace Tp
{
    class Program
    {

        static Random random = new Random();
        
        static void Main(string[] args)
        {
            //Ejercicio 2
            /*Teacher t = new Teacher();
            for(int i = 0; i < 20; i++){
            	
            	IComparable estudiante = FabricaDeComparables.CrearAleatorio(5);
            	t.goToClass(new AlumnoAdapter((IAlumno)estudiante));
        	}
        	t.teachingAClass();*/
            
            //Ejercicio 10
            Pila pila = new Pila();
            Aula aula = new Aula();
            pila.SetOrdenInicio(new OrdenInicio(aula));
            pila.SetOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
            pila.SetOrdenAulaLlena(new OrdenAulaLlena(aula));
            Llenar(pila, 2);
            Llenar(pila, 3);

            Console.ReadKey(true);
        }
        static void Llenar(IColeccionable c, int opcion)
        {
            for (int i = 0; i < 20; i++)
            {
            	IComparable com = FabricaDeComparables.CrearAleatorio(opcion);
                c.Agregar(com);
            }
        }
        
        static int GenerarNumRandom(int min, int max){
        	return random.Next(min, max + 1);
        }
        
        static void Informar(IColeccionable c, int opcion){
        	
        	Console.WriteLine("Cantidad de elementos: " + c.Cuantos());
        	Console.WriteLine("Minimo: " + c.Minimo().ToString());
        	Console.WriteLine("Maximo: " + c.Maximo().ToString());
        	IComparable com = FabricaDeComparables.CrearPorTeclado(opcion);
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
        
        static void CambiarEstrategia(Iterable c, IEstrategiaComparacion es){
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
