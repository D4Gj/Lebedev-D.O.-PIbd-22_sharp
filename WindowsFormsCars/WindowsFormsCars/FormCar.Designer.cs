namespace WindowsFormsCars
{
    partial class FormCar
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_down = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.button_up = new System.Windows.Forms.Button();
            this.pictureBoxCars = new System.Windows.Forms.PictureBox();
            this.btn_CreateWorkTractor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCars)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(12, 12);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // button_right
            // 
            this.button_right.BackgroundImage = global::WindowsFormsCars.Properties.Resources._98673__1_;
            this.button_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_right.Location = new System.Drawing.Point(803, 395);
            this.button_right.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(75, 46);
            this.button_right.TabIndex = 5;
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.Button_up_Click);
            // 
            // button_down
            // 
            this.button_down.BackgroundImage = global::WindowsFormsCars.Properties.Resources._110657__1_;
            this.button_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_down.Location = new System.Drawing.Point(707, 395);
            this.button_down.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(89, 46);
            this.button_down.TabIndex = 4;
            this.button_down.UseVisualStyleBackColor = true;
            this.button_down.Click += new System.EventHandler(this.Button_up_Click);
            // 
            // button_left
            // 
            this.button_left.BackgroundImage = global::WindowsFormsCars.Properties.Resources._17264;
            this.button_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_left.Location = new System.Drawing.Point(609, 395);
            this.button_left.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(92, 46);
            this.button_left.TabIndex = 3;
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.Button_up_Click);
            // 
            // button_up
            // 
            this.button_up.BackgroundImage = global::WindowsFormsCars.Properties.Resources.up;
            this.button_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_up.Location = new System.Drawing.Point(707, 343);
            this.button_up.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(89, 46);
            this.button_up.TabIndex = 2;
            this.button_up.UseVisualStyleBackColor = true;
            this.button_up.Click += new System.EventHandler(this.Button_up_Click);
            // 
            // pictureBoxCars
            // 
            this.pictureBoxCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCars.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCars.Name = "pictureBoxCars";
            this.pictureBoxCars.Size = new System.Drawing.Size(883, 453);
            this.pictureBoxCars.TabIndex = 0;
            this.pictureBoxCars.TabStop = false;
            // 
            // btn_CreateWorkTractor
            // 
            this.btn_CreateWorkTractor.Location = new System.Drawing.Point(124, 12);
            this.btn_CreateWorkTractor.Name = "btn_CreateWorkTractor";
            this.btn_CreateWorkTractor.Size = new System.Drawing.Size(205, 33);
            this.btn_CreateWorkTractor.TabIndex = 6;
            this.btn_CreateWorkTractor.Text = "создать рабочий трактор";
            this.btn_CreateWorkTractor.UseVisualStyleBackColor = true;
            this.btn_CreateWorkTractor.Click += new System.EventHandler(this.Btn_CreateWorkTractor_Click);
            // 
            // FormCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 453);
            this.Controls.Add(this.btn_CreateWorkTractor);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_down);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.button_up);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.pictureBoxCars);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCars;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button button_up;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_down;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button btn_CreateWorkTractor;
    }
}

