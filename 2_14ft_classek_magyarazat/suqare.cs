using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_14ft_classek_magyarazat
{
    class square : UserControl
    {
        private CheckBox checkBox1;
        public square(string data)
        {
            InitializeComponent();
            checkBox1.Text = data;
            checkBox1.CheckedChanged += (s, e) =>
            {
                IsChecked = checkBox1.Checked;
            };
        }
        public bool IsChecked { get; private set; }

        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // square
            // 
            this.Controls.Add(this.checkBox1);
            this.Name = "square";
            this.Size = new System.Drawing.Size(101, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
