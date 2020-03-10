Public Class Form1
    Dim myemployee As Employee
    Dim PhotoPath As String = " "

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        CreateEmployee("rad", "marvin", "administration", "this guy is awsome", 0)
    End Sub
    Private Sub CreateEmployee(fname As String, lname As String, dept As String, notes As String, status As Integer)
        If MsgBox(" would you like to add a photo", MsgBoxStyle.YesNo, "add photo") = MsgBoxResult.Yes Then
            OFDphoto.ShowDialog()
        End If

        If PhotoPath = " " Then
            myemployee = New Employee(Me.CreateGraphics, fname, lname, dept, notes, status)
        Else
            Dim Oimg As Image = Image.FromFile(PhotoPath)
        End If
        If myemployee IsNot Nothing Then
            myemployee.Draw()
        End If

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OFDphoto.FileOk
        PhotoPath = OFDphoto.FileName

    End Sub


End Class
