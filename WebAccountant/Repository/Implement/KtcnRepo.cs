using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using System.Collections;
using System.Globalization;
using WebAccountant.DAOs;
using WebAccountant.ModelsBase;

namespace WebAccountant.Repository.Implement
{
    public class KtcnRepo : IKtcnsRepo
    {
        private readonly UnitOfWork _unitOfWork;
        public KtcnRepo(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<EntityEntry<Ktcn>> AddNew(string values)
        {
            var model = new Ktcn();
            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);
            var result = await _unitOfWork.KTCNDAO.Add(model);
            await _unitOfWork.SaveChangesAsync();
            return result;
        }

        public async Task Delete(string key)
        {
            var keys = JsonConvert.DeserializeObject<IDictionary>(key);
            var keyMadtpn = Convert.ToString(keys["Madtpn"]);
            var keyMatk = Convert.ToString(keys["Matk"]);
            var model = (await _unitOfWork.KTCNDAO.GetAll()).FirstOrDefault(item =>
                            item.Madtpn == keyMadtpn &&
                            item.Matk == keyMatk);

            await _unitOfWork.KTCNDAO.RemoveEntity(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<Ktcn>> GetAllAsync()
        {
            return await _unitOfWork.KTCNDAO.GetAll();
        }

        public async Task Update(string key, string values)
        {
            var keys = JsonConvert.DeserializeObject<IDictionary>(key);
            var keyMadtpn = Convert.ToString(keys["Madtpn"]);
            var keyMatk = Convert.ToString(keys["Matk"]);
            var model = (await _unitOfWork.KTCNDAO.GetAll()).FirstOrDefault(item =>
                            item.Madtpn == keyMadtpn &&
                            item.Matk == keyMatk);
            if (model == null)
                return;

            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);
            await _unitOfWork.SaveChangesAsync();
        }
        private void PopulateModel(Ktcn model, IDictionary values)
        {
            string MATK = nameof(Ktcn.Matk);
            string MADTPN = nameof(Ktcn.Madtpn);
            string TENDTPN = nameof(Ktcn.Tendtpn);
            string VNDDUNO = nameof(Ktcn.Vndduno);
            string VNDDUCO = nameof(Ktcn.Vndduco);
            string VNDPSNO = nameof(Ktcn.Vndpsno);
            string VNDPSCO = nameof(Ktcn.Vndpsco);
            string VNDCKNO = nameof(Ktcn.Vndckno);
            string VNDCKCO = nameof(Ktcn.Vndckco);
            string USDDUNO = nameof(Ktcn.Usdduno);
            string USDDUCO = nameof(Ktcn.Usdduco);
            string USDPSNO = nameof(Ktcn.Usdpsno);
            string USDPSCO = nameof(Ktcn.Usdpsco);
            string USDCKNO = nameof(Ktcn.Usdckno);
            string USDCKCO = nameof(Ktcn.Usdckco);
            string DANHDAU = nameof(Ktcn.Danhdau);
            string TRANGTHAI = nameof(Ktcn.Trangthai);
            string VNDNO_MAX = nameof(Ktcn.VndnoMax);
            string DIACHI = nameof(Ktcn.Diachi);
            string DIENTICH = nameof(Ktcn.Dientich);
            string DONGIA = nameof(Ktcn.Dongia);
            string EURCKCO = nameof(Ktcn.Eurckco);
            string EURCKNO = nameof(Ktcn.Eurckno);
            string EURDUCO = nameof(Ktcn.Eurduco);
            string EURDUNO = nameof(Ktcn.Eurduno);
            string EURPSCO = nameof(Ktcn.Eurpsco);
            string EURPSNO = nameof(Ktcn.Eurpsno);
            string GIATRI_HOPDONG = nameof(Ktcn.GiatriHopdong);
            string MANHOM1 = nameof(Ktcn.Manhom1);
            string MANHOM2 = nameof(Ktcn.Manhom2);
            string MANHOM3 = nameof(Ktcn.Manhom3);
            string MATT = nameof(Ktcn.Matt);
            string NGAY_HOPDONG = nameof(Ktcn.NgayHopdong);
            string NGAY_THANHLY = nameof(Ktcn.NgayThanhly);
            string SO_HOPDONG = nameof(Ktcn.SoHopdong);
            string TENNHOM1 = nameof(Ktcn.Tennhom1);
            string TENNHOM2 = nameof(Ktcn.Tennhom2);
            string TENNHOM3 = nameof(Ktcn.Tennhom3);
            string TENTT = nameof(Ktcn.Tentt);
            string ID_UPDATE = nameof(Ktcn.IdUpdate);

            if (values.Contains(MATK))
            {
                model.Matk = Convert.ToString(values[MATK]);
            }

            if (values.Contains(MADTPN))
            {
                model.Madtpn = Convert.ToString(values[MADTPN]);
            }

            if (values.Contains(TENDTPN))
            {
                model.Tendtpn = Convert.ToString(values[TENDTPN]);
            }

            if (values.Contains(VNDDUNO))
            {
                model.Vndduno = Convert.ToDouble(values[VNDDUNO], CultureInfo.InvariantCulture);
            }

            if (values.Contains(VNDDUCO))
            {
                model.Vndduco = Convert.ToDouble(values[VNDDUCO], CultureInfo.InvariantCulture);
            }

            if (values.Contains(VNDPSNO))
            {
                model.Vndpsno = Convert.ToDouble(values[VNDPSNO], CultureInfo.InvariantCulture);
            }

            if (values.Contains(VNDPSCO))
            {
                model.Vndpsco = Convert.ToDouble(values[VNDPSCO], CultureInfo.InvariantCulture);
            }

            if (values.Contains(VNDCKNO))
            {
                model.Vndckno = Convert.ToDouble(values[VNDCKNO], CultureInfo.InvariantCulture);
            }

            if (values.Contains(VNDCKCO))
            {
                model.Vndckco = Convert.ToDouble(values[VNDCKCO], CultureInfo.InvariantCulture);
            }

            if (values.Contains(USDDUNO))
            {
                model.Usdduno = Convert.ToDouble(values[USDDUNO], CultureInfo.InvariantCulture);
            }

            if (values.Contains(USDDUCO))
            {
                model.Usdduco = Convert.ToDouble(values[USDDUCO], CultureInfo.InvariantCulture);
            }

            if (values.Contains(USDPSNO))
            {
                model.Usdpsno = Convert.ToDouble(values[USDPSNO], CultureInfo.InvariantCulture);
            }

            if (values.Contains(USDPSCO))
            {
                model.Usdpsco = Convert.ToDouble(values[USDPSCO], CultureInfo.InvariantCulture);
            }

            if (values.Contains(USDCKNO))
            {
                model.Usdckno = Convert.ToDouble(values[USDCKNO], CultureInfo.InvariantCulture);
            }

            if (values.Contains(USDCKCO))
            {
                model.Usdckco = Convert.ToDouble(values[USDCKCO], CultureInfo.InvariantCulture);
            }

            if (values.Contains(DANHDAU))
            {
                model.Danhdau = Convert.ToString(values[DANHDAU]);
            }

            if (values.Contains(TRANGTHAI))
            {
                model.Trangthai = values[TRANGTHAI] != null ? Convert.ToDouble(values[TRANGTHAI], CultureInfo.InvariantCulture) : (double?)null;
            }

            if (values.Contains(VNDNO_MAX))
            {
                model.VndnoMax = Convert.ToDouble(values[VNDNO_MAX], CultureInfo.InvariantCulture);
            }

            if (values.Contains(DIACHI))
            {
                model.Diachi = Convert.ToString(values[DIACHI]);
            }

            if (values.Contains(DIENTICH))
            {
                model.Dientich = Convert.ToDouble(values[DIENTICH], CultureInfo.InvariantCulture);
            }

            if (values.Contains(DONGIA))
            {
                model.Dongia = Convert.ToDouble(values[DONGIA], CultureInfo.InvariantCulture);
            }

            if (values.Contains(EURCKCO))
            {
                model.Eurckco = Convert.ToDouble(values[EURCKCO], CultureInfo.InvariantCulture);
            }

            if (values.Contains(EURCKNO))
            {
                model.Eurckno = Convert.ToDouble(values[EURCKNO], CultureInfo.InvariantCulture);
            }

            if (values.Contains(EURDUCO))
            {
                model.Eurduco = Convert.ToDouble(values[EURDUCO], CultureInfo.InvariantCulture);
            }

            if (values.Contains(EURDUNO))
            {
                model.Eurduno = Convert.ToDouble(values[EURDUNO], CultureInfo.InvariantCulture);
            }

            if (values.Contains(EURPSCO))
            {
                model.Eurpsco = Convert.ToDouble(values[EURPSCO], CultureInfo.InvariantCulture);
            }

            if (values.Contains(EURPSNO))
            {
                model.Eurpsno = Convert.ToDouble(values[EURPSNO], CultureInfo.InvariantCulture);
            }

            if (values.Contains(GIATRI_HOPDONG))
            {
                model.GiatriHopdong = Convert.ToDouble(values[GIATRI_HOPDONG], CultureInfo.InvariantCulture);
            }

            if (values.Contains(MANHOM1))
            {
                model.Manhom1 = Convert.ToString(values[MANHOM1]);
            }

            if (values.Contains(MANHOM2))
            {
                model.Manhom2 = Convert.ToString(values[MANHOM2]);
            }

            if (values.Contains(MANHOM3))
            {
                model.Manhom3 = Convert.ToString(values[MANHOM3]);
            }

            if (values.Contains(MATT))
            {
                model.Matt = Convert.ToString(values[MATT]);
            }

            if (values.Contains(NGAY_HOPDONG))
            {
                model.NgayHopdong = values[NGAY_HOPDONG] != null ? Convert.ToDateTime(values[NGAY_HOPDONG]) : (DateTime?)null;
            }

            if (values.Contains(NGAY_THANHLY))
            {
                model.NgayThanhly = values[NGAY_THANHLY] != null ? Convert.ToDateTime(values[NGAY_THANHLY]) : (DateTime?)null;
            }

            if (values.Contains(SO_HOPDONG))
            {
                model.SoHopdong = Convert.ToString(values[SO_HOPDONG]);
            }

            if (values.Contains(TENNHOM1))
            {
                model.Tennhom1 = Convert.ToString(values[TENNHOM1]);
            }

            if (values.Contains(TENNHOM2))
            {
                model.Tennhom2 = Convert.ToString(values[TENNHOM2]);
            }

            if (values.Contains(TENNHOM3))
            {
                model.Tennhom3 = Convert.ToString(values[TENNHOM3]);
            }

            if (values.Contains(TENTT))
            {
                model.Tentt = Convert.ToString(values[TENTT]);
            }

            if (values.Contains(ID_UPDATE))
            {
                model.IdUpdate = Convert.ToString(values[ID_UPDATE]);
            }
        }
    }
}
