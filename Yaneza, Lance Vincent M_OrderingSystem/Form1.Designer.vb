<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtName = New TextBox()
        lblTitle = New Label()
        txtQty = New TextBox()
        grpSize = New GroupBox()
        rbLarge = New RadioButton()
        rbMedium = New RadioButton()
        rbSmall = New RadioButton()
        grpAddon = New GroupBox()
        rbCheese = New RadioButton()
        rbNata = New RadioButton()
        rbPearl = New RadioButton()
        rbNone = New RadioButton()
        btnCompute = New Button()
        btnClear = New Button()
        btnExit = New Button()
        grpSummary = New GroupBox()
        lblTotprice = New Label()
        lblUnitprice = New Label()
        lblQuantity = New Label()
        lblAddon = New Label()
        lblSize = New Label()
        lblCostumer = New Label()
        lblResTotal = New Label()
        lblResUnit = New Label()
        lblResQty = New Label()
        lblResAddon = New Label()
        lblResSize = New Label()
        lblResName = New Label()
        Label1 = New Label()
        Label2 = New Label()
        grpSize.SuspendLayout()
        grpAddon.SuspendLayout()
        grpSummary.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.Gray
        txtName.BorderStyle = BorderStyle.None
        txtName.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(210, 72)
        txtName.Name = "txtName"
        txtName.Size = New Size(333, 26)
        txtName.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Vivaldi", 36F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(189, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(497, 57)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Milktea Ordering System"
        ' 
        ' txtQty
        ' 
        txtQty.BackColor = Color.Gray
        txtQty.BorderStyle = BorderStyle.None
        txtQty.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtQty.Location = New Point(692, 72)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(92, 26)
        txtQty.TabIndex = 2
        ' 
        ' grpSize
        ' 
        grpSize.BackColor = Color.LightSteelBlue
        grpSize.Controls.Add(rbLarge)
        grpSize.Controls.Add(rbMedium)
        grpSize.Controls.Add(rbSmall)
        grpSize.FlatStyle = FlatStyle.Flat
        grpSize.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpSize.Location = New Point(72, 120)
        grpSize.Name = "grpSize"
        grpSize.Size = New Size(279, 155)
        grpSize.TabIndex = 3
        grpSize.TabStop = False
        grpSize.Text = "Cup Sizes"
        ' 
        ' rbLarge
        ' 
        rbLarge.AutoSize = True
        rbLarge.Location = New Point(6, 101)
        rbLarge.Name = "rbLarge"
        rbLarge.Size = New Size(80, 29)
        rbLarge.TabIndex = 2
        rbLarge.TabStop = True
        rbLarge.Text = "Large"
        rbLarge.UseVisualStyleBackColor = True
        ' 
        ' rbMedium
        ' 
        rbMedium.AutoSize = True
        rbMedium.Location = New Point(6, 70)
        rbMedium.Name = "rbMedium"
        rbMedium.Size = New Size(104, 29)
        rbMedium.TabIndex = 1
        rbMedium.TabStop = True
        rbMedium.Text = "Medium"
        rbMedium.UseVisualStyleBackColor = True
        ' 
        ' rbSmall
        ' 
        rbSmall.AutoSize = True
        rbSmall.Location = New Point(6, 39)
        rbSmall.Name = "rbSmall"
        rbSmall.Size = New Size(78, 29)
        rbSmall.TabIndex = 0
        rbSmall.TabStop = True
        rbSmall.Text = "Small"
        rbSmall.UseVisualStyleBackColor = True
        ' 
        ' grpAddon
        ' 
        grpAddon.BackColor = Color.LightSteelBlue
        grpAddon.Controls.Add(rbCheese)
        grpAddon.Controls.Add(rbNata)
        grpAddon.Controls.Add(rbPearl)
        grpAddon.Controls.Add(rbNone)
        grpAddon.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpAddon.Location = New Point(428, 118)
        grpAddon.Name = "grpAddon"
        grpAddon.Size = New Size(356, 166)
        grpAddon.TabIndex = 4
        grpAddon.TabStop = False
        grpAddon.Text = "Add-Ons"
        ' 
        ' rbCheese
        ' 
        rbCheese.AutoSize = True
        rbCheese.Location = New Point(6, 130)
        rbCheese.Name = "rbCheese"
        rbCheese.Size = New Size(256, 29)
        rbCheese.TabIndex = 3
        rbCheese.TabStop = True
        rbCheese.Text = "Cream Cheese (+ 20 PHP)"
        rbCheese.UseVisualStyleBackColor = True
        ' 
        ' rbNata
        ' 
        rbNata.AutoSize = True
        rbNata.Location = New Point(6, 101)
        rbNata.Name = "rbNata"
        rbNata.Size = New Size(244, 29)
        rbNata.TabIndex = 2
        rbNata.TabStop = True
        rbNata.Text = "Nata de coco (+10 PHP)"
        rbNata.UseVisualStyleBackColor = True
        ' 
        ' rbPearl
        ' 
        rbPearl.AutoSize = True
        rbPearl.Location = New Point(6, 70)
        rbPearl.Name = "rbPearl"
        rbPearl.Size = New Size(180, 29)
        rbPearl.TabIndex = 1
        rbPearl.TabStop = True
        rbPearl.Text = "Pearls (+10 PHP)"
        rbPearl.UseVisualStyleBackColor = True
        ' 
        ' rbNone
        ' 
        rbNone.AutoSize = True
        rbNone.Location = New Point(6, 39)
        rbNone.Name = "rbNone"
        rbNone.Size = New Size(79, 29)
        rbNone.TabIndex = 0
        rbNone.TabStop = True
        rbNone.Text = "None"
        rbNone.UseVisualStyleBackColor = True
        ' 
        ' btnCompute
        ' 
        btnCompute.BackColor = Color.ForestGreen
        btnCompute.BackgroundImageLayout = ImageLayout.None
        btnCompute.FlatAppearance.BorderColor = Color.ForestGreen
        btnCompute.FlatStyle = FlatStyle.Flat
        btnCompute.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCompute.ForeColor = Color.White
        btnCompute.Location = New Point(101, 290)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(223, 43)
        btnCompute.TabIndex = 5
        btnCompute.Text = "COMPUTE"
        btnCompute.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(332, 290)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(223, 43)
        btnClear.TabIndex = 6
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Red
        btnExit.FlatAppearance.BorderColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(561, 290)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(223, 43)
        btnExit.TabIndex = 7
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' grpSummary
        ' 
        grpSummary.BackColor = Color.LightSteelBlue
        grpSummary.Controls.Add(lblTotprice)
        grpSummary.Controls.Add(lblUnitprice)
        grpSummary.Controls.Add(lblQuantity)
        grpSummary.Controls.Add(lblAddon)
        grpSummary.Controls.Add(lblSize)
        grpSummary.Controls.Add(lblCostumer)
        grpSummary.Controls.Add(lblResTotal)
        grpSummary.Controls.Add(lblResUnit)
        grpSummary.Controls.Add(lblResQty)
        grpSummary.Controls.Add(lblResAddon)
        grpSummary.Controls.Add(lblResSize)
        grpSummary.Controls.Add(lblResName)
        grpSummary.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpSummary.Location = New Point(72, 351)
        grpSummary.Name = "grpSummary"
        grpSummary.Size = New Size(504, 293)
        grpSummary.TabIndex = 8
        grpSummary.TabStop = False
        grpSummary.Text = "ORDER SUMMARY"
        ' 
        ' lblTotprice
        ' 
        lblTotprice.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotprice.Location = New Point(212, 231)
        lblTotprice.Name = "lblTotprice"
        lblTotprice.Size = New Size(137, 28)
        lblTotprice.TabIndex = 11
        ' 
        ' lblUnitprice
        ' 
        lblUnitprice.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUnitprice.Location = New Point(212, 152)
        lblUnitprice.Name = "lblUnitprice"
        lblUnitprice.Size = New Size(137, 28)
        lblUnitprice.TabIndex = 10
        ' 
        ' lblQuantity
        ' 
        lblQuantity.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblQuantity.Location = New Point(212, 124)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(137, 28)
        lblQuantity.TabIndex = 9
        ' 
        ' lblAddon
        ' 
        lblAddon.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddon.Location = New Point(212, 96)
        lblAddon.Name = "lblAddon"
        lblAddon.Size = New Size(137, 28)
        lblAddon.TabIndex = 8
        ' 
        ' lblSize
        ' 
        lblSize.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSize.Location = New Point(212, 68)
        lblSize.Name = "lblSize"
        lblSize.Size = New Size(137, 28)
        lblSize.TabIndex = 7
        ' 
        ' lblCostumer
        ' 
        lblCostumer.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCostumer.Location = New Point(212, 40)
        lblCostumer.Name = "lblCostumer"
        lblCostumer.Size = New Size(137, 28)
        lblCostumer.TabIndex = 6
        ' 
        ' lblResTotal
        ' 
        lblResTotal.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResTotal.Location = New Point(6, 231)
        lblResTotal.Name = "lblResTotal"
        lblResTotal.Size = New Size(137, 28)
        lblResTotal.TabIndex = 5
        lblResTotal.Text = "TOTAL:"
        ' 
        ' lblResUnit
        ' 
        lblResUnit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResUnit.Location = New Point(6, 152)
        lblResUnit.Name = "lblResUnit"
        lblResUnit.Size = New Size(137, 28)
        lblResUnit.TabIndex = 4
        lblResUnit.Text = "Unit Price:"
        ' 
        ' lblResQty
        ' 
        lblResQty.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResQty.Location = New Point(6, 124)
        lblResQty.Name = "lblResQty"
        lblResQty.Size = New Size(137, 28)
        lblResQty.TabIndex = 3
        lblResQty.Text = "Quantity:"
        ' 
        ' lblResAddon
        ' 
        lblResAddon.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResAddon.Location = New Point(6, 96)
        lblResAddon.Name = "lblResAddon"
        lblResAddon.Size = New Size(137, 28)
        lblResAddon.TabIndex = 2
        lblResAddon.Text = "Add-On"
        ' 
        ' lblResSize
        ' 
        lblResSize.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResSize.Location = New Point(6, 68)
        lblResSize.Name = "lblResSize"
        lblResSize.Size = New Size(137, 28)
        lblResSize.TabIndex = 1
        lblResSize.Text = "Cup Size:"
        ' 
        ' lblResName
        ' 
        lblResName.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResName.Location = New Point(6, 40)
        lblResName.Name = "lblResName"
        lblResName.Size = New Size(137, 28)
        lblResName.TabIndex = 0
        lblResName.Text = "Costumer Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.LightSteelBlue
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(72, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 21)
        Label1.TabIndex = 9
        Label1.Text = "Costumer Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.LightSteelBlue
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(610, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 21)
        Label2.TabIndex = 10
        Label2.Text = "Quantity:"
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.CornflowerBlue
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(887, 656)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(grpSummary)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCompute)
        Controls.Add(grpAddon)
        Controls.Add(grpSize)
        Controls.Add(lblTitle)
        Controls.Add(txtName)
        Controls.Add(txtQty)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        grpSize.ResumeLayout(False)
        grpSize.PerformLayout()
        grpAddon.ResumeLayout(False)
        grpAddon.PerformLayout()
        grpSummary.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents grpSize As GroupBox
    Friend WithEvents rbLarge As RadioButton
    Friend WithEvents rbMedium As RadioButton
    Friend WithEvents rbSmall As RadioButton
    Friend WithEvents grpAddon As GroupBox
    Friend WithEvents rbNata As RadioButton
    Friend WithEvents rbPearl As RadioButton
    Friend WithEvents rbNone As RadioButton
    Friend WithEvents rbCheese As RadioButton
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpSummary As GroupBox
    Friend WithEvents lblResName As Label
    Friend WithEvents lblResTotal As Label
    Friend WithEvents lblResUnit As Label
    Friend WithEvents lblResQty As Label
    Friend WithEvents lblResAddon As Label
    Friend WithEvents lblResSize As Label
    Friend WithEvents lblCostumer As Label
    Friend WithEvents lblSize As Label
    Friend WithEvents lblTotprice As Label
    Friend WithEvents lblUnitprice As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblAddon As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
