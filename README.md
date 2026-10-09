##  Colaboradores
<a href="https://github.com/anmaribaphomet"> @anmaribaphomet</a><br>
<a href="https://github.com/Jimaxo2"> @Jimaxo2</a><br>
<a href="https://github.com/IsHectron"> @IsHectron</a><br>
<a href="https://github.com/ahectpaul"> @ahectpaul</a><br>
<a href="https://github.com/SantaCruzVelarde"> @SantaCruzVelarde</a><br>

Proyecto desarrollado como una aplicación de escritorio cliente para el juego Piedra, Papel o Tijera en la materia  Desarrollo de Sistemas 3

## PIEDRA, PAPEL Y TIJERA
El programa desarrollado consiste en un videojuego multijugador de Piedra, Papel o Tijera basado en una arquitectura cliente-servidor. El sistema permite que dos jugadores se conecten mediante una red, creen una cuenta o inicien sesión y participen en una partida en tiempo real.

#  PPT-Juego — Cliente
Aplicación de escritorio desarrollada en C# con Windows Forms para jugar **Piedra, Papel o Tijera** mediante una arquitectura cliente-servidor. El cliente proporciona la interfaz gráfica con la que los usuarios inician sesión, participan en partidas y consultan sus resultados, mientras que la comunicación y la coordinación del juego se realizan a través de un servidor.

## Descripción del proyecto

**PPT-Juego-Cliente** es el componente encargado de la interacción entre el usuario y el sistema de juego. Su función principal es presentar las pantallas, capturar las elecciones del jugador y comunicarse con el servidor para recibir las instrucciones y los resultados de cada partida.

La aplicación utiliza conexiones TCP para intercambiar mensajes con el servidor, permitiendo coordinar los turnos de los jugadores y mostrar el resultado final de cada enfrentamiento.

Este repositorio contiene únicamente el código del cliente. Para utilizar el sistema completo, es necesario contar también con el servidor correspondiente.
Solo ejecutamos el programa mientras exista un <a href="https://github.com/Jimaxo2/PPT-Juego-Servidor" target="_blank">servidor</a> activo con base de datos en SQL Server y que la ip a la que se conecte el cliente este correctamente agregada, si el servidor corre en la misma máquina que el cliente, la ip se queda en 127.0.0.1

## Interfaz Grafica
<img width="380" height="500" alt="image" src="https://github.com/user-attachments/assets/bdbf62d0-53f4-4a8f-ac4e-10aeece505c7" />
<img width="921" height="494" alt="image" src="https://github.com/user-attachments/assets/ead96417-c94a-444f-992c-c24f6a9f2a1d" />
<img width="921" height="496" alt="image" src="https://github.com/user-attachments/assets/3c5f45d6-2ce3-4f77-b5a0-67785e1cda4b" />
<img width="921" height="499" alt="image" src="https://github.com/user-attachments/assets/684abad8-5a8c-4841-babc-20c9e56815dc" />
<img width="921" height="463" alt="image" src="https://github.com/user-attachments/assets/c64fe353-3ead-47ec-9b1a-11067bb12e33" />


##  Funcionalidades

* **Inicio de sesión:** presenta la interfaz para que el usuario acceda al sistema.
* **Menú principal:** permite navegar por las opciones disponibles del juego.
* **Inicio de partida:** solicita una nueva partida al sistema y muestra una pantalla de espera mientras se coordina el enfrentamiento.
* **Selección de jugada:** permite al jugador realizar su elección durante su turno.
* **Comunicación en tiempo real con el servidor:** recibe instrucciones, mensajes y datos relacionados con la partida.
* **Visualización de resultados:** muestra las elecciones de los jugadores y el resultado del enfrentamiento.
* **Detección de ganador, perdedor o empate:** presenta la pantalla correspondiente según el resultado recibido.
* **Retorno al menú principal:** después de mostrar el resultado final, permite regresar al menú y comenzar otra partida.
* **Reconexión:** contempla el establecimiento de una nueva conexión para iniciar partidas posteriores.

##  Tecnologías utilizadas

| Tecnología           | Descripción                                                               |
| -------------------- | ------------------------------------------------------------------------- |
| C#                   | Lenguaje de programación del cliente.                                     |
| .NET / Windows Forms | Desarrollo de la aplicación de escritorio y sus interfaces gráficas.      |
| TCP (`TcpClient`)    | Establecimiento de la conexión con el servidor.                           |
| `NetworkStream`      | Envío y recepción de información mediante la conexión TCP.                |
| `System.Threading`   | Gestión de hilos para escuchar al servidor y realizar tareas de conexión. |
| `System.Text`        | Codificación de los mensajes intercambiados mediante UTF-8.               |

##  Estructura del proyecto

La solución está organizada en los siguientes archivos y carpetas:

```text
PPT-Juego-Cliente/
├── Properties/
│   └── Resources.resx
├── Media/
├── Models/
├── Panels/
│   ├── Empate.cs
│   ├── EsperaConfirmacion.cs
│   ├── Ganador.cs
│   ├── IniciarSesion.cs
│   ├── MenuPrincipal.cs
│   ├── PanelEleccion.cs
│   ├── Perdedor.cs
│   └── Resultado.cs
├── Resources/
├── CrearCuenta.cs
├── Form1.cs
├── Program.cs
├── .gitattributes
└── .gitignore
```

*La estructura anterior representa los elementos visibles en el explorador de soluciones; pueden existir archivos adicionales asociados a los formularios y recursos.*

### Descripción de los componentes

* **`Program.cs`:** punto de entrada de la aplicación.
* **`Form1.cs`:** formulario principal que administra la conexión TCP, recibe y procesa los mensajes del servidor, cambia las pantallas y coordina el flujo de la partida.
* **`CrearCuenta.cs`:** componente asociado a la creación de cuentas.
* **`Models/`:** carpeta destinada a los modelos de datos del cliente.
* **`Panels/`:** contiene los paneles que conforman las diferentes pantallas del juego.
* **`Properties/`:** contiene recursos y propiedades del proyecto.
* **`Media/` y `Resources/`:** carpetas destinadas a los recursos utilizados por la aplicación.

### Paneles principales

| Panel                | Función                                                        |
| -------------------- | -------------------------------------------------------------- |
| `IniciarSesion`      | Interfaz de inicio de sesión.                                  |
| `MenuPrincipal`      | Menú de navegación principal.                                  |
| `EsperaConfirmacion` | Pantalla de espera mientras se coordina la partida.            |
| `PanelEleccion`      | Interfaz para seleccionar una jugada.                          |
| `Resultado`          | Presentación de las elecciones y los resultados de la partida. |
| `Ganador`            | Pantalla mostrada cuando el usuario gana.                      |
| `Perdedor`           | Pantalla mostrada cuando el usuario pierde.                    |
| `Empate`             | Pantalla mostrada cuando la partida termina en empate.         |

##  Arquitectura cliente-servidor

El cliente se comunica con el servidor mediante una conexión TCP. En la implementación actual de `Form1.cs`, la conexión se establece utilizando la dirección `127.0.0.1` y el puerto `5000`.

El flujo general de una partida es el siguiente:

1. El cliente establece la conexión con el servidor.
2. Se presenta la pantalla de inicio de sesión.
3. El usuario accede al menú principal.
4. Al iniciar una partida, el cliente espera las instrucciones del servidor.
5. Cuando recibe la solicitud de jugada, muestra la pantalla de selección.
6. El cliente envía la elección realizada por el usuario.
7. El servidor procesa la partida y envía la información de las elecciones y el resultado.
8. El cliente muestra la pantalla correspondiente y permite volver al menú principal.

### Comunicación mediante mensajes

El cliente procesa mensajes de texto recibidos del servidor. Entre los comandos reconocidos en `Form1.cs` se encuentran:

| Comando             | Función                                                              |
| ------------------- | -------------------------------------------------------------------- |
| `PedirJugada`       | Solicita al cliente que presente la pantalla para elegir una jugada. |
| `ResultadoCompleto` | Envía la información de las elecciones de ambos jugadores.           |
| `Ganador`           | Comunica el resultado final del enfrentamiento.                      |
| `Mensaje`           | Actualiza el título de la ventana con un mensaje del servidor.       |

Los mensajes utilizan delimitadores de texto para separar comandos y argumentos. Por ello, el cliente y el servidor deben utilizar un protocolo de comunicación compatible.

##  Requisitos previos

Para ejecutar el cliente se requiere:

* Windows.
* Visual Studio con soporte para C# y Windows Forms.
* Una versión de .NET compatible con la configuración del proyecto.
* El servidor de PPT-Juego ejecutándose y accesible desde el cliente.

##  Instalación y ejecución

1. Clona este repositorio:

   ```bash
   git clone <URL_DEL_REPOSITORIO>
   ```

2. Abre la solución o el archivo de proyecto del cliente en Visual Studio.

3. Restaura las dependencias necesarias y compila el proyecto.

4. Inicia el servidor de PPT-Juego y verifica que esté escuchando en la dirección y el puerto configurados.

5. Ejecuta el proyecto cliente desde Visual Studio.

6. Inicia sesión y utiliza el menú principal para comenzar una partida.

###  Configuración de conexión

Actualmente, `Form1.cs` establece la conexión de la siguiente manera:

```csharp
client = new TcpClient("127.0.0.1", 5000);
stream = client.GetStream();
```

La dirección `127.0.0.1` corresponde al equipo local. Por lo tanto, si el servidor se ejecuta en otra computadora, será necesario cambiar esta dirección por la IP del equipo donde se encuentre el servidor y asegurarse de que el puerto `5000` sea accesible.

Si el servidor no está activo o no acepta conexiones, el cliente no podrá iniciar correctamente la comunicación.

## 📄 Estado del proyecto

El cliente cuenta con componentes para el inicio de sesión, la navegación entre pantallas, la selección de jugadas, la recepción de resultados y la reconexión entre partidas.

Su funcionamiento completo depende de la disponibilidad del servidor y de que ambos componentes mantengan una configuración y un protocolo de comunicación compatibles.



