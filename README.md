# DGT_IS

Prueba técnica de IS

Se me plantea diseñar una estructura de datos para la DGT que gestiona las infracciones y los puntos del carnet.

Esta aplicación está desarrollada en .NET C# sobre Windows 8.1 Pro.

El desarrollo se ha hecho con Visual Studio 2017 y la base de datos con SQL Server EXPRESS 2017.

Pasos para probar la aplicación:

1- Tener instalados Visual Studio 2017, SQL Server EXPRESS 2017 y Microsoft SQL Management Studio.

2- Crear la base de datos: Tenemos que abrir Microsoft SQL Management Studio y pulsar new query, copiar el contenido del fichero
   Database DGTdb script.sql y ejecutar la query con F5.

3- Cargar la solución DGT_IS con Visual studio 2017. Una vez cargada pulsar F5.

4- Si hemos configurado SQL Server EXPRESS para entrar por Windows authentication no tenemos que hacer nada. Si tenemos SQL Server
elegiremos en el tipo de servidor SQL Server. Si le hemos configurado para que entre por usuario y contraseña tendremos que modificar
la cadena de conexión. Si nos diera error porque no deja cambiar la cadena de conexión tenemos que entrar en FrmDbConnection.cs y
comentar la siguiente línea:

```
	 Properties.Settings.Default["DGTdbConnectionString"] = TbStingConexion.Text;
```

e ir a la pestaña Solution Explorer (View/Solution Explorer o pulsando las teclas Ctrl+Alt+L) en Visual Studio 2017, luego hacemos clic en Properties/Settings.settings. Cambiamos la cadena de conexión y volvemos a pulsar F5 y cuando nos pregunte la cadena de conexión
modificarla con la que necesita nuestro servidor SQL Server EXPRESS (hace dos conexiones a la base de datos: Datasets y SqlConnection).

