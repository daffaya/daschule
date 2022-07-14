<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradeDeleteConfirm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEditData = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button1.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(48, 110)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Cancel"
        Me.Button1.UseMnemonic = False
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnEditData
        '
        Me.btnEditData.BackColor = System.Drawing.Color.DarkRed
        Me.btnEditData.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEditData.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditData.Location = New System.Drawing.Point(162, 110)
        Me.btnEditData.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEditData.Name = "btnEditData"
        Me.btnEditData.Size = New System.Drawing.Size(75, 23)
        Me.btnEditData.TabIndex = 15
        Me.btnEditData.Text = "Delete"
        Me.btnEditData.UseMnemonic = False
        Me.btnEditData.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btnEditData)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(197, 82)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(392, 152)
        Me.Panel2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(48, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 30)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "You are going to delete this data from database." & Global.Microsoft.VisualBasic.ChrW(10) & "Are you sure about this?"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(48, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 24)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Delete Data"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'GradeDeleteConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 562)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "GradeDeleteConfirm"
        Me.Text = "GradeDeleteConfirm"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents btnEditData As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
End Class
