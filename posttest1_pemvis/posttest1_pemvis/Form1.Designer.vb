<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        tbips = New TextBox()
        tbipk = New TextBox()
        btntambah = New Button()
        btnreset = New Button()
        Label1 = New Label()
        Label2 = New Label()
        LabelPredikat = New Label()
        SuspendLayout()
        ' 
        ' tbips
        ' 
        tbips.Location = New Point(238, 110)
        tbips.Name = "tbips"
        tbips.Size = New Size(186, 27)
        tbips.TabIndex = 0
        ' 
        ' tbipk
        ' 
        tbipk.Location = New Point(237, 204)
        tbipk.Name = "tbipk"
        tbipk.Size = New Size(189, 27)
        tbipk.TabIndex = 1
        ' 
        ' btntambah
        ' 
        btntambah.Location = New Point(238, 163)
        btntambah.Name = "btntambah"
        btntambah.Size = New Size(82, 35)
        btntambah.TabIndex = 2
        btntambah.Text = "Tambah"
        btntambah.UseVisualStyleBackColor = True
        ' 
        ' btnreset
        ' 
        btnreset.Location = New Point(349, 168)
        btnreset.Name = "btnreset"
        btnreset.Size = New Size(77, 30)
        btnreset.TabIndex = 3
        btnreset.Text = "Reset"
        btnreset.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(135, 117)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 4
        Label1.Text = "IP Semester"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(132, 204)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 5
        Label2.Text = "IP Kumulatif"
        ' 
        ' LabelPredikat
        ' 
        LabelPredikat.AutoSize = True
        LabelPredikat.Location = New Point(251, 250)
        LabelPredikat.Name = "LabelPredikat"
        LabelPredikat.Size = New Size(0, 20)
        LabelPredikat.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LabelPredikat)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnreset)
        Controls.Add(btntambah)
        Controls.Add(tbipk)
        Controls.Add(tbips)
        Name = "Form1"
        Text = "2309106011"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbips As TextBox
    Friend WithEvents tbipk As TextBox
    Friend WithEvents btntambah As Button
    Friend WithEvents btnreset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelPredikat As Label

End Class
