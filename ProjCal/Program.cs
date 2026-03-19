int Soma(int n1, int n2)
{
    return n1 + n2;
}

int Sub(int n1, int n2){
    return n1 - n2;
}

double Raiz(double n3){
    double raiz = Math.Sqrt(n3);
    return raiz;
}

Console.WriteLine("Digite um numero: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite um numero: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite um numero: ");
double n3 = double.Parse(Console.ReadLine());


Console.WriteLine($"Soma: {Soma(n1, n2)}\nSubtração: {Sub(n1, n2)}\nRaiz Quadrada: {Raiz(n3)}");
Console.WriteLine("Isso é bugfix");
