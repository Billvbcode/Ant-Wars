<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnts
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAnts))
        Me.pAnt1 = New System.Windows.Forms.PictureBox()
        Me.pAnt2 = New System.Windows.Forms.PictureBox()
        Me.pAnt3 = New System.Windows.Forms.PictureBox()
        Me.pAnt4 = New System.Windows.Forms.PictureBox()
        Me.pAnt5 = New System.Windows.Forms.PictureBox()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.TimMove = New System.Windows.Forms.Timer(Me.components)
        Me.LblWin = New System.Windows.Forms.Label()
        CType(Me.pAnt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pAnt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pAnt3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pAnt4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pAnt5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pAnt1
        '
        Me.pAnt1.Image = CType(resources.GetObject("pAnt1.Image"), System.Drawing.Image)
        Me.pAnt1.Location = New System.Drawing.Point(44, 289)
        Me.pAnt1.Name = "pAnt1"
        Me.pAnt1.Size = New System.Drawing.Size(84, 125)
        Me.pAnt1.TabIndex = 0
        Me.pAnt1.TabStop = False
        '
        'pAnt2
        '
        Me.pAnt2.Image = CType(resources.GetObject("pAnt2.Image"), System.Drawing.Image)
        Me.pAnt2.Location = New System.Drawing.Point(180, 289)
        Me.pAnt2.Name = "pAnt2"
        Me.pAnt2.Size = New System.Drawing.Size(84, 125)
        Me.pAnt2.TabIndex = 1
        Me.pAnt2.TabStop = False
        '
        'pAnt3
        '
        Me.pAnt3.Image = CType(resources.GetObject("pAnt3.Image"), System.Drawing.Image)
        Me.pAnt3.Location = New System.Drawing.Point(492, 289)
        Me.pAnt3.Name = "pAnt3"
        Me.pAnt3.Size = New System.Drawing.Size(84, 125)
        Me.pAnt3.TabIndex = 2
        Me.pAnt3.TabStop = False
        '
        'pAnt4
        '
        Me.pAnt4.Image = CType(resources.GetObject("pAnt4.Image"), System.Drawing.Image)
        Me.pAnt4.Location = New System.Drawing.Point(322, 289)
        Me.pAnt4.Name = "pAnt4"
        Me.pAnt4.Size = New System.Drawing.Size(84, 125)
        Me.pAnt4.TabIndex = 3
        Me.pAnt4.TabStop = False
        '
        'pAnt5
        '
        Me.pAnt5.Image = CType(resources.GetObject("pAnt5.Image"), System.Drawing.Image)
        Me.pAnt5.Location = New System.Drawing.Point(662, 289)
        Me.pAnt5.Name = "pAnt5"
        Me.pAnt5.Size = New System.Drawing.Size(84, 125)
        Me.pAnt5.TabIndex = 4
        Me.pAnt5.TabStop = False
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(416, 424)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(75, 23)
        Me.BtnStart.TabIndex = 5
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'TimMove
        '
        '
        'LblWin
        '
        Me.LblWin.AutoSize = True
        Me.LblWin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWin.Location = New System.Drawing.Point(188, 46)
        Me.LblWin.Name = "LblWin"
        Me.LblWin.Size = New System.Drawing.Size(63, 20)
        Me.LblWin.TabIndex = 6
        Me.LblWin.Text = "Label1"
        Me.LblWin.Visible = False
        '
        'FrmAnts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblWin)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.pAnt5)
        Me.Controls.Add(Me.pAnt4)
        Me.Controls.Add(Me.pAnt3)
        Me.Controls.Add(Me.pAnt2)
        Me.Controls.Add(Me.pAnt1)
        Me.Name = "FrmAnts"
        Me.Text = "FrmAnts"
        CType(Me.pAnt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pAnt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pAnt3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pAnt4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pAnt5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pAnt1 As PictureBox
    Friend WithEvents pAnt2 As PictureBox
    Friend WithEvents pAnt3 As PictureBox
    Friend WithEvents pAnt4 As PictureBox
    Friend WithEvents pAnt5 As PictureBox
    Friend WithEvents BtnStart As Button
    Friend WithEvents TimMove As Timer
    Friend WithEvents LblWin As Label
End Class
