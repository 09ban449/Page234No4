<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblCitySateZip = New System.Windows.Forms.Label()
        Me.txtCityStateZip = New System.Windows.Forms.TextBox()
        Me.lblNumOfChairs = New System.Windows.Forms.Label()
        Me.txtNumOfChairs = New System.Windows.Forms.TextBox()
        Me.lblNumOfSofas = New System.Windows.Forms.Label()
        Me.txtNumOfSofas = New System.Windows.Forms.TextBox()
        Me.btnProcessOrder = New System.Windows.Forms.Button()
        Me.btnClearOrderForm = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lstInvoice = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(13, 13)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(83, 26)
        Me.lblCustomerName.TabIndex = 0
        Me.lblCustomerName.Text = "Customer name:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Last, First)"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(102, 13)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(154, 20)
        Me.txtCustomerName.TabIndex = 1
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(48, 56)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(102, 53)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(154, 20)
        Me.txtAddress.TabIndex = 3
        '
        'lblCitySateZip
        '
        Me.lblCitySateZip.AutoSize = True
        Me.lblCitySateZip.Location = New System.Drawing.Point(17, 96)
        Me.lblCitySateZip.Name = "lblCitySateZip"
        Me.lblCitySateZip.Size = New System.Drawing.Size(79, 13)
        Me.lblCitySateZip.TabIndex = 4
        Me.lblCitySateZip.Text = "City, State, Zip:"
        '
        'txtCityStateZip
        '
        Me.txtCityStateZip.Location = New System.Drawing.Point(102, 93)
        Me.txtCityStateZip.Name = "txtCityStateZip"
        Me.txtCityStateZip.Size = New System.Drawing.Size(154, 20)
        Me.txtCityStateZip.TabIndex = 5
        '
        'lblNumOfChairs
        '
        Me.lblNumOfChairs.AutoSize = True
        Me.lblNumOfChairs.Location = New System.Drawing.Point(19, 129)
        Me.lblNumOfChairs.Name = "lblNumOfChairs"
        Me.lblNumOfChairs.Size = New System.Drawing.Size(77, 26)
        Me.lblNumOfChairs.TabIndex = 6
        Me.lblNumOfChairs.Text = "Number of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "chairs ordered:"
        '
        'txtNumOfChairs
        '
        Me.txtNumOfChairs.Location = New System.Drawing.Point(102, 135)
        Me.txtNumOfChairs.Name = "txtNumOfChairs"
        Me.txtNumOfChairs.Size = New System.Drawing.Size(43, 20)
        Me.txtNumOfChairs.TabIndex = 7
        '
        'lblNumOfSofas
        '
        Me.lblNumOfSofas.AutoSize = True
        Me.lblNumOfSofas.Location = New System.Drawing.Point(22, 169)
        Me.lblNumOfSofas.Name = "lblNumOfSofas"
        Me.lblNumOfSofas.Size = New System.Drawing.Size(74, 26)
        Me.lblNumOfSofas.TabIndex = 8
        Me.lblNumOfSofas.Text = "Number of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sofas ordered:"
        '
        'txtNumOfSofas
        '
        Me.txtNumOfSofas.Location = New System.Drawing.Point(102, 175)
        Me.txtNumOfSofas.Name = "txtNumOfSofas"
        Me.txtNumOfSofas.Size = New System.Drawing.Size(43, 20)
        Me.txtNumOfSofas.TabIndex = 9
        '
        'btnProcessOrder
        '
        Me.btnProcessOrder.Location = New System.Drawing.Point(25, 203)
        Me.btnProcessOrder.Name = "btnProcessOrder"
        Me.btnProcessOrder.Size = New System.Drawing.Size(147, 23)
        Me.btnProcessOrder.TabIndex = 10
        Me.btnProcessOrder.Text = "Process Order"
        Me.btnProcessOrder.UseVisualStyleBackColor = True
        '
        'btnClearOrderForm
        '
        Me.btnClearOrderForm.Location = New System.Drawing.Point(191, 203)
        Me.btnClearOrderForm.Name = "btnClearOrderForm"
        Me.btnClearOrderForm.Size = New System.Drawing.Size(147, 23)
        Me.btnClearOrderForm.TabIndex = 11
        Me.btnClearOrderForm.Text = "Clear Order Form"
        Me.btnClearOrderForm.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(354, 203)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(147, 23)
        Me.btnQuit.TabIndex = 12
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lstInvoice
        '
        Me.lstInvoice.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInvoice.FormattingEnabled = True
        Me.lstInvoice.ItemHeight = 14
        Me.lstInvoice.Location = New System.Drawing.Point(263, 13)
        Me.lstInvoice.Name = "lstInvoice"
        Me.lstInvoice.Size = New System.Drawing.Size(247, 172)
        Me.lstInvoice.TabIndex = 13
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 238)
        Me.Controls.Add(Me.lstInvoice)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnClearOrderForm)
        Me.Controls.Add(Me.btnProcessOrder)
        Me.Controls.Add(Me.txtNumOfSofas)
        Me.Controls.Add(Me.lblNumOfSofas)
        Me.Controls.Add(Me.txtNumOfChairs)
        Me.Controls.Add(Me.lblNumOfChairs)
        Me.Controls.Add(Me.txtCityStateZip)
        Me.Controls.Add(Me.lblCitySateZip)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Name = "frmMain"
        Me.Text = "Furniture Order Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblCitySateZip As System.Windows.Forms.Label
    Friend WithEvents txtCityStateZip As System.Windows.Forms.TextBox
    Friend WithEvents lblNumOfChairs As System.Windows.Forms.Label
    Friend WithEvents txtNumOfChairs As System.Windows.Forms.TextBox
    Friend WithEvents lblNumOfSofas As System.Windows.Forms.Label
    Friend WithEvents txtNumOfSofas As System.Windows.Forms.TextBox
    Friend WithEvents btnProcessOrder As System.Windows.Forms.Button
    Friend WithEvents btnClearOrderForm As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lstInvoice As System.Windows.Forms.ListBox

End Class
