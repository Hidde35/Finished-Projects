namespace ControllerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSensoren = new System.Windows.Forms.Button();
            this.textInfoHandschoen = new System.Windows.Forms.RichTextBox();
            this.buttonReadArduino = new System.Windows.Forms.Button();
            this.groupBoxArduino = new System.Windows.Forms.GroupBox();
            this.ButtonStopArduino = new System.Windows.Forms.Button();
            this.ShowArduinoText = new System.Windows.Forms.TextBox();
            this.textComString = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBoxConnecting = new System.Windows.Forms.GroupBox();
            this.textReadConnected = new System.Windows.Forms.TextBox();
            this.textReadNotConnected = new System.Windows.Forms.TextBox();
            this.textColorConnected = new System.Windows.Forms.RichTextBox();
            this.textColorNotConnected = new System.Windows.Forms.RichTextBox();
            this.textReadConnect = new System.Windows.Forms.TextBox();
            this.timerReadArduino = new System.Windows.Forms.Timer(this.components);
            this.PictureHandschoen = new System.Windows.Forms.PictureBox();
            this.ArrowLeft = new System.Windows.Forms.PictureBox();
            this.ArrowDown = new System.Windows.Forms.PictureBox();
            this.ArrowUp = new System.Windows.Forms.PictureBox();
            this.ArrowRight = new System.Windows.Forms.PictureBox();
            this.buttonPlayDeadMelodie = new System.Windows.Forms.Button();
            this.groupBoxArduino.SuspendLayout();
            this.groupBoxConnecting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureHandschoen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowRight)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSensoren
            // 
            this.buttonSensoren.Location = new System.Drawing.Point(54, 64);
            this.buttonSensoren.Name = "buttonSensoren";
            this.buttonSensoren.Size = new System.Drawing.Size(151, 53);
            this.buttonSensoren.TabIndex = 1;
            this.buttonSensoren.Text = "Sensoren";
            this.buttonSensoren.UseVisualStyleBackColor = true;
            this.buttonSensoren.Click += new System.EventHandler(this.ShowData_Click_1);
            // 
            // textInfoHandschoen
            // 
            this.textInfoHandschoen.BackColor = System.Drawing.SystemColors.Control;
            this.textInfoHandschoen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInfoHandschoen.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInfoHandschoen.Location = new System.Drawing.Point(263, 12);
            this.textInfoHandschoen.Name = "textInfoHandschoen";
            this.textInfoHandschoen.ReadOnly = true;
            this.textInfoHandschoen.Size = new System.Drawing.Size(249, 51);
            this.textInfoHandschoen.TabIndex = 2;
            this.textInfoHandschoen.Text = "Info Handschoen";
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
            // groupBoxArduino
            // 
            this.groupBoxArduino.Controls.Add(this.ButtonStopArduino);
            this.groupBoxArduino.Controls.Add(this.ShowArduinoText);
            this.groupBoxArduino.Controls.Add(this.buttonReadArduino);
            this.groupBoxArduino.Location = new System.Drawing.Point(484, 252);
            this.groupBoxArduino.Name = "groupBoxArduino";
            this.groupBoxArduino.Size = new System.Drawing.Size(288, 166);
            this.groupBoxArduino.TabIndex = 5;
            this.groupBoxArduino.TabStop = false;
            this.groupBoxArduino.Text = "Arduino";
            // 
            // ButtonStopArduino
            // 
            this.ButtonStopArduino.Location = new System.Drawing.Point(18, 101);
            this.ButtonStopArduino.Name = "ButtonStopArduino";
            this.ButtonStopArduino.Size = new System.Drawing.Size(149, 50);
            this.ButtonStopArduino.TabIndex = 5;
            this.ButtonStopArduino.Text = "StopArduino";
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
            // textComString
            // 
            this.textComString.Location = new System.Drawing.Point(18, 54);
            this.textComString.Name = "textComString";
            this.textComString.Size = new System.Drawing.Size(100, 20);
            this.textComString.TabIndex = 6;
            this.textComString.TextChanged += new System.EventHandler(this.textComString_TextChanged);
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
            // groupBoxConnecting
            // 
            this.groupBoxConnecting.Controls.Add(this.textReadConnected);
            this.groupBoxConnecting.Controls.Add(this.textReadNotConnected);
            this.groupBoxConnecting.Controls.Add(this.textColorNotConnected);
            this.groupBoxConnecting.Controls.Add(this.textColorConnected);
            this.groupBoxConnecting.Controls.Add(this.textReadConnect);
            this.groupBoxConnecting.Controls.Add(this.textComString);
            this.groupBoxConnecting.Controls.Add(this.buttonConnect);
            this.groupBoxConnecting.Location = new System.Drawing.Point(484, 69);
            this.groupBoxConnecting.Name = "groupBoxConnecting";
            this.groupBoxConnecting.Size = new System.Drawing.Size(288, 167);
            this.groupBoxConnecting.TabIndex = 9;
            this.groupBoxConnecting.TabStop = false;
            this.groupBoxConnecting.Text = "Connecting";
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
            // textReadConnect
            // 
            this.textReadConnect.Location = new System.Drawing.Point(18, 19);
            this.textReadConnect.Name = "textReadConnect";
            this.textReadConnect.ReadOnly = true;
            this.textReadConnect.Size = new System.Drawing.Size(100, 20);
            this.textReadConnect.TabIndex = 9;
            this.textReadConnect.Text = "What is your port:";
            // 
            // timerReadArduino
            // 
            this.timerReadArduino.Interval = 250;
            this.timerReadArduino.Tick += new System.EventHandler(this.TimerTickReadArduino);
            // 
            // PictureHandschoen
            // 
            this.PictureHandschoen.Image = global::ControllerApp.Properties.Resources.images;
            this.PictureHandschoen.Location = new System.Drawing.Point(103, 132);
            this.PictureHandschoen.Name = "PictureHandschoen";
            this.PictureHandschoen.Size = new System.Drawing.Size(253, 306);
            this.PictureHandschoen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureHandschoen.TabIndex = 14;
            this.PictureHandschoen.TabStop = false;
            // 
            // ArrowLeft
            // 
            this.ArrowLeft.Image = global::ControllerApp.Properties.Resources.ArrowLeft;
            this.ArrowLeft.Location = new System.Drawing.Point(71, 142);
            this.ArrowLeft.Name = "ArrowLeft";
            this.ArrowLeft.Size = new System.Drawing.Size(332, 276);
            this.ArrowLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ArrowLeft.TabIndex = 13;
            this.ArrowLeft.TabStop = false;
            this.ArrowLeft.Visible = false;
            // 
            // ArrowDown
            // 
            this.ArrowDown.Image = global::ControllerApp.Properties.Resources.ArrowDown;
            this.ArrowDown.Location = new System.Drawing.Point(110, 141);
            this.ArrowDown.Name = "ArrowDown";
            this.ArrowDown.Size = new System.Drawing.Size(246, 333);
            this.ArrowDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ArrowDown.TabIndex = 12;
            this.ArrowDown.TabStop = false;
            this.ArrowDown.Visible = false;
            // 
            // ArrowUp
            // 
            this.ArrowUp.Image = global::ControllerApp.Properties.Resources.IjKBRmO;
            this.ArrowUp.Location = new System.Drawing.Point(110, 123);
            this.ArrowUp.Name = "ArrowUp";
            this.ArrowUp.Size = new System.Drawing.Size(239, 333);
            this.ArrowUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ArrowUp.TabIndex = 11;
            this.ArrowUp.TabStop = false;
            this.ArrowUp.Visible = false;
            // 
            // ArrowRight
            // 
            this.ArrowRight.Image = ((System.Drawing.Image)(resources.GetObject("ArrowRight.Image")));
            this.ArrowRight.Location = new System.Drawing.Point(54, 128);
            this.ArrowRight.Name = "ArrowRight";
            this.ArrowRight.Size = new System.Drawing.Size(384, 308);
            this.ArrowRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ArrowRight.TabIndex = 10;
            this.ArrowRight.TabStop = false;
            this.ArrowRight.Visible = false;
            // 
            // buttonPlayDeadMelodie
            // 
            this.buttonPlayDeadMelodie.Enabled = false;
            this.buttonPlayDeadMelodie.Location = new System.Drawing.Point(252, 64);
            this.buttonPlayDeadMelodie.Name = "buttonPlayDeadMelodie";
            this.buttonPlayDeadMelodie.Size = new System.Drawing.Size(151, 53);
            this.buttonPlayDeadMelodie.TabIndex = 15;
            this.buttonPlayDeadMelodie.Text = "PlayDeadMelodie";
            this.buttonPlayDeadMelodie.UseVisualStyleBackColor = true;
            this.buttonPlayDeadMelodie.Click += new System.EventHandler(this.buttonPlayDeadMelodie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPlayDeadMelodie);
            this.Controls.Add(this.PictureHandschoen);
            this.Controls.Add(this.ArrowLeft);
            this.Controls.Add(this.ArrowDown);
            this.Controls.Add(this.ArrowUp);
            this.Controls.Add(this.ArrowRight);
            this.Controls.Add(this.groupBoxConnecting);
            this.Controls.Add(this.groupBoxArduino);
            this.Controls.Add(this.textInfoHandschoen);
            this.Controls.Add(this.buttonSensoren);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxArduino.ResumeLayout(false);
            this.groupBoxArduino.PerformLayout();
            this.groupBoxConnecting.ResumeLayout(false);
            this.groupBoxConnecting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureHandschoen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSensoren;
        private System.Windows.Forms.RichTextBox textInfoHandschoen;
        private System.Windows.Forms.Button buttonReadArduino;
        private System.Windows.Forms.GroupBox groupBoxArduino;
        private System.Windows.Forms.TextBox textComString;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBoxConnecting;
        private System.Windows.Forms.TextBox textReadNotConnected;
        private System.Windows.Forms.RichTextBox textColorNotConnected;
        private System.Windows.Forms.TextBox textReadConnect;
        private System.Windows.Forms.RichTextBox textColorConnected;
        private System.Windows.Forms.TextBox textReadConnected;
        private System.Windows.Forms.PictureBox ArrowRight;
        private System.Windows.Forms.PictureBox ArrowUp;
        private System.Windows.Forms.PictureBox ArrowDown;
        private System.Windows.Forms.PictureBox ArrowLeft;
        private System.Windows.Forms.TextBox ShowArduinoText;
        private System.Windows.Forms.Timer timerReadArduino;
        private System.Windows.Forms.Button ButtonStopArduino;
        private System.Windows.Forms.PictureBox PictureHandschoen;
        private System.Windows.Forms.Button buttonPlayDeadMelodie;
    }
}

