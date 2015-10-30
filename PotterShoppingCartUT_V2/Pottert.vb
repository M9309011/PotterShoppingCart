
Class Potter

    Private m_nEpisode As Integer

    Sub New(p1 As Integer)
        m_nEpisode = p1
    End Sub

    ReadOnly Property Episode As Integer
        Get
            Return Me.m_nEpisode
        End Get
    End Property

    Shared ReadOnly Property Price As Integer
        Get
            '1. 一到五集的哈利波特，每一本都是賣100元
            Return 100
        End Get
    End Property

    Function Clone() As Potter
        Return New Potter(Me.m_nEpisode)
    End Function

End Class
