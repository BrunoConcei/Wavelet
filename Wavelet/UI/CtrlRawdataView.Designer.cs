﻿namespace Wavelet.UI
{
   partial class CtrlRawdataView
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.pictureBoxUntransformed = new System.Windows.Forms.PictureBox();
         this.pictureBoxTransformed = new System.Windows.Forms.PictureBox();
         this.txtPicUntransformedInfo = new System.Windows.Forms.RichTextBox();
         this.txtPicTransformedInfo = new System.Windows.Forms.RichTextBox();
         this.tableLayoutPanel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUntransformed)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransformed)).BeginInit();
         this.SuspendLayout();
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 3;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.Controls.Add(this.pictureBoxUntransformed, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.pictureBoxTransformed, 0, 2);
         this.tableLayoutPanel1.Controls.Add(this.txtPicTransformedInfo, 2, 2);
         this.tableLayoutPanel1.Controls.Add(this.txtPicUntransformedInfo, 2, 1);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 4;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(874, 437);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // pictureBoxUntransformed
         // 
         this.pictureBoxUntransformed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.pictureBoxUntransformed.Dock = System.Windows.Forms.DockStyle.Fill;
         this.pictureBoxUntransformed.Location = new System.Drawing.Point(3, 53);
         this.pictureBoxUntransformed.Name = "pictureBoxUntransformed";
         this.pictureBoxUntransformed.Size = new System.Drawing.Size(421, 177);
         this.pictureBoxUntransformed.TabIndex = 0;
         this.pictureBoxUntransformed.TabStop = false;
         // 
         // pictureBoxTransformed
         // 
         this.pictureBoxTransformed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.pictureBoxTransformed.Dock = System.Windows.Forms.DockStyle.Fill;
         this.pictureBoxTransformed.Location = new System.Drawing.Point(3, 236);
         this.pictureBoxTransformed.Name = "pictureBoxTransformed";
         this.pictureBoxTransformed.Size = new System.Drawing.Size(421, 177);
         this.pictureBoxTransformed.TabIndex = 1;
         this.pictureBoxTransformed.TabStop = false;
         // 
         // txtPicUntransformedInfo
         // 
         this.txtPicUntransformedInfo.Dock = System.Windows.Forms.DockStyle.Fill;
         this.txtPicUntransformedInfo.Location = new System.Drawing.Point(450, 53);
         this.txtPicUntransformedInfo.Name = "txtPicUntransformedInfo";
         this.txtPicUntransformedInfo.Size = new System.Drawing.Size(421, 177);
         this.txtPicUntransformedInfo.TabIndex = 2;
         this.txtPicUntransformedInfo.Text = "";
         // 
         // txtPicTransformedInfo
         // 
         this.txtPicTransformedInfo.Dock = System.Windows.Forms.DockStyle.Fill;
         this.txtPicTransformedInfo.Location = new System.Drawing.Point(450, 236);
         this.txtPicTransformedInfo.Name = "txtPicTransformedInfo";
         this.txtPicTransformedInfo.Size = new System.Drawing.Size(421, 177);
         this.txtPicTransformedInfo.TabIndex = 3;
         this.txtPicTransformedInfo.Text = "";
         // 
         // CtrlRawdataView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.tableLayoutPanel1);
         this.Name = "CtrlRawdataView";
         this.Size = new System.Drawing.Size(874, 437);
         this.tableLayoutPanel1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUntransformed)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransformed)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.PictureBox pictureBoxUntransformed;
      private System.Windows.Forms.PictureBox pictureBoxTransformed;
      private System.Windows.Forms.RichTextBox txtPicTransformedInfo;
      private System.Windows.Forms.RichTextBox txtPicUntransformedInfo;
   }
}
