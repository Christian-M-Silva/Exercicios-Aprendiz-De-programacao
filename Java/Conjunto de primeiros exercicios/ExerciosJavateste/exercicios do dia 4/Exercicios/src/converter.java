import java.util.Scanner;
public class converter {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Scanner conversao = new Scanner (System.in);
		float celcius;
		float converter;
		
		System.out.println("Digite o valor em Celsius");
		celcius = conversao.nextFloat();
		System.out.println("");
		
		converter = (9 * celcius + 160)/5;
		
		System.out.println("A conversão em Fahrenheit é " + converter);
		
		conversao.close();
	}

}
