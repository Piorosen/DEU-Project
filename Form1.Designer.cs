namespace DEU_Project
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.TabPage_Prime = new System.Windows.Forms.TabPage();
            this.ListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabPage_DAP = new System.Windows.Forms.TabPage();
            this.DapListview = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialTabControl1.SuspendLayout();
            this.TabPage_Prime.SuspendLayout();
            this.TabPage_DAP.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TabPage_Prime);
            this.materialTabControl1.Controls.Add(this.TabPage_DAP);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(936, 477);
            this.materialTabControl1.TabIndex = 1;
            // 
            // TabPage_Prime
            // 
            this.TabPage_Prime.Controls.Add(this.ListView);
            this.TabPage_Prime.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Prime.Name = "TabPage_Prime";
            this.TabPage_Prime.Size = new System.Drawing.Size(928, 451);
            this.TabPage_Prime.TabIndex = 0;
            this.TabPage_Prime.Text = "Prime";
            this.TabPage_Prime.UseVisualStyleBackColor = true;
            // 
            // ListView
            // 
            this.ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ListView.Depth = 0;
            this.ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ListView.FullRowSelect = true;
            this.ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListView.Location = new System.Drawing.Point(0, 0);
            this.ListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListView.MouseState = MaterialSkin.MouseState.OUT;
            this.ListView.Name = "ListView";
            this.ListView.OwnerDraw = true;
            this.ListView.Size = new System.Drawing.Size(928, 451);
            this.ListView.TabIndex = 0;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "제목";
            this.columnHeader1.Width = 674;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "작성일";
            this.columnHeader2.Width = 104;
            // 
            // TabPage_DAP
            // 
            this.TabPage_DAP.Controls.Add(this.DapListview);
            this.TabPage_DAP.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TabPage_DAP.Location = new System.Drawing.Point(4, 22);
            this.TabPage_DAP.Name = "TabPage_DAP";
            this.TabPage_DAP.Size = new System.Drawing.Size(743, 294);
            this.TabPage_DAP.TabIndex = 1;
            this.TabPage_DAP.Text = "DAP";
            this.TabPage_DAP.UseVisualStyleBackColor = true;
            // 
            // DapListview
            // 
            this.DapListview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DapListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.DapListview.Depth = 0;
            this.DapListview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DapListview.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.DapListview.FullRowSelect = true;
            this.DapListview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DapListview.Location = new System.Drawing.Point(0, 0);
            this.DapListview.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DapListview.MouseState = MaterialSkin.MouseState.OUT;
            this.DapListview.Name = "DapListview";
            this.DapListview.OwnerDraw = true;
            this.DapListview.Size = new System.Drawing.Size(743, 294);
            this.DapListview.TabIndex = 1;
            this.DapListview.UseCompatibleStateImageBehavior = false;
            this.DapListview.View = System.Windows.Forms.View.Details;
            this.DapListview.SelectedIndexChanged += new System.EventHandler(this.DapListview_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "제목";
            this.columnHeader3.Width = 674;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "작성일";
            this.columnHeader4.Width = 104;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(960, 48);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.materialTabControl1);
            this.panel3.Location = new System.Drawing.Point(12, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(936, 477);
            this.panel3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 607);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.TabPage_Prime.ResumeLayout(false);
            this.TabPage_DAP.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage TabPage_Prime;
        private MaterialSkin.Controls.MaterialListView ListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabPage TabPage_DAP;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialListView DapListview;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

