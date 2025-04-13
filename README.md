# 🛡️ Battle City 3D - Mini Juego con Tanques
Integrantes : Mathias Muñoz,
              Nicolas San Martin,
              Eduardo Melgarejo
              
Docente: RODRIGO ALEXIS VENEGAS MUÑOZ

Este es un mini juego 3D desarrollado como parte del **Trabajo 1** del curso. El objetivo es construir una réplica básica del clásico **Battle City Tank**, con elementos modernos en un entorno tridimensional, utilizando **Unity3D**.

---

## 🎯 Objetivo del Juego

Controlás un tanque en una plataforma tipo laberinto 3D. Debés buscar y destruir 5 objetivos que se mueven dentro del escenario. Al apuntar correctamente y disparar, podés eliminarlos y ganar puntos. La dificultad es configurable y el número de disparos necesarios para destruir cada objetivo dependerá del nivel seleccionado.

---

## 🧱 Características Implementadas

✅ 1. **Escenario tipo laberinto 3D** construido con objetos simples organizados en jerarquías.  
✅ 2. **Tanque controlable** con rotación y desplazamiento; destruir objetivos usando colisiones.  
✅ 3. **Objetivos en movimiento**: se desplazan entre puntos definidos usando funciones matemáticas.  
✅ 4. **Spawns aleatorios**: los objetivos aparecen en 5 posiciones definidas aleatoriamente al iniciar el juego.  
✅ 5. **Materiales básicos aplicados** a tanques, paredes, proyectiles, pisos y objetivos.  
✅ 6. **Sistema de puntuación**: la cantidad de objetivos destruidos se guarda en una variable que se muestra en consola cada 3 segundos. También se imprime al inicio del juego con la última puntuación guardada.  
✅ 7. **Selector de dificultad (switch)** en el inspector:
- 1 Disparo para dificultad *Fácil*  
- 2 Disparos para *Media*  
- 3 Disparos para *Difícil*  
✅ 8. **Proyecto versionado con Git**  
✅ 9. `.gitignore` configurado para proyectos Unity  
✅ 10. Proyecto subido a [GitHub](https://github.com/eduardomelgarejo/juego_de_tank.git) ✅

## 🧱 Como moverse

tecla w: hacia adelante
tecla d: hacia la derecha
tecla a: para la izquierda
tecla s: para la derecha

click izquierdo:disparar 

---

## 🕹️ Cómo ejecutar el juego

1. Cloná el repositorio:
   ```bash
   git clone (https://github.com/eduardomelgarejo/juego_de_tank.git)

