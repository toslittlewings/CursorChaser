Public Class CursorChaserForm
    ' WindowsAPI
    Declare Function GetForegroundWindow Lib "user32" () As Long
    Declare Function GetWindowThreadProcessId Lib "user32" (hWnd As IntPtr, ByRef lpdwProcessId As Integer) As Integer

    '
    Private _timer As New Timer()
    Private _marker As New Marker()

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        '
        _marker.Show()
        _marker.Visible = False
        _cursorSize.Value = My.Settings.CursorSize
        _interval.Value = My.Settings.Interval
        _timer.Interval = _interval.Value
        _APHistory.Items.Clear()
        _targets.Items.Clear()
        Using sr = New IO.StringReader(My.Settings.Targets)
            Do
                Dim buf = sr.ReadLine()
                If IsNothing(buf) Then Exit Do
                _targets.Items.Add(buf)
            Loop
        End Using

        '
        AddHandler _timer.Tick,
            Sub(sender, ea)
                Dim h = GetForegroundWindow()
                Dim id = -1
                Dim result = GetWindowThreadProcessId(h, id)
                If id = -1 Then
                    Debug.WriteLine("can not detect process")
                    Return
                End If

                Dim p = Process.GetProcessById(id)
                Dim haveFocus = p.ProcessName.Equals("CursorChaser")
                ' アクティブなアプリが履歴に無いか先頭でないときは履歴の先頭に入れる（ちらつくのを防ぐため）
                If 0 < _APHistory.Items.IndexOf(p.ProcessName) Then _APHistory.Items.Remove(p.ProcessName)
                If Not haveFocus And Not _APHistory.Items.Contains(p.ProcessName) Then _APHistory.Items.Insert(0, p.ProcessName)

                Dim targetHasForcus = False
                For Each target In _targets.Items
                    If p.ProcessName.Equals(target) Then
                        targetHasForcus = True
                        Exit For
                    End If
                Next
                If targetHasForcus Or haveFocus Then
                    _marker.Visible = True
                    _marker.Location = New Point(Cursor.Position.X - _marker.Size.Width / 2, Cursor.Position.Y - _marker.Size.Height / 2)
                Else
                    _marker.Visible = False
                End If
                Debug.WriteLine(p.ProcessName)
            End Sub
        _timer.Start()
    End Sub

    Protected Overrides Sub OnClosed(e As EventArgs)
        MyBase.OnClosed(e)

        _timer.Stop()

        My.Settings.CursorSize = _cursorSize.Value
        My.Settings.Interval = _interval.Value
        Using sw = New IO.StringWriter()
            For Each target In _targets.Items
                sw.WriteLine(target)
            Next
            sw.Flush()
            My.Settings.Targets = sw.ToString()
        End Using
        My.Settings.Save()
    End Sub

    Private Sub _cursorSize_ValueChanged(sender As Object, e As EventArgs) Handles _cursorSize.ValueChanged
        If _marker.IsHandleCreated Then
            _marker.Invoke(Sub() _marker.Size = New Size(_cursorSize.Value, _cursorSize.Value))
        End If
    End Sub

    Private Sub _interval_ValueChanged(sender As Object, e As EventArgs) Handles _interval.ValueChanged
        _timer.Interval = _interval.Value
    End Sub

    Private Sub _addTarget_Click(sender As Object, e As EventArgs) Handles _addTarget.Click
        Dim item = _APHistory.SelectedItem
        If IsNothing(item) Then Return
        If Not _targets.Items.Contains(item) Then _targets.Items.Add(item)
    End Sub

    Private Sub _removeTarget_Click(sender As Object, e As EventArgs) Handles _removeTarget.Click
        Dim item = _targets.SelectedItem
        If IsNothing(item) Then Return
        _targets.Items.Remove(item)
    End Sub
End Class
