using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using WebAccountant.DAOs;
using WebAccountant.Models;
using WebAccountant.ModelsBase;
using WebAccountant.ModelsLogin;
using WebAccountant.Repository;
using WebAccountant.Repository.Implement;

namespace WebAccountant
{
    public static class ExtentionService
    {
        public static System.Reflection.PropertyInfo GetAttribute(this Ktsc t, string name)
        {
            return typeof(Ktsc).GetProperty("Lctg");
        }
        //public static string AppConnectionString = "No Connection";
        public static string AppConnectionString = "Data Source=(local);Initial Catalog=TIENHIEU2024; Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<UnitOfWork>();
            services.AddScoped<ILoginRepo, LoginRepo>();
            services.AddScoped<IKtdmRepo, KtdmRepo>();
            services.AddScoped<IKtcnsRepo, KtcnRepo>();
            services.AddScoped<IKtdtpnsRepo, KtdtpnRepo>();
            services.AddScoped<IKtlctgRepo, KtlctgRepo>();
            services.AddScoped<IKtscRepo, KtscRepo>();
            services.AddScoped<IKttkRepo, KttkRepo>();
            services.AddScoped<IUserKTSCColumnsRepo, UserKTSCColumnsRepo>();
            services.AddScoped<IUserKTDMColumnRepo , UserKTDMColumnRepo>();
            services.AddScoped<IUserTableRepo, UserTableRepo>();
            return services;
        }
        public static IServiceCollection AddDatabase(this IServiceCollection services)
        {
            services.AddDbContext<TIENHIEU2024Context>(options =>
            {
                options.UseSqlServer(AppConnectionString);
            });
            services.AddDbContext<LoginContext>(options =>
            {
                options.UseSqlServer(GetConnectionString());
            });
            return services;
        }

        public static void SetAppConnectionString(string connectionString)
        {
            if(AppConnectionString == "No Connection")
            {
				AppConnectionString = connectionString;
			}           
        }
        private static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true).Build();
            return config["ConnectionStrings"];
        }
        private static string GetEncryptKey()
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true).Build();
            return config["PrivateKey"];
        }
        public static KtdmDTO KTDMMapper(this Ktdm baseEntity)
        {
            return new KtdmDTO()
            {
                Matk = baseEntity.Matk,
                Madm = baseEntity.Madm,
                Donvi = baseEntity.Donvi,
                Tendm = baseEntity.Tendm,
                Dgban = baseEntity.Dgban,
                TonTDv1 = baseEntity.TonTDv1,
                Soluong = 0,
            };
        }
        public static UserDTO UserDTOMapper(this User baseEntity)
        {
            return new UserDTO()
            {
                UserName = baseEntity.UserName,
                Email = baseEntity.Email,
                Phone = baseEntity.Phone,
            };
        }
        public static string EncryptString(string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(GetEncryptKey());
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public static string DecryptString(string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(GetEncryptKey());
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
