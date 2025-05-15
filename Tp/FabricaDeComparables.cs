using System;

namespace Tp
{
	 public abstract class FabricaDeComparables
	{
	 	protected GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
	 	protected LectorDeDatos lector = new LectorDeDatos();
	 	
		public FabricaDeComparables(){}
		
		public static IComparable CrearAleatorio(int opcion){
			FabricaDeComparables fabrica = null;
			switch(opcion){
				case 1:
					fabrica = new FabricaDeNumeros(); break;
				case 2:
					fabrica = new FabricaDeAlumnos(); break;
				case 3:
					fabrica = new FabricaDeAlumnosMuyEstudiosos(); break;
				case 4:
					fabrica = new FabricaDeProfesores(); break;
				case 5:
					fabrica = new StudentsFactory(); break;
				default:
					Console.WriteLine("Opcion incorrecta"); break;
			}
			return fabrica.CrearAleatorio();
		}
		
		public static IComparable CrearPorTeclado(int opcion){
			FabricaDeComparables fabrica = null;
			switch(opcion){
				case 1:
					fabrica = new FabricaDeNumeros(); break;
				case 2:
					fabrica = new FabricaDeAlumnos(); break;
				case 3:
					fabrica = new FabricaDeAlumnosMuyEstudiosos(); break;
				case 4:
					fabrica = new FabricaDeProfesores(); break;
				case 5:
					fabrica = new StudentsFactory(); break;
				default:
					Console.WriteLine("Opcion incorrecta"); break;
			}
			return fabrica.CrearPorTeclado();
		}
		
		public abstract IComparable CrearAleatorio();
		public abstract IComparable CrearPorTeclado();
	}
}
