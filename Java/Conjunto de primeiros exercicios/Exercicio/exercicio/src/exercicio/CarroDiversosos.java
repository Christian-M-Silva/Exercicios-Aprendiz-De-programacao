package exercicio;

import java.util.Scanner;

public class CarroDiversosos {

	public static void main(String[] args) {
		
		Scanner teclado = new Scanner(System.in);
		Carro carro1 = new Carro();
		carro1.chassi = teclado.next();
		carro1.modelo = "Ford";
		carro1.qtdPortas = 2;
		carro1.acelerar();
		
		
		Carro carro2 = new Carro();
		carro2.chassi = "8437274878472ey";
		carro2.modelo = "Gol";
		carro2.qtdPortas = 4;
		carro2.acelerar();
		
		System.out.println(carro1.chassi);
		/*
		Carro carro3 = new Carro();
		carro3.chassi = "74874282478hs";
		carro3.modelo = "Fusca";
		carro3.qtdPortas = 6;
		carro3.acelerar();*/
		teclado.close();
	}

}
