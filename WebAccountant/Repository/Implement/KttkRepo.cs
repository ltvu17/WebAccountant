using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using System.Collections;
using System.Globalization;
using WebAccountant.DAOs;
using WebAccountant.ModelsBase;

namespace WebAccountant.Repository.Implement
{
    public class KttkRepo : IKttkRepo
    {
        private readonly UnitOfWork _unitOfWork;
        public KttkRepo(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<EntityEntry<Kttk>> AddNew(string values)
        {
            var model = new Kttk();
            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);
            var result = await _unitOfWork.KTTKDAO.Add(model);
            await _unitOfWork.SaveChangesAsync();
            return result;
        }

        public async Task Delete(string key)
        {
            var model = (await _unitOfWork.KTTKDAO.GetAll()).FirstOrDefault(item => item.Matk == key);
            await _unitOfWork.KTTKDAO.RemoveEntity(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<Kttk>> GetAllAsync()
        {
            return await _unitOfWork.KTTKDAO.GetAll();
        }

        public async Task Update(string key, string values)
        {
            var model = (await _unitOfWork.KTTKDAO.GetAll()).FirstOrDefault(item => item.Matk == key);
            if (model == null)
                return;

            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);
            await _unitOfWork.SaveChangesAsync();
        }
        private void PopulateModel(Kttk model, IDictionary values)
        {
            string MATK = nameof(Kttk.Matk);
            string TENTK = nameof(Kttk.Tentk);
            string MATK_E = nameof(Kttk.MatkE);
            string TENTK_E = nameof(Kttk.TentkE);
            string LOAITIEN = nameof(Kttk.Loaitien);
            string VNDDUNO = nameof(Kttk.Vndduno);
            string VNDDUCO = nameof(Kttk.Vndduco);
            string VNDPSNO = nameof(Kttk.Vndpsno);
            string VNDPSCO = nameof(Kttk.Vndpsco);
            string VNDPSNO_LK = nameof(Kttk.VndpsnoLk);
            string VNDPSCO_LK = nameof(Kttk.VndpscoLk);
            string VNDCKNO = nameof(Kttk.Vndckno);
            string VNDCKCO = nameof(Kttk.Vndckco);
            string USDDUNO = nameof(Kttk.Usdduno);
            string USDDUCO = nameof(Kttk.Usdduco);
            string USDPSNO = nameof(Kttk.Usdpsno);
            string USDPSCO = nameof(Kttk.Usdpsco);
            string USDCKNO = nameof(Kttk.Usdckno);
            string USDCKCO = nameof(Kttk.Usdckco);
            string DANHDAU = nameof(Kttk.Danhdau);
            string TRANGTHAI = nameof(Kttk.Trangthai);
            string EURCKCO = nameof(Kttk.Eurckco);
            string EURCKNO = nameof(Kttk.Eurckno);
            string EURDUCO = nameof(Kttk.Eurduco);
            string EURDUNO = nameof(Kttk.Eurduno);
            string EURPSCO = nameof(Kttk.Eurpsco);
            string EURPSNO = nameof(Kttk.Eurpsno);
            string MATK_KC = nameof(Kttk.MatkKc);
            string USDPSCO_LK = nameof(Kttk.UsdpscoLk);
            string USDPSNO_LK = nameof(Kttk.UsdpsnoLk);
            string MATK_MOI = nameof(Kttk.MatkMoi);
            string TK_CHIETKHAU = nameof(Kttk.TkChietkhau);
            string TK_GIAVON = nameof(Kttk.TkGiavon);
            string TK_TRALAI = nameof(Kttk.TkTralai);

            if (values.Contains(MATK))
            {
                model.Matk = Convert.ToString(values[MATK]);
            }

            if (values.Contains(TENTK))
            {
                model.Tentk = Convert.ToString(values[TENTK]);
            }

            if (values.Contains(MATK_E))
            {
                model.MatkE = Convert.ToString(values[MATK_E]);
            }

            if (values.Contains(TENTK_E))
            {
                model.TentkE = Convert.ToString(values[TENTK_E]);
            }

            if (values.Contains(LOAITIEN))
            {
                model.Loaitien = Convert.ToString(values[LOAITIEN]);
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

            if (values.Contains(VNDPSNO_LK))
            {
                model.VndpsnoLk = Convert.ToDouble(values[VNDPSNO_LK], CultureInfo.InvariantCulture);
            }

            if (values.Contains(VNDPSCO_LK))
            {
                model.VndpscoLk = Convert.ToDouble(values[VNDPSCO_LK], CultureInfo.InvariantCulture);
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

            if (values.Contains(MATK_KC))
            {
                model.MatkKc = Convert.ToString(values[MATK_KC]);
            }

            if (values.Contains(USDPSCO_LK))
            {
                model.UsdpscoLk = Convert.ToDouble(values[USDPSCO_LK], CultureInfo.InvariantCulture);
            }

            if (values.Contains(USDPSNO_LK))
            {
                model.UsdpsnoLk = Convert.ToDouble(values[USDPSNO_LK], CultureInfo.InvariantCulture);
            }

            if (values.Contains(MATK_MOI))
            {
                model.MatkMoi = Convert.ToString(values[MATK_MOI]);
            }

            if (values.Contains(TK_CHIETKHAU))
            {
                model.TkChietkhau = Convert.ToString(values[TK_CHIETKHAU]);
            }

            if (values.Contains(TK_GIAVON))
            {
                model.TkGiavon = Convert.ToString(values[TK_GIAVON]);
            }

            if (values.Contains(TK_TRALAI))
            {
                model.TkTralai = Convert.ToString(values[TK_TRALAI]);
            }
        }
    }
}
