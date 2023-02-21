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
        Dim shoppingList(19) As String 'Fixed size array with 20 slots
        AddNewItem(shoppingList, "milk")
        AddNewItem(shoppingList, "bread")
        AddNewItem(shoppingList, "cake")
        For Each item As String In shoppingList
            Console.WriteLine(item)
        Next

    End Sub

    Sub AddNewItem(ByRef aList() As String, ByVal newItem As String)
        Dim i As Integer = 0
        Dim itemAdded As Boolean = False
        ' Find empty slot to add the item
        While itemAdded = False AndAlso i < aList.Length
            If aList(i) = Nothing Then
                aList(i) = newItem
                itemAdded = True
            End If
            i = i + 1
        End While
    End Sub

End Module
