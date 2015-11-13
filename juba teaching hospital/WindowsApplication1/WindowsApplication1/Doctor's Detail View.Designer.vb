<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctor_s_Detail_View
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
        Me.DoctorsRegistrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hospital_management_systemDataSet14 = New WindowsApplication1.Hospital_management_systemDataSet14()
        Me.Doctor_s_registrationTableAdapter = New WindowsApplication1.Hospital_management_systemDataSet14TableAdapters.Doctor_s_registrationTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Hospital_management_systemDataSet = New WindowsApplication1.Hospital_management_systemDataSet()
        Me.Doctor_s_registrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Doctor_s_registrationTableAdapter1 = New WindowsApplication1.Hospital_management_systemDataSetTableAdapters.Doctor_s_registrationTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager()
        Me.Doctor_s_registrationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DoctorsRegistrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital_management_systemDataSet14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Doctor_s_registrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Doctor_s_registrationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DoctorsRegistrationBindingSource
        '
        Me.DoctorsRegistrationBindingSource.DataMember = "Doctor's registration"
        Me.DoctorsRegistrationBindingSource.DataSource = Me.Hospital_management_systemDataSet14
        '
        'Hospital_management_systemDataSet14
        '
        Me.Hospital_management_systemDataSet14.DataSetName = "Hospital_management_systemDataSet14"
        Me.Hospital_management_systemDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Doctor_s_registrationTableAdapter
        '
        Me.Doctor_s_registrationTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(463, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Hospital_management_systemDataSet
        '
        Me.Hospital_management_systemDataSet.DataSetName = "Hospital_management_systemDataSet"
        Me.Hospital_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Doctor_s_registrationBindingSource
        '
        Me.Doctor_s_registrationBindingSource.DataMember = "Doctor's registration"
        Me.Doctor_s_registrationBindingSource.DataSource = Me.Hospital_management_systemDataSet
        '
        'Doctor_s_registrationTableAdapter1
        '
        Me.Doctor_s_registrationTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Add_new_departmentTableAdapter = Nothing
        Me.TableAdapterManager.Add_new_RoomTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Blood_Bank_RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Discharge_SheetTableAdapter = Nothing
        Me.TableAdapterManager.Doctor_s_registrationTableAdapter = Me.Doctor_s_registrationTableAdapter1
        Me.TableAdapterManager.Doctor_UpdateTableAdapter = Nothing
        Me.TableAdapterManager.IP_BillTableAdapter = Nothing
        Me.TableAdapterManager.Lab_BillTableAdapter = Nothing
        Me.TableAdapterManager.Medicine_UpdateTableAdapter = Nothing
        Me.TableAdapterManager.OP_BillTableAdapter = Nothing
        Me.TableAdapterManager.Patient_RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Pharmacy_BillTableAdapter = Nothing
        Me.TableAdapterManager.RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Room_allocationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Doctor_s_registrationDataGridView
        '
        Me.Doctor_s_registrationDataGridView.AutoGenerateColumns = False
        Me.Doctor_s_registrationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Doctor_s_registrationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.Doctor_s_registrationDataGridView.DataSource = Me.Doctor_s_registrationBindingSource
        Me.Doctor_s_registrationDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.Doctor_s_registrationDataGridView.Name = "Doctor_s_registrationDataGridView"
        Me.Doctor_s_registrationDataGridView.Size = New System.Drawing.Size(1243, 220)
        Me.Doctor_s_registrationDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Dr's name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Dr's name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Sex"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sex"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Department"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Department"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Consultation day"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Consultation day"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "consultation time From"
        Me.DataGridViewTextBoxColumn6.HeaderText = "consultation time From"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Contact number"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Contact number"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Emergency number"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Emergency number"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Consultation"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Consultation"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Total patient"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Total patient"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn12.HeaderText = "date"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'Doctor_s_Detail_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1293, 353)
        Me.Controls.Add(Me.Doctor_s_registrationDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Doctor_s_Detail_View"
        Me.Text = "Doctor_s_Detail_View"
        CType(Me.DoctorsRegistrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital_management_systemDataSet14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Doctor_s_registrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Doctor_s_registrationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Hospital_management_systemDataSet14 As WindowsApplication1.Hospital_management_systemDataSet14
    Friend WithEvents DoctorsRegistrationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Doctor_s_registrationTableAdapter As WindowsApplication1.Hospital_management_systemDataSet14TableAdapters.Doctor_s_registrationTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Hospital_management_systemDataSet As WindowsApplication1.Hospital_management_systemDataSet
    Friend WithEvents Doctor_s_registrationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Doctor_s_registrationTableAdapter1 As WindowsApplication1.Hospital_management_systemDataSetTableAdapters.Doctor_s_registrationTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Doctor_s_registrationDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
