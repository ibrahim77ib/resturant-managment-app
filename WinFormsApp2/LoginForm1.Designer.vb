<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm1
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents U As System.Windows.Forms.TextBox
    Friend WithEvents P As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        UsernameLabel = New Label()
        PasswordLabel = New Label()
        U = New TextBox()
        P = New TextBox()
        OK = New Button()
        Cancel = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Location = New Point(262, 24)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(220, 23)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "&User name"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Location = New Point(262, 81)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(220, 23)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "&Password"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' U
        ' 
        U.AccessibleDescription = ""
        U.AccessibleName = ""
        U.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        U.Location = New Point(262, 50)
        U.Name = "U"
        U.PlaceholderText = "Enter your user name"
        U.Size = New Size(220, 23)
        U.TabIndex = 1
        U.Tag = ""
        ' 
        ' P
        ' 
        P.AutoCompleteMode = AutoCompleteMode.Append
        P.Location = New Point(262, 107)
        P.Name = "P"
        P.PasswordChar = "*"c
        P.PlaceholderText = "Enter your password"
        P.Size = New Size(220, 23)
        P.TabIndex = 3
        ' 
        ' OK
        ' 
        OK.Location = New Point(262, 161)
        OK.Name = "OK"
        OK.Size = New Size(94, 23)
        OK.TabIndex = 4
        OK.Text = "&OK"
        ' 
        ' Cancel
        ' 
        Cancel.DialogResult = DialogResult.Cancel
        Cancel.Location = New Point(388, 161)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(94, 23)
        Cancel.TabIndex = 5
        Cancel.Text = "&Cancel"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = My.Resources.Resources.istockphoto_1141797008_1024x1024
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(248, 397)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' LoginForm1
        ' 
        AcceptButton = OK
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        CancelButton = Cancel
        ClientSize = New Size(591, 397)
        Controls.Add(PictureBox1)
        Controls.Add(Cancel)
        Controls.Add(OK)
        Controls.Add(P)
        Controls.Add(U)
        Controls.Add(PasswordLabel)
        Controls.Add(UsernameLabel)
        ForeColor = Color.Transparent
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginForm1"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterParent
        Text = "المطعم"
        TransparencyKey = Color.Fuchsia
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox

End Class
