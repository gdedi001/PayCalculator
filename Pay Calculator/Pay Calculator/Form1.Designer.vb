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
		Me.title = New System.Windows.Forms.Label()
		Me.lblHrPR = New System.Windows.Forms.Label()
		Me.lblHrsWrkd = New System.Windows.Forms.Label()
		Me.txtHrPR = New System.Windows.Forms.TextBox()
		Me.txtHrWrkd = New System.Windows.Forms.TextBox()
		Me.btnCalculate = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.lblGrossPay = New System.Windows.Forms.Label()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.OutputPanel = New System.Windows.Forms.Panel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.lblDeductions = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.lblNetPay = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.radPension = New System.Windows.Forms.RadioButton()
		Me.rad401K = New System.Windows.Forms.RadioButton()
		Me.chkTravelBonus = New System.Windows.Forms.CheckBox()
		Me.StatusStrip1.SuspendLayout()
		Me.OutputPanel.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'title
		'
		Me.title.AutoSize = True
		Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.title.Location = New System.Drawing.Point(173, 9)
		Me.title.Name = "title"
		Me.title.Size = New System.Drawing.Size(199, 20)
		Me.title.TabIndex = 0
		Me.title.Text = "Calculating Monthly Pay"
		'
		'lblHrPR
		'
		Me.lblHrPR.AutoSize = True
		Me.lblHrPR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHrPR.Location = New System.Drawing.Point(12, 69)
		Me.lblHrPR.Name = "lblHrPR"
		Me.lblHrPR.Size = New System.Drawing.Size(115, 17)
		Me.lblHrPR.TabIndex = 1
		Me.lblHrPR.Text = "Hourly Pay Rate:"
		'
		'lblHrsWrkd
		'
		Me.lblHrsWrkd.AutoSize = True
		Me.lblHrsWrkd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHrsWrkd.Location = New System.Drawing.Point(24, 113)
		Me.lblHrsWrkd.Name = "lblHrsWrkd"
		Me.lblHrsWrkd.Size = New System.Drawing.Size(103, 17)
		Me.lblHrsWrkd.TabIndex = 2
		Me.lblHrsWrkd.Text = "Hours Worked:"
		'
		'txtHrPR
		'
		Me.txtHrPR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHrPR.Location = New System.Drawing.Point(133, 69)
		Me.txtHrPR.Name = "txtHrPR"
		Me.txtHrPR.Size = New System.Drawing.Size(100, 23)
		Me.txtHrPR.TabIndex = 3
		Me.txtHrPR.Text = "0.00"
		Me.txtHrPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'txtHrWrkd
		'
		Me.txtHrWrkd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHrWrkd.Location = New System.Drawing.Point(133, 110)
		Me.txtHrWrkd.Name = "txtHrWrkd"
		Me.txtHrWrkd.Size = New System.Drawing.Size(100, 23)
		Me.txtHrWrkd.TabIndex = 4
		Me.txtHrWrkd.Text = "0.00"
		Me.txtHrWrkd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'btnCalculate
		'
		Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCalculate.Location = New System.Drawing.Point(287, 192)
		Me.btnCalculate.Name = "btnCalculate"
		Me.btnCalculate.Size = New System.Drawing.Size(85, 27)
		Me.btnCalculate.TabIndex = 5
		Me.btnCalculate.Text = "Calculate"
		Me.btnCalculate.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(29, 8)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(78, 17)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Gross Pay:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblGrossPay
		'
		Me.lblGrossPay.BackColor = System.Drawing.SystemColors.Info
		Me.lblGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblGrossPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGrossPay.Location = New System.Drawing.Point(122, 8)
		Me.lblGrossPay.Name = "lblGrossPay"
		Me.lblGrossPay.Size = New System.Drawing.Size(86, 23)
		Me.lblGrossPay.TabIndex = 7
		Me.lblGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'btnExit
		'
		Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnExit.Location = New System.Drawing.Point(467, 192)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(88, 27)
		Me.btnExit.TabIndex = 8
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClear.Location = New System.Drawing.Point(378, 192)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(83, 27)
		Me.btnClear.TabIndex = 9
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 293)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(581, 22)
		Me.StatusStrip1.TabIndex = 10
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(0, 17)
		'
		'OutputPanel
		'
		Me.OutputPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.OutputPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.OutputPanel.Controls.Add(Me.Label4)
		Me.OutputPanel.Controls.Add(Me.lblNetPay)
		Me.OutputPanel.Controls.Add(Me.Label3)
		Me.OutputPanel.Controls.Add(Me.lblDeductions)
		Me.OutputPanel.Controls.Add(Me.Label2)
		Me.OutputPanel.Controls.Add(Me.lblGrossPay)
		Me.OutputPanel.Location = New System.Drawing.Point(287, 43)
		Me.OutputPanel.Name = "OutputPanel"
		Me.OutputPanel.Size = New System.Drawing.Size(268, 130)
		Me.OutputPanel.TabIndex = 11
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(24, 50)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(83, 17)
		Me.Label3.TabIndex = 8
		Me.Label3.Text = "Deductions:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblDeductions
		'
		Me.lblDeductions.BackColor = System.Drawing.SystemColors.Info
		Me.lblDeductions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDeductions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDeductions.Location = New System.Drawing.Point(122, 50)
		Me.lblDeductions.Name = "lblDeductions"
		Me.lblDeductions.Size = New System.Drawing.Size(86, 23)
		Me.lblDeductions.TabIndex = 9
		Me.lblDeductions.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(45, 94)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(62, 17)
		Me.Label4.TabIndex = 10
		Me.Label4.Text = "Net Pay:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblNetPay
		'
		Me.lblNetPay.BackColor = System.Drawing.SystemColors.Info
		Me.lblNetPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblNetPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNetPay.Location = New System.Drawing.Point(122, 94)
		Me.lblNetPay.Name = "lblNetPay"
		Me.lblNetPay.Size = New System.Drawing.Size(86, 23)
		Me.lblNetPay.TabIndex = 11
		Me.lblNetPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'GroupBox1
		'
		Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.GroupBox1.Controls.Add(Me.rad401K)
		Me.GroupBox1.Controls.Add(Me.radPension)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(15, 163)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(189, 69)
		Me.GroupBox1.TabIndex = 12
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Retirement Plan"
		'
		'radPension
		'
		Me.radPension.AutoSize = True
		Me.radPension.Location = New System.Drawing.Point(6, 39)
		Me.radPension.Name = "radPension"
		Me.radPension.Size = New System.Drawing.Size(77, 21)
		Me.radPension.TabIndex = 0
		Me.radPension.TabStop = True
		Me.radPension.Text = "Pension"
		Me.radPension.UseVisualStyleBackColor = True
		'
		'rad401K
		'
		Me.rad401K.AutoSize = True
		Me.rad401K.Location = New System.Drawing.Point(103, 39)
		Me.rad401K.Name = "rad401K"
		Me.rad401K.Size = New System.Drawing.Size(59, 21)
		Me.rad401K.TabIndex = 1
		Me.rad401K.TabStop = True
		Me.rad401K.Text = "401K"
		Me.rad401K.UseVisualStyleBackColor = True
		'
		'chkTravelBonus
		'
		Me.chkTravelBonus.AutoSize = True
		Me.chkTravelBonus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkTravelBonus.Location = New System.Drawing.Point(21, 260)
		Me.chkTravelBonus.Name = "chkTravelBonus"
		Me.chkTravelBonus.Size = New System.Drawing.Size(111, 21)
		Me.chkTravelBonus.TabIndex = 13
		Me.chkTravelBonus.Text = "Travel Bonus"
		Me.chkTravelBonus.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLight
		Me.ClientSize = New System.Drawing.Size(581, 315)
		Me.ControlBox = False
		Me.Controls.Add(Me.chkTravelBonus)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.OutputPanel)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnCalculate)
		Me.Controls.Add(Me.txtHrWrkd)
		Me.Controls.Add(Me.txtHrPR)
		Me.Controls.Add(Me.lblHrsWrkd)
		Me.Controls.Add(Me.lblHrPR)
		Me.Controls.Add(Me.title)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "Form1"
		Me.Text = "My Application"
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.OutputPanel.ResumeLayout(False)
		Me.OutputPanel.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents title As Label
	Friend WithEvents lblHrPR As Label
	Friend WithEvents lblHrsWrkd As Label
	Friend WithEvents txtHrPR As TextBox
	Friend WithEvents txtHrWrkd As TextBox
	Friend WithEvents btnCalculate As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents lblGrossPay As Label
	Friend WithEvents btnExit As Button
	Friend WithEvents btnClear As Button
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents lblStatus As ToolStripStatusLabel
	Friend WithEvents OutputPanel As Panel
	Friend WithEvents Label4 As Label
	Friend WithEvents lblNetPay As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents lblDeductions As Label
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents rad401K As RadioButton
	Friend WithEvents radPension As RadioButton
	Friend WithEvents chkTravelBonus As CheckBox
End Class
