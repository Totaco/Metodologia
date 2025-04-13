using System;

namespace Tp
{
	public interface Iterador
	{
		Comparable Actual();
		void Siguiente();
		bool Fin();
	}
}
