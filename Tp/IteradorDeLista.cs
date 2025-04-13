using System.Collections.Generic;

namespace Tp
{
	public class IteradorDeLista : Iterador
	{
		private List<Comparable> lista;
		private int indice;
		
		public IteradorDeLista(List<Comparable> cl)
		{
			lista=cl;
			indice=0;
		}
		
		public Comparable Actual(){
			return lista[indice];
		}
		
		public void Siguiente(){
			indice++;
		}
		
		public bool Fin(){
			return indice >= lista.Count;
		}
		
	}
}
