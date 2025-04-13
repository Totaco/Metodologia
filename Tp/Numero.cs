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
		
		public bool sosIgual(Comparable c){
			return ((Numero)c).getValor==valor;
		}
		
		public bool sosMenor(Comparable c){
			return ((Numero)c).getValor>valor;
		}
			
		public bool	sosMayor(Comparable c){
			return ((Numero)c).getValor<valor;
		}
		
		public override string ToString(){
			return getValor.ToString();
		}
	}
}
