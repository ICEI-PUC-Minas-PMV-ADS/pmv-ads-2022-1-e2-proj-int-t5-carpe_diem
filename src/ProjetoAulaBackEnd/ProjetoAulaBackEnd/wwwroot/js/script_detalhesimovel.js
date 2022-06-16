cards_places.innerHTML = ''

function card(img, lugar, regiao, qt_quarto, qt_hospede, qt_banheiro, price, link){
  card_html = `
  <div class="flex gap-3 w-f hover:shadow-3 transition" id="card_places">
      <div class="flex-1 shadow-1"> 
          <img class="w-f h-2 object-cover" src="${img}">
          <p class="p-1 bold-7 t-black t-center font-size-5">${lugar}</p>     
          <div class="grid grid-col-2 p-1">
              <div>
                  <p class="flex"><span class="material-symbols-outlined pr-1">local_see</span> ${regiao}</p>
                  <p class="flex"><span class="material-symbols-outlined pr-1">bed</span> ${qt_quarto} Quarto</p>
              </div>
              <div>
                  <p class="flex"><span class="material-symbols-outlined pr-1">person</span> ${qt_hospede} hóspedes</p>
                  <p class="flex"><span class="material-symbols-outlined pr-1">bathroom</span> ${qt_banheiro} Banheiro</p>
              </div>
          </div> 
          <p class="bold-6 t-black t-center p-1">A partir de R$ ${price} / noite</p>   
          <a href="${link}"><p class="bold-6 t-black t-center p-1 bg-blue-2 m-3">DETALHES</p></a>     
      </div>
  </div>
  `

  div = document.createElement('div')
  div.innerHTML = card_html

  cards_places.appendChild(div.children[0])
}

card('.../img/hotel-1.jpg', 'Casa em Vila Velha - ES', "Praia Morro", 1, 5, 1, 180, 'asp-area="" asp-controller="Imoveis" asp-action="Details"')
card('.../img/hotel-2.jpg', 'Casa em Vila Velha - ES', "Vitória", 1, 5, 1, 280, 'asp-area="" asp-controller="Imoveis" asp-action="Details"')
card('.../img/hotel-3.jpg', 'Casa em Vila Velha - ES', "São Luiz", 1, 5, 1, 130, 'asp-area="" asp-controller="Imoveis" asp-action="Details"')
card('.../img/hotel-4.jpg', 'Casa em Vila Velha - ES', "Florianópolis", 1, 5, 1, 980, 'asp-area="" asp-controller="Imoveis" asp-action="Details"')

d = new Date()
ano.innerHTML = d.getFullYear()

