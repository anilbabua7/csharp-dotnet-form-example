using System.Windows.Forms;

namespace FormExample
{
    partial class PopupExample
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenu();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.MenuItems.Add("First Item", new System.EventHandler(firstSelected));
            this.contextMenuStrip1.MenuItems.Add("Second Item", new System.EventHandler(secondSelected));
            // 
            // contextMenuStrip2
            // 
            // 
            // PopupExample
            // 
            this.ContextMenu = contextMenuStrip1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "PopupExample";
            this.Text = "PopupExample";
            this.Load += new System.EventHandler(this.PopupExample_Load);
            this.ResumeLayout(false);

        }

        public void firstSelected(object obj, System.EventArgs args)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            // Code for what to do after first item being selected
        }

        public void secondSelected(object obj, System.EventArgs args)
        {
            FontDialog fontDialog = new FontDialog(); ;
            fontDialog.ShowDialog();
            // Code for what to do after second item being selected
        }

        #endregion

        private System.Windows.Forms.ContextMenu contextMenuStrip1;
        private System.Windows.Forms.ContextMenu contextMenuStrip2;
    }

   
}