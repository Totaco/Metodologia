using System;

namespace Tp
{
	public interface IEstrategiaComparacion
	{
		bool Igual(IComparable c, IComparable c2);
		bool Menor(IComparable c, IComparable c2);
		bool Mayor(IComparable c, IComparable c2);
		
	}
}
