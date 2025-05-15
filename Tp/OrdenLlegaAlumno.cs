using System;

namespace Tp
{
	public class OrdenLlegaAlumno : IOrdenEnAula2
	{
		private Aula aula;
		
		public OrdenLlegaAlumno(Aula a)
		{
			this.aula = a;
		}
		
		public void Ejecutar(IComparable c){
			aula.NuevoAlumno(c);
		}
	}
}
