Public Class Campbell_Ch72
    Private Sub Ex1_BtnDisplay_Click(sender As Object, e As EventArgs) Handles Ex1_BtnDisplay.Click
        Dim states() As String = IO.File.ReadAllLines("States.txt")
        Dim stateQuery1 = From state In states
                          Where state.Length = 5
                          Select state
        For Each state As String In stateQuery1
            Ex1_LstOutput.Items.Add(state)
        Next
        Ex1_LstOutput.Items.Add("")
        Dim stateQuery2 = From state In states
                          Where state.StartsWith("New")
                          Select state
        For Each state As String In stateQuery2
            Ex1_LstOutput.Items.Add(state)
        Next
End Sub

    Private Sub Ex2_BtnDisplay_Click(sender As Object, e As EventArgs) Handles Ex2_BtnDisplay.Click
        Dim nums() As Integer = {5, 12, 8, 7, 11}
        Dim numQuery1 = From num In nums
                        Where num > 7
                        Select num
        For Each num As Integer In numQuery1
            Ex2_LstOutput.Items.Add(num)
        Next
        Ex2_LstOutput.Items.Add("Largest number: " & numQuery1.Max)
        Ex2_LstOutput.Items.Add("Second number: " & numQuery1(1))
        Ex2_LstOutput.Items.Add("Sum of numbers : " & numQuery1.Sum)
        Ex2_LstOutput.Items.Add("")
        Dim numQuery2 = From num In nums
                        Where num Mod 2 = 0
                        Select num
        Ex2_LstOutput.Items.Add("Number of even numbers: " & numQuery2.Count)
        Ex2_LstOutput.Items.Add("Average of even numbers: " & numQuery2.Average)
        Ex2_LstOutput.Items.Add("Last even number: " & numQuery2.Last)
    End Sub

    Private Sub Ex4_BtnSort_Click(sender As Object, e As EventArgs) Handles Ex4_BtnSort.Click
        Dim nums() As Integer = {3, 6, 4, 1}
        Dim numQuery = From num In nums
                       Order By num Ascending
                       Select num
        For Each n As Integer In numQuery
                Ex4_LstOutput.Items.Add(n)
            Next
    End Sub

    Private Sub Ex5_BtnDisplay_Click(sender As Object, e As EventArgs) Handles Ex5_BtnDisplay.Click
        Dim states() As String = IO.File.ReadAllLines("States.txt")
        Dim stateQuery = From state In states
                 Order By state.Length Ascending, state Descending
                 Select state
        For Each state As String In stateQuery
            Ex5_LstStates.Items.Add(state)
        Next
    End Sub
End Class
