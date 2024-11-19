﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using Microsoft.Reporting.WinForms;

namespace MeVaBeProject
{
    public partial class frmPhieuDatHang : Form
    {
        private string maPhieuDat;
        private PhieuDat phieuDat;
        private NhaCungCap nhaCungCap;
        private List<ChiTietPhieuDat> danhSachCTPD;
        private PhieuDatBLL phieuDatBLL;
        private NhaCungCapBLL nhaCungCapBLL;
        private ChiTietPhieuDatBLL chiTietPhieuDatBLL;
        public frmPhieuDatHang(string  maPhieuDat)
        {
            this.maPhieuDat = maPhieuDat;
            this.phieuDatBLL = new PhieuDatBLL();
            this.nhaCungCapBLL = new NhaCungCapBLL();
            this.chiTietPhieuDatBLL = new ChiTietPhieuDatBLL();
            InitializeComponent();
        }

        private void frmPhieuDatHang_Load(object sender, EventArgs e)
        {           
            phieuDat = phieuDatBLL.TimKiemPhieuDatTheoMaPhieuDat(maPhieuDat);
            nhaCungCap = nhaCungCapBLL.TimNhaCungCapTheoMa(phieuDat.maNhaCungCap);
            danhSachCTPD = chiTietPhieuDatBLL.LayChiTietPhieuDat(maPhieuDat);
            int tongTien = int.Parse(phieuDat.tongTien.ToString().Split(',')[0]);
            ReportParameter[] reportParameters = new ReportParameter[] {
                new ReportParameter("tenNhaCungCap", nhaCungCap.tenNhaCungCap),
                new ReportParameter("diaChi", nhaCungCap.diaChi),
                new ReportParameter("soDienThoai", nhaCungCap.soDienThoai),
                new ReportParameter("ngayLap", phieuDat.ngayLap.Value.ToString("dd-MM-yyyy")),
                new ReportParameter("tongTienPhieuDat", tongTien.ToString("C0"))
            };

            ReportDataSource rdsChiTiet = new ReportDataSource("DataSet1", danhSachCTPD);

            phieuDatReportView.LocalReport.DataSources.Clear();
            phieuDatReportView.LocalReport.DataSources.Add(rdsChiTiet);
            phieuDatReportView.LocalReport.SetParameters(reportParameters);
            this.phieuDatReportView.RefreshReport();
        }
    }
}
