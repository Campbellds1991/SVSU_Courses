Public Class SpellCheckSVC
    '------------------------------------------------------------
    '-                Subprogram Name: CheckWord                -
    '------------------------------------------------------------
    '-                Written By: Devin Campbell                -
    '-                Written On: 04/16/2017                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Passes the spellchecking onto the installed word program -
    '-  to process                                              –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Shared WordCheckSystem As New Microsoft.Office.Interop.Word.Application()
    Public Shared Function CheckWord(word As String) As Boolean
        Return WordCheckSystem.CheckSpelling(word)
    End Function
End Class
