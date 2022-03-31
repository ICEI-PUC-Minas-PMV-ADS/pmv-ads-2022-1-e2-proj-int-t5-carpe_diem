# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Requisitos para realização dos testes:<br/>
 •	_Site_ publicado na internet;<br/>
 •	Navegador de Internet (_Google Chrome, Firefox, Microsoft Edge_);<br/>
 •	Conexão com a internet para acesso à plataforma.<br/>
 
Os testes funcionais a serem realizados no _site_ são descritos a seguir:

|Caso de Teste | CT-01 - Realizar cadastro e _login_ |
|:--|:--|
|**Requisitos Associados**|RF-001 – O sistema deve permitir ao usuário realizar o cadastro como hóspede, realizando a validação através de um _e-mail_ de confirmação. <br/> RF 009 - O sistema deve permitir que o usuário faça _login_ em sua conta através do seu _e-mail_ e senha cadastrados.  
|**Objetivo do teste**|- Permitir que o usuário se cadastre na plataforma.<br/> - Permitir que o usuário faça _login_ na plataforma.|
|**Passos**| 1) Acessar o navegador.<br/> 2) Informar o endereço do _site_. <br/> 3) Clicar no botão "cadastre-se". <br/> 4) Preencher os campos com informações validas.<br/> 5) Clicar no botão cadastrar.<br/> 6) Clicar no link de validação recebido no _e-mail_ cadastrado. <br/> 7) Clicar no botão _login_.<br/> 8) Preencher os campos com o _e-mail_ e senha cadastrados. <br/> 9) Clicar em entrar.|
|**Critérios de Êxito**| - Receber _e-mail_ de validação.<br/> - Confirmação do _login_ e redirecionamento para _homepage_ do site.|

|Caso de Teste | CT-02 - Realizar gerenciamento do cadastro |
|:--|:--|
|**Requisitos Associados**|RF-002 – O sistema deve permitir ao usuário gerenciar seu cadastro.  
|**Objetivo do teste**|- Permitir que o usuário altere suas informações cadastradas. <br/> - Permitir que o usuário exclua sua conta.|
|**Passos**| 1) Acessar o navegador.<br/> 2) Informar o endereço do _site_. <br/> 3) Clicar no botão de _login_. <br/> 4) Realizar _login_.<br/> 5) Clicar em “meu perfil” e depois em “meus dados”. <br/> 6) Clicar em "alterar dados".<br/> 7) Digitar os dados a serem alterados. <br/> 8) Clicar em salvar alterações.<br/> 9) Clicar em excluir conta e confirmar a exclusão.|
|**Critérios de Êxito**| - Salvar alterações realizadas.<br/> - Confirmação da exclusão da conta.

|Caso de Teste | CT-03 - Realizar cadastro anfitrião e imóvel |
|:--|:--|
|**Requisitos Associados**|RF-003 – O sistema deve permitir ao hóspede a opção de se tornar anfitrião, gerenciar as informações do imóvel cadastrado e o disponibilizar para locação de temporada.  
|**Objetivo do teste**|- Permitir que o hóspede se cadastre como anfitrião.  <br/> - Permitir o cadastro do imóvel.|
|**Passos**|1) Acessar o navegador.<br/> 2) Informar o endereço do _site_. <br/> 3) Realizar _login_. <br/> 4) Clicar no botão "seja um anfitrião". <br/> 5) Cadastrar os dados do imóvel.<br/> 6) Confirmar o cadastro.|
|**Critérios de Êxito**|- Confirmação do imóvel cadastrado. 

|Caso de Teste | CT-04 - Redefinir senha |
|:--|:--|
|**Requisitos Associados**|RF-007 – O sistema deve permitir ao usuário solicitar a redefinição de sua senha, informando o _e-mail_ cadastrado.  
|**Objetivo do teste**|- Permitir que o usuário redefina sua senha.|
|**Passos**|1) Acessar o navegador.<br/> 2) Informar o endereço do _site_. <br/> 3) Acessar a página de _login_. <br/> 4) Clicar no botão "esqueci minha senha". <br/> 5) Digitar _e-mail_ cadastrado e clicar em "redefinir".<br/> 6) Clicar no _link_ de redefinição recebido no _e-mail_ cadastrado.<br/> 7) Inserir a nova senha nos campos indicados e clicar no botão “salvar”. |
|**Critérios de Êxito**|- Receber _e-mail_ com _link_ para redefinição de senha.<br/> - Realizar novo _login_ após redefinir senha. 
  
|Caso de Teste | CT-05 - Realizar busca por imóvel |
|:--|:--|
|**Requisitos Associados**|RF-005 – O sistema deve permitir ao hóspede realizar a busca de imóveis através da funcionalidade de filtros como: tipo de imóvel, quantidade de cômodos, acessibilidade, número máximo de hóspedes, disponibilidade por data, entre outros.<br/> RF-008 – O sistema deve apresentar ao usuário apenas os imóveis disponíveis na data selecionada durante a busca.  
|**Objetivo do teste**|- Permitir que o usuário realize a busca por imóveis de acordo com os filtros selecionados.<br/> - Apresentar nos resultados da busca somente os imóveis disponíveis na data selecionada.|
|**Passos**|1) Acessar o navegador.<br/> 2) Informar o endereço do _site_. <br/> 3) Clicar no botão "buscar imóveis". <br/> 4) Selecionar os filtros desejados para a busca.  <br/> 5) Clicar em buscar.|
|**Critérios de Êxito**|- Apresentar somente os imóveis de acordo com os critérios de busca selecionados.

|Caso de Teste | CT-06 - Realizar reserva do imóvel |
|:--|:--|
|**Requisitos Associados**|RF-004 – O sistema deve permitir que o hóspede reserve o imóvel escolhido.<br/> RF-011 – O sistema deve notificar o anfitrião sempre que seu imóvel for reservado.  
|**Objetivo do teste**|- Permitir que o hóspede reserve um imóvel.<br/> - Notificar anfitrião da reserva do imóvel.|
|**Passos**|1) Acessar o navegador.<br/> 2) Informar o endereço do _site_. <br/> 3) Realizar _login_. <br/> 4) Realizar a busca por imóvel. <br/> 5) Selecionar imóvel escolhido.<br/> 6) Clicar no botão "reservar".|
|**Critérios de Êxito**|- Hóspede realizar confirmação da reserva do imóvel. <br/> - Anfitrião receber e-mail de confirmação da reserva.

|Caso de Teste | CT-07 - Realizar gerenciamento de reservas |
|:--|:--|
|**Requisitos Associados**|RF-010 – O sistema deve permitir ao hóspede gerenciar suas reservas, conforme regras contratuais e disponibilidade.  
|**Objetivo do teste**|- Permitir que o hóspede altere as informações da sua reserva. <br/> - Permitir que o hóspede cancele sua reserva.|
|**Passos**|1) Acessar o navegador.<br/> 2) Informar o endereço do _site_. <br/> 3) Realizar _login_. <br/> 4) Clicar em “meu perfil” e depois em “minhas reservas”. <br/> 5) Selecionar a reserva e clicar em “alterar reserva”.<br/> 6) Digitar os dados a serem alterados.<br/> 7) Clicar em "salvar alterações".<br/> 8) Clicar em "cancelar reserva" e confirmar o cancelamento. |
|**Critérios de Êxito**|- Salvar alterações realizadas.<br/> - Confirmar cancelamento da reserva.<br/> - Anfitrião receber _e-mail_ de cancelamento da reserva.

|Caso de Teste | CT-08 - Preencher formulário fale conosco |
|:--|:--|
|**Requisitos Associados**|RF-006 – O sistema deve disponibilizar um formulário de fale conosco para esclarecer dúvidas relacionadas ao _site_.  
|**Objetivo do teste**|- Permitir o envio do formulário fale conosco. |
|**Passos**|1) Acessar o navegador.<br/> 2) Informar o endereço do _site_. <br/> 3) Clicar em “fale conosco”. <br/> 4) Preencher o formulário. <br/> 5) Clicar em "enviar". |
|**Critérios de Êxito**|- Confirmação do envio do formulário.


## Ferramentas de Testes (Opcional)

Comente sobre as ferramentas de testes utilizadas.
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
