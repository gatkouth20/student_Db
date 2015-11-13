<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpeningAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClosingAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WithdrawalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepositToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ATMCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusinessAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(67, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(832, 349)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomePageToolStripMenuItem, Me.ContactToolStripMenuItem, Me.AboutUsToolStripMenuItem, Me.StaffToolStripMenuItem, Me.ServicesToolStripMenuItem, Me.LocationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(957, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomePageToolStripMenuItem
        '
        Me.HomePageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoanToolStripMenuItem, Me.OpeningAccountToolStripMenuItem, Me.ClosingAccountToolStripMenuItem, Me.WithdrawalToolStripMenuItem, Me.DepositToolStripMenuItem, Me.ATMCardToolStripMenuItem})
        Me.HomePageToolStripMenuItem.Name = "HomePageToolStripMenuItem"
        Me.HomePageToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.HomePageToolStripMenuItem.Text = "home page"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ContactToolStripMenuItem.Text = "Contact"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AboutUsToolStripMenuItem.Text = "About Us"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.StaffToolStripMenuItem.Text = "Staff"
        '
        'ServicesToolStripMenuItem
        '
        Me.ServicesToolStripMenuItem.Name = "ServicesToolStripMenuItem"
        Me.ServicesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ServicesToolStripMenuItem.Text = "Services"
        '
        'LocationToolStripMenuItem
        '
        Me.LocationToolStripMenuItem.Name = "LocationToolStripMenuItem"
        Me.LocationToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.LocationToolStripMenuItem.Text = "Location"
        '
        'LoanToolStripMenuItem
        '
        Me.LoanToolStripMenuItem.Name = "LoanToolStripMenuItem"
        Me.LoanToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.LoanToolStripMenuItem.Text = "loan"
        '
        'OpeningAccountToolStripMenuItem
        '
        Me.OpeningAccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentAccountToolStripMenuItem, Me.BusinessAccountToolStripMenuItem, Me.PersonalAccountToolStripMenuItem})
        Me.OpeningAccountToolStripMenuItem.Name = "OpeningAccountToolStripMenuItem"
        Me.OpeningAccountToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.OpeningAccountToolStripMenuItem.Text = "opening account"
        '
        'ClosingAccountToolStripMenuItem
        '
        Me.ClosingAccountToolStripMenuItem.Name = "ClosingAccountToolStripMenuItem"
        Me.ClosingAccountToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ClosingAccountToolStripMenuItem.Text = "Closing account"
        '
        'WithdrawalToolStripMenuItem
        '
        Me.WithdrawalToolStripMenuItem.Name = "WithdrawalToolStripMenuItem"
        Me.WithdrawalToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.WithdrawalToolStripMenuItem.Text = "withdrawal"
        '
        'DepositToolStripMenuItem
        '
        Me.DepositToolStripMenuItem.Name = "DepositToolStripMenuItem"
        Me.DepositToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DepositToolStripMenuItem.Text = "deposit"
        '
        'ATMCardToolStripMenuItem
        '
        Me.ATMCardToolStripMenuItem.Name = "ATMCardToolStripMenuItem"
        Me.ATMCardToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ATMCardToolStripMenuItem.Text = "ATM Card"
        '
        'StudentAccountToolStripMenuItem
        '
        Me.StudentAccountToolStripMenuItem.Name = "StudentAccountToolStripMenuItem"
        Me.StudentAccountToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.StudentAccountToolStripMenuItem.Text = "student account"
        '
        'BusinessAccountToolStripMenuItem
        '
        Me.BusinessAccountToolStripMenuItem.Name = "BusinessAccountToolStripMenuItem"
        Me.BusinessAccountToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.BusinessAccountToolStripMenuItem.Text = "business Account"
        '
        'PersonalAccountToolStripMenuItem
        '
        Me.PersonalAccountToolStripMenuItem.Name = "PersonalAccountToolStripMenuItem"
        Me.PersonalAccountToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.PersonalAccountToolStripMenuItem.Text = "Personal Account"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(957, 494)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Home page"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HomePageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpeningAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClosingAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WithdrawalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepositToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ATMCardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BusinessAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
