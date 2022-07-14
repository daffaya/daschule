<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teacher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Teacher))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btnGrade = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnTeacher = New System.Windows.Forms.Button()
        Me.btnSubject = New System.Windows.Forms.Button()
        Me.btnClass = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGSiswa = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DGSiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(5, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(799, 77)
        Me.Panel1.TabIndex = 33
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
        'btnGrade
        '
        Me.btnGrade.BackColor = System.Drawing.Color.LightGray
        Me.btnGrade.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGrade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnGrade.Location = New System.Drawing.Point(42, 250)
        Me.btnGrade.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGrade.Name = "btnGrade"
        Me.btnGrade.Size = New System.Drawing.Size(75, 34)
        Me.btnGrade.TabIndex = 19
        Me.btnGrade.Text = "Grade"
        Me.btnGrade.UseMnemonic = False
        Me.btnGrade.UseVisualStyleBackColor = False
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
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnTeacher)
        Me.Panel2.Controls.Add(Me.btnSubject)
        Me.Panel2.Controls.Add(Me.btnClass)
        Me.Panel2.Controls.Add(Me.btnStudent)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.btnGrade)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(5, 91)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(159, 354)
        Me.Panel2.TabIndex = 34
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
        Me.btnTeacher.TabIndex = 23
        Me.btnTeacher.Text = "Teacher"
        Me.btnTeacher.UseMnemonic = False
        Me.btnTeacher.UseVisualStyleBackColor = False
        '
        'btnSubject
        '
        Me.btnSubject.BackColor = System.Drawing.Color.LightGray
        Me.btnSubject.Font = New System.Drawing.Font("Lato", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSubject.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnSubject.Location = New System.Drawing.Point(42, 52)
        Me.btnSubject.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSubject.Name = "btnSubject"
        Me.btnSubject.Size = New System.Drawing.Size(75, 34)
        Me.btnSubject.TabIndex = 22
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
        Me.btnClass.TabIndex = 21
        Me.btnClass.Text = "Class"
        Me.btnClass.UseMnemonic = False
        Me.btnClass.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lato Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(179, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 23)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Teacher Database"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'DGSiswa
        '
        Me.DGSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSiswa.Location = New System.Drawing.Point(179, 148)
        Me.DGSiswa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGSiswa.Name = "DGSiswa"
        Me.DGSiswa.RowHeadersWidth = 51
        Me.DGSiswa.RowTemplate.Height = 29
        Me.DGSiswa.Size = New System.Drawing.Size(612, 262)
        Me.DGSiswa.TabIndex = 32
        '
        'Teacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 452)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGSiswa)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Teacher"
        Me.Text = "Teacher"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGSiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnStudent As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnGrade As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Protected Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnTeacher As Button
    Friend WithEvents btnSubject As Button
    Friend WithEvents btnClass As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DGSiswa As DataGridView
End Class
