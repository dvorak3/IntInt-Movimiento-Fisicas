# Práctica: Ejercicio Físicas 3D en Unity

## Descripción

En esta práctica se experimenta con diferentes configuraciones de los componentes `Rigidbody` y `Collider` en Unity 3D. El objetivo es analizar el comportamiento físico y dinámico de tres objetos básicos (Plano, Cubo y Esfera) ante distintas variaciones de masa, fricción y propiedades cinemáticas o de *Trigger*.

## Hitos y Pruebas de Ejecución

### Situación 1

* **Configuración:** Plano (solo Collider), Cubo (Collider + Rigidbody), Esfera (solo Collider).

* **Resultado:** La esfera se mantiene flotando en el aire porque carece de componente físico (`Rigidbody`) que la someta a la gravedad. El cubo cae y reposa sobre el plano.

* **Prueba de ejecución:**
  ![Situación 1](gifs/situacion1.gif)

### Situación 2

* **Configuración:** Plano (solo Collider), Cubo (Collider + Rigidbody), Esfera (Collider + Rigidbody).

* **Resultado:** Ambos objetos (cubo y esfera) se ven afectados por la gravedad, caen y colisionan de forma realista.

* **Prueba de ejecución:**
  ![Situación 2](gifs/situacion2.gif)

### Situación 3

* **Configuración:** Plano (solo Collider), Cubo (Collider + Rigidbody), Esfera (Collider + Rigidbody Cinemático).

* **Resultado:** Al activar `Is Kinematic` en la esfera, esta deja de ser afectada por la gravedad y se queda flotando en el aire, aunque conserva sus propiedades de colisión.

* **Prueba de ejecución:**
  ![Situación 3](gifs/situacion3.gif)

### Situación 4

* **Configuración:** Plano (Collider + Rigidbody), Cubo (Collider + Rigidbody), Esfera (Collider + Rigidbody).

* **Resultado:** Al tener el plano un componente `Rigidbody` dinámico, la gravedad actúa sobre todos los elementos de la escena. El plano, el cubo y la esfera caen infinitamente hacia el vacío.

* **Prueba de ejecución:**
  ![Situación 4](gifs/situacion4.gif)

### Situación 5

* **Configuración:** Plano (Collider + Rigidbody Cinemático), Cubo (Collider + Rigidbody, Masa: 1), Esfera (Collider + Rigidbody, Masa: 10).

* **Resultado:** El plano vuelve a ser una superficie estática. La esfera, al tener 10 veces más masa que el cubo, lo desplaza con bastante fuerza tras el impacto.

* **Prueba de ejecución:**
  ![Situación 5](gifs/situacion5.gif)

### Situación 6

* **Configuración:** Plano (Collider + Rigidbody Cinemático), Cubo (Collider + Rigidbody, Masa: 1), Esfera (Collider + Rigidbody, Masa: 100).

* **Resultado:** La diferencia de masa es tan extrema que la esfera desplaza al cubo de forma violenta y casi sin perder su propio impulso.

* **Prueba de ejecución:**
  ![Situación 6](gifs/situacion6.gif)

### Situación 7

* **Configuración:** Plano (Collider + Rigidbody), Cubo (Collider + Rigidbody), Esfera (Collider + Rigidbody + Physic Material de fricción).

* **Resultado:** Al desmarcar `Is Kinematic` del plano, todos los objetos caen al unísono acelerados por la gravedad. Dado que no hay movimiento relativo entre ellos en el eje de caída, no llegan a chocar y el material de fricción no llega a aplicarse.

* **Prueba de ejecución:**
  ![Situación 7](gifs/situacion7.gif)

### Situación 8

* **Configuración:** Plano (Collider + Rigidbody Cinemático), Cubo (Collider + Rigidbody), Esfera (Collider \[Trigger\] + Rigidbody Cinemático).

* **Resultado:** La esfera funciona como un área de detección (Trigger) e ignora la gravedad (Kinematic), quedando suspendida en el aire sin interactuar físicamente con el entorno.

* **Prueba de ejecución:**
  ![Situación 8](gifs/situacion8.gif)

### Situación 9

* **Configuración:** Plano (Collider + Rigidbody Cinemático), Cubo (Collider + Rigidbody), Esfera (Collider \[Trigger\] + Rigidbody dinámico).

* **Resultado:** La gravedad vuelve a afectar a la esfera. Sin embargo, al ser un disparador (`Is Trigger`), pierde la capacidad de colisionar de forma sólida y atraviesa tanto el cubo como el plano como si fuera un fantasma.

* **Prueba de ejecución:**
  ![Situación 9](gifs/situacion9.gif)