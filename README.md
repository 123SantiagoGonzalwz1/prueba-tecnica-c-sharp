# Prueba Técnica en C# 🧪

Este proyecto resuelve tres ejercicios técnicos utilizando el lenguaje C#. Cada ejercicio está en su propia clase para mantener una estructura modular y clara.

---

## 📋 Índice

1. [Ejercicio 1: Tablero de Damas](#ejercicio-1-tablero-de-damas)
2. [Ejercicio 2: Dos elementos del arreglo que suman 10](#ejercicio-2-elementos-del-arreglo-que-suman-10)
3. [Ejercicio 3: Movimiento en una matriz 4x4](#ejercicio-3-movimiento-en-una-matriz-4x4)
4. [Cómo ejecutar el programa](#cómo-ejecutar-el-programa)

---

## 🧠 Ejercicio 1: Tablero de Damas

Este ejercicio imprime un tablero de damas (n x n) con las siguientes reglas:

- `"X"` representa una casilla negra.
- `"_"` representa una casilla blanca.
- La esquina superior izquierda siempre comienza con `"X"`.
- Si el usuario ingresa un número fuera del rango 1–10, se usa el valor por defecto de 7.

### 💡 Lógica usada:

- Se recorre la matriz con bucles anidados.
- Se imprime `"X"` o `"_"` alternadamente usando la fórmula: `(fila + columna) % 2 == 0`.

### 📝 Ejemplo de salida: Tablero de Damas (7x7)

```
*************Tablero de Damas**************

Ingresa el número de casillas (del 1 al 10)

7
X_X_X_X
_X_X_X_
X_X_X_X
_X_X_X_
X_X_X_X
_X_X_X_
X_X_X_X
```

---

## 🧠 Ejercicio 2: Elementos del arreglo que suman 10

Este ejercicio recorre un arreglo y encuentra la **primera pareja** de elementos cuya suma sea igual a 10.
Ambos números deben imprimirse de forma separada por un espacio (en el orden en que aparece en el arreglo).

### 💡 Lógica usada:

- Se usan dos bucles anidados para recorrer todas las combinaciones posibles.
- Al encontrar la primera pareja que cumple la condición, se imprimen los dos números y se finaliza la búsqueda.
- Si no se encuentra ninguna, se notifica al usuario.

### 📝 Ejemplo de salida: Dos elementos que suman 10

```
*************Dos números que al sumarlos den 10**************

Dado un array [1, 2, 3, 2, 7, 0], estos dos elementos suman 10

3 7
```

---

## 🧠 Ejercicio 3: Movimiento en una matriz 4x4

Este ejercicio simula el movimiento de una `"X"` dentro de una matriz 4x4, a partir de un conjunto de instrucciones contenidas en un arreglo.

### 💡 Reglas del movimiento:

- Cada dos elementos del arreglo representan un movimiento: horizontal (`X`) y vertical (`Y`).
- La posición de la `"X"` se actualiza de acuerdo con los valores, pero si algún movimiento excede los bordes de la matriz, la `"X"` se queda en el límite.
- Se imprime la matriz final con la `"X"` en su nueva posición y `"O"` en las demás.

### 💡 Lógica usada:

- Se usa un arreglo de 16 posiciones.
- Se calcula la posición con la fórmula: `fila * 4 + columna`.
- La matriz se limpia antes de cada nuevo movimiento.
- Al finalizar, se imprime en formato 4x4.

### 📝 Ejemplo de salida: Matriz 4x4 con un arreglo de movimientos de = { 4,2,-1,-1 }

```
*************Matriz 4x4***************
OOOO
OOXO
OOOO
OOOO
```

---

## ▶️ Cómo ejecutar el programa

1. Clonar o descargar el repositorio.
2. Abrir el proyecto en Visual Studio o Visual Studio Code.
3. Se uso Visual Studio 2022 y Net 8.0.
4. Compilar y ejecutar el programa.
5. En consola, selecciona una opción del menú:

```
*************Menu de Ejercicios**************

1. Tablero de Damas.

2. Elementos de un arreglo que sumados dan 10.

3. Movimientos en una matriz de 4x4.

4. Salir.

Por favor, selecciona un ejercicio:
```

---

## 🧑‍💻 Autor

**Santiago González**  
Desarrollador FullStack Web.
Contacto: [LinkedIn](https://linkedin.com/in/santiago-gonzález-bab0131b0/)
