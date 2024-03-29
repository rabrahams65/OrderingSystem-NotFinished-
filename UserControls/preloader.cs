﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystem.UserControls
{
    public partial class preloader : Form
    {
        public preloader()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void preloader_Load(object sender, EventArgs e)
        {

        }

        public preloader(Form parent)
        {
            InitializeComponent();
            if (parent != null)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(parent.Location.X + parent.Width / 2 - this.Width / 2,parent.Location.Y+parent.Height/2-this.Height/2);

            }
            else
            {
                this.StartPosition = FormStartPosition.CenterParent;
            }
        }

        public void CloseWaitForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            if (lblImage.Image != null)
            {
                lblImage.Image.Dispose();
            }
        }
    }
}
