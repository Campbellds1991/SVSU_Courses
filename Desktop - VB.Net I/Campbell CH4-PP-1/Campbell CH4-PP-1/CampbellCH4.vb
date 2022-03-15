'''***********************************************************************************************************
'''     Name: Devin Campbell
'''     Class: CS146 - 02 - MW
'''     Date: 3-2-2016
'''     
'''     Program:
'''         Input:
'''             6 Checkboxes internally limited to no more then 1 concurrent selection per item
'''         Process:
'''             0) On Load:
'''                 On Load, initialize and format List box that contains 
'''                     the order menu for customers to see
'''             1) Checkboxes:
'''                 a) When selected, Remove selection from opposite Checkbox
'''                 b) Start OrderCode() Process
'''             2) OrderCode():
'''                 a) Set TotalOut (Totals purchase cost) to 0 in order to restart receipt
'''                 b) Per Item, check for the state of Each item, then set 
'''                     a numerical code in order to process reciept later
'''                 c) Start ReceiptOut() Process
'''             3) ReceiptOut():
'''                 a) Set format used to display the receipt
'''                 b) using case statements, compare each items code in 
'''                     order to determine the proper output for each line
'''                 c) determine if any box is checked, if so, place the deposit above the line
'''                     seperating the total
'''                 d) Closing statement
'''         Output:
'''             Listbox including each item, as they are required, the Deposit, and total of all items checked.
''' 
'''************************************************************************************************************
Public Class CampbellCH4
    ' Global variables

    Const TRUCK_PRICE As Double = 85
    Const TRAILER_PRICE As Double = 50
    Const DOLLY_PRICE As Double = 20
    Const FULL_DAY_MODIFIER As Double = 1.5
    Const DEPOSIT As Double = 50
    Dim isTruckOut As Char
    Dim isTrailerOut As Char
    Dim isDollyOut As Char
    Dim TotalOut As Double

    ' listbox used to display pricing and options will be initialized at time program is loaded
    Private Sub CampbellCH4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim FmtHeader As String = "{0,-22}{1,10}{2,10}"
        Dim FmtDetails As String = "{0,9}{1,6}{2,-7}{3,10:C}{4,10:C}"

        With LstPricing.Items
            .Add(String.Format(FmtHeader, "Price of Equipment:", "Half-Day", "Full-Day"))
            .Add(String.Format(FmtDetails, "Half    ", "Full    ", "", "", ""))
            .Add(String.Format(FmtDetails, "", "", "Truck", TRUCK_PRICE,
                               TRUCK_PRICE * FULL_DAY_MODIFIER))
            .Add(String.Format(FmtDetails, "", "", "Trailer",
                               TRAILER_PRICE, TRAILER_PRICE * FULL_DAY_MODIFIER))
            .Add(String.Format(FmtDetails, "", "", "Dolly",
                               DOLLY_PRICE, DOLLY_PRICE * FULL_DAY_MODIFIER))
        End With
        ReceiptOut()
    End Sub
    ' Following events control the checkmarks in order to ensure each item is only checked once, then updates
    '       the reciept to show the updated listing

    Private Sub CkbTruckHalf_CheckedChanged(sender As Object, e As EventArgs) Handles CkbTruckHalf.CheckedChanged
        CkbTruckFull.CheckState = False
        OrderCode()
    End Sub

    Private Sub CkbTruckFull_CheckedChanged(sender As Object, e As EventArgs) Handles CkbTruckFull.CheckedChanged
        CkbTruckHalf.CheckState = False
        OrderCode()
    End Sub

    Private Sub CkbTrailerHalf_CheckedChanged(sender As Object, e As EventArgs) Handles CkbTrailerHalf.CheckedChanged
        CkbTrailerFull.CheckState = False
        OrderCode()
    End Sub

    Private Sub CkbTrailerFull_CheckedChanged(sender As Object, e As EventArgs) Handles CkbTrailerFull.CheckedChanged
        CkbTrailerHalf.CheckState = False
        OrderCode()
    End Sub

    Private Sub CkbDollyHalf_CheckedChanged(sender As Object, e As EventArgs) Handles CkbDollyHalf.CheckedChanged
        CkbDollyFull.CheckState = False
        OrderCode()
    End Sub

    Private Sub CkbDollyFull_CheckedChanged(sender As Object, e As EventArgs) Handles CkbDollyFull.CheckedChanged
        CkbDollyHalf.CheckState = False
        OrderCode()
    End Sub

    Private Sub OrderCode()
        TotalOut = 0
        ' Use chars as the following,  0 for no Units out, 
        '       1 for Half-Day rental, 2 for Full-Day Rental

        '---- Truck ----
        If CkbTruckFull.CheckState = CheckState.Checked Then
            isTruckOut = "2"
            TotalOut += TRUCK_PRICE * FULL_DAY_MODIFIER
        ElseIf CkbTruckHalf.CheckState = CheckState.Checked Then
            isTruckOut = "1"
            TotalOut += TRUCK_PRICE
        Else
            isTruckOut = "0"
        End If
        '---- Trailer ----
        If CkbTrailerFull.Checked = True Then
            isTrailerOut = "2"
            TotalOut += TRAILER_PRICE * FULL_DAY_MODIFIER
        ElseIf CkbTrailerHalf.Checked Then
            isTrailerOut = "1"
            TotalOut += TRAILER_PRICE
        Else
            isTrailerOut = "0"
        End If
        '---- Dolly ----
        If CkbDollyFull.Checked = True Then
            isDollyOut = "2"
            TotalOut += DOLLY_PRICE * FULL_DAY_MODIFIER
        ElseIf CkbDollyHalf.Checked Then
            isDollyOut = "1"
            TotalOut += DOLLY_PRICE
        Else
            isDollyOut = "0"
        End If

        ReceiptOut()
    End Sub

    Private Sub ReceiptOut()

        ' Select case used in order to ensure the output for each item is properly addressed
        '       as each checkbox is selected

        Dim FmtReciept As String = "{0,-23}{1,10:C}{2,20}"
        With LstReciept.Items
            .Clear()
            .Add(String.Format(FmtReciept, "Receipt from Campbell's Equipment Rental", "", ""))
            .Add("")
            Select Case isTruckOut
                Case "0"
                    Exit Select
                Case "1"
                    .Add(String.Format(FmtReciept, "Truck: ", TRUCK_PRICE, "(Half-day Charge)"))
                Case "2"
                    .Add(String.Format(FmtReciept, "Truck: ", TRUCK_PRICE * FULL_DAY_MODIFIER,
                                       "(Full-day Charge)"))
            End Select
            Select Case isTrailerOut
                Case "0"
                    Exit Select
                Case "1"
                    .Add(String.Format(FmtReciept, "Trailer: ", TRAILER_PRICE, "(Half-day Charge)"))
                Case "2"
                    .Add(String.Format(FmtReciept, "Trailer: ", TRAILER_PRICE * FULL_DAY_MODIFIER,
                                       "(Full-day Charge)"))
            End Select
            Select Case isDollyOut
                Case "0"
                    Exit Select
                Case "1"
                    .Add(String.Format(FmtReciept, "Dolly: ", DOLLY_PRICE, "(Half-day Charge)"))
                Case "2"
                    .Add(String.Format(FmtReciept, "Dolly: ", DOLLY_PRICE * FULL_DAY_MODIFIER,
                                       "(Full-day Charge)"))
            End Select

            ' verifies that atleast one item is selected, if so, Deposit is applied
            If (CkbDollyFull.Checked = True Or CkbDollyHalf.Checked = True Or
                        CkbTrailerFull.Checked = True Or CkbTrailerHalf.Checked = True Or
                        CkbTruckFull.Checked = True Or CkbTruckHalf.Checked = True) Then
                .Add(String.Format(FmtReciept, "Deposit:", DEPOSIT, ""))
                TotalOut += DEPOSIT
            End If
            .Add(String.Format(FmtReciept, "", "---------------", ""))
            .Add(String.Format(FmtReciept, "Total Cost of Rental: ", TotalOut, ""))
            .Add("")
            .Add("Have a Good Day!")
        End With
    End Sub


End Class
