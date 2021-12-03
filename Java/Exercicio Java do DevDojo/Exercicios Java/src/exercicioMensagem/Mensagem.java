package exercicioMensagem;

import java.util.Scanner;

public class Mensagem {
	/*
	 * Criar variaveis para cada nome que está entre <> Eu <nome>, morando no
	 * endereço <endereço>, confirmo que recebi o sálario de <salario>, na data <data>
	 */
	public static void main(String[] args) {
		String nome;
		String endereco;
		float salario;
		String data;
		
		System.out.println("Olá seja bem vindo a tela de cadastro de confirmação de sálario, digite seus dados abaixo:");
		System.out.println("");
		
		Scanner teclado = new Scanner(System.in);
		
		System.out.println("Digite seu nome:");
		nome = teclado.nextLine();
		System.out.println();
		
		System.out.println("Digite seu endereço:");
		endereco= teclado.next();
		System.out.println();
		
		System.out.println("Digite seu salario:");
		salario= teclado.nextFloat();
		System.out.println();
		
		System.out.println("Digite a data do recebmeto do sálario (EX.: 2):");
		data= teclado.next();
		System.out.println();
		
		System.out.println("Eu " + nome + ", morando no endereço " + endereco + ", confirmo que recebi o sálario de " + salario + "$, na data " + data + ".");
		
		teclado.close();
	}

}
