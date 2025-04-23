using System;

namespace Tp
{
	public interface IObservadorDeProfesores : IObservador
	{
		void actualizar(string accion);
	}
}
