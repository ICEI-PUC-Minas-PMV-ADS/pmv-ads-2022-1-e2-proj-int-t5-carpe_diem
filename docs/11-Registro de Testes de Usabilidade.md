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


### 11.1.1 Resultados Gráficos Relacionados ao Tempo Gasto

No que tange ao tempo gasto, os resultados foram convertidos para segundos, aspirando uma melhor visualização.

![image](https://user-images.githubusercontent.com/89549220/175822866-db1d3b70-0f4e-446d-ac86-b484d5790b5f.png)

![image](https://user-images.githubusercontent.com/89549220/175822871-2e1ad071-0374-42ae-a2e9-ce03108f0f99.png)

![image](https://user-images.githubusercontent.com/89549220/175822874-52795129-d9ef-4122-b315-077c7032b559.png)

![image](https://user-images.githubusercontent.com/89549220/175822881-b49793f3-7867-48a6-a106-d1143ee11704.png)

![image](https://user-images.githubusercontent.com/89549220/175822889-dbaf64e3-5e02-43c9-92a8-53fe11563dea.png)
<br>

### 11.1.2 Resultados Gráficos Relacionados ao Nível de Dificuldade

No que tange ao nível de dificuldade, os resultados foram direcionados ao quantitativo de voluntários que pontuaram cada nível, em cada teste, aspirando uma melhor visualização.

![image](https://user-images.githubusercontent.com/89549220/175822899-ea6d5dae-31c8-4bfa-8dab-0b538f894762.png)

![image](https://user-images.githubusercontent.com/89549220/175822918-432af064-d8e7-4e7f-a71c-713b82c96acb.png)

![image](https://user-images.githubusercontent.com/89549220/175822929-7b3e9dfb-b9c3-4592-b6b3-3034fe1112ae.png)

![image](https://user-images.githubusercontent.com/89549220/175822939-c1e3a3b2-f58b-4089-8055-f211defbc5ec.png)

![image](https://user-images.githubusercontent.com/89549220/175822946-ad5b5066-f78c-4f44-a0af-e1f40f8ccd36.png)
<br>

### 11.1.3 Resultados Gráficos Relacionados ao Nível de Satisfação

Em se tratando do nível de satisfação, os resultados foram direcionados ao quantitativo de voluntários que pontuaram cada nível, em cada teste, aspirando uma melhor visualização.

![image](https://user-images.githubusercontent.com/89549220/175822997-734cbbdb-3606-4462-8a3e-4832d8053d4b.png)

![image](https://user-images.githubusercontent.com/89549220/175823005-39a55ddd-ac40-4340-b832-35a3f3f224c1.png)

![image](https://user-images.githubusercontent.com/89549220/175823011-6674d00f-ed25-48de-9039-a8e5e15db5a3.png)

![image](https://user-images.githubusercontent.com/89549220/175823018-ce514b09-f054-48ca-996b-724be434e861.png)

![image](https://user-images.githubusercontent.com/89549220/175823021-018c881a-1d82-40b7-aff8-4d68662e2a19.png)
<br>
