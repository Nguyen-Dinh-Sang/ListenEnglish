using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace English.Models
{
    public class User
    {
        [Key]
        public int iD { get; set; }

        public string tenNguoiDung { get; set; }

        public string taiKhoan { get; set; }

        public string matKhau { get; set; }

        [DataType(DataType.Date)]
        public DateTime ngayTao { get; set; }

        public string soDienThoai { get; set; }

        public string gmail { get; set; }

        public enum VaiTro
        {
            nguoiDungThuong = 1,
            nguoiQuanTri = 2
        }
        public VaiTro vaiTro { get; set; }
    }
}
