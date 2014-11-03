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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.MenuFile = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuFile_Exit = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuCatia = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuCatia_Connect = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuCatia_FindReplace = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuCatia_Colors = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuCatia_InsertText = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuCatia_ReadViewLink = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuHelp = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuHelp_About = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuHelp_ClearStatusMsg = New System.Windows.Forms.ToolStripMenuItem()
    Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
    Me.StatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txt_toFind = New System.Windows.Forms.TextBox()
    Me.txt_Replace = New System.Windows.Forms.TextBox()
    Me.MenuCatia_GetDrawing = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuStrip1.SuspendLayout()
    Me.StatusStrip1.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFile, Me.MenuCatia, Me.MenuHelp})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(378, 24)
    Me.MenuStrip1.TabIndex = 0
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'MenuFile
    '
    Me.MenuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFile_Exit})
    Me.MenuFile.Name = "MenuFile"
    Me.MenuFile.Size = New System.Drawing.Size(37, 20)
    Me.MenuFile.Text = "File"
    '
    'MenuFile_Exit
    '
    Me.MenuFile_Exit.Name = "MenuFile_Exit"
    Me.MenuFile_Exit.Size = New System.Drawing.Size(92, 22)
    Me.MenuFile_Exit.Text = "Exit"
    '
    'MenuCatia
    '
    Me.MenuCatia.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuCatia_Connect, Me.MenuCatia_GetDrawing, Me.MenuCatia_FindReplace, Me.MenuCatia_Colors, Me.MenuCatia_InsertText, Me.MenuCatia_ReadViewLink})
    Me.MenuCatia.Name = "MenuCatia"
    Me.MenuCatia.Size = New System.Drawing.Size(46, 20)
    Me.MenuCatia.Text = "Catia"
    '
    'MenuCatia_Connect
    '
    Me.MenuCatia_Connect.Name = "MenuCatia_Connect"
    Me.MenuCatia_Connect.Size = New System.Drawing.Size(153, 22)
    Me.MenuCatia_Connect.Text = "Connect"
    '
    'MenuCatia_FindReplace
    '
    Me.MenuCatia_FindReplace.Name = "MenuCatia_FindReplace"
    Me.MenuCatia_FindReplace.Size = New System.Drawing.Size(153, 22)
    Me.MenuCatia_FindReplace.Text = "Find Replace"
    '
    'MenuCatia_Colors
    '
    Me.MenuCatia_Colors.Name = "MenuCatia_Colors"
    Me.MenuCatia_Colors.Size = New System.Drawing.Size(153, 22)
    Me.MenuCatia_Colors.Text = "Colors"
    '
    'MenuCatia_InsertText
    '
    Me.MenuCatia_InsertText.Name = "MenuCatia_InsertText"
    Me.MenuCatia_InsertText.Size = New System.Drawing.Size(153, 22)
    Me.MenuCatia_InsertText.Text = "Insert Text"
    '
    'MenuCatia_ReadViewLink
    '
    Me.MenuCatia_ReadViewLink.Name = "MenuCatia_ReadViewLink"
    Me.MenuCatia_ReadViewLink.Size = New System.Drawing.Size(153, 22)
    Me.MenuCatia_ReadViewLink.Text = "Read View Link"
    '
    'MenuHelp
    '
    Me.MenuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuHelp_About, Me.MenuHelp_ClearStatusMsg})
    Me.MenuHelp.Name = "MenuHelp"
    Me.MenuHelp.Size = New System.Drawing.Size(44, 20)
    Me.MenuHelp.Text = "Help"
    '
    'MenuHelp_About
    '
    Me.MenuHelp_About.Name = "MenuHelp_About"
    Me.MenuHelp_About.Size = New System.Drawing.Size(162, 22)
    Me.MenuHelp_About.Text = "About"
    '
    'MenuHelp_ClearStatusMsg
    '
    Me.MenuHelp_ClearStatusMsg.Name = "MenuHelp_ClearStatusMsg"
    Me.MenuHelp_ClearStatusMsg.Size = New System.Drawing.Size(162, 22)
    Me.MenuHelp_ClearStatusMsg.Text = "Clear Status Msg"
    '
    'StatusStrip1
    '
    Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel1})
    Me.StatusStrip1.Location = New System.Drawing.Point(0, 188)
    Me.StatusStrip1.Name = "StatusStrip1"
    Me.StatusStrip1.Size = New System.Drawing.Size(378, 22)
    Me.StatusStrip1.TabIndex = 1
    Me.StatusStrip1.Text = "StatusStrip1"
    '
    'StatusLabel1
    '
    Me.StatusLabel1.Name = "StatusLabel1"
    Me.StatusLabel1.Size = New System.Drawing.Size(0, 17)
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 4
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 2)
    Me.TableLayoutPanel1.Controls.Add(Me.txt_toFind, 2, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.txt_Replace, 2, 2)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 4
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(378, 164)
    Me.TableLayoutPanel1.TabIndex = 2
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(23, 10)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(40, 20)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Find"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(23, 36)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(68, 20)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Replace"
    '
    'txt_toFind
    '
    Me.txt_toFind.Location = New System.Drawing.Point(97, 13)
    Me.txt_toFind.Name = "txt_toFind"
    Me.txt_toFind.Size = New System.Drawing.Size(150, 20)
    Me.txt_toFind.TabIndex = 2
    '
    'txt_Replace
    '
    Me.txt_Replace.Location = New System.Drawing.Point(97, 39)
    Me.txt_Replace.Name = "txt_Replace"
    Me.txt_Replace.Size = New System.Drawing.Size(150, 20)
    Me.txt_Replace.TabIndex = 3
    '
    'MenuCatia_GetDrawing
    '
    Me.MenuCatia_GetDrawing.Name = "MenuCatia_GetDrawing"
    Me.MenuCatia_GetDrawing.Size = New System.Drawing.Size(153, 22)
    Me.MenuCatia_GetDrawing.Text = "Get Drawing"
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(378, 210)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.StatusStrip1)
    Me.Controls.Add(Me.MenuStrip1)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "Form1"
    Me.Text = "Catia Application"
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.StatusStrip1.ResumeLayout(False)
    Me.StatusStrip1.PerformLayout()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents MenuFile As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuFile_Exit As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuCatia As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuCatia_Connect As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuCatia_FindReplace As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuHelp As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuHelp_About As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
  Friend WithEvents StatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txt_toFind As System.Windows.Forms.TextBox
  Friend WithEvents txt_Replace As System.Windows.Forms.TextBox
  Friend WithEvents MenuHelp_ClearStatusMsg As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuCatia_Colors As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuCatia_InsertText As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuCatia_ReadViewLink As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuCatia_GetDrawing As System.Windows.Forms.ToolStripMenuItem

End Class
