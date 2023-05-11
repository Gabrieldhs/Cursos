const escola = "Coder"

console.log(escola.charAt(4)) // retornando a posição do indice
console.log(escola.charAt(5)) // retornando null
console.log(escola.charCodeAt(3)) // retornando o valor Unicode
console.log(escola.indexOf('e')) // retornando o valor mencionado

console.log(escola.substring(1))// retornando o valor do indice até o final
console.log(escola.substring(0,3)) // retornando até o indice 2
console.log('Escola'.concat(escola).concat("!"))
console.log(escola.replace(3, 'e')) // substituindo o indice

console.log('Ana,Maria,Pedro'.split(','))
