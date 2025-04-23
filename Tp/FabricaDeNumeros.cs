using System;

namespace Tp
{
	public class FabricaDeNumeros : FabricaDeComparables
	{
		public FabricaDeNumeros()
		{
		}
		
		public override Comparable CrearAleatorio()
		{
			return new Numero(generador.NumeroAleatorio(100));
		}
		
		public override Comparable CrearPorTeclado(){
			return new Numero(lector.NumeroPorTeclado());	
		}
	}
}
