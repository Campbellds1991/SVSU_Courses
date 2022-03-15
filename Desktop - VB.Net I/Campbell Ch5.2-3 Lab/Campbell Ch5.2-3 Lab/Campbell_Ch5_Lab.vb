Public Class Campbell_Ch5_Lab
    '   Program: Chapter 5 Section 2,3 Lab
    '   Name: Devin Campbell
    '   Date: 3/21/16
    '   Class: CS146 - WM - Sec 2

    ' Ex5.2.1
    Private Sub BtnAddNumbers_Click(sender As Object, e As EventArgs) Handles Ex5_21_BtnAddNumbers.Click
        DisplaySum(1, 2)
        Dim x As Double = 3
        Dim y As Double = 4
        DisplaySum(x, y)
        DisplaySum(2 * x, y + 5)
    End Sub
    Sub DisplaySum(Num1 As Double, Num2 As Double)
        Dim z As Double = Num1 + Num2
        Ex5_21_LstOutput.Items.Add("the sum of " & Num1 & " and " & Num2 &
                               " is " & z & ".")
    End Sub
    ' Ex5.2.2
    Private Sub Ex2_2_BtnDisplay_Click(sender As Object, e As EventArgs) Handles Ex5_22_BtnDisplay.Click
        Dim state As String, pop, landArea As Double
        Ex5_22_LstDensity.Items.Clear()
        state = "Hawaii"
        pop = 1375000
        landArea = 6423
        CalculateDensity(state, pop, landArea)
        Ex5_22_LstDensity.Items.Add(" ")
        state = "Alaska"
        pop = 722718
        landArea = 570600
        CalculateDensity(state, pop, landArea)
    End Sub
    Sub CalculateDensity(state As String, pop As Double, landArea As Double)
        Dim density As Double
        density = pop / landArea
        Ex5_22_LstDensity.Items.Add("The density of " & state & " Is ")
        Ex5_22_LstDensity.Items.Add(density.ToString("n1") & " people per square mile.")
    End Sub
    ' Ex5.2.4
    Private Sub Ex2_4_BtnDisplay_Click(sender As Object, e As EventArgs) Handles Ex5_24_BtnDisplay.Click
        FirstPart()
        Ex5_24_LstOutput.Items.Add(4 & " from event procedure")
    End Sub

    Sub FirstPart()
        Ex5_24_LstOutput.Items.Add(1 & " from FirstPart")
        SecondPart()
        Ex5_24_LstOutput.Items.Add(3 & " from FirstPart")
    End Sub
    Sub SecondPart()
        Ex5_24_LstOutput.Items.Add(2 & " from SecondPart")
    End Sub
    ' Ex 5.3.1
    Private Sub Ex5_31_BtnDisplay_Click(sender As Object, e As EventArgs) Handles Ex5_31_BtnDisplay.Click
        Dim amt As Double = 2
        Ex5_31_LstOutput.Items.Add(amt & " from event procedure")
        Triple(amt)
        Ex5_31_LstOutput.Items.Add(amt & " from event procedure")
    End Sub
    Sub Triple(num As Double)
        'Triple a number
        Ex5_31_LstOutput.Items.Add(num & " from Sub procedure")
        num = 3 * num
        Ex5_31_LstOutput.Items.Add(num & " from Sub procedure")
    End Sub
    ' Ex 5.3.2
    Private Sub Ex5_32_BtnCompute_Click(sender As Object, e As EventArgs) Handles Ex5_32_BtnCompute.Click
        Dim x, y As Double
        Ex5_32_GetNumbers(x, y)
        Ex5_32_DisplaySum(x, y)
    End Sub
    Sub Ex5_32_GetNumbers(ByRef x As Double, ByRef y As Double)
        x = CDbl(Ex5_32_TxtFirstNum.Text)
        y = CDbl(Ex5_32_TxtSecondNum.Text)
    End Sub
    Sub Ex5_32_DisplaySum(ByVal numl As Double, ByVal num2 As Double)
        Dim sum As Double
        sum = numl + num2
        Ex5_32_TxtResult.Text = ("The sum of " & numl & " And " &
            num2 & " Is " & sum & ".")
    End Sub
    ' Ex 5.3.3
    Private Sub Ex5_33_BtnSort_Click(sender As Object, e As EventArgs) Handles Ex5_33_BtnSort.Click
        Dim Word1 As String = Ex5_33_TxtFirst.Text
        Dim Word2 As String = Ex5_33_TxtSecond.Text
        If (Word2 < Word1) Then
            SwapWords(Word1, Word2)
        End If
        Ex5_33_TxtOutput.Text = Word1 & " before " & Word2
    End Sub
    Sub SwapWords(ByRef wordl As String, ByRef word2 As String)
        Dim temp As String
        temp = wordl
        wordl = word2
        word2 = temp
    End Sub
End Class