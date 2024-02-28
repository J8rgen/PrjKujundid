<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formKujundid
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKylgB = New System.Windows.Forms.TextBox()
        Me.txtKylgA = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRistkylik = New System.Windows.Forms.Button()
        Me.btnRuut = New System.Windows.Forms.Button()
        Me.btnKolmnurk = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTyyp = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPindala = New System.Windows.Forms.TextBox()
        Me.txtYmbermoot = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtKylgB)
        Me.GroupBox1.Controls.Add(Me.txtKylgA)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Algandmed"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "b ="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "a ="
        '
        'txtKylgB
        '
        Me.txtKylgB.Location = New System.Drawing.Point(81, 58)
        Me.txtKylgB.Name = "txtKylgB"
        Me.txtKylgB.Size = New System.Drawing.Size(100, 20)
        Me.txtKylgB.TabIndex = 1
        '
        'txtKylgA
        '
        Me.txtKylgA.Location = New System.Drawing.Point(81, 32)
        Me.txtKylgA.Name = "txtKylgA"
        Me.txtKylgA.Size = New System.Drawing.Size(100, 20)
        Me.txtKylgA.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRistkylik)
        Me.GroupBox2.Controls.Add(Me.btnRuut)
        Me.GroupBox2.Controls.Add(Me.btnKolmnurk)
        Me.GroupBox2.Location = New System.Drawing.Point(237, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 271)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kujundid"
        '
        'btnRistkylik
        '
        Me.btnRistkylik.Location = New System.Drawing.Point(106, 78)
        Me.btnRistkylik.Name = "btnRistkylik"
        Me.btnRistkylik.Size = New System.Drawing.Size(75, 23)
        Me.btnRistkylik.TabIndex = 2
        Me.btnRistkylik.Text = "Ristkülik"
        Me.btnRistkylik.UseVisualStyleBackColor = True
        '
        'btnRuut
        '
        Me.btnRuut.Location = New System.Drawing.Point(106, 49)
        Me.btnRuut.Name = "btnRuut"
        Me.btnRuut.Size = New System.Drawing.Size(75, 23)
        Me.btnRuut.TabIndex = 1
        Me.btnRuut.Text = "Ruut"
        Me.btnRuut.UseVisualStyleBackColor = True
        '
        'btnKolmnurk
        '
        Me.btnKolmnurk.Location = New System.Drawing.Point(106, 19)
        Me.btnKolmnurk.Name = "btnKolmnurk"
        Me.btnKolmnurk.Size = New System.Drawing.Size(75, 23)
        Me.btnKolmnurk.TabIndex = 0
        Me.btnKolmnurk.Text = "Kolmnurk"
        Me.btnKolmnurk.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTyyp)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtPindala)
        Me.GroupBox3.Controls.Add(Me.txtYmbermoot)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 166)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 118)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tulemused"
        '
        'lblTyyp
        '
        Me.lblTyyp.AutoSize = True
        Me.lblTyyp.Location = New System.Drawing.Point(81, 33)
        Me.lblTyyp.Name = "lblTyyp"
        Me.lblTyyp.Size = New System.Drawing.Size(60, 13)
        Me.lblTyyp.TabIndex = 5
        Me.lblTyyp.Text = "Määramata"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "kujundi tüüp"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ümbermõõt"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pindala"
        '
        'txtPindala
        '
        Me.txtPindala.Location = New System.Drawing.Point(81, 82)
        Me.txtPindala.Name = "txtPindala"
        Me.txtPindala.Size = New System.Drawing.Size(100, 20)
        Me.txtPindala.TabIndex = 1
        '
        'txtYmbermoot
        '
        Me.txtYmbermoot.Location = New System.Drawing.Point(81, 56)
        Me.txtYmbermoot.Name = "txtYmbermoot"
        Me.txtYmbermoot.Size = New System.Drawing.Size(100, 20)
        Me.txtYmbermoot.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.ComboBox1.Location = New System.Drawing.Point(91, 118)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'formKujundid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 313)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formKujundid"
        Me.Text = "Kujundid"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtKylgB As TextBox
    Friend WithEvents txtKylgA As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblTyyp As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPindala As TextBox
    Friend WithEvents txtYmbermoot As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRistkylik As Button
    Friend WithEvents btnRuut As Button
    Friend WithEvents btnKolmnurk As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ComboBox1 As ComboBox
End Class
