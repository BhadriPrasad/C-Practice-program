using System;
class Program
{
  static void Main(string[] args)
  {
     char op,a;
     double num1,num2;
    while(true)
    {
           Console.WriteLine("Enter number 1:");
      num1=Convert.ToDouble(Console.ReadLine());
     Console.WriteLine("Enter number 2:");
     num2=Convert.ToDouble(Console.ReadLine());
     Console.WriteLine("Enter Symbol ( + - * / ):");
     op=Console.ReadLine()[0];
      switch(op)
     {
       case '+':
       Console.WriteLine("The answer is {0}",num1+num2);
       break;

       case '-':
       Console.WriteLine("The answer is {0}",num1-num2);
       break;

       case '*':
       Console.WriteLine("The answer is {0}",num1*num2);
       break;

       case '/':
       Console.WriteLine("The answer is {0}",num1/num2);
       break;
       default:
       Console.WriteLine("invalid");
       break;

     }
     Console.WriteLine("Do You want To Continue?(Y/N) ");
     a=Convert.ToChar(Console.ReadLine());
     if (a!='Y')
     break;
     
     
    




      

  }
}
}
