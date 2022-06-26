# 11. Registro de Testes de Usabilidade

O Registro de Testes de Usabilidade é um relatório que contém as evidências dos testes e relatos dos usuários participantes, baseado no Plano de Testes de Usabilidade desenvolvido para os casos de uso desta etapa. Após realizar os testes de usabilidade, obtém-se um relatório a partir das análises realizadas.

Quadro 13 - Perfil dos Voluntários

|IDENTIFICAÇÃO | IDADE    | GRAU DE INSTRUÇÃO    | PROFISSÃO                     | AÇÃO/TESTE APLICADO    |
|--------------|----------|----------------------|-------------------------------|------------------------|
|Voluntário 01 |    46    |Superior Completo     |Servidor Público               |Cadastro de novo usuário e cadastrar imóvel|
|Voluntário 02 |    21    |Superior Incompleto   |Estudante                      |Cadastro de novo usuário|
|Voluntário 03 |    37    |Ensino Médio Incomp.  |Autônomo                       |Cadastro de novo usuário e logar no sistema|
|Voluntário 04 |    33    |Ensino Médio Completo |Manobrador de Locomotiva       |Cadastro de novo usuário, cadastrar imóvel, realizar a busca e reserva de um imóvel e utilizar o Fale Conosco|
|Voluntário 05 |    30    |Superior Incompleto   |Estudante                      |Cadastro de novo usuário|
|Voluntário 06 |    42    |Superior Completo     |Administrador                  |Logar no sistema, cadastrar imóvel, realizar a busca e reserva de um imóvel e Utilizar o Fale Conosco|
|Voluntário 07 |    27    |Superior Incompleto   |Bancario                       |Logar no sistema|
|Voluntário 08 |    55    |Ensino Médio Incomp.  |Cozinheiro                     |Logar no sistema|
|Voluntário 09 |    38    |Superior Completo     |Bombeiro Militar               |Logar no sistema, realizar a busca e reserva de um imóvel e utilizar o Fale Conosco|
|Voluntário 10 |    27    |Superior Completo     |Fisioterapeuta                 |Cadastrar imóvel, realizar a busca e reserva de um imóvel e utilizar o Fale Conosco|
|Voluntário 11 |    55    |Superior Incompleto   |Vendedor                       |Cadastrar imóvel, realizar a busca e reserva de um imóvel e utilizar o Fale Conosco|

Fonte: Elaborado pelos autores
<br><br>

No teste de usabilidade, conforme pode ser observado no Quadro 14, foi avaliado: a) Concretização da tarefa. b) Quantidade e tipo de erros cometidos. c) Tempo necessário para se concluir.

Quadro 14 - Testes de Usabilidade

|IDENTIFICAÇÃO |TESTE                                   |TEMPO GASTO   |NÍVEL DE DIFICULDADE |NÍVEL DE SATISFAÇÃO |
|--------------|----------------------------------------|--------------|---------------------|--------------------|
|Voluntário 01 |Cadastro de novo usuário                |2min 05seg.   |4                    |4                   |
|Voluntário 01 |Cadastrar Imóvel                        |3min 50seg.   |4                    |5                   |
|Voluntário 02 |Cadastro de novo usuário                |1min 48seg.   |4                    |5                   |
|Voluntário 03 |Cadastro de novo usuário                |2min 53seg.   |2                    |4                   |
|Voluntário 03 |Logar no Sistema                        |1min 10seg.   |4                    |5                   |
|Voluntário 04 |Cadastro de novo usuário                |1min 40seg.   |4                    |5                   |
|Voluntário 04 |Cadastrar Imóvel                        |4min 20seg.   |5                    |5                   |
|Voluntário 04 |Realizar a busca e reserva de um imóvel |2min 24seg.   |3                    |4                   |
|Voluntário 04 |Utilizar o Fale Conosco                 |2min 05seg.   |4                    |3                   |
|Voluntário 05 |Cadastro de novo usuário                |1min 32seg.   |4                    |5                   |
|Voluntário 06 |Logar no Sistema                        |1min 24seg.   |4                    |5                   |
|Voluntário 06 |Cadastrar Imóvel                        |3min 59seg.   |4                    |4                   |
|Voluntário 06 |Realizar a busca e reserva de um imóvel |1min 48seg.   |4                    |4                   |
|Voluntário 06 |Utilizar o Fale Conosco                 |1min 50seg.   |3                    |2                   |
|Voluntário 07 |Logar no Sistema                        |1min 20seg.   |4                    |5                   |
|Voluntário 08 |Logar no Sistema                        |1min 05seg.   |4                    |5                   |
|Voluntário 09 |Logar no Sistema                        |1min 22seg.   |4                    |5                   |
|Voluntário 09 |Realizar a busca e reserva de um imóvel |1min 53seg.   |4                    |4                   |
|Voluntário 09 |Utilizar o Fale Conosco                 |1min 42seg.   |3                    |3                   |
|Voluntário 10 |Cadastrar Imóvel                        |3min 42seg.   |4                    |5                   |
|Voluntário 10 |Realizar a busca e reserva de um imóvel |2min 14seg.   |4                    |5                   |
|Voluntário 10 |Utilizar o Fale Conosco                 |1min 55seg.   |4                    |4                   |
|Voluntário 11 |Cadastrar Imóvel                        |4min 09seg.   |4                    |4                   |
|Voluntário 11 |Realizar a busca e reserva de um imóvel |1min 59seg.   |4                    |4                   |
|Voluntário 11 |Utilizar o Fale Conosco                 |1min 36seg.   |4                    |4                   |

Fonte: Elaborado pelos autores
<br>

## 11.1 Relatório de Teste de Usabilidade

Quadro 15 - Resultado

|TESTE REALIZADO                         |AVALIAÇÃO DO TESTE                                         |
|----------------------------------------|-----------------------------------------------------------|
|Cadastro de novo usuário                |Com a aplicação do teste de cadastro de novo usuário pudemos identificar algumas oportunidades de melhoria na aplicação. Por exemplo, um voluntário relatou que se digitasse qualquer número no CPF, independente da quantidade de dígitos, ele poderia concluir seu cadastro. Outro voluntário relatou que após a finalização do cadastro, ficou um pouco perdido sobre o que deveria fazer. </BR> Diante desses questionamentos, foram implementadas melhorias como a utilização de máscara para o CPF e posteriormente a utilização de código para verificar se o CPF era válido como também, o limite de onze caracteres. No geral, os voluntários enfatizaram a beleza do site e o ambiente agradável de navegação.|
|Logar no sistema                        |A tarefa de logar no sistema foi realizada por todos os voluntários sem dificuldades ou queixas, sendo considerada uma tarefa fácil de se realizar.|
|Realizar a busca e reserva de um imóvel |A tarefa de busca e reserva de imóvel, apesar de suas limitações por algumas funcionalidades não concretizadas, foi realizada sem grandes dificuldades pelos voluntários. Os mesmos foram orientados previamente que a busca deveria ser realizada utilizando-se somente o filtro de "cidade destino", já que os outros filtros ainda não foram implantados. Foram orientados também sobre a impossibilidade de se calcular o valor total da reserva no momento. No geral, os voluntários se sentiram satisfeitos com a realização da tarefa.|
|Cadastrar imóvel                        |A tarefa de cadastrar imóvel, mesmo sendo uma tarefa que requer mais tempo para ser realizada, foi conluída sem dificuldades pelos voluntários, sendo elogiada por ser "bem completa". Os voluntários foram orientados previamente sobre uma falha na aplicação, onde o anfitrião precisa selecionar seu CPF entre uma lista de todos os anfitriões cadastrados, para que possa iniciar o cadastro do seu imóvel. Essa falha no sistema foi uma das grandes dificuldades do grupo para a finalização do projeto e não pode ser corrigida em tempo hábil. |
|Utilizar o Fale Conosco                 |Apesar da facilidade em se concluir a tarefa de utilizar o Fale Conosco, alguns voluntários consideraram a tarefa como sendo "neutra", já que a tarefa não é efetivada através do envio da mensagem aos administradores do site. Essa foi outra dificuldade encontrada pelo grupo, não sendo possível finalizar a funcionalidade em tempo hábil.|

Fonte: Elaborado pelos autores
<br>
