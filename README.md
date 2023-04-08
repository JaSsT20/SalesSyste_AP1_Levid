# Sales system

![](https://raw.githubusercontent.com/JaSsT20/SalesSyste_AP1_Levid/main/wwwroot/imgs/LogoSmall.jpg)

Sales system, traducido al español **"Sistema de ventas"** es un sistema de ventas desarrollado en [blazor server](httphttps://learn.microsoft.com/es-es/aspnet/core/blazor/hosting-models?view=aspnetcore-7.0#blazor-server:// "blazor server") el usuario puede registrarse en el sistema y una vez registrado, podrá iniciar sesión permitiendole así registrar las ventas, de igual manera podrá registrar clientes habituales, productos, vendedores y por supuesto, las ventas que realizan, el sistema también le permite al usuario realizar consultas de todo lo ya mencionado y registrado en el sistema.

## Estructura del proyecto
El proyecto está estructurado en varias capas como lo son:
- [**Lógica de negocio (BLL)**:](https://github.com/JaSsT20/SalesSyste_AP1_Levid/tree/main/BLL "Lógica de negocio (BLL):") En esta se encuentra toda la lógica detrás de cada registro, cada modelo consta con su propia BLL. 
- [ **Capa de datos (DAL)**:](https://github.com/JaSsT20/SalesSyste_AP1_Levid/tree/main/Data " Capa de datos (DAL):") En esta se encuentran las migraciones realizadas y el DataContext del sistema.
- [**Capa de usuario (UI)**](https://github.com/JaSsT20/SalesSyste_AP1_Levid/tree/main/Pages "Capa de usuario (UI)"): Es la capa del frontend que se enfoca en la presentación de la información y la interacción con el usuario. 
## Relaciones
![](https://lh3.googleusercontent.com/pw/AMWts8DufhYJd9QzwJpWhL95_y_SadT8iYVLLh26VNbnFpEUl_X98vlNKrBv0vaV-2YfowIlo3QSA8WB2IDqQccmRljSTV5mO7_Jr3Ip1B4Qpow9szzNi6glnq0YE0731cBhLusoaJfqboN8gYUyJADDgxY_WSthjMc-GmXRjySm5jTDOACV7TUEMOjRHRYJ9tNbT3bMuWTbuP-WBtAvMfDqcu4oAmAkbpR2vzZrQu7xWuqkqsK1obMPuo2WG7bVDVvaJuchNBmP9v6DggZwTPTJ7DEqXjL4GUdN-S2dNP8p5AwH-SGwmIZMY034Y0eXKL4kelxiuykYWyNccZSo-Xvi9WxYnuJwFkt_josc0VZ6UzpM-wNT6cMiPf-b5yncAzrSxksBXuHOhWvBuhvSiVw0gytIcEI6rOQP1iz8qcgkp-qtHgGw2RsALLDGAcAOazcPQOXeGce25puZzcf1EMIqJQz4Ai4Dgo54bIvZ2Lltt-TqDeg8_inuVIiRrZfT7TuNUsvvWOpM5_Jfxiw9bZ-tRY-w3EyW1B7JZ912m4icblj8VP7WJG9vhrXha6hENtuloAoFbQ19SMEKvxXyc1XwnJGy8zV388yfvDE2DmbZtdJtx7rLwOvqhG7GbSqcfoz-wq74GCc8Gb535HWBkDnVXX3lXmEwipC0d1F12YKkFy5t3IxyGiQjblNQYdoaN8qU95IBYOi3rHc_EFiuEom7rxoEO0nnq9Me1ideefxRP8fIITJY3SZP4vxZMuA5evOOCNenrJy81edEdWuD5yBKFXVTqGQ_kWnfNkEjTT7wJL5esxzQQktaaXZSbhc5JI1RH5HlaRjFhjkOAt2QwRVyFiLnVmLN0gKuvoUDo6uFou7l7MGMfb2qa2e5yiMNV63mP1JKjbQeJ92KHdH3N9Y-2-sAzsR58DcsD7IaPavqI8wGqaa4PKJBgHHxkIQ8wBXP7eaYnueJEnyPHfDfYiwH4k48GzOrObqGUnV7ukSufAXNZsaTgOtQMjSuiAwEyv5XQwX2=w1340-h536-s-no?authuser=0)

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
