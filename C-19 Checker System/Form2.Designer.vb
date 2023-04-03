<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbPI = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tbPN = New System.Windows.Forms.TextBox()
        Me.lbPN = New System.Windows.Forms.Label()
        Me.lbGend = New System.Windows.Forms.Label()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.rbFem = New System.Windows.Forms.RadioButton()
        Me.lbMH = New System.Windows.Forms.Label()
        Me.lbQ1 = New System.Windows.Forms.Label()
        Me.lbQ2 = New System.Windows.Forms.Label()
        Me.rbQ1Yes = New System.Windows.Forms.RadioButton()
        Me.rbQ1No = New System.Windows.Forms.RadioButton()
        Me.rbQ2NS = New System.Windows.Forms.RadioButton()
        Me.rbQ2No = New System.Windows.Forms.RadioButton()
        Me.rbQ2Yes = New System.Windows.Forms.RadioButton()
        Me.lbQ3 = New System.Windows.Forms.Label()
        Me.lbQ4 = New System.Windows.Forms.Label()
        Me.rbQ5Rly = New System.Windows.Forms.RadioButton()
        Me.rbQ5Occ = New System.Windows.Forms.RadioButton()
        Me.rbQ5Often = New System.Windows.Forms.RadioButton()
        Me.lbQ5 = New System.Windows.Forms.Label()
        Me.rbQ5Nvr = New System.Windows.Forms.RadioButton()
        Me.btNextMH = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SymptomsInputFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TravelHistoryFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RiskLevelFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpAndGuidanceFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbq1 = New System.Windows.Forms.GroupBox()
        Me.gbq2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.gbMF = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.gbq1.SuspendLayout()
        Me.gbq2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbMF.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.BackColor = System.Drawing.Color.Transparent
        Me.lbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbName.Location = New System.Drawing.Point(41, 5)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(70, 27)
        Me.lbName.TabIndex = 0
        Me.lbName.Text = "Name :"
        '
        'lbPI
        '
        Me.lbPI.AutoSize = True
        Me.lbPI.BackColor = System.Drawing.Color.Transparent
        Me.lbPI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbPI.Location = New System.Drawing.Point(5, 42)
        Me.lbPI.Name = "lbPI"
        Me.lbPI.Size = New System.Drawing.Size(179, 27)
        Me.lbPI.TabIndex = 1
        Me.lbPI.Text = "Personal Information"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(55, 104)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(229, 31)
        Me.TextBox1.TabIndex = 2
        '
        'tbPN
        '
        Me.tbPN.Location = New System.Drawing.Point(290, 104)
        Me.tbPN.Name = "tbPN"
        Me.tbPN.Size = New System.Drawing.Size(229, 31)
        Me.tbPN.TabIndex = 4
        '
        'lbPN
        '
        Me.lbPN.AutoSize = True
        Me.lbPN.BackColor = System.Drawing.Color.Transparent
        Me.lbPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbPN.Location = New System.Drawing.Point(276, 5)
        Me.lbPN.Name = "lbPN"
        Me.lbPN.Size = New System.Drawing.Size(143, 27)
        Me.lbPN.TabIndex = 3
        Me.lbPN.Text = "Phone Number :"
        '
        'lbGend
        '
        Me.lbGend.AutoSize = True
        Me.lbGend.BackColor = System.Drawing.Color.Transparent
        Me.lbGend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbGend.Location = New System.Drawing.Point(511, 7)
        Me.lbGend.Name = "lbGend"
        Me.lbGend.Size = New System.Drawing.Size(80, 27)
        Me.lbGend.TabIndex = 5
        Me.lbGend.Text = "Gender :"
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.BackColor = System.Drawing.Color.Transparent
        Me.rbMale.Location = New System.Drawing.Point(7, 0)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(75, 29)
        Me.rbMale.TabIndex = 6
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = False
        '
        'rbFem
        '
        Me.rbFem.AutoSize = True
        Me.rbFem.BackColor = System.Drawing.Color.Transparent
        Me.rbFem.Location = New System.Drawing.Point(111, 0)
        Me.rbFem.Name = "rbFem"
        Me.rbFem.Size = New System.Drawing.Size(93, 29)
        Me.rbFem.TabIndex = 7
        Me.rbFem.TabStop = True
        Me.rbFem.Text = "Female"
        Me.rbFem.UseVisualStyleBackColor = False
        '
        'lbMH
        '
        Me.lbMH.AutoSize = True
        Me.lbMH.BackColor = System.Drawing.Color.Transparent
        Me.lbMH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbMH.Location = New System.Drawing.Point(5, 158)
        Me.lbMH.Name = "lbMH"
        Me.lbMH.Size = New System.Drawing.Size(137, 27)
        Me.lbMH.TabIndex = 8
        Me.lbMH.Text = "Medical History"
        '
        'lbQ1
        '
        Me.lbQ1.AutoSize = True
        Me.lbQ1.BackColor = System.Drawing.Color.Transparent
        Me.lbQ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbQ1.Location = New System.Drawing.Point(28, 192)
        Me.lbQ1.Name = "lbQ1"
        Me.lbQ1.Size = New System.Drawing.Size(337, 27)
        Me.lbQ1.TabIndex = 10
        Me.lbQ1.Text = "Are you currently taking any medication?"
        '
        'lbQ2
        '
        Me.lbQ2.AutoSize = True
        Me.lbQ2.BackColor = System.Drawing.Color.Transparent
        Me.lbQ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbQ2.Location = New System.Drawing.Point(28, 247)
        Me.lbQ2.Name = "lbQ2"
        Me.lbQ2.Size = New System.Drawing.Size(318, 27)
        Me.lbQ2.TabIndex = 12
        Me.lbQ2.Text = "Do you have any medication allergies?"
        '
        'rbQ1Yes
        '
        Me.rbQ1Yes.AutoSize = True
        Me.rbQ1Yes.BackColor = System.Drawing.Color.Transparent
        Me.rbQ1Yes.Location = New System.Drawing.Point(11, 0)
        Me.rbQ1Yes.Name = "rbQ1Yes"
        Me.rbQ1Yes.Size = New System.Drawing.Size(62, 29)
        Me.rbQ1Yes.TabIndex = 14
        Me.rbQ1Yes.TabStop = True
        Me.rbQ1Yes.Text = "Yes"
        Me.rbQ1Yes.UseVisualStyleBackColor = False
        '
        'rbQ1No
        '
        Me.rbQ1No.AutoSize = True
        Me.rbQ1No.BackColor = System.Drawing.Color.Transparent
        Me.rbQ1No.Location = New System.Drawing.Point(79, 0)
        Me.rbQ1No.Name = "rbQ1No"
        Me.rbQ1No.Size = New System.Drawing.Size(61, 29)
        Me.rbQ1No.TabIndex = 15
        Me.rbQ1No.TabStop = True
        Me.rbQ1No.Text = "No"
        Me.rbQ1No.UseVisualStyleBackColor = False
        '
        'rbQ2NS
        '
        Me.rbQ2NS.AutoSize = True
        Me.rbQ2NS.BackColor = System.Drawing.Color.Transparent
        Me.rbQ2NS.Location = New System.Drawing.Point(138, 1)
        Me.rbQ2NS.Name = "rbQ2NS"
        Me.rbQ2NS.Size = New System.Drawing.Size(107, 29)
        Me.rbQ2NS.TabIndex = 19
        Me.rbQ2NS.TabStop = True
        Me.rbQ2NS.Text = "Not Sure"
        Me.rbQ2NS.UseVisualStyleBackColor = False
        '
        'rbQ2No
        '
        Me.rbQ2No.AutoSize = True
        Me.rbQ2No.BackColor = System.Drawing.Color.Transparent
        Me.rbQ2No.Location = New System.Drawing.Point(71, 1)
        Me.rbQ2No.Name = "rbQ2No"
        Me.rbQ2No.Size = New System.Drawing.Size(61, 29)
        Me.rbQ2No.TabIndex = 18
        Me.rbQ2No.TabStop = True
        Me.rbQ2No.Text = "No"
        Me.rbQ2No.UseVisualStyleBackColor = False
        '
        'rbQ2Yes
        '
        Me.rbQ2Yes.AutoSize = True
        Me.rbQ2Yes.BackColor = System.Drawing.Color.Transparent
        Me.rbQ2Yes.Location = New System.Drawing.Point(3, 1)
        Me.rbQ2Yes.Name = "rbQ2Yes"
        Me.rbQ2Yes.Size = New System.Drawing.Size(62, 29)
        Me.rbQ2Yes.TabIndex = 17
        Me.rbQ2Yes.TabStop = True
        Me.rbQ2Yes.Text = "Yes"
        Me.rbQ2Yes.UseVisualStyleBackColor = False
        '
        'lbQ3
        '
        Me.lbQ3.AutoSize = True
        Me.lbQ3.BackColor = System.Drawing.Color.Transparent
        Me.lbQ3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbQ3.Location = New System.Drawing.Point(29, 314)
        Me.lbQ3.Name = "lbQ3"
        Me.lbQ3.Size = New System.Drawing.Size(435, 27)
        Me.lbQ3.TabIndex = 20
        Me.lbQ3.Text = "Do you use or do you have history of using tabacco?"
        '
        'lbQ4
        '
        Me.lbQ4.AutoSize = True
        Me.lbQ4.BackColor = System.Drawing.Color.Transparent
        Me.lbQ4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbQ4.Location = New System.Drawing.Point(30, 375)
        Me.lbQ4.Name = "lbQ4"
        Me.lbQ4.Size = New System.Drawing.Size(469, 27)
        Me.lbQ4.TabIndex = 24
        Me.lbQ4.Text = "Do you use or do you have history of using illegal drugs?"
        '
        'rbQ5Rly
        '
        Me.rbQ5Rly.AutoSize = True
        Me.rbQ5Rly.BackColor = System.Drawing.Color.Transparent
        Me.rbQ5Rly.Location = New System.Drawing.Point(269, 463)
        Me.rbQ5Rly.Name = "rbQ5Rly"
        Me.rbQ5Rly.Size = New System.Drawing.Size(85, 29)
        Me.rbQ5Rly.TabIndex = 31
        Me.rbQ5Rly.TabStop = True
        Me.rbQ5Rly.Text = "Rarely"
        Me.rbQ5Rly.UseVisualStyleBackColor = False
        '
        'rbQ5Occ
        '
        Me.rbQ5Occ.AutoSize = True
        Me.rbQ5Occ.BackColor = System.Drawing.Color.Transparent
        Me.rbQ5Occ.Location = New System.Drawing.Point(128, 463)
        Me.rbQ5Occ.Name = "rbQ5Occ"
        Me.rbQ5Occ.Size = New System.Drawing.Size(135, 29)
        Me.rbQ5Occ.TabIndex = 30
        Me.rbQ5Occ.TabStop = True
        Me.rbQ5Occ.Text = "Occasionally"
        Me.rbQ5Occ.UseVisualStyleBackColor = False
        '
        'rbQ5Often
        '
        Me.rbQ5Often.AutoSize = True
        Me.rbQ5Often.BackColor = System.Drawing.Color.Transparent
        Me.rbQ5Often.Location = New System.Drawing.Point(40, 463)
        Me.rbQ5Often.Name = "rbQ5Often"
        Me.rbQ5Often.Size = New System.Drawing.Size(82, 29)
        Me.rbQ5Often.TabIndex = 29
        Me.rbQ5Often.TabStop = True
        Me.rbQ5Often.Text = "Often"
        Me.rbQ5Often.UseVisualStyleBackColor = False
        '
        'lbQ5
        '
        Me.lbQ5.AutoSize = True
        Me.lbQ5.BackColor = System.Drawing.Color.Transparent
        Me.lbQ5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbQ5.Location = New System.Drawing.Point(34, 435)
        Me.lbQ5.Name = "lbQ5"
        Me.lbQ5.Size = New System.Drawing.Size(307, 27)
        Me.lbQ5.TabIndex = 28
        Me.lbQ5.Text = "How often do you consume alcohol?"
        '
        'rbQ5Nvr
        '
        Me.rbQ5Nvr.AutoSize = True
        Me.rbQ5Nvr.BackColor = System.Drawing.Color.Transparent
        Me.rbQ5Nvr.Location = New System.Drawing.Point(360, 463)
        Me.rbQ5Nvr.Name = "rbQ5Nvr"
        Me.rbQ5Nvr.Size = New System.Drawing.Size(83, 29)
        Me.rbQ5Nvr.TabIndex = 32
        Me.rbQ5Nvr.TabStop = True
        Me.rbQ5Nvr.Text = "Never"
        Me.rbQ5Nvr.UseVisualStyleBackColor = False
        '
        'btNextMH
        '
        Me.btNextMH.Location = New System.Drawing.Point(656, 509)
        Me.btNextMH.Name = "btNextMH"
        Me.btNextMH.Size = New System.Drawing.Size(112, 34)
        Me.btNextMH.TabIndex = 33
        Me.btNextMH.Text = "Next"
        Me.btNextMH.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FormToolStripMenuItem
        '
        Me.FormToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SymptomsInputFormToolStripMenuItem, Me.TravelHistoryFormToolStripMenuItem, Me.RiskLevelFormToolStripMenuItem, Me.HelpAndGuidanceFormToolStripMenuItem})
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
        'TravelHistoryFormToolStripMenuItem
        '
        Me.TravelHistoryFormToolStripMenuItem.Name = "TravelHistoryFormToolStripMenuItem"
        Me.TravelHistoryFormToolStripMenuItem.Size = New System.Drawing.Size(311, 34)
        Me.TravelHistoryFormToolStripMenuItem.Text = "Travel History Form"
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
        'gbq1
        '
        Me.gbq1.BackColor = System.Drawing.Color.Transparent
        Me.gbq1.Controls.Add(Me.rbQ1No)
        Me.gbq1.Controls.Add(Me.rbQ1Yes)
        Me.gbq1.Location = New System.Drawing.Point(29, 220)
        Me.gbq1.Name = "gbq1"
        Me.gbq1.Size = New System.Drawing.Size(146, 29)
        Me.gbq1.TabIndex = 35
        Me.gbq1.TabStop = False
        '
        'gbq2
        '
        Me.gbq2.Controls.Add(Me.rbQ2NS)
        Me.gbq2.Controls.Add(Me.rbQ2Yes)
        Me.gbq2.Controls.Add(Me.rbQ2No)
        Me.gbq2.Location = New System.Drawing.Point(36, 275)
        Me.gbq2.Name = "gbq2"
        Me.gbq2.Size = New System.Drawing.Size(298, 36)
        Me.gbq2.TabIndex = 36
        Me.gbq2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 343)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 29)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Location = New System.Drawing.Point(79, 0)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(61, 29)
        Me.RadioButton1.TabIndex = 15
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "No"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Location = New System.Drawing.Point(11, 0)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(62, 29)
        Me.RadioButton2.TabIndex = 14
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Yes"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 403)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(146, 29)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.Location = New System.Drawing.Point(79, 0)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(61, 29)
        Me.RadioButton3.TabIndex = 15
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "No"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton4.Location = New System.Drawing.Point(11, 0)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(62, 29)
        Me.RadioButton4.TabIndex = 14
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Yes"
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'gbMF
        '
        Me.gbMF.Controls.Add(Me.rbFem)
        Me.gbMF.Controls.Add(Me.rbMale)
        Me.gbMF.Location = New System.Drawing.Point(528, 35)
        Me.gbMF.Name = "gbMF"
        Me.gbMF.Size = New System.Drawing.Size(221, 31)
        Me.gbMF.TabIndex = 39
        Me.gbMF.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.gbMF)
        Me.Panel1.Controls.Add(Me.lbGend)
        Me.Panel1.Controls.Add(Me.lbPN)
        Me.Panel1.Controls.Add(Me.lbName)
        Me.Panel1.Location = New System.Drawing.Point(12, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(756, 88)
        Me.Panel1.TabIndex = 40
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(12, 186)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(756, 317)
        Me.Panel2.TabIndex = 41
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(800, 574)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbq2)
        Me.Controls.Add(Me.gbq1)
        Me.Controls.Add(Me.btNextMH)
        Me.Controls.Add(Me.rbQ5Nvr)
        Me.Controls.Add(Me.rbQ5Rly)
        Me.Controls.Add(Me.rbQ5Occ)
        Me.Controls.Add(Me.rbQ5Often)
        Me.Controls.Add(Me.lbQ5)
        Me.Controls.Add(Me.lbQ4)
        Me.Controls.Add(Me.lbQ3)
        Me.Controls.Add(Me.lbQ2)
        Me.Controls.Add(Me.lbQ1)
        Me.Controls.Add(Me.lbMH)
        Me.Controls.Add(Me.tbPN)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbPI)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medical History Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbq1.ResumeLayout(False)
        Me.gbq1.PerformLayout()
        Me.gbq2.ResumeLayout(False)
        Me.gbq2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbMF.ResumeLayout(False)
        Me.gbMF.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbName As Label
    Friend WithEvents lbPI As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents tbPN As TextBox
    Friend WithEvents lbPN As Label
    Friend WithEvents lbGend As Label
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents rbFem As RadioButton
    Friend WithEvents lbMH As Label
    Friend WithEvents lbQ1 As Label
    Friend WithEvents lbQ2 As Label
    Friend WithEvents rbQ1Yes As RadioButton
    Friend WithEvents rbQ1No As RadioButton
    Friend WithEvents rbQ2NS As RadioButton
    Friend WithEvents rbQ2No As RadioButton
    Friend WithEvents rbQ2Yes As RadioButton
    Friend WithEvents lbQ3 As Label
    Friend WithEvents lbQ4 As Label
    Friend WithEvents rbQ5Rly As RadioButton
    Friend WithEvents rbQ5Occ As RadioButton
    Friend WithEvents rbQ5Often As RadioButton
    Friend WithEvents lbQ5 As Label
    Friend WithEvents rbQ5Nvr As RadioButton
    Friend WithEvents btNextMH As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SymptomsInputFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TravelHistoryFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RiskLevelFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpAndGuidanceFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbq1 As GroupBox
    Friend WithEvents gbq2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents gbMF As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
