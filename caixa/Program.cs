bool caixaAberto = true;
double saldoConta = 0;

while(caixaAberto){
    Console.WriteLine("Caixa Eletrônico");
    Console.WriteLine("1 - Consultar Saldo");
    Console.WriteLine("2 - Sacar");
    Console.WriteLine("3 - Depositar");
    Console.WriteLine("4 - Sair");
    string opc = Console.ReadLine();

    switch(opc){
        case "1":
            Console.WriteLine("Saldo em contado: R$ " + saldoConta);
            break;
        
        case "2":
            Console.Write("Digite o valor que deseja sacar:");
            double valorSacar = Convert.ToDouble(Console.ReadLine());
            
            if(valorSacar <= saldoConta){
                saldoConta -= valorSacar;
            }else{
                Console.WriteLine("Saldo insuficiente na conta!");
            }
            break;

        case "3":
            Console.WriteLine("Digite o valor que deseja depositar");
            double valorDeposito = Convert.ToDouble(Console.ReadLine());
            if(valorDeposito >= 0){
                saldoConta += valorDeposito;
            }else{
                Console.WriteLine("Valor invalido");
            }
            break;

        case "4":
            Console.WriteLine("Encerrando o sistema!");
            caixaAberto = false;
            break;

    }
}