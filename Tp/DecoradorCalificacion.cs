using System;

namespace Tp
{
	public abstract class DecoradorCalificacion : IAlumno
	{
		protected IAlumno alumno;
		
		public DecoradorCalificacion(IAlumno a)
		{
			alumno = a;
		}
		
		public virtual string GetNombre() { return alumno.GetNombre(); }
        public virtual int GetLegajo() { return alumno.GetLegajo(); }
        public virtual double GetPromedio() { return alumno.GetPromedio(); }
        public virtual int GetDni() { return alumno.GetDni(); }
        public virtual int GetCalificacion() { return alumno.GetCalificacion(); }
        public int ResponderPregunta(int pregunta) { return alumno.ResponderPregunta(pregunta); }
        public void PrestarAtencion() { alumno.PrestarAtencion(); }
        public void Distraerse() { alumno.Distraerse(); }
        public override string ToString() { return alumno.ToString(); }
        public void SetEstrategia(EstrategiaComparacion es) { alumno.SetEstrategia(es); }
        public EstrategiaComparacion GetEstrategia() { return alumno.GetEstrategia(); }
        public void SetCalificacion(int c) { alumno.SetCalificacion(c); }
        public void Actualizar(string accion) { alumno.Actualizar(accion); }
        public abstract string MostrarCalificacion();
        public bool SosIgual(Comparable c) { return alumno.SosIgual(c); }
        public bool SosMenor(Comparable c) { return alumno.SosMenor(c); }
        public bool SosMayor(Comparable c) { return alumno.SosMayor(c); }
	}
}
