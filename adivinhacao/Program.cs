Random random = new Random();

int numeroAleatorio;

numeroAleatorio = random.Next(1,100);

Console.WriteLine("Adivinhe o número entre 1 e 100");
double opc = Convert.ToDouble(Console.ReadLine());

while(opc != numeroAleatorio){
    if(opc > numeroAleatorio){
        Console.WriteLine("O numero é menor");
    }else if(opc < numeroAleatorio){
        Console.WriteLine("O numero é maior");
    }else{
        continue;
    }

    Console.WriteLine("Ainda não, tente novamente: ");
    opc = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Parabens, você acertou! O numero era " + numeroAleatorio);