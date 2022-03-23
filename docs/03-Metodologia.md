
# 3. Metodologia

A metodologia pormenoriza as ferramentas aplicadas pelo grupo na organização e na estruturação da implantação das tarefas do projeto, assim como nas plataformas e artefatos utilizados para a manutenção e conservação dos códigos.


## 3.1 Relação de Ambientes de Trabalho

Os artefatos do projeto são acompanhados e evoluídos com a ajuda de diferentes plataformas, cada qual com sua função específica. A combinação dos ambientes com suas respectivas finalidades é apresentada no quadro abaixo.

Quadro 7 - Ambientes de Trabalho

| AMBIENTE                             | PLATAFORMA        | LINK DE ACESSO                                                                                    |
|--------------------------------------|-------------------|---------------------------------------------------------------------------------------------------|
| Repositório de Código Fonte          | GitHub            | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t5-carpe_diem                |
| Documento do Projeto                 | GitHub Docs       | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t5-carpe_diem/tree/main/docs |
| Projeto de Interface e  _Wireframes_ | Figma             | (processo não iniciado)                                                                           |
| Gerenciamento do Projeto             | _Git Projects_    | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t5-carpe_diem/projects/1     |

Fonte: Elaborado pelos autores


## 3.2 Gestão de Código Fonte

De acordo com Vietro (2015), é importante observar o uso de técnicas e metodologias para o desenvolvimento de sistemas, buscando melhorar as práticas atuais. Diante disso torna-se essencial o gerenciamento do _software_, e isso envolve administrar as várias etapas do processo, como, por exemplo: requisitos do sistema, arquitetura do _software_, padrões de codificação, gerência de configuração, _deploy_, entre outros.

Pensando nesse contexto, o grupo optou por utilizar um processo fundamentado no _GitFlow_ para a gestão do código fonte do _software_ que será desenvolvido. 

O _GitFlow_ é um _framework_ criado em 2010 e considerado um ótimo modelo de _branching_, além de ser usado para trabalhar em conjunto com o sistema de controle de versão Git (VIETRO, 2015). Assim sendo, as manutenções do código serão efetuadas definindo-se os papéis de cada _branch_ em separado, como eles devem interagir entre si, e com a identificação de _Branch Master, Branch Develop, Feature Branch, Release Branch, Maintenance Branch (Hotfix)_.

Figura 2 - _GitFlow Workflow_ <br>
Modelo de Fluxo de Controle do Código Fonte no Repositório Git

![image](https://user-images.githubusercontent.com/89549220/158081865-4b79a24d-9a25-4a51-baab-c757846680b3.png)

Fonte: Vietro (2015)

Esse modelo de _workflow_ utiliza dois _branches_ principais para guardar o histórico do projeto, ao invés de trabalhar com apenas um _Branch Master_. O _Branch Master_ guarda o histórico oficial das entregas, já o _Branch Develop_ serve como integração entre todos os _branches_ de funcionalidades (_Feature Branches_). Cada funcionalidade deve ter seu próprio _branch_, e ele deve ser criado a partir do _Branch Develop_. Quando uma funcionalidade for concluída, ela é mesclada (_merged_) novamente com o seu _branch_ pai. Quando o _Branch Develop_ estiver com funcionalidades suficientes para uma entrega, criaremos um _branch_ de entrega (_Release Branch_). Com isso, damos início ao próximo ciclo de entrega, ou seja, nenhuma nova funcionalidade pode ser incluída a partir desse momento. Quando estivermos prontos para realizar a entrega, o _Release Branch_ é mesclada com os _branches Master e Develop_. O _Maintenance Branches (Hotfix)_ são usados para corrigir rapidamente algum problema em produção. Este é o único _branch_ que deve ser criado a partir do _Master_. Assim que a correção for finalizada, o _branch_ é fechado e mesclado com o _Master e Develop_, mantendo assim as linhas completamente atualizadas (VIETRO, 2015).


## 3.3 Gerenciamento do Projeto

O grupo decidiu por utilizar a metodologia Ágil, sendo escolhido o _Scrum_ como base para definição do processo de desenvolvimento do projeto.


### 3.3.1 Divisão de Papéis

Sua organização está apresentada conforme abaixo:

a) _Scrum Master_
  -	Fabiana Bicalho Palhano Rocha Cossenzo

b) _Product Owner_
   -	Luciana De Nardin

c) Equipe de Desenvolvimento
  -	Cristiane Fumagalli Navarro Martins
  -	Eduardo Lordeiro Alves
  -	Fabiana Bicalho Palhano Rocha Cossenzo
  -	Guilherme da Silva Moreira
  -	Márcia Maria de Paula Ferreira
  -	Nayara Katlin Oliveira da Silva

d) Equipe de _Design_
  -	Cristiane Fumagalli Navarro Martins
  -	Eduardo Lordeiro Alves
  -	Fabiana Bicalho Palhano Rocha Cossenzo
  -	Guilherme da Silva Moreira
  -	Márcia Maria de Paula Ferreira
  -	Nayara Katlin Oliveira da Silva


### 3.3.2 Processo

Na organização e na distribuição das tarefas do projeto, o grupo utiliza o aplicativo de gerenciamento de projetos denominado _Git Projects_, onde o mesmo está estruturado com as seguintes listas: 

*	Documentação: sequência das tarefas referentes à documentação de contexto que serão trabalhadas pela equipe, conforme cronograma do curso.
*	_Product Backlog_: local onde é adicionado as tarefas a serem trabalhadas pela equipe, assim como as tarefas que forem identificadas no andamento do projeto. 
*	_To Do_: representa o Sprint Backlog atual que está sendo trabalhado.
*	_In Progress_: tarefas que foram iniciadas são adicionadas nessa lista.
*	_Test_ (CQ - Checagem de Qualidade): lista das tarefas que foram concluídas. Nesse estágio cabe-se ainda uma revisão para verificar a qualidade.
*	_Done_: nesta lista são adicionadas as tarefas que passaram pela Checagem de Qualidade e estão prontas para serem enviadas e/ou entregues.
*	_Locked_: lista onde será relacionado e especificado o que está impedindo a conclusão da tarefa, juntamente com um comentário sobre o que está travando a tarefa.

O quadro gerenciado pelo grupo no aplicativo _Git Projects_ está disponível através da URL especificada no Quadro 7 e é apresentado, em seu estado atual, congênere figura abaixo. A caracterização da estrutura montada se fundamentou no artigo escrito por Littlefield (2016), assim como nos conceitos de _Scrum_ de Schwaber e Sutherland (2020).

Figura 3 - Tela do _Git Projects_ para Gerenciamento do Projeto 

![image](https://user-images.githubusercontent.com/89549220/159369667-0236bdc8-8083-4801-b53c-fb83b4e89dba.png)
<br>
![image](https://user-images.githubusercontent.com/89549220/159369694-f07a44ec-d9d1-4cb8-a7c7-7492941611cb.png)

Fonte: _Git Projects_ - Elaborado pelos autores


## 3.4 Controle de Versão

A hospedagem do repositório, definida pela faculdade, será no _GitHub_, sendo assumido para o controle de versão do projeto, a utilização do _Git_. 

O sistema de controle de versão moderno e mais utilizado é o _Git_ e, com ele, é possível acompanhar as alterações de código realizadas no decorrer da codificação, assim como ser possível reverter para versões anteriores e específicas (Taysser-Ghergal et al, 2022).

No que tange ao gerenciamento das _Issues_, optamos por adotar no projeto as etiquetas: _documentation, delivery, planning, invalid, help wanted e code review_.

A tarefas estão etiquetadas em função da natureza da atividade e seguem o esquema de cores/categorias conforme abaixo:

- Documentation
- Delivery
- Planning
- Invalid
- Help Wanted
- Code Review

Figura 4 - _Labels_

![image](https://user-images.githubusercontent.com/89549220/159600691-a02f23c8-63cb-475d-869a-9c67fbfca010.png)

Fonte: Elaborado pelos Autores

****


## 3.5 Ferramentas

As ferramentas aplicadas no projeto são:

a) Editor de código: 
- _Visual Studio Code e Visual Studio_.
- Possuem integração com o _Git_, sendo possível realizar commits do _GitHub_ para o _Visual Studio e/ou Visual Studio Code_.

b) Ferramentas de Comunicação: 
- _WhatsApp, Discord, Microsoft Teams, Git Projects_.
- São ferramentas completas e úteis para a gestão da equipe, viabilizando as chamadas de vídeo, de áudio e/ou por chat, seja pelo computador ou pelo _smartphone_.

c) Ferramentas para Criação de Diagramas: 
- _Lucidchart_
- Possui acesso gratuito e de fácil interação, sendo possível criar diagramas conforme a necessidade do projeto, assim como a edição colaborativa pela equipe.

d) Ferramentas de Desenho de Tela (_Wireframing_): 
- Figma
- Possui acesso gratuito e de fácil interação, sendo possível criar wireframes conforme a necessidade do projeto, assim como a edição colaborativa pela equipe.

<br>
<br>
<br>
<br>
<br>
<br>

**PARA CONSULTA**

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

Descreva aqui a metodologia de trabalho do grupo para atacar o problema. Definições sobre os ambiente de trabalho utilizados pela  equipe para desenvolver o projeto. Abrange a relação de ambientes utilizados, a estrutura para gestão do código fonte, além da definição do processo e ferramenta através dos quais a equipe se organiza (Gestão de Times).

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software
- `unstable`: versão já testada do software, porém instável
- `testing`: versão em testes do software
- `dev`: versão de desenvolvimento do software

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `enhancement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida

Discuta como a configuração do projeto foi feita na ferramenta de versionamento escolhida. Exponha como a gerência de tags, merges, commits e branchs é realizada. Discuta como a gerência de issues foi realizada.

> **Links Úteis**:
> - [Tutorial GitHub](https://guides.github.com/activities/hello-world/)
> - [Git e Github](https://www.youtube.com/playlist?list=PLHz_AreHm4dm7ZULPAmadvNhH6vk9oNZA)
>  - [Comparando fluxos de trabalho](https://www.atlassian.com/br/git/tutorials/comparing-workflows)
> - [Understanding the GitHub flow](https://guides.github.com/introduction/flow/)
> - [The gitflow workflow - in less than 5 mins](https://www.youtube.com/watch?v=1SXpE08hvGs)

## Gerenciamento de Projeto

### Divisão de Papéis

Apresente a divisão de papéis entre os membros do grupo.

> **Links Úteis**:
> - [11 Passos Essenciais para Implantar Scrum no seu 
> Projeto](https://mindmaster.com.br/scrum-11-passos/)
> - [Scrum em 9 minutos](https://www.youtube.com/watch?v=XfvQWnRgxG0)

### Processo

Coloque  informações sobre detalhes da implementação do Scrum seguido pelo grupo. O grupo poderá fazer uso de ferramentas on-line para acompanhar o andamento do projeto, a execução das tarefas e o status de desenvolvimento da solução.
 
> **Links Úteis**:
> - [Project management, made simple](https://github.com/features/project-management/)
> - [Sobre quadros de projeto](https://docs.github.com/pt/github/managing-your-work-on-github/about-project-boards)
> - [Como criar Backlogs no Github](https://www.youtube.com/watch?v=RXEy6CFu9Hk)
> - [Tutorial Slack](https://slack.com/intl/en-br/)

### Ferramentas

As ferramentas empregadas no projeto são:

- Editor de código.
- Ferramentas de comunicação
- Ferramentas de desenho de tela (_wireframing_)

O editor de código foi escolhido porque ele possui uma integração com o
sistema de versão. As ferramentas de comunicação utilizadas possuem
integração semelhante e por isso foram selecionadas. Por fim, para criar
diagramas utilizamos essa ferramenta por melhor captar as
necessidades da nossa solução.

Liste quais ferramentas foram empregadas no desenvolvimento do projeto, justificando a escolha delas, sempre que possível.
 
> **Possíveis Ferramentas que auxiliarão no gerenciamento**: 
> - [Slack](https://slack.com/)
> - [Github](https://github.com/)
