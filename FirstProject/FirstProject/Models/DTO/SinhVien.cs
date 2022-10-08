using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FirstProject.Models.DTO
{
    public class SinhVien
    {
        [DisplayName("Mã sinh viên")]
        public String Id { get; set; }
        [DisplayName("Mật khẩu"), DataType(DataType.Password)]
        public String PassWord { get; set; }
        [DisplayName("Tên sinh viên")]
        public String FullName { get; set; }
        [DisplayName("Giới tính")]
        public bool Gender { get; set; }
        [DisplayName("Ngày sinh"), DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        [DisplayName("Ghi chú"),DataType(DataType.MultilineText)]
        public String Notes { get; set; }
    }
}