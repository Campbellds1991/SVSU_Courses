Imports System.IO

Public Class Campbell_Ch8_Lab

    ' Campbell Ch8 Lab
    ' Devin Campbell
    ' CS146-02-MW
    ' 4/20/16

    Private Sub Btn_8_1_Click(sender As Object, e As EventArgs) Handles Btn_8_1.Click
        Dim agesAtInaug() As String = IO.File.ReadAllLines("AgeAtInaug.txt")
        Dim query = From line In agesAtInaug
                    Let age = CInt(line.Split(","c)(1))
                    Order By age
                    Select line
        IO.File.WriteAllLines("Sorted.Txt", query)
    End Sub

    Private Sub BtnSort_Click(sender As Object, e As EventArgs) Handles BtnSort.Click
        Dim agesAtInaug() As String = IO.File.ReadAllLines("Sorted.txt")
        Dim Query = From line In agesAtInaug
                    Let name = line.Split(","c)(0)
                    Let age = CInt(line.Split(","c)(1))
                    Select name, age
        Dgv_8_2.DataSource = Query.ToList
        Dgv_8_2.CurrentCell = Nothing
    End Sub

    Dim firstSet() As String = IO.File.ReadAllLines("File1.txt")
    Dim SecondSet() As String = IO.File.ReadAllLines("File2.txt")
    Private Sub Btn_8_5_ConcatWRep_Click(sender As Object, e As EventArgs) Handles Btn_8_5_ConcatWRep.Click
        IO.File.WriteAllLines("Concat.txt", firstSet.Concat(SecondSet))
    End Sub
    Private Sub Btn_8_5_ConcatWoRep_Click(sender As Object, e As EventArgs) Handles Btn_8_5_ConcatWoRep.Click
        IO.File.WriteAllLines("Union.txt", firstSet.Union(SecondSet))
    End Sub
    Private Sub Btn_8_5_IntersectFiles_Click(sender As Object, e As EventArgs) Handles Btn_8_5_IntersectFiles.Click
        IO.File.WriteAllLines("Intersect.txt", firstSet.Intersect(SecondSet))
    End Sub
    Private Sub Btn_8_5_Remove2From1_Click(sender As Object, e As EventArgs) Handles Btn_8_5_Remove2From1.Click
        IO.File.WriteAllLines("Except.txt", firstSet.Except(SecondSet))
    End Sub
    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect_8_9.Click
        Dim TextFile As String
        OpenFileDialog1.ShowDialog()
        TextFile = OpenFileDialog1.FileName
        LstOutput_8_9.DataSource = IO.File.ReadAllLines(TextFile)
        LstOutput_8_9.SelectedItem = Nothing
    End Sub

    Private Sub BtnAdd_8_2_3_Click(sender As Object, e As EventArgs) Handles BtnAdd_8_2_3.Click
        Dim Person As String = TxtName_8_2_3.Text
        If Person <> "" Then
            If IsInFile(Person) Then
                MessageBox.Show(Person & " is already in the file.", "Alert")
            Else
                Dim SW As StreamWriter = File.AppendText("Names.txt")
                SW.WriteLine(Person)
                SW.Close()
                MessageBox.Show(Person & " added to file.", "Name Added")
                TxtName_8_2_3.Clear()
                TxtName_8_2_3.Focus()
            End If
        Else
            MessageBox.Show("You must enter a name.", "information Incomplete")
        End If
    End Sub

    Private Sub BtnDetermine_8_2_3_Click(sender As Object, e As EventArgs) Handles BtnDetermine_8_2_3.Click
        Dim Person As String = TxtName_8_2_3.Text
        If Person <> "" Then
            If IsInFile(Person) Then
                MessageBox.Show(Person & " is in the file.", "Yes")
            Else
                MessageBox.Show(Person & " is not in the file.", "No")
            End If
        Else
            MessageBox.Show("You must enter a name.", "information Incomplete")
        End If
        TxtName_8_2_3.Clear()
        TxtName_8_2_3.Focus()
    End Sub

    Private Sub BtnDelete_8_2_3_Click(sender As Object, e As EventArgs) Handles BtnDelete_8_2_3.Click
        Dim Person As String = TxtName_8_2_3.Text
        If Person <> "" Then
            If IsInFile(Person) Then
                Dim sr As StreamReader = File.OpenText("Names.txt")
                Dim sw As StreamWriter = File.CreateText("Temp.txt")
                Dim individual As String
                Do Until sr.EndOfStream
                    individual = sr.ReadLine
                    If individual <> Person Then
                        sw.WriteLine(individual)
                    End If
                Loop
                sr.Close()
                sw.Close()
                File.Delete("Names.txt")
                File.Move("Temp.txt", "Names.txt")
                MessageBox.Show(Person & " removed from file.", "Name Removed")
            Else
                MessageBox.Show(Person & " is not in the file.", "Name Not Found")
            End If
        Else
            MessageBox.Show("You must enter a name.", "information Incomplete")
        End If
        TxtName_8_2_3.Clear()
        TxtName_8_2_3.Focus()
    End Sub
    Function IsInFile(person As String) As Boolean
        If File.Exists("Names.txt") Then
            Dim Sr As StreamReader = File.OpenText("Names.txt")
            Dim individual As String
            Do Until Sr.EndOfStream
                individual = Sr.ReadLine
                If individual = person Then
                    Sr.Close()
                    Return True
                End If
            Loop
            Sr.Close()
        End If
        Return False
    End Function
End Class
