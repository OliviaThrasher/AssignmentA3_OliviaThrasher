<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBurger
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
        LabelFarmB = New Label()
        PicMeat = New PictureBox()
        PicVeggie = New PictureBox()
        ButtonSelect = New Button()
        ButtonMeat = New Button()
        ButtonVeggie = New Button()
        TextInstructions = New TextBox()
        TextConfirm = New TextBox()
        ButtonExit = New Button()
        CType(PicMeat, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicVeggie, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelFarmB
        ' 
        LabelFarmB.AutoSize = True
        LabelFarmB.Font = New Font("Constantia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelFarmB.Location = New Point(237, 27)
        LabelFarmB.Name = "LabelFarmB"
        LabelFarmB.Size = New Size(293, 35)
        LabelFarmB.TabIndex = 0
        LabelFarmB.Text = "Farm Burger Specials"
        ' 
        ' PicMeat
        ' 
        PicMeat.Location = New Point(124, 96)
        PicMeat.Name = "PicMeat"
        PicMeat.Size = New Size(206, 156)
        PicMeat.TabIndex = 1
        PicMeat.TabStop = False
        ' 
        ' PicVeggie
        ' 
        PicVeggie.Location = New Point(462, 96)
        PicVeggie.Name = "PicVeggie"
        PicVeggie.Size = New Size(206, 156)
        PicVeggie.TabIndex = 2
        PicVeggie.TabStop = False
        ' 
        ' ButtonSelect
        ' 
        ButtonSelect.BackColor = SystemColors.AppWorkspace
        ButtonSelect.FlatStyle = FlatStyle.Flat
        ButtonSelect.Font = New Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonSelect.ForeColor = SystemColors.ControlText
        ButtonSelect.Location = New Point(335, 272)
        ButtonSelect.Name = "ButtonSelect"
        ButtonSelect.Size = New Size(125, 37)
        ButtonSelect.TabIndex = 3
        ButtonSelect.Text = "Select Meal"
        ButtonSelect.UseVisualStyleBackColor = False
        ' 
        ' ButtonMeat
        ' 
        ButtonMeat.BackColor = SystemColors.AppWorkspace
        ButtonMeat.FlatStyle = FlatStyle.Flat
        ButtonMeat.Font = New Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonMeat.ForeColor = SystemColors.ControlText
        ButtonMeat.Location = New Point(170, 272)
        ButtonMeat.Name = "ButtonMeat"
        ButtonMeat.Size = New Size(125, 37)
        ButtonMeat.TabIndex = 4
        ButtonMeat.Text = "Prime Beef"
        ButtonMeat.UseVisualStyleBackColor = False
        ' 
        ' ButtonVeggie
        ' 
        ButtonVeggie.BackColor = SystemColors.AppWorkspace
        ButtonVeggie.FlatStyle = FlatStyle.Flat
        ButtonVeggie.Font = New Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonVeggie.ForeColor = SystemColors.ControlText
        ButtonVeggie.Location = New Point(495, 272)
        ButtonVeggie.Name = "ButtonVeggie"
        ButtonVeggie.Size = New Size(125, 37)
        ButtonVeggie.TabIndex = 5
        ButtonVeggie.Text = "Veggie"
        ButtonVeggie.UseVisualStyleBackColor = False
        ' 
        ' TextInstructions
        ' 
        TextInstructions.BackColor = SystemColors.Menu
        TextInstructions.BorderStyle = BorderStyle.None
        TextInstructions.Font = New Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextInstructions.Location = New Point(185, 326)
        TextInstructions.Name = "TextInstructions"
        TextInstructions.Size = New Size(410, 20)
        TextInstructions.TabIndex = 6
        TextInstructions.Text = "Choose a burger and then click the Select Meal button"
        ' 
        ' TextConfirm
        ' 
        TextConfirm.BackColor = SystemColors.Menu
        TextConfirm.BorderStyle = BorderStyle.None
        TextConfirm.Font = New Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextConfirm.Location = New Point(303, 352)
        TextConfirm.Name = "TextConfirm"
        TextConfirm.Size = New Size(198, 20)
        TextConfirm.TabIndex = 7
        TextConfirm.Text = "Enjoy your burger special"
        ' 
        ' ButtonExit
        ' 
        ButtonExit.BackColor = SystemColors.AppWorkspace
        ButtonExit.FlatStyle = FlatStyle.Flat
        ButtonExit.Font = New Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonExit.ForeColor = SystemColors.ControlText
        ButtonExit.Location = New Point(335, 389)
        ButtonExit.Name = "ButtonExit"
        ButtonExit.Size = New Size(125, 37)
        ButtonExit.TabIndex = 8
        ButtonExit.Text = "Exit Window"
        ButtonExit.UseVisualStyleBackColor = False
        ' 
        ' FormBurger
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonExit)
        Controls.Add(TextConfirm)
        Controls.Add(TextInstructions)
        Controls.Add(ButtonVeggie)
        Controls.Add(ButtonMeat)
        Controls.Add(ButtonSelect)
        Controls.Add(PicVeggie)
        Controls.Add(PicMeat)
        Controls.Add(LabelFarmB)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormBurger"
        Text = "Burger Specials"
        CType(PicMeat, ComponentModel.ISupportInitialize).EndInit()
        CType(PicVeggie, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelFarmB As Label
    Friend WithEvents PicMeat As PictureBox
    Friend WithEvents PicVeggie As PictureBox
    Friend WithEvents ButtonSelect As Button
    Friend WithEvents ButtonMeat As Button
    Friend WithEvents ButtonVeggie As Button
    Friend WithEvents TextInstructions As TextBox
    Friend WithEvents TextConfirm As TextBox
    Friend WithEvents ButtonExit As Button

End Class
