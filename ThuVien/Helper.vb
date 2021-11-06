Public Module Helper
    Public Sub ValidateInput(control As Control, e As System.ComponentModel.CancelEventArgs, errProvider As ErrorProvider, expectedType As String, errMsg As String)
        Dim validInput As Boolean = True
        Dim number As Integer = 0
        If TypeOf control Is TextBox Then
            Dim txtInput As TextBox = control
            If String.IsNullOrEmpty(txtInput.Text.Trim) Then
                validInput = False
            ElseIf expectedType = "int" And (Integer.TryParse(txtInput.Text.Trim, number) = False Or number <= 0) Then
                validInput = False
            End If
        ElseIf TypeOf control Is ComboBox Then
            Dim cbBox As ComboBox = control
            If cbBox.SelectedIndex <= 0 Then
                validInput = False
            End If
        ElseIf TypeOf control Is NumericUpDown Then
            Dim min As Integer = 0
            If expectedType IsNot "" Then
                min = Integer.Parse(expectedType)
            End If

            Dim num As NumericUpDown = control
            If num.Value <= 0 Or num.Value < min Then
                validInput = False
            End If
        ElseIf TypeOf control Is DataGridView Then
            Dim dtGridView As DataGridView = control
            If dtGridView.RowCount() <= 0 Then
                validInput = False
            End If
        End If


        If validInput = False Then
            e.Cancel = True

            If TypeOf control IsNot DataGridView Then
                control.Focus()
            Else
                ShowErrorDialog(errMsg, "Thông báo", MessageBoxIcon.Error)
            End If

            errProvider.SetError(control, errMsg)
        Else
            e.Cancel = False
            errProvider.SetError(control, Nothing)
        End If

    End Sub


    Function ShowErrorDialog(message As String, dialogTitle As String, messageBoxIcon As MessageBoxIcon) As Boolean
        Dim dialogResult As DialogResult = MessageBox.Show(message, dialogTitle, MessageBoxButtons.OK, messageBoxIcon, MessageBoxDefaultButton.Button1)
        Return dialogResult = DialogResult.Yes
    End Function

    Function ShowDialog(message As String, dialogTitle As String, messageBoxIcon As MessageBoxIcon) As Boolean
        Dim dialogResult As DialogResult = MessageBox.Show(message, dialogTitle, MessageBoxButtons.YesNo, messageBoxIcon, MessageBoxDefaultButton.Button2)
        Return dialogResult = DialogResult.Yes
    End Function
End Module
