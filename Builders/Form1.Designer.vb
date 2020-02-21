<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtDiameter = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblDiameter = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblOutputCir = New System.Windows.Forms.Label()
        Me.lblOutputPrice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDiameter
        '
        Me.txtDiameter.Location = New System.Drawing.Point(397, 67)
        Me.txtDiameter.Name = "txtDiameter"
        Me.txtDiameter.Size = New System.Drawing.Size(146, 20)
        Me.txtDiameter.TabIndex = 0
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(397, 123)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(146, 20)
        Me.txtPrice.TabIndex = 1
        '
        'lblDiameter
        '
        Me.lblDiameter.AutoSize = True
        Me.lblDiameter.Font = New System.Drawing.Font("MingLiU-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiameter.Location = New System.Drawing.Point(86, 67)
        Me.lblDiameter.Name = "lblDiameter"
        Me.lblDiameter.Size = New System.Drawing.Size(305, 16)
        Me.lblDiameter.TabIndex = 2
        Me.lblDiameter.Text = "Enter the diameter of the circle:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("MingLiU-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(86, 123)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(305, 16)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "Enter the price/foot of material:"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Cyan
        Me.btnCalculate.Font = New System.Drawing.Font("MingLiU-ExtB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(285, 173)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(135, 34)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblOutputCir
        '
        Me.lblOutputCir.AutoSize = True
        Me.lblOutputCir.Font = New System.Drawing.Font("MingLiU-ExtB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputCir.Location = New System.Drawing.Point(158, 242)
        Me.lblOutputCir.Name = "lblOutputCir"
        Me.lblOutputCir.Size = New System.Drawing.Size(0, 21)
        Me.lblOutputCir.TabIndex = 5
        '
        'lblOutputPrice
        '
        Me.lblOutputPrice.AutoSize = True
        Me.lblOutputPrice.Font = New System.Drawing.Font("MingLiU-ExtB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputPrice.Location = New System.Drawing.Point(158, 294)
        Me.lblOutputPrice.Name = "lblOutputPrice"
        Me.lblOutputPrice.Size = New System.Drawing.Size(0, 21)
        Me.lblOutputPrice.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblOutputPrice)
        Me.Controls.Add(Me.lblOutputCir)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblDiameter)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtDiameter)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDiameter As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblDiameter As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblOutputCir As Label
    Friend WithEvents lblOutputPrice As Label
End Class
