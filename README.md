# LP1 - Apuntes

En esta primera semana se trataron conceptos sobre la representación de la información mediante estados binarios utilizados por las computadoras. Esta información puede ser procesada mediante una serie de instrucciones organizadas en algoritmos y expresadas a través de **lenguajes** de programación. También se analizaron mecanismos de traducción, como compiladores e intérpretes, que permiten transformar o ejecutar el código escrito por el programador.

---

### Lenguaje de programación:

Es un lenguaje formal que permite expresar instrucciones, algoritmos, datos y estructuras que pueden ser procesados por una computadora mediante una implementación del lenguaje.

Como todo lenguaje formal, posee reglas y estructuras. Entre las más importantes se encuentran:

- **Sintaxis:** determina cómo debe escribirse correctamente el código.
- **Semántica:** determina qué significa ese código.
- **Símbolos y palabras reservadas:** elementos utilizados para construir las instrucciones.
- **Reglas de tipos y estructuras:** determinan cómo pueden utilizarse y combinarse los datos.

### Propiedades o características de un lenguaje de programación:

Son cualidades que determinan cómo está diseñado un lenguaje, cómo se utiliza y qué características ofrece al programador.

Algunas pueden ser:

- **Legibilidad:** facilidad para comprender el código.
- **Simplicidad:** cantidad y complejidad de reglas y estructuras.
- **Portabilidad:** facilidad para utilizar el código en diferentes plataformas.
- **Eficiencia:** capacidad para utilizar adecuadamente los recursos y obtener buen rendimiento.
- **Mantenibilidad:** facilidad para modificar y mantener el código.
- **Abstracción:** capacidad para ocultar detalles complejos del hardware o de la implementación.

---

### Código Binario:

El sistema binario utiliza únicamente dos valores:

**0 y 1**

La unidad mínima de información digital es el **bit** (_binary digit_), que puede representar uno de dos estados lógicos.

Los bits pueden agruparse para representar diferentes tipos de información. Dependiendo de las reglas de interpretación utilizadas, pueden representar números, caracteres, colores, instrucciones, etc.

Es importante distinguir:

**Binario ≠ código máquina**

El binario es una forma de representación mediante `0` y `1`, mientras que el código máquina consiste en instrucciones codificadas que una arquitectura de procesador puede ejecutar directamente.

Por ejemplo:

```text
Código máquina → CPU
```

```text
1010 = 10
```

| 1   | 0   | 1   | 0    |
| --- | --- | --- | ---- |
| 2³  | 2²  | 2¹  | 2⁰   |
| 8   | 4   | 2   | 1    |
| ↓   |     | ↓   |      |
| 8   | +   | 2   | = 10 |

> **Nota:** Se toman únicamente las posiciones donde aparece `1`.

---

### Lenguaje de Bajo Nivel:

Los lenguajes de bajo nivel tienen una mayor cercanía con la arquitectura del hardware y proporcionan menos abstracciones que los lenguajes de alto nivel.

**Ejemplos:** _Lenguaje ensamblador, lenguaje máquina._

---

### Lenguaje de Alto Nivel:

Los lenguajes de alto nivel proporcionan un mayor nivel de abstracción y facilitan la expresión de algoritmos y estructuras complejas sin tener que trabajar directamente con los detalles de una arquitectura específica.

**Ejemplos:** _Python, Java, C#._

---

### Compiladores VS Interpretes:

Tanto los intérpretes como los compiladores son mecanismos utilizados para implementar lenguajes de programación y permitir la ejecución del código escrito por el programador.

**Compilador:** analiza el código fuente y lo transforma a otra representación, que puede ser código máquina, código objeto, código intermedio o bytecode, dependiendo del lenguaje y su implementación.

```text
Código fuente → Compilador → Código objeto / intermedio / máquina
```

**Intérprete:** ejecuta el programa mediante una implementación capaz de analizar y ejecutar el código o una representación del mismo durante la ejecución.

> **Nota:** Un compilador no necesariamente genera un archivo `.exe`, y "ejecutar línea por línea" es solamente una simplificación del funcionamiento de un intérprete.

---

### Memoria:

Durante el procesamiento de cualquier programa, la memoria juega un rol crucial para almacenar de forma temporal o permanente los datos y las instrucciones.

- **RAM (Memoria de Acceso Aleatorio):** es una memoria de trabajo **rápida y volátil**. Funciona como la **superficie de un escritorio físico**: ahí colocas los libros, papeles y herramientas con los que estás trabajando en este preciso instante. Al apagar la computadora, el contenido de la RAM se pierde.

- **Almacenamiento Persistente (SSD/HDD):** conserva los datos aunque la computadora se apague. Puede entenderse como el archivador donde se guardan los documentos para utilizarlos posteriormente.

---

### Sentencia, comando e instrucción:

Son conceptos relacionados con las acciones que un programa puede realizar, aunque no siempre significan exactamente lo mismo.

- **Instrucción:** orden que indica una operación que debe realizarse.
- **Sentencia:** construcción del lenguaje que representa una acción o declaración dentro del programa.
- **Comando:** orden dada a un sistema o programa para realizar una acción; se utiliza frecuentemente en terminales y sistemas operativos.

Ejemplo:

```csharp
int edad = 20;
```

En C#, esta línea constituye una **sentencia** que contiene una declaración y una asignación.

---

### Editor de texto:

Es un programa que permite crear y modificar archivos de texto.

En programación puede utilizarse para escribir código fuente.

**Ejemplos:** _Notepad, Notepad++, Vim, Visual Studio Code._

Un editor de código puede incluir funciones adicionales como:

- Resaltado de sintaxis.
- Autocompletado.
- Búsqueda y reemplazo.
- Extensiones.
- Navegación entre archivos.

---

### Entorno de Desarrollo de Software:

Es el conjunto de herramientas, programas y recursos utilizados para desarrollar software.

Puede incluir:

- Editor de código.
- Compilador.
- Depurador.
- Terminal.
- Bibliotecas.
- Sistema de control de versiones.
- Herramientas de pruebas.

---

### IDE (Entorno Integrado de Desarrollo):

Un **IDE (Integrated Development Environment)** es un entorno que integra diferentes herramientas de desarrollo dentro de una misma aplicación.

Puede incluir:

- Editor de código.
- Compilador.
- Depurador.
- Gestión de proyectos.
- Terminal.
- Herramientas de pruebas.
- Autocompletado.

**Ejemplo:** _Visual Studio._

### Entorno de desarrollo vs. IDE:

**Entorno de desarrollo:** concepto amplio que engloba las herramientas utilizadas para desarrollar software.

**IDE:** aplicación que integra varias de esas herramientas en un mismo entorno.

---

### Librerías vs Frameworks:

**Librería:** conjunto de código reutilizable que el programa puede utilizar para realizar determinadas tareas.

```text
Programa → llama a la librería
```

**Framework:** proporciona una estructura sobre la cual se desarrolla una aplicación y puede controlar parte del flujo de ejecución.

```text
Framework → controla parte del flujo → código del programador
```

> **Idea clave:** con una librería, el programa normalmente llama al código; con un framework, el framework puede llamar al código del programador.

---

### Estructura básica de un programa en C#:

Un programa de consola en C# puede contener elementos como:

```csharp
using System;

namespace MiPrograma
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hola");
        }
    }
}
```

Elementos principales:

- **`using`:** permite utilizar nombres de determinados espacios de nombres.
- **`namespace`:** organiza los tipos y evita conflictos entre nombres.
- **`class`:** define una clase.
- **`Main`:** punto de entrada tradicional de una aplicación.

---

### Namespace en C#:

Un **namespace** es una forma de organizar y agrupar tipos relacionados dentro de un programa.

Ayuda a evitar conflictos cuando diferentes clases, métodos u otros tipos tienen nombres iguales.

```csharp
namespace MiPrograma
{
    class Program
    {
    }
}
```

> **Nota:** un `namespace` no es lo mismo que una clase ni que una carpeta, aunque puede coincidir por convención con la estructura de carpetas del proyecto.

---

### Clase:

Una **clase** es una definición que establece los datos y comportamientos que pueden tener sus objetos.

Ejemplo:

```text
Clase: Persona

Propiedades:
- Nombre
- Edad

Métodos:
- Saludar()
- Caminar()
```

---

### Objeto:

Un **objeto** es una instancia concreta de una clase.

```text
Clase → Persona

Objetos:
- Pedro
- María
- Juan
```

Cada objeto puede tener sus propios valores para las propiedades definidas por la clase.

---

### Propiedad:

Una **propiedad** representa una característica o dato asociado a un objeto.

Ejemplo:

```text
Persona
├── Nombre
├── Edad
└── Ciudad
```

En este caso:

**Nombre, Edad y Ciudad → propiedades**

Mientras que acciones como:

**Saludar(), Caminar() → métodos**

---

### Estructuras de Control:

Son estructuras que permiten controlar el flujo de ejecución de un programa.

**Selección:**

```text
if
if - else
switch
```

**Repetición:**

```text
for
while
do - while
foreach
```

**Secuencia:** las instrucciones se ejecutan en el orden en que aparecen.

---

### Estructuras de Datos:

Son formas de organizar y almacenar datos para poder utilizarlos de manera eficiente.

Ejemplos en C#:

- **Array**
- **List<T>**
- **Dictionary<TKey, TValue>**
- **Stack<T>**
- **Queue<T>**

> **Diferencia:** las estructuras de control organizan el **flujo de ejecución**, mientras que las estructuras de datos organizan los **datos**.

---

### Métodos de Búsqueda VS Métodos de Ordenación:

**Búsqueda:** consiste en localizar un elemento dentro de un conjunto de datos.

Ejemplos:

- Búsqueda lineal.
- Búsqueda binaria.

**Ordenación:** consiste en reorganizar los elementos siguiendo un criterio determinado.

Ejemplos:

- Bubble Sort.
- Selection Sort.
- Insertion Sort.
- Merge Sort.
- Quick Sort.

> **Idea clave:** buscar = **encontrar**; ordenar = **reorganizar**.

---

### Manejo de cadenas de caracteres:

Una **cadena de caracteres (`string`)** es una secuencia de caracteres.

Ejemplo:

```csharp
string nombre = "German";
```

Algunas operaciones comunes en C#:

```text
Length
ToUpper()
ToLower()
Contains()
StartsWith()
EndsWith()
Substring()
Replace()
Split()
Trim()
```

Permiten realizar operaciones como:

- Obtener la longitud.
- Cambiar mayúsculas y minúsculas.
- Buscar texto.
- Extraer partes de una cadena.
- Reemplazar caracteres o texto.
- Dividir una cadena.

---

## Conexión de los conceptos

```text
Lenguaje de programación
        ↓
Sintaxis y semántica
        ↓
Código fuente
        ↓
Editor / IDE
        ↓
Compilador / intérprete
        ↓
Programa
        ↓
Estructuras de control
        ↓
Estructuras de datos
        ↓
Clases / objetos / propiedades
        ↓
Ejecución
```

---
