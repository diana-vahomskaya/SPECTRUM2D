
namespace Spectrum2D
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PICTURE = new System.Windows.Forms.PictureBox();
            this.PICTURE_SHUM = new System.Windows.Forms.PictureBox();
            this.SPECTR = new System.Windows.Forms.PictureBox();
            this.RESTOR_IMAGE = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NUM_GAUS = new System.Windows.Forms.TextBox();
            this.AMP1_GAUS = new System.Windows.Forms.TextBox();
            this.AMP2_GAUS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DISP2_GAUS = new System.Windows.Forms.TextBox();
            this.DISP1_GAUS = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNoisePercent = new System.Windows.Forms.TextBox();
            this.txtFilterPercent = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.radioUpload = new System.Windows.Forms.RadioButton();
            this.radioCreate = new System.Windows.Forms.RadioButton();
            this.btnInitial = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSetNoise = new System.Windows.Forms.Button();
            this.btnStretch = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnCreateSpectre = new System.Windows.Forms.Button();
            this.chkLog = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PICTURE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICTURE_SHUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPECTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RESTOR_IMAGE)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // PICTURE
            // 
            this.PICTURE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PICTURE.Location = new System.Drawing.Point(22, 36);
            this.PICTURE.Name = "PICTURE";
            this.PICTURE.Size = new System.Drawing.Size(498, 439);
            this.PICTURE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICTURE.TabIndex = 0;
            this.PICTURE.TabStop = false;
            // 
            // PICTURE_SHUM
            // 
            this.PICTURE_SHUM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PICTURE_SHUM.Location = new System.Drawing.Point(526, 36);
            this.PICTURE_SHUM.Name = "PICTURE_SHUM";
            this.PICTURE_SHUM.Size = new System.Drawing.Size(498, 439);
            this.PICTURE_SHUM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICTURE_SHUM.TabIndex = 1;
            this.PICTURE_SHUM.TabStop = false;
            // 
            // SPECTR
            // 
            this.SPECTR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SPECTR.Cursor = System.Windows.Forms.Cursors.Default;
            this.SPECTR.Location = new System.Drawing.Point(22, 503);
            this.SPECTR.Name = "SPECTR";
            this.SPECTR.Size = new System.Drawing.Size(498, 447);
            this.SPECTR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SPECTR.TabIndex = 2;
            this.SPECTR.TabStop = false;
            // 
            // RESTOR_IMAGE
            // 
            this.RESTOR_IMAGE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RESTOR_IMAGE.Location = new System.Drawing.Point(526, 503);
            this.RESTOR_IMAGE.Name = "RESTOR_IMAGE";
            this.RESTOR_IMAGE.Size = new System.Drawing.Size(498, 447);
            this.RESTOR_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RESTOR_IMAGE.TabIndex = 3;
            this.RESTOR_IMAGE.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.DISP2_GAUS);
            this.groupBox1.Controls.Add(this.DISP1_GAUS);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AMP2_GAUS);
            this.groupBox1.Controls.Add(this.AMP1_GAUS);
            this.groupBox1.Controls.Add(this.NUM_GAUS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(1044, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 138);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Гауссовы купола";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кол-во:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Амплитуда:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дисперсия:";
            // 
            // NUM_GAUS
            // 
            this.NUM_GAUS.Location = new System.Drawing.Point(202, 21);
            this.NUM_GAUS.Name = "NUM_GAUS";
            this.NUM_GAUS.Size = new System.Drawing.Size(131, 23);
            this.NUM_GAUS.TabIndex = 3;
            this.NUM_GAUS.Text = "10";
            this.NUM_GAUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AMP1_GAUS
            // 
            this.AMP1_GAUS.Location = new System.Drawing.Point(202, 61);
            this.AMP1_GAUS.Name = "AMP1_GAUS";
            this.AMP1_GAUS.Size = new System.Drawing.Size(46, 23);
            this.AMP1_GAUS.TabIndex = 4;
            this.AMP1_GAUS.Text = "1";
            this.AMP1_GAUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AMP2_GAUS
            // 
            this.AMP2_GAUS.Location = new System.Drawing.Point(286, 61);
            this.AMP2_GAUS.Name = "AMP2_GAUS";
            this.AMP2_GAUS.Size = new System.Drawing.Size(46, 23);
            this.AMP2_GAUS.TabIndex = 5;
            this.AMP2_GAUS.Text = "5";
            this.AMP2_GAUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "от";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "до";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(215, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Изображение";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(684, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Изображение + Шум";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(224, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Спектр";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(643, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(278, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "Восстановленное изображение";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "до";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(171, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "от";
            // 
            // DISP2_GAUS
            // 
            this.DISP2_GAUS.Location = new System.Drawing.Point(287, 95);
            this.DISP2_GAUS.Name = "DISP2_GAUS";
            this.DISP2_GAUS.Size = new System.Drawing.Size(46, 23);
            this.DISP2_GAUS.TabIndex = 9;
            this.DISP2_GAUS.Text = "5";
            this.DISP2_GAUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DISP1_GAUS
            // 
            this.DISP1_GAUS.Location = new System.Drawing.Point(202, 95);
            this.DISP1_GAUS.Name = "DISP1_GAUS";
            this.DISP1_GAUS.Size = new System.Drawing.Size(46, 23);
            this.DISP1_GAUS.TabIndex = 8;
            this.DISP1_GAUS.Text = "1";
            this.DISP1_GAUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.labelHeight);
            this.groupBox2.Controls.Add(this.txtWidth);
            this.groupBox2.Controls.Add(this.labelWidth);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtHeight);
            this.groupBox2.Location = new System.Drawing.Point(1044, 155);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(215, 111);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Размеры";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(5, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 18);
            this.label12.TabIndex = 13;
            this.label12.Text = "Ширина";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHeight
            // 
            this.labelHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHeight.Location = new System.Drawing.Point(141, 66);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(53, 23);
            this.labelHeight.TabIndex = 20;
            this.labelHeight.Text = "0";
            this.labelHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(82, 30);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(53, 23);
            this.txtWidth.TabIndex = 12;
            this.txtWidth.Text = "142";
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelWidth
            // 
            this.labelWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWidth.Location = new System.Drawing.Point(141, 30);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(53, 23);
            this.labelWidth.TabIndex = 12;
            this.labelWidth.Text = "0";
            this.labelWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(5, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 18);
            this.label13.TabIndex = 15;
            this.label13.Text = "Высота";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(82, 66);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(53, 23);
            this.txtHeight.TabIndex = 14;
            this.txtHeight.Text = "128";
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtNoisePercent);
            this.groupBox3.Controls.Add(this.txtFilterPercent);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(1280, 155);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(155, 111);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Шум и фильтрация";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(5, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 18);
            this.label14.TabIndex = 13;
            this.label14.Text = "Шум, %";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNoisePercent
            // 
            this.txtNoisePercent.Location = new System.Drawing.Point(82, 30);
            this.txtNoisePercent.Name = "txtNoisePercent";
            this.txtNoisePercent.Size = new System.Drawing.Size(57, 23);
            this.txtNoisePercent.TabIndex = 12;
            this.txtNoisePercent.Text = "5";
            this.txtNoisePercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFilterPercent
            // 
            this.txtFilterPercent.Location = new System.Drawing.Point(82, 66);
            this.txtFilterPercent.Name = "txtFilterPercent";
            this.txtFilterPercent.Size = new System.Drawing.Size(57, 23);
            this.txtFilterPercent.TabIndex = 18;
            this.txtFilterPercent.Text = "99";
            this.txtFilterPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(5, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 18);
            this.label15.TabIndex = 19;
            this.label15.Text = "Фильтр, %";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUpload);
            this.groupBox4.Controls.Add(this.radioUpload);
            this.groupBox4.Controls.Add(this.radioCreate);
            this.groupBox4.Controls.Add(this.btnInitial);
            this.groupBox4.Location = new System.Drawing.Point(1044, 287);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(391, 131);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Изображение";
            // 
            // btnUpload
            // 
            this.btnUpload.Enabled = false;
            this.btnUpload.Location = new System.Drawing.Point(202, 33);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(173, 49);
            this.btnUpload.TabIndex = 25;
            this.btnUpload.Text = "Загрузить изображение";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // radioUpload
            // 
            this.radioUpload.Location = new System.Drawing.Point(202, 97);
            this.radioUpload.Margin = new System.Windows.Forms.Padding(2);
            this.radioUpload.Name = "radioUpload";
            this.radioUpload.Size = new System.Drawing.Size(173, 20);
            this.radioUpload.TabIndex = 19;
            this.radioUpload.TabStop = true;
            this.radioUpload.Text = "Загрузить";
            this.radioUpload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioUpload.UseVisualStyleBackColor = true;
            // 
            // radioCreate
            // 
            this.radioCreate.Location = new System.Drawing.Point(12, 97);
            this.radioCreate.Margin = new System.Windows.Forms.Padding(2);
            this.radioCreate.Name = "radioCreate";
            this.radioCreate.Size = new System.Drawing.Size(173, 20);
            this.radioCreate.TabIndex = 0;
            this.radioCreate.TabStop = true;
            this.radioCreate.Text = "Создать";
            this.radioCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioCreate.UseVisualStyleBackColor = true;
            // 
            // btnInitial
            // 
            this.btnInitial.Location = new System.Drawing.Point(12, 33);
            this.btnInitial.Name = "btnInitial";
            this.btnInitial.Size = new System.Drawing.Size(173, 49);
            this.btnInitial.TabIndex = 1;
            this.btnInitial.Text = "Создать изображение";
            this.btnInitial.UseVisualStyleBackColor = true;
            this.btnInitial.Click += new System.EventHandler(this.btnInitial_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSetNoise);
            this.groupBox6.Controls.Add(this.btnStretch);
            this.groupBox6.Location = new System.Drawing.Point(1044, 422);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(391, 86);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            // 
            // btnSetNoise
            // 
            this.btnSetNoise.Location = new System.Drawing.Point(12, 21);
            this.btnSetNoise.Name = "btnSetNoise";
            this.btnSetNoise.Size = new System.Drawing.Size(173, 49);
            this.btnSetNoise.TabIndex = 19;
            this.btnSetNoise.Text = "Наложить шум";
            this.btnSetNoise.UseVisualStyleBackColor = true;
            this.btnSetNoise.Click += new System.EventHandler(this.btnSetNoise_Click);
            // 
            // btnStretch
            // 
            this.btnStretch.Location = new System.Drawing.Point(202, 21);
            this.btnStretch.Name = "btnStretch";
            this.btnStretch.Size = new System.Drawing.Size(173, 49);
            this.btnStretch.TabIndex = 18;
            this.btnStretch.Text = "Растянуть";
            this.btnStretch.UseVisualStyleBackColor = true;
            this.btnStretch.Click += new System.EventHandler(this.btnStretch_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkLog);
            this.groupBox5.Controls.Add(this.btnFilter);
            this.groupBox5.Controls.Add(this.btnCreateSpectre);
            this.groupBox5.Location = new System.Drawing.Point(1044, 512);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(391, 138);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Фильтрация";
            // 
            // btnFilter
            // 
            this.btnFilter.Enabled = false;
            this.btnFilter.Location = new System.Drawing.Point(202, 33);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(173, 49);
            this.btnFilter.TabIndex = 17;
            this.btnFilter.Text = "Фильтровать";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnCreateSpectre
            // 
            this.btnCreateSpectre.Location = new System.Drawing.Point(12, 33);
            this.btnCreateSpectre.Name = "btnCreateSpectre";
            this.btnCreateSpectre.Size = new System.Drawing.Size(173, 49);
            this.btnCreateSpectre.TabIndex = 16;
            this.btnCreateSpectre.Text = "Создать спектр";
            this.btnCreateSpectre.UseVisualStyleBackColor = true;
            this.btnCreateSpectre.Click += new System.EventHandler(this.btnCreateSpectre_Click);
            // 
            // chkLog
            // 
            this.chkLog.Location = new System.Drawing.Point(12, 100);
            this.chkLog.Margin = new System.Windows.Forms.Padding(2);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(363, 20);
            this.chkLog.TabIndex = 28;
            this.chkLog.Text = "Логарифмический масштаб";
            this.chkLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkLog.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1466, 953);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RESTOR_IMAGE);
            this.Controls.Add(this.SPECTR);
            this.Controls.Add(this.PICTURE_SHUM);
            this.Controls.Add(this.PICTURE);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PICTURE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICTURE_SHUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPECTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RESTOR_IMAGE)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PICTURE;
        private System.Windows.Forms.PictureBox PICTURE_SHUM;
        private System.Windows.Forms.PictureBox SPECTR;
        private System.Windows.Forms.PictureBox RESTOR_IMAGE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DISP2_GAUS;
        private System.Windows.Forms.TextBox DISP1_GAUS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AMP2_GAUS;
        private System.Windows.Forms.TextBox AMP1_GAUS;
        private System.Windows.Forms.TextBox NUM_GAUS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNoisePercent;
        private System.Windows.Forms.TextBox txtFilterPercent;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.RadioButton radioUpload;
        private System.Windows.Forms.RadioButton radioCreate;
        private System.Windows.Forms.Button btnInitial;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSetNoise;
        private System.Windows.Forms.Button btnStretch;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnCreateSpectre;
        private System.Windows.Forms.CheckBox chkLog;
    }
}

