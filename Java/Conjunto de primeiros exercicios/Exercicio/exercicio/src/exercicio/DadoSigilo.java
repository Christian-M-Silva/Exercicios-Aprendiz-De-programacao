package exercicio;

public class DadoSigilo {
	private String nome = "Tiago";
	private String cpf = "928.856.298.21";
	
	public String getVerNome(){
		return this.nome;
	}
	
	public void setAlterarNome() {
		this.nome = "João";
	}
	
	public String getVerCpf() {
		return this.cpf;
	}
	
	public void setAlterarCpf(String cpfNovo) {
		this.cpf= cpfNovo;
	}
}
