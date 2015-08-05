Module CollectionsExercise
    'Create 2 collections
    '1 collection has 10 names
    'second collection is empty
    'code such that : transfer of all the names from one collection to another 
    'except the one which has your name

    'Module level variable
    Dim myColl As New Collection
    Dim newcoll As New Collection
    Sub AddCollection()
        myColl.Add("Priya")
        myColl.Add("Rekha")
        myColl.Add("Amit")
        myColl.Add("Sasmita")
        myColl.Add("Kishore")
        myColl.Add("Junaid")
        myColl.Add("Vani")
        myColl.Add("Srikant")
        myColl.Add("Ruchira")
        myColl.Add("Agnes")

        For Each item In myColl
            If Not item.Equals("Rekha") Then
                newcoll.Add(item)
            End If
        Next
        For Each item In newcoll
            Console.WriteLine(item)
        Next
        Console.ReadLine()
    End Sub


End Module
