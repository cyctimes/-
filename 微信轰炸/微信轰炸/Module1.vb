Module Module1

    Sub Main()
        Dim Index As Integer
        Dim Bomb As String
        Dim Message As String
        Dim BombTry As Integer
        Dim YESN As String


        Do
            Console.WriteLine("轰炸？【对/错】")
            Bomb = Console.ReadLine
            If Bomb = "对" Then
                Console.WriteLine("轰炸什么?")
                Message = Console.ReadLine
                Console.WriteLine("轰炸几次？")
                BombTry = Console.ReadLine
                Console.WriteLine("正在准备轰炸文件：")
                For Index = 0 To 5
                    Console.WriteLine()
                Next
                Index = 0
                Console.WriteLine()
                For Index = 0 To BombTry
                    Console.WriteLine(Message)
                Next
                For Index = 0 To 5
                    Console.WriteLine()
                Next
                Console.WriteLine("结束？【是/否】")
                YESN = Console.ReadLine
                If YESN = "是" Then
                    Exit Do
                Else

                End If
            ElseIf Bomb = "错" Then
                    Console.WriteLine("那你点进来干嘛？")
                    Console.ReadLine()
                    Exit Sub
                Else
                    Console.WriteLine("输入错误！")
                Console.WriteLine()
            End If
        Loop Until Bomb = "对" And Bomb = "错"
        Console.ReadLine()
    End Sub

End Module
