using System;

namespace Tp
{
	public class FabricaDeAlumnos : FabricaDeComparables
	{
		public FabricaDeAlumnos()
		{
		}
		
		public override Comparable CrearAleatorio()
		{
			return new Alumno(generador.StringAleatorio(5),generador.NumeroAleatorio(99999999),generador.NumeroAleatorio(99999),generador.NumeroAleatorio(10),new PorDni());
		}
		
		public override Comparable CrearPorTeclado(){
			return new Alumno(lector.StringPorTeclado(),lector.NumeroPorTeclado(),lector.NumeroPorTeclado(),lector.NumeroPorTeclado(),new PorDni());
		}
	}
}
