<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainUI))
        Me.Title_Encrypt = New System.Windows.Forms.Label()
        Me.USBIcon = New System.Windows.Forms.PictureBox()
        Me.Subtitle_Encrypt = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.InitializationProgress = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lost_USB = New System.Windows.Forms.Button()
        Me.SoftInfo = New System.Windows.Forms.Button()
        Me.InitializationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Initializing = New System.Windows.Forms.Label()
        Me.Processing = New System.Windows.Forms.Label()
        Me.Enp_Key = New System.Windows.Forms.Label()
        Me.Clean_Up = New System.Windows.Forms.Label()
        Me.acct = New System.Windows.Forms.TextBox()
        Me.key = New System.Windows.Forms.TextBox()
        Me.AcctLabel = New System.Windows.Forms.Label()
        Me.KeyLabel = New System.Windows.Forms.Label()
        Me.False_Access_Data = New System.Windows.Forms.Button()
        Me.Auto_Decrypt = New System.Windows.Forms.CheckBox()
        Me.CounterTimer = New System.Windows.Forms.Timer(Me.components)
        Me.True_Access_Date = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AttemptPH = New System.Windows.Forms.Label()
        Me.Attemptno = New System.Windows.Forms.Label()
        CType(Me.USBIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title_Encrypt
        '
        Me.Title_Encrypt.AutoSize = True
        Me.Title_Encrypt.Font = New System.Drawing.Font("Myriad Pro Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title_Encrypt.Location = New System.Drawing.Point(243, 66)
        Me.Title_Encrypt.Name = "Title_Encrypt"
        Me.Title_Encrypt.Size = New System.Drawing.Size(192, 28)
        Me.Title_Encrypt.TabIndex = 0
        Me.Title_Encrypt.Text = "This Device is Encrypted."
        '
        'USBIcon
        '
        Me.USBIcon.Image = CType(resources.GetObject("USBIcon.Image"), System.Drawing.Image)
        Me.USBIcon.Location = New System.Drawing.Point(12, 53)
        Me.USBIcon.Name = "USBIcon"
        Me.USBIcon.Size = New System.Drawing.Size(200, 260)
        Me.USBIcon.TabIndex = 1
        Me.USBIcon.TabStop = False
        '
        'Subtitle_Encrypt
        '
        Me.Subtitle_Encrypt.AutoSize = True
        Me.Subtitle_Encrypt.Font = New System.Drawing.Font("Myriad Pro Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subtitle_Encrypt.Location = New System.Drawing.Point(244, 91)
        Me.Subtitle_Encrypt.Name = "Subtitle_Encrypt"
        Me.Subtitle_Encrypt.Size = New System.Drawing.Size(247, 19)
        Me.Subtitle_Encrypt.TabIndex = 2
        Me.Subtitle_Encrypt.Text = "Please unlock this USB device before continuing."
        '
        'Cancel
        '
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Myriad Pro Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(329, 229)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 26)
        Me.Cancel.TabIndex = 3
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'InitializationProgress
        '
        Me.InitializationProgress.Location = New System.Drawing.Point(248, 181)
        Me.InitializationProgress.Name = "InitializationProgress"
        Me.InitializationProgress.Size = New System.Drawing.Size(243, 23)
        Me.InitializationProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.InitializationProgress.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Myriad Pro Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(244, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Analyzing Encrypted Files..."
        '
        'Lost_USB
        '
        Me.Lost_USB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lost_USB.Font = New System.Drawing.Font("Myriad Pro Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lost_USB.Location = New System.Drawing.Point(246, 261)
        Me.Lost_USB.Name = "Lost_USB"
        Me.Lost_USB.Size = New System.Drawing.Size(243, 26)
        Me.Lost_USB.TabIndex = 6
        Me.Lost_USB.Text = "View USB Owner Information (If USB is Lost)"
        Me.Lost_USB.UseVisualStyleBackColor = True
        '
        'SoftInfo
        '
        Me.SoftInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SoftInfo.Font = New System.Drawing.Font("Myriad Pro Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoftInfo.Location = New System.Drawing.Point(410, 229)
        Me.SoftInfo.Name = "SoftInfo"
        Me.SoftInfo.Size = New System.Drawing.Size(79, 26)
        Me.SoftInfo.TabIndex = 7
        Me.SoftInfo.Text = "Software Info"
        Me.SoftInfo.UseVisualStyleBackColor = True
        '
        'InitializationTimer
        '
        Me.InitializationTimer.Enabled = True
        '
        'Initializing
        '
        Me.Initializing.AutoSize = True
        Me.Initializing.Font = New System.Drawing.Font("Myriad Pro Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Initializing.Location = New System.Drawing.Point(244, 148)
        Me.Initializing.Name = "Initializing"
        Me.Initializing.Size = New System.Drawing.Size(69, 19)
        Me.Initializing.TabIndex = 8
        Me.Initializing.Text = "Initializing..."
        '
        'Processing
        '
        Me.Processing.AutoSize = True
        Me.Processing.Font = New System.Drawing.Font("Myriad Pro Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Processing.Location = New System.Drawing.Point(244, 148)
        Me.Processing.Name = "Processing"
        Me.Processing.Size = New System.Drawing.Size(70, 19)
        Me.Processing.TabIndex = 9
        Me.Processing.Text = "Processing..."
        '
        'Enp_Key
        '
        Me.Enp_Key.AutoSize = True
        Me.Enp_Key.Font = New System.Drawing.Font("Myriad Pro Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enp_Key.Location = New System.Drawing.Point(244, 148)
        Me.Enp_Key.Name = "Enp_Key"
        Me.Enp_Key.Size = New System.Drawing.Size(132, 19)
        Me.Enp_Key.TabIndex = 10
        Me.Enp_Key.Text = "Loading Encryption Key..."
        '
        'Clean_Up
        '
        Me.Clean_Up.AutoSize = True
        Me.Clean_Up.Font = New System.Drawing.Font("Myriad Pro Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clean_Up.Location = New System.Drawing.Point(244, 148)
        Me.Clean_Up.Name = "Clean_Up"
        Me.Clean_Up.Size = New System.Drawing.Size(75, 19)
        Me.Clean_Up.TabIndex = 11
        Me.Clean_Up.Text = "Cleaning Up..."
        '
        'acct
        '
        Me.acct.Location = New System.Drawing.Point(305, 137)
        Me.acct.Name = "acct"
        Me.acct.Size = New System.Drawing.Size(170, 20)
        Me.acct.TabIndex = 12
        '
        'key
        '
        Me.key.Location = New System.Drawing.Point(305, 167)
        Me.key.Name = "key"
        Me.key.Size = New System.Drawing.Size(170, 20)
        Me.key.TabIndex = 13
        '
        'AcctLabel
        '
        Me.AcctLabel.AutoSize = True
        Me.AcctLabel.Font = New System.Drawing.Font("Myriad Pro Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcctLabel.Location = New System.Drawing.Point(244, 138)
        Me.AcctLabel.Name = "AcctLabel"
        Me.AcctLabel.Size = New System.Drawing.Size(33, 19)
        Me.AcctLabel.TabIndex = 14
        Me.AcctLabel.Text = "Acct:"
        '
        'KeyLabel
        '
        Me.KeyLabel.AutoSize = True
        Me.KeyLabel.Font = New System.Drawing.Font("Myriad Pro Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyLabel.Location = New System.Drawing.Point(244, 168)
        Me.KeyLabel.Name = "KeyLabel"
        Me.KeyLabel.Size = New System.Drawing.Size(30, 19)
        Me.KeyLabel.TabIndex = 15
        Me.KeyLabel.Text = "Key:"
        '
        'False_Access_Data
        '
        Me.False_Access_Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.False_Access_Data.Font = New System.Drawing.Font("Myriad Pro Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.False_Access_Data.Location = New System.Drawing.Point(248, 229)
        Me.False_Access_Data.Name = "False_Access_Data"
        Me.False_Access_Data.Size = New System.Drawing.Size(75, 26)
        Me.False_Access_Data.TabIndex = 16
        Me.False_Access_Data.Text = "Access Data"
        Me.False_Access_Data.UseVisualStyleBackColor = True
        '
        'Auto_Decrypt
        '
        Me.Auto_Decrypt.AutoSize = True
        Me.Auto_Decrypt.Location = New System.Drawing.Point(248, 197)
        Me.Auto_Decrypt.Name = "Auto_Decrypt"
        Me.Auto_Decrypt.Size = New System.Drawing.Size(165, 17)
        Me.Auto_Decrypt.TabIndex = 17
        Me.Auto_Decrypt.Text = "Automatically Decrypt Device"
        Me.Auto_Decrypt.UseVisualStyleBackColor = True
        '
        'CounterTimer
        '
        Me.CounterTimer.Interval = 1
        '
        'True_Access_Date
        '
        Me.True_Access_Date.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.True_Access_Date.Font = New System.Drawing.Font("Myriad Pro Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.True_Access_Date.Location = New System.Drawing.Point(248, 229)
        Me.True_Access_Date.Name = "True_Access_Date"
        Me.True_Access_Date.Size = New System.Drawing.Size(75, 26)
        Me.True_Access_Date.TabIndex = 19
        Me.True_Access_Date.Text = "Access Data"
        Me.True_Access_Date.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(264, 333)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Alpha Release 0.0.2.160905-ae/sc"
        '
        'AttemptPH
        '
        Me.AttemptPH.AutoSize = True
        Me.AttemptPH.Font = New System.Drawing.Font("Myriad Pro Cond", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttemptPH.Location = New System.Drawing.Point(254, 291)
        Me.AttemptPH.Name = "AttemptPH"
        Me.AttemptPH.Size = New System.Drawing.Size(224, 14)
        Me.AttemptPH.TabIndex = 21
        Me.AttemptPH.Text = "You had attempted to unlock the USB drive       Times"
        '
        'Attemptno
        '
        Me.Attemptno.AutoSize = True
        Me.Attemptno.ForeColor = System.Drawing.Color.Red
        Me.Attemptno.Location = New System.Drawing.Point(435, 291)
        Me.Attemptno.Name = "Attemptno"
        Me.Attemptno.Size = New System.Drawing.Size(13, 13)
        Me.Attemptno.TabIndex = 22
        Me.Attemptno.Text = "1"
        '
        'MainUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(566, 368)
        Me.ControlBox = False
        Me.Controls.Add(Me.Attemptno)
        Me.Controls.Add(Me.AttemptPH)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.True_Access_Date)
        Me.Controls.Add(Me.Auto_Decrypt)
        Me.Controls.Add(Me.False_Access_Data)
        Me.Controls.Add(Me.KeyLabel)
        Me.Controls.Add(Me.AcctLabel)
        Me.Controls.Add(Me.key)
        Me.Controls.Add(Me.acct)
        Me.Controls.Add(Me.Clean_Up)
        Me.Controls.Add(Me.Enp_Key)
        Me.Controls.Add(Me.Processing)
        Me.Controls.Add(Me.Initializing)
        Me.Controls.Add(Me.SoftInfo)
        Me.Controls.Add(Me.Lost_USB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.InitializationProgress)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Subtitle_Encrypt)
        Me.Controls.Add(Me.USBIcon)
        Me.Controls.Add(Me.Title_Encrypt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainUI"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encrypted Device"
        Me.TopMost = True
        CType(Me.USBIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title_Encrypt As Label
    Friend WithEvents USBIcon As PictureBox
    Friend WithEvents Subtitle_Encrypt As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents InitializationProgress As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Lost_USB As Button
    Friend WithEvents SoftInfo As Button
    Friend WithEvents InitializationTimer As Timer
    Friend WithEvents Initializing As Label
    Friend WithEvents Processing As Label
    Friend WithEvents Enp_Key As Label
    Friend WithEvents Clean_Up As Label
    Friend WithEvents acct As TextBox
    Friend WithEvents KeyLabel As Label
    Friend WithEvents AcctLabel As Label
    Friend WithEvents key As TextBox
    Friend WithEvents False_Access_Data As Button
    Friend WithEvents Auto_Decrypt As CheckBox
    Friend WithEvents CounterTimer As Timer
    Friend WithEvents True_Access_Date As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents AttemptPH As Label
    Friend WithEvents Attemptno As Label
End Class
