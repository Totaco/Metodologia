using System.Collections.Generic;

namespace Tp
{
	public class Conjunto : IColeccionable, Iterable
	{
		private List<IComparable> lista;
		
		public Conjunto()
		{
			this.lista = new List<IComparable>();
		}
		
		public List<IComparable> GetLista(){
			return lista;
		}
		
		public int Cuantos(){
			return lista.Count;
		}
		
		public IComparable Minimo(){
			IComparable min = lista[0];
			foreach(IComparable c in lista){
				if(c.SosMenor(min))
					min=c;
			}
			return min;
		}
		
		public IComparable Maximo(){
			IComparable max = lista[0];
			foreach(IComparable c in lista){
				if(c.SosMayor(max))
					max=c;
			}
			return max;
		}
		
		public void Agregar(IComparable c){
			if(!Pertenece(c))
				lista.Add(c);
		}
		
		public bool Contiene(IComparable c){
			return Pertenece(c);
		}
		
		private bool Pertenece(IComparable c){
			foreach(IComparable com in lista){
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
