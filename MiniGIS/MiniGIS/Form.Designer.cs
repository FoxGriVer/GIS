namespace MiniGIS
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            MiniGIS.GEOPoint geoPoint1 = new MiniGIS.GEOPoint();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.selectBtn = new System.Windows.Forms.ToolStripButton();
            this.panBtn = new System.Windows.Forms.ToolStripButton();
            this.zoomInBtn = new System.Windows.Forms.ToolStripButton();
            this.zoomOutBtn = new System.Windows.Forms.ToolStripButton();
            this.entireViewBtn = new System.Windows.Forms.ToolStripButton();
            this.mapControl = new MiniGIS.Map();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectBtn,
            this.panBtn,
            this.zoomInBtn,
            this.zoomOutBtn,
            this.entireViewBtn});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(1368, 27);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // selectBtn
            // 
            this.selectBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectBtn.Image = ((System.Drawing.Image)(resources.GetObject("selectBtn.Image")));
            this.selectBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(24, 24);
            this.selectBtn.Text = "Select";
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // panBtn
            // 
            this.panBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.panBtn.Image = ((System.Drawing.Image)(resources.GetObject("panBtn.Image")));
            this.panBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.panBtn.Name = "panBtn";
            this.panBtn.Size = new System.Drawing.Size(24, 24);
            this.panBtn.Text = "Pan";
            this.panBtn.Click += new System.EventHandler(this.panBtn_Click);
            // 
            // zoomInBtn
            // 
            this.zoomInBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomInBtn.Image = ((System.Drawing.Image)(resources.GetObject("zoomInBtn.Image")));
            this.zoomInBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInBtn.Name = "zoomInBtn";
            this.zoomInBtn.Size = new System.Drawing.Size(24, 24);
            this.zoomInBtn.Text = "Zoom In";
            this.zoomInBtn.Click += new System.EventHandler(this.zoomInBtn_Click);
            // 
            // zoomOutBtn
            // 
            this.zoomOutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutBtn.Image")));
            this.zoomOutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutBtn.Name = "zoomOutBtn";
            this.zoomOutBtn.Size = new System.Drawing.Size(24, 24);
            this.zoomOutBtn.Text = "Zoom Out";
            this.zoomOutBtn.Click += new System.EventHandler(this.zoomOutBtn_Click);
            // 
            // entireViewBtn
            // 
            this.entireViewBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.entireViewBtn.Image = ((System.Drawing.Image)(resources.GetObject("entireViewBtn.Image")));
            this.entireViewBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.entireViewBtn.Name = "entireViewBtn";
            this.entireViewBtn.Size = new System.Drawing.Size(24, 24);
            this.entireViewBtn.Text = "Entire View";
            // 
            // mapControl
            // 
            this.mapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapControl.Location = new System.Drawing.Point(21, 22);
            geoPoint1.X = 0D;
            geoPoint1.Y = 0D;
            this.mapControl.MapCenter = geoPoint1;
            this.mapControl.MapScale = 1D;
            this.mapControl.Margin = new System.Windows.Forms.Padding(9);
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(1396, 1321);
            this.mapControl.TabIndex = 0;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1368, 1365);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.mapControl);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniGIS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Load);            
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Map mapControl;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton selectBtn;
        private System.Windows.Forms.ToolStripButton panBtn;
        private System.Windows.Forms.ToolStripButton zoomInBtn;
        private System.Windows.Forms.ToolStripButton zoomOutBtn;
        private System.Windows.Forms.ToolStripButton entireViewBtn;
    }
}

