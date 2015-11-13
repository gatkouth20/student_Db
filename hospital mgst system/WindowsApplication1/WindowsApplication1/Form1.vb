Public Class Form1

    Private Sub Doctor_listBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Doctor_listBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Doctor_listBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital_systemDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital_systemDataSet.Doctor_list' table. You can move, or remove it, as needed.
        Me.Doctor_listTableAdapter.Fill(Me.Hospital_systemDataSet.Doctor_list)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form3.Show()
        Me.Hide()

    End Sub
End Class
