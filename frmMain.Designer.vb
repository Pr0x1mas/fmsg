<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.grpConnect = New System.Windows.Forms.GroupBox()
        Me.lblChatDirectory = New System.Windows.Forms.Label()
        Me.txtChatDirectory = New System.Windows.Forms.TextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.cmbRoom = New System.Windows.Forms.ComboBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.grpMessage = New System.Windows.Forms.GroupBox()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.grpConnect.SuspendLayout()
        Me.grpMessage.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpConnect
        '
        Me.grpConnect.Controls.Add(Me.lblChatDirectory)
        Me.grpConnect.Controls.Add(Me.txtChatDirectory)
        Me.grpConnect.Controls.Add(Me.btnConnect)
        Me.grpConnect.Controls.Add(Me.lblRoom)
        Me.grpConnect.Controls.Add(Me.cmbRoom)
        Me.grpConnect.Controls.Add(Me.lblUsername)
        Me.grpConnect.Controls.Add(Me.txtUsername)
        Me.grpConnect.Location = New System.Drawing.Point(8, 232)
        Me.grpConnect.Name = "grpConnect"
        Me.grpConnect.Size = New System.Drawing.Size(144, 208)
        Me.grpConnect.TabIndex = 0
        Me.grpConnect.TabStop = False
        Me.grpConnect.Text = "Connect"
        '
        'lblChatDirectory
        '
        Me.lblChatDirectory.AutoSize = True
        Me.lblChatDirectory.Location = New System.Drawing.Point(8, 112)
        Me.lblChatDirectory.Name = "lblChatDirectory"
        Me.lblChatDirectory.Size = New System.Drawing.Size(105, 13)
        Me.lblChatDirectory.TabIndex = 6
        Me.lblChatDirectory.Text = "Chat Room Directory"
        '
        'txtChatDirectory
        '
        Me.txtChatDirectory.Location = New System.Drawing.Point(8, 128)
        Me.txtChatDirectory.Name = "txtChatDirectory"
        Me.txtChatDirectory.Size = New System.Drawing.Size(128, 20)
        Me.txtChatDirectory.TabIndex = 5
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(16, 160)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(112, 32)
        Me.btnConnect.TabIndex = 4
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Location = New System.Drawing.Point(8, 64)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(60, 13)
        Me.lblRoom.TabIndex = 3
        Me.lblRoom.Text = "Chat Room"
        '
        'cmbRoom
        '
        Me.cmbRoom.FormattingEnabled = True
        Me.cmbRoom.Items.AddRange(New Object() {"room1", "room2", "room3"})
        Me.cmbRoom.Location = New System.Drawing.Point(8, 80)
        Me.cmbRoom.Name = "cmbRoom"
        Me.cmbRoom.Size = New System.Drawing.Size(128, 21)
        Me.cmbRoom.TabIndex = 2
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(8, 16)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(72, 13)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Display Name"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(8, 32)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(128, 20)
        Me.txtUsername.TabIndex = 0
        '
        'grpMessage
        '
        Me.grpMessage.Controls.Add(Me.txtRoom)
        Me.grpMessage.Controls.Add(Me.btnSend)
        Me.grpMessage.Controls.Add(Me.txtMessage)
        Me.grpMessage.Location = New System.Drawing.Point(160, 8)
        Me.grpMessage.Name = "grpMessage"
        Me.grpMessage.Size = New System.Drawing.Size(624, 432)
        Me.grpMessage.TabIndex = 1
        Me.grpMessage.TabStop = False
        Me.grpMessage.Text = "Message"
        '
        'txtRoom
        '
        Me.txtRoom.Enabled = False
        Me.txtRoom.Location = New System.Drawing.Point(8, 24)
        Me.txtRoom.Multiline = True
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRoom.Size = New System.Drawing.Size(608, 368)
        Me.txtRoom.TabIndex = 2
        '
        'btnSend
        '
        Me.btnSend.Enabled = False
        Me.btnSend.Location = New System.Drawing.Point(560, 400)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(56, 24)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Enabled = False
        Me.txtMessage.Location = New System.Drawing.Point(8, 400)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(544, 20)
        Me.txtMessage.TabIndex = 0
        '
        'Timer1
        '
        '
        'picLogo
        '
        Me.picLogo.Image = Global.Fmsg.My.Resources.Resources.logo
        Me.picLogo.Location = New System.Drawing.Point(8, 8)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(96, 96)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 2
        Me.picLogo.TabStop = False
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(8, 112)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(119, 104)
        Me.lblInfo.TabIndex = 3
        Me.lblInfo.Text = "Fmsg v0.1a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "© Joshua Britain 2020" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This program and it's " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "developer(s) are not" &
    " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "responsible in any" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " way for the contents " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of messages sent with it" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.grpMessage)
        Me.Controls.Add(Me.grpConnect)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "FMsg V0.1a"
        Me.grpConnect.ResumeLayout(False)
        Me.grpConnect.PerformLayout()
        Me.grpMessage.ResumeLayout(False)
        Me.grpMessage.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpConnect As GroupBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents lblRoom As Label
    Friend WithEvents cmbRoom As ComboBox
    Friend WithEvents grpMessage As GroupBox
    Friend WithEvents txtRoom As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblChatDirectory As Label
    Friend WithEvents txtChatDirectory As TextBox
End Class
