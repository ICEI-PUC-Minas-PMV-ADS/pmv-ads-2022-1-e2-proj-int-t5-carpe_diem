cards_places.innerHTML = ''

function card(img, link1, link2, link3){
  card_html = `
  <div class="flex gap-3 w-f hover:shadow-3 transition" id="card_places">
      <div class="flex-1 shadow-1"> 
          <a><img class="w-f h-2 object-cover" src="${img}"> </a>
          <a href="${link1}"><p class="bold-6 t-black t-center p-1 bg-blue-2 m-3">DETALHES</p></a> 
          <a href="${link2}"><p class="bold-6 t-black t-center p-1 bg-blue-2 m-3">EDITAR RESERVA</p></a>
          <a href="${link3}"><p class="bold-6 t-black t-center p-1 bg-blue-2 m-3">CANCELAR RESERVA</p></a>
      </div>
  </div>
  `

  div = document.createElement('div')
  div.innerHTML = card_html

  cards_places.appendChild(div.children[0])
}

card('img/hotel-1.jpg', 'detalhes_imovel.html', 'editar_reserva.html', 'editar_reserva.html' )
card('img/hotel-2.jpg', 'detalhes_imovel.html', 'editar_reserva.html', 'editar_reserva.html' )
card('img/hotel-3.jpg', 'detalhes_imovel.html', 'editar_reserva.html', 'editar_reserva.html' )
card('img/hotel-4.jpg', 'detalhes_imovel.html', 'editar_reserva.html', 'editar_reserva.html' )



// slideshow
setInterval(()=>{ capa.scrollTo(0,0*400) },2*1000)
setInterval(()=>{ capa.scrollTo(0,1*400) },4*1000)
setInterval(()=>{ capa.scrollTo(0,2*400) },6*1000)
setInterval(()=>{ capa.scrollTo(0,3*400) },8*1000)

d = new Date()
ano.innerHTML = d.getFullYear()