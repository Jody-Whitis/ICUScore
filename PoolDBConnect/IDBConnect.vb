Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Public Interface IDBConnect


    'connect


    'insert
    Sub InsertGame()
    Sub InsertPlayer()

    'pull up
    Sub GetGames(cb As ComboBox, cb2 As ComboBox, txtwins As TextBox, txtWins2 As TextBox, lblError As Label)
    Sub GetPlayers(cbPlayer1 As ComboBox, txtwins As TextBox, lblError As Label)
    Sub getResults(tb As TextBox)


    'close



End Interface
