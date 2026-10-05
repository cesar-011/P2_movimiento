## Ejercicio 5: Teletransporte con Coordenadas
* **Qué hemos utilizado:** Usamos grupos de tres números (llamados `Vector3`) para representar posiciones en el espacio 3D. Luego, le dijimos al juego que detectara cuándo pulsamos la barra espaciadora usando `Input.GetAxis()` para teletransportar un objeto a esa nueva posición.
<img width="678" height="396" alt="ej_5" src="https://github.com/user-attachments/assets/0df29e6d-d360-47fc-aa72-a130de5c5893" />


## Ejercicio 6: Controles Básicos y Mensajes
* **Qué hemos utilizado:** Aprendimos a detectar cuándo el jugador pulsa las flechas del teclado usando comandos como `Input.GetKey()` y `KeyCode`. Además, hicimos que el juego multiplicara la velocidad y nos mostrara el resultado como si fuera un mensaje de texto en la consola de Unity.
<img width="756" height="356" alt="ej_6" src="https://github.com/user-attachments/assets/fbf79b1d-511d-43dc-8326-0d3024edaf41" />


## Ejercicio 7: Cambiar los Ajustes del Juego
* **Qué hemos utilizado:** En lugar de escribir código, entramos en los ajustes internos de Unity (el *Input Manager*) para enseñarle al motor que, a partir de ahora, pulsar la tecla "H" significa "disparar".
<img width="1261" height="330" alt="ej_7" src="https://github.com/user-attachments/assets/3ac496fa-14f6-4b01-bdd2-e9c3182d982c" />


## Ejercicio 8: Movimiento Continuo y Puntos de Vista
* **Qué hemos utilizado:** Usamos la orden `Translate(x, y, z)` para hacer que un cubo se desplace de forma suave y continua. También descubrimos que no es lo mismo mover un objeto según su propia perspectiva (hacia *su* derecha) que según el mapa del mundo (hacia el "Este" global).
<img width="682" height="394" alt="ej_8" src="https://github.com/user-attachments/assets/8ac416f7-f2ee-4b0c-b27d-67f1c00a2940" />


## Ejercicio 9: Dos Jugadores en un Teclado
* **Qué hemos utilizado:** Configuramos los controles para que dos objetos distintos no se peleen por las mismas teclas. Usando `Input` y `Translate`, hicimos que un objeto obedeciera solo a las flechas direccionales y el otro respondiera solo a las letras WASD.
<img width="690" height="390" alt="ej_9" src="https://github.com/user-attachments/assets/5c7ad456-9afd-489a-be63-7115151f649b" />


## Ejercicio 10: El Truco para que el Juego no vaya a Tirones
* **Qué hemos utilizado:** Multiplicamos el movimiento por un valor llamado `Time.deltaTime`. Esto es un truco fundamental que hace que el objeto se mueva según el tiempo real del reloj, garantizando que el juego funcione a la misma velocidad en un ordenador viejo que en uno súper potente.
<img width="736" height="366" alt="ej_10" src="https://github.com/user-attachments/assets/d2949d4f-507e-4876-bb5e-6b6d052c44a1" />


## Ejercicio 11: Persecución a Velocidad Constante
* **Qué hemos utilizado:** Le enseñamos al cubo a perseguir a la esfera trazando una flecha imaginaria entre ellos. Usamos una herramienta matemática llamada "normalización" (`miVector.normalized`) para que el cubo corra siempre a la misma velocidad de persecución, sin importar si la esfera está a un metro o a un kilómetro de distancia.
<img width="736" height="366" alt="ej_11" src="https://github.com/user-attachments/assets/1371513e-35a5-457d-906f-6df695318802" />


## Ejercicio 12: Mirada Automática (Cámara de Seguridad)
* **Qué hemos utilizado:** Usamos un comando especial llamado `LookAt()`. Funciona como el motor de una cámara de seguridad: hace que el objeto gire la cabeza automáticamente para estar mirando siempre de frente a su objetivo (la esfera), aunque esta se mueva.
<img width="736" height="366" alt="ej_12" src="https://github.com/user-attachments/assets/551dce5a-c688-4682-a620-8bc73c297380" />


## Ejercicio 13: Controles de Coche y Láseres Invisibles
* **Qué hemos utilizado:** Programamos un control tipo "vehículo". El objeto acelera solo hacia adelante usando su propia brújula interna (`transform.forward`), y el jugador solo usa las teclas para girar el volante. Además, usamos `Debug.DrawRay` para dibujar un rayo láser que solo podemos ver los creadores del juego, lo que nos ayuda a comprobar hacia dónde está apuntando el objeto.
<img width="736" height="364" alt="ej_13" src="https://github.com/user-attachments/assets/ccabc2cf-d82b-4204-8737-c6829b9dd463" />

