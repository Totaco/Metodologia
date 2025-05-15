using System;

namespace Tp
{
	public interface IColeccionable
	{
		int Cuantos();
		IComparable Minimo();
		IComparable Maximo();
		void Agregar(IComparable c);
		bool Contiene(IComparable c);
	}
}
