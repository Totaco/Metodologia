using System.Collections.Generic;

namespace Tp
{
	public class Conjunto : Coleccionable, Iterable
	{
		private List<Comparable> lista;
		
		public Conjunto()
		{
			this.lista = new List<Comparable>();
		}
		
		public List<Comparable> GetLista{
			get{return lista;}
		}
		
		public int Cuantos(){
			return lista.Count;
		}
		
		public Comparable Minimo(){
			Comparable min = lista[0];
			foreach(Comparable c in lista){
				if(c.SosMenor(min))
					min=c;
			}
			return min;
		}
		
		public Comparable Maximo(){
			Comparable max = lista[0];
			foreach(Comparable c in lista){
				if(c.SosMayor(max))
					max=c;
			}
			return max;
		}
		
		public void Agregar(Comparable c){
			if(!Pertenece(c))
				lista.Add(c);
		}
		
		public bool Contiene(Comparable c){
			return Pertenece(c);
		}
		
		private bool Pertenece(Comparable c){
			foreach(Comparable com in lista){
				if(com.SosIgual(c))
					return true;
			}
			return false;
		}
		
		public IteradorDeLista CrearIterador(){
			return new IteradorDeLista(lista);
		}
	}
}
