<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lost
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lost))
        Me.Title_Lost = New System.Windows.Forms.Label()
        Me.Subtitle_Lost = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NameText = New System.Windows.Forms.TextBox()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.AddressLabel1 = New System.Windows.Forms.TextBox()
        Me.AddressLabel2 = New System.Windows.Forms.TextBox()
        Me.PostalCodeText = New System.Windows.Forms.TextBox()
        Me.PC = New System.Windows.Forms.Label()
        Me.SubSubTitle_Lost = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.IfFound = New System.Windows.Forms.Label()
        Me.IfFoundText = New System.Windows.Forms.TextBox()
        Me.Back = New System.Windows.Forms.Button()
        Me.Email = New System.Windows.Forms.Button()
        Me.DesignCredit = New System.Windows.Forms.Label()
        Me.InformationVerificationInterval = New System.Windows.Forms.Timer(Me.components)
        Me.TestButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Title_Lost
        '
        Me.Title_Lost.AutoSize = True
        Me.Title_Lost.Font = New System.Drawing.Font("Myriad Pro Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title_Lost.Location = New System.Drawing.Point(163, 28)
        Me.Title_Lost.Name = "Title_Lost"
        Me.Title_Lost.Size = New System.Drawing.Size(185, 28)
        Me.Title_Lost.TabIndex = 1
        Me.Title_Lost.Text = "Found a lost USB drive?"
        '
        'Subtitle_Lost
        '
        Me.Subtitle_Lost.AutoSize = True
        Me.Subtitle_Lost.Font = New System.Drawing.Font("Myriad Pro Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subtitle_Lost.Location = New System.Drawing.Point(82, 51)
        Me.Subtitle_Lost.Name = "Subtitle_Lost"
        Me.Subtitle_Lost.Size = New System.Drawing.Size(350, 19)
        Me.Subtitle_Lost.TabIndex = 3
        Me.Subtitle_Lost.Text = "The following  are information regarding the owner of this USB drive."
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Myriad Pro Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(82, 111)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(38, 19)
        Me.NameLabel.TabIndex = 15
        Me.NameLabel.Text = "Name"
        '
        'NameText
        '
        Me.NameText.Location = New System.Drawing.Point(133, 112)
        Me.NameText.Name = "NameText"
        Me.NameText.Size = New System.Drawing.Size(118, 20)
        Me.NameText.TabIndex = 16
        Me.NameText.Text = "Jiawen (Fred) Deng"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Font = New System.Drawing.Font("Myriad Pro Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLabel.Location = New System.Drawing.Point(82, 138)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(48, 19)
        Me.AddressLabel.TabIndex = 17
        Me.AddressLabel.Text = "Address"
        '
        'AddressLabel1
        '
        Me.AddressLabel1.Location = New System.Drawing.Point(133, 138)
        Me.AddressLabel1.Name = "AddressLabel1"
        Me.AddressLabel1.Size = New System.Drawing.Size(118, 20)
        Me.AddressLabel1.TabIndex = 18
        Me.AddressLabel1.Text = "303 Fergus Crescent"
        '
        'AddressLabel2
        '
        Me.AddressLabel2.Location = New System.Drawing.Point(133, 164)
        Me.AddressLabel2.Name = "AddressLabel2"
        Me.AddressLabel2.Size = New System.Drawing.Size(66, 20)
        Me.AddressLabel2.TabIndex = 19
        Me.AddressLabel2.Text = "Ottawa, ON"
        '
        'PostalCodeText
        '
        Me.PostalCodeText.Location = New System.Drawing.Point(133, 190)
        Me.PostalCodeText.Name = "PostalCodeText"
        Me.PostalCodeText.Size = New System.Drawing.Size(52, 20)
        Me.PostalCodeText.TabIndex = 20
        Me.PostalCodeText.Text = "K2J 5S4"
        '
        'PC
        '
        Me.PC.AutoSize = True
        Me.PC.Font = New System.Drawing.Font("Myriad Pro Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PC.Location = New System.Drawing.Point(82, 189)
        Me.PC.Name = "PC"
        Me.PC.Size = New System.Drawing.Size(21, 19)
        Me.PC.TabIndex = 21
        Me.PC.Text = "PC"
        '
        'SubSubTitle_Lost
        '
        Me.SubSubTitle_Lost.AutoSize = True
        Me.SubSubTitle_Lost.Font = New System.Drawing.Font("Myriad Pro Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubSubTitle_Lost.Location = New System.Drawing.Point(129, 70)
        Me.SubSubTitle_Lost.Name = "SubSubTitle_Lost"
        Me.SubSubTitle_Lost.Size = New System.Drawing.Size(271, 19)
        Me.SubSubTitle_Lost.TabIndex = 22
        Me.SubSubTitle_Lost.Text = "Please do not change the listed personal information."
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Enabled = False
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Encrypted", "Important Info Enclosed", "No File Backup"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(86, 226)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(165, 49)
        Me.CheckedListBox1.TabIndex = 23
        '
        'IfFound
        '
        Me.IfFound.AutoSize = True
        Me.IfFound.Font = New System.Drawing.Font("Myriad Pro Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IfFound.Location = New System.Drawing.Point(270, 111)
        Me.IfFound.Name = "IfFound"
        Me.IfFound.Size = New System.Drawing.Size(49, 19)
        Me.IfFound.TabIndex = 24
        Me.IfFound.Text = "If Found"
        '
        'IfFoundText
        '
        Me.IfFoundText.AcceptsReturn = True
        Me.IfFoundText.Location = New System.Drawing.Point(274, 137)
        Me.IfFoundText.Multiline = True
        Me.IfFoundText.Name = "IfFoundText"
        Me.IfFoundText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.IfFoundText.Size = New System.Drawing.Size(158, 85)
        Me.IfFoundText.TabIndex = 25
        Me.IfFoundText.Text = "Please return to either my home address @ 303 Fergus Crescent, OR return to John " &
    "McCrae Secondary School. Thank you very much."
        '
        'Back
        '
        Me.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Back.Font = New System.Drawing.Font("Myriad Pro Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(273, 228)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 26)
        Me.Back.TabIndex = 26
        Me.Back.Text = "Return"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Email
        '
        Me.Email.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Email.Font = New System.Drawing.Font("Myriad Pro Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(357, 228)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(75, 26)
        Me.Email.TabIndex = 27
        Me.Email.Text = "Email Owner"
        Me.Email.UseVisualStyleBackColor = True
        '
        'DesignCredit
        '
        Me.DesignCredit.AutoSize = True
        Me.DesignCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesignCredit.Location = New System.Drawing.Point(278, 257)
        Me.DesignCredit.Name = "DesignCredit"
        Me.DesignCredit.Size = New System.Drawing.Size(150, 12)
        Me.DesignCredit.TabIndex = 28
        Me.DesignCredit.Text = "Software designed by Jiawen Deng"
        '
        'InformationVerificationInterval
        '
        Me.InformationVerificationInterval.Enabled = True
        Me.InformationVerificationInterval.Interval = 1000
        '
        'TestButton
        '
        Me.TestButton.Location = New System.Drawing.Point(273, 281)
        Me.TestButton.Name = "TestButton"
        Me.TestButton.Size = New System.Drawing.Size(158, 60)
        Me.TestButton.TabIndex = 29
        Me.TestButton.Text = "TEST BUTTON - NOT PRESENT IN RELEASE VERSION"
        Me.TestButton.UseVisualStyleBackColor = True
        '
        'Lost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(520, 300)
        Me.Controls.Add(Me.TestButton)
        Me.Controls.Add(Me.DesignCredit)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.IfFoundText)
        Me.Controls.Add(Me.IfFound)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.SubSubTitle_Lost)
        Me.Controls.Add(Me.PC)
        Me.Controls.Add(Me.PostalCodeText)
        Me.Controls.Add(Me.AddressLabel2)
        Me.Controls.Add(Me.AddressLabel1)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.NameText)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.Subtitle_Lost)
        Me.Controls.Add(Me.Title_Lost)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Lost"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lost USB Drive"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title_Lost As Label
    Friend WithEvents Subtitle_Lost As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents NameText As TextBox
    Friend WithEvents AddressLabel As Label
    Friend WithEvents AddressLabel1 As TextBox
    Friend WithEvents AddressLabel2 As TextBox
    Friend WithEvents PostalCodeText As TextBox
    Friend WithEvents PC As Label
    Friend WithEvents SubSubTitle_Lost As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents IfFound As Label
    Friend WithEvents IfFoundText As TextBox
    Friend WithEvents Back As Button
    Friend WithEvents Email As Button
    Friend WithEvents DesignCredit As Label
    Friend WithEvents InformationVerificationInterval As Timer
    Friend WithEvents TestButton As Button
End Class
