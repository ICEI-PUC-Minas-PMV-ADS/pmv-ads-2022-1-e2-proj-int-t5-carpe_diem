# 5. Arquitetura da Solução

A arquitetura de solução apresenta como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação. Seguem abaixo os principais elementos relacionados a esse tópico.

## 5.1 Diagrama de Classes

O diagrama de classes ilustra esquematicamente como será a estrutura do software e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

Figura 26 - Diagrama de Classes

![Diagrama de Classes - atualizado](https://user-images.githubusercontent.com/89617881/162593374-e77bbf5e-ce22-4485-8219-a2178ed56ff3.png)

Fonte: Elaborado pelos autores


## 5.2 Modelo ER

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.<br/> Segue abaixo a representação do Modelo ER:

Figura 27 - Modelo ER

![Modelo-ER_edit_Final_CP_V4](https://user-images.githubusercontent.com/90981080/162637229-ba472e6d-8185-4084-8b5c-55d890b49267.png)

Fonte: Elaborado pelos autores


## 5.3 Esquema Relacional

O Esquema Relacional corresponde à representação dos dados em tabelas juntamente com as restrições de integridade e chave primária.<br/> Segue abaixo a representação do Esquema Relacional:

Figura 28 - Esquema Relacional

![Esquema Relacional_CP_V4](https://user-images.githubusercontent.com/90981080/162637243-50623f08-b61b-45e4-993a-ea6cbd42d808.png)

Fonte: Elaborado pelos autores


## 5.4 Diagrama de Componentes

Compreendemos nessa seção os componentes que fazem parte da arquitetura da solução, consoante figura adiante.

Figura 29 - Arquitetura da Solução

![arquitetura](https://user-images.githubusercontent.com/89549220/168407564-43605626-ffc1-4773-b63e-94eb1d8cdf3f.png)

Fonte: Elaborado pelos autores / Imagens: Freepik - Flaticon

A arquitetura da solução concretizada conta com os seguintes módulos:
  - Navegador - Interface básica do sistema 
      - Páginas Web - Conjunto de arquivos HTML5, CSS3, JavaScript, Bootstrap e imagens que efetivam as funcionalidades do sistema.
  - Hospedagem - local na Internet onde as páginas serão mantidas e conectadas pelo navegador. 
      - Plataforma Heroku ou Azure
  - Local Storage - armazenamento mantido no Navegador, onde são empreendidos bancos de dados baseados no JSON (JavaScript Object Notation).  
      - Dados do Hóspede
      - Dados do Cadastro do Imóvel
      - Dados da Reserva do Imóvel


## 5.5 Hospedagem

Como ambiente de hospedagem da aplicação do projeto Carpe Diem, optamos por utilizar a plataforma Heroku ou Azure, e o mesmo será mantido no ambiente da URL <https://carpediempucmg.azurewebsites.net/>.

A publicação da aplicação no Heroku ou no Azure será realizada através da submissão do projeto (push) via Git para o repositório remoto que estará disponível no GitHub.


## 5.6 Tecnologias Utilizadas

- Linguagens e _frameworks_ utilizadas para desenvolver o projeto: HTML5, CSS3, JavaScript, C#, _Bootstrap_, _Media Queries_, .NET
- IDEs de desenvolvimento: Visual Studio Code e Visual Studio
- Plataforma para hospedagem do site: Heroku ou Azure
- Plataforma para hospedagem dos arquivos: GitHub e Google Drive
- Ferramenta de versionamento: Git e GitHub Desktop
- Ferramenta para a criação de logo e imagens: Figma, Ilustrator, CorelDraw
- Ferramenta para criação do template / wireframing: Figma e Adobe XD
- Ferramenta para criação de diagramas e fluxos: Lucidchart e Visio
- Banco de Dados: SQL Server
