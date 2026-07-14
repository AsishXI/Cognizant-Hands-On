namespace KafkaChatApp
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
            btnSend = new Button();
            label1 = new Label();
            label2 = new Label();
            txtTopic = new TextBox();
            txtMessage = new TextBox();
            lstMessages = new ListBox();
            btnReceive = new Button();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(321, 197);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(161, 29);
            btnSend.TabIndex = 0;
            btnSend.Text = "Send Message";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 49);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 1;
            label1.Text = "Topic";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 131);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Message";
            // 
            // txtTopic
            // 
            txtTopic.Location = new Point(332, 49);
            txtTopic.Name = "txtTopic";
            txtTopic.Size = new Size(125, 27);
            txtTopic.TabIndex = 3;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(332, 131);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(125, 27);
            txtMessage.TabIndex = 4;
            // 
            // lstMessages
            // 
            lstMessages.FormattingEnabled = true;
            lstMessages.Location = new Point(307, 309);
            lstMessages.Name = "lstMessages";
            lstMessages.Size = new Size(150, 104);
            lstMessages.TabIndex = 5;
            // 
            // btnReceive
            // 
            btnReceive.Location = new Point(321, 246);
            btnReceive.Name = "btnReceive";
            btnReceive.Size = new Size(161, 29);
            btnReceive.TabIndex = 6;
            btnReceive.Text = "Start Consumer";
            btnReceive.UseVisualStyleBackColor = true;
            btnReceive.Click += btnReceive_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReceive);
            Controls.Add(lstMessages);
            Controls.Add(txtMessage);
            Controls.Add(txtTopic);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSend);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private Label label1;
        private Label label2;
        private TextBox txtTopic;
        private TextBox txtMessage;
        private ListBox lstMessages;
        private Button btnReceive;
    }
}
