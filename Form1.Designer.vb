<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.picHeader = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblGroupSize = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSelectBadge = New System.Windows.Forms.Label()
        Me.txtGroupSize = New System.Windows.Forms.TextBox()
        Me.radConSuperhero = New System.Windows.Forms.RadioButton()
        Me.radConAutographs = New System.Windows.Forms.RadioButton()
        Me.radCon = New System.Windows.Forms.RadioButton()
        Me.lblRegistrationCost = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.picHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picHeader
        '
        Me.picHeader.Image = CType(resources.GetObject("picHeader.Image"), System.Drawing.Image)
        Me.picHeader.Location = New System.Drawing.Point(12, 12)
        Me.picHeader.Name = "picHeader"
        Me.picHeader.Size = New System.Drawing.Size(755, 199)
        Me.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHeader.TabIndex = 0
        Me.picHeader.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bookman Old Style", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(92, 232)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(595, 41)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Comic Convention Registration"
        '
        'lblGroupSize
        '
        Me.lblGroupSize.AutoSize = True
        Me.lblGroupSize.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupSize.Location = New System.Drawing.Point(203, 323)
        Me.lblGroupSize.Name = "lblGroupSize"
        Me.lblGroupSize.Size = New System.Drawing.Size(136, 24)
        Me.lblGroupSize.TabIndex = 2
        Me.lblGroupSize.Text = "Group Size:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel1.Controls.Add(Me.radCon)
        Me.Panel1.Controls.Add(Me.radConAutographs)
        Me.Panel1.Controls.Add(Me.radConSuperhero)
        Me.Panel1.Controls.Add(Me.lblSelectBadge)
        Me.Panel1.Location = New System.Drawing.Point(184, 424)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(411, 126)
        Me.Panel1.TabIndex = 3
        '
        'lblSelectBadge
        '
        Me.lblSelectBadge.AutoSize = True
        Me.lblSelectBadge.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectBadge.Location = New System.Drawing.Point(98, 0)
        Me.lblSelectBadge.Name = "lblSelectBadge"
        Me.lblSelectBadge.Size = New System.Drawing.Size(215, 24)
        Me.lblSelectBadge.TabIndex = 3
        Me.lblSelectBadge.Text = "Select Badge Type:"
        '
        'txtGroupSize
        '
        Me.txtGroupSize.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupSize.Location = New System.Drawing.Point(371, 323)
        Me.txtGroupSize.Name = "txtGroupSize"
        Me.txtGroupSize.Size = New System.Drawing.Size(68, 26)
        Me.txtGroupSize.TabIndex = 4
        '
        'radConSuperhero
        '
        Me.radConSuperhero.AutoSize = True
        Me.radConSuperhero.Checked = True
        Me.radConSuperhero.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radConSuperhero.Location = New System.Drawing.Point(3, 37)
        Me.radConSuperhero.Name = "radConSuperhero"
        Me.radConSuperhero.Size = New System.Drawing.Size(329, 23)
        Me.radConSuperhero.TabIndex = 4
        Me.radConSuperhero.TabStop = True
        Me.radConSuperhero.Text = "Convention && Superhero Experience"
        Me.radConSuperhero.UseVisualStyleBackColor = True
        '
        'radConAutographs
        '
        Me.radConAutographs.AutoSize = True
        Me.radConAutographs.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radConAutographs.Location = New System.Drawing.Point(3, 66)
        Me.radConAutographs.Name = "radConAutographs"
        Me.radConAutographs.Size = New System.Drawing.Size(241, 23)
        Me.radConAutographs.TabIndex = 5
        Me.radConAutographs.Text = "Convention && Autographs"
        Me.radConAutographs.UseVisualStyleBackColor = True
        '
        'radCon
        '
        Me.radCon.AutoSize = True
        Me.radCon.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCon.Location = New System.Drawing.Point(3, 95)
        Me.radCon.Name = "radCon"
        Me.radCon.Size = New System.Drawing.Size(124, 23)
        Me.radCon.TabIndex = 6
        Me.radCon.Text = "Convention"
        Me.radCon.UseVisualStyleBackColor = True
        '
        'lblRegistrationCost
        '
        Me.lblRegistrationCost.AutoSize = True
        Me.lblRegistrationCost.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrationCost.Location = New System.Drawing.Point(149, 597)
        Me.lblRegistrationCost.Name = "lblRegistrationCost"
        Me.lblRegistrationCost.Size = New System.Drawing.Size(211, 24)
        Me.lblRegistrationCost.TabIndex = 5
        Me.lblRegistrationCost.Text = "Registration Cost:"
        '
        'lblCost
        '
        Me.lblCost.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(442, 597)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(187, 24)
        Me.lblCost.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(153, 648)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(158, 48)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(437, 648)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(158, 48)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 721)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblRegistrationCost)
        Me.Controls.Add(Me.txtGroupSize)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblGroupSize)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picHeader)
        Me.Name = "frmMain"
        Me.Text = "Comic Convention"
        CType(Me.picHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picHeader As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblGroupSize As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents radCon As RadioButton
    Friend WithEvents radConAutographs As RadioButton
    Friend WithEvents radConSuperhero As RadioButton
    Friend WithEvents lblSelectBadge As Label
    Friend WithEvents txtGroupSize As TextBox
    Friend WithEvents lblRegistrationCost As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
