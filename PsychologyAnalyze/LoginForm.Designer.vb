<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StartTest = New System.Windows.Forms.Button()
        Me.HeightTip = New System.Windows.Forms.Label()
        Me.Height = New System.Windows.Forms.TextBox()
        Me.Weight = New System.Windows.Forms.TextBox()
        Me.WeightTip = New System.Windows.Forms.Label()
        Me.Sex = New System.Windows.Forms.TextBox()
        Me.SexTip = New System.Windows.Forms.Label()
        Me.Age = New System.Windows.Forms.TextBox()
        Me.AgeTip = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'StartTest
        '
        Me.StartTest.Location = New System.Drawing.Point(225, 414)
        Me.StartTest.Name = "StartTest"
        Me.StartTest.Size = New System.Drawing.Size(142, 34)
        Me.StartTest.TabIndex = 0
        Me.StartTest.Text = "开始测试"
        Me.StartTest.UseVisualStyleBackColor = True
        '
        'HeightTip
        '
        Me.HeightTip.AutoSize = True
        Me.HeightTip.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.HeightTip.Location = New System.Drawing.Point(153, 120)
        Me.HeightTip.Name = "HeightTip"
        Me.HeightTip.Size = New System.Drawing.Size(49, 20)
        Me.HeightTip.TabIndex = 1
        Me.HeightTip.Text = "身高"
        '
        'Height
        '
        Me.Height.Location = New System.Drawing.Point(240, 115)
        Me.Height.Name = "Height"
        Me.Height.Size = New System.Drawing.Size(191, 25)
        Me.Height.TabIndex = 2
        '
        'Weight
        '
        Me.Weight.Location = New System.Drawing.Point(240, 178)
        Me.Weight.Name = "Weight"
        Me.Weight.Size = New System.Drawing.Size(191, 25)
        Me.Weight.TabIndex = 4
        '
        'WeightTip
        '
        Me.WeightTip.AutoSize = True
        Me.WeightTip.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.WeightTip.Location = New System.Drawing.Point(153, 183)
        Me.WeightTip.Name = "WeightTip"
        Me.WeightTip.Size = New System.Drawing.Size(49, 20)
        Me.WeightTip.TabIndex = 3
        Me.WeightTip.Text = "体重"
        '
        'Sex
        '
        Me.Sex.Location = New System.Drawing.Point(240, 240)
        Me.Sex.Name = "Sex"
        Me.Sex.Size = New System.Drawing.Size(191, 25)
        Me.Sex.TabIndex = 6
        '
        'SexTip
        '
        Me.SexTip.AutoSize = True
        Me.SexTip.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SexTip.Location = New System.Drawing.Point(153, 245)
        Me.SexTip.Name = "SexTip"
        Me.SexTip.Size = New System.Drawing.Size(49, 20)
        Me.SexTip.TabIndex = 5
        Me.SexTip.Text = "性别"
        '
        'Age
        '
        Me.Age.Location = New System.Drawing.Point(240, 307)
        Me.Age.Name = "Age"
        Me.Age.Size = New System.Drawing.Size(191, 25)
        Me.Age.TabIndex = 8
        '
        'AgeTip
        '
        Me.AgeTip.AutoSize = True
        Me.AgeTip.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.AgeTip.Location = New System.Drawing.Point(153, 312)
        Me.AgeTip.Name = "AgeTip"
        Me.AgeTip.Size = New System.Drawing.Size(49, 20)
        Me.AgeTip.TabIndex = 7
        Me.AgeTip.Text = "年龄"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 518)
        Me.Controls.Add(Me.Age)
        Me.Controls.Add(Me.AgeTip)
        Me.Controls.Add(Me.Sex)
        Me.Controls.Add(Me.SexTip)
        Me.Controls.Add(Me.Weight)
        Me.Controls.Add(Me.WeightTip)
        Me.Controls.Add(Me.Height)
        Me.Controls.Add(Me.HeightTip)
        Me.Controls.Add(Me.StartTest)
        Me.Name = "LoginForm"
        Me.Text = "开始测试"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartTest As Button
    Friend WithEvents HeightTip As Label
    Friend WithEvents Height As TextBox
    Friend WithEvents Weight As TextBox
    Friend WithEvents WeightTip As Label
    Friend WithEvents Sex As TextBox
    Friend WithEvents SexTip As Label
    Friend WithEvents Age As TextBox
    Friend WithEvents AgeTip As Label
End Class
