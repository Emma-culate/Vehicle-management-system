Public Class Form1
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If vehicleIDTextBox.Text = "" Or vehicleNameTextBox.Text = "" Or ModelTextBox.Text = "" Or OwnerTextBox.Text = "" Then
            MessageBox.Show("Fill all fields")
        Else
            DataGridView1.Rows.Add(vehicleIDTextBox.Text, vehicleNameTextBox.Text, ModelTextBox.Text, OwnerTextBox.Text)
            vehicleIDTextBox.Clear()
            vehicleNameTextBox.Clear()
            ModelTextBox.Clear()
            OwnerTextBox.Clear()
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        vehicleIDTextBox.Text = ""
        vehicleNameTextBox.Text = ""
        ModelTextBox.Text = ""
        OwnerTextBox.Text = ""
        vehicleIDTextBox.Focus()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete")
        Else
            DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
        End If
    End Sub
End Class