<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnPumpkin = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnMocha = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHeading.Location = New System.Drawing.Point(275, 37)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(168, 25)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Latte Selection"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(11, 152)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 200)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(403, 152)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(300, 200)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'btnPumpkin
        '
        Me.btnPumpkin.Location = New System.Drawing.Point(90, 376)
        Me.btnPumpkin.Name = "btnPumpkin"
        Me.btnPumpkin.Size = New System.Drawing.Size(96, 23)
        Me.btnPumpkin.TabIndex = 3
        Me.btnPumpkin.Text = "Pumpkin Spice"
        Me.btnPumpkin.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(308, 376)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(96, 23)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Text = "Select Latte"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnMocha
        '
        Me.btnMocha.Location = New System.Drawing.Point(529, 376)
        Me.btnMocha.Name = "btnMocha"
        Me.btnMocha.Size = New System.Drawing.Size(96, 23)
        Me.btnMocha.TabIndex = 5
        Me.btnMocha.Text = "Mocha"
        Me.btnMocha.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(309, 517)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInstructions.Location = New System.Drawing.Point(220, 420)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(274, 14)
        Me.lblInstructions.TabIndex = 7
        Me.lblInstructions.Text = "Choose a latte flavor and then click Select Latte."
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblConfirmation.Location = New System.Drawing.Point(308, 500)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(98, 14)
        Me.lblConfirmation.TabIndex = 8
        Me.lblConfirmation.Text = "Enjoy your latte!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 661)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMocha)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnPumpkin)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "Form1"
        Me.Text = "Latte Selection"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnPumpkin As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnMocha As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblConfirmation As Label
End Class
