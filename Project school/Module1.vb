Imports System.Data.SqlClient


Module Module1
    Public en As New SqlConnection
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter
    Public ds As New DataSet


    Public Sub connect()

        If en.State = ConnectionState.Closed Then
            en.ConnectionString = "Data Source=DESKTOP-35M65UD;Initial Catalog=school;Integrated Security=True"
            en.Open()

        End If

    End Sub
End Module
