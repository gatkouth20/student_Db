Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub OpeningAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpeningAccountToolStripMenuItem.Click
        Opening_Account_form.Show()
        Me.Hide()


    End Sub

    Private Sub StudentAcountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentAcountToolStripMenuItem.Click
        ATM_Form.Show()
        Me.Hide()


    End Sub

    Private Sub WithdrawalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WithdrawalToolStripMenuItem.Click
        Withdrawal_form.Show()
        Me.Hide()


    End Sub

    Private Sub DepositToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepositToolStripMenuItem.Click
        Deposit_form.Show()
        Me.Hide()


    End Sub

    Private Sub TransactionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionToolStripMenuItem.Click
        Transaction_form.Show()
        Me.Hide()


    End Sub

    Private Sub CheckBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBookToolStripMenuItem.Click
        CheckBook_form.Show()
        Me.Hide()


    End Sub

    Private Sub ClosingAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClosingAccountToolStripMenuItem.Click

    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        Home_info.Show()
        Me.Hide()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label1.Location.X + Label1.Width < 0 Then
            Label1.Location = New Point(Me.Width,Label1.Location.Y)
        Else
            Label1.Location = New Point(Label1.Location.X - 3, Label1.Location.Y)
        End If
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutUsToolStripMenuItem.Click
        About_form.Show()


    End Sub

    Private Sub ServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiceToolStripMenuItem.Click
        Service_form.Show()
        Me.Hide()



    End Sub

    Private Sub LoansToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoansToolStripMenuItem.Click
        Loan_form.Show()
        Me.Hide()


    End Sub

    Private Sub LoansToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoansToolStripMenuItem1.Click
        Loan_form.Show()
        Me.Hide()


    End Sub
End Class
