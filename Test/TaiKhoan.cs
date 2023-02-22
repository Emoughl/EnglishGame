using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class TaiKhoan
    {
        private string tenTaiKhoan;
        private string matKhau;
        private string email;
        

        public TaiKhoan()
        {
        }

        public TaiKhoan(string tenTaiKhoan, string matKhau, string email)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
            this.email = email;
            
        }

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string Email { get => email; set => email = value; }

    }
}
