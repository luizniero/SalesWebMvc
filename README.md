# SalesWebMvc

 Parte do curso c# completo, módulo asp net mvc


 ### Informações aprendidas no curso

1. As página de uma aplicação asp.net core MVC possuem a extensão .cshtml e são páginas do tipo 'Razor'
2. Razor é o sistema de template que o asp net core utiliza
3. Páginas razor aceitam tanto códigos HTML como código c# (assim com o ecmascript aceita javascript e html)
4. A pasta shared contém páginas (componentes) que são compartilhados por mais de um controlador.
5. O arquivo _Layout.cshtml é a base do layout geral da aplicação.
6. O arquivo _ViewStart define qual é o arquivo de layout geral da aplicação
7. O arquivo _ViewImport defiine importações que serão usadas na aplicação de forma geral


Neste projeto:
1. As rotas têm o perfil [controlador]/[ação]/[id]
2. O [id] é opcional
3. Esse pattern está definido no Startup.cs:  pattern: "{controller=Home}/{action=Index}/{id?}");
4. Um controlador é uma classe que herda de :Controller e possui vários métodos públicos que retornam um IActionResult. Ver: HomeController.cs
5. O action na URL é exatamente o nome do método.
6. Os métodos do controller precisam ter o mesmo nome que as páginas que eles chamam. Exemplo: O método Privacy() vai renderizar em View() o conteúdo de /Home/Privacy.cshtml


Nas páginas Views (.cshtml), podemos:

Utilizar um bloco @{} para poder utilizar código c#
ou utilizar, dentro de tags html, um @[instrução] para utilizar uma instrução c#

Exemplos:

@{
	int x = 20;
	if (x > 0)
		ViewData["Title"] = "O valor de X é maior que 20";
}

<h2>@ViewData["Title"]</h2>

Tomar cuidado para não lotar a view com códigos que deveriam ficar nos controllers!
