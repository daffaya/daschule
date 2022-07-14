<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Grade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Grade))
        Me.DGSiswa = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddData = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnTeacher = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnSubject = New System.Windows.Forms.Button()
        Me.btnClass = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEditData = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DGSiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGSiswa
        '
        Me.DGSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSiswa.Location = New System.Drawing.Point(177, 142)
        Me.DGSiswa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGSiswa.Name = "DGSiswa"
        Me.DGSiswa.RowHeadersWidth = 51
        Me.DGSiswa.RowTemplate.Height = 29
        Me.DGSiswa.Size = New System.Drawing.Size(612, 262)
        Me.DGSiswa.TabIndex = 13
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DarkRed
        Me.btnDelete.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDelete.Location = New System.Drawing.Point(714, 96)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseMnemonic = False
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(11, 260)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(25, 17)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 10
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(11, 214)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(25, 17)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(11, 114)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 17)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(11, 58)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 17)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 165)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 17)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lato Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(177, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 23)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Grade Database"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'btnAddData
        '
        Me.btnAddData.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnAddData.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddData.Location = New System.Drawing.Point(539, 96)
        Me.btnAddData.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAddData.Name = "btnAddData"
        Me.btnAddData.Size = New System.Drawing.Size(75, 23)
        Me.btnAddData.TabIndex = 22
        Me.btnAddData.Text = "Add Data"
        Me.btnAddData.UseMnemonic = False
        Me.btnAddData.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnTeacher)
        Me.Panel2.Controls.Add(Me.btnStudent)
        Me.Panel2.Controls.Add(Me.btnSubject)
        Me.Panel2.Controls.Add(Me.btnClass)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(3, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(159, 354)
        Me.Panel2.TabIndex = 18
        '
        'btnTeacher
        '
        Me.btnTeacher.BackColor = System.Drawing.Color.LightGray
        Me.btnTeacher.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTeacher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnTeacher.Location = New System.Drawing.Point(42, 105)
        Me.btnTeacher.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTeacher.Name = "btnTeacher"
        Me.btnTeacher.Size = New System.Drawing.Size(75, 34)
        Me.btnTeacher.TabIndex = 29
        Me.btnTeacher.Text = "Teacher"
        Me.btnTeacher.UseMnemonic = False
        Me.btnTeacher.UseVisualStyleBackColor = False
        '
        'btnStudent
        '
        Me.btnStudent.BackColor = System.Drawing.Color.LightGray
        Me.btnStudent.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnStudent.Location = New System.Drawing.Point(42, 157)
        Me.btnStudent.Margin = New System.Windows.Forms.Padding(0)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(75, 34)
        Me.btnStudent.TabIndex = 20
        Me.btnStudent.Text = "Student"
        Me.btnStudent.UseMnemonic = False
        Me.btnStudent.UseVisualStyleBackColor = False
        '
        'btnSubject
        '
        Me.btnSubject.BackColor = System.Drawing.Color.LightGray
        Me.btnSubject.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSubject.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnSubject.Location = New System.Drawing.Point(42, 50)
        Me.btnSubject.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSubject.Name = "btnSubject"
        Me.btnSubject.Size = New System.Drawing.Size(75, 34)
        Me.btnSubject.TabIndex = 28
        Me.btnSubject.Text = "Subject"
        Me.btnSubject.UseMnemonic = False
        Me.btnSubject.UseVisualStyleBackColor = False
        '
        'btnClass
        '
        Me.btnClass.BackColor = System.Drawing.Color.LightGray
        Me.btnClass.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnClass.Location = New System.Drawing.Point(42, 206)
        Me.btnClass.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClass.Name = "btnClass"
        Me.btnClass.Size = New System.Drawing.Size(75, 34)
        Me.btnClass.TabIndex = 27
        Me.btnClass.Text = "Class"
        Me.btnClass.UseMnemonic = False
        Me.btnClass.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGray
        Me.Button1.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(42, 250)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Grade"
        Me.Button1.UseMnemonic = False
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(32, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "daschule"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'btnEditData
        '
        Me.btnEditData.BackColor = System.Drawing.Color.LightGray
        Me.btnEditData.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEditData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnEditData.Location = New System.Drawing.Point(627, 96)
        Me.btnEditData.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEditData.Name = "btnEditData"
        Me.btnEditData.Size = New System.Drawing.Size(75, 23)
        Me.btnEditData.TabIndex = 20
        Me.btnEditData.Text = "Edit Data"
        Me.btnEditData.UseMnemonic = False
        Me.btnEditData.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(799, 77)
        Me.Panel1.TabIndex = 17
        '
        'Grade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 456)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAddData)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnEditData)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGSiswa)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Grade"
        Me.Text = "Database Grade"
        CType(Me.DGSiswa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGSiswa As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Protected Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddData As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEditData As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnStudent As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnTeacher As Button
    Friend WithEvents btnSubject As Button
    Friend WithEvents btnClass As Button
End Class
