# 9. Registro de Testes de Software

Relatório com os resultados obtidos nos testes de _software_ realizados na aplicação pela equipe, baseado em um plano de testes pré-definido.

## 9.1 Avaliação

Quadro 10 - Registro dos Testes

|Caso de Teste |Ação                                 |Resultado Esperado                              |Resultado Obtido                    |
|--------------|-------------------------------------|------------------------------------------------|------------------------------------|
|CT-01    |Realizar cadastro                    |Permitir que o usuário se cadastre na plataforma.|Objetivo alcançado. <br> Vídeo 01   |
|CT-02    |Realizar login                       |Permitir que o usuário faça login na plataforma. |Objetivo alcançado. <br> Vídeo 01   |
|CT-03    |Realizar gerenciamento do cadastro (Editar)   |Permitir que o usuário altere suas informações cadastradas.|Objetivo alcançado.<br> Vídeo 02 |
|CT-04    |Realizar gerenciamento do cadastro (Excluir)  |Permitir que o usuário exclua sua conta.|Objetivo alcançado. <br> Vídeo 02   |
|CT-05    |Realizar cadastro anfitrião e imóvel |Permitir que o hóspede se cadastre como anfitrião.<br>Permitir o cadastro do imóvel  |Objetivo alcançado. <br> Vídeo 04   |
|CT-06    |Redefinir senha                      |Permitir que o usuário redefina sua senha       |Objetivo não alcançado.             |
|CT-07    |Realizar busca por imóvel            |Permitir que o usuário realize a busca por imóveis de acordo com o filtro "cidade destino".<br>Apresentar nos resultados da busca somente os imóveis disponíveis na localidade selecionada.                               |Objetivo alcançado. <br> Vídeo 04|
|CT-08    |Realizar reserva do imóvel           |Permitir que o hóspede reserve um imóvel.<br>Notificar anfitrião da reserva do imóvel.|Objetivo alcançado parcialmente. <br> Vídeo 05|
|CT-09    |Realizar gerenciamento de reservas (Editar)   |Permitir que o hóspede altere as informações da sua reserva.|Objetivo alcançado.<br> Vídeo 06|
|CT-10    |Realizar gerenciamento de reservas (Cancelar)   |Permitir que o hóspede cancele sua reserva.|Objetivo alcançado.<br> Vídeo 06|
|CT-11    |Preencher formulário fale conosco    |Permitir o envio do formulário fale conosco     |Objetivo alcançado parcialmente. <br> Vídeo 07|

Fonte: Elaborado pelos Autores

<br>

### 9.1.1 Vídeo 01 - Caso de Teste 01 e 02

<https://sgapucminasbr.sharepoint.com/:v:/s/team_sga_865_2022_1_3657105-G5/EbJ0U52tJfxPhiUbYHDtwYgBImUFYOG1dovhbEA9nAOzKg?e=FS6BTG>


### 9.1.2 Vídeo 02 - Caso de Teste 03 e 04

https://sgapucminasbr.sharepoint.com/:v:/s/team_sga_865_2022_1_3657105-G5/ESdOb0g5zb1Cq2_FSk_UgvYBBpIcF9NSpCiNcc9SPIcu_g?e=3misDh


### 9.1.3 Vídeo 03 - Caso de Teste 05

https://sgapucminasbr.sharepoint.com/:v:/s/team_sga_865_2022_1_3657105-G5/ET3oFzSC-FJAjslnBfIV4roBkNoKqNmuC0V-cT5L7MEPJQ?e=WJgRvZ


### 9.1.4 Vídeo 04 - Caso de Teste 07

https://sgapucminasbr.sharepoint.com/:v:/s/team_sga_865_2022_1_3657105-G5/EUXNdFo2rQZNuD8dp_2FSqYB-zBx039gK4MbsUP8WCMPRw?e=UpMlBg


### 9.1.5 Vídeo 05 - Caso de Teste 08

https://sgapucminasbr.sharepoint.com/:v:/s/team_sga_865_2022_1_3657105-G5/EaBrzwgWD71CmPyEwoiyztwB06xVzYQOOfzBzNmiUk3azQ?e=E7cq8J


### 9.1.6 Vídeo 06 - Caso de Teste 09 e 10

https://sgapucminasbr.sharepoint.com/:v:/s/team_sga_865_2022_1_3657105-G5/Ed5H4YtBvA5Kn577I4PCHt8Bn8lIH4i_CwfmGckBeVI_bA?e=xVuPyO


### 9.1.7 Vídeo 07 - Caso de Teste 11

https://sgapucminasbr.sharepoint.com/:v:/s/team_sga_865_2022_1_3657105-G5/EZ3J1pFWW2hNrKcmnxzrvcQBQscz9-OlYcl3nh8f9TH2Pg?e=gBzy8n

<br>
## 9.2 Resultado do Teste de Software

Quadro 11 - Resultado

|Caso de Teste |Ação                                          |Relatório                   |
|--------------|----------------------------------------------|----------------------------|
|CT-01         |Realizar cadastro                             |Resultado obtido com êxito. |
|CT-02         |Realizar login                                |Resultado obtido com êxito. |
|CT-03         |Realizar gerenciamento do cadastro (Editar)   |É possível editar o cadastro, porém, para executar a tarefa é preciso acessar, logado, a lista geral de usuários, procurar seu nome e clicar em editar, pois não concluímos a página que irá direcionar diretamente para a edição do cadastro. |
|CT-04         |Realizar gerenciamento do cadastro (Excluir)  |É possível editar o cadastro, porém, para executar a tarefa é preciso acessar, logado, a lista geral de usuários, procurar seu nome e clicar em deletar, pois não concluímos a página que irá direcionar diretamente para a exclusão do cadastro. |
|CT-05         |Realizar cadastro anfitrião e imóvel          |Resultado obtido com êxito, com a ressalva de que o anfitrião precisa selecionar seu CPF numa lista contendo todos os CPFs cadastrados. Essa foi uma falha na aplicação que o grupo teve dificuldade de solucionar em tempo hábil. |
|CT-06         |Redefinir senha                               |Objetivo não alcançado pois a funcionalidade de enviar email para o usuário redefinir sua senha não foi concluída. |
|CT-07         |Realizar busca por imóvel                     |Não foi possível implementar todos os filtros de busca. <br> Está em funcionamento a busca por “cidade destino”.<br> Caso o usuário não preencha nenhum campo de busca e clique em buscar, será redirecionado para um resultado de busca não encontrada. |
|CT-08         |Realizar reserva do imóvel                    |Não foi possível implementar a funcionalidade de envio de email de confirmação. |
|CT-09         |Realizar gerenciamento de reservas (Editar)   |Para acessar as reservas é preciso o usuário acessar, logado, a lista geral de reservas no menu superior, selecionar a reserva desejada e editar os dados da reserva, pois não conseguimos concluir em tempo hábil a funcionalidade direcionada para a edição da reserva. |
|CT-10         |Realizar gerenciamento de reservas (Cancelar) |Para cancelar a reserva é preciso o usuário acessar, logado, a lista geral de reservas no menu superior, selecionar a reserva desejada e deletar a reserva. <br> A funcionalidade de enviar email para o usuário confirmando o cancelamento da reserva não foi concluída. |
|CT-11         |Preencher formulário fale conosco             |A funcionalidade de confirmação do envio do formulário não foi concluída, não sendo possível receber as informações preenchidas no formulário. |

Fonte: Elaborado pelos Autores
