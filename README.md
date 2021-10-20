# Roll-a-Ball_DiegoHiriart
## Ingeniería de Software
## ISWZ2104-01 Programación V
## 2021-Octubre-11

### Tarea semana 2 - Programación en Unity

### Descripción de GameObjects añadidos:

- Se añadió lo que esencialmente es un jugador, a continuación, se describen sus componentes y acciones en el juego:
- Componentes/Apecto
    - El cuerpo del jugador, por llamarlo de alguna manera, es un prisma rojo.
    - A la derecha del cubo, se ha creado un arma de color azul. Esta es un cilindro que sirve como el punto de donde se disparan los proyectiles. 
    - Existen 3 tipos de proyectiles, balas, granadas y cohete; son cápsulas, esferas y cilindros. Tienen diferentes comportamientos, pero todos estos son parte del tutorial, por lo que no se describirán a detalle las funcionalidades de estos.
- Funcionamiento
    - Se creó un nuevo script para el jugador. Este script utiliza clases creadas en el tutorial, y se basa en scripts del mismo para mover al jugador. El script 