using System;
using System.Drawing;
using System.Windows.Forms;

namespace EveOPreview.View
{
	partial class MainForm
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

        /// <summary>s
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolStripMenuItem RestoreWindowMenuItem;
            ToolStripMenuItem ExitMenuItem;
            ToolStripMenuItem TitleMenuItem;
            ToolStripSeparator SeparatorMenuItem;
            TabControl ContentTabControl;
            TabPage GeneralTabPage;
            Panel GeneralSettingsPanel;
            Label label4;
            TabPage ThumbnailTabPage;
            Panel ThumbnailSettingsPanel;
            Label HeigthLabel;
            Label WidthLabel;
            Label OpacityLabel;
            Panel ZoomSettingsPanel;
            Label ZoomFactorLabel;
            Label ZoomAnchorLabel;
            TabPage OverlayTabPage;
            Panel OverlaySettingsPanel;
            TabPage ClientsTabPage;
            Panel ClientsPanel;
            Label ThumbnailsListLabel;
            TabPage AboutTabPage;
            Panel AboutPanel;
            Label CreditMaintLabel;
            Label DocumentationLinkLabel;
            Label DescriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Label NameLabel;
            AnimationStyleCombo = new ComboBox();
            MinimizeInactiveClientsCheckBox = new CheckBox();
            EnableClientLayoutTrackingCheckBox = new CheckBox();
            HideActiveClientThumbnailCheckBox = new CheckBox();
            ShowThumbnailsAlwaysOnTopCheckBox = new CheckBox();
            HideThumbnailsOnLostFocusCheckBox = new CheckBox();
            EnablePerClientThumbnailsLayoutsCheckBox = new CheckBox();
            MinimizeToTrayCheckBox = new CheckBox();
            HotkeysTabPage = new TabPage();
            CycleGroupSelectorComboBox = new ComboBox();
            HotkeysForwardLabel = new Label();
            HotkeysForwardListBox = new ListBox();
            HotkeysForwardAddButton = new Button();
            HotkeysForwardRemoveButton = new Button();
            HotkeysBackwardLabel = new Label();
            HotkeysBackwardListBox = new ListBox();
            HotkeysBackwardAddButton = new Button();
            HotkeysBackwardRemoveButton = new Button();
            HotkeyCaptureTextBox = new TextBox();
            HotkeysClientsList = new CheckedListBox();
            HotkeysClientUpButton = new Button();
            HotkeysClientDownButton = new Button();
            HotkeyCaptureButton = new Button();
            HotkeyReadmeTextBox = new TextBox();
            HotkeySaveButton = new Button();
            ThumbnailSnapToGridCheckBox = new CheckBox();
            ThumbnailSnapToGridSizeYNumericEdit = new NumericUpDown();
            SnapYLabel = new Label();
            ThumbnailSnapToGridSizeXNumericEdit = new NumericUpDown();
            SnapXLabel = new Label();
            LockThumbnailLocationCheckbox = new CheckBox();
            ThumbnailsWidthNumericEdit = new NumericUpDown();
            ThumbnailsHeightNumericEdit = new NumericUpDown();
            ThumbnailOpacityTrackBar = new TrackBar();
            ZoomTabPage = new TabPage();
            ZoomAnchorPanel = new Panel();
            ZoomAanchorNWRadioButton = new RadioButton();
            ZoomAanchorNRadioButton = new RadioButton();
            ZoomAanchorNERadioButton = new RadioButton();
            ZoomAanchorWRadioButton = new RadioButton();
            ZoomAanchorSERadioButton = new RadioButton();
            ZoomAanchorCRadioButton = new RadioButton();
            ZoomAanchorSRadioButton = new RadioButton();
            ZoomAanchorERadioButton = new RadioButton();
            ZoomAanchorSWRadioButton = new RadioButton();
            EnableThumbnailZoomCheckBox = new CheckBox();
            ThumbnailZoomFactorNumericEdit = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            OverlayLabelColorButton = new Panel();
            OverlayLabelSizeNumericEdit = new NumericUpDown();
            panel1 = new Panel();
            OverlayLabelNWRadioButton = new RadioButton();
            OverlayLabelNRadioButton = new RadioButton();
            OverlayLabelNERadioButton = new RadioButton();
            OverlayLabelWRadioButton = new RadioButton();
            OverlayLabelSERadioButton = new RadioButton();
            OverlayLabelCRadioButton = new RadioButton();
            OverlayLabelSRadioButton = new RadioButton();
            OverlayLabelERadioButton = new RadioButton();
            OverlayLabelSWRadioButton = new RadioButton();
            label1 = new Label();
            HighlightColorLabel = new Label();
            ActiveClientHighlightColorButton = new Panel();
            EnableActiveClientHighlightCheckBox = new CheckBox();
            ShowThumbnailOverlaysCheckBox = new CheckBox();
            ShowThumbnailFramesCheckBox = new CheckBox();
            ThumbnailsList = new CheckedListBox();
            VersionLabel = new Label();
            DocumentationLink = new LinkLabel();
            NotifyIcon = new NotifyIcon(components);
            TrayMenu = new ContextMenuStrip(components);
            RestoreWindowMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            TitleMenuItem = new ToolStripMenuItem();
            SeparatorMenuItem = new ToolStripSeparator();
            ContentTabControl = new TabControl();
            GeneralTabPage = new TabPage();
            GeneralSettingsPanel = new Panel();
            label4 = new Label();
            ThumbnailTabPage = new TabPage();
            ThumbnailSettingsPanel = new Panel();
            HeigthLabel = new Label();
            WidthLabel = new Label();
            OpacityLabel = new Label();
            ZoomSettingsPanel = new Panel();
            ZoomFactorLabel = new Label();
            ZoomAnchorLabel = new Label();
            OverlayTabPage = new TabPage();
            OverlaySettingsPanel = new Panel();
            ClientsTabPage = new TabPage();
            ClientsPanel = new Panel();
            ThumbnailsListLabel = new Label();
            AboutTabPage = new TabPage();
            AboutPanel = new Panel();
            CreditMaintLabel = new Label();
            DocumentationLinkLabel = new Label();
            DescriptionLabel = new Label();
            NameLabel = new Label();
            ContentTabControl.SuspendLayout();
            GeneralTabPage.SuspendLayout();
            GeneralSettingsPanel.SuspendLayout();
            HotkeysTabPage.SuspendLayout();
            ThumbnailTabPage.SuspendLayout();
            ThumbnailSettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ThumbnailSnapToGridSizeYNumericEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ThumbnailSnapToGridSizeXNumericEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ThumbnailsWidthNumericEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ThumbnailsHeightNumericEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ThumbnailOpacityTrackBar).BeginInit();
            ZoomTabPage.SuspendLayout();
            ZoomSettingsPanel.SuspendLayout();
            ZoomAnchorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ThumbnailZoomFactorNumericEdit).BeginInit();
            OverlayTabPage.SuspendLayout();
            OverlaySettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OverlayLabelSizeNumericEdit).BeginInit();
            panel1.SuspendLayout();
            ClientsTabPage.SuspendLayout();
            ClientsPanel.SuspendLayout();
            AboutTabPage.SuspendLayout();
            AboutPanel.SuspendLayout();
            TrayMenu.SuspendLayout();
            SuspendLayout();
            // 
            // RestoreWindowMenuItem
            // 
            RestoreWindowMenuItem.Name = "RestoreWindowMenuItem";
            RestoreWindowMenuItem.Size = new Size(209, 30);
            RestoreWindowMenuItem.Text = "主菜单";
            RestoreWindowMenuItem.Click += RestoreMainForm_Handler;
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(209, 30);
            ExitMenuItem.Text = "退出";
            ExitMenuItem.Click += ExitMenuItemClick_Handler;
            // 
            // TitleMenuItem
            // 
            TitleMenuItem.Enabled = false;
            TitleMenuItem.Name = "TitleMenuItem";
            TitleMenuItem.Size = new Size(209, 30);
            TitleMenuItem.Text = "EVE-O-Preview";
            // 
            // SeparatorMenuItem
            // 
            SeparatorMenuItem.Name = "SeparatorMenuItem";
            SeparatorMenuItem.Size = new Size(206, 6);
            // 
            // ContentTabControl
            // 
            ContentTabControl.Alignment = TabAlignment.Left;
            ContentTabControl.Controls.Add(GeneralTabPage);
            ContentTabControl.Controls.Add(HotkeysTabPage);
            ContentTabControl.Controls.Add(ThumbnailTabPage);
            ContentTabControl.Controls.Add(ZoomTabPage);
            ContentTabControl.Controls.Add(OverlayTabPage);
            ContentTabControl.Controls.Add(ClientsTabPage);
            ContentTabControl.Controls.Add(AboutTabPage);
            ContentTabControl.Dock = DockStyle.Fill;
            ContentTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            ContentTabControl.ItemSize = new Size(35, 120);
            ContentTabControl.Location = new Point(0, 0);
            ContentTabControl.Margin = new Padding(6);
            ContentTabControl.Multiline = true;
            ContentTabControl.Name = "ContentTabControl";
            ContentTabControl.SelectedIndex = 0;
            ContentTabControl.Size = new Size(715, 402);
            ContentTabControl.SizeMode = TabSizeMode.Fixed;
            ContentTabControl.TabIndex = 6;
            ContentTabControl.DrawItem += ContentTabControl_DrawItem;
            // 
            // GeneralTabPage
            // 
            GeneralTabPage.BackColor = SystemColors.Control;
            GeneralTabPage.Controls.Add(GeneralSettingsPanel);
            GeneralTabPage.Location = new Point(124, 4);
            GeneralTabPage.Margin = new Padding(6);
            GeneralTabPage.Name = "GeneralTabPage";
            GeneralTabPage.Padding = new Padding(6);
            GeneralTabPage.Size = new Size(587, 394);
            GeneralTabPage.TabIndex = 0;
            GeneralTabPage.Text = "常规";
            // 
            // GeneralSettingsPanel
            // 
            GeneralSettingsPanel.BorderStyle = BorderStyle.FixedSingle;
            GeneralSettingsPanel.Controls.Add(label4);
            GeneralSettingsPanel.Controls.Add(AnimationStyleCombo);
            GeneralSettingsPanel.Controls.Add(MinimizeInactiveClientsCheckBox);
            GeneralSettingsPanel.Controls.Add(EnableClientLayoutTrackingCheckBox);
            GeneralSettingsPanel.Controls.Add(HideActiveClientThumbnailCheckBox);
            GeneralSettingsPanel.Controls.Add(ShowThumbnailsAlwaysOnTopCheckBox);
            GeneralSettingsPanel.Controls.Add(HideThumbnailsOnLostFocusCheckBox);
            GeneralSettingsPanel.Controls.Add(EnablePerClientThumbnailsLayoutsCheckBox);
            GeneralSettingsPanel.Controls.Add(MinimizeToTrayCheckBox);
            GeneralSettingsPanel.Dock = DockStyle.Fill;
            GeneralSettingsPanel.Location = new Point(6, 6);
            GeneralSettingsPanel.Margin = new Padding(6);
            GeneralSettingsPanel.Name = "GeneralSettingsPanel";
            GeneralSettingsPanel.Size = new Size(575, 382);
            GeneralSettingsPanel.TabIndex = 18;
            GeneralSettingsPanel.Paint += GeneralSettingsPanel_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 184);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 27;
            label4.Text = "动画样式";
            // 
            // AnimationStyleCombo
            // 
            AnimationStyleCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            AnimationStyleCombo.FormattingEnabled = true;
            AnimationStyleCombo.Location = new Point(165, 180);
            AnimationStyleCombo.Margin = new Padding(6);
            AnimationStyleCombo.Name = "AnimationStyleCombo";
            AnimationStyleCombo.Size = new Size(276, 32);
            AnimationStyleCombo.TabIndex = 26;
            AnimationStyleCombo.SelectedIndexChanged += OptionChanged_Handler;
            // 
            // MinimizeInactiveClientsCheckBox
            // 
            MinimizeInactiveClientsCheckBox.AutoSize = true;
            MinimizeInactiveClientsCheckBox.Location = new Point(14, 144);
            MinimizeInactiveClientsCheckBox.Margin = new Padding(6);
            MinimizeInactiveClientsCheckBox.Name = "MinimizeInactiveClientsCheckBox";
            MinimizeInactiveClientsCheckBox.Size = new Size(258, 28);
            MinimizeInactiveClientsCheckBox.TabIndex = 24;
            MinimizeInactiveClientsCheckBox.Text = "最小化非活动的 EVE 客户端";
            MinimizeInactiveClientsCheckBox.UseVisualStyleBackColor = true;
            MinimizeInactiveClientsCheckBox.CheckedChanged += OptionChanged_Handler;
            // 
            // EnableClientLayoutTrackingCheckBox
            // 
            EnableClientLayoutTrackingCheckBox.AutoSize = true;
            EnableClientLayoutTrackingCheckBox.Location = new Point(14, 58);
            EnableClientLayoutTrackingCheckBox.Margin = new Padding(6);
            EnableClientLayoutTrackingCheckBox.Name = "EnableClientLayoutTrackingCheckBox";
            EnableClientLayoutTrackingCheckBox.Size = new Size(162, 28);
            EnableClientLayoutTrackingCheckBox.TabIndex = 19;
            EnableClientLayoutTrackingCheckBox.Text = "记录客户端位置";
            EnableClientLayoutTrackingCheckBox.UseVisualStyleBackColor = true;
            EnableClientLayoutTrackingCheckBox.CheckedChanged += OptionChanged_Handler;
            // 
            // HideActiveClientThumbnailCheckBox
            // 
            HideActiveClientThumbnailCheckBox.AutoSize = true;
            HideActiveClientThumbnailCheckBox.Checked = true;
            HideActiveClientThumbnailCheckBox.CheckState = CheckState.Checked;
            HideActiveClientThumbnailCheckBox.Location = new Point(14, 102);
            HideActiveClientThumbnailCheckBox.Margin = new Padding(6);
            HideActiveClientThumbnailCheckBox.Name = "HideActiveClientThumbnailCheckBox";
            HideActiveClientThumbnailCheckBox.Size = new Size(258, 28);
            HideActiveClientThumbnailCheckBox.TabIndex = 20;
            HideActiveClientThumbnailCheckBox.Text = "隐藏活动 EVE 客户端的预览";
            HideActiveClientThumbnailCheckBox.UseVisualStyleBackColor = true;
            HideActiveClientThumbnailCheckBox.CheckedChanged += OptionChanged_Handler;
            // 
            // ShowThumbnailsAlwaysOnTopCheckBox
            // 
            ShowThumbnailsAlwaysOnTopCheckBox.AutoSize = true;
            ShowThumbnailsAlwaysOnTopCheckBox.Checked = true;
            ShowThumbnailsAlwaysOnTopCheckBox.CheckState = CheckState.Checked;
            ShowThumbnailsAlwaysOnTopCheckBox.Location = new Point(14, 228);
            ShowThumbnailsAlwaysOnTopCheckBox.Margin = new Padding(6);
            ShowThumbnailsAlwaysOnTopCheckBox.Name = "ShowThumbnailsAlwaysOnTopCheckBox";
            ShowThumbnailsAlwaysOnTopCheckBox.RightToLeft = RightToLeft.No;
            ShowThumbnailsAlwaysOnTopCheckBox.Size = new Size(180, 28);
            ShowThumbnailsAlwaysOnTopCheckBox.TabIndex = 21;
            ShowThumbnailsAlwaysOnTopCheckBox.Text = "预览窗口始终置顶";
            ShowThumbnailsAlwaysOnTopCheckBox.UseVisualStyleBackColor = true;
            ShowThumbnailsAlwaysOnTopCheckBox.CheckedChanged += OptionChanged_Handler;
            // 
            // HideThumbnailsOnLostFocusCheckBox
            // 
            HideThumbnailsOnLostFocusCheckBox.AutoSize = true;
            HideThumbnailsOnLostFocusCheckBox.Checked = true;
            HideThumbnailsOnLostFocusCheckBox.CheckState = CheckState.Checked;
            HideThumbnailsOnLostFocusCheckBox.Location = new Point(14, 274);
            HideThumbnailsOnLostFocusCheckBox.Margin = new Padding(6);
            HideThumbnailsOnLostFocusCheckBox.Name = "HideThumbnailsOnLostFocusCheckBox";
            HideThumbnailsOnLostFocusCheckBox.Size = new Size(330, 28);
            HideThumbnailsOnLostFocusCheckBox.TabIndex = 22;
            HideThumbnailsOnLostFocusCheckBox.Text = "当 EVE 客户端不活动时隐藏预览窗口";
            HideThumbnailsOnLostFocusCheckBox.UseVisualStyleBackColor = true;
            HideThumbnailsOnLostFocusCheckBox.CheckedChanged += OptionChanged_Handler;
            // 
            // EnablePerClientThumbnailsLayoutsCheckBox
            // 
            EnablePerClientThumbnailsLayoutsCheckBox.AutoSize = true;
            EnablePerClientThumbnailsLayoutsCheckBox.Checked = true;
            EnablePerClientThumbnailsLayoutsCheckBox.CheckState = CheckState.Checked;
            EnablePerClientThumbnailsLayoutsCheckBox.Location = new Point(14, 318);
            EnablePerClientThumbnailsLayoutsCheckBox.Margin = new Padding(6);
            EnablePerClientThumbnailsLayoutsCheckBox.Name = "EnablePerClientThumbnailsLayoutsCheckBox";
            EnablePerClientThumbnailsLayoutsCheckBox.Size = new Size(294, 28);
            EnablePerClientThumbnailsLayoutsCheckBox.TabIndex = 23;
            EnablePerClientThumbnailsLayoutsCheckBox.Text = "为每个 EVE 客户端使用独立布局";
            EnablePerClientThumbnailsLayoutsCheckBox.UseVisualStyleBackColor = true;
            EnablePerClientThumbnailsLayoutsCheckBox.CheckedChanged += OptionChanged_Handler;
            // 
            // MinimizeToTrayCheckBox
            // 
            MinimizeToTrayCheckBox.AutoSize = true;
            MinimizeToTrayCheckBox.Location = new Point(14, 12);
            MinimizeToTrayCheckBox.Margin = new Padding(6);
            MinimizeToTrayCheckBox.Name = "MinimizeToTrayCheckBox";
            MinimizeToTrayCheckBox.Size = new Size(180, 28);
            MinimizeToTrayCheckBox.TabIndex = 18;
            MinimizeToTrayCheckBox.Text = "最小化到系统托盘";
            MinimizeToTrayCheckBox.UseVisualStyleBackColor = true;
            MinimizeToTrayCheckBox.CheckedChanged += OptionChanged_Handler;
            // 
            // HotkeysTabPage
            // 
            HotkeysTabPage.BackColor = SystemColors.Control;
            HotkeysTabPage.Controls.Add(CycleGroupSelectorComboBox);
            HotkeysTabPage.Controls.Add(HotkeysForwardLabel);
            HotkeysTabPage.Controls.Add(HotkeysForwardListBox);
            HotkeysTabPage.Controls.Add(HotkeysForwardAddButton);
            HotkeysTabPage.Controls.Add(HotkeysForwardRemoveButton);
            HotkeysTabPage.Controls.Add(HotkeysBackwardLabel);
            HotkeysTabPage.Controls.Add(HotkeysBackwardListBox);
            HotkeysTabPage.Controls.Add(HotkeysBackwardAddButton);
            HotkeysTabPage.Controls.Add(HotkeysBackwardRemoveButton);
            HotkeysTabPage.Controls.Add(HotkeyCaptureTextBox);
            HotkeysTabPage.Controls.Add(HotkeysClientsList);
            HotkeysTabPage.Controls.Add(HotkeysClientUpButton);
            HotkeysTabPage.Controls.Add(HotkeysClientDownButton);
            HotkeysTabPage.Controls.Add(HotkeyCaptureButton);
            HotkeysTabPage.Controls.Add(HotkeyReadmeTextBox);
            HotkeysTabPage.Controls.Add(HotkeySaveButton);
            HotkeysTabPage.Location = new Point(124, 4);
            HotkeysTabPage.Margin = new Padding(6);
            HotkeysTabPage.Name = "HotkeysTabPage";
            HotkeysTabPage.Padding = new Padding(6);
            HotkeysTabPage.Size = new Size(587, 394);
            HotkeysTabPage.TabIndex = 5;
            HotkeysTabPage.Text = "热键";
            // 
            // CycleGroupSelectorComboBox
            // 
            CycleGroupSelectorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CycleGroupSelectorComboBox.Items.AddRange(new object[] { "组 1", "组 2", "组 3", "组 4", "组 5" });
            CycleGroupSelectorComboBox.Location = new Point(9, 3);
            CycleGroupSelectorComboBox.Name = "CycleGroupSelectorComboBox";
            CycleGroupSelectorComboBox.Size = new Size(99, 32);
            CycleGroupSelectorComboBox.TabIndex = 0;
            CycleGroupSelectorComboBox.SelectedIndexChanged += CycleGroupSelectorComboBox_SelectedIndexChanged;
            // 
            // HotkeysForwardLabel
            // 
            HotkeysForwardLabel.AutoSize = true;
            HotkeysForwardLabel.Location = new Point(3, 50);
            HotkeysForwardLabel.Name = "HotkeysForwardLabel";
            HotkeysForwardLabel.Size = new Size(46, 24);
            HotkeysForwardLabel.TabIndex = 1;
            HotkeysForwardLabel.Text = "前进";
            // 
            // HotkeysForwardListBox
            // 
            HotkeysForwardListBox.ItemHeight = 24;
            HotkeysForwardListBox.Location = new Point(9, 77);
            HotkeysForwardListBox.Name = "HotkeysForwardListBox";
            HotkeysForwardListBox.Size = new Size(158, 100);
            HotkeysForwardListBox.TabIndex = 2;
            // 
            // HotkeysForwardAddButton
            // 
            HotkeysForwardAddButton.Location = new Point(42, 47);
            HotkeysForwardAddButton.Name = "HotkeysForwardAddButton";
            HotkeysForwardAddButton.Size = new Size(66, 31);
            HotkeysForwardAddButton.TabIndex = 3;
            HotkeysForwardAddButton.Text = "添加";
            HotkeysForwardAddButton.Click += HotkeysForwardAddButton_Click;
            // 
            // HotkeysForwardRemoveButton
            // 
            HotkeysForwardRemoveButton.Location = new Point(101, 47);
            HotkeysForwardRemoveButton.Name = "HotkeysForwardRemoveButton";
            HotkeysForwardRemoveButton.Size = new Size(66, 31);
            HotkeysForwardRemoveButton.TabIndex = 4;
            HotkeysForwardRemoveButton.Text = "移除";
            HotkeysForwardRemoveButton.Click += HotkeysForwardRemoveButton_Click;
            // 
            // HotkeysBackwardLabel
            // 
            HotkeysBackwardLabel.AutoSize = true;
            HotkeysBackwardLabel.Location = new Point(3, 180);
            HotkeysBackwardLabel.Name = "HotkeysBackwardLabel";
            HotkeysBackwardLabel.Size = new Size(46, 24);
            HotkeysBackwardLabel.TabIndex = 5;
            HotkeysBackwardLabel.Text = "后退";
            // 
            // HotkeysBackwardListBox
            // 
            HotkeysBackwardListBox.ItemHeight = 24;
            HotkeysBackwardListBox.Location = new Point(9, 207);
            HotkeysBackwardListBox.Name = "HotkeysBackwardListBox";
            HotkeysBackwardListBox.Size = new Size(158, 100);
            HotkeysBackwardListBox.TabIndex = 6;
            // 
            // HotkeysBackwardAddButton
            // 
            HotkeysBackwardAddButton.Location = new Point(42, 177);
            HotkeysBackwardAddButton.Name = "HotkeysBackwardAddButton";
            HotkeysBackwardAddButton.Size = new Size(66, 31);
            HotkeysBackwardAddButton.TabIndex = 7;
            HotkeysBackwardAddButton.Text = "添加";
            HotkeysBackwardAddButton.Click += HotkeysBackwardAddButton_Click;
            // 
            // HotkeysBackwardRemoveButton
            // 
            HotkeysBackwardRemoveButton.Location = new Point(101, 177);
            HotkeysBackwardRemoveButton.Name = "HotkeysBackwardRemoveButton";
            HotkeysBackwardRemoveButton.Size = new Size(66, 31);
            HotkeysBackwardRemoveButton.TabIndex = 8;
            HotkeysBackwardRemoveButton.Text = "移除";
            HotkeysBackwardRemoveButton.Click += HotkeysBackwardRemoveButton_Click;
            // 
            // HotkeyCaptureTextBox
            // 
            HotkeyCaptureTextBox.Location = new Point(237, 3);
            HotkeyCaptureTextBox.Name = "HotkeyCaptureTextBox";
            HotkeyCaptureTextBox.Size = new Size(251, 30);
            HotkeyCaptureTextBox.TabIndex = 9;
            HotkeyCaptureTextBox.KeyDown += HotkeyCaptureTextBox_KeyDown;
            HotkeyCaptureTextBox.MouseDown += HotkeyCaptureTextBox_MouseDown;
            // 
            // HotkeysClientsList
            // 
            HotkeysClientsList.Location = new Point(174, 50);
            HotkeysClientsList.Name = "HotkeysClientsList";
            HotkeysClientsList.Size = new Size(278, 220);
            HotkeysClientsList.TabIndex = 10;
            // 
            // HotkeysClientUpButton
            // 
            HotkeysClientUpButton.Location = new Point(483, 50);
            HotkeysClientUpButton.Name = "HotkeysClientUpButton";
            HotkeysClientUpButton.Size = new Size(73, 32);
            HotkeysClientUpButton.TabIndex = 11;
            HotkeysClientUpButton.Text = "上移";
            HotkeysClientUpButton.Click += HotkeysClientUpButton_Click;
            // 
            // HotkeysClientDownButton
            // 
            HotkeysClientDownButton.Location = new Point(483, 98);
            HotkeysClientDownButton.Name = "HotkeysClientDownButton";
            HotkeysClientDownButton.Size = new Size(73, 32);
            HotkeysClientDownButton.TabIndex = 12;
            HotkeysClientDownButton.Text = "下移";
            HotkeysClientDownButton.Click += HotkeysClientDownButton_Click;
            // 
            // HotkeyCaptureButton
            // 
            HotkeyCaptureButton.Location = new Point(123, 3);
            HotkeyCaptureButton.Name = "HotkeyCaptureButton";
            HotkeyCaptureButton.Size = new Size(108, 30);
            HotkeyCaptureButton.TabIndex = 13;
            HotkeyCaptureButton.Text = "开始捕获";
            HotkeyCaptureButton.Click += HotkeyCaptureButton_Click;
            // 
            // HotkeyReadmeTextBox
            // 
            HotkeyReadmeTextBox.Location = new Point(173, 276);
            HotkeyReadmeTextBox.Multiline = true;
            HotkeyReadmeTextBox.Name = "HotkeyReadmeTextBox";
            HotkeyReadmeTextBox.ReadOnly = true;
            HotkeyReadmeTextBox.Size = new Size(405, 109);
            HotkeyReadmeTextBox.TabIndex = 14;
            HotkeyReadmeTextBox.Text = "使用说明:\r\n上方热键缓存可捕获可写入，录入缓存后点添加\r\n没有角色请移动下对应角色缩略图后重启本软件";
            // 
            // HotkeySaveButton
            // 
            HotkeySaveButton.Location = new Point(9, 313);
            HotkeySaveButton.Name = "HotkeySaveButton";
            HotkeySaveButton.Size = new Size(158, 35);
            HotkeySaveButton.TabIndex = 15;
            HotkeySaveButton.Text = "保存";
            HotkeySaveButton.Click += HotkeySaveButton_Click;
            // 
            // ThumbnailTabPage
            // 
            ThumbnailTabPage.BackColor = SystemColors.Control;
            ThumbnailTabPage.Controls.Add(ThumbnailSettingsPanel);
            ThumbnailTabPage.Location = new Point(124, 4);
            ThumbnailTabPage.Margin = new Padding(6);
            ThumbnailTabPage.Name = "ThumbnailTabPage";
            ThumbnailTabPage.Padding = new Padding(6);
            ThumbnailTabPage.Size = new Size(587, 394);
            ThumbnailTabPage.TabIndex = 1;
            ThumbnailTabPage.Text = "缩略图";
            // 
            // ThumbnailSettingsPanel
            // 
            ThumbnailSettingsPanel.BorderStyle = BorderStyle.FixedSingle;
            ThumbnailSettingsPanel.Controls.Add(ThumbnailSnapToGridCheckBox);
            ThumbnailSettingsPanel.Controls.Add(ThumbnailSnapToGridSizeYNumericEdit);
            ThumbnailSettingsPanel.Controls.Add(SnapYLabel);
            ThumbnailSettingsPanel.Controls.Add(ThumbnailSnapToGridSizeXNumericEdit);
            ThumbnailSettingsPanel.Controls.Add(SnapXLabel);
            ThumbnailSettingsPanel.Controls.Add(LockThumbnailLocationCheckbox);
            ThumbnailSettingsPanel.Controls.Add(HeigthLabel);
            ThumbnailSettingsPanel.Controls.Add(WidthLabel);
            ThumbnailSettingsPanel.Controls.Add(ThumbnailsWidthNumericEdit);
            ThumbnailSettingsPanel.Controls.Add(ThumbnailsHeightNumericEdit);
            ThumbnailSettingsPanel.Controls.Add(ThumbnailOpacityTrackBar);
            ThumbnailSettingsPanel.Controls.Add(OpacityLabel);
            ThumbnailSettingsPanel.Dock = DockStyle.Fill;
            ThumbnailSettingsPanel.Location = new Point(6, 6);
            ThumbnailSettingsPanel.Margin = new Padding(6);
            ThumbnailSettingsPanel.Name = "ThumbnailSettingsPanel";
            ThumbnailSettingsPanel.Size = new Size(575, 382);
            ThumbnailSettingsPanel.TabIndex = 19;
            // 
            // ThumbnailSnapToGridCheckBox
            // 
            ThumbnailSnapToGridCheckBox.AutoSize = true;
            ThumbnailSnapToGridCheckBox.Location = new Point(20, 192);
            ThumbnailSnapToGridCheckBox.Margin = new Padding(6);
            ThumbnailSnapToGridCheckBox.Name = "ThumbnailSnapToGridCheckBox";
            ThumbnailSnapToGridCheckBox.Size = new Size(162, 28);
            ThumbnailSnapToGridCheckBox.TabIndex = 32;
            ThumbnailSnapToGridCheckBox.Text = "缩略图对齐网格";
            ThumbnailSnapToGridCheckBox.UseVisualStyleBackColor = true;
            ThumbnailSnapToGridCheckBox.CheckedChanged += OptionChanged_Handler;
            // 
            // ThumbnailSnapToGridSizeYNumericEdit
            // 
            ThumbnailSnapToGridSizeYNumericEdit.BackColor = SystemColors.Window;
            ThumbnailSnapToGridSizeYNumericEdit.BorderStyle = BorderStyle.FixedSingle;
            ThumbnailSnapToGridSizeYNumericEdit.CausesValidation = false;
            ThumbnailSnapToGridSizeYNumericEdit.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            ThumbnailSnapToGridSizeYNumericEdit.Location = new Point(239, 226);
            ThumbnailSnapToGridSizeYNumericEdit.Margin = new Padding(6);
            ThumbnailSnapToGridSizeYNumericEdit.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            ThumbnailSnapToGridSizeYNumericEdit.Name = "ThumbnailSnapToGridSizeYNumericEdit";
            ThumbnailSnapToGridSizeYNumericEdit.Size = new Size(88, 30);
            ThumbnailSnapToGridSizeYNumericEdit.TabIndex = 31;
            ThumbnailSnapToGridSizeYNumericEdit.Value = new decimal(new int[] { 100, 0, 0, 0 });
            ThumbnailSnapToGridSizeYNumericEdit.ValueChanged += OptionChanged_Handler;
            // 
            // SnapYLabel
            // 
            SnapYLabel.AutoSize = true;
            SnapYLabel.Location = new Point(201, 228);
            SnapYLabel.Margin = new Padding(6, 0, 6, 0);
            SnapYLabel.Name = "SnapYLabel";
            SnapYLabel.Size = new Size(21, 24);
            SnapYLabel.TabIndex = 30;
            SnapYLabel.Text = "Y";
            // 
            // ThumbnailSnapToGridSizeXNumericEdit
            // 
            ThumbnailSnapToGridSizeXNumericEdit.BackColor = SystemColors.Window;
            ThumbnailSnapToGridSizeXNumericEdit.BorderStyle = BorderStyle.FixedSingle;
            ThumbnailSnapToGridSizeXNumericEdit.CausesValidation = false;
            ThumbnailSnapToGridSizeXNumericEdit.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            ThumbnailSnapToGridSizeXNumericEdit.Location = new Point(102, 226);
            ThumbnailSnapToGridSizeXNumericEdit.Margin = new Padding(6);
            ThumbnailSnapToGridSizeXNumericEdit.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            ThumbnailSnapToGridSizeXNumericEdit.Name = "ThumbnailSnapToGridSizeXNumericEdit";
            ThumbnailSnapToGridSizeXNumericEdit.Size = new Size(88, 30);
            ThumbnailSnapToGridSizeXNumericEdit.TabIndex = 29;
            ThumbnailSnapToGridSizeXNumericEdit.Value = new decimal(new int[] { 100, 0, 0, 0 });
            ThumbnailSnapToGridSizeXNumericEdit.ValueChanged += OptionChanged_Handler;
            // 
            // SnapXLabel
            // 
            SnapXLabel.AutoSize = true;
            SnapXLabel.Location = new Point(14, 228);
            SnapXLabel.Margin = new Padding(6, 0, 6, 0);
            SnapXLabel.Name = "SnapXLabel";
            SnapXLabel.Size = new Size(63, 24);
            SnapXLabel.TabIndex = 28;
            SnapXLabel.Text = "对齐 X";
            // 
            // LockThumbnailLocationCheckbox
            // 
            LockThumbnailLocationCheckbox.AutoSize = true;
            LockThumbnailLocationCheckbox.Location = new Point(20, 150);
            LockThumbnailLocationCheckbox.Margin = new Padding(6);
            LockThumbnailLocationCheckbox.Name = "LockThumbnailLocationCheckbox";
            LockThumbnailLocationCheckbox.Size = new Size(162, 28);
            LockThumbnailLocationCheckbox.TabIndex = 26;
            LockThumbnailLocationCheckbox.Text = "锁定缩略图位置";
            LockThumbnailLocationCheckbox.UseVisualStyleBackColor = true;
            LockThumbnailLocationCheckbox.CheckedChanged += OptionChanged_Handler;
            // 
            // HeigthLabel
            // 
            HeigthLabel.AutoSize = true;
            HeigthLabel.Location = new Point(14, 106);
            HeigthLabel.Margin = new Padding(6, 0, 6, 0);
            HeigthLabel.Name = "HeigthLabel";
            HeigthLabel.Size = new Size(100, 24);
            HeigthLabel.TabIndex = 24;
            HeigthLabel.Text = "缩略图高度";
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(14, 60);
            WidthLabel.Margin = new Padding(6, 0, 6, 0);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(100, 24);
            WidthLabel.TabIndex = 23;
            WidthLabel.Text = "缩略图宽度";
            // 
            // ThumbnailsWidthNumericEdit
            // 
            ThumbnailsWidthNumericEdit.BackColor = SystemColors.Window;
            ThumbnailsWidthNumericEdit.BorderStyle = BorderStyle.FixedSingle;
            ThumbnailsWidthNumericEdit.CausesValidation = false;
            ThumbnailsWidthNumericEdit.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            ThumbnailsWidthNumericEdit.Location = new Point(192, 58);
            ThumbnailsWidthNumericEdit.Margin = new Padding(6);
            ThumbnailsWidthNumericEdit.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            ThumbnailsWidthNumericEdit.Name = "ThumbnailsWidthNumericEdit";
            ThumbnailsWidthNumericEdit.Size = new Size(88, 30);
            ThumbnailsWidthNumericEdit.TabIndex = 21;
            ThumbnailsWidthNumericEdit.Value = new decimal(new int[] { 100, 0, 0, 0 });
            ThumbnailsWidthNumericEdit.ValueChanged += ThumbnailSizeChanged_Handler;
            // 
            // ThumbnailsHeightNumericEdit
            // 
            ThumbnailsHeightNumericEdit.BackColor = SystemColors.Window;
            ThumbnailsHeightNumericEdit.BorderStyle = BorderStyle.FixedSingle;
            ThumbnailsHeightNumericEdit.CausesValidation = false;
            ThumbnailsHeightNumericEdit.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            ThumbnailsHeightNumericEdit.Location = new Point(192, 102);
            ThumbnailsHeightNumericEdit.Margin = new Padding(6);
            ThumbnailsHeightNumericEdit.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            ThumbnailsHeightNumericEdit.Name = "ThumbnailsHeightNumericEdit";
            ThumbnailsHeightNumericEdit.Size = new Size(88, 30);
            ThumbnailsHeightNumericEdit.TabIndex = 22;
            ThumbnailsHeightNumericEdit.Value = new decimal(new int[] { 70, 0, 0, 0 });
            ThumbnailsHeightNumericEdit.ValueChanged += ThumbnailSizeChanged_Handler;
            // 
            // ThumbnailOpacityTrackBar
            // 
            ThumbnailOpacityTrackBar.AutoSize = false;
            ThumbnailOpacityTrackBar.LargeChange = 10;
            ThumbnailOpacityTrackBar.Location = new Point(112, 12);
            ThumbnailOpacityTrackBar.Margin = new Padding(6);
            ThumbnailOpacityTrackBar.Maximum = 100;
            ThumbnailOpacityTrackBar.Minimum = 20;
            ThumbnailOpacityTrackBar.Name = "ThumbnailOpacityTrackBar";
            ThumbnailOpacityTrackBar.Size = new Size(350, 40);
            ThumbnailOpacityTrackBar.TabIndex = 20;
            ThumbnailOpacityTrackBar.TickFrequency = 10;
            ThumbnailOpacityTrackBar.Value = 20;
            ThumbnailOpacityTrackBar.ValueChanged += OptionChanged_Handler;
            // 
            // OpacityLabel
            // 
            OpacityLabel.AutoSize = true;
            OpacityLabel.Location = new Point(14, 16);
            OpacityLabel.Margin = new Padding(6, 0, 6, 0);
            OpacityLabel.Name = "OpacityLabel";
            OpacityLabel.Size = new Size(64, 24);
            OpacityLabel.TabIndex = 19;
            OpacityLabel.Text = "透明度";
            // 
            // ZoomTabPage
            // 
            ZoomTabPage.BackColor = SystemColors.Control;
            ZoomTabPage.Controls.Add(ZoomSettingsPanel);
            ZoomTabPage.Location = new Point(124, 4);
            ZoomTabPage.Margin = new Padding(6);
            ZoomTabPage.Name = "ZoomTabPage";
            ZoomTabPage.Size = new Size(587, 394);
            ZoomTabPage.TabIndex = 2;
            ZoomTabPage.Text = "缩放";
            // 
            // ZoomSettingsPanel
            // 
            ZoomSettingsPanel.BorderStyle = BorderStyle.FixedSingle;
            ZoomSettingsPanel.Controls.Add(ZoomFactorLabel);
            ZoomSettingsPanel.Controls.Add(ZoomAnchorPanel);
            ZoomSettingsPanel.Controls.Add(ZoomAnchorLabel);
            ZoomSettingsPanel.Controls.Add(EnableThumbnailZoomCheckBox);
            ZoomSettingsPanel.Controls.Add(ThumbnailZoomFactorNumericEdit);
            ZoomSettingsPanel.Dock = DockStyle.Fill;
            ZoomSettingsPanel.Location = new Point(0, 0);
            ZoomSettingsPanel.Margin = new Padding(6);
            ZoomSettingsPanel.Name = "ZoomSettingsPanel";
            ZoomSettingsPanel.Size = new Size(587, 394);
            ZoomSettingsPanel.TabIndex = 36;
            // 
            // ZoomFactorLabel
            // 
            ZoomFactorLabel.AutoSize = true;
            ZoomFactorLabel.Location = new Point(14, 60);
            ZoomFactorLabel.Margin = new Padding(6, 0, 6, 0);
            ZoomFactorLabel.Name = "ZoomFactorLabel";
            ZoomFactorLabel.Size = new Size(82, 24);
            ZoomFactorLabel.TabIndex = 39;
            ZoomFactorLabel.Text = "缩放系数";
            // 
            // ZoomAnchorPanel
            // 
            ZoomAnchorPanel.BorderStyle = BorderStyle.FixedSingle;
            ZoomAnchorPanel.Controls.Add(ZoomAanchorNWRadioButton);
            ZoomAnchorPanel.Controls.Add(ZoomAanchorNRadioButton);
            ZoomAnchorPanel.Controls.Add(ZoomAanchorNERadioButton);
            ZoomAnchorPanel.Controls.Add(ZoomAanchorWRadioButton);
            ZoomAnchorPanel.Controls.Add(ZoomAanchorSERadioButton);
            ZoomAnchorPanel.Controls.Add(ZoomAanchorCRadioButton);
            ZoomAnchorPanel.Controls.Add(ZoomAanchorSRadioButton);
            ZoomAnchorPanel.Controls.Add(ZoomAanchorERadioButton);
            ZoomAnchorPanel.Controls.Add(ZoomAanchorSWRadioButton);
            ZoomAnchorPanel.Location = new Point(148, 100);
            ZoomAnchorPanel.Margin = new Padding(6);
            ZoomAnchorPanel.Name = "ZoomAnchorPanel";
            ZoomAnchorPanel.Size = new Size(140, 134);
            ZoomAnchorPanel.TabIndex = 38;
            // 
            // ZoomAanchorNWRadioButton
            // 
            ZoomAanchorNWRadioButton.AutoSize = true;
            ZoomAanchorNWRadioButton.Location = new Point(6, 6);
            ZoomAanchorNWRadioButton.Margin = new Padding(6);
            ZoomAanchorNWRadioButton.Name = "ZoomAanchorNWRadioButton";
            ZoomAanchorNWRadioButton.Size = new Size(21, 20);
            ZoomAanchorNWRadioButton.TabIndex = 0;
            ZoomAanchorNWRadioButton.TabStop = true;
            ZoomAanchorNWRadioButton.UseVisualStyleBackColor = true;
            ZoomAanchorNWRadioButton.CheckedChanged += OptionChanged_Handler;
            // 
            // ZoomAanchorNRadioButton
            // 
            ZoomAanchorNRadioButton.AutoSize = true;
            ZoomAanchorNRadioButton.Location = new Point(57, 6);
            ZoomAanchorNRadioButton.Margin = new Padding(6);
            ZoomAanchorNRadioButton.Name = "ZoomAanchorNRadioButton";
            ZoomAanchorNRadioButton.Size = new Size(21, 20);
            ZoomAanchorNRadioButton.TabIndex = 1;
            ZoomAanchorNRadioButton.TabStop = true;
            ZoomAanchorNRadioButton.UseVisualStyleBackColor = true;
            ZoomAanchorNRadioButton.CheckedChanged += OptionChanged_Handler;
            // 
            // ZoomAanchorNERadioButton
            // 
            ZoomAanchorNERadioButton.AutoSize = true;
            ZoomAanchorNERadioButton.Location = new Point(108, 6);
            ZoomAanchorNERadioButton.Margin = new Padding(6);
            ZoomAanchorNERadioButton.Name = "ZoomAanchorNERadioButton";
            ZoomAanchorNERadioButton.Size = new Size(21, 20);
            ZoomAanchorNERadioButton.TabIndex = 2;
            ZoomAanchorNERadioButton.TabStop = true;
            ZoomAanchorNERadioButton.UseVisualStyleBackColor = true;
            ZoomAanchorNERadioButton.CheckedChanged += OptionChanged_Handler;
            // 
            // ZoomAanchorWRadioButton
            // 
            ZoomAanchorWRadioButton.AutoSize = true;
            ZoomAanchorWRadioButton.Location = new Point(6, 54);
            ZoomAanchorWRadioButton.Margin = new Padding(6);
            ZoomAanchorWRadioButton.Name = "ZoomAanchorWRadioButton";
            ZoomAanchorWRadioButton.Size = new Size(21, 20);
            ZoomAanchorWRadioButton.TabIndex = 3;
            ZoomAanchorWRadioButton.TabStop = true;
            ZoomAanchorWRadioButton.UseVisualStyleBackColor = true;
            ZoomAanchorWRadioButton.CheckedChanged += OptionChanged_Handler;
            // 
            // ZoomAanchorSERadioButton
            // 
            ZoomAanchorSERadioButton.AutoSize = true;
            ZoomAanchorSERadioButton.Location = new Point(108, 102);
            ZoomAanchorSERadioButton.Margin = new Padding(6);
            ZoomAanchorSERadioButton.Name = "ZoomAanchorSERadioButton";
            ZoomAanchorSERadioButton.Size = new Size(21, 20);
            ZoomAanchorSERadioButton.TabIndex = 8;
            ZoomAanchorSERadioButton.TabStop = true;
            ZoomAanchorSERadioButton.UseVisualStyleBackColor = true;
            ZoomAanchorSERadioButton.CheckedChanged += OptionChanged_Handler;
            // 
            // ZoomAanchorCRadioButton
            // 
            ZoomAanchorCRadioButton.AutoSize = true;
            ZoomAanchorCRadioButton.Location = new Point(57, 54);
            ZoomAanchorCRadioButton.Margin = new Padding(6);
            ZoomAanchorCRadioButton.Name = "ZoomAanchorCRadioButton";
            ZoomAanchorCRadioButton.Size = new Size(21, 20);
            ZoomAanchorCRadioButton.TabIndex = 4;
            ZoomAanchorCRadioButton.TabStop = true;
            ZoomAanchorCRadioButton.UseVisualStyleBackColor = true;
            ZoomAanchorCRadioButton.CheckedChanged += OptionChanged_Handler;
            // 
            // ZoomAanchorSRadioButton
            // 
            ZoomAanchorSRadioButton.AutoSize = true;
            ZoomAanchorSRadioButton.Location = new Point(57, 102);
            ZoomAanchorSRadioButton.Margin = new Padding(6);
            ZoomAanchorSRadioButton.Name = "ZoomAanchorSRadioButton";
            ZoomAanchorSRadioButton.Size = new Size(21, 20);
            ZoomAanchorSRadioButton.TabIndex = 7;
            ZoomAanchorSRadioButton.TabStop = true;
            ZoomAanchorSRadioButton.UseVisualStyleBackColor = true;
            ZoomAanchorSRadioButton.CheckedChanged += OptionChanged_Handler;
            // 
            // ZoomAanchorERadioButton
            // 
            ZoomAanchorERadioButton.AutoSize = true;
            ZoomAanchorERadioButton.Location = new Point(108, 54);
            ZoomAanchorERadioButton.Margin = new Padding(6);
            ZoomAanchorERadioButton.Name = "ZoomAanchorERadioButton";
            ZoomAanchorERadioButton.Size = new Size(21, 20);
            ZoomAanchorERadioButton.TabIndex = 5;
            ZoomAanchorERadioButton.TabStop = true;
            ZoomAanchorERadioButton.UseVisualStyleBackColor = true;
            ZoomAanchorERadioButton.CheckedChanged += OptionChanged_Handler;
            // 
            // ZoomAanchorSWRadioButton
            // 
            ZoomAanchorSWRadioButton.AutoSize = true;
            ZoomAanchorSWRadioButton.Location = new Point(6, 102);
            ZoomAanchorSWRadioButton.Margin = new Padding(6);
            ZoomAanchorSWRadioButton.Name = "ZoomAanchorSWRadioButton";
            ZoomAanchorSWRadioButton.Size = new Size(21, 20);
            ZoomAanchorSWRadioButton.TabIndex = 6;
            ZoomAanchorSWRadioButton.TabStop = true;
            ZoomAanchorSWRadioButton.UseVisualStyleBackColor = true;
            ZoomAanchorSWRadioButton.CheckedChanged += OptionChanged_Handler;
            // 
            // ZoomAnchorLabel
            // 
            ZoomAnchorLabel.AutoSize = true;
            ZoomAnchorLabel.Location = new Point(14, 106);
            ZoomAnchorLabel.Margin = new Padding(6, 0, 6, 0);
            ZoomAnchorLabel.Name = "ZoomAnchorLabel";
            ZoomAnchorLabel.Size = new Size(46, 24);
            ZoomAnchorLabel.TabIndex = 40;
            ZoomAnchorLabel.Text = "锚点";
            // 
            // EnableThumbnailZoomCheckBox
            // 
            EnableThumbnailZoomCheckBox.AutoSize = true;
            EnableThumbnailZoomCheckBox.Checked = true;
            EnableThumbnailZoomCheckBox.CheckState = CheckState.Checked;
            EnableThumbnailZoomCheckBox.Location = new Point(14, 12);
            EnableThumbnailZoomCheckBox.Margin = new Padding(6);
            EnableThumbnailZoomCheckBox.Name = "EnableThumbnailZoomCheckBox";
            EnableThumbnailZoomCheckBox.RightToLeft = RightToLeft.No;
            EnableThumbnailZoomCheckBox.Size = new Size(126, 28);
            EnableThumbnailZoomCheckBox.TabIndex = 36;
            EnableThumbnailZoomCheckBox.Text = "悬停时缩放";
            EnableThumbnailZoomCheckBox.UseVisualStyleBackColor = true;
            EnableThumbnailZoomCheckBox.CheckedChanged += OptionChanged_Handler;
            // 
            // ThumbnailZoomFactorNumericEdit
            // 
            ThumbnailZoomFactorNumericEdit.BackColor = SystemColors.Window;
            ThumbnailZoomFactorNumericEdit.BorderStyle = BorderStyle.FixedSingle;
            ThumbnailZoomFactorNumericEdit.Location = new Point(148, 58);
            ThumbnailZoomFactorNumericEdit.Margin = new Padding(6);
            ThumbnailZoomFactorNumericEdit.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            ThumbnailZoomFactorNumericEdit.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            ThumbnailZoomFactorNumericEdit.Name = "ThumbnailZoomFactorNumericEdit";
            ThumbnailZoomFactorNumericEdit.Size = new Size(69, 30);
            ThumbnailZoomFactorNumericEdit.TabIndex = 37;
            ThumbnailZoomFactorNumericEdit.Value = new decimal(new int[] { 2, 0, 0, 0 });
            ThumbnailZoomFactorNumericEdit.ValueChanged += OptionChanged_Handler;
            // 
            // OverlayTabPage
            // 
            OverlayTabPage.BackColor = SystemColors.Control;
            OverlayTabPage.Controls.Add(OverlaySettingsPanel);
            OverlayTabPage.Location = new Point(124, 4);
            OverlayTabPage.Margin = new Padding(6);
            OverlayTabPage.Name = "OverlayTabPage";
            OverlayTabPage.Size = new Size(587, 394);
            OverlayTabPage.TabIndex = 3;
            OverlayTabPage.Text = "覆盖层";
            // 
            // OverlaySettingsPanel
            // 
            OverlaySettingsPanel.BorderStyle = BorderStyle.FixedSingle;
            OverlaySettingsPanel.Controls.Add(label3);
            OverlaySettingsPanel.Controls.Add(label2);
            OverlaySettingsPanel.Controls.Add(OverlayLabelColorButton);
            OverlaySettingsPanel.Controls.Add(OverlayLabelSizeNumericEdit);
            OverlaySettingsPanel.Controls.Add(panel1);
            OverlaySettingsPanel.Controls.Add(label1);
            OverlaySettingsPanel.Controls.Add(HighlightColorLabel);
            OverlaySettingsPanel.Controls.Add(ActiveClientHighlightColorButton);
            OverlaySettingsPanel.Controls.Add(EnableActiveClientHighlightCheckBox);
            OverlaySettingsPanel.Controls.Add(ShowThumbnailOverlaysCheckBox);
            OverlaySettingsPanel.Controls.Add(ShowThumbnailFramesCheckBox);
            OverlaySettingsPanel.Dock = DockStyle.Fill;
            OverlaySettingsPanel.Location = new Point(0, 0);
            OverlaySettingsPanel.Margin = new Padding(6);
            OverlaySettingsPanel.Name = "OverlaySettingsPanel";
            OverlaySettingsPanel.Size = new Size(587, 394);
            OverlaySettingsPanel.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 270);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 24);
            label3.TabIndex = 43;
            label3.Text = "位置";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 234);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 24);
            label2.TabIndex = 42;
            label2.Text = "颜色";
            // 
            // OverlayLabelColorButton
            // 
            OverlayLabelColorButton.BorderStyle = BorderStyle.FixedSingle;
            OverlayLabelColorButton.Location = new Point(77, 232);
            OverlayLabelColorButton.Margin = new Padding(6);
            OverlayLabelColorButton.Name = "OverlayLabelColorButton";
            OverlayLabelColorButton.Size = new Size(169, 30);
            OverlayLabelColorButton.TabIndex = 41;
            OverlayLabelColorButton.Click += OverlayLabelColorButton_Click;
            // 
            // OverlayLabelSizeNumericEdit
            // 
            OverlayLabelSizeNumericEdit.BackColor = SystemColors.Window;
            OverlayLabelSizeNumericEdit.BorderStyle = BorderStyle.FixedSingle;
            OverlayLabelSizeNumericEdit.CausesValidation = false;
            OverlayLabelSizeNumericEdit.Location = new Point(160, 184);
            OverlayLabelSizeNumericEdit.Margin = new Padding(6);
            OverlayLabelSizeNumericEdit.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            OverlayLabelSizeNumericEdit.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            OverlayLabelSizeNumericEdit.Name = "OverlayLabelSizeNumericEdit";
            OverlayLabelSizeNumericEdit.Size = new Size(88, 30);
            OverlayLabelSizeNumericEdit.TabIndex = 40;
            OverlayLabelSizeNumericEdit.Value = new decimal(new int[] { 30, 0, 0, 0 });
            OverlayLabelSizeNumericEdit.ValueChanged += OptionChanged_Handler;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(OverlayLabelNWRadioButton);
            panel1.Controls.Add(OverlayLabelNRadioButton);
            panel1.Controls.Add(OverlayLabelNERadioButton);
            panel1.Controls.Add(OverlayLabelWRadioButton);
            panel1.Controls.Add(OverlayLabelSERadioButton);
            panel1.Controls.Add(OverlayLabelCRadioButton);
            panel1.Controls.Add(OverlayLabelSRadioButton);
            panel1.Controls.Add(OverlayLabelERadioButton);
            panel1.Controls.Add(OverlayLabelSWRadioButton);
            panel1.Location = new Point(132, 276);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(114, 104);
            panel1.TabIndex = 39;
            // 
            // OverlayLabelNWRadioButton
            // 
            OverlayLabelNWRadioButton.AutoSize = true;
            OverlayLabelNWRadioButton.Location = new Point(6, 6);
            OverlayLabelNWRadioButton.Margin = new Padding(6);
            OverlayLabelNWRadioButton.Name = "OverlayLabelNWRadioButton";
            OverlayLabelNWRadioButton.Size = new Size(21, 20);
            OverlayLabelNWRadioButton.TabIndex = 0;
            OverlayLabelNWRadioButton.TabStop = true;
            OverlayLabelNWRadioButton.UseVisualStyleBackColor = true;
            OverlayLabelNWRadioButton.CheckedChanged += OptionChanged_Handler;
            // 
            // OverlayLabelNRadioButton
            // 
            OverlayLabelNRadioButton.AutoSize = true;
            OverlayLabelNRadioButton.Location = new Point(42, 6);
            OverlayLabelNRadioButton.Margin = new Padding(6);
            OverlayLabelNRadioButton.Name = "OverlayLabelNRadioButton";
            OverlayLabelNRadioButton.Size = new Size(21, 20);
            OverlayLabelNRadioButton.TabIndex = 1;
            OverlayLabelNRadioButton.TabStop = true;
            OverlayLabelNRadioButton.UseVisualStyleBackColor = true;
            OverlayLabelNRadioButton.CheckedChanged += OptionChanged_Handler;
            // 
            // OverlayLabelNERadioButton
            // 
            OverlayLabelNERadioButton.AutoSize = true;
            OverlayLabelNERadioButton.Location = new Point(79, 6);
            OverlayLabelNERadioButton.Margin = new Padding(6);
            OverlayLabelNERadioButton.Name = "OverlayLabelNERadioButton";
            OverlayLabelNERadioButton.Size = new Size(21, 20);
            OverlayLabelNERadioButton.TabIndex = 2;
            OverlayLabelNERadioButton.TabStop = true;
            OverlayLabelNERadioButton.UseVisualStyleBackColor = true;
            OverlayLabelNERadioButton.CheckedChanged += OptionChanged_Handler;
            // 
            // OverlayLabelWRadioButton
            // 
            OverlayLabelWRadioButton.AutoSize = true;
            OverlayLabelWRadioButton.Location = new Point(6, 40);
            OverlayLabelWRadioButton.Margin = new Padding(6);
            OverlayLabelWRadioButton.Name = "OverlayLabelWRadioButton";
            OverlayLabelWRadioButton.Size = new Size(21, 20);
            OverlayLabelWRadioButton.TabIndex = 3;
            OverlayLabelWRadioButton.TabStop = true;
            OverlayLabelWRadioButton.UseVisualStyleBackColor = true;
            OverlayLabelWRadioButton.CheckedChanged += OptionChanged_Handler;
            // 
            // OverlayLabelSERadioButton
            // 
            OverlayLabelSERadioButton.AutoSize = true;
            OverlayLabelSERadioButton.Location = new Point(79, 74);
            OverlayLabelSERadioButton.Margin = new Padding(6);
            OverlayLabelSERadioButton.Name = "OverlayLabelSERadioButton";
            OverlayLabelSERadioButton.Size = new Size(21, 20);
            OverlayLabelSERadioButton.TabIndex = 8;
            OverlayLabelSERadioButton.TabStop = true;
            OverlayLabelSERadioButton.UseVisualStyleBackColor = true;
            OverlayLabelSERadioButton.CheckedChanged += OptionChanged_Handler;
            // 
            // OverlayLabelCRadioButton
            // 
            OverlayLabelCRadioButton.AutoSize = true;
            OverlayLabelCRadioButton.Location = new Point(42, 40);
            OverlayLabelCRadioButton.Margin = new Padding(6);
            OverlayLabelCRadioButton.Name = "OverlayLabelCRadioButton";
            OverlayLabelCRadioButton.Size = new Size(21, 20);
            OverlayLabelCRadioButton.TabIndex = 4;
            OverlayLabelCRadioButton.TabStop = true;
            OverlayLabelCRadioButton.UseVisualStyleBackColor = true;
            OverlayLabelCRadioButton.CheckedChanged += OptionChanged_Handler;
            // 
            // OverlayLabelSRadioButton
            // 
            OverlayLabelSRadioButton.AutoSize = true;
            OverlayLabelSRadioButton.Location = new Point(42, 74);
            OverlayLabelSRadioButton.Margin = new Padding(6);
            OverlayLabelSRadioButton.Name = "OverlayLabelSRadioButton";
            OverlayLabelSRadioButton.Size = new Size(21, 20);
            OverlayLabelSRadioButton.TabIndex = 7;
            OverlayLabelSRadioButton.TabStop = true;
            OverlayLabelSRadioButton.UseVisualStyleBackColor = true;
            OverlayLabelSRadioButton.CheckedChanged += OptionChanged_Handler;
            // 
            // OverlayLabelERadioButton
            // 
            OverlayLabelERadioButton.AutoSize = true;
            OverlayLabelERadioButton.Location = new Point(79, 40);
            OverlayLabelERadioButton.Margin = new Padding(6);
            OverlayLabelERadioButton.Name = "OverlayLabelERadioButton";
            OverlayLabelERadioButton.Size = new Size(21, 20);
            OverlayLabelERadioButton.TabIndex = 5;
            OverlayLabelERadioButton.TabStop = true;
            OverlayLabelERadioButton.UseVisualStyleBackColor = true;
            OverlayLabelERadioButton.CheckedChanged += OptionChanged_Handler;
            // 
            // OverlayLabelSWRadioButton
            // 
            OverlayLabelSWRadioButton.AutoSize = true;
            OverlayLabelSWRadioButton.Location = new Point(6, 74);
            OverlayLabelSWRadioButton.Margin = new Padding(6);
            OverlayLabelSWRadioButton.Name = "OverlayLabelSWRadioButton";
            OverlayLabelSWRadioButton.Size = new Size(21, 20);
            OverlayLabelSWRadioButton.TabIndex = 6;
            OverlayLabelSWRadioButton.TabStop = true;
            OverlayLabelSWRadioButton.UseVisualStyleBackColor = true;
            OverlayLabelSWRadioButton.CheckedChanged += OptionChanged_Handler;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 188);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 30;
            label1.Text = "标签大小";
            // 
            // HighlightColorLabel
            // 
            HighlightColorLabel.AutoSize = true;
            HighlightColorLabel.Location = new Point(9, 144);
            HighlightColorLabel.Margin = new Padding(6, 0, 6, 0);
            HighlightColorLabel.Name = "HighlightColorLabel";
            HighlightColorLabel.Size = new Size(56, 24);
            HighlightColorLabel.TabIndex = 29;
            HighlightColorLabel.Text = "Color";
            // 
            // ActiveClientHighlightColorButton
            // 
            ActiveClientHighlightColorButton.BorderStyle = BorderStyle.FixedSingle;
            ActiveClientHighlightColorButton.Location = new Point(77, 142);
            ActiveClientHighlightColorButton.Margin = new Padding(6);
            ActiveClientHighlightColorButton.Name = "ActiveClientHighlightColorButton";
            ActiveClientHighlightColorButton.Size = new Size(169, 30);
            ActiveClientHighlightColorButton.TabIndex = 28;
            ActiveClientHighlightColorButton.Click += ActiveClientHighlightColorButton_Click;
            // 
            // EnableActiveClientHighlightCheckBox
            // 
            EnableActiveClientHighlightCheckBox.AutoSize = true;
            EnableActiveClientHighlightCheckBox.Checked = true;
            EnableActiveClientHighlightCheckBox.CheckState = CheckState.Checked;
            EnableActiveClientHighlightCheckBox.Location = new Point(14, 102);
            EnableActiveClientHighlightCheckBox.Margin = new Padding(6);
            EnableActiveClientHighlightCheckBox.Name = "EnableActiveClientHighlightCheckBox";
            EnableActiveClientHighlightCheckBox.RightToLeft = RightToLeft.No;
            EnableActiveClientHighlightCheckBox.Size = new Size(198, 28);
            EnableActiveClientHighlightCheckBox.TabIndex = 27;
            EnableActiveClientHighlightCheckBox.Text = "高亮显示活动客户端";
            EnableActiveClientHighlightCheckBox.UseVisualStyleBackColor = true;
            EnableActiveClientHighlightCheckBox.CheckedChanged += OptionChanged_Handler;
            // 
            // ShowThumbnailOverlaysCheckBox
            // 
            ShowThumbnailOverlaysCheckBox.AutoSize = true;
            ShowThumbnailOverlaysCheckBox.Checked = true;
            ShowThumbnailOverlaysCheckBox.CheckState = CheckState.Checked;
            ShowThumbnailOverlaysCheckBox.Location = new Point(14, 12);
            ShowThumbnailOverlaysCheckBox.Margin = new Padding(6);
            ShowThumbnailOverlaysCheckBox.Name = "ShowThumbnailOverlaysCheckBox";
            ShowThumbnailOverlaysCheckBox.RightToLeft = RightToLeft.No;
            ShowThumbnailOverlaysCheckBox.Size = new Size(126, 28);
            ShowThumbnailOverlaysCheckBox.TabIndex = 25;
            ShowThumbnailOverlaysCheckBox.Text = "显示角色名";
            ShowThumbnailOverlaysCheckBox.UseVisualStyleBackColor = true;
            ShowThumbnailOverlaysCheckBox.CheckedChanged += OptionChanged_Handler;
            // 
            // ShowThumbnailFramesCheckBox
            // 
            ShowThumbnailFramesCheckBox.AutoSize = true;
            ShowThumbnailFramesCheckBox.Checked = true;
            ShowThumbnailFramesCheckBox.CheckState = CheckState.Checked;
            ShowThumbnailFramesCheckBox.Location = new Point(14, 58);
            ShowThumbnailFramesCheckBox.Margin = new Padding(6);
            ShowThumbnailFramesCheckBox.Name = "ShowThumbnailFramesCheckBox";
            ShowThumbnailFramesCheckBox.RightToLeft = RightToLeft.No;
            ShowThumbnailFramesCheckBox.Size = new Size(108, 28);
            ShowThumbnailFramesCheckBox.TabIndex = 26;
            ShowThumbnailFramesCheckBox.Text = "显示边框";
            ShowThumbnailFramesCheckBox.UseVisualStyleBackColor = true;
            ShowThumbnailFramesCheckBox.CheckedChanged += OptionChanged_Handler;
            // 
            // ClientsTabPage
            // 
            ClientsTabPage.BackColor = SystemColors.Control;
            ClientsTabPage.Controls.Add(ClientsPanel);
            ClientsTabPage.Location = new Point(124, 4);
            ClientsTabPage.Margin = new Padding(6);
            ClientsTabPage.Name = "ClientsTabPage";
            ClientsTabPage.Size = new Size(587, 394);
            ClientsTabPage.TabIndex = 4;
            ClientsTabPage.Text = "活动客户端";
            // 
            // ClientsPanel
            // 
            ClientsPanel.BorderStyle = BorderStyle.FixedSingle;
            ClientsPanel.Controls.Add(ThumbnailsList);
            ClientsPanel.Controls.Add(ThumbnailsListLabel);
            ClientsPanel.Dock = DockStyle.Fill;
            ClientsPanel.Location = new Point(0, 0);
            ClientsPanel.Margin = new Padding(6);
            ClientsPanel.Name = "ClientsPanel";
            ClientsPanel.Size = new Size(587, 394);
            ClientsPanel.TabIndex = 32;
            // 
            // ThumbnailsList
            // 
            ThumbnailsList.BackColor = SystemColors.Window;
            ThumbnailsList.BorderStyle = BorderStyle.FixedSingle;
            ThumbnailsList.CheckOnClick = true;
            ThumbnailsList.Dock = DockStyle.Bottom;
            ThumbnailsList.FormattingEnabled = true;
            ThumbnailsList.IntegralHeight = false;
            ThumbnailsList.Location = new Point(0, 62);
            ThumbnailsList.Margin = new Padding(6);
            ThumbnailsList.Name = "ThumbnailsList";
            ThumbnailsList.Size = new Size(585, 330);
            ThumbnailsList.TabIndex = 34;
            ThumbnailsList.ItemCheck += ThumbnailsList_ItemCheck_Handler;
            // 
            // ThumbnailsListLabel
            // 
            ThumbnailsListLabel.AutoSize = true;
            ThumbnailsListLabel.Location = new Point(14, 16);
            ThumbnailsListLabel.Margin = new Padding(6, 0, 6, 0);
            ThumbnailsListLabel.Name = "ThumbnailsListLabel";
            ThumbnailsListLabel.Size = new Size(207, 24);
            ThumbnailsListLabel.TabIndex = 33;
            ThumbnailsListLabel.Text = "缩略图 (勾选以强制隐藏)";
            // 
            // AboutTabPage
            // 
            AboutTabPage.BackColor = SystemColors.Control;
            AboutTabPage.Controls.Add(AboutPanel);
            AboutTabPage.Location = new Point(124, 4);
            AboutTabPage.Margin = new Padding(6);
            AboutTabPage.Name = "AboutTabPage";
            AboutTabPage.Size = new Size(587, 394);
            AboutTabPage.TabIndex = 5;
            AboutTabPage.Text = "关于";
            // 
            // AboutPanel
            // 
            AboutPanel.BackColor = Color.Transparent;
            AboutPanel.BorderStyle = BorderStyle.FixedSingle;
            AboutPanel.Controls.Add(CreditMaintLabel);
            AboutPanel.Controls.Add(DocumentationLinkLabel);
            AboutPanel.Controls.Add(DescriptionLabel);
            AboutPanel.Controls.Add(VersionLabel);
            AboutPanel.Controls.Add(NameLabel);
            AboutPanel.Controls.Add(DocumentationLink);
            AboutPanel.Dock = DockStyle.Fill;
            AboutPanel.Location = new Point(0, 0);
            AboutPanel.Margin = new Padding(6);
            AboutPanel.Name = "AboutPanel";
            AboutPanel.Size = new Size(587, 394);
            AboutPanel.TabIndex = 2;
            // 
            // CreditMaintLabel
            // 
            CreditMaintLabel.AutoSize = true;
            CreditMaintLabel.Location = new Point(-1, 242);
            CreditMaintLabel.Margin = new Padding(6, 0, 6, 0);
            CreditMaintLabel.Name = "CreditMaintLabel";
            CreditMaintLabel.Padding = new Padding(14, 6, 14, 6);
            CreditMaintLabel.Size = new Size(548, 36);
            CreditMaintLabel.TabIndex = 7;
            CreditMaintLabel.Text = "现作者: Proopai 翻译:混沌仲裁者CACX-刺怒/StabberORVexor";
            // 
            // DocumentationLinkLabel
            // 
            DocumentationLinkLabel.AutoSize = true;
            DocumentationLinkLabel.Location = new Point(-1, 278);
            DocumentationLinkLabel.Margin = new Padding(6, 0, 6, 0);
            DocumentationLinkLabel.Name = "DocumentationLinkLabel";
            DocumentationLinkLabel.Padding = new Padding(14, 6, 14, 6);
            DocumentationLinkLabel.Size = new Size(603, 36);
            DocumentationLinkLabel.TabIndex = 6;
            DocumentationLinkLabel.Text = "致谢前作者: Phrynohyas Tig-Rah 欲了解更多信息，请访问论坛主题：";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.BackColor = Color.Transparent;
            DescriptionLabel.Location = new Point(0, 33);
            DescriptionLabel.Margin = new Padding(6, 0, 6, 0);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Padding = new Padding(14, 6, 14, 6);
            DescriptionLabel.Size = new Size(478, 209);
            DescriptionLabel.TabIndex = 5;
            DescriptionLabel.Text = resources.GetString("DescriptionLabel.Text");
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            VersionLabel.Location = new Point(233, 4);
            VersionLabel.Margin = new Padding(6, 0, 6, 0);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(69, 29);
            VersionLabel.TabIndex = 4;
            VersionLabel.Text = "1.0.0";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameLabel.Location = new Point(6, 4);
            NameLabel.Margin = new Padding(6, 0, 6, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(195, 29);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "EVE-O-Preview";
            // 
            // DocumentationLink
            // 
            DocumentationLink.Location = new Point(6, 320);
            DocumentationLink.Margin = new Padding(55, 6, 6, 6);
            DocumentationLink.Name = "DocumentationLink";
            DocumentationLink.Padding = new Padding(14, 6, 14, 6);
            DocumentationLink.Size = new Size(481, 60);
            DocumentationLink.TabIndex = 2;
            DocumentationLink.TabStop = true;
            DocumentationLink.Text = "to be set from prresenter";
            DocumentationLink.LinkClicked += DocumentationLinkClicked_Handler;
            // 
            // NotifyIcon
            // 
            NotifyIcon.ContextMenuStrip = TrayMenu;
            NotifyIcon.Icon = (Icon)resources.GetObject("NotifyIcon.Icon");
            NotifyIcon.Text = "EVE-O-Preview";
            NotifyIcon.Visible = true;
            NotifyIcon.MouseDoubleClick += RestoreMainForm_Handler;
            // 
            // TrayMenu
            // 
            TrayMenu.ImageScalingSize = new Size(24, 24);
            TrayMenu.Items.AddRange(new ToolStripItem[] { TitleMenuItem, RestoreWindowMenuItem, SeparatorMenuItem, ExitMenuItem });
            TrayMenu.Name = "contextMenuStrip1";
            TrayMenu.Size = new Size(210, 100);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(715, 402);
            Controls.Add(ContentTabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(0);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "EVE-O-Preview";
            TopMost = true;
            FormClosing += MainFormClosing_Handler;
            Load += MainFormResize_Handler;
            Resize += MainFormResize_Handler;
            ContentTabControl.ResumeLayout(false);
            GeneralTabPage.ResumeLayout(false);
            GeneralSettingsPanel.ResumeLayout(false);
            GeneralSettingsPanel.PerformLayout();
            HotkeysTabPage.ResumeLayout(false);
            HotkeysTabPage.PerformLayout();
            ThumbnailTabPage.ResumeLayout(false);
            ThumbnailSettingsPanel.ResumeLayout(false);
            ThumbnailSettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ThumbnailSnapToGridSizeYNumericEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)ThumbnailSnapToGridSizeXNumericEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)ThumbnailsWidthNumericEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)ThumbnailsHeightNumericEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)ThumbnailOpacityTrackBar).EndInit();
            ZoomTabPage.ResumeLayout(false);
            ZoomSettingsPanel.ResumeLayout(false);
            ZoomSettingsPanel.PerformLayout();
            ZoomAnchorPanel.ResumeLayout(false);
            ZoomAnchorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ThumbnailZoomFactorNumericEdit).EndInit();
            OverlayTabPage.ResumeLayout(false);
            OverlaySettingsPanel.ResumeLayout(false);
            OverlaySettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OverlayLabelSizeNumericEdit).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ClientsTabPage.ResumeLayout(false);
            ClientsPanel.ResumeLayout(false);
            ClientsPanel.PerformLayout();
            AboutTabPage.ResumeLayout(false);
            AboutPanel.ResumeLayout(false);
            AboutPanel.PerformLayout();
            TrayMenu.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private NotifyIcon NotifyIcon;
		private ContextMenuStrip TrayMenu;
		private TabPage ZoomTabPage;
		private CheckBox EnableClientLayoutTrackingCheckBox;
		private CheckBox HideActiveClientThumbnailCheckBox;
		private CheckBox ShowThumbnailsAlwaysOnTopCheckBox;
		private CheckBox HideThumbnailsOnLostFocusCheckBox;
		private CheckBox EnablePerClientThumbnailsLayoutsCheckBox;
		private CheckBox MinimizeToTrayCheckBox;
		private NumericUpDown ThumbnailsWidthNumericEdit;
		private NumericUpDown ThumbnailsHeightNumericEdit;
		private TrackBar ThumbnailOpacityTrackBar;
		private Panel ZoomAnchorPanel;
		private RadioButton ZoomAanchorNWRadioButton;
		private RadioButton ZoomAanchorNRadioButton;
		private RadioButton ZoomAanchorNERadioButton;
		private RadioButton ZoomAanchorWRadioButton;
		private RadioButton ZoomAanchorSERadioButton;
		private RadioButton ZoomAanchorCRadioButton;
		private RadioButton ZoomAanchorSRadioButton;
		private RadioButton ZoomAanchorERadioButton;
		private RadioButton ZoomAanchorSWRadioButton;
		private CheckBox EnableThumbnailZoomCheckBox;
		private NumericUpDown ThumbnailZoomFactorNumericEdit;
		private Label HighlightColorLabel;
		private Panel ActiveClientHighlightColorButton;
		private CheckBox EnableActiveClientHighlightCheckBox;
		private CheckBox ShowThumbnailOverlaysCheckBox;
		private CheckBox ShowThumbnailFramesCheckBox;
		private CheckedListBox ThumbnailsList;
		private LinkLabel DocumentationLink;
		private Label VersionLabel;
		private CheckBox MinimizeInactiveClientsCheckBox;
		private CheckBox LockThumbnailLocationCheckbox;
		private NumericUpDown ThumbnailSnapToGridSizeYNumericEdit;
		private Label SnapYLabel;
		private NumericUpDown ThumbnailSnapToGridSizeXNumericEdit;
		private Label SnapXLabel;
		private CheckBox ThumbnailSnapToGridCheckBox;
		private Label label3;
		private Label label2;
		private Panel OverlayLabelColorButton;
		private NumericUpDown OverlayLabelSizeNumericEdit;
		private Panel panel1;
		private RadioButton OverlayLabelNWRadioButton;
		private RadioButton OverlayLabelNRadioButton;
		private RadioButton OverlayLabelNERadioButton;
		private RadioButton OverlayLabelWRadioButton;
		private RadioButton OverlayLabelSERadioButton;
		private RadioButton OverlayLabelCRadioButton;
		private RadioButton OverlayLabelSRadioButton;
		private RadioButton OverlayLabelERadioButton;
		private RadioButton OverlayLabelSWRadioButton;
		private Label label1;
		private TabPage HotkeysTabPage;
		private ComboBox CycleGroupSelectorComboBox;
		private Label HotkeysForwardLabel;
		private ListBox HotkeysForwardListBox;
		private Button HotkeysForwardAddButton;
		private Button HotkeysForwardRemoveButton;
		private Label HotkeysBackwardLabel;
		private ListBox HotkeysBackwardListBox;
		private Button HotkeysBackwardAddButton;
		private Button HotkeysBackwardRemoveButton;
		private TextBox HotkeyCaptureTextBox;
		private CheckedListBox HotkeysClientsList;
		private Button HotkeysClientUpButton;
		private Button HotkeysClientDownButton;
		private ComboBox AnimationStyleCombo;
		private Button HotkeyCaptureButton;
        private TextBox HotkeyReadmeTextBox;
        private Button HotkeySaveButton;
    }
}