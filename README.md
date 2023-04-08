#Sales system
![](https://raw.githubusercontent.com/JaSsT20/SalesSyste_AP1_Levid/bcf0913fd4b0968ee3a422fab5cb27f8be710b69/wwwroot/imgs/LogoSmall.png)

Sales system, traducido al español **"Sistema de ventas"** es un sistema de ventas desarrollado en [blazor server](httphttps://learn.microsoft.com/es-es/aspnet/core/blazor/hosting-models?view=aspnetcore-7.0#blazor-server:// "blazor server") el usuario puede registrarse en el sistema y una vez registrado, podrá iniciar sesión permitiendole así registrar las ventas, de igual manera podrá registrar clientes habituales, productos, vendedores y por supuesto, las ventas que realizan, el sistema también le permite al usuario realizar consultas de todo lo ya mencionado y registrado en el sistema.

##Estructura del proyecto
El proyecto está estructurado en varias capas como lo son:
- [**Lógica de negocio (BLL)**:](https://github.com/JaSsT20/SalesSyste_AP1_Levid/tree/main/BLL "Lógica de negocio (BLL):") En esta se encuentra toda la lógica detrás de cada registro, cada modelo consta con su propia BLL. 
- [ **Capa de datos (DAL)**:](https://github.com/JaSsT20/SalesSyste_AP1_Levid/tree/main/Data " Capa de datos (DAL):") En esta se encuentran las migraciones realizadas y el DataContext del sistema.
- [**Capa de usuario (UI)**](https://github.com/JaSsT20/SalesSyste_AP1_Levid/tree/main/Pages "Capa de usuario (UI)"): Es la capa del frontend que se enfoca en la presentación de la información y la interacción con el usuario. 
##Relaciones

