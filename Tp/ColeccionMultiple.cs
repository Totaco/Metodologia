using System;

namespace Tp
{
	public class ColeccionMultiple : IColeccionable
	{
		private Pila pila;
		private	Cola cola;
		
		public ColeccionMultiple(Pila p, Cola c)
		{
			this.pila = p;
			this.cola = c;
		}
		
		public int Cuantos(){
			return pila.Cuantos() + cola.Cuantos();
		}
		
		public IComparable Minimo(){
			IComparable min = pila.Minimo();
			IComparable min2 = cola.Minimo();
			if(min.SosMenor(min2))
				return min;
			return min2;
		}
		public IComparable Maximo(){
			IComparable max = pila.Maximo();
			IComparable max2 = cola.Maximo();
			if(max.SosMayor(max2))
				return max;
			return max2;	
		}
		public void Agregar(IComparable c){}
		
		public bool Contiene(IComparable c){
			if(pila.Contiene(c) || cola.Contiene(c))
				return true;
			return false;
		}
	}
}
