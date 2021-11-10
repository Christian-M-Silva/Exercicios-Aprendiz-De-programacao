import java.util.Scanner;
public class reajuste {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Scanner reajuste = new Scanner(System.in);
		int salario;
		float salarioFinal;
		
		System.out.println("Digite o seu sálario");
		salario = reajuste.nextInt();
	
		salarioFinal = salario * 1.01f;
		System.out.println("");
		
		System.out.println("O valor reajustado é " + salarioFinal);
		
		reajuste.close();
	}

}
