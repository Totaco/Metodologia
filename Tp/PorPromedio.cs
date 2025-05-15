using System;

namespace Tp
{
	public class PorPromedio : IEstrategiaComparacion
	{
		public PorPromedio(){}
		
        public bool Igual(IComparable c, IComparable c2)
        {
        	return ((IAlumno)c).GetPromedio() == ((IAlumno)c2).GetPromedio();
        }
        public  bool Menor(IComparable c, IComparable c2)
        {
            return ((IAlumno)c).GetPromedio() < ((IAlumno)c2).GetPromedio();
        }
        public bool Mayor(IComparable c, IComparable c2)
        {
            return ((IAlumno)c).GetPromedio() > ((IAlumno)c2).GetPromedio();
        }
    }
}
