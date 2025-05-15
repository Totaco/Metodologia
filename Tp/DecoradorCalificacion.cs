using System;

namespace Tp
{
	public abstract class DecoradorCalificacion : IAlumno
	{
		protected IAlumno alumno;
		
		public DecoradorCalificacion(IAlumno a)
		{
			this.alumno = a;
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
        public void SetEstrategia(IEstrategiaComparacion es) { alumno.SetEstrategia(es); }
        public IEstrategiaComparacion GetEstrategia() { return alumno.GetEstrategia(); }
        public void SetCalificacion(int c) { alumno.SetCalificacion(c); }
        public void Actualizar(string accion) { alumno.Actualizar(accion); }
        public abstract string MostrarCalificacion();
        public bool SosIgual(IComparable c) { return alumno.SosIgual(c); }
        public bool SosMenor(IComparable c) { return alumno.SosMenor(c); }
        public bool SosMayor(IComparable c) { return alumno.SosMayor(c); }
	}
}
