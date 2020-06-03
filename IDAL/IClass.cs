using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using StudentManager.Model;

namespace StudentManager.IDAL
{

    /// <summary>
    /// 班级数据访问接口层
    /// </summary>
    public interface IClass
    {
        #region 添加班级
        int AddClass(ClassInf clsssInf);
        #endregion

        #region 获取班级列表信息
        DataTable GetClassList(string sp_id);
        #endregion

        #region 获取班级信息
        DataTable GetClasses(string dp_name, string sp_name);
        #endregion
    }
   
}
