<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rooms
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
        Dim R_idLabel As System.Windows.Forms.Label
        Dim RoomNoLabel As System.Windows.Forms.Label
        Dim Room_typeLabel As System.Windows.Forms.Label
        Dim Amount_dayLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rooms))
        Me.SystemDataSet = New WindowsApplication1.systemDataSet()
        Me.Rooms_allocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rooms_allocationTableAdapter = New WindowsApplication1.systemDataSetTableAdapters.Rooms_allocationTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.systemDataSetTableAdapters.TableAdapterManager()
        Me.Rooms_allocationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Rooms_allocationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.R_idTextBox = New System.Windows.Forms.TextBox()
        Me.RoomNoTextBox = New System.Windows.Forms.TextBox()
        Me.Room_typeTextBox = New System.Windows.Forms.TextBox()
        Me.Amount_dayTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        R_idLabel = New System.Windows.Forms.Label()
        RoomNoLabel = New System.Windows.Forms.Label()
        Room_typeLabel = New System.Windows.Forms.Label()
        Amount_dayLabel = New System.Windows.Forms.Label()
        CType(Me.SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rooms_allocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rooms_allocationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Rooms_allocationBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'R_idLabel
        '
        R_idLabel.AutoSize = True
        R_idLabel.Location = New System.Drawing.Point(117, 62)
        R_idLabel.Name = "R_idLabel"
        R_idLabel.Size = New System.Drawing.Size(29, 13)
        R_idLabel.TabIndex = 1
        R_idLabel.Text = "R id:"
        '
        'RoomNoLabel
        '
        RoomNoLabel.AutoSize = True
        RoomNoLabel.Location = New System.Drawing.Point(117, 88)
        RoomNoLabel.Name = "RoomNoLabel"
        RoomNoLabel.Size = New System.Drawing.Size(55, 13)
        RoomNoLabel.TabIndex = 3
        RoomNoLabel.Text = "Room No:"
        '
        'Room_typeLabel
        '
        Room_typeLabel.AutoSize = True
        Room_typeLabel.Location = New System.Drawing.Point(117, 114)
        Room_typeLabel.Name = "Room_typeLabel"
        Room_typeLabel.Size = New System.Drawing.Size(61, 13)
        Room_typeLabel.TabIndex = 5
        Room_typeLabel.Text = "Room type:"
        '
        'Amount_dayLabel
        '
        Amount_dayLabel.AutoSize = True
        Amount_dayLabel.Location = New System.Drawing.Point(117, 140)
        Amount_dayLabel.Name = "Amount_dayLabel"
        Amount_dayLabel.Size = New System.Drawing.Size(68, 13)
        Amount_dayLabel.TabIndex = 7
        Amount_dayLabel.Text = "Amount/day:"
        '
        'SystemDataSet
        '
        Me.SystemDataSet.DataSetName = "systemDataSet"
        Me.SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Rooms_allocationBindingSource
        '
        Me.Rooms_allocationBindingSource.DataMember = "Rooms allocation"
        Me.Rooms_allocationBindingSource.DataSource = Me.SystemDataSet
        '
        'Rooms_allocationTableAdapter
        '
        Me.Rooms_allocationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Doctor_s_RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Edite__PatientTableAdapter = Nothing
        Me.TableAdapterManager.Edite_Dr_s_formTableAdapter = Nothing
        Me.TableAdapterManager.Patient_RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Rooms_allocationTableAdapter = Me.Rooms_allocationTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Rooms_allocationBindingNavigator
        '
        Me.Rooms_allocationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Rooms_allocationBindingNavigator.BindingSource = Me.Rooms_allocationBindingSource
        Me.Rooms_allocationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Rooms_allocationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Rooms_allocationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Rooms_allocationBindingNavigatorSaveItem})
        Me.Rooms_allocationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Rooms_allocationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Rooms_allocationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Rooms_allocationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Rooms_allocationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Rooms_allocationBindingNavigator.Name = "Rooms_allocationBindingNavigator"
        Me.Rooms_allocationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Rooms_allocationBindingNavigator.Size = New System.Drawing.Size(573, 25)
        Me.Rooms_allocationBindingNavigator.TabIndex = 0
        Me.Rooms_allocationBindingNavigator.Text = "BindingNavigator1"
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
        'Rooms_allocationBindingNavigatorSaveItem
        '
        Me.Rooms_allocationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Rooms_allocationBindingNavigatorSaveItem.Image = CType(resources.GetObject("Rooms_allocationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Rooms_allocationBindingNavigatorSaveItem.Name = "Rooms_allocationBindingNavigatorSaveItem"
        Me.Rooms_allocationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Rooms_allocationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'R_idTextBox
        '
        Me.R_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Rooms_allocationBindingSource, "R_id", True))
        Me.R_idTextBox.Location = New System.Drawing.Point(191, 59)
        Me.R_idTextBox.Name = "R_idTextBox"
        Me.R_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.R_idTextBox.TabIndex = 2
        '
        'RoomNoTextBox
        '
        Me.RoomNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Rooms_allocationBindingSource, "RoomNo", True))
        Me.RoomNoTextBox.Location = New System.Drawing.Point(191, 85)
        Me.RoomNoTextBox.Name = "RoomNoTextBox"
        Me.RoomNoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RoomNoTextBox.TabIndex = 4
        '
        'Room_typeTextBox
        '
        Me.Room_typeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Rooms_allocationBindingSource, "Room type", True))
        Me.Room_typeTextBox.Location = New System.Drawing.Point(191, 111)
        Me.Room_typeTextBox.Name = "Room_typeTextBox"
        Me.Room_typeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Room_typeTextBox.TabIndex = 6
        '
        'Amount_dayTextBox
        '
        Me.Amount_dayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Rooms_allocationBindingSource, "Amount/day", True))
        Me.Amount_dayTextBox.Location = New System.Drawing.Point(191, 137)
        Me.Amount_dayTextBox.Name = "Amount_dayTextBox"
        Me.Amount_dayTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Amount_dayTextBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(120, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(216, 177)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Display"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.Rooms_allocationBindingSource
        Me.ComboBox1.DisplayMember = "RoomNo"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(355, 54)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(162, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(522, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Searching"
        '
        'Rooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(573, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(R_idLabel)
        Me.Controls.Add(Me.R_idTextBox)
        Me.Controls.Add(RoomNoLabel)
        Me.Controls.Add(Me.RoomNoTextBox)
        Me.Controls.Add(Room_typeLabel)
        Me.Controls.Add(Me.Room_typeTextBox)
        Me.Controls.Add(Amount_dayLabel)
        Me.Controls.Add(Me.Amount_dayTextBox)
        Me.Controls.Add(Me.Rooms_allocationBindingNavigator)
        Me.Name = "Rooms"
        Me.Text = "Rooms"
        CType(Me.SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rooms_allocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rooms_allocationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Rooms_allocationBindingNavigator.ResumeLayout(False)
        Me.Rooms_allocationBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SystemDataSet As WindowsApplication1.systemDataSet
    Friend WithEvents Rooms_allocationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rooms_allocationTableAdapter As WindowsApplication1.systemDataSetTableAdapters.Rooms_allocationTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Rooms_allocationBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Rooms_allocationBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents R_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RoomNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Room_typeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Amount_dayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
