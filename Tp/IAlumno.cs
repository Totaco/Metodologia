using System;

namespace Tp
{
	public interface IAlumno : IObservadorDeProfesores, IComparable
	{
		string GetNombre();
        int GetLegajo();
        double GetPromedio();
        int GetDni();
        int GetCalificacion();
        int ResponderPregunta(int pregunta);
        void PrestarAtencion();
        void Distraerse();
        string ToString();
        void SetEstrategia(IEstrategiaComparacion es);
        IEstrategiaComparacion GetEstrategia();
        void SetCalificacion(int c);
        string MostrarCalificacion();
		
	}
}
