namespace WebcamCaptureApp;

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
        comboBox1WebcamList = new ComboBox();
        buttonStart = new Button();
        buttonCapture = new Button();
        buttonSaveImage = new Button();
        buttonExit = new Button();
        tableLayoutPanel1 = new TableLayoutPanel();
        pictureBox1 = new PictureBox();
        pictureBox2 = new PictureBox();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        SuspendLayout();
        // 
        // comboBox1WebcamList
        // 
        comboBox1WebcamList.FormattingEnabled = true;
        comboBox1WebcamList.Location = new Point(12, 12);
        comboBox1WebcamList.Name = "comboBox1WebcamList";
        comboBox1WebcamList.Size = new Size(188, 28);
        comboBox1WebcamList.TabIndex = 0;
        // 
        // buttonStart
        // 
        buttonStart.Location = new Point(206, 12);
        buttonStart.Name = "buttonStart";
        buttonStart.Size = new Size(94, 29);
        buttonStart.TabIndex = 1;
        buttonStart.Text = "Start";
        buttonStart.UseVisualStyleBackColor = true;
        buttonStart.Click += buttonStart_Click;
        // 
        // buttonCapture
        // 
        buttonCapture.Location = new Point(306, 12);
        buttonCapture.Name = "buttonCapture";
        buttonCapture.Size = new Size(94, 29);
        buttonCapture.TabIndex = 2;
        buttonCapture.Text = "Capture";
        buttonCapture.UseVisualStyleBackColor = true;
        buttonCapture.Click += buttonCapture_Click;
        // 
        // buttonSaveImage
        // 
        buttonSaveImage.Location = new Point(406, 12);
        buttonSaveImage.Name = "buttonSaveImage";
        buttonSaveImage.Size = new Size(94, 29);
        buttonSaveImage.TabIndex = 3;
        buttonSaveImage.Text = "Save Image";
        buttonSaveImage.UseVisualStyleBackColor = true;
        buttonSaveImage.Click += buttonSaveImage_Click;
        // 
        // buttonExit
        // 
        buttonExit.Location = new Point(694, 11);
        buttonExit.Name = "buttonExit";
        buttonExit.Size = new Size(94, 29);
        buttonExit.TabIndex = 4;
        buttonExit.Text = "Exit";
        buttonExit.UseVisualStyleBackColor = true;
        buttonExit.Click += buttonExit_Click;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 388F));
        tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
        tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
        tableLayoutPanel1.Location = new Point(12, 47);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.Size = new Size(776, 391);
        tableLayoutPanel1.TabIndex = 5;
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new Point(3, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(382, 385);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // pictureBox2
        // 
        pictureBox2.Location = new Point(391, 3);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(382, 385);
        pictureBox2.TabIndex = 1;
        pictureBox2.TabStop = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(tableLayoutPanel1);
        Controls.Add(buttonExit);
        Controls.Add(buttonSaveImage);
        Controls.Add(buttonCapture);
        Controls.Add(buttonStart);
        Controls.Add(comboBox1WebcamList);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        tableLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private ComboBox comboBox1WebcamList;
    private Button buttonStart;
    private Button buttonCapture;
    private Button buttonSaveImage;
    private Button buttonExit;
    private TableLayoutPanel tableLayoutPanel1;
    private PictureBox pictureBox1;
    private PictureBox pictureBox2;
}
