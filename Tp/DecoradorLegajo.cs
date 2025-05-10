using System;

namespace Tp
{
	public class DecoradorLegajo : DecoradorCalificacion
	{
		public DecoradorLegajo(IAlumno a) : base(a) {}
		
		public override string MostrarCalificacion()
		{
			return GetNombre() + " " + "(" + GetLegajo() + ")" + "  " + GetCalificacion();
		}
	}
}
