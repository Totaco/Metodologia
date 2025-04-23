using System;

namespace Tp
{
	public interface IObservado
	{
		void agregarObservador(IObservador o);
		void notificar(string accion);
	}
}
