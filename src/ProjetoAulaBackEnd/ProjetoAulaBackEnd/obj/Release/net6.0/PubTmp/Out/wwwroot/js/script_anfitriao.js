cards_places.innerHTML = ''

function card(img, link){
  card_html = `
  <div class="flex gap-3 w-f hover:shadow-3 transition" id="card_places">
      <div class="flex-1 shadow-1"> 
          <a href='${link}'><img class="w-f h-2 object-cover" src="${img}"> </a>
                                
          <a href="${link}"><p class="bold-6 t-black t-center p-1 bg-blue-2 m-3">EDITAR INFORMAÇÕES DO IMÓVEL</p></a> 
          
          <a href="${link}"><p class="bold-6 t-black t-center p-1 bg-blue-2 m-3">DESATIVAR IMÓVEL</p></a>

          <a href="${link}"><p class="bold-6 t-black t-center p-1 bg-blue-2 m-3">CANCELAR RESERVA</p></a>
      </div>
  </div>
  `

  div = document.createElement('div')
  div.innerHTML = card_html

  cards_places.appendChild(div.children[0])
}

card('img/hotel-1.jpg', 1, 5, 1, 180, 'http://www.youtube.com')
card('img/hotel-2.jpg', 1, 5, 1, 280, 'http://www.google.com')
card('img/hotel-3.jpg', 1, 5, 1, 130, 'http://www.clickjogos.com')
card('img/hotel-4.jpg', 1, 5, 1, 980, 'https://pt.wikipedia.org/')
card('img/hotel-1.jpg', 1, 5, 1, 180, 'http://www.youtube.com')
card('img/hotel-2.jpg', 1, 5, 1, 280, 'http://www.google.com')
card('img/hotel-3.jpg', 1, 5, 1, 130, 'http://www.clickjogos.com')
card('img/hotel-4.jpg', 1, 5, 1, 980, 'https://pt.wikipedia.org/')



// slideshow
setInterval(()=>{ capa.scrollTo(0,0*400) },2*1000)
setInterval(()=>{ capa.scrollTo(0,1*400) },4*1000)
setInterval(()=>{ capa.scrollTo(0,2*400) },6*1000)
setInterval(()=>{ capa.scrollTo(0,3*400) },8*1000)

d = new Date()
ano.innerHTML = d.getFullYear()