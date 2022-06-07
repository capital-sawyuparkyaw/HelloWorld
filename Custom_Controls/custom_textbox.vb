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
    Public Enum type
        origin = 0
        number = 1
        ddate = 2
        price = 3
    End Enum

    <Browsable(True)>
    <Description("Select Textbox Type")>
    <Category("Custom Properties")>
    Public Property textbox_type As type
        Get
            Return textbox_type
        End Get
        Private Set(ByVal value As type)
            textbox_type = value
        End Set
    End Property
End Class
