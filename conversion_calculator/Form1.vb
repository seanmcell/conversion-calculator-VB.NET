Public Class Conversion_Calculator
    Dim weightMetric As Boolean = False
    Dim volumeMetric As Boolean = False
    Dim currencyMetric As Boolean = False
    Dim distanceMetric As Boolean = False

    Dim calculation As String
    Dim input As String = ""

    Dim panelsCreated As Boolean = False
    Dim weightPanel As Panel
    Dim volumePanel As Panel
    Dim currencyPanel As Panel
    Dim distancePanel As Panel

    Dim createWeightPanel = New CreatePanel
    Dim createVolumePanel = New CreatePanel
    Dim createDistancePanel = New CreatePanel
    Dim createCurrencyPanel = New CreatePanel

    '--------------------Creates All Panels Once User Selects A Metric Button----------------------------------
    Private Sub createPanels()

        createWeightPanel.setLeftButtonsText("Grams", "Oz", "lbs", "Tons")
        createWeightPanel.setRightButtonsText("Grams", "Oz", "lbs", "Tons")
        weightPanel = createWeightPanel.getPanel
        weightPanel.BackColor = Color.White

        createVolumePanel.setLeftButtonsText("Milliliter", "Pint", "Quart", "Gallon")
        createVolumePanel.setRightButtonsText("Milliliter", "Pint", "Quart", "Gallon")
        volumePanel = createVolumePanel.getPanel
        volumePanel.BackColor = Color.Violet

        createCurrencyPanel.setLeftButtonsText("USD", "EUR", "CAD", "AUS")
        createCurrencyPanel.setRightButtonsText("USD", "EUR", "CAD", "AUS")
        currencyPanel = createCurrencyPanel.getPanel
        currencyPanel.BackColor = Color.Green

        createDistancePanel.setLeftButtonsText("Yards", "Miles", "Meters", "Kilometers")
        createDistancePanel.setRightButtonsText("Yards", "Miles", "Meters", "Kilometers")
        distancePanel = createDistancePanel.getPanel
        distancePanel.BackColor = Color.Blue

        Controls.Add(weightPanel)
        Controls.Add(volumePanel)
        Controls.Add(currencyPanel)
        Controls.Add(distancePanel)

        panelsCreated = True
        pnlStart.Visible = False

    End Sub


    '--------------------------------Buttons That Switch Metric Panels-------------------------------------------------

    '------------------------Each Button Hides Other Metric Panels--------------------------
    Private Sub btnWeight_Click(sender As Object, e As EventArgs) Handles btnWeight.Click
        If panelsCreated = False Then
            createPanels()
        End If

        currencyPanel.Visible = False
        distancePanel.Visible = False
        volumePanel.Visible = False
        weightPanel.Visible = True

        weightMetric = True
        volumeMetric = False
        currencyMetric = False
        distanceMetric = False
    End Sub


    Private Sub btnVolume_Click(sender As Object, e As EventArgs) Handles btnVolume.Click
        If panelsCreated = False Then
            createPanels()
        End If

        weightPanel.Visible = False
        currencyPanel.Visible = False
        distancePanel.Visible = False
        volumePanel.Visible = True

        weightMetric = False
        volumeMetric = True
        currencyMetric = False
        distanceMetric = False
    End Sub

    Private Sub btnCurrency_Click(sender As Object, e As EventArgs) Handles btnCurrency.Click
        If panelsCreated = False Then
            createPanels()
        End If

        weightPanel.Visible = False
        distancePanel.Visible = False
        volumePanel.Visible = False
        currencyPanel.Visible = True

        weightMetric = False
        volumeMetric = False
        currencyMetric = True
        distanceMetric = False

    End Sub


    Private Sub btnDistance_Click(sender As Object, e As EventArgs) Handles btnDistance.Click
        If panelsCreated = False Then
            createPanels()
        End If

        weightPanel.Visible = False
        currencyPanel.Visible = False
        volumePanel.Visible = False
        distancePanel.Visible = True

        weightMetric = False
        volumeMetric = False
        currencyMetric = False
        distanceMetric = True
    End Sub




    '------------------------------------------Get Input Text After Convert Button Is Clicked---------------------------------------------
    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        input = txtInput.Text
    End Sub




    '-----------------------Converts Based On Which Metric Panel Is Currently Visible-----------------------------
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim fromSelected As Integer
        Dim toSelected As Integer


        If weightMetric = True Then
            fromSelected = createWeightPanel.getFromSelected
            toSelected = createWeightPanel.getToSelected
            Dim weight As New WeightConversion(fromSelected, toSelected, input)
            calculation = weight.Driver()
            lblConvertedInput.Text = calculation


            Select Case fromSelected
                Case 0
                    lblFromMetric.Text = "Grams"
                Case 1
                    lblFromMetric.Text = "Oz"
                Case 2
                    lblFromMetric.Text = "lbs"
                Case 3
                    lblFromMetric.Text = "Tons"
            End Select

            Select Case toSelected
                Case 0
                    lblConvertedMetric.Text = "Grams"
                Case 1
                    lblConvertedMetric.Text = "Oz"
                Case 2
                    lblConvertedMetric.Text = "lbs"
                Case 3
                    lblConvertedMetric.Text = "Tons"
            End Select

        ElseIf volumeMetric = True Then
            fromSelected = createVolumePanel.getFromSelected
            toSelected = createVolumePanel.getToSelected
            Dim volume As New VolumeConversion(fromSelected, toSelected, input)
            calculation = volume.Driver()
            lblConvertedInput.Text = calculation

            Select Case fromSelected
                Case 0
                    lblFromMetric.Text = "Milliliter"
                Case 1
                    lblFromMetric.Text = "Pint"
                Case 2
                    lblFromMetric.Text = "Quart"
                Case 3
                    lblFromMetric.Text = "Gallon"
            End Select

            Select Case toSelected
                Case 0
                    lblConvertedMetric.Text = "Milliliter"
                Case 1
                    lblConvertedMetric.Text = "Pint"
                Case 2
                    lblConvertedMetric.Text = "Quart"
                Case 3
                    lblConvertedMetric.Text = "Gallon"
            End Select

        ElseIf currencyMetric = True Then
            fromSelected = createCurrencyPanel.getFromSelected
            toSelected = createCurrencyPanel.getToSelected
            Dim currency As New CurrencyConversion(fromSelected, toSelected, input)
            calculation = currency.Driver()
            lblConvertedInput.Text = calculation

            Select Case fromSelected
                Case 0
                    lblFromMetric.Text = "USD"
                Case 1
                    lblFromMetric.Text = "EUR"
                Case 2
                    lblFromMetric.Text = "CAD"
                Case 3
                    lblFromMetric.Text = "AUS"
            End Select

            Select Case toSelected
                Case 0
                    lblConvertedMetric.Text = "USD"
                Case 1
                    lblConvertedMetric.Text = "EUR"
                Case 2
                    lblConvertedMetric.Text = "CAD"
                Case 3
                    lblConvertedMetric.Text = "AUS"
            End Select

        ElseIf distanceMetric = True Then
            fromSelected = createDistancePanel.getFromSelected
            toSelected = createDistancePanel.getToSelected
            Dim distance As New DistanceConversion(fromSelected, toSelected, input)
            calculation = distance.Driver()
            lblConvertedInput.Text = calculation

            Select Case fromSelected
                Case 0
                    lblFromMetric.Text = "Yards"
                Case 1
                    lblFromMetric.Text = "Miles"
                Case 2
                    lblFromMetric.Text = "Meters"
                Case 3
                    lblFromMetric.Text = "Kilometers"
            End Select

            Select Case toSelected
                Case 0
                    lblConvertedMetric.Text = "Yards"
                Case 1
                    lblConvertedMetric.Text = "Miles"
                Case 2
                    lblConvertedMetric.Text = "Meters"
                Case 3
                    lblConvertedMetric.Text = "Kilometers"
            End Select

        End If

    End Sub

End Class
