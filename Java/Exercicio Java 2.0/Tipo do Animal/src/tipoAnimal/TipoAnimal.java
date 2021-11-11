package tipoAnimal;

public class TipoAnimal {

	public static void main(String[] args) {
		/*
		 * Desenvolva um programa no qual o usuário deverá informar o nome e o tipo de
		 * três animais de estimação. O programa deverá exibir na tela para o usuário
		 * quantos Animais foram informados e seus tipos. Regras que deverão ser
		 * seguidas para a implementação do código:
		 * 
		 * •Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
		 * 
		 * •Caso seja informado um tipo diferente o programa deverá definir o tipo do
		 * animal como Peixe.
		 * 
		 * •É obrigatório criar uma classe para representar o Animal.
		 * 
		 * •A classe deverá possuir dois dados privados (propriedades) para representar
		 * as características do animal.
		 * 
		 * •A classe deverá possuir métodos de acesso para permitir que o usuário
		 * armazene/leia os dados dos dois dados privados (propriedades).
		 */
		
		Animal animal1 = new Animal();
		animal1.nome();
		animal1.tipo();
		animal1.setPeso(null);
		animal1.setAltura(null);
		System.out.println();
	
		
		Animal animal2 = new Animal();
		animal2.nome();
		animal2.tipo();
		animal2.setPeso(null);
		animal2.setAltura(null);
		System.out.println();
		
		Animal animal3 = new Animal();
		animal3.nome();
		animal3.tipo();
		animal3.setPeso(null);
		animal3.setAltura(null);
		System.out.println();
		
		animal1.exibir();
		System.out.println("____________________________");
		animal2.exibir();
		System.out.println("____________________________");
		animal3.exibir();	
	}

}
