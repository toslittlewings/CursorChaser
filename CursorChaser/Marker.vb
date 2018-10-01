Public Class Marker
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or &H200
            cp.ExStyle = cp.ExStyle Or &H20
            Return cp
        End Get
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.FillEllipse(Brushes.Black, 0, 0, ClientRectangle.Width, ClientRectangle.Height)
        e.Graphics.FillEllipse(Brushes.Yellow, 2, 2, ClientRectangle.Width - 5, ClientRectangle.Height - 5)
        e.Graphics.FillEllipse(Brushes.Black, 4, 4, ClientRectangle.Width - 9, ClientRectangle.Height - 9)
        e.Graphics.FillEllipse(Brushes.White, 6, 6, ClientRectangle.Width - 13, ClientRectangle.Height - 13)
    End Sub

End Class