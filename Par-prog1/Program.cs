
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
        CurrencyConverter();
    }
    else if (menyChoice.KeyChar == '2')
    {
        TempConverter();
    }
    else if (menyChoice.KeyChar == '3')
    {
        WeightConverter();
    }
    else
    {
        Console.WriteLine("Please choose 1, 2 or 3");
    }
}

int CurrencyConverter()
{
    return 11;
}

int TempConverter()
{
    return 12;
}

int WeightConverter()
{
    return 13;
}