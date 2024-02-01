Imports System.IO
Public Class Form

    Private Sub n7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles n7.Click
        ecran.Text = ecran.Text + "7"
        ecran.Text = CDbl(ecran.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub n0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles n0.Click
        ecran.Text = ecran.Text + "0"
        ecran.Text = CDbl(ecran.Text)
    End Sub

    Private Sub n1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles n1.Click
        ecran.Text = ecran.Text + "1"
        ecran.Text = CDbl(ecran.Text)
    End Sub

    Private Sub n2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles n2.Click
        ecran.Text = ecran.Text + "2"
        ecran.Text = CDbl(ecran.Text)
    End Sub

    Private Sub n3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles n3.Click
        ecran.Text = ecran.Text + "3"
        ecran.Text = CDbl(ecran.Text)
    End Sub

    Private Sub n4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles n4.Click
        ecran.Text = ecran.Text + "4"
        ecran.Text = CDbl(ecran.Text)
    End Sub

    Private Sub n5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles n5.Click
        ecran.Text = ecran.Text + "5"
        ecran.Text = CDbl(ecran.Text)
    End Sub

    Private Sub n6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles n6.Click
        ecran.Text = ecran.Text + "6"
        ecran.Text = CDbl(ecran.Text)
    End Sub

    Private Sub n8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles n8.Click
        ecran.Text = ecran.Text + "8"
        ecran.Text = CDbl(ecran.Text)
    End Sub

    Private Sub n9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles n9.Click
        ecran.Text = ecran.Text + "9"
        ecran.Text = CDbl(ecran.Text)
    End Sub

    Private Sub plus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plus.Click
        op.Text = "+"
        mem.Text = ecran.Text
        ecran.Text = 0

    End Sub

    Private Sub moins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles moins.Click
        op.Text = "-"
        mem.Text = ecran.Text
        ecran.Text = 0
    End Sub

    Private Sub egale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles egale.Click
        Dim tmp As String = ecran.Text
        If (op.Text = "+") Then

            ecran.Text = CDbl(mem.Text) + CDbl(ecran.Text)
        End If
        If (op.Text = "-") Then
            ecran.Text = CDbl(mem.Text) - CDbl(ecran.Text)
        End If
        If (op.Text = "*") Then
            ecran.Text = CDbl(mem.Text) * CDbl(ecran.Text)
        End If
        If (op.Text = "/") Then
            ecran.Text = CDbl(mem.Text) / CDbl(ecran.Text)
        End If
        If (op.Text = "%") Then
            ecran.Text = CDbl(mem.Text) Mod CDbl(ecran.Text)
        End If
        If (op.Text = "p") Then
            Dim p As Double = 1
            For i = 1 To CDbl(ecran.Text)
                p = p * CDbl(mem.Text)
            Next
            ecran.Text = p.ToString
        End If
        TextBox1.Text &= mem.Text + op.Text + tmp + "=" + ecran.Text + Environment.NewLine
        op.Text = "op"
    End Sub

    Private Sub multi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles multi.Click
        op.Text = "*"
        mem.Text = ecran.Text
        ecran.Text = 0
    End Sub

    Private Sub division_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles division.Click
        op.Text = "/"
        mem.Text = ecran.Text
        ecran.Text = 0
    End Sub

    Private Sub c_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c.Click
        op.Text = "op"
        mem.Text = "MEM"
        ecran.Text = "0"

    End Sub

    Private Sub ce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ce.Click
        ecran.Text = "0"
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        If Len(ecran.Text) > 0 Then
            ecran.Text = Mid(ecran.Text, 1, Len(ecran.Text) - 1)
            If Len(ecran.Text) = 0 Then ecran.Text = 0
        Else
            ecran.Text = 0

        End If





    End Sub

    Private Sub virgule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles virgule.Click
        ecran.Text = ecran.Text + ","
    End Sub

    Private Sub pourcent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pourcent.Click

        op.Text = "%"
        mem.Text = ecran.Text
        ecran.Text = 0

    End Sub

    Private Sub unsurx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unsurx.Click
        Dim tmp As String = ecran.Text
        Dim x As Double
        x = 1 / CDbl(ecran.Text)
        ecran.Text = x.ToString
        TextBox1.Text &= "1/" + mem.Text + "=" + ecran.Text + Environment.NewLine
    End Sub

    Private Sub aucare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aucare.Click
        Dim x As Integer
        x = CDbl(ecran.Text) * CDbl(ecran.Text)
        ecran.Text = x.ToString
    End Sub

    Private Sub xsury_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xsury.Click
        op.Text = "p"
        mem.Text = ecran.Text
        ecran.Text = 0
    End Sub

    Private Sub mem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mem.Click

    End Sub

    Private Sub pdix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pdix.Click
        Dim x As Double = 1
        For i = 1 To CDbl(ecran.Text)
            x = x * 10
        Next
        ecran.Text = x.ToString
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rc.Click
        Dim x As Double
        x = Math.Sqrt(CDbl(ecran.Text))
        ecran.Text = x.ToString


    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sigma.Click

        Dim s As Double = 0
        For i = 1 To CDbl(ecran.Text)
            s = s + i
        Next
        ecran.Text = s.ToString



    End Sub

    Private Sub cos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dpx.Click
        Dim f As Double = 1
        For i = 1 To CDbl(ecran.Text)
            f = f * i
        Next
        ecran.Text = f.ToString
    End Sub

    Private Sub xfa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xfa.Click
        Dim p As Double = 1
        For i = 1 To CDbl(ecran.Text)
            p = p * 2
        Next
        ecran.Text = p.ToString
    End Sub

    Private Sub cosx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cosx.Click
        ecran.Text = Math.Cos(CDbl(ecran.Text)).ToString
    End Sub

    Private Sub Button1_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As Integer
        x = CDbl(ecran.Text) * CDbl(ecran.Text) * CDbl(ecran.Text)
        ecran.Text = x.ToString
    End Sub

    Private Sub sin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sin.Click
        ecran.Text = Math.Sin(CDbl(ecran.Text)).ToString
    End Sub

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tan.Click
        ecran.Text = Math.Tan(CDbl(ecran.Text)).ToString
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.SelectedIndex <> -1) Then
            ComboBox2.Enabled = True
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If (ComboBox1.SelectedIndex = 0) Then
            If (ComboBox2.SelectedIndex = 0) Then
                Label1.Text = ecran.Text
            End If
            If (ComboBox2.SelectedIndex = 1) Then
                Dim df As Double
                df = CDbl(ecran.Text) * 1.8 + 32
                Label1.Text = df.ToString
            End If
            If (ComboBox2.SelectedIndex = 2) Then
                Dim dk As Double
                dk = CDbl(ecran.Text) + 273.15
                Label1.Text = dk.ToString
            End If
            If (ComboBox2.SelectedIndex = 3) Then
                Dim dk As Double
                dk = CDbl(ecran.Text) + 273.15
                Label1.Text = dk.ToString
            End If
        End If
        '____________________________________
        If (ComboBox1.SelectedIndex = 1) Then
            If (ComboBox2.SelectedIndex = 0) Then
                Dim dc As Double
                dc = (CDbl(ecran.Text) - 32) / 1.8
                Label1.Text = ecran.Text

            End If
            If (ComboBox2.SelectedIndex = 1) Then

                Label1.Text = ecran.ToString
            End If
            If (ComboBox2.SelectedIndex = 2) Then
                Dim dc As Double
                dc = (CDbl(ecran.Text) - 32) / 1.8
                Dim dk As Double
                dk = dc + 273.15
                Label1.Text = dk.ToString
            End If
            If (ComboBox2.SelectedIndex = 3) Then
                Dim dk As Double
                dk = CDbl(ecran.Text) + 273.15
                Label1.Text = dk.ToString
            End If
        End If
        '____________________________________________
        If (ComboBox1.SelectedIndex = 2) Then
            If (ComboBox2.SelectedIndex = 0) Then
                Dim dc As Double
                dc = CDbl(ecran.Text) - 273.15
                Label1.Text = ecran.Text

            End If
            If (ComboBox2.SelectedIndex = 1) Then
                Dim dc As Double
                dc = CDbl(ecran.Text) - 273.15
                Dim df As Double
                df = dc * 1.8 + 32
                Label1.Text = ecran.ToString
            End If
            If (ComboBox2.SelectedIndex = 2) Then

                Label1.Text = CDbl(ecran.Text)
            End If

        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Width = Me.Width + 40
        If Me.Width >= 683 Then
            Me.Width = 683
            Timer1.Stop()

        End If
    End Sub

    Private Sub ConvertisseurDeTempératureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertisseurDeTempératureToolStripMenuItem.Click
        If (ConvertisseurDeTempératureToolStripMenuItem.Checked = False) Then
            ConvertisseurDeTempératureToolStripMenuItem.Checked = True
            Timer1.Start()
        Else
            ConvertisseurDeTempératureToolStripMenuItem.Checked = False
            Me.Width = 500

        End If





    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SaveFileDialog1.Filter = "Fichier texte (*.txt)|*.txt"
        SaveFileDialog1.Title = "Enregistrer les données"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

            Using streamWriter As New StreamWriter(SaveFileDialog1.FileName)

                For Each item As String In TextBox1.Text
                    streamWriter.WriteLine(item)
                Next
            End Using
        End If
    End Sub

    Private Sub AficherLHistoriqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub AficherLHistoriqueToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AficherLHistoriqueToolStripMenuItem.Click
        Me.Width = 860
        Dim d, h As String
        d = DateAndTime.Now.Date
        h = DateAndTime.TimeString
        TextBox1.Text = d + " " + h + Environment.NewLine
    End Sub

    Private Sub AficherLHistoriqueToolStripMenuItem_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AficherLHistoriqueToolStripMenuItem.TextChanged


    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox1.Size = New Size(207, 249)

    End Sub

    Private Sub AProposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AProposToolStripMenuItem.Click
        apropos.ShowDialog()
    End Sub

    Private Sub AideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AideToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub ecran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ecran.Click

    End Sub
End Class

