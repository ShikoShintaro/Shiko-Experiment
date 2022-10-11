<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Fav1 = New System.Windows.Forms.TextBox()
        Me.Fav2 = New System.Windows.Forms.TextBox()
        Me.Fav3 = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Fav1
        '
        Me.Fav1.Location = New System.Drawing.Point(284, 169)
        Me.Fav1.Name = "Fav1"
        Me.Fav1.Size = New System.Drawing.Size(192, 20)
        Me.Fav1.TabIndex = 0
        '
        'Fav2
        '
        Me.Fav2.Location = New System.Drawing.Point(284, 217)
        Me.Fav2.Name = "Fav2"
        Me.Fav2.Size = New System.Drawing.Size(192, 20)
        Me.Fav2.TabIndex = 1
        '
        'Fav3
        '
        Me.Fav3.Location = New System.Drawing.Point(284, 260)
        Me.Fav3.Name = "Fav3"
        Me.Fav3.Size = New System.Drawing.Size(192, 20)
        Me.Fav3.TabIndex = 2
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(345, 331)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(296, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Whats Your Favorite?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Fav3)
        Me.Controls.Add(Me.Fav2)
        Me.Controls.Add(Me.Fav1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Fav1 As TextBox
    Friend WithEvents Fav2 As TextBox
    Friend WithEvents Fav3 As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        
        'Creates a Function uses: Dim

        Dim TB1 As String
        Dim TB2 As String
        Dim TB3 As String

        'Calling the function of the string and calling the TB1 to the textbox

        TB1 = Fav1.Text
        TB2 = Fav2.Text
        TB3 = Fav3.Text

        'From the (TB1) textbox to the msg box

        MsgBox("So this is your Favorite? " & TB1 & ", " & TB2 & ", " & TB3 & ", " & " how cute is that isnt it?")




    End Sub
End Class
