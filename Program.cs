double num1, num2;

Console.Write("Ingrese el primer numero: ");
num1=double.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo numero: ");
num2 = double.Parse(Console.ReadLine());

if (num1 == num2)
{
    Console.WriteLine("Ambos numeros son iguales ");
}
else if (num1 > num2)
{
    Console.WriteLine($"{num1} es mayor a {num2}");
}
else 
{
    Console.WriteLine($"{num2} es mayor a {num1}");
}