bool calcAberta = true;

while(calcAberta){

    Console.WriteLine("Calculadora");
    Console.WriteLine("1 - adição");
    Console.WriteLine("2 - subtração");
    Console.WriteLine("3 - multiplicação");
    Console.WriteLine("4 - divisão");
    Console.WriteLine("5 - Sair");
    string opc = Console.ReadLine();

    switch(opc){
        case "1":
            Console.WriteLine("Digite o primeiro número: ");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Resultado: " + (primeiroNumero + segundoNumero));
            break;

        case "2":
            Console.WriteLine("Digite o primeiro número: ");
            primeiroNumero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            segundoNumero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Resultado: " + (primeiroNumero - segundoNumero));
            break;

        case "3":
            Console.WriteLine("Digite o primeiro número: ");
            primeiroNumero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            segundoNumero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Resultado: " + (primeiroNumero * segundoNumero));
            break;

        case "4":
            Console.WriteLine("Digite o primeiro número: ");
            primeiroNumero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            segundoNumero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Resultado: " + (primeiroNumero / segundoNumero));
            break;

        case "5":
            Console.WriteLine("Encerrando o sistema!");
            calcAberta = false;
            break;
    }

}
