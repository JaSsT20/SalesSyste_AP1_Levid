#Sales system

![](https://raw.githubusercontent.com/JaSsT20/SalesSyste_AP1_Levid/bcf0913fd4b0968ee3a422fab5cb27f8be710b69/wwwroot/imgs/LogoSmall.png)

Sales system, traducido al español **"Sistema de ventas"** es un sistema de ventas desarrollado en [blazor server](httphttps://learn.microsoft.com/es-es/aspnet/core/blazor/hosting-models?view=aspnetcore-7.0#blazor-server:// "blazor server") el usuario puede registrarse en el sistema y una vez registrado, podrá iniciar sesión permitiendole así registrar las ventas, de igual manera podrá registrar clientes habituales, productos, vendedores y por supuesto, las ventas que realizan, el sistema también le permite al usuario realizar consultas de todo lo ya mencionado y registrado en el sistema.

##Estructura del proyecto
El proyecto está estructurado en varias capas como lo son:
- [**Lógica de negocio (BLL)**:](https://github.com/JaSsT20/SalesSyste_AP1_Levid/tree/main/BLL "Lógica de negocio (BLL):") En esta se encuentra toda la lógica detrás de cada registro, cada modelo consta con su propia BLL. 
- [ **Capa de datos (DAL)**:](https://github.com/JaSsT20/SalesSyste_AP1_Levid/tree/main/Data " Capa de datos (DAL):") En esta se encuentran las migraciones realizadas y el DataContext del sistema.
- [**Capa de usuario (UI)**](https://github.com/JaSsT20/SalesSyste_AP1_Levid/tree/main/Pages "Capa de usuario (UI)"): Es la capa del frontend que se enfoca en la presentación de la información y la interacción con el usuario. 
##Relaciones
![](https://lh3.googleusercontent.com/pw/AMWts8DufhYJd9QzwJpWhL95_y_SadT8iYVLLh26VNbnFpEUl_X98vlNKrBv0vaV-2YfowIlo3QSA8WB2IDqQccmRljSTV5mO7_Jr3Ip1B4Qpow9szzNi6glnq0YE0731cBhLusoaJfqboN8gYUyJADDgxY_WSthjMc-GmXRjySm5jTDOACV7TUEMOjRHRYJ9tNbT3bMuWTbuP-WBtAvMfDqcu4oAmAkbpR2vzZrQu7xWuqkqsK1obMPuo2WG7bVDVvaJuchNBmP9v6DggZwTPTJ7DEqXjL4GUdN-S2dNP8p5AwH-SGwmIZMY034Y0eXKL4kelxiuykYWyNccZSo-Xvi9WxYnuJwFkt_josc0VZ6UzpM-wNT6cMiPf-b5yncAzrSxksBXuHOhWvBuhvSiVw0gytIcEI6rOQP1iz8qcgkp-qtHgGw2RsALLDGAcAOazcPQOXeGce25puZzcf1EMIqJQz4Ai4Dgo54bIvZ2Lltt-TqDeg8_inuVIiRrZfT7TuNUsvvWOpM5_Jfxiw9bZ-tRY-w3EyW1B7JZ912m4icblj8VP7WJG9vhrXha6hENtuloAoFbQ19SMEKvxXyc1XwnJGy8zV388yfvDE2DmbZtdJtx7rLwOvqhG7GbSqcfoz-wq74GCc8Gb535HWBkDnVXX3lXmEwipC0d1F12YKkFy5t3IxyGiQjblNQYdoaN8qU95IBYOi3rHc_EFiuEom7rxoEO0nnq9Me1ideefxRP8fIITJY3SZP4vxZMuA5evOOCNenrJy81edEdWuD5yBKFXVTqGQ_kWnfNkEjTT7wJL5esxzQQktaaXZSbhc5JI1RH5HlaRjFhjkOAt2QwRVyFiLnVmLN0gKuvoUDo6uFou7l7MGMfb2qa2e5yiMNV63mP1JKjbQeJ92KHdH3N9Y-2-sAzsR58DcsD7IaPavqI8wGqaa4PKJBgHHxkIQ8wBXP7eaYnueJEnyPHfDfYiwH4k48GzOrObqGUnV7ukSufAXNZsaTgOtQMjSuiAwEyv5XQwX2=w1340-h536-s-no?authuser=0)
