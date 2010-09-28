Public Class frmMain
    Private Function InvoiceNum() As String
        'makeing the invoice number
        Dim intNum As Integer = txtCityStateZip.Text.IndexOf(",")
        Dim strZip As String = txtCityStateZip.Text.Substring(intNum + 6)
        Dim strInvoiceNumber As String = (txtCustomerName.Text.Substring(0, 2).ToUpper) & strZip
        Return strInvoiceNumber
    End Function

    Private Function Last() As String
        'Putting the last name into its own variable
        Dim intName As Integer = txtCustomerName.Text.IndexOf(",")
        Dim strLastName As String = txtCustomerName.Text.Substring(0, intName)
        Return strLastName
    End Function

    Private Function First() As String
        'Putting the first name into it's own variable
        Dim intName As Integer = txtCustomerName.Text.IndexOf(",")
        Dim strFirstName As String = txtCustomerName.Text.Substring(intName + 2)
        Return strFirstName
    End Function

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
        'printing the invoice in the list box variables
        Dim reader As IO.StreamReader = IO.File.OpenText("..\..\PriceAndTaxData.txt")
        Dim dblChair As Double = CDbl(reader.ReadLine)
        Dim dblSofa As Double = CDbl(reader.ReadLine)
        Dim dblTaxAmount As Double = CDbl(reader.ReadLine)
        Dim fmtStr As String = "{0, 15}{1, 15}"
        Dim dblCost, dblTax, dblTotalCost As Double

        'calling the functions made
        Dim strFirstName As String = First()
        Dim strLastName As String = Last()
        Dim strInvoiceNumber As String = InvoiceNum()

        'calculations
        dblCost = (CInt(txtNumOfChairs.Text) * dblChair) + (CInt(txtNumOfSofas.Text) * dblSofa)
        dblTax = dblCost * dblTaxAmount
        dblTotalCost = dblCost + dblTax
        'output
        lstInvoice.Items.Add("Invoice Number: " & strInvoiceNumber)
        lstInvoice.Items.Add("")
        lstInvoice.Items.Add("Name: " & strFirstName & " " & strLastName)
        lstInvoice.Items.Add("Address: " & txtAddress.Text)
        lstInvoice.Items.Add("City: " & txtCityStateZip.Text)
        lstInvoice.Items.Add("")
        lstInvoice.Items.Add(String.Format(fmtStr, "Cost:", FormatCurrency(dblCost)))
        lstInvoice.Items.Add(String.Format(fmtStr, "Sales Tax:", FormatCurrency(dblTax)))
        lstInvoice.Items.Add(String.Format(fmtStr, "", "------------"))
        lstInvoice.Items.Add(String.Format(fmtStr, "Total Cost:", FormatCurrency(dblTotalCost)))


    End Sub
End Class
