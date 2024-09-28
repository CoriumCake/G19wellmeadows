<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ForgotPasswordForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPasswordForm))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.a = New System.Windows.Forms.Panel()
        Me.pnlNewPassword = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNewPassword = New wellmeadows.RoundCornerTextbox()
        Me.txtConfirmPassword = New wellmeadows.RoundCornerTextbox()
        Me.btnSubmitNewPassword = New System.Windows.Forms.Button()
        Me.pnlEmailAndOTP = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmail = New wellmeadows.RoundCornerTextbox()
        Me.txtOTP = New wellmeadows.RoundCornerTextbox()
        Me.btnSendOTP = New System.Windows.Forms.Button()
        Me.btnSubmitOTP = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.a.SuspendLayout()
        Me.pnlNewPassword.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.pnlEmailAndOTP.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(3, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(828, 105)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(297, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 92)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Wellmeadows"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.wellmeadows.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(230, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.a)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(834, 562)
        Me.Panel1.TabIndex = 3
        '
        'a
        '
        Me.a.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.a.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.a.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.a.Controls.Add(Me.pnlNewPassword)
        Me.a.Controls.Add(Me.pnlEmailAndOTP)
        Me.a.Location = New System.Drawing.Point(0, 0)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(834, 562)
        Me.a.TabIndex = 1
        '
        'pnlNewPassword
        '
        Me.pnlNewPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.pnlNewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlNewPassword.Controls.Add(Me.TableLayoutPanel2)
        Me.pnlNewPassword.Location = New System.Drawing.Point(8, 8)
        Me.pnlNewPassword.Name = "pnlNewPassword"
        Me.pnlNewPassword.Size = New System.Drawing.Size(834, 562)
        Me.pnlNewPassword.TabIndex = 4
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.BackgroundImage = Global.wellmeadows.My.Resources.Resources.login_border
        Me.TableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.223!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.16725!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.60976!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtConfirmPassword, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txtNewPassword, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSubmitNewPassword, 1, 5)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(141, 123)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.07317!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.68293!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.13605!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(574, 395)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label7, 3)
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(565, 62)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "  New Password"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtNewPassword, 2)
        Me.txtNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(162, 115)
        Me.txtNewPassword.Margin = New System.Windows.Forms.Padding(0, 6, 3, 8)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(261, 30)
        Me.txtNewPassword.TabIndex = 10
        Me.txtNewPassword.UseSystemPasswordChar = True
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtConfirmPassword, 2)
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(162, 197)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(0, 6, 3, 8)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(261, 30)
        Me.txtConfirmPassword.TabIndex = 12
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'btnSubmitNewPassword
        '
        Me.btnSubmitNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSubmitNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSubmitNewPassword.BackgroundImage = Global.wellmeadows.My.Resources.Resources.login_button1
        Me.btnSubmitNewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSubmitNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitNewPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSubmitNewPassword.Location = New System.Drawing.Point(215, 250)
        Me.btnSubmitNewPassword.Margin = New System.Windows.Forms.Padding(15, 8, 3, 9)
        Me.btnSubmitNewPassword.Name = "btnSubmitNewPassword"
        Me.btnSubmitNewPassword.Size = New System.Drawing.Size(170, 47)
        Me.btnSubmitNewPassword.TabIndex = 9
        Me.btnSubmitNewPassword.Text = "SUBMIT"
        Me.btnSubmitNewPassword.UseVisualStyleBackColor = False
        '
        'pnlEmailAndOTP
        '
        Me.pnlEmailAndOTP.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlEmailAndOTP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEmailAndOTP.Location = New System.Drawing.Point(0, 0)
        Me.pnlEmailAndOTP.Name = "pnlEmailAndOTP"
        Me.pnlEmailAndOTP.Size = New System.Drawing.Size(834, 562)
        Me.pnlEmailAndOTP.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.BackgroundImage = Global.wellmeadows.My.Resources.Resources.login_border
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.38037!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.96933!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.6!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEmail, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtOTP, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSendOTP, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSubmitOTP, 2, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(141, 123)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.38461!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.69231!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.92308!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(574, 395)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 177)
        Me.Label4.Margin = New System.Windows.Forms.Padding(40, 0, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 83)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "OTP"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(40, 0, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 98)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label3, 4)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(565, 62)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "  Reset Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtEmail, 2)
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(129, 112)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(0, 6, 3, 8)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(356, 30)
        Me.txtEmail.TabIndex = 10
        '
        'txtOTP
        '
        Me.txtOTP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtOTP, 2)
        Me.txtOTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOTP.Location = New System.Drawing.Point(129, 202)
        Me.txtOTP.Margin = New System.Windows.Forms.Padding(0, 6, 3, 8)
        Me.txtOTP.Name = "txtOTP"
        Me.txtOTP.Size = New System.Drawing.Size(190, 30)
        Me.txtOTP.TabIndex = 12
        '
        'btnSendOTP
        '
        Me.btnSendOTP.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSendOTP.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSendOTP.BackgroundImage = Global.wellmeadows.My.Resources.Resources.login_button1
        Me.btnSendOTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSendOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendOTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendOTP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSendOTP.Location = New System.Drawing.Point(132, 268)
        Me.btnSendOTP.Margin = New System.Windows.Forms.Padding(3, 8, 3, 9)
        Me.btnSendOTP.Name = "btnSendOTP"
        Me.btnSendOTP.Size = New System.Drawing.Size(165, 55)
        Me.btnSendOTP.TabIndex = 13
        Me.btnSendOTP.Text = "OTP"
        Me.btnSendOTP.UseVisualStyleBackColor = False
        '
        'btnSubmitOTP
        '
        Me.btnSubmitOTP.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSubmitOTP.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSubmitOTP.BackgroundImage = Global.wellmeadows.My.Resources.Resources.login_button1
        Me.btnSubmitOTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSubmitOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitOTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitOTP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSubmitOTP.Location = New System.Drawing.Point(315, 268)
        Me.btnSubmitOTP.Margin = New System.Windows.Forms.Padding(15, 8, 3, 9)
        Me.btnSubmitOTP.Name = "btnSubmitOTP"
        Me.btnSubmitOTP.Size = New System.Drawing.Size(170, 55)
        Me.btnSubmitOTP.TabIndex = 9
        Me.btnSubmitOTP.Text = "SUBMIT"
        Me.btnSubmitOTP.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(162, 78)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Password"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(162, 165)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Confirm Password"
        '
        'ForgotPasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 562)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ForgotPasswordForm"
        Me.Text = "Wellsmeadows Hospital"
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.a.ResumeLayout(False)
        Me.pnlNewPassword.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.pnlEmailAndOTP.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents a As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnSubmitOTP As Button
    Friend WithEvents txtEmail As RoundCornerTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtOTP As RoundCornerTextbox
    Friend WithEvents btnSendOTP As Button
    Friend WithEvents pnlNewPassword As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNewPassword As RoundCornerTextbox
    Friend WithEvents txtConfirmPassword As RoundCornerTextbox
    Friend WithEvents btnSubmitNewPassword As Button
    Friend WithEvents pnlEmailAndOTP As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
