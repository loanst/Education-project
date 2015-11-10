namespace Shaft
{
    partial class Form_ShaftPparts
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
            this.btnAddElement = new System.Windows.Forms.Button();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.btnDeleteElement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLenghtOfShaft = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewShaftElements = new System.Windows.Forms.ListView();
            this.columnZero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWidth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStartEdgeType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStartEdgeTypeSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStartEdgeTypeSize2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStartEdgeTypeSize3Angle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEndEdgeType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEndEdgeTypeSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEndEdgeTypeSize2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEndEdgeTypeSize3Angle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnShaftCreate = new System.Windows.Forms.Button();
            this.comboBoxStartEdgeType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxStartEdgeSize = new System.Windows.Forms.ComboBox();
            this.comboBoxEndEdgeType = new System.Windows.Forms.ComboBox();
            this.comboBoxEndEdgeSize = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxStartEdgeSize2_Chamfer = new System.Windows.Forms.ComboBox();
            this.comboBoxEndEdgeSize2_Chamfer = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxStartAngle_Chamfer = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxEndAngle_Chamfer = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.radioButton_StandartMode = new System.Windows.Forms.RadioButton();
            this.radioButton_EditMode = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddElement
            // 
            this.btnAddElement.Location = new System.Drawing.Point(372, 277);
            this.btnAddElement.Name = "btnAddElement";
            this.btnAddElement.Size = new System.Drawing.Size(107, 23);
            this.btnAddElement.TabIndex = 3;
            this.btnAddElement.TabStop = false;
            this.btnAddElement.Text = "&Add element";
            this.btnAddElement.UseVisualStyleBackColor = true;
            this.btnAddElement.Click += new System.EventHandler(this.AddShaftElement);
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(98, 303);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(100, 20);
            this.tbWidth.TabIndex = 2;
            this.tbWidth.TabStop = false;
            this.tbWidth.Tag = "";
            this.tbWidth.TextChanged += new System.EventHandler(this.tbWidth_TextChanged);
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(98, 277);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(100, 20);
            this.tbHeight.TabIndex = 1;
            this.tbHeight.TabStop = false;
            // 
            // btnDeleteElement
            // 
            this.btnDeleteElement.Location = new System.Drawing.Point(485, 277);
            this.btnDeleteElement.Name = "btnDeleteElement";
            this.btnDeleteElement.Size = new System.Drawing.Size(107, 23);
            this.btnDeleteElement.TabIndex = 4;
            this.btnDeleteElement.TabStop = false;
            this.btnDeleteElement.Text = "&Remove element";
            this.btnDeleteElement.UseVisualStyleBackColor = true;
            this.btnDeleteElement.Click += new System.EventHandler(this.RemoveShaftElement);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(671, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total lenght of shaft:";
            // 
            // tbLenghtOfShaft
            // 
            this.tbLenghtOfShaft.Location = new System.Drawing.Point(781, 400);
            this.tbLenghtOfShaft.Name = "tbLenghtOfShaft";
            this.tbLenghtOfShaft.ReadOnly = true;
            this.tbLenghtOfShaft.Size = new System.Drawing.Size(100, 20);
            this.tbLenghtOfShaft.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Width:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Height (radius):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listViewShaftElements
            // 
            this.listViewShaftElements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnZero,
            this.columnHeight,
            this.columnWidth,
            this.columnStartEdgeType,
            this.columnStartEdgeTypeSize,
            this.columnStartEdgeTypeSize2,
            this.columnStartEdgeTypeSize3Angle,
            this.columnEndEdgeType,
            this.columnEndEdgeTypeSize,
            this.columnEndEdgeTypeSize2,
            this.columnEndEdgeTypeSize3Angle});
            this.listViewShaftElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewShaftElements.FullRowSelect = true;
            this.listViewShaftElements.GridLines = true;
            this.listViewShaftElements.HideSelection = false;
            this.listViewShaftElements.Location = new System.Drawing.Point(15, 12);
            this.listViewShaftElements.MultiSelect = false;
            this.listViewShaftElements.Name = "listViewShaftElements";
            this.listViewShaftElements.Size = new System.Drawing.Size(982, 259);
            this.listViewShaftElements.TabIndex = 9;
            this.listViewShaftElements.UseCompatibleStateImageBehavior = false;
            this.listViewShaftElements.View = System.Windows.Forms.View.Details;
            this.listViewShaftElements.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewShaftElements_ItemSelectionChanged);
            // 
            // columnZero
            // 
            this.columnZero.Width = 0;
            // 
            // columnHeight
            // 
            this.columnHeight.Text = "Height (radius)";
            this.columnHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeight.Width = 83;
            // 
            // columnWidth
            // 
            this.columnWidth.Text = "Width";
            this.columnWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnWidth.Width = 76;
            // 
            // columnStartEdgeType
            // 
            this.columnStartEdgeType.Text = "Start edge type";
            this.columnStartEdgeType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnStartEdgeType.Width = 86;
            // 
            // columnStartEdgeTypeSize
            // 
            this.columnStartEdgeTypeSize.Text = "Start size";
            this.columnStartEdgeTypeSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnStartEdgeTypeSize.Width = 74;
            // 
            // columnStartEdgeTypeSize2
            // 
            this.columnStartEdgeTypeSize2.Text = "Start Size 2 (Chamfer)";
            this.columnStartEdgeTypeSize2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnStartEdgeTypeSize2.Width = 123;
            // 
            // columnStartEdgeTypeSize3Angle
            // 
            this.columnStartEdgeTypeSize3Angle.Text = "Start Angle (Chamfer)";
            this.columnStartEdgeTypeSize3Angle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnStartEdgeTypeSize3Angle.Width = 117;
            // 
            // columnEndEdgeType
            // 
            this.columnEndEdgeType.Text = "End edge type";
            this.columnEndEdgeType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnEndEdgeType.Width = 86;
            // 
            // columnEndEdgeTypeSize
            // 
            this.columnEndEdgeTypeSize.Text = "End size";
            this.columnEndEdgeTypeSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnEndEdgeTypeSize.Width = 77;
            // 
            // columnEndEdgeTypeSize2
            // 
            this.columnEndEdgeTypeSize2.Text = "End Size 2 (Chamfer)";
            this.columnEndEdgeTypeSize2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnEndEdgeTypeSize2.Width = 116;
            // 
            // columnEndEdgeTypeSize3Angle
            // 
            this.columnEndEdgeTypeSize3Angle.Text = "End Angle (Chamfer)";
            this.columnEndEdgeTypeSize3Angle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnEndEdgeTypeSize3Angle.Width = 117;
            // 
            // btnShaftCreate
            // 
            this.btnShaftCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShaftCreate.Location = new System.Drawing.Point(890, 398);
            this.btnShaftCreate.Name = "btnShaftCreate";
            this.btnShaftCreate.Size = new System.Drawing.Size(107, 23);
            this.btnShaftCreate.TabIndex = 10;
            this.btnShaftCreate.Text = "Create 3d model";
            this.btnShaftCreate.UseVisualStyleBackColor = true;
            this.btnShaftCreate.Click += new System.EventHandler(this.CreateShaft3dmodel);
            // 
            // comboBoxStartEdgeType
            // 
            this.comboBoxStartEdgeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStartEdgeType.FormattingEnabled = true;
            this.comboBoxStartEdgeType.Items.AddRange(new object[] {
            "Standart",
            "Fillet",
            "Chamfer (Distance)",
            "Chamfer (Distance And Angle)",
            "Chamfer (Two Distances)"});
            this.comboBoxStartEdgeType.Location = new System.Drawing.Point(97, 349);
            this.comboBoxStartEdgeType.Name = "comboBoxStartEdgeType";
            this.comboBoxStartEdgeType.Size = new System.Drawing.Size(170, 21);
            this.comboBoxStartEdgeType.TabIndex = 11;
            this.comboBoxStartEdgeType.SelectedIndexChanged += new System.EventHandler(this.comboBoxStartEdgeType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(12, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Start edge type:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Start size";
            // 
            // comboBoxStartEdgeSize
            // 
            this.comboBoxStartEdgeSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStartEdgeSize.FormattingEnabled = true;
            this.comboBoxStartEdgeSize.Items.AddRange(new object[] {
            "0,1",
            "0,2",
            "0,3",
            "0,4",
            "0,5"});
            this.comboBoxStartEdgeSize.Location = new System.Drawing.Point(273, 349);
            this.comboBoxStartEdgeSize.Name = "comboBoxStartEdgeSize";
            this.comboBoxStartEdgeSize.Size = new System.Drawing.Size(100, 21);
            this.comboBoxStartEdgeSize.TabIndex = 15;
            // 
            // comboBoxEndEdgeType
            // 
            this.comboBoxEndEdgeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEndEdgeType.FormattingEnabled = true;
            this.comboBoxEndEdgeType.Items.AddRange(new object[] {
            "Standart",
            "Fillet",
            "Chamfer (Distance)",
            "Chamfer (Distance And Angle)",
            "Chamfer (Two Distances)"});
            this.comboBoxEndEdgeType.Location = new System.Drawing.Point(97, 404);
            this.comboBoxEndEdgeType.Name = "comboBoxEndEdgeType";
            this.comboBoxEndEdgeType.Size = new System.Drawing.Size(170, 21);
            this.comboBoxEndEdgeType.TabIndex = 16;
            this.comboBoxEndEdgeType.SelectedIndexChanged += new System.EventHandler(this.comboBoxEndEdgeType_SelectedIndexChanged);
            // 
            // comboBoxEndEdgeSize
            // 
            this.comboBoxEndEdgeSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEndEdgeSize.FormattingEnabled = true;
            this.comboBoxEndEdgeSize.Items.AddRange(new object[] {
            "0,1",
            "0,2",
            "0,3",
            "0,4",
            "0,5"});
            this.comboBoxEndEdgeSize.Location = new System.Drawing.Point(273, 404);
            this.comboBoxEndEdgeSize.Name = "comboBoxEndEdgeSize";
            this.comboBoxEndEdgeSize.Size = new System.Drawing.Size(100, 21);
            this.comboBoxEndEdgeSize.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "End edge type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "End size";
            // 
            // comboBoxStartEdgeSize2_Chamfer
            // 
            this.comboBoxStartEdgeSize2_Chamfer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStartEdgeSize2_Chamfer.FormattingEnabled = true;
            this.comboBoxStartEdgeSize2_Chamfer.Items.AddRange(new object[] {
            "0,1",
            "0,2",
            "0,3",
            "0,4",
            "0,5"});
            this.comboBoxStartEdgeSize2_Chamfer.Location = new System.Drawing.Point(379, 349);
            this.comboBoxStartEdgeSize2_Chamfer.Name = "comboBoxStartEdgeSize2_Chamfer";
            this.comboBoxStartEdgeSize2_Chamfer.Size = new System.Drawing.Size(100, 21);
            this.comboBoxStartEdgeSize2_Chamfer.TabIndex = 20;
            // 
            // comboBoxEndEdgeSize2_Chamfer
            // 
            this.comboBoxEndEdgeSize2_Chamfer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEndEdgeSize2_Chamfer.FormattingEnabled = true;
            this.comboBoxEndEdgeSize2_Chamfer.Items.AddRange(new object[] {
            "0,1",
            "0,2",
            "0,3",
            "0,4",
            "0,5"});
            this.comboBoxEndEdgeSize2_Chamfer.Location = new System.Drawing.Point(379, 404);
            this.comboBoxEndEdgeSize2_Chamfer.Name = "comboBoxEndEdgeSize2_Chamfer";
            this.comboBoxEndEdgeSize2_Chamfer.Size = new System.Drawing.Size(100, 21);
            this.comboBoxEndEdgeSize2_Chamfer.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Start Size 2 (Chamfer)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "End Size 2 (Chamfer)";
            // 
            // comboBoxStartAngle_Chamfer
            // 
            this.comboBoxStartAngle_Chamfer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStartAngle_Chamfer.FormattingEnabled = true;
            this.comboBoxStartAngle_Chamfer.Items.AddRange(new object[] {
            "0,1",
            "0,2",
            "0,3",
            "0,4",
            "0,5",
            "0,6",
            "0,7"});
            this.comboBoxStartAngle_Chamfer.Location = new System.Drawing.Point(494, 349);
            this.comboBoxStartAngle_Chamfer.Name = "comboBoxStartAngle_Chamfer";
            this.comboBoxStartAngle_Chamfer.Size = new System.Drawing.Size(100, 21);
            this.comboBoxStartAngle_Chamfer.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(491, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Start Angle (Chamfer)";
            // 
            // comboBoxEndAngle_Chamfer
            // 
            this.comboBoxEndAngle_Chamfer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEndAngle_Chamfer.FormattingEnabled = true;
            this.comboBoxEndAngle_Chamfer.Items.AddRange(new object[] {
            "0,1",
            "0,2",
            "0,3",
            "0,4",
            "0,5",
            "0,6",
            "0,7"});
            this.comboBoxEndAngle_Chamfer.Location = new System.Drawing.Point(494, 403);
            this.comboBoxEndAngle_Chamfer.Name = "comboBoxEndAngle_Chamfer";
            this.comboBoxEndAngle_Chamfer.Size = new System.Drawing.Size(100, 21);
            this.comboBoxEndAngle_Chamfer.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(491, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "End Angle (Chamfer)";
            // 
            // radioButton_StandartMode
            // 
            this.radioButton_StandartMode.AutoSize = true;
            this.radioButton_StandartMode.Checked = true;
            this.radioButton_StandartMode.Location = new System.Drawing.Point(6, 19);
            this.radioButton_StandartMode.Name = "radioButton_StandartMode";
            this.radioButton_StandartMode.Size = new System.Drawing.Size(94, 17);
            this.radioButton_StandartMode.TabIndex = 27;
            this.radioButton_StandartMode.TabStop = true;
            this.radioButton_StandartMode.Text = "Standart mode";
            this.radioButton_StandartMode.UseVisualStyleBackColor = true;
            this.radioButton_StandartMode.CheckedChanged += new System.EventHandler(this.radioButton_StandartMode_CheckedChanged);
            // 
            // radioButton_EditMode
            // 
            this.radioButton_EditMode.AutoSize = true;
            this.radioButton_EditMode.Location = new System.Drawing.Point(6, 42);
            this.radioButton_EditMode.Name = "radioButton_EditMode";
            this.radioButton_EditMode.Size = new System.Drawing.Size(72, 17);
            this.radioButton_EditMode.TabIndex = 28;
            this.radioButton_EditMode.Text = "Edit mode";
            this.radioButton_EditMode.UseVisualStyleBackColor = true;
            this.radioButton_EditMode.CheckedChanged += new System.EventHandler(this.radioButton_EditMode_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_EditMode);
            this.groupBox1.Controls.Add(this.radioButton_StandartMode);
            this.groupBox1.Location = new System.Drawing.Point(887, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 63);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input mode";
            // 
            // Form_ShaftPparts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxEndAngle_Chamfer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxStartAngle_Chamfer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxEndEdgeSize2_Chamfer);
            this.Controls.Add(this.comboBoxStartEdgeSize2_Chamfer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxEndEdgeSize);
            this.Controls.Add(this.comboBoxEndEdgeType);
            this.Controls.Add(this.comboBoxStartEdgeSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxStartEdgeType);
            this.Controls.Add(this.btnShaftCreate);
            this.Controls.Add(this.listViewShaftElements);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLenghtOfShaft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteElement);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.btnAddElement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_ShaftPparts";
            this.Text = "Shaft parts";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddElement;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Button btnDeleteElement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLenghtOfShaft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewShaftElements;
        private System.Windows.Forms.ColumnHeader columnWidth;
        private System.Windows.Forms.ColumnHeader columnHeight;
        private System.Windows.Forms.Button btnShaftCreate;
        private System.Windows.Forms.ComboBox comboBoxStartEdgeType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxStartEdgeSize;
        private System.Windows.Forms.ColumnHeader columnStartEdgeType;
        private System.Windows.Forms.ColumnHeader columnStartEdgeTypeSize;
        private System.Windows.Forms.ComboBox comboBoxEndEdgeType;
        private System.Windows.Forms.ComboBox comboBoxEndEdgeSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnEndEdgeType;
        private System.Windows.Forms.ColumnHeader columnEndEdgeTypeSize;
        private System.Windows.Forms.ComboBox comboBoxStartEdgeSize2_Chamfer;
        private System.Windows.Forms.ComboBox comboBoxEndEdgeSize2_Chamfer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader columnStartEdgeTypeSize2;
        private System.Windows.Forms.ColumnHeader columnStartEdgeTypeSize3Angle;
        private System.Windows.Forms.ColumnHeader columnEndEdgeTypeSize2;
        private System.Windows.Forms.ColumnHeader columnEndEdgeTypeSize3Angle;
        private System.Windows.Forms.ComboBox comboBoxStartAngle_Chamfer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxEndAngle_Chamfer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColumnHeader columnZero;
        private System.Windows.Forms.RadioButton radioButton_StandartMode;
        private System.Windows.Forms.RadioButton radioButton_EditMode;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

