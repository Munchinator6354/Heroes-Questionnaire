<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConcat
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
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblQuestion1 = New System.Windows.Forms.Label()
        Me.lblQuestion2 = New System.Windows.Forms.Label()
        Me.txtAnswer1 = New System.Windows.Forms.TextBox()
        Me.lblQuestion3 = New System.Windows.Forms.Label()
        Me.btnStartQuestionnaire = New System.Windows.Forms.Button()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExitProgram = New System.Windows.Forms.Button()
        Me.txtAnswer2 = New System.Windows.Forms.TextBox()
        Me.txtAnswer3 = New System.Windows.Forms.TextBox()
        Me.lblStoryOutput = New System.Windows.Forms.Label()
        Me.lnkMontyPythonVid = New System.Windows.Forms.LinkLabel()
        Me.picAskMeTheQuestions = New System.Windows.Forms.PictureBox()
        CType(Me.picAskMeTheQuestions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(4, 4)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(218, 51)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Ryan Isaacson" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CSS 115 Fall 2020" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Exercise 3 - String Concatenation"
        '
        'lblQuestion1
        '
        Me.lblQuestion1.AutoSize = True
        Me.lblQuestion1.Location = New System.Drawing.Point(364, 108)
        Me.lblQuestion1.Name = "lblQuestion1"
        Me.lblQuestion1.Size = New System.Drawing.Size(0, 17)
        Me.lblQuestion1.TabIndex = 2
        Me.lblQuestion1.Visible = False
        '
        'lblQuestion2
        '
        Me.lblQuestion2.AutoSize = True
        Me.lblQuestion2.Location = New System.Drawing.Point(364, 170)
        Me.lblQuestion2.Name = "lblQuestion2"
        Me.lblQuestion2.Size = New System.Drawing.Size(51, 17)
        Me.lblQuestion2.TabIndex = 3
        Me.lblQuestion2.Text = "Label2"
        Me.lblQuestion2.Visible = False
        '
        'txtAnswer1
        '
        Me.txtAnswer1.Location = New System.Drawing.Point(576, 108)
        Me.txtAnswer1.Name = "txtAnswer1"
        Me.txtAnswer1.Size = New System.Drawing.Size(169, 22)
        Me.txtAnswer1.TabIndex = 5
        Me.txtAnswer1.Visible = False
        '
        'lblQuestion3
        '
        Me.lblQuestion3.AutoSize = True
        Me.lblQuestion3.Location = New System.Drawing.Point(364, 233)
        Me.lblQuestion3.Name = "lblQuestion3"
        Me.lblQuestion3.Size = New System.Drawing.Size(51, 17)
        Me.lblQuestion3.TabIndex = 4
        Me.lblQuestion3.Text = "Label3"
        Me.lblQuestion3.Visible = False
        '
        'btnStartQuestionnaire
        '
        Me.btnStartQuestionnaire.Location = New System.Drawing.Point(299, 134)
        Me.btnStartQuestionnaire.Name = "btnStartQuestionnaire"
        Me.btnStartQuestionnaire.Size = New System.Drawing.Size(195, 116)
        Me.btnStartQuestionnaire.TabIndex = 1
        Me.btnStartQuestionnaire.Text = "Start the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Heroes Questionnaire!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click Me" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To Begin"
        Me.btnStartQuestionnaire.UseVisualStyleBackColor = True
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(45, 343)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(201, 76)
        Me.btnRun.TabIndex = 10
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        Me.btnRun.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(295, 343)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(199, 76)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.Visible = False
        '
        'btnExitProgram
        '
        Me.btnExitProgram.Location = New System.Drawing.Point(546, 343)
        Me.btnExitProgram.Name = "btnExitProgram"
        Me.btnExitProgram.Size = New System.Drawing.Size(199, 76)
        Me.btnExitProgram.TabIndex = 12
        Me.btnExitProgram.Text = "Exit"
        Me.btnExitProgram.UseVisualStyleBackColor = True
        Me.btnExitProgram.Visible = False
        '
        'txtAnswer2
        '
        Me.txtAnswer2.Location = New System.Drawing.Point(576, 170)
        Me.txtAnswer2.Name = "txtAnswer2"
        Me.txtAnswer2.Size = New System.Drawing.Size(169, 22)
        Me.txtAnswer2.TabIndex = 6
        Me.txtAnswer2.Visible = False
        '
        'txtAnswer3
        '
        Me.txtAnswer3.Location = New System.Drawing.Point(576, 233)
        Me.txtAnswer3.Name = "txtAnswer3"
        Me.txtAnswer3.Size = New System.Drawing.Size(169, 22)
        Me.txtAnswer3.TabIndex = 7
        Me.txtAnswer3.Visible = False
        '
        'lblStoryOutput
        '
        Me.lblStoryOutput.AutoSize = True
        Me.lblStoryOutput.Location = New System.Drawing.Point(100, 104)
        Me.lblStoryOutput.Name = "lblStoryOutput"
        Me.lblStoryOutput.Size = New System.Drawing.Size(123, 17)
        Me.lblStoryOutput.TabIndex = 9
        Me.lblStoryOutput.Text = "Story Output Here"
        Me.lblStoryOutput.Visible = False
        '
        'lnkMontyPythonVid
        '
        Me.lnkMontyPythonVid.AutoSize = True
        Me.lnkMontyPythonVid.Location = New System.Drawing.Point(139, 309)
        Me.lnkMontyPythonVid.Name = "lnkMontyPythonVid"
        Me.lnkMontyPythonVid.Size = New System.Drawing.Size(545, 17)
        Me.lnkMontyPythonVid.TabIndex = 8
        Me.lnkMontyPythonVid.TabStop = True
        Me.lnkMontyPythonVid.Text = "This Questionnaire is inspired by this Monty Python and the Holy Grail snippet, E" &
    "njoy!"
        '
        'picAskMeTheQuestions
        '
        Me.picAskMeTheQuestions.Location = New System.Drawing.Point(25, 75)
        Me.picAskMeTheQuestions.Name = "picAskMeTheQuestions"
        Me.picAskMeTheQuestions.Size = New System.Drawing.Size(333, 231)
        Me.picAskMeTheQuestions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAskMeTheQuestions.TabIndex = 13
        Me.picAskMeTheQuestions.TabStop = False
        Me.picAskMeTheQuestions.Visible = False
        '
        'frmConcat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picAskMeTheQuestions)
        Me.Controls.Add(Me.lnkMontyPythonVid)
        Me.Controls.Add(Me.lblStoryOutput)
        Me.Controls.Add(Me.txtAnswer3)
        Me.Controls.Add(Me.txtAnswer2)
        Me.Controls.Add(Me.btnExitProgram)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.btnStartQuestionnaire)
        Me.Controls.Add(Me.lblQuestion3)
        Me.Controls.Add(Me.txtAnswer1)
        Me.Controls.Add(Me.lblQuestion2)
        Me.Controls.Add(Me.lblQuestion1)
        Me.Controls.Add(Me.lblID)
        Me.Name = "frmConcat"
        Me.Text = "Heroes Questionnaire Concatenation Form"
        CType(Me.picAskMeTheQuestions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents lblQuestion1 As Label
    Friend WithEvents lblQuestion2 As Label
    Friend WithEvents txtAnswer1 As TextBox
    Friend WithEvents lblQuestion3 As Label
    Friend WithEvents btnStartQuestionnaire As Button
    Friend WithEvents btnRun As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExitProgram As Button
    Friend WithEvents txtAnswer2 As TextBox
    Friend WithEvents txtAnswer3 As TextBox
    Friend WithEvents lblStoryOutput As Label
    Friend WithEvents lnkMontyPythonVid As LinkLabel
    Friend WithEvents picAskMeTheQuestions As PictureBox
End Class
