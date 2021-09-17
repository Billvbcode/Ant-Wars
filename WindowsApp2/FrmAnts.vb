Public Class FrmAnts
    Dim iScore As Integer 'To Keep Score
    Dim iTick As Integer  'To Speed up Timer


    Private Sub FrmAnts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        iScore = 0  ' Reset Score
        iTick = 0 ' Reset iTick
        TimMove.Interval = 100  ' Reset Timer      
        pAnt1.Top = 400 ' Reset Ant1 to the bottom
        pAnt2.Top = 400 ' Reset Ant2 to the bottom
        pAnt3.Top = 400 ' Reset Ant3 to the bottom
        pAnt4.Top = 400 ' Reset Ant4 to the bottom
        pAnt5.Top = 400 ' Reset Ant5 to the bottom
        'Show Score
        Me.Text = "Score=" & iScore & " " _
            & " Speed =" & TimMove.Interval
        pAnt4.Visible = False    ' Hide Ant 4
        pAnt5.Visible = False    ' Hide Ant 5
        TimMove.Start   ' Start Timer
        BtnStart.Visible = False ' Hide BtnStart
        LblWin.Visible = False ' Hide LblWin
    End Sub

    Private Sub pAnt1_Click(sender As Object, e As EventArgs) Handles pAnt1.Click
        iScore += 1   ' Increase Score
        iTick += 1 ' Increase iTick
        pAnt1.Top = 500 ' Reset Ant1 to the bottom
        'Show Score
        Me.Text = "Score=" & iScore & " " _
            & " Speed =" & TimMove.Interval
    End Sub

    Private Sub pAnt2_Click(sender As Object, e As EventArgs) Handles pAnt2.Click
        iScore += 1   ' Increase Score
        iTick += 1 ' Increase iTick
        pAnt2.Top = 500 ' Reset Ant2 to the bottom
        'Show Score
        Me.Text = "Score=" & iScore & " " _
            & " Speed =" & TimMove.Interval
    End Sub
    Private Sub pAnt3_Click(sender As Object, e As EventArgs) Handles pAnt3.Click
        iScore += 1   ' Increase Score
        iTick += 1 ' Increase iTick
        pAnt3.Top = 500 ' Reset Ant3 to the bottom
        'Show Score 
        Me.Text = "Score=" & iScore & " " _
            & " Speed =" & TimMove.Interval
    End Sub
    Private Sub pAnt4_Click(sender As Object, e As EventArgs) Handles pAnt4.Click
        iScore += 1   ' Increase Score
        iTick += 1 ' Increase iTick
        pAnt4.Top = 500 ' Reset Ant4 to the bottom
        'Show Score
        Me.Text = "Score=" & iScore & " " _
            & " Speed =" & TimMove.Interval
    End Sub
    Private Sub pAnt5_Click(sender As Object, e As EventArgs) Handles pAnt5.Click
        iScore += 1   ' Increase Score
        iTick += 1 ' Increase iTick
        pAnt5.Top = 500 ' Reset Ant5 to the bottom
        'Show Score
        Me.Text = "Score=" & iScore & " " _
            & " Speed =" & TimMove.Interval
    End Sub

    Private Sub TimMove_Tick(sender As Object, e As EventArgs) Handles TimMove.Tick
        If iScore > 5 Then pAnt4.Visible = True 'Ant4 Visible
        If iScore > 8 Then pAnt5.Visible = True 'Ant5 Visible
        If iTick > 2 Then 'Speed up Timer
            TimMove.Interval -= 2 'or 3 or 4 0r 5
            iTick = 0
        End If
        pAnt1.Top -= 5 ' Move ant1 Up
        If pAnt1.Top < 10 Then 'Ant1 Moves Off Screen
            TimMove.Stop() 'Stop Timer
            LblWin.Text = "You Lost " & "Score= " & iScore
            LblWin.Visible = True 'Show Label
            BtnStart.Visible = True 'Show Start Button
        End If
        pAnt2.Top -= 5 ' Move ant2 Up
        If pAnt2.Top < 10 Then 'Ant2 Moves Off Screen
            TimMove.Stop() 'Stop Timer
            LblWin.Text = "You Lost " & "Score= " & iScore
            LblWin.Visible = True 'Show Label
            BtnStart.Visible = True 'Show Start Button
        End If
        pAnt3.Top -= 5 ' Move ant3 Up
        If pAnt3.Top < 10 Then 'Ant3 Moves Off Screen
            TimMove.Stop() 'Stop Timer
            LblWin.Text = "You Lost " & "Score= " & iScore
            LblWin.Visible = True 'Show Label
            BtnStart.Visible = True 'Show Start Button
        End If
        If pAnt4.Visible Then pAnt4.Top -= 5 ' Move ant4 Up
        If pAnt4.Top < 10 Then 'Ant4 Moves Off Screen
            TimMove.Stop() 'Stop Timer
            LblWin.Text = "You Lost " & "Score= " & iScore
            LblWin.Visible = True 'Show Label
            BtnStart.Visible = True 'Show Start Button
        End If
        If pAnt5.Visible Then pAnt5.Top -= 5 ' Move ant5 Up
        If pAnt5.Top < 10 Then 'Ant5 Moves Off Screen
            TimMove.Stop() 'Stop Timer
            LblWin.Text = "You Lost " & "Score= " & iScore
            LblWin.Visible = True 'Show Label
            BtnStart.Visible = True 'Show Start Button
        End If

    End Sub
End Class