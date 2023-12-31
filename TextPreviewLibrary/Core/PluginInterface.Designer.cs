﻿using System.Drawing;
using System.Windows.Forms;

namespace TextPreviewLibrary.Core;

partial class PluginInterface
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
        Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginInterface));
        sPanel1 = new Sipaa.Framework.SPanel();
        pnlTabs = new Panel();
        bntMenu = new Guna.UI2.WinForms.Guna2Button();
        lblVersion = new Label();
        guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
        bntDesign = new Guna.UI2.WinForms.Guna2Button();
        mainTextBox = new RichTextBox();
        sPanel2 = new Sipaa.Framework.SPanel();
        lblWordCounts = new Label();
        lblErrors = new Label();
        lblLanguage = new Label();
        pnlMenu = new Sipaa.Framework.SPanel();
        guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
        lblBottom = new Label();
        pnlDesing = new Sipaa.Framework.SPanel();
        dynamikPermissionView1 = new LILO_Packager.v2.Controls.DynamikPermissionView();
        guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
        label1 = new Label();
        panel3 = new Panel();
        panel2 = new Panel();
        panel1 = new Panel();
        guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
        sPanel3 = new Sipaa.Framework.SPanel();
        Transition = new Guna.UI2.WinForms.Guna2Transition();
        sPanel1.SuspendLayout();
        sPanel2.SuspendLayout();
        pnlMenu.SuspendLayout();
        guna2Panel3.SuspendLayout();
        pnlDesing.SuspendLayout();
        sPanel3.SuspendLayout();
        SuspendLayout();
        // 
        // sPanel1
        // 
        sPanel1.BackColor = Color.White;
        sPanel1.BackgroundImageLayout = ImageLayout.Stretch;
        sPanel1.BorderColor = Color.Black;
        sPanel1.BorderRadius = 0;
        sPanel1.BorderSize = 0;
        sPanel1.Controls.Add(pnlTabs);
        sPanel1.Controls.Add(bntMenu);
        Transition.SetDecoration(sPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
        sPanel1.Dock = DockStyle.Top;
        sPanel1.ForeColor = Color.White;
        sPanel1.Location = new Point(0, 0);
        sPanel1.Margin = new Padding(4);
        sPanel1.Name = "sPanel1";
        sPanel1.Size = new Size(1356, 88);
        sPanel1.TabIndex = 12;
        // 
        // pnlTabs
        // 
        pnlTabs.AutoScroll = true;
        Transition.SetDecoration(pnlTabs, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlTabs.Location = new Point(104, 16);
        pnlTabs.Name = "pnlTabs";
        pnlTabs.Size = new Size(1232, 56);
        pnlTabs.TabIndex = 17;
        // 
        // bntMenu
        // 
        bntMenu.Animated = true;
        bntMenu.BackColor = Color.Transparent;
        bntMenu.BackgroundImageLayout = ImageLayout.Zoom;
        bntMenu.BorderColor = Color.Gainsboro;
        bntMenu.BorderRadius = 10;
        bntMenu.CheckedState.Image = Properties.Resources.icons8_close_96;
        Transition.SetDecoration(bntMenu, Guna.UI2.AnimatorNS.DecorationType.None);
        bntMenu.DisabledState.BorderColor = Color.DarkGray;
        bntMenu.DisabledState.CustomBorderColor = Color.DarkGray;
        bntMenu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntMenu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntMenu.FillColor = Color.Transparent;
        bntMenu.FocusedColor = Color.FromArgb(100, 170, 209);
        bntMenu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        bntMenu.ForeColor = Color.White;
        bntMenu.Image = Properties.Resources.icons8_menu_240;
        bntMenu.ImageSize = new Size(35, 35);
        bntMenu.Location = new Point(16, 16);
        bntMenu.Margin = new Padding(2);
        bntMenu.Name = "bntMenu";
        bntMenu.Size = new Size(64, 58);
        bntMenu.TabIndex = 16;
        bntMenu.Click += bntPlugin_Click;
        // 
        // lblVersion
        // 
        lblVersion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblVersion.BackColor = Color.Transparent;
        Transition.SetDecoration(lblVersion, Guna.UI2.AnimatorNS.DecorationType.None);
        lblVersion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblVersion.ForeColor = Color.DimGray;
        lblVersion.Location = new Point(16, 8);
        lblVersion.Margin = new Padding(4, 0, 4, 0);
        lblVersion.Name = "lblVersion";
        lblVersion.Size = new Size(248, 32);
        lblVersion.TabIndex = 1;
        lblVersion.Text = "n/a";
        lblVersion.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // guna2Button7
        // 
        guna2Button7.Animated = true;
        guna2Button7.BackColor = Color.Transparent;
        guna2Button7.BackgroundImageLayout = ImageLayout.Zoom;
        guna2Button7.BorderColor = Color.Gainsboro;
        guna2Button7.BorderRadius = 10;
        Transition.SetDecoration(guna2Button7, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button7.DisabledState.BorderColor = Color.DarkGray;
        guna2Button7.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button7.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button7.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button7.FillColor = Color.Transparent;
        guna2Button7.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        guna2Button7.ForeColor = Color.Black;
        guna2Button7.Image = Properties.Resources.icons8_foxit_reader_240;
        guna2Button7.ImageAlign = HorizontalAlignment.Left;
        guna2Button7.ImageSize = new Size(35, 35);
        guna2Button7.Location = new Point(24, 472);
        guna2Button7.Margin = new Padding(2);
        guna2Button7.Name = "guna2Button7";
        guna2Button7.Size = new Size(288, 58);
        guna2Button7.TabIndex = 16;
        guna2Button7.Text = "Formatting";
        guna2Button7.TextAlign = HorizontalAlignment.Left;
        guna2Button7.Click += bntFormating;
        // 
        // bntDesign
        // 
        bntDesign.Animated = true;
        bntDesign.BackColor = Color.Transparent;
        bntDesign.BackgroundImageLayout = ImageLayout.Zoom;
        bntDesign.BorderColor = Color.Gainsboro;
        bntDesign.BorderRadius = 10;
        Transition.SetDecoration(bntDesign, Guna.UI2.AnimatorNS.DecorationType.None);
        bntDesign.DisabledState.BorderColor = Color.DarkGray;
        bntDesign.DisabledState.CustomBorderColor = Color.DarkGray;
        bntDesign.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntDesign.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntDesign.FillColor = Color.Transparent;
        bntDesign.FocusedColor = Color.FromArgb(100, 170, 209);
        bntDesign.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        bntDesign.ForeColor = Color.Black;
        bntDesign.Image = Properties.Resources.icons8_windows_10_personalization_96;
        bntDesign.ImageAlign = HorizontalAlignment.Left;
        bntDesign.ImageSize = new Size(35, 35);
        bntDesign.Location = new Point(24, 392);
        bntDesign.Margin = new Padding(2);
        bntDesign.Name = "bntDesign";
        bntDesign.Size = new Size(280, 58);
        bntDesign.TabIndex = 16;
        bntDesign.Text = "Design";
        bntDesign.TextAlign = HorizontalAlignment.Left;
        bntDesign.Click += bntOpenDesingPop_Click;
        // 
        // mainTextBox
        // 
        mainTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        mainTextBox.BorderStyle = BorderStyle.None;
        Transition.SetDecoration(mainTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
        mainTextBox.Location = new Point(40, 32);
        mainTextBox.Margin = new Padding(2);
        mainTextBox.Name = "mainTextBox";
        mainTextBox.Size = new Size(1216, 808);
        mainTextBox.TabIndex = 13;
        mainTextBox.Text = "";
        // 
        // sPanel2
        // 
        sPanel2.BackColor = Color.White;
        sPanel2.BackgroundImageLayout = ImageLayout.Stretch;
        sPanel2.BorderColor = Color.Black;
        sPanel2.BorderRadius = 0;
        sPanel2.BorderSize = 0;
        sPanel2.Controls.Add(lblWordCounts);
        sPanel2.Controls.Add(lblErrors);
        sPanel2.Controls.Add(lblLanguage);
        Transition.SetDecoration(sPanel2, Guna.UI2.AnimatorNS.DecorationType.None);
        sPanel2.Dock = DockStyle.Bottom;
        sPanel2.ForeColor = Color.White;
        sPanel2.Location = new Point(0, 1017);
        sPanel2.Margin = new Padding(4);
        sPanel2.Name = "sPanel2";
        sPanel2.Size = new Size(1356, 38);
        sPanel2.TabIndex = 14;
        // 
        // lblWordCounts
        // 
        lblWordCounts.BackColor = Color.Transparent;
        Transition.SetDecoration(lblWordCounts, Guna.UI2.AnimatorNS.DecorationType.None);
        lblWordCounts.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblWordCounts.ForeColor = Color.Black;
        lblWordCounts.Location = new Point(208, 8);
        lblWordCounts.Margin = new Padding(4, 0, 4, 0);
        lblWordCounts.Name = "lblWordCounts";
        lblWordCounts.Size = new Size(368, 24);
        lblWordCounts.TabIndex = 1;
        lblWordCounts.Text = "n/a";
        lblWordCounts.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblErrors
        // 
        lblErrors.BackColor = Color.Transparent;
        Transition.SetDecoration(lblErrors, Guna.UI2.AnimatorNS.DecorationType.None);
        lblErrors.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblErrors.ForeColor = Color.Black;
        lblErrors.Location = new Point(584, 8);
        lblErrors.Margin = new Padding(4, 0, 4, 0);
        lblErrors.Name = "lblErrors";
        lblErrors.Size = new Size(120, 24);
        lblErrors.TabIndex = 1;
        lblErrors.Text = "n/a";
        lblErrors.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblLanguage
        // 
        lblLanguage.BackColor = Color.Transparent;
        Transition.SetDecoration(lblLanguage, Guna.UI2.AnimatorNS.DecorationType.None);
        lblLanguage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblLanguage.ForeColor = Color.Black;
        lblLanguage.Location = new Point(8, 8);
        lblLanguage.Margin = new Padding(4, 0, 4, 0);
        lblLanguage.Name = "lblLanguage";
        lblLanguage.Size = new Size(192, 24);
        lblLanguage.TabIndex = 1;
        lblLanguage.Text = "n/a";
        lblLanguage.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // pnlMenu
        // 
        pnlMenu.BackColor = Color.White;
        pnlMenu.BackgroundImageLayout = ImageLayout.Stretch;
        pnlMenu.BorderColor = Color.Gainsboro;
        pnlMenu.BorderRadius = 15;
        pnlMenu.BorderSize = 1;
        pnlMenu.Controls.Add(guna2Panel3);
        pnlMenu.Controls.Add(pnlDesing);
        pnlMenu.Controls.Add(panel2);
        pnlMenu.Controls.Add(panel1);
        pnlMenu.Controls.Add(guna2Button7);
        pnlMenu.Controls.Add(guna2Button3);
        pnlMenu.Controls.Add(guna2Button5);
        pnlMenu.Controls.Add(bntDesign);
        pnlMenu.Controls.Add(guna2Button2);
        pnlMenu.Controls.Add(guna2Button1);
        Transition.SetDecoration(pnlMenu, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlMenu.ForeColor = Color.White;
        pnlMenu.Location = new Point(16, 104);
        pnlMenu.Margin = new Padding(4);
        pnlMenu.Name = "pnlMenu";
        pnlMenu.Size = new Size(328, 696);
        pnlMenu.TabIndex = 15;
        pnlMenu.Visible = false;
        // 
        // guna2Panel3
        // 
        guna2Panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        guna2Panel3.BackColor = Color.Transparent;
        guna2Panel3.BorderColor = Color.Gainsboro;
        guna2Panel3.BorderRadius = 15;
        guna2Panel3.BorderThickness = 2;
        guna2Panel3.Controls.Add(lblVersion);
        guna2Panel3.Controls.Add(lblBottom);
        Transition.SetDecoration(guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Panel3.FillColor = Color.White;
        guna2Panel3.Location = new Point(24, 592);
        guna2Panel3.Margin = new Padding(2);
        guna2Panel3.Name = "guna2Panel3";
        guna2Panel3.Size = new Size(280, 80);
        guna2Panel3.TabIndex = 39;
        // 
        // lblBottom
        // 
        lblBottom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblBottom.BackColor = Color.Transparent;
        Transition.SetDecoration(lblBottom, Guna.UI2.AnimatorNS.DecorationType.None);
        lblBottom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblBottom.ForeColor = Color.DarkGray;
        lblBottom.Location = new Point(16, 8);
        lblBottom.Margin = new Padding(4, 0, 4, 0);
        lblBottom.Name = "lblBottom";
        lblBottom.Size = new Size(256, 64);
        lblBottom.TabIndex = 1;
        lblBottom.Text = "\r\nJW Limited © 2023";
        lblBottom.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // pnlDesing
        // 
        pnlDesing.AutoScroll = true;
        pnlDesing.BackColor = Color.White;
        pnlDesing.BackgroundImageLayout = ImageLayout.Stretch;
        pnlDesing.BorderColor = Color.Gainsboro;
        pnlDesing.BorderRadius = 15;
        pnlDesing.BorderSize = 1;
        pnlDesing.Controls.Add(dynamikPermissionView1);
        pnlDesing.Controls.Add(guna2Button4);
        pnlDesing.Controls.Add(label1);
        pnlDesing.Controls.Add(panel3);
        Transition.SetDecoration(pnlDesing, Guna.UI2.AnimatorNS.DecorationType.BottomMirror);
        pnlDesing.ForeColor = Color.White;
        pnlDesing.Location = new Point(0, 0);
        pnlDesing.Margin = new Padding(4);
        pnlDesing.Name = "pnlDesing";
        pnlDesing.Size = new Size(328, 568);
        pnlDesing.TabIndex = 15;
        pnlDesing.Visible = false;
        // 
        // dynamikPermissionView1
        // 
        Transition.SetDecoration(dynamikPermissionView1, Guna.UI2.AnimatorNS.DecorationType.None);
        dynamikPermissionView1.Location = new Point(24, 136);
        dynamikPermissionView1.Name = "dynamikPermissionView1";
        dynamikPermissionView1.PermissionDescription = "Manager";
        dynamikPermissionView1.PermissionName = "Color";
        dynamikPermissionView1.Size = new Size(280, 96);
        dynamikPermissionView1.TabIndex = 39;
        // 
        // guna2Button4
        // 
        guna2Button4.Animated = true;
        guna2Button4.BackColor = Color.Transparent;
        guna2Button4.BackgroundImageLayout = ImageLayout.Zoom;
        guna2Button4.BorderColor = Color.Gainsboro;
        guna2Button4.BorderRadius = 10;
        Transition.SetDecoration(guna2Button4, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button4.DisabledState.BorderColor = Color.DarkGray;
        guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button4.FillColor = Color.Transparent;
        guna2Button4.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        guna2Button4.ForeColor = Color.White;
        guna2Button4.Image = Properties.Resources.icons8_close_96;
        guna2Button4.ImageSize = new Size(35, 35);
        guna2Button4.Location = new Point(24, 24);
        guna2Button4.Margin = new Padding(2);
        guna2Button4.Name = "guna2Button4";
        guna2Button4.Size = new Size(64, 58);
        guna2Button4.TabIndex = 16;
        guna2Button4.Click += bntCloseDesign;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        label1.BackColor = Color.Transparent;
        Transition.SetDecoration(label1, Guna.UI2.AnimatorNS.DecorationType.None);
        label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
        label1.ForeColor = Color.DimGray;
        label1.Location = new Point(96, 24);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(208, 56);
        label1.TabIndex = 1;
        label1.Text = "Design";
        label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // panel3
        // 
        panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
        panel3.BackgroundImageLayout = ImageLayout.Stretch;
        Transition.SetDecoration(panel3, Guna.UI2.AnimatorNS.DecorationType.None);
        panel3.Location = new Point(24, 96);
        panel3.Margin = new Padding(2);
        panel3.Name = "panel3";
        panel3.Size = new Size(280, 16);
        panel3.TabIndex = 38;
        // 
        // panel2
        // 
        panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
        panel2.BackgroundImageLayout = ImageLayout.Stretch;
        Transition.SetDecoration(panel2, Guna.UI2.AnimatorNS.DecorationType.None);
        panel2.Location = new Point(24, 360);
        panel2.Margin = new Padding(2);
        panel2.Name = "panel2";
        panel2.Size = new Size(280, 16);
        panel2.TabIndex = 38;
        // 
        // panel1
        // 
        panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
        panel1.BackgroundImageLayout = ImageLayout.Stretch;
        Transition.SetDecoration(panel1, Guna.UI2.AnimatorNS.DecorationType.None);
        panel1.Location = new Point(24, 176);
        panel1.Margin = new Padding(2);
        panel1.Name = "panel1";
        panel1.Size = new Size(280, 16);
        panel1.TabIndex = 38;
        // 
        // guna2Button3
        // 
        guna2Button3.Animated = true;
        guna2Button3.BackColor = Color.Transparent;
        guna2Button3.BackgroundImageLayout = ImageLayout.Zoom;
        guna2Button3.BorderColor = Color.Gainsboro;
        guna2Button3.BorderRadius = 10;
        Transition.SetDecoration(guna2Button3, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button3.DisabledState.BorderColor = Color.DarkGray;
        guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button3.FillColor = Color.Transparent;
        guna2Button3.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        guna2Button3.ForeColor = Color.Black;
        guna2Button3.Image = Properties.Resources.icons8_document_240;
        guna2Button3.ImageAlign = HorizontalAlignment.Left;
        guna2Button3.ImageSize = new Size(35, 35);
        guna2Button3.Location = new Point(24, 30);
        guna2Button3.Margin = new Padding(2);
        guna2Button3.Name = "guna2Button3";
        guna2Button3.Size = new Size(280, 58);
        guna2Button3.TabIndex = 16;
        guna2Button3.Text = "Neu";
        guna2Button3.TextAlign = HorizontalAlignment.Left;
        guna2Button3.Click += newFile_Click;
        // 
        // guna2Button5
        // 
        guna2Button5.Animated = true;
        guna2Button5.BackColor = Color.Transparent;
        guna2Button5.BackgroundImageLayout = ImageLayout.Zoom;
        guna2Button5.BorderColor = Color.Gainsboro;
        guna2Button5.BorderRadius = 10;
        Transition.SetDecoration(guna2Button5, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button5.DisabledState.BorderColor = Color.DarkGray;
        guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button5.FillColor = Color.Transparent;
        guna2Button5.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        guna2Button5.ForeColor = Color.Black;
        guna2Button5.Image = Properties.Resources.icons8_folder_240;
        guna2Button5.ImageAlign = HorizontalAlignment.Left;
        guna2Button5.ImageSize = new Size(35, 35);
        guna2Button5.Location = new Point(24, 104);
        guna2Button5.Margin = new Padding(2);
        guna2Button5.Name = "guna2Button5";
        guna2Button5.Size = new Size(280, 58);
        guna2Button5.TabIndex = 16;
        guna2Button5.Text = "Öffnen";
        guna2Button5.TextAlign = HorizontalAlignment.Left;
        guna2Button5.Click += guna2Button5_Click;
        // 
        // guna2Button2
        // 
        guna2Button2.Animated = true;
        guna2Button2.BackColor = Color.Transparent;
        guna2Button2.BackgroundImageLayout = ImageLayout.Zoom;
        guna2Button2.BorderColor = Color.Gainsboro;
        guna2Button2.BorderRadius = 10;
        Transition.SetDecoration(guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button2.DisabledState.BorderColor = Color.DarkGray;
        guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button2.FillColor = Color.Transparent;
        guna2Button2.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        guna2Button2.ForeColor = Color.Black;
        guna2Button2.Image = Properties.Resources.icons8_save_all_96;
        guna2Button2.ImageAlign = HorizontalAlignment.Left;
        guna2Button2.ImageSize = new Size(35, 35);
        guna2Button2.Location = new Point(24, 288);
        guna2Button2.Margin = new Padding(2);
        guna2Button2.Name = "guna2Button2";
        guna2Button2.Size = new Size(280, 58);
        guna2Button2.TabIndex = 16;
        guna2Button2.Text = "  Alles speichern";
        guna2Button2.TextAlign = HorizontalAlignment.Left;
        // 
        // guna2Button1
        // 
        guna2Button1.Animated = true;
        guna2Button1.BackColor = Color.Transparent;
        guna2Button1.BackgroundImageLayout = ImageLayout.Zoom;
        guna2Button1.BorderColor = Color.Gainsboro;
        guna2Button1.BorderRadius = 10;
        Transition.SetDecoration(guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button1.DisabledState.BorderColor = Color.DarkGray;
        guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button1.FillColor = Color.Transparent;
        guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        guna2Button1.ForeColor = Color.Black;
        guna2Button1.Image = Properties.Resources.icons8_save_96;
        guna2Button1.ImageAlign = HorizontalAlignment.Left;
        guna2Button1.ImageSize = new Size(35, 35);
        guna2Button1.Location = new Point(24, 208);
        guna2Button1.Margin = new Padding(2);
        guna2Button1.Name = "guna2Button1";
        guna2Button1.Size = new Size(280, 58);
        guna2Button1.TabIndex = 16;
        guna2Button1.Text = "  Speichern";
        guna2Button1.TextAlign = HorizontalAlignment.Left;
        guna2Button1.Click += guna2Button1_Click_1;
        // 
        // sPanel3
        // 
        sPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        sPanel3.BackColor = Color.White;
        sPanel3.BackgroundImageLayout = ImageLayout.Stretch;
        sPanel3.BorderColor = Color.Gainsboro;
        sPanel3.BorderRadius = 20;
        sPanel3.BorderSize = 2;
        sPanel3.Controls.Add(mainTextBox);
        Transition.SetDecoration(sPanel3, Guna.UI2.AnimatorNS.DecorationType.None);
        sPanel3.ForeColor = Color.White;
        sPanel3.Location = new Point(32, 120);
        sPanel3.Margin = new Padding(4);
        sPanel3.Name = "sPanel3";
        sPanel3.Size = new Size(1294, 872);
        sPanel3.TabIndex = 15;
        // 
        // Transition
        // 
        Transition.Cursor = null;
        animation1.AnimateOnlyDifferences = true;
        animation1.LeafCoeff = 0F;
        animation1.MaxTime = 1F;
        animation1.MinTime = 0F;
        animation1.MosaicSize = 0;
        animation1.Padding = new Padding(0);
        animation1.RotateCoeff = 0F;
        animation1.RotateLimit = 0F;
        animation1.TimeCoeff = 0F;
        animation1.TransparencyCoeff = 0F;
        Transition.DefaultAnimation = animation1;
        Transition.Interval = 1;
        // 
        // PluginInterface
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(1356, 1055);
        Controls.Add(pnlMenu);
        Controls.Add(sPanel3);
        Controls.Add(sPanel2);
        Controls.Add(sPanel1);
        Transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
        Margin = new Padding(2);
        MinimumSize = new Size(300, 496);
        Name = "PluginInterface";
        ShowIcon = false;
        ShowInTaskbar = false;
        Text = "TextPreview";
        Load += ui_Load;
        Shown += PluginInterface_Shown;
        sPanel1.ResumeLayout(false);
        sPanel2.ResumeLayout(false);
        pnlMenu.ResumeLayout(false);
        guna2Panel3.ResumeLayout(false);
        pnlDesing.ResumeLayout(false);
        sPanel3.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Sipaa.Framework.SPanel sPanel1;
    private Label lblVersion;
    private Guna.UI2.WinForms.Guna2Button bntMenu;
    private Sipaa.Framework.SPanel sPanel2;
    private Label lblLanguage;
    private Label lblWordCounts;
    private Label lblErrors;
    private Sipaa.Framework.SPanel pnlMenu;
    private Guna.UI2.WinForms.Guna2Button guna2Button1;
    private Guna.UI2.WinForms.Guna2Button guna2Button2;
    private Sipaa.Framework.SPanel sPanel3;
    private Guna.UI2.WinForms.Guna2Button guna2Button5;
    private Guna.UI2.WinForms.Guna2Button guna2Button3;
    private Guna.UI2.WinForms.Guna2Button guna2Button7;
    private Guna.UI2.WinForms.Guna2Button bntDesign;
    private Sipaa.Framework.SPanel pnlDesing;
    private Panel panel1;
    private Panel panel2;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
    private Label lblBottom;
    public Guna.UI2.WinForms.Guna2Transition Transition;
    private Guna.UI2.WinForms.Guna2Button guna2Button4;
    private Label label1;
    private Panel panel3;
    private Panel pnlTabs;
    public RichTextBox mainTextBox;
    private LILO_Packager.v2.Controls.DynamikPermissionView dynamikPermissionView1;
}