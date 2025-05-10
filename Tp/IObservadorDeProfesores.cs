using System;

namespace Tp
{
	public interface IObservadorDeProfesores : IObservador
	{
		void Actualizar(string accion);
	}
}
