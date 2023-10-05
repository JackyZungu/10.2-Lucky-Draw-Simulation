<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lbOutCome = New Label()
        btnDraw = New Button()
        SuspendLayout()
        ' 
        ' lbOutCome
        ' 
        lbOutCome.AutoSize = True
        lbOutCome.Location = New Point(259, 121)
        lbOutCome.Name = "lbOutCome"
        lbOutCome.Size = New Size(0, 20)
        lbOutCome.TabIndex = 1
        ' 
        ' btnDraw
        ' 
        btnDraw.Location = New Point(317, 163)
        btnDraw.Name = "btnDraw"
        btnDraw.Size = New Size(149, 51)
        btnDraw.TabIndex = 3
        btnDraw.Text = "Draw Number"
        btnDraw.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDraw)
        Controls.Add(lbOutCome)
        Name = "Form1"
        Text = "Lucky Draw Simulation"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lbOutCome As Label
    Friend WithEvents btnDraw As Button
End Class
