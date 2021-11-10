package exercicio;

public class Main {

	@SuppressWarnings("null")
	public static void main(String[] args) {
		String antigaFrase = null;
		String NovaFrase = null;
		
		try {
			NovaFrase = antigaFrase.toUpperCase();
			System.out.println(NovaFrase);
		}
		catch(NullPointerException e) {
			System.out.println("As frases estão com valores nulos, para resolver isso \nAntigaFrase vai receber 'Novos dados'");
			antigaFrase = "Novos dados";
		}
		finally {
			NovaFrase= antigaFrase.toUpperCase();
			System.out.println();
			System.out.println(NovaFrase);
		}
		
	}

}
