namespace MSSQLLogAnalyzer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtConnectionstring = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTablename = new System.Windows.Forms.TextBox();
            this.dtEndtime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtStarttime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReadlog = new System.Windows.Forms.Button();
            this.dgLogs = new System.Windows.Forms.DataGridView();
            this.transactionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.redoSQLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.undoSQLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsProg = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsRows = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConnectionstring
            // 
            this.txtConnectionstring.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConnectionstring.Location = new System.Drawing.Point(140, 2);
            this.txtConnectionstring.Name = "txtConnectionstring";
            this.txtConnectionstring.Size = new System.Drawing.Size(1000, 30);
            this.txtConnectionstring.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 44;
            this.label4.Text = "ConnectionString";
            // 
            // txtTablename
            // 
            this.txtTablename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTablename.Location = new System.Drawing.Point(699, 31);
            this.txtTablename.Name = "txtTablename";
            this.txtTablename.Size = new System.Drawing.Size(170, 30);
            this.txtTablename.TabIndex = 43;
            // 
            // dtEndtime
            // 
            this.dtEndtime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndtime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtEndtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndtime.Location = new System.Drawing.Point(376, 31);
            this.dtEndtime.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtEndtime.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dtEndtime.Name = "dtEndtime";
            this.dtEndtime.Size = new System.Drawing.Size(190, 30);
            this.dtEndtime.TabIndex = 42;
            this.dtEndtime.TabStop = false;
            this.dtEndtime.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "StartTime";
            // 
            // dtStarttime
            // 
            this.dtStarttime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStarttime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtStarttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStarttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStarttime.Location = new System.Drawing.Point(83, 31);
            this.dtStarttime.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtStarttime.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dtStarttime.Name = "dtStarttime";
            this.dtStarttime.Size = new System.Drawing.Size(190, 30);
            this.dtStarttime.TabIndex = 41;
            this.dtStarttime.TabStop = false;
            this.dtStarttime.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(605, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "TableName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 38;
            this.label2.Text = "EndTime";
            // 
            // btnReadlog
            // 
            this.btnReadlog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReadlog.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnReadlog.FlatAppearance.BorderSize = 2;
            this.btnReadlog.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadlog.Location = new System.Drawing.Point(1162, 3);
            this.btnReadlog.Name = "btnReadlog";
            this.btnReadlog.Size = new System.Drawing.Size(107, 51);
            this.btnReadlog.TabIndex = 40;
            this.btnReadlog.Text = "ReadLog";
            this.btnReadlog.UseVisualStyleBackColor = true;
            this.btnReadlog.Click += new System.EventHandler(this.btnReadlog_Click);
            // 
            // dgLogs
            // 
            this.dgLogs.AllowUserToAddRows = false;
            this.dgLogs.AllowUserToDeleteRows = false;
            this.dgLogs.AllowUserToResizeRows = false;
            this.dgLogs.AutoGenerateColumns = false;
            this.dgLogs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIDDataGridViewTextBoxColumn,
            this.beginTimeDataGridViewTextBoxColumn,
            this.objectNameDataGridViewTextBoxColumn,
            this.operationDataGridViewTextBoxColumn,
            this.redoSQLDataGridViewTextBoxColumn,
            this.undoSQLDataGridViewTextBoxColumn});
            this.dgLogs.DataSource = this.bindingSource1;
            this.dgLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgLogs.EnableHeadersVisualStyles = false;
            this.dgLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgLogs.Location = new System.Drawing.Point(0, 0);
            this.dgLogs.Name = "dgLogs";
            this.dgLogs.ReadOnly = true;
            this.dgLogs.RowHeadersVisible = false;
            this.dgLogs.RowHeadersWidth = 51;
            this.dgLogs.RowTemplate.Height = 23;
            this.dgLogs.ShowCellToolTips = false;
            this.dgLogs.ShowEditingIcon = false;
            this.dgLogs.ShowRowErrors = false;
            this.dgLogs.Size = new System.Drawing.Size(1278, 572);
            this.dgLogs.TabIndex = 46;
            this.dgLogs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLogs_CellDoubleClick);
            // 
            // transactionIDDataGridViewTextBoxColumn
            // 
            this.transactionIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionID";
            this.transactionIDDataGridViewTextBoxColumn.HeaderText = "TransactionID";
            this.transactionIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionIDDataGridViewTextBoxColumn.Name = "transactionIDDataGridViewTextBoxColumn";
            this.transactionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionIDDataGridViewTextBoxColumn.Width = 110;
            // 
            // beginTimeDataGridViewTextBoxColumn
            // 
            this.beginTimeDataGridViewTextBoxColumn.DataPropertyName = "BeginTime";
            this.beginTimeDataGridViewTextBoxColumn.HeaderText = "BeginTime";
            this.beginTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.beginTimeDataGridViewTextBoxColumn.Name = "beginTimeDataGridViewTextBoxColumn";
            this.beginTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.beginTimeDataGridViewTextBoxColumn.Width = 145;
            // 
            // objectNameDataGridViewTextBoxColumn
            // 
            this.objectNameDataGridViewTextBoxColumn.DataPropertyName = "ObjectName";
            this.objectNameDataGridViewTextBoxColumn.HeaderText = "ObjectName";
            this.objectNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.objectNameDataGridViewTextBoxColumn.Name = "objectNameDataGridViewTextBoxColumn";
            this.objectNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.objectNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // operationDataGridViewTextBoxColumn
            // 
            this.operationDataGridViewTextBoxColumn.DataPropertyName = "Operation";
            this.operationDataGridViewTextBoxColumn.HeaderText = "Operation";
            this.operationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.operationDataGridViewTextBoxColumn.Name = "operationDataGridViewTextBoxColumn";
            this.operationDataGridViewTextBoxColumn.ReadOnly = true;
            this.operationDataGridViewTextBoxColumn.Width = 125;
            // 
            // redoSQLDataGridViewTextBoxColumn
            // 
            this.redoSQLDataGridViewTextBoxColumn.DataPropertyName = "RedoSQL";
            this.redoSQLDataGridViewTextBoxColumn.HeaderText = "RedoSQL  (DoubleClick cell to View full SQL)";
            this.redoSQLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.redoSQLDataGridViewTextBoxColumn.Name = "redoSQLDataGridViewTextBoxColumn";
            this.redoSQLDataGridViewTextBoxColumn.ReadOnly = true;
            this.redoSQLDataGridViewTextBoxColumn.Width = 320;
            // 
            // undoSQLDataGridViewTextBoxColumn
            // 
            this.undoSQLDataGridViewTextBoxColumn.DataPropertyName = "UndoSQL";
            this.undoSQLDataGridViewTextBoxColumn.HeaderText = "UndoSQL  (DoubleClick cell to View full SQL)";
            this.undoSQLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.undoSQLDataGridViewTextBoxColumn.Name = "undoSQLDataGridViewTextBoxColumn";
            this.undoSQLDataGridViewTextBoxColumn.ReadOnly = true;
            this.undoSQLDataGridViewTextBoxColumn.Width = 320;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(DBLOG.DatabaseLog);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1284, 673);
            this.tableLayoutPanel1.TabIndex = 47;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.statusStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 646);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1278, 24);
            this.panel3.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProg,
            this.toolStripStatusLabel1,
            this.tsTime,
            this.tsRows});
            this.statusStrip1.Location = new System.Drawing.Point(0, -11);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1278, 35);
            this.statusStrip1.TabIndex = 0;
            // 
            // tsProg
            // 
            this.tsProg.AutoSize = false;
            this.tsProg.Name = "tsProg";
            this.tsProg.Size = new System.Drawing.Size(100, 27);
            this.tsProg.Step = 1;
            this.tsProg.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(994, 29);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // tsTime
            // 
            this.tsTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tsTime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsTime.Name = "tsTime";
            this.tsTime.Size = new System.Drawing.Size(94, 29);
            this.tsTime.Text = "00:00:00";
            // 
            // tsRows
            // 
            this.tsRows.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tsRows.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsRows.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsRows.Name = "tsRows";
            this.tsRows.Size = new System.Drawing.Size(73, 29);
            this.tsRows.Text = "0 rows";
            this.tsRows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgLogs);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1278, 572);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnReadlog);
            this.panel1.Controls.Add(this.txtConnectionstring);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.txtTablename);
            this.panel1.Controls.Add(this.dtStarttime);
            this.panel1.Controls.Add(this.dtEndtime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 59);
            this.panel1.TabIndex = 0;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(970, 31);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(170, 30);
            this.search.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(885, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 39;
            this.label5.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 673);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Analyzer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtConnectionstring;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTablename;
        private System.Windows.Forms.DateTimePicker dtEndtime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtStarttime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReadlog;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dgLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn redoSQLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn undoSQLDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsTime;
        private System.Windows.Forms.ToolStripStatusLabel tsRows;
        private System.Windows.Forms.ToolStripProgressBar tsProg;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label5;
    }
}

