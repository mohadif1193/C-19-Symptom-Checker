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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbFC = New System.Windows.Forms.CheckBox()
        Me.cbCough = New System.Windows.Forms.CheckBox()
        Me.cbSDB = New System.Windows.Forms.CheckBox()
        Me.cbFTQ = New System.Windows.Forms.CheckBox()
        Me.cbMBA = New System.Windows.Forms.CheckBox()
        Me.cbHA = New System.Windows.Forms.CheckBox()
        Me.cbTSL = New System.Windows.Forms.CheckBox()
        Me.cbST = New System.Windows.Forms.CheckBox()
        Me.cbCRN = New System.Windows.Forms.CheckBox()
        Me.cbNV = New System.Windows.Forms.CheckBox()
        Me.cbDRA = New System.Windows.Forms.CheckBox()
        Me.tbOther = New System.Windows.Forms.TextBox()
        Me.lbOther = New System.Windows.Forms.Label()
        Me.btNext = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicalHistoryFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TravelHistoryFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RiskLevelFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpAndGuidanceFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Symptoms"
        '
        'cbFC
        '
        Me.cbFC.AutoSize = True
        Me.cbFC.BackColor = System.Drawing.Color.Transparent
        Me.cbFC.Location = New System.Drawing.Point(39, 89)
        Me.cbFC.Name = "cbFC"
        Me.cbFC.Size = New System.Drawing.Size(145, 29)
        Me.cbFC.TabIndex = 2
        Me.cbFC.Tag = "1"
        Me.cbFC.Text = "Fever or chills"
        Me.cbFC.UseVisualStyleBackColor = False
        '
        'cbCough
        '
        Me.cbCough.AutoSize = True
        Me.cbCough.BackColor = System.Drawing.Color.Transparent
        Me.cbCough.Location = New System.Drawing.Point(39, 124)
        Me.cbCough.Name = "cbCough"
        Me.cbCough.Size = New System.Drawing.Size(91, 29)
        Me.cbCough.TabIndex = 3
        Me.cbCough.Tag = "1"
        Me.cbCough.Text = "Cough"
        Me.cbCough.UseVisualStyleBackColor = False
        '
        'cbSDB
        '
        Me.cbSDB.AutoSize = True
        Me.cbSDB.BackColor = System.Drawing.Color.Transparent
        Me.cbSDB.Location = New System.Drawing.Point(39, 159)
        Me.cbSDB.Name = "cbSDB"
        Me.cbSDB.Size = New System.Drawing.Size(370, 29)
        Me.cbSDB.TabIndex = 4
        Me.cbSDB.Tag = "1"
        Me.cbSDB.Text = "Shortness of breath or difficulty breathing"
        Me.cbSDB.UseVisualStyleBackColor = False
        '
        'cbFTQ
        '
        Me.cbFTQ.AutoSize = True
        Me.cbFTQ.BackColor = System.Drawing.Color.Transparent
        Me.cbFTQ.Location = New System.Drawing.Point(39, 194)
        Me.cbFTQ.Name = "cbFTQ"
        Me.cbFTQ.Size = New System.Drawing.Size(95, 29)
        Me.cbFTQ.TabIndex = 5
        Me.cbFTQ.Tag = "1"
        Me.cbFTQ.Text = "Fatigue"
        Me.cbFTQ.UseVisualStyleBackColor = False
        '
        'cbMBA
        '
        Me.cbMBA.AutoSize = True
        Me.cbMBA.BackColor = System.Drawing.Color.Transparent
        Me.cbMBA.Location = New System.Drawing.Point(39, 229)
        Me.cbMBA.Name = "cbMBA"
        Me.cbMBA.Size = New System.Drawing.Size(211, 29)
        Me.cbMBA.TabIndex = 6
        Me.cbMBA.Tag = "1"
        Me.cbMBA.Text = "Muscle or body aches"
        Me.cbMBA.UseVisualStyleBackColor = False
        '
        'cbHA
        '
        Me.cbHA.AutoSize = True
        Me.cbHA.BackColor = System.Drawing.Color.Transparent
        Me.cbHA.Location = New System.Drawing.Point(39, 264)
        Me.cbHA.Name = "cbHA"
        Me.cbHA.Size = New System.Drawing.Size(116, 29)
        Me.cbHA.TabIndex = 7
        Me.cbHA.Tag = "1"
        Me.cbHA.Text = "Headache"
        Me.cbHA.UseVisualStyleBackColor = False
        '
        'cbTSL
        '
        Me.cbTSL.AutoSize = True
        Me.cbTSL.BackColor = System.Drawing.Color.Transparent
        Me.cbTSL.Location = New System.Drawing.Point(429, 89)
        Me.cbTSL.Name = "cbTSL"
        Me.cbTSL.Size = New System.Drawing.Size(242, 29)
        Me.cbTSL.TabIndex = 8
        Me.cbTSL.Tag = "1"
        Me.cbTSL.Text = "New loss of taste or smell"
        Me.cbTSL.UseVisualStyleBackColor = False
        '
        'cbST
        '
        Me.cbST.AutoSize = True
        Me.cbST.BackColor = System.Drawing.Color.Transparent
        Me.cbST.Location = New System.Drawing.Point(429, 124)
        Me.cbST.Name = "cbST"
        Me.cbST.Size = New System.Drawing.Size(127, 29)
        Me.cbST.TabIndex = 9
        Me.cbST.Tag = "1"
        Me.cbST.Text = "Sore throat"
        Me.cbST.UseVisualStyleBackColor = False
        '
        'cbCRN
        '
        Me.cbCRN.AutoSize = True
        Me.cbCRN.BackColor = System.Drawing.Color.Transparent
        Me.cbCRN.Location = New System.Drawing.Point(429, 159)
        Me.cbCRN.Name = "cbCRN"
        Me.cbCRN.Size = New System.Drawing.Size(244, 29)
        Me.cbCRN.TabIndex = 10
        Me.cbCRN.Tag = "1"
        Me.cbCRN.Text = "Congestion or runny nose"
        Me.cbCRN.UseVisualStyleBackColor = False
        '
        'cbNV
        '
        Me.cbNV.AutoSize = True
        Me.cbNV.BackColor = System.Drawing.Color.Transparent
        Me.cbNV.Location = New System.Drawing.Point(429, 194)
        Me.cbNV.Name = "cbNV"
        Me.cbNV.Size = New System.Drawing.Size(194, 29)
        Me.cbNV.TabIndex = 11
        Me.cbNV.Tag = "1"
        Me.cbNV.Text = "Nausea or vomiting"
        Me.cbNV.UseVisualStyleBackColor = False
        '
        'cbDRA
        '
        Me.cbDRA.AutoSize = True
        Me.cbDRA.BackColor = System.Drawing.Color.Transparent
        Me.cbDRA.Location = New System.Drawing.Point(429, 229)
        Me.cbDRA.Name = "cbDRA"
        Me.cbDRA.Size = New System.Drawing.Size(104, 29)
        Me.cbDRA.TabIndex = 12
        Me.cbDRA.Tag = "1"
        Me.cbDRA.Text = "Diarrhea"
        Me.cbDRA.UseVisualStyleBackColor = False
        '
        'tbOther
        '
        Me.tbOther.Location = New System.Drawing.Point(39, 330)
        Me.tbOther.Multiline = True
        Me.tbOther.Name = "tbOther"
        Me.tbOther.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbOther.Size = New System.Drawing.Size(632, 59)
        Me.tbOther.TabIndex = 13
        Me.tbOther.Text = "(Please State)"
        Me.tbOther.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbOther
        '
        Me.lbOther.AutoSize = True
        Me.lbOther.BackColor = System.Drawing.Color.Transparent
        Me.lbOther.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbOther.Location = New System.Drawing.Point(39, 302)
        Me.lbOther.Name = "lbOther"
        Me.lbOther.Size = New System.Drawing.Size(59, 27)
        Me.lbOther.TabIndex = 14
        Me.lbOther.Text = "Other"
        '
        'btNext
        '
        Me.btNext.Location = New System.Drawing.Point(559, 407)
        Me.btNext.Name = "btNext"
        Me.btNext.Size = New System.Drawing.Size(112, 34)
        Me.btNext.TabIndex = 15
        Me.btNext.Text = "Next"
        Me.btNext.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(696, 33)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MedicalHistoryFormToolStripMenuItem, Me.TravelHistoryFormToolStripMenuItem, Me.RiskLevelFormToolStripMenuItem, Me.HelpAndGuidanceFormToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(70, 29)
        Me.MenuToolStripMenuItem.Text = "Form"
        '
        'MedicalHistoryFormToolStripMenuItem
        '
        Me.MedicalHistoryFormToolStripMenuItem.Name = "MedicalHistoryFormToolStripMenuItem"
        Me.MedicalHistoryFormToolStripMenuItem.Size = New System.Drawing.Size(311, 34)
        Me.MedicalHistoryFormToolStripMenuItem.Text = "Medical History Form"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(25, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(646, 222)
        Me.Panel1.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(696, 465)
        Me.Controls.Add(Me.btNext)
        Me.Controls.Add(Me.lbOther)
        Me.Controls.Add(Me.tbOther)
        Me.Controls.Add(Me.cbDRA)
        Me.Controls.Add(Me.cbNV)
        Me.Controls.Add(Me.cbCRN)
        Me.Controls.Add(Me.cbST)
        Me.Controls.Add(Me.cbTSL)
        Me.Controls.Add(Me.cbHA)
        Me.Controls.Add(Me.cbMBA)
        Me.Controls.Add(Me.cbFTQ)
        Me.Controls.Add(Me.cbSDB)
        Me.Controls.Add(Me.cbCough)
        Me.Controls.Add(Me.cbFC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Symptoms Input Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbFC As CheckBox
    Friend WithEvents cbCough As CheckBox
    Friend WithEvents cbSDB As CheckBox
    Friend WithEvents cbFTQ As CheckBox
    Friend WithEvents cbMBA As CheckBox
    Friend WithEvents cbHA As CheckBox
    Friend WithEvents cbTSL As CheckBox
    Friend WithEvents cbST As CheckBox
    Friend WithEvents cbCRN As CheckBox
    Friend WithEvents cbNV As CheckBox
    Friend WithEvents cbDRA As CheckBox
    Friend WithEvents tbOther As TextBox
    Friend WithEvents lbOther As Label
    Friend WithEvents btNext As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicalHistoryFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TravelHistoryFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RiskLevelFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpAndGuidanceFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
End Class
