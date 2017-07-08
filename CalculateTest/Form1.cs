using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateTest
{
    public partial class Form1 : Form
    {
        //Данный калькулятор реализован с помощью алгоритма обратной польской записи. Ввод устроен так, чтобы пользователь не смог записать неправильное выражение.
        //Для этого в обрабочтиках событий прописаны проверки, затрагивающие большее число всевозможных типов ошибок, которые могут возникнуть при составления выражения. 
        public Form1()
        {
            InitializeComponent();
        }

        static bool prevOperation = false, comma = false;//предикаты для учитывания был ли предыдущий символ операция/запятая
        static List<bool> leftBrace = new List<bool>();//список булевских значений для контроля парных скобок 

        private void button0_Click(object sender, EventArgs e)//ввод кнопки "0". Для кнопок ввода цифр аналогично
        {
            try
            {
                if (richTextBox1Output.Text == "0")//Если значение равняется нулю 
                {
                    richTextBox1Output.Text = "0";//Тогда оно заменится на значение нажатой кнопки, таким образом это будет являться началом нашего выражения  
                }
                else
                {
                    richTextBox1Output.Text += "0";//если нет, то значения последующих нажатых кнопок будут приписываться к существующему выражению, то есть запись выражения продолжается 
                }
                prevOperation = false;//если введено число, то предикат принимает ложное значение
            }
            catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка! Очистите поле ввода и повторите попытку!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1Output.Text == "0")
                {
                    richTextBox1Output.Text = "1";
                }
                else
                {
                    richTextBox1Output.Text += "1";
                }
                prevOperation = false;
            }
            catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка! Очистите поле ввода и повторите попытку!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1Output.Text == "0")
                {
                    richTextBox1Output.Text = "2";
                }
                else
                {
                    richTextBox1Output.Text += "2";
                }
                prevOperation = false;
            }
            catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка! Очистите поле ввода и повторите попытку!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1Output.Text == "0")
                {
                    richTextBox1Output.Text = "3";
                }
                else
                {
                    richTextBox1Output.Text += "3";
                }
                prevOperation = false;
            }
            catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка! Очистите поле ввода и повторите попытку!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1Output.Text == "0")
                {
                    richTextBox1Output.Text = "4";
                }
                else
                {
                    richTextBox1Output.Text += "4";
                }
                prevOperation = false;
            }
            catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка! Очистите поле ввода и повторите попытку!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1Output.Text == "0")
                {
                    richTextBox1Output.Text = "5";
                }
                else
                {
                    richTextBox1Output.Text += "5";
                }
                prevOperation = false;
            }
            catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка! Очистите поле ввода и повторите попытку!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1Output.Text == "0")
                {
                    richTextBox1Output.Text = "6";
                }
                else
                {
                    richTextBox1Output.Text += "6";
                }
                prevOperation = false;
            }
            catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка! Очистите поле ввода и повторите попытку!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1Output.Text == "0")
                {
                    richTextBox1Output.Text = "7";
                }
                else
                {
                    richTextBox1Output.Text += "7";
                }
                prevOperation = false;
            }
            catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка! Очистите поле ввода и повторите попытку!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1Output.Text == "0")
                {
                    richTextBox1Output.Text = "8";
                }
                else
                {
                    richTextBox1Output.Text += "8";
                }
                prevOperation = false;
            }
            catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка! Очистите поле ввода и повторите попытку!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1Output.Text == "0")
                {
                    richTextBox1Output.Text = "9";
                }
                else
                {
                    richTextBox1Output.Text += "9";
                }
                prevOperation = false;
            }
            catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка! Очистите поле ввода и повторите попытку!");
            }
        }

        private void buttonLeftBrace_Click(object sender, EventArgs e)//кнопка "("
        {
            try
            {
                if (richTextBox1Output.Text == "0")
                {
                    richTextBox1Output.Text = "(";
                    prevOperation = false;
                    leftBrace.Add(true);//при нажатии открывающейся скобки помещаем в наш список булевское значение, тем самым запоминая число открывшихся скобок
                }//если предыдущий символ является операцией или открывающейся скобкой, тогда
                else if (prevOperation && richTextBox1Output.Text[richTextBox1Output.Text.Length - 1] != ',' || richTextBox1Output.Text[richTextBox1Output.Text.Length - 1] == '(')
                {
                    richTextBox1Output.Text += "(";//приписываем "(" к выражениею
                    prevOperation = false;
                    leftBrace.Add(true);//запоминаем в наш список открывающихся скобок
                }
            }
            catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка! Очистите поле ввода и повторите попытку!");
            }   
        }

        private void buttonRightBrace_Click(object sender, EventArgs e)//кнопка ")"
        {
            try
            {   //если список не пуст и предыдущий символ является цифрой,тогда 
                if (leftBrace.Count > 0 && "+-*/(".IndexOf(richTextBox1Output.Text[richTextBox1Output.Text.Length - 1]) == -1)
                {
                    richTextBox1Output.Text += ")";//приписываем ")" к выражениею
                    leftBrace.RemoveAt(leftBrace.Count - 1);//удаляем из списка значение помняющую откр. скобку. Таким образом на каждую открывш. скобку должна приходиться закр. скобка
                }
            }
            catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка! Очистите поле ввода и повторите попытку!");
            }
        }

        private void buttonComma_Click(object sender, EventArgs e)// кнопка ",". Кнопки операций аналогичны
        {
            try
            {
                if (!comma)//Если предыдущий символ не запятая
                {
                    if (!prevOperation)//Еслии предыдущий символ не операция, тогда
                    {
                        richTextBox1Output.Text += ",";//приписываем
                    }
                    else
                    {   //иначе заменяем предыдущий символ операции на ","
                        richTextBox1Output.Text = richTextBox1Output.Text.Remove(richTextBox1Output.Text.Length - 1).Insert(richTextBox1Output.Text.Length - 1, ",");
                    }
                    prevOperation = true;
                    comma = true;
                }
            }
            catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка! Очистите поле ввода и повторите попытку!");
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            try
            {
                if (!prevOperation)
                {
                    richTextBox1Output.Text += "+";
                }
                else
                {
                    richTextBox1Output.Text = richTextBox1Output.Text.Remove(richTextBox1Output.Text.Length - 1).Insert(richTextBox1Output.Text.Length - 1, "+");
                }
                prevOperation = true;
                comma = false;
            }
            catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка! Очистите поле ввода и повторите попытку!");
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            try
            {
                if (!prevOperation)
                {
                    richTextBox1Output.Text += "-";
                }
                else
                {
                    richTextBox1Output.Text = richTextBox1Output.Text.Remove(richTextBox1Output.Text.Length - 1).Insert(richTextBox1Output.Text.Length - 1, "-");
                }
                prevOperation = true;
                comma = false;
            }
            catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка! Очистите поле ввода и повторите попытку!");
            }
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            try
            {
                if (!prevOperation)
                {
                    richTextBox1Output.Text += "*";
                }
                else
                {
                    richTextBox1Output.Text = richTextBox1Output.Text.Remove(richTextBox1Output.Text.Length - 1).Insert(richTextBox1Output.Text.Length - 1, "*");
                }
                prevOperation = true;
                comma = false;
            }
            catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка! Очистите поле ввода и повторите попытку!");
            }
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            try
            {
                if (!prevOperation)
                {
                    richTextBox1Output.Text += "/";
                }
                else
                {
                    richTextBox1Output.Text = richTextBox1Output.Text.Remove(richTextBox1Output.Text.Length - 1).Insert(richTextBox1Output.Text.Length - 1, "/");
                }
                prevOperation = true;
                comma = false;
            }
            catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка! Очистите поле ввода и повторите попытку!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)//удаление последнего символа
        {
            try
            {
                if (richTextBox1Output.Text.Length > 1)//если длина выражения больше одного,
                {
                    if ("+-*/".IndexOf(richTextBox1Output.Text[richTextBox1Output.Text.Length - 1]) != -1)//если удаляемый символ операция
                    {
                        prevOperation = false;
                    }
                    else if (richTextBox1Output.Text[richTextBox1Output.Text.Length - 1] == ',')//если удаляемый символ запятая
                    {
                        prevOperation = false;
                        comma = false;
                    }
                    else if (richTextBox1Output.Text[richTextBox1Output.Text.Length - 1] == '(')//если удаляемый символ откр. скобка
                    {
                        leftBrace.RemoveAt(leftBrace.Count - 1);
                    }
                    else if (richTextBox1Output.Text[richTextBox1Output.Text.Length - 1] == ')')//если удаляемый символ закрыв. скобочка
                    {
                        leftBrace.Add(true);
                    }
                    richTextBox1Output.Text = richTextBox1Output.Text.Remove(richTextBox1Output.Text.Length - 1);//удаляем последний символ
                }
                else//иначе чистим наше окно
                {
                    buttonClear_Click(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка! Очистите поле ввода и повторите попытку!");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)//очищение окна
        {
            try
            {
                richTextBox1Output.Text = "0";//значение обращается в 0
                prevOperation = false;
                comma = false;
                leftBrace.RemoveRange(0, leftBrace.Count);//удаляем все элементы списка
            }
            catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка! Перезапустите приложение!");
            }
        }

        //реализация обратно польской записи
        static private bool Delimeter(char c)//функция-предикат возвращающая занчение true, если встречаются разделители: " " и "="
        {
            if (" =".IndexOf(c) != -1)
            {
                return true;
            }
            return false;
        }

        static private bool Operation(char c)//Функция-предикат возвращающая занчение true, если встречаются  операторы:"(",")","+","-","*","/"
        {
            if ("()+-*/".IndexOf(c) != -1)
            {
                return true;
            }
            return false;
        }

        static private int Priority(char c)//Функция возвращающая приоритет операции
        {
            switch (c)
            {
                case '(':return 1;
                case ')':return 1;
                case '+':return 2;
                case '-':return 2;
                case '*':return 3;
                case '/':return 3;
                default:return 4;
            }
        }

        static private string Expression(string input)//функция возвращающая постфиксную запись из инфиксной
        {
            try
            {
                string output = String.Empty;//заводим выходную строку, пустую
                Stack<char> operationStack = new Stack<char>();//заводим стэк для операторов
                input = input.Replace(" ", "");//удаляем из входной строки все пропуски
                int j = 0;

                while (j != input.Length)//через цикл проходимся по входной строке и преобразовываем унарный "-" в бинарный
                {
                    if (j == 0)
                    {
                        if (input[j] == '-')
                        {
                            input = input.Remove(j, 1).Insert(j, "0-");
                        }
                    }
                    else if (input[j] == '-' && input[j - 1] == '(')
                    {
                        input = input.Remove(j, 1).Insert(j, "0-");
                    }

                    j++;
                }

                for (int i = 0; i < input.Length; i++)//проходимся по входной строке
                {
                    if (Delimeter(input[i]))//если разделитель, то переходим к следующей итерации
                    {
                        continue;
                    }

                    if (Char.IsDigit(input[i]))//если встретилась цифра, то считываем в выходную строку все символы цифр, пока не встретиться разделитель или оператор
                    {
                        while (!Delimeter(input[i]) && !Operation(input[i]) && i != input.Length)
                        {
                            output += input[i];
                            i++;
                        }

                        output += " ";
                        i--;
                    }

                    if (Operation(input[i]))//если встретился оператор
                    {
                        if (input[i] == '(')//если открывающаяся скобочка, то бросаем в стэк
                        {
                            operationStack.Push(input[i]);
                        }
                        else if (input[i] == ')')//если закрывающаяся, то выкидываем из стэка в выходную строку все операторы пока не встретится откр. скобочка
                        {
                            char operation = operationStack.Pop();

                            while (operation != '(')
                            {
                                output += operation.ToString() + " ";
                                operation = operationStack.Pop();
                            }
                        }
                        else//иначе
                        {
                            if (operationStack.Count > 0)//если стэк не пустой
                            {
                                while (Priority(input[i]) <= Priority(operationStack.Peek()))//пока приоритет оператора из входной строки <= приоритета верхенго элемента стэка
                                {
                                    output += operationStack.Pop().ToString() + " ";//выкидываем из стэка в выходную строку верхний элемент 
                                    if (operationStack.Count == 0)//если стэк пустой, то выходим из цикла
                                    {
                                        break;
                                    }
                                }
                            }
                            operationStack.Push(input[i]);//заносим оператор из входной строки в стэк
                        }
                    }
                }

                while (operationStack.Count > 0)//пройдясь по входной строке, выкидываем оставшиеся операторы из стэка в выходную строку
                {
                    output += operationStack.Pop() + " ";
                }

                return output;//возвращаем постфиксную запись
            }
            catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка! Очистите поле ввода и повторите попытку!");
                return String.Empty;
            }
        }

        static private double Calculate(string input)//функция считающая значение
        {
            try
            {
                double result = 0;
                Stack<double> numberStack = new Stack<double>();//заводим стэк для чисел

                for (int i = 0; i < input.Length; i++)//проходимся по входной строке
                {
                    if (Delimeter(input[i]))//если разделители, идём дальше
                    {
                        continue;
                    }

                    if (Char.IsDigit(input[i]))//если встретилась цифра, то считываем число
                    {
                        string number = String.Empty;

                        while (!Delimeter(input[i]) && !Operation(input[i]) && i != input.Length)
                        {
                            number += input[i];
                            i++;
                        }

                        numberStack.Push(double.Parse(number));//кладём считанное число в стэк
                        i--;
                    }
                    else if (Operation(input[i]))//если операция
                    {
                        double number1 = numberStack.Pop(), number2 = numberStack.Pop();//вытаскиваем из стека два 2 числа
                        try
                        {
                            switch (input[i])
                            {
                                case '+': result = number2 + number1; break;//если плюс, складываем
                                case '-': result = number2 - number1; break;//если минус, вычитаем
                                case '*': result = number2 * number1; break;//если умножение, перемножаем
                                case '/': result = number2 / number1; break;//если деление, делим
                                default: break;
                            }
                        }
                        catch (DivideByZeroException)
                        {
                            MessageBox.Show("В выражении произошло деление на ноль!");
                        }

                        numberStack.Push(result);//кладём результат в стэк
                    }
                }

                return numberStack.Peek();//после цикла получаем окончательный результат. Выталкиваем его из стэка
            }
            catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка! Очистите поле ввода и повторите попытку!");
                return 0;
            }
        }     

        private void buttonEqually_Click(object sender, EventArgs e)//кнопка, которая считает
        {
            if (leftBrace.Count == 0)//проверяет все ли открывшиеся скобки были закрыты, если да
            {
                richTextBox1Output.Text += "=";//приписываем равно
                richTextBox1Output.Text = Calculate(Expression(richTextBox1Output.Text)).ToString();//передаём входное выражение в наши функции
            }
            else
            {
                MessageBox.Show("В выражении непарные скобки! Проверьте выражение!");
            }
        }
    }
}
