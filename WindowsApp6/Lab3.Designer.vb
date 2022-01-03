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
        Me.components = New System.ComponentModel.Container()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.txtEmployee1 = New System.Windows.Forms.TextBox()
        Me.txtEmployee2 = New System.Windows.Forms.TextBox()
        Me.txtEmployee3 = New System.Windows.Forms.TextBox()
        Me.lblAverageEmployee1 = New System.Windows.Forms.Label()
        Me.lblAverageEmployee2 = New System.Windows.Forms.Label()
        Me.lblAverageEmployee3 = New System.Windows.Forms.Label()
        Me.lblAveragePerDay = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(47, 44)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(35, 13)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = "&Day 1"
        Me.ToolTip1.SetToolTip(Me.lblDay, "Day counter ")
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(45, 91)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(37, 13)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "&Units: "
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(109, 88)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(66, 20)
        Me.txtInput.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtInput, "Input units per day ")
        '
        'lblEmployee1
        '
        Me.lblEmployee1.AutoSize = True
        Me.lblEmployee1.Location = New System.Drawing.Point(89, 128)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(62, 13)
        Me.lblEmployee1.TabIndex = 3
        Me.lblEmployee1.Text = "E&mployee 1"
        Me.lblEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee2
        '
        Me.lblEmployee2.AutoSize = True
        Me.lblEmployee2.Location = New System.Drawing.Point(309, 128)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(62, 13)
        Me.lblEmployee2.TabIndex = 4
        Me.lblEmployee2.Text = "Em&ployee 2"
        Me.lblEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee3
        '
        Me.lblEmployee3.AutoSize = True
        Me.lblEmployee3.Location = New System.Drawing.Point(531, 128)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(62, 13)
        Me.lblEmployee3.TabIndex = 5
        Me.lblEmployee3.Text = "Emp&loyee 3"
        Me.lblEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmployee1
        '
        Me.txtEmployee1.Location = New System.Drawing.Point(66, 153)
        Me.txtEmployee1.Multiline = True
        Me.txtEmployee1.Name = "txtEmployee1"
        Me.txtEmployee1.Size = New System.Drawing.Size(100, 121)
        Me.txtEmployee1.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtEmployee1, "Displays the units per day for Employee 1")
        '
        'txtEmployee2
        '
        Me.txtEmployee2.Location = New System.Drawing.Point(291, 153)
        Me.txtEmployee2.Multiline = True
        Me.txtEmployee2.Name = "txtEmployee2"
        Me.txtEmployee2.Size = New System.Drawing.Size(100, 121)
        Me.txtEmployee2.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtEmployee2, "Displays the units per day for Employee 2")
        '
        'txtEmployee3
        '
        Me.txtEmployee3.Location = New System.Drawing.Point(512, 153)
        Me.txtEmployee3.Multiline = True
        Me.txtEmployee3.Name = "txtEmployee3"
        Me.txtEmployee3.Size = New System.Drawing.Size(100, 121)
        Me.txtEmployee3.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txtEmployee3, "Displays the units per day for Employee 3")
        '
        'lblAverageEmployee1
        '
        Me.lblAverageEmployee1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageEmployee1.Location = New System.Drawing.Point(63, 299)
        Me.lblAverageEmployee1.Name = "lblAverageEmployee1"
        Me.lblAverageEmployee1.Size = New System.Drawing.Size(100, 23)
        Me.lblAverageEmployee1.TabIndex = 9
        Me.lblAverageEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblAverageEmployee1, "Displays the  average for Employee 1")
        '
        'lblAverageEmployee2
        '
        Me.lblAverageEmployee2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageEmployee2.Location = New System.Drawing.Point(291, 299)
        Me.lblAverageEmployee2.Name = "lblAverageEmployee2"
        Me.lblAverageEmployee2.Size = New System.Drawing.Size(100, 23)
        Me.lblAverageEmployee2.TabIndex = 10
        Me.lblAverageEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblAverageEmployee2, "Displays the  average for Employee 2")
        '
        'lblAverageEmployee3
        '
        Me.lblAverageEmployee3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageEmployee3.Location = New System.Drawing.Point(512, 299)
        Me.lblAverageEmployee3.Name = "lblAverageEmployee3"
        Me.lblAverageEmployee3.Size = New System.Drawing.Size(100, 23)
        Me.lblAverageEmployee3.TabIndex = 11
        Me.lblAverageEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblAverageEmployee3, "Displays the  average for Employee 3")
        '
        'lblAveragePerDay
        '
        Me.lblAveragePerDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAveragePerDay.Location = New System.Drawing.Point(63, 332)
        Me.lblAveragePerDay.Name = "lblAveragePerDay"
        Me.lblAveragePerDay.Size = New System.Drawing.Size(549, 23)
        Me.lblAveragePerDay.TabIndex = 12
        Me.lblAveragePerDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblAveragePerDay, "Displays the  average for all Employee")
        '
        'btnEnter
        '
        Me.btnEnter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnter.Location = New System.Drawing.Point(63, 378)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.ToolTip1.SetToolTip(Me.btnEnter, "This inputs the Employee units")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(296, 378)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "This button resets the form ")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(534, 378)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "&Close"
        Me.ToolTip1.SetToolTip(Me.btnClose, "This closes the form")
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblAveragePerDay)
        Me.Controls.Add(Me.lblAverageEmployee3)
        Me.Controls.Add(Me.lblAverageEmployee2)
        Me.Controls.Add(Me.lblAverageEmployee1)
        Me.Controls.Add(Me.txtEmployee3)
        Me.Controls.Add(Me.txtEmployee2)
        Me.Controls.Add(Me.txtEmployee1)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblDay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped by Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDay As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents txtEmployee1 As TextBox
    Friend WithEvents txtEmployee2 As TextBox
    Friend WithEvents txtEmployee3 As TextBox
    Friend WithEvents lblAverageEmployee1 As Label
    Friend WithEvents lblAverageEmployee2 As Label
    Friend WithEvents lblAverageEmployee3 As Label
    Friend WithEvents lblAveragePerDay As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
