<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentAddForm
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
        Me.dateBirthday = New System.Windows.Forms.DateTimePicker()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEditData = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStudentsBirthPlace = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStudentsName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStudentsID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtStudentsAddress = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtStudentsAddress)
        Me.Panel1.Controls.Add(Me.dateBirthday)
        Me.Panel1.Controls.Add(Me.cmbClass)
        Me.Panel1.Controls.Add(Me.cmbGender)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnEditData)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtStudentsBirthPlace)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtStudentsName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtStudentsID)
        Me.Panel1.Location = New System.Drawing.Point(119, 25)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(536, 413)
        Me.Panel1.TabIndex = 0
        '
        'dateBirthday
        '
        Me.dateBirthday.CalendarFont = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dateBirthday.Location = New System.Drawing.Point(237, 270)
        Me.dateBirthday.Name = "dateBirthday"
        Me.dateBirthday.Size = New System.Drawing.Size(205, 23)
        Me.dateBirthday.TabIndex = 19
        '
        'cmbClass
        '
        Me.cmbClass.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Items.AddRange(New Object() {"IPA 1", "IPA 2", "IPA 3", "IPA 4", "IPA 5", "IPS 1", "IPS 2", "IPS 3", "IPS 4", "IPS 5", "IPB", "AGAMA"})
        Me.cmbClass.Location = New System.Drawing.Point(237, 316)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(205, 23)
        Me.cmbClass.TabIndex = 18
        '
        'cmbGender
        '
        Me.cmbGender.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(237, 185)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(205, 23)
        Me.cmbGender.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button1.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(282, 370)
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
        Me.btnEditData.Location = New System.Drawing.Point(157, 370)
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
        Me.Label7.Location = New System.Drawing.Point(103, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Class"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(103, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Birthday"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(103, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Birth Place"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txtStudentsBirthPlace
        '
        Me.txtStudentsBirthPlace.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtStudentsBirthPlace.Location = New System.Drawing.Point(237, 226)
        Me.txtStudentsBirthPlace.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStudentsBirthPlace.Name = "txtStudentsBirthPlace"
        Me.txtStudentsBirthPlace.Size = New System.Drawing.Size(205, 22)
        Me.txtStudentsBirthPlace.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(103, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Gender"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(103, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Students Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txtStudentsName
        '
        Me.txtStudentsName.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtStudentsName.Location = New System.Drawing.Point(237, 106)
        Me.txtStudentsName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStudentsName.Name = "txtStudentsName"
        Me.txtStudentsName.Size = New System.Drawing.Size(205, 22)
        Me.txtStudentsName.TabIndex = 5
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
        Me.Label3.Location = New System.Drawing.Point(167, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Add Student Data Form"
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(103, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Address"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txtStudentsAddress
        '
        Me.txtStudentsAddress.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtStudentsAddress.Location = New System.Drawing.Point(237, 144)
        Me.txtStudentsAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStudentsAddress.Name = "txtStudentsAddress"
        Me.txtStudentsAddress.Size = New System.Drawing.Size(205, 22)
        Me.txtStudentsAddress.TabIndex = 20
        '
        'StudentAddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 449)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "StudentAddForm"
        Me.Text = "StudentAddForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtStudentsID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStudentsBirthPlace As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStudentsName As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnEditData As Button
    Friend WithEvents dateBirthday As DateTimePicker
    Friend WithEvents cmbClass As ComboBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtStudentsAddress As TextBox
End Class
