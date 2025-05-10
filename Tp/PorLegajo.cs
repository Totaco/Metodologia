using System;

namespace Tp
{
	public class PorLegajo : EstrategiaComparacion
	{
		public PorLegajo()
		{
		}
		
		public bool Igual(Comparable c, Comparable c2)
        {
        	return ((IAlumno)c).GetLegajo() == ((IAlumno)c2).GetLegajo();
        }
        public  bool Menor(Comparable c, Comparable c2)
        {
            return ((IAlumno)c).GetLegajo() < ((IAlumno)c2).GetLegajo();
        }
        public bool Mayor(Comparable c, Comparable c2)
        {
            return ((IAlumno)c).GetLegajo() > ((IAlumno)c2).GetLegajo();
        }
	}
}
