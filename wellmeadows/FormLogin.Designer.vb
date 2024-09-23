<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RoundCornerTextbox1 = New wellmeadows.RoundCornerTextbox()
        Me.RoundCornerTextbox2 = New wellmeadows.RoundCornerTextbox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(556, 365)
        Me.Panel1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(2, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(552, 68)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(198, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 60)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Wellmeadows"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(556, 365)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.wellmeadows.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(153, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.BackgroundImage = Global.wellmeadows.My.Resources.Resources.login_border
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.0863!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.71719!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.39002!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox1, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LinkLabel1, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.RoundCornerTextbox1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.RoundCornerTextbox2, 1, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(94, 80)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.10582!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.58201!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.33862!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(383, 257)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(147, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 40)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Login"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 108)
        Me.Label4.Margin = New System.Windows.Forms.Padding(27, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 57)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Password"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(27, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 57)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(147, 167)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 5)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(99, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "show password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(272, 165)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(109, 23)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "forgot password?"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LinkLabel1.UseMnemonic = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Button1.BackgroundImage = Global.wellmeadows.My.Resources.Resources.login_button1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(151, 197)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 5, 2, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 36)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RoundCornerTextbox1
        '
        Me.RoundCornerTextbox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel1.SetColumnSpan(Me.RoundCornerTextbox1, 2)
        Me.RoundCornerTextbox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundCornerTextbox1.Location = New System.Drawing.Point(147, 66)
        Me.RoundCornerTextbox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 5)
        Me.RoundCornerTextbox1.Name = "RoundCornerTextbox1"
        Me.RoundCornerTextbox1.Size = New System.Drawing.Size(197, 23)
        Me.RoundCornerTextbox1.TabIndex = 10
        '
        'RoundCornerTextbox2
        '
        Me.RoundCornerTextbox2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel1.SetColumnSpan(Me.RoundCornerTextbox2, 2)
        Me.RoundCornerTextbox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundCornerTextbox2.Location = New System.Drawing.Point(147, 123)
        Me.RoundCornerTextbox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 5)
        Me.RoundCornerTextbox2.Name = "RoundCornerTextbox2"
        Me.RoundCornerTextbox2.Size = New System.Drawing.Size(197, 23)
        Me.RoundCornerTextbox2.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(556, 365)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(668, 522)
        Me.MinimumSize = New System.Drawing.Size(568, 392)
        Me.Name = "Form1"
        Me.Text = "Wellsmeadows Hospital"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents RoundCornerTextbox1 As RoundCornerTextbox
    Friend WithEvents RoundCornerTextbox2 As RoundCornerTextbox
End Class
