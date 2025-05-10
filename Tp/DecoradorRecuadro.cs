using System;

namespace Tp
{
	public class DecoradorRecuadro : DecoradorCalificacion
	{
		public DecoradorRecuadro(IAlumno a) : base(a) {}
		
		public override string MostrarCalificacion()
		{
			return "*********************************\n*" + ((IAlumno)alumno).MostrarCalificacion() + "*\n*********************************";
		}
	}
}
