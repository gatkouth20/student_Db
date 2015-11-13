Public Class Form2

    Private Sub Patient_listBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Patient_listBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Patient_listBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital_systemDataSet)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital_systemDataSet.Patient_list' table. You can move, or remove it, as needed.
        Me.Patient_listTableAdapter.Fill(Me.Hospital_systemDataSet.Patient_list)

    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class