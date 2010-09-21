Public Class frmMain

    Private Sub btnClearOrderForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearOrderForm.Click
        'clearing the list box and text boxes
        lstInvoice.Items.Clear()
        txtAddress.Clear()
        txtCityStateZip.Clear()
        txtCustomerName.Clear()
        txtNumOfChairs.Clear()
        txtNumOfSofas.Clear()

    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        'the quit button
        Me.Close()

    End Sub

    Private Sub btnProcessOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessOrder.Click

    End Sub
End Class
