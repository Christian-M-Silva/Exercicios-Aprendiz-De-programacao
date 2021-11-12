package pessoa;



public class Pessoas {

	public static void main(String[] args) {
			
		//INICIO DA PESSOA 1
		System.out.println("---------------------------");
		Pessoa pessoa1= new Pessoa();
	
		System.out.println("Escreva o nome da pessoa");
		pessoa1.nome();
		System.out.println();
		
		System.out.println("Escreva a idade da pessoa");
		pessoa1.idade();
		System.out.println();
		System.out.println("---------------------------");
		System.out.println();
		//FIM DA PESSOA 1
		
		
		//INICIO DA PESSOA 2
		System.out.println("---------------------------");
		Pessoa pessoa2= new Pessoa();
			
		System.out.println("Escreva o nome da pessoa");
		pessoa2.nome();
		System.out.println();
				
		System.out.println("Escreva a idade da pessoa");
		pessoa2.idade();
		System.out.println();
		System.out.println("---------------------------");
		System.out.println();
		//FIM DA PESSOA 2
		
		//INICIO DA PESSOA 3
		System.out.println("---------------------------");
		Pessoa pessoa3= new Pessoa();
					
		System.out.println("Escreva o nome da pessoa");
		pessoa3.nome();
		System.out.println();
						
		System.out.println("Escreva a idade da pessoa");
		pessoa3.idade();
		System.out.println();
		System.out.println("---------------------------");
		System.out.println();
		//FIM DA PESSOA 3
		
		if((pessoa1.idade > pessoa2.idade) && (pessoa1.idade > pessoa3.idade)) {
			System.out.println(pessoa1.nome + " tem a maior idade dos três, a idade dele é " + pessoa1.idade);
		}
		else if((pessoa2.idade > pessoa1.idade) && (pessoa2.idade > pessoa3.idade)) {
			System.out.println(pessoa2.nome + " tem a maior idade dos três, a idade dele é " + pessoa2.idade);
		}
		else {
			System.out.println(pessoa3.nome + " tem a maior idade dos três, a idade dele é " + pessoa3.idade);
		}
	}

}
