Imports Library

'------------------------------------------------------------
'-                File Name : App.vb                        - 
'-                Part of Project: Assign10                 -
'------------------------------------------------------------
'-                Written By: Devin Campbell                -
'-                Written On: 04/16/2016                    -
'------------------------------------------------------------
'- File / Program Purpose:                                  -
'- Initailized a DLL GUI at program start                   -
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'- (none)
'------------------------------------------------------------

Namespace My
    Class Main
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- GUI - Graphics class implemented to use Library form.    -
        '------------------------------------------------------------
        Public Shared Sub Main()
            Dim GUI As New SpellCheckGUI
            GUI.ShowDialog()
        End Sub
    End Class
End Namespace

