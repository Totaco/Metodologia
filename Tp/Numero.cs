using System;

namespace Tp
{
	public class Numero : Comparable
	{
		private int valor;
		
		public Numero(int v)
		{this.valor=v;}
		
		public int getValor
		{get{return valor;}}
		
		public bool SosIgual(Comparable c){
			return ((Numero)c).getValor==valor;
		}
		
		public bool SosMenor(Comparable c){
			return ((Numero)c).getValor>valor;
		}
			
		public bool	SosMayor(Comparable c){
			return ((Numero)c).getValor<valor;
		}
		
		public override string ToString(){
			return getValor.ToString();
		}
	}
}
