using System;
using System.Globalization;

namespace EjerciciosCSharpConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Seleccione un ejercicio (1-20) o 0 para salir:");
                Console.WriteLine("1. Número positivo, negativo o cero");
                Console.WriteLine("2. Número par o impar");
                Console.WriteLine("3. Mayor de edad");
                Console.WriteLine("4. Múltiplo de 5");
                Console.WriteLine("5. Descuento por edad");
                Console.WriteLine("6. Calificación aprobatoria");
                Console.WriteLine("7. Día de la semana");
                Console.WriteLine("8. Número mayor entre dos");
                Console.WriteLine("9. Mayor entre tres números");
                Console.WriteLine("10. Clasificación de ángulos");
                Console.WriteLine("11. Cálculo de impuestos");
                Console.WriteLine("12. Clasificación de números");
                Console.WriteLine("13. Verificación de año bisiesto");
                Console.WriteLine("14. Conversión de calificaciones");
                Console.WriteLine("15. Comparación de tres longitudes");
                Console.WriteLine("16. Calculadora de descuentos");
                Console.WriteLine("17. Tipo de triángulo");
                Console.WriteLine("18. Evaluación de temperatura");
                Console.WriteLine("19. Conversión de horas a turnos");
                Console.WriteLine("20. Clasificación de IMC");

                string opcion = Console.ReadLine();
                if (int.TryParse(opcion, out int num) && num >= 1 && num <= 20)
                {
                    Console.Clear();
                    switch (num)
                    {
                        case 1: Ejercicio1(); break;
                        case 2: Ejercicio2(); break;
                        case 3: Ejercicio3(); break;
                        case 4: Ejercicio4(); break;
                        case 5: Ejercicio5(); break;
                        case 6: Ejercicio6(); break;
                        case 7: Ejercicio7(); break;
                        case 8: Ejercicio8(); break;
                        case 9: Ejercicio9(); break;
                        case 10: Ejercicio10(); break;
                        case 11: Ejercicio11(); break;
                        case 12: Ejercicio12(); break;
                        case 13: Ejercicio13(); break;
                        case 14: Ejercicio14(); break;
                        case 15: Ejercicio15(); break;
                        case 16: Ejercicio16(); break;
                        case 17: Ejercicio17(); break;
                        case 18: Ejercicio18(); break;
                        case 19: Ejercicio19(); break;
                        case 20: Ejercicio20(); break;
                    }
                    Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }
                else if (num == 0)
                {
                    salir = true;
                }
                else
                {
                    Console.WriteLine("Opción inválida. Presione cualquier tecla...");
                    Console.ReadKey();
                }
            }
        }

        static void Ejercicio1()
        {
            Console.Write("Ingrese un número: ");
            if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double numero))
            {
                Console.WriteLine(numero > 0 ? "Positivo" : numero < 0 ? "Negativo" : "Cero");
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
        }

        static void Ejercicio2()
        {
            Console.Write("Ingrese un número entero: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine(numero % 2 == 0 ? "Par" : "Impar");
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
        }

        static void Ejercicio3()
        {
            Console.Write("Ingrese su edad: ");
            if (int.TryParse(Console.ReadLine(), out int edad))
            {
                Console.WriteLine(edad >= 18 ? "Mayor de edad" : "Menor de edad");
            }
            else
            {
                Console.WriteLine("Edad inválida.");
            }
        }

        static void Ejercicio4()
        {
            Console.Write("Ingrese un número: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine(numero % 5 == 0 ? "Es múltiplo de 5" : "No es múltiplo de 5");
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
        }

        static void Ejercicio5()
        {
            Console.Write("Ingrese su edad: ");
            if (int.TryParse(Console.ReadLine(), out int edad))
            {
                Console.WriteLine(edad > 60 ? "Aplica descuento del 50%" : "No aplica descuento");
            }
            else
            {
                Console.WriteLine("Edad inválida.");
            }
        }

        static void Ejercicio6()
        {
            Console.Write("Ingrese la calificación (0-100): ");
            if (int.TryParse(Console.ReadLine(), out int calificacion) && calificacion >= 0 && calificacion <= 100)
            {
                Console.WriteLine(calificacion >= 60 ? "Aprobó" : "Reprobó");
            }
            else
            {
                Console.WriteLine("Calificación inválida.");
            }
        }

        static void Ejercicio7()
        {
            Console.Write("Ingrese un número del 1 al 7: ");
            if (int.TryParse(Console.ReadLine(), out int dia) && dia >= 1 && dia <= 7)
            {
                string resultado = dia switch
                {
                    1 => "Lunes",
                    2 => "Martes",
                    3 => "Miércoles",
                    4 => "Jueves",
                    5 => "Viernes",
                    6 => "Sábado",
                    7 => "Domingo",
                    _ => "Inválido"
                };
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
        }

        static void Ejercicio8()
        {
            Console.Write("Ingrese el primer número: ");
            if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double num1))
            {
                Console.Write("Ingrese el segundo número: ");
                if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double num2))
                {
                    Console.WriteLine(num1 > num2 ? $"{num1} es mayor" : num2 > num1 ? $"{num2} es mayor" : "Son iguales");
                }
                else
                {
                    Console.WriteLine("Segundo número inválido.");
                }
            }
            else
            {
                Console.WriteLine("Primer número inválido.");
            }
        }

        static void Ejercicio9()
        {
            Console.Write("Ingrese el primer número: ");
            if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double num1))
            {
                Console.Write("Ingrese el segundo número: ");
                if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double num2))
                {
                    Console.Write("Ingrese el tercer número: ");
                    if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double num3))
                    {
                        double mayor = Math.Max(num1, Math.Max(num2, num3));
                        Console.WriteLine($"El mayor es {mayor}");
                    }
                    else
                    {
                        Console.WriteLine("Tercer número inválido.");
                    }
                }
                else
                {
                    Console.WriteLine("Segundo número inválido.");
                }
            }
            else
            {
                Console.WriteLine("Primer número inválido.");
            }
        }

        static void Ejercicio10()
        {
            Console.Write("Ingrese el ángulo en grados: ");
            if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double angulo))
            {
                string resultado = angulo < 90 ? "Agudo" : angulo == 90 ? "Recto" : angulo < 180 ? "Obtuso" : angulo == 180 ? "Llano" : "Inválido";
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("Ángulo inválido.");
            }
        }

        static void Ejercicio11()
        {
            Console.Write("Ingrese su salario mensual: ");
            if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double salario))
            {
                double impuestoRate = salario < 10000 ? 0 : salario <= 30000 ? 0.10 : 0.20;
                double impuesto = salario * impuestoRate;
                Console.WriteLine($"Impuesto: {impuesto:F2}");
            }
            else
            {
                Console.WriteLine("Salario inválido.");
            }
        }

        static void Ejercicio12()
        {
            Console.Write("Ingrese el primer número: ");
            if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double num1))
            {
                Console.Write("Ingrese el segundo número: ");
                if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double num2))
                {
                    Console.Write("Ingrese el tercer número: ");
                    if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double num3))
                    {
                        bool todosPositivos = num1 > 0 && num2 > 0 && num3 > 0;
                        bool todosNegativos = num1 < 0 && num2 < 0 && num3 < 0;
                        bool hayCeros = num1 == 0 || num2 == 0 || num3 == 0;
                        string resultado = todosPositivos ? "Todos positivos" : todosNegativos ? "Todos negativos" : hayCeros ? "Hay ceros" : "Mixtos";
                        Console.WriteLine(resultado);
                    }
                    else
                    {
                        Console.WriteLine("Tercer número inválido.");
                    }
                }
                else
                {
                    Console.WriteLine("Segundo número inválido.");
                }
            }
            else
            {
                Console.WriteLine("Primer número inválido.");
            }
        }

        static void Ejercicio13()
        {
            Console.Write("Ingrese un año: ");
            if (int.TryParse(Console.ReadLine(), out int anio))
            {
                bool esBisiesto = (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);
                Console.WriteLine(esBisiesto ? "Bisiesto" : "No bisiesto");
            }
            else
            {
                Console.WriteLine("Año inválido.");
            }
        }

        static void Ejercicio14()
        {
            Console.Write("Ingrese la calificación (0-100): ");
            if (int.TryParse(Console.ReadLine(), out int calificacion) && calificacion >= 0 && calificacion <= 100)
            {
                string letra = calificacion >= 90 ? "A" : calificacion >= 80 ? "B" : calificacion >= 70 ? "C" : calificacion >= 60 ? "D" : "F";
                Console.WriteLine(letra);
            }
            else
            {
                Console.WriteLine("Calificación inválida.");
            }
        }

        static void Ejercicio15()
        {
            Console.Write("Ingrese la primera longitud: ");
            if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double lado1))
            {
                Console.Write("Ingrese la segunda longitud: ");
                if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double lado2))
                {
                    Console.Write("Ingrese la tercera longitud: ");
                    if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double lado3))
                    {
                        bool formaTriangulo = lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1;
                        Console.WriteLine(formaTriangulo ? "Puede formar un triángulo" : "No puede formar un triángulo");
                    }
                    else
                    {
                        Console.WriteLine("Tercera longitud inválida.");
                    }
                }
                else
                {
                    Console.WriteLine("Segunda longitud inválida.");
                }
            }
            else
            {
                Console.WriteLine("Primera longitud inválida.");
            }
        }

        static void Ejercicio16()
        {
            Console.Write("Ingrese el precio del producto: ");
            if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double precio))
            {
                double descuentoRate = precio < 50 ? 0 : precio <= 100 ? 0.05 : 0.10;
                double precioFinal = precio * (1 - descuentoRate);
                Console.WriteLine($"Precio con descuento: {precioFinal:F2}");
            }
            else
            {
                Console.WriteLine("Precio inválido.");
            }
        }

        static void Ejercicio17()
        {
            Console.Write("Ingrese el primer lado: ");
            if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double lado1))
            {
                Console.Write("Ingrese el segundo lado: ");
                if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double lado2))
                {
                    Console.Write("Ingrese el tercer lado: ");
                    if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double lado3))
                    {
                        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
                        {
                            string tipo = lado1 == lado2 && lado2 == lado3 ? "Equilátero" : (lado1 == lado2 || lado2 == lado3 || lado1 == lado3) ? "Isósceles" : "Escaleno";
                            Console.WriteLine(tipo);
                        }
                        else
                        {
                            Console.WriteLine("No forma un triángulo.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tercer lado inválido.");
                    }
                }
                else
                {
                    Console.WriteLine("Segundo lado inválido.");
                }
            }
            else
            {
                Console.WriteLine("Primer lado inválido.");
            }
        }

        static void Ejercicio18()
        {
            Console.Write("Ingrese la temperatura en °C: ");
            if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double temp))
            {
                string mensaje = temp < 0 ? "Hace mucho frío" : temp <= 20 ? "Clima fresco" : temp <= 30 ? "Clima agradable" : "Hace mucho calor";
                Console.WriteLine(mensaje);
            }
            else
            {
                Console.WriteLine("Temperatura inválida.");
            }
        }

        static void Ejercicio19()
        {
            Console.Write("Ingrese la hora (0-23): ");
            if (int.TryParse(Console.ReadLine(), out int hora) && hora >= 0 && hora <= 23)
            {
                string turno = hora >= 6 && hora <= 11 ? "Mañana" : hora >= 12 && hora <= 17 ? "Tarde" : hora >= 18 && hora <= 23 ? "Noche" : "Madrugada";
                Console.WriteLine(turno);
            }
            else
            {
                Console.WriteLine("Hora inválida.");
            }
        }

        static void Ejercicio20()
        {
            Console.Write("Ingrese el peso en kg: ");
            if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double peso) && peso > 0)
            {
                Console.Write("Ingrese la altura en metros: ");
                if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double altura) && altura > 0)
                {
                    double imc = peso / (altura * altura);
                    string clasificacion = imc < 18.5 ? "Bajo peso" :
                                          imc <= 24.9 ? "Normal" :
                                          imc <= 29.9 ? "Sobrepeso" : "Obesidad";
                    Console.WriteLine($"IMC: {imc:F2} - Clasificación: {clasificacion}");
                }
                else
                {
                    Console.WriteLine("Altura inválida. Debe ser un número positivo mayor que 0.");
                }
            }
            else
            {
                Console.WriteLine("Peso inválido. Debe ser un número positivo mayor que 0.");
            }
        }
    }
}
