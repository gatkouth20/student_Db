Public Class Doctor_edite

    Private Sub Edite_Dr_s_formBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edite_Dr_s_formBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Edite_Dr_s_formBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SystemDataSet)

    End Sub

    Private Sub Doctor_edite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SystemDataSet._Edite_Dr_s_form' table. You can move, or remove it, as needed.
        Me.Edite_Dr_s_formTableAdapter.Fill(Me.SystemDataSet._Edite_Dr_s_form)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Home_Page.Show()
        Me.Hide()


    End Sub
End Class