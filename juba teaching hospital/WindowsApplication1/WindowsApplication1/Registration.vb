﻿Public Class Registration

    Private Sub RegistrationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RegistrationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital_management_systemDataSet)

    End Sub

    Private Sub Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital_management_systemDataSet.Registration' table. You can move, or remove it, as needed.
        Me.RegistrationTableAdapter.Fill(Me.Hospital_management_systemDataSet.Registration)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BindingNavigatorAddNewItem.PerformClick()
        MsgBox("Registered")


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Home__Page.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Display_registration.Show()
        Me.Hide()

    End Sub
End Class