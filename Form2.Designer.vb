<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        gotoform2 = New Button()
        endapp = New Button()
        SuspendLayout()
        ' 
        ' gotoform2
        ' 
        gotoform2.Dock = DockStyle.Fill
        gotoform2.Location = New Point(0, 0)
        gotoform2.Name = "gotoform2"
        gotoform2.Size = New Size(800, 450)
        gotoform2.TabIndex = 0
        gotoform2.Text = "Button1"
        gotoform2.UseVisualStyleBackColor = True
        ' 
        ' endapp
        ' 
        endapp.Location = New Point(341, 0)
        endapp.Name = "endapp"
        endapp.Size = New Size(75, 30)
        endapp.TabIndex = 1
        endapp.Text = "end"
        endapp.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(endapp)
        Controls.Add(gotoform2)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents gotoform2 As Button
    Friend WithEvents endapp As Button
End Class
