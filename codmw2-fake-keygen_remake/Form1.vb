Public Class Form1
        Dim blnButtonDown, blnButtonDown_, blnButtonDown__
        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Criado por Antrax10" & vbCrLf & "Criado e Compilado por Antrax10 30/11/2009", MsgBoxStyle.OkOnly, "Antrox10")
        End Sub
        Private Sub Button1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Button1.Paint
            If blnButtonDown = False Then
                ControlPaint.DrawBorder3D(e.Graphics, sender.ClientRectangle,
                        Border3DStyle.Raised)
            Else
                ControlPaint.DrawBorder3D(e.Graphics, sender.ClientRectangle,
                        Border3DStyle.Sunken)
            End If
        End Sub
        Private Sub Button1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
            blnButtonDown = True
            sender.Invalidate()
        End Sub

        Private Sub Button1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseUp
            blnButtonDown = False
            sender.Invalidate()
        End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
        Private Sub Button2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Button2.Paint
            If blnButtonDown_ = False Then
                ControlPaint.DrawBorder3D(e.Graphics, sender.ClientRectangle,
                        Border3DStyle.Raised)
            Else
                ControlPaint.DrawBorder3D(e.Graphics, sender.ClientRectangle,
                        Border3DStyle.Sunken)
            End If
        End Sub
        Private Sub Button2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseDown
            blnButtonDown_ = True
            sender.Invalidate()
        End Sub

        Private Sub Button2_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseUp
            blnButtonDown_ = False
            sender.Invalidate()
        End Sub

        Private Sub Button3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Button3.Paint
            If blnButtonDown__ = False Then
                ControlPaint.DrawBorder3D(e.Graphics, sender.ClientRectangle,
                        Border3DStyle.Raised)
            Else
                ControlPaint.DrawBorder3D(e.Graphics, sender.ClientRectangle,
                        Border3DStyle.Sunken)
            End If
        End Sub
        Private Sub Button3_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseDown
            blnButtonDown__ = True
            sender.Invalidate()
        End Sub

        Private Sub Button3_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseUp
            blnButtonDown__ = False
            sender.Invalidate()
        End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim keys As New List(Of String)({"6LJJ-JEPU-WJ7P-3WJ3-4F49", "WA7W-H3EU-6WJH-GX63-A04A", "WA7L-GEQE-6WJX-HWA6-4156", "WH5W-WUGX-6QQH-5L5L-DB33", "W5HA-AAU5-666Q-6G3G-E92C", "WAEE-UQ63-6WW6-P5EU-E7B3", "WUHW-QWXJ-676H-EELP-9093", "WA7E-EGUX-6WJ6-QA3L-60C7", "6667-AW7Z-W5HZ-6EZ7-599A"})
        Dim rng_ As New Random
        RichTextBox1.Text = keys(rng_.Next(0, 8))
    End Sub
End Class
