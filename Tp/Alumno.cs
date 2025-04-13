using System;

namespace Tp
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno : Persona
	{
		private int legajo;
		private double promedio;
		private EstrategiaComparacion estrategia;
		
		public Alumno(string n, int d, int l, double p, EstrategiaComparacion e) : base(n,d)
		{
			legajo=l;
			promedio=p;
			estrategia=e;
		}
		
		public int GetLegajo{
			get{return legajo;}
		}
		
		public double GetPromedio{
			get{return promedio;}
		}
		
		public override string ToString(){
			return "Alumno " + GetNombre + ", Dni " + GetDni + ", Legajo " + GetLegajo + ", Promedio " + GetPromedio;
		}
		
		public override bool sosIgual(Comparable c){
			return estrategia.Igual(this,c);
		}
		
		public override bool sosMenor(Comparable c){
			return estrategia.Menor(this,c);
		}
		
		public override bool sosMayor(Comparable c){
			return estrategia.Mayor(this,c);
		}
		
		public void SetEstrategia(EstrategiaComparacion es){
			estrategia = es;
		}
		
		public EstrategiaComparacion GetEstrategia{
			get{return estrategia;}
		}
	}
}
