using System;

namespace Tp
{
	public class FabricaDeProfesores : FabricaDeComparables
	{
		public FabricaDeProfesores()
		{
		}
		
		public override IComparable CrearAleatorio()
		{
			return new Profesor(generador.StringAleatorio(5),generador.NumeroAleatorio(99999999),generador.NumeroAleatorio(30));
		}
		
		public override IComparable CrearPorTeclado()
		{
			return new Profesor(lector.StringPorTeclado(),lector.NumeroPorTeclado(),lector.NumeroPorTeclado());
		}
	}
}
