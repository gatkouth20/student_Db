<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deliver_View
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btn_DataGredView = New System.Windows.Forms.Button()
        Me.Btn_Back = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(843, 249)
        Me.DataGridView1.TabIndex = 0
        '
        'Btn_DataGredView
        '
        Me.Btn_DataGredView.Location = New System.Drawing.Point(323, 272)
        Me.Btn_DataGredView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_DataGredView.Name = "Btn_DataGredView"
        Me.Btn_DataGredView.Size = New System.Drawing.Size(112, 28)
        Me.Btn_DataGredView.TabIndex = 1
        Me.Btn_DataGredView.Text = "Display"
        Me.Btn_DataGredView.UseVisualStyleBackColor = True
        '
        'Btn_Back
        '
        Me.Btn_Back.Location = New System.Drawing.Point(443, 272)
        Me.Btn_Back.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.Size = New System.Drawing.Size(132, 28)
        Me.Btn_Back.TabIndex = 2
        Me.Btn_Back.Text = "Back to main"
        Me.Btn_Back.UseVisualStyleBackColor = True
        '
        'Deliver_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(874, 307)
        Me.Controls.Add(Me.Btn_Back)
        Me.Controls.Add(Me.Btn_DataGredView)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Deliver_View"
        Me.Text = "Deliver_View"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_DataGredView As System.Windows.Forms.Button
    Friend WithEvents Btn_Back As System.Windows.Forms.Button
End Class
