# EV09 - Interfaces y manejo de excepciones en C#

## Información de la evidencia

- Evidencia: 220501097-04-AA1 – EV09
- Programa: Análisis y Desarrollo de Software (ADSO)
- Institución: SENA
- Lenguaje: C#

## Descripción

Este repositorio contiene dos proyectos de consola desarrollados en C#, con el objetivo de aplicar los conceptos de interfaces, programación orientada a objetos y manejo de excepciones.

## Reto 1 - Interfaces

Se desarrolló un reproductor de música simulado mediante la interfaz IMediaPlayer, implementada en la clase MusicPlayer.

El programa permite:

- Cargar canciones.
- Reproducir canciones.
- Pausar canciones.
- Detener canciones.
- Consultar la canción actual.

## Reto 2 - Excepciones

Se desarrolló un programa que valida que la edad ingresada por el usuario sea un número entero entre 0 y 120 años.

Se aplicaron los siguientes conceptos:

- Try, catch y finally.
- Múltiples bloques catch.
- Lanzamiento de excepciones con throw.
- Excepciones personalizadas.
- Validación de entradas.

## Ejecución

Para ejecutar el reto de interfaces:

`dotnet run --project RetoInterfaces`

Para ejecutar el reto de excepciones:

`dotnet run --project RetoExcepciones`

## Casos de prueba

| Entrada | Resultado esperado |
|---|---|
| 18 | Edad válida |
| 0 | Edad válida |
| 120 | Edad válida |
| hola | Error de formato |
| -5 | Edad inválida |
| 150 | Edad inválida |
| 999999999999 | Desbordamiento de entero |

## Conclusión

Esta actividad permitió fortalecer los conocimientos de programación orientada a objetos mediante la implementación de interfaces como contratos entre clases y el manejo de excepciones para controlar errores durante la ejecución de un programa.