Public Class MainMenu

    Private Sub Panel_Left_Click(sender As Object, e As EventArgs) Handles menu_TestForm1.Click, menu_CRUDSimpleTest.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click
        Dim btn As Button
        btn = sender

        If btn.Text = "CRUDSimpleTest" Then
            btn_frm_1.Name = "btn_frm_CRUDSimpleTest"
            btn_frm_1.Text = "CRUDSimpleTest"

            btn_frm_2.Name = "SearchForm"
            btn_frm_2.Text = "SearchForm"

        ElseIf btn.Text = "TestForm1" Then
            btn_frm_1.Name = "Form1"
            btn_frm_1.Text = "Form1"
        End If

    End Sub

    Private Sub Panel_Right_Click(sender As Object, e As EventArgs) Handles Panel_Right.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btn_frm_1.Click
        Dim newfrm = New CRUDSimpleTest.CRUDSimpleTest
        newfrm.Show()
    End Sub
End Class
