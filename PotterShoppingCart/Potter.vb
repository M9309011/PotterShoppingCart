
Public Class Potter

    Private _Episode As Integer

    Sub New(Episode As Integer)
        _Episode = Episode
    End Sub

    Public ReadOnly Property Episode As Integer
        Get
            Return _Episode
        End Get
    End Property

    Function Clone() As Potter
        Return New Potter(Me._Episode)
    End Function

End Class
