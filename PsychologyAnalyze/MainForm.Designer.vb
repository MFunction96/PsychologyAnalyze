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
        Me.SuspendLayout()
        '
        'ShowTip
        '
        Me.ShowTip.AutoSize = True
        Me.ShowTip.Font = New System.Drawing.Font("宋体", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ShowTip.Location = New System.Drawing.Point(217, 139)
        Me.ShowTip.Name = "ShowTip"
        Me.ShowTip.Size = New System.Drawing.Size(170, 70)
        Me.ShowTip.TabIndex = 0
        Me.ShowTip.Text = "词汇"
        '
        'Positive
        '
        Me.Positive.Location = New System.Drawing.Point(88, 351)
        Me.Positive.Name = "Positive"
        Me.Positive.Size = New System.Drawing.Size(119, 34)
        Me.Positive.TabIndex = 1
        Me.Positive.Text = "积极"
        Me.Positive.UseVisualStyleBackColor = True
        '
        'Neuter
        '
        Me.Neuter.Location = New System.Drawing.Point(240, 351)
        Me.Neuter.Name = "Neuter"
        Me.Neuter.Size = New System.Drawing.Size(119, 34)
        Me.Neuter.TabIndex = 2
        Me.Neuter.Text = "中性"
        Me.Neuter.UseVisualStyleBackColor = True
        '
        'Negative
        '
        Me.Negative.Location = New System.Drawing.Point(393, 351)
        Me.Negative.Name = "Negative"
        Me.Negative.Size = New System.Drawing.Size(119, 34)
        Me.Negative.TabIndex = 3
        Me.Negative.Text = "消极"
        Me.Negative.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 510)
        Me.ControlBox = False
        Me.Controls.Add(Me.Negative)
        Me.Controls.Add(Me.Neuter)
        Me.Controls.Add(Me.Positive)
        Me.Controls.Add(Me.ShowTip)
        Me.Name = "MainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ShowTip As Label
    Friend WithEvents Positive As Button
    Friend WithEvents Neuter As Button
    Friend WithEvents Negative As Button
    Friend WithEvents Timer1 As Timer
End Class
