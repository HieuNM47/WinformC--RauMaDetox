
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DAO
{

using System;
    using System.Collections.Generic;
    
<<<<<<< HEAD
public partial class CTPhanQuyen
{

    public string IDNV { get; set; }

    public string IDquyen { get; set; }

    public string Taikhoan { get; set; }

    public string LoaiQuyen { get; set; }

    public Nullable<bool> TrangThai { get; set; }



    public virtual NhanVien NhanVien { get; set; }

    public virtual PhanQuyen PhanQuyen { get; set; }

}

=======
    public partial class CTPhanQuyen
    {
        public string IDNV { get; set; }
        public string IDquyen { get; set; }
        public string Taikhoan { get; set; }
        public string LoaiQuyen { get; set; }
        public Nullable<bool> TrangThai { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
        public virtual PhanQuyen PhanQuyen { get; set; }
    }
>>>>>>> 03aac24c7ebbbb114cdf087881bc786dd8086700
}
