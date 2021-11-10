package verificarMedia;

import java.util.Scanner;

public class VerificarMedia {

	public static void main(String[] args) {
		/*
		 * Desenvolva um código em Java que comece com a declaração de duas variáveis do
		 * tipo double, “acumulador” e “media”. Em “acumulador” deverá ser atribuída a
		 * soma de três notas que serão digitadas pelo usuário, usando uma instância da
		 * classe Scanner. O código deverá gerar a média das notas e depois, usando a
		 * condicional if, o programa precisa verificar em que faixa o aluno ficou e
		 * imprimir no console a mensagem de acordo com a tabela abaixo: “media” acima
		 * de 6 – “APROVADO DIRETO”; “media” entre 5 e 6, incluindo 5 e 6 - “APROVADO
		 * COM RECUPERAÇÃO”; “media” abaixo de 5 – “REPROVADO”;
		 */
		
		Scanner teclado= new Scanner(System.in);
		
		double acumulador = 0;
		double media;
		double nota;
		
		for(int i = 1; i<4; i++) {
			System.out.println("Digite a nota do bimestre " + i);
			nota= teclado.nextDouble();
			acumulador= acumulador + nota;
			System.out.println();
		}
		
		media= acumulador/3;
		
		if(media > 6) {
			System.out.println("APROVADO DIRETO");
		}
		else if(media>=5 && media<=6) {
			System.out.println("APROVADO COM RECUPERAÇÃO");
		}
		else {
			System.out.println("REPROVADO");
		}
		
		teclado.close();
		
	}

}
