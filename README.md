# CRM_Assessment
Assessment 6_CRM


REQUISITOS: 

En cuando a la idea de negocio, me pareció tener las ideas bastante claras: 

La aplicacion consta de: 
- Pagina login
- Pagina de gestión de oportunidades: 
	- Boton para añadir oportundiades: Se abrirá un formulario donde se podran añadir oportunidades. Este formulario tendra campos obligatorios, entre ellos el rellenar datos del primer contacto y el dni/cif de la entidad contactante. Este ultimo campo comprueba en la base de datos si ya hay una oportunidad con el mismo motivo y dni/cif para no duplicar oportunidades.
	- Se podrá ver el listado de oportunidades ordenado descendente por id para ver las ultimas creadas primero
	- En cada elemento del listado se podrá dar a detalles. Este link llevará a 'pagina detalles oportunidad'

- Pagina detalles oportunidad: muestra dos bloques, el primero todos los detalles de la oportunidad junto con un checkbox para indicar si esa oportunidad se ha convertido a cliente y el segundo un listado de contactos realizados en esa oportunidad ordenados descendente por id para ver los ultimos creados primero. Tendrá un boton para poder añadir más contactos relacionados a esa oportunidad.

- Pantalla Cliente: 
	- Se podrá ver el listado de clientes ordenado descendente por id para ver los ultimos creados primero. Tendrá tambien un buscador arriba para poder buscar clientes por los diferentes campos que puede tener un cliente (dni/cif, nombre, etc). 

	-En cada elemento del listado se podrá dar a detalles. Este link llevará a 'pagina detalles cliente'

-Pantalla detalles cliente: muestra dos bloques, el primero todos los detalles del cliente y el segundo un listado de oportunidades relacionadas a ese cliente (ya que puede estar interesado en mas productos de los que tengo) ordenados descendente por id para ver las ultimas creadas primero. Tendrá un boton para poder añadir más oportunidades directamente desde ahí que nos llevará al formulario anteriormente mencionado para crear oportunidad.

- Pantalla Agenda: Mostrará diferentes gráficas para ver de manera más visual los proximos contactos que habrá que realizar, pudiendo elegir que vista se quiere ver (calendario, kanbano o listado)



APLICACIONES: 

- VISUAL STUDIO - DOTNET C#: Se comienza creando una solucion con los siguientes proyectos dentro de SRC: 
	- Aplicacion: de momento tengo un DTO para las oportunidades
	- CRM Api: contiene los controladores, de momento controlador usuarios, clientes y oportunidades: contiene las llamadas a la base de datos SQL
	- Dominio: contiene todas las clases necesarias y la lógica

En cuanto a los Tests, se crean dos apartados: TestIntegracion (API) y TestUnitarios(logica)


- SSMS: Se trabaja con SQL Server para la creacion de base de datos
- VISUAL STUDIO CODE: React. 
	- Se utiliza para el FrontEnd. De momento creadas pantallas de Login y listado de oportunidades junto con sus CSS. Se utiliza AXIOS para la conexion con la API y ROUTER para crear diferentes 'pantallas'. 

- IntelliJ: Java-Maven. Se utiliza para realizar pruebas con SELENIUM del frontend. De momento realiza login. 




