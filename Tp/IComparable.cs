using System;

namespace Tp
{
	public interface IComparable
	{
		bool SosIgual(IComparable c);
		bool SosMenor(IComparable c);
		bool SosMayor(IComparable c);
	}
}
