namespace SortingAlgorithms_WinForm
{
    partial class Form1
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
            this.browseButton = new System.Windows.Forms.Button();
            this.dataFileLabel = new System.Windows.Forms.Label();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sortTypeGroup = new System.Windows.Forms.GroupBox();
            this.radixSort = new System.Windows.Forms.RadioButton();
            this.bubbleSort = new System.Windows.Forms.RadioButton();
            this.bucketSort = new System.Windows.Forms.RadioButton();
            this.shellSort = new System.Windows.Forms.RadioButton();
            this.heapSort = new System.Windows.Forms.RadioButton();
            this.quickSort = new System.Windows.Forms.RadioButton();
            this.mergeSort = new System.Windows.Forms.RadioButton();
            this.insertionSort = new System.Windows.Forms.RadioButton();
            this.generateCheckBox = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.runBtn = new System.Windows.Forms.Button();
            this.dataTypeGroup = new System.Windows.Forms.GroupBox();
            this.LinkedListRadio = new System.Windows.Forms.RadioButton();
            this.ListRadio = new System.Windows.Forms.RadioButton();
            this.ArrayRadio = new System.Windows.Forms.RadioButton();
            this.ammountGroup = new System.Windows.Forms.GroupBox();
            this.otherRadio = new System.Windows.Forms.RadioButton();
            this.millionRadio = new System.Windows.Forms.RadioButton();
            this.hundredThousandRadio = new System.Windows.Forms.RadioButton();
            this.tenThousandRadio = new System.Windows.Forms.RadioButton();
            this.thousandRadio = new System.Windows.Forms.RadioButton();
            this.hundredRadio = new System.Windows.Forms.RadioButton();
            this.tenRadio = new System.Windows.Forms.RadioButton();
            this.otherAmtText = new System.Windows.Forms.TextBox();
            this.sortTypeGroup.SuspendLayout();
            this.dataTypeGroup.SuspendLayout();
            this.ammountGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(306, 32);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(32, 29);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // dataFileLabel
            // 
            this.dataFileLabel.AutoSize = true;
            this.dataFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFileLabel.Location = new System.Drawing.Point(12, 12);
            this.dataFileLabel.MinimumSize = new System.Drawing.Size(50, 15);
            this.dataFileLabel.Name = "dataFileLabel";
            this.dataFileLabel.Size = new System.Drawing.Size(77, 20);
            this.dataFileLabel.TabIndex = 2;
            this.dataFileLabel.Text = "Data File:";
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathTextBox.Location = new System.Drawing.Point(16, 35);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(284, 26);
            this.filePathTextBox.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // sortTypeGroup
            // 
            this.sortTypeGroup.Controls.Add(this.radixSort);
            this.sortTypeGroup.Controls.Add(this.bubbleSort);
            this.sortTypeGroup.Controls.Add(this.bucketSort);
            this.sortTypeGroup.Controls.Add(this.shellSort);
            this.sortTypeGroup.Controls.Add(this.heapSort);
            this.sortTypeGroup.Controls.Add(this.quickSort);
            this.sortTypeGroup.Controls.Add(this.mergeSort);
            this.sortTypeGroup.Controls.Add(this.insertionSort);
            this.sortTypeGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortTypeGroup.Location = new System.Drawing.Point(16, 98);
            this.sortTypeGroup.Name = "sortTypeGroup";
            this.sortTypeGroup.Size = new System.Drawing.Size(284, 100);
            this.sortTypeGroup.TabIndex = 5;
            this.sortTypeGroup.TabStop = false;
            this.sortTypeGroup.Text = "Sort Type";
            // 
            // radixSort
            // 
            this.radixSort.AutoSize = true;
            this.radixSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radixSort.Location = new System.Drawing.Point(194, 77);
            this.radixSort.Name = "radixSort";
            this.radixSort.Size = new System.Drawing.Size(61, 20);
            this.radixSort.TabIndex = 7;
            this.radixSort.Text = "Radix";
            this.radixSort.UseVisualStyleBackColor = true;
            this.radixSort.Visible = false;
            // 
            // bubbleSort
            // 
            this.bubbleSort.AutoSize = true;
            this.bubbleSort.Checked = true;
            this.bubbleSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubbleSort.Location = new System.Drawing.Point(194, 19);
            this.bubbleSort.Name = "bubbleSort";
            this.bubbleSort.Size = new System.Drawing.Size(69, 20);
            this.bubbleSort.TabIndex = 2;
            this.bubbleSort.TabStop = true;
            this.bubbleSort.Text = "Bubble";
            this.bubbleSort.UseVisualStyleBackColor = true;
            // 
            // bucketSort
            // 
            this.bucketSort.AutoSize = true;
            this.bucketSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bucketSort.Location = new System.Drawing.Point(103, 77);
            this.bucketSort.Name = "bucketSort";
            this.bucketSort.Size = new System.Drawing.Size(67, 20);
            this.bucketSort.TabIndex = 5;
            this.bucketSort.Text = "Bucket";
            this.bucketSort.UseVisualStyleBackColor = true;
            this.bucketSort.Visible = false;
            // 
            // shellSort
            // 
            this.shellSort.AutoSize = true;
            this.shellSort.Enabled = false;
            this.shellSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shellSort.Location = new System.Drawing.Point(103, 49);
            this.shellSort.Name = "shellSort";
            this.shellSort.Size = new System.Drawing.Size(56, 20);
            this.shellSort.TabIndex = 4;
            this.shellSort.Text = "Shell";
            this.shellSort.UseVisualStyleBackColor = true;
            this.shellSort.Visible = false;
            // 
            // heapSort
            // 
            this.heapSort.AutoSize = true;
            this.heapSort.Enabled = false;
            this.heapSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heapSort.Location = new System.Drawing.Point(7, 74);
            this.heapSort.Name = "heapSort";
            this.heapSort.Size = new System.Drawing.Size(60, 20);
            this.heapSort.TabIndex = 3;
            this.heapSort.Text = "Heap";
            this.heapSort.UseVisualStyleBackColor = true;
            this.heapSort.Visible = false;
            // 
            // quickSort
            // 
            this.quickSort.AutoSize = true;
            this.quickSort.Enabled = false;
            this.quickSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickSort.Location = new System.Drawing.Point(7, 49);
            this.quickSort.Name = "quickSort";
            this.quickSort.Size = new System.Drawing.Size(60, 20);
            this.quickSort.TabIndex = 3;
            this.quickSort.Text = "Quick";
            this.quickSort.UseVisualStyleBackColor = true;
            this.quickSort.Visible = false;
            // 
            // mergeSort
            // 
            this.mergeSort.AutoSize = true;
            this.mergeSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mergeSort.Location = new System.Drawing.Point(103, 19);
            this.mergeSort.Name = "mergeSort";
            this.mergeSort.Size = new System.Drawing.Size(65, 20);
            this.mergeSort.TabIndex = 1;
            this.mergeSort.Text = "Merge";
            this.mergeSort.UseVisualStyleBackColor = true;
            // 
            // insertionSort
            // 
            this.insertionSort.AutoSize = true;
            this.insertionSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertionSort.Location = new System.Drawing.Point(7, 20);
            this.insertionSort.Name = "insertionSort";
            this.insertionSort.Size = new System.Drawing.Size(76, 20);
            this.insertionSort.TabIndex = 0;
            this.insertionSort.Text = "Insertion";
            this.insertionSort.UseVisualStyleBackColor = true;
            // 
            // generateCheckBox
            // 
            this.generateCheckBox.AutoSize = true;
            this.generateCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateCheckBox.Location = new System.Drawing.Point(147, 12);
            this.generateCheckBox.Name = "generateCheckBox";
            this.generateCheckBox.Size = new System.Drawing.Size(153, 20);
            this.generateCheckBox.TabIndex = 6;
            this.generateCheckBox.Text = "Generate data in app";
            this.generateCheckBox.UseVisualStyleBackColor = true;
            this.generateCheckBox.CheckedChanged += new System.EventHandler(this.GenerateCheckBox_CheckedChanged);
            // 
            // runBtn
            // 
            this.runBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runBtn.Location = new System.Drawing.Point(36, 484);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(150, 63);
            this.runBtn.TabIndex = 7;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // dataTypeGroup
            // 
            this.dataTypeGroup.Controls.Add(this.LinkedListRadio);
            this.dataTypeGroup.Controls.Add(this.ListRadio);
            this.dataTypeGroup.Controls.Add(this.ArrayRadio);
            this.dataTypeGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTypeGroup.Location = new System.Drawing.Point(16, 218);
            this.dataTypeGroup.Name = "dataTypeGroup";
            this.dataTypeGroup.Size = new System.Drawing.Size(168, 107);
            this.dataTypeGroup.TabIndex = 8;
            this.dataTypeGroup.TabStop = false;
            this.dataTypeGroup.Text = "Type of Data";
            // 
            // LinkedListRadio
            // 
            this.LinkedListRadio.AutoSize = true;
            this.LinkedListRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkedListRadio.Location = new System.Drawing.Point(7, 77);
            this.LinkedListRadio.Name = "LinkedListRadio";
            this.LinkedListRadio.Size = new System.Drawing.Size(135, 20);
            this.LinkedListRadio.TabIndex = 2;
            this.LinkedListRadio.Text = "Doubly Linked List";
            this.LinkedListRadio.UseVisualStyleBackColor = true;
            // 
            // ListRadio
            // 
            this.ListRadio.AutoSize = true;
            this.ListRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListRadio.Location = new System.Drawing.Point(7, 51);
            this.ListRadio.Name = "ListRadio";
            this.ListRadio.Size = new System.Drawing.Size(130, 20);
            this.ListRadio.TabIndex = 1;
            this.ListRadio.Text = "Single Linked List";
            this.ListRadio.UseVisualStyleBackColor = true;
            // 
            // ArrayRadio
            // 
            this.ArrayRadio.AutoSize = true;
            this.ArrayRadio.Checked = true;
            this.ArrayRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrayRadio.Location = new System.Drawing.Point(7, 25);
            this.ArrayRadio.Name = "ArrayRadio";
            this.ArrayRadio.Size = new System.Drawing.Size(58, 20);
            this.ArrayRadio.TabIndex = 0;
            this.ArrayRadio.TabStop = true;
            this.ArrayRadio.Text = "Array";
            this.ArrayRadio.UseVisualStyleBackColor = true;
            // 
            // ammountGroup
            // 
            this.ammountGroup.Controls.Add(this.otherRadio);
            this.ammountGroup.Controls.Add(this.millionRadio);
            this.ammountGroup.Controls.Add(this.hundredThousandRadio);
            this.ammountGroup.Controls.Add(this.tenThousandRadio);
            this.ammountGroup.Controls.Add(this.thousandRadio);
            this.ammountGroup.Controls.Add(this.hundredRadio);
            this.ammountGroup.Controls.Add(this.tenRadio);
            this.ammountGroup.Enabled = false;
            this.ammountGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ammountGroup.Location = new System.Drawing.Point(16, 345);
            this.ammountGroup.Name = "ammountGroup";
            this.ammountGroup.Size = new System.Drawing.Size(202, 133);
            this.ammountGroup.TabIndex = 9;
            this.ammountGroup.TabStop = false;
            this.ammountGroup.Text = "How Many Elements?";
            // 
            // otherRadio
            // 
            this.otherRadio.AutoSize = true;
            this.otherRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherRadio.Location = new System.Drawing.Point(131, 94);
            this.otherRadio.Name = "otherRadio";
            this.otherRadio.Size = new System.Drawing.Size(58, 20);
            this.otherRadio.TabIndex = 6;
            this.otherRadio.Text = "Other";
            this.otherRadio.UseVisualStyleBackColor = true;
            this.otherRadio.CheckedChanged += new System.EventHandler(this.OtherRadio_CheckedChanged);
            // 
            // millionRadio
            // 
            this.millionRadio.AutoSize = true;
            this.millionRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.millionRadio.Location = new System.Drawing.Point(131, 72);
            this.millionRadio.Name = "millionRadio";
            this.millionRadio.Size = new System.Drawing.Size(75, 20);
            this.millionRadio.TabIndex = 5;
            this.millionRadio.Text = "1000000";
            this.millionRadio.UseVisualStyleBackColor = true;
            // 
            // hundredThousandRadio
            // 
            this.hundredThousandRadio.AutoSize = true;
            this.hundredThousandRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hundredThousandRadio.Location = new System.Drawing.Point(131, 46);
            this.hundredThousandRadio.Name = "hundredThousandRadio";
            this.hundredThousandRadio.Size = new System.Drawing.Size(68, 20);
            this.hundredThousandRadio.TabIndex = 4;
            this.hundredThousandRadio.Text = "100000";
            this.hundredThousandRadio.UseVisualStyleBackColor = true;
            // 
            // tenThousandRadio
            // 
            this.tenThousandRadio.AutoSize = true;
            this.tenThousandRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenThousandRadio.Location = new System.Drawing.Point(131, 20);
            this.tenThousandRadio.Name = "tenThousandRadio";
            this.tenThousandRadio.Size = new System.Drawing.Size(61, 20);
            this.tenThousandRadio.TabIndex = 3;
            this.tenThousandRadio.Text = "10000";
            this.tenThousandRadio.UseVisualStyleBackColor = true;
            // 
            // thousandRadio
            // 
            this.thousandRadio.AutoSize = true;
            this.thousandRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thousandRadio.Location = new System.Drawing.Point(7, 72);
            this.thousandRadio.Name = "thousandRadio";
            this.thousandRadio.Size = new System.Drawing.Size(54, 20);
            this.thousandRadio.TabIndex = 2;
            this.thousandRadio.Text = "1000";
            this.thousandRadio.UseVisualStyleBackColor = true;
            // 
            // hundredRadio
            // 
            this.hundredRadio.AutoSize = true;
            this.hundredRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hundredRadio.Location = new System.Drawing.Point(7, 46);
            this.hundredRadio.Name = "hundredRadio";
            this.hundredRadio.Size = new System.Drawing.Size(47, 20);
            this.hundredRadio.TabIndex = 1;
            this.hundredRadio.Text = "100";
            this.hundredRadio.UseVisualStyleBackColor = true;
            // 
            // tenRadio
            // 
            this.tenRadio.AutoSize = true;
            this.tenRadio.Checked = true;
            this.tenRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenRadio.Location = new System.Drawing.Point(7, 20);
            this.tenRadio.Name = "tenRadio";
            this.tenRadio.Size = new System.Drawing.Size(40, 20);
            this.tenRadio.TabIndex = 0;
            this.tenRadio.TabStop = true;
            this.tenRadio.Text = "10";
            this.tenRadio.UseVisualStyleBackColor = true;
            // 
            // otherAmtText
            // 
            this.otherAmtText.Location = new System.Drawing.Point(224, 439);
            this.otherAmtText.Name = "otherAmtText";
            this.otherAmtText.Size = new System.Drawing.Size(100, 20);
            this.otherAmtText.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 582);
            this.Controls.Add(this.otherAmtText);
            this.Controls.Add(this.ammountGroup);
            this.Controls.Add(this.dataTypeGroup);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.generateCheckBox);
            this.Controls.Add(this.sortTypeGroup);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.dataFileLabel);
            this.Controls.Add(this.browseButton);
            this.Name = "Form1";
            this.Text = "Sorting App";
            this.sortTypeGroup.ResumeLayout(false);
            this.sortTypeGroup.PerformLayout();
            this.dataTypeGroup.ResumeLayout(false);
            this.dataTypeGroup.PerformLayout();
            this.ammountGroup.ResumeLayout(false);
            this.ammountGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label dataFileLabel;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox sortTypeGroup;
        private System.Windows.Forms.RadioButton bucketSort;
        private System.Windows.Forms.RadioButton shellSort;
        private System.Windows.Forms.RadioButton heapSort;
        private System.Windows.Forms.RadioButton quickSort;
        private System.Windows.Forms.RadioButton mergeSort;
        private System.Windows.Forms.RadioButton insertionSort;
        private System.Windows.Forms.RadioButton radixSort;
        private System.Windows.Forms.RadioButton bubbleSort;
        private System.Windows.Forms.CheckBox generateCheckBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.GroupBox dataTypeGroup;
        private System.Windows.Forms.RadioButton LinkedListRadio;
        private System.Windows.Forms.RadioButton ListRadio;
        private System.Windows.Forms.RadioButton ArrayRadio;
        private System.Windows.Forms.GroupBox ammountGroup;
        private System.Windows.Forms.TextBox otherAmtText;
        private System.Windows.Forms.RadioButton otherRadio;
        private System.Windows.Forms.RadioButton millionRadio;
        private System.Windows.Forms.RadioButton hundredThousandRadio;
        private System.Windows.Forms.RadioButton tenThousandRadio;
        private System.Windows.Forms.RadioButton thousandRadio;
        private System.Windows.Forms.RadioButton hundredRadio;
        private System.Windows.Forms.RadioButton tenRadio;
    }
}

