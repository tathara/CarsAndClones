namespace CarsAndClones
{
    partial class CarsAndClones
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsAndClones));
            this.bodiesBox = new System.Windows.Forms.ListBox();
            this.coloursBox = new System.Windows.Forms.ListBox();
            this.enginesBox = new System.Windows.Forms.ListBox();
            this.gearBoxesBox = new System.Windows.Forms.ListBox();
            this.optionsBox = new System.Windows.Forms.ListBox();
            this.carsList = new System.Windows.Forms.ListView();
            this.Model = new System.Windows.Forms.ColumnHeader();
            this.Body = new System.Windows.Forms.ColumnHeader();
            this.Colour = new System.Windows.Forms.ColumnHeader();
            this.Engine = new System.Windows.Forms.ColumnHeader();
            this.GearBox = new System.Windows.Forms.ColumnHeader();
            this.Option = new System.Windows.Forms.ColumnHeader();
            this.carModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.removeCarButton = new System.Windows.Forms.Button();
            this.cloneCarButton = new System.Windows.Forms.Button();
            this.buildCarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bodiesBox
            // 
            this.bodiesBox.BackColor = System.Drawing.Color.OldLace;
            this.bodiesBox.FormattingEnabled = true;
            this.bodiesBox.ItemHeight = 20;
            this.bodiesBox.Location = new System.Drawing.Point(12, 101);
            this.bodiesBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bodiesBox.Name = "bodiesBox";
            this.bodiesBox.Size = new System.Drawing.Size(154, 124);
            this.bodiesBox.TabIndex = 0;
            this.bodiesBox.SelectedIndexChanged += new System.EventHandler(this.bodiesBox_SelectedIndexChanged);
            // 
            // coloursBox
            // 
            this.coloursBox.BackColor = System.Drawing.Color.OldLace;
            this.coloursBox.FormattingEnabled = true;
            this.coloursBox.ItemHeight = 20;
            this.coloursBox.Location = new System.Drawing.Point(209, 101);
            this.coloursBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.coloursBox.Name = "coloursBox";
            this.coloursBox.Size = new System.Drawing.Size(154, 124);
            this.coloursBox.TabIndex = 1;
            this.coloursBox.SelectedIndexChanged += new System.EventHandler(this.coloursBox_SelectedIndexChanged);
            // 
            // enginesBox
            // 
            this.enginesBox.BackColor = System.Drawing.Color.OldLace;
            this.enginesBox.FormattingEnabled = true;
            this.enginesBox.ItemHeight = 20;
            this.enginesBox.Location = new System.Drawing.Point(407, 101);
            this.enginesBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enginesBox.Name = "enginesBox";
            this.enginesBox.Size = new System.Drawing.Size(154, 124);
            this.enginesBox.TabIndex = 2;
            this.enginesBox.SelectedIndexChanged += new System.EventHandler(this.enginesBox_SelectedIndexChanged);
            // 
            // gearBoxesBox
            // 
            this.gearBoxesBox.BackColor = System.Drawing.Color.OldLace;
            this.gearBoxesBox.FormattingEnabled = true;
            this.gearBoxesBox.ItemHeight = 20;
            this.gearBoxesBox.Location = new System.Drawing.Point(610, 101);
            this.gearBoxesBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gearBoxesBox.Name = "gearBoxesBox";
            this.gearBoxesBox.Size = new System.Drawing.Size(154, 124);
            this.gearBoxesBox.TabIndex = 3;
            this.gearBoxesBox.SelectedIndexChanged += new System.EventHandler(this.gearBoxesBox_SelectedIndexChanged);
            // 
            // optionsBox
            // 
            this.optionsBox.BackColor = System.Drawing.Color.OldLace;
            this.optionsBox.FormattingEnabled = true;
            this.optionsBox.ItemHeight = 20;
            this.optionsBox.Location = new System.Drawing.Point(809, 101);
            this.optionsBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optionsBox.Name = "optionsBox";
            this.optionsBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.optionsBox.Size = new System.Drawing.Size(154, 124);
            this.optionsBox.TabIndex = 4;
            this.optionsBox.SelectedIndexChanged += new System.EventHandler(this.optionsBox_SelectedIndexChanged);
            // 
            // carsList
            // 
            this.carsList.BackColor = System.Drawing.Color.White;
            this.carsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Model,
            this.Body,
            this.Colour,
            this.Engine,
            this.GearBox,
            this.Option});
            this.carsList.FullRowSelect = true;
            this.carsList.GridLines = true;
            this.carsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.carsList.LabelWrap = false;
            this.carsList.Location = new System.Drawing.Point(139, 249);
            this.carsList.MultiSelect = false;
            this.carsList.Name = "carsList";
            this.carsList.ShowGroups = false;
            this.carsList.Size = new System.Drawing.Size(824, 332);
            this.carsList.TabIndex = 7;
            this.carsList.UseCompatibleStateImageBehavior = false;
            this.carsList.View = System.Windows.Forms.View.Details;
            // 
            // Model
            // 
            this.Model.Text = "Модель";
            this.Model.Width = 80;
            // 
            // Body
            // 
            this.Body.Text = "Кузов";
            this.Body.Width = 130;
            // 
            // Colour
            // 
            this.Colour.Text = "Цвет";
            this.Colour.Width = 120;
            // 
            // Engine
            // 
            this.Engine.Text = "Двигатель";
            this.Engine.Width = 120;
            // 
            // GearBox
            // 
            this.GearBox.Text = "КПП";
            this.GearBox.Width = 170;
            // 
            // Option
            // 
            this.Option.Text = "Доп. опции";
            this.Option.Width = 200;
            // 
            // carModel
            // 
            this.carModel.BackColor = System.Drawing.Color.OldLace;
            this.carModel.Location = new System.Drawing.Point(407, 44);
            this.carModel.Name = "carModel";
            this.carModel.Size = new System.Drawing.Size(154, 25);
            this.carModel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Кузовы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Цвета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Двигатели";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(610, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "КПП";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(809, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Доп. опции";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Название модели";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(5, 258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // removeCarButton
            // 
            this.removeCarButton.BackColor = System.Drawing.Color.OldLace;
            this.removeCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeCarButton.Location = new System.Drawing.Point(21, 531);
            this.removeCarButton.Name = "removeCarButton";
            this.removeCarButton.Size = new System.Drawing.Size(97, 50);
            this.removeCarButton.TabIndex = 19;
            this.removeCarButton.Text = "Удалить авто";
            this.removeCarButton.UseVisualStyleBackColor = false;
            // 
            // cloneCarButton
            // 
            this.cloneCarButton.BackColor = System.Drawing.Color.OldLace;
            this.cloneCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cloneCarButton.Location = new System.Drawing.Point(21, 465);
            this.cloneCarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cloneCarButton.Name = "cloneCarButton";
            this.cloneCarButton.Size = new System.Drawing.Size(97, 50);
            this.cloneCarButton.TabIndex = 18;
            this.cloneCarButton.Text = "Создать клон";
            this.cloneCarButton.UseVisualStyleBackColor = false;
            // 
            // buildCarButton
            // 
            this.buildCarButton.BackColor = System.Drawing.Color.OldLace;
            this.buildCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildCarButton.Location = new System.Drawing.Point(21, 393);
            this.buildCarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buildCarButton.Name = "buildCarButton";
            this.buildCarButton.Size = new System.Drawing.Size(97, 54);
            this.buildCarButton.TabIndex = 17;
            this.buildCarButton.Text = "Создать прототип";
            this.buildCarButton.UseVisualStyleBackColor = false;
            // 
            // CarsAndClones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(978, 593);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.removeCarButton);
            this.Controls.Add(this.cloneCarButton);
            this.Controls.Add(this.buildCarButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carModel);
            this.Controls.Add(this.carsList);
            this.Controls.Add(this.optionsBox);
            this.Controls.Add(this.gearBoxesBox);
            this.Controls.Add(this.enginesBox);
            this.Controls.Add(this.coloursBox);
            this.Controls.Add(this.bodiesBox);
            this.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CarsAndClones";
            this.Text = "CarsAndClones";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox bodiesBox;
        private ListBox coloursBox;
        private ListBox enginesBox;
        private ListBox gearBoxesBox;
        private ListBox optionsBox;
        private ListView carsList;
        private TextBox carModel;
        private ColumnHeader Model;
        private ColumnHeader Body;
        private ColumnHeader Colour;
        private ColumnHeader Engine;
        private ColumnHeader GearBox;
        private ColumnHeader Option;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Button removeCarButton;
        private Button cloneCarButton;
        private Button buildCarButton;
    }
}