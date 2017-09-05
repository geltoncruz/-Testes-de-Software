class Retangulo{
	constructor(altura,largura ){
		this.altura = altura;
		this.largura = largura;
	}
	calcularArea(){ () => this.altura * this.largura;	}
}
var r = new Retangulo(12,21);
console.log(r.calcularArea());