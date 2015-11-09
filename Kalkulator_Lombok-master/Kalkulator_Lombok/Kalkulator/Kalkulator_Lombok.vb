Public Class Kalkulator_Lombok
    Dim kondisi1 As Integer
    Dim kondisi2 As Byte

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        If (liatisi()) Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text &= "0"
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (liatisi()) Then
            TextBox1.Text = "1"
        Else
            TextBox1.Text &= "1"

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (liatisi()) Then
            TextBox1.Text = "2"
        Else
            TextBox1.Text &= "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (liatisi()) Then
            TextBox1.Text = "3"
        Else
            TextBox1.Text &= "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (liatisi()) Then
            TextBox1.Text = "4"
        Else
            TextBox1.Text &= "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (liatisi()) Then
            TextBox1.Text = "5"
        Else
            TextBox1.Text &= "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (liatisi()) Then
            TextBox1.Text = "6"
        Else
            TextBox1.Text &= "6"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (liatisi()) Then
            TextBox1.Text = "7"
        Else
            TextBox1.Text &= "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (liatisi()) Then
            TextBox1.Text = "8"
        Else
            TextBox1.Text &= "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (liatisi()) Then
            TextBox1.Text = "9"
        Else
            TextBox1.Text &= "9"
        End If
    End Sub

    Private Function liatisi()
        If (TextBox1.Text.Equals("0") Or Me.kondisi2 > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        TextBox1.Text = "0"
        Me.kondisi1 = 0
        Me.kondisi2 = 0
    End Sub


    Private Sub ButtonKurang_Click(sender As Object, e As EventArgs) Handles ButtonKurang.Click
        If (Me.kondisi1 = 0 Or Me.kondisi2 = 2) Then
            Me.kondisi1 += Convert.ToInt32(TextBox1.Text)
        Else
            Me.kondisi1 -= Convert.ToInt32(TextBox1.Text)
        End If
        TextBox1.Text = Me.kondisi1.ToString
        Me.kondisi2 = 1
    End Sub


    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        If (Me.kondisi2 = 1) Then
            Me.kondisi1 -= Convert.ToInt32(TextBox1.Text)
        Else
            Me.kondisi1 += Convert.ToInt32(TextBox1.Text)
        End If
        TextBox1.Text = Me.kondisi1.ToString
        Me.kondisi2 = 2
    End Sub

    Private Sub ButtonSamaDengan_Click(sender As Object, e As EventArgs) Handles ButtonSamaDengan.Click
        Select Case Me.kondisi2
            Case 1
                TextBox1.Text = Convert.ToString(Me.kondisi1 - Convert.ToInt32(TextBox1.Text))
            Case 2
                TextBox1.Text = Convert.ToString(Me.kondisi1 + Convert.ToInt32(TextBox1.Text))
        End Select
        Me.kondisi1 = 0
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

