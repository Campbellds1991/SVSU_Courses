Public Class FrmCampbell_Ch6
    '   Program: Chapter 6 Sections 1,2,3 Lab
    '   Name: Devin Campbell
    '   Date: 3/28/16
    '   Class: CS146 - WM - Sec 2


    Private Sub Ex1_1_BtnDisplay_Click(sender As Object, e As EventArgs) Handles Ex1_1_BtnDisplay.Click
        Dim num As Integer = 1
        Do While num <= 7
            Ex1_1_LstOutput.Items.Add(num)
            num += 1
        Loop
    End Sub

    Private Sub Ex1_2_BtnDisplay_Click(sender As Object, e As EventArgs) Handles Ex1_2_BtnDisplay.Click
        Dim Response As Integer, quote As String = ""
        Do
            Response = CInt(InputBox("Enter a Number from 1 to 3"))
        Loop Until (Response >= 1) And (Response <= 3)
        Select Case Response
            Case 1 : quote = "Plastics"
            Case 2 : quote = "Rosebud"
            Case 3 : quote = "That's all folks."
        End Select
        Ex1_2_TxtOutput.Text = quote
    End Sub

    Private Sub Ex2_2_BtnDisplay_Click(sender As Object, e As EventArgs) Handles Ex2_2_BtnDisplay.Click
        Dim n, s As Double
        n = CDbl(Ex2_2_TxtEnd.Text)
        s = CDbl(Ex2_2_TxtStep.Text)
        Ex2_2_LstValues.Items.Clear()
        For index As Double = 0 To n Step s
            Ex2_2_LstValues.Items.Add(index)
        Next
    End Sub

    Private Sub Ex2_3_BtnReverse_Click(sender As Object, e As EventArgs) Handles Ex2_3_BtnReverse.Click
        Ex2_3_TxtBackwards.Text = Reverse(Ex2_3_TxtWord.Text)
    End Sub

    Function Reverse(info As String) As String
        Dim m As Integer, Temp As String = ""
        m = info.Length
        For j As Integer = m - 1 To 0 Step -1
            Temp &= info.Substring(j, 1)
        Next
        Return Temp
    End Function

    Private Sub Ex2_4_BtnDisplay_Click(sender As Object, e As EventArgs) Handles Ex2_4_BtnDisplay.Click
        Dim row, entry As String
        Ex2_4_LstTable.Items.Clear()
        For j As Integer = 1 To 3
            row = ""
            For k As Integer = 1 To 3
                entry = j & " x " & k & " = " & (j * k)
                row &= entry & "   "

            Next
            Ex2_4_LstTable.Items.Add(row)
        Next
    End Sub

    Private Sub Ex3_1_BtnLast10_Click(sender As Object, e As EventArgs) Handles Ex3_1_BtnLast10.Click
        Dim n As Integer = Ex3_1_LstStates.Items.Count
        For i As Integer = (n - 1) To (n - 10) Step -1
            Ex3_1_LstLast10.Items.Add(Ex3_1_LstStates.Items(i))
        Next
    End Sub

    Private Sub Ex3_2_BtnSearch_Click(sender As Object, e As EventArgs) Handles Ex3_2_BtnSearch.Click
        Dim Letters As String = Ex3_2_MtbFirstTwoLetters.Text.ToUpper
        Dim FoundFlag As Boolean = False
        Dim i As Integer = -1
        Do Until (FoundFlag) Or (i = Ex3_1_LstStates.Items.Count - 1)
            i += 1
            If CStr(Ex3_2_LstStates.Items(i).toUpper.StartsWith(Letters)) Then
                FoundFlag = True
            End If
        Loop
        If FoundFlag Then
            Ex3_2_TxtOutput.Text = CStr(Ex3_2_LstStates.Items(i)) & " is state #" & (i + 1) & "."
        Else
            Ex3_2_TxtOutput.Text = "No state begins with " & Ex3_2_MtbFirstTwoLetters.Text & "."
        End If
    End Sub

    Private Sub Ex3_3_BtnRecord_Click(sender As Object, e As EventArgs) Handles Ex3_3_BtnRecord.Click
        Ex3_3_LstGrades.Items.Add(Ex3_3_TxtGrade.Text)
        Ex3_3_TxtGrade.Clear()
        Ex3_3_TxtGrade.Focus()
    End Sub

    Private Sub Ex3_3_BtnCalculate_Click(sender As Object, e As EventArgs) Handles Ex3_3_BtnCalculate.Click
        Dim Sum As Double = 0
        Dim MaxGrade As Double = 0
        If Ex3_3_LstGrades.Items.Count > 0 Then
            For i As Integer = 0 To Ex3_3_LstGrades.Items.Count - 1
                Sum += CDbl(Ex3_3_LstGrades.Items(i))
                If CDbl(Ex3_3_LstGrades.Items(i)) > MaxGrade Then
                    MaxGrade = CDbl(Ex3_3_LstGrades.Items(i))
                End If
            Next
            Ex3_3_TxtAverage.Text = (Sum / Ex3_3_LstGrades.Items.Count).ToString("N0")
            Ex3_3_TxtHighest.Text = CStr(MaxGrade)
        Else
            MessageBox.Show("You must first enter some grades.")
        End If
    End Sub
End Class
