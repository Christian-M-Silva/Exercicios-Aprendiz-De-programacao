package exercicio;

public class MetodoClasParam {



static int idade;



static void conNome(String fname)
{
System.out.println(fname + " Fico");
}

static void conNomeIdade(String fname, int idade)
{
System.out.println(fname + " Fico " + idade);
}

static int retNumero(int val)
{
return val + 10;
}

public static void main(String[] args)
{
//conNome("Claudio");

//conNomeIdade("Claudio", 49);

//System.out.println(retNumero(11));

int resultado = retNumero(11);
System.out.println("O resultado é: " + resultado);

System.out.println("A idade é: " + idade);
}
}
