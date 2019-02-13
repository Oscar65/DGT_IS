# DGT_IS

Prueba técnica de IS

Se me plantea diseñar una estructura de datos para la DGT que gestiona las infracciones y los puntos del carnet.

Esta aplicación está desarrollada en .NET C# sobre Windows 8.1 Pro.

El desarrollo se ha hecho con Visual Studio 2017 y la base de datos con SQL Server EXPRESS 2017.

Pasos para probar la aplicación:

1- Tener instalados Visual Studio y SQL Server.

2- Crear la base de datos: Tenemos que crear una nueva query en SQL Server, copiar el contenido del fichero
   Database DGTdb script.sql y ejecutar la query (el path donde graba los ficheros de la base de datos está en inglés,
   por lo que se puede dar el caso que se tenga que cambiar por un path correcto en nuestra máquina).

3- Cargar la solución DGT_IS con Visual studio. Una vez cargada pulsar F5.

4- Si hemos configurado SQL Server para entrar por Windows authentication no tenemos que hacer nada más que elegir el tipo de servidor
   (SQL Server o SQL Server EXPRESS). Si le hemos configurado para que entre por usuario y contraseña tendremos que modificar la cadena
   de conexión. Si nos diera error porque no deja cambiar la cadena de conexión tenemos que entrar en FrmDbConnection.cs y comentar la
   línea:

```
	 Properties.Settings.Default["DGTdbConnectionString"] = TbStingConexion.Text;
```

e ir a la pestaña Solution Explorer/Settings.settings, cambiar allí la cadena de conexión y volver a pulsar F5 y cuuando nos pregunte
la cadena de conexión modificarla con la nuestra (hace dos conexiones a la base de datos: Datasets y SqlConnection).

