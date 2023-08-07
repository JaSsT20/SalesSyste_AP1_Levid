# Sales system
![](https://levishop.azurewebsites.net)
![](https://raw.githubusercontent.com/JaSsT20/SalesSyste_AP1_Levid/main/Extras/LogoSmall.jpg)

Sales system, traducido al español **"Sistema de ventas"** es un sistema de ventas desarrollado en [blazor server](httphttps://learn.microsoft.com/es-es/aspnet/core/blazor/hosting-models?view=aspnetcore-7.0#blazor-server:// "blazor server") el usuario puede registrarse en el sistema y una vez registrado, podrá iniciar sesión permitiendole así registrar las ventas, de igual manera podrá registrar clientes habituales, productos, vendedores y por supuesto, las ventas que realizan, el sistema también le permite al usuario realizar consultas de todo lo ya mencionado y registrado en el sistema.

## Estructura del proyecto
El proyecto está estructurado en varias capas como lo son:
- [**Lógica de negocio (BLL)**:](https://github.com/JaSsT20/SalesSyste_AP1_Levid/tree/main/BLL "Lógica de negocio (BLL):") En esta se encuentra toda la lógica detrás de cada registro, cada modelo consta con su propia BLL. 
- [ **Capa de datos (DAL)**:](https://github.com/JaSsT20/SalesSyste_AP1_Levid/tree/main/Data " Capa de datos (DAL):") En esta se encuentran las migraciones realizadas y el DataContext del sistema.
- [**Capa de usuario (UI)**](https://github.com/JaSsT20/SalesSyste_AP1_Levid/tree/main/Pages "Capa de usuario (UI)"): Es la capa del frontend que se enfoca en la presentación de la información y la interacción con el usuario. 
## Relaciones
![](https://raw.githubusercontent.com/JaSsT20/SalesSyste_AP1_Levid/main/Extras/DiagramaBD.png)

## ¿Cómo probar el sistema?
Al ser un sistema desarrollado en blazor necesitaremos un par de cosas antes de poder correr el sistema sin problemas, a continuación se listará lo necesario para ello:
1. Debe tener instalado .NET Core, Blazor Server se basa en .NET Core, por lo que necesitas tener .NET Core instalado. [Puedes descargar .NET Core desde el sitio web oficial de Microsoft.](https://dotnet.microsoft.com/en-us/download "Puedes descargar .NET Core desde el sitio web oficial de Microsoft.")
2. Necesitarás luego clonar/descargar este proyecto, luego de ello tendrás que abrir una terminal ya sea CMD, PowerShell o Bash, tendrás que navegar dentro de la terminal hasta la ubicación del proyecto, una vez ahí deberás escribir el siguiente comando `dotnet run`.
3. Luego de ello tendrás acceso al proyecto, sin embargo tendrás que introducir las credecenciales válidas para poder tener la autorización necesaria y visualizar todo el contenido disponible, para ello he registrado un usuario a modo de prueba para poder visualizar todo lo que el sistema ofrece, a continuación les dejo las credenciales.
> Usuario: Enel
Contraseña: Enel123.
(El punto final es parte de la contraseña)

## Resumen
El "Sistema de ventas" es una aplicación diseñada para ser ejecutada en Blazor Server, que tiene como objetivo facilitar la gestión de ventas y clientes para los usuarios.

El sistema cuenta con una estructura en capas, incluyendo la lógica de negocio (BLL), la capa de datos (DAL) y la capa de usuario (UI). En la capa de lógica de negocio se encuentra la lógica detrás de cada registro, incluyendo los modelos utilizados en el sistema. Por su parte, la capa de datos almacena las migraciones realizadas y el DataContext del sistema.

El usuario puede registrar ventas, clientes habituales, productos y vendedores utilizando el sistema. Para acceder a estas funciones, el usuario debe estar registrado e iniciar sesión en el sistema. También puede realizar consultas de lo ya registrado en el sistema.

Para probar el sistema, se requiere tener instalado .NET Core, ya que Blazor Server se basa en esta tecnología. Una vez descargado o clonado el proyecto, el usuario debe ejecutar el comando "dotnet run" en la terminal en la ubicación del proyecto. Luego, se debe ingresar con credenciales válidas para poder tener autorización y acceder a todo el contenido disponible. Se proporciona un usuario de prueba para poder visualizar todas las funcionalidades del sistema.
