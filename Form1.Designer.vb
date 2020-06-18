<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim Passenger_NameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim PNR_NumberLabel As System.Windows.Forms.Label
        Dim Starting_PlaceLabel As System.Windows.Forms.Label
        Dim Destination_PlaceLabel As System.Windows.Forms.Label
        Dim Train_NumberLabel As System.Windows.Forms.Label
        Dim Ticket_PriceLabel As System.Windows.Forms.Label
        Dim Date_of_JourneyLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Railway_ReservationDataSet = New Railway_Reservation_Project.Railway_ReservationDataSet()
        Me.Reservation_TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reservation_TableTableAdapter = New Railway_Reservation_Project.Railway_ReservationDataSetTableAdapters.Reservation_TableTableAdapter()
        Me.TableAdapterManager = New Railway_Reservation_Project.Railway_ReservationDataSetTableAdapters.TableAdapterManager()
        Me.Reservation_TableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Reservation_TableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Passenger_NameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.PNR_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Starting_PlaceTextBox = New System.Windows.Forms.TextBox()
        Me.Destination_PlaceTextBox = New System.Windows.Forms.TextBox()
        Me.Train_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Ticket_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_JourneyDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Passenger_NameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        PNR_NumberLabel = New System.Windows.Forms.Label()
        Starting_PlaceLabel = New System.Windows.Forms.Label()
        Destination_PlaceLabel = New System.Windows.Forms.Label()
        Train_NumberLabel = New System.Windows.Forms.Label()
        Ticket_PriceLabel = New System.Windows.Forms.Label()
        Date_of_JourneyLabel = New System.Windows.Forms.Label()
        CType(Me.Railway_ReservationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reservation_TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reservation_TableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Reservation_TableBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Passenger_NameLabel
        '
        Passenger_NameLabel.AutoSize = True
        Passenger_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Passenger_NameLabel.Location = New System.Drawing.Point(146, 79)
        Passenger_NameLabel.Name = "Passenger_NameLabel"
        Passenger_NameLabel.Size = New System.Drawing.Size(135, 20)
        Passenger_NameLabel.TabIndex = 1
        Passenger_NameLabel.Text = "Passenger Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(146, 113)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(67, 20)
        GenderLabel.TabIndex = 3
        GenderLabel.Text = "Gender:"
        '
        'PNR_NumberLabel
        '
        PNR_NumberLabel.AutoSize = True
        PNR_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PNR_NumberLabel.Location = New System.Drawing.Point(146, 147)
        PNR_NumberLabel.Name = "PNR_NumberLabel"
        PNR_NumberLabel.Size = New System.Drawing.Size(106, 20)
        PNR_NumberLabel.TabIndex = 5
        PNR_NumberLabel.Text = "PNR Number:"
        '
        'Starting_PlaceLabel
        '
        Starting_PlaceLabel.AutoSize = True
        Starting_PlaceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Starting_PlaceLabel.Location = New System.Drawing.Point(146, 181)
        Starting_PlaceLabel.Name = "Starting_PlaceLabel"
        Starting_PlaceLabel.Size = New System.Drawing.Size(112, 20)
        Starting_PlaceLabel.TabIndex = 7
        Starting_PlaceLabel.Text = "Starting Place:"
        '
        'Destination_PlaceLabel
        '
        Destination_PlaceLabel.AutoSize = True
        Destination_PlaceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Destination_PlaceLabel.Location = New System.Drawing.Point(146, 221)
        Destination_PlaceLabel.Name = "Destination_PlaceLabel"
        Destination_PlaceLabel.Size = New System.Drawing.Size(137, 20)
        Destination_PlaceLabel.TabIndex = 9
        Destination_PlaceLabel.Text = "Destination Place:"
        '
        'Train_NumberLabel
        '
        Train_NumberLabel.AutoSize = True
        Train_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Train_NumberLabel.Location = New System.Drawing.Point(146, 249)
        Train_NumberLabel.Name = "Train_NumberLabel"
        Train_NumberLabel.Size = New System.Drawing.Size(108, 20)
        Train_NumberLabel.TabIndex = 11
        Train_NumberLabel.Text = "Train Number:"
        '
        'Ticket_PriceLabel
        '
        Ticket_PriceLabel.AutoSize = True
        Ticket_PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ticket_PriceLabel.Location = New System.Drawing.Point(146, 283)
        Ticket_PriceLabel.Name = "Ticket_PriceLabel"
        Ticket_PriceLabel.Size = New System.Drawing.Size(94, 20)
        Ticket_PriceLabel.TabIndex = 13
        Ticket_PriceLabel.Text = "Ticket Price:"
        '
        'Date_of_JourneyLabel
        '
        Date_of_JourneyLabel.AutoSize = True
        Date_of_JourneyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_of_JourneyLabel.Location = New System.Drawing.Point(146, 318)
        Date_of_JourneyLabel.Name = "Date_of_JourneyLabel"
        Date_of_JourneyLabel.Size = New System.Drawing.Size(126, 20)
        Date_of_JourneyLabel.TabIndex = 15
        Date_of_JourneyLabel.Text = "Date of Journey:"
        '
        'Railway_ReservationDataSet
        '
        Me.Railway_ReservationDataSet.DataSetName = "Railway_ReservationDataSet"
        Me.Railway_ReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Reservation_TableBindingSource
        '
        Me.Reservation_TableBindingSource.DataMember = "Reservation Table"
        Me.Reservation_TableBindingSource.DataSource = Me.Railway_ReservationDataSet
        '
        'Reservation_TableTableAdapter
        '
        Me.Reservation_TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Reservation_TableTableAdapter = Me.Reservation_TableTableAdapter
        Me.TableAdapterManager.Train_TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Railway_Reservation_Project.Railway_ReservationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Reservation_TableBindingNavigator
        '
        Me.Reservation_TableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Reservation_TableBindingNavigator.BindingSource = Me.Reservation_TableBindingSource
        Me.Reservation_TableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Reservation_TableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Reservation_TableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Reservation_TableBindingNavigatorSaveItem})
        Me.Reservation_TableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Reservation_TableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Reservation_TableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Reservation_TableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Reservation_TableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Reservation_TableBindingNavigator.Name = "Reservation_TableBindingNavigator"
        Me.Reservation_TableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Reservation_TableBindingNavigator.Size = New System.Drawing.Size(874, 25)
        Me.Reservation_TableBindingNavigator.TabIndex = 0
        Me.Reservation_TableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Reservation_TableBindingNavigatorSaveItem
        '
        Me.Reservation_TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Reservation_TableBindingNavigatorSaveItem.Image = CType(resources.GetObject("Reservation_TableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Reservation_TableBindingNavigatorSaveItem.Name = "Reservation_TableBindingNavigatorSaveItem"
        Me.Reservation_TableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Reservation_TableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Passenger_NameTextBox
        '
        Me.Passenger_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Reservation_TableBindingSource, "Passenger Name", True))
        Me.Passenger_NameTextBox.Location = New System.Drawing.Point(287, 76)
        Me.Passenger_NameTextBox.Name = "Passenger_NameTextBox"
        Me.Passenger_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Passenger_NameTextBox.TabIndex = 2
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Reservation_TableBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(287, 110)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.ReadOnly = True
        Me.GenderTextBox.Size = New System.Drawing.Size(71, 20)
        Me.GenderTextBox.TabIndex = 4
        '
        'PNR_NumberTextBox
        '
        Me.PNR_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Reservation_TableBindingSource, "PNR Number", True))
        Me.PNR_NumberTextBox.Location = New System.Drawing.Point(287, 144)
        Me.PNR_NumberTextBox.Name = "PNR_NumberTextBox"
        Me.PNR_NumberTextBox.ReadOnly = True
        Me.PNR_NumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PNR_NumberTextBox.TabIndex = 6
        '
        'Starting_PlaceTextBox
        '
        Me.Starting_PlaceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Reservation_TableBindingSource, "Starting Place", True))
        Me.Starting_PlaceTextBox.Location = New System.Drawing.Point(287, 178)
        Me.Starting_PlaceTextBox.Name = "Starting_PlaceTextBox"
        Me.Starting_PlaceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Starting_PlaceTextBox.TabIndex = 8
        '
        'Destination_PlaceTextBox
        '
        Me.Destination_PlaceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Reservation_TableBindingSource, "Destination Place", True))
        Me.Destination_PlaceTextBox.Location = New System.Drawing.Point(287, 212)
        Me.Destination_PlaceTextBox.Name = "Destination_PlaceTextBox"
        Me.Destination_PlaceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Destination_PlaceTextBox.TabIndex = 10
        '
        'Train_NumberTextBox
        '
        Me.Train_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Reservation_TableBindingSource, "Train Number", True))
        Me.Train_NumberTextBox.Location = New System.Drawing.Point(287, 246)
        Me.Train_NumberTextBox.Name = "Train_NumberTextBox"
        Me.Train_NumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Train_NumberTextBox.TabIndex = 12
        '
        'Ticket_PriceTextBox
        '
        Me.Ticket_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Reservation_TableBindingSource, "Ticket Price", True))
        Me.Ticket_PriceTextBox.Location = New System.Drawing.Point(287, 280)
        Me.Ticket_PriceTextBox.Name = "Ticket_PriceTextBox"
        Me.Ticket_PriceTextBox.ReadOnly = True
        Me.Ticket_PriceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Ticket_PriceTextBox.TabIndex = 14
        '
        'Date_of_JourneyDateTimePicker
        '
        Me.Date_of_JourneyDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Reservation_TableBindingSource, "Date of Journey", True))
        Me.Date_of_JourneyDateTimePicker.Location = New System.Drawing.Point(287, 314)
        Me.Date_of_JourneyDateTimePicker.Name = "Date_of_JourneyDateTimePicker"
        Me.Date_of_JourneyDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_of_JourneyDateTimePicker.TabIndex = 16
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(374, 110)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(61, 24)
        Me.RadioButton1.TabIndex = 17
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RadioButton2.Location = New System.Drawing.Point(470, 111)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(80, 24)
        Me.RadioButton2.TabIndex = 18
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(150, 354)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(291, 354)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(432, 354)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 24)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "RAILWAY RESERVATION SYSTEM"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 495)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Passenger_NameLabel)
        Me.Controls.Add(Me.Passenger_NameTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(PNR_NumberLabel)
        Me.Controls.Add(Me.PNR_NumberTextBox)
        Me.Controls.Add(Starting_PlaceLabel)
        Me.Controls.Add(Me.Starting_PlaceTextBox)
        Me.Controls.Add(Destination_PlaceLabel)
        Me.Controls.Add(Me.Destination_PlaceTextBox)
        Me.Controls.Add(Train_NumberLabel)
        Me.Controls.Add(Me.Train_NumberTextBox)
        Me.Controls.Add(Ticket_PriceLabel)
        Me.Controls.Add(Me.Ticket_PriceTextBox)
        Me.Controls.Add(Date_of_JourneyLabel)
        Me.Controls.Add(Me.Date_of_JourneyDateTimePicker)
        Me.Controls.Add(Me.Reservation_TableBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Railway_ReservationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reservation_TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reservation_TableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Reservation_TableBindingNavigator.ResumeLayout(False)
        Me.Reservation_TableBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Railway_ReservationDataSet As Railway_ReservationDataSet
    Friend WithEvents Reservation_TableBindingSource As BindingSource
    Friend WithEvents Reservation_TableTableAdapter As Railway_ReservationDataSetTableAdapters.Reservation_TableTableAdapter
    Friend WithEvents TableAdapterManager As Railway_ReservationDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Reservation_TableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Reservation_TableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Passenger_NameTextBox As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents PNR_NumberTextBox As TextBox
    Friend WithEvents Starting_PlaceTextBox As TextBox
    Friend WithEvents Destination_PlaceTextBox As TextBox
    Friend WithEvents Train_NumberTextBox As TextBox
    Friend WithEvents Ticket_PriceTextBox As TextBox
    Friend WithEvents Date_of_JourneyDateTimePicker As DateTimePicker
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
End Class
