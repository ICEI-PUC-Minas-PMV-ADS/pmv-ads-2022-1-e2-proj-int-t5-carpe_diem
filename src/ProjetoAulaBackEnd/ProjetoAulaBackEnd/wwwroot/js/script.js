// cards_places.innerHTML = ''

function card(img, lugar, regiao, qt_quarto, qt_hospede, qt_banheiro, price, link){

    let card_html = `<div class="card" id="div_card">
        <img class="card-top" src="${img}">
        <div class="card-body">
            <div class="card-t card-center card-title">${lugar}</div>
            <div class="card-m">
                <div class="card-center-y"> <span class="material-symbols-outlined pr-1">local_see</span>${regiao} </div>
                <div class="card-center-y"> <span class="material-symbols-outlined pr-1">person</span>${qt_hospede} hóspedes </div>
                <div class="card-center-y"> <span class="material-symbols-outlined pr-1">bed</span>${qt_quarto} Quarto </div>
                <div class="card-center-y"> <span class="material-symbols-outlined pr-1">bathroom</span>${qt_banheiro} Banheiro </div>
            </div>
            <div class="card-b card-center"><b>A partir de R$ ${price} / noite</b></div>
        </div>
    </div>`

  div = document.createElement('div')
  div.innerHTML = card_html

  cards_places.appendChild(div.children[0])
  
}

card('img/hotel-1.jpg', 'Praia', "Porto Seguro"  , 1, 5, 1, 180, 'http://www.youtube.com')
card('img/hotel-2.jpg', 'Praia', "Vitória"       , 1, 5, 1, 280, 'http://www.google.com')
card('img/hotel-3.jpg', 'Praia', "São Luiz"      , 1, 5, 1, 130, 'http://www.clickjogos.com')
card('img/hotel-4.jpg', 'Praia', "Florianópolis" , 1, 5, 1, 980, 'https://pt.wikipedia.org/')
cards_places.children[0].remove()

// slideshow
n = 0
quantity = capa.children.length

setInterval(()=>{ capa.scrollTo(capa.offsetWidth*(++n%quantity),0) }, 4*1000)

// capa.scrollTo(capa.offsetWidth*0,0)
