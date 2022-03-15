' ************************************************************************************
' Program:CH5-PP-3
' Name: Devin Campbell  
' Date: 03/22/2016
' Class: CS146-02 (M-W)
' Program Desc: Company Invoice Form: 
'       Produces a Invoice from a sale of goods including:
'           Customer info and Product info
'                              
'   Input: 
'       Each line in its own array.
'           * Customer Name, Customer Address, Customer City_State_Zip
'           * Number of Stove(s), Refrigerator(s), and Dishwasher(s)
'
'       --- Declared Constants: Stove, Refrigerator, and Dishwasher Costs ---
'    
'   Process:  
'       1) Set Name to Last, First Format
'       2) Set Invoice to First 2 letters of last name in caps and last 4 of the Zip
'
'   Output: 
'       Display in ListBox a organized Listbox finalizing the Invoice
'
' ***************************************************************************************
Public Class FrmOrder
    Const STOVECOST As Double = 695
    Const REFRIGCOST As Double = 1195
    Const DISHCOST As Double = 345
    Const TAXRATE As Double = 0.06

    Private Sub BtnProcess_Click(sender As Object, e As EventArgs) Handles BtnProcess.Click
        Dim InvoiceNo As String = ""
        Dim Customer() = {"", "", ""}
        Dim OrderOut() = {0, 0, 0}
        input(TxtCustName.Text, TxtCustAddress.Text, TxtCustCSZ.Text, TxtOrder_Stove.Text,
              TxtOrder_Refridg.Text, TxtOrder_Dishwasher.Text, Customer, OrderOut)
        Process_Order(Customer, OrderOut, InvoiceNo)
        Output(InvoiceNo, Customer, OrderOut)
    End Sub

    Private Sub input(ByRef Name As String, ByRef Address As String, ByRef CSZ As String, NoStove As String,
                      NoRefridge As String, NoDishwasher As String, ByRef Customer() As String, ByRef OrderOut() As Integer)
        ' Customer()
        ' (0) = FullName Dishwasher
        ' (1) = Address 
        ' (2) = City, State, Zip
        Customer(0) = Name
        Customer(1) = Address
        Customer(2) = CSZ
        Dim CustHeader() As String = New String() {" Name", "n Address", " City, State, and Zip"}

        ' Check to ensure values are numeric
        '
        ' OrderOut()
        ' (0) = Stoves
        ' (1) = Refridgerator
        ' (2) = Dishwasher
        If (IsNumeric(NoStove)) Then
            OrderOut(0) = Integer.Parse(NoStove)
        Else
            OrderOut(0) = 0
        End If
        If (IsNumeric(NoRefridge)) Then
            OrderOut(1) = Integer.Parse(NoRefridge)
        Else
            OrderOut(1) = 0
        End If
        If (IsNumeric(NoDishwasher)) Then
            OrderOut(2) = Integer.Parse(NoDishwasher)
        Else
            OrderOut(2) = 0
        End If

        ' Validates that there is data entered in each textbox
        For i As Integer = 0 To Customer.Length - 1
            If Customer(i).Equals("") Then
                Customer(i) = InputBox("Please Enter a" + CustHeader(i), "Invalid Data")
            End If
        Next i

        ' Sets blank cells to 0
        For j As Integer = 0 To OrderOut.Length - 1
            If OrderOut(j).Equals("") Or OrderOut(j) < 1 Then
                OrderOut(j) = 0
            End If
        Next j
    End Sub
    ' Produces the correct Name format for the invoice and creates and Invoice number
    Private Sub Process_Order(ByRef Customer() As String, ByRef OrderOut() As Integer, ByRef InvoiceNo As String)
        Customer(0) = NameLastFirst(Customer(0))
        InvoiceNo = Invoice_Number(Customer(0), Customer(2))
    End Sub
    Private Sub Output(InvoiceNo As String, Customer() As String, OrderOut() As Integer)
        ' Sets the output format of the output Listbox
        Dim FmtStr_CustInfo As String = "{0,-10}{1}"
        Dim FmtStr_OrderInfo As String = "{0,-23}{1,2} @ {2,10:C} = {3,12:C}"
        Dim FmtStr_Total As String = "{0,40}{1,13:C}"
        Dim SubTotalCost As Double = (OrderOut(0) * STOVECOST + OrderOut(1) * REFRIGCOST +
            OrderOut(2) * DISHCOST)

        With LstOut_Invoice.Items
            .Clear()
            .Add("Invoice Number: " & InvoiceNo)
            .Add("")
            .Add(String.Format(FmtStr_CustInfo, "Name:", Customer(0)))
            .Add(String.Format(FmtStr_CustInfo, "Address:", Customer(1)))
            .Add(String.Format(FmtStr_CustInfo, "City:", Customer(2)))
        End With
        ' Prints line only if quantity is > 0
        If (OrderOut(0) > 0) Then
            LstOut_Invoice.Items.Add(String.Format(FmtStr_OrderInfo, "No of Stoves:",
                                                   OrderOut(0), STOVECOST, OrderOut(0) * STOVECOST))
        End If
        If (OrderOut(1) > 0) Then
            LstOut_Invoice.Items.Add(String.Format(FmtStr_OrderInfo, "No of Refrigerators:",
                                                   OrderOut(1), REFRIGCOST, OrderOut(1) * REFRIGCOST))
        End If
        If (OrderOut(2) > 0) Then
            LstOut_Invoice.Items.Add(String.Format(FmtStr_OrderInfo, "No of Dishwashers:",
                                                   OrderOut(2), DISHCOST, OrderOut(2) * DISHCOST))
        End If
        ' Subtotals, Taxes, Final Total
        LstOut_Invoice.Items.Add(String.Format(FmtStr_Total, " ", "------------"))
        LstOut_Invoice.Items.Add(String.Format(FmtStr_Total, "Price:", SubTotalCost))
        LstOut_Invoice.Items.Add(String.Format(FmtStr_Total, "Sales Tax:", SubTotalCost * TAXRATE))
        LstOut_Invoice.Items.Add(String.Format(FmtStr_Total, "", "------------"))
        LstOut_Invoice.Items.Add(String.Format(FmtStr_Total, "Total Price:", SubTotalCost * (1 + TAXRATE)))
    End Sub
    ' Outputs the Invoice Number
    Private Function Invoice_Number(Name As String, CSZ As String)
        Name = Name.Substring(0, 2).ToUpper
        Dim i As Integer
        i = CSZ.Length
        CSZ = CSZ.Substring(i - 4)
        Dim InvoiceNo = Name & CSZ
        Return InvoiceNo
    End Function
    ' Sets name to (Last, First) format
    Function NameLastFirst(ByRef FullName)
        Dim i As Integer = FullName.IndexOf(" ")
        Dim temp As String = FullName.Substring(0, i)
        FullName = FullName.Substring(i + 1)
        FullName = FullName & ", " & temp
        Return FullName
    End Function
    ' Clears the listbox and textboxs
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        LstOut_Invoice.Items.Clear()
        TxtCustName.Text = ""
        TxtCustAddress.Text = ""
        TxtCustCSZ.Text = ""
        TxtOrder_Stove.Text = "0"
        TxtOrder_Refridg.Text = "0"
        TxtOrder_Dishwasher.Text = "0"
    End Sub
    ' Close the application
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        Me.Close()
    End Sub

End Class
