
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

    Function Clone() As Potter
        Return New Potter(Me.m_nEpisode)
    End Function

End Class
