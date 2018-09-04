Public Class VolumeConversion

    Private calculation As Decimal
    Private input As String
    Private fromMetric As Integer
    Private toMetric As Integer

    'US pint , US Quart, US Gallon
    Private milliliterToMilliliter As Decimal = 1
    Private milliliterToPint As Decimal = 0.00211338
    Private milliliterToQuart As Decimal = 0.00105669
    Private milliliterToGallon As Decimal = 0.00026417

    Private pintToMilliliter As Decimal = 473.176
    Private pintToPint As Decimal = 1
    Private pintToQuart As Decimal = 0.5
    Private pintToGallon As Decimal = 0.125

    Private quartToMilliliter As Decimal = 946.353
    Private quartToPint As Decimal = 2
    Private quartToQuart As Decimal = 1
    Private quartToGallon As Decimal = 0.25

    Private gallonToMilliliter As Decimal = 3785.41
    Private gallonToPint As Decimal = 8
    Private gallonToQuart As Decimal = 4
    Private gallonToGallon As Decimal = 1


    Public Sub New(ByVal fromMetric As Integer, ByVal toMetric As Integer, ByVal input As String)
        Me.fromMetric = fromMetric
        Me.toMetric = toMetric
        Me.input = input
    End Sub


    Public Function Driver()
        'fromMetrc AND toMetric {0 = mL, 1 = US Pint, 2 = US Quart, 3 = US Gallon}
        Select Case fromMetric

            Case 0 'From mL
                If toMetric = 0 Then
                    Return calculate(milliliterToMilliliter)
                ElseIf toMetric = 1 Then
                    Return calculate(milliliterToPint)
                ElseIf toMetric = 2 Then
                    Return calculate(milliliterToQuart)
                ElseIf toMetric = 3 Then
                    Return calculate(milliliterToGallon)
                Else
                    input = "Error"
                    Return input
                End If

            Case 1 'From Pint
                If toMetric = 0 Then
                    Return calculate(pintToMilliliter)
                ElseIf toMetric = 1 Then
                    Return calculate(pintToPint)
                ElseIf toMetric = 2 Then
                    Return calculate(pintToQuart)
                ElseIf toMetric = 3 Then
                    Return calculate(pintToGallon)
                Else
                    input = "Error"
                    Return input
                End If

            Case 2 'From Quart
                If toMetric = 0 Then
                    Return calculate(quartToMilliliter)
                ElseIf toMetric = 1 Then
                    Return calculate(quartToPint)
                ElseIf toMetric = 2 Then
                    Return calculate(quartToQuart)
                ElseIf toMetric = 3 Then
                    Return calculate(quartToGallon)
                Else
                    input = "Error"
                    Return input
                End If

            Case 3 'From Tons
                If toMetric = 0 Then
                    Return calculate(gallonToMilliliter)
                ElseIf toMetric = 1 Then
                    Return calculate(gallonToPint)
                ElseIf toMetric = 2 Then
                    Return calculate(gallonToQuart)
                ElseIf toMetric = 3 Then
                    Return calculate(gallonToGallon)
                Else
                    input = "Error"
                    Return input
                End If


            Case Else
                input = "Error"
                Return input

        End Select

    End Function

    Function calculate(ByVal conversion As Decimal)
        Me.calculation = CInt(input) * conversion
        Return CStr(Math.Round(calculation, 3))
    End Function

End Class
