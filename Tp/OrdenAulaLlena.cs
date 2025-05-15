using System;

namespace Tp
{
	public class OrdenAulaLlena : IOrdenEnAula1
	{
		private Aula aula;
		
		public OrdenAulaLlena(Aula a)
		{
			this.aula = a;
		}
		
		public void Ejecutar(){
			aula.ClaseLista();
		}
	}
}
