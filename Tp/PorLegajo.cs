using System;

namespace Tp
{
	public class PorLegajo : IEstrategiaComparacion
	{
		public PorLegajo(){}
		
		public bool Igual(IComparable c, IComparable c2)
        {
        	return ((IAlumno)c).GetLegajo() == ((IAlumno)c2).GetLegajo();
        }
        public  bool Menor(IComparable c, IComparable c2)
        {
            return ((IAlumno)c).GetLegajo() < ((IAlumno)c2).GetLegajo();
        }
        public bool Mayor(IComparable c, IComparable c2)
        {
            return ((IAlumno)c).GetLegajo() > ((IAlumno)c2).GetLegajo();
        }
	}
}
