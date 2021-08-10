# ChecaVacina
<a href="https://docs.microsoft.com/pt-br/dotnet/csharp/"> 💻 C#</a>

<strong>Funciona apenas para o município de Fortaleza</strong>

<p align="center"> 💉 App para te lembrar do seu dia de vacinação</p>
<h1 align="center">
  <img alt="Vacinação" title="#vacinacao" src="./ChecaVacina/vacina.png" />
</h1>

## 💻 Como executar

 - Clone o repositório
 - Instale as bibliotecas, inclusive a Selenium.
 - Crie um arquivo "Appsettings.json", informando seus dados do servidor SMTP e dados do registro que deseja consultar. Exemplo:
  <BR/>
 {<BR/>
  "Configuration": {<BR/>
    "Email": "seu@mail.com",<BR/>
    "Password": "senhadoseuemail",<BR/>
    "Smtp": "seusmtp.com.br",<BR/>
    "Port": 26<BR/>
  },<BR/>
  "Pessoas": [<BR/>
    {<BR/>
      "Nome": "Nome",<BR/>
      "Cpf": "0218548565",<BR/>
      "Email": "email@mail.com"<BR/>
    },<BR/>
    {<BR/>
      "Nome": "nome",<BR/>
      "Cpf": "00436515553",<BR/>
      "Email": "teste@ig.com"<BR/>
    }<BR/>
  ]<BR/>
}<BR/>
 
 - Compile o aplicativo.
 - Execute o "ChecaVacina.exe"
 - Exemplo de execução:
 <h1 align="center">
  <img alt="Software" title="#software" src="./ChecaVacina/emailEnviado.png" />
</h1>
 - Se o seu nome aparecer na lista, um e-mail será enviado.
 
 ## Autor
  Thallys Freitas  <br/>
  Entre em contato comigo: ![Gmail Badge](https://img.shields.io/badge/thallys%40hotmail.com-E--mail-green?style=flat-square&logo=Gmail&logoColor=white&link=mailto:thallys@hotmail.com) |
![Linkedin Badge](https://img.shields.io/badge/Thallys-LinkedIn-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/thallys-freitas-87155074/)

