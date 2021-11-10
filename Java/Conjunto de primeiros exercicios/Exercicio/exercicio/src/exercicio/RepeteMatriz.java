package exercicio;
/*Fazer um programa para preencher uma matriz de duas linhas e 3 colunas. 
O usuário deverá digitar um número e será preciso verificar se aquele número existe em alguma posição da matriz.*/
import java.util.Scanner;

public class RepeteMatriz {

	public static void main(String[] args) {
		Scanner teclado = new Scanner(System.in);
		
			int l, c, num;
			int[][] n = new int[2][3]; 
			
			for(l=0; l<2; l++) {
				for(c=0; c<3; c++) {
					System.out.println("Digite um valor inteiro");
					n[l][c]= teclado.nextInt();
					System.out.println();
				}
			}
			
			System.out.println("Digite um número para ver se existe na matriz");
			num= teclado.nextInt();
			System.out.println();
			
			for(l=0; l<2; l++) {
				for(c=0; c<3; c++) {
					if(num==n[l][c]) {
						System.out.println("Esse número existe na linha " + l + " e coluna " + c + " da matriz");
					}
				}
			}
		
		teclado.close();

	}

}
