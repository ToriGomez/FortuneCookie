﻿'Tori Gomez
'RCET0265
'Spring 2021
'Fortune Cookie
'https://github.com/ToriGomez/FortuneCookie.git

Option Strict On
Option Explicit On

Module FortuneCookie

    Sub Main()
        Dim wisdomOne As Double = 1
        Dim wisdomTwo As Double = 2
        Dim wisdomThree As Double = 3
        Dim wisdomFour As Double = 4

        For i = 1 To 2
            RandomNumberInRange(1)
        Next

        If RandomNumberInRange(1) = CInt(wisdomOne) Then
            Console.WriteLine("To truly find yourself you should")
            Console.WriteLine("play hide and seek alone.")
            Console.ReadLine()
            End
        ElseIf RandomNumberInRange(1) = CInt(wisdomTwo) Then
            Console.WriteLine("I see money in your future...")
            Console.WriteLine("it is not yours though.")
            Console.ReadLine()
            End
        ElseIf RandomNumberInRange(1) = CInt(wisdomThree) Then
            Console.WriteLine("Life is a series of choices...")
            Console.WriteLine("Today yours are good ones.")
            Console.ReadLine()
            End
        ElseIf RandomNumberInRange(1) = CInt(wisdomFour) Then
            Console.WriteLine("Plan to be spontaneous tomorrow.")
            Console.ReadLine()
            End
        End If

        Console.WriteLine("Ignore previous cookie")
        Console.Read()

    End Sub

    Function RandomNumberInRange(maxNumber As Integer) As Integer
        Randomize(DateTime.Now.Millisecond)
        maxNumber = CInt(Int(5 * Rnd()))
        Return maxNumber
    End Function

End Module
