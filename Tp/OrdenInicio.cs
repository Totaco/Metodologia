using System;

namespace Tp
{
	public class OrdenInicio : IOrdenEnAula1
	{
		private Aula aula;
		
		public OrdenInicio(Aula a)
		{
			this.aula = a;
		}
		
		public void Ejecutar(){
			aula.Comenzar();
		}
		
	}
}
