namespace GrundlagenIFundELSE
{
    partial class IFundElse
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
            TxtEingabe = new TextBox();
            LblAnzeige = new Label();
            CmdAnzeigen = new Button();
            CmdRechnen = new Button();
            CmdErgebnis = new Button();
            NumEingabe = new NumericUpDown();
            CmdDemo = new Button();
            ((System.ComponentModel.ISupportInitialize)NumEingabe).BeginInit();
            SuspendLayout();
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(47, 131);
            TxtEingabe.MaxLength = 32768;
            TxtEingabe.Multiline = true;
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.ScrollBars = ScrollBars.Vertical;
            TxtEingabe.Size = new Size(297, 27);
            TxtEingabe.TabIndex = 0;
            TxtEingabe.TextChanged += TxtEingabe_TextChanged;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.BorderStyle = BorderStyle.FixedSingle;
            LblAnzeige.Location = new Point(469, 64);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(2, 22);
            LblAnzeige.TabIndex = 1;
            LblAnzeige.Click += LblAnzeige_Click;
            // 
            // CmdAnzeigen
            // 
            CmdAnzeigen.Location = new Point(47, 197);
            CmdAnzeigen.Name = "CmdAnzeigen";
            CmdAnzeigen.Size = new Size(297, 27);
            CmdAnzeigen.TabIndex = 2;
            CmdAnzeigen.Text = "Anzeigen";
            CmdAnzeigen.UseVisualStyleBackColor = true;
            CmdAnzeigen.Click += CmdAnzeigen_Click;
            // 
            // CmdRechnen
            // 
            CmdRechnen.Location = new Point(47, 265);
            CmdRechnen.Name = "CmdRechnen";
            CmdRechnen.Size = new Size(297, 27);
            CmdRechnen.TabIndex = 3;
            CmdRechnen.Text = "Rechnen";
            CmdRechnen.UseVisualStyleBackColor = true;
            CmdRechnen.Click += CmdRechnen_Click;
            // 
            // CmdErgebnis
            // 
            CmdErgebnis.Location = new Point(47, 333);
            CmdErgebnis.Name = "CmdErgebnis";
            CmdErgebnis.Size = new Size(297, 27);
            CmdErgebnis.TabIndex = 4;
            CmdErgebnis.Text = "Ergebnis";
            CmdErgebnis.UseVisualStyleBackColor = true;
            CmdErgebnis.Click += CmdErgebnis_Click;
            // 
            // NumEingabe
            // 
            NumEingabe.DecimalPlaces = 3;
            NumEingabe.Location = new Point(47, 64);
            NumEingabe.Name = "NumEingabe";
            NumEingabe.Size = new Size(297, 27);
            NumEingabe.TabIndex = 5;
            NumEingabe.ValueChanged += NumEingabe_ValueChanged;
            // 
            // CmdDemo
            // 
            CmdDemo.Location = new Point(47, 398);
            CmdDemo.Name = "CmdDemo";
            CmdDemo.Size = new Size(297, 27);
            CmdDemo.TabIndex = 6;
            CmdDemo.Text = "Demo";
            CmdDemo.UseVisualStyleBackColor = true;
            CmdDemo.Click += CmdDemo_Click;
            // 
            // IFundElse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdDemo);
            Controls.Add(NumEingabe);
            Controls.Add(CmdErgebnis);
            Controls.Add(CmdRechnen);
            Controls.Add(CmdAnzeigen);
            Controls.Add(LblAnzeige);
            Controls.Add(TxtEingabe);
            Name = "IFundElse";
            Text = "IFundElse";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)NumEingabe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtEingabe;
        private Label LblAnzeige;
        private Button CmdAnzeigen;
        private Button CmdRechnen;
        private Button CmdErgebnis;
        private NumericUpDown NumEingabe;
        private Button CmdDemo;
    }
}
