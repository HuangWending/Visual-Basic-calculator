# Visual-Basic-calculator
Visual Basic计算器程序
Imports System：引入System命名空间，其中包含了许多基本的类型和常用函数。

Module Calculator：定义一个名为Calculator的模块，其中包含了我们的计算器程序的主要代码。

Sub Main()：定义一个名为Main的子过程，它是程序的入口点。

Dim num1, num2 As Double：声明两个名为num1和num2的Double类型的变量，用于存储输入的数字。

Dim operation As Char：声明一个名为operation的Char类型的变量，用于存储操作符。

Console.WriteLine("欢迎使用黄文定计算器程序！")：在控制台输出欢迎消息。

Console.Write("请输入第一个数字：")：在控制台上输出提示，要求用户输入第一个数字。

num1 = Convert.ToDouble(Console.ReadLine())：从用户输入的控制台读取一行文本，并将其转换为Double类型，然后将其赋值给num1变量。

Console.Write("请输入操作符（+、-、*、/）：")：在控制台输出提示，要求用户输入操作符。

operation = Console.ReadLine()(0)：从用户输入的控制台读取一行文本，并将其第一个字符赋值给operation变量。

Console.Write("请输入第二个数字：")：在控制台输出提示，要求用户输入第二个数字。

num2 = Convert.ToDouble(Console.ReadLine())：从用户输入的控制台读取一行文本，并将其转换为Double类型，然后将其赋值给num2变量。

Dim result As Double：声明一个名为result的Double类型的变量，用于存储计算结果。

Select Case operation：根据操作符的值执行不同的操作。

Case "+"：如果操作符为"+"，则执行下面的代码块。

result = num1 + num2：将num1和num2的和赋值给result。

Case "-"：如果操作符为"-"，则执行下面的代码块。

result = num1 - num2：将num1和num2的差赋值给result。

Case "*"：如果操作符为"*"，则执行下面的代码块。

result = num1 * num2：将num1和num2的乘积赋值给result。

Case "/"：如果操作符为"/"，则执行下面的代码块。

result = num1 / num2：将num1除以num2的结果赋值给result。

Case Else：如果操作符不是以上任何一种情况，则执行下面的代码块。

Console.WriteLine("无效的操作符！")：在控制台输出错误消息。

Exit Sub：退出当前子过程。

Console.WriteLine("结果： " & result)：在控制台上输出计算结果。

Console.WriteLine("按任意键继续...")：在控制台上输出提示，要求用户按下任意键继续。

Console.ReadKey()：等待用户按下任意键，然后继续执行程序。
