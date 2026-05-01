using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_23_progra_3_30_de_abril
{
    internal class Program
    {
        class Usuario

        {
            private string nombre;

            private string ip;

            private string nivel;

            private string estado;

            public Usuario(string nombre, string ip, string nivel, string estado)

            {
                this.nombre = nombre;
                this.ip = ip;
                this.nivel = nivel;
                this.estado = estado;

            }

            public string Nombre

            {
                get

                {
                    return nombre;
                }

                set

                {
                    if (value.Length >= 6)

                    {

                        nombre = value;

                    }

                    else

                    {

                        Console.WriteLine("Error, el nombre de usuario debe tener 6 carácteres");

                    }


                }

            }

            public string Ip

            {
                get

                {

                    return ip;

                }

                set

                {
                    if (value.Length >= 13)

                    {
                        ip = value;

                    }

                    else

                    {

                        Console.WriteLine("Dirección IP no válida");

                    }




                }


            }

            public string Nivel


            {
                get

                {
                    return nivel;


                }

                set

                {

                    if (value.Length >= 4)

                    {

                        nivel = value;


                    }

                    else

                    {

                        Console.WriteLine("Nivel no valido");


                    }



                }




            }

            public string Estado


            {
                get

                {

                    return estado;

                }

                set

                {
                    if (value.Length >= 6)

                    {

                        estado = value;


                    }

                    else

                    {

                        Console.WriteLine("Estado ingresado no valido");

                    }


                }




            }


            public void MostrarUsuario()

            {
                Console.WriteLine($"Nombre de usuario: {Nombre}");

                Console.WriteLine();

                Console.WriteLine($"IP: {Ip}");

                Console.WriteLine();

                Console.WriteLine($"Nivel de usuario: {Nivel}");

                Console.WriteLine();

                Console.WriteLine($"Estado de usuario: {Estado}");

            }

        }

        class Admin : Usuario

        {
            private string rango;

            private string contraseña;

            public Admin(string nombre, string ip, string nivel, string estado, string rango, string contraseña) : base(nombre, ip, nivel, estado)

            {
                this.rango = rango;

                this.contraseña = contraseña;

            }

            public string Rango

            {
                get

                {

                    return rango;


                }


                set

                {

                    if (value.Length >=1)

                    {

                        rango = value;

                    }

                    else

                    {

                        Console.WriteLine("Rango no valido");

                    }

                }




            }

            public string Contraseña


            {

                get

                {

                    return contraseña;


                }

                set

                {

                    if (value.Length<8)

                    {

                        Console.WriteLine("Contraseña no valida");

                    }

                    else

                    {
                        contraseña = value;

                    }

                }


            }

            public void MostrarAdmin()

            {
                Console.WriteLine($"Rango de adiministrador: {rango}");

                Console.WriteLine();

                Console.WriteLine($"Contraseña de administrador: {contraseña}");



            }


        }

        class Junior : Usuario

        {
            private string carnet;

            private string area;

            public Junior(string nombre, string ip, string nivel, string estado, string carnet, string area) : base(nombre, ip, nivel, estado)

            {
                this.carnet = carnet;

                this.area = area;

            }

            public string Carnet

            {
                get

                {
                    return carnet;

                }

                set

                {
                    if( value.Length==10)

                    {
                        carnet = value;


                    }

                    else

                    {

                        Console.WriteLine("No. de carnet invaldio, el No. de carnet debe de tener 10 carácteres");

                    }


                }
            }

            public string Area

            {
                get

                {

                    return area;

                }

                set

                {
                    if(value.Length>5)

                    {

                        area = value;

                    }

                    else

                    {

                        Console.WriteLine("No se ha ingresado un area valida");

                    }


                }


            }

            public void MostrarJunior()

            {
                Console.WriteLine($"Carnet de Junior: {Carnet}");

                Console.WriteLine();

                Console.WriteLine($"Area de trabajo actual de Junior: {Area}");



            }


        }

        static void Main(string[] args)

        {
            int opcion;

            Dictionary<string, Admin> Administradores = new Dictionary<string, Admin>();

            Dictionary<string,Junior> Comunes = new Dictionary<string,Junior>();

            bool correcto;

            do


            {
                Console.WriteLine("==REGISTRO DE USUARIOS==");

                Console.WriteLine();

                Console.WriteLine();

                Console.WriteLine("1. Registrar Administrador");

                Console.WriteLine();

                Console.WriteLine("2. Registrar Usuario Junior");

                Console.WriteLine();

                Console.WriteLine("3. Mostrar Informacion de usuarios privilegiados");

                Console.WriteLine();

                Console.WriteLine("4. Mostrar informacion de usuarios junior");

                Console.WriteLine();

                Console.WriteLine("5. Salir del menú");

                Console.WriteLine();

                Console.Write("Ingrese la opción que desea utilizar:_ ");

                correcto = int.TryParse(Console.ReadLine(), out opcion);

                if (correcto != true)

                {
                    Console.WriteLine();

                    Console.WriteLine("No se ha ingresado una opcion valida");

                    Console.WriteLine();

                    Console.WriteLine("Presione enter para intentarlo nuevamente");

                    Console.WriteLine();

                    Console.ReadKey();

                    Console.Clear();

                }

                else if (correcto == true)
                {



                    switch (opcion)

                    {
                        case 1:

                            Console.Clear();

                            Console.WriteLine("==BIENVENIDO A LA OPCION REGISTRAR ADMINISTRADOR==");

                            Console.WriteLine();

                            Console.Write("Ingrese la clave de acceso del nuevo administrador:_ ");

                            string clave = Console.ReadLine();

                            string contraseña = clave;

                            Console.WriteLine();

                            Console.Write("Ingrese el nombre de usuario del administrador:_ ");

                            string nombre = Console.ReadLine();

                            Console.WriteLine();

                            Console.Write("Ingrese la dirección Ip: ");

                            string ip = Console.ReadLine();

                            Console.WriteLine();

                            Console.Write("Ingrese nivel de administrador (bajo,medio,alto):_ ");

                            string nivel = Console.ReadLine();

                            Console.WriteLine();

                            Console.Write("Ingrese el estado del administrador (Activo/Inactivo):_ ");

                            string estado = Console.ReadLine();

                            Console.WriteLine();

                            Console.Write("Ingrese el rango del administrador (S,A,B,C,):_ ");

                            string rango = Console.ReadLine();

                            Console.WriteLine();

                            Console.WriteLine("Presione enter para terminar el registro");

                            Admin admini = new Admin(nombre, ip, nivel, estado, rango, contraseña);

                            Administradores.Add(clave, admini);

                            Console.ReadKey();

                            Console.Clear();

                            break;

                        case 2:

                            Console.Clear();

                            Console.WriteLine("==BIENVENIDO A LA OPCION REGISTRAR USUARIO JUNIOR==");

                            Console.WriteLine();

                            Console.Write("Ingrese el No. de carnet del usuario Junior:_ ");

                            string identificador = Console.ReadLine();

                            string carnet = identificador;

                            Console.WriteLine();

                            Console.Write("Ingrese el nombre de usuario del usuario Junior:_ ");

                            string nombrej = Console.ReadLine();

                            Console.WriteLine();

                            Console.Write("Ingrese la dirección Ip: ");

                            string ipj = Console.ReadLine();

                            Console.WriteLine();

                            Console.Write("Ingrese nivel de usuario Junior (bajo,medio,alto):_ ");

                            string nivelj = Console.ReadLine();

                            Console.WriteLine();

                            Console.Write("Ingrese el estado del usuario Junior (Activo/Inactivo):_ ");

                            string estadoj = Console.ReadLine();

                            Console.WriteLine();

                            Console.Write("Ingrese el area de trabajo actual del usuario Junior:_ ");

                            string area = Console.ReadLine();

                            Console.WriteLine();

                            Console.WriteLine("Presione enter para terminar el registro");

                            Junior j = new Junior(nombrej, ipj, nivelj, estadoj, identificador, area);

                            Comunes.Add(identificador, j);

                            Console.ReadKey();

                            Console.Clear();

                            break;


                        case 3:

                            Console.Clear();

                            Console.WriteLine("==BIENVENIDO A LA OPCION DE MOSTRAR INFORMACION DE USUARIOS PRIVILEGIADOS==");

                            Console.WriteLine();

                            Console.Write("Ingrese la contraseña de acceso del administrador del cual quiere ver la info:_ ");

                            string poscontra = Console.ReadLine();

                            if (Administradores.ContainsKey(poscontra))

                            {
                                Console.WriteLine();

                                Console.WriteLine("Acceso consedido");

                                Console.WriteLine();

                                Console.WriteLine($"La info del administrador con clave de acceso {poscontra} es la siguiente:");

                                Console.WriteLine();

                                Administradores[poscontra].MostrarUsuario();

                                Console.WriteLine();

                                Administradores[poscontra].MostrarAdmin();


                            }

                            else

                            {

                                Console.WriteLine();

                                Console.WriteLine("Acceso denegado, la contraseña de acceso ingresada no es válida");

                            }

                            Console.WriteLine();

                            Console.WriteLine("Presione enter para cerrar esta ventana");

                            Console.ReadKey();

                            Console.Clear();

                            break;

                        case 4:

                            Console.Clear();

                            Console.WriteLine("==BIENVENIDO A LA OPCION DE MOSTRAR INFORMACION DE USUARIOS JUNIOR==");

                            Console.WriteLine();

                            Console.Write("Ingrese el No. de carnet del usuario junior del cual quiere ver la info:_ ");

                            string poscarnet = Console.ReadLine();

                            if (Comunes.ContainsKey(poscarnet))

                            {
                                Console.WriteLine();

                                Console.WriteLine("Acceso consedido");

                                Console.WriteLine();

                                Console.WriteLine($"La info del usuario junior con No. de carnet {poscarnet} es la siguiente:");

                                Console.WriteLine();

                                Comunes[poscarnet].MostrarUsuario();

                                Console.WriteLine();

                                Comunes[poscarnet].MostrarJunior();


                            }

                            else

                            {

                                Console.WriteLine();

                                Console.WriteLine("Acceso denegado, el No. de carnet ingresado no es valido");

                            }

                            Console.WriteLine();

                            Console.WriteLine("Presione enter para cerrar esta ventana");

                            Console.ReadKey();

                            Console.Clear();

                            break;

                        case 5:

                            Console.Clear();

                            Console.WriteLine("Usted ha salido del menu :3");

                            break;

                        default:

                            Console.Clear();

                            Console.WriteLine("Usted no ha ingresado una opción válida");

                            Console.ReadKey();

                            Console.Clear();

                            break;

                    }
                }

            }

            while (opcion != 5);


        }
    }
}
