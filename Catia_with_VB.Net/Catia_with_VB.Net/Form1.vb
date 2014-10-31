Public Class Form1

  Dim CATIA As INFITF.Application
  Dim theSelection As INFITF.Selection

#Region "Menu"

  Private Sub MenuFile_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuFile_Exit.Click
    Me.Close()
  End Sub

  Private Sub MenuHelp_About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuHelp_About.Click
    Try
      Dim mySplash As New Splash(0)
    Catch ex As Exception

    End Try
  End Sub

  Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    StatusLabel1.Text = "Ready"
  End Sub

  Private Sub MenuHelp_ClearStatusMsg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuHelp_ClearStatusMsg.Click
    StatusLabel1.Text = ""
  End Sub

  Private Sub MenuCatia_Connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCatia_Connect.Click
    getCATIA()
  End Sub

  Private Sub MenuCatia_FindReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCatia_FindReplace.Click
    ReplaceText()
  End Sub

  Private Sub MenuCatia_Colors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCatia_Colors.Click
    setColors()
  End Sub

  Private Sub MenuCatia_InsertText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCatia_InsertText.Click
    insertText()
  End Sub

#End Region

  Private Sub insertText()
    Try
      Const theText As String = "DELETE THIS"

      Dim drawingDoc As DRAFTINGITF.DrawingDocument = getDrawingDocument()
      If drawingDoc Is Nothing Then
        StatusLabel1.Text = "No drawing found"
        Exit Sub
      End If

      ' get the main view
      Dim drawingSheet As DRAFTINGITF.DrawingSheet = drawingDoc.Sheets.ActiveSheet
      Dim mainView As DRAFTINGITF.DrawingView = Nothing
      For i = 1 To drawingSheet.Views.Count
        If drawingSheet.Views.Item(i).ViewType = DRAFTINGITF.CatDrawingViewType.catViewMain Then
          mainView = drawingSheet.Views.Item(i)
          Exit For
        End If
      Next

      If mainView IsNot Nothing Then

        Dim textCoords(2)
        StatusLabel1.Text = "Select Text Location"
        Dim status = drawingDoc.Indicate2D("Select Text Location", textCoords)
        If status = "Normal" Then
          Dim newText As DRAFTINGITF.DrawingText
          newText = mainView.Texts.Add(theText, textCoords(0), textCoords(1))
          StatusLabel1.Text = "Text insert complete"
        Else
          StatusLabel1.Text = "Insert Text cancelled"
        End If
      End If

    Catch ex As Exception
      StatusLabel1.Text = "Error inserting text."
    End Try
  End Sub

  Private Sub setColors()
    Try

      Dim drawingDoc As DRAFTINGITF.DrawingDocument = getDrawingDocument()
      If drawingDoc Is Nothing Then
        StatusLabel1.Text = "No drawing found"
        Exit Sub
      End If

      Dim drawingSheet As DRAFTINGITF.DrawingSheet = drawingDoc.Sheets.ActiveSheet

      For i = 1 To drawingSheet.Views.Count
        Dim theView As DRAFTINGITF.DrawingView = drawingSheet.Views.Item(i)
        For j = theView.Texts.Count To 1 Step -1
          Dim theText As DRAFTINGITF.DrawingText = theView.Texts.Item(j)

          Select Case theText.Text
            Case "RED"
              theSelection.Clear()
              theSelection.Add(theText)
              theSelection.VisProperties.SetRealColor(255, 0, 0, 0)

            Case "BLUE"
              theSelection.Clear()
              theSelection.Add(theText)
              theSelection.VisProperties.SetRealColor(0, 0, 255, 0)

            Case "GREEN"
              theSelection.Clear()
              theSelection.Add(theText)
              theSelection.VisProperties.SetRealColor(0, 255, 0, 0)

            Case "DELETE THIS"
              theSelection.Clear()
              theSelection.Add(theText)
              theSelection.Delete()

          End Select
        Next
      Next

      theSelection.Clear()
      StatusLabel1.Text = "Colors are set."

    Catch ex As Exception
      StatusLabel1.Text = "Error setting colors."
    End Try
  End Sub

  Private Sub ReplaceText()
    Try
      Dim i, j, k As Integer

      Dim Text2Find As String
      If txt_toFind.TextLength > 0 Then
        Text2Find = txt_toFind.Text
      Else
        StatusLabel1.Text = "Please enter text to find."
        Exit Sub
      End If

      Dim NewText As String
      If txt_Replace.TextLength > 0 Then
        NewText = txt_Replace.Text
      Else
        StatusLabel1.Text = "Please enter text to replace with."
        Exit Sub
      End If

      Dim drawingDoc As DRAFTINGITF.DrawingDocument = getDrawingDocument()
      If drawingDoc Is Nothing Then
        StatusLabel1.Text = "No drawing found"
        Exit Sub
      End If

      Dim drawingSheet As DRAFTINGITF.DrawingSheet = drawingDoc.Sheets.ActiveSheet

      For i = 1 To drawingSheet.Views.Count
        Dim theView As DRAFTINGITF.DrawingView = drawingSheet.Views.Item(i)
        For j = 1 To theView.Texts.Count
          Dim theText As DRAFTINGITF.DrawingText = theView.Texts.Item(j)
          'MsgBox(theText.Text)
          If theText.Text.Contains(Text2Find) Then
            theText.Text = theText.Text.Replace(Text2Find, NewText)
            k += 1
          End If
          'If theText.Text = Text2Find Then
          '  theText.Text = NewText
          'End If
        Next
      Next
      StatusLabel1.Text = "Replaced in " & k & " places"
    Catch ex As Exception
      StatusLabel1.Text = "Error in Find/Replace: " & ex.Message
    End Try

  End Sub

  Private Function getCATIA() As Boolean
    Try
      CATIA = GetObject("", "Catia.Application")
      StatusLabel1.Text = "Connected to Catia."
    Catch ex As Exception
      StatusLabel1.Text = "Error connecting to Catia."
      Return False
    End Try
    Return True
  End Function

  Private Function getDrawingDocument() As DRAFTINGITF.DrawingDocument
    Dim drawingDocument As DRAFTINGITF.DrawingDocument = Nothing
    Try
      If getCATIA() Then
        Dim Document1 As INFITF.Document
        Try
          Document1 = CATIA.ActiveDocument
          If TypeName(Document1) = "DrawingDocument" Then
            drawingDocument = Document1
            theSelection = drawingDocument.Selection
            StatusLabel1.Text = "Found Drawing: " & drawingDocument.Name
            Return drawingDocument
          End If
        Catch ex As Exception
          StatusLabel1.Text = "No active document found"
          Return Nothing
        End Try
      End If
    Catch ex As Exception
      StatusLabel1.Text = "Error getting Drawing Document. " & ex.Message
      Return Nothing
    End Try
    Return drawingDocument
  End Function

End Class
