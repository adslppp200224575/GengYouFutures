﻿
namespace WindowsFormsApp1
{
    partial class OSSKProxyUpdateOrderForm
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
            this.richTextBoxMethodMessage = new System.Windows.Forms.RichTextBox();
            this.panelOrderControlForm = new System.Windows.Forms.Panel();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.tabControlUpdateOrder = new System.Windows.Forms.TabControl();
            this.tabPageCancelForeignStockOrder = new System.Windows.Forms.TabPage();
            this.textBoxbstrExchangeNo = new System.Windows.Forms.TextBox();
            this.labelbstrExchangeNo = new System.Windows.Forms.Label();
            this.textBoxbstrStockNo = new System.Windows.Forms.TextBox();
            this.labelbstrStockNo = new System.Windows.Forms.Label();
            this.buttonSendForeignStockProxyCancel = new System.Windows.Forms.Button();
            this.textBoxCancelForeignStockOrderbstrBookNo = new System.Windows.Forms.TextBox();
            this.labelCancelForeignStockOrderbstrBookNo = new System.Windows.Forms.Label();
            this.textBoxCancelForeignStockOrderbstrSeqNo = new System.Windows.Forms.TextBox();
            this.labelCancelForeignStockOrderbstrSeqNo = new System.Windows.Forms.Label();
            this.comboBoxUpdateTFOrder = new System.Windows.Forms.ComboBox();
            this.comboBoxAccount = new System.Windows.Forms.ComboBox();
            this.comboBoxUserID = new System.Windows.Forms.ComboBox();
            this.panelOrderControlForm.SuspendLayout();
            this.tabControlUpdateOrder.SuspendLayout();
            this.tabPageCancelForeignStockOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxMethodMessage
            // 
            this.richTextBoxMethodMessage.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBoxMethodMessage.Location = new System.Drawing.Point(0, 76);
            this.richTextBoxMethodMessage.Name = "richTextBoxMethodMessage";
            this.richTextBoxMethodMessage.ReadOnly = true;
            this.richTextBoxMethodMessage.Size = new System.Drawing.Size(370, 38);
            this.richTextBoxMethodMessage.TabIndex = 31;
            this.richTextBoxMethodMessage.Text = "";
            // 
            // panelOrderControlForm
            // 
            this.panelOrderControlForm.AutoScroll = true;
            this.panelOrderControlForm.Controls.Add(this.richTextBoxMessage);
            this.panelOrderControlForm.Controls.Add(this.tabControlUpdateOrder);
            this.panelOrderControlForm.Controls.Add(this.comboBoxUpdateTFOrder);
            this.panelOrderControlForm.Controls.Add(this.comboBoxAccount);
            this.panelOrderControlForm.Controls.Add(this.comboBoxUserID);
            this.panelOrderControlForm.Controls.Add(this.richTextBoxMethodMessage);
            this.panelOrderControlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrderControlForm.Location = new System.Drawing.Point(0, 0);
            this.panelOrderControlForm.Name = "panelOrderControlForm";
            this.panelOrderControlForm.Size = new System.Drawing.Size(374, 401);
            this.panelOrderControlForm.TabIndex = 103;
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBoxMessage.Location = new System.Drawing.Point(3, 357);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.ReadOnly = true;
            this.richTextBoxMessage.Size = new System.Drawing.Size(363, 38);
            this.richTextBoxMessage.TabIndex = 126;
            this.richTextBoxMessage.Text = "";
            // 
            // tabControlUpdateOrder
            // 
            this.tabControlUpdateOrder.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlUpdateOrder.Controls.Add(this.tabPageCancelForeignStockOrder);
            this.tabControlUpdateOrder.Font = new System.Drawing.Font("DFKai-SB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControlUpdateOrder.Location = new System.Drawing.Point(3, 120);
            this.tabControlUpdateOrder.Name = "tabControlUpdateOrder";
            this.tabControlUpdateOrder.SelectedIndex = 0;
            this.tabControlUpdateOrder.Size = new System.Drawing.Size(367, 235);
            this.tabControlUpdateOrder.TabIndex = 107;
            // 
            // tabPageCancelForeignStockOrder
            // 
            this.tabPageCancelForeignStockOrder.AutoScroll = true;
            this.tabPageCancelForeignStockOrder.Controls.Add(this.textBoxbstrExchangeNo);
            this.tabPageCancelForeignStockOrder.Controls.Add(this.labelbstrExchangeNo);
            this.tabPageCancelForeignStockOrder.Controls.Add(this.textBoxbstrStockNo);
            this.tabPageCancelForeignStockOrder.Controls.Add(this.labelbstrStockNo);
            this.tabPageCancelForeignStockOrder.Controls.Add(this.buttonSendForeignStockProxyCancel);
            this.tabPageCancelForeignStockOrder.Controls.Add(this.textBoxCancelForeignStockOrderbstrBookNo);
            this.tabPageCancelForeignStockOrder.Controls.Add(this.labelCancelForeignStockOrderbstrBookNo);
            this.tabPageCancelForeignStockOrder.Controls.Add(this.textBoxCancelForeignStockOrderbstrSeqNo);
            this.tabPageCancelForeignStockOrder.Controls.Add(this.labelCancelForeignStockOrderbstrSeqNo);
            this.tabPageCancelForeignStockOrder.Location = new System.Drawing.Point(4, 32);
            this.tabPageCancelForeignStockOrder.Name = "tabPageCancelForeignStockOrder";
            this.tabPageCancelForeignStockOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCancelForeignStockOrder.Size = new System.Drawing.Size(359, 199);
            this.tabPageCancelForeignStockOrder.TabIndex = 5;
            this.tabPageCancelForeignStockOrder.Text = "複委託";
            this.tabPageCancelForeignStockOrder.UseVisualStyleBackColor = true;
            // 
            // textBoxbstrExchangeNo
            // 
            this.textBoxbstrExchangeNo.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxbstrExchangeNo.Location = new System.Drawing.Point(231, 122);
            this.textBoxbstrExchangeNo.Name = "textBoxbstrExchangeNo";
            this.textBoxbstrExchangeNo.Size = new System.Drawing.Size(121, 33);
            this.textBoxbstrExchangeNo.TabIndex = 114;
            // 
            // labelbstrExchangeNo
            // 
            this.labelbstrExchangeNo.AutoSize = true;
            this.labelbstrExchangeNo.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelbstrExchangeNo.Location = new System.Drawing.Point(3, 131);
            this.labelbstrExchangeNo.Name = "labelbstrExchangeNo";
            this.labelbstrExchangeNo.Size = new System.Drawing.Size(206, 24);
            this.labelbstrExchangeNo.TabIndex = 113;
            this.labelbstrExchangeNo.Text = "交易所代碼，美股：US";
            // 
            // textBoxbstrStockNo
            // 
            this.textBoxbstrStockNo.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxbstrStockNo.Location = new System.Drawing.Point(231, 84);
            this.textBoxbstrStockNo.Name = "textBoxbstrStockNo";
            this.textBoxbstrStockNo.Size = new System.Drawing.Size(121, 33);
            this.textBoxbstrStockNo.TabIndex = 112;
            // 
            // labelbstrStockNo
            // 
            this.labelbstrStockNo.AutoSize = true;
            this.labelbstrStockNo.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelbstrStockNo.Location = new System.Drawing.Point(3, 93);
            this.labelbstrStockNo.Name = "labelbstrStockNo";
            this.labelbstrStockNo.Size = new System.Drawing.Size(124, 24);
            this.labelbstrStockNo.TabIndex = 111;
            this.labelbstrStockNo.Text = "委託股票代號";
            // 
            // buttonSendForeignStockProxyCancel
            // 
            this.buttonSendForeignStockProxyCancel.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonSendForeignStockProxyCancel.Location = new System.Drawing.Point(116, 161);
            this.buttonSendForeignStockProxyCancel.Name = "buttonSendForeignStockProxyCancel";
            this.buttonSendForeignStockProxyCancel.Size = new System.Drawing.Size(121, 32);
            this.buttonSendForeignStockProxyCancel.TabIndex = 110;
            this.buttonSendForeignStockProxyCancel.Text = "送出";
            this.buttonSendForeignStockProxyCancel.UseVisualStyleBackColor = true;
            this.buttonSendForeignStockProxyCancel.Click += new System.EventHandler(this.buttonSendForeignStockProxyCancel_Click);
            // 
            // textBoxCancelForeignStockOrderbstrBookNo
            // 
            this.textBoxCancelForeignStockOrderbstrBookNo.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxCancelForeignStockOrderbstrBookNo.Location = new System.Drawing.Point(231, 44);
            this.textBoxCancelForeignStockOrderbstrBookNo.Name = "textBoxCancelForeignStockOrderbstrBookNo";
            this.textBoxCancelForeignStockOrderbstrBookNo.Size = new System.Drawing.Size(121, 33);
            this.textBoxCancelForeignStockOrderbstrBookNo.TabIndex = 109;
            // 
            // labelCancelForeignStockOrderbstrBookNo
            // 
            this.labelCancelForeignStockOrderbstrBookNo.AutoSize = true;
            this.labelCancelForeignStockOrderbstrBookNo.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelCancelForeignStockOrderbstrBookNo.Location = new System.Drawing.Point(3, 53);
            this.labelCancelForeignStockOrderbstrBookNo.Name = "labelCancelForeignStockOrderbstrBookNo";
            this.labelCancelForeignStockOrderbstrBookNo.Size = new System.Drawing.Size(143, 24);
            this.labelCancelForeignStockOrderbstrBookNo.TabIndex = 108;
            this.labelCancelForeignStockOrderbstrBookNo.Text = "請輸入委託書號";
            // 
            // textBoxCancelForeignStockOrderbstrSeqNo
            // 
            this.textBoxCancelForeignStockOrderbstrSeqNo.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxCancelForeignStockOrderbstrSeqNo.Location = new System.Drawing.Point(231, 6);
            this.textBoxCancelForeignStockOrderbstrSeqNo.Name = "textBoxCancelForeignStockOrderbstrSeqNo";
            this.textBoxCancelForeignStockOrderbstrSeqNo.Size = new System.Drawing.Size(121, 33);
            this.textBoxCancelForeignStockOrderbstrSeqNo.TabIndex = 107;
            // 
            // labelCancelForeignStockOrderbstrSeqNo
            // 
            this.labelCancelForeignStockOrderbstrSeqNo.AutoSize = true;
            this.labelCancelForeignStockOrderbstrSeqNo.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelCancelForeignStockOrderbstrSeqNo.Location = new System.Drawing.Point(3, 15);
            this.labelCancelForeignStockOrderbstrSeqNo.Name = "labelCancelForeignStockOrderbstrSeqNo";
            this.labelCancelForeignStockOrderbstrSeqNo.Size = new System.Drawing.Size(143, 24);
            this.labelCancelForeignStockOrderbstrSeqNo.TabIndex = 105;
            this.labelCancelForeignStockOrderbstrSeqNo.Text = "請輸入委託序號";
            // 
            // comboBoxUpdateTFOrder
            // 
            this.comboBoxUpdateTFOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUpdateTFOrder.Enabled = false;
            this.comboBoxUpdateTFOrder.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxUpdateTFOrder.FormattingEnabled = true;
            this.comboBoxUpdateTFOrder.Location = new System.Drawing.Point(174, 38);
            this.comboBoxUpdateTFOrder.Name = "comboBoxUpdateTFOrder";
            this.comboBoxUpdateTFOrder.Size = new System.Drawing.Size(121, 32);
            this.comboBoxUpdateTFOrder.TabIndex = 125;
            // 
            // comboBoxAccount
            // 
            this.comboBoxAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccount.FormattingEnabled = true;
            this.comboBoxAccount.Location = new System.Drawing.Point(3, 40);
            this.comboBoxAccount.Name = "comboBoxAccount";
            this.comboBoxAccount.Size = new System.Drawing.Size(165, 30);
            this.comboBoxAccount.TabIndex = 114;
            // 
            // comboBoxUserID
            // 
            this.comboBoxUserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUserID.FormattingEnabled = true;
            this.comboBoxUserID.Location = new System.Drawing.Point(3, 4);
            this.comboBoxUserID.Name = "comboBoxUserID";
            this.comboBoxUserID.Size = new System.Drawing.Size(165, 30);
            this.comboBoxUserID.TabIndex = 104;
            this.comboBoxUserID.DropDown += new System.EventHandler(this.comboBoxUserID_DropDown);
            // 
            // OSSKProxyUpdateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(374, 401);
            this.Controls.Add(this.panelOrderControlForm);
            this.Name = "OSSKProxyUpdateOrderForm";
            this.Text = "OSSKProxyUpdateOrderForm";
            this.Load += new System.EventHandler(this.OrderControlForm_Load);
            this.panelOrderControlForm.ResumeLayout(false);
            this.tabControlUpdateOrder.ResumeLayout(false);
            this.tabPageCancelForeignStockOrder.ResumeLayout(false);
            this.tabPageCancelForeignStockOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxMethodMessage;
        private System.Windows.Forms.Panel panelOrderControlForm;
        private System.Windows.Forms.ComboBox comboBoxUserID;
        private System.Windows.Forms.TabControl tabControlUpdateOrder;
        private System.Windows.Forms.TabPage tabPageCancelForeignStockOrder;
        private System.Windows.Forms.Button buttonSendForeignStockProxyCancel;
        private System.Windows.Forms.TextBox textBoxCancelForeignStockOrderbstrBookNo;
        private System.Windows.Forms.Label labelCancelForeignStockOrderbstrBookNo;
        private System.Windows.Forms.TextBox textBoxCancelForeignStockOrderbstrSeqNo;
        private System.Windows.Forms.Label labelCancelForeignStockOrderbstrSeqNo;
        private System.Windows.Forms.ComboBox comboBoxAccount;
        private System.Windows.Forms.ComboBox comboBoxUpdateTFOrder;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.TextBox textBoxbstrExchangeNo;
        private System.Windows.Forms.Label labelbstrExchangeNo;
        private System.Windows.Forms.TextBox textBoxbstrStockNo;
        private System.Windows.Forms.Label labelbstrStockNo;
    }
}