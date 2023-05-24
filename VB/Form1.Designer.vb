Namespace StoreRepInDB

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.btnLoad = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            ' 
            ' btnLoad
            ' 
            Me.btnLoad.Location = New System.Drawing.Point(82, 156)
            Me.btnLoad.Name = "btnLoad"
            Me.btnLoad.Size = New System.Drawing.Size(120, 48)
            Me.btnLoad.TabIndex = 3
            Me.btnLoad.Text = "Load report and preview"
            AddHandler Me.btnLoad.Click, New System.EventHandler(AddressOf Me.btnLoad_Click)
            ' 
            ' btnSave
            ' 
            Me.btnSave.Location = New System.Drawing.Point(82, 60)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(120, 48)
            Me.btnSave.TabIndex = 2
            Me.btnSave.Text = "Save report to DB"
            AddHandler Me.btnSave.Click, New System.EventHandler(AddressOf Me.btnSave_Click)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(284, 264)
            Me.Controls.Add(Me.btnLoad)
            Me.Controls.Add(Me.btnSave)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private btnLoad As System.Windows.Forms.Button

        Private btnSave As System.Windows.Forms.Button
    End Class
End Namespace
