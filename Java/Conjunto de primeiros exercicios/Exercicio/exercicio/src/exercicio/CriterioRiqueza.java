package exercicio;

public class CriterioRiqueza {
	String nome = "Tiago";
	String cpf;
	int valor;
	
	public void verificar() {


		if (valor > 10000) {
			System.out.println("Burguês safado");
		}
		else {
			System.out.println("To na mesma situação jovem");
		}
	}
	
	public void ganhar() {

		if(valor < 10000) {
			this.valor += 1000;
			System.out.println();
			System.out.println("Só porque me indentifico toma aqui uns 1000 'do banco imobiliario'");
			System.out.println(valor);
		}
		else {
			System.out.println();
			System.out.println("Devia dar um de robin hood pra cima de tu rapa");
		}
	}
	
}
