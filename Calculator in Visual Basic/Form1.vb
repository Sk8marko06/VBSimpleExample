'This tutorial is provided in part by Server Intellect Web Hosting Solutions _http://www.serverintellect.com
' Visit _http://v4.vbasic.net for more v4.vbasic.net Tutorials

Public Class Form1

    Private Sub calculateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateBtn.Click
        Dim a_x As Double
        Dim a_y As Double
        Dim b_x As Double
        Dim b_y As Double

        Dim c_x As Double
        Dim c_y As Double
        Dim d_x As Double
        Dim d_y As Double

        Dim ab_x As Double
        Dim ab_y As Double
        Dim cd_x As Double
        Dim cd_y As Double

        Dim answer As Double

        a_x = Double.Parse(TextBox1.Text)
        a_y = Double.Parse(TextBox2.Text)
        b_x = Double.Parse(TextBox3.Text)
        b_y = Double.Parse(TextBox4.Text)

        c_x = Double.Parse(TextBox5.Text)
        c_y = Double.Parse(TextBox6.Text)
        d_x = Double.Parse(TextBox7.Text)
        d_y = Double.Parse(TextBox8.Text)

        ' Warunek sprawdzający czy wektory są równoległe:
        ' http://www.matematyka.pl/128191.htm
        ' http://zadane.pl/zadanie/369584

        ab_x = b_x - a_x
        ab_y = b_y - a_y

        cd_x = d_x - c_x
        cd_y = d_y - c_y

        answer = (ab_x * cd_y) - (ab_y * cd_x)

        If answer = 0 Then
            answerLbl.Text = "Odcinki są równoległe"
        Else
            answerLbl.Text = "Odcinki nie są równoległe"
        End If

    End Sub

    Private Sub clearBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearBtn.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""

        answerLbl.Text = "Result"

    End Sub

End Class
