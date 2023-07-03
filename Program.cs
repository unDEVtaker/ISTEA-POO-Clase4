//colecciones System. Generic y Linq;
//1ro Agregar alumnos e imprimir listado.

using System.Collections.Generic;
using System.Linq;

List<Alumno> listaAlumno = new List<Alumno>()
{
    new Alumno (){Nombre="Jonatan", Apellido="Silva", DNI=1222222, Edad=20},
    new Alumno (){Nombre="Benjamin", Apellido="Gaturro", DNI=1232522, Edad=22},
    new Alumno (){Nombre="Valentina", Apellido="Silva", DNI=1232412, Edad=17},
    new Alumno (){Nombre="Fausto", Apellido="Hernandez", DNI=1111412, Edad=30},
    new Alumno (){Nombre="Camila", Apellido="Teo", DNI=1666412, Edad=28},
};

//AddRange(); agregar o unir otra lista
//RemoveAt(); remover un lugar
//Clear(); limpiar
//Count(); contar
//Reverse(); dar vuelta la lista

//listaAlumno.RemoveAt(4);
Console.WriteLine($"Cantidad de alumnos: {listaAlumno.Count()}");

listaAlumno.Reverse();
//linq
//.Where; donde se cumple
//.Contains; que contenga
//OrderBy
//OrderByDescending

var listafiltrada= listaAlumno
                        .Where(x=>  x.Apellido == "Gaturro" && 
                                    x.Nombre=="Benjamin" &&
                                    x.Edad<23);

var listaordenada = listaAlumno.OrderBy(x=> x.Edad);
foreach(var alu in listaordenada){
    Console.WriteLine($"Nombre: {alu.Nombre.ToUpper()} Apellido: {alu.Apellido.ToUpper()} DNI: {alu.DNI} Edad: {alu.Edad}") ;
}


class Alumno
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int DNI { get; set; }
    public int Edad { get; set; }

}