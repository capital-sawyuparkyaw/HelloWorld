Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menu_CRUDSimpleTest.PerformClick()
    End Sub
    Private Sub Panel_Left_Click(sender As Object, e As EventArgs) Handles menu_TestForm1.Click,
        menu_CRUDSimpleTest.Click,
        Button7.Click, Button6.Click,
        Button5.Click, Button4.Click,
        Button3.Click
        Dim btn As Button
        btn = sender

        If btn.Text = "CRUDSimpleTest" Then
            btn_frm_1.Visible = True
            btn_frm_2.Visible = True
            btn_frm_3.Visible = True
            btn_frm_4.Visible = False

            btn_frm_1.Name = "btn_frm_CRUDSimpleTest"
            btn_frm_1.Text = "CRUDSimpleTest"

            btn_frm_2.Name = "SearchForm"
            btn_frm_2.Text = "SearchForm"

            btn_frm_3.Name = "frmExcelImport"
            btn_frm_3.Text = "Excel Import to table"
        ElseIf btn.Text = "TestForm1" Then
            btn_frm_1.Visible = True
            btn_frm_2.Visible = False
            btn_frm_3.Visible = False
            btn_frm_4.Visible = False

            btn_frm_1.Name = "Form1"
            btn_frm_1.Text = "Form1"
        End If

    End Sub

    Private Sub Panel_Right_Click(sender As Object, e As EventArgs) Handles Panel_Right.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btn_frm_1.Click
        If btn_frm_1.Text = "CRUDSimpleTest" Then
            Dim newfrm = New CRUDSimpleTest.CRUDSimpleTest
            newfrm.Show()
        ElseIf btn_frm_1.Text = "Form1" Then
            Dim newfrm = New TestForm1.Form1
            newfrm.Show()
        End If
    End Sub

    Private Sub btn_frm_2_Click(sender As Object, e As EventArgs) Handles btn_frm_2.Click
        If btn_frm_2.Text = "SearchForm" Then
            Dim newfrm = New CRUDSimpleTest.SearchForm
            newfrm.Show()
        End If
    End Sub

    Private Sub btn_frm_3_Click(sender As Object, e As EventArgs) Handles btn_frm_3.Click
        If btn_frm_3.Text = "Excel Import to table" Then
            Dim newfrm = New SMS_VB.frmExcelImport
            newfrm.Show()
        End If
    End Sub
End Class
