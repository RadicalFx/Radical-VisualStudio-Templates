Imports RadicalTemplate.Presentation

Class Application

    ' Application-level events, such as Startup, Exit, and DispatcherUnhandledException
    ' can be handled in this file.
    Sub New()

        Dim bootsrapper As New Topics.Radical.Windows.Presentation.Boot.WindsorApplicationBootstrapper(Of MainView)()

    End Sub

End Class
