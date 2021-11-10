package agencia;

public class AgenciaViagem {

	@SuppressWarnings("unused")
	public static void main(String[] args) {
		String cadastro;
		
		Cliente NovoCliente = new Cliente();
		
		NovoCliente.cpf = "000.000.00-00";
		NovoCliente.idade = "20";
		NovoCliente.localDestino = "Paris";
		NovoCliente.nome= "Christian Morais Silva";
		
		NovoCliente.cadastrar();
		NovoCliente.pagar();

	}

}
