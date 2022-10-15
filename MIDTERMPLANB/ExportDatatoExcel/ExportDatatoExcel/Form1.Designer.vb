<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmgenerate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(243, 15)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 53)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "&Export Excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(44, 15)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(168, 53)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "&Get Data"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(432, 15)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(168, 53)
        Me.Button7.TabIndex = 32
        Me.Button7.Text = "&Reset"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(16, 94)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView3.MultiSelect = False
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.Size = New System.Drawing.Size(648, 434)
        Me.DataGridView3.TabIndex = 34
        '
        'frmgenerate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 543)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.DataGridView3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmgenerate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export to Excel"
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
End Class
