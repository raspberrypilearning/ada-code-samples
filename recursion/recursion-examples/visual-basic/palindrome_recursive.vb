' Raspberry Pi Foundation
' Usage licensed under CC BY-NC-SA 4.0
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program


Module Program

    ' The Main subroutine is the default entry point for a VB program
    Sub Main()
        Dim testWord As String = "kayak" ' Test data
        Dim isPalindrome As Boolean = Palindrome(testWord)
        Dim result As String = $"{testWord}: {isPalindrome}"
        Console.WriteLine(result)

        testWord = "apple" ' Test data
        isPalindrome = Palindrome(testWord)
        result = $"{testWord}: {isPalindrome}"
        Console.WriteLine(result)
        Console.ReadLine()
    End Sub

    Function Palindrome(ByVal word As String) As Boolean
        Dim length As Integer = word.Length

        If length = 0 OrElse length = 1 Then
            Return True
        ElseIf word(0) = word(length - 1) Then
            Dim newWord As String = word.Substring(1, length - 2)
            Return Palindrome(newWord)
        Else
            Return False
        End If
    End Function
End Module
