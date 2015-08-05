<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnClick = New System.Windows.Forms.Button()
        Me.txtBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnClick
        '
        Me.btnClick.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClick.Location = New System.Drawing.Point(64, 117)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(75, 23)
        Me.btnClick.TabIndex = 0
        Me.btnClick.Text = "ClickMe"
        Me.btnClick.UseVisualStyleBackColor = False
        '
        'txtBox
        '
        Me.txtBox.Location = New System.Drawing.Point(53, 71)
        Me.txtBox.Name = "txtBox"
        Me.txtBox.Size = New System.Drawing.Size(100, 20)
        Me.txtBox.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtBox)
        Me.Controls.Add(Me.btnClick)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClick As System.Windows.Forms.Button
    Friend WithEvents txtBox As System.Windows.Forms.TextBox

End Class
