using System.Collections.Generic;

namespace Tp
{
	public class Cola : Coleccionable, Iterable
	{
		private List<Comparable> lista;
		public Cola()
		{
			this.lista = new List<Comparable>();
		}
		
		public void Encolar(Comparable c){
			lista.Add(c);
		}
		public Comparable Desencolar(){
			Comparable aux = lista[0];
			lista.RemoveAt(0);
			return aux;	
		}
		
		public int Cuantos(){
			return lista.Count;
		}
		
		public Comparable Minimo(){
			Comparable min = lista[0];
			foreach(Comparable c in lista){
				if(c.sosMenor(min))
					min=c;
			}
			return min;
		}
		
		public Comparable Maximo(){
			Comparable max = lista[0];
			foreach(Comparable c in lista){
				if(c.sosMayor(max))
					max=c;
			}
			return max;
		}
		
		public void Agregar(Comparable c){
			Encolar(c);
		}
		
		public bool Contiene(Comparable c){
			foreach(Comparable com in lista){
				if(com.sosIgual(c))
					return true;
			}
			return false;
		}
		
		public IteradorDeLista CrearIterador(){
			return new IteradorDeLista(lista);
		}
	}
}
