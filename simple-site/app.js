//Ativa o modo estrito, ajudando a informar possíveis erros de código que antes não seriam possíveis de existir
'use strict'
const swithcer = document.querySelector('.btn');

swithcer.addEventListener('click', function() {
    document.body.classList.toggle('light-theme');
    document.body.classList.toggle('dark-theme');

    const className = document.body.className;
    if(className == "light-theme") {
        this.textContent = "Dark";
    } else {
        this.textContent = "Light";
    }

    console.log('Nome da classe atual: ' + className);
});