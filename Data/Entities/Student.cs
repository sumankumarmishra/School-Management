﻿namespace Data.Entities;


public class Student : GeneralLocalizeEntity
{
    [Key]
    public int StudID { get; set; }
    [StringLength(200)]
    public string NameAr { get; set; }
    [StringLength(200)]
    public string NameEn { get; set; }

    [StringLength(500)]
    public string Address { get; set; }
    [StringLength(500)]
    public string Phone { get; set; }

    [Display(Name = "Department")]
    public int? DepartmentID { get; set; }

    [ForeignKey("DepartmentID")]
    public virtual Department Department { get; set; }
}
