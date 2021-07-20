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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.chrtData = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumBins = New System.Windows.Forms.TextBox()
        Me.txtIterations = New System.Windows.Forms.TextBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpBoxNormalPV = New System.Windows.Forms.GroupBox()
        Me.txtStndDevPv = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMeanPv = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpBoxUniformN = New System.Windows.Forms.GroupBox()
        Me.txtMinN = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMaxN = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblOutputAvg = New System.Windows.Forms.Label()
        Me.radUniformPv = New System.Windows.Forms.RadioButton()
        Me.radNormalPv = New System.Windows.Forms.RadioButton()
        Me.DistSelect = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radNormalN = New System.Windows.Forms.RadioButton()
        Me.radUniformN = New System.Windows.Forms.RadioButton()
        Me.grpBoxNormalN = New System.Windows.Forms.GroupBox()
        Me.txtStndDevN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMeanN = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grpBoxUniformPv = New System.Windows.Forms.GroupBox()
        Me.txtMinPv = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMaxPV = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.chrtData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoxNormalPV.SuspendLayout()
        Me.grpBoxUniformN.SuspendLayout()
        Me.DistSelect.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpBoxNormalN.SuspendLayout()
        Me.grpBoxUniformPv.SuspendLayout()
        Me.SuspendLayout()
        '
        'chrtData
        '
        ChartArea2.Name = "ChartArea1"
        Me.chrtData.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chrtData.Legends.Add(Legend2)
        Me.chrtData.Location = New System.Drawing.Point(96, 70)
        Me.chrtData.Name = "chrtData"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chrtData.Series.Add(Series2)
        Me.chrtData.Size = New System.Drawing.Size(1060, 451)
        Me.chrtData.TabIndex = 0
        Me.chrtData.Text = "Chart1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 576)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Number of Bins"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(484, 576)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 32)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Iterations"
        '
        'txtNumBins
        '
        Me.txtNumBins.Location = New System.Drawing.Point(313, 576)
        Me.txtNumBins.Name = "txtNumBins"
        Me.txtNumBins.Size = New System.Drawing.Size(100, 38)
        Me.txtNumBins.TabIndex = 4
        '
        'txtIterations
        '
        Me.txtIterations.Location = New System.Drawing.Point(651, 573)
        Me.txtIterations.Name = "txtIterations"
        Me.txtIterations.Size = New System.Drawing.Size(100, 38)
        Me.txtIterations.TabIndex = 5
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(1348, 338)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(137, 54)
        Me.btnRun.TabIndex = 6
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1765, 38)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(137, 54)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpBoxNormalPV
        '
        Me.grpBoxNormalPV.Controls.Add(Me.txtStndDevPv)
        Me.grpBoxNormalPV.Controls.Add(Me.Label5)
        Me.grpBoxNormalPV.Controls.Add(Me.txtMeanPv)
        Me.grpBoxNormalPV.Controls.Add(Me.Label4)
        Me.grpBoxNormalPV.Location = New System.Drawing.Point(260, 812)
        Me.grpBoxNormalPV.Name = "grpBoxNormalPV"
        Me.grpBoxNormalPV.Size = New System.Drawing.Size(491, 262)
        Me.grpBoxNormalPV.TabIndex = 11
        Me.grpBoxNormalPV.TabStop = False
        Me.grpBoxNormalPV.Text = "Pv - Profit Per Vehicle"
        '
        'txtStndDevPv
        '
        Me.txtStndDevPv.Location = New System.Drawing.Point(329, 181)
        Me.txtStndDevPv.Name = "txtStndDevPv"
        Me.txtStndDevPv.Size = New System.Drawing.Size(100, 38)
        Me.txtStndDevPv.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(266, 32)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Standard Deviation:"
        '
        'txtMeanPv
        '
        Me.txtMeanPv.Location = New System.Drawing.Point(329, 67)
        Me.txtMeanPv.Name = "txtMeanPv"
        Me.txtMeanPv.Size = New System.Drawing.Size(100, 38)
        Me.txtMeanPv.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 32)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Mean:"
        '
        'grpBoxUniformN
        '
        Me.grpBoxUniformN.Controls.Add(Me.txtMinN)
        Me.grpBoxUniformN.Controls.Add(Me.Label6)
        Me.grpBoxUniformN.Controls.Add(Me.txtMaxN)
        Me.grpBoxUniformN.Controls.Add(Me.Label7)
        Me.grpBoxUniformN.Location = New System.Drawing.Point(1112, 812)
        Me.grpBoxUniformN.Name = "grpBoxUniformN"
        Me.grpBoxUniformN.Size = New System.Drawing.Size(488, 262)
        Me.grpBoxUniformN.TabIndex = 12
        Me.grpBoxUniformN.TabStop = False
        Me.grpBoxUniformN.Text = "N - Number of Vehicles (Uniform) "
        '
        'txtMinN
        '
        Me.txtMinN.Location = New System.Drawing.Point(311, 146)
        Me.txtMinN.Name = "txtMinN"
        Me.txtMinN.Size = New System.Drawing.Size(100, 38)
        Me.txtMinN.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 32)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Min:"
        '
        'txtMaxN
        '
        Me.txtMaxN.Location = New System.Drawing.Point(311, 47)
        Me.txtMaxN.Name = "txtMaxN"
        Me.txtMaxN.Size = New System.Drawing.Size(100, 38)
        Me.txtMaxN.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 32)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Max:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1311, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(195, 32)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Average Profit"
        '
        'lblOutputAvg
        '
        Me.lblOutputAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputAvg.Location = New System.Drawing.Point(1284, 217)
        Me.lblOutputAvg.Name = "lblOutputAvg"
        Me.lblOutputAvg.Size = New System.Drawing.Size(253, 56)
        Me.lblOutputAvg.TabIndex = 14
        '
        'radUniformPv
        '
        Me.radUniformPv.AutoSize = True
        Me.radUniformPv.Location = New System.Drawing.Point(17, 37)
        Me.radUniformPv.Name = "radUniformPv"
        Me.radUniformPv.Size = New System.Drawing.Size(151, 36)
        Me.radUniformPv.TabIndex = 15
        Me.radUniformPv.TabStop = True
        Me.radUniformPv.Text = "Uniform"
        Me.radUniformPv.UseVisualStyleBackColor = True
        '
        'radNormalPv
        '
        Me.radNormalPv.AutoSize = True
        Me.radNormalPv.Location = New System.Drawing.Point(17, 79)
        Me.radNormalPv.Name = "radNormalPv"
        Me.radNormalPv.Size = New System.Drawing.Size(143, 36)
        Me.radNormalPv.TabIndex = 17
        Me.radNormalPv.TabStop = True
        Me.radNormalPv.Text = "Normal"
        Me.radNormalPv.UseVisualStyleBackColor = True
        '
        'DistSelect
        '
        Me.DistSelect.Controls.Add(Me.radNormalPv)
        Me.DistSelect.Controls.Add(Me.radUniformPv)
        Me.DistSelect.Location = New System.Drawing.Point(297, 661)
        Me.DistSelect.Name = "DistSelect"
        Me.DistSelect.Size = New System.Drawing.Size(434, 132)
        Me.DistSelect.TabIndex = 4
        Me.DistSelect.TabStop = False
        Me.DistSelect.Text = "Pv - Distribution Selection"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radNormalN)
        Me.GroupBox1.Controls.Add(Me.radUniformN)
        Me.GroupBox1.Location = New System.Drawing.Point(1141, 661)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 132)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "N - Distribution Selection"
        '
        'radNormalN
        '
        Me.radNormalN.AutoSize = True
        Me.radNormalN.Location = New System.Drawing.Point(17, 79)
        Me.radNormalN.Name = "radNormalN"
        Me.radNormalN.Size = New System.Drawing.Size(143, 36)
        Me.radNormalN.TabIndex = 17
        Me.radNormalN.TabStop = True
        Me.radNormalN.Text = "Normal"
        Me.radNormalN.UseVisualStyleBackColor = True
        '
        'radUniformN
        '
        Me.radUniformN.AutoSize = True
        Me.radUniformN.Location = New System.Drawing.Point(17, 37)
        Me.radUniformN.Name = "radUniformN"
        Me.radUniformN.Size = New System.Drawing.Size(151, 36)
        Me.radUniformN.TabIndex = 15
        Me.radUniformN.TabStop = True
        Me.radUniformN.Text = "Uniform"
        Me.radUniformN.UseVisualStyleBackColor = True
        '
        'grpBoxNormalN
        '
        Me.grpBoxNormalN.Controls.Add(Me.txtStndDevN)
        Me.grpBoxNormalN.Controls.Add(Me.Label2)
        Me.grpBoxNormalN.Controls.Add(Me.txtMeanN)
        Me.grpBoxNormalN.Controls.Add(Me.Label9)
        Me.grpBoxNormalN.Location = New System.Drawing.Point(1103, 812)
        Me.grpBoxNormalN.Name = "grpBoxNormalN"
        Me.grpBoxNormalN.Size = New System.Drawing.Size(491, 262)
        Me.grpBoxNormalN.TabIndex = 12
        Me.grpBoxNormalN.TabStop = False
        Me.grpBoxNormalN.Text = "N - Number of Vehicles (Normal)"
        '
        'txtStndDevN
        '
        Me.txtStndDevN.Location = New System.Drawing.Point(329, 181)
        Me.txtStndDevN.Name = "txtStndDevN"
        Me.txtStndDevN.Size = New System.Drawing.Size(100, 38)
        Me.txtStndDevN.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Standard Deviation:"
        '
        'txtMeanN
        '
        Me.txtMeanN.Location = New System.Drawing.Point(329, 67)
        Me.txtMeanN.Name = "txtMeanN"
        Me.txtMeanN.Size = New System.Drawing.Size(100, 38)
        Me.txtMeanN.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(47, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 32)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Mean:"
        '
        'grpBoxUniformPv
        '
        Me.grpBoxUniformPv.Controls.Add(Me.txtMinPv)
        Me.grpBoxUniformPv.Controls.Add(Me.Label10)
        Me.grpBoxUniformPv.Controls.Add(Me.txtMaxPV)
        Me.grpBoxUniformPv.Controls.Add(Me.Label11)
        Me.grpBoxUniformPv.Location = New System.Drawing.Point(260, 812)
        Me.grpBoxUniformPv.Name = "grpBoxUniformPv"
        Me.grpBoxUniformPv.Size = New System.Drawing.Size(488, 262)
        Me.grpBoxUniformPv.TabIndex = 13
        Me.grpBoxUniformPv.TabStop = False
        Me.grpBoxUniformPv.Text = "Pv - Profit Per Vehicle (Uniform) "
        '
        'txtMinPv
        '
        Me.txtMinPv.Location = New System.Drawing.Point(311, 146)
        Me.txtMinPv.Name = "txtMinPv"
        Me.txtMinPv.Size = New System.Drawing.Size(100, 38)
        Me.txtMinPv.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 32)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Min:"
        '
        'txtMaxPV
        '
        Me.txtMaxPV.Location = New System.Drawing.Point(311, 47)
        Me.txtMaxPV.Name = "txtMaxPV"
        Me.txtMaxPV.Size = New System.Drawing.Size(100, 38)
        Me.txtMaxPV.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 32)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Max:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1940, 1181)
        Me.Controls.Add(Me.grpBoxUniformPv)
        Me.Controls.Add(Me.grpBoxNormalN)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DistSelect)
        Me.Controls.Add(Me.lblOutputAvg)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.grpBoxUniformN)
        Me.Controls.Add(Me.grpBoxNormalPV)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.txtIterations)
        Me.Controls.Add(Me.txtNumBins)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chrtData)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.chrtData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoxNormalPV.ResumeLayout(False)
        Me.grpBoxNormalPV.PerformLayout()
        Me.grpBoxUniformN.ResumeLayout(False)
        Me.grpBoxUniformN.PerformLayout()
        Me.DistSelect.ResumeLayout(False)
        Me.DistSelect.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpBoxNormalN.ResumeLayout(False)
        Me.grpBoxNormalN.PerformLayout()
        Me.grpBoxUniformPv.ResumeLayout(False)
        Me.grpBoxUniformPv.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chrtData As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumBins As TextBox
    Friend WithEvents txtIterations As TextBox
    Friend WithEvents btnRun As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpBoxNormalPV As GroupBox
    Friend WithEvents txtStndDevPv As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMeanPv As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents grpBoxUniformN As GroupBox
    Friend WithEvents txtMinN As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMaxN As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblOutputAvg As Label
    Friend WithEvents radUniformPv As RadioButton
    Friend WithEvents radNormalPv As RadioButton
    Friend WithEvents DistSelect As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radNormalN As RadioButton
    Friend WithEvents radUniformN As RadioButton
    Friend WithEvents grpBoxNormalN As GroupBox
    Friend WithEvents txtStndDevN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMeanN As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents grpBoxUniformPv As GroupBox
    Friend WithEvents txtMinPv As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMaxPV As TextBox
    Friend WithEvents Label11 As Label
End Class
