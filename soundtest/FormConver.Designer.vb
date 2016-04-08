<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConver
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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.txtIn = New System.Windows.Forms.TextBox()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(501, 714)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(247, 80)
        Me.btnConvert.TabIndex = 1
        Me.btnConvert.Text = "Convert Text"
        Me.btnConvert.UseVisualStyleBackColor = True
        Me.btnConvert.UseWaitCursor = True
        '
        'txtIn
        '
        Me.txtIn.Location = New System.Drawing.Point(29, 31)
        Me.txtIn.Multiline = True
        Me.txtIn.Name = "txtIn"
        Me.txtIn.Size = New System.Drawing.Size(556, 641)
        Me.txtIn.TabIndex = 2
        Me.txtIn.UseWaitCursor = True
        '
        'txtOut
        '
        Me.txtOut.Location = New System.Drawing.Point(657, 31)
        Me.txtOut.Multiline = True
        Me.txtOut.Name = "txtOut"
        Me.txtOut.Size = New System.Drawing.Size(556, 641)
        Me.txtOut.TabIndex = 3
        Me.txtOut.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(476, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 147)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "WIP"
        Me.Label1.UseWaitCursor = True
        '
        'FormConver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 979)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.txtIn)
        Me.Controls.Add(Me.btnConvert)
        Me.Name = "FormConver"
        Me.Text = "Convert"
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConvert As Button
    Friend WithEvents txtIn As TextBox
    Friend WithEvents txtOut As TextBox
    Friend WithEvents Label1 As Label
End Class
