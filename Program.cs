// QUESTÃO 1
// Explique o que é herança em orientação a objetos e como ela é implementadaem C#.
// Dê um exemplo prático de como a herança pode ser utilizada em um sistema de gerenciamento de funcionários. 


//   RESPOSTA:
// A herança é basicamente como o próprio nome já diz, possibilita criar outras classes apartir das que já existem, as classes "filhas" ou subclasse herdam elementos/atributos e métodos da classe "mãe"/superclasse, evitando assim duplicação de código. Como podemos ver no exemplo prático, a herança funciona assim, temos a superclasse chamada de "Pessoa" e nela temos todos os atributos que teriamos nas outras classe, como por exemplo, nome, salario, idade e cargo, com a implementação do símbolo : no inicio da class ("class Atendente : Funcionario" e "class Gerente : Funcionario") as subclasse tem acesso a esse atributos que estão na superclasse.

// Console.WriteLine("Gerente");

// Gerente gerente = new Gerente();
// Pessoa pessoa2 = new Pessoa();

// pessoa2.Nome = "Jorge";
// pessoa2.Idade = 35;
// pessoa2.Valor = 6500;
// pessoa2.Cargo = "Gerente";

// pessoa2.Informacao(pessoa2.Nome, pessoa2.Idade, pessoa2.Valor, pessoa2.Cargo);

// gerente.AtualizarPagode(pessoa2);

// Console.WriteLine("Salário com a Comissão: " + gerente.Salario);

// Console.WriteLine();
// Console.WriteLine();

// Console.WriteLine("Atendente");

// Atendente atendente = new Atendente();
// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Sabrina";
// pessoa1.Idade = 20;
// pessoa1.Valor = 2000;
// pessoa1.Cargo = "Atendente";

// pessoa1.Informacao(pessoa1.Nome, pessoa1.Idade, pessoa1.Valor, pessoa1.Cargo);

// atendente.AtualizarPagode(pessoa1);

// Console.WriteLine("Salário com a Comissão: " + atendente.Salario);

//*************************************************************************************************************************
//*************************************************************************************************************************
//*************************************************************************************************************************


// QUESTÃO 2
// O que são interfaces em orientação a objetos e qual é a sua importância naconstrução de sistemas em C#? Dê um exemplo de como uma interface podeser utilizada para garantir a interoperabilidade entre diferentes classes em um sistema de pagamento online.


//   RESPOSTA:
// A interface é um conjunto de métodos sem apresentar lógica apenas as assinaturas dos métodos e, seu uso é de extrema importâcia, pois possibilita o polimorfismo, onde as classes são tratadas iguas, e possibilita a sua reutilização em outras classe diferentes. E sua implementação é feita atravéz do símbolo : no inicio da class igual a da herança.


// Inter inter = new Inter();
// Transacao transacao1 = new Transacao();
// inter.Saldo = 50;
// Console.WriteLine("Saldo Antes: " + inter.Saldo);

// transacao1.Valor = 10;
// transacao1.Tipo = "Pagar";
// transacao1.NumConta = 1234;
// transacao1.NomeConta = "Sabrina";

// inter.NovoSaldo(transacao1);

// transacao1.Exibir(transacao1.Tipo, transacao1.Valor, transacao1.NumConta, transacao1.NomeConta);

// Console.WriteLine("Saldo em conta: " + inter.Saldo);

//*************************************************************************************************************************
//*************************************************************************************************************************
//*************************************************************************************************************************


// QUESTÃO 3
// Diferencie sobrecarga e sobreposição (ou sobrescrita) e forneça exemplos decada um em C#.

//   RESPOSTA:
//  sobrecarga é quando aplicamos varios métodos com o mesmo nome, porem com parâmetros diferentes. Já a sobrescrever é usado com o mesmo conceito da herança, onde as classes subclasses sobrescreve o método da classe superclasse, com os mesmos parâmetros. em geral, a sobrecarga é onde temos vários métodos com o mesmo nome em uma classe, mas todos com assinaturas diferentes, enquanto na sobreposição é apenas substituir a implementação de um método em uma classe derivada por uma implementação específica dessa classe derivada.

// Exemplo de sobrescrever  
// Caminhonete caminhonete = new Caminhonete();
// caminhonete.Som();

// Carro carro = new Carro();
// carro.Som();


// Exemplo de sobrecarga
// Calcular calcular = new Calcular();

// Console.WriteLine(calcular.Multi(2 , 5));
// Console.WriteLine(calcular.Multi(2 , 5 , 10));
// Console.WriteLine(calcular.Multi(2.5 , 2.5));

//*************************************************************************************************************************
//*************************************************************************************************************************
//*************************************************************************************************************************


// QUESTÃO 4
// Crie uma classe Produto que represente um produto em uma loja online. A classe deve ter os seguintes atributos: Nome, Preco, QuantidadeEmEstoque. Implemente métodos para adicionar e remover unidades do estoque, e um método para calcular o valor total do produto em estoque. Os métodos devem alterar o estado do objeto instanciado

//   RESPOSTA:

// Produto feijao = new Produto("Feijão", 10, 10);
// Console.WriteLine("Produto: " + feijao.Nome);
// Console.WriteLine("Preço do produto: R$" + feijao.Preco);
// feijao.Adicionar(10);

// Console.WriteLine("Valor total em estoque: R$" + feijao.TotalEmEstoque());

// Console.WriteLine();

// feijao.Remover(5);
// Console.WriteLine("Valor do estoque atualizado: " + feijao.QuantidadeEmEstoque + " unidades");

// Console.WriteLine();

// Console.WriteLine("Valor total em estoque: R$" + feijao.TotalEmEstoque());

// Console.WriteLine();
// Console.WriteLine("*******************************************");
// Console.WriteLine();

// Produto arroz = new Produto("Arroz", 2, 10);
// Console.WriteLine("Produto: " + arroz.Nome);
// Console.WriteLine("Preco do produto: R$" + arroz.Preco);
// arroz.Adicionar(10);

// Console.WriteLine("Valor total em estoque: R$" + arroz.TotalEmEstoque());

// Console.WriteLine();

// arroz.Remover(2);

// Console.WriteLine("Valor do estoque atualizado: " + arroz.QuantidadeEmEstoque + " unidades");

// Console.WriteLine();

// Console.WriteLine("Valor total em estoque: R$" + arroz.TotalEmEstoque());


//*************************************************************************************************************************
//*************************************************************************************************************************
//*************************************************************************************************************************


// QUESTÃO 5
// Implemente um sistema para uma locadora de filmes. Crie uma classe Filme com os seguintes atributos: Titulo, Genero, Duracao, Disponivel (indicando se o filme está disponível para locação). Implemente métodos para registrar a locação de um filme, registrar a devolução de um filme e verificar se um filmeestá disponível para locação. Não há necessidade de implementar rotinas de bancos de dados

//   RESPOSTA:

// Filme filme1 = new Filme("O Poderoso Chefão", "Drama", 175);
// Console.WriteLine("Nome do filme: " + filme1.Titulo);
// Console.WriteLine("Gênero do filme: " + filme1.Genero);
// Console.WriteLine("Duração do filme: " + filme1.Duracao + " Minutos");
// filme1.Estado();

// filme1.Locacao();
// filme1.Estado();

// Console.WriteLine();

// Console.WriteLine("Nome do Filme: " + filme1.Titulo);
// filme1.Devolucao();

// filme1.Estado();


//*************************************************************************************************************************
//*************************************************************************************************************************
//*************************************************************************************************************************

// QUESTÃO 6
// Implemente uma hierarquia de classes para representar diferentes tipos de veículos, como carros, motos e bicicletas. Cada classe deve herdar da classebase Veiculo. Adicione atributos específicos para cada tipo de veículo, como número de portas para carros, cilindrada para motos e número de marchas para bicicletas.

//   RESPOSTA:

// Veiculo veiculo = new Veiculo();
// Carro1 carro = new Carro1();
// Moto1 moto = new Moto1();
// Bicicleta bicicleta = new Bicicleta();

// carro.QuantPorta = 4;
// moto.Cilidrada = 160;
// bicicleta.QuantMarcha = 7;

// Console.WriteLine("Carro tem: " + carro.QuantPorta + " Porta(s)");
// Console.WriteLine("A moto tem: " + moto.Cilidrada + " Cilidradas");
// Console.WriteLine("a Bicicleta tem: " + carro.QuantPorta + " Marchas");

//*************************************************************************************************************************
//*************************************************************************************************************************
//*************************************************************************************************************************

// QUESTÃO 7
// Desenvolva um sistema de gerenciamento de contas bancárias com diferentes tipos de contas, como conta corrente, conta poupança e conta empresarial. Utilize herança para representar a relação entre as classes de contas e implemente métodos específicos para cada tipo de conta, como calcular juros para contas poupança e verificar saldo mínimo para contas empresariais.

//   RESPOSTA:

// Contas conta = new Contas();
// ContaCorrente contaCorrente = new ContaCorrente();
// ContaPoupança contaPoupança = new ContaPoupança();
// ContaEmpresarial contaEmpresarial1 = new ContaEmpresarial();
// ContaEmpresarial contaEmpresarial2 = new ContaEmpresarial();

// contaPoupança.NumConta = 1534;
// contaPoupança.Saldo = 1500;

// Console.WriteLine("Conta Poupança");
// Console.WriteLine("Número da conta: " + contaPoupança.NumConta);
// Console.WriteLine("Saldo da conta: " + contaPoupança.Saldo);

// contaPoupança.CalcJuros();

// Console.WriteLine();
// Console.WriteLine("****************************************");
// Console.WriteLine();

// contaEmpresarial1.NumConta = 2305;
// contaEmpresarial1.Saldo = 15000;

// Console.WriteLine("Conta Empresarial 1");
// Console.WriteLine("Número da conta: " + contaEmpresarial1.NumConta);
// Console.WriteLine("Saldo Mínimo: " + contaEmpresarial2.saldoMin);
// Console.WriteLine("Saldo da conta: " + contaEmpresarial1.Saldo);

// contaEmpresarial1.VerificarSaldo();

// Console.WriteLine();
// Console.WriteLine("****************************************");
// Console.WriteLine();

// contaEmpresarial2.NumConta = 1010;
// contaEmpresarial2.Saldo = 1000;

// Console.WriteLine("Conta Empresarial 2");
// Console.WriteLine("Número da conta: " + contaEmpresarial2.NumConta);
// Console.WriteLine("Saldo Mínimo: " + contaEmpresarial2.saldoMin);
// Console.WriteLine("Saldo da conta: " + contaEmpresarial2.Saldo);

// contaEmpresarial2.VerificarSaldo();

// Console.WriteLine();
// Console.WriteLine("****************************************");
// Console.WriteLine();

// contaCorrente.NumConta = 1234;
// contaCorrente.Saldo = 1500;

// Console.WriteLine("Conta Corrente");
// Console.WriteLine("Número da conta: " + contaPoupança.NumConta);
// Console.WriteLine("Saldo da conta: " + contaPoupança.Saldo);

//*************************************************************************************************************************
//*************************************************************************************************************************
//*************************************************************************************************************************

// QUESTÃO 8
// Crie uma aplicação para uma escola de idiomas que oferece diferentes tipos de cursos, como inglês, espanhol e francês. Utilize herança para representar a relação entre as classes de cursos e implemente métodos específicos para cada tipo de curso, como calcular a média de notas para cursos avançados e gerar certificados para cursos concluídos.

//   RESPOSTA:
// Curso curso1 = new Curso ();
// Frances frances = new Frances();

// curso1.Nome = "Jorge";
// curso1.Nota1 = 10;
// curso1.Nota2 = 10;
// curso1.Nota3 = 10;

// Console.WriteLine("Nome: " + curso1.Nome);
// Console.WriteLine("Nota 1: " + curso1.Nota1);
// Console.WriteLine("Nota 2: " + curso1.Nota2);
// Console.WriteLine("Nota 3: " + curso1.Nota3);

// curso1.Media(curso1.Nota1, curso1.Nota2, curso1.Nota3);
// frances.Certificado(curso1.Nome);

// Console.WriteLine();
// Console.WriteLine("**********************");
// Console.WriteLine();

// Curso curso2 = new Curso ();
// Ingles ingles = new Ingles();

// curso2.Nome = "Ana";
// curso2.Nota1 = 10;
// curso2.Nota2 = 10;
// curso2.Nota3 = 10;

// Console.WriteLine("Nome: " + curso2.Nome);
// Console.WriteLine("Nota 1: " + curso2.Nota1);
// Console.WriteLine("Nota 2: " + curso2.Nota2);
// Console.WriteLine("Nota 3: " + curso2.Nota3);
// curso2.Media(curso2.Nota1, curso2.Nota2, curso2.Nota3);
// ingles.Certificado(curso2.Nome);

// Console.WriteLine();
// Console.WriteLine("*****************************");
// Console.WriteLine();

// Curso curso3 = new Curso ();
// Espanhol espanhol = new Espanhol();

// curso3.Nome = "Fred";
// curso3.Nota1 = 10;
// curso3.Nota2 = 10;
// curso3.Nota3 = 10;

// Console.WriteLine("Nome: " + curso3.Nome);
// Console.WriteLine("Nota 1: " + curso3.Nota1);
// Console.WriteLine("Nota 2: " + curso3.Nota2);
// Console.WriteLine("Nota 3: " + curso3.Nota3);

// curso3.Media(curso3.Nota1, curso3.Nota2, curso3.Nota3);
// espanhol.Certificado(curso3.Nome);

//*************************************************************************************************************************
//*************************************************************************************************************************
//*************************************************************************************************************************

// QUESTÃO 9
// Desenvolva um sistema de processamento de pagamentos com diferentes métodos de pagamento, como cartão de crédito, boleto bancário e transferência bancária. Crie uma interface IMetodoPagamento com métodos para realizar o pagamento e verificar o status do pagamento. Implemente classes para cada método de pagamento que herdem dessa interface e forneça a lógica específica para cada método de pagamento.

//   RESPOSTA:
Console.WriteLine("**Cartão de Crédito**");
IMetodoPagamento pagamento1 = new CartaoCredito("123456", "12/25", "123"); 
pagamento1.Realizar(789.80);
Console.WriteLine(pagamento1.Verificar());

Console.WriteLine();
Console.WriteLine("*************************************");
Console.WriteLine();

Console.WriteLine("**Boleto**");
IMetodoPagamento pagamento2 = new Boleto("7144390");
pagamento2.Realizar(1200);
Console.WriteLine(pagamento2.Verificar());

Console.WriteLine();
Console.WriteLine("************************************");
Console.WriteLine();

Console.WriteLine("**Transferencia Bancária**");
IMetodoPagamento pagamento3 = new TransferenciaBancaria("Banco: Santander", "1502");
pagamento3.Realizar(500);
Console.WriteLine(pagamento3.Verificar());


//*************************************************************************************************************************
//*************************************************************************************************************************
//*************************************************************************************************************************

// QUESTÃO 10
// 

//   RESPOSTA: