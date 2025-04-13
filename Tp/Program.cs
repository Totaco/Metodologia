using System;
using System.Collections.Generic;

namespace Tp
{
    class Program
    {

        static Random random = new Random();
        
        static void Main(string[] args)
        {
            /*Ejercicio 2
            Pila pila = new Pila();
            Cola cola = new Cola();
            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
            LlenarAlumnos(pila);
            LlenarAlumnos(cola);
            Informar(multiple);*/
            
            /*Ejercicio 7
            Pila pila = new Pila();
            Cola cola = new Cola();
            Conjunto conjunto = new Conjunto();
            LlenarAlumnos(pila);
            LlenarAlumnos(cola);
            LlenarAlumnos(conjunto);
            ImprimirElementos(pila);
            Console.WriteLine("");
            ImprimirElementos(cola);
            Console.WriteLine("");
            ImprimirElementos(conjunto);*/
            
            //Ejercicio 9
            Pila pila = new Pila();
            LlenarAlumnos(pila);
            Console.WriteLine("Coleccionable comparado por dni");
            Informar(pila);
            Console.WriteLine("");
            CambiarEstrategia(pila, new PorNombre());
            Console.WriteLine("Coleccionable comparado por nombre");
            Informar(pila);
            Console.WriteLine("");
            CambiarEstrategia(pila, new PorLegajo());
            Console.WriteLine("Coleccionable comparado por legajo");
            Informar(pila);
            Console.WriteLine("");
            CambiarEstrategia(pila, new PorPromedio());
            Console.WriteLine("Coleccionable comparado por promedio");
            Informar(pila);

            Console.ReadKey(true);
        }
        static void Llenar(Coleccionable c)
        {
            for (int i = 0; i < 20; i++)
            {
                c.Agregar(new Numero(GenerarNumRandom(1, 100)));
            }
        }
        static int GenerarNumRandom(int min, int max){
        	return random.Next(min, max + 1);
        }
        static void Informar(Coleccionable c){
        	
        	Console.WriteLine("Cantidad de elementos: " + c.Cuantos());
        	Console.WriteLine("Minimo: " + c.Minimo().ToString());
        	Console.WriteLine("Maximo: " + c.Maximo().ToString());

        	Console.Write("Ingrese un valor para ver si esta en la colección(Si es por nombre ingrese misma cantidad de letras): ");
        	int opt = int.Parse(Console.ReadLine());
        	Comparable com;
        	if (c.Minimo() is Alumno){com = new Alumno(opt.ToString(), opt, opt, opt, ((Alumno)c.Minimo()).GetEstrategia);}
        	else
        		if (c.Minimo() is Numero){com = new Numero(opt);}
        	else
        	{
        		Console.WriteLine("Tipo de dato no identificado");
        		return;
        	}

        	if(c.Contiene(com)){
        		Console.WriteLine("El elemento leído está en la colección");
        	}
        	else
        		Console.WriteLine("El elemento leído no está en la colección");
        }

        static void LlenarAlumnos(Coleccionable c)
        {
            for (int i = 0; i < 20; i++)
            {
            	Comparable nuevoAlumno = new Alumno(GenerarNombreRandom(),GenerarNumRandom(10000000, 99999999),GenerarNumRandom(10000, 99999), GenerarNumRandom(1, 10),new PorDni());
                c.Agregar(nuevoAlumno);
            }
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
    }
}
