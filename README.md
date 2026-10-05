## Ejercicio 5: Teletransporte con Coordenadas
* **Qué hemos utilizado:** Usamos grupos de tres números (llamados `Vector3`) para representar posiciones en el espacio 3D[cite: 2]. Luego, le dijimos al juego que detectara cuándo pulsamos la barra espaciadora usando `Input.GetAxis()` para teletransportar un objeto a esa nueva posición[cite: 2].

## Ejercicio 6: Controles Básicos y Mensajes
* **Qué hemos utilizado:** Aprendimos a detectar cuándo el jugador pulsa las flechas del teclado usando comandos como `Input.GetKey()` y `KeyCode`[cite: 2]. Además, hicimos que el juego multiplicara la velocidad y nos mostrara el resultado como si fuera un mensaje de texto en la consola de Unity[cite: 2].

## Ejercicio 7: Cambiar los Ajustes del Juego
* **Qué hemos utilizado:** En lugar de escribir código, entramos en los ajustes internos de Unity (el *Input Manager*) para enseñarle al motor que, a partir de ahora, pulsar la tecla "H" significa "disparar"[cite: 2]. 

## Ejercicio 8: Movimiento Continuo y Puntos de Vista
* **Qué hemos utilizado:** Usamos la orden `Translate(x, y, z)` para hacer que un cubo se desplace de forma suave y continua[cite: 2, 3]. También descubrimos que no es lo mismo mover un objeto según su propia perspectiva (hacia *su* derecha) que según el mapa del mundo (hacia el "Este" global)[cite: 3].

## Ejercicio 9: Dos Jugadores en un Teclado
* **Qué hemos utilizado:** Configuramos los controles para que dos objetos distintos no se peleen por las mismas teclas[cite: 3]. Usando `Input` y `Translate`, hicimos que un objeto obedeciera solo a las flechas direccionales y el otro respondiera solo a las letras WASD[cite: 3].

## Ejercicio 10: El Truco para que el Juego no vaya a Tirones
* **Qué hemos utilizado:** Multiplicamos el movimiento por un valor llamado `Time.deltaTime`[cite: 4]. Esto es un truco fundamental que hace que el objeto se mueva según el tiempo real del reloj, garantizando que el juego funcione a la misma velocidad en un ordenador viejo que en uno súper potente[cite: 3, 4].

## Ejercicio 11: Persecución a Velocidad Constante
* **Qué hemos utilizado:** Le enseñamos al cubo a perseguir a la esfera trazando una flecha imaginaria entre ellos[cite: 4]. Usamos una herramienta matemática llamada "normalización" (`miVector.normalized`) para que el cubo corra siempre a la misma velocidad de persecución, sin importar si la esfera está a un metro o a un kilómetro de distancia[cite: 4].

## Ejercicio 12: Mirada Automática (Cámara de Seguridad)
* **Qué hemos utilizado:** Usamos un comando especial llamado `LookAt()`[cite: 4]. Funciona como el motor de una cámara de seguridad: hace que el objeto gire la cabeza automáticamente para estar mirando siempre de frente a su objetivo (la esfera), aunque esta se mueva[cite: 4].

## Ejercicio 13: Controles de Coche y Láseres Invisibles
* **Qué hemos utilizado:** Programamos un control tipo "vehículo". El objeto acelera solo hacia adelante usando su propia brújula interna (`transform.forward`), y el jugador solo usa las teclas para girar el volante[cite: 4, 5]. Además, usamos `Debug.DrawRay` para dibujar un rayo láser que solo podemos ver los creadores del juego, lo que nos ayuda a comprobar hacia dónde está apuntando el objeto[cite: 5].
