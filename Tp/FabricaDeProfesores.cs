using System;

namespace Tp
{
	public class FabricaDeProfesores : FabricaDeComparables
	{
		public FabricaDeProfesores()
		{
		}
		
		public override Comparable CrearAleatorio()
		{
			return new Profesor(generador.StringAleatorio(5),generador.NumeroAleatorio(99999999),generador.NumeroAleatorio(30));
		}
		
		public override Comparable CrearPorTeclado()
		{
			return new Profesor(lector.StringPorTeclado(),lector.NumeroPorTeclado(),lector.NumeroPorTeclado());
		}
	}
}
