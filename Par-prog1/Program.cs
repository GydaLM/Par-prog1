
//Oppgave 1
//Lag et program som kan konvertere valuta, temperatur eller vekt
//Du skal kunne få alternativer for hva du vil konvertere,
//velge hva du vil konvertere til, og så skrive inn en verdi før du får svar i konsollen.


Converter();
void Converter()
{
    Console.WriteLine("Choose one:");
    Console.WriteLine("1. Currency\n2. Temperature\n3. Weight");
    var menyChoice = Console.ReadKey();
    
    Console.Clear();

    if (menyChoice.KeyChar == '1')
    {
        Console.WriteLine(CurrencyConverter());
        
    }
    else if (menyChoice.KeyChar == '2')
    {
        Console.WriteLine(TempConverter());
        
    }
    else if (menyChoice.KeyChar == '3')
    {
        Console.WriteLine(WeightConverter());
    }
    else
    {
        Console.WriteLine("Please choose 1, 2 or 3");
    }
}

double CurrencyConverter()
{
    //Console.WriteLine("1. NOK -> USD\n2. USD -> NOK");
    //var currency = Console.ReadKey();
    Console.WriteLine("Write number");
    var input = Console.ReadLine();
    double inputNumber = double.Parse(input);
    double finalNumber = inputNumber / 10.22;
    double result = Math.Round(finalNumber, 3);
    return result;
}

int TempConverter()
{
    return 12;
}

int WeightConverter()
{
    return 13;
}