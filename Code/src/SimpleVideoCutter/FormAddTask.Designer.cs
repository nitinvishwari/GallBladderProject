namespace SimpleVideoCutter
{
    partial class FormAddTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddTask));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.labelFFmpegProfile = new System.Windows.Forms.Label();
            this.textBoxOutputFilePath = new System.Windows.Forms.TextBox();
            this.labelOutputFilePath = new System.Windows.Forms.Label();
            this.stepType = new System.Windows.Forms.ComboBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qualityType = new System.Windows.Forms.ComboBox();
            this.comboBoxFFmpegProfile = new System.Windows.Forms.ComboBox();
            this.comboBoxFileType = new System.Windows.Forms.ComboBox();
            this.buttonSaveProfile = new System.Windows.Forms.Button();
            this.labelFFmpegArguments = new System.Windows.Forms.Label();
            this.labelOriginalFilePath = new System.Windows.Forms.Label();
            this.textBoxOriginalFilePath = new System.Windows.Forms.TextBox();
            this.textBoxFFmpegArguments = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonEnqueue = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelExplanation = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.textBoxDuration, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelFFmpegProfile, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxOutputFilePath, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelOutputFilePath, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.stepType, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelDuration, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.qualityType, 1, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // textBoxDuration
            // 
            resources.ApplyResources(this.textBoxDuration, "textBoxDuration");
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.ReadOnly = true;
            // 
            // labelFFmpegProfile
            // 
            resources.ApplyResources(this.labelFFmpegProfile, "labelFFmpegProfile");
            this.labelFFmpegProfile.Name = "labelFFmpegProfile";
            // 
            // textBoxOutputFilePath
            // 
            resources.ApplyResources(this.textBoxOutputFilePath, "textBoxOutputFilePath");
            this.textBoxOutputFilePath.Name = "textBoxOutputFilePath";
            this.textBoxOutputFilePath.ReadOnly = true;
            // 
            // labelOutputFilePath
            // 
            resources.ApplyResources(this.labelOutputFilePath, "labelOutputFilePath");
            this.labelOutputFilePath.Name = "labelOutputFilePath";
            // 
            // stepType
            // 
            this.stepType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stepType.FormattingEnabled = true;
            resources.ApplyResources(this.stepType, "stepType");
            this.stepType.Name = "stepType";
            this.stepType.SelectedIndexChanged += new System.EventHandler(this.stepType_SelectedIndexChanged);
            // 
            // labelDuration
            // 
            resources.ApplyResources(this.labelDuration, "labelDuration");
            this.labelDuration.Name = "labelDuration";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // qualityType
            // 
            this.qualityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qualityType.FormattingEnabled = true;
            resources.ApplyResources(this.qualityType, "qualityType");
            this.qualityType.Name = "qualityType";
            this.qualityType.SelectedIndexChanged += new System.EventHandler(this.qualityType_SelectedIndexChanged);
            // 
            // comboBoxFFmpegProfile
            // 
            resources.ApplyResources(this.comboBoxFFmpegProfile, "comboBoxFFmpegProfile");
            this.comboBoxFFmpegProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFFmpegProfile.FormattingEnabled = true;
            this.comboBoxFFmpegProfile.Name = "comboBoxFFmpegProfile";
            this.comboBoxFFmpegProfile.SelectedIndexChanged += new System.EventHandler(this.comboBoxFFmpegProfile_SelectedIndexChanged);
            // 
            // comboBoxFileType
            // 
            resources.ApplyResources(this.comboBoxFileType, "comboBoxFileType");
            this.comboBoxFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFileType.FormattingEnabled = true;
            this.comboBoxFileType.Name = "comboBoxFileType";
            this.comboBoxFileType.SelectedIndexChanged += new System.EventHandler(this.comboBoxFileType_SelectedIndexChanged);
            // 
            // buttonSaveProfile
            // 
            resources.ApplyResources(this.buttonSaveProfile, "buttonSaveProfile");
            this.buttonSaveProfile.Name = "buttonSaveProfile";
            this.buttonSaveProfile.UseVisualStyleBackColor = true;
            this.buttonSaveProfile.Click += new System.EventHandler(this.buttonSaveProfile_Click);
            // 
            // labelFFmpegArguments
            // 
            resources.ApplyResources(this.labelFFmpegArguments, "labelFFmpegArguments");
            this.labelFFmpegArguments.Name = "labelFFmpegArguments";
            // 
            // labelOriginalFilePath
            // 
            resources.ApplyResources(this.labelOriginalFilePath, "labelOriginalFilePath");
            this.labelOriginalFilePath.Name = "labelOriginalFilePath";
            // 
            // textBoxOriginalFilePath
            // 
            resources.ApplyResources(this.textBoxOriginalFilePath, "textBoxOriginalFilePath");
            this.textBoxOriginalFilePath.Name = "textBoxOriginalFilePath";
            this.textBoxOriginalFilePath.ReadOnly = true;
            // 
            // textBoxFFmpegArguments
            // 
            resources.ApplyResources(this.textBoxFFmpegArguments, "textBoxFFmpegArguments");
            this.textBoxFFmpegArguments.Name = "textBoxFFmpegArguments";
            this.textBoxFFmpegArguments.TextChanged += new System.EventHandler(this.textBoxFFmpegArguments_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonEnqueue);
            this.flowLayoutPanel1.Controls.Add(this.buttonCancel);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // buttonEnqueue
            // 
            this.buttonEnqueue.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.buttonEnqueue, "buttonEnqueue");
            this.buttonEnqueue.Name = "buttonEnqueue";
            this.buttonEnqueue.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelExplanation
            // 
            this.labelExplanation.BackColor = System.Drawing.Color.LightYellow;
            resources.ApplyResources(this.labelExplanation, "labelExplanation");
            this.labelExplanation.Name = "labelExplanation";
            // 
            // FormAddTask
            // 
            this.AcceptButton = this.buttonEnqueue;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelExplanation);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddTask";
            this.ShowInTaskbar = false;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelOriginalFilePath;
        private System.Windows.Forms.TextBox textBoxOriginalFilePath;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Label labelFFmpegProfile;
        private System.Windows.Forms.ComboBox comboBoxFFmpegProfile;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonEnqueue;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFileType;
        // nitin added
        private System.Windows.Forms.ComboBox qualityType;
        private System.Windows.Forms.ComboBox stepType;
        private System.Windows.Forms.Label labelExplanation;
        private System.Windows.Forms.Button buttonSaveProfile;
        private System.Windows.Forms.Label labelFFmpegArguments;
        private System.Windows.Forms.TextBox textBoxOutputFilePath;
        private System.Windows.Forms.Label labelOutputFilePath;
        private System.Windows.Forms.TextBox textBoxFFmpegArguments;
    }
}