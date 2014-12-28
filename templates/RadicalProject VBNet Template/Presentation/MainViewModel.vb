Namespace Presentation
    Public Class MainViewModel
        Inherits Topics.Radical.Windows.Presentation.AbstractViewModel

        Sub New()
            Me.SetInitialPropertyValue(Function() Me.SampleText, "Welcome to Radical.")
        End Sub

        Public Property SampleText As String
            Get
                Return Me.GetPropertyValue(Function() Me.SampleText)
            End Get
            Set(value As String)
                Me.SetPropertyValue(Function() Me.SampleText, value)
            End Set
        End Property

    End Class
End Namespace
