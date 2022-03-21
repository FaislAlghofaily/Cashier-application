
namespace WindowsFormsApp1
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
            this.finishbill = new System.Windows.Forms.Button();
            this.deleteproduct = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.edit = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.save = new System.Windows.Forms.Button();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cucumber = new System.Windows.Forms.Button();
            this.pumpkin = new System.Windows.Forms.Button();
            this.carrot = new System.Windows.Forms.Button();
            this.corn = new System.Windows.Forms.Button();
            this.lettuce = new System.Windows.Forms.Button();
            this.onion = new System.Windows.Forms.Button();
            this.potato = new System.Windows.Forms.Button();
            this.tomato = new System.Windows.Forms.Button();
            this.watermelon = new System.Windows.Forms.Button();
            this.avocado = new System.Windows.Forms.Button();
            this.mango = new System.Windows.Forms.Button();
            this.strawberry = new System.Windows.Forms.Button();
            this.grapes = new System.Windows.Forms.Button();
            this.banana = new System.Windows.Forms.Button();
            this.orange = new System.Windows.Forms.Button();
            this.apples = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // finishbill
            // 
            this.finishbill.BackColor = System.Drawing.Color.Green;
            this.finishbill.Location = new System.Drawing.Point(898, 636);
            this.finishbill.Name = "finishbill";
            this.finishbill.Size = new System.Drawing.Size(156, 99);
            this.finishbill.TabIndex = 16;
            this.finishbill.Text = "pay";
            this.finishbill.UseVisualStyleBackColor = false;
            this.finishbill.Click += new System.EventHandler(this.pay);
            // 
            // deleteproduct
            // 
            this.deleteproduct.BackColor = System.Drawing.Color.DarkRed;
            this.deleteproduct.Location = new System.Drawing.Point(898, 595);
            this.deleteproduct.Name = "deleteproduct";
            this.deleteproduct.Size = new System.Drawing.Size(156, 35);
            this.deleteproduct.TabIndex = 17;
            this.deleteproduct.Text = "delete last product";
            this.deleteproduct.UseVisualStyleBackColor = false;
            this.deleteproduct.Click += new System.EventHandler(this.button_delete);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(898, 70);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(156, 519);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(805, 595);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(87, 33);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(12, 12);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(138, 37);
            this.edit.TabIndex = 21;
            this.edit.Text = "Change prices";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.change_prices);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(156, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(103, 37);
            this.richTextBox2.TabIndex = 22;
            this.richTextBox2.Text = "";
            this.richTextBox2.Visible = false;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.Location = new System.Drawing.Point(265, 12);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(53, 37);
            this.richTextBox3.TabIndex = 23;
            this.richTextBox3.Text = "";
            this.richTextBox3.Visible = false;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(507, 13);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 36);
            this.save.TabIndex = 24;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Visible = false;
            this.save.Click += new System.EventHandler(this.SaveButton);
            // 
            // richTextBox4
            // 
            this.richTextBox4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.Location = new System.Drawing.Point(444, 13);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(53, 37);
            this.richTextBox4.TabIndex = 26;
            this.richTextBox4.Text = "";
            this.richTextBox4.Visible = false;
            // 
            // richTextBox5
            // 
            this.richTextBox5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.Location = new System.Drawing.Point(335, 13);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.Size = new System.Drawing.Size(103, 37);
            this.richTextBox5.TabIndex = 25;
            this.richTextBox5.Text = "";
            this.richTextBox5.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(805, 636);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(87, 33);
            this.textBox2.TabIndex = 27;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancel.Location = new System.Drawing.Point(898, 13);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(156, 37);
            this.cancel.TabIndex = 28;
            this.cancel.Text = "Cancel order";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.Cancel);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(805, 702);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(87, 33);
            this.textBox3.TabIndex = 29;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(805, 673);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cal);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(588, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(304, 35);
            this.button2.TabIndex = 31;
            this.button2.Text = "Show Bills";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.showbill);
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(588, 70);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.ReadOnly = true;
            this.richTextBox6.Size = new System.Drawing.Size(304, 454);
            this.richTextBox6.TabIndex = 32;
            this.richTextBox6.Text = "";
            this.richTextBox6.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(588, 530);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(304, 37);
            this.button3.TabIndex = 33;
            this.button3.Text = "finish";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.closebills);
            // 
            // cucumber
            // 
            this.cucumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cucumber.Image = global::WindowsFormsApp1.Properties.Resources.images__4_;
            this.cucumber.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cucumber.Location = new System.Drawing.Point(444, 415);
            this.cucumber.Name = "cucumber";
            this.cucumber.Size = new System.Drawing.Size(138, 109);
            this.cucumber.TabIndex = 15;
            this.cucumber.Text = "CUCUMBER";
            this.cucumber.UseVisualStyleBackColor = true;
            this.cucumber.Click += new System.EventHandler(this.button_cucumber);
            // 
            // pumpkin
            // 
            this.pumpkin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pumpkin.Image = global::WindowsFormsApp1.Properties.Resources.تنزيل__14_;
            this.pumpkin.Location = new System.Drawing.Point(300, 415);
            this.pumpkin.Name = "pumpkin";
            this.pumpkin.Size = new System.Drawing.Size(138, 109);
            this.pumpkin.TabIndex = 14;
            this.pumpkin.Text = "PUMPKIN";
            this.pumpkin.UseVisualStyleBackColor = true;
            this.pumpkin.Click += new System.EventHandler(this.button_pumpkin);
            // 
            // carrot
            // 
            this.carrot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.carrot.Image = global::WindowsFormsApp1.Properties.Resources.تنزيل__13_;
            this.carrot.Location = new System.Drawing.Point(156, 415);
            this.carrot.Name = "carrot";
            this.carrot.Size = new System.Drawing.Size(138, 109);
            this.carrot.TabIndex = 13;
            this.carrot.Text = "CARROT";
            this.carrot.UseVisualStyleBackColor = true;
            this.carrot.Click += new System.EventHandler(this.button_carrot);
            // 
            // corn
            // 
            this.corn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.corn.Image = global::WindowsFormsApp1.Properties.Resources.images__2_;
            this.corn.Location = new System.Drawing.Point(12, 415);
            this.corn.Name = "corn";
            this.corn.Size = new System.Drawing.Size(138, 109);
            this.corn.TabIndex = 12;
            this.corn.Text = "CORN";
            this.corn.UseVisualStyleBackColor = true;
            this.corn.Click += new System.EventHandler(this.button_corn);
            // 
            // lettuce
            // 
            this.lettuce.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lettuce.Image = global::WindowsFormsApp1.Properties.Resources.تنزيل__12_;
            this.lettuce.Location = new System.Drawing.Point(444, 300);
            this.lettuce.Name = "lettuce";
            this.lettuce.Size = new System.Drawing.Size(138, 109);
            this.lettuce.TabIndex = 11;
            this.lettuce.Text = "LETTUCE";
            this.lettuce.UseVisualStyleBackColor = true;
            this.lettuce.Click += new System.EventHandler(this.button_lettuce);
            // 
            // onion
            // 
            this.onion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.onion.Image = global::WindowsFormsApp1.Properties.Resources.تنزيل__11_;
            this.onion.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.onion.Location = new System.Drawing.Point(300, 300);
            this.onion.Name = "onion";
            this.onion.Size = new System.Drawing.Size(138, 109);
            this.onion.TabIndex = 10;
            this.onion.Text = "ONION";
            this.onion.UseVisualStyleBackColor = true;
            this.onion.Click += new System.EventHandler(this.button_onion);
            // 
            // potato
            // 
            this.potato.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.potato.Image = global::WindowsFormsApp1.Properties.Resources.تنزيل__10_;
            this.potato.Location = new System.Drawing.Point(156, 300);
            this.potato.Name = "potato";
            this.potato.Size = new System.Drawing.Size(138, 109);
            this.potato.TabIndex = 9;
            this.potato.Text = "POTATO";
            this.potato.UseVisualStyleBackColor = true;
            this.potato.Click += new System.EventHandler(this.button_potato);
            // 
            // tomato
            // 
            this.tomato.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tomato.Image = global::WindowsFormsApp1.Properties.Resources.تنزيل__9_;
            this.tomato.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tomato.Location = new System.Drawing.Point(12, 300);
            this.tomato.Name = "tomato";
            this.tomato.Size = new System.Drawing.Size(138, 109);
            this.tomato.TabIndex = 8;
            this.tomato.Text = "TOMATO";
            this.tomato.UseVisualStyleBackColor = true;
            this.tomato.Click += new System.EventHandler(this.button_tomato);
            // 
            // watermelon
            // 
            this.watermelon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.watermelon.Image = global::WindowsFormsApp1.Properties.Resources.images__1_;
            this.watermelon.Location = new System.Drawing.Point(444, 185);
            this.watermelon.Name = "watermelon";
            this.watermelon.Size = new System.Drawing.Size(138, 109);
            this.watermelon.TabIndex = 7;
            this.watermelon.Text = "WATERMELON";
            this.watermelon.UseVisualStyleBackColor = true;
            this.watermelon.Click += new System.EventHandler(this.button_watermelon);
            // 
            // avocado
            // 
            this.avocado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.avocado.Image = global::WindowsFormsApp1.Properties.Resources.images;
            this.avocado.Location = new System.Drawing.Point(300, 185);
            this.avocado.Name = "avocado";
            this.avocado.Size = new System.Drawing.Size(138, 109);
            this.avocado.TabIndex = 6;
            this.avocado.Text = "AVOCADO";
            this.avocado.UseVisualStyleBackColor = true;
            this.avocado.Click += new System.EventHandler(this.button_avocado);
            // 
            // mango
            // 
            this.mango.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mango.Image = global::WindowsFormsApp1.Properties.Resources.تنزيل__8_;
            this.mango.Location = new System.Drawing.Point(156, 185);
            this.mango.Name = "mango";
            this.mango.Size = new System.Drawing.Size(138, 109);
            this.mango.TabIndex = 5;
            this.mango.Text = "MANGO";
            this.mango.UseVisualStyleBackColor = true;
            this.mango.Click += new System.EventHandler(this.button_mango);
            // 
            // strawberry
            // 
            this.strawberry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.strawberry.Image = global::WindowsFormsApp1.Properties.Resources.تنزيل__7_;
            this.strawberry.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.strawberry.Location = new System.Drawing.Point(12, 185);
            this.strawberry.Name = "strawberry";
            this.strawberry.Size = new System.Drawing.Size(138, 109);
            this.strawberry.TabIndex = 4;
            this.strawberry.Text = "STRAWBERRY";
            this.strawberry.UseVisualStyleBackColor = true;
            this.strawberry.Click += new System.EventHandler(this.button_strawberry);
            // 
            // grapes
            // 
            this.grapes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grapes.Image = global::WindowsFormsApp1.Properties.Resources.تنزيل__6_;
            this.grapes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.grapes.Location = new System.Drawing.Point(444, 70);
            this.grapes.Name = "grapes";
            this.grapes.Size = new System.Drawing.Size(138, 109);
            this.grapes.TabIndex = 3;
            this.grapes.Text = "GRAPES";
            this.grapes.UseVisualStyleBackColor = true;
            this.grapes.Click += new System.EventHandler(this.button_grapes);
            // 
            // banana
            // 
            this.banana.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.banana.Image = global::WindowsFormsApp1.Properties.Resources._100118_Debunked_01;
            this.banana.Location = new System.Drawing.Point(300, 70);
            this.banana.Name = "banana";
            this.banana.Size = new System.Drawing.Size(138, 109);
            this.banana.TabIndex = 2;
            this.banana.Text = "BANANA";
            this.banana.UseVisualStyleBackColor = true;
            this.banana.Click += new System.EventHandler(this.button_banana);
            // 
            // orange
            // 
            this.orange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.orange.Image = global::WindowsFormsApp1.Properties.Resources.تنزيل__4_;
            this.orange.Location = new System.Drawing.Point(156, 70);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(138, 109);
            this.orange.TabIndex = 1;
            this.orange.Text = "ORANGE";
            this.orange.UseVisualStyleBackColor = true;
            this.orange.Click += new System.EventHandler(this.button_orange);
            // 
            // apples
            // 
            this.apples.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.apples.ForeColor = System.Drawing.Color.Black;
            this.apples.Image = global::WindowsFormsApp1.Properties.Resources.Do_Apples_Affect_Diabetes_and_Blood_Sugar_Levels_732x549_thumbnail_1_732x549;
            this.apples.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.apples.Location = new System.Drawing.Point(12, 70);
            this.apples.Name = "apples";
            this.apples.Size = new System.Drawing.Size(138, 109);
            this.apples.TabIndex = 0;
            this.apples.Text = "APPLES";
            this.apples.UseVisualStyleBackColor = true;
            this.apples.Click += new System.EventHandler(this.button_apple);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 753);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.save);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.deleteproduct);
            this.Controls.Add(this.finishbill);
            this.Controls.Add(this.cucumber);
            this.Controls.Add(this.pumpkin);
            this.Controls.Add(this.carrot);
            this.Controls.Add(this.corn);
            this.Controls.Add(this.lettuce);
            this.Controls.Add(this.onion);
            this.Controls.Add(this.potato);
            this.Controls.Add(this.tomato);
            this.Controls.Add(this.watermelon);
            this.Controls.Add(this.avocado);
            this.Controls.Add(this.mango);
            this.Controls.Add(this.strawberry);
            this.Controls.Add(this.grapes);
            this.Controls.Add(this.banana);
            this.Controls.Add(this.orange);
            this.Controls.Add(this.apples);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saleh store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button apples;
        private System.Windows.Forms.Button orange;
        private System.Windows.Forms.Button banana;
        private System.Windows.Forms.Button grapes;
        private System.Windows.Forms.Button strawberry;
        private System.Windows.Forms.Button mango;
        private System.Windows.Forms.Button avocado;
        private System.Windows.Forms.Button watermelon;
        private System.Windows.Forms.Button cucumber;
        private System.Windows.Forms.Button pumpkin;
        private System.Windows.Forms.Button carrot;
        private System.Windows.Forms.Button corn;
        private System.Windows.Forms.Button lettuce;
        private System.Windows.Forms.Button onion;
        private System.Windows.Forms.Button potato;
        private System.Windows.Forms.Button tomato;
        private System.Windows.Forms.Button finishbill;
        private System.Windows.Forms.Button deleteproduct;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.Button button3;
    }
}

