Public Class BtnPreview

    Private Sub Doctor_s_registrationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Doctor_s_registrationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Doctor_s_registrationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital_management_systemDataSet)

    End Sub

    Private Sub Doctor_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital_management_systemDataSet._Doctor_s_registration' table. You can move, or remove it, as needed.
        Me.Doctor_s_registrationTableAdapter.Fill(Me.Hospital_management_systemDataSet._Doctor_s_registration)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BindingNavigatorAddNewItem.PerformClick()
        MsgBox("one row affected")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Doctor_s_Detail_View.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PrintDocument1.Print()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim Printfont As New Font("Arial", 14)
        Dim horizontalPrintPosition As Single
        Dim verticalPrintPostion As Single
        horizontalPrintPosition = e.MarginBounds.Left
        verticalPrintPostion = e.MarginBounds.Top

        e.Graphics.DrawString("Print this infromation", Printfont, Brushes.Blue, horizontalPrintPosition, verticalPrintPostion)

    End Sub

    Private Sub ButtonPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Home__Page.Show()
        Me.Hide()


    End Sub
End Class