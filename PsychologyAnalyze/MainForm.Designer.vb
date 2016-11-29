<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ShowTip = New System.Windows.Forms.Label()
        Me.Positive = New System.Windows.Forms.Button()
        Me.Neuter = New System.Windows.Forms.Button()
        Me.Negative = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Test = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ShowTip
        '
        Me.ShowTip.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowTip.Font = New System.Drawing.Font("宋体", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ShowTip.Location = New System.Drawing.Point(164, 120)
        Me.ShowTip.Name = "ShowTip"
        Me.ShowTip.Size = New System.Drawing.Size(274, 70)
        Me.ShowTip.TabIndex = 0
        Me.ShowTip.Text = "词汇"
        Me.ShowTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Positive
        '
        Me.Positive.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Positive.Location = New System.Drawing.Point(390, 351)
        Me.Positive.Name = "Positive"
        Me.Positive.Size = New System.Drawing.Size(119, 34)
        Me.Positive.TabIndex = 1
        Me.Positive.Text = "积极（J）"
        Me.Positive.UseVisualStyleBackColor = True
        '
        'Neuter
        '
        Me.Neuter.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Neuter.Location = New System.Drawing.Point(237, 351)
        Me.Neuter.Name = "Neuter"
        Me.Neuter.Size = New System.Drawing.Size(119, 34)
        Me.Neuter.TabIndex = 2
        Me.Neuter.Text = "中性（H）"
        Me.Neuter.UseVisualStyleBackColor = True
        '
        'Negative
        '
        Me.Negative.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Negative.Location = New System.Drawing.Point(83, 351)
        Me.Negative.Name = "Negative"
        Me.Negative.Size = New System.Drawing.Size(119, 34)
        Me.Negative.TabIndex = 3
        Me.Negative.Text = "消极（F）"
        Me.Negative.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Test
        '
        Me.Test.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Test.Location = New System.Drawing.Point(237, 429)
        Me.Test.Name = "Test"
        Me.Test.Size = New System.Drawing.Size(122, 33)
        Me.Test.TabIndex = 4
        Me.Test.Text = "开始测试"
        Me.Test.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 510)
        Me.ControlBox = False
        Me.Controls.Add(Me.Test)
        Me.Controls.Add(Me.Negative)
        Me.Controls.Add(Me.Neuter)
        Me.Controls.Add(Me.Positive)
        Me.Controls.Add(Me.ShowTip)
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Positive As Button
    Friend WithEvents Neuter As Button
    Friend WithEvents Negative As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ShowTip As Label
    Friend WithEvents Test As Button
End Class
