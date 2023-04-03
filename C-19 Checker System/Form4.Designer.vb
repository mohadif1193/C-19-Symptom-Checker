<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SymptomsInputFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicalHistoryFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TravelHistoryFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpAndGuidanceFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btNextRL = New System.Windows.Forms.Button()
        Me.lbRL = New System.Windows.Forms.Label()
        Me.lbOP = New System.Windows.Forms.Label()
        Me.lblLowRisk = New System.Windows.Forms.Label()
        Me.picBarelySafe = New System.Windows.Forms.PictureBox()
        Me.lblModerateRisk = New System.Windows.Forms.Label()
        Me.picRisky = New System.Windows.Forms.PictureBox()
        Me.lblHighRisk = New System.Windows.Forms.Label()
        Me.picHighRisk = New System.Windows.Forms.PictureBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picBarelySafe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRisky, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHighRisk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(682, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FormToolStripMenuItem
        '
        Me.FormToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SymptomsInputFormToolStripMenuItem, Me.MedicalHistoryFormToolStripMenuItem, Me.TravelHistoryFormToolStripMenuItem, Me.HelpAndGuidanceFormToolStripMenuItem})
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
        'TravelHistoryFormToolStripMenuItem
        '
        Me.TravelHistoryFormToolStripMenuItem.Name = "TravelHistoryFormToolStripMenuItem"
        Me.TravelHistoryFormToolStripMenuItem.Size = New System.Drawing.Size(311, 34)
        Me.TravelHistoryFormToolStripMenuItem.Text = "Travel History Form"
        '
        'HelpAndGuidanceFormToolStripMenuItem
        '
        Me.HelpAndGuidanceFormToolStripMenuItem.Name = "HelpAndGuidanceFormToolStripMenuItem"
        Me.HelpAndGuidanceFormToolStripMenuItem.Size = New System.Drawing.Size(311, 34)
        Me.HelpAndGuidanceFormToolStripMenuItem.Text = "Help and Guidance Form"
        '
        'btNextRL
        '
        Me.btNextRL.Location = New System.Drawing.Point(530, 236)
        Me.btNextRL.Name = "btNextRL"
        Me.btNextRL.Size = New System.Drawing.Size(112, 34)
        Me.btNextRL.TabIndex = 40
        Me.btNextRL.Text = "Next"
        Me.btNextRL.UseVisualStyleBackColor = True
        '
        'lbRL
        '
        Me.lbRL.AutoSize = True
        Me.lbRL.BackColor = System.Drawing.Color.Transparent
        Me.lbRL.Location = New System.Drawing.Point(35, 185)
        Me.lbRL.Name = "lbRL"
        Me.lbRL.Size = New System.Drawing.Size(495, 25)
        Me.lbRL.TabIndex = 41
        Me.lbRL.Text = "Based On Your Responded, We Calculated Your Risk Level is : "
        '
        'lbOP
        '
        Me.lbOP.AutoSize = True
        Me.lbOP.BackColor = System.Drawing.Color.Transparent
        Me.lbOP.Location = New System.Drawing.Point(536, 185)
        Me.lbOP.Name = "lbOP"
        Me.lbOP.Size = New System.Drawing.Size(106, 25)
        Me.lbOP.TabIndex = 42
        Me.lbOP.Text = "---Result--- "
        '
        'lblLowRisk
        '
        Me.lblLowRisk.AutoSize = True
        Me.lblLowRisk.BackColor = System.Drawing.Color.Transparent
        Me.lblLowRisk.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblLowRisk.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblLowRisk.Location = New System.Drawing.Point(75, 25)
        Me.lblLowRisk.Name = "lblLowRisk"
        Me.lblLowRisk.Size = New System.Drawing.Size(120, 28)
        Me.lblLowRisk.TabIndex = 49
        Me.lblLowRisk.Text = "1: Low Risk"
        '
        'picBarelySafe
        '
        Me.picBarelySafe.BackgroundImage = CType(resources.GetObject("picBarelySafe.BackgroundImage"), System.Drawing.Image)
        Me.picBarelySafe.Location = New System.Drawing.Point(39, 63)
        Me.picBarelySafe.Name = "picBarelySafe"
        Me.picBarelySafe.Size = New System.Drawing.Size(44, 41)
        Me.picBarelySafe.TabIndex = 48
        Me.picBarelySafe.TabStop = False
        '
        'lblModerateRisk
        '
        Me.lblModerateRisk.AutoSize = True
        Me.lblModerateRisk.BackColor = System.Drawing.Color.Transparent
        Me.lblModerateRisk.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblModerateRisk.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblModerateRisk.Location = New System.Drawing.Point(266, 25)
        Me.lblModerateRisk.Name = "lblModerateRisk"
        Me.lblModerateRisk.Size = New System.Drawing.Size(180, 28)
        Me.lblModerateRisk.TabIndex = 51
        Me.lblModerateRisk.Text = "2: Moderate Risk"
        '
        'picRisky
        '
        Me.picRisky.BackgroundImage = CType(resources.GetObject("picRisky.BackgroundImage"), System.Drawing.Image)
        Me.picRisky.Location = New System.Drawing.Point(230, 63)
        Me.picRisky.Name = "picRisky"
        Me.picRisky.Size = New System.Drawing.Size(44, 41)
        Me.picRisky.TabIndex = 50
        Me.picRisky.TabStop = False
        '
        'lblHighRisk
        '
        Me.lblHighRisk.AutoSize = True
        Me.lblHighRisk.BackColor = System.Drawing.Color.Transparent
        Me.lblHighRisk.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblHighRisk.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHighRisk.Location = New System.Drawing.Point(509, 25)
        Me.lblHighRisk.Name = "lblHighRisk"
        Me.lblHighRisk.Size = New System.Drawing.Size(128, 28)
        Me.lblHighRisk.TabIndex = 53
        Me.lblHighRisk.Text = "3: High Risk"
        '
        'picHighRisk
        '
        Me.picHighRisk.BackgroundImage = CType(resources.GetObject("picHighRisk.BackgroundImage"), System.Drawing.Image)
        Me.picHighRisk.Location = New System.Drawing.Point(473, 63)
        Me.picHighRisk.Name = "picHighRisk"
        Me.picHighRisk.Size = New System.Drawing.Size(44, 41)
        Me.picHighRisk.TabIndex = 52
        Me.picHighRisk.TabStop = False
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(390, 236)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(112, 34)
        Me.btnCalc.TabIndex = 54
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(35, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 25)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Press ""Calculate"" button to see the result."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblLowRisk)
        Me.Panel1.Controls.Add(Me.lblModerateRisk)
        Me.Panel1.Controls.Add(Me.lblHighRisk)
        Me.Panel1.Location = New System.Drawing.Point(12, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(644, 73)
        Me.Panel1.TabIndex = 56
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(12, 128)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(644, 102)
        Me.Panel2.TabIndex = 57
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(682, 303)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.picHighRisk)
        Me.Controls.Add(Me.picRisky)
        Me.Controls.Add(Me.picBarelySafe)
        Me.Controls.Add(Me.lbOP)
        Me.Controls.Add(Me.lbRL)
        Me.Controls.Add(Me.btNextRL)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Risk Level Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picBarelySafe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRisky, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHighRisk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SymptomsInputFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicalHistoryFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TravelHistoryFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpAndGuidanceFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btNextRL As Button
    Friend WithEvents lbRL As Label
    Friend WithEvents lbOP As Label
    Friend WithEvents lblLowRisk As Label
    Friend WithEvents picBarelySafe As PictureBox
    Friend WithEvents lblModerateRisk As Label
    Friend WithEvents picRisky As PictureBox
    Friend WithEvents lblHighRisk As Label
    Friend WithEvents picHighRisk As PictureBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
