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
        Dim SNOLabel As System.Windows.Forms.Label
        Dim Doctor_s_nameLabel As System.Windows.Forms.Label
        Dim SpecializationLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Hospital_systemDataSet = New WindowsApplication1.hospital_systemDataSet()
        Me.Doctor_listBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Doctor_listTableAdapter = New WindowsApplication1.hospital_systemDataSetTableAdapters.Doctor_listTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.hospital_systemDataSetTableAdapters.TableAdapterManager()
        Me.Doctor_listBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Doctor_listBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SNOTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_s_nameTextBox = New System.Windows.Forms.TextBox()
        Me.SpecializationTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        SNOLabel = New System.Windows.Forms.Label()
        Doctor_s_nameLabel = New System.Windows.Forms.Label()
        SpecializationLabel = New System.Windows.Forms.Label()
        CType(Me.Hospital_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Doctor_listBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Doctor_listBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Doctor_listBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(53, 190)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Hospital_systemDataSet
        '
        Me.Hospital_systemDataSet.DataSetName = "hospital_systemDataSet"
        Me.Hospital_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Doctor_listBindingSource
        '
        Me.Doctor_listBindingSource.DataMember = "Doctor list"
        Me.Doctor_listBindingSource.DataSource = Me.Hospital_systemDataSet
        '
        'Doctor_listTableAdapter
        '
        Me.Doctor_listTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.appointmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Doctor_listTableAdapter = Me.Doctor_listTableAdapter
        Me.TableAdapterManager.Patient_listTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.hospital_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Doctor_listBindingNavigator
        '
        Me.Doctor_listBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Doctor_listBindingNavigator.BindingSource = Me.Doctor_listBindingSource
        Me.Doctor_listBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Doctor_listBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Doctor_listBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Doctor_listBindingNavigatorSaveItem})
        Me.Doctor_listBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Doctor_listBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Doctor_listBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Doctor_listBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Doctor_listBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Doctor_listBindingNavigator.Name = "Doctor_listBindingNavigator"
        Me.Doctor_listBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Doctor_listBindingNavigator.Size = New System.Drawing.Size(536, 25)
        Me.Doctor_listBindingNavigator.TabIndex = 1
        Me.Doctor_listBindingNavigator.Text = "BindingNavigator1"
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
        'Doctor_listBindingNavigatorSaveItem
        '
        Me.Doctor_listBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Doctor_listBindingNavigatorSaveItem.Image = CType(resources.GetObject("Doctor_listBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Doctor_listBindingNavigatorSaveItem.Name = "Doctor_listBindingNavigatorSaveItem"
        Me.Doctor_listBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Doctor_listBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SNOLabel
        '
        SNOLabel.AutoSize = True
        SNOLabel.Location = New System.Drawing.Point(159, 81)
        SNOLabel.Name = "SNOLabel"
        SNOLabel.Size = New System.Drawing.Size(33, 13)
        SNOLabel.TabIndex = 2
        SNOLabel.Text = "SNO:"
        '
        'SNOTextBox
        '
        Me.SNOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_listBindingSource, "SNO", True))
        Me.SNOTextBox.Location = New System.Drawing.Point(243, 78)
        Me.SNOTextBox.Name = "SNOTextBox"
        Me.SNOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SNOTextBox.TabIndex = 3
        '
        'Doctor_s_nameLabel
        '
        Doctor_s_nameLabel.AutoSize = True
        Doctor_s_nameLabel.Location = New System.Drawing.Point(159, 107)
        Doctor_s_nameLabel.Name = "Doctor_s_nameLabel"
        Doctor_s_nameLabel.Size = New System.Drawing.Size(78, 13)
        Doctor_s_nameLabel.TabIndex = 4
        Doctor_s_nameLabel.Text = "Doctor's name:"
        '
        'Doctor_s_nameTextBox
        '
        Me.Doctor_s_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_listBindingSource, "Doctor's name", True))
        Me.Doctor_s_nameTextBox.Location = New System.Drawing.Point(243, 104)
        Me.Doctor_s_nameTextBox.Name = "Doctor_s_nameTextBox"
        Me.Doctor_s_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Doctor_s_nameTextBox.TabIndex = 5
        '
        'SpecializationLabel
        '
        SpecializationLabel.AutoSize = True
        SpecializationLabel.Location = New System.Drawing.Point(159, 133)
        SpecializationLabel.Name = "SpecializationLabel"
        SpecializationLabel.Size = New System.Drawing.Size(75, 13)
        SpecializationLabel.TabIndex = 6
        SpecializationLabel.Text = "Specialization:"
        '
        'SpecializationTextBox
        '
        Me.SpecializationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_listBindingSource, "Specialization", True))
        Me.SpecializationTextBox.Location = New System.Drawing.Point(243, 130)
        Me.SpecializationTextBox.Name = "SpecializationTextBox"
        Me.SpecializationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SpecializationTextBox.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(180, 190)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "patient list"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(364, 190)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "apointment"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 261)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(SNOLabel)
        Me.Controls.Add(Me.SNOTextBox)
        Me.Controls.Add(Doctor_s_nameLabel)
        Me.Controls.Add(Me.Doctor_s_nameTextBox)
        Me.Controls.Add(SpecializationLabel)
        Me.Controls.Add(Me.SpecializationTextBox)
        Me.Controls.Add(Me.Doctor_listBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Doctor's list"
        CType(Me.Hospital_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Doctor_listBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Doctor_listBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Doctor_listBindingNavigator.ResumeLayout(False)
        Me.Doctor_listBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Hospital_systemDataSet As WindowsApplication1.hospital_systemDataSet
    Friend WithEvents Doctor_listBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Doctor_listTableAdapter As WindowsApplication1.hospital_systemDataSetTableAdapters.Doctor_listTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.hospital_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Doctor_listBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Doctor_listBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SNOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Doctor_s_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SpecializationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
