Diego Hiriart León		2021-Octubre-11
Ingeniería de Software
ISWZ2104-01 Programación V

Tarea semana 2 - Programación en Unity

Descripción de GameObjects añadidos:

- Se añadió lo que esencialmente es un jugador con un arma, y una granada para completar los proyectiles que se hicieron para el tutorial, también se creó una UI para mostrar la munición. A continuación, se describen sus componentes y acciones en el juego:
- Componentes/Aspecto
    - El cuerpo del jugador, por llamarlo de alguna manera, es una esfera roja.
    - Encima de la esfera, se ha creado un arma de color azul. Esta es un cilindro que sirve como el punto de donde se disparan los proyectiles. 
    - Existen 3 tipos de proyectiles: balas, granadas y cohetes; son cápsulas grises, esferas verdes y cilindros cafés, respectivamente. Las balas y cohetes se hicieron en el tutorial, las granadas se añadieron para utilizar el campo de granadas que existe en la clase Stuff del tutorial que sirve como un inventario.
    - La UI solo indica la cantidad de balas, granadas, y cohetes restantes con textos.
- Funcionamiento
    - Se creó un nuevo script para el jugador llamado ScriptJugadorHiriart. Este script utiliza la clase Stuff creada en el tutorial, y se basa en scripts del mismo para mover al jugador y disparar. El script detecta las teclas que se están aplastando (w, a, s, d) para mover el jugador, y para saltar la barra espaciadora. Todos los movimientos se hacen mediante la aplicación de fuerzas en un FixedUpdate.
    - Para no tener munición ilimitada, se usa la clase Stuff creada en el tutorial para contar con un inventario, el inventario se inicializa en la función Start(). 
    - El método Update() llama a la función Disparar(), esta controla que si: se da un clic izquierdo se dispare una bala, un clic derecho dispara un misil, la tecla G lanza una granada. Las balas y los cohetes se generan en la posición del arma que está encima del jugador y se propulsan hacia adelante; las grandas se lanzan desde la izquierda del jugador y tienen un movimiento parabólico (se les aplica fuerza hacia adelante y arriba). Todos los proyectiles usan un script del tutorial que los destruye después de cierto tiempo. Cada vez que se usa un proyectil, se resta del atributo adecuado de la instancia de Stuff, que es el inventario del player; y si no hay más munición no se dispara o lanza nada.
    - El arma tiene un script (SeguirPlayer) que controla su giro (con las teclas Q y E) utilizando la función Rotate(). Su script también mantiene constantes la distancia y posición relativas del arma a la posición del player.
    - El script UIAmmo controla un Canvas de TextMeshPro que indica la cantidad de proyectiles que se tienen. Este accede al inventario que tiene el script ScriptJugadorHiriart para leer cuantas balas, granadas y cohetes se tienen, con estos datos se actualiza la UI constantemente.

- Nota: se utilizó la escena "Empty" para el tutorial y la creación de los objetos adicionales, solo los objetos adicionales descritos en este documento están habilitados, los demás se pueden activar para revisarlos. Los scripts del tutorial y los descritos aquí están en una carpeta llamada DiegoHiriart en la carpeta Scritps. 
