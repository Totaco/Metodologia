using System.Collections.Generic;

namespace Tp
{
	public class Pila : IColeccionable, Iterable, IOrdenable
	{
		private List<IComparable> lista;
		private IOrdenEnAula1 ordenInicio;
        private IOrdenEnAula1 ordenAulaLlena;
        private IOrdenEnAula2 ordenNuevoAlumno;
		
		public Pila()
		{
			this.lista = new List<IComparable>();
		}
		
		public void Apilar(IComparable c){
			if(Cuantos() == 0)
				ordenInicio.Ejecutar();
			lista.Add(c);
			ordenNuevoAlumno.Ejecutar(c);
			if(Cuantos() == 40)
				ordenAulaLlena.Ejecutar();
		}
		
		public IComparable Desapilar(){
			IComparable aux = lista[lista.Count-1];
			lista.RemoveAt(lista.Count-1);
			return aux;	
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
			Apilar(c);
		}
		
		public bool Contiene(IComparable c){
			foreach(IComparable com in lista){
				if(com.SosIgual(c))
					return true;
			}
			return false;
		}
		
		public IteradorDeLista CrearIterador(){
			return new IteradorDeLista(lista);
		}
		
		public void SetOrdenInicio(IOrdenEnAula1 o){
			ordenInicio = o;
		}
		
		public void SetOrdenLlegaAlumno(IOrdenEnAula2 o){
			ordenNuevoAlumno = o;
		}
		
		public void SetOrdenAulaLlena(IOrdenEnAula1 o){
			ordenAulaLlena = o;
		}
	}
}
