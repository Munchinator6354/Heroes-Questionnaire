Option Strict On
Option Explicit On
'Instructor: Penny Russell 
'Class: CS115 Fall 2020
'Student: Ryan Isaacson
'Assignment: Exercise 3 String Concatenation

Public Class frmConcat
    'This Subroutine handles Clicking the Start Questionnaire button and inializes the program
    Private Sub btnStartQuestionnaire_Click(sender As Object, e As EventArgs) Handles btnStartQuestionnaire.Click
        lblQuestion1.Text = "1) What is your name?"
        lblQuestion2.Text = "2) What do you quest for?"
        lblQuestion3.Text = "3) What is your favorite color?"
        lblQuestion1.Show()
        txtAnswer1.Show()
        btnRun.Text = "Click for" & vbCrLf & "Next Question"
        btnRun.Show()
        btnClear.Text = "Clear" & vbCrLf & "Answers"
        btnClear.Show()
        btnExitProgram.Text = "Exit" & vbCrLf & "Program"
        btnExitProgram.Show()
        btnStartQuestionnaire.Hide()
        picAskMeTheQuestions.Image = Image.FromFile("..\Images\AskMeTheQuestions.jpg")
        picAskMeTheQuestions.Show()
        txtAnswer1.Focus()
    End Sub

    'This subroutine handles the "enter key" submission of answer 1
    Private Sub txtAnswer1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAnswer1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtAnswer1.Text = "" Then
                MessageBox.Show("Hero! You must enter your name!")
            Else
                lblQuestion2.Show()
                txtAnswer2.Show()
                txtAnswer2.Focus()
                e.SuppressKeyPress = True
            End If
        End If
    End Sub

    'This subroutine handles the "enter key" submission of answer 2
    Private Sub txtAnswer2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAnswer2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtAnswer2.Text = "" Then
                MessageBox.Show("Hero! You must enter what it is you quest for!")
            Else
                lblQuestion3.Show()
                txtAnswer3.Show()
                btnRun.Text = "Finish Heroes" & vbCrLf & "Questionnaire"
                txtAnswer3.Focus()
                e.SuppressKeyPress = True
            End If
        End If
    End Sub

    'This subroutine handles the "enter key" submission of answer 3
    Private Sub txtAnswer3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAnswer3.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtAnswer3.Text = "" Then
                MessageBox.Show("Hero! Everyone has a favorite color, come on now!")
            Else
                Dim name As String
                Dim quest As String
                Dim color As String
                Dim story As String
                name = txtAnswer1.Text
                quest = txtAnswer2.Text
                color = txtAnswer3.Text
                story = "Our heroes' name is " & name & "." & vbCrLf & vbCrLf &
                        "They quest for " & quest & "." & vbCrLf & vbCrLf &
                        "But most importantly, their favorite color is " & color & "!"
                lblStoryOutput.Text = story
                picAskMeTheQuestions.Hide()
                btnClear.Focus()
                e.SuppressKeyPress = True
                lblQuestion1.Hide()
                lblQuestion2.Hide()
                lblQuestion3.Hide()
                txtAnswer1.Hide()
                txtAnswer2.Hide()
                txtAnswer3.Hide()
                lblStoryOutput.Show()
                btnClear.Text = "Restart" & vbCrLf & "Questionnaire?"
                btnRun.Hide()
            End If
        End If
    End Sub

    'This subroutine handles the "mouse click" submission of the questionnaire progression button
    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        If txtAnswer1.Text = "" Then
            MessageBox.Show("Hero! You must enter your name!")
        ElseIf lblQuestion2.Visible = False Then
            lblQuestion2.Show()
            txtAnswer2.Show()
            txtAnswer2.Focus()
        ElseIf txtAnswer2.Text = "" Then
            MessageBox.Show("Hero! You must enter what it is you quest for!")
        ElseIf lblQuestion3.Visible = False Then
            btnRun.Text = "Finish Heroes" & vbCrLf & "Questionnaire"
            lblQuestion3.Show()
            txtAnswer3.Show()
            txtAnswer3.Focus()
        ElseIf txtAnswer3.Text = "" Then
            MessageBox.Show("Hero! Everyone has a favorite color, come on now!")
        Else
            Dim name As String
            Dim quest As String
            Dim color As String
            Dim story As String
            name = txtAnswer1.Text
            quest = txtAnswer2.Text
            color = txtAnswer3.Text
            story = "Our heroes' name is " & name & "." & vbCrLf & vbCrLf &
                        "They quest for " & quest & "." & vbCrLf & vbCrLf &
                        "But most importantly, their favorite color is " & color & "!"
            lblStoryOutput.Text = story
            picAskMeTheQuestions.Hide()
            btnClear.Focus()
            lblQuestion1.Hide()
            lblQuestion2.Hide()
            lblQuestion3.Hide()
            txtAnswer1.Hide()
            txtAnswer2.Hide()
            txtAnswer3.Hide()
            lblStoryOutput.Show()
            btnClear.Text = "Restart" & vbCrLf & "Questionnaire?"
            btnRun.Hide()
        End If
    End Sub

    'This subroutine handles the Clear Answers button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblQuestion2.Hide()
        lblQuestion3.Hide()
        txtAnswer2.Hide()
        txtAnswer3.Hide()
        txtAnswer1.Text = ""
        txtAnswer2.Text = ""
        txtAnswer3.Text = ""
        lblStoryOutput.Text = ""
        lblQuestion1.Show()
        txtAnswer1.Show()
        btnRun.Show()
        txtAnswer1.Focus()
        picAskMeTheQuestions.Show()
        btnRun.Text = "Click for" & vbCrLf & "Next Question"
    End Sub

    'This subroutine opens up the video that references the underlying theme of the app
    Private Sub lnkMontyPythonVid_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkMontyPythonVid.LinkClicked
        Process.Start("https://www.youtube.com/watch?v=pWS8Mg-JWSg")
    End Sub

    'This subroutine handles the Exit Program button
    Private Sub btnExitProgram_Click(sender As Object, e As EventArgs) Handles btnExitProgram.Click
        Me.Close()
    End Sub

End Class
