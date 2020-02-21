<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScary
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
        Me.components = New System.ComponentModel.Container()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picFav = New System.Windows.Forms.PictureBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.tmrAppear = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDisappear = New System.Windows.Forms.Timer(Me.components)
        Me.tmrReappear = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picFav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHello
        '
        Me.lblHello.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHello.BackColor = System.Drawing.Color.Coral
        Me.lblHello.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHello.Font = New System.Drawing.Font("Old English Text MT", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblHello.Location = New System.Drawing.Point(63, 23)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(475, 57)
        Me.lblHello.TabIndex = 0
        Me.lblHello.Text = "                Hello there!"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.BackgroundImage = Global.ScaryD1.My.Resources.Resources.stop_sign
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(552, 339)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(59, 56)
        Me.btnExit.TabIndex = 2
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picFav
        '
        Me.picFav.Image = Global.ScaryD1.My.Resources.Resources.scary_spider
        Me.picFav.ImageLocation = ""
        Me.picFav.Location = New System.Drawing.Point(168, 104)
        Me.picFav.Name = "picFav"
        Me.picFav.Size = New System.Drawing.Size(307, 213)
        Me.picFav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFav.TabIndex = 1
        Me.picFav.TabStop = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnShow.Font = New System.Drawing.Font("Ravie", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.Violet
        Me.btnShow.Location = New System.Drawing.Point(110, 339)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(365, 56)
        Me.btnShow.TabIndex = 3
        Me.btnShow.Text = "Show my favorite picture"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'tmrAppear
        '
        Me.tmrAppear.Enabled = True
        Me.tmrAppear.Interval = 5000
        '
        'tmrDisappear
        '
        Me.tmrDisappear.Enabled = True
        Me.tmrDisappear.Interval = 10000
        '
        'tmrReappear
        '
        Me.tmrReappear.Enabled = True
        Me.tmrReappear.Interval = 15000
        '
        'frmScary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picFav)
        Me.Controls.Add(Me.lblHello)
        Me.Name = "frmScary"
        Me.Text = "Yikes! A spider!"
        CType(Me.picFav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblHello As Label
    Friend WithEvents picFav As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents tmrAppear As Timer
    Friend WithEvents tmrDisappear As Timer
    Friend WithEvents tmrReappear As Timer
End Class
