Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txtQty.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblResName.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblResTotal.Click

    End Sub

    Private Sub lblCostumer_Click(sender As Object, e As EventArgs) Handles lblCostumer.Click

    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click


        If txtName.Text = "" Then

            MessageBox.Show("Please input your name.")
            Exit Sub

        End If

        If txtQty.Text = "" Then

            MessageBox.Show("Please enter amount.")
            Exit Sub

        End If

        If Not IsNumeric(txtQty.Text) Then
            MessageBox.Show("Please properly the amount you want.")
            Exit Sub
        End If


        If Val(txtQty.Text) <= 0 Then
            MessageBox.Show("Please properly your name.")
            Exit Sub

        End If



        Dim cupPrice As Integer
        Dim quantity As Integer
        Dim addOns As Integer
        Dim price As Integer
        Dim total As Integer

        quantity = Val(txtQty.Text)



        If rbSmall.Checked Then
            cupPrice = 49
            lblSize.Text = "Small"

        ElseIf rbMedium.Checked Then
            cupPrice = 69
            lblSize.Text = "Medium"

        ElseIf rbLarge.Checked Then
            cupPrice = 89
            lblSize.Text = "Large"

        End If

        If rbNone.Checked Then
            addOns = 0
            lblAddon.Text = "None"

        ElseIf rbNata.Checked Then
            addOns = 10
            lblAddon.Text = "Nata de coco"

        ElseIf rbPearl.Checked Then
            addOns = 10
            lblAddon.Text = "Pearl"

        ElseIf rbCheese.Checked Then
            addOns = 20
            lblAddon.Text = "Cream Cheese"

        End If

        price = cupPrice + addOns
        total = price * quantity

        lblCostumer.Text = txtName.Text
        lblQuantity.Text = txtQty.Text
        lblUnitprice.Text = "Php " & price
        lblTotprice.Text = "Php " & total

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtName.Clear()
        txtQty.Clear()

        rbSmall.Checked = False
        rbMedium.Checked = False
        rbLarge.Checked = False
        rbNone.Checked = False
        rbNata.Checked = False
        rbCheese.Checked = False
        rbPearl.Checked = False



        lblAddon.Text = ""
        lblCostumer.Text = ""
        lblQuantity.Text = ""
        lblSize.Text = ""
        lblTotprice.Text = ""
        lblUnitprice.Text = ""


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lblSize_Click(sender As Object, e As EventArgs) Handles lblSize.Click

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub lblAddon_Click(sender As Object, e As EventArgs) Handles lblAddon.Click

    End Sub
End Class
