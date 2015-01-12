<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMDodgeCar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMDodgeCar))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LBLDummy = New System.Windows.Forms.Label()
        Me.LBLCarName = New System.Windows.Forms.Label()
        Me.BTNExit = New System.Windows.Forms.Button()
        Me.BTNPick = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXTTrade = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PIC1 = New System.Windows.Forms.PictureBox()
        Me.GBXFin = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LBLSumPay = New System.Windows.Forms.Label()
        Me.LBLMonPay = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BTNClearFin = New System.Windows.Forms.Button()
        Me.BTNClacFin = New System.Windows.Forms.Button()
        Me.CBOMonths = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.HSRate = New System.Windows.Forms.HScrollBar()
        Me.LBLRate = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GBXOptions = New System.Windows.Forms.GroupBox()
        Me.RADAuto = New System.Windows.Forms.RadioButton()
        Me.RADMan = New System.Windows.Forms.RadioButton()
        Me.BTNReset = New System.Windows.Forms.Button()
        Me.CHKPDI = New System.Windows.Forms.CheckBox()
        Me.CHKSeats = New System.Windows.Forms.CheckBox()
        Me.CHKSpoiler = New System.Windows.Forms.CheckBox()
        Me.CHKOil = New System.Windows.Forms.CheckBox()
        Me.CHKUSB = New System.Windows.Forms.CheckBox()
        Me.CHKPlay = New System.Windows.Forms.CheckBox()
        Me.CHKSun = New System.Windows.Forms.CheckBox()
        Me.CHKAir = New System.Windows.Forms.CheckBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GBXSummary = New System.Windows.Forms.GroupBox()
        Me.LBLTotal = New System.Windows.Forms.Label()
        Me.LBLPST = New System.Windows.Forms.Label()
        Me.LBLGST = New System.Windows.Forms.Label()
        Me.LBLSub = New System.Windows.Forms.Label()
        Me.LBLAir = New System.Windows.Forms.Label()
        Me.LBLTrade = New System.Windows.Forms.Label()
        Me.LBLOptions = New System.Windows.Forms.Label()
        Me.LBLBase = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PIC1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBXFin.SuspendLayout()
        Me.GBXOptions.SuspendLayout()
        Me.GBXSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Car_Project.My.Resources.Resources.DodgeLogo
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'LBLDummy
        '
        Me.LBLDummy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLDummy.Location = New System.Drawing.Point(581, 47)
        Me.LBLDummy.Name = "LBLDummy"
        Me.LBLDummy.Size = New System.Drawing.Size(85, 49)
        Me.LBLDummy.TabIndex = 33
        Me.LBLDummy.Visible = False
        '
        'LBLCarName
        '
        Me.LBLCarName.BackColor = System.Drawing.Color.Transparent
        Me.LBLCarName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCarName.ForeColor = System.Drawing.Color.Blue
        Me.LBLCarName.Location = New System.Drawing.Point(283, 220)
        Me.LBLCarName.Name = "LBLCarName"
        Me.LBLCarName.Size = New System.Drawing.Size(212, 22)
        Me.LBLCarName.TabIndex = 32
        Me.LBLCarName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BTNExit
        '
        Me.BTNExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNExit.Location = New System.Drawing.Point(399, 606)
        Me.BTNExit.Name = "BTNExit"
        Me.BTNExit.Size = New System.Drawing.Size(373, 45)
        Me.BTNExit.TabIndex = 31
        Me.BTNExit.Text = "Exit"
        Me.BTNExit.UseVisualStyleBackColor = True
        '
        'BTNPick
        '
        Me.BTNPick.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPick.Location = New System.Drawing.Point(12, 606)
        Me.BTNPick.Name = "BTNPick"
        Me.BTNPick.Size = New System.Drawing.Size(373, 45)
        Me.BTNPick.TabIndex = 30
        Me.BTNPick.Text = "Pick Another Car"
        Me.BTNPick.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXTTrade)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(246, 528)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 72)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Trade In"
        '
        'TXTTrade
        '
        Me.TXTTrade.Location = New System.Drawing.Point(200, 28)
        Me.TXTTrade.Name = "TXTTrade"
        Me.TXTTrade.Size = New System.Drawing.Size(77, 26)
        Me.TXTTrade.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(204, 27)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Estimated Trade In Value:"
        '
        'PIC1
        '
        Me.PIC1.Location = New System.Drawing.Point(15, 13)
        Me.PIC1.Name = "PIC1"
        Me.PIC1.Size = New System.Drawing.Size(760, 204)
        Me.PIC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PIC1.TabIndex = 28
        Me.PIC1.TabStop = False
        '
        'GBXFin
        '
        Me.GBXFin.Controls.Add(Me.Label14)
        Me.GBXFin.Controls.Add(Me.LBLSumPay)
        Me.GBXFin.Controls.Add(Me.LBLMonPay)
        Me.GBXFin.Controls.Add(Me.Label11)
        Me.GBXFin.Controls.Add(Me.BTNClearFin)
        Me.GBXFin.Controls.Add(Me.BTNClacFin)
        Me.GBXFin.Controls.Add(Me.CBOMonths)
        Me.GBXFin.Controls.Add(Me.Label10)
        Me.GBXFin.Controls.Add(Me.HSRate)
        Me.GBXFin.Controls.Add(Me.LBLRate)
        Me.GBXFin.Controls.Add(Me.Label9)
        Me.GBXFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBXFin.Location = New System.Drawing.Point(544, 235)
        Me.GBXFin.Name = "GBXFin"
        Me.GBXFin.Size = New System.Drawing.Size(228, 365)
        Me.GBXFin.TabIndex = 27
        Me.GBXFin.TabStop = False
        Me.GBXFin.Text = "Financing"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(50, 295)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(197, 27)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Sum Of Payments"
        '
        'LBLSumPay
        '
        Me.LBLSumPay.BackColor = System.Drawing.Color.White
        Me.LBLSumPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLSumPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSumPay.Location = New System.Drawing.Point(54, 322)
        Me.LBLSumPay.Name = "LBLSumPay"
        Me.LBLSumPay.Size = New System.Drawing.Size(119, 27)
        Me.LBLSumPay.TabIndex = 10
        '
        'LBLMonPay
        '
        Me.LBLMonPay.BackColor = System.Drawing.Color.White
        Me.LBLMonPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLMonPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMonPay.Location = New System.Drawing.Point(54, 259)
        Me.LBLMonPay.Name = "LBLMonPay"
        Me.LBLMonPay.Size = New System.Drawing.Size(119, 27)
        Me.LBLMonPay.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(50, 232)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(197, 27)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Monthly Payments"
        '
        'BTNClearFin
        '
        Me.BTNClearFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNClearFin.Location = New System.Drawing.Point(122, 168)
        Me.BTNClearFin.Name = "BTNClearFin"
        Me.BTNClearFin.Size = New System.Drawing.Size(90, 41)
        Me.BTNClearFin.TabIndex = 7
        Me.BTNClearFin.Text = "Reset"
        Me.BTNClearFin.UseVisualStyleBackColor = True
        '
        'BTNClacFin
        '
        Me.BTNClacFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNClacFin.Location = New System.Drawing.Point(19, 168)
        Me.BTNClacFin.Name = "BTNClacFin"
        Me.BTNClacFin.Size = New System.Drawing.Size(88, 41)
        Me.BTNClacFin.TabIndex = 6
        Me.BTNClacFin.Text = "Calculate"
        Me.BTNClacFin.UseVisualStyleBackColor = True
        '
        'CBOMonths
        '
        Me.CBOMonths.FormattingEnabled = True
        Me.CBOMonths.Items.AddRange(New Object() {"12", "24", "36", "48", "60", "72"})
        Me.CBOMonths.Location = New System.Drawing.Point(93, 116)
        Me.CBOMonths.Name = "CBOMonths"
        Me.CBOMonths.Size = New System.Drawing.Size(119, 28)
        Me.CBOMonths.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 27)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Months"
        '
        'HSRate
        '
        Me.HSRate.LargeChange = 1
        Me.HSRate.Location = New System.Drawing.Point(19, 66)
        Me.HSRate.Maximum = 50
        Me.HSRate.Name = "HSRate"
        Me.HSRate.Size = New System.Drawing.Size(193, 17)
        Me.HSRate.TabIndex = 3
        '
        'LBLRate
        '
        Me.LBLRate.BackColor = System.Drawing.Color.White
        Me.LBLRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLRate.Location = New System.Drawing.Point(93, 27)
        Me.LBLRate.Name = "LBLRate"
        Me.LBLRate.Size = New System.Drawing.Size(119, 27)
        Me.LBLRate.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 27)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Rate %"
        '
        'GBXOptions
        '
        Me.GBXOptions.Controls.Add(Me.RADAuto)
        Me.GBXOptions.Controls.Add(Me.RADMan)
        Me.GBXOptions.Controls.Add(Me.BTNReset)
        Me.GBXOptions.Controls.Add(Me.CHKPDI)
        Me.GBXOptions.Controls.Add(Me.CHKSeats)
        Me.GBXOptions.Controls.Add(Me.CHKSpoiler)
        Me.GBXOptions.Controls.Add(Me.CHKOil)
        Me.GBXOptions.Controls.Add(Me.CHKUSB)
        Me.GBXOptions.Controls.Add(Me.CHKPlay)
        Me.GBXOptions.Controls.Add(Me.CHKSun)
        Me.GBXOptions.Controls.Add(Me.CHKAir)
        Me.GBXOptions.Controls.Add(Me.ShapeContainer2)
        Me.GBXOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBXOptions.Location = New System.Drawing.Point(278, 245)
        Me.GBXOptions.Name = "GBXOptions"
        Me.GBXOptions.Size = New System.Drawing.Size(228, 276)
        Me.GBXOptions.TabIndex = 26
        Me.GBXOptions.TabStop = False
        Me.GBXOptions.Text = "Options"
        '
        'RADAuto
        '
        Me.RADAuto.AutoSize = True
        Me.RADAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RADAuto.Location = New System.Drawing.Point(18, 27)
        Me.RADAuto.Name = "RADAuto"
        Me.RADAuto.Size = New System.Drawing.Size(175, 17)
        Me.RADAuto.TabIndex = 22
        Me.RADAuto.Text = "Transmission - Automatic $1150"
        Me.RADAuto.UseVisualStyleBackColor = True
        '
        'RADMan
        '
        Me.RADMan.AutoSize = True
        Me.RADMan.Checked = True
        Me.RADMan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RADMan.Location = New System.Drawing.Point(18, 50)
        Me.RADMan.Name = "RADMan"
        Me.RADMan.Size = New System.Drawing.Size(145, 17)
        Me.RADMan.TabIndex = 21
        Me.RADMan.TabStop = True
        Me.RADMan.Text = "Transmission - Manuel $0"
        Me.RADMan.UseVisualStyleBackColor = True
        '
        'BTNReset
        '
        Me.BTNReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNReset.Location = New System.Drawing.Point(147, 247)
        Me.BTNReset.Name = "BTNReset"
        Me.BTNReset.Size = New System.Drawing.Size(75, 23)
        Me.BTNReset.TabIndex = 20
        Me.BTNReset.Text = "Reset"
        Me.BTNReset.UseVisualStyleBackColor = True
        '
        'CHKPDI
        '
        Me.CHKPDI.AutoSize = True
        Me.CHKPDI.Checked = True
        Me.CHKPDI.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKPDI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKPDI.Location = New System.Drawing.Point(18, 242)
        Me.CHKPDI.Name = "CHKPDI"
        Me.CHKPDI.Size = New System.Drawing.Size(71, 17)
        Me.CHKPDI.TabIndex = 19
        Me.CHKPDI.Text = "PDI $975"
        Me.CHKPDI.UseVisualStyleBackColor = True
        '
        'CHKSeats
        '
        Me.CHKSeats.AutoSize = True
        Me.CHKSeats.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKSeats.Location = New System.Drawing.Point(18, 219)
        Me.CHKSeats.Name = "CHKSeats"
        Me.CHKSeats.Size = New System.Drawing.Size(182, 17)
        Me.CHKSeats.TabIndex = 18
        Me.CHKSeats.Text = "Heated Front Bucket Seats $250"
        Me.CHKSeats.UseVisualStyleBackColor = True
        '
        'CHKSpoiler
        '
        Me.CHKSpoiler.AutoSize = True
        Me.CHKSpoiler.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKSpoiler.Location = New System.Drawing.Point(18, 196)
        Me.CHKSpoiler.Name = "CHKSpoiler"
        Me.CHKSpoiler.Size = New System.Drawing.Size(161, 17)
        Me.CHKSpoiler.TabIndex = 17
        Me.CHKSpoiler.Text = "Trunk Mounted Spoiler $295"
        Me.CHKSpoiler.UseVisualStyleBackColor = True
        '
        'CHKOil
        '
        Me.CHKOil.AutoSize = True
        Me.CHKOil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKOil.Location = New System.Drawing.Point(18, 173)
        Me.CHKOil.Name = "CHKOil"
        Me.CHKOil.Size = New System.Drawing.Size(122, 17)
        Me.CHKOil.TabIndex = 16
        Me.CHKOil.Text = "Oil Pan Heater $100"
        Me.CHKOil.UseVisualStyleBackColor = True
        '
        'CHKUSB
        '
        Me.CHKUSB.AutoSize = True
        Me.CHKUSB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKUSB.Location = New System.Drawing.Point(18, 150)
        Me.CHKUSB.Name = "CHKUSB"
        Me.CHKUSB.Size = New System.Drawing.Size(97, 17)
        Me.CHKUSB.TabIndex = 15
        Me.CHKUSB.Text = "USB Port $150"
        Me.CHKUSB.UseVisualStyleBackColor = True
        '
        'CHKPlay
        '
        Me.CHKPlay.AutoSize = True
        Me.CHKPlay.Checked = True
        Me.CHKPlay.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKPlay.Location = New System.Drawing.Point(18, 127)
        Me.CHKPlay.Name = "CHKPlay"
        Me.CHKPlay.Size = New System.Drawing.Size(138, 17)
        Me.CHKPlay.TabIndex = 14
        Me.CHKPlay.Text = "CD/MP3 Playback Incl."
        Me.CHKPlay.UseVisualStyleBackColor = True
        '
        'CHKSun
        '
        Me.CHKSun.AutoSize = True
        Me.CHKSun.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKSun.Location = New System.Drawing.Point(18, 104)
        Me.CHKSun.Name = "CHKSun"
        Me.CHKSun.Size = New System.Drawing.Size(90, 17)
        Me.CHKSun.TabIndex = 13
        Me.CHKSun.Text = "Sunroof $985"
        Me.CHKSun.UseVisualStyleBackColor = True
        '
        'CHKAir
        '
        Me.CHKAir.AutoSize = True
        Me.CHKAir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKAir.Location = New System.Drawing.Point(18, 81)
        Me.CHKAir.Name = "CHKAir"
        Me.CHKAir.Size = New System.Drawing.Size(132, 17)
        Me.CHKAir.TabIndex = 12
        Me.CHKAir.Text = "Air Conditioning $1150"
        Me.CHKAir.UseVisualStyleBackColor = True
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 22)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3})
        Me.ShapeContainer2.Size = New System.Drawing.Size(222, 251)
        Me.ShapeContainer2.TabIndex = 23
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.Blue
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 21
        Me.LineShape3.X2 = 202
        Me.LineShape3.Y1 = 52
        Me.LineShape3.Y2 = 52
        '
        'GBXSummary
        '
        Me.GBXSummary.Controls.Add(Me.LBLTotal)
        Me.GBXSummary.Controls.Add(Me.LBLPST)
        Me.GBXSummary.Controls.Add(Me.LBLGST)
        Me.GBXSummary.Controls.Add(Me.LBLSub)
        Me.GBXSummary.Controls.Add(Me.LBLAir)
        Me.GBXSummary.Controls.Add(Me.LBLTrade)
        Me.GBXSummary.Controls.Add(Me.LBLOptions)
        Me.GBXSummary.Controls.Add(Me.LBLBase)
        Me.GBXSummary.Controls.Add(Me.Label8)
        Me.GBXSummary.Controls.Add(Me.Label7)
        Me.GBXSummary.Controls.Add(Me.Label6)
        Me.GBXSummary.Controls.Add(Me.Label5)
        Me.GBXSummary.Controls.Add(Me.Label4)
        Me.GBXSummary.Controls.Add(Me.Label3)
        Me.GBXSummary.Controls.Add(Me.Label2)
        Me.GBXSummary.Controls.Add(Me.Label1)
        Me.GBXSummary.Controls.Add(Me.ShapeContainer1)
        Me.GBXSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBXSummary.Location = New System.Drawing.Point(12, 235)
        Me.GBXSummary.Name = "GBXSummary"
        Me.GBXSummary.Size = New System.Drawing.Size(228, 365)
        Me.GBXSummary.TabIndex = 25
        Me.GBXSummary.TabStop = False
        Me.GBXSummary.Text = "Summary"
        '
        'LBLTotal
        '
        Me.LBLTotal.BackColor = System.Drawing.Color.White
        Me.LBLTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTotal.Location = New System.Drawing.Point(124, 322)
        Me.LBLTotal.Name = "LBLTotal"
        Me.LBLTotal.Size = New System.Drawing.Size(91, 27)
        Me.LBLTotal.TabIndex = 15
        '
        'LBLPST
        '
        Me.LBLPST.BackColor = System.Drawing.Color.White
        Me.LBLPST.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLPST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPST.Location = New System.Drawing.Point(123, 264)
        Me.LBLPST.Name = "LBLPST"
        Me.LBLPST.Size = New System.Drawing.Size(91, 27)
        Me.LBLPST.TabIndex = 14
        '
        'LBLGST
        '
        Me.LBLGST.BackColor = System.Drawing.Color.White
        Me.LBLGST.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLGST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLGST.Location = New System.Drawing.Point(123, 232)
        Me.LBLGST.Name = "LBLGST"
        Me.LBLGST.Size = New System.Drawing.Size(91, 27)
        Me.LBLGST.TabIndex = 13
        '
        'LBLSub
        '
        Me.LBLSub.BackColor = System.Drawing.Color.White
        Me.LBLSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSub.Location = New System.Drawing.Point(123, 199)
        Me.LBLSub.Name = "LBLSub"
        Me.LBLSub.Size = New System.Drawing.Size(91, 27)
        Me.LBLSub.TabIndex = 12
        '
        'LBLAir
        '
        Me.LBLAir.BackColor = System.Drawing.Color.White
        Me.LBLAir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLAir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLAir.Location = New System.Drawing.Point(122, 137)
        Me.LBLAir.Name = "LBLAir"
        Me.LBLAir.Size = New System.Drawing.Size(91, 27)
        Me.LBLAir.TabIndex = 11
        '
        'LBLTrade
        '
        Me.LBLTrade.BackColor = System.Drawing.Color.White
        Me.LBLTrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTrade.Location = New System.Drawing.Point(122, 101)
        Me.LBLTrade.Name = "LBLTrade"
        Me.LBLTrade.Size = New System.Drawing.Size(91, 27)
        Me.LBLTrade.TabIndex = 10
        '
        'LBLOptions
        '
        Me.LBLOptions.BackColor = System.Drawing.Color.White
        Me.LBLOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLOptions.Location = New System.Drawing.Point(122, 68)
        Me.LBLOptions.Name = "LBLOptions"
        Me.LBLOptions.Size = New System.Drawing.Size(91, 27)
        Me.LBLOptions.TabIndex = 9
        '
        'LBLBase
        '
        Me.LBLBase.BackColor = System.Drawing.Color.White
        Me.LBLBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBase.Location = New System.Drawing.Point(122, 35)
        Me.LBLBase.Name = "LBLBase"
        Me.LBLBase.Size = New System.Drawing.Size(91, 27)
        Me.LBLBase.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 322)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 27)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 27)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "PST (8%):"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 27)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "GST (7%):"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 27)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Subtotal:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Air Con. Tax:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Trade In:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Options:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Base Price:"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 22)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(222, 340)
        Me.ShapeContainer1.TabIndex = 16
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Blue
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 18
        Me.LineShape2.X2 = 211
        Me.LineShape2.Y1 = 284
        Me.LineShape2.Y2 = 284
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Blue
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 19
        Me.LineShape1.X2 = 208
        Me.LineShape1.Y1 = 157
        Me.LineShape1.Y2 = 157
        '
        'FRMDodgeCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Car_Project.My.Resources.Resources.open_road11
        Me.ClientSize = New System.Drawing.Size(784, 662)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LBLDummy)
        Me.Controls.Add(Me.LBLCarName)
        Me.Controls.Add(Me.BTNExit)
        Me.Controls.Add(Me.BTNPick)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PIC1)
        Me.Controls.Add(Me.GBXFin)
        Me.Controls.Add(Me.GBXOptions)
        Me.Controls.Add(Me.GBXSummary)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMDodgeCar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DodgeCar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PIC1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBXFin.ResumeLayout(False)
        Me.GBXOptions.ResumeLayout(False)
        Me.GBXOptions.PerformLayout()
        Me.GBXSummary.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LBLDummy As System.Windows.Forms.Label
    Public WithEvents LBLCarName As System.Windows.Forms.Label
    Friend WithEvents BTNExit As System.Windows.Forms.Button
    Friend WithEvents BTNPick As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TXTTrade As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PIC1 As System.Windows.Forms.PictureBox
    Friend WithEvents GBXFin As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LBLSumPay As System.Windows.Forms.Label
    Friend WithEvents LBLMonPay As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BTNClearFin As System.Windows.Forms.Button
    Friend WithEvents BTNClacFin As System.Windows.Forms.Button
    Friend WithEvents CBOMonths As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents HSRate As System.Windows.Forms.HScrollBar
    Friend WithEvents LBLRate As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GBXOptions As System.Windows.Forms.GroupBox
    Friend WithEvents RADAuto As System.Windows.Forms.RadioButton
    Friend WithEvents RADMan As System.Windows.Forms.RadioButton
    Friend WithEvents BTNReset As System.Windows.Forms.Button
    Friend WithEvents CHKPDI As System.Windows.Forms.CheckBox
    Friend WithEvents CHKSeats As System.Windows.Forms.CheckBox
    Friend WithEvents CHKSpoiler As System.Windows.Forms.CheckBox
    Friend WithEvents CHKOil As System.Windows.Forms.CheckBox
    Friend WithEvents CHKUSB As System.Windows.Forms.CheckBox
    Friend WithEvents CHKPlay As System.Windows.Forms.CheckBox
    Friend WithEvents CHKSun As System.Windows.Forms.CheckBox
    Friend WithEvents CHKAir As System.Windows.Forms.CheckBox
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents GBXSummary As System.Windows.Forms.GroupBox
    Friend WithEvents LBLTotal As System.Windows.Forms.Label
    Friend WithEvents LBLPST As System.Windows.Forms.Label
    Friend WithEvents LBLGST As System.Windows.Forms.Label
    Friend WithEvents LBLSub As System.Windows.Forms.Label
    Friend WithEvents LBLAir As System.Windows.Forms.Label
    Friend WithEvents LBLTrade As System.Windows.Forms.Label
    Friend WithEvents LBLOptions As System.Windows.Forms.Label
    Friend WithEvents LBLBase As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
