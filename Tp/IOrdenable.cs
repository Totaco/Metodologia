using System;

namespace Tp
{
	public interface IOrdenable
	{
		void SetOrdenInicio(IOrdenEnAula1 o);
		void SetOrdenLlegaAlumno(IOrdenEnAula2 o);
		void SetOrdenAulaLlena(IOrdenEnAula1 o);
	}
}
