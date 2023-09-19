using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace laboratorio_2_herramientas
{
    class Program
    {
        static void Main(string[] args)
        {


            //menu de seleccion
                int seleccion = 0;
            do
            {
                Console.WriteLine("EJERCICIOS LABORATORIO 2");
                Console.Write("Ingresa el numero del ejercicio, del 1 al 10. 11 PARA SALIR: ");
                seleccion = int.Parse(Console.ReadLine());

                switch (seleccion)
                {
                    case 1:
                        int operacion;


                        do
                        {
                            Console.WriteLine("CALCULADORA AVANZADA\nElige la operacion a realizar, \n1.Suma\n2.Resta\n3.Multiplicacion\n4.Divicion\n5.Potenciacion\n6.Raiz cuadrada.\n7.SALIR");

                            operacion = int.Parse(Console.ReadLine());

                            switch (operacion)
                            {
                                case 1:
                                    suma();
                                    break;
                                case 2:
                                    resta();
                                    break;
                                case 3:
                                    multiplicacion();
                                    break;
                                case 4:
                                    division();
                                    break;
                                case 5:
                                    potenciacion();
                                    break;
                                case 6:
                                    Raiz();
                                    break;

                            }
                        } while (operacion != 7);
                        break;
                    case 2:

                        int elegir;
                        do
                        {

                            Console.WriteLine("CONVERSION DE UNIDADES\n1.Longitud\n2.Peso.\n3.Volumen.\n4.Salir");
                            elegir = int.Parse(Console.ReadLine());

                            switch (elegir)
                            {
                                case 1:
                                    longitud();
                                    break;
                                case 2:
                                    Peso();
                                    break;
                                case 3:
                                    Volumen();
                                    break;
                            }
                        } while (elegir != 4);
                        break;
                    case 3:
                        Primo();


                        break;
                    case 4:
                        fibonacci();
                        break;
                    case 5:
                        Console.WriteLine("Calculo de area y perimetro\nIngresa la opción\n1.Circulo.\n2.Rectangulo\n.Triangulo");
                        int ap;
                        ap = int.Parse(Console.ReadLine());

                        switch (ap)
                        {
                            case 1:
                                circulo();
                                break;
                            case 2:
                                rectangulo();
                                break;
                            case 3:
                                triangulo();
                                break;
                        }

                        break;
                    case 6:
                        IMC();
                        break;
                    case 7:
                        int selection;
                        
                        Console.WriteLine("Conversor de temperatura\nSeleccione una opción\n1.Celsius.\n2.Farenheit.\n3.kelvin");
                        selection = int.Parse(Console.ReadLine());

                        switch (selection)
                        {
                            case 1:
                                celsius();
                                break;
                            case 2:
                                farenheit();
                                break;
                            case 3:
                                kelvin();
                                break;


                        }

                        break;
                    case 8:
                        //calculo de fecha de nacimiento
                        Console.WriteLine("CALCULO DE EDAD\nIngresa la fecha de nacimiento en formato yyyy-mm-dd: ");
                        DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());
                        int year = edad(fechaNacimiento);
                        Console.WriteLine($"Su edad en años es {year}");
                        break;
                    case 9:
                        palindromo();
                        break;
                    case 10:
                        int lon_contrasena;
                        Console.WriteLine("GENERADOR CONTRASENAS\nIngresa la longitud de la contraseña");
                        lon_contrasena = int.Parse(Console.ReadLine());
                        string new_password = contrasenas(lon_contrasena);

                        Console.WriteLine("La contraseña generada es: " + new_password);
                        break;
                }
            } while (seleccion != 11);
        }
        public static void suma()
        {
            float a;
            float b;
            Console.WriteLine("SUMA");
            Console.WriteLine("Ingresa un numero: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero: ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("LA SUMA ES " + (a + b));
        }
        public static void resta()
        {
            float a;
            float b;
            Console.WriteLine("RESTA");
            Console.Write("Ingresa un numero: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Ingresa otro numero: ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("LA RESTA ES " + (a - b));
        }
        public static void multiplicacion()
        {
            float a;
            float b;
            Console.WriteLine("MULTIPLICACION");
            Console.Write("Ingresa un numero: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Ingresa otro numero: ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("La multiplicacion de ambos es " + (a * b));
        }
        public static void division()
        {
            float a;
            float b;
            Console.WriteLine("DIVISION");
            Console.Write("Ingresa un numero: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Ingresa otro numero: ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("La division es: " + (a / b));
        }
        public static void potenciacion()
        {
            float a;
            float b;
            Console.Write("Ingresa la base: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Ingresa el exponente: ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("La potenciacion es: " + (Math.Pow(a, b)));
        }
        public static void Raiz()
        {
            float a;

            Console.WriteLine("RAIZ CUADRADA");

            Console.Write("Ingresaa el numero del radicando: ");
            a = float.Parse(Console.ReadLine());

            if (a >= 0)
            {
                Console.WriteLine($"RAIZ CUADRADA DE {a} es {Math.Sqrt(a)}");
            }
            else
            {
                Console.Write("No se le puede sacar raiz");
            }

        }
        public static void Peso()
        {
            float a;
            float gramos;
            float libra;
            Console.WriteLine("Ingresa la cantidad de klg: ");
            a = float.Parse(Console.ReadLine());

            libra = a * 2205;
            gramos = a * 1000;

            Console.WriteLine(a + " klg son: " + gramos + " gramos");
            Console.WriteLine(a + " klg son: " + libra + " libras");
        }
        public static void longitud()
        {
            //m to cm plus 100----m to pies plus 3281
            float a;
            int lon;
            float cm;
            float pies;
            Console.WriteLine("CONVERSION DE LONGITUDES\nIngresa la longitud en metros: ");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("1. CM\n2.PIES");
            lon = int.Parse(Console.ReadLine());

            switch (lon)
            {
                case 1:
                    cm = a * 100;
                    Console.WriteLine(a + " son " + cm + " centimetros");
                    break;
                case 2:
                    pies = a * 3281;
                    Console.WriteLine(a + " son " + pies + " pies");
                    break;
            }

        }
        public static void Volumen()
        {
            float a;
            float ml;
            double galon;
            int elegido;
            Console.WriteLine("CONVERSION DE VOLUMEN\nIngresa la cantidad de litros");
            a = float.Parse(Console.ReadLine());
            //l to mml *1000----l to gl 0,26
            Console.WriteLine("1.Ml\n2.Galon");
            elegido = int.Parse(Console.ReadLine());

            switch (elegido)
            {
                case 1:
                    ml = a * 1000;
                    Console.WriteLine(a + " l SON: " + ml + " mililitros");
                    break;
                case 2:
                    galon = a * 0.26;
                    Console.WriteLine(a + " l son " + galon + " galones");
                    break;
            }
        }
        public static void Primo()
        {
            Console.WriteLine("VALIDADOR NUMERO PRIMO\nIngresa un numero: ");
            int a;
            a = int.Parse(Console.ReadLine());

            if (a <= 1)
            {
                Console.WriteLine(a + " NO es primo");
            }else if(a == 2)
            {
                Console.WriteLine(a + " SI es numero primo");
            }else if(a %2 == 0)
            {
                Console.WriteLine(a + " NO es primo");
            }
            else
            {
                int limite = (int)Math.Floor(Math.Sqrt(a));

                //inicializa en 3
                for (int i = 3; i <= limite; i += 2)
                {
                    if (a % i == 0)
                    {
                        Console.WriteLine($"{a} no es un número primo.");
                        return;
                    }
                    
                }
                Console.WriteLine(a + " SI es primo");
            }
        
            

        }
        public static void fibonacci()
        {
            int cantidad;
            int v1 = 0;
            int v2 = 1;
            Console.Write("SECUENCIA FIBONACCI\nIngresa la cantidad de terminos a generar: ");
            cantidad = int.Parse(Console.ReadLine());

            Console.Write(v1+" ");

            for(int i =1; i <= cantidad; i++)
            {
                //
                int temp = v1;//temp  = 0
                v1 = v2;//v1 =  1
                v2 = temp+v1;//1 == 0+1==1

                //next 2
                //temp = 1
                //v1  = 1
                //v2 == 1+1==2


                //next 3
                //temp = 1;
                //v1==2
                //v2 = 1+2==3
                Console.Write(v1+" ");
            }
            

        }
        public static void circulo()
        {
            
            //area=pi*r*r perimetro=2*pi*r
            const  double Pi = 3.1416;
            double radio;
            double area;
            double perimetro;
            
            Console.WriteLine("CALCULO DE AREA Y PERIMETRO CIRCULO\nIngresa el valor del radio: ");
            radio = double.Parse(Console.ReadLine());
            area = Pi * radio * radio;
            perimetro = 2*Pi*radio;

            Console.WriteLine("EL area del circulo es: " + area);
            Console.WriteLine("El perimetro del circulo es: " + perimetro);
        }
        public static void rectangulo()
        {
            //area=largo x ancho--- perimetro =2*(largo+ancho)
            float largo;
            float ancho;
            float area;
            float perimetro;
            Console.WriteLine("AREA Y PERIMETRO DE RECTANGULO\nIngresa el largo del rectangulo");
            largo = float.Parse(Console.ReadLine());    
            Console.WriteLine("Ingresa el valor del ancho: ");
            ancho = float.Parse(Console.ReadLine());


            area = largo * ancho;
            perimetro = 2 * (largo + ancho);


            Console.WriteLine($"El area del rectangulo es: {area}\nEl perimetro del rectangulo es: {perimetro}");
        }
        public static void triangulo()
        {
            //area  y perimetro dependen de la longitud de sus lados
            float a;
            float b;
            float c;
            float a_a;
            float a_b;
            float a_c;
            float area;
            float perimetro;
            float lado_mayor;
            float lado_inter;
            float lado_menor;
            Console.WriteLine("AREA Y PERIMETRO DE TRIANGULO\nIngresa el valor de un lado1: ");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor del lado2: ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor del lado3: ");
            c = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor del angulo 1: ");
            a_a = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor del angulo 2: ");
            a_b = float.Parse(Console.ReadLine());

            a_c = 180 - a_b - a_a;


            //lado mayor
            lado_mayor = a;
            lado_menor = a;
            if (b > lado_mayor)
            {
                lado_mayor = b;
            } else if (c > lado_mayor)
            {
                lado_mayor = c;
            }

            //lado menor
            if (b < lado_menor)
            {
                lado_menor = b;
                lado_inter = c;
            } else if (c < lado_menor)
            {
                lado_menor = c;
                lado_inter = b;
            }
            else
            {
                lado_inter = a;
            }


            //area == (base*altura)/2
            //perimetro == suma de los tres lados
            if (a_a == 90 || a_b == 90 || a_c == 90)
            {
                Console.WriteLine("TRIANGULO RECTANGULO");
                area = (lado_inter * lado_menor) / 2;
                perimetro = a + b + c;
                Console.WriteLine($"El area del triangulo es {area}");
            } else if (a == b && a == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
                area = (float)((a * a) * Math.Sqrt(3)) / 4;
            } else{
                area = ((a + b + c) / 2);
            }
            perimetro = a + b + c;
            Console.WriteLine($"El perimetro del triangulo es: {perimetro}");





        }
        public static void IMC()
        {
            float peso;
            float imc;
            float altura;
            Console.WriteLine("CALCULO DE IMC\nIngresa el peso: ");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la altura : ");
            altura = float.Parse(Console.ReadLine());

            imc = peso / altura;
            Console.WriteLine("El IMC de una persona que pesa " + peso + " y tiene altura de " + altura + " es " + imc);

            if (imc < 18.5)
            {
                Console.WriteLine("DEBAJO DEL PESO SALUDABLE");
            }else if(imc >=18.5 && imc <= 24.9)
            {
                Console.WriteLine("PESO SALUDABLE");
            }else if(imc >=25 && imc <= 29.9)
            {
                Console.WriteLine("SOBREPESO");
            }
            else
            {
                Console.WriteLine("OBESIDAD");
            }


        }
        public static void celsius()
        {
            float celsius;
            float kelvin;
            float farenheit;
            Console.WriteLine("CONVERSOR CELSIUS");
            Console.WriteLine("Ingresa la temperatura en celsius: ");
            celsius = float.Parse(Console.ReadLine());

            farenheit = celsius * (9 / 5) + 32;
            kelvin = (float)(celsius + 273.15);

            Console.WriteLine(celsius + " celsius son: ");
            Console.WriteLine(farenheit + " grados farenheit");
            Console.WriteLine(kelvin + " grados kelvin ");

            
        }
        public static void farenheit()
        {
            float celsius;
            float kelvin;
            float farenheit;
            Console.WriteLine("CONVERSOR FARENHEIT\nIngresa la temperatura en farenheit");
            farenheit = float.Parse(Console.ReadLine());

            celsius = (farenheit - 32) * 5 / 9;
            kelvin = (float) (celsius + 273.15);

            Console.WriteLine(farenheit + " grados farenheit son \n" + celsius + " grados celsius\n" + kelvin + " grados kelvin");


        }
        public static void kelvin()
        {
            float celsius;
            float kelvin;
            float farenheit;
            Console.WriteLine("CONVERSOR TEMPERATURA DE KELVIN\nIngresa la temperatura en grados kelvin: ");
            kelvin = float.Parse(Console.ReadLine());

            farenheit = (float)(kelvin - 273.15) * 9 / 5 + 32;
            celsius = (float)(kelvin - 273.15);

            Console.WriteLine(kelvin + " grados kelvin equivale a: \n" + celsius + " grados celsius\n" + farenheit + " grados farenheit");

        }
       static int  edad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;//fecha actual
            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaNacimiento > fechaActual.AddYears(-edad))
            {
                edad--;
            }
            return edad;

        }
        public static void palindromo()
        {
            //ingresar palanbra
            string palabra;
            Console.WriteLine("Calcular Palindromo\nIngresa una palabra: ");
            palabra = Console.ReadLine();
            //limpiar espacios en bkanco y llevar a minuscula
            string limpiarCadena = palabra.Replace(" ", "").ToLower();
            //guardarla y reversar
            char[] cadena = palabra.ToCharArray();
            Array.Reverse(cadena);
            string palabra_reversada = new string (cadena);

            //verificar si es palindromo

            if(limpiarCadena == palabra_reversada)
            {
                Console.WriteLine(palabra + " es palindromo");

            }
            else
            {
                Console.WriteLine(palabra + " no es palindromo");
            }

        }
         static string contrasenas(int longitud)
        {
            
            string generada;
            const string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-=_+[]{}|;:',.<>?";
            

            StringBuilder contraseña = new StringBuilder();

            Random random = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int indiceAleatorio = random.Next(caracteresPermitidos.Length);
                contraseña.Append(caracteresPermitidos[indiceAleatorio]);
            }

            return contraseña.ToString();




        }
    }
}







