
# 3. Metodologia

A metodologia circunstancia as ferramentas aplicadas pelo grupo na organização e na estruturação da implantação das tarefas do projeto, assim como nas plataformas e artefatos utilizados para a manutenção e conservação dos códigos.


## 3.1 Relação de Ambientes de Trabalho

Os artefatos do projeto são acompanhados e evoluídos com a ajuda de diferentes plataformas, cada qual com sua função específica. A combinação dos ambientes com suas respectivas finalidades é apresentada no quadro abaixo.

Quadro x - Ambientes de Trabalho

| AMBIENTE                             | PLATAFORMA        | LINK DE ACESSO |
|--------------------------------------|-------------------|----------------|
| Repositório de Código Fonte          | GitHub            | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t5-carpe_diem |
| Projeto de Interface e  _Wireframes_ | Figma             | (processo não iniciado) |
| Gerenciamento do Projeto             | Projects - GitHub | colocar link |

Fonte: Elaborado pelos autores


## 3.2 Gestão de Código Fonte

De acordo com Vietro (2015), é importante observar o uso de técnicas e metodologias para o desenvolvimento de sistemas, buscando melhorar as práticas atuais. Diante disso torna-se essencial o gerenciamento do _software_, e isso envolve administrar as várias etapas do processo, como, por exemplo: requisitos do sistema, arquitetura do _software_, padrões de codificação, gerência de configuração, _deploy_, entre outros.

Pensando nesse contexto, o grupo optou por utilizar um processo fundamentado no _GitFlow_ para a gestão do código fonte do _software_ que será desenvolvido. 

O _GitFlow_ é um _framework_ criado em 2010 e considerado um ótimo modelo de _branching_, além de ser usado para trabalhar em conjunto com o sistema de controle de versão Git (VIETRO, 2015). Assim sendo, as manutenções do código serão efetuadas definindo-se os papéis de cada _branch_ em separado, como eles devem interagir entre si, e com a identificação de _Branch Master, Branch Develop, Feature Branch, Release Branch, Maintenance Branch (Hotfix)_.

Figura x - _GitFlow Workflow_ <br>
Modelo de Fluxo de Controle do Código Fonte no Repositório Git

![image](https://user-images.githubusercontent.com/89549220/158081865-4b79a24d-9a25-4a51-baab-c757846680b3.png)

Fonte: Vietro (2015)

Esse modelo de _workflow_ utiliza dois _branches_ principais para guardar o histórico do projeto, ao invés de trabalhar com apenas um _Branch Master_. O _Branch Master_ guarda o histórico oficial das entregas, já o _Branch Develop_ serve como integração entre todos os _branches_ de funcionalidades (_Feature Branches_). Cada funcionalidade deve ter seu próprio _branch_, e ele deve ser criado a partir do _Branch Develop_. Quando uma funcionalidade for concluída, ela é mesclada (_merged_) novamente com o seu _branch_ pai. Quando o _Branch Develop_ estiver com funcionalidades suficientes para uma entrega, criaremos um _branch_ de entrega (_Release Branch_). Com isso, damos início ao próximo ciclo de entrega, ou seja, nenhuma nova funcionalidade pode ser incluída a partir desse momento. Quando estivermos prontos para realizar a entrega, o _Release Branch_ é mesclada com os _branches Master e Develop_. O _Maintenance Branches (Hotfix)_ são usados para corrigir rapidamente algum problema em produção. Este é o único _branch_ que deve ser criado a partir do _Master_. Assim que a correção for finalizada, o _branch_ é fechado e mesclado com o _Master e Develop_, mantendo assim as linhas completamente atualizadas (VIETRO, 2015).


## 3.3 Gerenciamento do Projeto


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
