using System;

namespace Tp
{
	public interface Iterador
	{
		IComparable Actual();
		void Siguiente();
		bool Fin();
	}
}
