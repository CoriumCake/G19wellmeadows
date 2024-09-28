<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAppointment
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RoundCornerTextbox14 = New wellmeadows.RoundCornerTextbox()
        Me.RoundCornerTextbox12 = New wellmeadows.RoundCornerTextbox()
        Me.RoundCornerTextbox7 = New wellmeadows.RoundCornerTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RoundCornerTextbox1 = New wellmeadows.RoundCornerTextbox()
        Me.RoundCornerTextbox2 = New wellmeadows.RoundCornerTextbox()
        Me.RoundCornerTextbox3 = New wellmeadows.RoundCornerTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PatientFeedbackTableAdapter1 = New wellmeadows.dbWellsmeadowsHospitalG19DataSetTableAdapters.PatientFeedbackTableAdapter()
        Me.DbWellsmeadowsHospitalG19DataSet1 = New wellmeadows.dbWellsmeadowsHospitalG19DataSet()
        CType(Me.DbWellsmeadowsHospitalG19DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(207, 160)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "PatientID"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(559, 159)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 13)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "AppointmentID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(394, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "StaffID"
        '
        'RoundCornerTextbox14
        '
        Me.RoundCornerTextbox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundCornerTextbox14.Location = New System.Drawing.Point(394, 184)
        Me.RoundCornerTextbox14.Margin = New System.Windows.Forms.Padding(2, 2, 2, 5)
        Me.RoundCornerTextbox14.Name = "RoundCornerTextbox14"
        Me.RoundCornerTextbox14.Size = New System.Drawing.Size(142, 23)
        Me.RoundCornerTextbox14.TabIndex = 43
        '
        'RoundCornerTextbox12
        '
        Me.RoundCornerTextbox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundCornerTextbox12.Location = New System.Drawing.Point(207, 184)
        Me.RoundCornerTextbox12.Margin = New System.Windows.Forms.Padding(2, 2, 2, 5)
        Me.RoundCornerTextbox12.Name = "RoundCornerTextbox12"
        Me.RoundCornerTextbox12.Size = New System.Drawing.Size(142, 23)
        Me.RoundCornerTextbox12.TabIndex = 42
        '
        'RoundCornerTextbox7
        '
        Me.RoundCornerTextbox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundCornerTextbox7.Location = New System.Drawing.Point(562, 248)
        Me.RoundCornerTextbox7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 5)
        Me.RoundCornerTextbox7.Name = "RoundCornerTextbox7"
        Me.RoundCornerTextbox7.Size = New System.Drawing.Size(145, 23)
        Me.RoundCornerTextbox7.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(210, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "ExaminationRoom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(400, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "AppointmentTime"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(590, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "AppointmentDate"
        '
        'RoundCornerTextbox1
        '
        Me.RoundCornerTextbox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundCornerTextbox1.Location = New System.Drawing.Point(562, 184)
        Me.RoundCornerTextbox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 5)
        Me.RoundCornerTextbox1.Name = "RoundCornerTextbox1"
        Me.RoundCornerTextbox1.Size = New System.Drawing.Size(142, 23)
        Me.RoundCornerTextbox1.TabIndex = 49
        '
        'RoundCornerTextbox2
        '
        Me.RoundCornerTextbox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundCornerTextbox2.Location = New System.Drawing.Point(210, 248)
        Me.RoundCornerTextbox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 5)
        Me.RoundCornerTextbox2.Name = "RoundCornerTextbox2"
        Me.RoundCornerTextbox2.Size = New System.Drawing.Size(142, 23)
        Me.RoundCornerTextbox2.TabIndex = 48
        '
        'RoundCornerTextbox3
        '
        Me.RoundCornerTextbox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundCornerTextbox3.Location = New System.Drawing.Point(397, 248)
        Me.RoundCornerTextbox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 5)
        Me.RoundCornerTextbox3.Name = "RoundCornerTextbox3"
        Me.RoundCornerTextbox3.Size = New System.Drawing.Size(145, 23)
        Me.RoundCornerTextbox3.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(388, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 31)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Appointment "
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Button2.BackgroundImage = Global.wellmeadows.My.Resources.Resources.login_button1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(605, 351)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 5, 2, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 36)
        Me.Button2.TabIndex = 55
        Me.Button2.Text = "NEXT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Button1.BackgroundImage = Global.wellmeadows.My.Resources.Resources.login_button1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(457, 351)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 5, 2, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 36)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PatientFeedbackTableAdapter1
        '
        Me.PatientFeedbackTableAdapter1.ClearBeforeFill = True
        '
        'DbWellsmeadowsHospitalG19DataSet1
        '
        Me.DbWellsmeadowsHospitalG19DataSet1.DataSetName = "dbWellsmeadowsHospitalG19DataSet"
        Me.DbWellsmeadowsHospitalG19DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FormAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 490)
        Me.Controls.Add(Me.RoundCornerTextbox14)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RoundCornerTextbox1)
        Me.Controls.Add(Me.RoundCornerTextbox2)
        Me.Controls.Add(Me.RoundCornerTextbox3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RoundCornerTextbox12)
        Me.Controls.Add(Me.RoundCornerTextbox7)
        Me.Name = "FormAppointment"
        Me.Text = "FromAppointment"
        CType(Me.DbWellsmeadowsHospitalG19DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RoundCornerTextbox14 As RoundCornerTextbox
    Friend WithEvents RoundCornerTextbox12 As RoundCornerTextbox
    Friend WithEvents RoundCornerTextbox7 As RoundCornerTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RoundCornerTextbox1 As RoundCornerTextbox
    Friend WithEvents RoundCornerTextbox2 As RoundCornerTextbox
    Friend WithEvents RoundCornerTextbox3 As RoundCornerTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PatientFeedbackTableAdapter1 As dbWellsmeadowsHospitalG19DataSetTableAdapters.PatientFeedbackTableAdapter
    Friend WithEvents DbWellsmeadowsHospitalG19DataSet1 As dbWellsmeadowsHospitalG19DataSet
End Class
