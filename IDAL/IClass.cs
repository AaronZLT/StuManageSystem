using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using StudentManager.Model;

namespace StudentManager.IDAL
{

    /// <summary>
    /// �༶���ݷ��ʽӿڲ�
    /// </summary>
    public interface IClass
    {
        #region ��Ӱ༶
        int AddClass(ClassInf clsssInf);
        #endregion

        #region ��ȡ�༶�б���Ϣ
        DataTable GetClassList(string sp_id);
        #endregion

        #region ��ȡ�༶��Ϣ
        DataTable GetClasses(string dp_name, string sp_name);
        #endregion
    }
   
}
