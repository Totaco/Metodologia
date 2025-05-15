using System;

namespace Tp
{
	public class Numero : IComparable
	{
		private int valor;
		
		public Numero(int v)
		{
			this.valor=v;
		}
		
		public int GetValor(){
			return valor;
		}
		
		public bool SosIgual(IComparable c){
			return ((Numero)c).GetValor()==valor;
		}
		
		public bool SosMenor(IComparable c){
			return ((Numero)c).GetValor()>valor;
		}
			
		public bool	SosMayor(IComparable c){
			return ((Numero)c).GetValor()<valor;
		}
		
		public override string ToString(){
			return GetValor().ToString();
		}
	}
}
