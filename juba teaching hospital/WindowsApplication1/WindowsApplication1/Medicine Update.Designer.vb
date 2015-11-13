<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medicine_Update
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
        Dim M_idLabel As System.Windows.Forms.Label
        Dim Medicine_nameLabel As System.Windows.Forms.Label
        Dim Med_typeLabel As System.Windows.Forms.Label
        Dim Amount_unitLabel As System.Windows.Forms.Label
        Dim Expired_dateLabel As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Medicine_Update))
        Me.Hospital_management_systemDataSet = New WindowsApplication1.Hospital_management_systemDataSet()
        Me.Medicine_UpdateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Medicine_UpdateTableAdapter = New WindowsApplication1.Hospital_management_systemDataSetTableAdapters.Medicine_UpdateTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager()
        Me.Medicine_UpdateBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Medicine_UpdateBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.M_idTextBox = New System.Windows.Forms.TextBox()
        Me.Medicine_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Med_typeTextBox = New System.Windows.Forms.TextBox()
        Me.Amount_unitTextBox = New System.Windows.Forms.TextBox()
        Me.Expired_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        M_idLabel = New System.Windows.Forms.Label()
        Medicine_nameLabel = New System.Windows.Forms.Label()
        Med_typeLabel = New System.Windows.Forms.Label()
        Amount_unitLabel = New System.Windows.Forms.Label()
        Expired_dateLabel = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        CType(Me.Hospital_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Medicine_UpdateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Medicine_UpdateBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Medicine_UpdateBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'M_idLabel
        '
        M_idLabel.AutoSize = True
        M_idLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        M_idLabel.Location = New System.Drawing.Point(71, 60)
        M_idLabel.Name = "M_idLabel"
        M_idLabel.Size = New System.Drawing.Size(41, 16)
        M_idLabel.TabIndex = 1
        M_idLabel.Text = "M id:"
        '
        'Medicine_nameLabel
        '
        Medicine_nameLabel.AutoSize = True
        Medicine_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Medicine_nameLabel.Location = New System.Drawing.Point(28, 84)
        Medicine_nameLabel.Name = "Medicine_nameLabel"
        Medicine_nameLabel.Size = New System.Drawing.Size(84, 16)
        Medicine_nameLabel.TabIndex = 3
        Medicine_nameLabel.Text = "Med name:"
        AddHandler Medicine_nameLabel.Click, AddressOf Me.Medicine_nameLabel_Click
        '
        'Med_typeLabel
        '
        Med_typeLabel.AutoSize = True
        Med_typeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Med_typeLabel.Location = New System.Drawing.Point(36, 112)
        Med_typeLabel.Name = "Med_typeLabel"
        Med_typeLabel.Size = New System.Drawing.Size(76, 16)
        Med_typeLabel.TabIndex = 5
        Med_typeLabel.Text = "Med type:"
        '
        'Amount_unitLabel
        '
        Amount_unitLabel.AutoSize = True
        Amount_unitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Amount_unitLabel.Location = New System.Drawing.Point(20, 138)
        Amount_unitLabel.Name = "Amount_unitLabel"
        Amount_unitLabel.Size = New System.Drawing.Size(92, 16)
        Amount_unitLabel.TabIndex = 7
        Amount_unitLabel.Text = "Amount/unit:"
        '
        'Expired_dateLabel
        '
        Expired_dateLabel.AutoSize = True
        Expired_dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Expired_dateLabel.Location = New System.Drawing.Point(12, 163)
        Expired_dateLabel.Name = "Expired_dateLabel"
        Expired_dateLabel.Size = New System.Drawing.Size(100, 16)
        Expired_dateLabel.TabIndex = 9
        Expired_dateLabel.Text = "Expired date:"
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StockLabel.Location = New System.Drawing.Point(61, 188)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(51, 16)
        StockLabel.TabIndex = 11
        StockLabel.Text = "Stock:"
        '
        'Hospital_management_systemDataSet
        '
        Me.Hospital_management_systemDataSet.DataSetName = "Hospital_management_systemDataSet"
        Me.Hospital_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Medicine_UpdateBindingSource
        '
        Me.Medicine_UpdateBindingSource.DataMember = "Medicine Update"
        Me.Medicine_UpdateBindingSource.DataSource = Me.Hospital_management_systemDataSet
        '
        'Medicine_UpdateTableAdapter
        '
        Me.Medicine_UpdateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Add_new_departmentTableAdapter = Nothing
        Me.TableAdapterManager.Add_new_RoomTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Blood_Bank_RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Discharge_SheetTableAdapter = Nothing
        Me.TableAdapterManager.Doctor_s_registrationTableAdapter = Nothing
        Me.TableAdapterManager.Doctor_UpdateTableAdapter = Nothing
        Me.TableAdapterManager.IP_BillTableAdapter = Nothing
        Me.TableAdapterManager.Lab_BillTableAdapter = Nothing
        Me.TableAdapterManager.Medicine_UpdateTableAdapter = Me.Medicine_UpdateTableAdapter
        Me.TableAdapterManager.OP_BillTableAdapter = Nothing
        Me.TableAdapterManager.Patient_RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Pharmacy_BillTableAdapter = Nothing
        Me.TableAdapterManager.RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Room_allocationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Medicine_UpdateBindingNavigator
        '
        Me.Medicine_UpdateBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Medicine_UpdateBindingNavigator.BindingSource = Me.Medicine_UpdateBindingSource
        Me.Medicine_UpdateBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Medicine_UpdateBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Medicine_UpdateBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Medicine_UpdateBindingNavigatorSaveItem})
        Me.Medicine_UpdateBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Medicine_UpdateBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Medicine_UpdateBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Medicine_UpdateBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Medicine_UpdateBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Medicine_UpdateBindingNavigator.Name = "Medicine_UpdateBindingNavigator"
        Me.Medicine_UpdateBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Medicine_UpdateBindingNavigator.Size = New System.Drawing.Size(627, 25)
        Me.Medicine_UpdateBindingNavigator.TabIndex = 0
        Me.Medicine_UpdateBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Medicine_UpdateBindingNavigatorSaveItem
        '
        Me.Medicine_UpdateBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Medicine_UpdateBindingNavigatorSaveItem.Image = CType(resources.GetObject("Medicine_UpdateBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Medicine_UpdateBindingNavigatorSaveItem.Name = "Medicine_UpdateBindingNavigatorSaveItem"
        Me.Medicine_UpdateBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Medicine_UpdateBindingNavigatorSaveItem.Text = "Save Data"
        '
        'M_idTextBox
        '
        Me.M_idTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.M_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Medicine_UpdateBindingSource, "M_id", True))
        Me.M_idTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M_idTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.M_idTextBox.Location = New System.Drawing.Point(124, 55)
        Me.M_idTextBox.Name = "M_idTextBox"
        Me.M_idTextBox.Size = New System.Drawing.Size(176, 21)
        Me.M_idTextBox.TabIndex = 2
        '
        'Medicine_nameTextBox
        '
        Me.Medicine_nameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Medicine_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Medicine_UpdateBindingSource, "Medicine name", True))
        Me.Medicine_nameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Medicine_nameTextBox.Location = New System.Drawing.Point(124, 81)
        Me.Medicine_nameTextBox.Name = "Medicine_nameTextBox"
        Me.Medicine_nameTextBox.Size = New System.Drawing.Size(176, 21)
        Me.Medicine_nameTextBox.TabIndex = 4
        '
        'Med_typeTextBox
        '
        Me.Med_typeTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Med_typeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Medicine_UpdateBindingSource, "Med_type", True))
        Me.Med_typeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Med_typeTextBox.Location = New System.Drawing.Point(124, 107)
        Me.Med_typeTextBox.Name = "Med_typeTextBox"
        Me.Med_typeTextBox.Size = New System.Drawing.Size(176, 21)
        Me.Med_typeTextBox.TabIndex = 6
        '
        'Amount_unitTextBox
        '
        Me.Amount_unitTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Amount_unitTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Amount_unitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Medicine_UpdateBindingSource, "Amount/unit", True))
        Me.Amount_unitTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Amount_unitTextBox.Location = New System.Drawing.Point(124, 133)
        Me.Amount_unitTextBox.Name = "Amount_unitTextBox"
        Me.Amount_unitTextBox.Size = New System.Drawing.Size(176, 21)
        Me.Amount_unitTextBox.TabIndex = 8
        '
        'Expired_dateDateTimePicker
        '
        Me.Expired_dateDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDark
        Me.Expired_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Medicine_UpdateBindingSource, "Expired date", True))
        Me.Expired_dateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Expired_dateDateTimePicker.Location = New System.Drawing.Point(124, 159)
        Me.Expired_dateDateTimePicker.Name = "Expired_dateDateTimePicker"
        Me.Expired_dateDateTimePicker.Size = New System.Drawing.Size(176, 21)
        Me.Expired_dateDateTimePicker.TabIndex = 10
        '
        'StockTextBox
        '
        Me.StockTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.StockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Medicine_UpdateBindingSource, "Stock", True))
        Me.StockTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.StockTextBox.Location = New System.Drawing.Point(124, 185)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(176, 21)
        Me.StockTextBox.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(100, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(181, 239)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "View"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(262, 239)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Back"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(343, 239)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.Medicine_UpdateBindingSource
        Me.ComboBox1.DisplayMember = "Medicine name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(386, 61)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(163, 21)
        Me.ComboBox1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(555, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 18)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Look up"
        '
        'Medicine_Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(627, 274)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(M_idLabel)
        Me.Controls.Add(Me.M_idTextBox)
        Me.Controls.Add(Medicine_nameLabel)
        Me.Controls.Add(Me.Medicine_nameTextBox)
        Me.Controls.Add(Med_typeLabel)
        Me.Controls.Add(Me.Med_typeTextBox)
        Me.Controls.Add(Amount_unitLabel)
        Me.Controls.Add(Me.Amount_unitTextBox)
        Me.Controls.Add(Expired_dateLabel)
        Me.Controls.Add(Me.Expired_dateDateTimePicker)
        Me.Controls.Add(StockLabel)
        Me.Controls.Add(Me.StockTextBox)
        Me.Controls.Add(Me.Medicine_UpdateBindingNavigator)
        Me.Name = "Medicine_Update"
        Me.Text = "Medicine_Update"
        CType(Me.Hospital_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Medicine_UpdateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Medicine_UpdateBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Medicine_UpdateBindingNavigator.ResumeLayout(False)
        Me.Medicine_UpdateBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Hospital_management_systemDataSet As WindowsApplication1.Hospital_management_systemDataSet
    Friend WithEvents Medicine_UpdateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Medicine_UpdateTableAdapter As WindowsApplication1.Hospital_management_systemDataSetTableAdapters.Medicine_UpdateTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Medicine_UpdateBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Medicine_UpdateBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents M_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Medicine_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Med_typeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Amount_unitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Expired_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents StockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
