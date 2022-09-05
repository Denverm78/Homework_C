/*  Пользователь вводит скобочные последовательности. В последовательности могут встретиться скобки вида: {}, (), [].
Правильная скобочная последовательность - символьная последовательность, составленная в алфавите, 
состоящем из символов, сгруппированных в упорядоченные пары.
Пример правильной скобочной последовательности: (), ()[]{}
Пример неправильной: (], ({)}
Написать программу, которая определяет правильная ли скобочная последовательность была введена */

bool CheckSequens(String sequens)
{
    if (sequens.Length % 2 == 1) return false; //Если нечетное число скобок - сразу "Неправильно"
    else
    {
        Stack<char> mystack = new Stack<char>();
        for (int i = 0; i <= sequens.Length - 1; i++)
        {
            if (sequens[i] == '{' || sequens[i] == '[' || sequens[i] == '(')
            {
                mystack.Push(sequens[i]);
            }
            else if (sequens[i] == '}' || sequens[i] == ']' || sequens[i] == ')')
            {
                if (mystack.Count == 0) return false; //Если стек пустой, а скобка закрывающаяся - "Неправильно"
                if (CompareChar(mystack.Pop(), sequens[i]) == false) return false; //Сравниваем закрывающуюся скобку с верхней в стеке
            }
        }
        return true;
    }
}

bool CompareChar(char a, char b)
{
    if (a == '(' && b == ')' || a == '[' && b == ']' || a == '{' && b == '}') return true;
    else return false;
}

Console.WriteLine("Введите последовательность скобок: ");
string seq = Console.ReadLine();
if (CheckSequens(seq) == true) Console.WriteLine("Последовательность правильная");
else Console.WriteLine("Последовательность неправильная");
