﻿namespace Bit706_as2
{
    partial class ManageCustomers
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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.bntEditCustomer = new System.Windows.Forms.Button();
            this.bntDeleteCustomer = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(242)))));
            this.btnAddCustomer.FlatAppearance.BorderSize = 2;
            this.btnAddCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnAddCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(242)))));
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Location = new System.Drawing.Point(182, 96);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(187, 77);
            this.btnAddCustomer.TabIndex = 3;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // bntEditCustomer
            // 
            this.bntEditCustomer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bntEditCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(242)))));
            this.bntEditCustomer.FlatAppearance.BorderSize = 2;
            this.bntEditCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.bntEditCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(242)))));
            this.bntEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntEditCustomer.Location = new System.Drawing.Point(182, 179);
            this.bntEditCustomer.Name = "bntEditCustomer";
            this.bntEditCustomer.Size = new System.Drawing.Size(187, 77);
            this.bntEditCustomer.TabIndex = 4;
            this.bntEditCustomer.Text = "Edit Selected Customer";
            this.bntEditCustomer.UseVisualStyleBackColor = true;
            // 
            // bntDeleteCustomer
            // 
            this.bntDeleteCustomer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bntDeleteCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(242)))));
            this.bntDeleteCustomer.FlatAppearance.BorderSize = 2;
            this.bntDeleteCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.bntDeleteCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(242)))));
            this.bntDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntDeleteCustomer.Location = new System.Drawing.Point(182, 262);
            this.bntDeleteCustomer.Name = "bntDeleteCustomer";
            this.bntDeleteCustomer.Size = new System.Drawing.Size(187, 77);
            this.bntDeleteCustomer.TabIndex = 5;
            this.bntDeleteCustomer.Text = "Delete Selected Customer";
            this.bntDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(133, 303);
            this.listBox1.TabIndex = 6;
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bntDeleteCustomer);
            this.Controls.Add(this.bntEditCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "ManageCustomers";
            this.Text = "ManageCustomers";
            this.Controls.SetChildIndex(this.btnAddCustomer, 0);
            this.Controls.SetChildIndex(this.bntEditCustomer, 0);
            this.Controls.SetChildIndex(this.bntDeleteCustomer, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button bntEditCustomer;
        private System.Windows.Forms.Button bntDeleteCustomer;
        private System.Windows.Forms.ListBox listBox1;
    }
}