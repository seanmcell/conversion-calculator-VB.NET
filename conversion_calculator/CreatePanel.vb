Public Class CreatePanel
    Dim panel As New Panel()
    Dim fromSelected As Integer
    Dim toSelected As Integer

    Public Sub New()

        Dim lblTo As New Label
        lblTo.Text = "TO"
        lblTo.Location = New Point(377, 143)
        lblTo.Size = New System.Drawing.Size(30, 17)
        panel.Controls.Add(lblTo)

        'Buttons From Top To Bottom - 0-3
        Me.btnLeft0 = New Button
        Me.btnLeft1 = New Button
        Me.btnLeft2 = New Button
        Me.btnLeft3 = New Button

        Me.btnRight0 = New Button
        Me.btnRight1 = New Button
        Me.btnRight2 = New Button
        Me.btnRight3 = New Button


        panel.Location = New Point(0, 143)
        panel.Size = New Size(800, 307)

        '----------------From Buttons-----------------------------------


        Me.btnLeft0.Location = New Point(235, 37)
        Me.btnLeft0.Size = New Size(130, 60)
        Me.btnLeft0.BackColor = Color.Black
        Me.btnLeft0.ForeColor = Color.White
        Me.panel.Controls.Add(btnLeft0)

        Me.btnLeft1.Location = New Point(235, 91)
        Me.btnLeft1.Size = New Size(130, 60)
        Me.btnLeft1.BackColor = Color.Black
        Me.btnLeft1.ForeColor = Color.White
        Me.panel.Controls.Add(btnLeft1)

        Me.btnLeft2.Location = New Point(235, 147)
        Me.btnLeft2.Size = New Size(130, 60)
        Me.btnLeft2.BackColor = Color.Black
        Me.btnLeft2.ForeColor = Color.White
        Me.panel.Controls.Add(btnLeft2)

        Me.btnLeft3.Location = New Point(235, 205)
        Me.btnLeft3.Size = New Size(130, 60)
        Me.btnLeft3.ForeColor = Color.White
        Me.btnLeft3.BackColor = Color.Black
        Me.panel.Controls.Add(btnLeft3)

        '-----------------To Buttons----------------------------------------

        Me.btnRight0.Location = New Point(414, 37)
        Me.btnRight0.Size = New Size(130, 60)
        Me.btnRight0.BackColor = Color.Black
        Me.btnRight0.ForeColor = Color.White
        Me.panel.Controls.Add(btnRight0)

        Me.btnRight1.Location = New Point(414, 91)
        Me.btnRight1.Size = New Size(130, 60)
        Me.btnRight1.BackColor = Color.Black
        Me.btnRight1.ForeColor = Color.White
        Me.panel.Controls.Add(btnRight1)

        Me.btnRight2.Location = New Point(414, 147)
        Me.btnRight2.Size = New Size(130, 60)
        Me.btnRight2.BackColor = Color.Black
        Me.btnRight2.ForeColor = Color.White
        Me.panel.Controls.Add(btnRight2)

        Me.btnRight3.Location = New Point(414, 205)
        Me.btnRight3.Size = New Size(130, 60)
        Me.btnRight3.ForeColor = Color.White
        Me.btnRight3.BackColor = Color.Black
        Me.panel.Controls.Add(btnRight3)

    End Sub


    Function getPanel() As Panel
        Return Me.panel
    End Function



    'Set Button Texts------------------------------------------------------------------------
    Public Sub setLeftButtonsText(ByVal btnText0 As String, ByVal btnText1 As String,
                             ByVal btnText2 As String, ByVal btnText3 As String)
        Me.btnLeft0.Text = btnText0
        Me.btnLeft1.Text = btnText1
        Me.btnLeft2.Text = btnText2
        Me.btnLeft3.Text = btnText3

    End Sub

    Public Sub setRightButtonsText(ByVal btnText0 As String, ByVal btnText1 As String,
                             ByVal btnText2 As String, ByVal btnText3 As String)
        Me.btnRight0.Text = btnText0
        Me.btnRight1.Text = btnText1
        Me.btnRight2.Text = btnText2
        Me.btnRight3.Text = btnText3
    End Sub


    'Handle button clicks -----------------------------------------------------------------------------
    Public Sub btnLeft0_Click(sender As System.Object, e As System.EventArgs) Handles btnLeft0.Click
        Me.btnLeft0.BackColor = Color.Red
        Me.btnLeft1.BackColor = Color.Black
        Me.btnLeft2.BackColor = Color.Black
        Me.btnLeft3.BackColor = Color.Black
        Me.fromSelected = 0
    End Sub


    Public Sub btnLeft1_Click(sender As System.Object, e As System.EventArgs) Handles btnLeft1.Click
        btnLeft0.BackColor = Color.Black
        btnLeft1.BackColor = Color.Red
        btnLeft2.BackColor = Color.Black
        btnLeft3.BackColor = Color.Black
        Me.fromSelected = 1
    End Sub


    Public Sub btnLeft2_Click(sender As System.Object, e As System.EventArgs) Handles btnLeft2.Click
        btnLeft0.BackColor = Color.Black
        btnLeft1.BackColor = Color.Black
        btnLeft2.BackColor = Color.Red
        btnLeft3.BackColor = Color.Black
        Me.fromSelected = 2
    End Sub


    Public Sub btnLeft3_Click(sender As System.Object, e As System.EventArgs) Handles btnLeft3.Click
        btnLeft0.BackColor = Color.Black
        btnLeft1.BackColor = Color.Black
        btnLeft2.BackColor = Color.Black
        btnLeft3.BackColor = Color.Red
        Me.fromSelected = 3
    End Sub


    '----------------------------------------
    Public Sub btnRight0_Click(sender As System.Object, e As System.EventArgs) Handles btnRight0.Click
        btnRight0.BackColor = Color.Red
        btnRight1.BackColor = Color.Black
        btnRight2.BackColor = Color.Black
        btnRight3.BackColor = Color.Black
        Me.toSelected = 0
    End Sub

    Public Sub btnRight1_Click(sender As System.Object, e As System.EventArgs) Handles btnRight1.Click
        btnRight0.BackColor = Color.Black
        btnRight1.BackColor = Color.Red
        btnRight2.BackColor = Color.Black
        btnRight3.BackColor = Color.Black
        Me.toSelected = 1
    End Sub

    Public Sub btnRight2_Click(sender As System.Object, e As System.EventArgs) Handles btnRight2.Click
        btnRight0.BackColor = Color.Black
        btnRight1.BackColor = Color.Black
        btnRight2.BackColor = Color.Red
        btnRight3.BackColor = Color.Black
        Me.toSelected = 2
    End Sub

    Public Sub btnRight3_Click(sender As System.Object, e As System.EventArgs) Handles btnRight3.Click
        btnRight0.BackColor = Color.Black
        btnRight1.BackColor = Color.Black
        btnRight2.BackColor = Color.Black
        btnRight3.BackColor = Color.Red
        Me.toSelected = 3
    End Sub


    WithEvents btnLeft0 As Button
    WithEvents btnLeft1 As Button
    WithEvents btnLeft2 As Button
    WithEvents btnLeft3 As Button

    WithEvents btnRight0 As Button
    WithEvents btnRight1 As Button
    WithEvents btnRight2 As Button
    WithEvents btnRight3 As Button


    Function getFromSelected() As Integer
        Return Me.fromSelected
    End Function

    Function getToSelected() As Integer
        Return Me.toSelected
    End Function

End Class
