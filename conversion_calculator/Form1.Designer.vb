<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conversion_Calculator
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
        Me.btnWeight = New System.Windows.Forms.Button()
        Me.btnCurrency = New System.Windows.Forms.Button()
        Me.btnVolume = New System.Windows.Forms.Button()
        Me.btnDistance = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.pnlStart = New System.Windows.Forms.Panel()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.lblEquals = New System.Windows.Forms.Label()
        Me.lblConvertedInput = New System.Windows.Forms.Label()
        Me.lblConvertedMetric = New System.Windows.Forms.Label()
        Me.lblFromMetric = New System.Windows.Forms.Label()
        Me.pnlStart.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnWeight
        '
        Me.btnWeight.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnWeight.Location = New System.Drawing.Point(59, 27)
        Me.btnWeight.Name = "btnWeight"
        Me.btnWeight.Size = New System.Drawing.Size(135, 59)
        Me.btnWeight.TabIndex = 9
        Me.btnWeight.Text = "Weight"
        Me.btnWeight.UseVisualStyleBackColor = False
        '
        'btnCurrency
        '
        Me.btnCurrency.BackColor = System.Drawing.Color.Green
        Me.btnCurrency.Location = New System.Drawing.Point(409, 27)
        Me.btnCurrency.Name = "btnCurrency"
        Me.btnCurrency.Size = New System.Drawing.Size(135, 59)
        Me.btnCurrency.TabIndex = 10
        Me.btnCurrency.Text = "Currency"
        Me.btnCurrency.UseVisualStyleBackColor = False
        '
        'btnVolume
        '
        Me.btnVolume.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnVolume.Location = New System.Drawing.Point(235, 27)
        Me.btnVolume.Name = "btnVolume"
        Me.btnVolume.Size = New System.Drawing.Size(135, 59)
        Me.btnVolume.TabIndex = 11
        Me.btnVolume.Text = "Volume"
        Me.btnVolume.UseVisualStyleBackColor = False
        '
        'btnDistance
        '
        Me.btnDistance.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnDistance.Location = New System.Drawing.Point(584, 27)
        Me.btnDistance.Name = "btnDistance"
        Me.btnDistance.Size = New System.Drawing.Size(135, 59)
        Me.btnDistance.TabIndex = 12
        Me.btnDistance.Text = "Distance"
        Me.btnDistance.UseVisualStyleBackColor = False
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtInput.Location = New System.Drawing.Point(235, 100)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(59, 33)
        Me.txtInput.TabIndex = 13
        '
        'pnlStart
        '
        Me.pnlStart.BackColor = System.Drawing.Color.White
        Me.pnlStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlStart.Controls.Add(Me.lblTo)
        Me.pnlStart.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStart.Location = New System.Drawing.Point(0, 143)
        Me.pnlStart.Name = "pnlStart"
        Me.pnlStart.Size = New System.Drawing.Size(800, 307)
        Me.pnlStart.TabIndex = 17
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(341, 134)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(116, 17)
        Me.lblTo.TabIndex = 8
        Me.lblTo.Text = "SELECT METRIC"
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.Blue
        Me.btnConvert.ForeColor = System.Drawing.Color.White
        Me.btnConvert.Location = New System.Drawing.Point(604, 100)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(103, 33)
        Me.btnConvert.TabIndex = 18
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'lblEquals
        '
        Me.lblEquals.AutoSize = True
        Me.lblEquals.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!)
        Me.lblEquals.ForeColor = System.Drawing.Color.White
        Me.lblEquals.Location = New System.Drawing.Point(367, 101)
        Me.lblEquals.Name = "lblEquals"
        Me.lblEquals.Size = New System.Drawing.Size(36, 37)
        Me.lblEquals.TabIndex = 19
        Me.lblEquals.Text = "="
        '
        'lblConvertedInput
        '
        Me.lblConvertedInput.AutoSize = True
        Me.lblConvertedInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblConvertedInput.ForeColor = System.Drawing.Color.White
        Me.lblConvertedInput.Location = New System.Drawing.Point(409, 105)
        Me.lblConvertedInput.Name = "lblConvertedInput"
        Me.lblConvertedInput.Size = New System.Drawing.Size(23, 25)
        Me.lblConvertedInput.TabIndex = 20
        Me.lblConvertedInput.Text = "0"
        '
        'lblConvertedMetric
        '
        Me.lblConvertedMetric.AutoSize = True
        Me.lblConvertedMetric.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblConvertedMetric.ForeColor = System.Drawing.Color.White
        Me.lblConvertedMetric.Location = New System.Drawing.Point(468, 105)
        Me.lblConvertedMetric.Name = "lblConvertedMetric"
        Me.lblConvertedMetric.Size = New System.Drawing.Size(56, 25)
        Me.lblConvertedMetric.TabIndex = 21
        Me.lblConvertedMetric.Text = "____"
        '
        'lblFromMetric
        '
        Me.lblFromMetric.AutoSize = True
        Me.lblFromMetric.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblFromMetric.ForeColor = System.Drawing.Color.White
        Me.lblFromMetric.Location = New System.Drawing.Point(300, 105)
        Me.lblFromMetric.Name = "lblFromMetric"
        Me.lblFromMetric.Size = New System.Drawing.Size(67, 25)
        Me.lblFromMetric.TabIndex = 22
        Me.lblFromMetric.Text = "_____"
        '
        'Conversion_Calculator
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblFromMetric)
        Me.Controls.Add(Me.lblConvertedMetric)
        Me.Controls.Add(Me.lblConvertedInput)
        Me.Controls.Add(Me.lblEquals)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.pnlStart)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnDistance)
        Me.Controls.Add(Me.btnVolume)
        Me.Controls.Add(Me.btnCurrency)
        Me.Controls.Add(Me.btnWeight)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(818, 497)
        Me.MinimumSize = New System.Drawing.Size(818, 497)
        Me.Name = "Conversion_Calculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.pnlStart.ResumeLayout(False)
        Me.pnlStart.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnWeight As Button
    Friend WithEvents btnCurrency As Button
    Friend WithEvents btnVolume As Button
    Friend WithEvents btnDistance As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents pnlStart As Panel
    Friend WithEvents lblTo As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents lblEquals As Label
    Friend WithEvents lblConvertedInput As Label
    Friend WithEvents lblConvertedMetric As Label
    Friend WithEvents lblFromMetric As Label
End Class
