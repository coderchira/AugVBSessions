Public Class Animal
    ' responsibilty / entity/ nouns
    ' Functions and their relevant data = class

    'Data variables/ members 
    Private _name As String
    Private _age As Integer
    Private _color As String

    'Behaviour / function / logic / method

    'Constructor
    Sub New()
        Console.WriteLine("we are inside the constructor of Animal class")
    End Sub

    Sub New(age As Integer)
        _age = age
        Console.WriteLine("We are inside parametrized constructor of the animal class")
    End Sub
    Overridable Sub Walk()
        Console.WriteLine("This is the animal walking")
        Console.ReadLine()
    End Sub

    'Sub setName(value As String)
    '    name = value
    'End Sub

    'Function getName() As String
    '    Return name
    'End Function


    'Sub setAge(value As String)
    '    age = value
    'End Sub
    'Function getAge() As Integer
    '    Return age
    'End Function

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public ReadOnly Property Age() As Integer
        Get
            Return _age
        End Get
    End Property


    Public WriteOnly Property Color() As String
        Set(ByVal value As String)
            _color = value
        End Set
    End Property


End Class
