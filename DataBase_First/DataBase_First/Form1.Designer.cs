namespace DataBase_First
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.filter_tb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.fn_radio = new MaterialSkin.Controls.MaterialRadioButton();
            this.ln_radio = new MaterialSkin.Controls.MaterialRadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.nb_radio = new MaterialSkin.Controls.MaterialRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // filter_tb
            // 
            this.filter_tb.Depth = 0;
            this.filter_tb.Hint = "";
            this.filter_tb.Location = new System.Drawing.Point(34, 98);
            this.filter_tb.MouseState = MaterialSkin.MouseState.HOVER;
            this.filter_tb.Name = "filter_tb";
            this.filter_tb.PasswordChar = '\0';
            this.filter_tb.SelectedText = "";
            this.filter_tb.SelectionLength = 0;
            this.filter_tb.SelectionStart = 0;
            this.filter_tb.Size = new System.Drawing.Size(367, 23);
            this.filter_tb.TabIndex = 0;
            this.filter_tb.UseSystemPasswordChar = false;
            this.filter_tb.TextChanged += new System.EventHandler(this.filter_tb_TextChanged);
            // 
            // fn_radio
            // 
            this.fn_radio.AutoSize = true;
            this.fn_radio.Depth = 0;
            this.fn_radio.Font = new System.Drawing.Font("Roboto", 10F);
            this.fn_radio.Location = new System.Drawing.Point(444, 90);
            this.fn_radio.Margin = new System.Windows.Forms.Padding(0);
            this.fn_radio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.fn_radio.MouseState = MaterialSkin.MouseState.HOVER;
            this.fn_radio.Name = "fn_radio";
            this.fn_radio.Ripple = true;
            this.fn_radio.Size = new System.Drawing.Size(93, 30);
            this.fn_radio.TabIndex = 1;
            this.fn_radio.TabStop = true;
            this.fn_radio.Text = "FirstName";
            this.fn_radio.UseVisualStyleBackColor = true;
            // 
            // ln_radio
            // 
            this.ln_radio.AutoSize = true;
            this.ln_radio.Depth = 0;
            this.ln_radio.Font = new System.Drawing.Font("Roboto", 10F);
            this.ln_radio.Location = new System.Drawing.Point(560, 90);
            this.ln_radio.Margin = new System.Windows.Forms.Padding(0);
            this.ln_radio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ln_radio.MouseState = MaterialSkin.MouseState.HOVER;
            this.ln_radio.Name = "ln_radio";
            this.ln_radio.Ripple = true;
            this.ln_radio.Size = new System.Drawing.Size(92, 30);
            this.ln_radio.TabIndex = 2;
            this.ln_radio.TabStop = true;
            this.ln_radio.Text = "LastName";
            this.ln_radio.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(34, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(618, 396);
            this.dataGridView1.TabIndex = 3;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(818, 172);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(175, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(684, 177);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(113, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Maximum Price";
            // 
            // nb_radio
            // 
            this.nb_radio.AutoSize = true;
            this.nb_radio.Depth = 0;
            this.nb_radio.Font = new System.Drawing.Font("Roboto", 10F);
            this.nb_radio.Location = new System.Drawing.Point(673, 90);
            this.nb_radio.Margin = new System.Windows.Forms.Padding(0);
            this.nb_radio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.nb_radio.MouseState = MaterialSkin.MouseState.HOVER;
            this.nb_radio.Name = "nb_radio";
            this.nb_radio.Ripple = true;
            this.nb_radio.Size = new System.Drawing.Size(100, 30);
            this.nb_radio.TabIndex = 6;
            this.nb_radio.TabStop = true;
            this.nb_radio.Text = "Name Book";
            this.nb_radio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 595);
            this.Controls.Add(this.nb_radio);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ln_radio);
            this.Controls.Add(this.fn_radio);
            this.Controls.Add(this.filter_tb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField filter_tb;
        private MaterialSkin.Controls.MaterialRadioButton fn_radio;
        private MaterialSkin.Controls.MaterialRadioButton ln_radio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TrackBar trackBar1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton nb_radio;
    }
}

