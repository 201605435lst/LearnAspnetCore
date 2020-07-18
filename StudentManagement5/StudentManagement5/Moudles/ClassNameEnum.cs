﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement5.Moudles
{
    /// <summary>
    /// 班级的枚举
    /// </summary>
    public enum ClassNameEnum
    {
        [Display(Name = "未分配")]
        None,
        [Display(Name = "一年级")]
        FirstGrade,
        [Display(Name = "二年级")]
        SecondeGrade,
        [Display(Name = "三年级")]
        ThreeGrade

    }
}
