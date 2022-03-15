Imports Library.SpellCheckSVC
Public Class SpellCheckGUI
    '------------------------------------------------------------
    '-                Subprogram Name: cmdCheckWord_Click       -
    '------------------------------------------------------------
    '-                Written By: Devin Campbell                -
    '-                Written On: 04/16/2017                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Calls the Checkword in SVC to resolve the spelling       –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------

    Private Sub cmdCheckWord_Click(sender As Object, e As EventArgs) Handles cmdCheckWord.Click
        If CheckWord(txtWord.Text) Then
            lblResult.Text = "Spelling is good"
        Else
            lblResult.Text = $"{txtWord.Text} is not a valid word in the dictionary"
        End If
    End Sub
End Class