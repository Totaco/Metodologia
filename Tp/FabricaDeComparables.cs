using System;

namespace Tp
{
	 public abstract class FabricaDeComparables
	{
	 	protected GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
	 	protected LectorDeDatos lector = new LectorDeDatos();
	 	
		public FabricaDeComparables()
		{
		}
		
		public static Comparable CrearAleatorio(int opcion){
			FabricaDeComparables fabrica = null;
			switch(opcion){
				case 1:
					fabrica = new FabricaDeNumeros(); break;
				case 2:
					fabrica = new FabricaDeAlumnos(); break;
				case 3:
					fabrica = new FabricaDeProfesores(); break;
				default:
					Console.WriteLine("Opcion incorrecta"); break;
			}
			return fabrica.CrearAleatorio();
		}
		
		public static Comparable CrearPorTeclado(int opcion){
			FabricaDeComparables fabrica = null;
			switch(opcion){
				case 1:
					fabrica = new FabricaDeNumeros(); break;
				case 2:
					fabrica = new FabricaDeAlumnos(); break;
				case 3:
					fabrica = new FabricaDeProfesores(); break;
				default:
					Console.WriteLine("Opcion incorrecta"); break;
			}
			return fabrica.CrearPorTeclado();
		}
		
		public abstract Comparable CrearAleatorio();
		public abstract Comparable CrearPorTeclado();
	}
}
