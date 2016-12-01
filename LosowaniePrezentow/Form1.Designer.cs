namespace LosowaniePrezentow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RandomPerson = new System.Windows.Forms.Button();
            this.MakeList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonChecked = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // RandomPerson
            // 
            this.RandomPerson.Location = new System.Drawing.Point(331, 51);
            this.RandomPerson.Name = "RandomPerson";
            this.RandomPerson.Size = new System.Drawing.Size(137, 23);
            this.RandomPerson.TabIndex = 0;
            this.RandomPerson.Text = "Losuj osobę!";
            this.RandomPerson.UseVisualStyleBackColor = true;
            this.RandomPerson.Click += new System.EventHandler(this.RandomPerson_Click);
            // 
            // MakeList
            // 
            this.MakeList.Location = new System.Drawing.Point(331, 94);
            this.MakeList.Name = "MakeList";
            this.MakeList.Size = new System.Drawing.Size(137, 23);
            this.MakeList.TabIndex = 1;
            this.MakeList.Text = "Dodaj osobę!";
            this.MakeList.UseVisualStyleBackColor = true;
            this.MakeList.Click += new System.EventHandler(this.MakeList_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Wyjście!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(433, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Copyright © All Rights Reserved";
            // 
            // PersonChecked
            // 
            this.PersonChecked.Location = new System.Drawing.Point(339, 15);
            this.PersonChecked.Name = "PersonChecked";
            this.PersonChecked.Size = new System.Drawing.Size(120, 20);
            this.PersonChecked.TabIndex = 5;
            this.PersonChecked.Text = "Wybierz losującego";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 352);
            this.Controls.Add(this.PersonChecked);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MakeList);
            this.Controls.Add(this.RandomPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Wylosuj sobie prezent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RandomPerson;
        private System.Windows.Forms.Button MakeList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown PersonChecked;
    }
}

