
using System.Collections.Generic;
using System.Windows.Forms;

namespace SudokuWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Block1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RTB1 = new System.Windows.Forms.RichTextBox();
            this.RTB2 = new System.Windows.Forms.RichTextBox();
            this.RTB3 = new System.Windows.Forms.RichTextBox();
            this.RTB10 = new System.Windows.Forms.RichTextBox();
            this.RTB11 = new System.Windows.Forms.RichTextBox();
            this.RTB12 = new System.Windows.Forms.RichTextBox();
            this.RTB19 = new System.Windows.Forms.RichTextBox();
            this.RTB20 = new System.Windows.Forms.RichTextBox();
            this.RTB21 = new System.Windows.Forms.RichTextBox();
            this.MainFieldBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.Block2 = new System.Windows.Forms.FlowLayoutPanel();
            this.RTB4 = new System.Windows.Forms.RichTextBox();
            this.RTB5 = new System.Windows.Forms.RichTextBox();
            this.RTB6 = new System.Windows.Forms.RichTextBox();
            this.RTB13 = new System.Windows.Forms.RichTextBox();
            this.RTB14 = new System.Windows.Forms.RichTextBox();
            this.RTB15 = new System.Windows.Forms.RichTextBox();
            this.RTB22 = new System.Windows.Forms.RichTextBox();
            this.RTB23 = new System.Windows.Forms.RichTextBox();
            this.RTB24 = new System.Windows.Forms.RichTextBox();
            this.Block3 = new System.Windows.Forms.FlowLayoutPanel();
            this.RTB7 = new System.Windows.Forms.RichTextBox();
            this.RTB8 = new System.Windows.Forms.RichTextBox();
            this.RTB9 = new System.Windows.Forms.RichTextBox();
            this.RTB16 = new System.Windows.Forms.RichTextBox();
            this.RTB17 = new System.Windows.Forms.RichTextBox();
            this.RTB18 = new System.Windows.Forms.RichTextBox();
            this.RTB25 = new System.Windows.Forms.RichTextBox();
            this.RTB26 = new System.Windows.Forms.RichTextBox();
            this.RTB27 = new System.Windows.Forms.RichTextBox();
            this.Block4 = new System.Windows.Forms.FlowLayoutPanel();
            this.RTB28 = new System.Windows.Forms.RichTextBox();
            this.RTB29 = new System.Windows.Forms.RichTextBox();
            this.RTB30 = new System.Windows.Forms.RichTextBox();
            this.RTB37 = new System.Windows.Forms.RichTextBox();
            this.RTB38 = new System.Windows.Forms.RichTextBox();
            this.RTB39 = new System.Windows.Forms.RichTextBox();
            this.RTB46 = new System.Windows.Forms.RichTextBox();
            this.RTB47 = new System.Windows.Forms.RichTextBox();
            this.RTB48 = new System.Windows.Forms.RichTextBox();
            this.Block5 = new System.Windows.Forms.FlowLayoutPanel();
            this.RTB31 = new System.Windows.Forms.RichTextBox();
            this.RTB32 = new System.Windows.Forms.RichTextBox();
            this.RTB33 = new System.Windows.Forms.RichTextBox();
            this.RTB40 = new System.Windows.Forms.RichTextBox();
            this.RTB41 = new System.Windows.Forms.RichTextBox();
            this.RTB42 = new System.Windows.Forms.RichTextBox();
            this.RTB49 = new System.Windows.Forms.RichTextBox();
            this.RTB50 = new System.Windows.Forms.RichTextBox();
            this.RTB51 = new System.Windows.Forms.RichTextBox();
            this.Block6 = new System.Windows.Forms.FlowLayoutPanel();
            this.RTB34 = new System.Windows.Forms.RichTextBox();
            this.RTB35 = new System.Windows.Forms.RichTextBox();
            this.RTB36 = new System.Windows.Forms.RichTextBox();
            this.RTB43 = new System.Windows.Forms.RichTextBox();
            this.RTB44 = new System.Windows.Forms.RichTextBox();
            this.RTB45 = new System.Windows.Forms.RichTextBox();
            this.RTB52 = new System.Windows.Forms.RichTextBox();
            this.RTB53 = new System.Windows.Forms.RichTextBox();
            this.RTB54 = new System.Windows.Forms.RichTextBox();
            this.Block7 = new System.Windows.Forms.FlowLayoutPanel();
            this.RTB55 = new System.Windows.Forms.RichTextBox();
            this.RTB56 = new System.Windows.Forms.RichTextBox();
            this.RTB57 = new System.Windows.Forms.RichTextBox();
            this.RTB64 = new System.Windows.Forms.RichTextBox();
            this.RTB65 = new System.Windows.Forms.RichTextBox();
            this.RTB66 = new System.Windows.Forms.RichTextBox();
            this.RTB73 = new System.Windows.Forms.RichTextBox();
            this.RTB74 = new System.Windows.Forms.RichTextBox();
            this.RTB75 = new System.Windows.Forms.RichTextBox();
            this.Block8 = new System.Windows.Forms.FlowLayoutPanel();
            this.RTB58 = new System.Windows.Forms.RichTextBox();
            this.RTB59 = new System.Windows.Forms.RichTextBox();
            this.RTB60 = new System.Windows.Forms.RichTextBox();
            this.RTB67 = new System.Windows.Forms.RichTextBox();
            this.RTB68 = new System.Windows.Forms.RichTextBox();
            this.RTB69 = new System.Windows.Forms.RichTextBox();
            this.RTB76 = new System.Windows.Forms.RichTextBox();
            this.RTB77 = new System.Windows.Forms.RichTextBox();
            this.RTB78 = new System.Windows.Forms.RichTextBox();
            this.Block9 = new System.Windows.Forms.FlowLayoutPanel();
            this.RTB61 = new System.Windows.Forms.RichTextBox();
            this.RTB62 = new System.Windows.Forms.RichTextBox();
            this.RTB63 = new System.Windows.Forms.RichTextBox();
            this.RTB70 = new System.Windows.Forms.RichTextBox();
            this.RTB71 = new System.Windows.Forms.RichTextBox();
            this.RTB72 = new System.Windows.Forms.RichTextBox();
            this.RTB79 = new System.Windows.Forms.RichTextBox();
            this.RTB80 = new System.Windows.Forms.RichTextBox();
            this.RTB81 = new System.Windows.Forms.RichTextBox();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.Block1.SuspendLayout();
            this.MainFieldBlock.SuspendLayout();
            this.Block2.SuspendLayout();
            this.Block3.SuspendLayout();
            this.Block4.SuspendLayout();
            this.Block5.SuspendLayout();
            this.Block6.SuspendLayout();
            this.Block7.SuspendLayout();
            this.Block8.SuspendLayout();
            this.Block9.SuspendLayout();
            this.SuspendLayout();
            // 
            // Block1
            // 
            this.Block1.Controls.Add(this.RTB1);
            this.Block1.Controls.Add(this.RTB2);
            this.Block1.Controls.Add(this.RTB3);
            this.Block1.Controls.Add(this.RTB10);
            this.Block1.Controls.Add(this.RTB11);
            this.Block1.Controls.Add(this.RTB12);
            this.Block1.Controls.Add(this.RTB19);
            this.Block1.Controls.Add(this.RTB20);
            this.Block1.Controls.Add(this.RTB21);
            this.Block1.Location = new System.Drawing.Point(3, 3);
            this.Block1.Name = "Block1";
            this.Block1.Size = new System.Drawing.Size(130, 130);
            this.Block1.TabIndex = 1;
            this.Block1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel5_Paint);
            // 
            // RTB1
            // 
            this.RTB1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB1.HideSelection = false;
            this.RTB1.Location = new System.Drawing.Point(3, 3);
            this.RTB1.MaxLength = 1;
            this.RTB1.Name = "RTB1";
            this.RTB1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB1.ShortcutsEnabled = false;
            this.RTB1.Size = new System.Drawing.Size(37, 37);
            this.RTB1.TabIndex = 0;
            this.RTB1.Text = "0";
            this.RTB1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // RTB2
            // 
            this.RTB2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB2.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB2.HideSelection = false;
            this.RTB2.Location = new System.Drawing.Point(46, 3);
            this.RTB2.MaxLength = 1;
            this.RTB2.Name = "RTB2";
            this.RTB2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB2.ShortcutsEnabled = false;
            this.RTB2.Size = new System.Drawing.Size(37, 37);
            this.RTB2.TabIndex = 1;
            this.RTB2.Text = "0";
            // 
            // RTB3
            // 
            this.RTB3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB3.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB3.HideSelection = false;
            this.RTB3.Location = new System.Drawing.Point(89, 3);
            this.RTB3.MaxLength = 1;
            this.RTB3.Name = "RTB3";
            this.RTB3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB3.ShortcutsEnabled = false;
            this.RTB3.Size = new System.Drawing.Size(37, 37);
            this.RTB3.TabIndex = 2;
            this.RTB3.Text = "0";
            // 
            // RTB10
            // 
            this.RTB10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB10.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB10.HideSelection = false;
            this.RTB10.Location = new System.Drawing.Point(3, 46);
            this.RTB10.MaxLength = 1;
            this.RTB10.Name = "RTB10";
            this.RTB10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB10.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB10.ShortcutsEnabled = false;
            this.RTB10.Size = new System.Drawing.Size(37, 37);
            this.RTB10.TabIndex = 3;
            this.RTB10.Text = "0";
            // 
            // RTB11
            // 
            this.RTB11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB11.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB11.HideSelection = false;
            this.RTB11.Location = new System.Drawing.Point(46, 46);
            this.RTB11.MaxLength = 1;
            this.RTB11.Name = "RTB11";
            this.RTB11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB11.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB11.ShortcutsEnabled = false;
            this.RTB11.Size = new System.Drawing.Size(37, 37);
            this.RTB11.TabIndex = 4;
            this.RTB11.Text = "0";
            // 
            // RTB12
            // 
            this.RTB12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB12.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB12.HideSelection = false;
            this.RTB12.Location = new System.Drawing.Point(89, 46);
            this.RTB12.MaxLength = 1;
            this.RTB12.Name = "RTB12";
            this.RTB12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB12.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB12.ShortcutsEnabled = false;
            this.RTB12.Size = new System.Drawing.Size(37, 37);
            this.RTB12.TabIndex = 5;
            this.RTB12.Text = "0";
            // 
            // RTB19
            // 
            this.RTB19.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB19.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB19.HideSelection = false;
            this.RTB19.Location = new System.Drawing.Point(3, 89);
            this.RTB19.MaxLength = 1;
            this.RTB19.Name = "RTB19";
            this.RTB19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB19.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB19.ShortcutsEnabled = false;
            this.RTB19.Size = new System.Drawing.Size(37, 37);
            this.RTB19.TabIndex = 6;
            this.RTB19.Text = "0";
            // 
            // RTB20
            // 
            this.RTB20.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB20.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB20.HideSelection = false;
            this.RTB20.Location = new System.Drawing.Point(46, 89);
            this.RTB20.MaxLength = 1;
            this.RTB20.Name = "RTB20";
            this.RTB20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB20.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB20.ShortcutsEnabled = false;
            this.RTB20.Size = new System.Drawing.Size(37, 37);
            this.RTB20.TabIndex = 7;
            this.RTB20.Text = "0";
            // 
            // RTB21
            // 
            this.RTB21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB21.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB21.HideSelection = false;
            this.RTB21.Location = new System.Drawing.Point(89, 89);
            this.RTB21.MaxLength = 1;
            this.RTB21.Name = "RTB21";
            this.RTB21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB21.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB21.ShortcutsEnabled = false;
            this.RTB21.Size = new System.Drawing.Size(37, 37);
            this.RTB21.TabIndex = 8;
            this.RTB21.Text = "0";
            // 
            // MainFieldBlock
            // 
            this.MainFieldBlock.Controls.Add(this.Block1);
            this.MainFieldBlock.Controls.Add(this.Block2);
            this.MainFieldBlock.Controls.Add(this.Block3);
            this.MainFieldBlock.Controls.Add(this.Block4);
            this.MainFieldBlock.Controls.Add(this.Block5);
            this.MainFieldBlock.Controls.Add(this.Block6);
            this.MainFieldBlock.Controls.Add(this.Block7);
            this.MainFieldBlock.Controls.Add(this.Block8);
            this.MainFieldBlock.Controls.Add(this.Block9);
            this.MainFieldBlock.Location = new System.Drawing.Point(40, 35);
            this.MainFieldBlock.Name = "MainFieldBlock";
            this.MainFieldBlock.Size = new System.Drawing.Size(408, 409);
            this.MainFieldBlock.TabIndex = 0;
            // 
            // Block2
            // 
            this.Block2.Controls.Add(this.RTB4);
            this.Block2.Controls.Add(this.RTB5);
            this.Block2.Controls.Add(this.RTB6);
            this.Block2.Controls.Add(this.RTB13);
            this.Block2.Controls.Add(this.RTB14);
            this.Block2.Controls.Add(this.RTB15);
            this.Block2.Controls.Add(this.RTB22);
            this.Block2.Controls.Add(this.RTB23);
            this.Block2.Controls.Add(this.RTB24);
            this.Block2.Location = new System.Drawing.Point(139, 3);
            this.Block2.Name = "Block2";
            this.Block2.Size = new System.Drawing.Size(130, 130);
            this.Block2.TabIndex = 2;
            // 
            // RTB4
            // 
            this.RTB4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB4.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB4.HideSelection = false;
            this.RTB4.Location = new System.Drawing.Point(3, 3);
            this.RTB4.MaxLength = 1;
            this.RTB4.Name = "RTB4";
            this.RTB4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB4.ShortcutsEnabled = false;
            this.RTB4.Size = new System.Drawing.Size(37, 37);
            this.RTB4.TabIndex = 0;
            this.RTB4.Text = "0";
            // 
            // RTB5
            // 
            this.RTB5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB5.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB5.HideSelection = false;
            this.RTB5.Location = new System.Drawing.Point(46, 3);
            this.RTB5.MaxLength = 1;
            this.RTB5.Name = "RTB5";
            this.RTB5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB5.ShortcutsEnabled = false;
            this.RTB5.Size = new System.Drawing.Size(37, 37);
            this.RTB5.TabIndex = 1;
            this.RTB5.Text = "0";
            // 
            // RTB6
            // 
            this.RTB6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB6.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB6.HideSelection = false;
            this.RTB6.Location = new System.Drawing.Point(89, 3);
            this.RTB6.MaxLength = 1;
            this.RTB6.Name = "RTB6";
            this.RTB6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB6.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB6.ShortcutsEnabled = false;
            this.RTB6.Size = new System.Drawing.Size(37, 37);
            this.RTB6.TabIndex = 2;
            this.RTB6.Text = "0";
            // 
            // RTB13
            // 
            this.RTB13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB13.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB13.HideSelection = false;
            this.RTB13.Location = new System.Drawing.Point(3, 46);
            this.RTB13.MaxLength = 1;
            this.RTB13.Name = "RTB13";
            this.RTB13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB13.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB13.ShortcutsEnabled = false;
            this.RTB13.Size = new System.Drawing.Size(37, 37);
            this.RTB13.TabIndex = 3;
            this.RTB13.Text = "0";
            // 
            // RTB14
            // 
            this.RTB14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB14.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB14.HideSelection = false;
            this.RTB14.Location = new System.Drawing.Point(46, 46);
            this.RTB14.MaxLength = 1;
            this.RTB14.Name = "RTB14";
            this.RTB14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB14.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB14.ShortcutsEnabled = false;
            this.RTB14.Size = new System.Drawing.Size(37, 37);
            this.RTB14.TabIndex = 4;
            this.RTB14.Text = "0";
            // 
            // RTB15
            // 
            this.RTB15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB15.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB15.HideSelection = false;
            this.RTB15.Location = new System.Drawing.Point(89, 46);
            this.RTB15.MaxLength = 1;
            this.RTB15.Name = "RTB15";
            this.RTB15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB15.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB15.ShortcutsEnabled = false;
            this.RTB15.Size = new System.Drawing.Size(37, 37);
            this.RTB15.TabIndex = 5;
            this.RTB15.Text = "0";
            // 
            // RTB22
            // 
            this.RTB22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB22.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB22.HideSelection = false;
            this.RTB22.Location = new System.Drawing.Point(3, 89);
            this.RTB22.MaxLength = 1;
            this.RTB22.Name = "RTB22";
            this.RTB22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB22.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB22.ShortcutsEnabled = false;
            this.RTB22.Size = new System.Drawing.Size(37, 37);
            this.RTB22.TabIndex = 6;
            this.RTB22.Text = "0";
            // 
            // RTB23
            // 
            this.RTB23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB23.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB23.HideSelection = false;
            this.RTB23.Location = new System.Drawing.Point(46, 89);
            this.RTB23.MaxLength = 1;
            this.RTB23.Name = "RTB23";
            this.RTB23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB23.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB23.ShortcutsEnabled = false;
            this.RTB23.Size = new System.Drawing.Size(37, 37);
            this.RTB23.TabIndex = 7;
            this.RTB23.Text = "0";
            // 
            // RTB24
            // 
            this.RTB24.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB24.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB24.HideSelection = false;
            this.RTB24.Location = new System.Drawing.Point(89, 89);
            this.RTB24.MaxLength = 1;
            this.RTB24.Name = "RTB24";
            this.RTB24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB24.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB24.ShortcutsEnabled = false;
            this.RTB24.Size = new System.Drawing.Size(37, 37);
            this.RTB24.TabIndex = 8;
            this.RTB24.Text = "0";
            // 
            // Block3
            // 
            this.Block3.Controls.Add(this.RTB7);
            this.Block3.Controls.Add(this.RTB8);
            this.Block3.Controls.Add(this.RTB9);
            this.Block3.Controls.Add(this.RTB16);
            this.Block3.Controls.Add(this.RTB17);
            this.Block3.Controls.Add(this.RTB18);
            this.Block3.Controls.Add(this.RTB25);
            this.Block3.Controls.Add(this.RTB26);
            this.Block3.Controls.Add(this.RTB27);
            this.Block3.Location = new System.Drawing.Point(275, 3);
            this.Block3.Name = "Block3";
            this.Block3.Size = new System.Drawing.Size(130, 130);
            this.Block3.TabIndex = 3;
            // 
            // RTB7
            // 
            this.RTB7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB7.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB7.HideSelection = false;
            this.RTB7.Location = new System.Drawing.Point(3, 3);
            this.RTB7.MaxLength = 1;
            this.RTB7.Name = "RTB7";
            this.RTB7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB7.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB7.ShortcutsEnabled = false;
            this.RTB7.Size = new System.Drawing.Size(37, 37);
            this.RTB7.TabIndex = 0;
            this.RTB7.Text = "0";
            // 
            // RTB8
            // 
            this.RTB8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB8.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB8.HideSelection = false;
            this.RTB8.Location = new System.Drawing.Point(46, 3);
            this.RTB8.MaxLength = 1;
            this.RTB8.Name = "RTB8";
            this.RTB8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB8.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB8.ShortcutsEnabled = false;
            this.RTB8.Size = new System.Drawing.Size(37, 37);
            this.RTB8.TabIndex = 1;
            this.RTB8.Text = "0";
            // 
            // RTB9
            // 
            this.RTB9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB9.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB9.HideSelection = false;
            this.RTB9.Location = new System.Drawing.Point(89, 3);
            this.RTB9.MaxLength = 1;
            this.RTB9.Name = "RTB9";
            this.RTB9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB9.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB9.ShortcutsEnabled = false;
            this.RTB9.Size = new System.Drawing.Size(37, 37);
            this.RTB9.TabIndex = 2;
            this.RTB9.Text = "0";
            // 
            // RTB16
            // 
            this.RTB16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB16.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB16.HideSelection = false;
            this.RTB16.Location = new System.Drawing.Point(3, 46);
            this.RTB16.MaxLength = 1;
            this.RTB16.Name = "RTB16";
            this.RTB16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB16.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB16.ShortcutsEnabled = false;
            this.RTB16.Size = new System.Drawing.Size(37, 37);
            this.RTB16.TabIndex = 3;
            this.RTB16.Text = "0";
            // 
            // RTB17
            // 
            this.RTB17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB17.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB17.HideSelection = false;
            this.RTB17.Location = new System.Drawing.Point(46, 46);
            this.RTB17.MaxLength = 1;
            this.RTB17.Name = "RTB17";
            this.RTB17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB17.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB17.ShortcutsEnabled = false;
            this.RTB17.Size = new System.Drawing.Size(37, 37);
            this.RTB17.TabIndex = 4;
            this.RTB17.Text = "0";
            // 
            // RTB18
            // 
            this.RTB18.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB18.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB18.HideSelection = false;
            this.RTB18.Location = new System.Drawing.Point(89, 46);
            this.RTB18.MaxLength = 1;
            this.RTB18.Name = "RTB18";
            this.RTB18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB18.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB18.ShortcutsEnabled = false;
            this.RTB18.Size = new System.Drawing.Size(37, 37);
            this.RTB18.TabIndex = 5;
            this.RTB18.Text = "0";
            // 
            // RTB25
            // 
            this.RTB25.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB25.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB25.HideSelection = false;
            this.RTB25.Location = new System.Drawing.Point(3, 89);
            this.RTB25.MaxLength = 1;
            this.RTB25.Name = "RTB25";
            this.RTB25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB25.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB25.ShortcutsEnabled = false;
            this.RTB25.Size = new System.Drawing.Size(37, 37);
            this.RTB25.TabIndex = 6;
            this.RTB25.Text = "0";
            // 
            // RTB26
            // 
            this.RTB26.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB26.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB26.HideSelection = false;
            this.RTB26.Location = new System.Drawing.Point(46, 89);
            this.RTB26.MaxLength = 1;
            this.RTB26.Name = "RTB26";
            this.RTB26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB26.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB26.ShortcutsEnabled = false;
            this.RTB26.Size = new System.Drawing.Size(37, 37);
            this.RTB26.TabIndex = 7;
            this.RTB26.Text = "0";
            // 
            // RTB27
            // 
            this.RTB27.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB27.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB27.HideSelection = false;
            this.RTB27.Location = new System.Drawing.Point(89, 89);
            this.RTB27.MaxLength = 1;
            this.RTB27.Name = "RTB27";
            this.RTB27.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB27.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB27.ShortcutsEnabled = false;
            this.RTB27.Size = new System.Drawing.Size(37, 37);
            this.RTB27.TabIndex = 8;
            this.RTB27.Text = "0";
            // 
            // Block4
            // 
            this.Block4.Controls.Add(this.RTB28);
            this.Block4.Controls.Add(this.RTB29);
            this.Block4.Controls.Add(this.RTB30);
            this.Block4.Controls.Add(this.RTB37);
            this.Block4.Controls.Add(this.RTB38);
            this.Block4.Controls.Add(this.RTB39);
            this.Block4.Controls.Add(this.RTB46);
            this.Block4.Controls.Add(this.RTB47);
            this.Block4.Controls.Add(this.RTB48);
            this.Block4.Location = new System.Drawing.Point(3, 139);
            this.Block4.Name = "Block4";
            this.Block4.Size = new System.Drawing.Size(130, 130);
            this.Block4.TabIndex = 4;
            // 
            // RTB28
            // 
            this.RTB28.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB28.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB28.HideSelection = false;
            this.RTB28.Location = new System.Drawing.Point(3, 3);
            this.RTB28.MaxLength = 1;
            this.RTB28.Name = "RTB28";
            this.RTB28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB28.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB28.ShortcutsEnabled = false;
            this.RTB28.Size = new System.Drawing.Size(37, 37);
            this.RTB28.TabIndex = 0;
            this.RTB28.Text = "0";
            // 
            // RTB29
            // 
            this.RTB29.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB29.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB29.HideSelection = false;
            this.RTB29.Location = new System.Drawing.Point(46, 3);
            this.RTB29.MaxLength = 1;
            this.RTB29.Name = "RTB29";
            this.RTB29.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB29.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB29.ShortcutsEnabled = false;
            this.RTB29.Size = new System.Drawing.Size(37, 37);
            this.RTB29.TabIndex = 1;
            this.RTB29.Text = "0";
            // 
            // RTB30
            // 
            this.RTB30.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB30.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB30.HideSelection = false;
            this.RTB30.Location = new System.Drawing.Point(89, 3);
            this.RTB30.MaxLength = 1;
            this.RTB30.Name = "RTB30";
            this.RTB30.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB30.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB30.ShortcutsEnabled = false;
            this.RTB30.Size = new System.Drawing.Size(37, 37);
            this.RTB30.TabIndex = 2;
            this.RTB30.Text = "0";
            // 
            // RTB37
            // 
            this.RTB37.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB37.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB37.HideSelection = false;
            this.RTB37.Location = new System.Drawing.Point(3, 46);
            this.RTB37.MaxLength = 1;
            this.RTB37.Name = "RTB37";
            this.RTB37.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB37.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB37.ShortcutsEnabled = false;
            this.RTB37.Size = new System.Drawing.Size(37, 37);
            this.RTB37.TabIndex = 3;
            this.RTB37.Text = "0";
            // 
            // RTB38
            // 
            this.RTB38.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB38.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB38.HideSelection = false;
            this.RTB38.Location = new System.Drawing.Point(46, 46);
            this.RTB38.MaxLength = 1;
            this.RTB38.Name = "RTB38";
            this.RTB38.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB38.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB38.ShortcutsEnabled = false;
            this.RTB38.Size = new System.Drawing.Size(37, 37);
            this.RTB38.TabIndex = 4;
            this.RTB38.Text = "0";
            // 
            // RTB39
            // 
            this.RTB39.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB39.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB39.HideSelection = false;
            this.RTB39.Location = new System.Drawing.Point(89, 46);
            this.RTB39.MaxLength = 1;
            this.RTB39.Name = "RTB39";
            this.RTB39.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB39.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB39.ShortcutsEnabled = false;
            this.RTB39.Size = new System.Drawing.Size(37, 37);
            this.RTB39.TabIndex = 5;
            this.RTB39.Text = "0";
            // 
            // RTB46
            // 
            this.RTB46.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB46.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB46.HideSelection = false;
            this.RTB46.Location = new System.Drawing.Point(3, 89);
            this.RTB46.MaxLength = 1;
            this.RTB46.Name = "RTB46";
            this.RTB46.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB46.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB46.ShortcutsEnabled = false;
            this.RTB46.Size = new System.Drawing.Size(37, 37);
            this.RTB46.TabIndex = 6;
            this.RTB46.Text = "0";
            // 
            // RTB47
            // 
            this.RTB47.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB47.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB47.HideSelection = false;
            this.RTB47.Location = new System.Drawing.Point(46, 89);
            this.RTB47.MaxLength = 1;
            this.RTB47.Name = "RTB47";
            this.RTB47.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB47.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB47.ShortcutsEnabled = false;
            this.RTB47.Size = new System.Drawing.Size(37, 37);
            this.RTB47.TabIndex = 7;
            this.RTB47.Text = "0";
            // 
            // RTB48
            // 
            this.RTB48.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB48.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB48.HideSelection = false;
            this.RTB48.Location = new System.Drawing.Point(89, 89);
            this.RTB48.MaxLength = 1;
            this.RTB48.Name = "RTB48";
            this.RTB48.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB48.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB48.ShortcutsEnabled = false;
            this.RTB48.Size = new System.Drawing.Size(37, 37);
            this.RTB48.TabIndex = 8;
            this.RTB48.Text = "0";
            // 
            // Block5
            // 
            this.Block5.Controls.Add(this.RTB31);
            this.Block5.Controls.Add(this.RTB32);
            this.Block5.Controls.Add(this.RTB33);
            this.Block5.Controls.Add(this.RTB40);
            this.Block5.Controls.Add(this.RTB41);
            this.Block5.Controls.Add(this.RTB42);
            this.Block5.Controls.Add(this.RTB49);
            this.Block5.Controls.Add(this.RTB50);
            this.Block5.Controls.Add(this.RTB51);
            this.Block5.Location = new System.Drawing.Point(139, 139);
            this.Block5.Name = "Block5";
            this.Block5.Size = new System.Drawing.Size(130, 130);
            this.Block5.TabIndex = 5;
            // 
            // RTB31
            // 
            this.RTB31.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB31.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB31.HideSelection = false;
            this.RTB31.Location = new System.Drawing.Point(3, 3);
            this.RTB31.MaxLength = 1;
            this.RTB31.Name = "RTB31";
            this.RTB31.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB31.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB31.ShortcutsEnabled = false;
            this.RTB31.Size = new System.Drawing.Size(37, 37);
            this.RTB31.TabIndex = 0;
            this.RTB31.Text = "0";
            // 
            // RTB32
            // 
            this.RTB32.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB32.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB32.HideSelection = false;
            this.RTB32.Location = new System.Drawing.Point(46, 3);
            this.RTB32.MaxLength = 1;
            this.RTB32.Name = "RTB32";
            this.RTB32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB32.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB32.ShortcutsEnabled = false;
            this.RTB32.Size = new System.Drawing.Size(37, 37);
            this.RTB32.TabIndex = 1;
            this.RTB32.Text = "0";
            // 
            // RTB33
            // 
            this.RTB33.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB33.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB33.HideSelection = false;
            this.RTB33.Location = new System.Drawing.Point(89, 3);
            this.RTB33.MaxLength = 1;
            this.RTB33.Name = "RTB33";
            this.RTB33.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB33.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB33.ShortcutsEnabled = false;
            this.RTB33.Size = new System.Drawing.Size(37, 37);
            this.RTB33.TabIndex = 2;
            this.RTB33.Text = "0";
            // 
            // RTB40
            // 
            this.RTB40.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB40.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB40.HideSelection = false;
            this.RTB40.Location = new System.Drawing.Point(3, 46);
            this.RTB40.MaxLength = 1;
            this.RTB40.Name = "RTB40";
            this.RTB40.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB40.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB40.ShortcutsEnabled = false;
            this.RTB40.Size = new System.Drawing.Size(37, 37);
            this.RTB40.TabIndex = 3;
            this.RTB40.Text = "0";
            this.RTB40.TextChanged += new System.EventHandler(this.richTextBox40_TextChanged);
            // 
            // RTB41
            // 
            this.RTB41.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB41.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB41.HideSelection = false;
            this.RTB41.Location = new System.Drawing.Point(46, 46);
            this.RTB41.MaxLength = 1;
            this.RTB41.Name = "RTB41";
            this.RTB41.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB41.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB41.ShortcutsEnabled = false;
            this.RTB41.Size = new System.Drawing.Size(37, 37);
            this.RTB41.TabIndex = 4;
            this.RTB41.Text = "0";
            // 
            // RTB42
            // 
            this.RTB42.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB42.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB42.HideSelection = false;
            this.RTB42.Location = new System.Drawing.Point(89, 46);
            this.RTB42.MaxLength = 1;
            this.RTB42.Name = "RTB42";
            this.RTB42.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB42.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB42.ShortcutsEnabled = false;
            this.RTB42.Size = new System.Drawing.Size(37, 37);
            this.RTB42.TabIndex = 5;
            this.RTB42.Text = "0";
            this.RTB42.TextChanged += new System.EventHandler(this.richTextBox42_TextChanged);
            // 
            // RTB49
            // 
            this.RTB49.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB49.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB49.HideSelection = false;
            this.RTB49.Location = new System.Drawing.Point(3, 89);
            this.RTB49.MaxLength = 1;
            this.RTB49.Name = "RTB49";
            this.RTB49.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB49.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB49.ShortcutsEnabled = false;
            this.RTB49.Size = new System.Drawing.Size(37, 37);
            this.RTB49.TabIndex = 6;
            this.RTB49.Text = "0";
            // 
            // RTB50
            // 
            this.RTB50.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB50.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB50.HideSelection = false;
            this.RTB50.Location = new System.Drawing.Point(46, 89);
            this.RTB50.MaxLength = 1;
            this.RTB50.Name = "RTB50";
            this.RTB50.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB50.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB50.ShortcutsEnabled = false;
            this.RTB50.Size = new System.Drawing.Size(37, 37);
            this.RTB50.TabIndex = 7;
            this.RTB50.Text = "0";
            this.RTB50.TextChanged += new System.EventHandler(this.richTextBox44_TextChanged);
            // 
            // RTB51
            // 
            this.RTB51.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB51.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB51.HideSelection = false;
            this.RTB51.Location = new System.Drawing.Point(89, 89);
            this.RTB51.MaxLength = 1;
            this.RTB51.Name = "RTB51";
            this.RTB51.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB51.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB51.ShortcutsEnabled = false;
            this.RTB51.Size = new System.Drawing.Size(37, 37);
            this.RTB51.TabIndex = 8;
            this.RTB51.Text = "0";
            // 
            // Block6
            // 
            this.Block6.Controls.Add(this.RTB34);
            this.Block6.Controls.Add(this.RTB35);
            this.Block6.Controls.Add(this.RTB36);
            this.Block6.Controls.Add(this.RTB43);
            this.Block6.Controls.Add(this.RTB44);
            this.Block6.Controls.Add(this.RTB45);
            this.Block6.Controls.Add(this.RTB52);
            this.Block6.Controls.Add(this.RTB53);
            this.Block6.Controls.Add(this.RTB54);
            this.Block6.Location = new System.Drawing.Point(275, 139);
            this.Block6.Name = "Block6";
            this.Block6.Size = new System.Drawing.Size(130, 130);
            this.Block6.TabIndex = 6;
            // 
            // RTB34
            // 
            this.RTB34.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB34.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB34.HideSelection = false;
            this.RTB34.Location = new System.Drawing.Point(3, 3);
            this.RTB34.MaxLength = 1;
            this.RTB34.Name = "RTB34";
            this.RTB34.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB34.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB34.ShortcutsEnabled = false;
            this.RTB34.Size = new System.Drawing.Size(37, 37);
            this.RTB34.TabIndex = 0;
            this.RTB34.Text = "0";
            // 
            // RTB35
            // 
            this.RTB35.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB35.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB35.HideSelection = false;
            this.RTB35.Location = new System.Drawing.Point(46, 3);
            this.RTB35.MaxLength = 1;
            this.RTB35.Name = "RTB35";
            this.RTB35.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB35.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB35.ShortcutsEnabled = false;
            this.RTB35.Size = new System.Drawing.Size(37, 37);
            this.RTB35.TabIndex = 1;
            this.RTB35.Text = "0";
            // 
            // RTB36
            // 
            this.RTB36.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB36.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB36.HideSelection = false;
            this.RTB36.Location = new System.Drawing.Point(89, 3);
            this.RTB36.MaxLength = 1;
            this.RTB36.Name = "RTB36";
            this.RTB36.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB36.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB36.ShortcutsEnabled = false;
            this.RTB36.Size = new System.Drawing.Size(37, 37);
            this.RTB36.TabIndex = 2;
            this.RTB36.Text = "0";
            // 
            // RTB43
            // 
            this.RTB43.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB43.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB43.HideSelection = false;
            this.RTB43.Location = new System.Drawing.Point(3, 46);
            this.RTB43.MaxLength = 1;
            this.RTB43.Name = "RTB43";
            this.RTB43.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB43.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB43.ShortcutsEnabled = false;
            this.RTB43.Size = new System.Drawing.Size(37, 37);
            this.RTB43.TabIndex = 3;
            this.RTB43.Text = "0";
            // 
            // RTB44
            // 
            this.RTB44.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB44.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB44.HideSelection = false;
            this.RTB44.Location = new System.Drawing.Point(46, 46);
            this.RTB44.MaxLength = 1;
            this.RTB44.Name = "RTB44";
            this.RTB44.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB44.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB44.ShortcutsEnabled = false;
            this.RTB44.Size = new System.Drawing.Size(37, 37);
            this.RTB44.TabIndex = 4;
            this.RTB44.Text = "0";
            // 
            // RTB45
            // 
            this.RTB45.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB45.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB45.HideSelection = false;
            this.RTB45.Location = new System.Drawing.Point(89, 46);
            this.RTB45.MaxLength = 1;
            this.RTB45.Name = "RTB45";
            this.RTB45.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB45.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB45.ShortcutsEnabled = false;
            this.RTB45.Size = new System.Drawing.Size(37, 37);
            this.RTB45.TabIndex = 5;
            this.RTB45.Text = "0";
            // 
            // RTB52
            // 
            this.RTB52.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB52.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB52.HideSelection = false;
            this.RTB52.Location = new System.Drawing.Point(3, 89);
            this.RTB52.MaxLength = 1;
            this.RTB52.Name = "RTB52";
            this.RTB52.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB52.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB52.ShortcutsEnabled = false;
            this.RTB52.Size = new System.Drawing.Size(37, 37);
            this.RTB52.TabIndex = 6;
            this.RTB52.Text = "0";
            // 
            // RTB53
            // 
            this.RTB53.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB53.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB53.HideSelection = false;
            this.RTB53.Location = new System.Drawing.Point(46, 89);
            this.RTB53.MaxLength = 1;
            this.RTB53.Name = "RTB53";
            this.RTB53.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB53.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB53.ShortcutsEnabled = false;
            this.RTB53.Size = new System.Drawing.Size(37, 37);
            this.RTB53.TabIndex = 7;
            this.RTB53.Text = "0";
            // 
            // RTB54
            // 
            this.RTB54.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB54.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB54.HideSelection = false;
            this.RTB54.Location = new System.Drawing.Point(89, 89);
            this.RTB54.MaxLength = 1;
            this.RTB54.Name = "RTB54";
            this.RTB54.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB54.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB54.ShortcutsEnabled = false;
            this.RTB54.Size = new System.Drawing.Size(37, 37);
            this.RTB54.TabIndex = 8;
            this.RTB54.Text = "0";
            // 
            // Block7
            // 
            this.Block7.Controls.Add(this.RTB55);
            this.Block7.Controls.Add(this.RTB56);
            this.Block7.Controls.Add(this.RTB57);
            this.Block7.Controls.Add(this.RTB64);
            this.Block7.Controls.Add(this.RTB65);
            this.Block7.Controls.Add(this.RTB66);
            this.Block7.Controls.Add(this.RTB73);
            this.Block7.Controls.Add(this.RTB74);
            this.Block7.Controls.Add(this.RTB75);
            this.Block7.Location = new System.Drawing.Point(3, 275);
            this.Block7.Name = "Block7";
            this.Block7.Size = new System.Drawing.Size(130, 130);
            this.Block7.TabIndex = 7;
            // 
            // RTB55
            // 
            this.RTB55.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB55.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB55.HideSelection = false;
            this.RTB55.Location = new System.Drawing.Point(3, 3);
            this.RTB55.MaxLength = 1;
            this.RTB55.Name = "RTB55";
            this.RTB55.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB55.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB55.ShortcutsEnabled = false;
            this.RTB55.Size = new System.Drawing.Size(37, 37);
            this.RTB55.TabIndex = 0;
            this.RTB55.Text = "0";
            // 
            // RTB56
            // 
            this.RTB56.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB56.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB56.HideSelection = false;
            this.RTB56.Location = new System.Drawing.Point(46, 3);
            this.RTB56.MaxLength = 1;
            this.RTB56.Name = "RTB56";
            this.RTB56.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB56.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB56.ShortcutsEnabled = false;
            this.RTB56.Size = new System.Drawing.Size(37, 37);
            this.RTB56.TabIndex = 1;
            this.RTB56.Text = "0";
            // 
            // RTB57
            // 
            this.RTB57.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB57.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB57.HideSelection = false;
            this.RTB57.Location = new System.Drawing.Point(89, 3);
            this.RTB57.MaxLength = 1;
            this.RTB57.Name = "RTB57";
            this.RTB57.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB57.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB57.ShortcutsEnabled = false;
            this.RTB57.Size = new System.Drawing.Size(37, 37);
            this.RTB57.TabIndex = 2;
            this.RTB57.Text = "0";
            // 
            // RTB64
            // 
            this.RTB64.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB64.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB64.HideSelection = false;
            this.RTB64.Location = new System.Drawing.Point(3, 46);
            this.RTB64.MaxLength = 1;
            this.RTB64.Name = "RTB64";
            this.RTB64.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB64.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB64.ShortcutsEnabled = false;
            this.RTB64.Size = new System.Drawing.Size(37, 37);
            this.RTB64.TabIndex = 3;
            this.RTB64.Text = "0";
            // 
            // RTB65
            // 
            this.RTB65.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB65.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB65.HideSelection = false;
            this.RTB65.Location = new System.Drawing.Point(46, 46);
            this.RTB65.MaxLength = 1;
            this.RTB65.Name = "RTB65";
            this.RTB65.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB65.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB65.ShortcutsEnabled = false;
            this.RTB65.Size = new System.Drawing.Size(37, 37);
            this.RTB65.TabIndex = 4;
            this.RTB65.Text = "0";
            // 
            // RTB66
            // 
            this.RTB66.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB66.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB66.HideSelection = false;
            this.RTB66.Location = new System.Drawing.Point(89, 46);
            this.RTB66.MaxLength = 1;
            this.RTB66.Name = "RTB66";
            this.RTB66.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB66.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB66.ShortcutsEnabled = false;
            this.RTB66.Size = new System.Drawing.Size(37, 37);
            this.RTB66.TabIndex = 5;
            this.RTB66.Text = "0";
            // 
            // RTB73
            // 
            this.RTB73.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB73.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB73.HideSelection = false;
            this.RTB73.Location = new System.Drawing.Point(3, 89);
            this.RTB73.MaxLength = 1;
            this.RTB73.Name = "RTB73";
            this.RTB73.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB73.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB73.ShortcutsEnabled = false;
            this.RTB73.Size = new System.Drawing.Size(37, 37);
            this.RTB73.TabIndex = 6;
            this.RTB73.Text = "0";
            // 
            // RTB74
            // 
            this.RTB74.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB74.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB74.HideSelection = false;
            this.RTB74.Location = new System.Drawing.Point(46, 89);
            this.RTB74.MaxLength = 1;
            this.RTB74.Name = "RTB74";
            this.RTB74.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB74.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB74.ShortcutsEnabled = false;
            this.RTB74.Size = new System.Drawing.Size(37, 37);
            this.RTB74.TabIndex = 7;
            this.RTB74.Text = "0";
            // 
            // RTB75
            // 
            this.RTB75.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB75.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB75.HideSelection = false;
            this.RTB75.Location = new System.Drawing.Point(89, 89);
            this.RTB75.MaxLength = 1;
            this.RTB75.Name = "RTB75";
            this.RTB75.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB75.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB75.ShortcutsEnabled = false;
            this.RTB75.Size = new System.Drawing.Size(37, 37);
            this.RTB75.TabIndex = 8;
            this.RTB75.Text = "0";
            // 
            // Block8
            // 
            this.Block8.Controls.Add(this.RTB58);
            this.Block8.Controls.Add(this.RTB59);
            this.Block8.Controls.Add(this.RTB60);
            this.Block8.Controls.Add(this.RTB67);
            this.Block8.Controls.Add(this.RTB68);
            this.Block8.Controls.Add(this.RTB69);
            this.Block8.Controls.Add(this.RTB76);
            this.Block8.Controls.Add(this.RTB77);
            this.Block8.Controls.Add(this.RTB78);
            this.Block8.Location = new System.Drawing.Point(139, 275);
            this.Block8.Name = "Block8";
            this.Block8.Size = new System.Drawing.Size(130, 130);
            this.Block8.TabIndex = 8;
            // 
            // RTB58
            // 
            this.RTB58.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB58.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB58.HideSelection = false;
            this.RTB58.Location = new System.Drawing.Point(3, 3);
            this.RTB58.MaxLength = 1;
            this.RTB58.Name = "RTB58";
            this.RTB58.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB58.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB58.ShortcutsEnabled = false;
            this.RTB58.Size = new System.Drawing.Size(37, 37);
            this.RTB58.TabIndex = 0;
            this.RTB58.Text = "0";
            // 
            // RTB59
            // 
            this.RTB59.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB59.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB59.HideSelection = false;
            this.RTB59.Location = new System.Drawing.Point(46, 3);
            this.RTB59.MaxLength = 1;
            this.RTB59.Name = "RTB59";
            this.RTB59.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB59.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB59.ShortcutsEnabled = false;
            this.RTB59.Size = new System.Drawing.Size(37, 37);
            this.RTB59.TabIndex = 1;
            this.RTB59.Text = "0";
            // 
            // RTB60
            // 
            this.RTB60.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB60.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB60.HideSelection = false;
            this.RTB60.Location = new System.Drawing.Point(89, 3);
            this.RTB60.MaxLength = 1;
            this.RTB60.Name = "RTB60";
            this.RTB60.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB60.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB60.ShortcutsEnabled = false;
            this.RTB60.Size = new System.Drawing.Size(37, 37);
            this.RTB60.TabIndex = 2;
            this.RTB60.Text = "0";
            this.RTB60.TextChanged += new System.EventHandler(this.richTextBox66_TextChanged);
            // 
            // RTB67
            // 
            this.RTB67.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB67.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB67.HideSelection = false;
            this.RTB67.Location = new System.Drawing.Point(3, 46);
            this.RTB67.MaxLength = 1;
            this.RTB67.Name = "RTB67";
            this.RTB67.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB67.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB67.ShortcutsEnabled = false;
            this.RTB67.Size = new System.Drawing.Size(37, 37);
            this.RTB67.TabIndex = 3;
            this.RTB67.Text = "0";
            // 
            // RTB68
            // 
            this.RTB68.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB68.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB68.HideSelection = false;
            this.RTB68.Location = new System.Drawing.Point(46, 46);
            this.RTB68.MaxLength = 1;
            this.RTB68.Name = "RTB68";
            this.RTB68.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB68.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB68.ShortcutsEnabled = false;
            this.RTB68.Size = new System.Drawing.Size(37, 37);
            this.RTB68.TabIndex = 4;
            this.RTB68.Text = "0";
            // 
            // RTB69
            // 
            this.RTB69.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB69.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB69.HideSelection = false;
            this.RTB69.Location = new System.Drawing.Point(89, 46);
            this.RTB69.MaxLength = 1;
            this.RTB69.Name = "RTB69";
            this.RTB69.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB69.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB69.ShortcutsEnabled = false;
            this.RTB69.Size = new System.Drawing.Size(37, 37);
            this.RTB69.TabIndex = 5;
            this.RTB69.Text = "0";
            // 
            // RTB76
            // 
            this.RTB76.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB76.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB76.HideSelection = false;
            this.RTB76.Location = new System.Drawing.Point(3, 89);
            this.RTB76.MaxLength = 1;
            this.RTB76.Name = "RTB76";
            this.RTB76.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB76.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB76.ShortcutsEnabled = false;
            this.RTB76.Size = new System.Drawing.Size(37, 37);
            this.RTB76.TabIndex = 6;
            this.RTB76.Text = "0";
            // 
            // RTB77
            // 
            this.RTB77.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB77.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB77.HideSelection = false;
            this.RTB77.Location = new System.Drawing.Point(46, 89);
            this.RTB77.MaxLength = 1;
            this.RTB77.Name = "RTB77";
            this.RTB77.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB77.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB77.ShortcutsEnabled = false;
            this.RTB77.Size = new System.Drawing.Size(37, 37);
            this.RTB77.TabIndex = 7;
            this.RTB77.Text = "0";
            // 
            // RTB78
            // 
            this.RTB78.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB78.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB78.HideSelection = false;
            this.RTB78.Location = new System.Drawing.Point(89, 89);
            this.RTB78.MaxLength = 1;
            this.RTB78.Name = "RTB78";
            this.RTB78.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB78.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB78.ShortcutsEnabled = false;
            this.RTB78.Size = new System.Drawing.Size(37, 37);
            this.RTB78.TabIndex = 8;
            this.RTB78.Text = "0";
            // 
            // Block9
            // 
            this.Block9.Controls.Add(this.RTB61);
            this.Block9.Controls.Add(this.RTB62);
            this.Block9.Controls.Add(this.RTB63);
            this.Block9.Controls.Add(this.RTB70);
            this.Block9.Controls.Add(this.RTB71);
            this.Block9.Controls.Add(this.RTB72);
            this.Block9.Controls.Add(this.RTB79);
            this.Block9.Controls.Add(this.RTB80);
            this.Block9.Controls.Add(this.RTB81);
            this.Block9.Location = new System.Drawing.Point(275, 275);
            this.Block9.Name = "Block9";
            this.Block9.Size = new System.Drawing.Size(130, 130);
            this.Block9.TabIndex = 9;
            // 
            // RTB61
            // 
            this.RTB61.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB61.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB61.HideSelection = false;
            this.RTB61.Location = new System.Drawing.Point(3, 3);
            this.RTB61.MaxLength = 1;
            this.RTB61.Name = "RTB61";
            this.RTB61.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB61.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB61.ShortcutsEnabled = false;
            this.RTB61.Size = new System.Drawing.Size(37, 37);
            this.RTB61.TabIndex = 0;
            this.RTB61.Text = "0";
            // 
            // RTB62
            // 
            this.RTB62.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB62.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB62.HideSelection = false;
            this.RTB62.Location = new System.Drawing.Point(46, 3);
            this.RTB62.MaxLength = 1;
            this.RTB62.Name = "RTB62";
            this.RTB62.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB62.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB62.ShortcutsEnabled = false;
            this.RTB62.Size = new System.Drawing.Size(37, 37);
            this.RTB62.TabIndex = 1;
            this.RTB62.Text = "0";
            // 
            // RTB63
            // 
            this.RTB63.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB63.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB63.HideSelection = false;
            this.RTB63.Location = new System.Drawing.Point(89, 3);
            this.RTB63.MaxLength = 1;
            this.RTB63.Name = "RTB63";
            this.RTB63.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB63.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB63.ShortcutsEnabled = false;
            this.RTB63.Size = new System.Drawing.Size(37, 37);
            this.RTB63.TabIndex = 2;
            this.RTB63.Text = "0";
            // 
            // RTB70
            // 
            this.RTB70.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB70.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB70.HideSelection = false;
            this.RTB70.Location = new System.Drawing.Point(3, 46);
            this.RTB70.MaxLength = 1;
            this.RTB70.Name = "RTB70";
            this.RTB70.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB70.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB70.ShortcutsEnabled = false;
            this.RTB70.Size = new System.Drawing.Size(37, 37);
            this.RTB70.TabIndex = 3;
            this.RTB70.Text = "0";
            // 
            // RTB71
            // 
            this.RTB71.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB71.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB71.HideSelection = false;
            this.RTB71.Location = new System.Drawing.Point(46, 46);
            this.RTB71.MaxLength = 1;
            this.RTB71.Name = "RTB71";
            this.RTB71.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB71.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB71.ShortcutsEnabled = false;
            this.RTB71.Size = new System.Drawing.Size(37, 37);
            this.RTB71.TabIndex = 4;
            this.RTB71.Text = "0";
            // 
            // RTB72
            // 
            this.RTB72.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB72.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB72.HideSelection = false;
            this.RTB72.Location = new System.Drawing.Point(89, 46);
            this.RTB72.MaxLength = 1;
            this.RTB72.Name = "RTB72";
            this.RTB72.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB72.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB72.ShortcutsEnabled = false;
            this.RTB72.Size = new System.Drawing.Size(37, 37);
            this.RTB72.TabIndex = 5;
            this.RTB72.Text = "0";
            // 
            // RTB79
            // 
            this.RTB79.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB79.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB79.HideSelection = false;
            this.RTB79.Location = new System.Drawing.Point(3, 89);
            this.RTB79.MaxLength = 1;
            this.RTB79.Name = "RTB79";
            this.RTB79.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB79.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB79.ShortcutsEnabled = false;
            this.RTB79.Size = new System.Drawing.Size(37, 37);
            this.RTB79.TabIndex = 6;
            this.RTB79.Text = "0";
            this.RTB79.TextChanged += new System.EventHandler(this.richTextBox79_TextChanged);
            // 
            // RTB80
            // 
            this.RTB80.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB80.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB80.HideSelection = false;
            this.RTB80.Location = new System.Drawing.Point(46, 89);
            this.RTB80.MaxLength = 1;
            this.RTB80.Name = "RTB80";
            this.RTB80.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB80.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB80.ShortcutsEnabled = false;
            this.RTB80.Size = new System.Drawing.Size(37, 37);
            this.RTB80.TabIndex = 7;
            this.RTB80.Text = "0";
            // 
            // RTB81
            // 
            this.RTB81.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB81.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTB81.HideSelection = false;
            this.RTB81.Location = new System.Drawing.Point(89, 89);
            this.RTB81.MaxLength = 1;
            this.RTB81.Name = "RTB81";
            this.RTB81.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTB81.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB81.ShortcutsEnabled = false;
            this.RTB81.Size = new System.Drawing.Size(37, 37);
            this.RTB81.TabIndex = 8;
            this.RTB81.Text = "0";
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(40, 566);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(86, 24);
            this.NewGameButton.TabIndex = 1;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.MainFieldBlock);
            this.Name = "Form1";
            this.Text = "Sudoku";
            this.Block1.ResumeLayout(false);
            this.MainFieldBlock.ResumeLayout(false);
            this.Block2.ResumeLayout(false);
            this.Block3.ResumeLayout(false);
            this.Block4.ResumeLayout(false);
            this.Block5.ResumeLayout(false);
            this.Block6.ResumeLayout(false);
            this.Block7.ResumeLayout(false);
            this.Block8.ResumeLayout(false);
            this.Block9.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private FlowLayoutPanel Block1;
        private RichTextBox RTB1;
        private FlowLayoutPanel MainFieldBlock;
        private RichTextBox RTB2;
        private RichTextBox RTB3;
        private RichTextBox RTB10;
        private RichTextBox RTB11;
        private RichTextBox RTB12;
        private RichTextBox RTB19;
        private RichTextBox RTB20;
        private RichTextBox RTB21;
        private FlowLayoutPanel Block2;
        private RichTextBox RTB4;
        private RichTextBox RTB5;
        private RichTextBox RTB6;
        private RichTextBox RTB13;
        private RichTextBox RTB14;
        private RichTextBox RTB15;
        private RichTextBox RTB22;
        private RichTextBox RTB23;
        private RichTextBox RTB24;
        private FlowLayoutPanel Block3;
        private RichTextBox RTB7;
        private RichTextBox RTB8;
        private RichTextBox RTB9;
        private RichTextBox RTB16;
        private RichTextBox RTB17;
        private RichTextBox RTB18;
        private RichTextBox RTB25;
        private RichTextBox RTB26;
        private RichTextBox RTB27;
        private FlowLayoutPanel Block4;
        private RichTextBox RTB28;
        private RichTextBox RTB29;
        private RichTextBox RTB30;
        private RichTextBox RTB37;
        private RichTextBox RTB38;
        private RichTextBox RTB39;
        private RichTextBox RTB46;
        private RichTextBox RTB47;
        private RichTextBox RTB48;
        private FlowLayoutPanel Block5;
        private RichTextBox RTB31;
        private RichTextBox RTB32;
        private RichTextBox RTB33;
        private RichTextBox RTB40;
        private RichTextBox RTB41;
        private RichTextBox RTB42;
        private RichTextBox RTB49;
        private RichTextBox RTB50;
        private RichTextBox RTB51;
        private FlowLayoutPanel Block6;
        private RichTextBox RTB34;
        private RichTextBox RTB35;
        private RichTextBox RTB36;
        private RichTextBox RTB43;
        private RichTextBox RTB44;
        private RichTextBox RTB45;
        private RichTextBox RTB52;
        private RichTextBox RTB53;
        private RichTextBox RTB54;
        private FlowLayoutPanel Block7;
        private RichTextBox RTB55;
        private RichTextBox RTB56;
        private RichTextBox RTB57;
        private RichTextBox RTB64;
        private RichTextBox RTB65;
        private RichTextBox RTB66;
        private RichTextBox RTB73;
        private RichTextBox RTB74;
        private RichTextBox RTB75;
        private FlowLayoutPanel Block8;
        private RichTextBox RTB58;
        private RichTextBox RTB59;
        private RichTextBox RTB60;
        private RichTextBox RTB67;
        private RichTextBox RTB68;
        private RichTextBox RTB69;
        private RichTextBox RTB76;
        private RichTextBox RTB77;
        private RichTextBox RTB78;
        private FlowLayoutPanel Block9;
        private RichTextBox RTB61;
        private RichTextBox RTB62;
        private RichTextBox RTB63;
        private RichTextBox RTB70;
        private RichTextBox RTB71;
        private RichTextBox RTB72;
        private RichTextBox RTB79;
        private RichTextBox RTB80;
        private RichTextBox RTB81;
        private Button NewGameButton;
    }
}

