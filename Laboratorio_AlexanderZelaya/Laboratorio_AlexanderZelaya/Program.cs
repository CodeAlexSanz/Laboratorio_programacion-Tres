using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Laboratorio_AlexanderZelaya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();

            Dictionary<string, List<string>> MunicipioDepartamento = new Dictionary<string, List<string>>();

            MunicipioDepartamento.Add("Chalatenango", new List<string> { "Potonico", "La Palma", "Nombre de Jesús", "San Ignacio", "Citalá", "San Antonio los Ranchos", "Cancasque", "Azacualpa" });
            MunicipioDepartamento.Add("Santa Ana", new List<string> { "Chalchuapa", "Coatepeque", "El Congo", "El Porvenir", "Masahuat", "Texistepeque", "San Antonio Pajonal", "Santa Rosa Guachipilín" });
            MunicipioDepartamento.Add("San Miguel", new List<string> { "Carolina", "Chapeltique", "Chinameca", "Chirilagua", "Ciudad Barrios", "Comacarán", "Lolotique", "Quelepa" });
            MunicipioDepartamento.Add("San Salvador", new List<string> { "Aguilares", "Apopa", "Ciudad Delgado", "Cuscatancingo", "El Paisnal", "Guazapa", "Ilopango", "Nejapa" });
            MunicipioDepartamento.Add("Ahuachapán", new List<string> { "Atiquizaya", "El refugio", "Guaymango", "Jujutla", "San Lorenzo", "Tacuba", "Turín", "San Pedro Puxtla" });
            MunicipioDepartamento.Add("La Libertad", new List<string> { "Antiguo Cuscatlán", "Ciudad Arce", "Jayaque", "Jicalapa", "Quezaltepeque", "Sacacoyo", "San Matías", "Talnique" });
            MunicipioDepartamento.Add("Sonsonate", new List<string> { "Armenia", "Caluco", "Izalco", "Nahulingo", "San Julián", "Sonzacate", "Cuisnahuat", "Salcoatitán" });
            MunicipioDepartamento.Add("Cuscatlán", new List<string> { "Candelaria", "El Carmen", "El Rosario", "Monte San Juán", "San Rafael Cedros", "San Cristobal", "San Ramón", "Tenancingo" });
            MunicipioDepartamento.Add("Cabañas", new List<string> { "Sensuntepeque", "Cinquera", "Dolores", "Guacotecti", "Jutiapa", "San Isidro", "Tejutepeque", "Victoria" });
            MunicipioDepartamento.Add("San Vicente", new List<string> { "Guadalupe", "San Idelfonso", "San Lorenzo", "Santa Clara", "Santo Domingo", "Tecoluca", "Tepetitán", "Verapaz" });
            MunicipioDepartamento.Add("Usulután", new List<string> { "Berlín", "California", "El Triunfo", "Jiquilisco", "Jucuarán", "Ozatlán", "Puerto El Triunfo", "San Augustín" });
            MunicipioDepartamento.Add("La Paz", new List<string> { "Zacatecoluca", "El Rosario", "Jerusalén", "San Emigdio", "Chimameca", "San Luis Talpa", "Tapalhuaca", "Santiago Nonualco" });
            MunicipioDepartamento.Add("La Unión", new List<string> { "Anamoros", "Bolívar", "El Carmen", "El Sauce", "Lislique", "Pasaquina", "San Alejo", "Yayantique" });
            MunicipioDepartamento.Add("Morazán", new List<string> { "Arambala", "Cacaopera", "Corinto", "El Divisadero", "El Rosario", "Joateca", "Jocoro", "Osicala" });

            while (true)
            {
                try
                {
                    WriteLine("================================\n" +
                              "         Bienvenido :)\n" +
                              "================================");

                    foreach(var DepartamentosMunicipios in MunicipioDepartamento)
                    {
                        WriteLine(DepartamentosMunicipios);
                    }

                    WriteLine("================================\n" +
                              "Ingrese los datos de su Usuario\n" +
                              "================================");
                    Write("Nombre y Apellido: ");
                    string nombre = ReadLine();
                    Write("edad: ");
                    int edad = int.Parse(ReadLine());
                    Write("Departamento: ");
                    string departamento = ReadLine();
                    Write("Municipio: ");
                    string municipio = ReadLine();

                    if (!MunicipioDepartamento[departamento].Contains(municipio))
                    {
                        WriteLine("================================\n" +
                            $"El municipio {municipio} no pertenece al departamento {departamento}. Intente nuevamente");
                        continue;
                    }

                    Persona persona = new Persona(nombre, edad, departamento, municipio);
                    personas.Add(persona);

                    Write("================================\n" +
                          "La persona agregada a la lista!\n" +
                          "================================\n" +
                          "Presione Enter para agregar a otra persona\n" +
                          "o ingrese 'mostrar' para ver las edades de las personas\n" +
                          "================================\n" +
                          "Opción: ");

                    string opc = ReadLine();

                    if (opc.ToLower() == "mostrar")
                    {
                        Write("================================\n" +
                              "Edades de las personas guardadas\n" +
                              "================================\n");
                        foreach (Persona personita in personas)
                        {
                            WriteLine(personita.Edad);
                            break;
                        }
                    }
                } catch (Exception ex)
                {
                    WriteLine($"Ha sucedido un error {ex}");
                }
            }
        }
    }
}
