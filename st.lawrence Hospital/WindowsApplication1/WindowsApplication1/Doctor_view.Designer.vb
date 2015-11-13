<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctor_view
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsultationDayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsultationTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmergencyCallDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsultationFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPatientDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Doctor_s_RegistrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SystemDataSet = New WindowsApplication1.systemDataSet()
        Me.Doctor_s_RegistrationTableAdapter = New WindowsApplication1.systemDataSetTableAdapters.Doctor_s_RegistrationTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.systemDataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Doctor_s_RegistrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DIDDataGridViewTextBoxColumn, Me.DrnameDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.ConsultationDayDataGridViewTextBoxColumn, Me.ConsultationTimeDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn, Me.EmergencyCallDataGridViewTextBoxColumn, Me.ConsultationFeeDataGridViewTextBoxColumn, Me.TotalPatientDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Doctor_s_RegistrationBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1219, 261)
        Me.DataGridView1.TabIndex = 0
        '
        'DIDDataGridViewTextBoxColumn
        '
        Me.DIDDataGridViewTextBoxColumn.DataPropertyName = "D_ID"
        Me.DIDDataGridViewTextBoxColumn.HeaderText = "D_ID"
        Me.DIDDataGridViewTextBoxColumn.Name = "DIDDataGridViewTextBoxColumn"
        '
        'DrnameDataGridViewTextBoxColumn
        '
        Me.DrnameDataGridViewTextBoxColumn.DataPropertyName = "Dr_name"
        Me.DrnameDataGridViewTextBoxColumn.HeaderText = "Dr_name"
        Me.DrnameDataGridViewTextBoxColumn.Name = "DrnameDataGridViewTextBoxColumn"
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "Sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        '
        'ConsultationDayDataGridViewTextBoxColumn
        '
        Me.ConsultationDayDataGridViewTextBoxColumn.DataPropertyName = "Consultation day"
        Me.ConsultationDayDataGridViewTextBoxColumn.HeaderText = "Consultation day"
        Me.ConsultationDayDataGridViewTextBoxColumn.Name = "ConsultationDayDataGridViewTextBoxColumn"
        '
        'ConsultationTimeDataGridViewTextBoxColumn
        '
        Me.ConsultationTimeDataGridViewTextBoxColumn.DataPropertyName = "Consultation time"
        Me.ConsultationTimeDataGridViewTextBoxColumn.HeaderText = "Consultation time"
        Me.ConsultationTimeDataGridViewTextBoxColumn.Name = "ConsultationTimeDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'ContactDataGridViewTextBoxColumn
        '
        Me.ContactDataGridViewTextBoxColumn.DataPropertyName = "Contact"
        Me.ContactDataGridViewTextBoxColumn.HeaderText = "Contact"
        Me.ContactDataGridViewTextBoxColumn.Name = "ContactDataGridViewTextBoxColumn"
        '
        'EmergencyCallDataGridViewTextBoxColumn
        '
        Me.EmergencyCallDataGridViewTextBoxColumn.DataPropertyName = "Emergency call"
        Me.EmergencyCallDataGridViewTextBoxColumn.HeaderText = "Emergency call"
        Me.EmergencyCallDataGridViewTextBoxColumn.Name = "EmergencyCallDataGridViewTextBoxColumn"
        '
        'ConsultationFeeDataGridViewTextBoxColumn
        '
        Me.ConsultationFeeDataGridViewTextBoxColumn.DataPropertyName = "Consultation fee"
        Me.ConsultationFeeDataGridViewTextBoxColumn.HeaderText = "Consultation fee"
        Me.ConsultationFeeDataGridViewTextBoxColumn.Name = "ConsultationFeeDataGridViewTextBoxColumn"
        '
        'TotalPatientDataGridViewTextBoxColumn
        '
        Me.TotalPatientDataGridViewTextBoxColumn.DataPropertyName = "Total patient"
        Me.TotalPatientDataGridViewTextBoxColumn.HeaderText = "Total patient"
        Me.TotalPatientDataGridViewTextBoxColumn.Name = "TotalPatientDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'Doctor_s_RegistrationBindingSource
        '
        Me.Doctor_s_RegistrationBindingSource.DataMember = "Doctor's Registration"
        Me.Doctor_s_RegistrationBindingSource.DataSource = Me.SystemDataSet
        '
        'SystemDataSet
        '
        Me.SystemDataSet.DataSetName = "systemDataSet"
        Me.SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Doctor_s_RegistrationTableAdapter
        '
        Me.Doctor_s_RegistrationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Doctor_s_RegistrationTableAdapter = Me.Doctor_s_RegistrationTableAdapter
        Me.TableAdapterManager.Edite__PatientTableAdapter = Nothing
        Me.TableAdapterManager.Edite_Dr_s_formTableAdapter = Nothing
        Me.TableAdapterManager.Patient_RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Rooms_allocationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(313, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "view"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Doctor_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Doctor_view"
        Me.Text = "Doctor_view"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Doctor_s_RegistrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SystemDataSet As WindowsApplication1.systemDataSet
    Friend WithEvents Doctor_s_RegistrationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Doctor_s_RegistrationTableAdapter As WindowsApplication1.systemDataSetTableAdapters.Doctor_s_RegistrationTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DrnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConsultationDayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConsultationTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmergencyCallDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConsultationFeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPatientDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
