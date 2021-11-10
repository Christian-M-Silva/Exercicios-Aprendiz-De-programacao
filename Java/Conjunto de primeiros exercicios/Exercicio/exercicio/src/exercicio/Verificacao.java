package exercicio;

public class Verificacao {

	public static void main(String[] args) {
		CriterioRiqueza pessoa1 = new CriterioRiqueza();
		pessoa1.cpf = "187.876.987.26";
		pessoa1.nome= "João";
		pessoa1.valor= 2000000000;
		pessoa1.verificar();
		pessoa1.ganhar();
	}

}
