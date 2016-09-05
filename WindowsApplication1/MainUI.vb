Public Class MainUI

    Private Sub MainUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub InitializationTimer_Tick(sender As Object, e As EventArgs) Handles InitializationTimer.Tick
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
        MessageBox.Show("Please wait until the software finishes initialization, and then try again.", "Please Wait for Initialization")
    End Sub

    Private Sub True_Access_Data_Click(sender As Object, e As EventArgs) Handles True_Access_Date.Click
        If acct.Text <> "dengjiawen" Then
            If CounterTimer.Interval = 1 Then Attemptno.Show()
            If CounterTimer.Interval = 1 Then AttemptPH.Show()
            If CounterTimer.Interval < 3 Then Attemptno.Text = CounterTimer.Interval
            If CounterTimer.Interval = 3 Then Attemptno.Text = "3"
            If CounterTimer.Interval = 3 Then MessageBox.Show("unlockfailevent placeholder")
            If CounterTimer.Interval = 2 Then MessageBox.Show("You had entered an invalid account name or encryption key. Please verify the entered information and try again. You have 1 attempt left.", "Error")
            If CounterTimer.Interval = 1 Then MessageBox.Show("You had entered an invalid account name or encryption key. Please verify the entered information and try again. You have 2 attempts left.", "Error")
            If CounterTimer.Interval < 3 Then CounterTimer.Interval = CounterTimer.Interval + 1
        Else
            If key.Text <> "dengjiawen" Then
                If CounterTimer.Interval = 1 Then Attemptno.Show()
                If CounterTimer.Interval = 1 Then AttemptPH.Show()
                If CounterTimer.Interval < 3 Then Attemptno.Text = CounterTimer.Interval
                If CounterTimer.Interval = 3 Then Attemptno.Text = "3"
                If CounterTimer.Interval = 3 Then MessageBox.Show("unlockfailevent placeholder")
                If CounterTimer.Interval = 2 Then MessageBox.Show("You had entered an invalid account name or encryption key. Please verify the entered information and try again. You have 1 attempt left.", "Error")
                If CounterTimer.Interval = 1 Then MessageBox.Show("You had entered an invalid account name or encryption key. Please verify the entered information and try again. You have 2 attempts left.", "Error")
                If CounterTimer.Interval < 3 Then CounterTimer.Interval = CounterTimer.Interval + 1
            Else
                MessageBox.Show("Test Successful<Test Code>")
            End If
        End If

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub CounterTimer_Tick(sender As Object, e As EventArgs) Handles CounterTimer.Tick
        'Timer is used purely for interval counting purposes.'
    End Sub

    Private Sub Lost_USB_Click(sender As Object, e As EventArgs) Handles Lost_USB.Click
        Lost.Show()


    End Sub
End Class

