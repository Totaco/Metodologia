using System;

namespace Tp
{
	public class PorPromedio : EstrategiaComparacion
	{
		public PorPromedio()
		{
		}
		
        //Metodos de Comparable - comparar personas
        public bool Igual(Comparable c, Comparable c2)
        {
        	return ((Alumno)c).GetPromedio == ((Alumno)c2).GetPromedio;
        }
        public  bool Menor(Comparable c, Comparable c2)
        {
            return ((Alumno)c).GetPromedio < ((Alumno)c2).GetPromedio;
        }
        public bool Mayor(Comparable c, Comparable c2)
        {
            return ((Alumno)c).GetPromedio > ((Alumno)c2).GetPromedio;
        }
    }
}
