﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentEditData
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(335, 258)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(334, 208)
        Me.Panel1.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(121, 136)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(106, 29)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Delete Data"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(121, 39)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 29)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Add Data"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(121, 86)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 29)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Edit Data"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(281, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StudentEditData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 725)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "StudentEditData"
        Me.Text = "StudentEditData"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
