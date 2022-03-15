Public Class CampbellCh71Lab
    ' Example 7.1.1
    Private Sub Ex7_1_BtnWhoWon_Click(sender As Object, e As EventArgs) Handles Ex7_1_BtnWhoWon.Click
        Dim teamNames(3) As String
        Dim n As Integer
        teamNames(0) = "Packers "
        teamNames(1) = "Packers"
        teamNames(2) = "Jets"
        teamNames(3) = "Chiefs"
        n = CInt(Ex7_1_MtbNumber.Text)
        Ex7_1_TxtWinner.Text = teamNames(n - 1)
    End Sub

    ' Example 7.1.2
    Dim Ex2_teamNames(3) As String
    Private Sub CampbellCh71Lab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ex2_teamNames(0) = "Packers "
        Ex2_teamNames(1) = "Packers"
        Ex2_teamNames(2) = "Jets"
        Ex2_teamNames(3) = "Chiefs"
    End Sub

    Private Sub Ex7_2_BtnWhoWon_Click(sender As Object, e As EventArgs) Handles Ex7_2_BtnWhoWon.Click
        Dim n As Integer
        n = CInt(Ex7_2_MtbNumber.Text)
        Ex7_2_TxtWinner.Text = Ex2_teamNames(n - 1)
    End Sub

    ' Example 7.1.3
    Private Sub Ex7_3_BtnDisplay_Click(sender As Object, e As EventArgs) Handles Ex7_3_BtnDisplay.Click
        Dim ages(43) As Integer
        Dim temp() As String = IO.File.ReadAllLines("AgesAtinaugural.txt")
        For i As Integer = 0 To 43
            ages(i) = CInt(temp(i))
        Next
        Ex7_3_LstValues.Items.Add("Obama: " & ages(ages.Count - 1))
        Ex7_3_LstValues.Items.Add("Washington:  " & ages.First)
        Ex7_3_LstValues.Items.Add("Obama " & ages.Last)
        Ex7_3_LstValues.Items.Add("Oldest Age: " & ages.Max)
        Ex7_3_LstValues.Items.Add("Youngest age " & ages.Min)
        Ex7_3_LstValues.Items.Add("Average age: " & (ages.Average).ToString("N"))
        Ex7_3_LstValues.Items.Add("Average age: " & (ages.Sum / ages.Count).ToString("N"))
    End Sub

    ' Example 7.1.7
    Dim states() As String = IO.File.ReadAllLines("states.txt")
    Private Sub Ex7_7_BtnDetermine_Click(sender As Object, e As EventArgs) Handles Ex7_7_BtnDetermine.Click
        Dim n As Integer, state As String
        state = Ex7_7_TxtState.Text
        n = Array.IndexOf(states, state)
        If n <> -1 Then
            Ex7_7_TxtOutput.Text = state & " was state number " & n + 1 & "."
        Else
            MessageBox.Show("Re-enter a state name.", "Error")
            Ex7_7_TxtState.Clear()
            Ex7_7_TxtState.Focus()
        End If
    End Sub

    ' Example 7.1.8
    Private Sub Ex7_8_BtnExtract_Click(sender As Object, e As EventArgs) Handles Ex7_8_BtnExtract.Click
        Dim FullName As String = Ex7_8_TxtFull.Text
        Dim ParsedName() As String = FullName.Split(" "c)
        Ex7_8_TxtFirst.Text = ParsedName.First
        Ex7_8_TxtLast.Text = ParsedName.Last
    End Sub
End Class
