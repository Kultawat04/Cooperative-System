<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Form))
        Me.UserLB = New System.Windows.Forms.Label()
        Me.pwLB = New System.Windows.Forms.Label()
        Me.LoginBT = New System.Windows.Forms.Button()
        Me.UsernameTB = New System.Windows.Forms.TextBox()
        Me.PwTB = New System.Windows.Forms.TextBox()
        Me.Login_GB = New System.Windows.Forms.GroupBox()
        Me.Close_BT = New System.Windows.Forms.Button()
        Me.Login_GB.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserLB
        '
        resources.ApplyResources(Me.UserLB, "UserLB")
        Me.UserLB.Name = "UserLB"
        '
        'pwLB
        '
        resources.ApplyResources(Me.pwLB, "pwLB")
        Me.pwLB.Name = "pwLB"
        '
        'LoginBT
        '
        resources.ApplyResources(Me.LoginBT, "LoginBT")
        Me.LoginBT.Name = "LoginBT"
        Me.LoginBT.UseVisualStyleBackColor = True
        '
        'UsernameTB
        '
        resources.ApplyResources(Me.UsernameTB, "UsernameTB")
        Me.UsernameTB.Name = "UsernameTB"
        '
        'PwTB
        '
        resources.ApplyResources(Me.PwTB, "PwTB")
        Me.PwTB.Name = "PwTB"
        Me.PwTB.UseSystemPasswordChar = True
        '
        'Login_GB
        '
        Me.Login_GB.Controls.Add(Me.Close_BT)
        Me.Login_GB.Controls.Add(Me.PwTB)
        Me.Login_GB.Controls.Add(Me.UsernameTB)
        Me.Login_GB.Controls.Add(Me.LoginBT)
        Me.Login_GB.Controls.Add(Me.pwLB)
        Me.Login_GB.Controls.Add(Me.UserLB)
        resources.ApplyResources(Me.Login_GB, "Login_GB")
        Me.Login_GB.Name = "Login_GB"
        Me.Login_GB.TabStop = False
        '
        'Close_BT
        '
        resources.ApplyResources(Me.Close_BT, "Close_BT")
        Me.Close_BT.Name = "Close_BT"
        Me.Close_BT.UseVisualStyleBackColor = True
        '
        'Login_Form
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Login_GB)
        Me.KeyPreview = True
        Me.Name = "Login_Form"
        Me.Login_GB.ResumeLayout(False)
        Me.Login_GB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UserLB As System.Windows.Forms.Label
    Friend WithEvents pwLB As System.Windows.Forms.Label
    Friend WithEvents LoginBT As System.Windows.Forms.Button
    Friend WithEvents UsernameTB As System.Windows.Forms.TextBox
    Friend WithEvents PwTB As System.Windows.Forms.TextBox
    Friend WithEvents Login_GB As System.Windows.Forms.GroupBox
    Friend WithEvents Close_BT As System.Windows.Forms.Button

End Class
