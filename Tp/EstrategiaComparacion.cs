using System;

namespace Tp
{
	public interface EstrategiaComparacion
	{
		bool Igual(Comparable c, Comparable c2);
		bool Menor(Comparable c, Comparable c2);
		bool Mayor(Comparable c, Comparable c2);
		
	}
}
