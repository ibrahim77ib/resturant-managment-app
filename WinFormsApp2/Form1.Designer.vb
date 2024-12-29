<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        GroupBox1 = New GroupBox()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Button7 = New Button()
        RichTextBox1 = New RichTextBox()
        Label1 = New Label()
        Timer1 = New Timer(components)
        Button8 = New Button()
        TextBox1 = New TextBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(Button6)
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Dock = DockStyle.Left
        GroupBox1.FlatStyle = FlatStyle.Popup
        GroupBox1.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(200, 454)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "القائمة"
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button6.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = SystemColors.ButtonHighlight
        Button6.Location = New Point(0, 481)
        Button6.Name = "Button6"
        Button6.Size = New Size(200, 85)
        Button6.TabIndex = 5
        Button6.Text = "الربح"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button5.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = SystemColors.ButtonHighlight
        Button5.Location = New Point(0, 390)
        Button5.Name = "Button5"
        Button5.Size = New Size(200, 85)
        Button5.TabIndex = 4
        Button5.Text = "الخروج"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button4.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = SystemColors.ButtonFace
        Button4.Location = New Point(0, 295)
        Button4.Name = "Button4"
        Button4.Size = New Size(200, 85)
        Button4.TabIndex = 3
        Button4.Text = "المشروبات"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button3.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(0, 204)
        Button3.Name = "Button3"
        Button3.Size = New Size(200, 85)
        Button3.TabIndex = 2
        Button3.Text = "المعجنات"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button2.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(0, 113)
        Button2.Name = "Button2"
        Button2.Size = New Size(200, 85)
        Button2.TabIndex = 1
        Button2.Text = "السندويشات"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button1.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(0, 22)
        Button1.Name = "Button1"
        Button1.Size = New Size(200, 85)
        Button1.TabIndex = 0
        Button1.Text = "الوجبات"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(635, 543)
        Button7.Name = "Button7"
        Button7.Size = New Size(217, 49)
        Button7.TabIndex = 3
        Button7.Text = "السعر"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.AccessibleName = "المطعم"
        RichTextBox1.Location = New Point(577, 156)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(336, 319)
        RichTextBox1.TabIndex = 5
        RichTextBox1.Text = ""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(1123, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 7
        Label1.Text = "Label1"
        ' 
        ' Timer1
        ' 
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(338, 142)
        Button8.Name = "Button8"
        Button8.Size = New Size(100, 23)
        Button8.TabIndex = 9
        Button8.Text = "Button8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(338, 113)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ClientSize = New Size(1253, 454)
        Controls.Add(TextBox1)
        Controls.Add(Button8)
        Controls.Add(Label1)
        Controls.Add(RichTextBox1)
        Controls.Add(Button7)
        Controls.Add(GroupBox1)
        IsMdiContainer = True
        MaximizeBox = False
        Name = "Form1"
        SizeGripStyle = SizeGripStyle.Show
        Text = "Form1"
        TransparencyKey = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents شاورما As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button8 As Button
    Friend WithEvents TextBox1 As TextBox

End Class
