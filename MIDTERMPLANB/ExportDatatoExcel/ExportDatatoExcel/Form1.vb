Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.OleDb
Public Class frmgenerate
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\GenerallPayroll.accdb;Persist Security Info=False;"
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("select (EmployeeName) as [Employee Name], (AmountWithdrawn) as [Amount Withdrawn], (SCCC) as [SC], (OrigSalary) as [OR Salary], (NetPay) as [Net], (NameOfRecepient) as [Name of Recepient], (RTOB) as [Relationship to borrower], (Signature) as [Signature], (DueDate) as [Due Date], (RMKS) as [Remarks] from genpayfinal order by EmployeeName,DateofOrigin ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "GenPayFinal")

            DataGridView3.DataSource = myDataSet.Tables("GenPayFinal").DefaultView



            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        DataGridView3.DataSource = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DataGridView3.RowCount = Nothing Then
            MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application

        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = DataGridView3.RowCount - 1
            colsTotal = DataGridView3.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView3.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView3.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12
                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
        Application.Exit()

    End Sub
End Class
