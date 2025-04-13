using System.Collections.Generic;

namespace Tp
{
	public class Pila : Coleccionable, Iterable 
	{
		List<Comparable> lista;
		
		public Pila()
		{
			this.lista = new List<Comparable>();
		}
		
		public void Apilar(Comparable c){
			lista.Add(c);
		}
		
		public Comparable Desapilar(){
			Comparable aux = lista[lista.Count-1];
			lista.RemoveAt(lista.Count-1);
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
			Apilar(c);
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
