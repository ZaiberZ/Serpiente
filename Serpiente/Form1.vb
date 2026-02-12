Imports System.Diagnostics
Imports System.Windows.Forms

Public Class frmSnake
    Dim x = 0
    Dim y = 0
    Dim x1 = 0
    Dim y1 = 0
    Dim x2 = 0
    Dim y2 = 0
    Dim x3 = 0
    Dim y3 = 0
    Dim x4 = 0
    Dim y4 = 0
    Dim x5 = 0
    Dim y5 = 0
    Dim x6 = 0
    Dim y6 = 0
    Dim x7 = 0
    Dim y7 = 0
    Dim x8 = 0
    Dim y8 = 0
    Dim x9 = 0
    Dim y9 = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If (RadioButton1.Checked) Then
            PictureBox1.Top -= 50
        End If
        If (RadioButton4.Checked) Then
            PictureBox1.Top += 50
        End If
        If (RadioButton2.Checked) Then
            PictureBox1.Left -= 50
        End If
        If (RadioButton3.Checked) Then
            PictureBox1.Left += 50
        End If

        If (a = 9) Then
            Timer1.Stop()
            MsgBox("Ganaste")
            Application.Exit()
        End If
        'p1,p2,p3,a
        If ((a = 1) And (PictureBox1.Location.X = PictureBox2.Location.X) And (PictureBox1.Location.Y = PictureBox2.Location.Y)) Then
            a = 2
            PictureBox3.Top = ejeY()
            PictureBox3.Left = ejeX()
        End If


        If (a >= 2) Then
            PictureBox2.Top = y
            PictureBox2.Left = x
            x = PictureBox1.Location.X
            y = PictureBox1.Location.Y
        End If
        'p1,p3,p4,p2,a
        'sigima(PictureBox1,PictureBox3 )
        If ((a >= 2) And (PictureBox1.Location.X = PictureBox3.Location.X) And (PictureBox1.Location.Y = PictureBox3.Location.Y)) Then
            a = 3
            PictureBox4.Top = ejeY()
            PictureBox4.Left = ejeX()
            x1 = PictureBox2.Left
            y1 = PictureBox2.Top
        End If

        If (a >= 3) Then
            PictureBox3.Top = y1
            PictureBox3.Left = x1
            x1 = PictureBox2.Location.X
            y1 = PictureBox2.Location.Y
        End If
        If ((a >= 3) And (PictureBox1.Location.X = PictureBox4.Location.X) And (PictureBox1.Location.Y = PictureBox4.Location.Y)) Then
            a = 4
            PictureBox5.Top = ejeY()
            PictureBox5.Left = ejeX()
            x2 = PictureBox3.Left
            y2 = PictureBox3.Top
            Timer1.Interval = 300
        End If


        If (a >= 4) Then
            PictureBox4.Top = y2
            PictureBox4.Left = x2
            x2 = PictureBox3.Location.X
            y2 = PictureBox3.Location.Y
        End If
        If ((a >= 4) And (PictureBox1.Location.X = PictureBox5.Location.X) And (PictureBox1.Location.Y = PictureBox5.Location.Y)) Then
            a = 5
            PictureBox6.Top = ejeY()
            PictureBox6.Left = ejeX()
            x3 = PictureBox4.Left
            y3 = PictureBox4.Top
        End If


        If (a >= 5) Then
            PictureBox5.Top = y3
            PictureBox5.Left = x3
            x3 = PictureBox4.Location.X
            y3 = PictureBox4.Location.Y            
            Label1.Text = a
        End If
        If ((a >= 5) And (PictureBox1.Location.X = PictureBox6.Location.X) And (PictureBox1.Location.Y = PictureBox6.Location.Y)) Then
            a = 6
            PictureBox7.Top = ejeY()
            PictureBox7.Left = ejeX()
            x4 = PictureBox5.Left
            y4 = PictureBox5.Top
            'MsgBox(y4 & " " & x4)
        End If


        If (a >= 6) Then
            PictureBox6.Top = y4
            PictureBox6.Left = x4
            'MsgBox(y4 & " " & x4)
            x4 = PictureBox5.Location.X
            y4 = PictureBox5.Location.Y
        End If

        If ((a >= 6) And (PictureBox1.Location.X = PictureBox7.Location.X) And (PictureBox1.Location.Y = PictureBox7.Location.Y)) Then
            a = 7
            PictureBox8.Top = ejeY()
            PictureBox8.Left = ejeX()
            x5 = PictureBox6.Left
            y5 = PictureBox6.Top
        End If

        If (a >= 7) Then
            PictureBox7.Top = y5
            PictureBox7.Left = x5
            x5 = PictureBox6.Location.X
            y5 = PictureBox6.Location.Y
        End If
        If ((a >= 7) And (PictureBox1.Location.X = PictureBox8.Location.X) And (PictureBox1.Location.Y = PictureBox8.Location.Y)) Then
            a = 8
            PictureBox9.Top = ejeY()
            PictureBox9.Left = ejeX()
            x6 = PictureBox7.Left
            y6 = PictureBox7.Top
        End If


        If (a >= 8) Then
            PictureBox8.Top = y6
            PictureBox8.Left = x6
            x6 = PictureBox7.Location.X
            y6 = PictureBox7.Location.Y
        End If
        If ((a >= 8) And (PictureBox1.Location.X = PictureBox9.Location.X) And (PictureBox1.Location.Y = PictureBox9.Location.Y)) Then
            a = 9
            PictureBox9.Top = ejeY()
            PictureBox9.Left = ejeX()
            x7 = PictureBox8.Left
            y7 = PictureBox8.Top
        End If
    End Sub
    Dim a As Integer
    Dim Vector(0 To 9, 0 To 1) As Integer

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'MsgBox(e.KeyCode)
        If e.KeyCode = 39 Then
            RadioButton3.Select()
        End If
        If e.KeyCode = 37 Then
            RadioButton2.Select()
        End If
        If e.KeyCode = 38 Then
            RadioButton1.Select()
        End If
        If e.KeyCode = 40 Then
            RadioButton4.Select()
        End If

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        a = 1
        PictureBox2.Top = ejeY()
        PictureBox2.Left = ejeX()
        x = PictureBox2.Left
        y = PictureBox2.Top
        Label2.Text = ti
    End Sub


    Dim Na As Double
    Dim Na1 As Double
    Private Function ejeX() As Integer
        'Na = Date.Now.Millisecond
        Na = CLng((0 - 1000) * Rnd() + 1000)

        If (Na >= 0 And Na <= 62.5) Then
            Return 0
        End If
        If (Na >= 62.5 And Na <= 125) Then
            Return 50
        End If
        If (Na >= 125 And Na <= 187.5) Then
            Return 100
        End If
        If (Na >= 187.5 And Na <= 250) Then
            Return 150
        End If
        If (Na >= 250 And Na <= 312.5) Then
            Return 200
        End If
        If (Na >= 312.5 And Na <= 375) Then
            Return 250
        End If
        If (Na >= 375 And Na <= 437.5) Then
            Return 300
        End If
        If (Na >= 437.5 And Na <= 500) Then
            Return 350
        End If
        If (Na >= 500 And Na <= 562.5) Then
            Return 400
        End If
        If (Na >= 562.5 And Na <= 625) Then
            Return 450
        End If
        If (Na >= 625 And Na <= 687.5) Then
            Return 500
        End If
        If (Na >= 687.5 And Na <= 750) Then
            Return 550
        End If
        If (Na >= 750 And Na <= 812.5) Then
            Return 600
        End If
        If (Na >= 812.5 And Na <= 875) Then
            Return 650
        End If
        If (Na >= 875 And Na <= 937.5) Then
            Return 700
        End If
        If (Na >= 937.5 And Na <= 1000) Then
            Return 750
        Else
            Return 400
        End If

    End Function

    Private Function ejeY() As Integer
        Na1 = Date.Now.Millisecond
        If (Na1 >= 0 And Na1 <= 83.3) Then
            Return 0
        End If
        If (Na1 >= 83.3 And Na1 <= 249.9) Then
            Return 50
        End If
        If (Na1 >= 249.9 And Na1 <= 333.2) Then
            Return 100
        End If
        If (Na1 >= 333.2 And Na1 <= 416.5) Then
            Return 150
        End If
        If (Na1 >= 416.5 And Na1 <= 499.8) Then
            Return 200
        End If
        If (Na1 >= 499.8 And Na1 <= 583.1) Then
            Return 250
        End If
        If (Na1 >= 583.1 And Na1 <= 666.4) Then
            Return 300
        End If
        If (Na1 >= 666.4 And Na1 <= 749.7) Then
            Return 350
        End If
        If (Na1 >= 749.7 And Na1 <= 833) Then
            Return 400
        End If
        If (Na1 >= 833 And Na1 <= 916.3) Then
            Return 450
        End If
        If (Na1 >= 916.3 And Na1 <= 999.6) Then
            Return 500
        Else
            Return 550
        End If
    End Function
    Dim ti = 40
    Private Sub tiempo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tiempo.Tick
        ti -= 1
        Label2.Text = ti
        If (ti = 0) Then
            tiempo.Stop()
            Timer1.Stop()
            MsgBox("Perdiste")
            Process.Start(Application.ExecutablePath)
            Application.Exit()
        End If

    End Sub
End Class
