<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSnake
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSnake))
        RadioButton1 = New System.Windows.Forms.RadioButton()
        RadioButton2 = New System.Windows.Forms.RadioButton()
        RadioButton3 = New System.Windows.Forms.RadioButton()
        RadioButton4 = New System.Windows.Forms.RadioButton()
        Timer1 = New System.Windows.Forms.Timer(components)
        PictureBox3 = New System.Windows.Forms.PictureBox()
        PictureBox5 = New System.Windows.Forms.PictureBox()
        PictureBox4 = New System.Windows.Forms.PictureBox()
        PictureBox6 = New System.Windows.Forms.PictureBox()
        PictureBox7 = New System.Windows.Forms.PictureBox()
        PictureBox8 = New System.Windows.Forms.PictureBox()
        PictureBox9 = New System.Windows.Forms.PictureBox()
        PictureBox10 = New System.Windows.Forms.PictureBox()
        PictureBox2 = New System.Windows.Forms.PictureBox()
        PictureBox1 = New System.Windows.Forms.PictureBox()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        tiempo = New System.Windows.Forms.Timer(components)
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New System.Drawing.Point(819, 684)
        RadioButton1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New System.Drawing.Size(57, 19)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Arriba"
        RadioButton1.UseVisualStyleBackColor = True
        RadioButton1.Visible = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New System.Drawing.Point(779, 711)
        RadioButton2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New System.Drawing.Size(40, 19)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Izq"
        RadioButton2.UseVisualStyleBackColor = True
        RadioButton2.Visible = False
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New System.Drawing.Point(853, 711)
        RadioButton3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New System.Drawing.Size(43, 19)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "Der"
        RadioButton3.UseVisualStyleBackColor = True
        RadioButton3.Visible = False
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New System.Drawing.Point(819, 737)
        RadioButton4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New System.Drawing.Size(56, 19)
        RadioButton4.TabIndex = 3
        RadioButton4.TabStop = True
        RadioButton4.Text = "Abajo"
        RadioButton4.UseVisualStyleBackColor = True
        RadioButton4.Visible = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 450
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Drawing.Image)
        PictureBox3.Location = New System.Drawing.Point(79, 697)
        PictureBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New System.Drawing.Size(58, 58)
        PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Drawing.Image)
        PictureBox5.Location = New System.Drawing.Point(210, 697)
        PictureBox5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New System.Drawing.Size(58, 58)
        PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 7
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Drawing.Image)
        PictureBox4.Location = New System.Drawing.Point(145, 697)
        PictureBox4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New System.Drawing.Size(58, 58)
        PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 8
        PictureBox4.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Drawing.Image)
        PictureBox6.Location = New System.Drawing.Point(275, 697)
        PictureBox6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New System.Drawing.Size(58, 58)
        PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 12
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Drawing.Image)
        PictureBox7.Location = New System.Drawing.Point(341, 697)
        PictureBox7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New System.Drawing.Size(58, 58)
        PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 11
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Drawing.Image)
        PictureBox8.Location = New System.Drawing.Point(402, 697)
        PictureBox8.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New System.Drawing.Size(58, 58)
        PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 10
        PictureBox8.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Drawing.Image)
        PictureBox9.Location = New System.Drawing.Point(468, 697)
        PictureBox9.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New System.Drawing.Size(46, 50)
        PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 9
        PictureBox9.TabStop = False
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), Drawing.Image)
        PictureBox10.Location = New System.Drawing.Point(520, 697)
        PictureBox10.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New System.Drawing.Size(58, 58)
        PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox10.TabIndex = 13
        PictureBox10.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Drawing.Image)
        PictureBox2.Location = New System.Drawing.Point(14, 697)
        PictureBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New System.Drawing.Size(58, 58)
        PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Drawing.Image)
        PictureBox1.Location = New System.Drawing.Point(400, 150)
        PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(58, 58)
        PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Drawing.SystemColors.ActiveCaptionText
        Label1.Location = New System.Drawing.Point(834, 595)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(41, 15)
        Label1.TabIndex = 14
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        Label2.Location = New System.Drawing.Point(671, 692)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(59, 41)
        Label2.TabIndex = 15
        Label2.Text = "40"
        ' 
        ' tiempo
        ' 
        tiempo.Enabled = True
        tiempo.Interval = 1000
        ' 
        ' frmSnake
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(924, 768)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox10)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox9)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(RadioButton4)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Name = "frmSnake"
        Text = "v "
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tiempo As System.Windows.Forms.Timer

End Class
