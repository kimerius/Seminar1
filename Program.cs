Console.Write("Введите первое число: ");
 int num1 = int.Parse(Console.ReadLine());

 Console.Write("Введите второе число: ");
 int num2 = int.Parse(Console.ReadLine());
 
 if(num1 * num1 == num2){
  Console.WriteLine($"Чисто {num2} является квадратом числа {num1}");
 }
else if(num1 == num2 *num2){
    Console.WriteLine("Число {0} является квадратом числа {1}", num1, num2); 
}

 else {
    Console.WriteLine("Не является ");
}

Console.WriteLine(Convert.ToInt32(Math.Pow(num1, 2)));