<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelFile = New System.Windows.Forms.Panel()
        Me.TextBoxDest = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.PanelFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ここにドロップしてね！"
        '
        'PanelFile
        '
        Me.PanelFile.AllowDrop = True
        Me.PanelFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelFile.Controls.Add(Me.Label1)
        Me.PanelFile.Location = New System.Drawing.Point(32, 50)
        Me.PanelFile.Name = "PanelFile"
        Me.PanelFile.Size = New System.Drawing.Size(200, 100)
        Me.PanelFile.TabIndex = 1
        '
        'TextBoxDest
        '
        Me.TextBoxDest.Location = New System.Drawing.Point(80, 13)
        Me.TextBoxDest.Name = "TextBoxDest"
        Me.TextBoxDest.Size = New System.Drawing.Size(191, 19)
        Me.TextBoxDest.TabIndex = 2
        Me.TextBoxDest.Text = "C:\test\"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "移動先"
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(78, 153)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(38, 12)
        Me.LabelStatus.TabIndex = 4
        Me.LabelStatus.Text = "Status"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 173)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxDest)
        Me.Controls.Add(Me.PanelFile)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.PanelFile.ResumeLayout(False)
        Me.PanelFile.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PanelFile As Panel
    Friend WithEvents TextBoxDest As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelStatus As Label
End Class
