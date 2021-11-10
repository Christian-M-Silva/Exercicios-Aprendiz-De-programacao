package exercicios;
import java.util.Scanner;
public class DoarSangue {

	public static void main(String[] args) {
		Scanner teclado = new Scanner(System.in);
		
		System.out.println("Quantos anos você tem?");
		int idade = teclado.nextInt();
		System.out.println();
		
		String a = "Você pode se vacinar";
		String b = "Você não pode se vacinar";
		
		System.out.println((idade > 20) ? a:b);
		
		teclado.close();
	}

}
