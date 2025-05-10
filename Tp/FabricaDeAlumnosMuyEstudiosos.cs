using System;

namespace Tp
{
	public class FabricaDeAlumnosMuyEstudiosos : FabricaDeAlumnos
	{
		public FabricaDeAlumnosMuyEstudiosos(){}
		
		public override Comparable CrearAleatorio()
		{
			return new AlumnoMuyEstudioso(generador.StringAleatorio(5),generador.NumeroAleatorio(99999999),generador.NumeroAleatorio(99999),generador.NumeroAleatorio(9)+1,generador.NumeroAleatorio(9)+1,new PorDni());
		}
		
		public override Comparable CrearPorTeclado()
		{
			return new AlumnoMuyEstudioso(lector.StringPorTeclado(),lector.NumeroPorTeclado(),lector.NumeroPorTeclado(),lector.NumeroPorTeclado(),lector.NumeroPorTeclado(),new PorDni());
		}
	}
}
