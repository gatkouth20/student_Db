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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim StdIdLabel As System.Windows.Forms.Label
        Dim StudnameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim TellLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Me.StudentDBDataSet = New Student_information.studentDBDataSet()
        Me.Student_DbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_DbTableAdapter = New Student_information.studentDBDataSetTableAdapters.student_DbTableAdapter()
        Me.TableAdapterManager = New Student_information.studentDBDataSetTableAdapters.TableAdapterManager()
        Me.Student_DbBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Student_DbBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StdIdTextBox = New System.Windows.Forms.TextBox()
        Me.StudnameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.TellTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        StdIdLabel = New System.Windows.Forms.Label()
        StudnameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        TellLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        CType(Me.StudentDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_DbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_DbBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Student_DbBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentDBDataSet
        '
        Me.StudentDBDataSet.DataSetName = "studentDBDataSet"
        Me.StudentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Student_DbBindingSource
        '
        Me.Student_DbBindingSource.DataMember = "student Db"
        Me.Student_DbBindingSource.DataSource = Me.StudentDBDataSet
        '
        'Student_DbTableAdapter
        '
        Me.Student_DbTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.student_DbTableAdapter = Me.Student_DbTableAdapter
        Me.TableAdapterManager.UpdateOrder = Student_information.studentDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Student_DbBindingNavigator
        '
        Me.Student_DbBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Student_DbBindingNavigator.BindingSource = Me.Student_DbBindingSource
        Me.Student_DbBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Student_DbBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Student_DbBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Student_DbBindingNavigatorSaveItem})
        Me.Student_DbBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Student_DbBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Student_DbBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Student_DbBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Student_DbBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Student_DbBindingNavigator.Name = "Student_DbBindingNavigator"
        Me.Student_DbBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Student_DbBindingNavigator.Size = New System.Drawing.Size(491, 25)
        Me.Student_DbBindingNavigator.TabIndex = 0
        Me.Student_DbBindingNavigator.Text = "BindingNavigator1"
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
        'Student_DbBindingNavigatorSaveItem
        '
        Me.Student_DbBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Student_DbBindingNavigatorSaveItem.Image = CType(resources.GetObject("Student_DbBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Student_DbBindingNavigatorSaveItem.Name = "Student_DbBindingNavigatorSaveItem"
        Me.Student_DbBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Student_DbBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StdIdLabel
        '
        StdIdLabel.AutoSize = True
        StdIdLabel.Location = New System.Drawing.Point(116, 58)
        StdIdLabel.Name = "StdIdLabel"
        StdIdLabel.Size = New System.Drawing.Size(38, 13)
        StdIdLabel.TabIndex = 1
        StdIdLabel.Text = "Std Id:"
        '
        'StdIdTextBox
        '
        Me.StdIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DbBindingSource, "StdId", True))
        Me.StdIdTextBox.Location = New System.Drawing.Point(180, 55)
        Me.StdIdTextBox.Name = "StdIdTextBox"
        Me.StdIdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StdIdTextBox.TabIndex = 2
        '
        'StudnameLabel
        '
        StudnameLabel.AutoSize = True
        StudnameLabel.Location = New System.Drawing.Point(116, 84)
        StudnameLabel.Name = "StudnameLabel"
        StudnameLabel.Size = New System.Drawing.Size(58, 13)
        StudnameLabel.TabIndex = 3
        StudnameLabel.Text = "Studname:"
        '
        'StudnameTextBox
        '
        Me.StudnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DbBindingSource, "Studname", True))
        Me.StudnameTextBox.Location = New System.Drawing.Point(180, 81)
        Me.StudnameTextBox.Name = "StudnameTextBox"
        Me.StudnameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StudnameTextBox.TabIndex = 4
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(116, 110)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 5
        GenderLabel.Text = "Gender:"
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DbBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(180, 107)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GenderTextBox.TabIndex = 6
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(116, 136)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 7
        PhoneLabel.Text = "Phone:"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DbBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(180, 133)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PhoneTextBox.TabIndex = 8
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(116, 162)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 9
        AddressLabel.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DbBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(180, 159)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AddressTextBox.TabIndex = 10
        '
        'TellLabel
        '
        TellLabel.AutoSize = True
        TellLabel.Location = New System.Drawing.Point(116, 188)
        TellLabel.Name = "TellLabel"
        TellLabel.Size = New System.Drawing.Size(27, 13)
        TellLabel.TabIndex = 11
        TellLabel.Text = "Tell:"
        '
        'TellTextBox
        '
        Me.TellTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DbBindingSource, "Tell", True))
        Me.TellTextBox.Location = New System.Drawing.Point(180, 185)
        Me.TellTextBox.Name = "TellTextBox"
        Me.TellTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TellTextBox.TabIndex = 12
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(116, 215)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 13
        DateLabel.Text = "Date:"
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Student_DbBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(180, 211)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 261)
        Me.Controls.Add(StdIdLabel)
        Me.Controls.Add(Me.StdIdTextBox)
        Me.Controls.Add(StudnameLabel)
        Me.Controls.Add(Me.StudnameTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(TellLabel)
        Me.Controls.Add(Me.TellTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.Student_DbBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.StudentDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_DbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_DbBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Student_DbBindingNavigator.ResumeLayout(False)
        Me.Student_DbBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StudentDBDataSet As Student_information.studentDBDataSet
    Friend WithEvents Student_DbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Student_DbTableAdapter As Student_information.studentDBDataSetTableAdapters.student_DbTableAdapter
    Friend WithEvents TableAdapterManager As Student_information.studentDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Student_DbBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Student_DbBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents StdIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TellTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
End Class
