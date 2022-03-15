Imports System.Data.OleDb
'------------------------------------------------------------
'-                File Name : MainForm.vb                   -
'-                Part of Project: AssignX                  -
'------------------------------------------------------------
'-                Written By: Devin Campbell                - 
'-                Written On: 3/28/2017        				-
'------------------------------------------------------------
'- File Purpose:                                            -
'- User Generated Code exists here. Including the load, 	-
'- database creation, and database manipulation events.     -                                 
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This Program's main purpose is to add, edit, and delete 	-
'- customers from a database And view their related orders 	-
'- placed													-
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'- DBConn – Object with the data connection parameters 		-
'- DBCustomers – Adapter for Customers Table 				-
'- DBOrders - Adapter for Orders Table						-
'------------------------------------------------------------

Public Class MainForm
	Public DBConn As OleDbConnection
	Public DBCustomers, DBOrders As OleDbDataAdapter

	Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
		Dim strDBName As String = "AppData\CustomerDB.mdb"
		Dim strConn As String = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = {strDBName}"
		'Build Database and Tables as needed
		CreateDataBase(strConn)
		'Set Text boxes to read only status
		txtID.ReadOnly = True
		TxtEntryState(False)
		'Threading.Thread.Sleep(500)
		DBCustomers = New OleDbDataAdapter("SELECT * FROM Customers", strConn)
        DBOrders = New OleDbDataAdapter("SELECT * FROM Orders", strConn)

        Try
			DBCustomers.Fill(CustomerDataSet, "Customers")
			DBOrders.Fill(CustomerDataSet, "Orders")
		Catch ex As Exception
			MsgBox(ex.Message, Title:="Exception Encountered")
			Environment.Exit(-1)
		End Try
		bsCustomers_PositionChanged(Nothing, Nothing)
	End Sub
	'-----------------------------------------------------------
	'-                Subprogram Name: CreateDataBase          -
	'-----------------------------------------------------------
	'-                Written By: Devin Campbell               -     
	'-                Written On: 3/28/2017        			   -
	'-----------------------------------------------------------
	'- Subprogram Purpose:                                     -
	'-                                                         -
	'- Creates a blank database or required tables if they do  -
	'-	Not exist                                        	   -
	'-----------------------------------------------------------
	'- Parameter Dictionary (in parameter order):              -
	'- strConn – database build location                       -            
	'-----------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):             -
	'- DBCat - Builds the Database File						   -
	'- DBCommand - builds and issues the sql statements used to-
	'-	build And modify the database And its tables		   -
	'-----------------------------------------------------------

	Private Sub CreateDataBase(strConn As String)
		'Creates Catalog / Database
		Dim DBCat As New ADOX.Catalog()
		Dim DBCommand As New OleDbCommand()
		Try
			DBCat.Create(strConn)
			Debug.WriteLine("Created DataBase")
		Catch ex As Exception
			Debug.WriteLine("DataBase Already Existed")
		End Try

		DBConn = New OleDbConnection(strConn)
		DBConn.Open()
		' Creates Customer Table
		DBCommand = New OleDbCommand("CREATE TABLE Customers (CustomerID INTEGER PRIMARY KEY,FirstName VARCHAR,LastName VARCHAR,StreetAddress VARCHAR,City VARCHAR,State VARCHAR(2),ZipCode VARCHAR(5))") With {
			.Connection = DBConn}
		Try
			DBCommand.ExecuteNonQuery()
			Debug.WriteLine("Created Customers Table")
		Catch ex As Exception
			Debug.WriteLine("Customers Table Already Exists")
		End Try
		' Creates Order Table
		DBCommand = New OleDbCommand("CREATE TABLE Orders (OrderNum INTEGER PRIMARY KEY,CustID INTEGER REFERENCES Customers(CustomerID) ON UPDATE CASCADE ON DELETE CASCADE,ItemNumber VARCHAR,ItemName VARCHAR,Quantity NUMERIC,ItemPrice NUMERIC)") With {
			.Connection = DBConn}
		Try
			DBCommand.ExecuteNonQuery()
			Debug.WriteLine("Created Orders Table")
		Catch ex As Exception
			Debug.WriteLine("Orders Table Already Exists")
		End Try
		DBConn.Close()
	End Sub
	'-----------------------------------------------------------
	'-                Subprogram Name: TxtEntryState            
	'-----------------------------------------------------------
	'-                Written By: Devin Campbell				    
	'-                Written On: 3/28/2017						
	'-----------------------------------------------------------
	'- Subprogram Purpose:                                      
	'-                                                          
	'- Changes the state of the textboxes readonly state to
	'- prevent unwanted changes               
	'-----------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               
	'- WriteAccess – Declares whether a user has permission to 
	'- edit a text field
	'-----------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              
	'- (None)                                                    
	'------------------------------------------------------------

	Public Sub TxtEntryState(WriteAccess As Boolean)
		txtNameFirst.ReadOnly = Not WriteAccess
		txtNameLast.ReadOnly = Not WriteAccess
		txtAddrSt.ReadOnly = Not WriteAccess
		txtAddrCity.ReadOnly = Not WriteAccess
		txtAddrState.ReadOnly = Not WriteAccess
		txtAddrZip.ReadOnly = Not WriteAccess
	End Sub
	'-----------------------------------------------------------
	'-                Subprogram Name: AddRecord            
	'-----------------------------------------------------------
	'-                Written By: Devin Campbell				    
	'-                Written On: 3/28/2017						
	'-----------------------------------------------------------
	'- Subprogram Purpose:                                      
	'-                                                          
	'- Button that holds two purposes, first is to delegate an 
	'- add record Event, the second To issue a save Of changes 
	'- all based On the text inside the control                             
	'-----------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               
	'- sender – Identifies which particular control raised the  
	'-          click event                                     
	'- e – Holds the EventArgs object sent to the routine       
	'-----------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              
	'- (None)                                                   
	'-----------------------------------------------------------  

	Public Sub AddRecord(sender As Button, e As EventArgs) Handles cmdAddRecord.Click
		Select Case sender.Text
			Case "Add"
				bsCustomers.AddNew()
				TxtEntryState(True)
				cmdAddRecord.Text = "Save"
				cmdDeleteRecord.Text = "Cancel"
				For Each control In gbCustInfo.Controls
					If TypeOf control Is TextBox Then
						control.Text = ""
					End If
				Next
				txtID.Text = (Aggregate id In CustomerDataSet.Customers Into Max(id.CustomerID)) + 1
				For Each control In gbCustInfo.Controls
					If TypeOf control Is Button And Not (control.Name = "cmdAddRecord" Or control.Name = "cmdDeleteRecord") Then
						control.Visible = False
					End If
				Next
            Case "Save"
                Using temp As New OleDbCommandBuilder(DBCustomers)
                    Try
                        Validate()
                        bsCustomers.EndEdit()
                        bsOrders.EndEdit()
                        DBCustomers.Update(CustomerDataSet, "Customers")
                        DBOrders.Update(CustomerDataSet, "Orders")
                        CustomerDataSet.AcceptChanges()
                    Catch ex As Exception
                        MsgBox(ex.Message, Title:="Exception encountered")
                        Exit Sub
                    End Try
                    cmdAddRecord.Text = "Add"
                    cmdDeleteRecord.Text = "Delete"
                    TxtEntryState(False)
                    For Each control In gbCustInfo.Controls
                        If TypeOf control Is Button And (Not control.Name = "cmdAddRecord" Or Not control.Name = "cmdDeleteRecord") Then
                            control.Visible = True
                        End If
                    Next
                End Using

        End Select
	End Sub
	'-----------------------------------------------------------
	'-                Subprogram Name: DeleteRecord            
	'-----------------------------------------------------------
	'-                Written By: Devin Campbell				    
	'-                Written On: 3/28/2017						
	'-----------------------------------------------------------
	'- Subprogram Purpose:                                      
	'-                                                          
	'- Button that holds two purposes, first is to delegate an 
	'- Delete record Event, the second To cancel any changes 
	'- made against the database         
	'-----------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               
	'- sender – Identifies which particular control raised the  
	'-          click event                                     
	'- e – Holds the EventArgs object sent to the routine       
	'-----------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              
	'- (None)                                                   
	'----------------------------------------------------------- 
	Private Sub DeleteRecord(sender As Button, e As EventArgs) Handles cmdDeleteRecord.Click
		Select Case sender.Text
			Case "Delete"
				If MsgBox("Are you sure you want to delete this record", Title:="Deleting Record", Buttons:=MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
					CustomerDataSet.Customers.FindByCustomerID(txtID.Text).Delete()
					bsCustomers.EndEdit()
					DBCustomers.DeleteCommand = New OleDbCommandBuilder(DBCustomers).GetDeleteCommand()
					DBCustomers.Update(CustomerDataSet, "Customers")
					CustomerDataSet.AcceptChanges()
				End If
			Case "Cancel"
				bsCustomers.CancelEdit()
				CustomerDataSet.RejectChanges()
				cmdAddRecord.Text = "Add"
				cmdDeleteRecord.Text = "Delete"
				TxtEntryState(False)
				For Each control In gbCustInfo.Controls
					If TypeOf control Is Button And (Not control.Name = "cmdAddRecord" Or Not control.Name = "cmdDeleteRecord") Then
						control.Visible = True
					End If
				Next
		End Select
	End Sub
	'-----------------------------------------------------------
	'-                Subprogram Name: UpdateRecord            
	'-----------------------------------------------------------
	'-                Written By: Devin Campbell				    
	'-                Written On: 3/28/2017						
	'-----------------------------------------------------------
	'- Subprogram Purpose:                                      
	'-                                                          
	'- this command unlocks the text fields so you can edit 
	'-	the data displayed On the current record 
	'-----------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               
	'- sender – Identifies which particular control raised the  
	'-          click event                                     
	'- e – Holds the EventArgs object sent to the routine       
	'-----------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              
	'- (None)                                                   
	'----------------------------------------------------------- 
	Private Sub UpdateRecord(sender As Object, e As EventArgs) Handles cmdUpdateRecord.Click
		TxtEntryState(True)
		cmdAddRecord.Text = "Save"
		cmdDeleteRecord.Text = "Cancel"
		For Each control In gbCustInfo.Controls
			If TypeOf control Is Button And Not (control.Name = "cmdAddRecord" Or control.Name = "cmdDeleteRecord") Then
				control.Visible = False
			End If
		Next
	End Sub
	'-----------------------------------------------------------
	'-                Subprogram Name: NavigateRecord            
	'-----------------------------------------------------------
	'-                Written By: Devin Campbell				    
	'-                Written On: 3/28/2017						
	'-----------------------------------------------------------
	'- Subprogram Purpose:                                      
	'-                                                          
	'- Moves the pointer on the data set relative to the 
	'-	directory button pressed On the gui
	'-----------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               
	'- sender – Identifies which particular control raised the  
	'-          click event                                     
	'- e – Holds the EventArgs object sent to the routine       
	'-----------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              
	'- (None)                                                   
	'----------------------------------------------------------- 
	Private Sub NavigateRecord(sender As Button, e As EventArgs) Handles cmdFirstRecord.Click, cmdPrevRecord.Click, cmdNextRecord.Click, cmdLastRecord.Click
		Select Case sender.Name
			Case cmdFirstRecord.Name
				bsCustomers.MoveFirst()
			Case cmdPrevRecord.Name
				bsCustomers.MovePrevious()
			Case cmdNextRecord.Name
				bsCustomers.MoveNext()
			Case cmdLastRecord.Name
				bsCustomers.MoveLast()
		End Select
	End Sub
	'-----------------------------------------------------------
	'-           Subprogram Name: bsCustomers_PositionChanged            
	'-----------------------------------------------------------
	'-                Written By: Devin Campbell				    
	'-                Written On: 3/28/2017						
	'-----------------------------------------------------------
	'- Subprogram Purpose:                                      
	'-                                                          
	'- Repopulates the Orders in the datagridview based on the 
	'-	visible customer
	'-----------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               
	'- sender – Identifies which particular control raised the  
	'-          click event                                     
	'- e – Holds the EventArgs object sent to the routine       
	'-----------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              
	'- (None)                                                   
	'----------------------------------------------------------- 
	Private Sub bsCustomers_PositionChanged(sender As Object, e As EventArgs) Handles bsCustomers.PositionChanged
		dgvOrders.DataSource = (From records In CustomerDataSet.Orders
								Where records.CustID = CInt(txtID.Text)
								Select OrderNumber = records.OrderNum,
								records.ItemNumber,
								records.ItemName,
								records.Quantity,
								records.ItemPrice,
								Total = records.ItemPrice * records.Quantity).ToList()
	End Sub
End Class