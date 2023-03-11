static void saludar(string nomsal)
{
    Console.WriteLine($"Un gran saludo a {nomsal}");
}

static int Calculo_año_nacimiento(int edad)
{
    int año = 2023 - edad;
    return año;
}
//string nombre;
//int edad;

static void marque(String palabra)
{
    int longitud = palabra.Length;
    for (int c = longitud-; c> 0; c--)
    {
        Console.SetCursorPosition(5, 10);
        Console.WriteLine(palabra[c]);
        Thread.Sleep(100);
    }
    //Console.WriteLine(palabra[2]);
}
String palabra;
    palabra ="maria";
marque(palabra);
bool esPalindromo = palindromo("anA".Tollpper());

if (esPalindromo)
{
    Console.WriteLine("Es palindromo;")
}
else 
{
    Console.WriteLine("Nel");
}
    //Console.Write("Como te llamas");
    //nombre = Console.ReadLine();

//Console.WriteLine($"Hola, gusto de slaudarte {nombre}");
//Console.WriteLine("Cuantos años tienes");
//edad = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine($"Bonita edad: {edad} naciste en {Calculo_año_nacimiento(edad)}");

    //static bool palindromo (string palabra)
//{
    //int longitud = palabra.Length;

    //string pal = "";
    //for (int c = longitud - 1; c >= 0; c--)
    //{
        //pal = pal + palabra{ [c].ToString().Tollpper();
        //}
        //if (palabra.Equals[pal])
       // {
         //   return true;
        //}
       // return false;
    //}