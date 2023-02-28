' Raspberry Pi Foundation
' Developed as part of Ada Computer Science
' Usage licensed under CC BY-NC-SA 4.0
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program

Module program

    Const MAXSIZE As Integer = 3 ' Four slots in stack

    ' The Main method is the default entry point for all VB programs
    Sub Main()
        ' Initialise the stack and pointer
        Dim stack(MAXSIZE) As String
        Dim top As Integer = -1

        ' Insert test data into the stack
        top = Push(stack, top, "Julie")
        top = Push(stack, top, "Rey")
        top = Push(stack, top, "Habib")
        top = Push(stack, top, "Sabrina")
        ' Trying to push - should say stack is full
        top = Push(stack, top, "Mina")

        ' Peek the top item of the stack
        Dim peekedItem = Peek(stack, top)
        Console.Write($"Peeked top of the stack - saw: {peekedItem}")

        ' Pop all of the items
        For Each item In stack
            ' Tuple is used to store multiple return values
            Dim poppedValues As Tuple(Of String, Integer) ' item, top
            poppedValues = Pop(stack, top)
            top = poppedValues.Item2
        Next

        ' Try to pop - should say stack is empty
        Dim finalPoppedValues As Tuple(Of String, Integer) ' item, top
        finalPoppedValues = Pop(stack, top)
    End Sub


    ' Check if the stack is empty
    Function IsEmpty(ByVal top As Integer) As Boolean
        If top = -1 Then
            Return True
        Else
            Return False
        End If
    End Function


    ' Check if the stack is full
    Function IsFull(ByVal top As Integer) As Boolean
        If top = MAXSIZE Then
            Return True
        Else
            Return False
        End If
    End Function


    ' Push data onto the top of the stack
    Function Push(ByVal stack As String(), ByVal top As Integer, ByVal data As String) As Integer
        If IsFull(top) = True Then
            Console.WriteLine(vbLf & $"Stack is full - {data} not added")
        Else
            top = top + 1
            stack(top) = data
            OutputStack(stack, top)
        End If
        Return top
    End Function


    ' Return a copy of the item from the top of stack without removing it
    Function Peek(ByVal stack As String(), ByVal top As Integer) As String
        Dim peekedItem As String

        If IsEmpty(top) = True Then
            Console.WriteLine(vbLf & "Stack is empty - nothing to peek")
            peekedItem = Nothing
        Else
            peekedItem = stack(top)
        End If

        Return peekedItem
    End Function


    ' Return the item from the top of stack and remove it from the stack
    Function Pop(ByVal stack As String(), ByVal top As Integer) As Tuple(Of String, Integer)
        Dim poppedItem As String

        If IsEmpty(top) = True Then
            Console.WriteLine(vbLf & "Stack is empty - nothing to pop")
            poppedItem = Nothing
        Else
            poppedItem = stack(top)
            stack(top) = Nothing  ' Testing
            top = top - 1
            OutputStack(stack, top)
        End If

        Return Tuple.Create(poppedItem, top)
    End Function


    ' Output the state of the stack
    Sub OutputStack(ByVal stack As String(), ByVal top As Integer)
        ' Testing
        Console.WriteLine(vbLf & "------ State of the stack (first item is the top) ------")

        For i = MAXSIZE To 0 Step -1
            Dim item = stack(i)
            If String.IsNullOrEmpty(item) Then
                item = Nothing
            End If
            Console.WriteLine($"{item}")
        Next

        Console.WriteLine($"Top pointer: {top}")
    End Sub


End Module
