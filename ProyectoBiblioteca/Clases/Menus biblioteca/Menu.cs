﻿using ProyectoBiblioteca.Clases;
using ProyectoBiblioteca.Clases.Funciones_Consola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.ClasesTemp
{
    public class Menu
    {
        public void MenuInicio()
        {
            string[] opciones = { "Agregar libro", "Ver catálogo de libros", "Salir" };
            int opcionSeleccionada = 0;
            bool mostrarMenu = true;
            bool nuevaOpcionSeleccionada = true;

            FuncionesConsola.EstablecerTituloConsola("Menú");

            while (mostrarMenu)
            {
                /* Explicación 1
                    Muestra opciones del menú y resalta la seleccionada
                    Si opción está seleccionada:
                        Cambiar color de letra a negro
                        Cambiar color de fondo a gris
                */
                if (nuevaOpcionSeleccionada)
                {
                    Console.Clear();
                    Console.WriteLine("Menú:");
                    for (int i = 0; i < opciones.Length; i++)
                    {
                        Console.ForegroundColor = i == opcionSeleccionada ? ConsoleColor.Black : ConsoleColor.Gray;
                        Console.BackgroundColor = i == opcionSeleccionada ? ConsoleColor.Gray : ConsoleColor.Black;
                        string prefijo = i == opcionSeleccionada ? "> " : "";
                        Console.WriteLine(prefijo + opciones[i]);
                        
                        Console.ResetColor();
                    }
                    DecoradorConsola.Dibujar(opcionSeleccionada);
                    nuevaOpcionSeleccionada = false;
                }

                /* Explicación 2
                    Función que lee la próxima tecla presionada por el usuario en 
                    la consola y devuelve un objeto ConsoleKeyInfo. El parámetro true 
                    que se pasa a la función indica que la tecla presionada no debe 
                    mostrarse en la consola. 
                */
                ConsoleKeyInfo tecla = Console.ReadKey(true);

                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    if (opcionSeleccionada > 0)
                    {
                        opcionSeleccionada--;
                        nuevaOpcionSeleccionada = true;
                    }

                }

                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    if (opcionSeleccionada < opciones.Length - 1)
                    {
                        opcionSeleccionada++;
                        nuevaOpcionSeleccionada = true;
                    }
                }

                if (tecla.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine($"Seleccionaste la opción de {opciones[opcionSeleccionada]}.");

                    switch (opcionSeleccionada)
                    {
                        case 0:
                            // FUNCIÓN PARA INGRESAR LIBRO
                            break;
                        case 1:
                            // FUNCIÓN PARA MOSTRAR CATÁLOGO
                            break;
                        case 2:
                            // CAMBIAR A FUNCION SALIR
                            // CREARLA FuncionesConsola
                            Console.WriteLine("Presiona cualquier tecla para salir.");
                            Console.ReadKey();
                            break;
                        default:
                            break;
                    }
                    mostrarMenu = false;
                }
            }
        }
    }
}