let d = new Date()
let year = d.getFullYear()

for(i of document.querySelectorAll(".copyright")){
    i.innerHTML = `© Copyright ${year} Carpe Diem - Todos os Direitos Reservados`
}