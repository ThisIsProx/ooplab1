
namespace ooplab1
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
            this.components = new System.ComponentModel.Container();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dtpSort = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(12, 156);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(132, 20);
            this.txtSurname.TabIndex = 0;
            this.txtSurname.Text = "Ім\'я";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 156);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Прізвище";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 202);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(312, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Додати данні";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSubmit_MouseClick);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(385, 202);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(279, 23);
            this.btnRead.TabIndex = 5;
            this.btnRead.Text = "Відобразити данні";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRead_MouseClick);
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(12, 130);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(312, 20);
            this.dtpBirthdate.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(312, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Обрати дату народження ↓";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(385, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(279, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Обрати місяць сортування ↓";
            // 
            // dtpSort
            // 
            this.dtpSort.Location = new System.Drawing.Point(385, 130);
            this.dtpSort.Name = "dtpSort";
            this.dtpSort.Size = new System.Drawing.Size(279, 20);
            this.dtpSort.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.dtpSort);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSurname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dtpSort;
    }
}

