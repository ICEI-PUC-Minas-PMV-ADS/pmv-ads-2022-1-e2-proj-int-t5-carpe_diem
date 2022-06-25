
cards_places.innerHTML = ''

function card(img, lugar, link1, link2, link3) {

    card_html = `
    <div class="flex gap-3 w-f hover:shadow-3 transition" id="card_places">
        <div class="flex-1 shadow-1">
            <a><img class="w-f h-2 object-cover" src="${img}"></a>
            <div class="card-reserva">
                <div class="card-t card-center card-title">${lugar}</div>
                <div class="card-m">
                    <a href="${link1}"><p class="font-size-5 bold-7 t-center p-1 t-black btn btn-blue btn-effect w-f">Detalhes</p></a>
                    <a href="${link2}"><p class="font-size-5 bold-7 t-center p-1 t-black btn btn-blue btn-effect w-f">Editar Reserva</p></a>
                    <a href="${link3}"><p class="font-size-5 bold-7 t-center p-1 t-black btn btn-blue btn-effect w-f">Cancelar Reserva</p></a>
                </div>            
            </div>
        </div>
    </div>`


    div = document.createElement('div')
    div.innerHTML = card_html

    cards_places.appendChild(div.children[0])
}

card('/img/hotel-1.jpg', 'Arraial DAjuda', 'asp-area="" asp-controller="Imoveis" asp-action="Details"')
card('/img/hotel-2.jpg', 'Maragogi', 'asp-area="" asp-controller="Imoveis" asp-action="Details"')
card('/img/hotel-3.jpg', 'Praia de Sao Marcos', 'asp-area="" asp-controller="Imoveis" asp-action="Details"')
card('/img/hotel-4.jpg', 'Praia de Canasvieiras', 'asp-area="" asp-controller="Imoveis" asp-action="Details"')



// slideshow
setInterval(() => { capa.scrollTo(0, 0 * 400) }, 2 * 1000)
setInterval(() => { capa.scrollTo(0, 1 * 400) }, 4 * 1000)
setInterval(() => { capa.scrollTo(0, 2 * 400) }, 6 * 1000)
setInterval(() => { capa.scrollTo(0, 3 * 400) }, 8 * 1000)

d = new Date()
ano.innerHTML = d.getFullYear()

