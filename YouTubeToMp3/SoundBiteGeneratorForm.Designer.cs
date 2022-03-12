
namespace YouTubeToMp3
{
   partial class SoundBiteGeneratorForm
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.txtYouTubeUrl = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.btnConvert = new System.Windows.Forms.Button();
         this.numSTHours = new System.Windows.Forms.NumericUpDown();
         this.label2 = new System.Windows.Forms.Label();
         this.numSTMinutes = new System.Windows.Forms.NumericUpDown();
         this.numSTSeconds = new System.Windows.Forms.NumericUpDown();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.numETSeconds = new System.Windows.Forms.NumericUpDown();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.numETMinutes = new System.Windows.Forms.NumericUpDown();
         this.label8 = new System.Windows.Forms.Label();
         this.numETHours = new System.Windows.Forms.NumericUpDown();
         this.txtFileName = new System.Windows.Forms.TextBox();
         this.label9 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.txtDestinationDirectory = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.btnSelectDirectory = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.numSTHours)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numSTMinutes)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numSTSeconds)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numETSeconds)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numETMinutes)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numETHours)).BeginInit();
         this.SuspendLayout();
         // 
         // txtYouTubeUrl
         // 
         this.txtYouTubeUrl.Location = new System.Drawing.Point(98, 15);
         this.txtYouTubeUrl.Name = "txtYouTubeUrl";
         this.txtYouTubeUrl.Size = new System.Drawing.Size(251, 23);
         this.txtYouTubeUrl.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 18);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(80, 15);
         this.label1.TabIndex = 1;
         this.label1.Text = "YouTube URL:";
         // 
         // btnConvert
         // 
         this.btnConvert.Location = new System.Drawing.Point(274, 200);
         this.btnConvert.Name = "btnConvert";
         this.btnConvert.Size = new System.Drawing.Size(75, 23);
         this.btnConvert.TabIndex = 2;
         this.btnConvert.Text = "Convert";
         this.btnConvert.UseVisualStyleBackColor = true;
         this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
         // 
         // numSTHours
         // 
         this.numSTHours.Location = new System.Drawing.Point(170, 54);
         this.numSTHours.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
         this.numSTHours.Name = "numSTHours";
         this.numSTHours.Size = new System.Drawing.Size(32, 23);
         this.numSTHours.TabIndex = 3;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 56);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(155, 15);
         this.label2.TabIndex = 4;
         this.label2.Text = "Start Time (HH:MM:SS.ssss):";
         // 
         // numSTMinutes
         // 
         this.numSTMinutes.Location = new System.Drawing.Point(224, 54);
         this.numSTMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
         this.numSTMinutes.Name = "numSTMinutes";
         this.numSTMinutes.Size = new System.Drawing.Size(32, 23);
         this.numSTMinutes.TabIndex = 5;
         // 
         // numSTSeconds
         // 
         this.numSTSeconds.DecimalPlaces = 4;
         this.numSTSeconds.Location = new System.Drawing.Point(278, 54);
         this.numSTSeconds.Maximum = new decimal(new int[] {
            599999,
            0,
            0,
            262144});
         this.numSTSeconds.Name = "numSTSeconds";
         this.numSTSeconds.Size = new System.Drawing.Size(71, 23);
         this.numSTSeconds.TabIndex = 9;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(208, 56);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(10, 15);
         this.label4.TabIndex = 7;
         this.label4.Text = ":";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(262, 56);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(10, 15);
         this.label3.TabIndex = 6;
         this.label3.Text = ":";
         // 
         // numETSeconds
         // 
         this.numETSeconds.DecimalPlaces = 4;
         this.numETSeconds.Location = new System.Drawing.Point(278, 90);
         this.numETSeconds.Maximum = new decimal(new int[] {
            599999,
            0,
            0,
            262144});
         this.numETSeconds.Name = "numETSeconds";
         this.numETSeconds.Size = new System.Drawing.Size(71, 23);
         this.numETSeconds.TabIndex = 17;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(208, 92);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(10, 15);
         this.label6.TabIndex = 16;
         this.label6.Text = ":";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(262, 92);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(10, 15);
         this.label7.TabIndex = 15;
         this.label7.Text = ":";
         // 
         // numETMinutes
         // 
         this.numETMinutes.Location = new System.Drawing.Point(224, 90);
         this.numETMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
         this.numETMinutes.Name = "numETMinutes";
         this.numETMinutes.Size = new System.Drawing.Size(32, 23);
         this.numETMinutes.TabIndex = 14;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(12, 92);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(151, 15);
         this.label8.TabIndex = 13;
         this.label8.Text = "End Time (HH:MM:SS.ssss):";
         // 
         // numETHours
         // 
         this.numETHours.Location = new System.Drawing.Point(170, 90);
         this.numETHours.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
         this.numETHours.Name = "numETHours";
         this.numETHours.Size = new System.Drawing.Size(32, 23);
         this.numETHours.TabIndex = 12;
         // 
         // txtFileName
         // 
         this.txtFileName.Location = new System.Drawing.Point(81, 122);
         this.txtFileName.Name = "txtFileName";
         this.txtFileName.Size = new System.Drawing.Size(175, 23);
         this.txtFileName.TabIndex = 19;
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(12, 125);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(63, 15);
         this.label9.TabIndex = 20;
         this.label9.Text = "File Name:";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(258, 126);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(34, 15);
         this.label10.TabIndex = 21;
         this.label10.Text = ".mp3";
         // 
         // txtDestinationDirectory
         // 
         this.txtDestinationDirectory.Location = new System.Drawing.Point(88, 155);
         this.txtDestinationDirectory.Name = "txtDestinationDirectory";
         this.txtDestinationDirectory.Size = new System.Drawing.Size(225, 23);
         this.txtDestinationDirectory.TabIndex = 22;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(12, 158);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(70, 15);
         this.label5.TabIndex = 23;
         this.label5.Text = "Destination:";
         // 
         // btnSelectDirectory
         // 
         this.btnSelectDirectory.Location = new System.Drawing.Point(319, 154);
         this.btnSelectDirectory.Name = "btnSelectDirectory";
         this.btnSelectDirectory.Size = new System.Drawing.Size(30, 23);
         this.btnSelectDirectory.TabIndex = 24;
         this.btnSelectDirectory.Text = "...";
         this.btnSelectDirectory.UseVisualStyleBackColor = true;
         this.btnSelectDirectory.Click += new System.EventHandler(this.btnSelectDirectory_Click);
         // 
         // SoundBiteGeneratorForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(361, 238);
         this.Controls.Add(this.btnSelectDirectory);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.txtDestinationDirectory);
         this.Controls.Add(this.label10);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.txtFileName);
         this.Controls.Add(this.numETSeconds);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.numETMinutes);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.numETHours);
         this.Controls.Add(this.numSTSeconds);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.numSTMinutes);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.numSTHours);
         this.Controls.Add(this.btnConvert);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtYouTubeUrl);
         this.MaximizeBox = false;
         this.MaximumSize = new System.Drawing.Size(377, 277);
         this.MinimumSize = new System.Drawing.Size(377, 277);
         this.Name = "SoundBiteGeneratorForm";
         this.Text = "Soundbite Generator";
         ((System.ComponentModel.ISupportInitialize)(this.numSTHours)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numSTMinutes)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numSTSeconds)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numETSeconds)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numETMinutes)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numETHours)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtYouTubeUrl;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnConvert;
      private System.Windows.Forms.NumericUpDown numSTHours;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.NumericUpDown numSTMinutes;
      private System.Windows.Forms.NumericUpDown numSTSeconds;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.NumericUpDown numETSeconds;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.NumericUpDown numETMinutes;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.NumericUpDown numETHours;
      private System.Windows.Forms.TextBox txtFileName;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.TextBox txtDestinationDirectory;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Button btnSelectDirectory;
   }
}

