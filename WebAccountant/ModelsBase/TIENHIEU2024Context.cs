using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAccountant.ModelsBase
{
    public partial class TIENHIEU2024Context : DbContext
    {
        public TIENHIEU2024Context()
        {
        }

        public TIENHIEU2024Context(DbContextOptions<TIENHIEU2024Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Baocaonhanh> Baocaonhanhs { get; set; } = null!;
        public virtual DbSet<Cfg> Cfgs { get; set; } = null!;
        public virtual DbSet<CfgCongthucTm> CfgCongthucTms { get; set; } = null!;
        public virtual DbSet<CfgF8D> CfgF8Ds { get; set; } = null!;
        public virtual DbSet<CfgGiaidoan> CfgGiaidoans { get; set; } = null!;
        public virtual DbSet<CfgImportBarcode> CfgImportBarcodes { get; set; } = null!;
        public virtual DbSet<CfgImportTuServerKhac> CfgImportTuServerKhacs { get; set; } = null!;
        public virtual DbSet<CfgKhac> CfgKhacs { get; set; } = null!;
        public virtual DbSet<CfgTm> CfgTms { get; set; } = null!;
        public virtual DbSet<Congthucnhapp> Congthucnhapps { get; set; } = null!;
        public virtual DbSet<Ctkiemke> Ctkiemkes { get; set; } = null!;
        public virtual DbSet<Cttsdh> Cttsdhs { get; set; } = null!;
        public virtual DbSet<Danhmucthuoc> Danhmucthuocs { get; set; } = null!;
        public virtual DbSet<DanhsachLtv> DanhsachLtvs { get; set; } = null!;
        public virtual DbSet<DmDoanhthuNhantruoc> DmDoanhthuNhantruocs { get; set; } = null!;
        public virtual DbSet<Dmbaogium> Dmbaogia { get; set; } = null!;
        public virtual DbSet<Dmbaohanh> Dmbaohanhs { get; set; } = null!;
        public virtual DbSet<Dmbarcode> Dmbarcodes { get; set; } = null!;
        public virtual DbSet<DmbarcodeLoi> DmbarcodeLois { get; set; } = null!;
        public virtual DbSet<DmchietkhauDtHh> DmchietkhauDtHhs { get; set; } = null!;
        public virtual DbSet<Dmcpcpb> Dmcpcpbs { get; set; } = null!;
        public virtual DbSet<DmcpcpbTkcp> DmcpcpbTkcps { get; set; } = null!;
        public virtual DbSet<Dmcttp> Dmcttps { get; set; } = null!;
        public virtual DbSet<Dmdatabase> Dmdatabases { get; set; } = null!;
        public virtual DbSet<DmdgbanMin> DmdgbanMins { get; set; } = null!;
        public virtual DbSet<Dmdhban> Dmdhbans { get; set; } = null!;
        public virtual DbSet<Dmdhmua> Dmdhmuas { get; set; } = null!;
        public virtual DbSet<Dmhhlo> Dmhhlos { get; set; } = null!;
        public virtual DbSet<Dmhoadon> Dmhoadons { get; set; } = null!;
        public virtual DbSet<Dmhopdong> Dmhopdongs { get; set; } = null!;
        public virtual DbSet<Dmkheuoc> Dmkheuocs { get; set; } = null!;
        public virtual DbSet<Dmkyhachtoan> Dmkyhachtoans { get; set; } = null!;
        public virtual DbSet<Dmlenhsx> Dmlenhsxes { get; set; } = null!;
        public virtual DbSet<Dmmaysudung> Dmmaysudungs { get; set; } = null!;
        public virtual DbSet<Dmnghiepvu> Dmnghiepvus { get; set; } = null!;
        public virtual DbSet<Dmthongbao> Dmthongbaos { get; set; } = null!;
        public virtual DbSet<Dmtrangthai> Dmtrangthais { get; set; } = null!;
        public virtual DbSet<Dmtscd> Dmtscds { get; set; } = null!;
        public virtual DbSet<DmtscdTkcp> DmtscdTkcps { get; set; } = null!;
        public virtual DbSet<Dmtstk> Dmtstks { get; set; } = null!;
        public virtual DbSet<Dmtstncn> Dmtstncns { get; set; } = null!;
        public virtual DbSet<Dmuser> Dmusers { get; set; } = null!;
        public virtual DbSet<Dmvitrihanghoa> Dmvitrihanghoas { get; set; } = null!;
        public virtual DbSet<Dsbaogium> Dsbaogia { get; set; } = null!;
        public virtual DbSet<Dscot> Dscots { get; set; } = null!;
        public virtual DbSet<Dsdhban> Dsdhbans { get; set; } = null!;
        public virtual DbSet<Dsdhmua> Dsdhmuas { get; set; } = null!;
        public virtual DbSet<Dsphimnong> Dsphimnongs { get; set; } = null!;
        public virtual DbSet<KhaiBaoKqkd> KhaiBaoKqkds { get; set; } = null!;
        public virtual DbSet<KhaiBaoKqkdBp> KhaiBaoKqkdBps { get; set; } = null!;
        public virtual DbSet<KhaiBaoKqkdQt> KhaiBaoKqkdQts { get; set; } = null!;
        public virtual DbSet<KhaiBaoLctt> KhaiBaoLctts { get; set; } = null!;
        public virtual DbSet<KhaiBaoLcttGt> KhaiBaoLcttGts { get; set; } = null!;
        public virtual DbSet<KhaiBaoLcttQt> KhaiBaoLcttQts { get; set; } = null!;
        public virtual DbSet<KhaibaoKctk> KhaibaoKctks { get; set; } = null!;
        public virtual DbSet<KhaibaoKctkDt> KhaibaoKctkDts { get; set; } = null!;
        public virtual DbSet<Khaibaocdkt> Khaibaocdkts { get; set; } = null!;
        public virtual DbSet<KhaibaocdktQt> KhaibaocdktQts { get; set; } = null!;
        public virtual DbSet<Khaibaokqkdmr> Khaibaokqkdmrs { get; set; } = null!;
        public virtual DbSet<Khaibaopt01> Khaibaopt01s { get; set; } = null!;
        public virtual DbSet<Kt154Gc> Kt154Gcs { get; set; } = null!;
        public virtual DbSet<KtBangLuong> KtBangLuongs { get; set; } = null!;
        public virtual DbSet<KtBophanUser> KtBophanUsers { get; set; } = null!;
        public virtual DbSet<KtChamCong> KtChamCongs { get; set; } = null!;
        public virtual DbSet<KtDoanhthuNhantruoc> KtDoanhthuNhantruocs { get; set; } = null!;
        public virtual DbSet<KtHamin> KtHamins { get; set; } = null!;
        public virtual DbSet<KtHd> KtHds { get; set; } = null!;
        public virtual DbSet<KtHdHh> KtHdHhs { get; set; } = null!;
        public virtual DbSet<KtMaCong> KtMaCongs { get; set; } = null!;
        public virtual DbSet<KtMaTt> KtMaTts { get; set; } = null!;
        public virtual DbSet<KtNgayLe> KtNgayLes { get; set; } = null!;
        public virtual DbSet<KtUngLuong> KtUngLuongs { get; set; } = null!;
        public virtual DbSet<KtUserTable> KtUserTables { get; set; } = null!;
        public virtual DbSet<Ktbaogium> Ktbaogia { get; set; } = null!;
        public virtual DbSet<Ktbaohanh> Ktbaohanhs { get; set; } = null!;
        public virtual DbSet<Ktbarcode> Ktbarcodes { get; set; } = null!;
        public virtual DbSet<Ktcaphh> Ktcaphhs { get; set; } = null!;
        public virtual DbSet<Ktcn> Ktcns { get; set; } = null!;
        public virtual DbSet<KtcnCt> KtcnCts { get; set; } = null!;
        public virtual DbSet<KtcnCtHd> KtcnCtHds { get; set; } = null!;
        public virtual DbSet<KtcnCtTt> KtcnCtTts { get; set; } = null!;
        public virtual DbSet<KtcnCtu> KtcnCtus { get; set; } = null!;
        public virtual DbSet<Ktcomputer> Ktcomputers { get; set; } = null!;
        public virtual DbSet<Ktcongthuc> Ktcongthucs { get; set; } = null!;
        public virtual DbSet<Ktcp> Ktcps { get; set; } = null!;
        public virtual DbSet<KtcpCt> KtcpCts { get; set; } = null!;
        public virtual DbSet<Ktcpcpb> Ktcpcpbs { get; set; } = null!;
        public virtual DbSet<Ktddck> Ktddcks { get; set; } = null!;
        public virtual DbSet<KtddckGd> KtddckGds { get; set; } = null!;
        public virtual DbSet<KtddnlGd> KtddnlGds { get; set; } = null!;
        public virtual DbSet<KtddnlZ2> KtddnlZ2s { get; set; } = null!;
        public virtual DbSet<Ktdgban> Ktdgbans { get; set; } = null!;
        public virtual DbSet<KtdgbanBp> KtdgbanBps { get; set; } = null!;
        public virtual DbSet<KtdgbanNgay> KtdgbanNgays { get; set; } = null!;
        public virtual DbSet<Ktdgck> Ktdgcks { get; set; } = null!;
        public virtual DbSet<Ktdgmua> Ktdgmuas { get; set; } = null!;
        public virtual DbSet<Ktdhban> Ktdhbans { get; set; } = null!;
        public virtual DbSet<Ktdhmua> Ktdhmuas { get; set; } = null!;
        public virtual DbSet<Ktdiengiai> Ktdiengiais { get; set; } = null!;
        public virtual DbSet<Ktdinhmuc> Ktdinhmucs { get; set; } = null!;
        public virtual DbSet<KtdinhmucGd> KtdinhmucGds { get; set; } = null!;
        public virtual DbSet<KtdinhmucGdNgay> KtdinhmucGdNgays { get; set; } = null!;
        public virtual DbSet<KtdinhmucGdNhom> KtdinhmucGdNhoms { get; set; } = null!;
        public virtual DbSet<KtdinhmucKhsx> KtdinhmucKhsxes { get; set; } = null!;
        public virtual DbSet<Ktdm> Ktdms { get; set; } = null!;
        public virtual DbSet<Ktdmcum> Ktdmcums { get; set; } = null!;
        public virtual DbSet<Ktdmh> Ktdmhs { get; set; } = null!;
        public virtual DbSet<Ktdmkho> Ktdmkhos { get; set; } = null!;
        public virtual DbSet<Ktdmlo> Ktdmlos { get; set; } = null!;
        public virtual DbSet<Ktdmnc> Ktdmncs { get; set; } = null!;
        public virtual DbSet<KtdmncGd> KtdmncGds { get; set; } = null!;
        public virtual DbSet<Ktdtgt> Ktdtgts { get; set; } = null!;
        public virtual DbSet<Ktdtpn> Ktdtpns { get; set; } = null!;
        public virtual DbSet<Ktgt> Ktgts { get; set; } = null!;
        public virtual DbSet<KtgtGd> KtgtGds { get; set; } = null!;
        public virtual DbSet<Ktgtct> Ktgtcts { get; set; } = null!;
        public virtual DbSet<KtgtctThang> KtgtctThangs { get; set; } = null!;
        public virtual DbSet<Ktgtcttp> Ktgtcttps { get; set; } = null!;
        public virtual DbSet<Ktgtgdct> Ktgtgdcts { get; set; } = null!;
        public virtual DbSet<Kthoadon> Kthoadons { get; set; } = null!;
        public virtual DbSet<KthoadonChinhanh> KthoadonChinhanhs { get; set; } = null!;
        public virtual DbSet<Ktkheuoc> Ktkheuocs { get; set; } = null!;
        public virtual DbSet<Ktkhsx> Ktkhsxes { get; set; } = null!;
        public virtual DbSet<Ktlctg> Ktlctgs { get; set; } = null!;
        public virtual DbSet<Ktlenhsx> Ktlenhsxes { get; set; } = null!;
        public virtual DbSet<KtlocAltF7> KtlocAltF7s { get; set; } = null!;
        public virtual DbSet<Ktmausac> Ktmausacs { get; set; } = null!;
        public virtual DbSet<KtmenuCon> KtmenuCons { get; set; } = null!;
        public virtual DbSet<KtmenuMe> KtmenuMes { get; set; } = null!;
        public virtual DbSet<KtmenuNadopo> KtmenuNadopos { get; set; } = null!;
        public virtual DbSet<Ktnhanvien> Ktnhanviens { get; set; } = null!;
        public virtual DbSet<Ktnhatkysua> Ktnhatkysuas { get; set; } = null!;
        public virtual DbSet<Ktnhomck> Ktnhomcks { get; set; } = null!;
        public virtual DbSet<Ktnhomdg> Ktnhomdgs { get; set; } = null!;
        public virtual DbSet<Ktnhomhh> Ktnhomhhs { get; set; } = null!;
        public virtual DbSet<Ktnhucaunguyenlieu> Ktnhucaunguyenlieus { get; set; } = null!;
        public virtual DbSet<Ktpbcp> Ktpbcps { get; set; } = null!;
        public virtual DbSet<KtpbcpCt> KtpbcpCts { get; set; } = null!;
        public virtual DbSet<KtpbcpGd> KtpbcpGds { get; set; } = null!;
        public virtual DbSet<KtpqForm> KtpqForms { get; set; } = null!;
        public virtual DbSet<KtpqFormUser> KtpqFormUsers { get; set; } = null!;
        public virtual DbSet<KtpqThang> KtpqThangs { get; set; } = null!;
        public virtual DbSet<KtpqThangUser> KtpqThangUsers { get; set; } = null!;
        public virtual DbSet<Ktpqchucvu> Ktpqchucvus { get; set; } = null!;
        public virtual DbSet<Ktpqct> Ktpqcts { get; set; } = null!;
        public virtual DbSet<Ktpqngay> Ktpqngays { get; set; } = null!;
        public virtual DbSet<KtquydoiDvt1> KtquydoiDvt1s { get; set; } = null!;
        public virtual DbSet<Ktsc> Ktscs { get; set; } = null!;
        public virtual DbSet<KtscBh> KtscBhs { get; set; } = null!;
        public virtual DbSet<KtscCkDp> KtscCkDps { get; set; } = null!;
        public virtual DbSet<KtscNhapp> KtscNhapps { get; set; } = null!;
        public virtual DbSet<Kttambarcode> Kttambarcodes { get; set; } = null!;
        public virtual DbSet<Kttk> Kttks { get; set; } = null!;
        public virtual DbSet<Kttscd> Kttscds { get; set; } = null!;
        public virtual DbSet<Kttsdh> Kttsdhs { get; set; } = null!;
        public virtual DbSet<Kttyle> Kttyles { get; set; } = null!;
        public virtual DbSet<KttyleGd> KttyleGds { get; set; } = null!;
        public virtual DbSet<KttyleGdYtcp> KttyleGdYtcps { get; set; } = null!;
        public virtual DbSet<KttylePb> KttylePbs { get; set; } = null!;
        public virtual DbSet<KttylePbCt> KttylePbCts { get; set; } = null!;
        public virtual DbSet<KttylePbcpCongtrinh> KttylePbcpCongtrinhs { get; set; } = null!;
        public virtual DbSet<KttyleYtcp> KttyleYtcps { get; set; } = null!;
        public virtual DbSet<Ktuser> Ktusers { get; set; } = null!;
        public virtual DbSet<Ktytcp> Ktytcps { get; set; } = null!;
        public virtual DbSet<NibotChitiet> NibotChitiets { get; set; } = null!;
        public virtual DbSet<Quyensd> Quyensds { get; set; } = null!;
        public virtual DbSet<Sodugt03> Sodugt03s { get; set; } = null!;
        public virtual DbSet<TablePk> TablePks { get; set; } = null!;
        public virtual DbSet<TblCtLsx> TblCtLsxes { get; set; } = null!;
        public virtual DbSet<TblCtYcxk> TblCtYcxks { get; set; } = null!;
        public virtual DbSet<TblDmddcongtrinhSl> TblDmddcongtrinhSls { get; set; } = null!;
        public virtual DbSet<TblDmdtcongtrinh> TblDmdtcongtrinhs { get; set; } = null!;
        public virtual DbSet<TblDsbpKqkd> TblDsbpKqkds { get; set; } = null!;
        public virtual DbSet<TblDsctKqkd> TblDsctKqkds { get; set; } = null!;
        public virtual DbSet<TblKehoachquetmavach> TblKehoachquetmavaches { get; set; } = null!;
        public virtual DbSet<TblKtddcongtrinhSl> TblKtddcongtrinhSls { get; set; } = null!;
        public virtual DbSet<TblKyhieumauhoadon> TblKyhieumauhoadons { get; set; } = null!;
        public virtual DbSet<TblP2d> TblP2ds { get; set; } = null!;
        public virtual DbSet<TblTangsochungtu> TblTangsochungtus { get; set; } = null!;
        public virtual DbSet<TblTangt> TblTangts { get; set; } = null!;
        public virtual DbSet<TblXkdinhmuctam> TblXkdinhmuctams { get; set; } = null!;
        public virtual DbSet<TblXmlDmhh> TblXmlDmhhs { get; set; } = null!;
        public virtual DbSet<Tblkehoachsanxuatchitiet> Tblkehoachsanxuatchitiets { get; set; } = null!;
        public virtual DbSet<Tblkehoachsanxuattonghop> Tblkehoachsanxuattonghops { get; set; } = null!;
        public virtual DbSet<TonghopLtv> TonghopLtvs { get; set; } = null!;
        public virtual DbSet<Xlclkk> Xlclkks { get; set; } = null!;
        public virtual DbSet<XlddnlGd> XlddnlGds { get; set; } = null!;
        public virtual DbSet<XlddnlZ2> XlddnlZ2s { get; set; } = null!;
        public virtual DbSet<Z10DdDn> Z10DdDns { get; set; } = null!;
        public virtual DbSet<Z10Dinhmucnguyenlieu> Z10Dinhmucnguyenlieus { get; set; } = null!;
        public virtual DbSet<Z10Dmtpcon> Z10Dmtpcons { get; set; } = null!;
        public virtual DbSet<Z10Kttpcon> Z10Kttpcons { get; set; } = null!;
        public virtual DbSet<Z10NhapDd> Z10NhapDds { get; set; } = null!;
        public virtual DbSet<Z10PbCpAllgd> Z10PbCpAllgds { get; set; } = null!;
        public virtual DbSet<Z12KtddckKho> Z12KtddckKhos { get; set; } = null!;
        public virtual DbSet<Z12KtdinhmucKho> Z12KtdinhmucKhos { get; set; } = null!;
        public virtual DbSet<Z12KtdmncKho> Z12KtdmncKhos { get; set; } = null!;
        public virtual DbSet<Z12KtgtKho> Z12KtgtKhos { get; set; } = null!;
        public virtual DbSet<Z12KtpbcpKho> Z12KtpbcpKhos { get; set; } = null!;
        public virtual DbSet<Z12KttyleKho> Z12KttyleKhos { get; set; } = null!;
        public virtual DbSet<Z12KttyleYtcpKho> Z12KttyleYtcpKhos { get; set; } = null!;
        public virtual DbSet<Z12Ktxldd> Z12Ktxldds { get; set; } = null!;
        public virtual DbSet<Z1Ktxldd> Z1Ktxldds { get; set; } = null!;
        public virtual DbSet<Z8Dd> Z8Dds { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-TQRP8RA3\\SQLEXPRESS;Initial Catalog=TIENHIEU2024;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AI");

            modelBuilder.Entity<Baocaonhanh>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__BAOCAONHANH__6B25B5D9");

                entity.ToTable("BAOCAONHANH");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.BtSubtotal)
                    .HasMaxLength(100)
                    .HasColumnName("BT_SUBTOTAL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BtSubtotal01)
                    .HasMaxLength(50)
                    .HasColumnName("BT_SUBTOTAL_01")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BtSubtotal02)
                    .HasMaxLength(50)
                    .HasColumnName("BT_SUBTOTAL_02")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoDkNgay)
                    .HasMaxLength(1)
                    .HasColumnName("CO_DK_NGAY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoDtpn)
                    .HasMaxLength(1)
                    .HasColumnName("CO_DTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoKtcn1)
                    .HasMaxLength(2)
                    .HasColumnName("CO_KTCN1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoKtdm1)
                    .HasMaxLength(2)
                    .HasColumnName("CO_KTDM1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoKtdm2)
                    .HasMaxLength(2)
                    .HasColumnName("CO_KTDM2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoKtsc1)
                    .HasMaxLength(2)
                    .HasColumnName("CO_KTSC1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoTk)
                    .HasMaxLength(1)
                    .HasColumnName("CO_TK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoYtcp)
                    .HasMaxLength(1)
                    .HasColumnName("CO_YTCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DanhSachUser)
                    .HasMaxLength(250)
                    .HasColumnName("DANH_SACH_USER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dieukien)
                    .HasMaxLength(600)
                    .HasColumnName("DIEUKIEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DscotIn)
                    .HasMaxLength(250)
                    .HasColumnName("DSCOT_IN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DscotSelect)
                    .HasMaxLength(1998)
                    .HasColumnName("DSCOT_SELECT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DscotSum)
                    .HasMaxLength(50)
                    .HasColumnName("DSCOT_SUM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FileExcel)
                    .HasMaxLength(50)
                    .HasColumnName("FILE_EXCEL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gop)
                    .HasMaxLength(250)
                    .HasColumnName("GOP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sapxep)
                    .HasMaxLength(250)
                    .HasColumnName("SAPXEP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Songuon)
                    .HasMaxLength(30)
                    .HasColumnName("SONGUON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenbc)
                    .HasMaxLength(500)
                    .HasColumnName("TENBC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Cfg>(entity =>
            {
                entity.HasKey(e => e.Idv)
                    .HasName("PK__CFG__7A721B0A");

                entity.ToTable("CFG");

                entity.Property(e => e.Idv)
                    .HasMaxLength(50)
                    .HasColumnName("IDV");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(255)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Giatri)
                    .HasMaxLength(4000)
                    .HasColumnName("GIATRI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Giatri2)
                    .HasMaxLength(250)
                    .HasColumnName("GIATRI_2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ten)
                    .HasMaxLength(100)
                    .HasColumnName("TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CfgCongthucTm>(entity =>
            {
                entity.HasKey(e => new { e.Cot, e.Dong })
                    .HasName("PK__CFG_CONGTHUC_TM__73852659");

                entity.ToTable("CFG_CONGTHUC_TM");

                entity.Property(e => e.Cot)
                    .HasMaxLength(50)
                    .HasColumnName("COT");

                entity.Property(e => e.Dong).HasColumnName("DONG");

                entity.Property(e => e.Congthuc)
                    .HasMaxLength(500)
                    .HasColumnName("CONGTHUC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(500)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CfgF8D>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__CFG_F8_D__03F163A3");

                entity.ToTable("CFG_F8_D");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dieukien)
                    .HasMaxLength(50)
                    .HasColumnName("DIEUKIEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DscotIn)
                    .HasMaxLength(250)
                    .HasColumnName("DSCOT_IN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FileExcel)
                    .HasMaxLength(100)
                    .HasColumnName("FILE_EXCEL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ListChieuRong)
                    .HasMaxLength(250)
                    .HasColumnName("LIST_CHIEU_RONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ListDinhDang)
                    .HasMaxLength(250)
                    .HasColumnName("LIST_DINH_DANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ListTieuDe)
                    .HasMaxLength(250)
                    .HasColumnName("LIST_TIEU_DE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom1)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom2)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom3)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sapxepchitietnhat)
                    .HasMaxLength(50)
                    .HasColumnName("SAPXEPCHITIETNHAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenBaoCao)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_BAO_CAO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CfgGiaidoan>(entity =>
            {
                entity.HasKey(e => e.Giaidoan)
                    .HasName("PK__CFG_GIAIDOAN__7E02B4CC");

                entity.ToTable("CFG_GIAIDOAN");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.CoDodang)
                    .HasMaxLength(5)
                    .HasColumnName("CO_DODANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CopyMactToMabpsx)
                    .HasMaxLength(10)
                    .HasColumnName("COPY_MACT_TO_MABPSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DsTkCpAllGd)
                    .HasMaxLength(250)
                    .HasColumnName("DS_TK_CP_ALL_GD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KPbcp)
                    .HasMaxLength(5)
                    .HasColumnName("K_PBCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kieudinhmuc)
                    .HasMaxLength(10)
                    .HasColumnName("KIEUDINHMUC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lamtrontheotaikhoan)
                    .HasMaxLength(5)
                    .HasColumnName("LAMTRONTHEOTAIKHOAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LctgGiamChiphi)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG_GIAM_CHIPHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MakhoNl)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO_NL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaytcpGiam)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCP_GIAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaytcpTang)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCP_TANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NhanSoluongTyle)
                    .HasMaxLength(5)
                    .HasColumnName("NHAN_SOLUONG_TYLE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PxkSua)
                    .HasMaxLength(12)
                    .HasColumnName("PXK_SUA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SttPb621).HasColumnName("STT_PB_621");

                entity.Property(e => e.SttPb622).HasColumnName("STT_PB_622");

                entity.Property(e => e.SttPb627).HasColumnName("STT_PB_627");

                entity.Property(e => e.Tk1doanhthu)
                    .HasMaxLength(50)
                    .HasColumnName("TK_1DOANHTHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkChiphi)
                    .HasMaxLength(250)
                    .HasColumnName("TK_CHIPHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkCpAllGd)
                    .HasMaxLength(250)
                    .HasColumnName("TK_CP_ALL_GD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkCpNc)
                    .HasMaxLength(50)
                    .HasColumnName("TK_CP_NC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkCpNl)
                    .HasMaxLength(50)
                    .HasColumnName("TK_CP_NL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkDoanhthu)
                    .HasMaxLength(250)
                    .HasColumnName("TK_DOANHTHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkDodang)
                    .HasMaxLength(100)
                    .HasColumnName("TK_DODANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkNguyenlieu)
                    .HasMaxLength(250)
                    .HasColumnName("TK_NGUYENLIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkThanhpham)
                    .HasMaxLength(250)
                    .HasColumnName("TK_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.XkThucte)
                    .HasMaxLength(5)
                    .HasColumnName("XK_THUCTE")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CfgImportBarcode>(entity =>
            {
                entity.ToTable("CFG_IMPORT_BARCODE");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DbNguon)
                    .HasMaxLength(50)
                    .HasColumnName("DB_NGUON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DsChungtuDich)
                    .HasMaxLength(250)
                    .HasColumnName("DS_CHUNGTU_DICH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DsChungtuNguon)
                    .HasMaxLength(250)
                    .HasColumnName("DS_CHUNGTU_NGUON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Goptheomadm)
                    .HasMaxLength(10)
                    .HasColumnName("GOPTHEOMADM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkTheoKtlctg)
                    .HasMaxLength(10)
                    .HasColumnName("TK_THEO_KTLCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CfgImportTuServerKhac>(entity =>
            {
                entity.ToTable("CFG_IMPORT_TU_SERVER_KHAC");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Bieuthucgop)
                    .HasMaxLength(50)
                    .HasColumnName("BIEUTHUCGOP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Coxoacu)
                    .HasMaxLength(50)
                    .HasColumnName("COXOACU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Coxulygiaban)
                    .HasMaxLength(5)
                    .HasColumnName("COXULYGIABAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DatabaseNguon)
                    .HasMaxLength(50)
                    .HasColumnName("DATABASE_NGUON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dieukien)
                    .HasMaxLength(50)
                    .HasColumnName("DIEUKIEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matkhau)
                    .HasMaxLength(50)
                    .HasColumnName("MATKHAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ServerNguon)
                    .HasMaxLength(100)
                    .HasColumnName("SERVER_NGUON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenbangNguon)
                    .HasMaxLength(50)
                    .HasColumnName("TENBANG_NGUON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CfgKhac>(entity =>
            {
                entity.HasKey(e => e.Idv)
                    .HasName("PK__CFG_KHAC__02133CD2");

                entity.ToTable("CFG_KHAC");

                entity.Property(e => e.Idv)
                    .HasMaxLength(50)
                    .HasColumnName("IDV");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(255)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Giatri)
                    .HasMaxLength(4000)
                    .HasColumnName("GIATRI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ten)
                    .HasMaxLength(100)
                    .HasColumnName("TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CfgTm>(entity =>
            {
                entity.HasKey(e => e.Idv)
                    .HasName("PK__CFG_TM__08C03A61");

                entity.ToTable("CFG_TM");

                entity.Property(e => e.Idv).HasColumnName("IDV");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(255)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Giatri)
                    .HasMaxLength(255)
                    .HasColumnName("GIATRI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ten)
                    .HasMaxLength(100)
                    .HasColumnName("TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Congthucnhapp>(entity =>
            {
                entity.ToTable("CONGTHUCNHAPPS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Congthuc)
                    .HasMaxLength(250)
                    .HasColumnName("CONGTHUC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dscotsudung)
                    .HasMaxLength(250)
                    .HasColumnName("DSCOTSUDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kieuchay).HasColumnName("KIEUCHAY");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MacotEnter)
                    .HasMaxLength(50)
                    .HasColumnName("MACOT_ENTER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MacotGan)
                    .HasMaxLength(50)
                    .HasColumnName("MACOT_GAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ctkiemke>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__CTKIEMKE__1333A733");

                entity.ToTable("CTKIEMKE");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .HasColumnName("BARCODE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Chenhlech).HasColumnName("CHENHLECH");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dg).HasColumnName("DG");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(50)
                    .HasColumnName("DVT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hansudung)
                    .HasColumnType("datetime")
                    .HasColumnName("HANSUDUNG");

                entity.Property(e => e.Lo)
                    .HasMaxLength(50)
                    .HasColumnName("LO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngaykk)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYKK");

                entity.Property(e => e.Ngaylo)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYLO");

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.Soct)
                    .HasMaxLength(50)
                    .HasColumnName("SOCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonCk).HasColumnName("TON_CK");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tt).HasColumnName("TT");
            });

            modelBuilder.Entity<Cttsdh>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__CTTSDH__245E3335");

                entity.ToTable("CTTSDH");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kybaocao)
                    .HasMaxLength(50)
                    .HasColumnName("KYBAOCAO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayDaoHan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_DAO_HAN");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HD");

                entity.Property(e => e.Ngayct)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYCT");

                entity.Property(e => e.Ngayhh)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYHH");

                entity.Property(e => e.Sapxep)
                    .HasMaxLength(10)
                    .HasColumnName("SAPXEP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soct)
                    .HasMaxLength(50)
                    .HasColumnName("SOCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SrHd)
                    .HasMaxLength(50)
                    .HasColumnName("SR_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TuoiNo).HasColumnName("TUOI_NO");

                entity.Property(e => e.Vndckco).HasColumnName("VNDCKCO");

                entity.Property(e => e.Vndckno).HasColumnName("VNDCKNO");

                entity.Property(e => e.Vndduco).HasColumnName("VNDDUCO");

                entity.Property(e => e.Vndduno).HasColumnName("VNDDUNO");

                entity.Property(e => e.Vndpsco).HasColumnName("VNDPSCO");

                entity.Property(e => e.Vndpsno).HasColumnName("VNDPSNO");
            });

            modelBuilder.Entity<Danhmucthuoc>(entity =>
            {
                entity.HasKey(e => new { e.Matk, e.Madm })
                    .HasName("PK__DANHMUCTHUOC__025333F4");

                entity.ToTable("DANHMUCTHUOC");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM");

                entity.Property(e => e.DangBaoChe)
                    .HasMaxLength(250)
                    .HasColumnName("DANG_BAO_CHE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DonViDongGoiNn)
                    .HasMaxLength(250)
                    .HasColumnName("DON_VI_DONG_GOI_NN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DonViTinh)
                    .HasMaxLength(250)
                    .HasColumnName("DON_VI_TINH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GiaBanBuon).HasColumnName("GIA_BAN_BUON");

                entity.Property(e => e.GiaKeKhai).HasColumnName("GIA_KE_KHAI");

                entity.Property(e => e.HangSanXuat)
                    .HasMaxLength(100)
                    .HasColumnName("HANG_SAN_XUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(150)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mathuoc)
                    .HasMaxLength(50)
                    .HasColumnName("MATHUOC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NhaNhapKhau)
                    .HasMaxLength(250)
                    .HasColumnName("NHA_NHAP_KHAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NongDoHamLuong)
                    .HasMaxLength(250)
                    .HasColumnName("NONG_DO_HAM_LUONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NuocSanXuat)
                    .HasMaxLength(100)
                    .HasColumnName("NUOC_SAN_XUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QuyCachDongGoi)
                    .HasMaxLength(250)
                    .HasColumnName("QUY_CACH_DONG_GOI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoDangKy)
                    .HasMaxLength(50)
                    .HasColumnName("SO_DANG_KY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoDklh)
                    .HasMaxLength(50)
                    .HasColumnName("SO_DKLH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenHoatChat)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_HOAT_CHAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DanhsachLtv>(entity =>
            {
                entity.ToTable("DANHSACH_LTV");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Chucdanh)
                    .HasMaxLength(50)
                    .HasColumnName("CHUCDANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Chucvu)
                    .HasMaxLength(50)
                    .HasColumnName("CHUCVU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Congtrinh)
                    .HasMaxLength(255)
                    .HasColumnName("CONGTRINH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Congviec)
                    .HasMaxLength(150)
                    .HasColumnName("CONGVIEC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Den)
                    .HasColumnType("datetime")
                    .HasColumnName("DEN");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NV")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Namsinh)
                    .HasMaxLength(4)
                    .HasColumnName("NAMSINH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngaycap)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYCAP");

                entity.Property(e => e.Ngaysinh)
                    .HasMaxLength(2)
                    .HasColumnName("NGAYSINH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nghenghiep)
                    .HasMaxLength(100)
                    .HasColumnName("NGHENGHIEP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NguyenQuan)
                    .HasMaxLength(255)
                    .HasColumnName("NGUYEN_QUAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Noicap)
                    .HasMaxLength(50)
                    .HasColumnName("NOICAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoCm)
                    .HasMaxLength(20)
                    .HasColumnName("SO_CM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .HasColumnName("TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thangsinh)
                    .HasMaxLength(2)
                    .HasColumnName("THANGSINH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ThuongTru)
                    .HasMaxLength(255)
                    .HasColumnName("THUONG_TRU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tienluong).HasColumnName("TIENLUONG");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tu)
                    .HasColumnType("datetime")
                    .HasColumnName("TU");
            });

            modelBuilder.Entity<DmDoanhthuNhantruoc>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__DM_DOANHTHU_NHAN__38652BE2");

                entity.ToTable("DM_DOANHTHU_NHANTRUOC");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.ChonTrichT01).HasColumnName("CHON_TRICH_T01");

                entity.Property(e => e.ChonTrichT02).HasColumnName("CHON_TRICH_T02");

                entity.Property(e => e.ChonTrichT03).HasColumnName("CHON_TRICH_T03");

                entity.Property(e => e.ChonTrichT04).HasColumnName("CHON_TRICH_T04");

                entity.Property(e => e.ChonTrichT05).HasColumnName("CHON_TRICH_T05");

                entity.Property(e => e.ChonTrichT06).HasColumnName("CHON_TRICH_T06");

                entity.Property(e => e.ChonTrichT07).HasColumnName("CHON_TRICH_T07");

                entity.Property(e => e.ChonTrichT08).HasColumnName("CHON_TRICH_T08");

                entity.Property(e => e.ChonTrichT09).HasColumnName("CHON_TRICH_T09");

                entity.Property(e => e.ChonTrichT10).HasColumnName("CHON_TRICH_T10");

                entity.Property(e => e.ChonTrichT11).HasColumnName("CHON_TRICH_T11");

                entity.Property(e => e.ChonTrichT12).HasColumnName("CHON_TRICH_T12");

                entity.Property(e => e.CoTrich)
                    .HasMaxLength(50)
                    .HasColumnName("CO_TRICH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(100)
                    .HasColumnName("DVT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GtclDaunam).HasColumnName("GTCL_DAUNAM");

                entity.Property(e => e.Kyhieu)
                    .HasMaxLength(50)
                    .HasColumnName("KYHIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LkTrichDaunam).HasColumnName("LK_TRICH_DAUNAM");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madoanhthu)
                    .HasMaxLength(50)
                    .HasColumnName("MADOANHTHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnco)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnno)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makh)
                    .HasMaxLength(50)
                    .HasColumnName("MAKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpno)
                    .HasMaxLength(100)
                    .HasColumnName("MAYTCPNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngaybatdau)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYBATDAU");

                entity.Property(e => e.Ngayhopdong)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYHOPDONG");

                entity.Property(e => e.Ngayketthuc)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYKETTHUC");

                entity.Property(e => e.Ngaythu)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYTHU");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(255)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sohopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SOHOPDONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Tendoanhthu)
                    .HasMaxLength(255)
                    .HasColumnName("TENDOANHTHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(250)
                    .HasColumnName("TENKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhom)
                    .HasMaxLength(250)
                    .HasColumnName("TENNHOM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thoigiantrich).HasColumnName("THOIGIANTRICH");

                entity.Property(e => e.TkCongno)
                    .HasMaxLength(50)
                    .HasColumnName("TK_CONGNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkDoanhthu)
                    .HasMaxLength(50)
                    .HasColumnName("TK_DOANHTHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkDoanhthuNhantruoc)
                    .HasMaxLength(100)
                    .HasColumnName("TK_DOANHTHU_NHANTRUOC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tongdoanhthu).HasColumnName("TONGDOANHTHU");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Trich1thang).HasColumnName("TRICH1THANG");
            });

            modelBuilder.Entity<Dmbaogium>(entity =>
            {
                entity.ToTable("DMBAOGIA");

                entity.Property(e => e.Id)
                    .HasMaxLength(15)
                    .HasColumnName("ID");

                entity.Property(e => e.Bguid)
                    .HasMaxLength(50)
                    .HasColumnName("BGUID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChietkhauUsd).HasColumnName("CHIETKHAU_USD");

                entity.Property(e => e.ChietkhauUsd2).HasColumnName("CHIETKHAU_USD2");

                entity.Property(e => e.ChietkhauVnd).HasColumnName("CHIETKHAU_VND");

                entity.Property(e => e.ChietkhauVnd2).HasColumnName("CHIETKHAU_VND2");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgusd).HasColumnName("DGUSD");

                entity.Property(e => e.Dgvnd).HasColumnName("DGVND");

                entity.Property(e => e.Donggoi01)
                    .HasMaxLength(50)
                    .HasColumnName("DONGGOI_01")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donggoi02)
                    .HasMaxLength(50)
                    .HasColumnName("DONGGOI_02")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(50)
                    .HasColumnName("DVT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt1)
                    .HasMaxLength(50)
                    .HasColumnName("DVT1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt2)
                    .HasMaxLength(50)
                    .HasColumnName("DVT2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhichuDh)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU_DH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhichuMh)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU_MH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ldh)
                    .HasMaxLength(50)
                    .HasColumnName("LDH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhbDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("LHB_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhbEmail)
                    .HasMaxLength(50)
                    .HasColumnName("LHB_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhbMaDt)
                    .HasMaxLength(50)
                    .HasColumnName("LHB_MA_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhbTenDt)
                    .HasMaxLength(250)
                    .HasColumnName("LHB_TEN_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnEmail)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnMaDt)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_MA_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnTenDt)
                    .HasMaxLength(250)
                    .HasColumnName("LHCN_TEN_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mabaogia)
                    .HasMaxLength(50)
                    .HasColumnName("MABAOGIA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mabaogia2)
                    .HasMaxLength(50)
                    .HasColumnName("MABAOGIA2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mahh)
                    .HasMaxLength(50)
                    .HasColumnName("MAHH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Malo)
                    .HasMaxLength(50)
                    .HasColumnName("MALO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HD");

                entity.Property(e => e.Ngaybaogia)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYBAOGIA");

                entity.Property(e => e.Ngaygiaohang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYGIAOHANG");

                entity.Property(e => e.Ngayhethan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYHETHAN");

                entity.Property(e => e.NmhDiachi)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_DIACHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhDiachiChinhanh)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_DIACHI_CHINHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhEmail)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhFax)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_FAX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMa)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMachinhanh)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MACHINHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMatinhthanh)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MATINHTHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMst)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MST")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhNlhDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_NLH_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhNlhTen)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_NLH_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTen)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTenchinhanh)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_TENCHINHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTentinhthanh)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_TENTINHTHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTknh)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_TKNH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PtChietkhau).HasColumnName("PT_CHIETKHAU");

                entity.Property(e => e.PtChietkhau2).HasColumnName("PT_CHIETKHAU2");

                entity.Property(e => e.Quycach01)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH_01")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quycach02)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH_02")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quycach03)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH_03")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Soluong1).HasColumnName("SOLUONG1");

                entity.Property(e => e.Soluong2).HasColumnName("SOLUONG2");

                entity.Property(e => e.SttBaogia).HasColumnName("STT_BAOGIA");

                entity.Property(e => e.SttKy).HasColumnName("STT_KY");

                entity.Property(e => e.SttMh).HasColumnName("STT_MH");

                entity.Property(e => e.Tenct)
                    .HasMaxLength(250)
                    .HasColumnName("TENCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenhh)
                    .HasMaxLength(50)
                    .HasColumnName("TENHH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thueusd).HasColumnName("THUEUSD");

                entity.Property(e => e.Thuevnd).HasColumnName("THUEVND");

                entity.Property(e => e.TonCk).HasColumnName("TON_CK");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TsGtgt).HasColumnName("TS_GTGT");

                entity.Property(e => e.Ttdh)
                    .HasMaxLength(10)
                    .HasColumnName("TTDH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ttusd).HasColumnName("TTUSD");

                entity.Property(e => e.TtusdTt).HasColumnName("TTUSD_TT");

                entity.Property(e => e.Ttvnd).HasColumnName("TTVND");

                entity.Property(e => e.TtvndSauCk).HasColumnName("TTVND_SAU_CK");

                entity.Property(e => e.TtvndTt).HasColumnName("TTVND_TT");

                entity.Property(e => e.Tygia).HasColumnName("TYGIA");
            });

            modelBuilder.Entity<Dmbaohanh>(entity =>
            {
                entity.HasKey(e => e.Imei)
                    .HasName("PK__DMBAOHANH__0F6D37F0");

                entity.ToTable("DMBAOHANH");

                entity.Property(e => e.Imei)
                    .HasMaxLength(50)
                    .HasColumnName("IMEI");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(250)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(250)
                    .HasColumnName("DIACHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(50)
                    .HasColumnName("DVT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(50)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Machinhanh)
                    .HasMaxLength(50)
                    .HasColumnName("MACHINHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makh)
                    .HasMaxLength(50)
                    .HasColumnName("MAKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MsDn)
                    .HasMaxLength(50)
                    .HasColumnName("MS_DN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngayban)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYBAN");

                entity.Property(e => e.Ngayhhbh)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYHHBH");

                entity.Property(e => e.Ngaynhap)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYNHAP");

                entity.Property(e => e.Ngayxuat)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYXUAT");

                entity.Property(e => e.Noidungbh)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNGBH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(250)
                    .HasColumnName("TENKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tinhtrang)
                    .HasMaxLength(50)
                    .HasColumnName("TINHTRANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkhh)
                    .HasMaxLength(50)
                    .HasColumnName("TKHH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonDk).HasColumnName("TON_DK");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Dmbarcode>(entity =>
            {
                entity.HasKey(e => new { e.Barcode, e.Matk, e.Madm, e.Madtpn, e.Lo })
                    .HasName("PK__DMBARCODE__7C8480AE");

                entity.ToTable("DMBARCODE");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .HasColumnName("BARCODE");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN");

                entity.Property(e => e.Lo)
                    .HasMaxLength(50)
                    .HasColumnName("LO");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgusd).HasColumnName("DGUSD");

                entity.Property(e => e.Dgvnd).HasColumnName("DGVND");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(255)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi1)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI_1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi2)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI_2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hansudung)
                    .HasColumnType("datetime")
                    .HasColumnName("HANSUDUNG");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(250)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kyhieu)
                    .HasMaxLength(255)
                    .HasColumnName("KYHIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngaylo)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYLO");

                entity.Property(e => e.Ngaynhapkho)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYNHAPKHO");

                entity.Property(e => e.Nhacungcap)
                    .HasMaxLength(250)
                    .HasColumnName("NHACUNGCAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhasanxuat)
                    .HasMaxLength(250)
                    .HasColumnName("NHASANXUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SttIn).HasColumnName("STT_IN");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(255)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(255)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonT).HasColumnName("TON_T");

                entity.Property(e => e.TonTDv1).HasColumnName("TON_T_DV1");

                entity.Property(e => e.TonTDv2).HasColumnName("TON_T_DV2");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsdtonT).HasColumnName("USDTON_T");

                entity.Property(e => e.VndtonT).HasColumnName("VNDTON_T");
            });

            modelBuilder.Entity<DmbarcodeLoi>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__DMBARCODE_LOI__5F7EF903");

                entity.ToTable("DMBARCODE_LOI");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .HasColumnName("BARCODE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diachigiaohang)
                    .HasMaxLength(250)
                    .HasColumnName("DIACHIGIAOHANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(20)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdChungtu).HasColumnName("ID_CHUNGTU");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(25)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makh)
                    .HasMaxLength(50)
                    .HasColumnName("MAKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngayct)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYCT");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.SttScan).HasColumnName("STT_SCAN");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(255)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(50)
                    .HasColumnName("TENKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DmchietkhauDtHh>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__DMCHIETKHAU_DT_H__7291CD77");

                entity.ToTable("DMCHIETKHAU_DT_HH");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(50)
                    .HasColumnName("DVT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngaybatdau)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYBATDAU");

                entity.Property(e => e.Ngaykethuc)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYKETHUC");

                entity.Property(e => e.PtCk1).HasColumnName("PT_CK1");

                entity.Property(e => e.PtCk2).HasColumnName("PT_CK2");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(150)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(150)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TtCk1).HasColumnName("TT_CK1");

                entity.Property(e => e.TtCk2).HasColumnName("TT_CK2");
            });

            modelBuilder.Entity<Dmcpcpb>(entity =>
            {
                entity.HasKey(e => e.Mats)
                    .HasName("PK__DMCPCPB__139DBB87");

                entity.ToTable("DMCPCPB");

                entity.Property(e => e.Mats)
                    .HasMaxLength(50)
                    .HasColumnName("MATS");

                entity.Property(e => e.ChonKhT01).HasColumnName("CHON_KH_T01");

                entity.Property(e => e.ChonKhT02).HasColumnName("CHON_KH_T02");

                entity.Property(e => e.ChonKhT03).HasColumnName("CHON_KH_T03");

                entity.Property(e => e.ChonKhT04).HasColumnName("CHON_KH_T04");

                entity.Property(e => e.ChonKhT05).HasColumnName("CHON_KH_T05");

                entity.Property(e => e.ChonKhT06).HasColumnName("CHON_KH_T06");

                entity.Property(e => e.ChonKhT07).HasColumnName("CHON_KH_T07");

                entity.Property(e => e.ChonKhT08).HasColumnName("CHON_KH_T08");

                entity.Property(e => e.ChonKhT09).HasColumnName("CHON_KH_T09");

                entity.Property(e => e.ChonKhT10).HasColumnName("CHON_KH_T10");

                entity.Property(e => e.ChonKhT11).HasColumnName("CHON_KH_T11");

                entity.Property(e => e.ChonKhT12).HasColumnName("CHON_KH_T12");

                entity.Property(e => e.CoKh)
                    .HasMaxLength(50)
                    .HasColumnName("CO_KH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DsThangKkh)
                    .HasMaxLength(50)
                    .HasColumnName("DS_THANG_KKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dtsudung)
                    .HasMaxLength(255)
                    .HasColumnName("DTSUDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(100)
                    .HasColumnName("DVT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GtconlaiDaunam).HasColumnName("GTCONLAI_DAUNAM");

                entity.Property(e => e.GtconlaiDaunamUsd).HasColumnName("GTCONLAI_DAUNAM_USD");

                entity.Property(e => e.Kh1thang).HasColumnName("KH1THANG");

                entity.Property(e => e.Kh1thangUsd).HasColumnName("KH1THANG_USD");

                entity.Property(e => e.Kyhieu)
                    .HasMaxLength(50)
                    .HasColumnName("KYHIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LkkhDaunam).HasColumnName("LKKH_DAUNAM");

                entity.Property(e => e.LkkhDaunamUsd).HasColumnName("LKKH_DAUNAM_USD");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnco)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnno)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom1)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MatsMe)
                    .HasMaxLength(50)
                    .HasColumnName("MATS_ME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpno)
                    .HasMaxLength(100)
                    .HasColumnName("MAYTCPNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .HasColumnName("MODEL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Namsanxuat).HasColumnName("NAMSANXUAT");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HD");

                entity.Property(e => e.Ngayban)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYBAN");

                entity.Property(e => e.Ngaymua)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYMUA");

                entity.Property(e => e.Ngaytrichkh)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYTRICHKH");

                entity.Property(e => e.Nguyengia).HasColumnName("NGUYENGIA");

                entity.Property(e => e.NguyengiaUsd).HasColumnName("NGUYENGIA_USD");

                entity.Property(e => e.Nuocsanxuat)
                    .HasMaxLength(50)
                    .HasColumnName("NUOCSANXUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quycach)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Tennhom)
                    .HasMaxLength(250)
                    .HasColumnName("TENNHOM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhom1)
                    .HasMaxLength(250)
                    .HasColumnName("TENNHOM1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tents)
                    .HasMaxLength(255)
                    .HasColumnName("TENTS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TentsMe)
                    .HasMaxLength(250)
                    .HasColumnName("TENTS_ME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thoigiankh).HasColumnName("THOIGIANKH");

                entity.Property(e => e.Tkcp)
                    .HasMaxLength(50)
                    .HasColumnName("TKCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkhm)
                    .HasMaxLength(50)
                    .HasColumnName("TKHM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkts)
                    .HasMaxLength(100)
                    .HasColumnName("TKTS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tygia).HasColumnName("TYGIA");
            });

            modelBuilder.Entity<DmcpcpbTkcp>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.Mats, e.Tkcp })
                    .HasName("PK__DMCPCPB_TKCP__58DCE86C");

                entity.ToTable("DMCPCPB_TKCP");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Mats)
                    .HasMaxLength(50)
                    .HasColumnName("MATS");

                entity.Property(e => e.Tkcp)
                    .HasMaxLength(50)
                    .HasColumnName("TKCP");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ptpb).HasColumnName("PTPB");

                entity.Property(e => e.Tents)
                    .HasMaxLength(255)
                    .HasColumnName("TENTS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TtvndKh).HasColumnName("TTVND_KH");
            });

            modelBuilder.Entity<Dmcttp>(entity =>
            {
                entity.HasKey(e => new { e.MaCt, e.Matp })
                    .HasName("PK__DMCTTP__36DC0ACC");

                entity.ToTable("DMCTTP");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT");

                entity.Property(e => e.Matp)
                    .HasMaxLength(50)
                    .HasColumnName("MATP");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DgDh).HasColumnName("DG_DH");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(50)
                    .HasColumnName("DVT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makh)
                    .HasMaxLength(50)
                    .HasColumnName("MAKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayHopdong)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HOPDONG");

                entity.Property(e => e.SlDh).HasColumnName("SL_DH");

                entity.Property(e => e.SoHopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HOPDONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct)
                    .HasMaxLength(200)
                    .HasColumnName("TENCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(250)
                    .HasColumnName("TENKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tentp)
                    .HasMaxLength(250)
                    .HasColumnName("TENTP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TtDh).HasColumnName("TT_DH");

                entity.Property(e => e.TylePb).HasColumnName("TYLE_PB");
            });

            modelBuilder.Entity<Dmdatabase>(entity =>
            {
                entity.HasKey(e => e.Tendatabase)
                    .HasName("PK__DMDATABASE__3726EEE6");

                entity.ToTable("DMDATABASE");

                entity.Property(e => e.Tendatabase)
                    .HasMaxLength(50)
                    .HasColumnName("TENDATABASE");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Namhachtoan).HasColumnName("NAMHACHTOAN");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DmdgbanMin>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Stt })
                    .HasName("PK__DMDGBAN_MIN__09E968C4");

                entity.ToTable("DMDGBAN_MIN");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .HasColumnName("ID");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgbanchuan).HasColumnName("DGBANCHUAN");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngayad)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYAD");

                entity.Property(e => e.Ngaykethuc)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYKETHUC");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Dmdhban>(entity =>
            {
                entity.ToTable("DMDHBAN");

                entity.Property(e => e.Id)
                    .HasMaxLength(15)
                    .HasColumnName("ID");

                entity.Property(e => e.ChietkhauUsd).HasColumnName("CHIETKHAU_USD");

                entity.Property(e => e.ChietkhauUsd2).HasColumnName("CHIETKHAU_USD2");

                entity.Property(e => e.ChietkhauVnd).HasColumnName("CHIETKHAU_VND");

                entity.Property(e => e.ChietkhauVnd2).HasColumnName("CHIETKHAU_VND2");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgusd).HasColumnName("DGUSD");

                entity.Property(e => e.Dgvnd).HasColumnName("DGVND");

                entity.Property(e => e.Dhguid)
                    .HasMaxLength(50)
                    .HasColumnName("DHGUID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donggoi01)
                    .HasMaxLength(50)
                    .HasColumnName("DONGGOI_01")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donggoi02)
                    .HasMaxLength(50)
                    .HasColumnName("DONGGOI_02")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(50)
                    .HasColumnName("DVT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt1)
                    .HasMaxLength(50)
                    .HasColumnName("DVT1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt2)
                    .HasMaxLength(50)
                    .HasColumnName("DVT2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhichuDh)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU_DH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhichuMh)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU_MH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ldh)
                    .HasMaxLength(50)
                    .HasColumnName("LDH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhbDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("LHB_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhbEmail)
                    .HasMaxLength(50)
                    .HasColumnName("LHB_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhbMaDt)
                    .HasMaxLength(50)
                    .HasColumnName("LHB_MA_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhbTenDt)
                    .HasMaxLength(250)
                    .HasColumnName("LHB_TEN_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnEmail)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnMaDt)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_MA_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnTenDt)
                    .HasMaxLength(250)
                    .HasColumnName("LHCN_TEN_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Luong01Cl).HasColumnName("LUONG_01_CL");

                entity.Property(e => e.Luong01LkCk).HasColumnName("LUONG_01_LK_CK");

                entity.Property(e => e.Luong01LkDk).HasColumnName("LUONG_01_LK_DK");

                entity.Property(e => e.Luong01PsTk).HasColumnName("LUONG_01_PS_TK");

                entity.Property(e => e.Luong02Cl).HasColumnName("LUONG_02_CL");

                entity.Property(e => e.Luong02LkCk).HasColumnName("LUONG_02_LK_CK");

                entity.Property(e => e.Luong02LkDk).HasColumnName("LUONG_02_LK_DK");

                entity.Property(e => e.Luong02PsTk).HasColumnName("LUONG_02_PS_TK");

                entity.Property(e => e.Luong03Cl).HasColumnName("LUONG_03_CL");

                entity.Property(e => e.Luong03LkCk).HasColumnName("LUONG_03_LK_CK");

                entity.Property(e => e.Luong03LkDk).HasColumnName("LUONG_03_LK_DK");

                entity.Property(e => e.Luong03PsTk).HasColumnName("LUONG_03_PS_TK");

                entity.Property(e => e.LuongDv1Cl).HasColumnName("LUONG_DV1_CL");

                entity.Property(e => e.LuongDv1LkCk).HasColumnName("LUONG_DV1_LK_CK");

                entity.Property(e => e.LuongDv1LkDk).HasColumnName("LUONG_DV1_LK_DK");

                entity.Property(e => e.LuongDv1PsTk).HasColumnName("LUONG_DV1_PS_TK");

                entity.Property(e => e.LuongDv2Cl).HasColumnName("LUONG_DV2_CL");

                entity.Property(e => e.LuongDv2LkCk).HasColumnName("LUONG_DV2_LK_CK");

                entity.Property(e => e.LuongDv2LkDk).HasColumnName("LUONG_DV2_LK_DK");

                entity.Property(e => e.LuongDv2PsTk).HasColumnName("LUONG_DV2_PS_TK");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madonhang)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madonhang2)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANG2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mahh)
                    .HasMaxLength(50)
                    .HasColumnName("MAHH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Malo)
                    .HasMaxLength(50)
                    .HasColumnName("MALO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HD");

                entity.Property(e => e.Ngaydonhang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYDONHANG");

                entity.Property(e => e.Ngaygiaohang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYGIAOHANG");

                entity.Property(e => e.Ngayhethan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYHETHAN");

                entity.Property(e => e.NmhDiachi)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_DIACHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhDiachiChinhanh)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_DIACHI_CHINHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhEmail)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhFax)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_FAX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMa)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMachinhanh)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MACHINHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMatinhthanh)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MATINHTHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMst)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MST")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhNlhDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_NLH_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhNlhTen)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_NLH_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTen)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTenchinhanh)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_TENCHINHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTentinhthanh)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_TENTINHTHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTknh)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_TKNH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PtChietkhau).HasColumnName("PT_CHIETKHAU");

                entity.Property(e => e.PtChietkhau2).HasColumnName("PT_CHIETKHAU2");

                entity.Property(e => e.Quycach01)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH_01")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quycach02)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH_02")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quycach03)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH_03")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Soluong1).HasColumnName("SOLUONG1");

                entity.Property(e => e.Soluong2).HasColumnName("SOLUONG2");

                entity.Property(e => e.SttDonhang).HasColumnName("STT_DONHANG");

                entity.Property(e => e.SttKy).HasColumnName("STT_KY");

                entity.Property(e => e.SttMh).HasColumnName("STT_MH");

                entity.Property(e => e.Tenct)
                    .HasMaxLength(250)
                    .HasColumnName("TENCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenhh)
                    .HasMaxLength(50)
                    .HasColumnName("TENHH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thueusd).HasColumnName("THUEUSD");

                entity.Property(e => e.Thuevnd).HasColumnName("THUEVND");

                entity.Property(e => e.TonCk).HasColumnName("TON_CK");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TsGtgt).HasColumnName("TS_GTGT");

                entity.Property(e => e.Ttdh)
                    .HasMaxLength(10)
                    .HasColumnName("TTDH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ttusd).HasColumnName("TTUSD");

                entity.Property(e => e.Ttusd01Cl).HasColumnName("TTUSD_01_CL");

                entity.Property(e => e.Ttusd01LkCk).HasColumnName("TTUSD_01_LK_CK");

                entity.Property(e => e.Ttusd01LkDk).HasColumnName("TTUSD_01_LK_DK");

                entity.Property(e => e.Ttusd01PsTk).HasColumnName("TTUSD_01_PS_TK");

                entity.Property(e => e.Ttusd02Cl).HasColumnName("TTUSD_02_CL");

                entity.Property(e => e.Ttusd02LkCk).HasColumnName("TTUSD_02_LK_CK");

                entity.Property(e => e.Ttusd02LkDk).HasColumnName("TTUSD_02_LK_DK");

                entity.Property(e => e.Ttusd02PsTk).HasColumnName("TTUSD_02_PS_TK");

                entity.Property(e => e.Ttusd03Cl).HasColumnName("TTUSD_03_CL");

                entity.Property(e => e.Ttusd03LkCk).HasColumnName("TTUSD_03_LK_CK");

                entity.Property(e => e.Ttusd03LkDk).HasColumnName("TTUSD_03_LK_DK");

                entity.Property(e => e.Ttusd03PsTk).HasColumnName("TTUSD_03_PS_TK");

                entity.Property(e => e.TtusdSauCk).HasColumnName("TTUSD_SAU_CK");

                entity.Property(e => e.TtusdTt).HasColumnName("TTUSD_TT");

                entity.Property(e => e.Ttvnd).HasColumnName("TTVND");

                entity.Property(e => e.Ttvnd01Cl).HasColumnName("TTVND_01_CL");

                entity.Property(e => e.Ttvnd01LkCk).HasColumnName("TTVND_01_LK_CK");

                entity.Property(e => e.Ttvnd01LkDk).HasColumnName("TTVND_01_LK_DK");

                entity.Property(e => e.Ttvnd01PsTk).HasColumnName("TTVND_01_PS_TK");

                entity.Property(e => e.Ttvnd02Cl).HasColumnName("TTVND_02_CL");

                entity.Property(e => e.Ttvnd02LkCk).HasColumnName("TTVND_02_LK_CK");

                entity.Property(e => e.Ttvnd02LkDk).HasColumnName("TTVND_02_LK_DK");

                entity.Property(e => e.Ttvnd02PsTk).HasColumnName("TTVND_02_PS_TK");

                entity.Property(e => e.Ttvnd03Cl).HasColumnName("TTVND_03_CL");

                entity.Property(e => e.Ttvnd03LkCk).HasColumnName("TTVND_03_LK_CK");

                entity.Property(e => e.Ttvnd03LkDk).HasColumnName("TTVND_03_LK_DK");

                entity.Property(e => e.Ttvnd03PsTk).HasColumnName("TTVND_03_PS_TK");

                entity.Property(e => e.TtvndSauCk).HasColumnName("TTVND_SAU_CK");

                entity.Property(e => e.TtvndTt).HasColumnName("TTVND_TT");

                entity.Property(e => e.Tygia).HasColumnName("TYGIA");
            });

            modelBuilder.Entity<Dmdhmua>(entity =>
            {
                entity.ToTable("DMDHMUA");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.ChietkhauUsd).HasColumnName("CHIETKHAU_USD");

                entity.Property(e => e.ChietkhauVnd).HasColumnName("CHIETKHAU_VND");

                entity.Property(e => e.Chonky)
                    .HasMaxLength(5)
                    .HasColumnName("CHONKY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgusd).HasColumnName("DGUSD");

                entity.Property(e => e.Dgvnd).HasColumnName("DGVND");

                entity.Property(e => e.Dhguid)
                    .HasMaxLength(50)
                    .HasColumnName("DHGUID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donggoi01)
                    .HasMaxLength(50)
                    .HasColumnName("DONGGOI_01")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donggoi02)
                    .HasMaxLength(50)
                    .HasColumnName("DONGGOI_02")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(50)
                    .HasColumnName("DVT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt1)
                    .HasMaxLength(50)
                    .HasColumnName("DVT1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt2)
                    .HasMaxLength(50)
                    .HasColumnName("DVT2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt3)
                    .HasMaxLength(50)
                    .HasColumnName("DVT3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhichuDh)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU_DH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhichuMh)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU_MH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ldh)
                    .HasMaxLength(50)
                    .HasColumnName("LDH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnDoituong)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_DOITUONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnEmail)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnMaDt)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_MA_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnTenDt)
                    .HasMaxLength(250)
                    .HasColumnName("LHCN_TEN_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhmDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("LHM_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhmDoituong)
                    .HasMaxLength(50)
                    .HasColumnName("LHM_DOITUONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhmEmail)
                    .HasMaxLength(50)
                    .HasColumnName("LHM_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhmMaDt)
                    .HasMaxLength(50)
                    .HasColumnName("LHM_MA_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhmTenDt)
                    .HasMaxLength(250)
                    .HasColumnName("LHM_TEN_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Luong01Cl).HasColumnName("LUONG_01_CL");

                entity.Property(e => e.Luong01LkCk).HasColumnName("LUONG_01_LK_CK");

                entity.Property(e => e.Luong01LkDk).HasColumnName("LUONG_01_LK_DK");

                entity.Property(e => e.Luong01PsTk).HasColumnName("LUONG_01_PS_TK");

                entity.Property(e => e.Luong02Cl).HasColumnName("LUONG_02_CL");

                entity.Property(e => e.Luong02LkCk).HasColumnName("LUONG_02_LK_CK");

                entity.Property(e => e.Luong02LkDk).HasColumnName("LUONG_02_LK_DK");

                entity.Property(e => e.Luong02PsTk).HasColumnName("LUONG_02_PS_TK");

                entity.Property(e => e.Luong03Cl).HasColumnName("LUONG_03_CL");

                entity.Property(e => e.Luong03LkCk).HasColumnName("LUONG_03_LK_CK");

                entity.Property(e => e.Luong03LkDk).HasColumnName("LUONG_03_LK_DK");

                entity.Property(e => e.Luong03PsTk).HasColumnName("LUONG_03_PS_TK");

                entity.Property(e => e.LuongDv1Cl).HasColumnName("LUONG_DV1_CL");

                entity.Property(e => e.LuongDv1LkCk).HasColumnName("LUONG_DV1_LK_CK");

                entity.Property(e => e.LuongDv1LkDk).HasColumnName("LUONG_DV1_LK_DK");

                entity.Property(e => e.LuongDv1PsTk).HasColumnName("LUONG_DV1_PS_TK");

                entity.Property(e => e.LuongDv2Cl).HasColumnName("LUONG_DV2_CL");

                entity.Property(e => e.LuongDv2LkCk).HasColumnName("LUONG_DV2_LK_CK");

                entity.Property(e => e.LuongDv2LkDk).HasColumnName("LUONG_DV2_LK_DK");

                entity.Property(e => e.LuongDv2PsTk).HasColumnName("LUONG_DV2_PS_TK");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madonhang)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MadonhangBan)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANG_BAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mahh)
                    .HasMaxLength(50)
                    .HasColumnName("MAHH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccDiachi)
                    .HasMaxLength(250)
                    .HasColumnName("NCC_DIACHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccEmail)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccFax)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_FAX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccMa)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_MA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccMst)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_MST")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccNlhDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_NLH_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccNlhTen)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_NLH_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccTen)
                    .HasMaxLength(250)
                    .HasColumnName("NCC_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccTknh)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_TKNH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HD");

                entity.Property(e => e.Ngaydonhang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYDONHANG");

                entity.Property(e => e.Ngaygiaohang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYGIAOHANG");

                entity.Property(e => e.Ngayhethan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYHETHAN");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PtChietkhau).HasColumnName("PT_CHIETKHAU");

                entity.Property(e => e.Quycach01)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH_01")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quycach02)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH_02")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quycach03)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH_03")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sodonhang)
                    .HasMaxLength(50)
                    .HasColumnName("SODONHANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Soluong1).HasColumnName("SOLUONG1");

                entity.Property(e => e.Soluong2).HasColumnName("SOLUONG2");

                entity.Property(e => e.Soluong3).HasColumnName("SOLUONG3");

                entity.Property(e => e.SttDonhang).HasColumnName("STT_DONHANG");

                entity.Property(e => e.SttKy).HasColumnName("STT_KY");

                entity.Property(e => e.SttMh).HasColumnName("STT_MH");

                entity.Property(e => e.Tenct)
                    .HasMaxLength(250)
                    .HasColumnName("TENCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenhh)
                    .HasMaxLength(50)
                    .HasColumnName("TENHH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thueusd).HasColumnName("THUEUSD");

                entity.Property(e => e.Thuevnd).HasColumnName("THUEVND");

                entity.Property(e => e.TonCk).HasColumnName("TON_CK");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TsGtgt).HasColumnName("TS_GTGT");

                entity.Property(e => e.Ttdh)
                    .HasMaxLength(10)
                    .HasColumnName("TTDH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ttusd).HasColumnName("TTUSD");

                entity.Property(e => e.Ttusd01Cl).HasColumnName("TTUSD_01_CL");

                entity.Property(e => e.Ttusd01LkCk).HasColumnName("TTUSD_01_LK_CK");

                entity.Property(e => e.Ttusd01LkDk).HasColumnName("TTUSD_01_LK_DK");

                entity.Property(e => e.Ttusd01PsTk).HasColumnName("TTUSD_01_PS_TK");

                entity.Property(e => e.Ttusd02Cl).HasColumnName("TTUSD_02_CL");

                entity.Property(e => e.Ttusd02LkCk).HasColumnName("TTUSD_02_LK_CK");

                entity.Property(e => e.Ttusd02LkDk).HasColumnName("TTUSD_02_LK_DK");

                entity.Property(e => e.Ttusd02PsTk).HasColumnName("TTUSD_02_PS_TK");

                entity.Property(e => e.Ttusd03Cl).HasColumnName("TTUSD_03_CL");

                entity.Property(e => e.Ttusd03LkCk).HasColumnName("TTUSD_03_LK_CK");

                entity.Property(e => e.Ttusd03LkDk).HasColumnName("TTUSD_03_LK_DK");

                entity.Property(e => e.Ttusd03PsTk).HasColumnName("TTUSD_03_PS_TK");

                entity.Property(e => e.TtusdSauCk).HasColumnName("TTUSD_SAU_CK");

                entity.Property(e => e.TtusdTt).HasColumnName("TTUSD_TT");

                entity.Property(e => e.Ttvnd).HasColumnName("TTVND");

                entity.Property(e => e.Ttvnd01Cl).HasColumnName("TTVND_01_CL");

                entity.Property(e => e.Ttvnd01LkCk).HasColumnName("TTVND_01_LK_CK");

                entity.Property(e => e.Ttvnd01LkDk).HasColumnName("TTVND_01_LK_DK");

                entity.Property(e => e.Ttvnd02Cl).HasColumnName("TTVND_02_CL");

                entity.Property(e => e.Ttvnd02LkCk).HasColumnName("TTVND_02_LK_CK");

                entity.Property(e => e.Ttvnd02LkDk).HasColumnName("TTVND_02_LK_DK");

                entity.Property(e => e.Ttvnd02PsTk).HasColumnName("TTVND_02_PS_TK");

                entity.Property(e => e.Ttvnd03Cl).HasColumnName("TTVND_03_CL");

                entity.Property(e => e.Ttvnd03LkCk).HasColumnName("TTVND_03_LK_CK");

                entity.Property(e => e.Ttvnd03LkDk).HasColumnName("TTVND_03_LK_DK");

                entity.Property(e => e.Ttvnd03PsTk).HasColumnName("TTVND_03_PS_TK");

                entity.Property(e => e.TtvndSauCk).HasColumnName("TTVND_SAU_CK");

                entity.Property(e => e.TtvndTt).HasColumnName("TTVND_TT");

                entity.Property(e => e.Tygia).HasColumnName("TYGIA");
            });

            modelBuilder.Entity<Dmhhlo>(entity =>
            {
                entity.HasKey(e => e.Lo)
                    .HasName("PK__DMHHLO__44A01A3E");

                entity.ToTable("DMHHLO");

                entity.Property(e => e.Lo)
                    .HasMaxLength(50)
                    .HasColumnName("LO");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hansudung)
                    .HasColumnType("datetime")
                    .HasColumnName("HANSUDUNG");

                entity.Property(e => e.Mavitri)
                    .HasMaxLength(50)
                    .HasColumnName("MAVITRI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngaylo)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYLO");

                entity.Property(e => e.Nhacungcap)
                    .HasMaxLength(250)
                    .HasColumnName("NHACUNGCAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhasanxuat)
                    .HasMaxLength(250)
                    .HasColumnName("NHASANXUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenlo)
                    .HasMaxLength(250)
                    .HasColumnName("TENLO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenvitri)
                    .HasMaxLength(250)
                    .HasColumnName("TENVITRI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Dmhoadon>(entity =>
            {
                entity.ToTable("DMHOADON");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dsphieuthu)
                    .HasMaxLength(250)
                    .HasColumnName("DSPHIEUTHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Namps)
                    .HasMaxLength(50)
                    .HasColumnName("NAMPS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayDaoHan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_DAO_HAN");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HD");

                entity.Property(e => e.Ngayct)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYCT");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoHopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HOPDONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soct)
                    .HasMaxLength(50)
                    .HasColumnName("SOCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.SrHd)
                    .HasMaxLength(50)
                    .HasColumnName("SR_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ttusd).HasColumnName("TTUSD");

                entity.Property(e => e.Ttvnd).HasColumnName("TTVND");

                entity.Property(e => e.Tygia).HasColumnName("TYGIA");
            });

            modelBuilder.Entity<Dmhopdong>(entity =>
            {
                entity.HasKey(e => e.Mahopdong)
                    .HasName("PK__DMHOPDONG__5C979F60");

                entity.ToTable("DMHOPDONG");

                entity.Property(e => e.Mahopdong)
                    .HasMaxLength(50)
                    .HasColumnName("MAHOPDONG");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(250)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GtUsd).HasColumnName("GT_USD");

                entity.Property(e => e.GtVnd).HasColumnName("GT_VND");

                entity.Property(e => e.HanmucUsd).HasColumnName("HANMUC_USD");

                entity.Property(e => e.HanmucVnd).HasColumnName("HANMUC_VND");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayDaoHan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_DAO_HAN");

                entity.Property(e => e.NgayGiaoHang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_GIAO_HANG");

                entity.Property(e => e.NgayHopdong)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HOPDONG");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoHopdongGoc)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HOPDONG_GOC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tylelaivay)
                    .HasMaxLength(200)
                    .HasColumnName("TYLELAIVAY")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Dmkheuoc>(entity =>
            {
                entity.HasKey(e => new { e.Matk, e.Madtpn, e.SoHopdong, e.Sokheuoc })
                    .HasName("PK__DMKHEUOC__6517D6C8");

                entity.ToTable("DMKHEUOC");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN");

                entity.Property(e => e.SoHopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HOPDONG");

                entity.Property(e => e.Sokheuoc)
                    .HasMaxLength(50)
                    .HasColumnName("SOKHEUOC");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DsLaiSuat)
                    .HasMaxLength(150)
                    .HasColumnName("DS_LAI_SUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GtHdUsd).HasColumnName("GT_HD_USD");

                entity.Property(e => e.GtHdVnd).HasColumnName("GT_HD_VND");

                entity.Property(e => e.GtKheuocUsd).HasColumnName("GT_KHEUOC_USD");

                entity.Property(e => e.GtKheuocVnd).HasColumnName("GT_KHEUOC_VND");

                entity.Property(e => e.HanmucUsd).HasColumnName("HANMUC_USD");

                entity.Property(e => e.HanmucVnd).HasColumnName("HANMUC_VND");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(250)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LaiSuatVay).HasColumnName("LAI_SUAT_VAY");

                entity.Property(e => e.NgayDaoHan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_DAO_HAN");

                entity.Property(e => e.NgayHopdong)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HOPDONG");

                entity.Property(e => e.Ngaykheuoc)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYKHEUOC");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(550)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(255)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkCpVay)
                    .HasMaxLength(50)
                    .HasColumnName("TK_CP_VAY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Dmkyhachtoan>(entity =>
            {
                entity.HasKey(e => e.Kyhachtoan)
                    .HasName("PK__DMKYHACHTOAN__43E1002F");

                entity.ToTable("DMKYHACHTOAN");

                entity.Property(e => e.Kyhachtoan)
                    .HasMaxLength(10)
                    .HasColumnName("KYHACHTOAN");

                entity.Property(e => e.Danhdau).HasColumnName("DANHDAU");

                entity.Property(e => e.Denngay)
                    .HasColumnType("datetime")
                    .HasColumnName("DENNGAY");

                entity.Property(e => e.Nam).HasColumnName("NAM");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tungay)
                    .HasColumnType("datetime")
                    .HasColumnName("TUNGAY");
            });

            modelBuilder.Entity<Dmlenhsx>(entity =>
            {
                entity.HasKey(e => e.MaLenh)
                    .HasName("PK__DMLENHSX__443605EA");

                entity.ToTable("DMLENHSX");

                entity.Property(e => e.MaLenh)
                    .HasMaxLength(50)
                    .HasColumnName("MA_LENH");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayLenh)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_LENH");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenLenh)
                    .HasMaxLength(50)
                    .HasColumnName("TEN_LENH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Dmmaysudung>(entity =>
            {
                entity.ToTable("DMMAYSUDUNG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Computer)
                    .HasMaxLength(100)
                    .HasColumnName("COMPUTER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hddid)
                    .HasMaxLength(50)
                    .HasColumnName("HDDID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sudung)
                    .HasMaxLength(10)
                    .HasColumnName("SUDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Dmnghiepvu>(entity =>
            {
                entity.HasKey(e => e.Manghiepvu)
                    .HasName("PK__DMNGHIEPVU__40BA7AC1");

                entity.ToTable("DMNGHIEPVU");

                entity.Property(e => e.Manghiepvu)
                    .HasMaxLength(50)
                    .HasColumnName("MANGHIEPVU");

                entity.Property(e => e.CopyToMadt)
                    .HasMaxLength(1)
                    .HasColumnName("COPY_TO_MADT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(250)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DgVc).HasColumnName("DG_VC");

                entity.Property(e => e.Dgvnd).HasColumnName("DGVND");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(250)
                    .HasColumnName("DIACHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diachikh)
                    .HasMaxLength(250)
                    .HasColumnName("DIACHIKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diengiai)
                    .HasMaxLength(250)
                    .HasColumnName("DIENGIAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DtNhan)
                    .HasMaxLength(50)
                    .HasColumnName("DT_NHAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DtXuat)
                    .HasMaxLength(50)
                    .HasColumnName("DT_XUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hdvat)
                    .HasMaxLength(50)
                    .HasColumnName("HDVAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Httt)
                    .HasMaxLength(50)
                    .HasColumnName("HTTT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imei)
                    .HasMaxLength(50)
                    .HasColumnName("IMEI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Invoi)
                    .HasMaxLength(50)
                    .HasColumnName("INVOI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Khachhang)
                    .HasMaxLength(250)
                    .HasColumnName("KHACHHANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lenhsx)
                    .HasMaxLength(50)
                    .HasColumnName("LENHSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Luong).HasColumnName("LUONG");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaNvBan)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NV_BAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaTiepThi)
                    .HasMaxLength(50)
                    .HasColumnName("MA_TIEP_THI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaTt)
                    .HasMaxLength(10)
                    .HasColumnName("MA_TT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaVung)
                    .HasMaxLength(50)
                    .HasColumnName("MA_VUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mabpsx)
                    .HasMaxLength(50)
                    .HasColumnName("MABPSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madmco)
                    .HasMaxLength(50)
                    .HasColumnName("MADMCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madmno)
                    .HasMaxLength(50)
                    .HasColumnName("MADMNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtgt)
                    .HasMaxLength(50)
                    .HasColumnName("MADTGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnco)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnno)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makh)
                    .HasMaxLength(100)
                    .HasColumnName("MAKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mangd)
                    .HasMaxLength(50)
                    .HasColumnName("MANGD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mathang)
                    .HasMaxLength(250)
                    .HasColumnName("MATHANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matttu)
                    .HasMaxLength(50)
                    .HasColumnName("MATTTU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpco)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCPCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpno)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCPNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MsDn)
                    .HasMaxLength(50)
                    .HasColumnName("MS_DN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NvBan)
                    .HasMaxLength(250)
                    .HasColumnName("NV_BAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PtCk).HasColumnName("PT_CK");

                entity.Property(e => e.PtVc).HasColumnName("PT_VC");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoHopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HOPDONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sokheuoc)
                    .HasMaxLength(50)
                    .HasColumnName("SOKHEUOC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sopgh)
                    .HasMaxLength(50)
                    .HasColumnName("SOPGH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SrHd)
                    .HasMaxLength(50)
                    .HasColumnName("SR_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(250)
                    .HasColumnName("TENKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkXuatkho)
                    .HasMaxLength(50)
                    .HasColumnName("TK_XUATKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkco)
                    .HasMaxLength(50)
                    .HasColumnName("TKCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkno)
                    .HasMaxLength(50)
                    .HasColumnName("TKNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkthue)
                    .HasMaxLength(50)
                    .HasColumnName("TKTHUE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TsGtgt)
                    .HasMaxLength(50)
                    .HasColumnName("TS_GTGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TsNk).HasColumnName("TS_NK");

                entity.Property(e => e.Ttusd).HasColumnName("TTUSD");

                entity.Property(e => e.Ttvnd).HasColumnName("TTVND");
            });

            modelBuilder.Entity<Dmthongbao>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__DMTHONGBAO__00DFECCE");

                entity.ToTable("DMTHONGBAO");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dieukien)
                    .HasMaxLength(50)
                    .HasColumnName("DIEUKIEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenbang)
                    .HasMaxLength(50)
                    .HasColumnName("TENBANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Dmtrangthai>(entity =>
            {
                entity.HasKey(e => new { e.Mauser, e.Matrangthai, e.Nhomtrangthai })
                    .HasName("PK__DMTRANGTHAI__023E255B");

                entity.ToTable("DMTRANGTHAI");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER");

                entity.Property(e => e.Matrangthai)
                    .HasMaxLength(20)
                    .HasColumnName("MATRANGTHAI");

                entity.Property(e => e.Nhomtrangthai)
                    .HasMaxLength(15)
                    .HasColumnName("NHOMTRANGTHAI");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tentrangthai)
                    .HasMaxLength(50)
                    .HasColumnName("TENTRANGTHAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Dmtscd>(entity =>
            {
                entity.HasKey(e => e.Mats)
                    .HasName("PK__DMTSCD__4535171B");

                entity.ToTable("DMTSCD");

                entity.Property(e => e.Mats)
                    .HasMaxLength(50)
                    .HasColumnName("MATS");

                entity.Property(e => e.ChonKhT01).HasColumnName("CHON_KH_T01");

                entity.Property(e => e.ChonKhT02).HasColumnName("CHON_KH_T02");

                entity.Property(e => e.ChonKhT03).HasColumnName("CHON_KH_T03");

                entity.Property(e => e.ChonKhT04).HasColumnName("CHON_KH_T04");

                entity.Property(e => e.ChonKhT05).HasColumnName("CHON_KH_T05");

                entity.Property(e => e.ChonKhT06).HasColumnName("CHON_KH_T06");

                entity.Property(e => e.ChonKhT07).HasColumnName("CHON_KH_T07");

                entity.Property(e => e.ChonKhT08).HasColumnName("CHON_KH_T08");

                entity.Property(e => e.ChonKhT09).HasColumnName("CHON_KH_T09");

                entity.Property(e => e.ChonKhT10).HasColumnName("CHON_KH_T10");

                entity.Property(e => e.ChonKhT11).HasColumnName("CHON_KH_T11");

                entity.Property(e => e.ChonKhT12).HasColumnName("CHON_KH_T12");

                entity.Property(e => e.CoKh)
                    .HasMaxLength(50)
                    .HasColumnName("CO_KH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DsThangKkh)
                    .HasMaxLength(50)
                    .HasColumnName("DS_THANG_KKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dtsudung)
                    .HasMaxLength(255)
                    .HasColumnName("DTSUDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(100)
                    .HasColumnName("DVT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GiamTk).HasColumnName("GIAM_TK");

                entity.Property(e => e.GtconlaiDaunam).HasColumnName("GTCONLAI_DAUNAM");

                entity.Property(e => e.GtconlaiDaunamUsd).HasColumnName("GTCONLAI_DAUNAM_USD");

                entity.Property(e => e.Kh1thang).HasColumnName("KH1THANG");

                entity.Property(e => e.Kh1thangUsd).HasColumnName("KH1THANG_USD");

                entity.Property(e => e.Kyhieu)
                    .HasMaxLength(50)
                    .HasColumnName("KYHIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LkkhDaunam).HasColumnName("LKKH_DAUNAM");

                entity.Property(e => e.LkkhDaunamUsd).HasColumnName("LKKH_DAUNAM_USD");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(100)
                    .HasColumnName("MA_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnco)
                    .HasMaxLength(200)
                    .HasColumnName("MADTPNCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnno)
                    .HasMaxLength(200)
                    .HasColumnName("MADTPNNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom1)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MatsMe)
                    .HasMaxLength(50)
                    .HasColumnName("MATS_ME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpno)
                    .HasMaxLength(100)
                    .HasColumnName("MAYTCPNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .HasColumnName("MODEL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Namsanxuat).HasColumnName("NAMSANXUAT");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HD");

                entity.Property(e => e.Ngayban)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYBAN");

                entity.Property(e => e.Ngaymua)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYMUA");

                entity.Property(e => e.Ngaytrichkh)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYTRICHKH");

                entity.Property(e => e.Nguonvon)
                    .HasMaxLength(50)
                    .HasColumnName("NGUONVON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nguyengia).HasColumnName("NGUYENGIA");

                entity.Property(e => e.NguyengiaUsd).HasColumnName("NGUYENGIA_USD");

                entity.Property(e => e.Nuocsanxuat)
                    .HasMaxLength(50)
                    .HasColumnName("NUOCSANXUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quycach)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.TangTk).HasColumnName("TANG_TK");

                entity.Property(e => e.Tennhom)
                    .HasMaxLength(250)
                    .HasColumnName("TENNHOM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhom1)
                    .HasMaxLength(250)
                    .HasColumnName("TENNHOM1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tents)
                    .HasMaxLength(255)
                    .HasColumnName("TENTS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TentsMe)
                    .HasMaxLength(250)
                    .HasColumnName("TENTS_ME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thoigiankh).HasColumnName("THOIGIANKH");

                entity.Property(e => e.Tkcp)
                    .HasMaxLength(50)
                    .HasColumnName("TKCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkhm)
                    .HasMaxLength(50)
                    .HasColumnName("TKHM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkts)
                    .HasMaxLength(50)
                    .HasColumnName("TKTS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonCk).HasColumnName("TON_CK");

                entity.Property(e => e.TonDk).HasColumnName("TON_DK");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tygia).HasColumnName("TYGIA");
            });

            modelBuilder.Entity<DmtscdTkcp>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.Mats, e.Tkcp })
                    .HasName("PK__DMTSCD_TKCP__607E0A34");

                entity.ToTable("DMTSCD_TKCP");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Mats)
                    .HasMaxLength(50)
                    .HasColumnName("MATS");

                entity.Property(e => e.Tkcp)
                    .HasMaxLength(50)
                    .HasColumnName("TKCP");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ptpb).HasColumnName("PTPB");

                entity.Property(e => e.Tents)
                    .HasMaxLength(255)
                    .HasColumnName("TENTS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TtvndKh).HasColumnName("TTVND_KH");
            });

            modelBuilder.Entity<Dmtstk>(entity =>
            {
                entity.HasKey(e => new { e.Mats, e.Tkcp })
                    .HasName("PK__DMTSTK__7B9127CC");

                entity.ToTable("DMTSTK");

                entity.Property(e => e.Mats)
                    .HasMaxLength(50)
                    .HasColumnName("MATS");

                entity.Property(e => e.Tkcp)
                    .HasMaxLength(50)
                    .HasColumnName("TKCP");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Tents)
                    .HasMaxLength(255)
                    .HasColumnName("TENTS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ttkh).HasColumnName("TTKH");
            });

            modelBuilder.Entity<Dmtstncn>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__DMTSTNCN__08810E96");

                entity.ToTable("DMTSTNCN");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LuongDen).HasColumnName("LUONG_DEN");

                entity.Property(e => e.LuongTu).HasColumnName("LUONG_TU");

                entity.Property(e => e.Thuesuat).HasColumnName("THUESUAT");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Dmuser>(entity =>
            {
                entity.HasKey(e => e.MaUser)
                    .HasName("PK__DMUSER__7E62A77F");

                entity.ToTable("DMUSER");

                entity.Property(e => e.MaUser)
                    .HasMaxLength(50)
                    .HasColumnName("MA_USER");

                entity.Property(e => e.Chucvu)
                    .HasMaxLength(50)
                    .HasColumnName("CHUCVU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kieukiemtramavach)
                    .HasMaxLength(5)
                    .HasColumnName("KIEUKIEMTRAMAVACH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SttKy).HasColumnName("STT_KY");

                entity.Property(e => e.TenUser)
                    .HasMaxLength(50)
                    .HasColumnName("TEN_USER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Dmvitrihanghoa>(entity =>
            {
                entity.HasKey(e => e.Mavitri)
                    .HasName("PK__DMVITRIHANGHOA__108C44B2");

                entity.ToTable("DMVITRIHANGHOA");

                entity.Property(e => e.Mavitri)
                    .HasMaxLength(50)
                    .HasColumnName("MAVITRI");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenvitri)
                    .HasMaxLength(150)
                    .HasColumnName("TENVITRI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Dsbaogium>(entity =>
            {
                entity.HasKey(e => e.Mabaogia)
                    .HasName("PK__DSBAOGIA__0762CD2B");

                entity.ToTable("DSBAOGIA");

                entity.Property(e => e.Mabaogia)
                    .HasMaxLength(50)
                    .HasColumnName("MABAOGIA");

                entity.Property(e => e.Bguid)
                    .HasMaxLength(50)
                    .HasColumnName("BGUID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChietkhauUsd).HasColumnName("CHIETKHAU_USD");

                entity.Property(e => e.ChietkhauVnd).HasColumnName("CHIETKHAU_VND");

                entity.Property(e => e.Chon)
                    .HasMaxLength(10)
                    .HasColumnName("CHON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhichuDh)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU_DH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hinhthucvanchuyen)
                    .HasMaxLength(100)
                    .HasColumnName("HINHTHUCVANCHUYEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Httt)
                    .HasMaxLength(100)
                    .HasColumnName("HTTT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lbg)
                    .HasMaxLength(50)
                    .HasColumnName("LBG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhbDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("LHB_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhbEmail)
                    .HasMaxLength(50)
                    .HasColumnName("LHB_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhbFax)
                    .HasMaxLength(50)
                    .HasColumnName("LHB_FAX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhbMaDt)
                    .HasMaxLength(50)
                    .HasColumnName("LHB_MA_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhbTenDt)
                    .HasMaxLength(250)
                    .HasColumnName("LHB_TEN_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnEmail)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnFax)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_FAX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnMaDt)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_MA_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnTenDt)
                    .HasMaxLength(250)
                    .HasColumnName("LHCN_TEN_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mahh)
                    .HasMaxLength(50)
                    .HasColumnName("MAHH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HD");

                entity.Property(e => e.Ngaybaogia)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYBAOGIA");

                entity.Property(e => e.Ngaygiaohang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYGIAOHANG");

                entity.Property(e => e.Ngayhethan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYHETHAN");

                entity.Property(e => e.NmhDiachi)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_DIACHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhDiachiChinhanh)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_DIACHI_CHINHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhEmail)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhFax)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_FAX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMa)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMachinhanh)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MACHINHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMatinhthanh)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MATINHTHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMst)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MST")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhNlhDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_NLH_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhNlhTen)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_NLH_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTen)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTenchinhanh)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_TENCHINHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTentinhthanh)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_TENTINHTHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTknh)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_TKNH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Phivanchuyen).HasColumnName("PHIVANCHUYEN");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SttBaogia).HasColumnName("STT_BAOGIA");

                entity.Property(e => e.SttKy).HasColumnName("STT_KY");

                entity.Property(e => e.Tenct)
                    .HasMaxLength(50)
                    .HasColumnName("TENCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenhh)
                    .HasMaxLength(50)
                    .HasColumnName("TENHH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thueusd).HasColumnName("THUEUSD");

                entity.Property(e => e.Thuevnd).HasColumnName("THUEVND");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TsGtgt).HasColumnName("TS_GTGT");

                entity.Property(e => e.Ttdh)
                    .HasMaxLength(10)
                    .HasColumnName("TTDH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ttusd).HasColumnName("TTUSD");

                entity.Property(e => e.TtusdSauCk).HasColumnName("TTUSD_SAU_CK");

                entity.Property(e => e.TtusdTt).HasColumnName("TTUSD_TT");

                entity.Property(e => e.Ttvnd).HasColumnName("TTVND");

                entity.Property(e => e.TtvndSauCk).HasColumnName("TTVND_SAU_CK");

                entity.Property(e => e.TtvndTt).HasColumnName("TTVND_TT");

                entity.Property(e => e.Tygia).HasColumnName("TYGIA");
            });

            modelBuilder.Entity<Dscot>(entity =>
            {
                entity.HasKey(e => new { e.Macot, e.Tenbang })
                    .HasName("PK__DSCOT__108157BA");

                entity.ToTable("DSCOT");

                entity.Property(e => e.Macot)
                    .HasMaxLength(50)
                    .HasColumnName("MACOT");

                entity.Property(e => e.Tenbang)
                    .HasMaxLength(50)
                    .HasColumnName("TENBANG");

                entity.Property(e => e.Berong)
                    .HasMaxLength(50)
                    .HasColumnName("BERONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kieudulieu)
                    .HasMaxLength(50)
                    .HasColumnName("KIEUDULIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Tencot)
                    .HasMaxLength(120)
                    .HasColumnName("TENCOT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Dsdhban>(entity =>
            {
                entity.HasKey(e => e.Madonhang)
                    .HasName("PK__DSDHBAN__24885067");

                entity.ToTable("DSDHBAN");

                entity.Property(e => e.Madonhang)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANG");

                entity.Property(e => e.ChietkhauUsd).HasColumnName("CHIETKHAU_USD");

                entity.Property(e => e.ChietkhauVnd).HasColumnName("CHIETKHAU_VND");

                entity.Property(e => e.Chon)
                    .HasMaxLength(10)
                    .HasColumnName("CHON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dhguid)
                    .HasMaxLength(50)
                    .HasColumnName("DHGUID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhichuDh)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU_DH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hinhthucvanchuyen)
                    .HasMaxLength(100)
                    .HasColumnName("HINHTHUCVANCHUYEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Httt)
                    .HasMaxLength(100)
                    .HasColumnName("HTTT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ldh)
                    .HasMaxLength(50)
                    .HasColumnName("LDH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhbDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("LHB_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhbEmail)
                    .HasMaxLength(50)
                    .HasColumnName("LHB_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhbFax)
                    .HasMaxLength(50)
                    .HasColumnName("LHB_FAX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhbMaDt)
                    .HasMaxLength(50)
                    .HasColumnName("LHB_MA_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhbTenDt)
                    .HasMaxLength(250)
                    .HasColumnName("LHB_TEN_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnEmail)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnFax)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_FAX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnMaDt)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_MA_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnTenDt)
                    .HasMaxLength(250)
                    .HasColumnName("LHCN_TEN_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madonhang2)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANG2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mahh)
                    .HasMaxLength(50)
                    .HasColumnName("MAHH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HD");

                entity.Property(e => e.Ngaydonhang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYDONHANG");

                entity.Property(e => e.Ngaygiaohang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYGIAOHANG");

                entity.Property(e => e.Ngayhethan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYHETHAN");

                entity.Property(e => e.NmhDiachi)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_DIACHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhDiachiChinhanh)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_DIACHI_CHINHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhEmail)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhFax)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_FAX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMa)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMachinhanh)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MACHINHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMatinhthanh)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MATINHTHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMst)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MST")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhNlhDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_NLH_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhNlhTen)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_NLH_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTen)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTenchinhanh)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_TENCHINHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTentinhthanh)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_TENTINHTHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTknh)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_TKNH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Phivanchuyen).HasColumnName("PHIVANCHUYEN");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SttDonhang).HasColumnName("STT_DONHANG");

                entity.Property(e => e.SttKy).HasColumnName("STT_KY");

                entity.Property(e => e.Tenct)
                    .HasMaxLength(50)
                    .HasColumnName("TENCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenhh)
                    .HasMaxLength(50)
                    .HasColumnName("TENHH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thueusd).HasColumnName("THUEUSD");

                entity.Property(e => e.Thuevnd).HasColumnName("THUEVND");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TsGtgt).HasColumnName("TS_GTGT");

                entity.Property(e => e.TtCnCk).HasColumnName("TT_CN_CK");

                entity.Property(e => e.TtHdCk).HasColumnName("TT_HD_CK");

                entity.Property(e => e.TtHdDk).HasColumnName("TT_HD_DK");

                entity.Property(e => e.TtHdTk).HasColumnName("TT_HD_TK");

                entity.Property(e => e.TtPtCk).HasColumnName("TT_PT_CK");

                entity.Property(e => e.TtPtDk).HasColumnName("TT_PT_DK");

                entity.Property(e => e.TtPtTk).HasColumnName("TT_PT_TK");

                entity.Property(e => e.Ttdh)
                    .HasMaxLength(10)
                    .HasColumnName("TTDH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ttusd).HasColumnName("TTUSD");

                entity.Property(e => e.TtusdSauCk).HasColumnName("TTUSD_SAU_CK");

                entity.Property(e => e.TtusdTt).HasColumnName("TTUSD_TT");

                entity.Property(e => e.Ttvnd).HasColumnName("TTVND");

                entity.Property(e => e.TtvndSauCk).HasColumnName("TTVND_SAU_CK");

                entity.Property(e => e.TtvndTt).HasColumnName("TTVND_TT");

                entity.Property(e => e.Tygia).HasColumnName("TYGIA");
            });

            modelBuilder.Entity<Dsdhmua>(entity =>
            {
                entity.HasKey(e => e.Madonhang)
                    .HasName("PK__DSDHMUA__646DCB52");

                entity.ToTable("DSDHMUA");

                entity.Property(e => e.Madonhang)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANG");

                entity.Property(e => e.ChietkhauUsd).HasColumnName("CHIETKHAU_USD");

                entity.Property(e => e.ChietkhauVnd).HasColumnName("CHIETKHAU_VND");

                entity.Property(e => e.Chonky)
                    .HasMaxLength(5)
                    .HasColumnName("CHONKY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dhguid)
                    .HasMaxLength(50)
                    .HasColumnName("DHGUID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhichuDh)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU_DH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hinhthucvanchuyen)
                    .HasMaxLength(100)
                    .HasColumnName("HINHTHUCVANCHUYEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Httt)
                    .HasMaxLength(100)
                    .HasColumnName("HTTT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ldh)
                    .HasMaxLength(50)
                    .HasColumnName("LDH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnEmail)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnFax)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_FAX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnMaDt)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_MA_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnTenDt)
                    .HasMaxLength(250)
                    .HasColumnName("LHCN_TEN_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhmDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("LHM_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhmEmail)
                    .HasMaxLength(50)
                    .HasColumnName("LHM_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhmFax)
                    .HasMaxLength(50)
                    .HasColumnName("LHM_FAX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhmMaDt)
                    .HasMaxLength(50)
                    .HasColumnName("LHM_MA_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhmTenDt)
                    .HasMaxLength(250)
                    .HasColumnName("LHM_TEN_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MadonhangBan)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANG_BAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mahh)
                    .HasMaxLength(50)
                    .HasColumnName("MAHH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccDiachi)
                    .HasMaxLength(250)
                    .HasColumnName("NCC_DIACHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccEmail)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccFax)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_FAX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccMa)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_MA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccMst)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_MST")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccNlhDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_NLH_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccNlhTen)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_NLH_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccTen)
                    .HasMaxLength(250)
                    .HasColumnName("NCC_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccTknh)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_TKNH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HD");

                entity.Property(e => e.Ngaydonhang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYDONHANG");

                entity.Property(e => e.Ngaygiaohang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYGIAOHANG");

                entity.Property(e => e.Ngayhethan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYHETHAN");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Phivanchuyen).HasColumnName("PHIVANCHUYEN");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SttDonhang).HasColumnName("STT_DONHANG");

                entity.Property(e => e.SttKy).HasColumnName("STT_KY");

                entity.Property(e => e.Tenct)
                    .HasMaxLength(250)
                    .HasColumnName("TENCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenhh)
                    .HasMaxLength(50)
                    .HasColumnName("TENHH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thueusd).HasColumnName("THUEUSD");

                entity.Property(e => e.Thuevnd).HasColumnName("THUEVND");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TsGtgt).HasColumnName("TS_GTGT");

                entity.Property(e => e.Ttdh)
                    .HasMaxLength(10)
                    .HasColumnName("TTDH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ttusd).HasColumnName("TTUSD");

                entity.Property(e => e.TtusdSauCk).HasColumnName("TTUSD_SAU_CK");

                entity.Property(e => e.TtusdTt).HasColumnName("TTUSD_TT");

                entity.Property(e => e.Ttvnd).HasColumnName("TTVND");

                entity.Property(e => e.TtvndSauCk).HasColumnName("TTVND_SAU_CK");

                entity.Property(e => e.TtvndTt).HasColumnName("TTVND_TT");

                entity.Property(e => e.Tygia).HasColumnName("TYGIA");
            });

            modelBuilder.Entity<Dsphimnong>(entity =>
            {
                entity.HasKey(e => e.Tenphim)
                    .HasName("PK__DSPHIMNONG__3BEBA403");

                entity.ToTable("DSPHIMNONG");

                entity.Property(e => e.Tenphim)
                    .HasMaxLength(50)
                    .HasColumnName("TENPHIM");

                entity.Property(e => e.Chucnang)
                    .HasMaxLength(350)
                    .HasColumnName("CHUCNANG")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<KhaiBaoKqkd>(entity =>
            {
                entity.HasKey(e => e.Chitieu)
                    .HasName("PK__KhaiBaoKQKD__71D1E811");

                entity.ToTable("KhaiBaoKQKD");

                entity.Property(e => e.Chitieu)
                    .HasMaxLength(50)
                    .HasColumnName("CHITIEU");

                entity.Property(e => e.CoIn)
                    .HasMaxLength(255)
                    .HasColumnName("CO_IN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Congthuc)
                    .HasMaxLength(255)
                    .HasColumnName("CONGTHUC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(1)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maso)
                    .HasMaxLength(255)
                    .HasColumnName("MASO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NhanVoi).HasColumnName("NHAN_VOI");

                entity.Property(e => e.Tenct1)
                    .HasMaxLength(255)
                    .HasColumnName("TENCT1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct2)
                    .HasMaxLength(255)
                    .HasColumnName("TENCT2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ThuyetMinh)
                    .HasMaxLength(255)
                    .HasColumnName("THUYET_MINH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkco)
                    .HasMaxLength(255)
                    .HasColumnName("TKCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkno)
                    .HasMaxLength(255)
                    .HasColumnName("TKNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TtusdKn).HasColumnName("TTUSD_KN");

                entity.Property(e => e.TtusdKt).HasColumnName("TTUSD_KT");

                entity.Property(e => e.TtusdLk).HasColumnName("TTUSD_LK");

                entity.Property(e => e.TtusdNt).HasColumnName("TTUSD_NT");

                entity.Property(e => e.TtvndKn).HasColumnName("TTVND_KN");

                entity.Property(e => e.TtvndKt).HasColumnName("TTVND_KT");

                entity.Property(e => e.TtvndLk).HasColumnName("TTVND_LK");

                entity.Property(e => e.TtvndNt).HasColumnName("TTVND_NT");
            });

            modelBuilder.Entity<KhaiBaoKqkdBp>(entity =>
            {
                entity.HasKey(e => e.Chitieu)
                    .HasName("PK__KhaiBao_KQKD_BP__36B12243");

                entity.ToTable("KhaiBao_KQKD_BP");

                entity.Property(e => e.Chitieu)
                    .HasMaxLength(50)
                    .HasColumnName("CHITIEU");

                entity.Property(e => e.CoChendong)
                    .HasMaxLength(5)
                    .HasColumnName("CO_CHENDONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoIn)
                    .HasMaxLength(255)
                    .HasColumnName("CO_IN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Congthuc)
                    .HasMaxLength(255)
                    .HasColumnName("CONGTHUC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(1)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KhongSumNhom)
                    .HasMaxLength(50)
                    .HasColumnName("KHONG_SUM_NHOM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mabp)
                    .HasMaxLength(50)
                    .HasColumnName("MABP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maso)
                    .HasMaxLength(255)
                    .HasColumnName("MASO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NhanVoi).HasColumnName("NHAN_VOI");

                entity.Property(e => e.Tenct1)
                    .HasMaxLength(255)
                    .HasColumnName("TENCT1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct2)
                    .HasMaxLength(255)
                    .HasColumnName("TENCT2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ThuyetMinh)
                    .HasMaxLength(255)
                    .HasColumnName("THUYET_MINH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkco)
                    .HasMaxLength(50)
                    .HasColumnName("TKCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkno)
                    .HasMaxLength(50)
                    .HasColumnName("TKNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KhaiBaoKqkdQt>(entity =>
            {
                entity.HasKey(e => e.Chitieu)
                    .HasName("PK__KhaiBaoKQKD_QT__05D8E0BE");

                entity.ToTable("KhaiBaoKQKD_QT");

                entity.Property(e => e.Chitieu)
                    .HasMaxLength(50)
                    .HasColumnName("CHITIEU");

                entity.Property(e => e.CoIn)
                    .HasMaxLength(255)
                    .HasColumnName("CO_IN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Congthuc)
                    .HasMaxLength(255)
                    .HasColumnName("CONGTHUC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(1)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maso)
                    .HasMaxLength(255)
                    .HasColumnName("MASO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NhanVoi).HasColumnName("NHAN_VOI");

                entity.Property(e => e.Tenct1)
                    .HasMaxLength(255)
                    .HasColumnName("TENCT1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct2)
                    .HasMaxLength(255)
                    .HasColumnName("TENCT2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ThuyetMinh)
                    .HasMaxLength(255)
                    .HasColumnName("THUYET_MINH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkco)
                    .HasMaxLength(255)
                    .HasColumnName("TKCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkno)
                    .HasMaxLength(255)
                    .HasColumnName("TKNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TtusdKn).HasColumnName("TTUSD_KN");

                entity.Property(e => e.TtusdKt).HasColumnName("TTUSD_KT");

                entity.Property(e => e.TtusdLk).HasColumnName("TTUSD_LK");

                entity.Property(e => e.TtusdNt).HasColumnName("TTUSD_NT");

                entity.Property(e => e.TtvndKn).HasColumnName("TTVND_KN");

                entity.Property(e => e.TtvndKt).HasColumnName("TTVND_KT");

                entity.Property(e => e.TtvndLk).HasColumnName("TTVND_LK");

                entity.Property(e => e.TtvndNt).HasColumnName("TTVND_NT");
            });

            modelBuilder.Entity<KhaiBaoLctt>(entity =>
            {
                entity.HasKey(e => e.Chitieu)
                    .HasName("PK__KhaiBaoLCTT__19DFD96B");

                entity.ToTable("KhaiBaoLCTT");

                entity.Property(e => e.Chitieu)
                    .HasMaxLength(50)
                    .HasColumnName("CHITIEU");

                entity.Property(e => e.CoIn)
                    .HasMaxLength(255)
                    .HasColumnName("CO_IN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(1)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maso)
                    .HasMaxLength(255)
                    .HasColumnName("MASO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpco)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCPCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpno)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCPNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NhanVoi).HasColumnName("NHAN_VOI");

                entity.Property(e => e.Sapxep)
                    .HasMaxLength(50)
                    .HasColumnName("SAPXEP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sodu)
                    .HasMaxLength(50)
                    .HasColumnName("SODU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct1)
                    .HasMaxLength(255)
                    .HasColumnName("TENCT1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct2)
                    .HasMaxLength(255)
                    .HasColumnName("TENCT2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ThuyetMinh)
                    .HasMaxLength(255)
                    .HasColumnName("THUYET_MINH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkco)
                    .HasMaxLength(255)
                    .HasColumnName("TKCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkno)
                    .HasMaxLength(255)
                    .HasColumnName("TKNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TtusdKn).HasColumnName("TTUSD_KN");

                entity.Property(e => e.TtusdKt).HasColumnName("TTUSD_KT");

                entity.Property(e => e.TtusdLk).HasColumnName("TTUSD_LK");

                entity.Property(e => e.TtusdNt).HasColumnName("TTUSD_NT");

                entity.Property(e => e.TtvndKn).HasColumnName("TTVND_KN");

                entity.Property(e => e.TtvndKt).HasColumnName("TTVND_KT");

                entity.Property(e => e.TtvndLk).HasColumnName("TTVND_LK");

                entity.Property(e => e.TtvndNt).HasColumnName("TTVND_NT");
            });

            modelBuilder.Entity<KhaiBaoLcttGt>(entity =>
            {
                entity.HasKey(e => e.Chitieu)
                    .HasName("PK__KhaiBaoLCTT_GT__30C33EC3");

                entity.ToTable("KhaiBaoLCTT_GT");

                entity.Property(e => e.Chitieu)
                    .HasMaxLength(50)
                    .HasColumnName("CHITIEU");

                entity.Property(e => e.CoIn)
                    .HasMaxLength(255)
                    .HasColumnName("CO_IN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Congthuc)
                    .HasMaxLength(510)
                    .HasColumnName("CONGTHUC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(1)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DkCk)
                    .HasMaxLength(50)
                    .HasColumnName("DK_CK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imei)
                    .HasMaxLength(50)
                    .HasColumnName("IMEI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kieulay)
                    .HasMaxLength(10)
                    .HasColumnName("KIEULAY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnco)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnno)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maso)
                    .HasMaxLength(255)
                    .HasColumnName("MASO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpco)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCPCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpno)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCPNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NhanVoi).HasColumnName("NHAN_VOI");

                entity.Property(e => e.Sapxep)
                    .HasMaxLength(50)
                    .HasColumnName("SAPXEP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sodu)
                    .HasMaxLength(50)
                    .HasColumnName("SODU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenbang)
                    .HasMaxLength(100)
                    .HasColumnName("TENBANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct1)
                    .HasMaxLength(255)
                    .HasColumnName("TENCT1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct2)
                    .HasMaxLength(255)
                    .HasColumnName("TENCT2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ThuyetMinh)
                    .HasMaxLength(255)
                    .HasColumnName("THUYET_MINH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkco)
                    .HasMaxLength(255)
                    .HasColumnName("TKCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkno)
                    .HasMaxLength(255)
                    .HasColumnName("TKNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TtusdKn).HasColumnName("TTUSD_KN");

                entity.Property(e => e.TtusdKt).HasColumnName("TTUSD_KT");

                entity.Property(e => e.TtusdLk).HasColumnName("TTUSD_LK");

                entity.Property(e => e.TtvndKn).HasColumnName("TTVND_KN");

                entity.Property(e => e.TtvndKt).HasColumnName("TTVND_KT");

                entity.Property(e => e.TtvndLk).HasColumnName("TTVND_LK");
            });

            modelBuilder.Entity<KhaiBaoLcttQt>(entity =>
            {
                entity.HasKey(e => e.Chitieu)
                    .HasName("PK__KhaiBaoLCTT_QT__4D5F7D71");

                entity.ToTable("KhaiBaoLCTT_QT");

                entity.Property(e => e.Chitieu)
                    .HasMaxLength(50)
                    .HasColumnName("CHITIEU");

                entity.Property(e => e.CoIn)
                    .HasMaxLength(255)
                    .HasColumnName("CO_IN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(1)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maso)
                    .HasMaxLength(255)
                    .HasColumnName("MASO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpco)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCPCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpno)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCPNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NhanVoi).HasColumnName("NHAN_VOI");

                entity.Property(e => e.Sapxep)
                    .HasMaxLength(50)
                    .HasColumnName("SAPXEP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sodu)
                    .HasMaxLength(50)
                    .HasColumnName("SODU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct1)
                    .HasMaxLength(255)
                    .HasColumnName("TENCT1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct2)
                    .HasMaxLength(255)
                    .HasColumnName("TENCT2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ThuyetMinh)
                    .HasMaxLength(255)
                    .HasColumnName("THUYET_MINH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkco)
                    .HasMaxLength(255)
                    .HasColumnName("TKCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkno)
                    .HasMaxLength(255)
                    .HasColumnName("TKNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TtusdKn).HasColumnName("TTUSD_KN");

                entity.Property(e => e.TtusdKt).HasColumnName("TTUSD_KT");

                entity.Property(e => e.TtusdLk).HasColumnName("TTUSD_LK");

                entity.Property(e => e.TtusdNt).HasColumnName("TTUSD_NT");

                entity.Property(e => e.TtvndKn).HasColumnName("TTVND_KN");

                entity.Property(e => e.TtvndKt).HasColumnName("TTVND_KT");

                entity.Property(e => e.TtvndLk).HasColumnName("TTVND_LK");

                entity.Property(e => e.TtvndNt).HasColumnName("TTVND_NT");
            });

            modelBuilder.Entity<KhaibaoKctk>(entity =>
            {
                entity.HasKey(e => new { e.TkKc, e.SoduKc })
                    .HasName("PK__KHAIBAO_KCTK__6E971F61");

                entity.ToTable("KHAIBAO_KCTK");

                entity.Property(e => e.TkKc)
                    .HasMaxLength(50)
                    .HasColumnName("TK_KC");

                entity.Property(e => e.SoduKc)
                    .HasMaxLength(1)
                    .HasColumnName("SODU_KC");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diengiai)
                    .HasMaxLength(250)
                    .HasColumnName("DIENGIAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkco)
                    .HasMaxLength(50)
                    .HasColumnName("TKCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkno)
                    .HasMaxLength(50)
                    .HasColumnName("TKNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TtKc).HasColumnName("TT_KC");

                entity.Property(e => e.Ttusd).HasColumnName("TTUSD");

                entity.Property(e => e.Ttvnd).HasColumnName("TTVND");
            });

            modelBuilder.Entity<KhaibaoKctkDt>(entity =>
            {
                entity.HasKey(e => new { e.TkKc, e.SoduKc })
                    .HasName("PK__KHAIBAO_KCTK_DT__7820899B");

                entity.ToTable("KHAIBAO_KCTK_DT");

                entity.Property(e => e.TkKc)
                    .HasMaxLength(50)
                    .HasColumnName("TK_KC");

                entity.Property(e => e.SoduKc)
                    .HasMaxLength(1)
                    .HasColumnName("SODU_KC");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diengiai)
                    .HasMaxLength(250)
                    .HasColumnName("DIENGIAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkco)
                    .HasMaxLength(50)
                    .HasColumnName("TKCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkno)
                    .HasMaxLength(50)
                    .HasColumnName("TKNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TtKc).HasColumnName("TT_KC");

                entity.Property(e => e.Ttusd).HasColumnName("TTUSD");

                entity.Property(e => e.Ttvnd).HasColumnName("TTVND");
            });

            modelBuilder.Entity<Khaibaocdkt>(entity =>
            {
                entity.HasKey(e => e.Chitieu)
                    .HasName("PK__KHAIBAOCDKT__45F365D3");

                entity.ToTable("KHAIBAOCDKT");

                entity.Property(e => e.Chitieu)
                    .HasMaxLength(50)
                    .HasColumnName("CHITIEU");

                entity.Property(e => e.CoIn)
                    .HasMaxLength(10)
                    .HasColumnName("CO_IN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(10)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KieuIn)
                    .HasMaxLength(10)
                    .HasColumnName("KIEU_IN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maso)
                    .HasMaxLength(50)
                    .HasColumnName("MASO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhom0)
                    .HasMaxLength(50)
                    .HasColumnName("NHOM_0")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhom1)
                    .HasMaxLength(50)
                    .HasColumnName("NHOM_1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhom2)
                    .HasMaxLength(50)
                    .HasColumnName("NHOM_2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhom3)
                    .HasMaxLength(50)
                    .HasColumnName("NHOM_3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhom4)
                    .HasMaxLength(50)
                    .HasColumnName("NHOM_4")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sodu)
                    .HasMaxLength(10)
                    .HasColumnName("SODU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Taikhoan)
                    .HasMaxLength(50)
                    .HasColumnName("TAIKHOAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct1)
                    .HasMaxLength(255)
                    .HasColumnName("TENCT1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct2)
                    .HasMaxLength(255)
                    .HasColumnName("TENCT2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tm)
                    .HasMaxLength(50)
                    .HasColumnName("TM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TtusdCk).HasColumnName("TTUSD_CK");

                entity.Property(e => e.TtusdDk).HasColumnName("TTUSD_DK");

                entity.Property(e => e.TtusdNt).HasColumnName("TTUSD_NT");

                entity.Property(e => e.TtvndCk).HasColumnName("TTVND_CK");

                entity.Property(e => e.TtvndDk).HasColumnName("TTVND_DK");

                entity.Property(e => e.TtvndNt).HasColumnName("TTVND_NT");
            });

            modelBuilder.Entity<KhaibaocdktQt>(entity =>
            {
                entity.HasKey(e => e.Chitieu)
                    .HasName("PK__KHAIBAOCDKT_QT__5BE2A6F2");

                entity.ToTable("KHAIBAOCDKT_QT");

                entity.Property(e => e.Chitieu)
                    .HasMaxLength(50)
                    .HasColumnName("CHITIEU");

                entity.Property(e => e.CoIn)
                    .HasMaxLength(10)
                    .HasColumnName("CO_IN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(10)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KieuIn)
                    .HasMaxLength(10)
                    .HasColumnName("KIEU_IN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maso)
                    .HasMaxLength(50)
                    .HasColumnName("MASO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhom0)
                    .HasMaxLength(50)
                    .HasColumnName("NHOM_0")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhom1)
                    .HasMaxLength(50)
                    .HasColumnName("NHOM_1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhom2)
                    .HasMaxLength(50)
                    .HasColumnName("NHOM_2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhom3)
                    .HasMaxLength(50)
                    .HasColumnName("NHOM_3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhom4)
                    .HasMaxLength(50)
                    .HasColumnName("NHOM_4")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sodu)
                    .HasMaxLength(10)
                    .HasColumnName("SODU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Taikhoan)
                    .HasMaxLength(50)
                    .HasColumnName("TAIKHOAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct1)
                    .HasMaxLength(250)
                    .HasColumnName("TENCT1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct2)
                    .HasMaxLength(250)
                    .HasColumnName("TENCT2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tm)
                    .HasMaxLength(50)
                    .HasColumnName("TM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TtusdCk).HasColumnName("TTUSD_CK");

                entity.Property(e => e.TtusdDk).HasColumnName("TTUSD_DK");

                entity.Property(e => e.TtusdNt).HasColumnName("TTUSD_NT");

                entity.Property(e => e.TtvndCk).HasColumnName("TTVND_CK");

                entity.Property(e => e.TtvndDk).HasColumnName("TTVND_DK");

                entity.Property(e => e.TtvndNt).HasColumnName("TTVND_NT");
            });

            modelBuilder.Entity<Khaibaokqkdmr>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Chitieu })
                    .HasName("PK__KHAIBAOKQKDMR__6D4D2A16");

                entity.ToTable("KHAIBAOKQKDMR");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.Chitieu)
                    .HasMaxLength(50)
                    .HasColumnName("CHITIEU");

                entity.Property(e => e.CoIn)
                    .HasMaxLength(255)
                    .HasColumnName("CO_IN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Congthuc)
                    .HasMaxLength(255)
                    .HasColumnName("CONGTHUC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(1)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maso)
                    .HasMaxLength(255)
                    .HasColumnName("MASO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NhanVoi).HasColumnName("NHAN_VOI");

                entity.Property(e => e.Tenct1)
                    .HasMaxLength(255)
                    .HasColumnName("TENCT1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct2)
                    .HasMaxLength(255)
                    .HasColumnName("TENCT2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ThuyetMinh)
                    .HasMaxLength(255)
                    .HasColumnName("THUYET_MINH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkco)
                    .HasMaxLength(50)
                    .HasColumnName("TKCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkno)
                    .HasMaxLength(50)
                    .HasColumnName("TKNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TtusdKn).HasColumnName("TTUSD_KN");

                entity.Property(e => e.TtusdKt).HasColumnName("TTUSD_KT");

                entity.Property(e => e.TtusdLk).HasColumnName("TTUSD_LK");

                entity.Property(e => e.TtusdNt).HasColumnName("TTUSD_NT");

                entity.Property(e => e.TtvndKn).HasColumnName("TTVND_KN");

                entity.Property(e => e.TtvndKt).HasColumnName("TTVND_KT");

                entity.Property(e => e.TtvndLk).HasColumnName("TTVND_LK");

                entity.Property(e => e.TtvndNt).HasColumnName("TTVND_NT");
            });

            modelBuilder.Entity<Khaibaopt01>(entity =>
            {
                entity.HasKey(e => e.Chitieu)
                    .HasName("PK__KHAIBAOPT01__6442E2C9");

                entity.ToTable("KHAIBAOPT01");

                entity.Property(e => e.Chitieu)
                    .HasMaxLength(50)
                    .HasColumnName("CHITIEU");

                entity.Property(e => e.CoIn)
                    .HasMaxLength(255)
                    .HasColumnName("CO_IN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(1)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maso)
                    .HasMaxLength(255)
                    .HasColumnName("MASO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NhanVoi).HasColumnName("NHAN_VOI");

                entity.Property(e => e.Tenct1)
                    .HasMaxLength(255)
                    .HasColumnName("TENCT1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct2)
                    .HasMaxLength(255)
                    .HasColumnName("TENCT2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ThuyetMinh)
                    .HasMaxLength(255)
                    .HasColumnName("THUYET_MINH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkco)
                    .HasMaxLength(255)
                    .HasColumnName("TKCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkno)
                    .HasMaxLength(255)
                    .HasColumnName("TKNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TtusdKn).HasColumnName("TTUSD_KN");

                entity.Property(e => e.TtusdKt).HasColumnName("TTUSD_KT");

                entity.Property(e => e.TtvndKn).HasColumnName("TTVND_KN");

                entity.Property(e => e.TtvndKt).HasColumnName("TTVND_KT");
            });

            modelBuilder.Entity<Kt154Gc>(entity =>
            {
                entity.HasKey(e => new { e.Giaidoan, e.Nam, e.Thang, e.Maytcp, e.MaThanhpham })
                    .HasName("PK__KT_154_GC__26CFC035");

                entity.ToTable("KT_154_GC");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.Nam).HasColumnName("NAM");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Maytcp)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCP");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM");

                entity.Property(e => e.Chiphi).HasColumnName("CHIPHI");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpco)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCPCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpno)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCPNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenytcp)
                    .HasMaxLength(250)
                    .HasColumnName("TENYTCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkno)
                    .HasMaxLength(50)
                    .HasColumnName("TKNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtBangLuong>(entity =>
            {
                entity.HasKey(e => new { e.LoaiBangLuong, e.Nam, e.Thang, e.Stt })
                    .HasName("PK__KT_BANG_LUONG__4D35603F");

                entity.ToTable("KT_BANG_LUONG");

                entity.Property(e => e.LoaiBangLuong)
                    .HasMaxLength(50)
                    .HasColumnName("LOAI_BANG_LUONG");

                entity.Property(e => e.Nam).HasColumnName("NAM");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.BhtnCongty).HasColumnName("BHTN_CONGTY");

                entity.Property(e => e.BhtnNld).HasColumnName("BHTN_NLD");

                entity.Property(e => e.BhxhCongty).HasColumnName("BHXH_CONGTY");

                entity.Property(e => e.BhxhNld).HasColumnName("BHXH_NLD");

                entity.Property(e => e.BhytCongty).HasColumnName("BHYT_CONGTY");

                entity.Property(e => e.BhytNld).HasColumnName("BHYT_NLD");

                entity.Property(e => e.CacKhoanGiamTru).HasColumnName("CAC_KHOAN_GIAM_TRU");

                entity.Property(e => e.CacKhoanMienThue).HasColumnName("CAC_KHOAN_MIEN_THUE");

                entity.Property(e => e.ChucDanh)
                    .HasMaxLength(50)
                    .HasColumnName("CHUC_DANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChucVu)
                    .HasMaxLength(50)
                    .HasColumnName("CHUC_VU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChucVuDamNhan)
                    .HasMaxLength(50)
                    .HasColumnName("CHUC_VU_DAM_NHAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChuyenNganh)
                    .HasMaxLength(50)
                    .HasColumnName("CHUYEN_NGANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DanToc)
                    .HasMaxLength(50)
                    .HasColumnName("DAN_TOC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DienThoai1)
                    .HasMaxLength(20)
                    .HasColumnName("DIEN_THOAI_1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DienThoai2)
                    .HasMaxLength(20)
                    .HasColumnName("DIEN_THOAI_2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(50)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GioiTinh)
                    .HasMaxLength(10)
                    .HasColumnName("GIOI_TINH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HeSoLuong).HasColumnName("HE_SO_LUONG");

                entity.Property(e => e.HoTenAnh)
                    .HasMaxLength(100)
                    .HasColumnName("HO_TEN_ANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HoTenHoa)
                    .HasMaxLength(100)
                    .HasColumnName("HO_TEN_HOA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HoTenViet)
                    .HasMaxLength(100)
                    .HasColumnName("HO_TEN_VIET")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kpcd).HasColumnName("KPCD");

                entity.Property(e => e.LuongCoBan).HasColumnName("LUONG_CO_BAN");

                entity.Property(e => e.LuongThucNhan).HasColumnName("LUONG_THUC_NHAN");

                entity.Property(e => e.MaNhanVien)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NHAN_VIEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaVach)
                    .HasMaxLength(50)
                    .HasColumnName("MA_VACH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayCap)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_CAP");

                entity.Property(e => e.NgayCong).HasColumnName("NGAY_CONG");

                entity.Property(e => e.NgayLuu)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_LUU");

                entity.Property(e => e.NgayNghi).HasColumnName("NGAY_NGHI");

                entity.Property(e => e.NgaySinh)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_SINH");

                entity.Property(e => e.NoiCap)
                    .HasMaxLength(50)
                    .HasColumnName("NOI_CAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NoiSinh)
                    .HasMaxLength(100)
                    .HasColumnName("NOI_SINH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PcAn).HasColumnName("PC_AN");

                entity.Property(e => e.PcChucVu).HasColumnName("PC_CHUC_VU");

                entity.Property(e => e.PcKhac).HasColumnName("PC_KHAC");

                entity.Property(e => e.PcThamNien).HasColumnName("PC_THAM_NIEN");

                entity.Property(e => e.PcTrachNhiem).HasColumnName("PC_TRACH_NHIEM");

                entity.Property(e => e.PcXangXe).HasColumnName("PC_XANG_XE");

                entity.Property(e => e.PhongBan)
                    .HasMaxLength(50)
                    .HasColumnName("PHONG_BAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QuanHuyen)
                    .HasMaxLength(50)
                    .HasColumnName("QUAN_HUYEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QueQuan)
                    .HasMaxLength(100)
                    .HasColumnName("QUE_QUAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QuocGia)
                    .HasMaxLength(20)
                    .HasColumnName("QUOC_GIA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QuocTich)
                    .HasMaxLength(50)
                    .HasColumnName("QUOC_TICH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoCmnd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_CMND")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TamTru)
                    .HasMaxLength(100)
                    .HasColumnName("TAM_TRU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TamUng).HasColumnName("TAM_UNG");

                entity.Property(e => e.TenPhongBan)
                    .HasMaxLength(99)
                    .HasColumnName("TEN_PHONG_BAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ThuNhapChiuThue).HasColumnName("THU_NHAP_CHIU_THUE");

                entity.Property(e => e.ThuNhapTinhThue).HasColumnName("THU_NHAP_TINH_THUE");

                entity.Property(e => e.ThuocTo)
                    .HasMaxLength(50)
                    .HasColumnName("THUOC_TO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ThuongTru)
                    .HasMaxLength(100)
                    .HasColumnName("THUONG_TRU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TinhThanhPho)
                    .HasMaxLength(50)
                    .HasColumnName("TINH_THANH_PHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkBhtn)
                    .HasMaxLength(50)
                    .HasColumnName("TK_BHTN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkBhxh)
                    .HasMaxLength(50)
                    .HasColumnName("TK_BHXH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkBhyt)
                    .HasMaxLength(50)
                    .HasColumnName("TK_BHYT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkCpLuong)
                    .HasMaxLength(50)
                    .HasColumnName("TK_CP_LUONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkKpcd)
                    .HasMaxLength(50)
                    .HasColumnName("TK_KPCD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkLuong)
                    .HasMaxLength(50)
                    .HasColumnName("TK_LUONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkTamung)
                    .HasMaxLength(50)
                    .HasColumnName("TK_TAMUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkTncn)
                    .HasMaxLength(50)
                    .HasColumnName("TK_TNCN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonGiao)
                    .HasMaxLength(50)
                    .HasColumnName("TON_GIAO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TongLuong).HasColumnName("TONG_LUONG");

                entity.Property(e => e.TongLuongHt).HasColumnName("TONG_LUONG_HT");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VanHoa)
                    .HasMaxLength(50)
                    .HasColumnName("VAN_HOA")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<KtBophanUser>(entity =>
            {
                entity.HasKey(e => new { e.Mabophan, e.Mauser })
                    .HasName("PK__KT_BOPHAN_USER__0CB0C6D6");

                entity.ToTable("KT_BOPHAN_USER");

                entity.Property(e => e.Mabophan)
                    .HasMaxLength(250)
                    .HasColumnName("MABOPHAN");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtChamCong>(entity =>
            {
                entity.HasKey(e => new { e.LoaiBangLuong, e.Nam, e.Thang, e.Stt })
                    .HasName("PK__KT_CHAM_CONG__0FF747D5");

                entity.ToTable("KT_CHAM_CONG");

                entity.Property(e => e.LoaiBangLuong)
                    .HasMaxLength(50)
                    .HasColumnName("LOAI_BANG_LUONG");

                entity.Property(e => e.Nam).HasColumnName("NAM");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.ChucVu)
                    .HasMaxLength(50)
                    .HasColumnName("CHUC_VU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HeSoLuong).HasColumnName("HE_SO_LUONG");

                entity.Property(e => e.HoTenViet)
                    .HasMaxLength(100)
                    .HasColumnName("HO_TEN_VIET")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LuongCoBan).HasColumnName("LUONG_CO_BAN");

                entity.Property(e => e.MaNhanVien)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NHAN_VIEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N01)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N02)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N03)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N04)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N05)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N06)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N07)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N08)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N09)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N10)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N11)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N12)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N13)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N14)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N15)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N16)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N17)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N18)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N19)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N20)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N21)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N22)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N23)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N24)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N25)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N26)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N27)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N28)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N29)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N30)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.N31)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhongBan)
                    .HasMaxLength(50)
                    .HasColumnName("PHONG_BAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenPhongBan)
                    .HasMaxLength(99)
                    .HasColumnName("TEN_PHONG_BAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TongNgayCong).HasColumnName("TONG_NGAY_CONG");

                entity.Property(e => e.TongNgayNghi).HasColumnName("TONG_NGAY_NGHI");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtDoanhthuNhantruoc>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.Stt })
                    .HasName("PK__KT_DOANHTHU_NHAN__00EAD9C6");

                entity.ToTable("KT_DOANHTHU_NHANTRUOC");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.CoTrich)
                    .HasMaxLength(50)
                    .HasColumnName("CO_TRICH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(100)
                    .HasColumnName("DVT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GtclCuoiky).HasColumnName("GTCL_CUOIKY");

                entity.Property(e => e.GtclDauky).HasColumnName("GTCL_DAUKY");

                entity.Property(e => e.GtclDaunam).HasColumnName("GTCL_DAUNAM");

                entity.Property(e => e.Kyhieu)
                    .HasMaxLength(50)
                    .HasColumnName("KYHIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LkTrichCuoiky).HasColumnName("LK_TRICH_CUOIKY");

                entity.Property(e => e.LkTrichDauky).HasColumnName("LK_TRICH_DAUKY");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madoanhthu)
                    .HasMaxLength(50)
                    .HasColumnName("MADOANHTHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnco)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnno)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makh)
                    .HasMaxLength(50)
                    .HasColumnName("MAKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpno)
                    .HasMaxLength(100)
                    .HasColumnName("MAYTCPNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngaybatdau)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYBATDAU");

                entity.Property(e => e.Ngayhopdong)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYHOPDONG");

                entity.Property(e => e.Ngayketthuc)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYKETTHUC");

                entity.Property(e => e.Ngaythu)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYTHU");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(255)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sohopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SOHOPDONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Tendoanhthu)
                    .HasMaxLength(255)
                    .HasColumnName("TENDOANHTHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(250)
                    .HasColumnName("TENKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhom)
                    .HasMaxLength(250)
                    .HasColumnName("TENNHOM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thoigiantrich).HasColumnName("THOIGIANTRICH");

                entity.Property(e => e.TkCongno)
                    .HasMaxLength(50)
                    .HasColumnName("TK_CONGNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkDoanhthu)
                    .HasMaxLength(50)
                    .HasColumnName("TK_DOANHTHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkDoanhthuNhantruoc)
                    .HasMaxLength(100)
                    .HasColumnName("TK_DOANHTHU_NHANTRUOC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tongdoanhthu).HasColumnName("TONGDOANHTHU");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Trich1thang).HasColumnName("TRICH1THANG");

                entity.Property(e => e.TrichThangNay).HasColumnName("TRICH_THANG_NAY");
            });

            modelBuilder.Entity<KtHamin>(entity =>
            {
                entity.HasKey(e => new { e.Lctg, e.Stt })
                    .HasName("PK__KT_HAMIN__3C0AD43D");

                entity.ToTable("KT_HAMIN");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG");

                entity.Property(e => e.Stt)
                    .HasMaxLength(53)
                    .HasColumnName("STT");

                entity.Property(e => e.BeronggapHd).HasColumnName("BERONGGAP_HD");

                entity.Property(e => e.Cotgap)
                    .HasMaxLength(50)
                    .HasColumnName("COTGAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FileExcel)
                    .HasMaxLength(50)
                    .HasColumnName("FILE_EXCEL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Haminchungtu)
                    .HasMaxLength(50)
                    .HasColumnName("HAMINCHUNGTU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sodong).HasColumnName("SODONG");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtHd>(entity =>
            {
                entity.HasKey(e => new { e.Matk, e.Madtpn, e.SoHopdong })
                    .HasName("PK__KT_HD__3568C3A6");

                entity.ToTable("KT_HD");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN");

                entity.Property(e => e.SoHopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HOPDONG");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(250)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GtUsd).HasColumnName("GT_USD");

                entity.Property(e => e.GtVnd).HasColumnName("GT_VND");

                entity.Property(e => e.Hanmuc).HasColumnName("HANMUC");

                entity.Property(e => e.Hanmucusd).HasColumnName("HANMUCUSD");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayDaoHan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_DAO_HAN");

                entity.Property(e => e.NgayGiaoHang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_GIAO_HANG");

                entity.Property(e => e.NgayHopdong)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HOPDONG");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoHopdongGoc)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HOPDONG_GOC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tylelaivay)
                    .HasMaxLength(200)
                    .HasColumnName("TYLELAIVAY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Usdckco).HasColumnName("USDCKCO");

                entity.Property(e => e.Usdckno).HasColumnName("USDCKNO");

                entity.Property(e => e.Usdduco).HasColumnName("USDDUCO");

                entity.Property(e => e.Usdduno).HasColumnName("USDDUNO");

                entity.Property(e => e.Usdpsco).HasColumnName("USDPSCO");

                entity.Property(e => e.Usdpsno).HasColumnName("USDPSNO");

                entity.Property(e => e.Vndckco).HasColumnName("VNDCKCO");

                entity.Property(e => e.Vndckno).HasColumnName("VNDCKNO");

                entity.Property(e => e.Vndduco).HasColumnName("VNDDUCO");

                entity.Property(e => e.Vndduno).HasColumnName("VNDDUNO");

                entity.Property(e => e.Vndpsco).HasColumnName("VNDPSCO");

                entity.Property(e => e.Vndpsno).HasColumnName("VNDPSNO");
            });

            modelBuilder.Entity<KtHdHh>(entity =>
            {
                entity.HasKey(e => new { e.Matk, e.Madtpn, e.SoHopdong, e.Madm })
                    .HasName("PK__KT_HD_HH__4D404D37");

                entity.ToTable("KT_HD_HH");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN");

                entity.Property(e => e.SoHopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HOPDONG");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(250)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GtUsd).HasColumnName("GT_USD");

                entity.Property(e => e.GtVnd).HasColumnName("GT_VND");

                entity.Property(e => e.LuongCk).HasColumnName("LUONG_CK");

                entity.Property(e => e.LuongCo).HasColumnName("LUONG_CO");

                entity.Property(e => e.LuongDk).HasColumnName("LUONG_DK");

                entity.Property(e => e.LuongNo).HasColumnName("LUONG_NO");

                entity.Property(e => e.NgayDaoHan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_DAO_HAN");

                entity.Property(e => e.NgayHopdong)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HOPDONG");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Usdckco).HasColumnName("USDCKCO");

                entity.Property(e => e.Usdckno).HasColumnName("USDCKNO");

                entity.Property(e => e.Usdduco).HasColumnName("USDDUCO");

                entity.Property(e => e.Usdduno).HasColumnName("USDDUNO");

                entity.Property(e => e.Usdpsco).HasColumnName("USDPSCO");

                entity.Property(e => e.Usdpsno).HasColumnName("USDPSNO");

                entity.Property(e => e.Vndckco).HasColumnName("VNDCKCO");

                entity.Property(e => e.Vndckno).HasColumnName("VNDCKNO");

                entity.Property(e => e.Vndduco).HasColumnName("VNDDUCO");

                entity.Property(e => e.Vndduno).HasColumnName("VNDDUNO");

                entity.Property(e => e.Vndpsco).HasColumnName("VNDPSCO");

                entity.Property(e => e.Vndpsno).HasColumnName("VNDPSNO");
            });

            modelBuilder.Entity<KtMaCong>(entity =>
            {
                entity.HasKey(e => e.MaCong)
                    .HasName("PK__KT_MA_CONG__418EA369");

                entity.ToTable("KT_MA_CONG");

                entity.Property(e => e.MaCong)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CONG");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoNgayCong).HasColumnName("SO_NGAY_CONG");

                entity.Property(e => e.TenCong)
                    .HasMaxLength(50)
                    .HasColumnName("TEN_CONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtMaTt>(entity =>
            {
                entity.HasKey(e => e.Kyhieu)
                    .HasName("PK__KT_MA_TT__6359AB88");

                entity.ToTable("KT_MA_TT");

                entity.Property(e => e.Kyhieu)
                    .HasMaxLength(50)
                    .HasColumnName("KYHIEU");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diengiai)
                    .HasMaxLength(250)
                    .HasColumnName("DIENGIAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtNgayLe>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__KT_NGAY_LE__1022305E");

                entity.ToTable("KT_NGAY_LE");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayOfLe).HasColumnName("NGAY_OF_LE");

                entity.Property(e => e.ThangOfLe).HasColumnName("THANG_OF_LE");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtUngLuong>(entity =>
            {
                entity.HasKey(e => new { e.Stt, e.Thang, e.Nam })
                    .HasName("PK__KT_UNG_LUONG__20E2A80C");

                entity.ToTable("KT_UNG_LUONG");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Nam).HasColumnName("NAM");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HoTenViet)
                    .HasMaxLength(100)
                    .HasColumnName("HO_TEN_VIET")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoaiBangLuong)
                    .HasMaxLength(50)
                    .HasColumnName("LOAI_BANG_LUONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LuongCoBan).HasColumnName("LUONG_CO_BAN");

                entity.Property(e => e.MaNhanVien)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NHAN_VIEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaVach)
                    .HasMaxLength(50)
                    .HasColumnName("MA_VACH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhongBan)
                    .HasMaxLength(50)
                    .HasColumnName("PHONG_BAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TamUngLuong).HasColumnName("TAM_UNG_LUONG");

                entity.Property(e => e.TenPhongBan)
                    .HasMaxLength(100)
                    .HasColumnName("TEN_PHONG_BAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkLuong)
                    .HasMaxLength(50)
                    .HasColumnName("TK_LUONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkTamung)
                    .HasMaxLength(50)
                    .HasColumnName("TK_TAMUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtUserTable>(entity =>
            {
                entity.HasKey(e => new { e.Tenbang, e.MaUser })
                    .HasName("PK__KT_USER_TABLE__3079F157");

                entity.ToTable("KT_USER_TABLE");

                entity.Property(e => e.Tenbang)
                    .HasMaxLength(50)
                    .HasColumnName("TENBANG");

                entity.Property(e => e.MaUser)
                    .HasMaxLength(50)
                    .HasColumnName("MA_USER");

                entity.Property(e => e.ChoSua)
                    .HasMaxLength(5)
                    .HasColumnName("CHO_SUA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChoThem)
                    .HasMaxLength(5)
                    .HasColumnName("CHO_THEM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChoXoa)
                    .HasMaxLength(5)
                    .HasColumnName("CHO_XOA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktbaogium>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__KTBAOGIA__16CF2DED");

                entity.ToTable("KTBAOGIA");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Chietkhau).HasColumnName("CHIETKHAU");

                entity.Property(e => e.ChietkhauUsd).HasColumnName("CHIETKHAU_USD");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diengiai)
                    .HasMaxLength(250)
                    .HasColumnName("DIENGIAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DienthoaiNlh)
                    .HasMaxLength(50)
                    .HasColumnName("DIENTHOAI_NLH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(15)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Giabao).HasColumnName("GIABAO");

                entity.Property(e => e.GiabaoUsd).HasColumnName("GIABAO_USD");

                entity.Property(e => e.Giachuan).HasColumnName("GIACHUAN");

                entity.Property(e => e.GiachuanUsd).HasColumnName("GIACHUAN_USD");

                entity.Property(e => e.Loaitien)
                    .HasMaxLength(10)
                    .HasColumnName("LOAITIEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngaybg)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYBG");

                entity.Property(e => e.Ngayhhl)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYHHL");

                entity.Property(e => e.Nguoilap)
                    .HasMaxLength(50)
                    .HasColumnName("NGUOILAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nguoilienhe)
                    .HasMaxLength(50)
                    .HasColumnName("NGUOILIENHE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PtCk).HasColumnName("PT_CK");

                entity.Property(e => e.Sobg)
                    .HasMaxLength(50)
                    .HasColumnName("SOBG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.SongayTt).HasColumnName("SONGAY_TT");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thuesuat).HasColumnName("THUESUAT");

                entity.Property(e => e.Thueusd).HasColumnName("THUEUSD");

                entity.Property(e => e.Thuevnd).HasColumnName("THUEVND");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ttusd).HasColumnName("TTUSD");

                entity.Property(e => e.TtusdTt).HasColumnName("TTUSD_TT");

                entity.Property(e => e.Ttvnd).HasColumnName("TTVND");

                entity.Property(e => e.TtvndTt).HasColumnName("TTVND_TT");

                entity.Property(e => e.Tygia).HasColumnName("TYGIA");
            });

            modelBuilder.Entity<Ktbaohanh>(entity =>
            {
                entity.HasKey(e => e.Imei)
                    .HasName("PK__KTBAOHANH__218BE82B");

                entity.ToTable("KTBAOHANH");

                entity.Property(e => e.Imei)
                    .HasMaxLength(50)
                    .HasColumnName("IMEI");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(250)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(250)
                    .HasColumnName("DIACHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(50)
                    .HasColumnName("DVT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Machinhanh)
                    .HasMaxLength(50)
                    .HasColumnName("MACHINHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makh)
                    .HasMaxLength(50)
                    .HasColumnName("MAKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MsDn)
                    .HasMaxLength(50)
                    .HasColumnName("MS_DN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngayban)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYBAN");

                entity.Property(e => e.Ngayhhbh)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYHHBH");

                entity.Property(e => e.Ngaynhap)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYNHAP");

                entity.Property(e => e.Ngayxuat)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYXUAT");

                entity.Property(e => e.NhapTk).HasColumnName("NHAP_TK");

                entity.Property(e => e.Noidungbh)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNGBH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(250)
                    .HasColumnName("TENKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tinhtrang)
                    .HasMaxLength(50)
                    .HasColumnName("TINHTRANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkhh)
                    .HasMaxLength(50)
                    .HasColumnName("TKHH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonCk).HasColumnName("TON_CK");

                entity.Property(e => e.TonDk).HasColumnName("TON_DK");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.XuatTk).HasColumnName("XUAT_TK");
            });

            modelBuilder.Entity<Ktbarcode>(entity =>
            {
                entity.HasKey(e => new { e.Barcode, e.Matk, e.Madm, e.Madtpn, e.Lo })
                    .HasName("PK__KTBARCODE__108B795B");

                entity.ToTable("KTBARCODE");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .HasColumnName("BARCODE");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN");

                entity.Property(e => e.Lo)
                    .HasMaxLength(50)
                    .HasColumnName("LO");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgban).HasColumnName("DGBAN");

                entity.Property(e => e.Dgnhap).HasColumnName("DGNHAP");

                entity.Property(e => e.Dgusd).HasColumnName("DGUSD");

                entity.Property(e => e.Dgxuat).HasColumnName("DGXUAT");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(255)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi1)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI_1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi2)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI_2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hansudung)
                    .HasColumnType("datetime")
                    .HasColumnName("HANSUDUNG");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(250)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kyhieu)
                    .HasMaxLength(255)
                    .HasColumnName("KYHIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Luongxuat).HasColumnName("LUONGXUAT");

                entity.Property(e => e.MsDg)
                    .HasMaxLength(255)
                    .HasColumnName("MS_DG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngaylo)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYLO");

                entity.Property(e => e.Ngaynhapkho)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYNHAPKHO");

                entity.Property(e => e.Nhacungcap)
                    .HasMaxLength(250)
                    .HasColumnName("NHACUNGCAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NhapT).HasColumnName("NHAP_T");

                entity.Property(e => e.NhapTDv1).HasColumnName("NHAP_T_DV1");

                entity.Property(e => e.NhapTDv2).HasColumnName("NHAP_T_DV2");

                entity.Property(e => e.Nhasanxuat)
                    .HasMaxLength(250)
                    .HasColumnName("NHASANXUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(255)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(255)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonCk).HasColumnName("TON_CK");

                entity.Property(e => e.TonCkDv1).HasColumnName("TON_CK_DV1");

                entity.Property(e => e.TonCkDv2).HasColumnName("TON_CK_DV2");

                entity.Property(e => e.TonT).HasColumnName("TON_T");

                entity.Property(e => e.TonTDv1).HasColumnName("TON_T_DV1");

                entity.Property(e => e.TonTDv2).HasColumnName("TON_T_DV2");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ttban).HasColumnName("TTBAN");

                entity.Property(e => e.UsdnhapT).HasColumnName("USDNHAP_T");

                entity.Property(e => e.UsdtonCk).HasColumnName("USDTON_CK");

                entity.Property(e => e.UsdtonT).HasColumnName("USDTON_T");

                entity.Property(e => e.UsdxuatT).HasColumnName("USDXUAT_T");

                entity.Property(e => e.VndnhapT).HasColumnName("VNDNHAP_T");

                entity.Property(e => e.VndtonCk).HasColumnName("VNDTON_CK");

                entity.Property(e => e.VndtonT).HasColumnName("VNDTON_T");

                entity.Property(e => e.VndxuatT).HasColumnName("VNDXUAT_T");

                entity.Property(e => e.XuatT).HasColumnName("XUAT_T");

                entity.Property(e => e.XuatTDv1).HasColumnName("XUAT_T_DV1");

                entity.Property(e => e.XuatTDv2).HasColumnName("XUAT_T_DV2");
            });

            modelBuilder.Entity<Ktcaphh>(entity =>
            {
                entity.HasKey(e => new { e.Loaima, e.Nhomcap, e.Macap })
                    .HasName("PK__KTCAPHH__3CC9EE4C");

                entity.ToTable("KTCAPHH");

                entity.Property(e => e.Loaima)
                    .HasMaxLength(10)
                    .HasColumnName("LOAIMA");

                entity.Property(e => e.Nhomcap)
                    .HasMaxLength(10)
                    .HasColumnName("NHOMCAP");

                entity.Property(e => e.Macap)
                    .HasMaxLength(10)
                    .HasColumnName("MACAP");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tencap)
                    .HasMaxLength(50)
                    .HasColumnName("TENCAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktcn>(entity =>
            {
                entity.HasKey(e => new { e.Matk, e.Madtpn })
                    .HasName("PK__KTCN__396E5EB4");

                entity.ToTable("KTCN");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(250)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(250)
                    .HasColumnName("DIACHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dientich).HasColumnName("DIENTICH");

                entity.Property(e => e.Dongia).HasColumnName("DONGIA");

                entity.Property(e => e.Eurckco).HasColumnName("EURCKCO");

                entity.Property(e => e.Eurckno).HasColumnName("EURCKNO");

                entity.Property(e => e.Eurduco).HasColumnName("EURDUCO");

                entity.Property(e => e.Eurduno).HasColumnName("EURDUNO");

                entity.Property(e => e.Eurpsco).HasColumnName("EURPSCO");

                entity.Property(e => e.Eurpsno).HasColumnName("EURPSNO");

                entity.Property(e => e.GiatriHopdong).HasColumnName("GIATRI_HOPDONG");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom1)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom2)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom3)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matt)
                    .HasMaxLength(50)
                    .HasColumnName("MATT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayHopdong)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HOPDONG");

                entity.Property(e => e.NgayThanhly)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_THANHLY");

                entity.Property(e => e.SoHopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HOPDONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhom1)
                    .HasMaxLength(250)
                    .HasColumnName("TENNHOM1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhom2)
                    .HasMaxLength(250)
                    .HasColumnName("TENNHOM2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhom3)
                    .HasMaxLength(250)
                    .HasColumnName("TENNHOM3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tentt)
                    .HasMaxLength(250)
                    .HasColumnName("TENTT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Usdckco).HasColumnName("USDCKCO");

                entity.Property(e => e.Usdckno).HasColumnName("USDCKNO");

                entity.Property(e => e.Usdduco).HasColumnName("USDDUCO");

                entity.Property(e => e.Usdduno).HasColumnName("USDDUNO");

                entity.Property(e => e.Usdpsco).HasColumnName("USDPSCO");

                entity.Property(e => e.Usdpsno).HasColumnName("USDPSNO");

                entity.Property(e => e.Vndckco).HasColumnName("VNDCKCO");

                entity.Property(e => e.Vndckno).HasColumnName("VNDCKNO");

                entity.Property(e => e.Vndduco).HasColumnName("VNDDUCO");

                entity.Property(e => e.Vndduno).HasColumnName("VNDDUNO");

                entity.Property(e => e.VndnoMax).HasColumnName("VNDNO_MAX");

                entity.Property(e => e.Vndpsco).HasColumnName("VNDPSCO");

                entity.Property(e => e.Vndpsno).HasColumnName("VNDPSNO");
            });

            modelBuilder.Entity<KtcnCt>(entity =>
            {
                entity.HasKey(e => new { e.Matk, e.MaCt, e.Madtpn })
                    .HasName("PK__KTCN_CT__2D729C23");

                entity.ToTable("KTCN_CT");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(250)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(250)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCt1)
                    .HasMaxLength(200)
                    .HasColumnName("MA_CT_1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCt2)
                    .HasMaxLength(200)
                    .HasColumnName("MA_CT_2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhomct)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOMCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhomdt)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOMDT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayDaoHan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_DAO_HAN");

                entity.Property(e => e.NgayHopdong)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HOPDONG");

                entity.Property(e => e.Ngayhh)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYHH");

                entity.Property(e => e.SoHopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HOPDONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenCt1)
                    .HasMaxLength(1000)
                    .HasColumnName("TEN_CT_1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenCt2)
                    .HasMaxLength(1000)
                    .HasColumnName("TEN_CT_2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct)
                    .HasMaxLength(250)
                    .HasColumnName("TENCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhomct)
                    .HasMaxLength(250)
                    .HasColumnName("TENNHOMCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhomdt)
                    .HasMaxLength(250)
                    .HasColumnName("TENNHOMDT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TuoiNo).HasColumnName("TUOI_NO");

                entity.Property(e => e.UsdNo30).HasColumnName("USD_NO_30");

                entity.Property(e => e.UsdNo3060).HasColumnName("USD_NO_30_60");

                entity.Property(e => e.UsdNo6090).HasColumnName("USD_NO_60_90");

                entity.Property(e => e.UsdNo90).HasColumnName("USD_NO_90");

                entity.Property(e => e.Usdckco).HasColumnName("USDCKCO");

                entity.Property(e => e.Usdckno).HasColumnName("USDCKNO");

                entity.Property(e => e.Usdduco).HasColumnName("USDDUCO");

                entity.Property(e => e.Usdduno).HasColumnName("USDDUNO");

                entity.Property(e => e.Usdpsco).HasColumnName("USDPSCO");

                entity.Property(e => e.Usdpsno).HasColumnName("USDPSNO");

                entity.Property(e => e.VndNo30).HasColumnName("VND_NO_30");

                entity.Property(e => e.VndNo3060).HasColumnName("VND_NO_30_60");

                entity.Property(e => e.VndNo6090).HasColumnName("VND_NO_60_90");

                entity.Property(e => e.VndNo90).HasColumnName("VND_NO_90");

                entity.Property(e => e.Vndckco).HasColumnName("VNDCKCO");

                entity.Property(e => e.Vndckno).HasColumnName("VNDCKNO");

                entity.Property(e => e.Vndduco).HasColumnName("VNDDUCO");

                entity.Property(e => e.Vndduno).HasColumnName("VNDDUNO");

                entity.Property(e => e.Vnddutoan).HasColumnName("VNDDUTOAN");

                entity.Property(e => e.Vndkehoach).HasColumnName("VNDKEHOACH");

                entity.Property(e => e.Vndpsco).HasColumnName("VNDPSCO");

                entity.Property(e => e.VndpscoLk).HasColumnName("VNDPSCO_LK");

                entity.Property(e => e.Vndpsno).HasColumnName("VNDPSNO");

                entity.Property(e => e.VndpsnoLk).HasColumnName("VNDPSNO_LK");
            });

            modelBuilder.Entity<KtcnCtHd>(entity =>
            {
                entity.HasKey(e => new { e.Matk, e.Madtpn, e.Maduan, e.MaCt, e.Mahopdong })
                    .HasName("PK__KTCN_CT_HD__15F0184D");

                entity.ToTable("KTCN_CT_HD");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN");

                entity.Property(e => e.Maduan)
                    .HasMaxLength(50)
                    .HasColumnName("MADUAN");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT");

                entity.Property(e => e.Mahopdong)
                    .HasMaxLength(50)
                    .HasColumnName("MAHOPDONG");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(250)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(250)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngayhopdong)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYHOPDONG");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sohopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SOHOPDONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct)
                    .HasMaxLength(250)
                    .HasColumnName("TENCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenduan)
                    .HasMaxLength(250)
                    .HasColumnName("TENDUAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TuoiNo).HasColumnName("TUOI_NO");

                entity.Property(e => e.UsdNo30).HasColumnName("USD_NO_30");

                entity.Property(e => e.UsdNo3060).HasColumnName("USD_NO_30_60");

                entity.Property(e => e.UsdNo6090).HasColumnName("USD_NO_60_90");

                entity.Property(e => e.UsdNo90).HasColumnName("USD_NO_90");

                entity.Property(e => e.Usdckco).HasColumnName("USDCKCO");

                entity.Property(e => e.Usdckno).HasColumnName("USDCKNO");

                entity.Property(e => e.Usdduco).HasColumnName("USDDUCO");

                entity.Property(e => e.Usdduno).HasColumnName("USDDUNO");

                entity.Property(e => e.Usdpsco).HasColumnName("USDPSCO");

                entity.Property(e => e.Usdpsno).HasColumnName("USDPSNO");

                entity.Property(e => e.VndNo30).HasColumnName("VND_NO_30");

                entity.Property(e => e.VndNo3060).HasColumnName("VND_NO_30_60");

                entity.Property(e => e.VndNo6090).HasColumnName("VND_NO_60_90");

                entity.Property(e => e.VndNo90).HasColumnName("VND_NO_90");

                entity.Property(e => e.Vndckco).HasColumnName("VNDCKCO");

                entity.Property(e => e.Vndckno).HasColumnName("VNDCKNO");

                entity.Property(e => e.Vndduco).HasColumnName("VNDDUCO");

                entity.Property(e => e.Vndduno).HasColumnName("VNDDUNO");

                entity.Property(e => e.Vndpsco).HasColumnName("VNDPSCO");

                entity.Property(e => e.VndpscoLk).HasColumnName("VNDPSCO_LK");

                entity.Property(e => e.Vndpsno).HasColumnName("VNDPSNO");

                entity.Property(e => e.VndpsnoLk).HasColumnName("VNDPSNO_LK");
            });

            modelBuilder.Entity<KtcnCtTt>(entity =>
            {
                entity.HasKey(e => new { e.Matk, e.Madtpn, e.MaCt, e.SttTt })
                    .HasName("PK__KTCN_CT_TT__5DABBF2A");

                entity.ToTable("KTCN_CT_TT");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT");

                entity.Property(e => e.SttTt).HasColumnName("STT_TT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(250)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KyTt)
                    .HasMaxLength(50)
                    .HasColumnName("KY_TT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayHopdong)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HOPDONG");

                entity.Property(e => e.NgayTt)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_TT");

                entity.Property(e => e.SoHopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HOPDONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct)
                    .HasMaxLength(250)
                    .HasColumnName("TENCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsdTt).HasColumnName("USD_TT");

                entity.Property(e => e.Usdckco).HasColumnName("USDCKCO");

                entity.Property(e => e.Usdckno).HasColumnName("USDCKNO");

                entity.Property(e => e.Usdduco).HasColumnName("USDDUCO");

                entity.Property(e => e.Usdduno).HasColumnName("USDDUNO");

                entity.Property(e => e.Usdpsco).HasColumnName("USDPSCO");

                entity.Property(e => e.Usdpsno).HasColumnName("USDPSNO");

                entity.Property(e => e.VndTt).HasColumnName("VND_TT");

                entity.Property(e => e.Vndckco).HasColumnName("VNDCKCO");

                entity.Property(e => e.Vndckno).HasColumnName("VNDCKNO");

                entity.Property(e => e.Vndduco).HasColumnName("VNDDUCO");

                entity.Property(e => e.Vndduno).HasColumnName("VNDDUNO");

                entity.Property(e => e.Vndpsco).HasColumnName("VNDPSCO");

                entity.Property(e => e.Vndpsno).HasColumnName("VNDPSNO");
            });

            modelBuilder.Entity<KtcnCtu>(entity =>
            {
                entity.HasKey(e => new { e.Matk, e.Madtpn, e.SoctU, e.MaCt, e.SoHopdong })
                    .HasName("PK__KTCN_CTU__2AB62B09");

                entity.ToTable("KTCN_CTU");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN");

                entity.Property(e => e.SoctU)
                    .HasMaxLength(50)
                    .HasColumnName("SOCT_U");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT");

                entity.Property(e => e.SoHopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HOPDONG");

                entity.Property(e => e.Cnee)
                    .HasMaxLength(100)
                    .HasColumnName("CNEE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(100)
                    .HasColumnName("INVOICE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngayct)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYCT");

                entity.Property(e => e.Shipper)
                    .HasMaxLength(100)
                    .HasColumnName("SHIPPER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoBillVc)
                    .HasMaxLength(100)
                    .HasColumnName("SO_BILL_VC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SochungtuVc)
                    .HasMaxLength(100)
                    .HasColumnName("SOCHUNGTU_VC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sovandon)
                    .HasMaxLength(100)
                    .HasColumnName("SOVANDON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(255)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .HasColumnName("TYPE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Usdckco).HasColumnName("USDCKCO");

                entity.Property(e => e.Usdckno).HasColumnName("USDCKNO");

                entity.Property(e => e.Usdduco).HasColumnName("USDDUCO");

                entity.Property(e => e.Usdduno).HasColumnName("USDDUNO");

                entity.Property(e => e.Usdpsco).HasColumnName("USDPSCO");

                entity.Property(e => e.Usdpsno).HasColumnName("USDPSNO");

                entity.Property(e => e.Vndckco).HasColumnName("VNDCKCO");

                entity.Property(e => e.Vndckno).HasColumnName("VNDCKNO");

                entity.Property(e => e.Vndduco).HasColumnName("VNDDUCO");

                entity.Property(e => e.Vndduno).HasColumnName("VNDDUNO");

                entity.Property(e => e.Vndpsco).HasColumnName("VNDPSCO");

                entity.Property(e => e.Vndpsno).HasColumnName("VNDPSNO");

                entity.Property(e => e.Vsl)
                    .HasMaxLength(100)
                    .HasColumnName("VSL")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Ktcomputer>(entity =>
            {
                entity.HasKey(e => e.Hddid)
                    .HasName("PK__KTCOMPUTER__703EA55A");

                entity.ToTable("KTCOMPUTER");

                entity.Property(e => e.Hddid)
                    .HasMaxLength(50)
                    .HasColumnName("HDDID");

                entity.Property(e => e.Computer)
                    .HasMaxLength(100)
                    .HasColumnName("COMPUTER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Khoadangnhap)
                    .HasMaxLength(10)
                    .HasColumnName("KHOADANGNHAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TgRa)
                    .HasMaxLength(50)
                    .HasColumnName("TG_RA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TgVao)
                    .HasMaxLength(50)
                    .HasColumnName("TG_VAO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktcongthuc>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__KTCONGTHUC__383021B8");

                entity.ToTable("KTCONGTHUC");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Congthuc)
                    .HasMaxLength(250)
                    .HasColumnName("CONGTHUC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dieukien)
                    .HasMaxLength(250)
                    .HasColumnName("DIEUKIEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kieucongthuc)
                    .HasMaxLength(50)
                    .HasColumnName("KIEUCONGTHUC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nam).HasColumnName("NAM");

                entity.Property(e => e.Tenbang)
                    .HasMaxLength(50)
                    .HasColumnName("TENBANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktcp>(entity =>
            {
                entity.HasKey(e => new { e.Matk, e.Maytcp, e.Madtpn })
                    .HasName("PK__KTCP__7DAE7A68");

                entity.ToTable("KTCP");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.Maytcp)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCP");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(250)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tentk)
                    .HasMaxLength(250)
                    .HasColumnName("TENTK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenytcp)
                    .HasMaxLength(250)
                    .HasColumnName("TENYTCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Usdckco).HasColumnName("USDCKCO");

                entity.Property(e => e.Usdckno).HasColumnName("USDCKNO");

                entity.Property(e => e.Usdduco).HasColumnName("USDDUCO");

                entity.Property(e => e.Usdduno).HasColumnName("USDDUNO");

                entity.Property(e => e.Usdpsco).HasColumnName("USDPSCO");

                entity.Property(e => e.UsdpscoLk).HasColumnName("USDPSCO_LK");

                entity.Property(e => e.Usdpsno).HasColumnName("USDPSNO");

                entity.Property(e => e.UsdpsnoLk).HasColumnName("USDPSNO_LK");

                entity.Property(e => e.Vndckco).HasColumnName("VNDCKCO");

                entity.Property(e => e.Vndckno).HasColumnName("VNDCKNO");

                entity.Property(e => e.Vndduco).HasColumnName("VNDDUCO");

                entity.Property(e => e.Vndduno).HasColumnName("VNDDUNO");

                entity.Property(e => e.Vndpsco).HasColumnName("VNDPSCO");

                entity.Property(e => e.VndpscoLk).HasColumnName("VNDPSCO_LK");

                entity.Property(e => e.Vndpsno).HasColumnName("VNDPSNO");

                entity.Property(e => e.VndpsnoLk).HasColumnName("VNDPSNO_LK");
            });

            modelBuilder.Entity<KtcpCt>(entity =>
            {
                entity.HasKey(e => new { e.Matk, e.MaCt, e.Maytcp, e.Madm })
                    .HasName("PK__KTCP_CT__548C6944");

                entity.ToTable("KTCP_CT");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT");

                entity.Property(e => e.Maytcp)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCP");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(250)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(250)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GtLkDkIn).HasColumnName("GT_LK_DK_IN");

                entity.Property(e => e.GtPsDenTungay).HasColumnName("GT_PS_DEN_TUNGAY");

                entity.Property(e => e.GtPsGiam).HasColumnName("GT_PS_GIAM");

                entity.Property(e => e.GtPsTang).HasColumnName("GT_PS_TANG");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Luong).HasColumnName("LUONG");

                entity.Property(e => e.LuongLkCk).HasColumnName("LUONG_LK_CK");

                entity.Property(e => e.LuongLkDk).HasColumnName("LUONG_LK_DK");

                entity.Property(e => e.LuongLkDkIn).HasColumnName("LUONG_LK_DK_IN");

                entity.Property(e => e.LuongPs).HasColumnName("LUONG_PS");

                entity.Property(e => e.LuongPsDenTungay).HasColumnName("LUONG_PS_DEN_TUNGAY");

                entity.Property(e => e.LuongPsGiam).HasColumnName("LUONG_PS_GIAM");

                entity.Property(e => e.LuongPsTang).HasColumnName("LUONG_PS_TANG");

                entity.Property(e => e.MaCt1)
                    .HasMaxLength(100)
                    .HasColumnName("MA_CT_1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCt2)
                    .HasMaxLength(100)
                    .HasColumnName("MA_CT_2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maduan)
                    .HasMaxLength(50)
                    .HasColumnName("MADUAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mahopdong)
                    .HasMaxLength(50)
                    .HasColumnName("MAHOPDONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngayhopdong)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYHOPDONG");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sohopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SOHOPDONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct)
                    .HasMaxLength(250)
                    .HasColumnName("TENCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenduan)
                    .HasMaxLength(250)
                    .HasColumnName("TENDUAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tentk)
                    .HasMaxLength(250)
                    .HasColumnName("TENTK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenytcp)
                    .HasMaxLength(250)
                    .HasColumnName("TENYTCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tinhtrang)
                    .HasMaxLength(50)
                    .HasColumnName("TINHTRANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Usdckco).HasColumnName("USDCKCO");

                entity.Property(e => e.Usdckno).HasColumnName("USDCKNO");

                entity.Property(e => e.Usdduco).HasColumnName("USDDUCO");

                entity.Property(e => e.Usdduno).HasColumnName("USDDUNO");

                entity.Property(e => e.Usdpsco).HasColumnName("USDPSCO");

                entity.Property(e => e.UsdpscoLk).HasColumnName("USDPSCO_LK");

                entity.Property(e => e.Usdpsno).HasColumnName("USDPSNO");

                entity.Property(e => e.UsdpsnoLk).HasColumnName("USDPSNO_LK");

                entity.Property(e => e.Vndckco).HasColumnName("VNDCKCO");

                entity.Property(e => e.Vndckno).HasColumnName("VNDCKNO");

                entity.Property(e => e.Vndduco).HasColumnName("VNDDUCO");

                entity.Property(e => e.Vndduno).HasColumnName("VNDDUNO");

                entity.Property(e => e.Vndpsco).HasColumnName("VNDPSCO");

                entity.Property(e => e.VndpscoLk).HasColumnName("VNDPSCO_LK");

                entity.Property(e => e.Vndpsno).HasColumnName("VNDPSNO");

                entity.Property(e => e.VndpsnoLk).HasColumnName("VNDPSNO_LK");
            });

            modelBuilder.Entity<Ktcpcpb>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.Mats })
                    .HasName("PK__KTCPCPB__1526DC9D");

                entity.ToTable("KTCPCPB");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Mats)
                    .HasMaxLength(50)
                    .HasColumnName("MATS");

                entity.Property(e => e.CoKh)
                    .HasMaxLength(50)
                    .HasColumnName("CO_KH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dtsudung)
                    .HasMaxLength(255)
                    .HasColumnName("DTSUDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gtconlai).HasColumnName("GTCONLAI");

                entity.Property(e => e.GtconlaiDk).HasColumnName("GTCONLAI_DK");

                entity.Property(e => e.GtconlaiUsd).HasColumnName("GTCONLAI_USD");

                entity.Property(e => e.Kh1thang).HasColumnName("KH1THANG");

                entity.Property(e => e.Kh1thangUsd).HasColumnName("KH1THANG_USD");

                entity.Property(e => e.KhThangnay).HasColumnName("KH_THANGNAY");

                entity.Property(e => e.KhThangnayUsd).HasColumnName("KH_THANGNAY_USD");

                entity.Property(e => e.LuykeKh).HasColumnName("LUYKE_KH");

                entity.Property(e => e.LuykeKhDk).HasColumnName("LUYKE_KH_DK");

                entity.Property(e => e.LuykeKhUsd).HasColumnName("LUYKE_KH_USD");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnco)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnno)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MatsMe)
                    .HasMaxLength(50)
                    .HasColumnName("MATS_ME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpno)
                    .HasMaxLength(100)
                    .HasColumnName("MAYTCPNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nam).HasColumnName("NAM");

                entity.Property(e => e.Ngayban)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYBAN");

                entity.Property(e => e.Ngaymua)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYMUA");

                entity.Property(e => e.Ngaytrichkh)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYTRICHKH");

                entity.Property(e => e.Nguyengia).HasColumnName("NGUYENGIA");

                entity.Property(e => e.NguyengiaDk).HasColumnName("NGUYENGIA_DK");

                entity.Property(e => e.NguyengiaUsd).HasColumnName("NGUYENGIA_USD");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Tents)
                    .HasMaxLength(255)
                    .HasColumnName("TENTS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TentsMe)
                    .HasMaxLength(250)
                    .HasColumnName("TENTS_ME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thoigiankh).HasColumnName("THOIGIANKH");

                entity.Property(e => e.Tkcp)
                    .HasMaxLength(50)
                    .HasColumnName("TKCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkhm)
                    .HasMaxLength(50)
                    .HasColumnName("TKHM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkts)
                    .HasMaxLength(100)
                    .HasColumnName("TKTS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tygia).HasColumnName("TYGIA");
            });

            modelBuilder.Entity<Ktddck>(entity =>
            {
                entity.HasKey(e => new { e.Kyhachtoan, e.MaThanhpham })
                    .HasName("PK__KTDDCK__4999D985");

                entity.ToTable("KTDDCK");

                entity.Property(e => e.Kyhachtoan).HasColumnName("KYHACHTOAN");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM");

                entity.Property(e => e.Cp621).HasColumnName("CP_621");

                entity.Property(e => e.Cp622).HasColumnName("CP_622");

                entity.Property(e => e.Cp627).HasColumnName("CP_627");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ptht).HasColumnName("PTHT");

                entity.Property(e => e.Slddck).HasColumnName("SLDDCK");

                entity.Property(e => e.Sldddk).HasColumnName("SLDDDK");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TongCp).HasColumnName("TONG_CP");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtddckGd>(entity =>
            {
                entity.HasKey(e => new { e.Giaidoan, e.Kyhachtoan, e.MaThanhpham })
                    .HasName("PK__KTDDCK_GD__1B9317B3");

                entity.ToTable("KTDDCK_GD");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.Kyhachtoan).HasColumnName("KYHACHTOAN");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM");

                entity.Property(e => e.Cp621).HasColumnName("CP_621");

                entity.Property(e => e.Cp622).HasColumnName("CP_622");

                entity.Property(e => e.Cp627).HasColumnName("CP_627");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Khongtinhchiphi)
                    .HasMaxLength(10)
                    .HasColumnName("KHONGTINHCHIPHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ptht).HasColumnName("PTHT");

                entity.Property(e => e.Slddck).HasColumnName("SLDDCK");

                entity.Property(e => e.Sldddk).HasColumnName("SLDDDK");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TongCp).HasColumnName("TONG_CP");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtddnlGd>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.Giaidoan, e.MaNguyenlieu })
                    .HasName("PK__KTDDNL_GD__4C220BCC");

                entity.ToTable("KTDDNL_GD");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.MaNguyenlieu)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NGUYENLIEU");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DgNl).HasColumnName("DG_NL");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(20)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SlNl).HasColumnName("SL_NL");

                entity.Property(e => e.TenNguyenlieu)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_NGUYENLIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkDd)
                    .HasMaxLength(50)
                    .HasColumnName("TK_DD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkNl)
                    .HasMaxLength(50)
                    .HasColumnName("TK_NL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TtNl).HasColumnName("TT_NL");
            });

            modelBuilder.Entity<KtddnlZ2>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.MaNguyenlieu })
                    .HasName("PK__KTDDNL_Z2__09EA341B");

                entity.ToTable("KTDDNL_Z2");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.MaNguyenlieu)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NGUYENLIEU");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DgNl).HasColumnName("DG_NL");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(20)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SlNl).HasColumnName("SL_NL");

                entity.Property(e => e.TenNguyenlieu)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_NGUYENLIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkDd)
                    .HasMaxLength(50)
                    .HasColumnName("TK_DD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkNl)
                    .HasMaxLength(50)
                    .HasColumnName("TK_NL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TtNl).HasColumnName("TT_NL");
            });

            modelBuilder.Entity<Ktdgban>(entity =>
            {
                entity.HasKey(e => new { e.SttDg, e.Manhom, e.Tennhom })
                    .HasName("PK__KTDGBAN__31190FD5");

                entity.ToTable("KTDGBAN");

                entity.Property(e => e.SttDg).HasColumnName("STT_DG");

                entity.Property(e => e.Manhom)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM");

                entity.Property(e => e.Tennhom)
                    .HasMaxLength(50)
                    .HasColumnName("TENNHOM");

                entity.Property(e => e.Cong).HasColumnName("CONG");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(1)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DenNgay)
                    .HasColumnType("datetime")
                    .HasColumnName("DEN_NGAY");

                entity.Property(e => e.Dgvnd).HasColumnName("DGVND");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TuNgay)
                    .HasColumnType("datetime")
                    .HasColumnName("TU_NGAY");
            });

            modelBuilder.Entity<KtdgbanBp>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__KTDGBAN_BP__43A1D464");

                entity.ToTable("KTDGBAN_BP");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(100)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DenNgay)
                    .HasColumnType("datetime")
                    .HasColumnName("DEN_NGAY");

                entity.Property(e => e.Dgvnd).HasColumnName("DGVND");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaNhomKh)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NHOM_KH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mabpsx)
                    .HasMaxLength(50)
                    .HasColumnName("MABPSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MatkHh)
                    .HasMaxLength(50)
                    .HasColumnName("MATK_HH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMa)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTen)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SttSapxep).HasColumnName("STT_SAPXEP");

                entity.Property(e => e.TenNhomKh)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_NHOM_KH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenbpsx)
                    .HasMaxLength(250)
                    .HasColumnName("TENBPSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TuNgay)
                    .HasColumnType("datetime")
                    .HasColumnName("TU_NGAY");
            });

            modelBuilder.Entity<KtdgbanNgay>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__KTDGBAN_NGAY__54CC6066");

                entity.ToTable("KTDGBAN_NGAY");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(10)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgvnd1).HasColumnName("DGVND1");

                entity.Property(e => e.Dgvnd2).HasColumnName("DGVND2");

                entity.Property(e => e.Dgvnd3).HasColumnName("DGVND3");

                entity.Property(e => e.Dgvnd4).HasColumnName("DGVND4");

                entity.Property(e => e.Dgvnd5).HasColumnName("DGVND5");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gioapdung)
                    .HasMaxLength(50)
                    .HasColumnName("GIOAPDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngayad)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYAD");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasMaxLength(10)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Ktdgck>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.Stt })
                    .HasName("PK__KTDGCK__2157A958");

                entity.ToTable("KTDGCK");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dg1kho).HasColumnName("DG_1KHO");

                entity.Property(e => e.DgAllkho).HasColumnName("DG_ALLKHO");

                entity.Property(e => e.DgChuyenkho).HasColumnName("DG_CHUYENKHO");

                entity.Property(e => e.DgKtsc).HasColumnName("DG_KTSC");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(250)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madmco)
                    .HasMaxLength(50)
                    .HasColumnName("MADMCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madmno)
                    .HasMaxLength(50)
                    .HasColumnName("MADMNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnco)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnno)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkco)
                    .HasMaxLength(50)
                    .HasColumnName("TKCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkno)
                    .HasMaxLength(50)
                    .HasColumnName("TKNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasMaxLength(10)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Ktdgmua>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__KTDGMUA__62265B84");

                entity.ToTable("KTDGMUA");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(100)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DenNgay)
                    .HasColumnType("datetime")
                    .HasColumnName("DEN_NGAY");

                entity.Property(e => e.Dgvnd).HasColumnName("DGVND");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mabpsx)
                    .HasMaxLength(50)
                    .HasColumnName("MABPSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ManhomDgMua)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM_DG_MUA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MatkHh)
                    .HasMaxLength(50)
                    .HasColumnName("MATK_HH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccMa)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_MA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccTen)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SttSapxep).HasColumnName("STT_SAPXEP");

                entity.Property(e => e.Tenbpsx)
                    .HasMaxLength(250)
                    .HasColumnName("TENBPSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TennhomDgMua)
                    .HasMaxLength(250)
                    .HasColumnName("TENNHOM_DG_MUA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TuNgay)
                    .HasColumnType("datetime")
                    .HasColumnName("TU_NGAY");
            });

            modelBuilder.Entity<Ktdhban>(entity =>
            {
                entity.ToTable("KTDHBAN");

                entity.Property(e => e.Id)
                    .HasMaxLength(15)
                    .HasColumnName("ID");

                entity.Property(e => e.ChietkhauUsd).HasColumnName("CHIETKHAU_USD");

                entity.Property(e => e.ChietkhauVnd).HasColumnName("CHIETKHAU_VND");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgusd).HasColumnName("DGUSD");

                entity.Property(e => e.Dgvnd).HasColumnName("DGVND");

                entity.Property(e => e.Donggoi01)
                    .HasMaxLength(50)
                    .HasColumnName("DONGGOI_01")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donggoi02)
                    .HasMaxLength(50)
                    .HasColumnName("DONGGOI_02")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(50)
                    .HasColumnName("DVT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhichuDh)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU_DH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhichuMh)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU_MH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ldh)
                    .HasMaxLength(50)
                    .HasColumnName("LDH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhbDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("LHB_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhbEmail)
                    .HasMaxLength(50)
                    .HasColumnName("LHB_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhbMaDt)
                    .HasMaxLength(50)
                    .HasColumnName("LHB_MA_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhbTenDt)
                    .HasMaxLength(250)
                    .HasColumnName("LHB_TEN_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnEmail)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnMaDt)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_MA_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnTenDt)
                    .HasMaxLength(250)
                    .HasColumnName("LHCN_TEN_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Luong01Cl).HasColumnName("LUONG_01_CL");

                entity.Property(e => e.Luong01LkCk).HasColumnName("LUONG_01_LK_CK");

                entity.Property(e => e.Luong01LkDk).HasColumnName("LUONG_01_LK_DK");

                entity.Property(e => e.Luong01PsTk).HasColumnName("LUONG_01_PS_TK");

                entity.Property(e => e.Luong02Cl).HasColumnName("LUONG_02_CL");

                entity.Property(e => e.Luong02LkCk).HasColumnName("LUONG_02_LK_CK");

                entity.Property(e => e.Luong02LkDk).HasColumnName("LUONG_02_LK_DK");

                entity.Property(e => e.Luong02PsTk).HasColumnName("LUONG_02_PS_TK");

                entity.Property(e => e.Luong03Cl).HasColumnName("LUONG_03_CL");

                entity.Property(e => e.Luong03LkCk).HasColumnName("LUONG_03_LK_CK");

                entity.Property(e => e.Luong03LkDk).HasColumnName("LUONG_03_LK_DK");

                entity.Property(e => e.Luong03PsTk).HasColumnName("LUONG_03_PS_TK");

                entity.Property(e => e.LuongDv1Cl).HasColumnName("LUONG_DV1_CL");

                entity.Property(e => e.LuongDv1LkCk).HasColumnName("LUONG_DV1_LK_CK");

                entity.Property(e => e.LuongDv1LkDk).HasColumnName("LUONG_DV1_LK_DK");

                entity.Property(e => e.LuongDv1PsTk).HasColumnName("LUONG_DV1_PS_TK");

                entity.Property(e => e.LuongDv2Cl).HasColumnName("LUONG_DV2_CL");

                entity.Property(e => e.LuongDv2LkCk).HasColumnName("LUONG_DV2_LK_CK");

                entity.Property(e => e.LuongDv2LkDk).HasColumnName("LUONG_DV2_LK_DK");

                entity.Property(e => e.LuongDv2PsTk).HasColumnName("LUONG_DV2_PS_TK");

                entity.Property(e => e.Madonhang)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mahh)
                    .HasMaxLength(50)
                    .HasColumnName("MAHH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HD");

                entity.Property(e => e.Ngaydonhang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYDONHANG");

                entity.Property(e => e.Ngaygiaohang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYGIAOHANG");

                entity.Property(e => e.Ngayhethan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYHETHAN");

                entity.Property(e => e.NmhDiachi)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_DIACHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhEmail)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhFax)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_FAX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMa)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMst)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MST")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhNlhDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_NLH_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhNlhTen)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_NLH_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTen)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTknh)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_TKNH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PtChietkhau).HasColumnName("PT_CHIETKHAU");

                entity.Property(e => e.Quycach01)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH_01")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quycach02)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH_02")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quycach03)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH_03")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.SttDonhang).HasColumnName("STT_DONHANG");

                entity.Property(e => e.SttMh).HasColumnName("STT_MH");

                entity.Property(e => e.Tenhh)
                    .HasMaxLength(50)
                    .HasColumnName("TENHH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thueusd).HasColumnName("THUEUSD");

                entity.Property(e => e.Thuevnd).HasColumnName("THUEVND");

                entity.Property(e => e.TonCk).HasColumnName("TON_CK");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TsGtgt).HasColumnName("TS_GTGT");

                entity.Property(e => e.Ttusd).HasColumnName("TTUSD");

                entity.Property(e => e.TtusdTt).HasColumnName("TTUSD_TT");

                entity.Property(e => e.Ttvnd).HasColumnName("TTVND");

                entity.Property(e => e.TtvndSauCk).HasColumnName("TTVND_SAU_CK");

                entity.Property(e => e.TtvndTt).HasColumnName("TTVND_TT");

                entity.Property(e => e.Tygia).HasColumnName("TYGIA");
            });

            modelBuilder.Entity<Ktdhmua>(entity =>
            {
                entity.ToTable("KTDHMUA");

                entity.Property(e => e.Id)
                    .HasMaxLength(15)
                    .HasColumnName("ID");

                entity.Property(e => e.ChietkhauUsd).HasColumnName("CHIETKHAU_USD");

                entity.Property(e => e.ChietkhauVnd).HasColumnName("CHIETKHAU_VND");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgusd).HasColumnName("DGUSD");

                entity.Property(e => e.Dgvnd).HasColumnName("DGVND");

                entity.Property(e => e.Donggoi01)
                    .HasMaxLength(50)
                    .HasColumnName("DONGGOI_01")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donggoi02)
                    .HasMaxLength(50)
                    .HasColumnName("DONGGOI_02")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(50)
                    .HasColumnName("DVT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhichuDh)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU_DH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhichuMh)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU_MH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ldh)
                    .HasMaxLength(50)
                    .HasColumnName("LDH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnEmail)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnMaDt)
                    .HasMaxLength(50)
                    .HasColumnName("LHCN_MA_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhcnTenDt)
                    .HasMaxLength(250)
                    .HasColumnName("LHCN_TEN_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhmDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("LHM_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhmEmail)
                    .HasMaxLength(50)
                    .HasColumnName("LHM_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhmMaDt)
                    .HasMaxLength(50)
                    .HasColumnName("LHM_MA_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LhmTenDt)
                    .HasMaxLength(250)
                    .HasColumnName("LHM_TEN_DT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Luong01Cl).HasColumnName("LUONG_01_CL");

                entity.Property(e => e.Luong01LkCk).HasColumnName("LUONG_01_LK_CK");

                entity.Property(e => e.Luong01LkDk).HasColumnName("LUONG_01_LK_DK");

                entity.Property(e => e.Luong01PsTk).HasColumnName("LUONG_01_PS_TK");

                entity.Property(e => e.Luong02Cl).HasColumnName("LUONG_02_CL");

                entity.Property(e => e.Luong02LkCk).HasColumnName("LUONG_02_LK_CK");

                entity.Property(e => e.Luong02LkDk).HasColumnName("LUONG_02_LK_DK");

                entity.Property(e => e.Luong02PsTk).HasColumnName("LUONG_02_PS_TK");

                entity.Property(e => e.Luong03Cl).HasColumnName("LUONG_03_CL");

                entity.Property(e => e.Luong03LkCk).HasColumnName("LUONG_03_LK_CK");

                entity.Property(e => e.Luong03LkDk).HasColumnName("LUONG_03_LK_DK");

                entity.Property(e => e.Luong03PsTk).HasColumnName("LUONG_03_PS_TK");

                entity.Property(e => e.LuongDv1Cl).HasColumnName("LUONG_DV1_CL");

                entity.Property(e => e.LuongDv1LkCk).HasColumnName("LUONG_DV1_LK_CK");

                entity.Property(e => e.LuongDv1LkDk).HasColumnName("LUONG_DV1_LK_DK");

                entity.Property(e => e.LuongDv1PsTk).HasColumnName("LUONG_DV1_PS_TK");

                entity.Property(e => e.LuongDv2Cl).HasColumnName("LUONG_DV2_CL");

                entity.Property(e => e.LuongDv2LkCk).HasColumnName("LUONG_DV2_LK_CK");

                entity.Property(e => e.LuongDv2LkDk).HasColumnName("LUONG_DV2_LK_DK");

                entity.Property(e => e.LuongDv2PsTk).HasColumnName("LUONG_DV2_PS_TK");

                entity.Property(e => e.Madonhang)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mahh)
                    .HasMaxLength(50)
                    .HasColumnName("MAHH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccDiachi)
                    .HasMaxLength(250)
                    .HasColumnName("NCC_DIACHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccEmail)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccFax)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_FAX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccMa)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_MA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccMst)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_MST")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccNlhDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_NLH_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccNlhTen)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_NLH_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccTen)
                    .HasMaxLength(250)
                    .HasColumnName("NCC_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NccTknh)
                    .HasMaxLength(50)
                    .HasColumnName("NCC_TKNH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HD");

                entity.Property(e => e.Ngaydonhang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYDONHANG");

                entity.Property(e => e.Ngaygiaohang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYGIAOHANG");

                entity.Property(e => e.Ngayhethan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYHETHAN");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PtChietkhau).HasColumnName("PT_CHIETKHAU");

                entity.Property(e => e.Quycach01)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH_01")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quycach02)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH_02")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quycach03)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH_03")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.SttDonhang).HasColumnName("STT_DONHANG");

                entity.Property(e => e.SttMh).HasColumnName("STT_MH");

                entity.Property(e => e.Tenhh)
                    .HasMaxLength(250)
                    .HasColumnName("TENHH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thueusd).HasColumnName("THUEUSD");

                entity.Property(e => e.Thuevnd).HasColumnName("THUEVND");

                entity.Property(e => e.TonCk).HasColumnName("TON_CK");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TsGtgt).HasColumnName("TS_GTGT");

                entity.Property(e => e.Ttusd).HasColumnName("TTUSD");

                entity.Property(e => e.TtusdTt).HasColumnName("TTUSD_TT");

                entity.Property(e => e.Ttvnd).HasColumnName("TTVND");

                entity.Property(e => e.TtvndSauCk).HasColumnName("TTVND_SAU_CK");

                entity.Property(e => e.TtvndTt).HasColumnName("TTVND_TT");

                entity.Property(e => e.Tygia).HasColumnName("TYGIA");
            });

            modelBuilder.Entity<Ktdiengiai>(entity =>
            {
                entity.HasKey(e => e.Diengiai1)
                    .HasName("PK__KTDIENGIAI__7A3223E8");

                entity.ToTable("KTDIENGIAI");

                entity.Property(e => e.Diengiai1)
                    .HasMaxLength(250)
                    .HasColumnName("DIENGIAI1");

                entity.Property(e => e.Diengiai2)
                    .HasMaxLength(250)
                    .HasColumnName("DIENGIAI2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktdinhmuc>(entity =>
            {
                entity.HasKey(e => new { e.MaThanhpham, e.MaNvl, e.Thang })
                    .HasName("PK__KTDINHMUC__7108AC61");

                entity.ToTable("KTDINHMUC");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM");

                entity.Property(e => e.MaNvl)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NVL");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.CpNvl).HasColumnName("CP_NVL");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DgNvl).HasColumnName("DG_NVL");

                entity.Property(e => e.Dinhmuc).HasColumnName("DINHMUC");

                entity.Property(e => e.DvtNvl)
                    .HasMaxLength(20)
                    .HasColumnName("DVT_NVL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DvtTp)
                    .HasMaxLength(20)
                    .HasColumnName("DVT_TP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SlNvl).HasColumnName("SL_NVL");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.TenNvl)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_NVL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtdinhmucGd>(entity =>
            {
                entity.HasKey(e => new { e.Giaidoan, e.MaThanhpham, e.MaNvl, e.Thang })
                    .HasName("PK__KTDINHMUC_GD__308E3499");

                entity.ToTable("KTDINHMUC_GD");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM");

                entity.Property(e => e.MaNvl)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NVL");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.CpNvl).HasColumnName("CP_NVL");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DgNvl).HasColumnName("DG_NVL");

                entity.Property(e => e.Dinhmuc).HasColumnName("DINHMUC");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(50)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnco)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnno)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SlNvl).HasColumnName("SL_NVL");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.TenNvl)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_NVL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtdinhmucGdNgay>(entity =>
            {
                entity.HasKey(e => new { e.Giaidoan, e.Thang, e.Ngay, e.MaThanhpham, e.MaNvl })
                    .HasName("PK__KTDINHMUC_GD_NGA__4924D839");

                entity.ToTable("KTDINHMUC_GD_NGAY");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Ngay).HasColumnName("NGAY");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM");

                entity.Property(e => e.MaNvl)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NVL");

                entity.Property(e => e.CpNvl).HasColumnName("CP_NVL");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DgNvl).HasColumnName("DG_NVL");

                entity.Property(e => e.Dinhmuc).HasColumnName("DINHMUC");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(50)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnco)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnno)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SlNvl).HasColumnName("SL_NVL");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.TenNvl)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_NVL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtdinhmucGdNhom>(entity =>
            {
                entity.HasKey(e => new { e.Giaidoan, e.ManhomThanhpham, e.MaNvl, e.Thang })
                    .HasName("PK__KTDINHMUC_GD_NHO__1975C517");

                entity.ToTable("KTDINHMUC_GD_NHOM");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.ManhomThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM_THANHPHAM");

                entity.Property(e => e.MaNvl)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NVL");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.CpNvl).HasColumnName("CP_NVL");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DgNvl).HasColumnName("DG_NVL");

                entity.Property(e => e.Dinhmuc).HasColumnName("DINHMUC");

                entity.Property(e => e.Madtpnco)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnno)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SlNvl).HasColumnName("SL_NVL");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.TenNvl)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_NVL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TennhomThanhpham)
                    .HasMaxLength(255)
                    .HasColumnName("TENNHOM_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtdinhmucKhsx>(entity =>
            {
                entity.ToTable("KTDINHMUC_KHSX");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dinhmuc1sp).HasColumnName("DINHMUC1SP");

                entity.Property(e => e.DmdhMa)
                    .HasMaxLength(50)
                    .HasColumnName("DMDH_MA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DmdhNgay)
                    .HasColumnType("datetime")
                    .HasColumnName("DMDH_NGAY");

                entity.Property(e => e.DmdhStt).HasColumnName("DMDH_STT");

                entity.Property(e => e.Dmguid)
                    .HasMaxLength(50)
                    .HasColumnName("DMGUID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DvtNvl)
                    .HasMaxLength(20)
                    .HasColumnName("DVT_NVL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DvtTp)
                    .HasMaxLength(20)
                    .HasColumnName("DVT_TP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhichuChitiet)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU_CHITIET")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhichuTong)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU_TONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaNvl)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NVL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madonhang)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makhsx)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nam).HasColumnName("NAM");

                entity.Property(e => e.Ngaydonhang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYDONHANG");

                entity.Property(e => e.Ngaygiaohang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYGIAOHANG");

                entity.Property(e => e.Ngayhethan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYHETHAN");

                entity.Property(e => e.Ngaykhsx)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYKHSX");

                entity.Property(e => e.NmhMa)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTen)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SlNl).HasColumnName("SL_NL");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.SlTpNk).HasColumnName("SL_TP_NK");

                entity.Property(e => e.SttDonhang).HasColumnName("STT_DONHANG");

                entity.Property(e => e.SttKy).HasColumnName("STT_KY");

                entity.Property(e => e.SttNl).HasColumnName("STT_NL");

                entity.Property(e => e.SttSapxep).HasColumnName("STT_SAPXEP");

                entity.Property(e => e.SttTp).HasColumnName("STT_TP");

                entity.Property(e => e.TenNvl)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_NVL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.TkNl)
                    .HasMaxLength(50)
                    .HasColumnName("TK_NL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkTp)
                    .HasMaxLength(50)
                    .HasColumnName("TK_TP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonkhoNl).HasColumnName("TONKHO_NL");

                entity.Property(e => e.TonkhoTp).HasColumnName("TONKHO_TP");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktdm>(entity =>
            {
                entity.HasKey(e => new { e.Matk, e.Madm })
                    .HasName("PK__KTDM__15660868");

                entity.ToTable("KTDM");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DgChuyenkho).HasColumnName("DG_CHUYENKHO");

                entity.Property(e => e.DgCktm)
                    .HasMaxLength(500)
                    .HasColumnName("DG_CKTM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DgVc).HasColumnName("DG_VC");

                entity.Property(e => e.Dgban).HasColumnName("DGBAN");

                entity.Property(e => e.Dgban1).HasColumnName("DGBAN1");

                entity.Property(e => e.Dgban2).HasColumnName("DGBAN2");

                entity.Property(e => e.Dgban3).HasColumnName("DGBAN3");

                entity.Property(e => e.Dgban4).HasColumnName("DGBAN4");

                entity.Property(e => e.DgbanGanNhat).HasColumnName("DGBAN_GAN_NHAT");

                entity.Property(e => e.DgmuaGanNhat).HasColumnName("DGMUA_GAN_NHAT");

                entity.Property(e => e.Dgnhap).HasColumnName("DGNHAP");

                entity.Property(e => e.Dgnhap1).HasColumnName("DGNHAP1");

                entity.Property(e => e.Dgnhap2).HasColumnName("DGNHAP2");

                entity.Property(e => e.Dgnhap3).HasColumnName("DGNHAP3");

                entity.Property(e => e.Dgnhap4).HasColumnName("DGNHAP4");

                entity.Property(e => e.Dgnhap5).HasColumnName("DGNHAP5");

                entity.Property(e => e.Dgusd).HasColumnName("DGUSD");

                entity.Property(e => e.Dgxuat).HasColumnName("DGXUAT");

                entity.Property(e => e.DmCktm)
                    .HasMaxLength(500)
                    .HasColumnName("DM_CKTM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(250)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi1)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI_1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi2)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI_2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi3)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI_3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gioihanton).HasColumnName("GIOIHANTON");

                entity.Property(e => e.GioihantonMax).HasColumnName("GIOIHANTON_MAX");

                entity.Property(e => e.Hansudung)
                    .HasColumnType("datetime")
                    .HasColumnName("HANSUDUNG");

                entity.Property(e => e.Hsqd1).HasColumnName("HSQD_1");

                entity.Property(e => e.Hsqd2).HasColumnName("HSQD_2");

                entity.Property(e => e.Hsqd3).HasColumnName("HSQD_3");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kyhieu)
                    .HasMaxLength(250)
                    .HasColumnName("KYHIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lo)
                    .HasMaxLength(100)
                    .HasColumnName("LO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MadmMe)
                    .HasMaxLength(100)
                    .HasColumnName("MADM_ME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom1)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom2)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhomtp)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOMTP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mavach)
                    .HasMaxLength(50)
                    .HasColumnName("MAVACH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .HasColumnName("MODEL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgaybanGanNhat)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYBAN_GAN_NHAT");

                entity.Property(e => e.Ngaylo)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYLO");

                entity.Property(e => e.NgaymuaGanNhat)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYMUA_GAN_NHAT");

                entity.Property(e => e.Nhacungcap)
                    .HasMaxLength(250)
                    .HasColumnName("NHACUNGCAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NhapT).HasColumnName("NHAP_T");

                entity.Property(e => e.NhapTDv1).HasColumnName("NHAP_T_DV1");

                entity.Property(e => e.NhapTDv2).HasColumnName("NHAP_T_DV2");

                entity.Property(e => e.Nhasanxuat)
                    .HasMaxLength(250)
                    .HasColumnName("NHASANXUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhomck)
                    .HasMaxLength(50)
                    .HasColumnName("NHOMCK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ptchietkhau).HasColumnName("PTCHIETKHAU");

                entity.Property(e => e.Quycach)
                    .HasMaxLength(250)
                    .HasColumnName("QUYCACH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoDdh)
                    .HasMaxLength(50)
                    .HasColumnName("SO_DDH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Songaysudung).HasColumnName("SONGAYSUDUNG");

                entity.Property(e => e.TenDdh)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_DDH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm2)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TendmMe)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM_ME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhom)
                    .HasMaxLength(50)
                    .HasColumnName("TENNHOM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhom1)
                    .HasMaxLength(250)
                    .HasColumnName("TENNHOM1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhom2)
                    .HasMaxLength(250)
                    .HasColumnName("TENNHOM2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhomtp)
                    .HasMaxLength(250)
                    .HasColumnName("TENNHOMTP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TgCktm)
                    .HasMaxLength(2)
                    .HasColumnName("TG_CKTM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thuesuat).HasColumnName("THUESUAT");

                entity.Property(e => e.TkChietkhau)
                    .HasMaxLength(50)
                    .HasColumnName("TK_CHIETKHAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkDoanhthu)
                    .HasMaxLength(50)
                    .HasColumnName("TK_DOANHTHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkGiavon)
                    .HasMaxLength(50)
                    .HasColumnName("TK_GIAVON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkTralai)
                    .HasMaxLength(50)
                    .HasColumnName("TK_TRALAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonCk).HasColumnName("TON_CK");

                entity.Property(e => e.TonCkDv1).HasColumnName("TON_CK_DV1");

                entity.Property(e => e.TonCkDv2).HasColumnName("TON_CK_DV2");

                entity.Property(e => e.TonT).HasColumnName("TON_T");

                entity.Property(e => e.TonTDv1).HasColumnName("TON_T_DV1");

                entity.Property(e => e.TonTDv2).HasColumnName("TON_T_DV2");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TyleOfNhom).HasColumnName("TYLE_OF_NHOM");

                entity.Property(e => e.UsdnhapT).HasColumnName("USDNHAP_T");

                entity.Property(e => e.UsdtonCk).HasColumnName("USDTON_CK");

                entity.Property(e => e.UsdtonT).HasColumnName("USDTON_T");

                entity.Property(e => e.UsdxuatT).HasColumnName("USDXUAT_T");

                entity.Property(e => e.VndnhapT).HasColumnName("VNDNHAP_T");

                entity.Property(e => e.VndtonCk).HasColumnName("VNDTON_CK");

                entity.Property(e => e.VndtonT).HasColumnName("VNDTON_T");

                entity.Property(e => e.VndxuatT).HasColumnName("VNDXUAT_T");

                entity.Property(e => e.XuatT).HasColumnName("XUAT_T");

                entity.Property(e => e.XuatTDv1).HasColumnName("XUAT_T_DV1");

                entity.Property(e => e.XuatTDv2).HasColumnName("XUAT_T_DV2");
            });

            modelBuilder.Entity<Ktdmcum>(entity =>
            {
                entity.HasKey(e => new { e.MadmMe, e.MadmCon })
                    .HasName("PK__KTDMCUM__18227982");

                entity.ToTable("KTDMCUM");

                entity.Property(e => e.MadmMe)
                    .HasMaxLength(50)
                    .HasColumnName("MADM_ME");

                entity.Property(e => e.MadmCon)
                    .HasMaxLength(50)
                    .HasColumnName("MADM_CON");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(100)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DvtCon)
                    .HasMaxLength(50)
                    .HasColumnName("DVT_CON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DvtMe)
                    .HasMaxLength(50)
                    .HasColumnName("DVT_ME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(20)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Luong).HasColumnName("LUONG");

                entity.Property(e => e.MatkCon)
                    .HasMaxLength(50)
                    .HasColumnName("MATK_CON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MatkMe)
                    .HasMaxLength(50)
                    .HasColumnName("MATK_ME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TendmCon)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM_CON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TendmMe)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM_ME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkDu)
                    .HasMaxLength(50)
                    .HasColumnName("TK_DU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktdmh>(entity =>
            {
                entity.HasKey(e => e.SttDmh)
                    .HasName("PK__KTDMH__3AA27A0F");

                entity.ToTable("KTDMH");

                entity.Property(e => e.SttDmh).HasColumnName("STT_DMH");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgton).HasColumnName("DGTON");

                entity.Property(e => e.Dgvnd).HasColumnName("DGVND");

                entity.Property(e => e.DiachiKh)
                    .HasMaxLength(250)
                    .HasColumnName("DIACHI_KH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DtLhBan)
                    .HasMaxLength(50)
                    .HasColumnName("DT_LH_BAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DtLhMua)
                    .HasMaxLength(50)
                    .HasColumnName("DT_LH_MUA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ldh)
                    .HasMaxLength(50)
                    .HasColumnName("LDH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Luong).HasColumnName("LUONG");

                entity.Property(e => e.MaLhBan)
                    .HasMaxLength(50)
                    .HasColumnName("MA_LH_BAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaLhMua)
                    .HasMaxLength(50)
                    .HasColumnName("MA_LH_MUA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makh)
                    .HasMaxLength(50)
                    .HasColumnName("MAKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MsDn)
                    .HasMaxLength(50)
                    .HasColumnName("MS_DN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngaydh)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYDH");

                entity.Property(e => e.Ngaygh)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYGH");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sodh).HasColumnName("SODH");

                entity.Property(e => e.SttBt).HasColumnName("STT_BT");

                entity.Property(e => e.TenLhBan)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_LH_BAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenLhMua)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_LH_MUA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(250)
                    .HasColumnName("TENKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thuevnd).HasColumnName("THUEVND");

                entity.Property(e => e.TonCk).HasColumnName("TON_CK");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TsGtgt).HasColumnName("TS_GTGT");

                entity.Property(e => e.Ttvnd).HasColumnName("TTVND");

                entity.Property(e => e.TtvndTt).HasColumnName("TTVND_TT");

                entity.Property(e => e.VndtonCk).HasColumnName("VNDTON_CK");
            });

            modelBuilder.Entity<Ktdmkho>(entity =>
            {
                entity.HasKey(e => new { e.Matk, e.Madm, e.Madtpn })
                    .HasName("PK__KTDMKHO__676A338E");

                entity.ToTable("KTDMKHO");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgnhap).HasColumnName("DGNHAP");

                entity.Property(e => e.Dgusd).HasColumnName("DGUSD");

                entity.Property(e => e.Dgxuat).HasColumnName("DGXUAT");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(255)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi1)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI_1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi2)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI_2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kyhieu)
                    .HasMaxLength(255)
                    .HasColumnName("KYHIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MsDg)
                    .HasMaxLength(255)
                    .HasColumnName("MS_DG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NhapT).HasColumnName("NHAP_T");

                entity.Property(e => e.NhapTDv1).HasColumnName("NHAP_T_DV1");

                entity.Property(e => e.NhapTDv2).HasColumnName("NHAP_T_DV2");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(255)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(255)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonCk).HasColumnName("TON_CK");

                entity.Property(e => e.TonCkDv1).HasColumnName("TON_CK_DV1");

                entity.Property(e => e.TonCkDv2).HasColumnName("TON_CK_DV2");

                entity.Property(e => e.TonT).HasColumnName("TON_T");

                entity.Property(e => e.TonTDv1).HasColumnName("TON_T_DV1");

                entity.Property(e => e.TonTDv2).HasColumnName("TON_T_DV2");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsdnhapT).HasColumnName("USDNHAP_T");

                entity.Property(e => e.UsdtonCk).HasColumnName("USDTON_CK");

                entity.Property(e => e.UsdtonT).HasColumnName("USDTON_T");

                entity.Property(e => e.UsdxuatT).HasColumnName("USDXUAT_T");

                entity.Property(e => e.VndnhapT).HasColumnName("VNDNHAP_T");

                entity.Property(e => e.VndtonCk).HasColumnName("VNDTON_CK");

                entity.Property(e => e.VndtonT).HasColumnName("VNDTON_T");

                entity.Property(e => e.VndxuatT).HasColumnName("VNDXUAT_T");

                entity.Property(e => e.XuatT).HasColumnName("XUAT_T");

                entity.Property(e => e.XuatTDv1).HasColumnName("XUAT_T_DV1");

                entity.Property(e => e.XuatTDv2).HasColumnName("XUAT_T_DV2");
            });

            modelBuilder.Entity<Ktdmlo>(entity =>
            {
                entity.HasKey(e => new { e.Matk, e.Madm, e.Madtpn, e.Lo })
                    .HasName("PK__KTDMLO__08CB2759");

                entity.ToTable("KTDMLO");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN");

                entity.Property(e => e.Lo)
                    .HasMaxLength(50)
                    .HasColumnName("LO");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgban).HasColumnName("DGBAN");

                entity.Property(e => e.Dgnhap).HasColumnName("DGNHAP");

                entity.Property(e => e.Dgusd).HasColumnName("DGUSD");

                entity.Property(e => e.Dgxuat).HasColumnName("DGXUAT");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(255)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi1)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI_1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi2)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI_2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi3)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI_3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hansudung)
                    .HasColumnType("datetime")
                    .HasColumnName("HANSUDUNG");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kyhieu)
                    .HasMaxLength(255)
                    .HasColumnName("KYHIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Luongxuat).HasColumnName("LUONGXUAT");

                entity.Property(e => e.MsDg)
                    .HasMaxLength(255)
                    .HasColumnName("MS_DG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngaylo)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYLO");

                entity.Property(e => e.Nhacungcap)
                    .HasMaxLength(500)
                    .HasColumnName("NHACUNGCAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NhapT).HasColumnName("NHAP_T");

                entity.Property(e => e.NhapTDv1).HasColumnName("NHAP_T_DV1");

                entity.Property(e => e.NhapTDv2).HasColumnName("NHAP_T_DV2");

                entity.Property(e => e.NhapTDv3).HasColumnName("NHAP_T_DV3");

                entity.Property(e => e.Nhasanxuat)
                    .HasMaxLength(200)
                    .HasColumnName("NHASANXUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Qc1)
                    .HasMaxLength(50)
                    .HasColumnName("QC1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Qc2)
                    .HasMaxLength(50)
                    .HasColumnName("QC2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Qc3)
                    .HasMaxLength(50)
                    .HasColumnName("QC3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Qc4)
                    .HasMaxLength(50)
                    .HasColumnName("QC4")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Qc5)
                    .HasMaxLength(50)
                    .HasColumnName("QC5")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sotam).HasColumnName("SOTAM");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(255)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(255)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonCk).HasColumnName("TON_CK");

                entity.Property(e => e.TonCkDv1).HasColumnName("TON_CK_DV1");

                entity.Property(e => e.TonCkDv2).HasColumnName("TON_CK_DV2");

                entity.Property(e => e.TonCkDv3).HasColumnName("TON_CK_DV3");

                entity.Property(e => e.TonT).HasColumnName("TON_T");

                entity.Property(e => e.TonTDv1).HasColumnName("TON_T_DV1");

                entity.Property(e => e.TonTDv2).HasColumnName("TON_T_DV2");

                entity.Property(e => e.TonTDv3).HasColumnName("TON_T_DV3");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ttban).HasColumnName("TTBAN");

                entity.Property(e => e.UsdnhapT).HasColumnName("USDNHAP_T");

                entity.Property(e => e.UsdtonCk).HasColumnName("USDTON_CK");

                entity.Property(e => e.UsdtonT).HasColumnName("USDTON_T");

                entity.Property(e => e.UsdxuatT).HasColumnName("USDXUAT_T");

                entity.Property(e => e.VndnhapT).HasColumnName("VNDNHAP_T");

                entity.Property(e => e.VndtonCk).HasColumnName("VNDTON_CK");

                entity.Property(e => e.VndtonT).HasColumnName("VNDTON_T");

                entity.Property(e => e.VndxuatT).HasColumnName("VNDXUAT_T");

                entity.Property(e => e.XuatT).HasColumnName("XUAT_T");

                entity.Property(e => e.XuatTDv1).HasColumnName("XUAT_T_DV1");

                entity.Property(e => e.XuatTDv2).HasColumnName("XUAT_T_DV2");

                entity.Property(e => e.XuatTDv3).HasColumnName("XUAT_T_DV3");
            });

            modelBuilder.Entity<Ktdmnc>(entity =>
            {
                entity.HasKey(e => e.MaThanhpham)
                    .HasName("PK__KTDMNC__60D24498");

                entity.ToTable("KTDMNC");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM");

                entity.Property(e => e.CpNc).HasColumnName("CP_NC");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dinhmuc).HasColumnName("DINHMUC");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtdmncGd>(entity =>
            {
                entity.HasKey(e => new { e.Giaidoan, e.MaThanhpham })
                    .HasName("PK__KTDMNC_GD__28ED12D1");

                entity.ToTable("KTDMNC_GD");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM");

                entity.Property(e => e.CpNc).HasColumnName("CP_NC");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dinhmuc).HasColumnName("DINHMUC");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktdtgt>(entity =>
            {
                entity.HasKey(e => new { e.Tkdd, e.Madtgt })
                    .HasName("PK__KTDTGT__01A9F3D5");

                entity.ToTable("KTDTGT");

                entity.Property(e => e.Tkdd)
                    .HasMaxLength(50)
                    .HasColumnName("TKDD");

                entity.Property(e => e.Madtgt)
                    .HasMaxLength(50)
                    .HasColumnName("MADTGT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngayps)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYPS");

                entity.Property(e => e.Tendtgt)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktdtpn>(entity =>
            {
                entity.HasKey(e => e.Madtpn)
                    .HasName("PK__KTDTPN__37661AB1");

                entity.ToTable("KTDTPN");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(255)
                    .HasColumnName("DIACHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DiachiGh)
                    .HasMaxLength(100)
                    .HasColumnName("DIACHI_GH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dienthoai)
                    .HasMaxLength(255)
                    .HasColumnName("DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Emailcc)
                    .HasMaxLength(150)
                    .HasColumnName("EMAILCC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .HasColumnName("FAX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kieudoituong)
                    .HasMaxLength(20)
                    .HasColumnName("KIEUDOITUONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LienHe)
                    .HasMaxLength(1020)
                    .HasColumnName("LIEN_HE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaVung)
                    .HasMaxLength(50)
                    .HasColumnName("MA_VUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MacosoDqg)
                    .HasMaxLength(50)
                    .HasColumnName("MACOSO_DQG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mactyme)
                    .HasMaxLength(50)
                    .HasColumnName("MACTYME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom)
                    .HasMaxLength(100)
                    .HasColumnName("MANHOM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom1)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhomdt1)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOMDT1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matt)
                    .HasMaxLength(50)
                    .HasColumnName("MATT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MsDn)
                    .HasMaxLength(255)
                    .HasColumnName("MS_DN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mucgia).HasColumnName("MUCGIA");

                entity.Property(e => e.Nguoidaidien)
                    .HasMaxLength(250)
                    .HasColumnName("NGUOIDAIDIEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhomck)
                    .HasMaxLength(50)
                    .HasColumnName("NHOMCK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NoMax).HasColumnName("NO_MAX");

                entity.Property(e => e.PtCk).HasColumnName("PT_CK");

                entity.Property(e => e.Songaythanhtoan).HasColumnName("SONGAYTHANHTOAN");

                entity.Property(e => e.Tenctyme)
                    .HasMaxLength(250)
                    .HasColumnName("TENCTYME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(255)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhom)
                    .HasMaxLength(100)
                    .HasColumnName("TENNHOM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhom1)
                    .HasMaxLength(150)
                    .HasColumnName("TENNHOM1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhomdt1)
                    .HasMaxLength(150)
                    .HasColumnName("TENNHOMDT1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tentknh)
                    .HasMaxLength(255)
                    .HasColumnName("TENTKNH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tentt)
                    .HasMaxLength(200)
                    .HasColumnName("TENTT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenvung)
                    .HasMaxLength(250)
                    .HasColumnName("TENVUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkco)
                    .HasMaxLength(50)
                    .HasColumnName("TKCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tknh)
                    .HasMaxLength(255)
                    .HasColumnName("TKNH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkno)
                    .HasMaxLength(50)
                    .HasColumnName("TKNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktgt>(entity =>
            {
                entity.HasKey(e => new { e.Madtgt, e.Thang })
                    .HasName("PK__KTGT__18E19391");

                entity.ToTable("KTGT");

                entity.Property(e => e.Madtgt)
                    .HasMaxLength(50)
                    .HasColumnName("MADTGT");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgban).HasColumnName("DGBAN");

                entity.Property(e => e.Doanhthu).HasColumnName("DOANHTHU");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(255)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gt1sp).HasColumnName("GT_1SP");

                entity.Property(e => e.Gt621).HasColumnName("GT_621");

                entity.Property(e => e.Gt622).HasColumnName("GT_622");

                entity.Property(e => e.Gt627).HasColumnName("GT_627");

                entity.Property(e => e.Gtsp).HasColumnName("GTSP");

                entity.Property(e => e.Pstk621).HasColumnName("PSTK_621");

                entity.Property(e => e.Pstk622).HasColumnName("PSTK_622");

                entity.Property(e => e.Pstk627).HasColumnName("PSTK_627");

                entity.Property(e => e.Ptht).HasColumnName("PTHT");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.Slddck).HasColumnName("SLDDCK");

                entity.Property(e => e.SoDdh)
                    .HasMaxLength(50)
                    .HasColumnName("SO_DDH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenDdh)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_DDH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtgt)
                    .HasMaxLength(255)
                    .HasColumnName("TENDTGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenky)
                    .HasMaxLength(5)
                    .HasColumnName("TENKY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonckGt).HasColumnName("TONCK_GT");

                entity.Property(e => e.TonckGt621).HasColumnName("TONCK_GT_621");

                entity.Property(e => e.TonckGt622).HasColumnName("TONCK_GT_622");

                entity.Property(e => e.TonckGt627).HasColumnName("TONCK_GT_627");

                entity.Property(e => e.TonckSl).HasColumnName("TONCK_SL");

                entity.Property(e => e.TondkGt).HasColumnName("TONDK_GT");

                entity.Property(e => e.TondkGt621).HasColumnName("TONDK_GT_621");

                entity.Property(e => e.TondkGt622).HasColumnName("TONDK_GT_622");

                entity.Property(e => e.TondkGt627).HasColumnName("TONDK_GT_627");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtgtGd>(entity =>
            {
                entity.HasKey(e => new { e.Giaidoan, e.Madtgt, e.Thang })
                    .HasName("PK__KTGT_GD__68D28DBC");

                entity.ToTable("KTGT_GD");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.Madtgt)
                    .HasMaxLength(50)
                    .HasColumnName("MADTGT");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgban).HasColumnName("DGBAN");

                entity.Property(e => e.Doanhthu).HasColumnName("DOANHTHU");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gt1sp).HasColumnName("GT_1SP");

                entity.Property(e => e.Gt621).HasColumnName("GT_621");

                entity.Property(e => e.Gt622).HasColumnName("GT_622");

                entity.Property(e => e.Gt627).HasColumnName("GT_627");

                entity.Property(e => e.Gtsp).HasColumnName("GTSP");

                entity.Property(e => e.MaTpGoc)
                    .HasMaxLength(50)
                    .HasColumnName("MA_TP_GOC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pstk621).HasColumnName("PSTK_621");

                entity.Property(e => e.Pstk622).HasColumnName("PSTK_622");

                entity.Property(e => e.Pstk627).HasColumnName("PSTK_627");

                entity.Property(e => e.Ptht).HasColumnName("PTHT");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.Slddck).HasColumnName("SLDDCK");

                entity.Property(e => e.SoDdh)
                    .HasMaxLength(50)
                    .HasColumnName("SO_DDH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenDdh)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_DDH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenTpGoc)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_TP_GOC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtgt)
                    .HasMaxLength(255)
                    .HasColumnName("TENDTGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonckGt).HasColumnName("TONCK_GT");

                entity.Property(e => e.TonckGt621).HasColumnName("TONCK_GT_621");

                entity.Property(e => e.TonckGt622).HasColumnName("TONCK_GT_622");

                entity.Property(e => e.TonckGt627).HasColumnName("TONCK_GT_627");

                entity.Property(e => e.TonckSl).HasColumnName("TONCK_SL");

                entity.Property(e => e.TondkGt).HasColumnName("TONDK_GT");

                entity.Property(e => e.TondkGt621).HasColumnName("TONDK_GT_621");

                entity.Property(e => e.TondkGt622).HasColumnName("TONDK_GT_622");

                entity.Property(e => e.TondkGt627).HasColumnName("TONDK_GT_627");

                entity.Property(e => e.TongPstk).HasColumnName("TONG_PSTK");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktgtct>(entity =>
            {
                entity.HasKey(e => e.MaCt)
                    .HasName("PK__KTGTCT__47477CBF");

                entity.ToTable("KTGTCT");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ddck621).HasColumnName("DDCK_621");

                entity.Property(e => e.Ddck622).HasColumnName("DDCK_622");

                entity.Property(e => e.Ddck623).HasColumnName("DDCK_623");

                entity.Property(e => e.Ddck627).HasColumnName("DDCK_627");

                entity.Property(e => e.Dddk621).HasColumnName("DDDK_621");

                entity.Property(e => e.Dddk622).HasColumnName("DDDK_622");

                entity.Property(e => e.Dddk623).HasColumnName("DDDK_623");

                entity.Property(e => e.Dddk627).HasColumnName("DDDK_627");

                entity.Property(e => e.DoanhthuCk).HasColumnName("DOANHTHU_CK");

                entity.Property(e => e.DoanhthuDk).HasColumnName("DOANHTHU_DK");

                entity.Property(e => e.DoanhthuLk).HasColumnName("DOANHTHU_LK");

                entity.Property(e => e.DoanhthuTk).HasColumnName("DOANHTHU_TK");

                entity.Property(e => e.DshoadonDk)
                    .HasMaxLength(250)
                    .HasColumnName("DSHOADON_DK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DshoadonTk)
                    .HasMaxLength(250)
                    .HasColumnName("DSHOADON_TK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GiavonCk).HasColumnName("GIAVON_CK");

                entity.Property(e => e.GiavonDk).HasColumnName("GIAVON_DK");

                entity.Property(e => e.GiavonLk).HasColumnName("GIAVON_LK");

                entity.Property(e => e.GiavonTk).HasColumnName("GIAVON_TK");

                entity.Property(e => e.GtUsdNt).HasColumnName("GT_USD_NT");

                entity.Property(e => e.GtUsdTt).HasColumnName("GT_USD_TT");

                entity.Property(e => e.GtVndNt).HasColumnName("GT_VND_NT");

                entity.Property(e => e.GtVndTt).HasColumnName("GT_VND_TT");

                entity.Property(e => e.HoanThanh).HasColumnName("HOAN_THANH");

                entity.Property(e => e.LaiGop).HasColumnName("LAI_GOP");

                entity.Property(e => e.LkcpDk621).HasColumnName("LKCP_DK_621");

                entity.Property(e => e.LkcpDk622).HasColumnName("LKCP_DK_622");

                entity.Property(e => e.LkcpDk623).HasColumnName("LKCP_DK_623");

                entity.Property(e => e.LkcpDk627).HasColumnName("LKCP_DK_627");

                entity.Property(e => e.Maduan)
                    .HasMaxLength(50)
                    .HasColumnName("MADUAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhomct)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOMCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayDaoHan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_DAO_HAN");

                entity.Property(e => e.NgayHopdong)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HOPDONG");

                entity.Property(e => e.Ngaygiaohang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYGIAOHANG");

                entity.Property(e => e.Ngaykc)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYKC");

                entity.Property(e => e.Ngaynt)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYNT");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(255)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ps621Lk).HasColumnName("PS_621_LK");

                entity.Property(e => e.Ps622Lk).HasColumnName("PS_622_LK");

                entity.Property(e => e.Ps623Lk).HasColumnName("PS_623_LK");

                entity.Property(e => e.Ps627Lk).HasColumnName("PS_627_LK");

                entity.Property(e => e.Psco154).HasColumnName("PSCO_154");

                entity.Property(e => e.Psco154Mtc).HasColumnName("PSCO_154_MTC");

                entity.Property(e => e.Psco154Nc).HasColumnName("PSCO_154_NC");

                entity.Property(e => e.Psco154Nvl).HasColumnName("PSCO_154_NVL");

                entity.Property(e => e.Psco154Sxc).HasColumnName("PSCO_154_SXC");

                entity.Property(e => e.Psno154).HasColumnName("PSNO_154");

                entity.Property(e => e.Pstk621).HasColumnName("PSTK_621");

                entity.Property(e => e.Pstk622).HasColumnName("PSTK_622");

                entity.Property(e => e.Pstk623).HasColumnName("PSTK_623");

                entity.Property(e => e.Pstk627).HasColumnName("PSTK_627");

                entity.Property(e => e.SoHopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HOPDONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Songaytc).HasColumnName("SONGAYTC");

                entity.Property(e => e.TamungCk).HasColumnName("TAMUNG_CK");

                entity.Property(e => e.TamungDk).HasColumnName("TAMUNG_DK");

                entity.Property(e => e.TamungLk).HasColumnName("TAMUNG_LK");

                entity.Property(e => e.TamungTk).HasColumnName("TAMUNG_TK");

                entity.Property(e => e.Tenct)
                    .HasMaxLength(200)
                    .HasColumnName("TENCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenduan)
                    .HasMaxLength(250)
                    .HasColumnName("TENDUAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhomct)
                    .HasMaxLength(250)
                    .HasColumnName("TENNHOMCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ThuegtgtCk).HasColumnName("THUEGTGT_CK");

                entity.Property(e => e.ThuegtgtDk).HasColumnName("THUEGTGT_DK");

                entity.Property(e => e.ThuegtgtLk).HasColumnName("THUEGTGT_LK");

                entity.Property(e => e.ThuegtgtTk).HasColumnName("THUEGTGT_TK");

                entity.Property(e => e.TkDd)
                    .HasMaxLength(100)
                    .HasColumnName("TK_DD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkGv)
                    .HasMaxLength(50)
                    .HasColumnName("TK_GV")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TongCp).HasColumnName("TONG_CP");

                entity.Property(e => e.TongDdck).HasColumnName("TONG_DDCK");

                entity.Property(e => e.TongDddk).HasColumnName("TONG_DDDK");

                entity.Property(e => e.TongLkcpDk).HasColumnName("TONG_LKCP_DK");

                entity.Property(e => e.TongPstk).HasColumnName("TONG_PSTK");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TyleLai).HasColumnName("TYLE_LAI");

                entity.Property(e => e.TylePhanbo).HasColumnName("TYLE_PHANBO");
            });

            modelBuilder.Entity<KtgtctThang>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.MaCt })
                    .HasName("PK__KTGTCT_THANG__24D33481");

                entity.ToTable("KTGTCT_THANG");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ddck621).HasColumnName("DDCK_621");

                entity.Property(e => e.Ddck622).HasColumnName("DDCK_622");

                entity.Property(e => e.Ddck623).HasColumnName("DDCK_623");

                entity.Property(e => e.Ddck627).HasColumnName("DDCK_627");

                entity.Property(e => e.Dddk621).HasColumnName("DDDK_621");

                entity.Property(e => e.Dddk622).HasColumnName("DDDK_622");

                entity.Property(e => e.Dddk623).HasColumnName("DDDK_623");

                entity.Property(e => e.Dddk627).HasColumnName("DDDK_627");

                entity.Property(e => e.DoanhthuCk).HasColumnName("DOANHTHU_CK");

                entity.Property(e => e.DoanhthuDk).HasColumnName("DOANHTHU_DK");

                entity.Property(e => e.DoanhthuLk).HasColumnName("DOANHTHU_LK");

                entity.Property(e => e.DoanhthuTk).HasColumnName("DOANHTHU_TK");

                entity.Property(e => e.DshoadonDk)
                    .HasMaxLength(250)
                    .HasColumnName("DSHOADON_DK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DshoadonTk)
                    .HasMaxLength(250)
                    .HasColumnName("DSHOADON_TK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GiavonCk).HasColumnName("GIAVON_CK");

                entity.Property(e => e.GiavonDk).HasColumnName("GIAVON_DK");

                entity.Property(e => e.GiavonLk).HasColumnName("GIAVON_LK");

                entity.Property(e => e.GiavonTk).HasColumnName("GIAVON_TK");

                entity.Property(e => e.GtUsdNt).HasColumnName("GT_USD_NT");

                entity.Property(e => e.GtUsdTt).HasColumnName("GT_USD_TT");

                entity.Property(e => e.GtVndNt).HasColumnName("GT_VND_NT");

                entity.Property(e => e.GtVndTt).HasColumnName("GT_VND_TT");

                entity.Property(e => e.HoanThanh).HasColumnName("HOAN_THANH");

                entity.Property(e => e.LaiGop).HasColumnName("LAI_GOP");

                entity.Property(e => e.LkcpCk621).HasColumnName("LKCP_CK_621");

                entity.Property(e => e.LkcpCk622).HasColumnName("LKCP_CK_622");

                entity.Property(e => e.LkcpCk623).HasColumnName("LKCP_CK_623");

                entity.Property(e => e.LkcpCk627).HasColumnName("LKCP_CK_627");

                entity.Property(e => e.LkcpDk621).HasColumnName("LKCP_DK_621");

                entity.Property(e => e.LkcpDk622).HasColumnName("LKCP_DK_622");

                entity.Property(e => e.LkcpDk623).HasColumnName("LKCP_DK_623");

                entity.Property(e => e.LkcpDk627).HasColumnName("LKCP_DK_627");

                entity.Property(e => e.Manhomct)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOMCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayHopdong)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HOPDONG");

                entity.Property(e => e.Ngaykc)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYKC");

                entity.Property(e => e.Ngaynt)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYNT");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(255)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ps621Lk).HasColumnName("PS_621_LK");

                entity.Property(e => e.Ps622Lk).HasColumnName("PS_622_LK");

                entity.Property(e => e.Ps623Lk).HasColumnName("PS_623_LK");

                entity.Property(e => e.Ps627Lk).HasColumnName("PS_627_LK");

                entity.Property(e => e.Psco154).HasColumnName("PSCO_154");

                entity.Property(e => e.Psco154Mtc).HasColumnName("PSCO_154_MTC");

                entity.Property(e => e.Psco154Nc).HasColumnName("PSCO_154_NC");

                entity.Property(e => e.Psco154Nvl).HasColumnName("PSCO_154_NVL");

                entity.Property(e => e.Psco154Sxc).HasColumnName("PSCO_154_SXC");

                entity.Property(e => e.Psno154).HasColumnName("PSNO_154");

                entity.Property(e => e.Pstk621).HasColumnName("PSTK_621");

                entity.Property(e => e.Pstk622).HasColumnName("PSTK_622");

                entity.Property(e => e.Pstk623).HasColumnName("PSTK_623");

                entity.Property(e => e.Pstk627).HasColumnName("PSTK_627");

                entity.Property(e => e.SoHopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HOPDONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Songaytc).HasColumnName("SONGAYTC");

                entity.Property(e => e.TamungCk).HasColumnName("TAMUNG_CK");

                entity.Property(e => e.TamungDk).HasColumnName("TAMUNG_DK");

                entity.Property(e => e.TamungLk).HasColumnName("TAMUNG_LK");

                entity.Property(e => e.TamungTk).HasColumnName("TAMUNG_TK");

                entity.Property(e => e.Tenct)
                    .HasMaxLength(250)
                    .HasColumnName("TENCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhomct)
                    .HasMaxLength(250)
                    .HasColumnName("TENNHOMCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ThuegtgtCk).HasColumnName("THUEGTGT_CK");

                entity.Property(e => e.ThuegtgtDk).HasColumnName("THUEGTGT_DK");

                entity.Property(e => e.ThuegtgtLk).HasColumnName("THUEGTGT_LK");

                entity.Property(e => e.ThuegtgtTk).HasColumnName("THUEGTGT_TK");

                entity.Property(e => e.TkDd)
                    .HasMaxLength(50)
                    .HasColumnName("TK_DD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkGv)
                    .HasMaxLength(50)
                    .HasColumnName("TK_GV")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TongCp).HasColumnName("TONG_CP");

                entity.Property(e => e.TongDdck).HasColumnName("TONG_DDCK");

                entity.Property(e => e.TongDddk).HasColumnName("TONG_DDDK");

                entity.Property(e => e.TongLkcpCk).HasColumnName("TONG_LKCP_CK");

                entity.Property(e => e.TongLkcpDk).HasColumnName("TONG_LKCP_DK");

                entity.Property(e => e.TongPstk).HasColumnName("TONG_PSTK");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TyleLai).HasColumnName("TYLE_LAI");

                entity.Property(e => e.TylePhanbo).HasColumnName("TYLE_PHANBO");
            });

            modelBuilder.Entity<Ktgtcttp>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.MaCt, e.Matp })
                    .HasName("PK__KTGTCTTP__7306CEC3");

                entity.ToTable("KTGTCTTP");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT");

                entity.Property(e => e.Matp)
                    .HasMaxLength(50)
                    .HasColumnName("MATP");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgban).HasColumnName("DGBAN");

                entity.Property(e => e.Doanhthu).HasColumnName("DOANHTHU");

                entity.Property(e => e.GtVndNt).HasColumnName("GT_VND_NT");

                entity.Property(e => e.GtVndTt).HasColumnName("GT_VND_TT");

                entity.Property(e => e.NgayHopdong)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HOPDONG");

                entity.Property(e => e.Ngaykc)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYKC");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(255)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Psco154).HasColumnName("PSCO_154");

                entity.Property(e => e.Psno154).HasColumnName("PSNO_154");

                entity.Property(e => e.Pstk621).HasColumnName("PSTK_621");

                entity.Property(e => e.Pstk622).HasColumnName("PSTK_622");

                entity.Property(e => e.Pstk623).HasColumnName("PSTK_623");

                entity.Property(e => e.Pstk627).HasColumnName("PSTK_627");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.SoHopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HOPDONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct)
                    .HasMaxLength(250)
                    .HasColumnName("TENCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tentp)
                    .HasMaxLength(250)
                    .HasColumnName("TENTP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TongPstk).HasColumnName("TONG_PSTK");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TylePhanbo).HasColumnName("TYLE_PHANBO");

                entity.Property(e => e.Z1tp).HasColumnName("Z1TP");

                entity.Property(e => e.Ztp).HasColumnName("ZTP");
            });

            modelBuilder.Entity<Ktgtgdct>(entity =>
            {
                entity.HasKey(e => new { e.Giaidoan, e.Madtgt, e.Thang, e.Mathanhpham })
                    .HasName("PK__KTGTGDCT__093F5D4E");

                entity.ToTable("KTGTGDCT");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.Madtgt)
                    .HasMaxLength(50)
                    .HasColumnName("MADTGT");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Mathanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MATHANHPHAM");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgban).HasColumnName("DGBAN");

                entity.Property(e => e.Doanhthu).HasColumnName("DOANHTHU");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gt1sp).HasColumnName("GT_1SP");

                entity.Property(e => e.Gt621).HasColumnName("GT_621");

                entity.Property(e => e.Gt622).HasColumnName("GT_622");

                entity.Property(e => e.Gt627).HasColumnName("GT_627");

                entity.Property(e => e.Gtsp).HasColumnName("GTSP");

                entity.Property(e => e.GtspMe).HasColumnName("GTSP_ME");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.Tendtgt)
                    .HasMaxLength(255)
                    .HasColumnName("TENDTGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenthanhpham)
                    .HasMaxLength(250)
                    .HasColumnName("TENTHANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Kthoadon>(entity =>
            {
                entity.HasKey(e => new { e.Matk, e.Madtpn, e.SrHd, e.SoHd })
                    .HasName("PK__KTHOADON__428DB49A");

                entity.ToTable("KTHOADON");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN");

                entity.Property(e => e.SrHd)
                    .HasMaxLength(50)
                    .HasColumnName("SR_HD");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dsphieuthu)
                    .HasMaxLength(250)
                    .HasColumnName("DSPHIEUTHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GiatriUsd).HasColumnName("GIATRI_USD");

                entity.Property(e => e.GiatriVnd).HasColumnName("GIATRI_VND");

                entity.Property(e => e.Hanmuc).HasColumnName("HANMUC");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LaiSuat)
                    .HasMaxLength(100)
                    .HasColumnName("LAI_SUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayDaoHan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_DAO_HAN");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HD");

                entity.Property(e => e.Ngayct)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYCT");

                entity.Property(e => e.SoHopdong)
                    .HasMaxLength(100)
                    .HasColumnName("SO_HOPDONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soct)
                    .HasMaxLength(50)
                    .HasColumnName("SOCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Songayquahan).HasColumnName("SONGAYQUAHAN");

                entity.Property(e => e.Tendb)
                    .HasMaxLength(50)
                    .HasColumnName("TENDB")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(255)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TuoiNo).HasColumnName("TUOI_NO");

                entity.Property(e => e.Tygia).HasColumnName("TYGIA");

                entity.Property(e => e.TygiaCo).HasColumnName("TYGIA_CO");

                entity.Property(e => e.TygiaNo).HasColumnName("TYGIA_NO");

                entity.Property(e => e.UsdNo30).HasColumnName("USD_NO_30");

                entity.Property(e => e.UsdNo3060).HasColumnName("USD_NO_30_60");

                entity.Property(e => e.UsdNo6090).HasColumnName("USD_NO_60_90");

                entity.Property(e => e.UsdNo90).HasColumnName("USD_NO_90");

                entity.Property(e => e.Usdckco).HasColumnName("USDCKCO");

                entity.Property(e => e.Usdckno).HasColumnName("USDCKNO");

                entity.Property(e => e.Usdduco).HasColumnName("USDDUCO");

                entity.Property(e => e.Usdduno).HasColumnName("USDDUNO");

                entity.Property(e => e.Usdpsco).HasColumnName("USDPSCO");

                entity.Property(e => e.Usdpsno).HasColumnName("USDPSNO");

                entity.Property(e => e.VndMuahomnay).HasColumnName("VND_MUAHOMNAY");

                entity.Property(e => e.VndMuatrongky).HasColumnName("VND_MUATRONGKY");

                entity.Property(e => e.VndNo30).HasColumnName("VND_NO_30");

                entity.Property(e => e.VndNo3060).HasColumnName("VND_NO_30_60");

                entity.Property(e => e.VndNo6090).HasColumnName("VND_NO_60_90");

                entity.Property(e => e.VndNo90).HasColumnName("VND_NO_90");

                entity.Property(e => e.VndNoquahan).HasColumnName("VND_NOQUAHAN");

                entity.Property(e => e.VndNotronghan).HasColumnName("VND_NOTRONGHAN");

                entity.Property(e => e.VndPhaithuhomnay).HasColumnName("VND_PHAITHUHOMNAY");

                entity.Property(e => e.VndPhaitrahomnay).HasColumnName("VND_PHAITRAHOMNAY");

                entity.Property(e => e.VndTratrongky).HasColumnName("VND_TRATRONGKY");

                entity.Property(e => e.Vndckco).HasColumnName("VNDCKCO");

                entity.Property(e => e.Vndckno).HasColumnName("VNDCKNO");

                entity.Property(e => e.Vndduco).HasColumnName("VNDDUCO");

                entity.Property(e => e.Vndduno).HasColumnName("VNDDUNO");

                entity.Property(e => e.Vndpsco).HasColumnName("VNDPSCO");

                entity.Property(e => e.Vndpsno).HasColumnName("VNDPSNO");
            });

            modelBuilder.Entity<KthoadonChinhanh>(entity =>
            {
                entity.HasKey(e => new { e.Matk, e.Madtpn, e.Machinhanh, e.SrHd, e.SoHd })
                    .HasName("PK__KTHOADON_CHINHAN__739B0049");

                entity.ToTable("KTHOADON_CHINHANH");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN");

                entity.Property(e => e.Machinhanh)
                    .HasMaxLength(50)
                    .HasColumnName("MACHINHANH");

                entity.Property(e => e.SrHd)
                    .HasMaxLength(50)
                    .HasColumnName("SR_HD");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GiatriVnd).HasColumnName("GIATRI_VND");

                entity.Property(e => e.Hanmuc).HasColumnName("HANMUC");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LaiSuat)
                    .HasMaxLength(100)
                    .HasColumnName("LAI_SUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayDaoHan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_DAO_HAN");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HD");

                entity.Property(e => e.Ngayct)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYCT");

                entity.Property(e => e.SoHopdong)
                    .HasMaxLength(100)
                    .HasColumnName("SO_HOPDONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenchinhanh)
                    .HasMaxLength(250)
                    .HasColumnName("TENCHINHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendb)
                    .HasMaxLength(50)
                    .HasColumnName("TENDB")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(255)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TuoiNo).HasColumnName("TUOI_NO");

                entity.Property(e => e.Tygia).HasColumnName("TYGIA");

                entity.Property(e => e.TygiaCo).HasColumnName("TYGIA_CO");

                entity.Property(e => e.TygiaNo).HasColumnName("TYGIA_NO");

                entity.Property(e => e.UsdNo30).HasColumnName("USD_NO_30");

                entity.Property(e => e.UsdNo3060).HasColumnName("USD_NO_30_60");

                entity.Property(e => e.UsdNo6090).HasColumnName("USD_NO_60_90");

                entity.Property(e => e.UsdNo90).HasColumnName("USD_NO_90");

                entity.Property(e => e.Usdckco).HasColumnName("USDCKCO");

                entity.Property(e => e.Usdckno).HasColumnName("USDCKNO");

                entity.Property(e => e.Usdduco).HasColumnName("USDDUCO");

                entity.Property(e => e.Usdduno).HasColumnName("USDDUNO");

                entity.Property(e => e.Usdpsco).HasColumnName("USDPSCO");

                entity.Property(e => e.Usdpsno).HasColumnName("USDPSNO");

                entity.Property(e => e.VndNo30).HasColumnName("VND_NO_30");

                entity.Property(e => e.VndNo3060).HasColumnName("VND_NO_30_60");

                entity.Property(e => e.VndNo6090).HasColumnName("VND_NO_60_90");

                entity.Property(e => e.VndNo90).HasColumnName("VND_NO_90");

                entity.Property(e => e.Vndckco).HasColumnName("VNDCKCO");

                entity.Property(e => e.Vndckno).HasColumnName("VNDCKNO");

                entity.Property(e => e.Vndduco).HasColumnName("VNDDUCO");

                entity.Property(e => e.Vndduno).HasColumnName("VNDDUNO");

                entity.Property(e => e.Vndpsco).HasColumnName("VNDPSCO");

                entity.Property(e => e.Vndpsno).HasColumnName("VNDPSNO");
            });

            modelBuilder.Entity<Ktkheuoc>(entity =>
            {
                entity.HasKey(e => new { e.Matk, e.Madtpn, e.SoHopdong, e.Sokheuoc })
                    .HasName("PK__KTKHEUOC__754E3E91");

                entity.ToTable("KTKHEUOC");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN");

                entity.Property(e => e.SoHopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HOPDONG");

                entity.Property(e => e.Sokheuoc)
                    .HasMaxLength(50)
                    .HasColumnName("SOKHEUOC");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DsLaiSuat)
                    .HasMaxLength(150)
                    .HasColumnName("DS_LAI_SUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GtHdUsd).HasColumnName("GT_HD_USD");

                entity.Property(e => e.GtHdVnd).HasColumnName("GT_HD_VND");

                entity.Property(e => e.GtKheuocUsd).HasColumnName("GT_KHEUOC_USD");

                entity.Property(e => e.GtKheuocVnd).HasColumnName("GT_KHEUOC_VND");

                entity.Property(e => e.HanmucUsd).HasColumnName("HANMUC_USD");

                entity.Property(e => e.HanmucVnd).HasColumnName("HANMUC_VND");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(250)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LaiSuatVay).HasColumnName("LAI_SUAT_VAY");

                entity.Property(e => e.NgayDaoHan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_DAO_HAN");

                entity.Property(e => e.NgayHopdong)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HOPDONG");

                entity.Property(e => e.Ngaykheuoc)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYKHEUOC");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(550)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SongayQh).HasColumnName("SONGAY_QH");

                entity.Property(e => e.SongayTh).HasColumnName("SONGAY_TH");

                entity.Property(e => e.SongayTong).HasColumnName("SONGAY_TONG");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(255)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkCpVay)
                    .HasMaxLength(50)
                    .HasColumnName("TK_CP_VAY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TuoiNo).HasColumnName("TUOI_NO");

                entity.Property(e => e.TygiaCo).HasColumnName("TYGIA_CO");

                entity.Property(e => e.TygiaNo).HasColumnName("TYGIA_NO");

                entity.Property(e => e.UsdLqhCk).HasColumnName("USD_LQH_CK");

                entity.Property(e => e.UsdLqhDk).HasColumnName("USD_LQH_DK");

                entity.Property(e => e.UsdLqhTk).HasColumnName("USD_LQH_TK");

                entity.Property(e => e.UsdLthCk).HasColumnName("USD_LTH_CK");

                entity.Property(e => e.UsdLthDk).HasColumnName("USD_LTH_DK");

                entity.Property(e => e.UsdLthTk).HasColumnName("USD_LTH_TK");

                entity.Property(e => e.UsdNo30).HasColumnName("USD_NO_30");

                entity.Property(e => e.UsdNo3060).HasColumnName("USD_NO_30_60");

                entity.Property(e => e.UsdNo6090).HasColumnName("USD_NO_60_90");

                entity.Property(e => e.UsdNo90).HasColumnName("USD_NO_90");

                entity.Property(e => e.UsdTongLai).HasColumnName("USD_TONG_LAI");

                entity.Property(e => e.Usdckco).HasColumnName("USDCKCO");

                entity.Property(e => e.Usdckno).HasColumnName("USDCKNO");

                entity.Property(e => e.Usdduco).HasColumnName("USDDUCO");

                entity.Property(e => e.Usdduno).HasColumnName("USDDUNO");

                entity.Property(e => e.Usdpsco).HasColumnName("USDPSCO");

                entity.Property(e => e.Usdpsno).HasColumnName("USDPSNO");

                entity.Property(e => e.VndLqhCk).HasColumnName("VND_LQH_CK");

                entity.Property(e => e.VndLqhDk).HasColumnName("VND_LQH_DK");

                entity.Property(e => e.VndLqhTk).HasColumnName("VND_LQH_TK");

                entity.Property(e => e.VndLthCk).HasColumnName("VND_LTH_CK");

                entity.Property(e => e.VndLthDk).HasColumnName("VND_LTH_DK");

                entity.Property(e => e.VndLthTk).HasColumnName("VND_LTH_TK");

                entity.Property(e => e.VndNo30).HasColumnName("VND_NO_30");

                entity.Property(e => e.VndNo3060).HasColumnName("VND_NO_30_60");

                entity.Property(e => e.VndNo6090).HasColumnName("VND_NO_60_90");

                entity.Property(e => e.VndNo90).HasColumnName("VND_NO_90");

                entity.Property(e => e.VndTongLai).HasColumnName("VND_TONG_LAI");

                entity.Property(e => e.Vndckco).HasColumnName("VNDCKCO");

                entity.Property(e => e.Vndckno).HasColumnName("VNDCKNO");

                entity.Property(e => e.Vndduco).HasColumnName("VNDDUCO");

                entity.Property(e => e.Vndduno).HasColumnName("VNDDUNO");

                entity.Property(e => e.Vndpsco).HasColumnName("VNDPSCO");

                entity.Property(e => e.Vndpsno).HasColumnName("VNDPSNO");
            });

            modelBuilder.Entity<Ktkhsx>(entity =>
            {
                entity.ToTable("KTKHSX");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DinhMuc1sp).HasColumnName("DINH_MUC_1SP");

                entity.Property(e => e.Dvt1)
                    .HasMaxLength(12)
                    .HasColumnName("DVT1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt2)
                    .HasMaxLength(12)
                    .HasColumnName("DVT2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt3)
                    .HasMaxLength(12)
                    .HasColumnName("DVT3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DvtNl)
                    .HasMaxLength(50)
                    .HasColumnName("DVT_NL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhichuMh)
                    .HasMaxLength(150)
                    .HasColumnName("GHICHU_MH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ghichukhsx)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHUKHSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kyhieukhsx)
                    .HasMaxLength(50)
                    .HasColumnName("KYHIEUKHSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mabpsx)
                    .HasMaxLength(50)
                    .HasColumnName("MABPSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madonhangban)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANGBAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madonhangmua)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANGMUA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makhsx)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manvl)
                    .HasMaxLength(50)
                    .HasColumnName("MANVL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matp)
                    .HasMaxLength(50)
                    .HasColumnName("MATP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngaybatdau)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYBATDAU");

                entity.Property(e => e.Ngayketthuc)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYKETTHUC");

                entity.Property(e => e.Ngaynhapkhsx)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYNHAPKHSX");

                entity.Property(e => e.NmhDiachi)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_DIACHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMa)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTen)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quycach1)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quycach2)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quycach3)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SlNlCan).HasColumnName("SL_NL_CAN");

                entity.Property(e => e.SlTpNk).HasColumnName("SL_TP_NK");

                entity.Property(e => e.Soluong1).HasColumnName("SOLUONG1");

                entity.Property(e => e.Soluong2).HasColumnName("SOLUONG2");

                entity.Property(e => e.Soluong3).HasColumnName("SOLUONG3");

                entity.Property(e => e.SttMh).HasColumnName("STT_MH");

                entity.Property(e => e.Sttkhsx).HasColumnName("STTKHSX");

                entity.Property(e => e.Tenbpsx)
                    .HasMaxLength(250)
                    .HasColumnName("TENBPSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennvl)
                    .HasMaxLength(250)
                    .HasColumnName("TENNVL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tentp)
                    .HasMaxLength(250)
                    .HasColumnName("TENTP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonCk).HasColumnName("TON_CK");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktlctg>(entity =>
            {
                entity.HasKey(e => e.Lctg)
                    .HasName("PK__KTLCTG__691284DE");

                entity.ToTable("KTLCTG");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG");

                entity.Property(e => e.BeronggapHd).HasColumnName("BERONGGAP_HD");

                entity.Property(e => e.ChungtuCopy)
                    .HasMaxLength(50)
                    .HasColumnName("CHUNGTU_COPY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoBbchomuon)
                    .HasMaxLength(1)
                    .HasColumnName("CO_BBCHOMUON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoChietkhau)
                    .HasMaxLength(1)
                    .HasColumnName("CO_CHIETKHAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoChuyenkho)
                    .HasMaxLength(1)
                    .HasColumnName("CO_CHUYENKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoCkTruoc)
                    .HasMaxLength(1)
                    .HasColumnName("CO_CK_TRUOC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoCktm)
                    .HasMaxLength(2)
                    .HasColumnName("CO_CKTM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoCktt)
                    .HasMaxLength(2)
                    .HasColumnName("CO_CKTT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoCltg)
                    .HasMaxLength(1)
                    .HasColumnName("CO_CLTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoDgnhap)
                    .HasMaxLength(1)
                    .HasColumnName("CO_DGNHAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoDiengiai2)
                    .HasMaxLength(1)
                    .HasColumnName("CO_DIENGIAI2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoDonviPhu)
                    .HasMaxLength(1)
                    .HasColumnName("CO_DONVI_PHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoFormRieng)
                    .HasMaxLength(1)
                    .HasColumnName("CO_FORM_RIENG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoHoiin)
                    .HasMaxLength(1)
                    .HasColumnName("CO_HOIIN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoHtphelieu)
                    .HasMaxLength(1)
                    .HasColumnName("CO_HTPHELIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoLenhsx)
                    .HasMaxLength(1)
                    .HasColumnName("CO_LENHSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoLonhap)
                    .HasMaxLength(1)
                    .HasColumnName("CO_LONHAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoMhunc)
                    .HasMaxLength(1)
                    .HasColumnName("CO_MHUNC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoTenhhIn)
                    .HasMaxLength(1)
                    .HasColumnName("CO_TENHH_IN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoTienhang)
                    .HasMaxLength(1)
                    .HasColumnName("CO_TIENHANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoTkXuat)
                    .HasMaxLength(2)
                    .HasColumnName("CO_TK_XUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoTkdutkthue)
                    .HasMaxLength(1)
                    .HasColumnName("CO_TKDUTKTHUE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoTschitiet)
                    .HasMaxLength(1)
                    .HasColumnName("CO_TSCHITIET")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoTttdb)
                    .HasMaxLength(1)
                    .HasColumnName("CO_TTTDB")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoVc)
                    .HasMaxLength(10)
                    .HasColumnName("CO_VC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoVthh)
                    .HasMaxLength(1)
                    .HasColumnName("CO_VTHH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoXuatkho)
                    .HasMaxLength(1)
                    .HasColumnName("CO_XUATKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CotGapXch)
                    .HasMaxLength(50)
                    .HasColumnName("COT_GAP_XCH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(1)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diengiai)
                    .HasMaxLength(250)
                    .HasColumnName("DIENGIAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DscotShowEdit)
                    .HasMaxLength(999)
                    .HasColumnName("DSCOT_SHOW_EDIT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DscotShowNhapps)
                    .HasMaxLength(999)
                    .HasColumnName("DSCOT_SHOW_NHAPPS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Haminchungtu)
                    .HasMaxLength(10)
                    .HasColumnName("HAMINCHUNGTU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hdvat)
                    .HasMaxLength(2)
                    .HasColumnName("HDVAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KhmHd)
                    .HasMaxLength(50)
                    .HasColumnName("KHM_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KieuChungtu)
                    .HasMaxLength(50)
                    .HasColumnName("KIEU_CHUNGTU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KieuCongty)
                    .HasMaxLength(40)
                    .HasColumnName("KIEU_CONGTY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KieuNhapps)
                    .HasMaxLength(10)
                    .HasColumnName("KIEU_NHAPPS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kieutangsoct)
                    .HasMaxLength(10)
                    .HasColumnName("KIEUTANGSOCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LctgPc)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG_PC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LctgPt)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG_PT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Loaitien)
                    .HasMaxLength(5)
                    .HasColumnName("LOAITIEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(50)
                    .HasColumnName("MA_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaPrifix)
                    .HasMaxLength(10)
                    .HasColumnName("MA_PRIFIX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaSufix)
                    .HasMaxLength(10)
                    .HasColumnName("MA_SUFIX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mabophan)
                    .HasMaxLength(50)
                    .HasColumnName("MABOPHAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnco)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnno)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhinh)
                    .HasMaxLength(999)
                    .HasColumnName("MANHINH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matt)
                    .HasMaxLength(2)
                    .HasColumnName("MATT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MsKh)
                    .HasMaxLength(1)
                    .HasColumnName("MS_KH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nguoigd)
                    .HasMaxLength(200)
                    .HasColumnName("NGUOIGD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NhieuDv)
                    .HasMaxLength(1)
                    .HasColumnName("NHIEU_DV")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NhieuHd)
                    .HasMaxLength(1)
                    .HasColumnName("NHIEU_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NhieuUser)
                    .HasMaxLength(1)
                    .HasColumnName("NHIEU_USER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhieulien)
                    .HasMaxLength(1)
                    .HasColumnName("NHIEULIEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NhomDscot)
                    .HasMaxLength(20)
                    .HasColumnName("NHOM_DSCOT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhomchungtu)
                    .HasMaxLength(20)
                    .HasColumnName("NHOMCHUNGTU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PtCk).HasColumnName("PT_CK");

                entity.Property(e => e.PxkOfHdbr)
                    .HasMaxLength(50)
                    .HasColumnName("PXK_OF_HDBR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sapxepchungtu).HasColumnName("SAPXEPCHUNGTU");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(15)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SocotCdEdit).HasColumnName("SOCOT_CD_EDIT");

                entity.Property(e => e.Soct)
                    .HasMaxLength(15)
                    .HasColumnName("SOCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sodong).HasColumnName("SODONG");

                entity.Property(e => e.Sokytusoct).HasColumnName("SOKYTUSOCT");

                entity.Property(e => e.SrHd)
                    .HasMaxLength(10)
                    .HasColumnName("SR_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TDtvung)
                    .HasMaxLength(1)
                    .HasColumnName("T_DTVUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenctg)
                    .HasMaxLength(255)
                    .HasColumnName("TENCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenwb)
                    .HasMaxLength(50)
                    .HasColumnName("TENWB")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkChietkhau)
                    .HasMaxLength(20)
                    .HasColumnName("TK_CHIETKHAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkGiavon)
                    .HasMaxLength(60)
                    .HasColumnName("TK_GIAVON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkTnk)
                    .HasMaxLength(10)
                    .HasColumnName("TK_TNK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkXuat)
                    .HasMaxLength(20)
                    .HasColumnName("TK_XUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkcltgLai)
                    .HasMaxLength(10)
                    .HasColumnName("TKCLTG_LAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkcltgLo)
                    .HasMaxLength(10)
                    .HasColumnName("TKCLTG_LO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkco)
                    .HasMaxLength(10)
                    .HasColumnName("TKCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkduTkthue)
                    .HasMaxLength(50)
                    .HasColumnName("TKDU_TKTHUE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkno)
                    .HasMaxLength(10)
                    .HasColumnName("TKNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkthue)
                    .HasMaxLength(10)
                    .HasColumnName("TKTHUE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TsGtgt)
                    .HasMaxLength(10)
                    .HasColumnName("TS_GTGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Vonglap)
                    .HasMaxLength(50)
                    .HasColumnName("VONGLAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.XkDm)
                    .HasMaxLength(1)
                    .HasColumnName("XK_DM")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Ktlenhsx>(entity =>
            {
                entity.HasKey(e => new { e.MaLenh, e.Matk, e.Madtpn, e.Madm })
                    .HasName("PK__KTLENHSX__4CCB4BEB");

                entity.ToTable("KTLENHSX");

                entity.Property(e => e.MaLenh)
                    .HasMaxLength(50)
                    .HasColumnName("MA_LENH");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayLenh)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_LENH");

                entity.Property(e => e.NhapT).HasColumnName("NHAP_T");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SttLenh).HasColumnName("STT_LENH");

                entity.Property(e => e.TenLenh)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_LENH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonCk).HasColumnName("TON_CK");

                entity.Property(e => e.TonT).HasColumnName("TON_T");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.XuatT).HasColumnName("XUAT_T");
            });

            modelBuilder.Entity<KtlocAltF7>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__KTLOC_ALT_F7__7350E786");

                entity.ToTable("KTLOC_ALT_F7");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dieukienloc)
                    .HasMaxLength(500)
                    .HasColumnName("DIEUKIENLOC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenbang)
                    .HasMaxLength(50)
                    .HasColumnName("TENBANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktmausac>(entity =>
            {
                entity.HasKey(e => new { e.Mamausac, e.Madm })
                    .HasName("PK__KTMAUSAC__391958F9");

                entity.ToTable("KTMAUSAC");

                entity.Property(e => e.Mamausac)
                    .HasMaxLength(50)
                    .HasColumnName("MAMAUSAC");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgmausac).HasColumnName("DGMAUSAC");

                entity.Property(e => e.PtThanhtien).HasColumnName("PT_THANHTIEN");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenmausac)
                    .HasMaxLength(250)
                    .HasColumnName("TENMAUSAC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtmenuCon>(entity =>
            {
                entity.HasKey(e => new { e.Matab, e.SttMe, e.SttCon })
                    .HasName("PK__KTMENU_CON__037C6257");

                entity.ToTable("KTMENU_CON");

                entity.Property(e => e.Matab)
                    .HasMaxLength(10)
                    .HasColumnName("MATAB");

                entity.Property(e => e.SttMe).HasColumnName("STT_ME");

                entity.Property(e => e.SttCon)
                    .HasMaxLength(10)
                    .HasColumnName("STT_CON");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DanhsachUser)
                    .HasMaxLength(250)
                    .HasColumnName("DANHSACH_USER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hide)
                    .HasMaxLength(1)
                    .HasColumnName("HIDE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenmenuCon)
                    .HasMaxLength(100)
                    .HasColumnName("TENMENU_CON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenmenuMe)
                    .HasMaxLength(50)
                    .HasColumnName("TENMENU_ME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasMaxLength(50)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<KtmenuMe>(entity =>
            {
                entity.HasKey(e => new { e.Matab, e.SttMe })
                    .HasName("PK__KTMENU_ME__7BDB408F");

                entity.ToTable("KTMENU_ME");

                entity.Property(e => e.Matab)
                    .HasMaxLength(10)
                    .HasColumnName("MATAB");

                entity.Property(e => e.SttMe).HasColumnName("STT_ME");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DanhsachUser)
                    .HasMaxLength(250)
                    .HasColumnName("DANHSACH_USER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hide)
                    .HasMaxLength(1)
                    .HasColumnName("HIDE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenmenuMe)
                    .HasMaxLength(250)
                    .HasColumnName("TENMENU_ME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtmenuNadopo>(entity =>
            {
                entity.HasKey(e => new { e.MaMenuMe, e.MaMenuCon })
                    .HasName("PK__KTMENU_NADOPOS__593122D0");

                entity.ToTable("KTMENU_NADOPOS");

                entity.Property(e => e.MaMenuMe)
                    .HasMaxLength(50)
                    .HasColumnName("MA_MENU_ME");

                entity.Property(e => e.MaMenuCon)
                    .HasMaxLength(50)
                    .HasColumnName("MA_MENU_CON");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DsUser)
                    .HasMaxLength(500)
                    .HasColumnName("DS_USER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SdLoaitru)
                    .HasMaxLength(5)
                    .HasColumnName("SD_LOAITRU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenMenuCon)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_MENU_CON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenMenuMe)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_MENU_ME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktnhanvien>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__KTNHANVIEN__7AF2094E");

                entity.ToTable("KTNHANVIEN");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.BhtnCongty).HasColumnName("BHTN_CONGTY");

                entity.Property(e => e.BhtnNld).HasColumnName("BHTN_NLD");

                entity.Property(e => e.BhxhCongty).HasColumnName("BHXH_CONGTY");

                entity.Property(e => e.BhxhNgd).HasColumnName("BHXH_NGD");

                entity.Property(e => e.BhytCongty).HasColumnName("BHYT_CONGTY");

                entity.Property(e => e.BhytNld).HasColumnName("BHYT_NLD");

                entity.Property(e => e.CacKhoanGiamTru).HasColumnName("CAC_KHOAN_GIAM_TRU");

                entity.Property(e => e.CacKhoanMienThue).HasColumnName("CAC_KHOAN_MIEN_THUE");

                entity.Property(e => e.ChucDanh)
                    .HasMaxLength(50)
                    .HasColumnName("CHUC_DANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChucVu)
                    .HasMaxLength(50)
                    .HasColumnName("CHUC_VU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChucVuDamNhan)
                    .HasMaxLength(50)
                    .HasColumnName("CHUC_VU_DAM_NHAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChuyenNganh)
                    .HasMaxLength(50)
                    .HasColumnName("CHUYEN_NGANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DanToc)
                    .HasMaxLength(50)
                    .HasColumnName("DAN_TOC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DienThoai1)
                    .HasMaxLength(20)
                    .HasColumnName("DIEN_THOAI_1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DienThoai2)
                    .HasMaxLength(20)
                    .HasColumnName("DIEN_THOAI_2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(50)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GioiTinh)
                    .HasMaxLength(10)
                    .HasColumnName("GIOI_TINH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HeSoLuong).HasColumnName("HE_SO_LUONG");

                entity.Property(e => e.HoTenAnh)
                    .HasMaxLength(100)
                    .HasColumnName("HO_TEN_ANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HoTenHoa)
                    .HasMaxLength(100)
                    .HasColumnName("HO_TEN_HOA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HoTenViet)
                    .HasMaxLength(100)
                    .HasColumnName("HO_TEN_VIET")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kpcd).HasColumnName("KPCD");

                entity.Property(e => e.LuongBh).HasColumnName("LUONG_BH");

                entity.Property(e => e.LuongCoBan).HasColumnName("LUONG_CO_BAN");

                entity.Property(e => e.LuongThucNhan).HasColumnName("LUONG_THUC_NHAN");

                entity.Property(e => e.MaNhanVien)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NHAN_VIEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaVach)
                    .HasMaxLength(50)
                    .HasColumnName("MA_VACH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayCap)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_CAP");

                entity.Property(e => e.NgayCong).HasColumnName("NGAY_CONG");

                entity.Property(e => e.NgayLuu)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_LUU");

                entity.Property(e => e.NgayRa)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_RA");

                entity.Property(e => e.NgaySinh)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_SINH");

                entity.Property(e => e.NgayVao)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_VAO");

                entity.Property(e => e.Ngayra1)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYRA");

                entity.Property(e => e.Ngayvao1)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYVAO");

                entity.Property(e => e.NoiCap)
                    .HasMaxLength(50)
                    .HasColumnName("NOI_CAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NoiSinh)
                    .HasMaxLength(100)
                    .HasColumnName("NOI_SINH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PcAn).HasColumnName("PC_AN");

                entity.Property(e => e.PcChucVu).HasColumnName("PC_CHUC_VU");

                entity.Property(e => e.PcKhac).HasColumnName("PC_KHAC");

                entity.Property(e => e.PcThamNien).HasColumnName("PC_THAM_NIEN");

                entity.Property(e => e.PcTrachNhiem).HasColumnName("PC_TRACH_NHIEM");

                entity.Property(e => e.PcXangXe).HasColumnName("PC_XANG_XE");

                entity.Property(e => e.PhongBan)
                    .HasMaxLength(50)
                    .HasColumnName("PHONG_BAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QuanHuyen)
                    .HasMaxLength(50)
                    .HasColumnName("QUAN_HUYEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QueQuan)
                    .HasMaxLength(100)
                    .HasColumnName("QUE_QUAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QuocGia)
                    .HasMaxLength(20)
                    .HasColumnName("QUOC_GIA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QuocTich)
                    .HasMaxLength(50)
                    .HasColumnName("QUOC_TICH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoCmnd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_CMND")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TamTru)
                    .HasMaxLength(100)
                    .HasColumnName("TAM_TRU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenPhongBan)
                    .HasMaxLength(99)
                    .HasColumnName("TEN_PHONG_BAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ThuNhapChiuThue).HasColumnName("THU_NHAP_CHIU_THUE");

                entity.Property(e => e.ThuNhapTinhThue).HasColumnName("THU_NHAP_TINH_THUE");

                entity.Property(e => e.ThuocTo)
                    .HasMaxLength(50)
                    .HasColumnName("THUOC_TO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ThuongTru)
                    .HasMaxLength(100)
                    .HasColumnName("THUONG_TRU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TinhThanhPho)
                    .HasMaxLength(50)
                    .HasColumnName("TINH_THANH_PHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkBhtn)
                    .HasMaxLength(50)
                    .HasColumnName("TK_BHTN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkBhxh)
                    .HasMaxLength(50)
                    .HasColumnName("TK_BHXH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkBhyt)
                    .HasMaxLength(50)
                    .HasColumnName("TK_BHYT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkCpLuong)
                    .HasMaxLength(50)
                    .HasColumnName("TK_CP_LUONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkKpcd)
                    .HasMaxLength(50)
                    .HasColumnName("TK_KPCD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkLuong)
                    .HasMaxLength(50)
                    .HasColumnName("TK_LUONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkTncn)
                    .HasMaxLength(50)
                    .HasColumnName("TK_TNCN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonGiao)
                    .HasMaxLength(50)
                    .HasColumnName("TON_GIAO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TongLuong).HasColumnName("TONG_LUONG");

                entity.Property(e => e.TongLuongHt).HasColumnName("TONG_LUONG_HT");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VanHoa)
                    .HasMaxLength(50)
                    .HasColumnName("VAN_HOA")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Ktnhatkysua>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__KTNHATKYSUA__39E36000");

                entity.ToTable("KTNHATKYSUA");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dieukien)
                    .HasMaxLength(250)
                    .HasColumnName("DIEUKIEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(50)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Giosua)
                    .HasMaxLength(50)
                    .HasColumnName("GIOSUA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Id1)
                    .HasMaxLength(50)
                    .HasColumnName("ID1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Id2)
                    .HasMaxLength(50)
                    .HasColumnName("ID2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Id3)
                    .HasMaxLength(50)
                    .HasColumnName("ID3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Id4)
                    .HasMaxLength(50)
                    .HasColumnName("ID4")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Id5)
                    .HasMaxLength(50)
                    .HasColumnName("ID5")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Id6)
                    .HasMaxLength(50)
                    .HasColumnName("ID6")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoaiSua)
                    .HasMaxLength(50)
                    .HasColumnName("LOAI_SUA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngaysua)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYSUA");

                entity.Property(e => e.Tenbang)
                    .HasMaxLength(50)
                    .HasColumnName("TENBANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktnhomck>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Stt })
                    .HasName("PK__KTNHOMCK__118A8A8C");

                entity.ToTable("KTNHOMCK");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .HasColumnName("ID");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhomdt)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOMDT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhomhh)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOMHH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngayad)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYAD");

                entity.Property(e => e.Ngaykethuc)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYKETHUC");

                entity.Property(e => e.PtCk).HasColumnName("PT_CK");

                entity.Property(e => e.Tennhomdt)
                    .HasMaxLength(150)
                    .HasColumnName("TENNHOMDT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhomhh)
                    .HasMaxLength(150)
                    .HasColumnName("TENNHOMHH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktnhomdg>(entity =>
            {
                entity.ToTable("KTNHOMDG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgban1).HasColumnName("DGBAN1");

                entity.Property(e => e.Dgban2).HasColumnName("DGBAN2");

                entity.Property(e => e.Dgban3).HasColumnName("DGBAN3");

                entity.Property(e => e.Dgban4).HasColumnName("DGBAN4");

                entity.Property(e => e.Dgban5).HasColumnName("DGBAN5");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Httt)
                    .HasMaxLength(50)
                    .HasColumnName("HTTT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kyduyet)
                    .HasMaxLength(250)
                    .HasColumnName("KYDUYET")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngayad)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYAD");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhom)
                    .HasMaxLength(250)
                    .HasColumnName("TENNHOM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktnhomhh>(entity =>
            {
                entity.HasKey(e => e.Manhom)
                    .HasName("PK__KTNHOMHH__76226739");

                entity.ToTable("KTNHOMHH");

                entity.Property(e => e.Manhom)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM");

                entity.Property(e => e.Danhdau).HasColumnName("DANHDAU");

                entity.Property(e => e.Kieunhom)
                    .HasMaxLength(50)
                    .HasColumnName("KIEUNHOM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhom)
                    .HasMaxLength(50)
                    .HasColumnName("TENNHOM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktnhucaunguyenlieu>(entity =>
            {
                entity.HasKey(e => new { e.Nam, e.Thang, e.Ngay })
                    .HasName("PK__KTNHUCAUNGUYENLI__3004F00B");

                entity.ToTable("KTNHUCAUNGUYENLIEU");

                entity.Property(e => e.Nam).HasColumnName("NAM");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Ngay).HasColumnName("NGAY");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(50)
                    .HasColumnName("DVT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kyhieu)
                    .HasMaxLength(50)
                    .HasColumnName("KYHIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manguyenlieu)
                    .HasMaxLength(50)
                    .HasColumnName("MANGUYENLIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SlCanMua).HasColumnName("SL_CAN_MUA");

                entity.Property(e => e.SlDhban).HasColumnName("SL_DHBAN");

                entity.Property(e => e.SlDhmua).HasColumnName("SL_DHMUA");

                entity.Property(e => e.SlTonMin).HasColumnName("SL_TON_MIN");

                entity.Property(e => e.SttNl).HasColumnName("STT_NL");

                entity.Property(e => e.Tennguyenlieu)
                    .HasMaxLength(250)
                    .HasColumnName("TENNGUYENLIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonCk).HasColumnName("TON_CK");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktpbcp>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.Stt })
                    .HasName("PK__KTPBCP__346A7DCC");

                entity.ToTable("KTPBCP");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.CpDuocPhanbo).HasColumnName("CP_DUOC_PHANBO");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kieuchiphi)
                    .HasMaxLength(10)
                    .HasColumnName("KIEUCHIPHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matk154)
                    .HasMaxLength(50)
                    .HasColumnName("MATK_154")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MatkCp)
                    .HasMaxLength(50)
                    .HasColumnName("MATK_CP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcp)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaytcpCon)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCP_CON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhantramCp).HasColumnName("PHANTRAM_CP");

                entity.Property(e => e.SlDuocPhanbo).HasColumnName("SL_DUOC_PHANBO");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TentkCp)
                    .HasMaxLength(250)
                    .HasColumnName("TENTK_CP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenytcp)
                    .HasMaxLength(250)
                    .HasColumnName("TENYTCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenytcpCon)
                    .HasMaxLength(250)
                    .HasColumnName("TENYTCP_CON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtpbcpCt>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.SttSc })
                    .HasName("PK__KTPBCP_CT__48717679");

                entity.ToTable("KTPBCP_CT");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.SttSc).HasColumnName("STT_SC");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(250)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgvnd).HasColumnName("DGVND");

                entity.Property(e => e.Diengiai)
                    .HasMaxLength(250)
                    .HasColumnName("DIENGIAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoNhap)
                    .HasMaxLength(50)
                    .HasColumnName("LO_NHAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoXuat)
                    .HasMaxLength(50)
                    .HasColumnName("LO_XUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Luong).HasColumnName("LUONG");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madmco)
                    .HasMaxLength(50)
                    .HasColumnName("MADMCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madmno)
                    .HasMaxLength(50)
                    .HasColumnName("MADMNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnco)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnno)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makh)
                    .HasMaxLength(100)
                    .HasColumnName("MAKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpco)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCPCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpno)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCPNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HD");

                entity.Property(e => e.Ngayct)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYCT");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoHopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HOPDONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soct)
                    .HasMaxLength(50)
                    .HasColumnName("SOCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SrHd)
                    .HasMaxLength(50)
                    .HasColumnName("SR_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SttBt).HasColumnName("STT_BT");

                entity.Property(e => e.SttSapxep).HasColumnName("STT_SAPXEP");

                entity.Property(e => e.Tenct)
                    .HasMaxLength(250)
                    .HasColumnName("TENCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(250)
                    .HasColumnName("TENKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thueusd).HasColumnName("THUEUSD");

                entity.Property(e => e.Thuevnd).HasColumnName("THUEVND");

                entity.Property(e => e.Tkco)
                    .HasMaxLength(50)
                    .HasColumnName("TKCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkno)
                    .HasMaxLength(50)
                    .HasColumnName("TKNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TnkUsd).HasColumnName("TNK_USD");

                entity.Property(e => e.TnkVnd).HasColumnName("TNK_VND");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ttusd).HasColumnName("TTUSD");

                entity.Property(e => e.Ttvnd).HasColumnName("TTVND");

                entity.Property(e => e.Tygia).HasColumnName("TYGIA");
            });

            modelBuilder.Entity<KtpbcpGd>(entity =>
            {
                entity.HasKey(e => new { e.Giaidoan, e.Thang, e.Stt })
                    .HasName("PK__KTPBCP_GD__58671BC9");

                entity.ToTable("KTPBCP_GD");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Cp1sp).HasColumnName("CP_1SP");

                entity.Property(e => e.CpDuocPhanbo).HasColumnName("CP_DUOC_PHANBO");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kieuchiphi)
                    .HasMaxLength(50)
                    .HasColumnName("KIEUCHIPHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matk154)
                    .HasMaxLength(50)
                    .HasColumnName("MATK_154")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MatkCp)
                    .HasMaxLength(50)
                    .HasColumnName("MATK_CP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcp)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaytcpCon)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCP_CON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhantramCp).HasColumnName("PHANTRAM_CP");

                entity.Property(e => e.SlDuocPhanbo).HasColumnName("SL_DUOC_PHANBO");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TentkCp)
                    .HasMaxLength(250)
                    .HasColumnName("TENTK_CP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenytcp)
                    .HasMaxLength(250)
                    .HasColumnName("TENYTCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenytcpCon)
                    .HasMaxLength(250)
                    .HasColumnName("TENYTCP_CON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkNl)
                    .HasMaxLength(50)
                    .HasColumnName("TK_NL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkTp)
                    .HasMaxLength(50)
                    .HasColumnName("TK_TP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtpqForm>(entity =>
            {
                entity.HasKey(e => e.IdForm)
                    .HasName("PK__KTPQ_FORM__5A054B78");

                entity.ToTable("KTPQ_FORM");

                entity.Property(e => e.IdForm)
                    .HasMaxLength(50)
                    .HasColumnName("ID_FORM");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KhaibaoJson)
                    .HasMaxLength(500)
                    .HasColumnName("KHAIBAO_JSON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenform)
                    .HasMaxLength(100)
                    .HasColumnName("TENFORM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtpqFormUser>(entity =>
            {
                entity.HasKey(e => new { e.IdForm, e.MaUser })
                    .HasName("PK__KTPQ_FORM_USER__5FBE24CE");

                entity.ToTable("KTPQ_FORM_USER");

                entity.Property(e => e.IdForm)
                    .HasMaxLength(50)
                    .HasColumnName("ID_FORM");

                entity.Property(e => e.MaUser)
                    .HasMaxLength(50)
                    .HasColumnName("MA_USER");

                entity.Property(e => e.ChoGiatri)
                    .HasMaxLength(50)
                    .HasColumnName("CHO_GIATRI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChoSudung)
                    .HasMaxLength(50)
                    .HasColumnName("CHO_SUDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KhaibaoJson)
                    .HasMaxLength(500)
                    .HasColumnName("KHAIBAO_JSON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenUser)
                    .HasMaxLength(100)
                    .HasColumnName("TEN_USER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenform)
                    .HasMaxLength(100)
                    .HasColumnName("TENFORM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtpqThang>(entity =>
            {
                entity.HasKey(e => e.Thang)
                    .HasName("PK__KTPQ_THANG__3EC810AE");

                entity.ToTable("KTPQ_THANG");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Chosua)
                    .HasMaxLength(1)
                    .HasColumnName("CHOSUA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Chothem)
                    .HasMaxLength(1)
                    .HasColumnName("CHOTHEM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Choxoa)
                    .HasMaxLength(1)
                    .HasColumnName("CHOXOA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtpqThangUser>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.Mauser })
                    .HasName("PK__KTPQ_THANG_USER__681F2BFC");

                entity.ToTable("KTPQ_THANG_USER");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER");

                entity.Property(e => e.Chosua)
                    .HasMaxLength(1)
                    .HasColumnName("CHOSUA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Chothem)
                    .HasMaxLength(1)
                    .HasColumnName("CHOTHEM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Choxoa)
                    .HasMaxLength(1)
                    .HasColumnName("CHOXOA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktpqchucvu>(entity =>
            {
                entity.HasKey(e => e.IdChucvu)
                    .HasName("PK__KTPQCHUCVU__1B13F4C6");

                entity.ToTable("KTPQCHUCVU");

                entity.Property(e => e.IdChucvu)
                    .HasMaxLength(50)
                    .HasColumnName("ID_CHUCVU");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DsQuensd)
                    .HasMaxLength(250)
                    .HasColumnName("DS_QUENSD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DsUser)
                    .HasMaxLength(250)
                    .HasColumnName("DS_USER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktpqct>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.Mauser, e.Lctg })
                    .HasName("PK__KTPQCT__6FC04DC4");

                entity.ToTable("KTPQCT");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG");

                entity.Property(e => e.Chosua)
                    .HasMaxLength(1)
                    .HasColumnName("CHOSUA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Chothem)
                    .HasMaxLength(1)
                    .HasColumnName("CHOTHEM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Choxoa)
                    .HasMaxLength(1)
                    .HasColumnName("CHOXOA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktpqngay>(entity =>
            {
                entity.ToTable("KTPQNGAY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Denngay)
                    .HasColumnType("datetime")
                    .HasColumnName("DENNGAY");

                entity.Property(e => e.Khoa)
                    .HasMaxLength(10)
                    .HasColumnName("KHOA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tungay)
                    .HasColumnType("datetime")
                    .HasColumnName("TUNGAY");
            });

            modelBuilder.Entity<KtquydoiDvt1>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Madm })
                    .HasName("PK__KTQUYDOI_DVT1__015422C3");

                entity.ToTable("KTQUYDOI_DVT1");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM");

                entity.Property(e => e.Danhdau).HasColumnName("DANHDAU");

                entity.Property(e => e.Dvt1)
                    .HasMaxLength(50)
                    .HasColumnName("DVT_1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DvtNhapps)
                    .HasMaxLength(50)
                    .HasColumnName("DVT_NHAPPS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hesoquydoi).HasColumnName("HESOQUYDOI");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktsc>(entity =>
            {
                entity.HasKey(e => e.SttSc)
                    .HasName("PK__KTSC__5927012F");

                entity.ToTable("KTSC");

                entity.Property(e => e.SttSc).HasColumnName("STT_SC");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .HasColumnName("BARCODE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Chietkhau).HasColumnName("CHIETKHAU");

                entity.Property(e => e.Chietkhau2).HasColumnName("CHIETKHAU2");

                entity.Property(e => e.ChietkhauUsd).HasColumnName("CHIETKHAU_USD");

                entity.Property(e => e.Col11).HasColumnName("COL_11");

                entity.Property(e => e.Col12).HasColumnName("COL_12");

                entity.Property(e => e.Col13).HasColumnName("COL_13");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(250)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DgGc).HasColumnName("DG_GC");

                entity.Property(e => e.DgVc).HasColumnName("DG_VC");

                entity.Property(e => e.Dgmausac).HasColumnName("DGMAUSAC");

                entity.Property(e => e.Dgusd).HasColumnName("DGUSD");

                entity.Property(e => e.Dgvnd).HasColumnName("DGVND");

                entity.Property(e => e.Dgvon).HasColumnName("DGVON");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(250)
                    .HasColumnName("DIACHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DiachiNgd)
                    .HasMaxLength(250)
                    .HasColumnName("DIACHI_NGD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diengiai)
                    .HasMaxLength(250)
                    .HasColumnName("DIENGIAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diengiai2)
                    .HasMaxLength(250)
                    .HasColumnName("DIENGIAI2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dontrong).HasColumnName("DONTRONG");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi1)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI_1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi2)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI_2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DonviCtu)
                    .HasMaxLength(53)
                    .HasColumnName("DONVI_CTU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DtNhan)
                    .HasMaxLength(50)
                    .HasColumnName("DT_NHAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DtXuat)
                    .HasMaxLength(50)
                    .HasColumnName("DT_XUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gtvon).HasColumnName("GTVON");

                entity.Property(e => e.Guid)
                    .HasMaxLength(50)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hansudung)
                    .HasColumnType("datetime")
                    .HasColumnName("HANSUDUNG");

                entity.Property(e => e.Hdvat)
                    .HasMaxLength(50)
                    .HasColumnName("HDVAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HsqdDvt).HasColumnName("HSQD_DVT");

                entity.Property(e => e.Httt)
                    .HasMaxLength(50)
                    .HasColumnName("HTTT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdChungtu).HasColumnName("ID_CHUNGTU");

                entity.Property(e => e.IdNghiepvu)
                    .HasMaxLength(20)
                    .HasColumnName("ID_NGHIEPVU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imei)
                    .HasMaxLength(50)
                    .HasColumnName("IMEI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Invoi)
                    .HasMaxLength(50)
                    .HasColumnName("INVOI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Khachhang)
                    .HasMaxLength(250)
                    .HasColumnName("KHACHHANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KhmHd)
                    .HasMaxLength(50)
                    .HasColumnName("KHM_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kxldg)
                    .HasMaxLength(5)
                    .HasColumnName("KXLDG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kyduyet)
                    .HasMaxLength(10)
                    .HasColumnName("KYDUYET")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kyhieu)
                    .HasMaxLength(250)
                    .HasColumnName("KYHIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LaiGop).HasColumnName("LAI_GOP");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lenhsx)
                    .HasMaxLength(50)
                    .HasColumnName("LENHSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoNhap)
                    .HasMaxLength(50)
                    .HasColumnName("LO_NHAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoXuat)
                    .HasMaxLength(50)
                    .HasColumnName("LO_XUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Luong).HasColumnName("LUONG");

                entity.Property(e => e.Luong1).HasColumnName("LUONG_1");

                entity.Property(e => e.Luong2).HasColumnName("LUONG_2");

                entity.Property(e => e.LuongCtu).HasColumnName("LUONG_CTU");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(50)
                    .HasColumnName("MA_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaHhGc)
                    .HasMaxLength(50)
                    .HasColumnName("MA_HH_GC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaNvBan)
                    .HasMaxLength(100)
                    .HasColumnName("MA_NV_BAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaTiepThi)
                    .HasMaxLength(50)
                    .HasColumnName("MA_TIEP_THI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaTt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_TT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaVung)
                    .HasMaxLength(50)
                    .HasColumnName("MA_VUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mabpsx)
                    .HasMaxLength(50)
                    .HasColumnName("MABPSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Machinhanh)
                    .HasMaxLength(50)
                    .HasColumnName("MACHINHANH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madmco)
                    .HasMaxLength(50)
                    .HasColumnName("MADMCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madmno)
                    .HasMaxLength(50)
                    .HasColumnName("MADMNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madonhang)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MadonhangMua)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANG_MUA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtgt)
                    .HasMaxLength(50)
                    .HasColumnName("MADTGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnco)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnno)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madvnt)
                    .HasMaxLength(250)
                    .HasColumnName("MADVNT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madvtt)
                    .HasMaxLength(250)
                    .HasColumnName("MADVTT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makh)
                    .HasMaxLength(100)
                    .HasColumnName("MAKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mamausac)
                    .HasMaxLength(50)
                    .HasColumnName("MAMAUSAC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mangd)
                    .HasMaxLength(50)
                    .HasColumnName("MANGD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom1)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom2)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhomdt1)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOMDT1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Masanpham)
                    .HasMaxLength(100)
                    .HasColumnName("MASANPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mathang)
                    .HasMaxLength(250)
                    .HasColumnName("MATHANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matttu)
                    .HasMaxLength(250)
                    .HasColumnName("MATTTU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(250)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpco)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCPCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpno)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCPNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .HasColumnName("MODEL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MsDn)
                    .HasMaxLength(250)
                    .HasColumnName("MS_DN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MsTm)
                    .HasMaxLength(20)
                    .HasColumnName("MS_TM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayDaoHan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_DAO_HAN");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HD");

                entity.Property(e => e.NgayHopdongSc)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HOPDONG_SC");

                entity.Property(e => e.NgayTt)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_TT");

                entity.Property(e => e.Ngayct)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYCT");

                entity.Property(e => e.Ngayctgs)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYCTGS");

                entity.Property(e => e.Ngaylo)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYLO");

                entity.Property(e => e.Nhacungcap)
                    .HasMaxLength(250)
                    .HasColumnName("NHACUNGCAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhasanxuat)
                    .HasMaxLength(250)
                    .HasColumnName("NHASANXUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhomkh)
                    .HasMaxLength(50)
                    .HasColumnName("NHOMKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NoidungSc)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG_SC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NvBan)
                    .HasMaxLength(250)
                    .HasColumnName("NV_BAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PtCk).HasColumnName("PT_CK");

                entity.Property(e => e.PtCk2).HasColumnName("PT_CK2");

                entity.Property(e => e.SlGc).HasColumnName("SL_GC");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoHopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HOPDONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoPc)
                    .HasMaxLength(10)
                    .HasColumnName("SO_PC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoPt)
                    .HasMaxLength(20)
                    .HasColumnName("SO_PT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soct)
                    .HasMaxLength(50)
                    .HasColumnName("SOCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoctN).HasColumnName("SOCT_N");

                entity.Property(e => e.SoctU)
                    .HasMaxLength(200)
                    .HasColumnName("SOCT_U")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soctgs)
                    .HasMaxLength(250)
                    .HasColumnName("SOCTGS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sokheuoc)
                    .HasMaxLength(50)
                    .HasColumnName("SOKHEUOC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SrHd)
                    .HasMaxLength(50)
                    .HasColumnName("SR_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SttBt).HasColumnName("STT_BT");

                entity.Property(e => e.SttSapxep).HasColumnName("STT_SAPXEP");

                entity.Property(e => e.SttTt).HasColumnName("STT_TT");

                entity.Property(e => e.TenTiepThi)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_TIEP_THI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenctSc)
                    .HasMaxLength(250)
                    .HasColumnName("TENCT_SC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtgt)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendvnt)
                    .HasMaxLength(250)
                    .HasColumnName("TENDVNT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendvtt)
                    .HasMaxLength(250)
                    .HasColumnName("TENDVTT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenhhIn)
                    .HasMaxLength(250)
                    .HasColumnName("TENHH_IN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(250)
                    .HasColumnName("TENKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenmausac)
                    .HasMaxLength(250)
                    .HasColumnName("TENMAUSAC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhomdt1)
                    .HasMaxLength(150)
                    .HasColumnName("TENNHOMDT1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tentknhco)
                    .HasMaxLength(250)
                    .HasColumnName("TENTKNHCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tentknhno)
                    .HasMaxLength(250)
                    .HasColumnName("TENTKNHNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenvung)
                    .HasMaxLength(250)
                    .HasColumnName("TENVUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenytcpno)
                    .HasMaxLength(250)
                    .HasColumnName("TENYTCPNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.ThangN).HasColumnName("THANG_N");

                entity.Property(e => e.Thoigiannhap)
                    .HasMaxLength(50)
                    .HasColumnName("THOIGIANNHAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thueeur).HasColumnName("THUEEUR");

                entity.Property(e => e.Thueusd).HasColumnName("THUEUSD");

                entity.Property(e => e.Thuevnd).HasColumnName("THUEVND");

                entity.Property(e => e.Tienhang).HasColumnName("TIENHANG");

                entity.Property(e => e.TkChietkhau)
                    .HasMaxLength(50)
                    .HasColumnName("TK_CHIETKHAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkXuatkho)
                    .HasMaxLength(50)
                    .HasColumnName("TK_XUATKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkco)
                    .HasMaxLength(50)
                    .HasColumnName("TKCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tknhco)
                    .HasMaxLength(250)
                    .HasColumnName("TKNHCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tknhno)
                    .HasMaxLength(250)
                    .HasColumnName("TKNHNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkno)
                    .HasMaxLength(50)
                    .HasColumnName("TKNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkthue)
                    .HasMaxLength(50)
                    .HasColumnName("TKTHUE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TnkUsd).HasColumnName("TNK_USD");

                entity.Property(e => e.TnkVnd).HasColumnName("TNK_VND");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TsGtgt)
                    .HasMaxLength(50)
                    .HasColumnName("TS_GTGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TsNk).HasColumnName("TS_NK");

                entity.Property(e => e.TtGc).HasColumnName("TT_GC");

                entity.Property(e => e.TtVc).HasColumnName("TT_VC");

                entity.Property(e => e.Tteur).HasColumnName("TTEUR");

                entity.Property(e => e.Ttmausac).HasColumnName("TTMAUSAC");

                entity.Property(e => e.Ttusd).HasColumnName("TTUSD");

                entity.Property(e => e.TtusdTt).HasColumnName("TTUSD_TT");

                entity.Property(e => e.Ttvnd).HasColumnName("TTVND");

                entity.Property(e => e.TtvndTt).HasColumnName("TTVND_TT");

                entity.Property(e => e.Tygia).HasColumnName("TYGIA");
            });

            modelBuilder.Entity<KtscBh>(entity =>
            {
                entity.HasKey(e => e.SttSc)
                    .HasName("PK__KTSC_BH__68343A95");

                entity.ToTable("KTSC_BH");

                entity.Property(e => e.SttSc).HasColumnName("STT_SC");

                entity.Property(e => e.Chietkhau1).HasColumnName("CHIETKHAU_1");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DgGc).HasColumnName("DG_GC");

                entity.Property(e => e.DgVc).HasColumnName("DG_VC");

                entity.Property(e => e.Dgvnd).HasColumnName("DGVND");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(250)
                    .HasColumnName("DIACHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diengiai)
                    .HasMaxLength(250)
                    .HasColumnName("DIENGIAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi1)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI_1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi2)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI_2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DonviCtu)
                    .HasMaxLength(53)
                    .HasColumnName("DONVI_CTU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hansudung)
                    .HasColumnType("datetime")
                    .HasColumnName("HANSUDUNG");

                entity.Property(e => e.HsqdDvt).HasColumnName("HSQD_DVT");

                entity.Property(e => e.IdChungtu).HasColumnName("ID_CHUNGTU");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoXuat)
                    .HasMaxLength(50)
                    .HasColumnName("LO_XUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Luong).HasColumnName("LUONG");

                entity.Property(e => e.Luong1).HasColumnName("LUONG_1");

                entity.Property(e => e.Luong2).HasColumnName("LUONG_2");

                entity.Property(e => e.LuongCtu).HasColumnName("LUONG_CTU");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaHhGc)
                    .HasMaxLength(50)
                    .HasColumnName("MA_HH_GC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaNvBan)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NV_BAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaTiepThi)
                    .HasMaxLength(50)
                    .HasColumnName("MA_TIEP_THI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaVung)
                    .HasMaxLength(50)
                    .HasColumnName("MA_VUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madmco)
                    .HasMaxLength(50)
                    .HasColumnName("MADMCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madonhang)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makh)
                    .HasMaxLength(50)
                    .HasColumnName("MAKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MsDn)
                    .HasMaxLength(250)
                    .HasColumnName("MS_DN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayDaoHan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_DAO_HAN");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HD");

                entity.Property(e => e.Ngayct)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYCT");

                entity.Property(e => e.Ngaylo)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYLO");

                entity.Property(e => e.Nguoilienhe)
                    .HasMaxLength(50)
                    .HasColumnName("NGUOILIENHE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhacungcap)
                    .HasMaxLength(250)
                    .HasColumnName("NHACUNGCAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhasanxuat)
                    .HasMaxLength(250)
                    .HasColumnName("NHASANXUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PtCk1).HasColumnName("PT_CK_1");

                entity.Property(e => e.PtCk2).HasColumnName("PT_CK_2");

                entity.Property(e => e.SlGc).HasColumnName("SL_GC");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soct)
                    .HasMaxLength(50)
                    .HasColumnName("SOCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SttBt).HasColumnName("STT_BT");

                entity.Property(e => e.TenTiepThi)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_TIEP_THI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenctSc)
                    .HasMaxLength(250)
                    .HasColumnName("TENCT_SC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(250)
                    .HasColumnName("TENKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ThanhtienDv1).HasColumnName("THANHTIEN_DV1");

                entity.Property(e => e.ThanhtienDv2).HasColumnName("THANHTIEN_DV2");

                entity.Property(e => e.ThanhtienDv3).HasColumnName("THANHTIEN_DV3");

                entity.Property(e => e.Thuevnd).HasColumnName("THUEVND");

                entity.Property(e => e.TkXuatkho)
                    .HasMaxLength(50)
                    .HasColumnName("TK_XUATKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TsGtgt)
                    .HasMaxLength(50)
                    .HasColumnName("TS_GTGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TtGc).HasColumnName("TT_GC");

                entity.Property(e => e.TtVc).HasColumnName("TT_VC");

                entity.Property(e => e.Ttvnd1).HasColumnName("TTVND_1");

                entity.Property(e => e.Ttvnd2).HasColumnName("TTVND_2");

                entity.Property(e => e.Ttvnd3).HasColumnName("TTVND_3");
            });

            modelBuilder.Entity<KtscCkDp>(entity =>
            {
                entity.HasKey(e => e.SttSc)
                    .HasName("PK__KTSC_CK_DP__207893B8");

                entity.ToTable("KTSC_CK_DP");

                entity.Property(e => e.SttSc).HasColumnName("STT_SC");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(20)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhichuCk)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU_CK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaDtCk1)
                    .HasMaxLength(50)
                    .HasColumnName("MA_DT_CK_1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaDtCk2)
                    .HasMaxLength(50)
                    .HasColumnName("MA_DT_CK_2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaDtCk3)
                    .HasMaxLength(50)
                    .HasColumnName("MA_DT_CK_3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madmco)
                    .HasMaxLength(50)
                    .HasColumnName("MADMCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HD");

                entity.Property(e => e.PtCk1).HasColumnName("PT_CK_1");

                entity.Property(e => e.PtCk2).HasColumnName("PT_CK_2");

                entity.Property(e => e.PtCk3).HasColumnName("PT_CK_3");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(20)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenDtCk1)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_DT_CK_1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenDtCk2)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_DT_CK_2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenDtCk3)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_DT_CK_3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TongCk).HasColumnName("TONG_CK");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TtCk1).HasColumnName("TT_CK_1");

                entity.Property(e => e.TtCk2).HasColumnName("TT_CK_2");

                entity.Property(e => e.TtCk3).HasColumnName("TT_CK_3");
            });

            modelBuilder.Entity<KtscNhapp>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__KTSC_NHAPPS__4A19C7C9");

                entity.ToTable("KTSC_NHAPPS");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Dgvnd).HasColumnName("DGVND");

                entity.Property(e => e.Luong).HasColumnName("LUONG");

                entity.Property(e => e.Madmco)
                    .HasMaxLength(50)
                    .HasColumnName("MADMCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madmno)
                    .HasMaxLength(50)
                    .HasColumnName("MADMNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkco)
                    .HasMaxLength(50)
                    .HasColumnName("TKCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkno)
                    .HasMaxLength(50)
                    .HasColumnName("TKNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ttvnd).HasColumnName("TTVND");
            });

            modelBuilder.Entity<Kttambarcode>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__KTTAMBARCODE__5497563C");

                entity.ToTable("KTTAMBARCODE");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .HasColumnName("BARCODE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ca)
                    .HasMaxLength(50)
                    .HasColumnName("CA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dacopy)
                    .HasMaxLength(1)
                    .HasColumnName("DACOPY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diachigiaohang)
                    .HasMaxLength(50)
                    .HasColumnName("DIACHIGIAOHANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(20)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gio).HasColumnName("GIO");

                entity.Property(e => e.IdChungtu).HasColumnName("ID_CHUNGTU");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(25)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makh)
                    .HasMaxLength(50)
                    .HasColumnName("MAKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngayct)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYCT");

                entity.Property(e => e.Nguoivanchuyen)
                    .HasMaxLength(50)
                    .HasColumnName("NGUOIVANCHUYEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhanvienban)
                    .HasMaxLength(50)
                    .HasColumnName("NHANVIENBAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Phut).HasColumnName("PHUT");

                entity.Property(e => e.SoctXe).HasColumnName("SOCT_XE");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Soxe)
                    .HasMaxLength(50)
                    .HasColumnName("SOXE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SttDonhang).HasColumnName("STT_DONHANG");

                entity.Property(e => e.SttScan).HasColumnName("STT_SCAN");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(255)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(50)
                    .HasColumnName("TENKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Kttk>(entity =>
            {
                entity.HasKey(e => e.Matk)
                    .HasName("PK__KTTK__0C11A858");

                entity.ToTable("KTTK");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Eurckco).HasColumnName("EURCKCO");

                entity.Property(e => e.Eurckno).HasColumnName("EURCKNO");

                entity.Property(e => e.Eurduco).HasColumnName("EURDUCO");

                entity.Property(e => e.Eurduno).HasColumnName("EURDUNO");

                entity.Property(e => e.Eurpsco).HasColumnName("EURPSCO");

                entity.Property(e => e.Eurpsno).HasColumnName("EURPSNO");

                entity.Property(e => e.Loaitien)
                    .HasMaxLength(10)
                    .HasColumnName("LOAITIEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MatkE)
                    .HasMaxLength(50)
                    .HasColumnName("MATK_E")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MatkKc)
                    .HasMaxLength(50)
                    .HasColumnName("MATK_KC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MatkMoi)
                    .HasMaxLength(50)
                    .HasColumnName("MATK_MOI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tentk)
                    .HasMaxLength(250)
                    .HasColumnName("TENTK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TentkE)
                    .HasMaxLength(100)
                    .HasColumnName("TENTK_E")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkChietkhau)
                    .HasMaxLength(50)
                    .HasColumnName("TK_CHIETKHAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkGiavon)
                    .HasMaxLength(50)
                    .HasColumnName("TK_GIAVON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkTralai)
                    .HasMaxLength(50)
                    .HasColumnName("TK_TRALAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Usdckco).HasColumnName("USDCKCO");

                entity.Property(e => e.Usdckno).HasColumnName("USDCKNO");

                entity.Property(e => e.Usdduco).HasColumnName("USDDUCO");

                entity.Property(e => e.Usdduno).HasColumnName("USDDUNO");

                entity.Property(e => e.Usdpsco).HasColumnName("USDPSCO");

                entity.Property(e => e.UsdpscoLk).HasColumnName("USDPSCO_LK");

                entity.Property(e => e.Usdpsno).HasColumnName("USDPSNO");

                entity.Property(e => e.UsdpsnoLk).HasColumnName("USDPSNO_LK");

                entity.Property(e => e.Vndckco).HasColumnName("VNDCKCO");

                entity.Property(e => e.Vndckno).HasColumnName("VNDCKNO");

                entity.Property(e => e.Vndduco).HasColumnName("VNDDUCO");

                entity.Property(e => e.Vndduno).HasColumnName("VNDDUNO");

                entity.Property(e => e.Vndpsco).HasColumnName("VNDPSCO");

                entity.Property(e => e.VndpscoLk).HasColumnName("VNDPSCO_LK");

                entity.Property(e => e.Vndpsno).HasColumnName("VNDPSNO");

                entity.Property(e => e.VndpsnoLk).HasColumnName("VNDPSNO_LK");
            });

            modelBuilder.Entity<Kttscd>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.Mats })
                    .HasName("PK__KTTSCD__3687D068");

                entity.ToTable("KTTSCD");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Mats)
                    .HasMaxLength(50)
                    .HasColumnName("MATS");

                entity.Property(e => e.CoKh)
                    .HasMaxLength(50)
                    .HasColumnName("CO_KH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dtsudung)
                    .HasMaxLength(255)
                    .HasColumnName("DTSUDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gtconlai).HasColumnName("GTCONLAI");

                entity.Property(e => e.GtconlaiDk).HasColumnName("GTCONLAI_DK");

                entity.Property(e => e.GtconlaiUsd).HasColumnName("GTCONLAI_USD");

                entity.Property(e => e.Kh1thang).HasColumnName("KH1THANG");

                entity.Property(e => e.Kh1thangUsd).HasColumnName("KH1THANG_USD");

                entity.Property(e => e.KhThangnay).HasColumnName("KH_THANGNAY");

                entity.Property(e => e.KhThangnayUsd).HasColumnName("KH_THANGNAY_USD");

                entity.Property(e => e.Kyhieu)
                    .HasMaxLength(50)
                    .HasColumnName("KYHIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LuykeKh).HasColumnName("LUYKE_KH");

                entity.Property(e => e.LuykeKhDk).HasColumnName("LUYKE_KH_DK");

                entity.Property(e => e.LuykeKhThangcuoi).HasColumnName("LUYKE_KH_THANGCUOI");

                entity.Property(e => e.LuykeKhUsd).HasColumnName("LUYKE_KH_USD");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(100)
                    .HasColumnName("MA_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnco)
                    .HasMaxLength(200)
                    .HasColumnName("MADTPNCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnno)
                    .HasMaxLength(200)
                    .HasColumnName("MADTPNNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpno)
                    .HasMaxLength(100)
                    .HasColumnName("MAYTCPNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nam).HasColumnName("NAM");

                entity.Property(e => e.Ngayban)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYBAN");

                entity.Property(e => e.Ngaymua)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYMUA");

                entity.Property(e => e.Ngaytrichkh)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYTRICHKH");

                entity.Property(e => e.Nguyengia).HasColumnName("NGUYENGIA");

                entity.Property(e => e.NguyengiaDk).HasColumnName("NGUYENGIA_DK");

                entity.Property(e => e.NguyengiaUsd).HasColumnName("NGUYENGIA_USD");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Tents)
                    .HasMaxLength(255)
                    .HasColumnName("TENTS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thoigiankh).HasColumnName("THOIGIANKH");

                entity.Property(e => e.Tkcp)
                    .HasMaxLength(50)
                    .HasColumnName("TKCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkhm)
                    .HasMaxLength(50)
                    .HasColumnName("TKHM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkts)
                    .HasMaxLength(50)
                    .HasColumnName("TKTS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tygia).HasColumnName("TYGIA");

                entity.Property(e => e.Vndtangnguyengia).HasColumnName("VNDTANGNGUYENGIA");
            });

            modelBuilder.Entity<Kttsdh>(entity =>
            {
                entity.HasKey(e => new { e.Kybaocao, e.Stt })
                    .HasName("PK__KTTSDH__3592E0D8");

                entity.ToTable("KTTSDH");

                entity.Property(e => e.Kybaocao)
                    .HasMaxLength(50)
                    .HasColumnName("KYBAOCAO");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayDaoHan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_DAO_HAN");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HD");

                entity.Property(e => e.Ngayct)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYCT");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soct)
                    .HasMaxLength(50)
                    .HasColumnName("SOCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SrHd)
                    .HasMaxLength(50)
                    .HasColumnName("SR_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TuoiNo).HasColumnName("TUOI_NO");

                entity.Property(e => e.Vndckco).HasColumnName("VNDCKCO");

                entity.Property(e => e.Vndckno).HasColumnName("VNDCKNO");
            });

            modelBuilder.Entity<Kttyle>(entity =>
            {
                entity.HasKey(e => e.MaThanhpham)
                    .HasName("PK__KTTYLE__68736660");

                entity.ToTable("KTTYLE");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Giathanh).HasColumnName("GIATHANH");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.SlTpQd).HasColumnName("SL_TP_QD");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tyle).HasColumnName("TYLE");
            });

            modelBuilder.Entity<KttyleGd>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.MaThanhpham, e.Giaidoan })
                    .HasName("PK__KTTYLE_GD__300FDD03");

                entity.ToTable("KTTYLE_GD");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Giathanh).HasColumnName("GIATHANH");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.SlTpQd).HasColumnName("SL_TP_QD");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tyle).HasColumnName("TYLE");
            });

            modelBuilder.Entity<KttyleGdYtcp>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.MaThanhpham, e.Giaidoan, e.Maytcp })
                    .HasName("PK__KTTYLE_GD_YTCP__3999473D");

                entity.ToTable("KTTYLE_GD_YTCP");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.Maytcp)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCP");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Giathanh).HasColumnName("GIATHANH");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.SlTpQd).HasColumnName("SL_TP_QD");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenytcp)
                    .HasMaxLength(250)
                    .HasColumnName("TENYTCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tyle).HasColumnName("TYLE");
            });

            modelBuilder.Entity<KttylePb>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.MaThanhpham })
                    .HasName("PK__KTTYLE_PB__286EBB3B");

                entity.ToTable("KTTYLE_PB");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tyle).HasColumnName("TYLE");
            });

            modelBuilder.Entity<KttylePbCt>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.MaCt })
                    .HasName("PK__KTTYLE_PB_CT__6C59D134");

                entity.ToTable("KTTYLE_PB_CT");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct)
                    .HasMaxLength(250)
                    .HasColumnName("TENCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tyle).HasColumnName("TYLE");
            });

            modelBuilder.Entity<KttylePbcpCongtrinh>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.Matk, e.MaCt, e.Maytcp, e.Mabpsx })
                    .HasName("PK__KTTYLE_PBCP_CONG__0AA94E2A");

                entity.ToTable("KTTYLE_PBCP_CONGTRINH");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT");

                entity.Property(e => e.Maytcp)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCP");

                entity.Property(e => e.Mabpsx)
                    .HasMaxLength(50)
                    .HasColumnName("MABPSX");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(250)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenbpsx)
                    .HasMaxLength(250)
                    .HasColumnName("TENBPSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct)
                    .HasMaxLength(250)
                    .HasColumnName("TENCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tentk)
                    .HasMaxLength(250)
                    .HasColumnName("TENTK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenytcp)
                    .HasMaxLength(250)
                    .HasColumnName("TENYTCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tyle).HasColumnName("TYLE");
            });

            modelBuilder.Entity<KttyleYtcp>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.Maytcp, e.MaThanhpham })
                    .HasName("PK__KTTYLE_YTCP__77616F8C");

                entity.ToTable("KTTYLE_YTCP");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Maytcp)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCP");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenytcp)
                    .HasMaxLength(250)
                    .HasColumnName("TENYTCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tyle).HasColumnName("TYLE");
            });

            modelBuilder.Entity<Ktuser>(entity =>
            {
                entity.HasKey(e => e.MaUser)
                    .HasName("PK__KTUSER__0603C947");

                entity.ToTable("KTUSER");

                entity.Property(e => e.MaUser)
                    .HasMaxLength(50)
                    .HasColumnName("MA_USER");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matkhau)
                    .HasMaxLength(50)
                    .HasColumnName("MATKHAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MatkhauMoi)
                    .HasMaxLength(50)
                    .HasColumnName("MATKHAU_MOI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenUser)
                    .HasMaxLength(50)
                    .HasColumnName("TEN_USER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ktytcp>(entity =>
            {
                entity.HasKey(e => e.Maytcp)
                    .HasName("PK__KTYTCP__1550F9CF");

                entity.ToTable("KTYTCP");

                entity.Property(e => e.Maytcp)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCP");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdPhanbo).HasColumnName("ID_PHANBO");

                entity.Property(e => e.Manhom1)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manhom2)
                    .HasMaxLength(50)
                    .HasColumnName("MANHOM2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SttYtcp)
                    .HasMaxLength(50)
                    .HasColumnName("STT_YTCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhom1)
                    .HasMaxLength(250)
                    .HasColumnName("TENNHOM1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennhom2)
                    .HasMaxLength(250)
                    .HasColumnName("TENNHOM2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenytcp)
                    .HasMaxLength(255)
                    .HasColumnName("TENYTCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenytcpE)
                    .HasMaxLength(255)
                    .HasColumnName("TENYTCP_E")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Usdckco).HasColumnName("USDCKCO");

                entity.Property(e => e.Usdckno).HasColumnName("USDCKNO");

                entity.Property(e => e.Usdduco).HasColumnName("USDDUCO");

                entity.Property(e => e.Usdduno).HasColumnName("USDDUNO");

                entity.Property(e => e.Usdpsco).HasColumnName("USDPSCO");

                entity.Property(e => e.UsdpscoLk).HasColumnName("USDPSCO_LK");

                entity.Property(e => e.Usdpsno).HasColumnName("USDPSNO");

                entity.Property(e => e.UsdpsnoLk).HasColumnName("USDPSNO_LK");

                entity.Property(e => e.Vndckco).HasColumnName("VNDCKCO");

                entity.Property(e => e.Vndckno).HasColumnName("VNDCKNO");

                entity.Property(e => e.Vndduco).HasColumnName("VNDDUCO");

                entity.Property(e => e.Vndduno).HasColumnName("VNDDUNO");

                entity.Property(e => e.Vndpsco).HasColumnName("VNDPSCO");

                entity.Property(e => e.VndpscoLk).HasColumnName("VNDPSCO_LK");

                entity.Property(e => e.Vndpsno).HasColumnName("VNDPSNO");

                entity.Property(e => e.VndpsnoLk).HasColumnName("VNDPSNO_LK");
            });

            modelBuilder.Entity<NibotChitiet>(entity =>
            {
                entity.HasKey(e => e.SttSc)
                    .HasName("PK__NIBOT_CHITIET__3667D4D7");

                entity.ToTable("NIBOT_CHITIET");

                entity.Property(e => e.SttSc).HasColumnName("STT_SC");

                entity.Property(e => e.Chietkhau).HasColumnName("CHIETKHAU");

                entity.Property(e => e.Chietkhau2).HasColumnName("CHIETKHAU2");

                entity.Property(e => e.ChietkhauUsd).HasColumnName("CHIETKHAU_USD");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgusd).HasColumnName("DGUSD");

                entity.Property(e => e.Dgvnd).HasColumnName("DGVND");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(250)
                    .HasColumnName("DIACHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DiachiNgd)
                    .HasMaxLength(250)
                    .HasColumnName("DIACHI_NGD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diengiai)
                    .HasMaxLength(250)
                    .HasColumnName("DIENGIAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(20)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi1)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI_1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi2)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI_2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DonviCtu)
                    .HasMaxLength(20)
                    .HasColumnName("DONVI_CTU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hansudung)
                    .HasColumnType("datetime")
                    .HasColumnName("HANSUDUNG");

                entity.Property(e => e.Hdvat)
                    .HasMaxLength(50)
                    .HasColumnName("HDVAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HsqdDvt).HasColumnName("HSQD_DVT");

                entity.Property(e => e.Httt)
                    .HasMaxLength(50)
                    .HasColumnName("HTTT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdChungtu).HasColumnName("ID_CHUNGTU");

                entity.Property(e => e.IdNghiepvu)
                    .HasMaxLength(20)
                    .HasColumnName("ID_NGHIEPVU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Invoi)
                    .HasMaxLength(50)
                    .HasColumnName("INVOI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Khachhang)
                    .HasMaxLength(250)
                    .HasColumnName("KHACHHANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KhmHd)
                    .HasMaxLength(50)
                    .HasColumnName("KHM_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KieuChungtu)
                    .HasMaxLength(50)
                    .HasColumnName("KIEU_CHUNGTU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kyhieu)
                    .HasMaxLength(50)
                    .HasColumnName("KYHIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoNhap)
                    .HasMaxLength(50)
                    .HasColumnName("LO_NHAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoXuat)
                    .HasMaxLength(50)
                    .HasColumnName("LO_XUAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Luong).HasColumnName("LUONG");

                entity.Property(e => e.Luong1).HasColumnName("LUONG_1");

                entity.Property(e => e.Luong2).HasColumnName("LUONG_2");

                entity.Property(e => e.LuongCtu).HasColumnName("LUONG_CTU");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(50)
                    .HasColumnName("MA_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaNvBan)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NV_BAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaTt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_TT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madmco)
                    .HasMaxLength(50)
                    .HasColumnName("MADMCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madmno)
                    .HasMaxLength(50)
                    .HasColumnName("MADMNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnco)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnno)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makh)
                    .HasMaxLength(50)
                    .HasColumnName("MAKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mangd)
                    .HasMaxLength(50)
                    .HasColumnName("MANGD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matttu)
                    .HasMaxLength(50)
                    .HasColumnName("MATTTU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpco)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCPCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpno)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCPNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .HasColumnName("MODEL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MsDn)
                    .HasMaxLength(50)
                    .HasColumnName("MS_DN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MsTm)
                    .HasMaxLength(20)
                    .HasColumnName("MS_TM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HD");

                entity.Property(e => e.Ngayct)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYCT");

                entity.Property(e => e.Ngaylo)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYLO");

                entity.Property(e => e.NvBan)
                    .HasMaxLength(250)
                    .HasColumnName("NV_BAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PtCk).HasColumnName("PT_CK");

                entity.Property(e => e.PtCk2).HasColumnName("PT_CK2");

                entity.Property(e => e.Sguid)
                    .HasMaxLength(50)
                    .HasColumnName("SGUID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoHopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HOPDONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soct)
                    .HasMaxLength(50)
                    .HasColumnName("SOCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SrHd)
                    .HasMaxLength(50)
                    .HasColumnName("SR_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SttBt).HasColumnName("STT_BT");

                entity.Property(e => e.SttSapxep).HasColumnName("STT_SAPXEP");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(250)
                    .HasColumnName("TENKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenytcpno)
                    .HasMaxLength(250)
                    .HasColumnName("TENYTCPNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.ThangN).HasColumnName("THANG_N");

                entity.Property(e => e.Thueusd).HasColumnName("THUEUSD");

                entity.Property(e => e.Thuevnd).HasColumnName("THUEVND");

                entity.Property(e => e.TkChietkhau)
                    .HasMaxLength(50)
                    .HasColumnName("TK_CHIETKHAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkXuatkho)
                    .HasMaxLength(50)
                    .HasColumnName("TK_XUATKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkco)
                    .HasMaxLength(50)
                    .HasColumnName("TKCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkno)
                    .HasMaxLength(50)
                    .HasColumnName("TKNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkthue)
                    .HasMaxLength(50)
                    .HasColumnName("TKTHUE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TnkUsd).HasColumnName("TNK_USD");

                entity.Property(e => e.TnkVnd).HasColumnName("TNK_VND");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TsGtgt)
                    .HasMaxLength(50)
                    .HasColumnName("TS_GTGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TsNk).HasColumnName("TS_NK");

                entity.Property(e => e.Ttusd).HasColumnName("TTUSD");

                entity.Property(e => e.TtusdTt).HasColumnName("TTUSD_TT");

                entity.Property(e => e.Ttvnd).HasColumnName("TTVND");

                entity.Property(e => e.TtvndTt).HasColumnName("TTVND_TT");

                entity.Property(e => e.Tygia).HasColumnName("TYGIA");
            });

            modelBuilder.Entity<Quyensd>(entity =>
            {
                entity.HasKey(e => new { e.Mauser, e.Tenbang })
                    .HasName("PK__QUYENSD__0702DA78");

                entity.ToTable("QUYENSD");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER");

                entity.Property(e => e.Tenbang)
                    .HasMaxLength(50)
                    .HasColumnName("TENBANG");

                entity.Property(e => e.CoAncot)
                    .HasMaxLength(5)
                    .HasColumnName("CO_ANCOT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dieukien)
                    .HasMaxLength(255)
                    .HasColumnName("DIEUKIEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dscot)
                    .HasMaxLength(255)
                    .HasColumnName("DSCOT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DscotAn)
                    .HasMaxLength(250)
                    .HasColumnName("DSCOT_AN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sddatauserkhac)
                    .HasMaxLength(10)
                    .HasColumnName("SDDATAUSERKHAC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenUser)
                    .HasMaxLength(50)
                    .HasColumnName("TEN_USER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Sodugt03>(entity =>
            {
                entity.HasKey(e => e.Thang)
                    .HasName("PK__SODUGT03__46693276");

                entity.ToTable("SODUGT03");

                entity.Property(e => e.Thang).HasColumnName("THANG");
            });

            modelBuilder.Entity<TablePk>(entity =>
            {
                entity.HasKey(e => new { e.Tenbang, e.Khoachinh })
                    .HasName("PK__TABLE_PK__2E91A8E5");

                entity.ToTable("TABLE_PK");

                entity.Property(e => e.Tenbang)
                    .HasMaxLength(100)
                    .HasColumnName("TENBANG");

                entity.Property(e => e.Khoachinh)
                    .HasMaxLength(100)
                    .HasColumnName("KHOACHINH");
            });

            modelBuilder.Entity<TblCtLsx>(entity =>
            {
                entity.HasKey(e => new { e.IdChungtu, e.SttMh })
                    .HasName("PK__TBL_CT_LSX__3C74E891");

                entity.ToTable("TBL_CT_LSX");

                entity.Property(e => e.IdChungtu).HasColumnName("ID_CHUNGTU");

                entity.Property(e => e.SttMh).HasColumnName("STT_MH");

                entity.Property(e => e.CoDinhMuc)
                    .HasMaxLength(10)
                    .HasColumnName("CO_DINH_MUC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DvtTp)
                    .HasMaxLength(15)
                    .HasColumnName("DVT_TP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhichuLsx)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU_LSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhichuMh)
                    .HasMaxLength(50)
                    .HasColumnName("GHICHU_MH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(20)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaKhsx)
                    .HasMaxLength(50)
                    .HasColumnName("MA_KHSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaLsx)
                    .HasMaxLength(50)
                    .HasColumnName("MA_LSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaTp)
                    .HasMaxLength(50)
                    .HasColumnName("MA_TP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mabophan)
                    .HasMaxLength(50)
                    .HasColumnName("MABOPHAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madonhang)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayKhsx)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_KHSX");

                entity.Property(e => e.NgayLsx)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_LSX");

                entity.Property(e => e.Ngaydonhang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYDONHANG");

                entity.Property(e => e.Ngaygiaohang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYGIAOHANG");

                entity.Property(e => e.Ngayhethan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYHETHAN");

                entity.Property(e => e.NhmTen)
                    .HasMaxLength(250)
                    .HasColumnName("NHM_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhDiachi)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_DIACHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhDienthoai)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_DIENTHOAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhEmail)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_EMAIL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhFax)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_FAX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMa)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMst)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MST")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTenlienhe)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_TENLIENHE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NoidungLsx)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG_LSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.SttLsx).HasColumnName("STT_LSX");

                entity.Property(e => e.TenTp)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_TP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonkhoTp).HasColumnName("TONKHO_TP");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblCtYcxk>(entity =>
            {
                entity.HasKey(e => new { e.IdChungtu, e.IdHh })
                    .HasName("PK__TBL_CT_YCXK__20CCCE1C");

                entity.ToTable("TBL_CT_YCXK");

                entity.Property(e => e.IdChungtu).HasColumnName("ID_CHUNGTU");

                entity.Property(e => e.IdHh).HasColumnName("ID_HH");

                entity.Property(e => e.CoDinhMuc)
                    .HasMaxLength(10)
                    .HasColumnName("CO_DINH_MUC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DvtNvl)
                    .HasMaxLength(15)
                    .HasColumnName("DVT_NVL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DvtTp)
                    .HasMaxLength(15)
                    .HasColumnName("DVT_TP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhichuLsx)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU_LSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhichuMh)
                    .HasMaxLength(50)
                    .HasColumnName("GHICHU_MH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(20)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaKhsx)
                    .HasMaxLength(50)
                    .HasColumnName("MA_KHSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaLsx)
                    .HasMaxLength(50)
                    .HasColumnName("MA_LSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaNvl)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NVL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaTp)
                    .HasMaxLength(50)
                    .HasColumnName("MA_TP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madonhang)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makh)
                    .HasMaxLength(50)
                    .HasColumnName("MAKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayKhsx)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_KHSX");

                entity.Property(e => e.NgayLsx)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_LSX");

                entity.Property(e => e.Ngaydonhang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYDONHANG");

                entity.Property(e => e.Ngaygiaohang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYGIAOHANG");

                entity.Property(e => e.Ngayhethan)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYHETHAN");

                entity.Property(e => e.NoidungLsx)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG_LSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SlNvl).HasColumnName("SL_NVL");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.SttLsx).HasColumnName("STT_LSX");

                entity.Property(e => e.TenNvl)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_NVL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenTp)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_TP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(250)
                    .HasColumnName("TENKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonkhoNvl).HasColumnName("TONKHO_NVL");

                entity.Property(e => e.TonkhoTp).HasColumnName("TONKHO_TP");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblDmddcongtrinhSl>(entity =>
            {
                entity.HasKey(e => new { e.MaCt, e.Matk, e.TkChiphi, e.Maytcp, e.Madm })
                    .HasName("PK__TBL_DMDDCONGTRIN__0AFD888E");

                entity.ToTable("TBL_DMDDCONGTRINH_SL");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.TkChiphi)
                    .HasMaxLength(50)
                    .HasColumnName("TK_CHIPHI");

                entity.Property(e => e.Maytcp)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCP");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgxuat).HasColumnName("DGXUAT");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(255)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kyhieu)
                    .HasMaxLength(50)
                    .HasColumnName("KYHIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LkCkGt).HasColumnName("LK_CK_GT");

                entity.Property(e => e.LkCkSl).HasColumnName("LK_CK_SL");

                entity.Property(e => e.LkDkGt).HasColumnName("LK_DK_GT");

                entity.Property(e => e.LkDkSl).HasColumnName("LK_DK_SL");

                entity.Property(e => e.NhapT).HasColumnName("NHAP_T");

                entity.Property(e => e.Quycach)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct)
                    .HasMaxLength(255)
                    .HasColumnName("TENCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(255)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonCk).HasColumnName("TON_CK");

                entity.Property(e => e.TonT).HasColumnName("TON_T");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VndnhapT).HasColumnName("VNDNHAP_T");

                entity.Property(e => e.VndtonCk).HasColumnName("VNDTON_CK");

                entity.Property(e => e.VndtonT).HasColumnName("VNDTON_T");

                entity.Property(e => e.VndxuatT).HasColumnName("VNDXUAT_T");

                entity.Property(e => e.XuatT).HasColumnName("XUAT_T");
            });

            modelBuilder.Entity<TblDmdtcongtrinh>(entity =>
            {
                entity.HasKey(e => new { e.Idc, e.SttBt })
                    .HasName("PK__TBL_DMDTCONGTRIN__68536ACF");

                entity.ToTable("TBL_DMDTCONGTRINH");

                entity.Property(e => e.Idc)
                    .HasMaxLength(50)
                    .HasColumnName("IDC");

                entity.Property(e => e.SttBt).HasColumnName("STT_BT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgdt).HasColumnName("DGDT");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaHm)
                    .HasMaxLength(50)
                    .HasColumnName("MA_HM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manvl)
                    .HasMaxLength(50)
                    .HasColumnName("MANVL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcp)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sldt).HasColumnName("SLDT");

                entity.Property(e => e.SttSs).HasColumnName("STT_SS");

                entity.Property(e => e.Tenct)
                    .HasMaxLength(250)
                    .HasColumnName("TENCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenhm)
                    .HasMaxLength(250)
                    .HasColumnName("TENHM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tennvl)
                    .HasMaxLength(250)
                    .HasColumnName("TENNVL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenytcp)
                    .HasMaxLength(250)
                    .HasColumnName("TENYTCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ttdt).HasColumnName("TTDT");
            });

            modelBuilder.Entity<TblDsbpKqkd>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__TBL_DSBP_KQKD__703F70B1");

                entity.ToTable("TBL_DSBP_KQKD");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mabophan)
                    .HasMaxLength(50)
                    .HasColumnName("MABOPHAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenbophan)
                    .HasMaxLength(250)
                    .HasColumnName("TENBOPHAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblDsctKqkd>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__TBL_DSCT_KQKD__76EC6E40");

                entity.ToTable("TBL_DSCT_KQKD");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NhomCt)
                    .HasMaxLength(50)
                    .HasColumnName("NHOM_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblKehoachquetmavach>(entity =>
            {
                entity.ToTable("TBL_KEHOACHQUETMAVACH");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ca)
                    .HasMaxLength(50)
                    .HasColumnName("CA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Daquetxong)
                    .HasMaxLength(5)
                    .HasColumnName("DAQUETXONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diachigiaohang)
                    .HasMaxLength(50)
                    .HasColumnName("DIACHIGIAOHANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(25)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpn)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makh)
                    .HasMaxLength(50)
                    .HasColumnName("MAKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngayct)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYCT");

                entity.Property(e => e.Ngayos)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYOS");

                entity.Property(e => e.Nguoivanchuyen)
                    .HasMaxLength(50)
                    .HasColumnName("NGUOIVANCHUYEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhanvienban)
                    .HasMaxLength(50)
                    .HasColumnName("NHANVIENBAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soct).HasColumnName("SOCT");

                entity.Property(e => e.SoctXe).HasColumnName("SOCT_XE");

                entity.Property(e => e.Soxe)
                    .HasMaxLength(50)
                    .HasColumnName("SOXE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SttDonhang).HasColumnName("STT_DONHANG");

                entity.Property(e => e.SttSapxep).HasColumnName("STT_SAPXEP");

                entity.Property(e => e.Tendtpn)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTPN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(50)
                    .HasColumnName("TENKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tongsoluong).HasColumnName("TONGSOLUONG");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblKtddcongtrinhSl>(entity =>
            {
                entity.HasKey(e => new { e.MaCt, e.Matk, e.TkChiphi, e.Maytcp, e.Madm })
                    .HasName("PK__TBL_KTDDCONGTRIN__20ECC9AD");

                entity.ToTable("TBL_KTDDCONGTRINH_SL");

                entity.Property(e => e.MaCt)
                    .HasMaxLength(50)
                    .HasColumnName("MA_CT");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.TkChiphi)
                    .HasMaxLength(50)
                    .HasColumnName("TK_CHIPHI");

                entity.Property(e => e.Maytcp)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCP");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgxuat).HasColumnName("DGXUAT");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(255)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kyhieu)
                    .HasMaxLength(50)
                    .HasColumnName("KYHIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LkCkGt).HasColumnName("LK_CK_GT");

                entity.Property(e => e.LkCkSl).HasColumnName("LK_CK_SL");

                entity.Property(e => e.LkDkGt).HasColumnName("LK_DK_GT");

                entity.Property(e => e.LkDkSl).HasColumnName("LK_DK_SL");

                entity.Property(e => e.NhapT).HasColumnName("NHAP_T");

                entity.Property(e => e.Quycach)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenct)
                    .HasMaxLength(255)
                    .HasColumnName("TENCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(255)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonCk).HasColumnName("TON_CK");

                entity.Property(e => e.TonT).HasColumnName("TON_T");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VndnhapT).HasColumnName("VNDNHAP_T");

                entity.Property(e => e.VndtonCk).HasColumnName("VNDTON_CK");

                entity.Property(e => e.VndtonT).HasColumnName("VNDTON_T");

                entity.Property(e => e.VndxuatT).HasColumnName("VNDXUAT_T");

                entity.Property(e => e.XuatT).HasColumnName("XUAT_T");
            });

            modelBuilder.Entity<TblKyhieumauhoadon>(entity =>
            {
                entity.ToTable("TBL_KYHIEUMAUHOADON");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblP2d>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__TblP2D__1A35AA7D");

                entity.ToTable("TblP2D");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Chitieu)
                    .HasMaxLength(500)
                    .HasColumnName("CHITIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(10)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Giatri)
                    .HasMaxLength(500)
                    .HasColumnName("GIATRI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblTangsochungtu>(entity =>
            {
                entity.HasKey(e => e.SttSc)
                    .HasName("PK__TBL_TANGSOCHUNGT__058F9352");

                entity.ToTable("TBL_TANGSOCHUNGTU");

                entity.Property(e => e.SttSc).HasColumnName("STT_SC");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngayct)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYCT");

                entity.Property(e => e.Nguid)
                    .HasMaxLength(50)
                    .HasColumnName("NGUID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soct).HasColumnName("SOCT");
            });

            modelBuilder.Entity<TblTangt>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__TBL_TANGTS__7D996BCF");

                entity.ToTable("TBL_TANGTS");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Danhdau).HasColumnName("DANHDAU");

                entity.Property(e => e.Kh1thangUsd).HasColumnName("KH1THANG_USD");

                entity.Property(e => e.Kh1thangUsdCu).HasColumnName("KH1THANG_USD_CU");

                entity.Property(e => e.Kh1thangVnd).HasColumnName("KH1THANG_VND");

                entity.Property(e => e.Kh1thangVndCu).HasColumnName("KH1THANG_VND_CU");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mats)
                    .HasMaxLength(50)
                    .HasColumnName("MATS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nam).HasColumnName("NAM");

                entity.Property(e => e.NgayHd)
                    .HasMaxLength(50)
                    .HasColumnName("NGAY_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngayct)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYCT");

                entity.Property(e => e.NguyengiatangUsd).HasColumnName("NGUYENGIATANG_USD");

                entity.Property(e => e.NguyengiatangUsdCu).HasColumnName("NGUYENGIATANG_USD_CU");

                entity.Property(e => e.NguyengiatangVnd).HasColumnName("NGUYENGIATANG_VND");

                entity.Property(e => e.NguyengiatangVndCu).HasColumnName("NGUYENGIATANG_VND_CU");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soct)
                    .HasMaxLength(50)
                    .HasColumnName("SOCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SrHd)
                    .HasMaxLength(50)
                    .HasColumnName("SR_HD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tents)
                    .HasMaxLength(255)
                    .HasColumnName("TENTS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Trangdau).HasColumnName("TRANGDAU");

                entity.Property(e => e.Ttvnd).HasColumnName("TTVND");
            });

            modelBuilder.Entity<TblXkdinhmuctam>(entity =>
            {
                entity.HasKey(e => e.SttSc)
                    .HasName("PK__TBL_XKDINHMUCTAM__0B486CA8");

                entity.ToTable("TBL_XKDINHMUCTAM");

                entity.Property(e => e.SttSc).HasColumnName("STT_SC");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgvnd).HasColumnName("DGVND");

                entity.Property(e => e.Diengiai)
                    .HasMaxLength(250)
                    .HasColumnName("DIENGIAI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(20)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdChungtu).HasColumnName("ID_CHUNGTU");

                entity.Property(e => e.IdNghiepvu)
                    .HasMaxLength(20)
                    .HasColumnName("ID_NGHIEPVU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kguid)
                    .HasMaxLength(50)
                    .HasColumnName("KGUID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kyduyet)
                    .HasMaxLength(10)
                    .HasColumnName("KYDUYET")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kyhieu)
                    .HasMaxLength(50)
                    .HasColumnName("KYHIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lenhsx)
                    .HasMaxLength(50)
                    .HasColumnName("LENHSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Luong).HasColumnName("LUONG");

                entity.Property(e => e.Mabpsx)
                    .HasMaxLength(50)
                    .HasColumnName("MABPSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madmco)
                    .HasMaxLength(50)
                    .HasColumnName("MADMCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madmno)
                    .HasMaxLength(50)
                    .HasColumnName("MADMNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madonhang)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnco)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnno)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makh)
                    .HasMaxLength(50)
                    .HasColumnName("MAKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpco)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCPCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcpno)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCPNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngayct)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYCT");

                entity.Property(e => e.Soct)
                    .HasMaxLength(50)
                    .HasColumnName("SOCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SttBt).HasColumnName("STT_BT");

                entity.Property(e => e.SttSapxep).HasColumnName("STT_SAPXEP");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(250)
                    .HasColumnName("TENKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Tkco)
                    .HasMaxLength(50)
                    .HasColumnName("TKCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tkno)
                    .HasMaxLength(50)
                    .HasColumnName("TKNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ttvnd).HasColumnName("TTVND");
            });

            modelBuilder.Entity<TblXmlDmhh>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__TBL_XML_DMHH__1388ACEE");

                entity.ToTable("TBL_XML_DMHH");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Tblkehoachsanxuatchitiet>(entity =>
            {
                entity.ToTable("TBLKEHOACHSANXUATCHITIET");

                entity.Property(e => e.Id)
                    .HasMaxLength(12)
                    .HasColumnName("ID");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt1)
                    .HasMaxLength(12)
                    .HasColumnName("DVT1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt2)
                    .HasMaxLength(12)
                    .HasColumnName("DVT2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt3)
                    .HasMaxLength(12)
                    .HasColumnName("DVT3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhichuMh)
                    .HasMaxLength(150)
                    .HasColumnName("GHICHU_MH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ghichukhsx)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHUKHSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kguid)
                    .HasMaxLength(50)
                    .HasColumnName("KGUID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kyhieukhsx)
                    .HasMaxLength(50)
                    .HasColumnName("KYHIEUKHSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mabpsx)
                    .HasMaxLength(50)
                    .HasColumnName("MABPSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madonhangban)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANGBAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madonhangmua)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANGMUA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makhsx)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matp)
                    .HasMaxLength(50)
                    .HasColumnName("MATP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngaybatdau)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYBATDAU");

                entity.Property(e => e.Ngayketthuc)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYKETTHUC");

                entity.Property(e => e.Ngaynhapkhsx)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYNHAPKHSX");

                entity.Property(e => e.NmhDiachi)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_DIACHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMa)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTen)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quycach1)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quycach2)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quycach3)
                    .HasMaxLength(50)
                    .HasColumnName("QUYCACH3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soluong1).HasColumnName("SOLUONG1");

                entity.Property(e => e.Soluong2).HasColumnName("SOLUONG2");

                entity.Property(e => e.Soluong3).HasColumnName("SOLUONG3");

                entity.Property(e => e.SttMh).HasColumnName("STT_MH");

                entity.Property(e => e.Sttkhsx).HasColumnName("STTKHSX");

                entity.Property(e => e.Tenbpsx)
                    .HasMaxLength(250)
                    .HasColumnName("TENBPSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tentp)
                    .HasMaxLength(250)
                    .HasColumnName("TENTP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonCk).HasColumnName("TON_CK");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Tblkehoachsanxuattonghop>(entity =>
            {
                entity.HasKey(e => e.Makhsx)
                    .HasName("PK__TBLKEHOACHSANXUA__26068485");

                entity.ToTable("TBLKEHOACHSANXUATTONGHOP");

                entity.Property(e => e.Makhsx)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHSX");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ghichukhsx)
                    .HasMaxLength(250)
                    .HasColumnName("GHICHUKHSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kguid)
                    .HasMaxLength(50)
                    .HasColumnName("KGUID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kyhieukhsx)
                    .HasMaxLength(50)
                    .HasColumnName("KYHIEUKHSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lctg)
                    .HasMaxLength(50)
                    .HasColumnName("LCTG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mabpsx)
                    .HasMaxLength(50)
                    .HasColumnName("MABPSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madonhangban)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANGBAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madonhangmua)
                    .HasMaxLength(50)
                    .HasColumnName("MADONHANGMUA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mauser)
                    .HasMaxLength(50)
                    .HasColumnName("MAUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngaybatdau)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYBATDAU");

                entity.Property(e => e.Ngaygiaohang)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYGIAOHANG");

                entity.Property(e => e.Ngayketthuc)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYKETTHUC");

                entity.Property(e => e.Ngaynhapkhsx)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYNHAPKHSX");

                entity.Property(e => e.NmhDiachi)
                    .HasMaxLength(250)
                    .HasColumnName("NMH_DIACHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhMa)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_MA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NmhTen)
                    .HasMaxLength(50)
                    .HasColumnName("NMH_TEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(250)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SttKy).HasColumnName("STT_KY");

                entity.Property(e => e.Sttkhsx).HasColumnName("STTKHSX");

                entity.Property(e => e.Tenbpsx)
                    .HasMaxLength(250)
                    .HasColumnName("TENBPSX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TonghopLtv>(entity =>
            {
                entity.ToTable("TONGHOP_LTV");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CongViec)
                    .HasMaxLength(255)
                    .HasColumnName("CONG_VIEC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ct)
                    .HasMaxLength(255)
                    .HasColumnName("CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(200)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KyNhan)
                    .HasMaxLength(255)
                    .HasColumnName("KY_NHAN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LuongCanban).HasColumnName("LUONG_CANBAN");

                entity.Property(e => e.LuongThucNhan).HasColumnName("LUONG_THUC_NHAN");

                entity.Property(e => e.MaNhanvien)
                    .HasMaxLength(255)
                    .HasColumnName("MA_NHANVIEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngaycong).HasColumnName("NGAYCONG");

                entity.Property(e => e.Ra)
                    .HasColumnType("datetime")
                    .HasColumnName("RA");

                entity.Property(e => e.TenCongtrinh)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_CONGTRINH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenNhanvien)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_NHANVIEN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thang)
                    .HasMaxLength(255)
                    .HasColumnName("THANG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tt)
                    .HasMaxLength(255)
                    .HasColumnName("TT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Vao)
                    .HasColumnType("datetime")
                    .HasColumnName("VAO");
            });

            modelBuilder.Entity<Xlclkk>(entity =>
            {
                entity.HasKey(e => new { e.Matk, e.Makho, e.Madm, e.Lo })
                    .HasName("PK__XLCLKK__7148A383");

                entity.ToTable("XLCLKK");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM");

                entity.Property(e => e.Lo)
                    .HasMaxLength(50)
                    .HasColumnName("LO");

                entity.Property(e => e.Chenhlech).HasColumnName("CHENHLECH");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dg).HasColumnName("DG");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(50)
                    .HasColumnName("DVT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hansudung)
                    .HasColumnType("datetime")
                    .HasColumnName("HANSUDUNG");

                entity.Property(e => e.Ngaykk)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYKK");

                entity.Property(e => e.Ngaylo)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYLO");

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.Soct)
                    .HasMaxLength(50)
                    .HasColumnName("SOCT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(250)
                    .HasColumnName("TENDM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonCk).HasColumnName("TON_CK");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tt).HasColumnName("TT");
            });

            modelBuilder.Entity<XlddnlGd>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.Giaidoan, e.MaNguyenlieu })
                    .HasName("PK__XLDDNL_GD__5793BE78");

                entity.ToTable("XLDDNL_GD");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.MaNguyenlieu)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NGUYENLIEU");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DgDdZ).HasColumnName("DG_DD_Z");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(20)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GtDdCk).HasColumnName("GT_DD_CK");

                entity.Property(e => e.GtDdDk).HasColumnName("GT_DD_DK");

                entity.Property(e => e.GtDdGiam).HasColumnName("GT_DD_GIAM");

                entity.Property(e => e.GtDdTang).HasColumnName("GT_DD_TANG");

                entity.Property(e => e.GtDdZ).HasColumnName("GT_DD_Z");

                entity.Property(e => e.SlDdCk).HasColumnName("SL_DD_CK");

                entity.Property(e => e.SlDdDk).HasColumnName("SL_DD_DK");

                entity.Property(e => e.SlDdGiam).HasColumnName("SL_DD_GIAM");

                entity.Property(e => e.SlDdTang).HasColumnName("SL_DD_TANG");

                entity.Property(e => e.SlDdZ).HasColumnName("SL_DD_Z");

                entity.Property(e => e.TenNguyenlieu)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_NGUYENLIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkDd)
                    .HasMaxLength(50)
                    .HasColumnName("TK_DD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkNl)
                    .HasMaxLength(50)
                    .HasColumnName("TK_NL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<XlddnlZ2>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.MaNguyenlieu })
                    .HasName("PK__XLDDNL_Z2__155BE6C7");

                entity.ToTable("XLDDNL_Z2");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.MaNguyenlieu)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NGUYENLIEU");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DgDdZ).HasColumnName("DG_DD_Z");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(20)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GtDdCk).HasColumnName("GT_DD_CK");

                entity.Property(e => e.GtDdDk).HasColumnName("GT_DD_DK");

                entity.Property(e => e.GtDdGiam).HasColumnName("GT_DD_GIAM");

                entity.Property(e => e.GtDdTang).HasColumnName("GT_DD_TANG");

                entity.Property(e => e.GtDdZ).HasColumnName("GT_DD_Z");

                entity.Property(e => e.SlDdCk).HasColumnName("SL_DD_CK");

                entity.Property(e => e.SlDdDk).HasColumnName("SL_DD_DK");

                entity.Property(e => e.SlDdGiam).HasColumnName("SL_DD_GIAM");

                entity.Property(e => e.SlDdTang).HasColumnName("SL_DD_TANG");

                entity.Property(e => e.SlDdZ).HasColumnName("SL_DD_Z");

                entity.Property(e => e.TenNguyenlieu)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_NGUYENLIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkDd)
                    .HasMaxLength(50)
                    .HasColumnName("TK_DD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkNl)
                    .HasMaxLength(50)
                    .HasColumnName("TK_NL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Z10DdDn>(entity =>
            {
                entity.HasKey(e => new { e.Giaidoan, e.Madtgt })
                    .HasName("PK__Z10_DD_DN__3EDC53F0");

                entity.ToTable("Z10_DD_DN");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.Madtgt)
                    .HasMaxLength(50)
                    .HasColumnName("MADTGT");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DkNc).HasColumnName("DK_NC");

                entity.Property(e => e.DkNl).HasColumnName("DK_NL");

                entity.Property(e => e.DkSxc).HasColumnName("DK_SXC");

                entity.Property(e => e.DkTong).HasColumnName("DK_TONG");

                entity.Property(e => e.Tendtgt)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Z10Dinhmucnguyenlieu>(entity =>
            {
                entity.HasKey(e => new { e.Giaidoan, e.Madtgt, e.MaThanhpham, e.MaNvl })
                    .HasName("PK__Z10_DINHMUCNGUYE__477199F1");

                entity.ToTable("Z10_DINHMUCNGUYENLIEU");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.Madtgt)
                    .HasMaxLength(50)
                    .HasColumnName("MADTGT");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM");

                entity.Property(e => e.MaNvl)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NVL");

                entity.Property(e => e.CpNvl).HasColumnName("CP_NVL");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DgNvl).HasColumnName("DG_NVL");

                entity.Property(e => e.Dinhmuc).HasColumnName("DINHMUC");

                entity.Property(e => e.DvtNvl)
                    .HasMaxLength(20)
                    .HasColumnName("DVT_NVL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DvtTp)
                    .HasMaxLength(20)
                    .HasColumnName("DVT_TP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nam).HasColumnName("NAM");

                entity.Property(e => e.SlNvl).HasColumnName("SL_NVL");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.TenNvl)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_NVL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtgt)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Z10Dmtpcon>(entity =>
            {
                entity.HasKey(e => new { e.Giaidoan, e.Madtgt, e.Matp })
                    .HasName("PK__Z10_DMTPCON__56B3DD81");

                entity.ToTable("Z10_DMTPCON");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.Madtgt)
                    .HasMaxLength(50)
                    .HasColumnName("MADTGT");

                entity.Property(e => e.Matp)
                    .HasMaxLength(50)
                    .HasColumnName("MATP");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgvnd).HasColumnName("DGVND");

                entity.Property(e => e.DvtTp)
                    .HasMaxLength(50)
                    .HasColumnName("DVT_TP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GtHopdong).HasColumnName("GT_HOPDONG");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Makh)
                    .HasMaxLength(50)
                    .HasColumnName("MAKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nam).HasColumnName("NAM");

                entity.Property(e => e.NgayHopdong)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HOPDONG");

                entity.Property(e => e.Ngayht)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYHT");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(255)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SlYc).HasColumnName("SL_YC");

                entity.Property(e => e.SoHopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HOPDONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtgt)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(250)
                    .HasColumnName("TENKH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tentp)
                    .HasMaxLength(250)
                    .HasColumnName("TENTP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ttvnd).HasColumnName("TTVND");

                entity.Property(e => e.TylePhanbo).HasColumnName("TYLE_PHANBO");
            });

            modelBuilder.Entity<Z10Kttpcon>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.Giaidoan, e.Madtgt, e.Matp })
                    .HasName("PK__Z10_KTTPCON__0095D40B");

                entity.ToTable("Z10_KTTPCON");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.Madtgt)
                    .HasMaxLength(50)
                    .HasColumnName("MADTGT");

                entity.Property(e => e.Matp)
                    .HasMaxLength(50)
                    .HasColumnName("MATP");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgban).HasColumnName("DGBAN");

                entity.Property(e => e.Doanhthu).HasColumnName("DOANHTHU");

                entity.Property(e => e.DvtTp)
                    .HasMaxLength(50)
                    .HasColumnName("DVT_TP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GtHopdong).HasColumnName("GT_HOPDONG");

                entity.Property(e => e.IdUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("ID_UPDATE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayHopdong)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAY_HOPDONG");

                entity.Property(e => e.Ngaykc)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYKC");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(255)
                    .HasColumnName("NOIDUNG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pstk621).HasColumnName("PSTK_621");

                entity.Property(e => e.Pstk621Tpme).HasColumnName("PSTK_621_TPME");

                entity.Property(e => e.Pstk622).HasColumnName("PSTK_622");

                entity.Property(e => e.Pstk622Tpme).HasColumnName("PSTK_622_TPME");

                entity.Property(e => e.Pstk623).HasColumnName("PSTK_623");

                entity.Property(e => e.Pstk623Tpme).HasColumnName("PSTK_623_TPME");

                entity.Property(e => e.Pstk627).HasColumnName("PSTK_627");

                entity.Property(e => e.Pstk627Tpme).HasColumnName("PSTK_627_TPME");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.SlTpMe).HasColumnName("SL_TP_ME");

                entity.Property(e => e.SoHopdong)
                    .HasMaxLength(50)
                    .HasColumnName("SO_HOPDONG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tendtgt)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tentp)
                    .HasMaxLength(250)
                    .HasColumnName("TENTP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TongPstk).HasColumnName("TONG_PSTK");

                entity.Property(e => e.TongPstkTpme).HasColumnName("TONG_PSTK_TPME");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TylePhanbo).HasColumnName("TYLE_PHANBO");

                entity.Property(e => e.Z1tp).HasColumnName("Z1TP");

                entity.Property(e => e.Ztp).HasColumnName("ZTP");
            });

            modelBuilder.Entity<Z10NhapDd>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.Giaidoan, e.Madtgt })
                    .HasName("PK__Z10_NHAP_DD__6AA692EC");

                entity.ToTable("Z10_NHAP_DD");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.Madtgt)
                    .HasMaxLength(50)
                    .HasColumnName("MADTGT");

                entity.Property(e => e.CkNc).HasColumnName("CK_NC");

                entity.Property(e => e.CkNl).HasColumnName("CK_NL");

                entity.Property(e => e.CkSxc).HasColumnName("CK_SXC");

                entity.Property(e => e.CkTong).HasColumnName("CK_TONG");

                entity.Property(e => e.Co154Nc).HasColumnName("CO154_NC");

                entity.Property(e => e.Co154Nl).HasColumnName("CO154_NL");

                entity.Property(e => e.Co154Sxc).HasColumnName("CO154_SXC");

                entity.Property(e => e.Co154Tong).HasColumnName("CO154_TONG");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DkNc).HasColumnName("DK_NC");

                entity.Property(e => e.DkNl).HasColumnName("DK_NL");

                entity.Property(e => e.DkSxc).HasColumnName("DK_SXC");

                entity.Property(e => e.DkTong).HasColumnName("DK_TONG");

                entity.Property(e => e.No154Nc).HasColumnName("NO154_NC");

                entity.Property(e => e.No154Nl).HasColumnName("NO154_NL");

                entity.Property(e => e.No154Sxc).HasColumnName("NO154_SXC");

                entity.Property(e => e.No154Tong).HasColumnName("NO154_TONG");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.Tendtgt)
                    .HasMaxLength(250)
                    .HasColumnName("TENDTGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Z10PbCpAllgd>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.Giaidoan, e.Matk })
                    .HasName("PK__Z10_PB_CP_ALLGD__1C3DEE80");

                entity.ToTable("Z10_PB_CP_ALLGD");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.CpAllGiaidoan).HasColumnName("CP_ALL_GIAIDOAN");

                entity.Property(e => e.CpPbGiaidoan).HasColumnName("CP_PB_GIAIDOAN");

                entity.Property(e => e.CpRiengGiaidoan).HasColumnName("CP_RIENG_GIAIDOAN");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tyle).HasColumnName("TYLE");
            });

            modelBuilder.Entity<Z12KtddckKho>(entity =>
            {
                entity.HasKey(e => new { e.Kyhachtoan, e.Makho, e.Giaidoan, e.MaThanhpham })
                    .HasName("PK__Z12_KTDDCK_KHO__56F3D4A3");

                entity.ToTable("Z12_KTDDCK_KHO");

                entity.Property(e => e.Kyhachtoan).HasColumnName("KYHACHTOAN");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM");

                entity.Property(e => e.Cp621).HasColumnName("CP_621");

                entity.Property(e => e.Cp622).HasColumnName("CP_622");

                entity.Property(e => e.Cp627).HasColumnName("CP_627");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ptht).HasColumnName("PTHT");

                entity.Property(e => e.Slddck).HasColumnName("SLDDCK");

                entity.Property(e => e.Sldddk).HasColumnName("SLDDDK");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TongCp).HasColumnName("TONG_CP");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Z12KtdinhmucKho>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.Makho, e.Giaidoan, e.MaThanhpham, e.MaNvl })
                    .HasName("PK__Z12_KTDINHMUC_KH__4CAC1BB1");

                entity.ToTable("Z12_KTDINHMUC_KHO");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM");

                entity.Property(e => e.MaNvl)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NVL");

                entity.Property(e => e.CpNvl).HasColumnName("CP_NVL");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DgNvl).HasColumnName("DG_NVL");

                entity.Property(e => e.Dinhmuc).HasColumnName("DINHMUC");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(50)
                    .HasColumnName("GHICHU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnco)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNCO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Madtpnno)
                    .HasMaxLength(50)
                    .HasColumnName("MADTPNNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SlNvl).HasColumnName("SL_NVL");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.TenNvl)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_NVL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Z12KtdmncKho>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.Makho, e.Giaidoan, e.MaThanhpham })
                    .HasName("PK__Z12_KTDMNC_KHO__4416D5B0");

                entity.ToTable("Z12_KTDMNC_KHO");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM");

                entity.Property(e => e.CpNc).HasColumnName("CP_NC");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dinhmuc).HasColumnName("DINHMUC");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Z12KtgtKho>(entity =>
            {
                entity.HasKey(e => new { e.Makho, e.Giaidoan, e.Madtgt, e.Thang })
                    .HasName("PK__Z12_KTGT_KHO__69F19A7E");

                entity.ToTable("Z12_KTGT_KHO");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.Madtgt)
                    .HasMaxLength(50)
                    .HasColumnName("MADTGT");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dgban).HasColumnName("DGBAN");

                entity.Property(e => e.Doanhthu).HasColumnName("DOANHTHU");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gt1sp).HasColumnName("GT_1SP");

                entity.Property(e => e.Gt621).HasColumnName("GT_621");

                entity.Property(e => e.Gt622).HasColumnName("GT_622");

                entity.Property(e => e.Gt627).HasColumnName("GT_627");

                entity.Property(e => e.Gtsp).HasColumnName("GTSP");

                entity.Property(e => e.Pstk621).HasColumnName("PSTK_621");

                entity.Property(e => e.Pstk622).HasColumnName("PSTK_622");

                entity.Property(e => e.Pstk627).HasColumnName("PSTK_627");

                entity.Property(e => e.Ptht).HasColumnName("PTHT");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.Slddck).HasColumnName("SLDDCK");

                entity.Property(e => e.Tendtgt)
                    .HasMaxLength(255)
                    .HasColumnName("TENDTGT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonckGt).HasColumnName("TONCK_GT");

                entity.Property(e => e.TonckGt621).HasColumnName("TONCK_GT_621");

                entity.Property(e => e.TonckGt622).HasColumnName("TONCK_GT_622");

                entity.Property(e => e.TonckGt627).HasColumnName("TONCK_GT_627");

                entity.Property(e => e.TonckSl).HasColumnName("TONCK_SL");

                entity.Property(e => e.TondkGt).HasColumnName("TONDK_GT");

                entity.Property(e => e.TondkGt621).HasColumnName("TONDK_GT_621");

                entity.Property(e => e.TondkGt622).HasColumnName("TONDK_GT_622");

                entity.Property(e => e.TondkGt627).HasColumnName("TONDK_GT_627");

                entity.Property(e => e.TongPstk).HasColumnName("TONG_PSTK");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Z12KtpbcpKho>(entity =>
            {
                entity.HasKey(e => new { e.Makho, e.Giaidoan, e.Thang, e.Stt })
                    .HasName("PK__Z12_KTPBCP_KHO__068DD92C");

                entity.ToTable("Z12_KTPBCP_KHO");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Cp1sp).HasColumnName("CP_1SP");

                entity.Property(e => e.CpDuocPhanbo).HasColumnName("CP_DUOC_PHANBO");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(50)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matk154)
                    .HasMaxLength(50)
                    .HasColumnName("MATK_154")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MatkCp)
                    .HasMaxLength(50)
                    .HasColumnName("MATK_CP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcp)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaytcpCon)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCP_CON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhantramCp).HasColumnName("PHANTRAM_CP");

                entity.Property(e => e.SlDuocPhanbo).HasColumnName("SL_DUOC_PHANBO");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TentkCp)
                    .HasMaxLength(250)
                    .HasColumnName("TENTK_CP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenytcp)
                    .HasMaxLength(250)
                    .HasColumnName("TENYTCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenytcpCon)
                    .HasMaxLength(250)
                    .HasColumnName("TENYTCP_CON")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkNl)
                    .HasMaxLength(50)
                    .HasColumnName("TK_NL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkTp)
                    .HasMaxLength(50)
                    .HasColumnName("TK_TP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Z12KttyleKho>(entity =>
            {
                entity.HasKey(e => new { e.Makho, e.Thang, e.MaThanhpham, e.Giaidoan })
                    .HasName("PK__Z12_KTTYLE_KHO__1C7D1A4B");

                entity.ToTable("Z12_KTTYLE_KHO");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Giathanh).HasColumnName("GIATHANH");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.SlTpQd).HasColumnName("SL_TP_QD");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tyle).HasColumnName("TYLE");
            });

            modelBuilder.Entity<Z12KttyleYtcpKho>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.Makho, e.Maytcp, e.MaThanhpham, e.Giaidoan })
                    .HasName("PK__Z12_KTTYLE_YTCP___5AFA3B08");

                entity.ToTable("Z12_KTTYLE_YTCP_KHO");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO");

                entity.Property(e => e.Maytcp)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCP");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Giathanh).HasColumnName("GIATHANH");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.SlTpQd).HasColumnName("SL_TP_QD");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenytcp)
                    .HasMaxLength(250)
                    .HasColumnName("TENYTCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tyle).HasColumnName("TYLE");
            });

            modelBuilder.Entity<Z12Ktxldd>(entity =>
            {
                entity.HasKey(e => new { e.Thang, e.Makho, e.Ppgt, e.MaThanhpham, e.MaNguyenlieu })
                    .HasName("PK__Z12_KTXLDD__6577C97B");

                entity.ToTable("Z12_KTXLDD");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .HasColumnName("MAKHO");

                entity.Property(e => e.Ppgt)
                    .HasMaxLength(12)
                    .HasColumnName("PPGT");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM");

                entity.Property(e => e.MaNguyenlieu)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NGUYENLIEU");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DdCk154Tong).HasColumnName("DD_CK_154_TONG");

                entity.Property(e => e.DdCkGtNl).HasColumnName("DD_CK_GT_NL");

                entity.Property(e => e.DdCkNc).HasColumnName("DD_CK_NC");

                entity.Property(e => e.DdCkSlNl).HasColumnName("DD_CK_SL_NL");

                entity.Property(e => e.DdCkSlTp).HasColumnName("DD_CK_SL_TP");

                entity.Property(e => e.DdCkSxc).HasColumnName("DD_CK_SXC");

                entity.Property(e => e.DdDk154Tong).HasColumnName("DD_DK_154_TONG");

                entity.Property(e => e.DdDkGtNl).HasColumnName("DD_DK_GT_NL");

                entity.Property(e => e.DdDkNc).HasColumnName("DD_DK_NC");

                entity.Property(e => e.DdDkSlNl).HasColumnName("DD_DK_SL_NL");

                entity.Property(e => e.DdDkSlTp).HasColumnName("DD_DK_SL_TP");

                entity.Property(e => e.DdDkSxc).HasColumnName("DD_DK_SXC");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(20)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DvtTp)
                    .HasMaxLength(20)
                    .HasColumnName("DVT_TP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kieuchiphi)
                    .HasMaxLength(10)
                    .HasColumnName("KIEUCHIPHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcp)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Psco154Tong).HasColumnName("PSCO_154_TONG");

                entity.Property(e => e.PscoGtNl).HasColumnName("PSCO_GT_NL");

                entity.Property(e => e.PscoNc).HasColumnName("PSCO_NC");

                entity.Property(e => e.PscoSlNl).HasColumnName("PSCO_SL_NL");

                entity.Property(e => e.PscoSlTp).HasColumnName("PSCO_SL_TP");

                entity.Property(e => e.PscoSxc).HasColumnName("PSCO_SXC");

                entity.Property(e => e.Psno154Tong).HasColumnName("PSNO_154_TONG");

                entity.Property(e => e.PsnoGtNl).HasColumnName("PSNO_GT_NL");

                entity.Property(e => e.PsnoNc).HasColumnName("PSNO_NC");

                entity.Property(e => e.PsnoSlNl).HasColumnName("PSNO_SL_NL");

                entity.Property(e => e.PsnoSlTp).HasColumnName("PSNO_SL_TP");

                entity.Property(e => e.PsnoSxc).HasColumnName("PSNO_SXC");

                entity.Property(e => e.PtHt).HasColumnName("PT_HT");

                entity.Property(e => e.TenNguyenlieu)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_NGUYENLIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkDd)
                    .HasMaxLength(50)
                    .HasColumnName("TK_DD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkNl)
                    .HasMaxLength(50)
                    .HasColumnName("TK_NL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkTp)
                    .HasMaxLength(50)
                    .HasColumnName("TK_TP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Z1Ktxldd>(entity =>
            {
                entity.HasKey(e => new { e.Ppgt, e.Thang, e.MaThanhpham, e.MaNguyenlieu })
                    .HasName("PK__Z1_KTXLDD__403B57D4");

                entity.ToTable("Z1_KTXLDD");

                entity.Property(e => e.Ppgt)
                    .HasMaxLength(12)
                    .HasColumnName("PPGT");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.MaThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_THANHPHAM");

                entity.Property(e => e.MaNguyenlieu)
                    .HasMaxLength(50)
                    .HasColumnName("MA_NGUYENLIEU");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DdCk154Tong).HasColumnName("DD_CK_154_TONG");

                entity.Property(e => e.DdCkGtNl).HasColumnName("DD_CK_GT_NL");

                entity.Property(e => e.DdCkGtTp).HasColumnName("DD_CK_GT_TP");

                entity.Property(e => e.DdCkNc).HasColumnName("DD_CK_NC");

                entity.Property(e => e.DdCkSlNl).HasColumnName("DD_CK_SL_NL");

                entity.Property(e => e.DdCkSlTp).HasColumnName("DD_CK_SL_TP");

                entity.Property(e => e.DdCkSxc).HasColumnName("DD_CK_SXC");

                entity.Property(e => e.DdDk154Tong).HasColumnName("DD_DK_154_TONG");

                entity.Property(e => e.DdDkGtNl).HasColumnName("DD_DK_GT_NL");

                entity.Property(e => e.DdDkGtTp).HasColumnName("DD_DK_GT_TP");

                entity.Property(e => e.DdDkNc).HasColumnName("DD_DK_NC");

                entity.Property(e => e.DdDkSlNl).HasColumnName("DD_DK_SL_NL");

                entity.Property(e => e.DdDkSlTp).HasColumnName("DD_DK_SL_TP");

                entity.Property(e => e.DdDkSxc).HasColumnName("DD_DK_SXC");

                entity.Property(e => e.Donvi)
                    .HasMaxLength(20)
                    .HasColumnName("DONVI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DvtTp)
                    .HasMaxLength(20)
                    .HasColumnName("DVT_TP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kieuchiphi)
                    .HasMaxLength(10)
                    .HasColumnName("KIEUCHIPHI")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matp)
                    .HasMaxLength(50)
                    .HasColumnName("MATP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maytcp)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Psco154Tong).HasColumnName("PSCO_154_TONG");

                entity.Property(e => e.PscoGtNl).HasColumnName("PSCO_GT_NL");

                entity.Property(e => e.PscoGtTp).HasColumnName("PSCO_GT_TP");

                entity.Property(e => e.PscoNc).HasColumnName("PSCO_NC");

                entity.Property(e => e.PscoSlNl).HasColumnName("PSCO_SL_NL");

                entity.Property(e => e.PscoSlTp).HasColumnName("PSCO_SL_TP");

                entity.Property(e => e.PscoSxc).HasColumnName("PSCO_SXC");

                entity.Property(e => e.Psno154Tong).HasColumnName("PSNO_154_TONG");

                entity.Property(e => e.PsnoGtNl).HasColumnName("PSNO_GT_NL");

                entity.Property(e => e.PsnoGtTp).HasColumnName("PSNO_GT_TP");

                entity.Property(e => e.PsnoNc).HasColumnName("PSNO_NC");

                entity.Property(e => e.PsnoSlNl).HasColumnName("PSNO_SL_NL");

                entity.Property(e => e.PsnoSlTp).HasColumnName("PSNO_SL_TP");

                entity.Property(e => e.PsnoSxc).HasColumnName("PSNO_SXC");

                entity.Property(e => e.PtHt).HasColumnName("PT_HT");

                entity.Property(e => e.TenNguyenlieu)
                    .HasMaxLength(250)
                    .HasColumnName("TEN_NGUYENLIEU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenThanhpham)
                    .HasMaxLength(50)
                    .HasColumnName("TEN_THANHPHAM")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tentp)
                    .HasMaxLength(250)
                    .HasColumnName("TENTP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkDd)
                    .HasMaxLength(50)
                    .HasColumnName("TK_DD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkNl)
                    .HasMaxLength(50)
                    .HasColumnName("TK_NL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TkTp)
                    .HasMaxLength(50)
                    .HasColumnName("TK_TP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Z8Dd>(entity =>
            {
                entity.HasKey(e => new { e.Giaidoan, e.Thang, e.Matp, e.Matk, e.Maytcp })
                    .HasName("PK__Z8_DD__324172E1");

                entity.ToTable("Z8_DD");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("GIAIDOAN");

                entity.Property(e => e.Thang).HasColumnName("THANG");

                entity.Property(e => e.Matp)
                    .HasMaxLength(50)
                    .HasColumnName("MATP");

                entity.Property(e => e.Matk)
                    .HasMaxLength(50)
                    .HasColumnName("MATK");

                entity.Property(e => e.Maytcp)
                    .HasMaxLength(50)
                    .HasColumnName("MAYTCP");

                entity.Property(e => e.Ck621).HasColumnName("CK_621");

                entity.Property(e => e.Ck622).HasColumnName("CK_622");

                entity.Property(e => e.Ck627).HasColumnName("CK_627");

                entity.Property(e => e.CkTong).HasColumnName("CK_TONG");

                entity.Property(e => e.Danhdau)
                    .HasMaxLength(50)
                    .HasColumnName("DANHDAU")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dk621).HasColumnName("DK_621");

                entity.Property(e => e.Dk622).HasColumnName("DK_622");

                entity.Property(e => e.Dk627).HasColumnName("DK_627");

                entity.Property(e => e.DkTong).HasColumnName("DK_TONG");

                entity.Property(e => e.Lk621).HasColumnName("LK_621");

                entity.Property(e => e.Lk622).HasColumnName("LK_622");

                entity.Property(e => e.Lk627).HasColumnName("LK_627");

                entity.Property(e => e.LkTong).HasColumnName("LK_TONG");

                entity.Property(e => e.Matk154)
                    .HasMaxLength(50)
                    .HasColumnName("MATK_154")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ps621).HasColumnName("PS_621");

                entity.Property(e => e.Ps622).HasColumnName("PS_622");

                entity.Property(e => e.Ps627).HasColumnName("PS_627");

                entity.Property(e => e.PsTong).HasColumnName("PS_TONG");

                entity.Property(e => e.SlTp).HasColumnName("SL_TP");

                entity.Property(e => e.Tentp)
                    .HasMaxLength(250)
                    .HasColumnName("TENTP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((0))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
