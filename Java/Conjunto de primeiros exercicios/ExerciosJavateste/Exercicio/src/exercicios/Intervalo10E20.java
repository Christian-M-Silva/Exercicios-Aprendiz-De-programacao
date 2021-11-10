package exercicios;
import java.util.Scanner;
public class Intervalo10E20 {

	public static void main(String[] args) {
		
		Scanner teclado = new Scanner(System.in);
		
			int n; //Declaração de variavel 
			
			System.out.println("Digite um número");
			n =teclado.nextInt(); //Mensagem de printar na tela e de entrada de dados
			
			if(n>10 && n<20) {
				System.out.println("O número " + n + " está entre 10 e 20");//Se n for maior que 10 e menor que ai executa essa linha
			}
			else {
				System.out.println("O número " + n + " não está entre 10 e 20");// Do contrario essa linha é executada
			}
		
		teclado.close();
	}

}
