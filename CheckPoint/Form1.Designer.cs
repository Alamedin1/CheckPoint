namespace CheckPoint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Start_Button = new System.Windows.Forms.Button();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Text_StartBut = new System.Windows.Forms.Label();
            this.BarcodeInfo_Text = new System.Windows.Forms.TextBox();
            this.ServerInfo_Text = new System.Windows.Forms.TextBox();
            this.BarcodeInfo = new System.Windows.Forms.Label();
            this.ServerInfo = new System.Windows.Forms.Label();
            this.Server_Indicator = new System.Windows.Forms.Panel();
            this.ServerIndicator_Text = new System.Windows.Forms.Label();
            this.Scaner_Indicator = new System.Windows.Forms.Panel();
            this.ScanerIndicator_Text = new System.Windows.Forms.Label();
            this.Start_Indicator = new CircularProgressBar.CircularProgressBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start_Button
            // 
            this.Start_Button.BackColor = System.Drawing.Color.SpringGreen;
            this.Start_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Start_Button.FlatAppearance.BorderSize = 0;
            this.Start_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.Start_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_Button.Location = new System.Drawing.Point(38, 78);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(138, 73);
            this.Start_Button.TabIndex = 0;
            this.Start_Button.TabStop = false;
            this.Start_Button.Text = "START";
            this.Start_Button.UseVisualStyleBackColor = false;
            this.Start_Button.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop_Button
            // 
            this.Stop_Button.BackColor = System.Drawing.Color.Tomato;
            this.Stop_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop_Button.FlatAppearance.BorderSize = 0;
            this.Stop_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Stop_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stop_Button.Location = new System.Drawing.Point(38, 363);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(138, 73);
            this.Stop_Button.TabIndex = 1;
            this.Stop_Button.TabStop = false;
            this.Stop_Button.Text = "STOP";
            this.Stop_Button.UseVisualStyleBackColor = false;
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(816, 33);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // Text_StartBut
            // 
            this.Text_StartBut.AutoSize = true;
            this.Text_StartBut.Location = new System.Drawing.Point(195, 78);
            this.Text_StartBut.Name = "Text_StartBut";
            this.Text_StartBut.Size = new System.Drawing.Size(156, 27);
            this.Text_StartBut.TabIndex = 4;
            this.Text_StartBut.Text = "Start indicator";
            this.Text_StartBut.Click += new System.EventHandler(this.TextIndicStart_Click);
            // 
            // BarcodeInfo_Text
            // 
            this.BarcodeInfo_Text.Location = new System.Drawing.Point(200, 197);
            this.BarcodeInfo_Text.Multiline = true;
            this.BarcodeInfo_Text.Name = "BarcodeInfo_Text";
            this.BarcodeInfo_Text.Size = new System.Drawing.Size(517, 49);
            this.BarcodeInfo_Text.TabIndex = 5;
            this.BarcodeInfo_Text.TextChanged += new System.EventHandler(this.Scaner_Indicator_Paint);
            // 
            // ServerInfo_Text
            // 
            this.ServerInfo_Text.Location = new System.Drawing.Point(200, 291);
            this.ServerInfo_Text.Multiline = true;
            this.ServerInfo_Text.Name = "ServerInfo_Text";
            this.ServerInfo_Text.Size = new System.Drawing.Size(517, 49);
            this.ServerInfo_Text.TabIndex = 6;
            this.ServerInfo_Text.TextChanged += new System.EventHandler(this.ServerInfo_Text_TextChanged);
            // 
            // BarcodeInfo
            // 
            this.BarcodeInfo.AutoSize = true;
            this.BarcodeInfo.Location = new System.Drawing.Point(363, 167);
            this.BarcodeInfo.Name = "BarcodeInfo";
            this.BarcodeInfo.Size = new System.Drawing.Size(216, 27);
            this.BarcodeInfo.TabIndex = 7;
            this.BarcodeInfo.Text = "Barcode information";
            this.BarcodeInfo.Click += new System.EventHandler(this.BarcodeInfo_Click);
            // 
            // ServerInfo
            // 
            this.ServerInfo.AutoSize = true;
            this.ServerInfo.Location = new System.Drawing.Point(320, 261);
            this.ServerInfo.Name = "ServerInfo";
            this.ServerInfo.Size = new System.Drawing.Size(290, 27);
            this.ServerInfo.TabIndex = 8;
            this.ServerInfo.Text = "Server response information";
            // 
            // Server_Indicator
            // 
            this.Server_Indicator.BackColor = System.Drawing.Color.Gray;
            this.Server_Indicator.Location = new System.Drawing.Point(420, 108);
            this.Server_Indicator.Name = "Server_Indicator";
            this.Server_Indicator.Size = new System.Drawing.Size(39, 43);
            this.Server_Indicator.TabIndex = 11;
            this.Server_Indicator.Paint += new System.Windows.Forms.PaintEventHandler(this.ServerIndic);
            // 
            // ServerIndicator_Text
            // 
            this.ServerIndicator_Text.AutoSize = true;
            this.ServerIndicator_Text.Location = new System.Drawing.Point(357, 78);
            this.ServerIndicator_Text.Name = "ServerIndicator_Text";
            this.ServerIndicator_Text.Size = new System.Drawing.Size(173, 27);
            this.ServerIndicator_Text.TabIndex = 12;
            this.ServerIndicator_Text.Text = "Server indicator";
            // 
            // Scaner_Indicator
            // 
            this.Scaner_Indicator.BackColor = System.Drawing.Color.Gray;
            this.Scaner_Indicator.Location = new System.Drawing.Point(616, 108);
            this.Scaner_Indicator.Name = "Scaner_Indicator";
            this.Scaner_Indicator.Size = new System.Drawing.Size(39, 43);
            this.Scaner_Indicator.TabIndex = 13;
            this.Scaner_Indicator.Paint += new System.Windows.Forms.PaintEventHandler(this.Scaner_Indicator_Paint);
            // 
            // ScanerIndicator_Text
            // 
            this.ScanerIndicator_Text.AutoSize = true;
            this.ScanerIndicator_Text.Location = new System.Drawing.Point(544, 78);
            this.ScanerIndicator_Text.Name = "ScanerIndicator_Text";
            this.ScanerIndicator_Text.Size = new System.Drawing.Size(176, 27);
            this.ScanerIndicator_Text.TabIndex = 14;
            this.ScanerIndicator_Text.Text = "Scaner indicator";
            // 
            // Start_Indicator
            // 
            this.Start_Indicator.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Start_Indicator.AnimationSpeed = 500;
            this.Start_Indicator.BackColor = System.Drawing.Color.Transparent;
            this.Start_Indicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.Start_Indicator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Start_Indicator.InnerColor = System.Drawing.Color.Silver;
            this.Start_Indicator.InnerMargin = 0;
            this.Start_Indicator.InnerWidth = -1;
            this.Start_Indicator.Location = new System.Drawing.Point(236, 108);
            this.Start_Indicator.MarqueeAnimationSpeed = 500;
            this.Start_Indicator.Name = "Start_Indicator";
            this.Start_Indicator.OuterColor = System.Drawing.Color.Gray;
            this.Start_Indicator.OuterMargin = -25;
            this.Start_Indicator.OuterWidth = 26;
            this.Start_Indicator.ProgressColor = System.Drawing.Color.Gray;
            this.Start_Indicator.ProgressWidth = 6;
            this.Start_Indicator.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Start_Indicator.Size = new System.Drawing.Size(52, 52);
            this.Start_Indicator.StartAngle = 270;
            this.Start_Indicator.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Start_Indicator.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Start_Indicator.SubscriptText = ".23";
            this.Start_Indicator.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Start_Indicator.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Start_Indicator.SuperscriptText = "°C";
            this.Start_Indicator.TabIndex = 10;
            this.Start_Indicator.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Start_Indicator.Value = 68;
            this.Start_Indicator.Click += new System.EventHandler(this.Start_Indicator_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(816, 472);
            this.Controls.Add(this.ScanerIndicator_Text);
            this.Controls.Add(this.Scaner_Indicator);
            this.Controls.Add(this.ServerIndicator_Text);
            this.Controls.Add(this.Server_Indicator);
            this.Controls.Add(this.Start_Indicator);
            this.Controls.Add(this.ServerInfo);
            this.Controls.Add(this.BarcodeInfo);
            this.Controls.Add(this.ServerInfo_Text);
            this.Controls.Add(this.BarcodeInfo_Text);
            this.Controls.Add(this.Text_StartBut);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.Start_Button);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CheckPoint";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Button Stop_Button;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label Text_StartBut;
        private System.Windows.Forms.TextBox BarcodeInfo_Text;
        private System.Windows.Forms.TextBox ServerInfo_Text;
        private System.Windows.Forms.Label BarcodeInfo;
        private System.Windows.Forms.Label ServerInfo;
        private System.Windows.Forms.Panel Server_Indicator;
        private System.Windows.Forms.Label ServerIndicator_Text;
        private System.Windows.Forms.Panel Scaner_Indicator;
        private System.Windows.Forms.Label ScanerIndicator_Text;
        private CircularProgressBar.CircularProgressBar Start_Indicator;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

