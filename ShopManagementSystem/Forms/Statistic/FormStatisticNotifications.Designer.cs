namespace ShopManagement.Forms.Statistic
{
    partial class FormStatisticNotifications
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatisticNotifications));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startdate_dp = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.endadte_dtp = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buy_grpbx = new System.Windows.Forms.GroupBox();
            this.buy_dgv = new System.Windows.Forms.DataGridView();
            this.sell_grpx = new System.Windows.Forms.GroupBox();
            this.sell_dgv = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.exp_grpx = new System.Windows.Forms.GroupBox();
            this.exp_dgv = new System.Windows.Forms.DataGridView();
            this.result_grpx = new System.Windows.Forms.GroupBox();
            this.EP_tb = new System.Windows.Forms.TextBox();
            this.BP_tb = new System.Windows.Forms.TextBox();
            this.SP_tb = new System.Windows.Forms.TextBox();
            this.E_tb = new System.Windows.Forms.TextBox();
            this.BAC_tb = new System.Windows.Forms.TextBox();
            this.SAC_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.buy_grpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buy_dgv)).BeginInit();
            this.sell_grpx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sell_dgv)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.exp_grpx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exp_dgv)).BeginInit();
            this.result_grpx.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.startdate_dp);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // startdate_dp
            // 
            resources.ApplyResources(this.startdate_dp, "startdate_dp");
            this.startdate_dp.Name = "startdate_dp";
            this.startdate_dp.ValueChanged += new System.EventHandler(this.startdate_dp_ValueChanged);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.endadte_dtp);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // endadte_dtp
            // 
            resources.ApplyResources(this.endadte_dtp, "endadte_dtp");
            this.endadte_dtp.Name = "endadte_dtp";
            this.endadte_dtp.ValueChanged += new System.EventHandler(this.endadte_dtp_ValueChanged);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.buy_grpbx, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.sell_grpx, 1, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // buy_grpbx
            // 
            resources.ApplyResources(this.buy_grpbx, "buy_grpbx");
            this.buy_grpbx.Controls.Add(this.buy_dgv);
            this.buy_grpbx.Name = "buy_grpbx";
            this.buy_grpbx.TabStop = false;
            // 
            // buy_dgv
            // 
            resources.ApplyResources(this.buy_dgv, "buy_dgv");
            this.buy_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buy_dgv.Name = "buy_dgv";
            // 
            // sell_grpx
            // 
            resources.ApplyResources(this.sell_grpx, "sell_grpx");
            this.sell_grpx.Controls.Add(this.sell_dgv);
            this.sell_grpx.Name = "sell_grpx";
            this.sell_grpx.TabStop = false;
            // 
            // sell_dgv
            // 
            resources.ApplyResources(this.sell_dgv, "sell_dgv");
            this.sell_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sell_dgv.Name = "sell_dgv";
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.exp_grpx, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.result_grpx, 1, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // exp_grpx
            // 
            resources.ApplyResources(this.exp_grpx, "exp_grpx");
            this.exp_grpx.Controls.Add(this.exp_dgv);
            this.exp_grpx.Name = "exp_grpx";
            this.exp_grpx.TabStop = false;
            // 
            // exp_dgv
            // 
            resources.ApplyResources(this.exp_dgv, "exp_dgv");
            this.exp_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exp_dgv.Name = "exp_dgv";
            // 
            // result_grpx
            // 
            resources.ApplyResources(this.result_grpx, "result_grpx");
            this.result_grpx.Controls.Add(this.EP_tb);
            this.result_grpx.Controls.Add(this.BP_tb);
            this.result_grpx.Controls.Add(this.SP_tb);
            this.result_grpx.Controls.Add(this.E_tb);
            this.result_grpx.Controls.Add(this.BAC_tb);
            this.result_grpx.Controls.Add(this.SAC_tb);
            this.result_grpx.Controls.Add(this.label8);
            this.result_grpx.Controls.Add(this.label6);
            this.result_grpx.Controls.Add(this.label5);
            this.result_grpx.Controls.Add(this.label4);
            this.result_grpx.Controls.Add(this.label3);
            this.result_grpx.Controls.Add(this.label2);
            this.result_grpx.Controls.Add(this.label1);
            this.result_grpx.Name = "result_grpx";
            this.result_grpx.TabStop = false;
            // 
            // EP_tb
            // 
            resources.ApplyResources(this.EP_tb, "EP_tb");
            this.EP_tb.Name = "EP_tb";
            // 
            // BP_tb
            // 
            resources.ApplyResources(this.BP_tb, "BP_tb");
            this.BP_tb.Name = "BP_tb";
            // 
            // SP_tb
            // 
            resources.ApplyResources(this.SP_tb, "SP_tb");
            this.SP_tb.Name = "SP_tb";
            // 
            // E_tb
            // 
            resources.ApplyResources(this.E_tb, "E_tb");
            this.E_tb.Name = "E_tb";
            // 
            // BAC_tb
            // 
            resources.ApplyResources(this.BAC_tb, "BAC_tb");
            this.BAC_tb.Name = "BAC_tb";
            // 
            // SAC_tb
            // 
            resources.ApplyResources(this.SAC_tb, "SAC_tb");
            this.SAC_tb.Name = "SAC_tb";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // FormStatisticNotifications
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormStatisticNotifications";
            this.Load += new System.EventHandler(this.FormStatisticNotifications_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.buy_grpbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buy_dgv)).EndInit();
            this.sell_grpx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sell_dgv)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.exp_grpx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exp_dgv)).EndInit();
            this.result_grpx.ResumeLayout(false);
            this.result_grpx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker startdate_dp;
        private System.Windows.Forms.DateTimePicker endadte_dtp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox buy_grpbx;
        private System.Windows.Forms.GroupBox sell_grpx;
        private System.Windows.Forms.DataGridView buy_dgv;
        private System.Windows.Forms.DataGridView sell_dgv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox exp_grpx;
        private System.Windows.Forms.DataGridView exp_dgv;
        private System.Windows.Forms.GroupBox result_grpx;
        private System.Windows.Forms.TextBox EP_tb;
        private System.Windows.Forms.TextBox BP_tb;
        private System.Windows.Forms.TextBox SP_tb;
        private System.Windows.Forms.TextBox E_tb;
        private System.Windows.Forms.TextBox BAC_tb;
        private System.Windows.Forms.TextBox SAC_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}