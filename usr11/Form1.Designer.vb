<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Форма переопределяет dispose для очистки списка компонентов.
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

	'Является обязательной для конструктора форм Windows Forms
	Private components As System.ComponentModel.IContainer

	'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
	'Для ее изменения используйте конструктор форм Windows Form.  
	'Не изменяйте ее в редакторе исходного кода.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.Axis1 = New myUCLib.Axis()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.ButtonInit = New System.Windows.Forms.Button()
		Me.ButtonStart = New System.Windows.Forms.Button()
		Me.ButtonStop = New System.Windows.Forms.Button()
		Me.TextBoxAlpha0 = New System.Windows.Forms.TextBox()
		Me.TextBoxDt = New System.Windows.Forms.TextBox()
		Me.TextBoxV0 = New System.Windows.Forms.TextBox()
		Me.TextBoxT = New System.Windows.Forms.TextBox()
		Me.TextBoxH = New System.Windows.Forms.TextBox()
		Me.TextBoxXBase = New System.Windows.Forms.TextBox()
		Me.TextBoxYBase = New System.Windows.Forms.TextBox()
		Me.TextBoxXmax = New System.Windows.Forms.TextBox()
		Me.TextBoxYmax = New System.Windows.Forms.TextBox()
		Me.TextBoxVmax = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.ButtonClear = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Axis1
		'
		Me.Axis1.axis_bkcolor = System.Drawing.Color.White
		Me.Axis1.axis_color = System.Drawing.Color.Gray
		Me.Axis1.Axis_Type = CType(1, Byte)
		Me.Axis1.E_x = 0
		Me.Axis1.E_y = 0
		Me.Axis1.Location = New System.Drawing.Point(298, 12)
		Me.Axis1.Name = "Axis1"
		Me.Axis1.Pix_color = System.Drawing.Color.Black
		Me.Axis1.Pix_Size = 2.0!
		Me.Axis1.Pix_type = CType(1, Byte)
		Me.Axis1.Size = New System.Drawing.Size(490, 323)
		Me.Axis1.TabIndex = 0
		Me.Axis1.x_Base = 1.0!
		Me.Axis1.x_Name = "X"
		Me.Axis1.y_Base = 1.0!
		Me.Axis1.y_Name = "Y"
		'
		'Timer1
		'
		Me.Timer1.Interval = 10
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadioButton1.Location = New System.Drawing.Point(271, 380)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(79, 24)
		Me.RadioButton1.TabIndex = 1
		Me.RadioButton1.Text = "Switch"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'ButtonInit
		'
		Me.ButtonInit.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold)
		Me.ButtonInit.Location = New System.Drawing.Point(382, 351)
		Me.ButtonInit.Name = "ButtonInit"
		Me.ButtonInit.Size = New System.Drawing.Size(122, 55)
		Me.ButtonInit.TabIndex = 2
		Me.ButtonInit.Text = "ButtonInit"
		Me.ButtonInit.UseVisualStyleBackColor = True
		'
		'ButtonStart
		'
		Me.ButtonStart.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold)
		Me.ButtonStart.Location = New System.Drawing.Point(523, 351)
		Me.ButtonStart.Name = "ButtonStart"
		Me.ButtonStart.Size = New System.Drawing.Size(120, 55)
		Me.ButtonStart.TabIndex = 3
		Me.ButtonStart.Text = "ButtonStart"
		Me.ButtonStart.UseVisualStyleBackColor = True
		'
		'ButtonStop
		'
		Me.ButtonStop.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold)
		Me.ButtonStop.Location = New System.Drawing.Point(662, 350)
		Me.ButtonStop.Name = "ButtonStop"
		Me.ButtonStop.Size = New System.Drawing.Size(117, 55)
		Me.ButtonStop.TabIndex = 4
		Me.ButtonStop.Text = "ButtonStop"
		Me.ButtonStop.UseVisualStyleBackColor = True
		'
		'TextBoxAlpha0
		'
		Me.TextBoxAlpha0.Location = New System.Drawing.Point(20, 49)
		Me.TextBoxAlpha0.Name = "TextBoxAlpha0"
		Me.TextBoxAlpha0.Size = New System.Drawing.Size(100, 32)
		Me.TextBoxAlpha0.TabIndex = 5
		'
		'TextBoxDt
		'
		Me.TextBoxDt.Location = New System.Drawing.Point(20, 106)
		Me.TextBoxDt.Name = "TextBoxDt"
		Me.TextBoxDt.Size = New System.Drawing.Size(100, 32)
		Me.TextBoxDt.TabIndex = 6
		'
		'TextBoxV0
		'
		Me.TextBoxV0.Location = New System.Drawing.Point(20, 164)
		Me.TextBoxV0.Name = "TextBoxV0"
		Me.TextBoxV0.Size = New System.Drawing.Size(100, 32)
		Me.TextBoxV0.TabIndex = 6
		'
		'TextBoxT
		'
		Me.TextBoxT.Location = New System.Drawing.Point(20, 285)
		Me.TextBoxT.Name = "TextBoxT"
		Me.TextBoxT.Size = New System.Drawing.Size(100, 32)
		Me.TextBoxT.TabIndex = 7
		'
		'TextBoxH
		'
		Me.TextBoxH.Location = New System.Drawing.Point(20, 227)
		Me.TextBoxH.Name = "TextBoxH"
		Me.TextBoxH.Size = New System.Drawing.Size(100, 32)
		Me.TextBoxH.TabIndex = 7
		'
		'TextBoxXBase
		'
		Me.TextBoxXBase.Location = New System.Drawing.Point(153, 49)
		Me.TextBoxXBase.Name = "TextBoxXBase"
		Me.TextBoxXBase.Size = New System.Drawing.Size(100, 32)
		Me.TextBoxXBase.TabIndex = 8
		'
		'TextBoxYBase
		'
		Me.TextBoxYBase.Location = New System.Drawing.Point(153, 106)
		Me.TextBoxYBase.Name = "TextBoxYBase"
		Me.TextBoxYBase.Size = New System.Drawing.Size(100, 32)
		Me.TextBoxYBase.TabIndex = 9
		'
		'TextBoxXmax
		'
		Me.TextBoxXmax.Location = New System.Drawing.Point(153, 164)
		Me.TextBoxXmax.Name = "TextBoxXmax"
		Me.TextBoxXmax.Size = New System.Drawing.Size(100, 32)
		Me.TextBoxXmax.TabIndex = 10
		'
		'TextBoxYmax
		'
		Me.TextBoxYmax.Location = New System.Drawing.Point(153, 227)
		Me.TextBoxYmax.Name = "TextBoxYmax"
		Me.TextBoxYmax.Size = New System.Drawing.Size(100, 32)
		Me.TextBoxYmax.TabIndex = 11
		'
		'TextBoxVmax
		'
		Me.TextBoxVmax.Location = New System.Drawing.Point(153, 285)
		Me.TextBoxVmax.Name = "TextBoxVmax"
		Me.TextBoxVmax.Size = New System.Drawing.Size(100, 32)
		Me.TextBoxVmax.TabIndex = 12
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(41, 26)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(63, 20)
		Me.Label1.TabIndex = 13
		Me.Label1.Text = "Alpha0"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(56, 84)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(29, 20)
		Me.Label2.TabIndex = 14
		Me.Label2.Text = "Dt"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(56, 141)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(32, 20)
		Me.Label3.TabIndex = 14
		Me.Label3.Text = "V0"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(57, 262)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(20, 20)
		Me.Label4.TabIndex = 14
		Me.Label4.Text = "T"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(56, 204)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(21, 20)
		Me.Label5.TabIndex = 15
		Me.Label5.Text = "H"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(173, 28)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(54, 20)
		Me.Label6.TabIndex = 16
		Me.Label6.Text = "XBase"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(174, 83)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(53, 20)
		Me.Label7.TabIndex = 17
		Me.Label7.Text = "YBase"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(176, 141)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(51, 20)
		Me.Label8.TabIndex = 18
		Me.Label8.Text = "Xmax"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(176, 204)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(50, 20)
		Me.Label9.TabIndex = 19
		Me.Label9.Text = "Ymax"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(176, 262)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(50, 20)
		Me.Label10.TabIndex = 20
		Me.Label10.Text = "Vmax"
		'
		'ButtonClear
		'
		Me.ButtonClear.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold)
		Me.ButtonClear.Location = New System.Drawing.Point(75, 365)
		Me.ButtonClear.Name = "ButtonClear"
		Me.ButtonClear.Size = New System.Drawing.Size(111, 55)
		Me.ButtonClear.TabIndex = 21
		Me.ButtonClear.Text = "Clear"
		Me.ButtonClear.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.TextBoxVmax)
		Me.GroupBox1.Controls.Add(Me.TextBoxAlpha0)
		Me.GroupBox1.Controls.Add(Me.Label10)
		Me.GroupBox1.Controls.Add(Me.TextBoxDt)
		Me.GroupBox1.Controls.Add(Me.Label9)
		Me.GroupBox1.Controls.Add(Me.TextBoxV0)
		Me.GroupBox1.Controls.Add(Me.Label8)
		Me.GroupBox1.Controls.Add(Me.TextBoxT)
		Me.GroupBox1.Controls.Add(Me.Label7)
		Me.GroupBox1.Controls.Add(Me.TextBoxH)
		Me.GroupBox1.Controls.Add(Me.Label6)
		Me.GroupBox1.Controls.Add(Me.TextBoxXBase)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.TextBoxYBase)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.TextBoxXmax)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.TextBoxYmax)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(272, 337)
		Me.GroupBox1.TabIndex = 22
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "data"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.ButtonClear)
		Me.Controls.Add(Me.ButtonStop)
		Me.Controls.Add(Me.ButtonStart)
		Me.Controls.Add(Me.ButtonInit)
		Me.Controls.Add(Me.RadioButton1)
		Me.Controls.Add(Me.Axis1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Form1"
		Me.Text = "usr1"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Axis1 As myUCLib.Axis
	Friend WithEvents Timer1 As Timer
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents ButtonInit As Button
	Friend WithEvents ButtonStart As Button
	Friend WithEvents ButtonStop As Button
	Friend WithEvents TextBoxAlpha0 As TextBox
	Friend WithEvents TextBoxDt As TextBox
	Friend WithEvents TextBoxV0 As TextBox
	Friend WithEvents TextBoxT As TextBox
	Friend WithEvents TextBoxH As TextBox
	Friend WithEvents TextBoxXBase As TextBox
	Friend WithEvents TextBoxYBase As TextBox
	Friend WithEvents TextBoxXmax As TextBox
	Friend WithEvents TextBoxYmax As TextBox
	Friend WithEvents TextBoxVmax As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents ButtonClear As Button
	Friend WithEvents GroupBox1 As GroupBox
End Class
