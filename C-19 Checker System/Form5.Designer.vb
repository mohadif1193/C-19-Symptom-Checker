<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SymptomsInputFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicalHistoryFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TravelHistoryFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RiskLevelFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(964, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FormToolStripMenuItem
        '
        Me.FormToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SymptomsInputFormToolStripMenuItem, Me.MedicalHistoryFormToolStripMenuItem, Me.TravelHistoryFormToolStripMenuItem, Me.RiskLevelFormToolStripMenuItem})
        Me.FormToolStripMenuItem.Name = "FormToolStripMenuItem"
        Me.FormToolStripMenuItem.Size = New System.Drawing.Size(70, 29)
        Me.FormToolStripMenuItem.Text = "Form"
        '
        'SymptomsInputFormToolStripMenuItem
        '
        Me.SymptomsInputFormToolStripMenuItem.Name = "SymptomsInputFormToolStripMenuItem"
        Me.SymptomsInputFormToolStripMenuItem.Size = New System.Drawing.Size(294, 34)
        Me.SymptomsInputFormToolStripMenuItem.Text = "Symptoms Input Form"
        '
        'MedicalHistoryFormToolStripMenuItem
        '
        Me.MedicalHistoryFormToolStripMenuItem.Name = "MedicalHistoryFormToolStripMenuItem"
        Me.MedicalHistoryFormToolStripMenuItem.Size = New System.Drawing.Size(294, 34)
        Me.MedicalHistoryFormToolStripMenuItem.Text = "Medical History Form"
        '
        'TravelHistoryFormToolStripMenuItem
        '
        Me.TravelHistoryFormToolStripMenuItem.Name = "TravelHistoryFormToolStripMenuItem"
        Me.TravelHistoryFormToolStripMenuItem.Size = New System.Drawing.Size(294, 34)
        Me.TravelHistoryFormToolStripMenuItem.Text = "Travel History Form"
        '
        'RiskLevelFormToolStripMenuItem
        '
        Me.RiskLevelFormToolStripMenuItem.Name = "RiskLevelFormToolStripMenuItem"
        Me.RiskLevelFormToolStripMenuItem.Size = New System.Drawing.Size(294, 34)
        Me.RiskLevelFormToolStripMenuItem.Text = "Risk Level Form"
        '
        'btSubmit
        '
        Me.btSubmit.Location = New System.Drawing.Point(816, 366)
        Me.btSubmit.Name = "btSubmit"
        Me.btSubmit.Size = New System.Drawing.Size(112, 34)
        Me.btSubmit.TabIndex = 40
        Me.btSubmit.Text = "Submit"
        Me.btSubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(894, 75)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(31, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(897, 96)
        Me.Panel1.TabIndex = 42
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(30, 147)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(897, 96)
        Me.Panel2.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(901, 75)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(30, 249)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(897, 96)
        Me.Panel3.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(0, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(699, 75)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(964, 422)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btSubmit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help and Guidance Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SymptomsInputFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicalHistoryFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TravelHistoryFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RiskLevelFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
End Class
