using System;

namespace Tp
{
	public class FabricaDeAlumnos : FabricaDeComparables
	{
		public FabricaDeAlumnos(){}
		
		public override IComparable CrearAleatorio()
		{
			return new AlumnoProxy(generador.StringAleatorio(5),generador.NumeroAleatorio(99999999),generador.NumeroAleatorio(99999),generador.NumeroAleatorio(9)+1,generador.NumeroAleatorio(9)+1);
		}
		
		public override IComparable CrearPorTeclado(){
			return new AlumnoProxy(lector.StringPorTeclado(),lector.NumeroPorTeclado(),lector.NumeroPorTeclado(),lector.NumeroPorTeclado(),lector.NumeroPorTeclado());
		}
	}
}
