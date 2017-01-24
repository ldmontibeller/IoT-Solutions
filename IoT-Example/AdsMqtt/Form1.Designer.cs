namespace AdsMqtt
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
            this.button_ReadTcData = new System.Windows.Forms.Button();
            this.button_WriteMqttData = new System.Windows.Forms.Button();
            this.textBox_Data = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_ReadTcData
            // 
            this.button_ReadTcData.Location = new System.Drawing.Point(34, 29);
            this.button_ReadTcData.Name = "button_ReadTcData";
            this.button_ReadTcData.Size = new System.Drawing.Size(157, 40);
            this.button_ReadTcData.TabIndex = 0;
            this.button_ReadTcData.Text = "Read data from TwinCAT";
            this.button_ReadTcData.UseVisualStyleBackColor = true;
            this.button_ReadTcData.Click += new System.EventHandler(this.button_ReadTcData_Click);
            // 
            // button_WriteMqttData
            // 
            this.button_WriteMqttData.Location = new System.Drawing.Point(197, 29);
            this.button_WriteMqttData.Name = "button_WriteMqttData";
            this.button_WriteMqttData.Size = new System.Drawing.Size(157, 40);
            this.button_WriteMqttData.TabIndex = 1;
            this.button_WriteMqttData.Text = "Write Data to MQTT Broker";
            this.button_WriteMqttData.UseVisualStyleBackColor = true;
            this.button_WriteMqttData.Click += new System.EventHandler(this.button_WriteMqttData_Click);
            // 
            // textBox_Data
            // 
            this.textBox_Data.Location = new System.Drawing.Point(143, 75);
            this.textBox_Data.Name = "textBox_Data";
            this.textBox_Data.Size = new System.Drawing.Size(100, 20);
            this.textBox_Data.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 109);
            this.Controls.Add(this.textBox_Data);
            this.Controls.Add(this.button_WriteMqttData);
            this.Controls.Add(this.button_ReadTcData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ReadTcData;
        private System.Windows.Forms.Button button_WriteMqttData;
        private System.Windows.Forms.TextBox textBox_Data;
    }
}

