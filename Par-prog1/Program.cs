
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
    Console.WriteLine("1. NOK -> USD\n2. USD -> NOK");
    var menuChoice = Console.ReadKey();
    Console.Clear();

    Console.WriteLine("Write number");
    if (menuChoice.KeyChar == '1')
    {
        var input = Console.ReadLine();
        double inputNumber = double.Parse(input);
        double result = inputNumber / 10.22;
        double finalNumber = Math.Round(result, 3);
        Console.WriteLine("NOK -> USD");
        return finalNumber;
    }
    else
    {
        return 0;
    }
}

double TempConverter()
{
    Console.WriteLine("1. C -> F\n2. F -> C");
    var menuChoice = Console.ReadKey();
    Console.Clear();

    Console.WriteLine("Write Temperature");
    if (menuChoice.KeyChar == '1')
    {
        var input = Console.ReadLine();
        double inputNumber = double.Parse(input);
        double result = (inputNumber * 1.8) + 32;
        double finalNumber = Math.Round(result, 1);
        Console.WriteLine("C -> F");
        return finalNumber;
    }
    else
    {
        return 0;
    }
}

double WeightConverter()
{
    Console.WriteLine("1. KG -> LBS\n2. LBS -> KG");
    var menuChoice = Console.ReadKey();
    Console.Clear();

    Console.WriteLine("Write Weight");
    if (menuChoice.KeyChar == '1')
    {
        var input = Console.ReadLine();
        double inputNumber = double.Parse(input);
        double result = inputNumber * 2.204;
        double finalNumber = Math.Round(result, 2);
        Console.WriteLine("KG -> LBS");
        return finalNumber;
    }
    else
    {
        return 0;
    }
}