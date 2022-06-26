# 9. Registro de Testes de Software

Relatório com os resultados obtidos nos testes de _software_ realizados na aplicação pela equipe, baseado em um plano de testes pré-definido.

## 9.1 Avaliação

Quadro 10 - Registro dos Testes

|Caso de Teste |Ação                                 |Resultado Esperado                              |Resultado Obtido                    |
|--------------|-------------------------------------|------------------------------------------------|------------------------------------|
|CT-01    |Realizar cadastro                    |Permitir que o usuário se cadastre na plataforma.|Objetivo alcançado. <br> Vídeo 01   |
|CT-02    |Realizar login                       |Permitir que o usuário faça login na plataforma. |Objetivo alcançado. <br> Vídeo 02   |
|CT-03    |Realizar gerenciamento do cadastro (Editar)   |Permitir que o usuário altere suas informações cadastradas.|Objetivo alcançado.<br> Vídeo 03 |
|CT-04    |Realizar gerenciamento do cadastro (Excluir)  |Permitir que o usuário exclua sua conta.|Objetivo alcançado. <br> Vídeo 03   |
|CT-05    |Realizar cadastro anfitrião e imóvel |Permitir que o hóspede se cadastre como anfitrião.<br>Permitir o cadastro do imóvel  |Objetivo alcançado. <br> Vídeo 04   |
|CT-06    |Redefinir senha                      |Permitir que o usuário redefina sua senha       |Objetivo não alcançado.             |
|CT-07    |Realizar busca por imóvel            |Permitir que o usuário realize a busca por imóveis de acordo com o filtro "cidade destino".<br>Apresentar nos resultados da busca somente os imóveis disponíveis na localidade selecionada.                               |Objetivo alcançado. <br> Vídeo 05|
|CT-08    |Realizar reserva do imóvel           |Permitir que o hóspede reserve um imóvel.<br>Notificar anfitrião da reserva do imóvel.|Objetivo alcançado parcialmente. <br> Vídeo 06|
|CT-09    |Realizar gerenciamento de reservas (Editar)   |Permitir que o hóspede altere as informações da sua reserva.|Objetivo alcançado.<br> Vídeo 07|
|CT-10    |Realizar gerenciamento de reservas (Cancelar)   |Permitir que o hóspede cancele sua reserva.|Objetivo alcançado.<br> Vídeo 07|
|CT-11    |Preencher formulário fale conosco    |Permitir o envio do formulário fale conosco     |Objetivo alcançado parcialmente. <br> Vídeo 08|

Fonte: Elaborado pelos Autores

<br>

### 9.1.1 Vídeo 01 - Caso de Teste 01 e 02

<https://sgapucminasbr.sharepoint.com/:v:/s/team_sga_865_2022_1_3657105-G5/EbJ0U52tJfxPhiUbYHDtwYgBImUFYOG1dovhbEA9nAOzKg?e=FS6BTG>


### 9.1.2 Vídeo 02 - Caso de Teste 03

<https://sgapucminasbr.sharepoint.com/:v:/s/team_sga_865_2022_1_3657105-G5/EYkvrVSh8CFLhnzqEvcZgNsBck_bRJRPTrHAa480YcIsfQ?e=1Nopm3>


### 9.1.3 Vídeo 03 - Caso de Teste 04

https://sgapucminasbr.sharepoint.com/:v:/s/team_sga_865_2022_1_3657105-G5/EYJcMDS5K89HnY8t1TJsp0AB-2UBvT6By0yzN2akYlLY4A?e=MdwrBX


### 9.1.3 Vídeo 04 - Caso de Teste 05




### 9.1.3 Vídeo 05 - Caso de Teste 07




### 9.1.3 Vídeo 06 - Caso de Teste 08




### 9.1.3 Vídeo 07 - Caso de Teste 09 e 10




### 9.1.3 Vídeo 08 - Caso de Teste 11




## 9.2 Resultado do Teste de Software

Quadro 11 - Resultado

|Caso de Teste |Ação                                          |Relatório |
|--------------|----------------------------------------------|----------|
|CT-01         |Realizar cadastro                             |Resultado obtido com êxito. |
|CT-02         |Realizar login                                |Resultado obtido com êxito. |
|CT-03         |Realizar gerenciamento do cadastro (Editar)   |Resultado obtido com êxito. |
|CT-04         |Realizar gerenciamento do cadastro (Excluir)  |Para excluir o cadastro é preciso acessar, logado, a lista geral de usuários, procurar seu nome na lista de clicar em deletar, pois não concluímos a página que irá direcionar diretamente para a exclusão do cadastro. |
|CT-05         |Realizar cadastro anfitrião e imóvel          |Resultado obtido com êxito. |
|CT-06         |Redefinir senha                               |Objetivo não alcançado pois a funcionalidade de enviar email para o usuário redefinir sua senha não foi concluída. |
|CT-07         |Realizar busca por imóvel                     |Não foi possível implementar todos os filtros de busca. <br> Está em funcionamento a busca por “cidade destino”.<br> Caso o usuário não preencha nenhum campo de busca e clique em buscar, será redirecionado para um resultado de busca não encontrada. |
|CT-08         |Realizar reserva do imóvel                    |Não foi possível implementar a funcionalidade de envio de email de confirmação. |
|CT-09         |Realizar gerenciamento de reservas (Editar)   |Para acessar as reservas é preciso o usuário acessar, logado, a lista geral de reservas no menu superior, selecionar a reserva desejada e editar os dados da reserva, pois não conseguimos concluir em tempo hábil a funcionalidade direcionada para a edição da reserva. |
|CT-10         |Realizar gerenciamento de reservas (Cancelar) |Para cancelar a reserva é preciso o usuário acessar, logado, a lista geral de reservas no menu superior, selecionar a reserva desejada e deletar a reserva. <br> A funcionalidade de enviar email para o usuário confirmando o cancelamento da reserva não foi concluída. |
|CT-11         |Preencher formulário fale conosco             |A funcionalidade de confirmação do envio do formulário não foi concluída, não sendo possível receber as informações preenchidas no formulário. |

Fonte: Elaborado pelos Autores
