# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Requisitos para realização dos testes:<br/>
 •	Site publicado na internet;<br/>
 •	Navegador de Internet (Google Chrome, Firefox, Microsoft Edge);<br/>
 •	Conexão com a internet para acesso à plataforma.<br/>
 
Os testes funcionais a serem realizados no site são descritos a seguir:

|Caso de Teste | CT-01 - Realizar cadastro e _login_ |
|:--|:--|
|**Requisitos Associados**|RF-001 – O sistema deve permitir ao usuário realizar o cadastro como hóspede, realizando a validação através de um e-mail de confirmação. <br/> RF 009 - O sistema deve permitir que o usuário faça _login_ em sua conta através do seu _e-mail_ e senha cadastrados.  
|**Objetivo do teste**|- Permitir que o usuário se cadastre na plataforma.<br/> - Permitir que o usuário faça login na plataforma.|
|**Passos**| 1) Acessar o navegador.<br/> 2) Informar o endereço do site. <br/> 3) Clicar no botão cadastre-se. <br/> 4) Preencher os campos com informações validas.<br/> 5) Clicar no botão cadastrar.<br/> 6) Clicar no link de validação recebido no e-mail cadastrado. <br/> 7) Clicar no botão login.<br/> 8) Preencher os campos com o e-mail e senha cadastrados. <br/> 9) Clicar em entrar.|
|**Critérios de Êxito**| - Receber e-mail de validação.<br/> - Confirmação do login e redirecionamento para homepage do site.|


|Caso de Teste | CT-02 - Realizar gerenciamento do cadastro |
|:--|:--|
|**Requisitos Associados**|RF-002 – O sistema deve permitir ao usuário gerenciar seu cadastro.  
|**Objetivo do teste**|- Permitir que o usuário altere suas informações cadastradas. <br/> - Permitir que o usuário exclua sua conta.|
|**Passos**| 1) Acessar o navegador.<br/> 2) Informar o endereço do site. <br/> Clicar no botão de login. <br/> 4) Realizar login e clicar em meu perfil.<br/> 5) Clicar em alterar conta.<br/> 6) Digitar os dados a serem alterados. <br/> 7) Clicar em salvar alterações.<br/> 8) Clicar em excluir conta e confirmar a exclusão.|
|**Critérios de Êxito**| - Salvar alterações realizadas.<br/> - - Confirmação da exclusão da conta.


|Caso de Teste | CT-03 - Realizar cadastro anfitrião e imóvel |
|:--|:--|
|**Requisitos Associados**|RF-003 – O sistema deve permitir ao hóspede a opção de se tornar anfitrião, gerenciar as informações do imóvel cadastrado e o disponibilizar para locação de temporada.  
|**Objetivo do teste**||
|**Passos**| |
|**Critérios de Êxito**| 

|Caso de Teste | CT-04 - Redefinir senha |
|:--|:--|
|**Requisitos Associados**|RF-007 – O sistema deve permitir ao usuário solicitar a redefinição de sua senha, informando o e-mail cadastrado.  
|**Objetivo do teste**||
|**Passos**| |
|**Critérios de Êxito**| 
 
 
|Caso de Teste | CT-05 - Realizar busca por imóvel |
|:--|:--|
|**Requisitos Associados**|RF-005 – O sistema deve permitir ao hóspede realizar a busca de imóveis através da funcionalidade de filtros como: tipo de imóvel, quantidade de cômodos, acessibilidade, número máximo de hóspedes, disponibilidade por data, entre outros.<br/> RF-008 – O sistema deve apresentar ao usuário apenas os imóveis disponíveis na data selecionada durante a busca.  
|**Objetivo do teste**||
|**Passos**| |
|**Critérios de Êxito**|

|Caso de Teste | CT-06 - Realizar reserva do imóvel |
|:--|:--|
|**Requisitos Associados**|RF-004 – O sistema deve permitir que o hóspede reserve o imóvel escolhido.<br/> RF-011 – O sistema deve notificar o anfitrião sempre que seu imóvel for reservado.  
|**Objetivo do teste**||
|**Passos**| |
|**Critérios de Êxito**|


|Caso de Teste | CT-07 - Realizar gerenciamento de reservas |
|:--|:--|
|**Requisitos Associados**|RF-010 – O sistema deve permitir ao hóspede gerenciar suas reservas, conforme regras contratuais e disponibilidade.  
|**Objetivo do teste**||
|**Passos**| |
|**Critérios de Êxito**|


|Caso de Teste | CT-08 - Preencher formulário fale conosco |
|:--|:--|
|**Requisitos Associados**|RF-006 – O sistema deve disponibilizar um formulário de fale conosco para esclarecer dúvidas relacionadas ao site.  
|**Objetivo do teste**||
|**Passos**| |
|**Critérios de Êxito**|


## Ferramentas de Testes (Opcional)

Comente sobre as ferramentas de testes utilizadas.
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
