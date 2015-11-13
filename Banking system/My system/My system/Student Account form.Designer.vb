<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Account_form
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_Account_form))
        Dim StuIDLabel As System.Windows.Forms.Label
        Dim Colleg_universityLabel As System.Windows.Forms.Label
        Dim End_dateLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim OthernameLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim Birth_certificateLabel As System.Windows.Forms.Label
        Dim Relation_with_applicantLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim SignLabel As System.Windows.Forms.Label
        Me.Banking_managmentDataSet = New My_system.Banking_managmentDataSet()
        Me.Student_accountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_accountTableAdapter = New My_system.Banking_managmentDataSetTableAdapters.student_accountTableAdapter()
        Me.TableAdapterManager = New My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager()
        Me.Student_accountBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Student_accountBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StuIDTextBox = New System.Windows.Forms.TextBox()
        Me.Colleg_universityTextBox = New System.Windows.Forms.TextBox()
        Me.End_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.OthernameTextBox = New System.Windows.Forms.TextBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Birth_certificateTextBox = New System.Windows.Forms.TextBox()
        Me.Relation_with_applicantTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SignTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        StuIDLabel = New System.Windows.Forms.Label()
        Colleg_universityLabel = New System.Windows.Forms.Label()
        End_dateLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        OthernameLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        Birth_certificateLabel = New System.Windows.Forms.Label()
        Relation_with_applicantLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        SignLabel = New System.Windows.Forms.Label()
        CType(Me.Banking_managmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_accountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_accountBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Student_accountBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Banking_managmentDataSet
        '
        Me.Banking_managmentDataSet.DataSetName = "Banking_managmentDataSet"
        Me.Banking_managmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Student_accountBindingSource
        '
        Me.Student_accountBindingSource.DataMember = "student account"
        Me.Student_accountBindingSource.DataSource = Me.Banking_managmentDataSet
        '
        'Student_accountTableAdapter
        '
        Me.Student_accountTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Account_closing_formTableAdapter = Nothing
        Me.TableAdapterManager.ATM_CardTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Check_Book_detailTableAdapter = Nothing
        Me.TableAdapterManager.Deposite_informationTableAdapter = Nothing
        Me.TableAdapterManager.Loan_informationTableAdapter = Nothing
        Me.TableAdapterManager.Official_Use_onlyTableAdapter = Nothing
        Me.TableAdapterManager.Opening_accountTableAdapter = Nothing
        Me.TableAdapterManager.student_accountTableAdapter = Me.Student_accountTableAdapter
        Me.TableAdapterManager.Transaction_infoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Withdrawal_formTableAdapter = Nothing
        Me.TableAdapterManager.Witness_informationTableAdapter = Nothing
        '
        'Student_accountBindingNavigator
        '
        Me.Student_accountBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Student_accountBindingNavigator.BindingSource = Me.Student_accountBindingSource
        Me.Student_accountBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Student_accountBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Student_accountBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Student_accountBindingNavigatorSaveItem})
        Me.Student_accountBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Student_accountBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Student_accountBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Student_accountBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Student_accountBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Student_accountBindingNavigator.Name = "Student_accountBindingNavigator"
        Me.Student_accountBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Student_accountBindingNavigator.Size = New System.Drawing.Size(965, 25)
        Me.Student_accountBindingNavigator.TabIndex = 0
        Me.Student_accountBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Student_accountBindingNavigatorSaveItem
        '
        Me.Student_accountBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Student_accountBindingNavigatorSaveItem.Image = CType(resources.GetObject("Student_accountBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Student_accountBindingNavigatorSaveItem.Name = "Student_accountBindingNavigatorSaveItem"
        Me.Student_accountBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Student_accountBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StuIDLabel
        '
        StuIDLabel.AutoSize = True
        StuIDLabel.Location = New System.Drawing.Point(98, 44)
        StuIDLabel.Name = "StuIDLabel"
        StuIDLabel.Size = New System.Drawing.Size(38, 13)
        StuIDLabel.TabIndex = 1
        StuIDLabel.Text = "stu ID:"
        '
        'StuIDTextBox
        '
        Me.StuIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_accountBindingSource, "stuID", True))
        Me.StuIDTextBox.Location = New System.Drawing.Point(151, 44)
        Me.StuIDTextBox.Name = "StuIDTextBox"
        Me.StuIDTextBox.Size = New System.Drawing.Size(96, 20)
        Me.StuIDTextBox.TabIndex = 2
        '
        'Colleg_universityLabel
        '
        Colleg_universityLabel.AutoSize = True
        Colleg_universityLabel.Location = New System.Drawing.Point(48, 70)
        Colleg_universityLabel.Name = "Colleg_universityLabel"
        Colleg_universityLabel.Size = New System.Drawing.Size(88, 13)
        Colleg_universityLabel.TabIndex = 3
        Colleg_universityLabel.Text = "Colleg/university:"
        '
        'Colleg_universityTextBox
        '
        Me.Colleg_universityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_accountBindingSource, "Colleg/university", True))
        Me.Colleg_universityTextBox.Location = New System.Drawing.Point(151, 70)
        Me.Colleg_universityTextBox.Name = "Colleg_universityTextBox"
        Me.Colleg_universityTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Colleg_universityTextBox.TabIndex = 4
        '
        'End_dateLabel
        '
        End_dateLabel.AutoSize = True
        End_dateLabel.Location = New System.Drawing.Point(83, 96)
        End_dateLabel.Name = "End_dateLabel"
        End_dateLabel.Size = New System.Drawing.Size(53, 13)
        End_dateLabel.TabIndex = 5
        End_dateLabel.Text = "End date:"
        '
        'End_dateDateTimePicker
        '
        Me.End_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Student_accountBindingSource, "End date", True))
        Me.End_dateDateTimePicker.Location = New System.Drawing.Point(151, 96)
        Me.End_dateDateTimePicker.Name = "End_dateDateTimePicker"
        Me.End_dateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.End_dateDateTimePicker.TabIndex = 6
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(84, 122)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(52, 13)
        SurnameLabel.TabIndex = 7
        SurnameLabel.Text = "Surname:"
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_accountBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(151, 122)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SurnameTextBox.TabIndex = 8
        '
        'OthernameLabel
        '
        OthernameLabel.AutoSize = True
        OthernameLabel.Location = New System.Drawing.Point(74, 148)
        OthernameLabel.Name = "OthernameLabel"
        OthernameLabel.Size = New System.Drawing.Size(62, 13)
        OthernameLabel.TabIndex = 9
        OthernameLabel.Text = "Othername:"
        '
        'OthernameTextBox
        '
        Me.OthernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_accountBindingSource, "Othername", True))
        Me.OthernameTextBox.Location = New System.Drawing.Point(151, 148)
        Me.OthernameTextBox.Name = "OthernameTextBox"
        Me.OthernameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OthernameTextBox.TabIndex = 10
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(103, 174)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(33, 13)
        DOBLabel.TabIndex = 11
        DOBLabel.Text = "DOB:"
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Student_accountBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(151, 174)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DOBDateTimePicker.TabIndex = 12
        '
        'Birth_certificateLabel
        '
        Birth_certificateLabel.AutoSize = True
        Birth_certificateLabel.Location = New System.Drawing.Point(56, 203)
        Birth_certificateLabel.Name = "Birth_certificateLabel"
        Birth_certificateLabel.Size = New System.Drawing.Size(80, 13)
        Birth_certificateLabel.TabIndex = 13
        Birth_certificateLabel.Text = "Birth certificate:"
        '
        'Birth_certificateTextBox
        '
        Me.Birth_certificateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_accountBindingSource, "Birth certificate", True))
        Me.Birth_certificateTextBox.Location = New System.Drawing.Point(151, 200)
        Me.Birth_certificateTextBox.Name = "Birth_certificateTextBox"
        Me.Birth_certificateTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Birth_certificateTextBox.TabIndex = 14
        '
        'Relation_with_applicantLabel
        '
        Relation_with_applicantLabel.AutoSize = True
        Relation_with_applicantLabel.Location = New System.Drawing.Point(19, 226)
        Relation_with_applicantLabel.Name = "Relation_with_applicantLabel"
        Relation_with_applicantLabel.Size = New System.Drawing.Size(117, 13)
        Relation_with_applicantLabel.TabIndex = 15
        Relation_with_applicantLabel.Text = "Relation with applicant:"
        '
        'Relation_with_applicantTextBox
        '
        Me.Relation_with_applicantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_accountBindingSource, "relation with applicant", True))
        Me.Relation_with_applicantTextBox.Location = New System.Drawing.Point(151, 226)
        Me.Relation_with_applicantTextBox.Name = "Relation_with_applicantTextBox"
        Me.Relation_with_applicantTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Relation_with_applicantTextBox.TabIndex = 16
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(103, 252)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 17
        DateLabel.Text = "Date:"
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Student_accountBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(151, 252)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 18
        '
        'SignLabel
        '
        SignLabel.AutoSize = True
        SignLabel.Location = New System.Drawing.Point(105, 278)
        SignLabel.Name = "SignLabel"
        SignLabel.Size = New System.Drawing.Size(31, 13)
        SignLabel.TabIndex = 19
        SignLabel.Text = "Sign:"
        '
        'SignTextBox
        '
        Me.SignTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_accountBindingSource, "Sign", True))
        Me.SignTextBox.Location = New System.Drawing.Point(151, 278)
        Me.SignTextBox.Name = "SignTextBox"
        Me.SignTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SignTextBox.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(151, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Save Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(232, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "View Db"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(313, 327)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(394, 327)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(475, 327)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "Close"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.Student_accountBindingSource
        Me.ComboBox1.DisplayMember = "Colleg/university"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(538, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(173, 21)
        Me.ComboBox1.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(717, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "LookUp"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(357, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(619, 263)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Student_Account_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(965, 369)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(StuIDLabel)
        Me.Controls.Add(Me.StuIDTextBox)
        Me.Controls.Add(Colleg_universityLabel)
        Me.Controls.Add(Me.Colleg_universityTextBox)
        Me.Controls.Add(End_dateLabel)
        Me.Controls.Add(Me.End_dateDateTimePicker)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(OthernameLabel)
        Me.Controls.Add(Me.OthernameTextBox)
        Me.Controls.Add(DOBLabel)
        Me.Controls.Add(Me.DOBDateTimePicker)
        Me.Controls.Add(Birth_certificateLabel)
        Me.Controls.Add(Me.Birth_certificateTextBox)
        Me.Controls.Add(Relation_with_applicantLabel)
        Me.Controls.Add(Me.Relation_with_applicantTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(SignLabel)
        Me.Controls.Add(Me.SignTextBox)
        Me.Controls.Add(Me.Student_accountBindingNavigator)
        Me.Name = "Student_Account_form"
        Me.Text = "Student_Account_form"
        CType(Me.Banking_managmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_accountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_accountBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Student_accountBindingNavigator.ResumeLayout(False)
        Me.Student_accountBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Banking_managmentDataSet As My_system.Banking_managmentDataSet
    Friend WithEvents Student_accountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Student_accountTableAdapter As My_system.Banking_managmentDataSetTableAdapters.student_accountTableAdapter
    Friend WithEvents TableAdapterManager As My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Student_accountBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Student_accountBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents StuIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Colleg_universityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents End_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OthernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOBDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Birth_certificateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Relation_with_applicantTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SignTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
