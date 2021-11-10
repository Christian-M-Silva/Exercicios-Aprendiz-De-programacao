package exercicio;

public class Dados {

	public static void main(String[] args) {
		DadoSigilo informacao = new DadoSigilo();
		informacao.getVerNome();
		informacao.getVerCpf();
		
		System.out.println("O nome no inicio era " + informacao.getVerNome() + " e o cpf era " + informacao.getVerCpf());
		
		informacao.setAlterarCpf("884.2867.000.26");
		informacao.setAlterarNome();
		
		System.out.println();
		System.out.println("O nome agora é " + informacao.getVerNome() + " e o cpf agora é " + informacao.getVerCpf());
		
		
	}

}
