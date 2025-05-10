using System;

namespace Tp
{
	public interface IAlumno : IObservadorDeProfesores, Comparable
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
        void SetEstrategia(EstrategiaComparacion es);
        EstrategiaComparacion GetEstrategia();
        void SetCalificacion(int c);
        string MostrarCalificacion();
		
	}
}
