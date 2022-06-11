cards_places.innerHTML = ''

function card(img, lugar, regiao, qt_quarto, qt_hospede, qt_banheiro, price, link){
  card_html = `
  <div class="flex gap-3 w-f hover:shadow-3 transition" id="card_places">
      <div class="flex-1 shadow-1"> 
          <a href='${link}'><img class="w-f h-2 object-cover" src="${img}"> </a>
          <p class="p-1 bold-7 t-black t-center font-size-5">${regiao}</p>     
          <div class="grid grid-col-2 p-1">
              <div>
                  <p class="flex"><span class="material-symbols-outlined pr-1">local_see</span> ${lugar}</p>
                  <p class="flex"><span class="material-symbols-outlined pr-1">bed</span> ${qt_quarto} Quarto</p>
              </div>
              <div>
                  <p class="flex"><span class="material-symbols-outlined pr-1">person</span> ${qt_hospede} hóspedes</p>
                  <p class="flex"><span class="material-symbols-outlined pr-1">bathroom</span> ${qt_banheiro} Banheiro</p>
              </div>
          </div> 
          <p class="bold-6 t-black t-center p-1">A partir de R$ ${price} / noite</p>     
      </div>
  </div>
  `

  div = document.createElement('div')
  div.innerHTML = card_html

  cards_places.appendChild(div.children[0])
}

card('img/hotel-1.jpg', 'Praia', "Porto Seguro - BA"  , 1, 5, 1, 180, 'http://www.youtube.com')
card('img/hotel-2.jpg', 'Praia', "Vitória - ES"       , 1, 5, 1, 280, 'http://www.google.com')
card('img/hotel-3.jpg', 'Praia', "São Luiz - MA"      , 1, 5, 1, 130, 'http://www.clickjogos.com')
card('img/hotel-4.jpg', 'Praia', "Florianópolis - SC" , 1, 5, 1, 980, 'https://pt.wikipedia.org/')

// slideshow
setInterval(()=>{ capa.scrollTo(0,0*400) },2*1000)
setInterval(()=>{ capa.scrollTo(0,1*400) },4*1000)
setInterval(()=>{ capa.scrollTo(0,2*400) },6*1000)
setInterval(()=>{ capa.scrollTo(0,3*400) },8*1000)

d = new Date()
ano.innerHTML = d.getFullYear()