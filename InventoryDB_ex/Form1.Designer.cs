namespace InventoryDB_ex
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.btPlanQuery = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.proList = new System.Windows.Forms.ListView();
            this.btSummary = new System.Windows.Forms.Button();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btComplete = new System.Windows.Forms.Button();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbWorkcenter = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(137, 15);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 23);
            this.cbYear.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "생산 년도 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "생산 월 :";
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(438, 16);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(121, 23);
            this.cbMonth.TabIndex = 3;
            // 
            // btPlanQuery
            // 
            this.btPlanQuery.Location = new System.Drawing.Point(668, 14);
            this.btPlanQuery.Name = "btPlanQuery";
            this.btPlanQuery.Size = new System.Drawing.Size(120, 31);
            this.btPlanQuery.TabIndex = 4;
            this.btPlanQuery.Text = "생산 계획 조회";
            this.btPlanQuery.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(801, 16);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(144, 29);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "생산 계획 삭제";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // proList
            // 
            this.proList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.proList.FullRowSelect = true;
            this.proList.GridLines = true;
            this.proList.HideSelection = false;
            this.proList.Location = new System.Drawing.Point(12, 68);
            this.proList.Name = "proList";
            this.proList.Size = new System.Drawing.Size(947, 258);
            this.proList.TabIndex = 6;
            this.proList.UseCompatibleStateImageBehavior = false;
            this.proList.View = System.Windows.Forms.View.Details;
            // 
            // btSummary
            // 
            this.btSummary.Location = new System.Drawing.Point(12, 332);
            this.btSummary.Name = "btSummary";
            this.btSummary.Size = new System.Drawing.Size(120, 31);
            this.btSummary.TabIndex = 7;
            this.btSummary.Text = "생산 실적 조회";
            this.btSummary.UseVisualStyleBackColor = true;
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(12, 378);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(420, 201);
            this.txtSummary.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "품목 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.cbWorkcenter);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbItem);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.dtStart);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(438, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 147);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(363, 105);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(113, 35);
            this.btAdd.TabIndex = 12;
            this.btAdd.Text = "생산계획등록";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(106, 116);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 25);
            this.dtStart.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "생산 시작일 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "작업장 :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btComplete);
            this.groupBox2.Controls.Add(this.dtEnd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(438, 513);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 80);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btComplete
            // 
            this.btComplete.Location = new System.Drawing.Point(363, 32);
            this.btComplete.Name = "btComplete";
            this.btComplete.Size = new System.Drawing.Size(113, 34);
            this.btComplete.TabIndex = 13;
            this.btComplete.Text = "생산 완료등록";
            this.btComplete.UseVisualStyleBackColor = true;
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(106, 32);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 25);
            this.dtEnd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "생산 완료일 :";
            // 
            // cbItem
            // 
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(59, 27);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(121, 23);
            this.cbItem.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "수량 :";
            // 
            // cbWorkcenter
            // 
            this.cbWorkcenter.FormattingEnabled = true;
            this.cbWorkcenter.Location = new System.Drawing.Point(74, 76);
            this.cbWorkcenter.Name = "cbWorkcenter";
            this.cbWorkcenter.Size = new System.Drawing.Size(121, 23);
            this.cbWorkcenter.TabIndex = 14;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(363, 59);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(67, 25);
            this.txtQty.TabIndex = 15;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "생산 계획번호";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "품목";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "작업장";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "생산수량";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "시작일";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "종료일";
            this.columnHeader6.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 613);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.btSummary);
            this.Controls.Add(this.proList);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btPlanQuery);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Button btPlanQuery;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.ListView proList;
        private System.Windows.Forms.Button btSummary;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Button btComplete;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ComboBox cbWorkcenter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbItem;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

