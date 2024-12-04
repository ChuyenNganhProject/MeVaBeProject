using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class SanPhamItemControl : UserControl
    {
        public event EventHandler SanPhamClicked;
        SanPhamBLL spbll = new SanPhamBLL();
        public SanPhamItemControl()
        {
            InitializeComponent();
            this.Load += (s, e) => SetRoundedCorners(this, 20);
            this.Click += SanPhamItemControl_Click;
            this.pbAnhSp.Click += SanPhamItemControl_Click;
            this.labelTenSp.Click += SanPhamItemControl_Click;
            this.labelGiaSanPham.Click += SanPhamItemControl_Click;
        }

        private void SanPhamItemControl_Click(object sender, EventArgs e)
        {
            SanPhamClicked?.Invoke(this, e);
        }

        private void SetRoundedCorners(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            control.Region = new Region(path);
        }

        private string GetPicSanPhamFolderPath()
        {
            // Đường dẫn tương đối từ thư mục gốc của project
            string relativePath = @"..\..\PicSanPham";
            string absolutePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath));
            return absolutePath;
        }

        public void SetSanPhamData(string image, string maSp, string tenSp, decimal? giaSp)
        {
            SanPham sp = spbll.TimKiemSanPhamTheoMaSP(maSp);
            if (sp != null)
            {
                string picFolder = GetPicSanPhamFolderPath();
                if (!string.IsNullOrEmpty(image))
                {
                    string imagePath = Path.Combine(picFolder, Path.GetFileName(image)).Replace("/", "\\");

                    if (File.Exists(imagePath))
                    {
                        try
                        {
                            if (pbAnhSp.Image != null)
                            {
                                pbAnhSp.Image.Dispose();
                                pbAnhSp.Image = null;
                            }

                            using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                            {
                                Image img = Image.FromStream(fs);
                                pbAnhSp.Image = new Bitmap(img);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi tải hình ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Hình ảnh không tồn tại tại đường dẫn: {imagePath}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Đường dẫn hình ảnh trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                labelMaSp.Text = maSp;
                labelTenSp.Text = tenSp;
                labelGiaSanPham.Text = giaSp.HasValue ? giaSp.Value.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + "đ" : "N/A";
                lblSoLuong.Text = "SL: " + spbll.TimKiemSanPhamTheoMaSP(maSp).soLuong.Value;
            }
        }

    }
}
