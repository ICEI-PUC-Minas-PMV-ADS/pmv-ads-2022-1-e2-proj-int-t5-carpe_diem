// cards_places.innerHTML = ''

function card(img, lugar, regiao, qt_quarto, qt_hospede, qt_banheiro, price, link) {

    let card_html = `<div class="card shadow-1 hover:shadow-3 transition" id="div_card">
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
            <a href="${link}"><p class="bold-6 t-black t-center p-1 bg-blue-2 m-3">DETALHES</p></a>
        </div>
    </div>`

    div = document.createElement('div')
    div.innerHTML = card_html

    cards_places.appendChild(div.children[0])

}

card('/img/hotel-1.jpg', 'Arraial DAjuda', "Porto Seguro", 1, 5, 1, 180, 'asp-area="" asp-controller="Imoveis" asp-action="Details"')
card('/img/hotel-2.jpg', 'Maragogi', "Alagoas", 1, 5, 1, 280, 'asp-area="" asp-controller="Imoveis" asp-action="Details"')
card('/img/hotel-3.jpg', 'Praia de São Marcos', "São Luiz", 1, 5, 1, 130, 'asp-area="" asp-controller="Imoveis" asp-action="Details"')
card('/img/hotel-4.jpg', 'Praia de Canasvieiras', "Florianópolis", 1, 5, 1, 980, 'asp-area="" asp-controller="Imoveis" asp-action="Details"')

cards_places.children[0].remove()
// slideshow
n = 0
quantity = capa.children.length

setInterval(() => { capa.scrollTo(capa.offsetWidth * (++n % quantity), 0) }, 4 * 1000)

// capa.scrollTo(capa.offsetWidth*0,0)

