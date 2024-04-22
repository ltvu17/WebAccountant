using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAccountant.ModelsBase
{
    public partial class Ktlctg
    {
        [Required(ErrorMessage = "Trường bắt buộc nhập")]
        public string Lctg { get; set; } = null!;
        [Required(ErrorMessage = "Trường bắt buộc nhập")]
        public string? Tenctg { get; set; }
        public string? Tkthue { get; set; }
        public string? CoTkdutkthue { get; set; }
        public string? CoTschitiet { get; set; }
        public string? CoVthh { get; set; }
        public string? SrHd { get; set; }
        public string? Loaitien { get; set; }
        public string? Soct { get; set; }
        public string? SoHd { get; set; }
        public string? MaSufix { get; set; }
        public string? MaPrifix { get; set; }
        public string? CoXuatkho { get; set; }
        public string? NhieuHd { get; set; }
        public string? Manhinh { get; set; }
        public string? Tkno { get; set; }
        public string? Tkco { get; set; }
        public string? Vonglap { get; set; }
        public string? TkTnk { get; set; }
        public string? Danhdau { get; set; }
        public string? Haminchungtu { get; set; }
        public string? CoMhunc { get; set; }
        public string? XkDm { get; set; }
        public string? Nguoigd { get; set; }
        public string? TDtvung { get; set; }
        public string? CoBbchomuon { get; set; }
        public string? CoLonhap { get; set; }
        public string? Tenwb { get; set; }
        public string? Nhieulien { get; set; }
        public string? CoCltg { get; set; }
        public string? CoHoiin { get; set; }
        public string? Diengiai { get; set; }
        public double Sodong { get; set; }
        public string? Matt { get; set; }
        public string? NhieuDv { get; set; }
        public string? CoDiengiai2 { get; set; }
        public string? CoChietkhau { get; set; }
        public string? TkcltgLai { get; set; }
        public string? TkcltgLo { get; set; }
        public string? CoChuyenkho { get; set; }
        public string? CoTienhang { get; set; }
        public string? CoFormRieng { get; set; }
        public string? CoCkTruoc { get; set; }
        public string? CoDonviPhu { get; set; }
        public string? CoTenhhIn { get; set; }
        public string? CoHtphelieu { get; set; }
        public string? MsKh { get; set; }
        public string? Hdvat { get; set; }
        public double BeronggapHd { get; set; }
        public string? CoDgnhap { get; set; }
        public string? Madtpnno { get; set; }
        public string? Madtpnco { get; set; }
        public string? CoTttdb { get; set; }
        public string? NhieuUser { get; set; }
        public double? Trangthai { get; set; }
        public string? CoTkXuat { get; set; }
        public string? TkXuat { get; set; }
        public string? TkGiavon { get; set; }
        public string? Nhomchungtu { get; set; }
        public string? NhomDscot { get; set; }
        public string? TsGtgt { get; set; }
        public string? KieuCongty { get; set; }
        public string? CoCktm { get; set; }
        public string? CoCktt { get; set; }
        public string? CoLenhsx { get; set; }
        public string? CoVc { get; set; }
        public string? CotGapXch { get; set; }
        public string? DscotShowEdit { get; set; }
        public string? KhmHd { get; set; }
        public string? KieuNhapps { get; set; }
        public string? MaHd { get; set; }
        public string? PxkOfHdbr { get; set; }
        public double SocotCdEdit { get; set; }
        public string? TkChietkhau { get; set; }
        public string? KieuChungtu { get; set; }
        public string? TkduTkthue { get; set; }
        public string? ChungtuCopy { get; set; }
        public string? DscotShowNhapps { get; set; }
        public double Sapxepchungtu { get; set; }
        public double PtCk { get; set; }
        public string? Kieutangsoct { get; set; }
        public string? LctgPc { get; set; }
        public string? LctgPt { get; set; }
        public string? MaCt { get; set; }
        public string? Mabophan { get; set; }
        public double Sokytusoct { get; set; }
    }
}
