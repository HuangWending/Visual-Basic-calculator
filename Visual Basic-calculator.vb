Imports System

Module Calculator
    Sub Main()
        Dim num1, num2 As Double
        Dim operation As Char

        Console.WriteLine("欢迎使用黄文定计算器程序！")
        Console.Write("请输入第一个数字：")
        num1 = Convert.ToDouble(Console.ReadLine())

        Console.Write("请输入操作符（+、-、*、/）：")
        operation = Console.ReadLine()(0)

        Console.Write("请输入第二个数字：")
        num2 = Convert.ToDouble(Console.ReadLine())

        Dim result As Double

        Select Case operation
            Case "+"
                result = num1 + num2
            Case "-"
                result = num1 - num2
            Case "*"
                result = num1 * num2
            Case "/"
                result = num1 / num2
            Case Else
                Console.WriteLine("无效的操作符！")
                Exit Sub
        End Select

        Console.WriteLine("结果： " & result)

        Console.WriteLine("按任意键继续...")
        Console.ReadKey()
    End Sub
End Module
