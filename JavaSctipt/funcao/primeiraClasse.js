// criar função forma literal
function fun1() {}

// armazenar em uma variavel
const fun2 = function() {}

// armazenar em um array
const array = [function(a,b){return a+b}, fun1,fun2]
console.log(array[0](2,3))

// armezenar em um atributo de objeto
const obj = {}
obj.falar = function() {return 'Eu sou da Viktech!!'}
console.log(obj.falar())

// Passando a função como param
function run(fun){
    fun()
}

run(function () {console.log('Executando...')})

// função que pode retornar/conter uma função

function soma(a,b){
    return function(c){
        console.log(a + b + c)
    }
}

soma(2,3)(4)
const cincoMais = soma(2,3)
cincoMais(4)