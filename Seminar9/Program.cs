// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
/*void PrintNumbers(int n){
    if(n > 1) PrintNumbers(n-1);
    Console.Write(n + " ");
}
PrintNumbers(5);*/
// Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр.
/*int SumOfDigits(int num){
    if(num != 0) return SumOfDigits(num/10) + num%10;
    else return 0;
}
Console.WriteLine($"Sum of digits is {SumOfDigits(1232)}");
*/
// Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N.
/*void ShowNumbers(int m, int n){
    Console.Write(m + " ");
    if(m < n) ShowNumbers(m+1, n);
    if(m > n) ShowNumbers(m-1, n);
}

ShowNumbers(22, 2);*/
// Напишите программу, которая на вход принимает два 
// числа A и B, и возводит число А в целую степень B.
double FindDegree(double a, int b){
    if(b > 0) return a*FindDegree(a, b - 1);
    if(b < 0) return 1/a*FindDegree(a, b + 1);
    else return 1;

}
Console.WriteLine(FindDegree(2, 4));
Console.WriteLine(FindDegree(2, -4));