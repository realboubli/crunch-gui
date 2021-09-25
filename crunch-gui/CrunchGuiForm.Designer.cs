namespace Crunch_GUI
{
    partial class CrunchGuiForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrunchGuiForm));
            this.xmlOption = new System.Windows.Forms.CheckBox();
            this.saveOptions = new System.Windows.Forms.GroupBox();
            this.jsonOption = new System.Windows.Forms.CheckBox();
            this.binOption = new System.Windows.Forms.CheckBox();
            this.imagesProcessingOptions = new System.Windows.Forms.GroupBox();
            this.paddingOption = new System.Windows.Forms.CheckBox();
            this.paddingInput = new System.Windows.Forms.NumericUpDown();
            this.maxAtlasOption = new System.Windows.Forms.CheckBox();
            this.maxAtlasComboBox = new System.Windows.Forms.ComboBox();
            this.rotateOption = new System.Windows.Forms.CheckBox();
            this.uniqueOption = new System.Windows.Forms.CheckBox();
            this.trimOption = new System.Windows.Forms.CheckBox();
            this.premultiplyOption = new System.Windows.Forms.CheckBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.addImageButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addFolderButton = new System.Windows.Forms.Button();
            this.packButton = new System.Windows.Forms.Button();
            this.saveConfigButton = new System.Windows.Forms.Button();
            this.loadConfigButton = new System.Windows.Forms.Button();
            this.rePackButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.sourcesLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.chooseOutputButton = new System.Windows.Forms.Button();
            this.createBatButton = new System.Windows.Forms.Button();
            this.sourcesList = new System.Windows.Forms.ListView();
            this.saveOptions.SuspendLayout();
            this.imagesProcessingOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paddingInput)).BeginInit();
            this.SuspendLayout();
            // 
            // xmlOption
            // 
            this.xmlOption.AutoSize = true;
            this.xmlOption.Checked = true;
            this.xmlOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xmlOption.Location = new System.Drawing.Point(6, 22);
            this.xmlOption.Name = "xmlOption";
            this.xmlOption.Size = new System.Drawing.Size(49, 19);
            this.xmlOption.TabIndex = 0;
            this.xmlOption.Text = ".xml";
            this.ToolTip.SetToolTip(this.xmlOption, "Saves the atlas data as a .xml file");
            this.xmlOption.UseVisualStyleBackColor = true;
            // 
            // saveOptions
            // 
            this.saveOptions.AutoSize = true;
            this.saveOptions.Controls.Add(this.jsonOption);
            this.saveOptions.Controls.Add(this.binOption);
            this.saveOptions.Controls.Add(this.xmlOption);
            this.saveOptions.Location = new System.Drawing.Point(440, 12);
            this.saveOptions.Name = "saveOptions";
            this.saveOptions.Size = new System.Drawing.Size(162, 113);
            this.saveOptions.TabIndex = 1;
            this.saveOptions.TabStop = false;
            this.saveOptions.Text = "Save Options";
            // 
            // jsonOption
            // 
            this.jsonOption.AutoSize = true;
            this.jsonOption.Location = new System.Drawing.Point(6, 72);
            this.jsonOption.Name = "jsonOption";
            this.jsonOption.Size = new System.Drawing.Size(51, 19);
            this.jsonOption.TabIndex = 2;
            this.jsonOption.Text = ".json";
            this.ToolTip.SetToolTip(this.jsonOption, "Saves the atlas data as a .json file");
            this.jsonOption.UseVisualStyleBackColor = true;
            // 
            // binOption
            // 
            this.binOption.AutoSize = true;
            this.binOption.Location = new System.Drawing.Point(6, 47);
            this.binOption.Name = "binOption";
            this.binOption.Size = new System.Drawing.Size(46, 19);
            this.binOption.TabIndex = 1;
            this.binOption.Text = ".bin";
            this.ToolTip.SetToolTip(this.binOption, "Saves the atlas data as a .bin file");
            this.binOption.UseVisualStyleBackColor = true;
            // 
            // imagesProcessingOptions
            // 
            this.imagesProcessingOptions.AutoSize = true;
            this.imagesProcessingOptions.Controls.Add(this.paddingOption);
            this.imagesProcessingOptions.Controls.Add(this.paddingInput);
            this.imagesProcessingOptions.Controls.Add(this.maxAtlasOption);
            this.imagesProcessingOptions.Controls.Add(this.maxAtlasComboBox);
            this.imagesProcessingOptions.Controls.Add(this.rotateOption);
            this.imagesProcessingOptions.Controls.Add(this.uniqueOption);
            this.imagesProcessingOptions.Controls.Add(this.trimOption);
            this.imagesProcessingOptions.Controls.Add(this.premultiplyOption);
            this.imagesProcessingOptions.Location = new System.Drawing.Point(440, 131);
            this.imagesProcessingOptions.Name = "imagesProcessingOptions";
            this.imagesProcessingOptions.Size = new System.Drawing.Size(162, 246);
            this.imagesProcessingOptions.TabIndex = 2;
            this.imagesProcessingOptions.TabStop = false;
            this.imagesProcessingOptions.Text = "Images processing options";
            // 
            // paddingOption
            // 
            this.paddingOption.AutoSize = true;
            this.paddingOption.Checked = true;
            this.paddingOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.paddingOption.Location = new System.Drawing.Point(5, 122);
            this.paddingOption.Name = "paddingOption";
            this.paddingOption.Size = new System.Drawing.Size(70, 19);
            this.paddingOption.TabIndex = 7;
            this.paddingOption.Text = "Padding";
            this.ToolTip.SetToolTip(this.paddingOption, "Padding between images (can be from 0 to 16)");
            this.paddingOption.UseVisualStyleBackColor = true;
            this.paddingOption.CheckedChanged += new System.EventHandler(this.paddingOption_CheckedChanged);
            // 
            // paddingInput
            // 
            this.paddingInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paddingInput.Location = new System.Drawing.Point(6, 147);
            this.paddingInput.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.paddingInput.Name = "paddingInput";
            this.paddingInput.Size = new System.Drawing.Size(98, 23);
            this.paddingInput.TabIndex = 3;
            this.ToolTip.SetToolTip(this.paddingInput, "Padding between images (can be from 0 to 16)");
            // 
            // maxAtlasOption
            // 
            this.maxAtlasOption.AutoSize = true;
            this.maxAtlasOption.Location = new System.Drawing.Point(5, 176);
            this.maxAtlasOption.Name = "maxAtlasOption";
            this.maxAtlasOption.Size = new System.Drawing.Size(98, 19);
            this.maxAtlasOption.TabIndex = 6;
            this.maxAtlasOption.Text = "Max atlas size";
            this.ToolTip.SetToolTip(this.maxAtlasOption, "Max atlas size (can be 4096, 2048, 1024, 512, 256, 128, or 64)");
            this.maxAtlasOption.UseVisualStyleBackColor = true;
            this.maxAtlasOption.CheckedChanged += new System.EventHandler(this.maxAtlasOption_CheckedChanged);
            // 
            // maxAtlasComboBox
            // 
            this.maxAtlasComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.maxAtlasComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.maxAtlasComboBox.Enabled = false;
            this.maxAtlasComboBox.FormattingEnabled = true;
            this.maxAtlasComboBox.Items.AddRange(new object[] {
            "4096",
            "2048",
            "1024",
            "512",
            "256",
            "128",
            "64"});
            this.maxAtlasComboBox.Location = new System.Drawing.Point(6, 201);
            this.maxAtlasComboBox.Name = "maxAtlasComboBox";
            this.maxAtlasComboBox.Size = new System.Drawing.Size(98, 23);
            this.maxAtlasComboBox.TabIndex = 5;
            this.maxAtlasComboBox.Text = "Select a size";
            this.ToolTip.SetToolTip(this.maxAtlasComboBox, "Max atlas size (can be 4096, 2048, 1024, 512, 256, 128, or 64)");
            // 
            // rotateOption
            // 
            this.rotateOption.AutoSize = true;
            this.rotateOption.Location = new System.Drawing.Point(6, 97);
            this.rotateOption.Name = "rotateOption";
            this.rotateOption.Size = new System.Drawing.Size(60, 19);
            this.rotateOption.TabIndex = 3;
            this.rotateOption.Text = "Rotate";
            this.ToolTip.SetToolTip(this.rotateOption, "Enable rotating bitmaps 90 degrees clockwise when packing");
            this.rotateOption.UseVisualStyleBackColor = true;
            // 
            // uniqueOption
            // 
            this.uniqueOption.AutoSize = true;
            this.uniqueOption.Checked = true;
            this.uniqueOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uniqueOption.Location = new System.Drawing.Point(6, 72);
            this.uniqueOption.Name = "uniqueOption";
            this.uniqueOption.Size = new System.Drawing.Size(64, 19);
            this.uniqueOption.TabIndex = 2;
            this.uniqueOption.Text = "Unique";
            this.ToolTip.SetToolTip(this.uniqueOption, "Remove duplicate bitmaps from the atlas");
            this.uniqueOption.UseVisualStyleBackColor = true;
            // 
            // trimOption
            // 
            this.trimOption.AutoSize = true;
            this.trimOption.Checked = true;
            this.trimOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trimOption.Location = new System.Drawing.Point(6, 47);
            this.trimOption.Name = "trimOption";
            this.trimOption.Size = new System.Drawing.Size(49, 19);
            this.trimOption.TabIndex = 1;
            this.trimOption.Text = "Trim";
            this.ToolTip.SetToolTip(this.trimOption, "Trims excess transparency off the bitmaps");
            this.trimOption.UseVisualStyleBackColor = true;
            // 
            // premultiplyOption
            // 
            this.premultiplyOption.AutoSize = true;
            this.premultiplyOption.Checked = true;
            this.premultiplyOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.premultiplyOption.Location = new System.Drawing.Point(6, 22);
            this.premultiplyOption.Name = "premultiplyOption";
            this.premultiplyOption.Size = new System.Drawing.Size(87, 19);
            this.premultiplyOption.TabIndex = 0;
            this.premultiplyOption.Text = "Premultiply";
            this.ToolTip.SetToolTip(this.premultiplyOption, "Premultiplies the pixels of the bitmaps by their alpha channel");
            this.premultiplyOption.UseVisualStyleBackColor = true;
            // 
            // addImageButton
            // 
            this.addImageButton.Location = new System.Drawing.Point(12, 411);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(75, 23);
            this.addImageButton.TabIndex = 4;
            this.addImageButton.Text = "Add image";
            this.ToolTip.SetToolTip(this.addImageButton, "Add an image to the sources");
            this.addImageButton.UseVisualStyleBackColor = true;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(174, 411);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.ToolTip.SetToolTip(this.deleteButton, "Delete the selected sources");
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addFolderButton
            // 
            this.addFolderButton.Location = new System.Drawing.Point(93, 411);
            this.addFolderButton.Name = "addFolderButton";
            this.addFolderButton.Size = new System.Drawing.Size(75, 23);
            this.addFolderButton.TabIndex = 6;
            this.addFolderButton.Text = "Add folder";
            this.ToolTip.SetToolTip(this.addFolderButton, "Add a folder to the sources");
            this.addFolderButton.UseVisualStyleBackColor = true;
            this.addFolderButton.Click += new System.EventHandler(this.addFolder_Click);
            // 
            // packButton
            // 
            this.packButton.Location = new System.Drawing.Point(527, 411);
            this.packButton.Name = "packButton";
            this.packButton.Size = new System.Drawing.Size(75, 23);
            this.packButton.TabIndex = 7;
            this.packButton.Text = "Pack";
            this.ToolTip.SetToolTip(this.packButton, "Pack the sources with the selected options to the choosen output");
            this.packButton.UseVisualStyleBackColor = true;
            this.packButton.Click += new System.EventHandler(this.packButton_Click);
            // 
            // saveConfigButton
            // 
            this.saveConfigButton.Location = new System.Drawing.Point(255, 411);
            this.saveConfigButton.Name = "saveConfigButton";
            this.saveConfigButton.Size = new System.Drawing.Size(87, 23);
            this.saveConfigButton.TabIndex = 8;
            this.saveConfigButton.Text = "Save config";
            this.ToolTip.SetToolTip(this.saveConfigButton, "Save a config file");
            this.saveConfigButton.UseVisualStyleBackColor = true;
            this.saveConfigButton.Click += new System.EventHandler(this.saveConfigButton_Click);
            // 
            // loadConfigButton
            // 
            this.loadConfigButton.Location = new System.Drawing.Point(348, 411);
            this.loadConfigButton.Name = "loadConfigButton";
            this.loadConfigButton.Size = new System.Drawing.Size(80, 23);
            this.loadConfigButton.TabIndex = 9;
            this.loadConfigButton.Text = "Load config";
            this.ToolTip.SetToolTip(this.loadConfigButton, "Load a config file");
            this.loadConfigButton.UseVisualStyleBackColor = true;
            this.loadConfigButton.Click += new System.EventHandler(this.loadConfigButton_Click);
            // 
            // rePackButton
            // 
            this.rePackButton.Location = new System.Drawing.Point(440, 411);
            this.rePackButton.Name = "rePackButton";
            this.rePackButton.Size = new System.Drawing.Size(75, 23);
            this.rePackButton.TabIndex = 10;
            this.rePackButton.Text = "Re-Pack";
            this.ToolTip.SetToolTip(this.rePackButton, "Ignore caching, forcing the packer to repack");
            this.rePackButton.UseVisualStyleBackColor = true;
            this.rePackButton.Click += new System.EventHandler(this.rePackButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(440, 382);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.ToolTip.SetToolTip(this.resetButton, "Reset options, output and sources to default");
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // sourcesLabel
            // 
            this.sourcesLabel.AutoSize = true;
            this.sourcesLabel.Location = new System.Drawing.Point(12, 41);
            this.sourcesLabel.Name = "sourcesLabel";
            this.sourcesLabel.Size = new System.Drawing.Size(48, 15);
            this.sourcesLabel.TabIndex = 12;
            this.sourcesLabel.Text = "Sources";
            this.ToolTip.SetToolTip(this.sourcesLabel, "The images and folders to pack");
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(63, 12);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(258, 23);
            this.outputTextBox.TabIndex = 13;
            this.ToolTip.SetToolTip(this.outputTextBox, "Where the packed image will be stored");
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(12, 15);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(45, 15);
            this.outputLabel.TabIndex = 14;
            this.outputLabel.Text = "Output";
            this.ToolTip.SetToolTip(this.outputLabel, "Where the packed image will be stored");
            // 
            // chooseOutputButton
            // 
            this.chooseOutputButton.Location = new System.Drawing.Point(327, 12);
            this.chooseOutputButton.Name = "chooseOutputButton";
            this.chooseOutputButton.Size = new System.Drawing.Size(101, 23);
            this.chooseOutputButton.TabIndex = 15;
            this.chooseOutputButton.Text = "Choose output";
            this.ToolTip.SetToolTip(this.chooseOutputButton, "Choose where the packed image will be stored");
            this.chooseOutputButton.UseVisualStyleBackColor = true;
            this.chooseOutputButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // createBatButton
            // 
            this.createBatButton.Location = new System.Drawing.Point(527, 382);
            this.createBatButton.Name = "createBatButton";
            this.createBatButton.Size = new System.Drawing.Size(75, 23);
            this.createBatButton.TabIndex = 16;
            this.createBatButton.Text = "Create .bat";
            this.ToolTip.SetToolTip(this.createBatButton, "Create a batch file with full paths to use in a build script");
            this.createBatButton.UseVisualStyleBackColor = true;
            this.createBatButton.Click += new System.EventHandler(this.createBatButton_Click);
            // 
            // sourcesList
            // 
            this.sourcesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourcesList.HideSelection = false;
            this.sourcesList.Location = new System.Drawing.Point(12, 59);
            this.sourcesList.Name = "sourcesList";
            this.sourcesList.Size = new System.Drawing.Size(416, 346);
            this.sourcesList.TabIndex = 3;
            this.sourcesList.UseCompatibleStateImageBehavior = false;
            this.sourcesList.View = System.Windows.Forms.View.List;
            // 
            // CrunchGuiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 446);
            this.Controls.Add(this.createBatButton);
            this.Controls.Add(this.chooseOutputButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.sourcesLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.rePackButton);
            this.Controls.Add(this.loadConfigButton);
            this.Controls.Add(this.saveConfigButton);
            this.Controls.Add(this.packButton);
            this.Controls.Add(this.addFolderButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.sourcesList);
            this.Controls.Add(this.imagesProcessingOptions);
            this.Controls.Add(this.saveOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CrunchGuiForm";
            this.Text = "crunch-gui";
            this.saveOptions.ResumeLayout(false);
            this.saveOptions.PerformLayout();
            this.imagesProcessingOptions.ResumeLayout(false);
            this.imagesProcessingOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paddingInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox xmlOption;
        private System.Windows.Forms.GroupBox saveOptions;
        private System.Windows.Forms.CheckBox jsonOption;
        private System.Windows.Forms.CheckBox binOption;
        private System.Windows.Forms.GroupBox imagesProcessingOptions;
        private System.Windows.Forms.CheckBox premultiplyOption;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.CheckBox trimOption;
        private System.Windows.Forms.CheckBox uniqueOption;
        private System.Windows.Forms.NumericUpDown paddingInput;
        private System.Windows.Forms.CheckBox rotateOption;
        private System.Windows.Forms.ComboBox maxAtlasComboBox;
        private System.Windows.Forms.CheckBox maxAtlasOption;
        private System.Windows.Forms.CheckBox paddingOption;
        private System.Windows.Forms.ListView sourcesList;
        private System.Windows.Forms.Button addImageButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addFolderButton;
        private System.Windows.Forms.Button packButton;
        private System.Windows.Forms.Button saveConfigButton;
        private System.Windows.Forms.Button loadConfigButton;
        private System.Windows.Forms.Button rePackButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label sourcesLabel;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button chooseOutputButton;
        private System.Windows.Forms.Button createBatButton;
    }
}

