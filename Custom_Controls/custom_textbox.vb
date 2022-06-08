Imports System
Imports System.Collections
Imports System.IO
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Drawing
Imports System.Globalization
Public Class custom_textbox
    Inherits TextBox

    Public textboxtype As type
    Public Enum type
        Origin = 0
        Number = 1
        DDate = 2
        Price = 3
    End Enum

    <Browsable(True)>
    <Description("Select Textbox Type")>
    <Category("Custom Properties")>
    <DisplayName("Type")>
    Public Property textbox_type As type
        Get
            Return textboxtype
        End Get
        Set(ByVal value As type)
            textboxtype = value
        End Set
    End Property


    Protected Overrides Sub OnKeyPress(e As KeyPressEventArgs)
        MyBase.OnKeyPress(e)

        If textbox_type = type.Number Then
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            Else e.Handled = True
            End If
        End If
    End Sub
End Class
