using System;

namespace Tp
{
	public class FabricaDeAlumnosMuyEstudiosos : FabricaDeAlumnos
	{
		public FabricaDeAlumnosMuyEstudiosos(){}
		
		public override IComparable CrearAleatorio()
		{
			return new AlumnoMuyEstudiosoProxy(generador.StringAleatorio(5),generador.NumeroAleatorio(99999999),generador.NumeroAleatorio(99999),generador.NumeroAleatorio(9)+1,generador.NumeroAleatorio(9)+1);
		}
		
		public override IComparable CrearPorTeclado()
		{
			return new AlumnoMuyEstudiosoProxy(lector.StringPorTeclado(),lector.NumeroPorTeclado(),lector.NumeroPorTeclado(),lector.NumeroPorTeclado(),lector.NumeroPorTeclado());
		}
	}
}
