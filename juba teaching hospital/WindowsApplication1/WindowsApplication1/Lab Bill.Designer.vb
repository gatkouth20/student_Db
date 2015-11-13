<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lab_Bill
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
        Dim Bill_numberLabel As System.Windows.Forms.Label
        Dim PatientLabel As System.Windows.Forms.Label
        Dim Lab_test_nameLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lab_Bill))
        Me.Hospital_management_systemDataSet = New WindowsApplication1.Hospital_management_systemDataSet()
        Me.Lab_BillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lab_BillTableAdapter = New WindowsApplication1.Hospital_management_systemDataSetTableAdapters.Lab_BillTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager()
        Me.Bill_numberTextBox = New System.Windows.Forms.TextBox()
        Me.PatientTextBox = New System.Windows.Forms.TextBox()
        Me.Lab_test_nameTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BillNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabTestNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pharmacy_BillBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Pharmacy_BillBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Bill_numberLabel = New System.Windows.Forms.Label()
        PatientLabel = New System.Windows.Forms.Label()
        Lab_test_nameLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        CType(Me.Hospital_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lab_BillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pharmacy_BillBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pharmacy_BillBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bill_numberLabel
        '
        Bill_numberLabel.AutoSize = True
        Bill_numberLabel.Location = New System.Drawing.Point(22, 95)
        Bill_numberLabel.Name = "Bill_numberLabel"
        Bill_numberLabel.Size = New System.Drawing.Size(61, 13)
        Bill_numberLabel.TabIndex = 1
        Bill_numberLabel.Text = "Bill number:"
        '
        'PatientLabel
        '
        PatientLabel.AutoSize = True
        PatientLabel.Location = New System.Drawing.Point(22, 121)
        PatientLabel.Name = "PatientLabel"
        PatientLabel.Size = New System.Drawing.Size(43, 13)
        PatientLabel.TabIndex = 3
        PatientLabel.Text = "Patient:"
        '
        'Lab_test_nameLabel
        '
        Lab_test_nameLabel.AutoSize = True
        Lab_test_nameLabel.Location = New System.Drawing.Point(22, 147)
        Lab_test_nameLabel.Name = "Lab_test_nameLabel"
        Lab_test_nameLabel.Size = New System.Drawing.Size(77, 13)
        Lab_test_nameLabel.TabIndex = 5
        Lab_test_nameLabel.Text = "Lab test name:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Location = New System.Drawing.Point(22, 173)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(46, 13)
        AmountLabel.TabIndex = 7
        AmountLabel.Text = "Amount:"
        '
        'Hospital_management_systemDataSet
        '
        Me.Hospital_management_systemDataSet.DataSetName = "Hospital_management_systemDataSet"
        Me.Hospital_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lab_BillBindingSource
        '
        Me.Lab_BillBindingSource.DataMember = "Lab Bill"
        Me.Lab_BillBindingSource.DataSource = Me.Hospital_management_systemDataSet
        '
        'Lab_BillTableAdapter
        '
        Me.Lab_BillTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Lab_BillTableAdapter = Me.Lab_BillTableAdapter
        Me.TableAdapterManager.Medicine_UpdateTableAdapter = Nothing
        Me.TableAdapterManager.OP_BillTableAdapter = Nothing
        Me.TableAdapterManager.Patient_RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Pharmacy_BillTableAdapter = Nothing
        Me.TableAdapterManager.RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Room_allocationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Bill_numberTextBox
        '
        Me.Bill_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lab_BillBindingSource, "Bill number", True))
        Me.Bill_numberTextBox.Location = New System.Drawing.Point(105, 92)
        Me.Bill_numberTextBox.Name = "Bill_numberTextBox"
        Me.Bill_numberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Bill_numberTextBox.TabIndex = 2
        '
        'PatientTextBox
        '
        Me.PatientTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lab_BillBindingSource, "Patient", True))
        Me.PatientTextBox.Location = New System.Drawing.Point(105, 118)
        Me.PatientTextBox.Name = "PatientTextBox"
        Me.PatientTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PatientTextBox.TabIndex = 4
        '
        'Lab_test_nameTextBox
        '
        Me.Lab_test_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lab_BillBindingSource, "Lab test name", True))
        Me.Lab_test_nameTextBox.Location = New System.Drawing.Point(105, 144)
        Me.Lab_test_nameTextBox.Name = "Lab_test_nameTextBox"
        Me.Lab_test_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Lab_test_nameTextBox.TabIndex = 6
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lab_BillBindingSource, "Amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(105, 170)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AmountTextBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.Lab_BillBindingSource
        Me.ComboBox1.DisplayMember = "Bill number"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(333, 86)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Look up"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(106, 198)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BillNumberDataGridViewTextBoxColumn, Me.PatientDataGridViewTextBoxColumn, Me.LabTestNameDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Lab_BillBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(272, 113)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(446, 150)
        Me.DataGridView1.TabIndex = 14
        '
        'BillNumberDataGridViewTextBoxColumn
        '
        Me.BillNumberDataGridViewTextBoxColumn.DataPropertyName = "Bill number"
        Me.BillNumberDataGridViewTextBoxColumn.HeaderText = "Bill number"
        Me.BillNumberDataGridViewTextBoxColumn.Name = "BillNumberDataGridViewTextBoxColumn"
        '
        'PatientDataGridViewTextBoxColumn
        '
        Me.PatientDataGridViewTextBoxColumn.DataPropertyName = "Patient"
        Me.PatientDataGridViewTextBoxColumn.HeaderText = "Patient"
        Me.PatientDataGridViewTextBoxColumn.Name = "PatientDataGridViewTextBoxColumn"
        '
        'LabTestNameDataGridViewTextBoxColumn
        '
        Me.LabTestNameDataGridViewTextBoxColumn.DataPropertyName = "Lab test name"
        Me.LabTestNameDataGridViewTextBoxColumn.HeaderText = "Lab test name"
        Me.LabTestNameDataGridViewTextBoxColumn.Name = "LabTestNameDataGridViewTextBoxColumn"
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        '
        'Pharmacy_BillBindingNavigator
        '
        Me.Pharmacy_BillBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Pharmacy_BillBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Pharmacy_BillBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Pharmacy_BillBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Pharmacy_BillBindingNavigatorSaveItem})
        Me.Pharmacy_BillBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Pharmacy_BillBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Pharmacy_BillBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Pharmacy_BillBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Pharmacy_BillBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Pharmacy_BillBindingNavigator.Name = "Pharmacy_BillBindingNavigator"
        Me.Pharmacy_BillBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Pharmacy_BillBindingNavigator.Size = New System.Drawing.Size(789, 25)
        Me.Pharmacy_BillBindingNavigator.TabIndex = 15
        Me.Pharmacy_BillBindingNavigator.Text = "BindingNavigator1"
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
        'Pharmacy_BillBindingNavigatorSaveItem
        '
        Me.Pharmacy_BillBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Pharmacy_BillBindingNavigatorSaveItem.Image = CType(resources.GetObject("Pharmacy_BillBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Pharmacy_BillBindingNavigatorSaveItem.Name = "Pharmacy_BillBindingNavigatorSaveItem"
        Me.Pharmacy_BillBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Pharmacy_BillBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(191, 198)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Lab_Bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(789, 360)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Pharmacy_BillBindingNavigator)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Bill_numberLabel)
        Me.Controls.Add(Me.Bill_numberTextBox)
        Me.Controls.Add(PatientLabel)
        Me.Controls.Add(Me.PatientTextBox)
        Me.Controls.Add(Lab_test_nameLabel)
        Me.Controls.Add(Me.Lab_test_nameTextBox)
        Me.Controls.Add(AmountLabel)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Name = "Lab_Bill"
        Me.Text = "Lab_Bill"
        CType(Me.Hospital_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lab_BillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pharmacy_BillBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pharmacy_BillBindingNavigator.ResumeLayout(False)
        Me.Pharmacy_BillBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Hospital_management_systemDataSet As WindowsApplication1.Hospital_management_systemDataSet
    Friend WithEvents Lab_BillBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Lab_BillTableAdapter As WindowsApplication1.Hospital_management_systemDataSetTableAdapters.Lab_BillTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Bill_numberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PatientTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lab_test_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BillNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabTestNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pharmacy_BillBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Pharmacy_BillBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
