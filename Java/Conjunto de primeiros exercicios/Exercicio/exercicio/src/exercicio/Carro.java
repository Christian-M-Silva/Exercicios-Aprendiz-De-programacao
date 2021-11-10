package exercicio;

public class Carro {
	String chassi; 
	String modelo;
	int qtdPortas;
	
	public void acelerar() {
		if(qtdPortas == 2) 
			System.out.println("O carro não pode ultrapassar 60Km!");
			
		else if(qtdPortas == 4) 
			System.out.println("O carro não pode ultrapassar 110 km!");
			
		else 
			System.out.println("O carro não ultrapassa 140 km!");
		
		System.out.println();
		System.out.println("A quantidade de portas é " + modelo);
		System.out.println();
		System.out.println("O chassi é " + chassi);
			
	}
	public void frear() {
		
	}
}
