# FlockIt

proyecto de prueba para FlockIT
dentro del mismo, se encuentran dos proyectos, uno el general, donde se encontraran los diferentes controladores de las API.

**Proyecto Flockit:**

LoginController:
Metodo POST, 
se pasan los datos de usuario para login, en caso de no pasar nada, devuelve error 400

ProvincesController:
metodo GetAsync,
se pasa el nombre de la provincia, y en caso de encontrarlo, de vuelve los datos correspondientes parseados en la entidad GeoRef

para probar, se debe instanciar el proyecto en un visual studio, preferentemente version 2019 en adelante, y darle a ejecutar
esto abrira un Swagger con todos los metodos existentes dentro del proyecto para probar

**Proyecto Flockit-test:**

en el mismo se encuentra el archivo UnitTest1
en el cual se podra encontrar los diferentes examenes correspondientes al proyecto.
primero se encuentra el NotNullControllerTest en el cual se testea de que se inicializa y existe el controlador de Provinces
segundo el GetProvinceTest en el cual  se pasa un nombre de provincia y en el caso de que exista y devuelva un valor, aprueba
tercero, LoginTestTrue, donde se pasan los datos de un usuario y asierta si tuvo respuestas.
