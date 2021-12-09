
namespace RiotApiForm
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
            this.API_Key_Text_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Summoners_Name_Search_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.Summoner_Level_Text_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Summoner_ID_Text_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Summoners_Name_Box = new System.Windows.Forms.TextBox();
            this.Summoners_Icon_ID_Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Summoners_Region_Search_Box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // API_Key_Text_Box
            // 
            this.API_Key_Text_Box.Location = new System.Drawing.Point(12, 23);
            this.API_Key_Text_Box.Name = "API_Key_Text_Box";
            this.API_Key_Text_Box.Size = new System.Drawing.Size(459, 20);
            this.API_Key_Text_Box.TabIndex = 0;
            this.API_Key_Text_Box.TextChanged += new System.EventHandler(this.API_Key_Text_Box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter an API Code";
            // 
            // Summoners_Name_Search_Box
            // 
            this.Summoners_Name_Search_Box.Location = new System.Drawing.Point(12, 67);
            this.Summoners_Name_Search_Box.Name = "Summoners_Name_Search_Box";
            this.Summoners_Name_Search_Box.Size = new System.Drawing.Size(230, 20);
            this.Summoners_Name_Search_Box.TabIndex = 2;
            this.Summoners_Name_Search_Box.TextChanged += new System.EventHandler(this.Summoners_Name_Search_Box_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search By Summoner\'s Name";
            // 
            // Submit_Button
            // 
            this.Submit_Button.Location = new System.Drawing.Point(396, 67);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(75, 23);
            this.Submit_Button.TabIndex = 4;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // Summoner_Level_Text_Box
            // 
            this.Summoner_Level_Text_Box.Location = new System.Drawing.Point(655, 23);
            this.Summoner_Level_Text_Box.Name = "Summoner_Level_Text_Box";
            this.Summoner_Level_Text_Box.Size = new System.Drawing.Size(91, 20);
            this.Summoner_Level_Text_Box.TabIndex = 5;
            this.Summoner_Level_Text_Box.TextChanged += new System.EventHandler(this.Summoner_Level_Text_Box_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(653, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Summoner\'s Level";
            // 
            // Summoner_ID_Text_Box
            // 
            this.Summoner_ID_Text_Box.Location = new System.Drawing.Point(655, 70);
            this.Summoner_ID_Text_Box.Name = "Summoner_ID_Text_Box";
            this.Summoner_ID_Text_Box.Size = new System.Drawing.Size(100, 20);
            this.Summoner_ID_Text_Box.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(668, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Summoner\'s ID";
            // 
            // Summoners_Name_Box
            // 
            this.Summoners_Name_Box.Location = new System.Drawing.Point(521, 23);
            this.Summoners_Name_Box.Name = "Summoners_Name_Box";
            this.Summoners_Name_Box.Size = new System.Drawing.Size(100, 20);
            this.Summoners_Name_Box.TabIndex = 9;
            // 
            // Summoners_Icon_ID_Box
            // 
            this.Summoners_Icon_ID_Box.Location = new System.Drawing.Point(521, 70);
            this.Summoners_Icon_ID_Box.Name = "Summoners_Icon_ID_Box";
            this.Summoners_Icon_ID_Box.Size = new System.Drawing.Size(100, 20);
            this.Summoners_Icon_ID_Box.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Summoner\'s Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Summoner\'s Profile Icon ID";
            // 
            // Summoners_Region_Search_Box
            // 
            this.Summoners_Region_Search_Box.Location = new System.Drawing.Point(266, 67);
            this.Summoners_Region_Search_Box.Name = "Summoners_Region_Search_Box";
            this.Summoners_Region_Search_Box.Size = new System.Drawing.Size(100, 20);
            this.Summoners_Region_Search_Box.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Summoner\'s Region";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Summoners_Region_Search_Box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Summoners_Icon_ID_Box);
            this.Controls.Add(this.Summoners_Name_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Summoner_ID_Text_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Summoner_Level_Text_Box);
            this.Controls.Add(this.Submit_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Summoners_Name_Search_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.API_Key_Text_Box);
            this.Name = "Form1";
            this.Text = "Riot Games API (League of Legends)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox API_Key_Text_Box;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Summoners_Name_Search_Box;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button Submit_Button;
        public System.Windows.Forms.TextBox Summoner_Level_Text_Box;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Summoner_ID_Text_Box;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Summoners_Name_Box;
        public System.Windows.Forms.TextBox Summoners_Icon_ID_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox Summoners_Region_Search_Box;
        private System.Windows.Forms.Label label7;
    }
}

