<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.rbQ1thNS = New System.Windows.Forms.RadioButton()
        Me.rbQ1thNo = New System.Windows.Forms.RadioButton()
        Me.rbQ1thYes = New System.Windows.Forms.RadioButton()
        Me.lbTH = New System.Windows.Forms.Label()
        Me.lbQ1th = New System.Windows.Forms.Label()
        Me.lbCV = New System.Windows.Forms.Label()
        Me.tbCV = New System.Windows.Forms.TextBox()
        Me.tbHCZ = New System.Windows.Forms.TextBox()
        Me.lbHCZ = New System.Windows.Forms.Label()
        Me.lbQ2th = New System.Windows.Forms.Label()
        Me.tbHFV = New System.Windows.Forms.TextBox()
        Me.lbHFV = New System.Windows.Forms.Label()
        Me.lbQ3th = New System.Windows.Forms.Label()
        Me.btNextTH = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SymptomsInputFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicalHistoryFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RiskLevelFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpAndGuidanceFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbQ1thNS
        '
        Me.rbQ1thNS.AutoSize = True
        Me.rbQ1thNS.BackColor = System.Drawing.Color.Transparent
        Me.rbQ1thNS.Location = New System.Drawing.Point(145, 6)
        Me.rbQ1thNS.Name = "rbQ1thNS"
        Me.rbQ1thNS.Size = New System.Drawing.Size(107, 29)
        Me.rbQ1thNS.TabIndex = 22
        Me.rbQ1thNS.TabStop = True
        Me.rbQ1thNS.Text = "Not Sure"
        Me.rbQ1thNS.UseVisualStyleBackColor = False
        '
        'rbQ1thNo
        '
        Me.rbQ1thNo.AutoSize = True
        Me.rbQ1thNo.BackColor = System.Drawing.Color.Transparent
        Me.rbQ1thNo.Location = New System.Drawing.Point(78, 6)
        Me.rbQ1thNo.Name = "rbQ1thNo"
        Me.rbQ1thNo.Size = New System.Drawing.Size(61, 29)
        Me.rbQ1thNo.TabIndex = 21
        Me.rbQ1thNo.TabStop = True
        Me.rbQ1thNo.Text = "No"
        Me.rbQ1thNo.UseVisualStyleBackColor = False
        '
        'rbQ1thYes
        '
        Me.rbQ1thYes.AutoCheck = False
        Me.rbQ1thYes.AutoSize = True
        Me.rbQ1thYes.BackColor = System.Drawing.Color.Transparent
        Me.rbQ1thYes.Location = New System.Drawing.Point(10, 6)
        Me.rbQ1thYes.Name = "rbQ1thYes"
        Me.rbQ1thYes.Size = New System.Drawing.Size(62, 29)
        Me.rbQ1thYes.TabIndex = 20
        Me.rbQ1thYes.TabStop = True
        Me.rbQ1thYes.Text = "Yes"
        Me.rbQ1thYes.UseVisualStyleBackColor = False
        '
        'lbTH
        '
        Me.lbTH.AutoSize = True
        Me.lbTH.BackColor = System.Drawing.Color.Transparent
        Me.lbTH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbTH.Location = New System.Drawing.Point(12, 44)
        Me.lbTH.Name = "lbTH"
        Me.lbTH.Size = New System.Drawing.Size(120, 27)
        Me.lbTH.TabIndex = 23
        Me.lbTH.Text = "Travel History"
        '
        'lbQ1th
        '
        Me.lbQ1th.AutoSize = True
        Me.lbQ1th.BackColor = System.Drawing.Color.Transparent
        Me.lbQ1th.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbQ1th.Location = New System.Drawing.Point(61, 94)
        Me.lbQ1th.Name = "lbQ1th"
        Me.lbQ1th.Size = New System.Drawing.Size(328, 27)
        Me.lbQ1th.TabIndex = 24
        Me.lbQ1th.Text = "History of recent travel in past 14 days :"
        '
        'lbCV
        '
        Me.lbCV.AutoSize = True
        Me.lbCV.BackColor = System.Drawing.Color.Transparent
        Me.lbCV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCV.Location = New System.Drawing.Point(240, 132)
        Me.lbCV.Name = "lbCV"
        Me.lbCV.Size = New System.Drawing.Size(149, 27)
        Me.lbCV.TabIndex = 25
        Me.lbCV.Text = "City visted (text) :"
        '
        'tbCV
        '
        Me.tbCV.Location = New System.Drawing.Point(430, 129)
        Me.tbCV.Multiline = True
        Me.tbCV.Name = "tbCV"
        Me.tbCV.Size = New System.Drawing.Size(364, 76)
        Me.tbCV.TabIndex = 26
        '
        'tbHCZ
        '
        Me.tbHCZ.Location = New System.Drawing.Point(430, 276)
        Me.tbHCZ.Multiline = True
        Me.tbHCZ.Name = "tbHCZ"
        Me.tbHCZ.Size = New System.Drawing.Size(364, 76)
        Me.tbHCZ.TabIndex = 32
        '
        'lbHCZ
        '
        Me.lbHCZ.AutoSize = True
        Me.lbHCZ.BackColor = System.Drawing.Color.Transparent
        Me.lbHCZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbHCZ.Location = New System.Drawing.Point(141, 279)
        Me.lbHCZ.Name = "lbHCZ"
        Me.lbHCZ.Size = New System.Drawing.Size(248, 27)
        Me.lbHCZ.TabIndex = 31
        Me.lbHCZ.Text = "Hotspot/contaminated zone :"
        '
        'lbQ2th
        '
        Me.lbQ2th.AutoSize = True
        Me.lbQ2th.BackColor = System.Drawing.Color.Transparent
        Me.lbQ2th.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbQ2th.Location = New System.Drawing.Point(79, 216)
        Me.lbQ2th.Name = "lbQ2th"
        Me.lbQ2th.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbQ2th.Size = New System.Drawing.Size(310, 52)
        Me.lbQ2th.TabIndex = 30
        Me.lbQ2th.Text = "Coming from hotspot/contaminated " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "zone prior to symptom onset :"
        Me.lbQ2th.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbHFV
        '
        Me.tbHFV.Location = New System.Drawing.Point(430, 393)
        Me.tbHFV.Multiline = True
        Me.tbHFV.Name = "tbHFV"
        Me.tbHFV.Size = New System.Drawing.Size(364, 76)
        Me.tbHFV.TabIndex = 38
        '
        'lbHFV
        '
        Me.lbHFV.AutoSize = True
        Me.lbHFV.BackColor = System.Drawing.Color.Transparent
        Me.lbHFV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbHFV.Location = New System.Drawing.Point(136, 396)
        Me.lbHFV.Name = "lbHFV"
        Me.lbHFV.Size = New System.Drawing.Size(253, 27)
        Me.lbHFV.TabIndex = 37
        Me.lbHFV.Text = "Health care facility(ies) visited :"
        '
        'lbQ3th
        '
        Me.lbQ3th.AutoSize = True
        Me.lbQ3th.BackColor = System.Drawing.Color.Transparent
        Me.lbQ3th.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbQ3th.Location = New System.Drawing.Point(29, 358)
        Me.lbQ3th.Name = "lbQ3th"
        Me.lbQ3th.Size = New System.Drawing.Size(360, 27)
        Me.lbQ3th.TabIndex = 36
        Me.lbQ3th.Text = "Visited health facility in the past two weeks :"
        '
        'btNextTH
        '
        Me.btNextTH.Location = New System.Drawing.Point(727, 490)
        Me.btNextTH.Name = "btNextTH"
        Me.btNextTH.Size = New System.Drawing.Size(112, 34)
        Me.btNextTH.TabIndex = 39
        Me.btNextTH.Text = "Next"
        Me.btNextTH.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(865, 33)
        Me.MenuStrip1.TabIndex = 40
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FormToolStripMenuItem
        '
        Me.FormToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SymptomsInputFormToolStripMenuItem, Me.MedicalHistoryFormToolStripMenuItem, Me.RiskLevelFormToolStripMenuItem, Me.HelpAndGuidanceFormToolStripMenuItem})
        Me.FormToolStripMenuItem.Name = "FormToolStripMenuItem"
        Me.FormToolStripMenuItem.Size = New System.Drawing.Size(70, 29)
        Me.FormToolStripMenuItem.Text = "Form"
        '
        'SymptomsInputFormToolStripMenuItem
        '
        Me.SymptomsInputFormToolStripMenuItem.Name = "SymptomsInputFormToolStripMenuItem"
        Me.SymptomsInputFormToolStripMenuItem.Size = New System.Drawing.Size(311, 34)
        Me.SymptomsInputFormToolStripMenuItem.Text = "Symptoms Input Form"
        '
        'MedicalHistoryFormToolStripMenuItem
        '
        Me.MedicalHistoryFormToolStripMenuItem.Name = "MedicalHistoryFormToolStripMenuItem"
        Me.MedicalHistoryFormToolStripMenuItem.Size = New System.Drawing.Size(311, 34)
        Me.MedicalHistoryFormToolStripMenuItem.Text = "Medical History Form"
        '
        'RiskLevelFormToolStripMenuItem
        '
        Me.RiskLevelFormToolStripMenuItem.Name = "RiskLevelFormToolStripMenuItem"
        Me.RiskLevelFormToolStripMenuItem.Size = New System.Drawing.Size(311, 34)
        Me.RiskLevelFormToolStripMenuItem.Text = "Risk Level Form"
        '
        'HelpAndGuidanceFormToolStripMenuItem
        '
        Me.HelpAndGuidanceFormToolStripMenuItem.Name = "HelpAndGuidanceFormToolStripMenuItem"
        Me.HelpAndGuidanceFormToolStripMenuItem.Size = New System.Drawing.Size(311, 34)
        Me.HelpAndGuidanceFormToolStripMenuItem.Text = "Help and Guidance Form"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbQ1thNS)
        Me.GroupBox1.Controls.Add(Me.rbQ1thNo)
        Me.GroupBox1.Controls.Add(Me.rbQ1thYes)
        Me.GroupBox1.Location = New System.Drawing.Point(422, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 38)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Location = New System.Drawing.Point(432, 231)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(362, 35)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Location = New System.Drawing.Point(145, 6)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(107, 29)
        Me.RadioButton1.TabIndex = 22
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Not Sure"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Location = New System.Drawing.Point(78, 6)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(61, 29)
        Me.RadioButton2.TabIndex = 21
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "No"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoCheck = False
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.Location = New System.Drawing.Point(10, 6)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(62, 29)
        Me.RadioButton3.TabIndex = 20
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Yes"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.RadioButton4)
        Me.GroupBox3.Controls.Add(Me.RadioButton5)
        Me.GroupBox3.Controls.Add(Me.RadioButton6)
        Me.GroupBox3.Location = New System.Drawing.Point(422, 352)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(372, 35)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton4.Location = New System.Drawing.Point(145, 6)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(107, 29)
        Me.RadioButton4.TabIndex = 22
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Not Sure"
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton5.Location = New System.Drawing.Point(78, 6)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(61, 29)
        Me.RadioButton5.TabIndex = 21
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "No"
        Me.RadioButton5.UseVisualStyleBackColor = False
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoCheck = False
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton6.Location = New System.Drawing.Point(10, 6)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(62, 29)
        Me.RadioButton6.TabIndex = 20
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Yes"
        Me.RadioButton6.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(12, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(795, 410)
        Me.Panel1.TabIndex = 44
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(865, 550)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btNextTH)
        Me.Controls.Add(Me.tbHFV)
        Me.Controls.Add(Me.lbHFV)
        Me.Controls.Add(Me.lbQ3th)
        Me.Controls.Add(Me.tbHCZ)
        Me.Controls.Add(Me.lbHCZ)
        Me.Controls.Add(Me.lbQ2th)
        Me.Controls.Add(Me.tbCV)
        Me.Controls.Add(Me.lbCV)
        Me.Controls.Add(Me.lbQ1th)
        Me.Controls.Add(Me.lbTH)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form3"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Travel History Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbQ1thNS As RadioButton
    Friend WithEvents rbQ1thNo As RadioButton
    Friend WithEvents rbQ1thYes As RadioButton
    Friend WithEvents lbTH As Label
    Friend WithEvents lbQ1th As Label
    Friend WithEvents lbCV As Label
    Friend WithEvents tbCV As TextBox
    Friend WithEvents tbHCZ As TextBox
    Friend WithEvents lbHCZ As Label
    Friend WithEvents lbQ2th As Label
    Friend WithEvents tbHFV As TextBox
    Friend WithEvents lbHFV As Label
    Friend WithEvents lbQ3th As Label
    Friend WithEvents btNextTH As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SymptomsInputFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicalHistoryFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RiskLevelFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpAndGuidanceFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents Panel1 As Panel
End Class
