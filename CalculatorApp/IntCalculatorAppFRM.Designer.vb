<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IntCalculatorAppFRM
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
        Me.AValueLBL = New System.Windows.Forms.Label()
        Me.BValueLBL = New System.Windows.Forms.Label()
        Me.aTBX = New System.Windows.Forms.TextBox()
        Me.bTBX = New System.Windows.Forms.TextBox()
        Me.addBTN = New System.Windows.Forms.Button()
        Me.divideBTN = New System.Windows.Forms.Button()
        Me.multiplyBTH = New System.Windows.Forms.Button()
        Me.minusBTN = New System.Windows.Forms.Button()
        Me.resultDescLBL = New System.Windows.Forms.Label()
        Me.outputLBL = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AValueLBL
        '
        Me.AValueLBL.AutoSize = True
        Me.AValueLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AValueLBL.Location = New System.Drawing.Point(22, 27)
        Me.AValueLBL.Name = "AValueLBL"
        Me.AValueLBL.Size = New System.Drawing.Size(65, 20)
        Me.AValueLBL.TabIndex = 5
        Me.AValueLBL.Text = "A value:"
        '
        'BValueLBL
        '
        Me.BValueLBL.AutoSize = True
        Me.BValueLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BValueLBL.Location = New System.Drawing.Point(22, 86)
        Me.BValueLBL.Name = "BValueLBL"
        Me.BValueLBL.Size = New System.Drawing.Size(65, 20)
        Me.BValueLBL.TabIndex = 6
        Me.BValueLBL.Text = "B value:"
        '
        'aTBX
        '
        Me.aTBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aTBX.Location = New System.Drawing.Point(115, 24)
        Me.aTBX.Name = "aTBX"
        Me.aTBX.Size = New System.Drawing.Size(73, 26)
        Me.aTBX.TabIndex = 7
        Me.aTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bTBX
        '
        Me.bTBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTBX.Location = New System.Drawing.Point(115, 83)
        Me.bTBX.Name = "bTBX"
        Me.bTBX.Size = New System.Drawing.Size(73, 26)
        Me.bTBX.TabIndex = 8
        Me.bTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'addBTN
        '
        Me.addBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBTN.Location = New System.Drawing.Point(24, 138)
        Me.addBTN.Name = "addBTN"
        Me.addBTN.Size = New System.Drawing.Size(82, 37)
        Me.addBTN.TabIndex = 0
        Me.addBTN.Text = "A + B"
        Me.addBTN.UseVisualStyleBackColor = True
        '
        'divideBTN
        '
        Me.divideBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divideBTN.Location = New System.Drawing.Point(288, 138)
        Me.divideBTN.Name = "divideBTN"
        Me.divideBTN.Size = New System.Drawing.Size(82, 37)
        Me.divideBTN.TabIndex = 3
        Me.divideBTN.Text = "A \ B"
        Me.divideBTN.UseVisualStyleBackColor = True
        '
        'multiplyBTH
        '
        Me.multiplyBTH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multiplyBTH.Location = New System.Drawing.Point(200, 138)
        Me.multiplyBTH.Name = "multiplyBTH"
        Me.multiplyBTH.Size = New System.Drawing.Size(82, 37)
        Me.multiplyBTH.TabIndex = 2
        Me.multiplyBTH.Text = "A * B"
        Me.multiplyBTH.UseVisualStyleBackColor = True
        '
        'minusBTN
        '
        Me.minusBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minusBTN.Location = New System.Drawing.Point(112, 138)
        Me.minusBTN.Name = "minusBTN"
        Me.minusBTN.Size = New System.Drawing.Size(82, 37)
        Me.minusBTN.TabIndex = 1
        Me.minusBTN.Text = "A - B"
        Me.minusBTN.UseVisualStyleBackColor = True
        '
        'resultDescLBL
        '
        Me.resultDescLBL.AutoSize = True
        Me.resultDescLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultDescLBL.Location = New System.Drawing.Point(233, 30)
        Me.resultDescLBL.Name = "resultDescLBL"
        Me.resultDescLBL.Size = New System.Drawing.Size(63, 20)
        Me.resultDescLBL.TabIndex = 9
        Me.resultDescLBL.Text = "Result: "
        '
        'outputLBL
        '
        Me.outputLBL.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.outputLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.outputLBL.Location = New System.Drawing.Point(238, 71)
        Me.outputLBL.Name = "outputLBL"
        Me.outputLBL.Size = New System.Drawing.Size(132, 44)
        Me.outputLBL.TabIndex = 10
        Me.outputLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IntCalculatorAppFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 187)
        Me.Controls.Add(Me.outputLBL)
        Me.Controls.Add(Me.resultDescLBL)
        Me.Controls.Add(Me.bTBX)
        Me.Controls.Add(Me.aTBX)
        Me.Controls.Add(Me.BValueLBL)
        Me.Controls.Add(Me.AValueLBL)
        Me.Controls.Add(Me.divideBTN)
        Me.Controls.Add(Me.multiplyBTH)
        Me.Controls.Add(Me.minusBTN)
        Me.Controls.Add(Me.addBTN)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "IntCalculatorAppFRM"
        Me.Text = "Integer Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AValueLBL As Label
    Friend WithEvents BValueLBL As Label
    Friend WithEvents aTBX As TextBox
    Friend WithEvents bTBX As TextBox
    Friend WithEvents addBTN As Button
    Friend WithEvents divideBTN As Button
    Friend WithEvents multiplyBTH As Button
    Friend WithEvents minusBTN As Button
    Friend WithEvents resultDescLBL As Label
    Friend WithEvents outputLBL As Label
End Class
