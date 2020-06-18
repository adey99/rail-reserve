Public Class Form1
    Private Sub Reservation_TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Reservation_TableBindingNavigatorSaveItem.Click
        Validate()
        Me.Reservation_TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Railway_ReservationDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Railway_ReservationDataSet.Reservation_Table' table. You can move, or remove it, as needed.
        Me.Reservation_TableTableAdapter.Fill(Me.Railway_ReservationDataSet.Reservation_Table)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            GenderTextBox.Text = RadioButton1.Text
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            GenderTextBox.Text = RadioButton2.Text
        End If
    End Sub

    Private Sub Reservation_TableBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles Reservation_TableBindingNavigator.RefreshItems
        If GenderTextBox.Text = RadioButton1.Text Then
            RadioButton1.Checked = True
            RadioButton2.Checked = False
        ElseIf GenderTextBox.Text = RadioButton2.Text Then
            RadioButton1.Checked = False
            RadioButton2.Checked = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pnr_num As Long
        Try
            pnr_num = Int(((999999 - 100000 + 1) * Rnd()) + 100000)
            Randomize()
            PNR_NumberTextBox.Text = pnr_num
            Select Case Train_NumberTextBox.Text
                Case 44832
                    Ticket_PriceTextBox.Text = 700
                Case 12376
                    Ticket_PriceTextBox.Text = 2000
                Case 33356
                    Ticket_PriceTextBox.Text = 1700
                Case 45467
                    Ticket_PriceTextBox.Text = 900
                Case Else
                    Ticket_PriceTextBox.Text = 1000
            End Select
            Reservation_TableBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Railway_ReservationDataSet)
            MsgBox("Reservation Successful")
        Catch ex As Exception
            MsgBox("Error Ocurred,Recheck the fields and try again")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Reservation_TableBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(Railway_ReservationDataSet)
        MsgBox("Current Record Deleted")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Reservation_TableBindingSource.AddNew()
        RadioButton1.Checked = True
    End Sub
End Class
