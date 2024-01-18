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
        lblCalculate = New Button()
        txtWeight = New TextBox()
        txtHeight = New TextBox()
        txtBMI = New TextBox()
        txtComment = New TextBox()
        lblWeight = New Label()
        lblHeight = New Label()
        lblBMI = New Label()
        lblComment = New Label()
        SuspendLayout()
        ' 
        ' lblCalculate
        ' 
        lblCalculate.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblCalculate.Location = New Point(176, 365)
        lblCalculate.Name = "lblCalculate"
        lblCalculate.Size = New Size(94, 29)
        lblCalculate.TabIndex = 0
        lblCalculate.Text = "Calculate"
        lblCalculate.UseVisualStyleBackColor = True
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(354, 83)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(125, 27)
        txtWeight.TabIndex = 1
        ' 
        ' txtHeight
        ' 
        txtHeight.Location = New Point(354, 147)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(125, 27)
        txtHeight.TabIndex = 2
        ' 
        ' txtBMI
        ' 
        txtBMI.Location = New Point(354, 203)
        txtBMI.Name = "txtBMI"
        txtBMI.Size = New Size(125, 27)
        txtBMI.TabIndex = 3
        ' 
        ' txtComment
        ' 
        txtComment.Location = New Point(354, 277)
        txtComment.Name = "txtComment"
        txtComment.Size = New Size(125, 27)
        txtComment.TabIndex = 4
        ' 
        ' lblWeight
        ' 
        lblWeight.AutoSize = True
        lblWeight.Location = New Point(203, 83)
        lblWeight.Name = "lblWeight"
        lblWeight.Size = New Size(127, 20)
        lblWeight.TabIndex = 5
        lblWeight.Text = "Enter your Weight"
        ' 
        ' lblHeight
        ' 
        lblHeight.AutoSize = True
        lblHeight.Location = New Point(205, 147)
        lblHeight.Name = "lblHeight"
        lblHeight.Size = New Size(125, 20)
        lblHeight.TabIndex = 6
        lblHeight.Text = "Enter your Height"
        ' 
        ' lblBMI
        ' 
        lblBMI.AutoSize = True
        lblBMI.Location = New Point(261, 205)
        lblBMI.Name = "lblBMI"
        lblBMI.Size = New Size(68, 20)
        lblBMI.TabIndex = 7
        lblBMI.Text = "Your BMI"
        ' 
        ' lblComment
        ' 
        lblComment.AutoSize = True
        lblComment.Location = New Point(255, 277)
        lblComment.Name = "lblComment"
        lblComment.Size = New Size(74, 20)
        lblComment.TabIndex = 8
        lblComment.Text = "Comment"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(800, 450)
        Controls.Add(lblComment)
        Controls.Add(lblBMI)
        Controls.Add(lblHeight)
        Controls.Add(lblWeight)
        Controls.Add(txtComment)
        Controls.Add(txtBMI)
        Controls.Add(txtHeight)
        Controls.Add(txtWeight)
        Controls.Add(lblCalculate)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCalculate As Button
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtBMI As TextBox
    Friend WithEvents txtComment As TextBox
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblBMI As Label
    Friend WithEvents lblComment As Label

End Class
