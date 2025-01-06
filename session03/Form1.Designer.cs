namespace session03
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
            buttonReflection = new Button();
            buttonPrivate = new Button();
            buttonToJSON = new Button();
            SuspendLayout();
            // 
            // buttonReflection
            // 
            buttonReflection.Location = new Point(12, 12);
            buttonReflection.Name = "buttonReflection";
            buttonReflection.Size = new Size(144, 23);
            buttonReflection.TabIndex = 0;
            buttonReflection.Text = "Reflection";
            buttonReflection.UseVisualStyleBackColor = true;
            buttonReflection.Click += buttonReflection_Click;
            // 
            // buttonPrivate
            // 
            buttonPrivate.Location = new Point(12, 41);
            buttonPrivate.Name = "buttonPrivate";
            buttonPrivate.Size = new Size(144, 25);
            buttonPrivate.TabIndex = 1;
            buttonPrivate.Text = "Private";
            buttonPrivate.UseVisualStyleBackColor = true;
            buttonPrivate.Click += buttonPrivate_Click;
            // 
            // buttonToJSON
            // 
            buttonToJSON.Location = new Point(12, 72);
            buttonToJSON.Name = "buttonToJSON";
            buttonToJSON.Size = new Size(144, 25);
            buttonToJSON.TabIndex = 2;
            buttonToJSON.Text = "To JSON";
            buttonToJSON.UseVisualStyleBackColor = true;
            buttonToJSON.Click += buttonToJSON_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonToJSON);
            Controls.Add(buttonPrivate);
            Controls.Add(buttonReflection);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonReflection;
        private Button buttonPrivate;
        private Button buttonToJSON;
    }
}
