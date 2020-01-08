<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.CMDvote = New System.Windows.Forms.Button()
        Me.CMDExit = New System.Windows.Forms.Button()
        Me.LLServerlist = New System.Windows.Forms.LinkLabel()
        Me.LLMS = New System.Windows.Forms.LinkLabel()
        Me.LLMSEU = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CMDvote
        '
        Me.CMDvote.BackColor = System.Drawing.Color.Transparent
        Me.CMDvote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMDvote.ForeColor = System.Drawing.Color.White
        Me.CMDvote.Location = New System.Drawing.Point(156, 88)
        Me.CMDvote.Name = "CMDvote"
        Me.CMDvote.Size = New System.Drawing.Size(75, 23)
        Me.CMDvote.TabIndex = 0
        Me.CMDvote.Text = "Voten"
        Me.CMDvote.UseVisualStyleBackColor = False
        '
        'CMDExit
        '
        Me.CMDExit.BackColor = System.Drawing.Color.Transparent
        Me.CMDExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMDExit.ForeColor = System.Drawing.Color.White
        Me.CMDExit.Location = New System.Drawing.Point(156, 117)
        Me.CMDExit.Name = "CMDExit"
        Me.CMDExit.Size = New System.Drawing.Size(75, 23)
        Me.CMDExit.TabIndex = 1
        Me.CMDExit.Text = "Beenden"
        Me.CMDExit.UseVisualStyleBackColor = False
        '
        'LLServerlist
        '
        Me.LLServerlist.AutoSize = True
        Me.LLServerlist.BackColor = System.Drawing.Color.Transparent
        Me.LLServerlist.LinkColor = System.Drawing.Color.White
        Me.LLServerlist.Location = New System.Drawing.Point(12, 90)
        Me.LLServerlist.Name = "LLServerlist"
        Me.LLServerlist.Size = New System.Drawing.Size(112, 13)
        Me.LLServerlist.TabIndex = 8
        Me.LLServerlist.TabStop = True
        Me.LLServerlist.Text = "minecraft-serverlist.net"
        '
        'LLMS
        '
        Me.LLMS.AutoSize = True
        Me.LLMS.BackColor = System.Drawing.Color.Transparent
        Me.LLMS.LinkColor = System.Drawing.Color.White
        Me.LLMS.Location = New System.Drawing.Point(12, 110)
        Me.LLMS.Name = "LLMS"
        Me.LLMS.Size = New System.Drawing.Size(102, 13)
        Me.LLMS.TabIndex = 9
        Me.LLMS.TabStop = True
        Me.LLMS.Text = "minecraft-servers.de"
        '
        'LLMSEU
        '
        Me.LLMSEU.AutoSize = True
        Me.LLMSEU.BackColor = System.Drawing.Color.Transparent
        Me.LLMSEU.LinkColor = System.Drawing.Color.White
        Me.LLMSEU.Location = New System.Drawing.Point(12, 130)
        Me.LLMSEU.Name = "LLMSEU"
        Me.LLMSEU.Size = New System.Drawing.Size(97, 13)
        Me.LLMSEU.TabIndex = 10
        Me.LLMSEU.TabStop = True
        Me.LLMSEU.Text = "minecraft-server.eu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Direkte Links:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RocketMiners_Voting_Tool.My.Resources.Resources._2016_06_14_14_22_45
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(243, 153)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LLMSEU)
        Me.Controls.Add(Me.LLMS)
        Me.Controls.Add(Me.LLServerlist)
        Me.Controls.Add(Me.CMDExit)
        Me.Controls.Add(Me.CMDvote)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "RM Voting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CMDvote As Button
    Friend WithEvents CMDExit As Button
    Friend WithEvents LLServerlist As LinkLabel
    Friend WithEvents LLMS As LinkLabel
    Friend WithEvents LLMSEU As LinkLabel
    Friend WithEvents Label1 As Label
End Class
