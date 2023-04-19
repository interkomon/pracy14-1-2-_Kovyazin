using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace pract14_1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.WriteLine("Выберите задание \t 1 \t 2A \t 2Б");
                string task = Console.ReadLine();

                switch (task)
                {
                    
                    case "1":
                        Stack<int> stack = new Stack<int>();
                        Console.WriteLine("Введите число n");
                        int n = int.Parse(Console.ReadLine());
                        if (n <= 0)
                        {
                            Console.WriteLine("Ошибка. Проверьте ввод. Нельзя чтобы было =>0");
                        }
                        else
                            for (int i = 1; i <= n; i++)
                            {
                                stack.Push(i);
                            }
                        Console.WriteLine($"Размерность стека {stack.Count}");
                        Console.WriteLine($"Верхний элепент стека = {stack.Peek()}");
                        Console.Write($"Содержимое стека = ");
                        while (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Pop() + " ");
                        }
                        Console.WriteLine($"Новая размерность стека {stack.Count}");
                        break;
                    case "2А":

                        Console.WriteLine("Введите математическое выражение:");
                        string expression = Console.ReadLine();
                        Stack<char> stack1 = new Stack<char>();
                        if(expression == " ")
                        {
                            Console.WriteLine("Математическое значение не может быть пустым");
                        }    
                        int balance = 0;
                        StreamWriter sw = new StreamWriter("t.txt");
                        sw.WriteLine(expression);
                        sw.Close();
                        for (int i = 0; i < expression.Length; i++)
                        {
                            if (expression[i] == '(')
                            {
                                stack1.Push(expression[i]);
                            }
                            else if (expression[i] == ')')
                            {
                                if (stack1.Count == 0)
                                {
                                    Console.WriteLine("Неверное раставлены скобки");
                                    return;
                                }
                                else
                                {
                                    stack1.Pop();
                                }
                            }
                        }

                        
                        if (stack1.Count == 0)
                        {
                            Console.WriteLine("Скобки сбалансированы");

                        }
                        else
                            Console.WriteLine("Скобки не сбалансированы");
                        Console.WriteLine($"Нехватает {stack1.Count} ( скобок");

                        break;

                    case "2Б":
                        Stack<char> stack2 = new Stack<char>();
                        Console.WriteLine("Введите математическое выражение: ");
                        string expression2 = Console.ReadLine();
                        if (expression2 == " ")
                        {
                            Console.WriteLine("Математическое значение не может быть пустым");
                        }

                        foreach (char c in expression2)
                        {
                            if (c == '(')
                            {
                                stack2.Push(c);
                            }
                            else if (c == ')')
                            {
                                if (stack2.Count > 0 && stack2.Peek() == '(')
                                {
                                    stack2.Pop();
                                }
                                else
                                {
                                    stack2.Push(c);
                                }
                            }
                        }

                        while (stack2.Count > 0)
                        {
                            if (stack2.Peek() == '(')
                            {
                                expression2 += ')';
                            }
                            else
                            {
                                expression2 = '(' + expression2;
                            }
                            stack2.Pop();
                        }
                        StreamWriter sw2 = new StreamWriter("t1.txt");
                        sw2.WriteLine(expression2);
                        sw2.Close();
                        Console.WriteLine("Новое математическое выражение записано в файл 't1.txt' ");
                        break;

                    default:
                        Console.WriteLine("Можно выбрать только из списка");
                        break;
                        



                }

            }
            catch
            {
                Console.WriteLine("Ошибка.Проверьте ввод");
            }
        }
  
        
    }
   
}

