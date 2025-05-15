using System;

namespace Tp
{
	public class PorDni : IEstrategiaComparacion
	{
		public PorDni(){}
		
		public bool Igual(IComparable c, IComparable c2)
        {
        	return ((IAlumno)c).GetDni() == ((IAlumno)c2).GetDni();
        }
        public  bool Menor(IComparable c, IComparable c2)
        {
            return ((IAlumno)c).GetDni() < ((IAlumno)c2).GetDni();
        }
        public bool Mayor(IComparable c, IComparable c2)
        {
            return ((IAlumno)c).GetDni() > ((IAlumno)c2).GetDni();
        }
	}
}
