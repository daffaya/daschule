<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradeEditForm
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEditData = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKKM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStudentsID = New System.Windows.Forms.TextBox()
        Me.cmbSubject = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.cmbSubject)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtGrade)
        Me.Panel1.Controls.Add(Me.cmbClass)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnEditData)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtKKM)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtStudentsID)
        Me.Panel1.Location = New System.Drawing.Point(132, 58)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(536, 334)
        Me.Panel1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(103, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Grade"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txtGrade
        '
        Me.txtGrade.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtGrade.Location = New System.Drawing.Point(237, 243)
        Me.txtGrade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(205, 22)
        Me.txtGrade.TabIndex = 19
        '
        'cmbClass
        '
        Me.cmbClass.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Items.AddRange(New Object() {"IPA 1", "IPA 2", "IPA 3", "IPA 4", "IPA 5", "IPS 1", "IPS 2", "IPS 3", "IPS 4", "IPS 5", "IPB", "AGAMA"})
        Me.cmbClass.Location = New System.Drawing.Point(237, 151)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(205, 23)
        Me.cmbClass.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button1.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(306, 298)
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
        Me.btnEditData.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnEditData.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEditData.ForeColor = System.Drawing.Color.Black
        Me.btnEditData.Location = New System.Drawing.Point(181, 298)
        Me.btnEditData.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEditData.Name = "btnEditData"
        Me.btnEditData.Size = New System.Drawing.Size(75, 23)
        Me.btnEditData.TabIndex = 15
        Me.btnEditData.Text = "Save"
        Me.btnEditData.UseMnemonic = False
        Me.btnEditData.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(103, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Class"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(103, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "KKM"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txtKKM
        '
        Me.txtKKM.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtKKM.Location = New System.Drawing.Point(237, 199)
        Me.txtKKM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKKM.Name = "txtKKM"
        Me.txtKKM.Size = New System.Drawing.Size(205, 22)
        Me.txtKKM.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(103, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Subject Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(103, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Students Id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(158, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(256, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Edit Student's Grade Form"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txtStudentsID
        '
        Me.txtStudentsID.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtStudentsID.Location = New System.Drawing.Point(237, 62)
        Me.txtStudentsID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStudentsID.Name = "txtStudentsID"
        Me.txtStudentsID.Size = New System.Drawing.Size(205, 22)
        Me.txtStudentsID.TabIndex = 1
        '
        'cmbSubject
        '
        Me.cmbSubject.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbSubject.FormattingEnabled = True
        Me.cmbSubject.Items.AddRange(New Object() {"IPA 1", "IPA 2", "IPA 3", "IPA 4", "IPA 5", "IPS 1", "IPS 2", "IPS 3", "IPS 4", "IPS 5", "IPB", "AGAMA"})
        Me.cmbSubject.Location = New System.Drawing.Point(237, 107)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(205, 23)
        Me.cmbSubject.TabIndex = 21
        '
        'GradeEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "GradeEditForm"
        Me.Text = "GradeEditForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents cmbClass As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnEditData As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKKM As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStudentsID As TextBox
    Friend WithEvents cmbSubject As ComboBox
End Class
