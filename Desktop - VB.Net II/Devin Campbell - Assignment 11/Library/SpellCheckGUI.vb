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
    Private currentculture As Culture
    Public LanguageResponses As Dictionary(Of String, String)
    Public Sub New(Optional Language As Culture = Culture.English)
        InitializeComponent()
        currentculture = Language
        LanguageResponses = New Dictionary(Of String, String)
        Select Case Language
            Case Culture.German
                System.Threading.Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("de-li")
                System.Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("de-li")
                LanguageResponses.Add("Valid", "Gültig")
                LanguageResponses.Add("Error", "ist kein gültiges Wort im Wörterbuch")
            Case Culture.Dutch
                System.Threading.Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("nl-nl")
                System.Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("nl-nl")
                LanguageResponses.Add("Valid", "Zin is goed")
                LanguageResponses.Add("Error", "is geen geldig woord in het woordenboek")
            Case Culture.Japanese
                System.Threading.Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("ja")
                System.Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("ja")
                LanguageResponses.Add("Valid", "スペルは良いです")
                LanguageResponses.Add("Error", "辞書の有効な単語ではありません")
            Case Culture.English
                System.Threading.Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("en-us")
                System.Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("en-us")
                LanguageResponses.Add("Valid", "Spelling is good")
                LanguageResponses.Add("Error", "is not a valid word in the dictionary")
        End Select
    End Sub
    Public Enum Culture
        English
        German
        Dutch
        Japanese
    End Enum
    Private Sub cmdCheckWord_Click(sender As Object, e As EventArgs) Handles cmdCheckWord.Click
        If CheckWord(txtWord.Text) Then
            lblResult.Text = LanguageResponses("Valid")
        Else
            lblResult.Text = $"{txtWord.Text} {LanguageResponses("Error")}"
        End If
    End Sub
End Class