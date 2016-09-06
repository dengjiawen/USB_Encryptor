
'This is the decryption portion of the USB Encryptor project.'
'Users should have this software on their USB Drive and adding it to their autorun.inf file, so this software is able to run automatically once the USB is plugged in.'
'This is only a UI demonstration. No forms of encryption will be done to your files. That functionality simply do not exist.'
'P.S. Daren Liang, I like Apple better then Microsoft. Suck it up.'
'Also, just so you know, my crush in FHS is 01010011 01111001 01100100 01101110 01100101 01111001 00100000 01000011 01110010 01100001 01101001 01101110.'

Public Class MainUI

    Private Sub MainUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The main User Interface will now be loaded.'
        'The following are elements that are not required in this stage of initialization.'
        'To make it easier for users to navegate the software, the following entities will be disabled.'
        'The reason why I didn't use multiple forms is because I ended up with a program that used over 100 megabytes of RAM because I had over 10 forms. So now I only use one.'
        'Again, my crush is 01010011 01111001 01100100 01101110 01100101 01111001 00100000 01000011 01110010 01100001 01101001 01101110. Just solve the mystry and post it on FB please.'

        Initializing.Hide()
        Processing.Hide()
        Enp_Key.Hide()
        Clean_Up.Hide()
        acct.Hide()
        key.Hide()
        AcctLabel.Hide()
        KeyLabel.Hide()
        True_Access_Date.Hide()
        Auto_Decrypt.Hide()
        Attemptno.Hide()
        AttemptPH.Hide()

    End Sub


    Private Sub frmcalculator_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call True_Access_Data_Click(sender, e)
        End If
    End Sub


    Private Sub InitializationTimer_Tick(sender As Object, e As EventArgs) Handles InitializationTimer.Tick

        'This timer setting controls which text will appear during different stages of initialization.'
        'For example, when the loading is 50% done, the original "Analyzing Encrypted Files" will change to "Initializng".'
        'This, along with the progress bar which is also controlled by this timer entity,'
        'provides no additional function, and is only for cosmetic purposes.'

        InitializationProgress.Maximum = 200
        InitializationProgress.Value = InitializationProgress.Value + 2
        If InitializationProgress.Value = 90 Then
            Label2.Hide()
            Initializing.Show()
        End If

        If InitializationProgress.Value = 150 Then
            Initializing.Hide()
            Processing.Show()
        End If

        If InitializationProgress.Value = 175 Then
            Processing.Hide()
            Enp_Key.Show()
        End If

        If InitializationProgress.Value = 180 Then
            Enp_Key.Hide()
            Clean_Up.Show()
        End If

        If InitializationProgress.Value = 200 Then

            'When the "initialization" is completed, the software will hide all elements that are not required in the next stage of software utilization'
            'for example, the progress bar. It will hide all unused elements, and will display the useful elements, for example, the login textboxes.'
            'It will also replace the fake "Access Data" button for a real, functional one, which will verify the login information.'

            InitializationTimer.Enabled = False
            Initializing.Hide()
            Processing.Hide()
            Enp_Key.Hide()
            Clean_Up.Hide()
            InitializationProgress.Hide()
            acct.Show()
            key.Show()
            AcctLabel.Show()
            KeyLabel.Show()
            False_Access_Data.Show()
            Auto_Decrypt.Show()
            False_Access_Data.Hide()
            True_Access_Date.Show()
        End If

    End Sub

    Private Sub False_Access_Data_Click(sender As Object, e As EventArgs) Handles False_Access_Data.Click

        'This is the fake "Access Data" button. The user is not supposed to be able to access data until the initialization process had been completed.'

        MessageBox.Show("Please wait until the software finishes initialization, and then try again.", "Please Wait for Initialization")
    End Sub

    Private Sub True_Access_Data_Click(sender As Object, e As EventArgs) Handles True_Access_Date.Click

        'When the real access data button is pressed, the software will examine the data entered in the textboxes.'
        'If they do not match the testing acct name and key, which is "dengjiawen", the user will be rejected access.'
        'Since VB's counter plugin is extremely difficult to use, I had instead, used the "Interval" value for a timer to act as a counter.'
        'Every wrong attempt will add 1 value to the Interval value, therefore the timer will count up.'
        'Apart from that, the timer "CounterTimer' have no other uses.'
        'If 3 incorrect logins are detected, the software will shut down the computer.'

        If acct.Text <> "dengjiawen" Then
            If CounterTimer.Interval = 1 Then Attemptno.Show()
            If CounterTimer.Interval = 1 Then AttemptPH.Show()
            If CounterTimer.Interval < 3 Then Attemptno.Text = CounterTimer.Interval
            If CounterTimer.Interval = 3 Then Attemptno.Text = "3"
            If CounterTimer.Interval = 3 Then MessageBox.Show("3 attempts placeholder")
            If CounterTimer.Interval = 3 Then Process.Start("cmd", "/k shutdown -r -t 10 -c ""An unauthorized access to a USB device had been detected. To protect the contents of the USB device, it will be disconnected, and your computer will now restart in 10 seconds.""")
            If CounterTimer.Interval = 2 Then MessageBox.Show("You had entered an invalid account name or encryption key. Please verify the entered information and try again. You have 1 attempt left.", "Error")
            If CounterTimer.Interval = 1 Then MessageBox.Show("You had entered an invalid account name or encryption key. Please verify the entered information and try again. You have 2 attempts left.", "Error")
            If CounterTimer.Interval < 3 Then CounterTimer.Interval = CounterTimer.Interval + 1
        Else
            If key.Text <> "dengjiawen" Then
                If CounterTimer.Interval = 1 Then Attemptno.Show()
                If CounterTimer.Interval = 1 Then AttemptPH.Show()
                If CounterTimer.Interval < 3 Then Attemptno.Text = CounterTimer.Interval
                If CounterTimer.Interval = 3 Then Attemptno.Text = "3"
                If CounterTimer.Interval = 3 Then MessageBox.Show("3 attempts placeholder")
                If CounterTimer.Interval = 3 Then Process.Start("cmd", "/k shutdown -r -t 10 -c ""An unauthorized access to a USB device had been detected. To protect the contents of the USB device, it will be disconnected, and your computer will now restart in 10 seconds.""")
                If CounterTimer.Interval = 2 Then MessageBox.Show("You had entered an invalid account name or encryption key. Please verify the entered information and try again. You have 1 attempt left.", "Error")
                If CounterTimer.Interval = 1 Then MessageBox.Show("You had entered an invalid account name or encryption key. Please verify the entered information and try again. You have 2 attempts left.", "Error")
                If CounterTimer.Interval < 3 Then CounterTimer.Interval = CounterTimer.Interval + 1
            Else
                MessageBox.Show("Test Successful<Test Code>")
            End If
        End If

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click

        'This is the cancel button.'
        'Again, my crush in Fredericton High School 01010011 01111001 01100100 01101110 01100101 01111001 00100000 01000011 01110010 01100001 01101001 01101110.'

        End
    End Sub

    Private Sub CounterTimer_Tick(sender As Object, e As EventArgs) Handles CounterTimer.Tick
        'Timer is used purely for interval counting purposes.'
        'Do not use this entity for any other purposes.'
    End Sub

    Private Sub Lost_USB_Click(sender As Object, e As EventArgs) Handles Lost_USB.Click
        Lost.Show()

        'This button simply opens up the lost USB page.'

    End Sub
End Class

