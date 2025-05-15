using System;

namespace Tp
{
	public class FabricaDeNumeros : FabricaDeComparables
	{
		public FabricaDeNumeros()
		{
		}
		
		public override IComparable CrearAleatorio()
		{
			return new Numero(generador.NumeroAleatorio(100));
		}
		
		public override IComparable CrearPorTeclado(){
			return new Numero(lector.NumeroPorTeclado());	
		}
	}
}
