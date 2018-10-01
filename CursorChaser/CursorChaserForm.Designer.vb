<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CursorChaserForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._interval = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._cursorSize = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._APHistory = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me._targets = New System.Windows.Forms.ListBox()
        Me._addTarget = New System.Windows.Forms.Button()
        Me._removeTarget = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me._interval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._cursorSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(167, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 12)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "msec"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(167, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "pixel"
        '
        '_interval
        '
        Me._interval.Location = New System.Drawing.Point(90, 32)
        Me._interval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me._interval.Name = "_interval"
        Me._interval.Size = New System.Drawing.Size(71, 19)
        Me._interval.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me._interval, "カーソル位置を監視する処理の頻度を時間で指定します" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "数値が小さいと追随の遅延が小さくなりますがPCの負荷が大きくなります")
        Me._interval.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "インターバル"
        '
        '_cursorSize
        '
        Me._cursorSize.Location = New System.Drawing.Point(90, 7)
        Me._cursorSize.Maximum = New Decimal(New Integer() {256, 0, 0, 0})
        Me._cursorSize.Minimum = New Decimal(New Integer() {32, 0, 0, 0})
        Me._cursorSize.Name = "_cursorSize"
        Me._cursorSize.Size = New System.Drawing.Size(71, 19)
        Me._cursorSize.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me._cursorSize, "マーカーのサイズを指定します")
        Me._cursorSize.Value = New Decimal(New Integer() {128, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "マーカーサイズ"
        '
        '_APHistory
        '
        Me._APHistory.FormattingEnabled = True
        Me._APHistory.ItemHeight = 12
        Me._APHistory.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me._APHistory.Location = New System.Drawing.Point(14, 82)
        Me._APHistory.Name = "_APHistory"
        Me._APHistory.Size = New System.Drawing.Size(120, 64)
        Me._APHistory.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me._APHistory, "ウィンドウがアクティブになったアプリケーションの履歴です")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 12)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "アクティブアプリ履歴"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(167, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 12)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "カーソル追随対象"
        '
        '_targets
        '
        Me._targets.FormattingEnabled = True
        Me._targets.ItemHeight = 12
        Me._targets.Items.AddRange(New Object() {"Client_tos"})
        Me._targets.Location = New System.Drawing.Point(169, 82)
        Me._targets.Name = "_targets"
        Me._targets.Size = New System.Drawing.Size(120, 64)
        Me._targets.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me._targets, "カーソル追随対象のアプリ一覧です")
        '
        '_addTarget
        '
        Me._addTarget.Location = New System.Drawing.Point(140, 82)
        Me._addTarget.Name = "_addTarget"
        Me._addTarget.Size = New System.Drawing.Size(23, 23)
        Me._addTarget.TabIndex = 16
        Me._addTarget.Text = ">"
        Me.ToolTip1.SetToolTip(Me._addTarget, "履歴で選択しているアプリを対象に加えます")
        Me._addTarget.UseVisualStyleBackColor = True
        '
        '_removeTarget
        '
        Me._removeTarget.Location = New System.Drawing.Point(140, 111)
        Me._removeTarget.Name = "_removeTarget"
        Me._removeTarget.Size = New System.Drawing.Size(23, 23)
        Me._removeTarget.TabIndex = 17
        Me._removeTarget.Text = "<"
        Me.ToolTip1.SetToolTip(Me._removeTarget, "対象から選択しているアプリを外します")
        Me._removeTarget.UseVisualStyleBackColor = True
        '
        'CursorChaserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 161)
        Me.Controls.Add(Me._removeTarget)
        Me.Controls.Add(Me._addTarget)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me._targets)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me._APHistory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me._interval)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me._cursorSize)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CursorChaserForm"
        Me.Text = "カーソル追随 β"
        CType(Me._interval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._cursorSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents _interval As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents _cursorSize As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents _APHistory As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents _targets As ListBox
    Friend WithEvents _addTarget As Button
    Friend WithEvents _removeTarget As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
