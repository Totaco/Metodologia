using System;

namespace Tp
{
	public class AlumnoMuyEstudiosoProxy : AlumnoProxy
	{
		public AlumnoMuyEstudiosoProxy(string n, int d, int l, double p, int c) : base(n, d, l, p, c)
		{
		}
		
		public override Alumno CrearAlumnoReal()
		{
			Console.WriteLine("Creando Alumno Estudioso real");
            return new AlumnoMuyEstudioso(nombre, dni, legajo, promedio, calificacion);
		}
	}
}
