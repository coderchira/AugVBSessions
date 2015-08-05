﻿Module Module1

    Sub Main()
        'Comments
        'What is a Program?
        ' Data <---> Logic
        '   Data
        '       Variables -- change value overtime
        '           Native
        '               Fixed size
        '               stack (faster)
        '               no need to dispose
        '           Reference /Object type
        '               vary in size
        '               heap(slower)
        '               dispose them explicitly
        '       Constants -- whose value remains fixed
        '           Pi etc.

        'Calling a sub from LogicDemo
        'LogicDemo.MySub()
        ' newfunc() -- not accessible since it is private to logicdemo
        'MySub()
        'DoThis()
        'DoThisAsWell()
        'LogicDemo.varForAll = 20

        'Dim obj As New Animal()
        'obj.Walk()
        'obj.setName("SomeNewAnimal")
        'Console.WriteLine(obj.getName())

        ''obj.Age = 20
        'Console.WriteLine(obj.Age)
        'obj.Color = "Blue"
        ''Console.WriteLine(obj.Color)

        'Dim obj2 As New Animal(1)
        'Console.WriteLine(obj2.Age)

        ''Dog Class
        'Dim obj3 As New Dog
        'obj3.Breed = "German shephard"
        'Console.WriteLine(obj3.Breed)
        'obj3.MakesSound()
        'obj3.Jump()

        'Dim obj3 As Animal
        'obj3 = New Animal

        CollectionsExercise.AddCollection()

        Dim obj4 As New Dog
        obj4.Jump()
        obj4.Walk()

        Dim obj5 As Animal 'base class
        obj5 = New Dog ' instantiate an object of child class
        obj5.Walk()
        obj5.Name = "Bruno"
        obj5.Color = "brown"
        CType(obj5, Dog).Jump()

        obj5 = New Cow
        CType(obj5, Cow).SomeMethod()

        ConditionsAndLoops.Run(9, 15, "Bunny")

        'Lifecycle of a variable
        ' Declare
        ' Use 
        ' Dispose

        'Declare
        '   Dim
        '   Name
        '   Type
        Dim flag As Boolean ' 2 bytes
        Dim num As Integer ' 4 bytes
        Dim precision As Single ' 4 bytes
        Dim doubleprecision As Double ' 8 bytes
        Dim accuracy As Decimal ' 16 bytes
        Dim name As String ' depends on length of string

        ' Assign/ Use
        flag = True
        num = 10
        precision = 1.12234234
        doubleprecision = 1.12351275386823
        accuracy = 1.25
        name = "Ruchira"

        Console.WriteLine(flag)
        Console.WriteLine(num)
        Console.ReadLine()

        'integer operations
        Dim leftInt As Integer
        Dim rightInt As Integer
        Dim sumOfnums As Integer
        Dim prodOfnums As Integer
        Dim subOfnums As Integer
        Dim remainder As Integer
        Dim quotient As Integer

        leftInt = 20
        rightInt = 30
        sumOfnums = leftInt + rightInt
        prodOfnums = leftInt * rightInt
        subOfnums = rightInt - leftInt
        quotient = Math.DivRem(rightInt, leftInt, remainder)

        Console.WriteLine(leftInt)
        Console.WriteLine(rightInt)
        Console.WriteLine(sumOfnums)
        Console.WriteLine(prodOfnums)
        Console.WriteLine(quotient)
        Console.WriteLine(remainder)
        Console.ReadLine()

        'string operations
        Dim message1 As String
        Dim message2 As String
        Dim resultMsg As String

        message1 = "Hurray! This is VB session day 1"
        message2 = "and we are confident of learning on day 1 !"

        'concatenation
        ' resultMsg = message1 + message2 ' avoid this 
        resultMsg = message1 & message2
        'Console.WriteLine(resultMsg)
        Console.WriteLine("Value of resultMsg is:" & message1 & " " & message2)


        Dim position As Integer
        position = InStr(resultMsg, "and")
        'insert a space before "and" and store the final message in resultMsg
        resultMsg = resultMsg.Insert(position - 1, " ")
        Console.WriteLine(resultMsg)
        Console.ReadLine()

        'position of second occurrence of the word "day"
        Dim position2 As Integer
        position2 = InStr(position + 1, resultMsg, "day")
        Console.WriteLine(position2)
        Console.ReadLine()

        Dim leftPortion As String
        Dim rightportion As String
        leftPortion = Left(resultMsg, 27)
        rightportion = Right(resultMsg, 30)
        Console.WriteLine(leftPortion)
        Console.WriteLine(rightportion)
        Console.ReadLine()

        'Conversion of variables from one type to another
        Dim number As Integer
        Dim numAsString As String
        number = 10
        numAsString = number.ToString()
        numAsString = CStr(number)

        'str into integers
        'CInt

        Dim str As String
        Dim strAsDouble As Double
        str = "1.273"
        strAsDouble = CDbl(str)

        'Reference variable
        Dim myColl As New Collection ' capable to hold native type variables
        myColl.Add("1")
        myColl.Add(20)
        myColl.Add("name")
        myColl.Add(True)
        Console.WriteLine("myColl has following items: {0},{1},{2}, {3}", myColl.Item(1), myColl.Item(2), myColl.Item(3), myColl.Item(4))
        Console.ReadLine()

        'myColl.Remove(1)
        'myColl.Remove(2)
        'myColl.Remove(3)
        'myColl.Remove(4)

        'Fails on runtime
        ' Console.WriteLine("myColl has following items: {0}", myColl.Item(0))
        Console.WriteLine("myColl has following items: {0},{1},{2}", myColl.Item(1), myColl.Item(2), myColl.Item(3))
        Console.ReadLine()

        'Dispose
        myColl = Nothing
    End Sub

End Module
