Public Class Form1

    Private Sub btnBeep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeep.Click

        '. Loop that creates a beep sound when the Beep button is clicked

        Dim i As Integer

        For i = 1 To 5
            Beep()
        Next i

    End Sub

    Private Sub btnLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoop.Click
        '. For loop which displays numbers from 1 to 200 in a listbox
        '    .
        Dim i As Integer

        For i = 1 To 200
            listLoop.Items.Add(i)

        Next i
    End Sub

    Private Sub btnStepLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStepLoop.Click
        '. The loop below loops through numbers 1 to 20 using a Step Index of 2, the loop results are added to the listLoop2 listbox
        Dim i As Integer

        For i = 1 To 200 Step 2
            listLoop2.Items.Add(i)

        Next i

    End Sub

    Private Sub btnWCloop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWCloop.Click
        '. The loop (leapYear) uses Step Index of 4 to loop
        '.through the numbers (years) 1994 to 2300, where the later is the End point and the former the Start point, the loop results are added to a listbox

        Dim loopYear As Integer

        For loopYear = 1994 To 2300 Step 4
            listWorldCup.Items.Add(loopYear)

        Next loopYear

    End Sub

    Private Sub btnPictureLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPictureLoop.Click


        '. The codes below creates a For loop (i) which is able to loop 
        '    . through images 1- 3
        '    .with the aid of a Message box
        '    .
        '    .
        Dim i As Integer

        For i = 1 To 3
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\loopPictures\image" & i & ".jpg")

            MessageBox.Show("Click here for the next image")
        Next i

    End Sub

End Class
