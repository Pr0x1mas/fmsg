Imports System.IO

Public Class frmMain
    Dim roomLocation As String
    Dim roomName As String
    Dim roomFile As String
    Dim userName As String

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Try
            Using room As StreamWriter = New StreamWriter(roomFile, True)
                room.WriteLine("[" & TimeOfDay.ToString("h:mm:ss tt") & "] " & userName & " has left the chat")
            End Using
        Catch ex As Exception
        End Try

        txtMessage.Enabled = True
        btnSend.Enabled = True

        roomLocation = txtChatDirectory.Text
        roomName = cmbRoom.Text
        userName = txtUsername.Text
        roomFile = roomLocation & "\" & roomName & ".txt"

        Try
            Using room As StreamWriter = New StreamWriter(roomFile, True)
                room.WriteLine("[" & TimeOfDay.ToString("h:mm:ss tt") & "] " & userName & " has joined the chat")
            End Using

            txtRoom.Text = System.IO.File.ReadAllText(roomFile)
        Catch ex As Exception
            MsgBox("Directory '" & roomLocation & "' does not exist")
        End Try
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Using room As StreamWriter = New StreamWriter(roomFile, True)
            room.WriteLine("[" & TimeOfDay.ToString("h:mm:ss tt") & "] " & userName & ": " & txtMessage.Text)
            txtMessage.Text = ""
        End Using
        txtRoom.Text = System.IO.File.ReadAllText(roomFile)
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As EventArgs) Handles Me.FormClosing
        Try
            Using room As StreamWriter = New StreamWriter(roomFile, True)
                room.WriteLine("[" & TimeOfDay.ToString("h:mm:ss tt") & "] " & userName & " has left the chat")
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Timer1.Interval = TimeSpan.FromSeconds(1).TotalMilliseconds
        Me.Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            txtRoom.Text = System.IO.File.ReadAllText(roomFile)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRoomLocation_Click(sender As Object, e As EventArgs)
        roomLocation = InputBox("Enter new room directory")
    End Sub
End Class
