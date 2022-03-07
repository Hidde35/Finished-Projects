
namespace ConnectArduino_Base
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxArduino = new System.Windows.Forms.GroupBox();
            this.ButtonStopArduino = new System.Windows.Forms.Button();
            this.ShowArduinoText = new System.Windows.Forms.TextBox();
            this.buttonReadArduino = new System.Windows.Forms.Button();
            this.groupBoxConnecting = new System.Windows.Forms.GroupBox();
            this.textComString = new System.Windows.Forms.NumericUpDown();
            this.textReadConnected = new System.Windows.Forms.TextBox();
            this.textReadNotConnected = new System.Windows.Forms.TextBox();
            this.textColorNotConnected = new System.Windows.Forms.RichTextBox();
            this.textColorConnected = new System.Windows.Forms.RichTextBox();
            this.textReadConnect = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.timerReadArduino = new System.Windows.Forms.Timer(this.components);
            this.groupBoxArduino.SuspendLayout();
            this.groupBoxConnecting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textComString)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxArduino
            // 
            this.groupBoxArduino.Controls.Add(this.ButtonStopArduino);
            this.groupBoxArduino.Controls.Add(this.ShowArduinoText);
            this.groupBoxArduino.Controls.Add(this.buttonReadArduino);
            this.groupBoxArduino.Location = new System.Drawing.Point(416, 142);
            this.groupBoxArduino.Name = "groupBoxArduino";
            this.groupBoxArduino.Size = new System.Drawing.Size(288, 166);
            this.groupBoxArduino.TabIndex = 13;
            this.groupBoxArduino.TabStop = false;
            this.groupBoxArduino.Text = "Arduino";
            // 
            // ButtonStopArduino
            // 
            this.ButtonStopArduino.Location = new System.Drawing.Point(18, 101);
            this.ButtonStopArduino.Name = "ButtonStopArduino";
            this.ButtonStopArduino.Size = new System.Drawing.Size(149, 50);
            this.ButtonStopArduino.TabIndex = 5;
            this.ButtonStopArduino.Text = "StopReading";
            this.ButtonStopArduino.UseVisualStyleBackColor = true;
            this.ButtonStopArduino.Click += new System.EventHandler(this.ButtonStopArduino_Click);
            // 
            // ShowArduinoText
            // 
            this.ShowArduinoText.Location = new System.Drawing.Point(194, 75);
            this.ShowArduinoText.Name = "ShowArduinoText";
            this.ShowArduinoText.ReadOnly = true;
            this.ShowArduinoText.Size = new System.Drawing.Size(72, 20);
            this.ShowArduinoText.TabIndex = 4;
            // 
            // buttonReadArduino
            // 
            this.buttonReadArduino.Location = new System.Drawing.Point(18, 40);
            this.buttonReadArduino.Name = "buttonReadArduino";
            this.buttonReadArduino.Size = new System.Drawing.Size(149, 55);
            this.buttonReadArduino.TabIndex = 3;
            this.buttonReadArduino.Text = "ReadArduino";
            this.buttonReadArduino.UseVisualStyleBackColor = true;
            this.buttonReadArduino.Click += new System.EventHandler(this.buttonReadArduino_Click);
            // 
            // groupBoxConnecting
            // 
            this.groupBoxConnecting.Controls.Add(this.textComString);
            this.groupBoxConnecting.Controls.Add(this.textReadConnected);
            this.groupBoxConnecting.Controls.Add(this.textReadNotConnected);
            this.groupBoxConnecting.Controls.Add(this.textColorNotConnected);
            this.groupBoxConnecting.Controls.Add(this.textColorConnected);
            this.groupBoxConnecting.Controls.Add(this.textReadConnect);
            this.groupBoxConnecting.Controls.Add(this.buttonConnect);
            this.groupBoxConnecting.Location = new System.Drawing.Point(84, 142);
            this.groupBoxConnecting.Name = "groupBoxConnecting";
            this.groupBoxConnecting.Size = new System.Drawing.Size(288, 167);
            this.groupBoxConnecting.TabIndex = 12;
            this.groupBoxConnecting.TabStop = false;
            this.groupBoxConnecting.Text = "Connecting";
            // 
            // textComString
            // 
            this.textComString.Location = new System.Drawing.Point(18, 53);
            this.textComString.Name = "textComString";
            this.textComString.Size = new System.Drawing.Size(100, 20);
            this.textComString.TabIndex = 14;
            this.textComString.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textReadConnected
            // 
            this.textReadConnected.BackColor = System.Drawing.Color.Lime;
            this.textReadConnected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textReadConnected.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReadConnected.ForeColor = System.Drawing.SystemColors.Menu;
            this.textReadConnected.Location = new System.Drawing.Point(50, 115);
            this.textReadConnected.Name = "textReadConnected";
            this.textReadConnected.ReadOnly = true;
            this.textReadConnected.Size = new System.Drawing.Size(182, 23);
            this.textReadConnected.TabIndex = 13;
            this.textReadConnected.Text = "You are Connected!";
            this.textReadConnected.Visible = false;
            // 
            // textReadNotConnected
            // 
            this.textReadNotConnected.BackColor = System.Drawing.Color.Red;
            this.textReadNotConnected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textReadNotConnected.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReadNotConnected.ForeColor = System.Drawing.SystemColors.Menu;
            this.textReadNotConnected.Location = new System.Drawing.Point(57, 117);
            this.textReadNotConnected.Name = "textReadNotConnected";
            this.textReadNotConnected.ReadOnly = true;
            this.textReadNotConnected.Size = new System.Drawing.Size(175, 19);
            this.textReadNotConnected.TabIndex = 11;
            this.textReadNotConnected.Text = "You are not Connected!";
            // 
            // textColorNotConnected
            // 
            this.textColorNotConnected.BackColor = System.Drawing.Color.Red;
            this.textColorNotConnected.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textColorNotConnected.ForeColor = System.Drawing.SystemColors.Info;
            this.textColorNotConnected.Location = new System.Drawing.Point(18, 91);
            this.textColorNotConnected.Name = "textColorNotConnected";
            this.textColorNotConnected.ReadOnly = true;
            this.textColorNotConnected.Size = new System.Drawing.Size(248, 70);
            this.textColorNotConnected.TabIndex = 10;
            this.textColorNotConnected.Text = "";
            // 
            // textColorConnected
            // 
            this.textColorConnected.BackColor = System.Drawing.Color.Lime;
            this.textColorConnected.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textColorConnected.ForeColor = System.Drawing.SystemColors.Info;
            this.textColorConnected.Location = new System.Drawing.Point(18, 91);
            this.textColorConnected.Name = "textColorConnected";
            this.textColorConnected.ReadOnly = true;
            this.textColorConnected.Size = new System.Drawing.Size(248, 70);
            this.textColorConnected.TabIndex = 12;
            this.textColorConnected.Text = "";
            this.textColorConnected.Visible = false;
            // 
            // textReadConnect
            // 
            this.textReadConnect.Location = new System.Drawing.Point(18, 19);
            this.textReadConnect.Name = "textReadConnect";
            this.textReadConnect.ReadOnly = true;
            this.textReadConnect.Size = new System.Drawing.Size(100, 20);
            this.textReadConnect.TabIndex = 9;
            this.textReadConnect.Text = "What is your port:";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(131, 19);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(151, 55);
            this.buttonConnect.TabIndex = 8;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // timerReadArduino
            // 
            this.timerReadArduino.Interval = 250;
            this.timerReadArduino.Tick += new System.EventHandler(this.timerReadArduino_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxArduino);
            this.Controls.Add(this.groupBoxConnecting);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxArduino.ResumeLayout(false);
            this.groupBoxArduino.PerformLayout();
            this.groupBoxConnecting.ResumeLayout(false);
            this.groupBoxConnecting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textComString)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxArduino;
        private System.Windows.Forms.Button ButtonStopArduino;
        private System.Windows.Forms.TextBox ShowArduinoText;
        private System.Windows.Forms.Button buttonReadArduino;
        private System.Windows.Forms.GroupBox groupBoxConnecting;
        private System.Windows.Forms.NumericUpDown textComString;
        private System.Windows.Forms.TextBox textReadConnected;
        private System.Windows.Forms.TextBox textReadNotConnected;
        private System.Windows.Forms.RichTextBox textColorNotConnected;
        private System.Windows.Forms.RichTextBox textColorConnected;
        private System.Windows.Forms.TextBox textReadConnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Timer timerReadArduino;
    }
}

