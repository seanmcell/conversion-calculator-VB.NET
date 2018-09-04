Public Class DistanceConversion

    Private calculation As Decimal
    Private input As String
    Private fromMetric As Integer
    Private toMetric As Integer

    Private yardsToYards As Decimal = 1
    Private yardsToMiles As Decimal = 0.000568182
    Private yardsToMeters As Decimal = 0.9144
    Private yardsToKilometers As Decimal = 0.0009144

    Private milesToYards As Decimal = 1 / 1760
    Private milesToMiles As Decimal = 1
    Private milesToMeters As Decimal = 1 / 1609.34
    Private milesToKilometers As Decimal = 1 / 1.60934

    Private metersToYards As Decimal = 1 / 1.09361
    Private metersToMiles As Decimal = 0.000621371
    Private metersToMeters As Decimal = 1
    Private metersToKilometers As Decimal = 0.001

    Private killometersToYards As Decimal = 1 / 1093.61
    Private killometerToMiles As Decimal = 0.621371
    Private killometersToMeters As Decimal = 1 / 1000
    Private killometersToKilometers As Decimal = 1


    Public Sub New(ByVal fromMetric As Integer, ByVal toMetric As Integer, ByVal input As String)
        Me.fromMetric = fromMetric
        Me.toMetric = toMetric
        Me.input = input

    End Sub


    Public Function Driver()
        'fromMetrc AND toMetric {0 = Yards, 1 = Miles, 2 = Meters, 3 = Kilometers}
        Select Case fromMetric

            Case 0 'From Yards
                If toMetric = 0 Then
                    Return calculate(yardsToYards)
                ElseIf toMetric = 1 Then
                    Return calculate(yardsToMiles)
                ElseIf toMetric = 2 Then
                    Return calculate(yardsToMeters)
                ElseIf toMetric = 3 Then
                    Return calculate(yardsToKilometers)
                Else
                    input = "Error"
                    Return input
                End If

            Case 1 'From Oz
                If toMetric = 0 Then
                    Return calculate(milesToYards)
                ElseIf toMetric = 1 Then
                    Return calculate(milesToMiles)
                ElseIf toMetric = 2 Then
                    Return calculate(milesToMeters)
                ElseIf toMetric = 3 Then
                    Return calculate(milesToKilometers)
                Else
                    input = "Error"
                    Return input
                End If

            Case 2 'From Lbs
                If toMetric = 0 Then
                    Return calculate(metersToYards)
                ElseIf toMetric = 1 Then
                    Return calculate(metersToMiles)
                ElseIf toMetric = 2 Then
                    Return calculate(metersToMeters)
                ElseIf toMetric = 3 Then
                    Return calculate(metersToKilometers)
                Else
                    input = "Error"
                    Return input
                End If

            Case 3 'From Tons
                If toMetric = 0 Then
                    Return calculate(killometersToYards)
                ElseIf toMetric = 1 Then
                    Return calculate(killometerToMiles)
                ElseIf toMetric = 2 Then
                    Return calculate(killometersToMeters)
                ElseIf toMetric = 3 Then
                    Return calculate(killometersToKilometers)
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
