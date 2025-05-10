using System;

namespace Tp
{
	public class ColeccionMultiple : Coleccionable
	{
		private Pila pila;
		private	Cola cola;
		
		public ColeccionMultiple(Pila p, Cola c)
		{
			pila = p;
			cola = c;
		}
		
		public int Cuantos(){
			return pila.Cuantos() + cola.Cuantos();
		}
		
		public Comparable Minimo(){
			Comparable min = pila.Minimo();
			Comparable min2 = cola.Minimo();
			if(min.SosMenor(min2))
				return min;
			return min2;
		}
		public Comparable Maximo(){
			Comparable max = pila.Maximo();
			Comparable max2 = cola.Maximo();
			if(max.SosMayor(max2))
				return max;
			return max2;	
		}
		public void Agregar(Comparable c){}
		
		public bool Contiene(Comparable c){
			if(pila.Contiene(c) || cola.Contiene(c))
				return true;
			return false;
		}
	}
}
