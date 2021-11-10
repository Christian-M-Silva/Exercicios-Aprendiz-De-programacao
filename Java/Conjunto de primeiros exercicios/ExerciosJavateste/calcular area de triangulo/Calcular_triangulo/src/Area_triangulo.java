import java.util.Scanner;
public class Area_triangulo {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

			Scanner triangulo = new Scanner(System.in);
			int base;
			int altura;
			int area;
			
			System.out.println("Escreva o valor da base");
			base = triangulo.nextInt();
			System.out.println("");
			
			System.out.println("Escreva o valor da altura");
			altura = triangulo.nextInt();
			
			area = base * altura;
			
			System.out.println("A area do triangulo é " + area);
			
			triangulo.close();
	}

}
