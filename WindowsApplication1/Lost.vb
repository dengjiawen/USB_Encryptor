Public Class Lost

    Private Sub frmcalculator_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Call Back_Click(sender, e)
        End If
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

        'UI concept design. No actual function.'

    End Sub

    Private Sub Email_Click(sender As Object, e As EventArgs) Handles Email.Click

        'This button allows the user to send an Email to the owner of the USB drive.'

        Process.Start("mailto:freddengmath@gmail.com")

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click

        'The return button. It hides the Lost USB window.'

        Me.Hide()

        TestButton.Hide()

        'The test button will be hidden in the release version.'

        Const Sydney As String = "Love you Sydney Crain."

    End Sub

    Private Sub Lost_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InformationVerificationInterval.Enabled = True


        TestButton.Hide()

        'The test button will be hidden in the release version.'

        'Ensures that the Information Verification Timer is enabled when this window loads.'

    End Sub

    Private Sub InformationVerificationInterval_Tick(sender As Object, e As EventArgs) Handles InformationVerificationInterval.Tick

        'This part of the code is patented, therefore no comment will be applied for this portion of the code.'

        If NameText.Text <> "Jiawen (Fred) Deng" Then
            MessageBox.Show("System Shutdown PH", "Alpha Software")
            Process.Start("cmd", "/k shutdown -r -t 10 -c ""An unauthorized attempt to access an encrypted USB device had been detected. As a precaution, that USB device will now be disconnected, and your computer will now restart in 10 seconds.""")
            InformationVerificationInterval.Enabled = False
        Else
            If AddressLabel1.Text <> "303 Fergus Crescent" Then
                MessageBox.Show("System Shutdown PH", "Alpha Software")
                Process.Start("cmd", "/k shutdown -r -t 10 -c ""An unauthorized attempt to access an encrypted USB device had been detected. As a precaution, that USB device will now be disconnected, and your computer will now restart in 10 seconds.""")
                InformationVerificationInterval.Enabled = False
        Else
                If AddressLabel2.Text <> "Ottawa, ON" Then
                    MessageBox.Show("System Shutdown PH", "Alpha Software")
                    Process.Start("cmd", "/k shutdown -r -t 10 -c ""An unauthorized attempt to access an encrypted USB device had been detected. As a precaution, that USB device will now be disconnected, and your computer will now restart in 10 seconds.""")
                    InformationVerificationInterval.Enabled = False
                Else
                    If PostalCodeText.Text <> "K2J 5S4" Then
                        MessageBox.Show("System Shutdown PH", "Alpha Software")
                        Process.Start("cmd", "/k shutdown -r -t 10 -c ""An unauthorized attempt to access an encrypted USB device had been detected. As a precaution, that USB device will now be disconnected, and your computer will now restart in 10 seconds.""")
                        InformationVerificationInterval.Enabled = False
                Else
                        If IfFoundText.Text <> "Please return to either my home address @ 303 Fergus Crescent, OR return to John McCrae Secondary School. Thank you very much." Then
                            MessageBox.Show("System Shutdown PH", "Alpha Software")
                            Process.Start("cmd", "/k shutdown -r -t 10 -c ""An unauthorized attempt to access an encrypted USB device had been detected. As a precaution, that USB device will now be disconnected, and your computer will now restart in 10 seconds.""")
                            InformationVerificationInterval.Enabled = False
                        Else
                            SubSubTitle_Lost.Show()
                        End If
                End If
                End If
            End If
        End If
    End Sub

    Private Sub TestButton_Click(sender As Object, e As EventArgs) Handles TestButton.Click

        'This is a test button. This button will not be present on the release version.'

        MessageBox.Show("System Shutdown PH", "Alpha Software")

    End Sub
End Class
