Public Class Dog ' Child Class / derived class / sub class
    Inherits Animal ' parent class / base class /Super class
    Private _breed As String
    Public Property Breed() As String
        Get
            Return _breed
        End Get
        Set(ByVal value As String)
            _breed = value
        End Set
    End Property

    Sub Jump()
        Console.WriteLine("This is the dog jumping")
    End Sub

    Sub MakesSound()
        Console.WriteLine("This is the dog barking!")
    End Sub

    Sub New()
        Console.WriteLine("we are inside the dog class constructor")
    End Sub

    Overrides Sub Walk()
        'Implementation / Body
        Console.WriteLine("This is the dog walking")
    End Sub
End Class
