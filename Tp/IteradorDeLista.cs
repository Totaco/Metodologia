using System.Collections.Generic;

namespace Tp
{
	public class IteradorDeLista : Iterador
	{
		private List<IComparable> lista;
		private int indice;
		
		public IteradorDeLista(List<IComparable> cl)
		{
			this.lista=cl;
			this.indice=0;
		}
		
		public IComparable Actual(){
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
