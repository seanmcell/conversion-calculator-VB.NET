Public Class CurrencyConversion

    Private calculation As Decimal
    Private input As String
    Private fromMetric As Integer
    Private toMetric As Integer

    'Google - Sep 4, 2018 3:22 AM UTC
    Private usdToUSD As Decimal = 1
    Private usdToEUR As Decimal = 0.86
    Private usdToCAD As Decimal = 1 / 1.31
    Private usdToAUS As Decimal = 1 / 1.39

    Private eurToUSD As Decimal = 1 / 1.16
    Private eurToEUR As Decimal = 1
    Private eurToCAD As Decimal = 1 / 1.52
    Private eurToAUS As Decimal = 1 / 1.61

    Private cadToUSD As Decimal = 0.76
    Private cadToEUR As Decimal = 0.66
    Private cadToCAD As Decimal = 1
    Private cadToAUS As Decimal = 1 / 1.06

    Private ausToUSD As Decimal = 0.72
    Private ausToEUR As Decimal = 0.62
    Private ausToCAD As Decimal = 0.94
    Private ausToAUS As Decimal = 1


    Public Sub New(ByVal fromMetric As Integer, ByVal toMetric As Integer, ByVal input As String)
        Me.fromMetric = fromMetric
        Me.toMetric = toMetric
        Me.input = input

    End Sub


    Public Function Driver()
        'fromMetrc AND toMetric {0 = USD, 1 = EUR, 2 = CAD, 3 = AUS}
        Select Case fromMetric

            Case 0 'From USD
                If toMetric = 0 Then
                    Return calculate(usdToUSD)
                ElseIf toMetric = 1 Then
                    Return calculate(usdToEUR)
                ElseIf toMetric = 2 Then
                    Return calculate(usdToCAD)
                ElseIf toMetric = 3 Then
                    Return calculate(usdToAUS)
                Else
                    input = "Error"
                    Return input
                End If

            Case 1 'From EUR
                If toMetric = 0 Then
                    Return calculate(eurToUSD)
                ElseIf toMetric = 1 Then
                    Return calculate(eurToEUR)
                ElseIf toMetric = 2 Then
                    Return calculate(eurToCAD)
                ElseIf toMetric = 3 Then
                    Return calculate(eurToAUS)
                Else
                    input = "Error"
                    Return input
                End If

            Case 2 'From CAD
                If toMetric = 0 Then
                    Return calculate(cadToUSD)
                ElseIf toMetric = 1 Then
                    Return calculate(cadToEUR)
                ElseIf toMetric = 2 Then
                    Return calculate(cadToCAD)
                ElseIf toMetric = 3 Then
                    Return calculate(cadToAUS)
                Else
                    input = "Error"
                    Return input
                End If

            Case 3 'From AUS
                If toMetric = 0 Then
                    Return calculate(ausToUSD)
                ElseIf toMetric = 1 Then
                    Return calculate(ausToEUR)
                ElseIf toMetric = 2 Then
                    Return calculate(ausToCAD)
                ElseIf toMetric = 3 Then
                    Return calculate(ausToAUS)
                Else
                    input = "Error"
                    Return input
                End If

            Case Else
                input = "Error"
                Return input

        End Select

    End Function

    Function calculate(ByRef conversion As Decimal)
        Me.calculation = CInt(input) * conversion
        Return CStr(Math.Round(calculation, 2))
    End Function

End Class
