
# Especificações do Projeto

A definição exata do problema e os pontos mais relevantes a serem tratados no projeto foi estabelecido com a participação dos usuários por meio de entrevista online com tópicos previamente estipulados. A partir dessa interação consolidamos os dados coletados na forma de personas e histórias de usuários.


## Personas

| Theo Bernardo      |                                    |                                        |                     
|--------------------|------------------------------------|----------------------------------------|
|![Theo Bernardo](https://user-images.githubusercontent.com/91228798/157347426-ca6c5897-c4ec-43cc-9b56-d8d7101097fa.jpg) |**Idade:** 26 anos - **Ocupação:** Aposentado por invalidez|**Aplicativos:** WhatsApp|
|**Motivações:** Gosta de realizar as sessões de fisioterapia na praia, pois se sente motivado.|**Frustrações:** Dificuldade em se deslocar de um lugar para o outro. Julgamento da sociedade em relação às pessoas com deficiência.|**Hobbies, História:** Amava andar de moto e sofreu acidente de trânsito no qual perdeu um braço e uma perna (ambos do lado esquerdo).|

| Clara Castilho     |                                    |                                        |                     
|--------------------|------------------------------------|----------------------------------------|
|![Clara Castilho](https://user-images.githubusercontent.com/91228798/156458375-3f731c6d-6ba3-4af7-ae83-d73682390cd2.png) |**Idade:** 30 anos - **Ocupação:** Autônoma. Trabalha como manicure e faz faculdade na área de estética. |**Aplicativos:** WhatsApp, Instagram.|
|**Motivações:**  Gosta muito de viajar para fugir da rotina e esquecer um pouco das obrigações do trabalho. |**Frustrações:** Não gosta de frequentar hotéis, pois não pode levar seus animais de estimação.|**Hobbies, História:** Trabalha como manicure desde os 13 anos. Possui o seu próprio estabelecimento e deseja crescer profissionalmente para ter condições de viajar pelo mundo.|

| Carlos José      |                                    |                |
|--------------------|------------------------------------|----------------------------------------|
|![image](https://user-images.githubusercontent.com/90849504/155332734-933e956a-909b-4d7f-af7c-538b2a0f4357.png)|**Idade:** 35 anos - **Ocupação:** Corretor de Imóveis, especialista em Aluguel para Temporada |**Aplicativos:** Linkedin, Instagram.|
|**Motivações:** Oferecer imóveis de aluguel para promover lazer e conforto.|**Frustrações:** Não conseguir alcançar clientes de outras cidades. |**Hobbies, História:** Pratica futebol uma vez por semana e gosta de reunir a família aos fins de semana |

| Caio      |                                    |                |
|--------------------|------------------------------------|----------------------------------------|
|![Caio](https://user-images.githubusercontent.com/91228798/156463881-5e25aced-eb5b-4e3c-bce1-f872e57f97cd.png) |**Idade:** 30 anos - **Ocupação:** Analista de Sistemas |**Aplicativos:** Linkedin, Instagram.|
|**Motivações:**  Adora conhecer novos lugares. Sempre gostou de mudar seu local de trabalho, pois se sente mais criativo.|**Frustrações:**  Acha um tédio trabalhar de home office sempre no mesmo lugar.|**Hobbies, História:** Reside em Belo Horizonte. Funcionário de uma empresa de TI dos Estados Unidos. Exerce sua função em home office período integral.|

| Marina Aguiar |         |         |                    
|--------------------|------------------------------------|----------------------------------------|
|![Marina](https://user-images.githubusercontent.com/91228798/156465093-eae46d42-ca19-40ed-afac-42115d8ad186.png) |**Idade:** 40 anos - **Ocupação:** Secretária Executiva em uma multinacional|**Aplicativos:** Linkedin, Instagram.|
|**Motivações:**  Conhecer novos lugares e pessoas.|**Frustrações:** Não viajar nas férias.|**Hobbies, História:** Viajar com sua família e com seus animais domésticos. Praticar ciclismo.|

| Ernesto de Aguiar  |                                    |                |
|--------------------|------------------------------------|----------------------------------------|
|![Ernesto de Aguiar](https://user-images.githubusercontent.com/91228798/156456724-505107af-ac46-47c4-8935-51fd67cf07c6.png) |**Idade:** 55 anos - **Ocupação:** Empresário. Gerenciador e proprietário de duas casas no litoral do Rio de Janeiro.  | **Aplicativos:** Facebook, WhatsApp  |
|**Motivações:** Dar uma vida melhor para os filhos. Adquirir uma renda extra para se aposentar.           |**Frustrações:** Grande concorrência. Dificuldade em divulgar o aluguel de suas propriedades. Falta de confiança em utilizar a internet.  |**Hobbies, História:** Realiza caminhadas ao pôr do sol. Pai de dois filhos. Empresário a mais de 10 anos.|
## Histórias de Usuários

A partir da compreensão do dia a dia das personas identificadas para o projeto, foram registradas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Teo Bernardo (Aposentado por invalidez)       |Comparar informações acerca da estrutura                |Encontrar a melhor casa no quesito acessibilidade  |
|Clara Castilho (Autônoma)     |
### Requisitos e Restrições do Projeto

O propósito funcional do projeto é definido por meio dos requisitos funcionais que descrevem ações que o sistema deve estar apto a executar, assim como os requisitos não funcionais que descrevem os atributos que o sistema deve possuir de maneira geral. Estes requisitos são relacionados nas tabelas a seguir.


### Requisitos Funcionais

Apresentamos a seguir os requisitos funcionais que o projeto deverá atender.

Quadro 03 - Requisitos Funcionais

|ID       | Descrição do Requisito  | Prioridade |
|---------|-------------------------|------------|
|RF-001   | O sistema deve permitir ao usuário realizar o cadastro como anfitrião (locador) e ou hóspede (locatário), realizando a validação através de um e-mail de confirmação. | Alta |
|RF-002   | O sistema deve permitir ao usuário editar e excluir seu cadastro. | Alta | 
|RF-003   | O sistema deve permitir ao anfitrião (locador) cadastrar e disponibilizar seu imóvel para locação de temporada. | Alta | 
|RF-004   | O sistema deve permitir ao anfitrião (locador) editar as informações e excluir o imóvel cadastrado. | Alta |
|RF-005   | O sistema deve permitir que o hóspede (locatário) alugue o imóvel escolhido. | Alta|
|RF-006   | O sistema deve permitir ao hóspede (locatário) realizar a busca de imóveis por tipo de imóvel e quantidade de cômodos. | Média |
|RF-007   | O sistema deve mostrar os imóveis separados por categorias personalizadas, para uma melhor interação do usuário. | Média |
|RF-008   | O sistema deve permitir que os imóveis sejam salvos em uma lista de favoritos. | Baixa |
|RF-009   | O sistema deve fornecer um campo específico para comentários e avaliação, pelos hóspedes (locatários), referentes a relatos de suas experiências de interação e/ou locação. | Média |
|RF-010   | O site deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar um imóvel específico e fácil acesso aos imóveis já viabilizados na plataforma. | Média |
|RF-011   | O sistema deve permitir visualizar as informações para contato e dúvidas, dos desenvolvedores do site. | Alta |
|RF-012   | O sistema deve disponibilizar formas de pagamento para o imóvel alugado. | Média |
|RF-013   | O sistema deve permitir ao usuário solicitar a redefinição de sua senha, informando o e-mail cadastrado. | Alta |      
|RF-014   | O sistema deve dispor de um calendário para que o hóspede (locatário) verifique se o imóvel estará disponível na data desejada. | Alta |
|RF-015   | O sistema deve permitir que o cliente faça login em sua conta através do seu e-mail e senha cadastrados. | Alta |
|RF-016   | O sistema deve permitir que o cliente acesse suas reservas e possa alterar e cancelar a mesma, conforme regras contratuais e disponibilidade. | Alta |
|RF-017   | O sistema deve permitir que o anfitrião cadastre dados para recebimento das reservas feitas no seu imóvel. | Alta |
|RF-018   | O sistema deve disponibilizar um meio de contato para que anfitrião e hóspede possam comunicar-se entre si. | Alta |
|RF-019   | O sistema deve permitir ao usuário compartilhar o imóvel escolhido. | Baixa |

Fonte: Elaborado pelos autores


### Requisitos não Funcionais

Apresentamos a seguir os requisitos não funcionais que o projeto deverá atender.

Quadro 04 - Requisitos Não Funcionais

|ID      | Descrição do Requisito  |Prioridade |
|--------|-------------------------|-----------|
|RNF-001 | O sistema deve ser multiplataforma, possibilitando seu uso em dispositivos com Windows, Linux e macOS. | Alta  | 
|RNF-002 | O sistema deve ter bom nível de contraste entre os elementos da tela em conformidade. | Alta  | 
|RNF-003 | O sistema deve ser compatível com os principais navegadores do mercado (Google Chrome, Mozilla Firefox, Microsoft Edge). | Alta  | 
|RNF-004 | O sistema deve ser responsivo em ambientes mobile. | Alta  | 
|RNF-005 | O desenvolvimento deve ser utilizando a linguagem C#. | Alta  | 
|RNF-006 | O sistema deve permitir a manutenção do cadastro do usuário (anfitrião e hóspede). | Alta  | 
|RNF-007 | O sistema deve processar requisições do usuário em no máximo 10s. | Média |
|RNF-008 | O sistema deve estar de acordo com LGPD (Lei Geral de Proteção de Dados).| Alta |
|RNF-009 | O sistema deve estar disponível pelos menos 99% das 24 horas do dia, nos 07 dias da semana. | Alta |

Fonte: Elaborado pelos autores


## Restrições

Apresentamos na tabela abaixo, tópicos consideráveis que limitam a execução do projeto e que se configuram como encargos necessários para seu desenvolvimento.

Quadro 05 - Restrições

|ID   | Restrição                                             |
|-----|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 26/06/2022. |
|RE-02| A equipe não pode subcontratar o desenvolvimento do trabalho. |
|RE-03| O aplicativo deve se restringir às tecnologias propostas pelo curso. |
|RE-04| Não é possível acesso ao sistema sem conexão de internet. |

Fonte: Elaborado pelos autores


## Diagrama de Casos de Uso

O diagrama de caso de uso, comumente oriundo da especificação dos requisitos funcionais do sistema, descreve as principais funcionalidades do sistema que será projetado pelo grupo e sua interação com os possíveis usuários (DevMedia, 2022). Segundo Ivar Jacobson, podemos dizer que um caso de uso é um "documento narrativo que descreve a sequência de eventos de um ator que usa um sistema para completar um processo" (Wikipédia, 2020).

Graficamente é representado com elementos como os atores, os casos de uso e seus relacionamentos entre si. Seu objetivo principal é ilustrar de forma abstrata, a interação dos elementos externos com as funcionalidades do sistema, ou seja, “a finalidade de um diagrama de caso de uso é apresentar um tipo de diagrama de contexto que apresenta os elementos externos de um sistema e as maneiras segundo as quais eles as utilizam” (Wikipédia, 2020).

Desta feita, o grupo representa abaixo o diagrama de caso de uso para o sistema que será projetado.

![Casos de Uso - Gerenciador de Imóveis](https://user-images.githubusercontent.com/89617881/157877009-a2dba6b5-fe90-4d6c-a0f1-0118ed329761.png)
Figura 1 - Diagrama de Casos de Uso


<br>
<br>

|ATOR| DESCRIÇÃO                                            |
|--|-------------------------------------------------------|
|Cliente/Hóspede| Pessoa interessada em alugar um imóvel de temporada. |
|Cliente/Anfitrião| Pessoa interessada em disponibilizar seu imóvel para aluguéis de temporada. |
|BD| Banco de dados que deve armazenar e buscar as informações dos clientes e dos imóveis cadastrados.|
|SAC| Serviço de atendimento ao cliente administrado pelo site.|

|CASO DE USO| DESCRIÇÃO | RF |
|--|-------------------------------------------------------|----------------------|
|Falar com SAC | O cliente pode comunicar-se com o SAC disponibilizado pela aplicação. | RF-11 |
|Criar conta | O cliente deve criar uma conta para utilizar os serviços oferecidos pela aplicação. | RF-01 |
|Alterar dados cadastrais| O cliente pode fazer alterações referentes ao seu cadastro pessoal. | RF-02 |
|Excluir conta | O cliente pode excluir sua conta quando assim o desejar. | RF-02 |
|Fazer login | O cliente deve fazer login para acessar sua conta. | RF-15 |
|Redefinir senha | O Cliente pode redefinir sua senha se necessário. | RF-13 |
|Buscar imóveis | O cliente pode buscar, filtrar, favoritar e compartilhar os imóveis disponíveis na aplicação, assim como as características e regras contratuais dos mesmos. | RF-06, RF-07, RF-08, RF-10, RF-14, RF-19 |
|Reservar imóvel | O cliente pode reservar um imóvel conforme disponibilidade. | RF-05 |
|Pagar reserva | O cliente pode pagar sua reserva através dos meios de pagamento oferecidos pela aplicação. | RF-12 |
|Acessar reserva| O cliente pode consultar suas reservas realizadas. | RF-16 |
|Editar reserva | O cliente pode alterar sua reserva conforme regras contratuais e disponibilidade. | RF-16 |
|Cancelar reserva | O cliente pode cancelar a reserva conforme regras contratuais. | RF-16 |
|Falar com anfitrião/hóspede | Anfitriões e hóspedes podem comunicar-se entre si através dos meios de contato disponíveis na aplicação. | RF-18 |
|Avaliar estadia | O cliente pode avaliar sua estadia após o início da mesma. | RF-09 | 
|Cadastrar imóvel | O anfitrião deve cadastrar os dados do seu imóvel na aplicação. | RF-03 |
|Cadastrar dados de recebimento | O anfitrião deve cadastrar os dados para recebimento das reservas realizadas no seu imóvel. | RF-17 |
|Alterar dados do imóvel | O anfitrião pode alterar dados referentes ao seu imóvel. | RF-04 |

|RELACIONAMENTO| DESCRIÇÃO                                            |
|--|-------------------------------------------------------|
|INCLUSÃO|  |
|| Para efetivar sua reserva, o cliente deve fazer o login e realizar o pagamento da mesma. |
|| Para alterar dados cadastrais, o cliente deve realizar o login. | 
|| Para excluir sua conta, o cliente deve realizar o login. |
|| Para acessar sua reserva, o cliente deve fazer o login. |
|| Para cadastrar um imóvel, o cliente deve criar uma conta. |
|| Para alterar dados do imóvel, o cliente deve fazer o login. |
|| Ao cadastrar seu imóvel, o cliente deve também cadastrar dados para recebimento das estadias realizadas no mesmo. | 
|EXTENSÃO|  |
|| Se o cliente esquecer sua senha, pode redefiní-la informando seu e-mail de cadastro. |
|| O cliente pode alterar os dados de sua reserva se desejar e conforme disponibilidade e regras contratuais, acessando sua reserva através do login. |
|| O cliente pode cancelar sua reserva se desejar, conforme regras contratuais, acessando sua reserva através do login. |


