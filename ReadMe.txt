Diego Hiriart León		2021-Octubre-11
Ingeniería de Software
ISWZ2104-01 Programación V

Tarea semana 2 - Programación en Unity

Descripción de GameObjects añadidos:

- Se añadieron 2 GameObjects del mismo tipo, estos son obstáculos que se mueven en el mapa para dificultar la recolección de puntos
- Aspecto:
	- El objeto de obstáculo que se creó para el juego tiene un cilindro que actúa como objeto padre.
	- Tiene dos cubos, que son hijos del cilindro, cuya escala hace que simulen planchas las cuales cruzan el cilindro y forman una especie de X.
	- Todo el obstáculo tiene aplicado un material verde metálico.
- Funcionamiento
	- Ambos obstáculos giran en su propio eje con la función Rotate() de tal manera que puedan empujar a la esfera del jugador.
	- Los 2 obstáculos tienen un tipo de movimiento cada uno, son:
		1) Un movimiento circular alrededor de un punto, el cual dificulta subir a una plataforma para recolectar un punto. Se utilizó la función RotateAround para lograr esto, 
		el movimiento rotacional del objeto es continuo.
		2) Seguimiento de un camino. Se utilizan GameObjects vacíos en la escena para crear el camino usándolos como nodos. Para que siga el camino, se 
		añaden los nodos a un array de Transform que es una variable pública. En el código, se recorre el array para obtener la posición de estos transforms, que conforme 
		se avanza, indica la posición siguiente en la que el obstáculo debe estar. Una función definida por mí es llamada para que, usando MoveTowards(), el obstáculo 
		recorra los nodos. Cuando el camino se acaba, en el código se controla que se reinicie el recorrido para que el obstáculo siempre se mueva.
