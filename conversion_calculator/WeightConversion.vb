Public Class WeightConversion

    Private calculation As Decimal
    Private input As String
    Private fromMetric As Integer
    Private toMetric As Integer

    Private gramsToGramsRatio As Decimal = 1
    Private gramsToOzRatio As Decimal = 0.035274
    Private gramsToLbsRatio As Decimal = 0.00220462
    Private gramsToTonsRatio As Decimal = 0.00000110231

    Private ozToGramsRatio As Decimal = 28.3494925
    Private ozToOzRatio As Decimal = 1
    Private ozToLbsRatio As Decimal = 0.0625
    Private ozToTonsRatio As Decimal = 0.00003125

    Private lbsToGramsRatio As Decimal = 453.592
    Private lbsToOzRatio As Decimal = 16
    Private lbsToLbsRatio As Decimal = 1
    Private lbsToTonsRatio As Decimal = 0.0005

    Private tonsToGramsRatio As Decimal = 907185.818871
    Private tonsToOzRatio As Decimal = 32000
    Private tonsToLbsRatio As Decimal = 2000
    Private tonsToTonsRatio As Decimal = 1


    Public Sub New(ByVal fromMetric As Integer, ByVal toMetric As Integer, ByVal input As String)
        Me.fromMetric = fromMetric
        Me.toMetric = toMetric
        Me.input = input
    End Sub


    Public Function Driver()
        'fromMetrc AND toMetric {0 = grams, 1 = oz, 2 = lbs, 3 = tons}
        Select Case fromMetric

            Case 0 'From Grams
                If toMetric = 0 Then
                    Return calculate(gramsToGramsRatio)
                ElseIf toMetric = 1 Then
                    Return calculate(gramsToOzRatio)
                ElseIf toMetric = 2 Then
                    Return calculate(gramsToLbsRatio)
                ElseIf toMetric = 3 Then
                    Return calculate(gramsToTonsRatio)
                Else
                    input = "Error"
                    Return input
                End If

            Case 1 'From Oz
                If toMetric = 0 Then
                    Return calculate(ozToGramsRatio)
                ElseIf toMetric = 1 Then
                    Return calculate(ozToOzRatio)
                ElseIf toMetric = 2 Then
                    Return calculate(ozToLbsRatio)
                ElseIf toMetric = 3 Then
                    Return calculate(ozToTonsRatio)
                Else
                    input = "Error"
                    Return input
                End If

            Case 2 'From Lbs
                If toMetric = 0 Then
                    Return calculate(lbsToGramsRatio)
                ElseIf toMetric = 1 Then
                    Return calculate(lbsToOzRatio)
                ElseIf toMetric = 2 Then
                    Return calculate(lbsToLbsRatio)
                ElseIf toMetric = 3 Then
                    Return calculate(lbsToTonsRatio)
                Else
                    input = "Error"
                    Return input
                End If

            Case 3 'From Tons
                If toMetric = 0 Then
                    Return calculate(tonsToGramsRatio)
                ElseIf toMetric = 1 Then
                    Return calculate(tonsToOzRatio)
                ElseIf toMetric = 2 Then
                    Return calculate(tonsToLbsRatio)
                ElseIf toMetric = 3 Then
                    Return calculate(tonsToTonsRatio)
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
        Return CStr(Math.Round(calculation, 3))
    End Function

End Class
