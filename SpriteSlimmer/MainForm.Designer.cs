namespace SpriteSlimmer
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.panelImagePreview = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonRateQuart = new System.Windows.Forms.RadioButton();
            this.radioButtonRateHalf = new System.Windows.Forms.RadioButton();
            this.radioButtonRate1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonPrevColor2 = new System.Windows.Forms.RadioButton();
            this.radioButtonPrevColor1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelError = new System.Windows.Forms.Label();
            this.comboBoxThinning = new System.Windows.Forms.ComboBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownOutputColumn = new System.Windows.Forms.NumericUpDown();
            this.comboBoxBackground = new System.Windows.Forms.ComboBox();
            this.numericUpDownOutputRow = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonOriginalPrev = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxColumn = new System.Windows.Forms.ComboBox();
            this.comboBoxRow = new System.Windows.Forms.ComboBox();
            this.checkBoxGridLine = new System.Windows.Forms.CheckBox();
            this.textBoxTargetPath = new System.Windows.Forms.TextBox();
            this.buttonPreviewOutput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.panelImagePreview.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutputColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutputRow)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(213, 24);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(51, 23);
            this.buttonAddItem.TabIndex = 2;
            this.buttonAddItem.Text = "参照";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(201, 454);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(75, 40);
            this.buttonOutput.TabIndex = 7;
            this.buttonOutput.Text = "出力";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "■ファイルパス";
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Location = new System.Drawing.Point(285, 4);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(366, 362);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPreview.TabIndex = 8;
            this.pictureBoxPreview.TabStop = false;
            // 
            // panelImagePreview
            // 
            this.panelImagePreview.AutoScroll = true;
            this.panelImagePreview.BackColor = System.Drawing.Color.Black;
            this.panelImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImagePreview.Controls.Add(this.pictureBoxPreview);
            this.panelImagePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImagePreview.Location = new System.Drawing.Point(0, 0);
            this.panelImagePreview.Name = "panelImagePreview";
            this.panelImagePreview.Size = new System.Drawing.Size(833, 515);
            this.panelImagePreview.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.textBoxTargetPath);
            this.panel1.Controls.Add(this.buttonPreviewOutput);
            this.panel1.Controls.Add(this.buttonAddItem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonOutput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 515);
            this.panel1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.checkBoxGridLine);
            this.groupBox5.Location = new System.Drawing.Point(22, 366);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(173, 131);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "プレビュー";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonRateQuart);
            this.groupBox4.Controls.Add(this.radioButtonRateHalf);
            this.groupBox4.Controls.Add(this.radioButtonRate1);
            this.groupBox4.Location = new System.Drawing.Point(89, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(68, 98);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "倍率";
            // 
            // radioButtonRateQuart
            // 
            this.radioButtonRateQuart.AutoSize = true;
            this.radioButtonRateQuart.Location = new System.Drawing.Point(10, 66);
            this.radioButtonRateQuart.Name = "radioButtonRateQuart";
            this.radioButtonRateQuart.Size = new System.Drawing.Size(41, 16);
            this.radioButtonRateQuart.TabIndex = 2;
            this.radioButtonRateQuart.Text = "1/4";
            this.radioButtonRateQuart.UseVisualStyleBackColor = true;
            this.radioButtonRateQuart.CheckedChanged += new System.EventHandler(this.RadioButtonRateQuart_CheckedChanged);
            // 
            // radioButtonRateHalf
            // 
            this.radioButtonRateHalf.AutoSize = true;
            this.radioButtonRateHalf.Location = new System.Drawing.Point(10, 42);
            this.radioButtonRateHalf.Name = "radioButtonRateHalf";
            this.radioButtonRateHalf.Size = new System.Drawing.Size(41, 16);
            this.radioButtonRateHalf.TabIndex = 1;
            this.radioButtonRateHalf.Text = "1/2";
            this.radioButtonRateHalf.UseVisualStyleBackColor = true;
            this.radioButtonRateHalf.CheckedChanged += new System.EventHandler(this.RadioButtonRateHalf_CheckedChanged);
            // 
            // radioButtonRate1
            // 
            this.radioButtonRate1.AutoSize = true;
            this.radioButtonRate1.Checked = true;
            this.radioButtonRate1.Location = new System.Drawing.Point(10, 18);
            this.radioButtonRate1.Name = "radioButtonRate1";
            this.radioButtonRate1.Size = new System.Drawing.Size(47, 16);
            this.radioButtonRate1.TabIndex = 0;
            this.radioButtonRate1.TabStop = true;
            this.radioButtonRate1.Text = "等倍";
            this.radioButtonRate1.UseVisualStyleBackColor = true;
            this.radioButtonRate1.CheckedChanged += new System.EventHandler(this.RadioButtonRate1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPrevColor2);
            this.groupBox1.Controls.Add(this.radioButtonPrevColor1);
            this.groupBox1.Location = new System.Drawing.Point(11, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(70, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "背景色";
            // 
            // radioButtonPrevColor2
            // 
            this.radioButtonPrevColor2.AutoSize = true;
            this.radioButtonPrevColor2.Location = new System.Drawing.Point(18, 41);
            this.radioButtonPrevColor2.Name = "radioButtonPrevColor2";
            this.radioButtonPrevColor2.Size = new System.Drawing.Size(35, 16);
            this.radioButtonPrevColor2.TabIndex = 1;
            this.radioButtonPrevColor2.Text = "灰";
            this.radioButtonPrevColor2.UseVisualStyleBackColor = true;
            this.radioButtonPrevColor2.CheckedChanged += new System.EventHandler(this.radioButtonPrevColor2_CheckedChanged);
            // 
            // radioButtonPrevColor1
            // 
            this.radioButtonPrevColor1.AutoSize = true;
            this.radioButtonPrevColor1.Checked = true;
            this.radioButtonPrevColor1.Location = new System.Drawing.Point(18, 18);
            this.radioButtonPrevColor1.Name = "radioButtonPrevColor1";
            this.radioButtonPrevColor1.Size = new System.Drawing.Size(35, 16);
            this.radioButtonPrevColor1.TabIndex = 0;
            this.radioButtonPrevColor1.TabStop = true;
            this.radioButtonPrevColor1.Text = "黒";
            this.radioButtonPrevColor1.UseVisualStyleBackColor = true;
            this.radioButtonPrevColor1.CheckedChanged += new System.EventHandler(this.radioButtonPrevColor1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelError);
            this.groupBox3.Controls.Add(this.comboBoxThinning);
            this.groupBox3.Controls.Add(this.labelTotal);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.numericUpDownOutputColumn);
            this.groupBox3.Controls.Add(this.comboBoxBackground);
            this.groupBox3.Controls.Add(this.numericUpDownOutputRow);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(22, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 179);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "出力の設定";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(94, 49);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 12);
            this.labelError.TabIndex = 3;
            // 
            // comboBoxThinning
            // 
            this.comboBoxThinning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThinning.FormattingEnabled = true;
            this.comboBoxThinning.Items.AddRange(new object[] {
            "0(飛ばさない)",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxThinning.Location = new System.Drawing.Point(16, 18);
            this.comboBoxThinning.Name = "comboBoxThinning";
            this.comboBoxThinning.Size = new System.Drawing.Size(100, 20);
            this.comboBoxThinning.TabIndex = 0;
            this.comboBoxThinning.SelectedIndexChanged += new System.EventHandler(this.ComboBoxThinning_SelectedIndexChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(15, 49);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(55, 12);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "合計：N個";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "個おきに飛ばす";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "出力画像の背景色";
            // 
            // numericUpDownOutputColumn
            // 
            this.numericUpDownOutputColumn.Location = new System.Drawing.Point(81, 95);
            this.numericUpDownOutputColumn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOutputColumn.Name = "numericUpDownOutputColumn";
            this.numericUpDownOutputColumn.Size = new System.Drawing.Size(46, 19);
            this.numericUpDownOutputColumn.TabIndex = 7;
            this.numericUpDownOutputColumn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOutputColumn.ValueChanged += new System.EventHandler(this.NumericUpDownOutputColumn_ValueChanged);
            // 
            // comboBoxBackground
            // 
            this.comboBoxBackground.FormattingEnabled = true;
            this.comboBoxBackground.Location = new System.Drawing.Point(14, 143);
            this.comboBoxBackground.Name = "comboBoxBackground";
            this.comboBoxBackground.Size = new System.Drawing.Size(135, 20);
            this.comboBoxBackground.TabIndex = 9;
            // 
            // numericUpDownOutputRow
            // 
            this.numericUpDownOutputRow.Location = new System.Drawing.Point(17, 95);
            this.numericUpDownOutputRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOutputRow.Name = "numericUpDownOutputRow";
            this.numericUpDownOutputRow.Size = new System.Drawing.Size(39, 19);
            this.numericUpDownOutputRow.TabIndex = 5;
            this.numericUpDownOutputRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOutputRow.ValueChanged += new System.EventHandler(this.NumericUpDownOutputRow_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "×";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(15, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "タテ×ヨコ/コマ数で指定";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonOriginalPrev);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxColumn);
            this.groupBox2.Controls.Add(this.comboBoxRow);
            this.groupBox2.Location = new System.Drawing.Point(22, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 115);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "分割数の設定";
            // 
            // buttonOriginalPrev
            // 
            this.buttonOriginalPrev.Location = new System.Drawing.Point(126, 75);
            this.buttonOriginalPrev.Name = "buttonOriginalPrev";
            this.buttonOriginalPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonOriginalPrev.TabIndex = 4;
            this.buttonOriginalPrev.Text = "プレビュー➡";
            this.buttonOriginalPrev.UseVisualStyleBackColor = true;
            this.buttonOriginalPrev.Click += new System.EventHandler(this.ButtonOriginalPrev_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "タテの分割数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "ヨコの分割数";
            // 
            // comboBoxColumn
            // 
            this.comboBoxColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColumn.FormattingEnabled = true;
            this.comboBoxColumn.Location = new System.Drawing.Point(41, 42);
            this.comboBoxColumn.Name = "comboBoxColumn";
            this.comboBoxColumn.Size = new System.Drawing.Size(53, 20);
            this.comboBoxColumn.TabIndex = 1;
            this.comboBoxColumn.SelectedIndexChanged += new System.EventHandler(this.ComboBoxColumn_SelectedIndexChanged);
            // 
            // comboBoxRow
            // 
            this.comboBoxRow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRow.FormattingEnabled = true;
            this.comboBoxRow.Location = new System.Drawing.Point(126, 42);
            this.comboBoxRow.Name = "comboBoxRow";
            this.comboBoxRow.Size = new System.Drawing.Size(53, 20);
            this.comboBoxRow.TabIndex = 3;
            this.comboBoxRow.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRow_SelectedIndexChanged);
            // 
            // checkBoxGridLine
            // 
            this.checkBoxGridLine.AutoSize = true;
            this.checkBoxGridLine.Checked = true;
            this.checkBoxGridLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGridLine.Location = new System.Drawing.Point(6, 97);
            this.checkBoxGridLine.Name = "checkBoxGridLine";
            this.checkBoxGridLine.Size = new System.Drawing.Size(80, 16);
            this.checkBoxGridLine.TabIndex = 2;
            this.checkBoxGridLine.Text = "グリッド表示";
            this.checkBoxGridLine.UseVisualStyleBackColor = true;
            this.checkBoxGridLine.CheckedChanged += new System.EventHandler(this.CheckBoxGridLine_CheckedChanged);
            // 
            // textBoxTargetPath
            // 
            this.textBoxTargetPath.Location = new System.Drawing.Point(22, 26);
            this.textBoxTargetPath.Name = "textBoxTargetPath";
            this.textBoxTargetPath.Size = new System.Drawing.Size(185, 19);
            this.textBoxTargetPath.TabIndex = 1;
            // 
            // buttonPreviewOutput
            // 
            this.buttonPreviewOutput.Location = new System.Drawing.Point(201, 425);
            this.buttonPreviewOutput.Name = "buttonPreviewOutput";
            this.buttonPreviewOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonPreviewOutput.TabIndex = 6;
            this.buttonPreviewOutput.Text = "プレビュー➡";
            this.buttonPreviewOutput.UseVisualStyleBackColor = true;
            this.buttonPreviewOutput.Click += new System.EventHandler(this.buttonPreviewOutput_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonOutput;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelImagePreview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SpriteSlimmer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.panelImagePreview.ResumeLayout(false);
            this.panelImagePreview.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutputColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutputRow)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Panel panelImagePreview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonPrevColor2;
        private System.Windows.Forms.RadioButton radioButtonPrevColor1;
        private System.Windows.Forms.Button buttonPreviewOutput;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRow;
        private System.Windows.Forms.ComboBox comboBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownOutputRow;
        private System.Windows.Forms.NumericUpDown numericUpDownOutputColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxThinning;
        private System.Windows.Forms.CheckBox checkBoxGridLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxBackground;
        private System.Windows.Forms.TextBox textBoxTargetPath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonOriginalPrev;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonRateQuart;
        private System.Windows.Forms.RadioButton radioButtonRateHalf;
        private System.Windows.Forms.RadioButton radioButtonRate1;
    }
}

