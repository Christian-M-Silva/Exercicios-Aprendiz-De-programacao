package exercicio;

public class Pessoa {

	public static void main(String[] args) {
		SerHumano joao = new SerHumano();
		joao.nome= "João";
		joao.peso= "70";
		joao.Idioma= "English";
		
		System.out.println("O nome é " + joao.nome + " o peso é " + joao.peso + " e o idioma que ele fala é " + joao.Idioma);
		joao.viver();
		joao.terminar();
		

	}

}
