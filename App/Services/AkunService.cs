using System;

using PBOBarberMate.App.Repository;
using PBOBarberMate.App.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data;


namespace PBOBarberMate.App.Services
{
    public class AkunService
    {
        private readonly AkunRepository _akunRepository;
        private readonly SessionService _sessionService;

        // Konstruktor: Menerima AkunRepository dan SessionService via Dependency Injection
        public AkunService(AkunRepository akunRepository, SessionService sessionService)
        {
            _akunRepository = akunRepository;
            _sessionService = sessionService;
        }


        public bool Login(string email, string plainPassword)
        {
            try
            {
                M_Akun akunDariDb = _akunRepository.getAkunByEmail(email);

                if (akunDariDb == null)
                {
                    return false;
                }

                string hashedPasswordInput = M_Akun.hashPassword(plainPassword);
                if (akunDariDb.Password != hashedPasswordInput)
                {
                    return false;
                }
                _sessionService.SetSession(akunDariDb.email, akunDariDb.nama, akunDariDb.id_akun, akunDariDb.role);
                return true;
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"AkunService: Gagal memproses login. Error: {ex.Message}", ex);
            }
        }
        public bool Signup(string nama, string email, string plainPassword)
        {
            try
            {
                // Periksa apakah email sudah terdaftar
                if (_akunRepository.getAkunByEmail(email) != null)
                {
                    return false; // Email sudah terdaftar
                }

                // Panggil Repository untuk menambahkan akun
                M_Akun newAkun = new M_Akun(nama, email, plainPassword, AkunRole.customer);
                int newAccountId = _akunRepository.createAkun(newAkun);

                // Jika akun berhasil dibuat maka otomatis login
                if (newAccountId > 0)
                {
                    _sessionService.SetSession(email, nama, newAccountId, AkunRole.customer);
                    return true;
                } 
                // Pendaftaran gagal
                else
                {
                    return false;
                }
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"AkunService: Gagal memproses pendaftaran. Error: {ex.Message}", ex);
            }
        }
        public void Logout()
        {
            _sessionService.ClearSession();
        }


        public List<M_Akun> getAllAkun()
        {
            try
            {
                return _akunRepository.getAllAkun();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"AkunService: Gagal mendapatkan semua akun. Error: {ex.Message}", ex);
            }
        }
        public List<M_Karyawan> getAllKaryawan()
        {
            try
            {
                return _akunRepository.getAllKaryawan();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"AkunService: Gagal mendapatkan semua karyawan. Error: {ex.Message}", ex);
            }
        }
        public M_Akun getAkunById(int id)
        {
            try
            {
                return _akunRepository.getAkunById(id);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"AkunService: Gagal mendapatkan akun dengan ID {id}. Error: {ex.Message}", ex);
            }
        }
        public M_Akun getAkunByEmail(string email)
        {
            try
            {
                return _akunRepository.getAkunByEmail(email);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"AkunService: Gagal mendapatkan akun dengan email {email}. Error: {ex.Message}", ex);
            }
        }
        public bool addAkun(string nama, string email, string password, AkunRole role)
        {
            try
            {
                M_Akun akun = new M_Akun(nama, email, password, role);
                int id = _akunRepository.createAkun(akun);
                return id > 0;
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"AkunService: Gagal menambahkan akun. Error: {ex.Message}", ex);
            }
        }
        public bool updateAkun(string nama, string email, string password, AkunRole role, int id)
        {
            try
            {
                M_Akun akun = new M_Akun(nama, email, password, role);
                return _akunRepository.UpdateAkun(akun, id);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"AkunService: Gagal memperbarui akun. Error: {ex.Message}", ex);
            }
        }
        public bool deleteAkun(int id)
        {
            try
            {
                return _akunRepository.DeleteAkun(id);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"AkunService: Gagal menghapus akun. Error: {ex.Message}", ex);
            }
        }
    }
}
