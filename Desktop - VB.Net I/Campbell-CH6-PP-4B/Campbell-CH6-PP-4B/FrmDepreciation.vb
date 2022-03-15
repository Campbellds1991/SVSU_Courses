Public Class FrmDepreciation
    ' Program:  Campbell CH6-PP-4B
    ' Name:     Devin Campbell
    ' Class:    CS146-02-MW
    ' Date:     04-03-16
    '
    ' Input:    Entered Data into 4 text fields
    ' Process:  
    '           1) Start by Clearing the output box for each button A & B
    '               A) Straight-Line Method
    '               B) Double-Declining-Balance Method
    '           2) Run data through checks to verify integrity
    '              ***note: if data fails any test, user will be 
    '                   asked to re-input data and require user to press button again***
    '           3) Populate output box with user data including method specific to button pressed
    '           4) Calculate using Data provided in textboxes
    ' Output:  
    '           Display Listing of depreciation based on factors determined by user.

    ' Button A
    Private Sub BtnStraightMethod_Click(sender As Object, e As EventArgs) Handles BtnStraightMethod.Click
        LstOutput.Items.Clear()
        ValidityTest()
        Header("Method: Straight-Line")
        SingleCalc()
    End Sub
    ' Button B
    Private Sub BtnDblMethod_Click(sender As Object, e As EventArgs) Handles BtnDblMethod.Click
        LstOutput.Items.Clear()
        ValidityTest()
        Header("Method: Double-Declining-Balance")
        DoubleCalc()
    End Sub
    ' ensures that numerical data fields are as such.
    Private Sub ValidityTest()
        While (Not IsNumeric(TxtStartValue.Text))
            ' When numerical testing failes, Requires user to input new data until data qualifies
            TxtStartValue.Text = InputBox("Cost is invalid, Please enter a numerical cost w/ no Symbols")
        End While
        While (Not IsNumeric(TxtStartYear.Text))
            TxtStartYear.Text = InputBox("Starting Year is invalid, Please enter a numerical Year w/ no Symbols")
        End While
        While (Not IsNumeric(TxtDuration.Text))
            TxtDuration.Text = InputBox("Estimated Life is invalid, Please enter a numerical cost w/ no Symbols")
        End While
    End Sub
    ' inputs the first few lines of information into the textboxes
    Sub Header(StrMethod As String)
        With LstOutput.Items
            .Add("Description: " & TxtItem.Text)
            .Add("Year of purchase: " & TxtStartYear.Text)
            .Add("Cost: " & String.Format("{0,-1:C}", CDbl(TxtStartValue.Text)))
            .Add("Estimated life: " & TxtDuration.Text)
            .Add(StrMethod)
            .Add("")
        End With
    End Sub
    ' Calculates a Straight-Line depreciation
    Sub SingleCalc()
        Dim StrColumnTitles As String = "{0,-6}{1,12}{2,16}    {3,-20}"
        Dim StrColumnValues As String = "{0,-6}{1,12:C}{2,14:C}{3,19:C}"
        Dim ValueStart As Double = CDbl(TxtStartValue.Text)
        Dim Depreciation As Double = CDbl(TxtStartValue.Text) / CDbl(TxtDuration.Text)
        Dim ValueEnd As Double = 0.0
        Dim Year As Integer = CInt(TxtStartYear.Text)
        LstOutput.Items.Add(String.Format(
                 StrColumnTitles, "", "Value at", "Amount Deprec", "Total Depreciation"))
        LstOutput.Items.Add(String.Format(
                 StrColumnTitles, "Year", "Beg of Yr", "During Year", "to End of Year"))
        Do While (CInt(ValueStart) > 0)
            ValueEnd += Depreciation
            LstOutput.Items.Add(String.Format(
                 StrColumnValues, Year, ValueStart, Depreciation, ValueEnd))
            ValueStart -= Depreciation
            Year += 1
        Loop
    End Sub
    ' Calculates a Double-Declining-Balance depreciation
    Sub DoubleCalc()
        Dim StrColumnTitles As String = "{0,-6}{1,12}{2,16}    {3,-20}"
        Dim StrColumnValues As String = "{0,-6}{1,12:C}{2,14:C}{3,19:C}"
        Dim ValueStart As Double = CDbl(TxtStartValue.Text)
        Dim Depreciation As Double = 0
        Dim ValueEnd As Double = 0.0
        Dim Duration As Double = CDbl(TxtDuration.Text)
        Dim Year As Integer = CInt(TxtStartYear.Text)
        LstOutput.Items.Add(String.Format(
                 StrColumnTitles, "", "Value at", "Amount Deprec", "Total Depreciation"))
        LstOutput.Items.Add(String.Format(
                 StrColumnTitles, "Year", "Beg of Yr", "During Year", "to End of Year"))
        For i As Integer = 0 To Duration - 2
            Depreciation = ValueStart * 2 / Duration
            ValueEnd += Depreciation
            LstOutput.Items.Add(String.Format(
                 StrColumnValues, Year, ValueStart, Depreciation, ValueEnd))
            Year += 1
            ValueStart -= Depreciation
        Next
        ValueEnd += ValueStart
        LstOutput.Items.Add(String.Format(
                 StrColumnValues, Year, ValueStart, ValueStart, ValueEnd))

    End Sub
    ' Ends Program when "Quit" button is pressed
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        Me.Close()
    End Sub
End Class
