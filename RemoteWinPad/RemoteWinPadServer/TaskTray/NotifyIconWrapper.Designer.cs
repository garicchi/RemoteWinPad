namespace RemoteWinPadServer.TaskTray
{
    partial class NotifyIconWrapper
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyIconWrapper));
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuMain.SuspendLayout();
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.ContextMenuStrip = this.contextMenuMain;
            this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
            this.notifyIconMain.Text = "RemoteWinPad";
            this.notifyIconMain.Visible = true;
            // 
            // contextMenuMain
            // 
            this.contextMenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_setting,
            this.toolStrip_exit});
            this.contextMenuMain.Name = "contextMenuMain";
            this.contextMenuMain.Size = new System.Drawing.Size(115, 48);
            // 
            // toolStrip_setting
            // 
            this.toolStrip_setting.Name = "toolStrip_setting";
            this.toolStrip_setting.Size = new System.Drawing.Size(114, 22);
            this.toolStrip_setting.Text = "setting";
            // 
            // toolStrip_exit
            // 
            this.toolStrip_exit.Name = "toolStrip_exit";
            this.toolStrip_exit.Size = new System.Drawing.Size(114, 22);
            this.toolStrip_exit.Text = "終了";
            this.contextMenuMain.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuMain;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_setting;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_exit;
    }
}
