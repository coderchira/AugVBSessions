
Module  CollectionsExercise
'Create 2 collections
    '1 collection has 10 names
    'second collection is empty
    'code such that : transfer of all the names from one collection to another 
    'except the one which has your name

    Sub Main()

        Dim myColl1 As New Collection
        Dim myColl2 As New Collection

        myColl1.Add("Ayush")
        myColl1.Add("Asha")
        myColl1.Add("Rekha")
        myColl1.Add("Goergia")
        myColl1.Add("Reynold")
        myColl1.Add("Billie")
        myColl1.Add("Jessica")
        myColl1.Add("Mathew")
        myColl1.Add("Stephen")
        myColl1.Add("Sara")

        'Console.WriteLine("The Collection 1 has the following items:{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", myColl1.Item(1),
        '                                                                                                     myColl1.Item(2),
        '                                                                                                     myColl1.Item(3),
        '                                                                                                     myColl1.Item(4),
        '                                                                                                     myColl1.Item(5),
        '                                                                                                     myColl1.Item(6),
        '                                                                                                     myColl1.Item(7),
        '                                                                                                     myColl1.Item(8),
        '                                                                                                     myColl1.Item(9),
        '                                                                                                     myColl1.Item(10))
        Console.WriteLine("The Collection 1 has the following items:")
        For Each item In myColl1
                Console.WriteLine(item)
        Next item

       
        For Each item In myColl1
            If Not item.Equals("Rekha") Then
                myColl2.Add(item)
            End If
        Next item

        Console.WriteLine("The Collection 2 has all the names except Rekha from Collection 1:")
        For Each item In myColl2
            Console.WriteLine(item)
        Next item
        Console.ReadLine()

    End Sub
End Module
