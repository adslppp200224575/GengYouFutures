﻿
namespace WindowsFormsApp1
{
    partial class TFSKProxySendOrderForm
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
            this.tabControlOrder = new System.Windows.Forms.TabControl();
            this.tabPageFutureOrder = new System.Windows.Forms.TabPage();
            this.labelTFnPriceFlag = new System.Windows.Forms.Label();
            this.comboBoxTFnPriceFlag = new System.Windows.Forms.ComboBox();
            this.labelTFbstrSettleYM = new System.Windows.Forms.Label();
            this.textBoxTFbstrSettleYM = new System.Windows.Forms.TextBox();
            this.comboBoxFutureReserved = new System.Windows.Forms.ComboBox();
            this.labelFutureReserved = new System.Windows.Forms.Label();
            this.textBoxFuturePrice = new System.Windows.Forms.TextBox();
            this.labelFuturePrice2 = new System.Windows.Forms.Label();
            this.buttonSendFutureOrderCLR = new System.Windows.Forms.Button();
            this.labelFuturePrice = new System.Windows.Forms.Label();
            this.comboBoxFutureNewClose = new System.Windows.Forms.ComboBox();
            this.labelFutureNewClose = new System.Windows.Forms.Label();
            this.comboBoxFutureDayTrade = new System.Windows.Forms.ComboBox();
            this.labelDayTrade = new System.Windows.Forms.Label();
            this.textBoxFutureQty = new System.Windows.Forms.TextBox();
            this.labelFutureQty = new System.Windows.Forms.Label();
            this.comboBoxFutureBuySell = new System.Windows.Forms.ComboBox();
            this.labelFutureBuySell = new System.Windows.Forms.Label();
            this.comboBoxFutureTradeType = new System.Windows.Forms.ComboBox();
            this.labelFutureTradeType = new System.Windows.Forms.Label();
            this.textBoxFutureID = new System.Windows.Forms.TextBox();
            this.labelFutureID = new System.Windows.Forms.Label();
            this.tabPageOptionOrder = new System.Windows.Forms.TabPage();
            this.labelnCP2 = new System.Windows.Forms.Label();
            this.comboBoxnCP2 = new System.Windows.Forms.ComboBox();
            this.textBoxbstrStrike2 = new System.Windows.Forms.TextBox();
            this.labelbstrStrike2 = new System.Windows.Forms.Label();
            this.textBoxTObstrSettleYM2 = new System.Windows.Forms.TextBox();
            this.labelTObstrSettleYM2 = new System.Windows.Forms.Label();
            this.comboBoxTOnPriceFlag = new System.Windows.Forms.ComboBox();
            this.labelTOnPriceFlag = new System.Windows.Forms.Label();
            this.labelnCP = new System.Windows.Forms.Label();
            this.comboBoxnCP = new System.Windows.Forms.ComboBox();
            this.textBoxbstrStrike = new System.Windows.Forms.TextBox();
            this.labelbstrStrike = new System.Windows.Forms.Label();
            this.textBoxTObstrSettleYM = new System.Windows.Forms.TextBox();
            this.labelTObstrSettleYM = new System.Windows.Forms.Label();
            this.labelOptionID2 = new System.Windows.Forms.Label();
            this.textBoxOptionID2 = new System.Windows.Forms.TextBox();
            this.labelOptionBuySell2 = new System.Windows.Forms.Label();
            this.comboBoxOptionBuySell2 = new System.Windows.Forms.ComboBox();
            this.comboBoxOptionBuySell = new System.Windows.Forms.ComboBox();
            this.textBoxOptionPrice = new System.Windows.Forms.TextBox();
            this.comboBoxOptionTradeType = new System.Windows.Forms.ComboBox();
            this.textBoxOptionQty = new System.Windows.Forms.TextBox();
            this.comboBoxOptionbstrOrderType = new System.Windows.Forms.ComboBox();
            this.comboBoxOptionReserved = new System.Windows.Forms.ComboBox();
            this.comboBoxOptionDayTrade = new System.Windows.Forms.ComboBox();
            this.textBoxOptionID = new System.Windows.Forms.TextBox();
            this.labelOptionID = new System.Windows.Forms.Label();
            this.labelDayTradeOption = new System.Windows.Forms.Label();
            this.labelOptionReserved = new System.Windows.Forms.Label();
            this.labelOptionNewClose = new System.Windows.Forms.Label();
            this.labelOptionQty = new System.Windows.Forms.Label();
            this.labelOptionTradeType = new System.Windows.Forms.Label();
            this.labelOptionPrice = new System.Windows.Forms.Label();
            this.labelOptionPrice2 = new System.Windows.Forms.Label();
            this.labelOptionBuySell = new System.Windows.Forms.Label();
            this.buttonSendOptionOrder = new System.Windows.Forms.Button();
            this.richTextBoxMethodMessage = new System.Windows.Forms.RichTextBox();
            this.panelSendOrderForm = new System.Windows.Forms.Panel();
            this.checkBoxSendDuplexOrder = new System.Windows.Forms.CheckBox();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.comboBoxAccount = new System.Windows.Forms.ComboBox();
            this.comboBoxUserID = new System.Windows.Forms.ComboBox();
            this.tabControlOrder.SuspendLayout();
            this.tabPageFutureOrder.SuspendLayout();
            this.tabPageOptionOrder.SuspendLayout();
            this.panelSendOrderForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlOrder
            // 
            this.tabControlOrder.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlOrder.Controls.Add(this.tabPageFutureOrder);
            this.tabControlOrder.Controls.Add(this.tabPageOptionOrder);
            this.tabControlOrder.Font = new System.Drawing.Font("DFKai-SB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControlOrder.Location = new System.Drawing.Point(3, 121);
            this.tabControlOrder.Name = "tabControlOrder";
            this.tabControlOrder.SelectedIndex = 0;
            this.tabControlOrder.Size = new System.Drawing.Size(364, 773);
            this.tabControlOrder.TabIndex = 0;
            // 
            // tabPageFutureOrder
            // 
            this.tabPageFutureOrder.AutoScroll = true;
            this.tabPageFutureOrder.Controls.Add(this.labelTFnPriceFlag);
            this.tabPageFutureOrder.Controls.Add(this.comboBoxTFnPriceFlag);
            this.tabPageFutureOrder.Controls.Add(this.labelTFbstrSettleYM);
            this.tabPageFutureOrder.Controls.Add(this.textBoxTFbstrSettleYM);
            this.tabPageFutureOrder.Controls.Add(this.comboBoxFutureReserved);
            this.tabPageFutureOrder.Controls.Add(this.labelFutureReserved);
            this.tabPageFutureOrder.Controls.Add(this.textBoxFuturePrice);
            this.tabPageFutureOrder.Controls.Add(this.labelFuturePrice2);
            this.tabPageFutureOrder.Controls.Add(this.buttonSendFutureOrderCLR);
            this.tabPageFutureOrder.Controls.Add(this.labelFuturePrice);
            this.tabPageFutureOrder.Controls.Add(this.comboBoxFutureNewClose);
            this.tabPageFutureOrder.Controls.Add(this.labelFutureNewClose);
            this.tabPageFutureOrder.Controls.Add(this.comboBoxFutureDayTrade);
            this.tabPageFutureOrder.Controls.Add(this.labelDayTrade);
            this.tabPageFutureOrder.Controls.Add(this.textBoxFutureQty);
            this.tabPageFutureOrder.Controls.Add(this.labelFutureQty);
            this.tabPageFutureOrder.Controls.Add(this.comboBoxFutureBuySell);
            this.tabPageFutureOrder.Controls.Add(this.labelFutureBuySell);
            this.tabPageFutureOrder.Controls.Add(this.comboBoxFutureTradeType);
            this.tabPageFutureOrder.Controls.Add(this.labelFutureTradeType);
            this.tabPageFutureOrder.Controls.Add(this.textBoxFutureID);
            this.tabPageFutureOrder.Controls.Add(this.labelFutureID);
            this.tabPageFutureOrder.Location = new System.Drawing.Point(4, 32);
            this.tabPageFutureOrder.Name = "tabPageFutureOrder";
            this.tabPageFutureOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFutureOrder.Size = new System.Drawing.Size(356, 737);
            this.tabPageFutureOrder.TabIndex = 1;
            this.tabPageFutureOrder.Text = "期貨";
            this.tabPageFutureOrder.UseVisualStyleBackColor = true;
            // 
            // labelTFnPriceFlag
            // 
            this.labelTFnPriceFlag.AutoSize = true;
            this.labelTFnPriceFlag.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelTFnPriceFlag.Location = new System.Drawing.Point(3, 94);
            this.labelTFnPriceFlag.Name = "labelTFnPriceFlag";
            this.labelTFnPriceFlag.Size = new System.Drawing.Size(178, 24);
            this.labelTFnPriceFlag.TabIndex = 74;
            this.labelTFnPriceFlag.Text = "市價/限價/範圍市價";
            // 
            // comboBoxTFnPriceFlag
            // 
            this.comboBoxTFnPriceFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTFnPriceFlag.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxTFnPriceFlag.FormattingEnabled = true;
            this.comboBoxTFnPriceFlag.Location = new System.Drawing.Point(231, 86);
            this.comboBoxTFnPriceFlag.Name = "comboBoxTFnPriceFlag";
            this.comboBoxTFnPriceFlag.Size = new System.Drawing.Size(121, 32);
            this.comboBoxTFnPriceFlag.TabIndex = 73;
            // 
            // labelTFbstrSettleYM
            // 
            this.labelTFbstrSettleYM.AutoSize = true;
            this.labelTFbstrSettleYM.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelTFbstrSettleYM.Location = new System.Drawing.Point(3, 54);
            this.labelTFbstrSettleYM.Name = "labelTFbstrSettleYM";
            this.labelTFbstrSettleYM.Size = new System.Drawing.Size(86, 24);
            this.labelTFbstrSettleYM.TabIndex = 72;
            this.labelTFbstrSettleYM.Text = "契約年月";
            // 
            // textBoxTFbstrSettleYM
            // 
            this.textBoxTFbstrSettleYM.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxTFbstrSettleYM.Location = new System.Drawing.Point(231, 45);
            this.textBoxTFbstrSettleYM.Name = "textBoxTFbstrSettleYM";
            this.textBoxTFbstrSettleYM.Size = new System.Drawing.Size(121, 33);
            this.textBoxTFbstrSettleYM.TabIndex = 71;
            // 
            // comboBoxFutureReserved
            // 
            this.comboBoxFutureReserved.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFutureReserved.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxFutureReserved.FormattingEnabled = true;
            this.comboBoxFutureReserved.Location = new System.Drawing.Point(231, 162);
            this.comboBoxFutureReserved.Name = "comboBoxFutureReserved";
            this.comboBoxFutureReserved.Size = new System.Drawing.Size(121, 32);
            this.comboBoxFutureReserved.TabIndex = 70;
            // 
            // labelFutureReserved
            // 
            this.labelFutureReserved.AutoSize = true;
            this.labelFutureReserved.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelFutureReserved.Location = new System.Drawing.Point(3, 170);
            this.labelFutureReserved.Name = "labelFutureReserved";
            this.labelFutureReserved.Size = new System.Drawing.Size(48, 24);
            this.labelFutureReserved.TabIndex = 69;
            this.labelFutureReserved.Text = "盤別";
            // 
            // textBoxFuturePrice
            // 
            this.textBoxFuturePrice.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxFuturePrice.Location = new System.Drawing.Point(231, 315);
            this.textBoxFuturePrice.Name = "textBoxFuturePrice";
            this.textBoxFuturePrice.Size = new System.Drawing.Size(121, 33);
            this.textBoxFuturePrice.TabIndex = 68;
            // 
            // labelFuturePrice2
            // 
            this.labelFuturePrice2.AutoSize = true;
            this.labelFuturePrice2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelFuturePrice2.Location = new System.Drawing.Point(3, 399);
            this.labelFuturePrice2.Name = "labelFuturePrice2";
            this.labelFuturePrice2.Size = new System.Drawing.Size(312, 24);
            this.labelFuturePrice2.TabIndex = 67;
            this.labelFuturePrice2.Text = "※IOC/FOK可用(M市價/P範圍市價)";
            // 
            // buttonSendFutureOrderCLR
            // 
            this.buttonSendFutureOrderCLR.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonSendFutureOrderCLR.Location = new System.Drawing.Point(110, 424);
            this.buttonSendFutureOrderCLR.Name = "buttonSendFutureOrderCLR";
            this.buttonSendFutureOrderCLR.Size = new System.Drawing.Size(121, 32);
            this.buttonSendFutureOrderCLR.TabIndex = 66;
            this.buttonSendFutureOrderCLR.Text = "送出";
            this.buttonSendFutureOrderCLR.UseVisualStyleBackColor = true;
            this.buttonSendFutureOrderCLR.Click += new System.EventHandler(this.buttonSendFutureOrderCLR_Click);
            // 
            // labelFuturePrice
            // 
            this.labelFuturePrice.AutoSize = true;
            this.labelFuturePrice.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelFuturePrice.Location = new System.Drawing.Point(3, 324);
            this.labelFuturePrice.Name = "labelFuturePrice";
            this.labelFuturePrice.Size = new System.Drawing.Size(67, 24);
            this.labelFuturePrice.TabIndex = 64;
            this.labelFuturePrice.Text = "委託價";
            // 
            // comboBoxFutureNewClose
            // 
            this.comboBoxFutureNewClose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFutureNewClose.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxFutureNewClose.FormattingEnabled = true;
            this.comboBoxFutureNewClose.Location = new System.Drawing.Point(231, 200);
            this.comboBoxFutureNewClose.Name = "comboBoxFutureNewClose";
            this.comboBoxFutureNewClose.Size = new System.Drawing.Size(121, 32);
            this.comboBoxFutureNewClose.TabIndex = 63;
            // 
            // labelFutureNewClose
            // 
            this.labelFutureNewClose.AutoSize = true;
            this.labelFutureNewClose.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelFutureNewClose.Location = new System.Drawing.Point(3, 208);
            this.labelFutureNewClose.Name = "labelFutureNewClose";
            this.labelFutureNewClose.Size = new System.Drawing.Size(67, 24);
            this.labelFutureNewClose.TabIndex = 62;
            this.labelFutureNewClose.Text = "新平倉";
            // 
            // comboBoxFutureDayTrade
            // 
            this.comboBoxFutureDayTrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFutureDayTrade.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxFutureDayTrade.FormattingEnabled = true;
            this.comboBoxFutureDayTrade.Location = new System.Drawing.Point(231, 124);
            this.comboBoxFutureDayTrade.Name = "comboBoxFutureDayTrade";
            this.comboBoxFutureDayTrade.Size = new System.Drawing.Size(121, 32);
            this.comboBoxFutureDayTrade.TabIndex = 61;
            // 
            // labelDayTrade
            // 
            this.labelDayTrade.AutoSize = true;
            this.labelDayTrade.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelDayTrade.Location = new System.Drawing.Point(3, 132);
            this.labelDayTrade.Name = "labelDayTrade";
            this.labelDayTrade.Size = new System.Drawing.Size(48, 24);
            this.labelDayTrade.TabIndex = 60;
            this.labelDayTrade.Text = "當沖";
            // 
            // textBoxFutureQty
            // 
            this.textBoxFutureQty.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxFutureQty.Location = new System.Drawing.Point(231, 238);
            this.textBoxFutureQty.Name = "textBoxFutureQty";
            this.textBoxFutureQty.Size = new System.Drawing.Size(121, 33);
            this.textBoxFutureQty.TabIndex = 59;
            // 
            // labelFutureQty
            // 
            this.labelFutureQty.AutoSize = true;
            this.labelFutureQty.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelFutureQty.Location = new System.Drawing.Point(3, 247);
            this.labelFutureQty.Name = "labelFutureQty";
            this.labelFutureQty.Size = new System.Drawing.Size(48, 24);
            this.labelFutureQty.TabIndex = 58;
            this.labelFutureQty.Text = "口數";
            // 
            // comboBoxFutureBuySell
            // 
            this.comboBoxFutureBuySell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFutureBuySell.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxFutureBuySell.FormattingEnabled = true;
            this.comboBoxFutureBuySell.Location = new System.Drawing.Point(231, 354);
            this.comboBoxFutureBuySell.Name = "comboBoxFutureBuySell";
            this.comboBoxFutureBuySell.Size = new System.Drawing.Size(121, 32);
            this.comboBoxFutureBuySell.TabIndex = 57;
            // 
            // labelFutureBuySell
            // 
            this.labelFutureBuySell.AutoSize = true;
            this.labelFutureBuySell.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelFutureBuySell.Location = new System.Drawing.Point(3, 362);
            this.labelFutureBuySell.Name = "labelFutureBuySell";
            this.labelFutureBuySell.Size = new System.Drawing.Size(99, 24);
            this.labelFutureBuySell.TabIndex = 56;
            this.labelFutureBuySell.Text = "買進/賣出:";
            // 
            // comboBoxFutureTradeType
            // 
            this.comboBoxFutureTradeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFutureTradeType.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxFutureTradeType.FormattingEnabled = true;
            this.comboBoxFutureTradeType.Location = new System.Drawing.Point(231, 277);
            this.comboBoxFutureTradeType.Name = "comboBoxFutureTradeType";
            this.comboBoxFutureTradeType.Size = new System.Drawing.Size(121, 32);
            this.comboBoxFutureTradeType.TabIndex = 55;
            // 
            // labelFutureTradeType
            // 
            this.labelFutureTradeType.AutoSize = true;
            this.labelFutureTradeType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFutureTradeType.Location = new System.Drawing.Point(3, 287);
            this.labelFutureTradeType.Name = "labelFutureTradeType";
            this.labelFutureTradeType.Size = new System.Drawing.Size(140, 22);
            this.labelFutureTradeType.TabIndex = 54;
            this.labelFutureTradeType.Text = "ROD/IOC/FOK";
            // 
            // textBoxFutureID
            // 
            this.textBoxFutureID.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxFutureID.Location = new System.Drawing.Point(231, 6);
            this.textBoxFutureID.Name = "textBoxFutureID";
            this.textBoxFutureID.Size = new System.Drawing.Size(121, 33);
            this.textBoxFutureID.TabIndex = 36;
            // 
            // labelFutureID
            // 
            this.labelFutureID.AutoSize = true;
            this.labelFutureID.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelFutureID.Location = new System.Drawing.Point(3, 15);
            this.labelFutureID.Name = "labelFutureID";
            this.labelFutureID.Size = new System.Drawing.Size(86, 24);
            this.labelFutureID.TabIndex = 0;
            this.labelFutureID.Text = "期貨代號";
            // 
            // tabPageOptionOrder
            // 
            this.tabPageOptionOrder.AutoScroll = true;
            this.tabPageOptionOrder.Controls.Add(this.labelnCP2);
            this.tabPageOptionOrder.Controls.Add(this.comboBoxnCP2);
            this.tabPageOptionOrder.Controls.Add(this.textBoxbstrStrike2);
            this.tabPageOptionOrder.Controls.Add(this.labelbstrStrike2);
            this.tabPageOptionOrder.Controls.Add(this.textBoxTObstrSettleYM2);
            this.tabPageOptionOrder.Controls.Add(this.labelTObstrSettleYM2);
            this.tabPageOptionOrder.Controls.Add(this.comboBoxTOnPriceFlag);
            this.tabPageOptionOrder.Controls.Add(this.labelTOnPriceFlag);
            this.tabPageOptionOrder.Controls.Add(this.labelnCP);
            this.tabPageOptionOrder.Controls.Add(this.comboBoxnCP);
            this.tabPageOptionOrder.Controls.Add(this.textBoxbstrStrike);
            this.tabPageOptionOrder.Controls.Add(this.labelbstrStrike);
            this.tabPageOptionOrder.Controls.Add(this.textBoxTObstrSettleYM);
            this.tabPageOptionOrder.Controls.Add(this.labelTObstrSettleYM);
            this.tabPageOptionOrder.Controls.Add(this.labelOptionID2);
            this.tabPageOptionOrder.Controls.Add(this.textBoxOptionID2);
            this.tabPageOptionOrder.Controls.Add(this.labelOptionBuySell2);
            this.tabPageOptionOrder.Controls.Add(this.comboBoxOptionBuySell2);
            this.tabPageOptionOrder.Controls.Add(this.comboBoxOptionBuySell);
            this.tabPageOptionOrder.Controls.Add(this.textBoxOptionPrice);
            this.tabPageOptionOrder.Controls.Add(this.comboBoxOptionTradeType);
            this.tabPageOptionOrder.Controls.Add(this.textBoxOptionQty);
            this.tabPageOptionOrder.Controls.Add(this.comboBoxOptionbstrOrderType);
            this.tabPageOptionOrder.Controls.Add(this.comboBoxOptionReserved);
            this.tabPageOptionOrder.Controls.Add(this.comboBoxOptionDayTrade);
            this.tabPageOptionOrder.Controls.Add(this.textBoxOptionID);
            this.tabPageOptionOrder.Controls.Add(this.labelOptionID);
            this.tabPageOptionOrder.Controls.Add(this.labelDayTradeOption);
            this.tabPageOptionOrder.Controls.Add(this.labelOptionReserved);
            this.tabPageOptionOrder.Controls.Add(this.labelOptionNewClose);
            this.tabPageOptionOrder.Controls.Add(this.labelOptionQty);
            this.tabPageOptionOrder.Controls.Add(this.labelOptionTradeType);
            this.tabPageOptionOrder.Controls.Add(this.labelOptionPrice);
            this.tabPageOptionOrder.Controls.Add(this.labelOptionPrice2);
            this.tabPageOptionOrder.Controls.Add(this.labelOptionBuySell);
            this.tabPageOptionOrder.Controls.Add(this.buttonSendOptionOrder);
            this.tabPageOptionOrder.Location = new System.Drawing.Point(4, 32);
            this.tabPageOptionOrder.Name = "tabPageOptionOrder";
            this.tabPageOptionOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOptionOrder.Size = new System.Drawing.Size(356, 737);
            this.tabPageOptionOrder.TabIndex = 2;
            this.tabPageOptionOrder.Text = "選擇權";
            this.tabPageOptionOrder.UseVisualStyleBackColor = true;
            // 
            // labelnCP2
            // 
            this.labelnCP2.AutoSize = true;
            this.labelnCP2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnCP2.Location = new System.Drawing.Point(0, 483);
            this.labelnCP2.Name = "labelnCP2";
            this.labelnCP2.Size = new System.Drawing.Size(114, 22);
            this.labelnCP2.TabIndex = 102;
            this.labelnCP2.Text = "CALL/PUT2";
            this.labelnCP2.Visible = false;
            // 
            // comboBoxnCP2
            // 
            this.comboBoxnCP2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxnCP2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxnCP2.FormattingEnabled = true;
            this.comboBoxnCP2.Location = new System.Drawing.Point(228, 473);
            this.comboBoxnCP2.Name = "comboBoxnCP2";
            this.comboBoxnCP2.Size = new System.Drawing.Size(121, 32);
            this.comboBoxnCP2.TabIndex = 101;
            this.comboBoxnCP2.Visible = false;
            // 
            // textBoxbstrStrike2
            // 
            this.textBoxbstrStrike2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxbstrStrike2.Location = new System.Drawing.Point(229, 201);
            this.textBoxbstrStrike2.Name = "textBoxbstrStrike2";
            this.textBoxbstrStrike2.Size = new System.Drawing.Size(121, 33);
            this.textBoxbstrStrike2.TabIndex = 100;
            this.textBoxbstrStrike2.Visible = false;
            // 
            // labelbstrStrike2
            // 
            this.labelbstrStrike2.AutoSize = true;
            this.labelbstrStrike2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelbstrStrike2.Location = new System.Drawing.Point(3, 210);
            this.labelbstrStrike2.Name = "labelbstrStrike2";
            this.labelbstrStrike2.Size = new System.Drawing.Size(78, 24);
            this.labelbstrStrike2.TabIndex = 99;
            this.labelbstrStrike2.Text = "履約價2";
            this.labelbstrStrike2.Visible = false;
            // 
            // textBoxTObstrSettleYM2
            // 
            this.textBoxTObstrSettleYM2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxTObstrSettleYM2.Location = new System.Drawing.Point(229, 123);
            this.textBoxTObstrSettleYM2.Name = "textBoxTObstrSettleYM2";
            this.textBoxTObstrSettleYM2.Size = new System.Drawing.Size(121, 33);
            this.textBoxTObstrSettleYM2.TabIndex = 98;
            this.textBoxTObstrSettleYM2.Visible = false;
            // 
            // labelTObstrSettleYM2
            // 
            this.labelTObstrSettleYM2.AutoSize = true;
            this.labelTObstrSettleYM2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelTObstrSettleYM2.Location = new System.Drawing.Point(3, 132);
            this.labelTObstrSettleYM2.Name = "labelTObstrSettleYM2";
            this.labelTObstrSettleYM2.Size = new System.Drawing.Size(97, 24);
            this.labelTObstrSettleYM2.TabIndex = 97;
            this.labelTObstrSettleYM2.Text = "契約年月2";
            this.labelTObstrSettleYM2.Visible = false;
            // 
            // comboBoxTOnPriceFlag
            // 
            this.comboBoxTOnPriceFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTOnPriceFlag.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxTOnPriceFlag.FormattingEnabled = true;
            this.comboBoxTOnPriceFlag.Location = new System.Drawing.Point(227, 511);
            this.comboBoxTOnPriceFlag.Name = "comboBoxTOnPriceFlag";
            this.comboBoxTOnPriceFlag.Size = new System.Drawing.Size(121, 32);
            this.comboBoxTOnPriceFlag.TabIndex = 96;
            // 
            // labelTOnPriceFlag
            // 
            this.labelTOnPriceFlag.AutoSize = true;
            this.labelTOnPriceFlag.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelTOnPriceFlag.Location = new System.Drawing.Point(0, 519);
            this.labelTOnPriceFlag.Name = "labelTOnPriceFlag";
            this.labelTOnPriceFlag.Size = new System.Drawing.Size(178, 24);
            this.labelTOnPriceFlag.TabIndex = 95;
            this.labelTOnPriceFlag.Text = "市價/限價/範圍市價";
            // 
            // labelnCP
            // 
            this.labelnCP.AutoSize = true;
            this.labelnCP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnCP.Location = new System.Drawing.Point(0, 445);
            this.labelnCP.Name = "labelnCP";
            this.labelnCP.Size = new System.Drawing.Size(104, 22);
            this.labelnCP.TabIndex = 94;
            this.labelnCP.Text = "CALL/PUT";
            // 
            // comboBoxnCP
            // 
            this.comboBoxnCP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxnCP.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxnCP.FormattingEnabled = true;
            this.comboBoxnCP.Location = new System.Drawing.Point(227, 435);
            this.comboBoxnCP.Name = "comboBoxnCP";
            this.comboBoxnCP.Size = new System.Drawing.Size(121, 32);
            this.comboBoxnCP.TabIndex = 93;
            // 
            // textBoxbstrStrike
            // 
            this.textBoxbstrStrike.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxbstrStrike.Location = new System.Drawing.Point(229, 162);
            this.textBoxbstrStrike.Name = "textBoxbstrStrike";
            this.textBoxbstrStrike.Size = new System.Drawing.Size(121, 33);
            this.textBoxbstrStrike.TabIndex = 92;
            // 
            // labelbstrStrike
            // 
            this.labelbstrStrike.AutoSize = true;
            this.labelbstrStrike.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelbstrStrike.Location = new System.Drawing.Point(3, 171);
            this.labelbstrStrike.Name = "labelbstrStrike";
            this.labelbstrStrike.Size = new System.Drawing.Size(78, 24);
            this.labelbstrStrike.TabIndex = 91;
            this.labelbstrStrike.Text = "履約價1";
            // 
            // textBoxTObstrSettleYM
            // 
            this.textBoxTObstrSettleYM.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxTObstrSettleYM.Location = new System.Drawing.Point(230, 84);
            this.textBoxTObstrSettleYM.Name = "textBoxTObstrSettleYM";
            this.textBoxTObstrSettleYM.Size = new System.Drawing.Size(121, 33);
            this.textBoxTObstrSettleYM.TabIndex = 90;
            // 
            // labelTObstrSettleYM
            // 
            this.labelTObstrSettleYM.AutoSize = true;
            this.labelTObstrSettleYM.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelTObstrSettleYM.Location = new System.Drawing.Point(3, 93);
            this.labelTObstrSettleYM.Name = "labelTObstrSettleYM";
            this.labelTObstrSettleYM.Size = new System.Drawing.Size(86, 24);
            this.labelTObstrSettleYM.TabIndex = 89;
            this.labelTObstrSettleYM.Text = "契約年月";
            // 
            // labelOptionID2
            // 
            this.labelOptionID2.AutoSize = true;
            this.labelOptionID2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelOptionID2.Location = new System.Drawing.Point(3, 54);
            this.labelOptionID2.Name = "labelOptionID2";
            this.labelOptionID2.Size = new System.Drawing.Size(116, 24);
            this.labelOptionID2.TabIndex = 88;
            this.labelOptionID2.Text = "選擇權代號2";
            this.labelOptionID2.Visible = false;
            // 
            // textBoxOptionID2
            // 
            this.textBoxOptionID2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxOptionID2.Location = new System.Drawing.Point(231, 45);
            this.textBoxOptionID2.Name = "textBoxOptionID2";
            this.textBoxOptionID2.Size = new System.Drawing.Size(121, 33);
            this.textBoxOptionID2.TabIndex = 87;
            this.textBoxOptionID2.Visible = false;
            // 
            // labelOptionBuySell2
            // 
            this.labelOptionBuySell2.AutoSize = true;
            this.labelOptionBuySell2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelOptionBuySell2.Location = new System.Drawing.Point(0, 634);
            this.labelOptionBuySell2.Name = "labelOptionBuySell2";
            this.labelOptionBuySell2.Size = new System.Drawing.Size(110, 24);
            this.labelOptionBuySell2.TabIndex = 86;
            this.labelOptionBuySell2.Text = "買進/賣出2:";
            this.labelOptionBuySell2.Visible = false;
            // 
            // comboBoxOptionBuySell2
            // 
            this.comboBoxOptionBuySell2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOptionBuySell2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxOptionBuySell2.FormattingEnabled = true;
            this.comboBoxOptionBuySell2.Location = new System.Drawing.Point(227, 626);
            this.comboBoxOptionBuySell2.Name = "comboBoxOptionBuySell2";
            this.comboBoxOptionBuySell2.Size = new System.Drawing.Size(121, 32);
            this.comboBoxOptionBuySell2.TabIndex = 85;
            this.comboBoxOptionBuySell2.Visible = false;
            // 
            // comboBoxOptionBuySell
            // 
            this.comboBoxOptionBuySell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOptionBuySell.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxOptionBuySell.FormattingEnabled = true;
            this.comboBoxOptionBuySell.Location = new System.Drawing.Point(227, 588);
            this.comboBoxOptionBuySell.Name = "comboBoxOptionBuySell";
            this.comboBoxOptionBuySell.Size = new System.Drawing.Size(121, 32);
            this.comboBoxOptionBuySell.TabIndex = 84;
            // 
            // textBoxOptionPrice
            // 
            this.textBoxOptionPrice.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxOptionPrice.Location = new System.Drawing.Point(227, 549);
            this.textBoxOptionPrice.Name = "textBoxOptionPrice";
            this.textBoxOptionPrice.Size = new System.Drawing.Size(121, 33);
            this.textBoxOptionPrice.TabIndex = 83;
            // 
            // comboBoxOptionTradeType
            // 
            this.comboBoxOptionTradeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOptionTradeType.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxOptionTradeType.FormattingEnabled = true;
            this.comboBoxOptionTradeType.Location = new System.Drawing.Point(228, 397);
            this.comboBoxOptionTradeType.Name = "comboBoxOptionTradeType";
            this.comboBoxOptionTradeType.Size = new System.Drawing.Size(121, 32);
            this.comboBoxOptionTradeType.TabIndex = 82;
            // 
            // textBoxOptionQty
            // 
            this.textBoxOptionQty.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxOptionQty.Location = new System.Drawing.Point(228, 358);
            this.textBoxOptionQty.Name = "textBoxOptionQty";
            this.textBoxOptionQty.Size = new System.Drawing.Size(121, 33);
            this.textBoxOptionQty.TabIndex = 81;
            // 
            // comboBoxOptionbstrOrderType
            // 
            this.comboBoxOptionbstrOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOptionbstrOrderType.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxOptionbstrOrderType.FormattingEnabled = true;
            this.comboBoxOptionbstrOrderType.Location = new System.Drawing.Point(228, 320);
            this.comboBoxOptionbstrOrderType.Name = "comboBoxOptionbstrOrderType";
            this.comboBoxOptionbstrOrderType.Size = new System.Drawing.Size(121, 32);
            this.comboBoxOptionbstrOrderType.TabIndex = 80;
            // 
            // comboBoxOptionReserved
            // 
            this.comboBoxOptionReserved.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOptionReserved.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxOptionReserved.FormattingEnabled = true;
            this.comboBoxOptionReserved.Location = new System.Drawing.Point(228, 282);
            this.comboBoxOptionReserved.Name = "comboBoxOptionReserved";
            this.comboBoxOptionReserved.Size = new System.Drawing.Size(121, 32);
            this.comboBoxOptionReserved.TabIndex = 79;
            // 
            // comboBoxOptionDayTrade
            // 
            this.comboBoxOptionDayTrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOptionDayTrade.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxOptionDayTrade.FormattingEnabled = true;
            this.comboBoxOptionDayTrade.Location = new System.Drawing.Point(228, 244);
            this.comboBoxOptionDayTrade.Name = "comboBoxOptionDayTrade";
            this.comboBoxOptionDayTrade.Size = new System.Drawing.Size(121, 32);
            this.comboBoxOptionDayTrade.TabIndex = 78;
            // 
            // textBoxOptionID
            // 
            this.textBoxOptionID.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxOptionID.Location = new System.Drawing.Point(231, 6);
            this.textBoxOptionID.Name = "textBoxOptionID";
            this.textBoxOptionID.Size = new System.Drawing.Size(121, 33);
            this.textBoxOptionID.TabIndex = 77;
            // 
            // labelOptionID
            // 
            this.labelOptionID.AutoSize = true;
            this.labelOptionID.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelOptionID.Location = new System.Drawing.Point(3, 15);
            this.labelOptionID.Name = "labelOptionID";
            this.labelOptionID.Size = new System.Drawing.Size(105, 24);
            this.labelOptionID.TabIndex = 76;
            this.labelOptionID.Text = "選擇權代號";
            // 
            // labelDayTradeOption
            // 
            this.labelDayTradeOption.AutoSize = true;
            this.labelDayTradeOption.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelDayTradeOption.Location = new System.Drawing.Point(3, 252);
            this.labelDayTradeOption.Name = "labelDayTradeOption";
            this.labelDayTradeOption.Size = new System.Drawing.Size(48, 24);
            this.labelDayTradeOption.TabIndex = 75;
            this.labelDayTradeOption.Text = "當沖";
            // 
            // labelOptionReserved
            // 
            this.labelOptionReserved.AutoSize = true;
            this.labelOptionReserved.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelOptionReserved.Location = new System.Drawing.Point(0, 290);
            this.labelOptionReserved.Name = "labelOptionReserved";
            this.labelOptionReserved.Size = new System.Drawing.Size(48, 24);
            this.labelOptionReserved.TabIndex = 74;
            this.labelOptionReserved.Text = "盤別";
            // 
            // labelOptionNewClose
            // 
            this.labelOptionNewClose.AutoSize = true;
            this.labelOptionNewClose.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelOptionNewClose.Location = new System.Drawing.Point(0, 328);
            this.labelOptionNewClose.Name = "labelOptionNewClose";
            this.labelOptionNewClose.Size = new System.Drawing.Size(67, 24);
            this.labelOptionNewClose.TabIndex = 73;
            this.labelOptionNewClose.Text = "新平倉";
            // 
            // labelOptionQty
            // 
            this.labelOptionQty.AutoSize = true;
            this.labelOptionQty.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelOptionQty.Location = new System.Drawing.Point(0, 367);
            this.labelOptionQty.Name = "labelOptionQty";
            this.labelOptionQty.Size = new System.Drawing.Size(48, 24);
            this.labelOptionQty.TabIndex = 72;
            this.labelOptionQty.Text = "口數";
            // 
            // labelOptionTradeType
            // 
            this.labelOptionTradeType.AutoSize = true;
            this.labelOptionTradeType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOptionTradeType.Location = new System.Drawing.Point(0, 407);
            this.labelOptionTradeType.Name = "labelOptionTradeType";
            this.labelOptionTradeType.Size = new System.Drawing.Size(140, 22);
            this.labelOptionTradeType.TabIndex = 71;
            this.labelOptionTradeType.Text = "ROD/IOC/FOK";
            // 
            // labelOptionPrice
            // 
            this.labelOptionPrice.AutoSize = true;
            this.labelOptionPrice.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelOptionPrice.Location = new System.Drawing.Point(3, 558);
            this.labelOptionPrice.Name = "labelOptionPrice";
            this.labelOptionPrice.Size = new System.Drawing.Size(67, 24);
            this.labelOptionPrice.TabIndex = 70;
            this.labelOptionPrice.Text = "委託價";
            // 
            // labelOptionPrice2
            // 
            this.labelOptionPrice2.AutoSize = true;
            this.labelOptionPrice2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelOptionPrice2.Location = new System.Drawing.Point(1, 666);
            this.labelOptionPrice2.Name = "labelOptionPrice2";
            this.labelOptionPrice2.Size = new System.Drawing.Size(312, 24);
            this.labelOptionPrice2.TabIndex = 69;
            this.labelOptionPrice2.Text = "※IOC/FOK可用(M市價/P範圍市價)";
            // 
            // labelOptionBuySell
            // 
            this.labelOptionBuySell.AutoSize = true;
            this.labelOptionBuySell.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelOptionBuySell.Location = new System.Drawing.Point(1, 596);
            this.labelOptionBuySell.Name = "labelOptionBuySell";
            this.labelOptionBuySell.Size = new System.Drawing.Size(94, 24);
            this.labelOptionBuySell.TabIndex = 68;
            this.labelOptionBuySell.Text = "買進/賣出";
            // 
            // buttonSendOptionOrder
            // 
            this.buttonSendOptionOrder.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonSendOptionOrder.Location = new System.Drawing.Point(108, 700);
            this.buttonSendOptionOrder.Name = "buttonSendOptionOrder";
            this.buttonSendOptionOrder.Size = new System.Drawing.Size(121, 32);
            this.buttonSendOptionOrder.TabIndex = 67;
            this.buttonSendOptionOrder.Text = "送出";
            this.buttonSendOptionOrder.UseVisualStyleBackColor = true;
            this.buttonSendOptionOrder.Click += new System.EventHandler(this.buttonSendOptionOrder_Click);
            // 
            // richTextBoxMethodMessage
            // 
            this.richTextBoxMethodMessage.Location = new System.Drawing.Point(3, 76);
            this.richTextBoxMethodMessage.Name = "richTextBoxMethodMessage";
            this.richTextBoxMethodMessage.ReadOnly = true;
            this.richTextBoxMethodMessage.Size = new System.Drawing.Size(356, 39);
            this.richTextBoxMethodMessage.TabIndex = 32;
            this.richTextBoxMethodMessage.Text = "";
            // 
            // panelSendOrderForm
            // 
            this.panelSendOrderForm.AutoScroll = true;
            this.panelSendOrderForm.Controls.Add(this.checkBoxSendDuplexOrder);
            this.panelSendOrderForm.Controls.Add(this.richTextBoxMessage);
            this.panelSendOrderForm.Controls.Add(this.comboBoxAccount);
            this.panelSendOrderForm.Controls.Add(this.richTextBoxMethodMessage);
            this.panelSendOrderForm.Controls.Add(this.comboBoxUserID);
            this.panelSendOrderForm.Controls.Add(this.tabControlOrder);
            this.panelSendOrderForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSendOrderForm.Location = new System.Drawing.Point(0, 0);
            this.panelSendOrderForm.Name = "panelSendOrderForm";
            this.panelSendOrderForm.Size = new System.Drawing.Size(370, 950);
            this.panelSendOrderForm.TabIndex = 110;
            // 
            // checkBoxSendDuplexOrder
            // 
            this.checkBoxSendDuplexOrder.AutoSize = true;
            this.checkBoxSendDuplexOrder.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxSendDuplexOrder.Location = new System.Drawing.Point(174, 8);
            this.checkBoxSendDuplexOrder.Name = "checkBoxSendDuplexOrder";
            this.checkBoxSendDuplexOrder.Size = new System.Drawing.Size(143, 28);
            this.checkBoxSendDuplexOrder.TabIndex = 111;
            this.checkBoxSendDuplexOrder.Text = "是否為複式單";
            this.checkBoxSendDuplexOrder.UseVisualStyleBackColor = true;
            this.checkBoxSendDuplexOrder.CheckedChanged += new System.EventHandler(this.checkBoxSendDuplexOrder_CheckedChanged);
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Location = new System.Drawing.Point(3, 896);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.ReadOnly = true;
            this.richTextBoxMessage.Size = new System.Drawing.Size(356, 39);
            this.richTextBoxMessage.TabIndex = 110;
            this.richTextBoxMessage.Text = "";
            // 
            // comboBoxAccount
            // 
            this.comboBoxAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccount.FormattingEnabled = true;
            this.comboBoxAccount.Location = new System.Drawing.Point(3, 40);
            this.comboBoxAccount.Name = "comboBoxAccount";
            this.comboBoxAccount.Size = new System.Drawing.Size(165, 30);
            this.comboBoxAccount.TabIndex = 58;
            // 
            // comboBoxUserID
            // 
            this.comboBoxUserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUserID.FormattingEnabled = true;
            this.comboBoxUserID.Location = new System.Drawing.Point(3, 4);
            this.comboBoxUserID.Name = "comboBoxUserID";
            this.comboBoxUserID.Size = new System.Drawing.Size(165, 30);
            this.comboBoxUserID.TabIndex = 56;
            this.comboBoxUserID.DropDown += new System.EventHandler(this.comboBoxUserID_DropDown);
            // 
            // TFSKProxySendOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 950);
            this.Controls.Add(this.panelSendOrderForm);
            this.Name = "TFSKProxySendOrderForm";
            this.Text = "TFSKProxySendOrderForm";
            this.Load += new System.EventHandler(this.SendOrderForm_Load);
            this.tabControlOrder.ResumeLayout(false);
            this.tabPageFutureOrder.ResumeLayout(false);
            this.tabPageFutureOrder.PerformLayout();
            this.tabPageOptionOrder.ResumeLayout(false);
            this.tabPageOptionOrder.PerformLayout();
            this.panelSendOrderForm.ResumeLayout(false);
            this.panelSendOrderForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlOrder;
        private System.Windows.Forms.TabPage tabPageFutureOrder;
        private System.Windows.Forms.RichTextBox richTextBoxMethodMessage;
        private System.Windows.Forms.Label labelFutureID;
        private System.Windows.Forms.TextBox textBoxFutureID;
        private System.Windows.Forms.Label labelFutureQty;
        private System.Windows.Forms.ComboBox comboBoxFutureBuySell;
        private System.Windows.Forms.Label labelFutureBuySell;
        private System.Windows.Forms.ComboBox comboBoxFutureTradeType;
        private System.Windows.Forms.Label labelFutureTradeType;
        private System.Windows.Forms.TextBox textBoxFutureQty;
        private System.Windows.Forms.ComboBox comboBoxFutureNewClose;
        private System.Windows.Forms.Label labelFutureNewClose;
        private System.Windows.Forms.ComboBox comboBoxFutureDayTrade;
        private System.Windows.Forms.Label labelDayTrade;
        private System.Windows.Forms.Button buttonSendFutureOrderCLR;
        private System.Windows.Forms.Label labelFuturePrice;
        private System.Windows.Forms.ComboBox comboBoxFutureReserved;
        private System.Windows.Forms.Label labelFutureReserved;
        private System.Windows.Forms.TextBox textBoxFuturePrice;
        private System.Windows.Forms.Label labelFuturePrice2;
        private System.Windows.Forms.TabPage tabPageOptionOrder;
        private System.Windows.Forms.ComboBox comboBoxOptionBuySell;
        private System.Windows.Forms.TextBox textBoxOptionPrice;
        private System.Windows.Forms.ComboBox comboBoxOptionTradeType;
        private System.Windows.Forms.TextBox textBoxOptionQty;
        private System.Windows.Forms.ComboBox comboBoxOptionbstrOrderType;
        private System.Windows.Forms.ComboBox comboBoxOptionReserved;
        private System.Windows.Forms.ComboBox comboBoxOptionDayTrade;
        private System.Windows.Forms.TextBox textBoxOptionID;
        private System.Windows.Forms.Label labelOptionID;
        private System.Windows.Forms.Label labelDayTradeOption;
        private System.Windows.Forms.Label labelOptionReserved;
        private System.Windows.Forms.Label labelOptionNewClose;
        private System.Windows.Forms.Label labelOptionQty;
        private System.Windows.Forms.Label labelOptionTradeType;
        private System.Windows.Forms.Label labelOptionPrice;
        private System.Windows.Forms.Label labelOptionPrice2;
        private System.Windows.Forms.Label labelOptionBuySell;
        private System.Windows.Forms.Button buttonSendOptionOrder;
        private System.Windows.Forms.Panel panelSendOrderForm;
        private System.Windows.Forms.ComboBox comboBoxAccount;
        private System.Windows.Forms.ComboBox comboBoxUserID;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.CheckBox checkBoxSendDuplexOrder;
        private System.Windows.Forms.Label labelOptionID2;
        private System.Windows.Forms.TextBox textBoxOptionID2;
        private System.Windows.Forms.Label labelOptionBuySell2;
        private System.Windows.Forms.ComboBox comboBoxOptionBuySell2;
        private System.Windows.Forms.Label labelTFbstrSettleYM;
        private System.Windows.Forms.TextBox textBoxTFbstrSettleYM;
        private System.Windows.Forms.Label labelTFnPriceFlag;
        private System.Windows.Forms.ComboBox comboBoxTFnPriceFlag;
        private System.Windows.Forms.TextBox textBoxTObstrSettleYM;
        private System.Windows.Forms.Label labelTObstrSettleYM;
        private System.Windows.Forms.TextBox textBoxbstrStrike;
        private System.Windows.Forms.Label labelbstrStrike;
        private System.Windows.Forms.Label labelnCP;
        private System.Windows.Forms.ComboBox comboBoxnCP;
        private System.Windows.Forms.ComboBox comboBoxTOnPriceFlag;
        private System.Windows.Forms.Label labelTOnPriceFlag;
        private System.Windows.Forms.TextBox textBoxTObstrSettleYM2;
        private System.Windows.Forms.Label labelTObstrSettleYM2;
        private System.Windows.Forms.TextBox textBoxbstrStrike2;
        private System.Windows.Forms.Label labelbstrStrike2;
        private System.Windows.Forms.Label labelnCP2;
        private System.Windows.Forms.ComboBox comboBoxnCP2;
    }
}