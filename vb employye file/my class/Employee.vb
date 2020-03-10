Imports System.Drawing



Public Class Employee
    'drawing surface
    Private G As Graphics
    Private PhotoBox As New Rectangle(5, 5, 150, 200)
    Private infoBox As New Rectangle(160, 5, 250, 200)

    ' employee properties
    Public firstname As String
    Public LastName As String
    Public Department As String
    Public Notes As String
    Public Status As EmployeeStatue
    ' employee photo 
    Public Photo As Image


    Public Enum EmployeeStatue
        active
        terminated
        unknown
    End Enum

    Public Sub New(GFX As Graphics, fname As String, Lname As String, Dept As String, Empnote As String, EmpStatus As Integer, Optional EmpPhoto As Image = Nothing)
        G = GFX
        firstname = fname
        LastName = Lname
        Department = Dept

        Notes = Empnote
        Select Case EmpStatus
            Case 0
                Status = EmployeeStatue.active
            Case 1
                Status = EmployeeStatue.terminated
            Case Else
                Status = EmployeeStatue.unknown
        End Select

        Photo = EmpPhoto


    End Sub
    Public Sub Draw()
        'clear the drawing surface
        G.Clear(Color.FromName("control"))
        'emp photobox
        G.FillRectangle(Brushes.Beige, PhotoBox)
        G.DrawRectangle(Pens.Black, PhotoBox)
        If Photo IsNot Nothing Then
            G.DrawImage(Photo, New Rectangle(PhotoBox.X + 1, PhotoBox.Y + 1, PhotoBox.Width - 1, PhotoBox.Height - 1))

        End If
        'employee information
        G.FillRectangle(Brushes.Azure, infoBox)
        G.DrawRectangle(Pens.ForestGreen, infoBox)
        G.DrawString(" " &
            "Emplyee Name: " & firstname & " " & LastName & vbCrLf &
            "Employee Status: " & Status.ToString & vbCrLf &
            "Department: " & Department & vbCrLf &
            "Notes :" & Notes, New Font("tahoma", 9), Brushes.Black, New Point(infoBox.X + 5, infoBox.Y + 5))

    End Sub



End Class
