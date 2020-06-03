using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Configuration;
//5_1_a_s_p_x.c_o_m

namespace StudentManager.DALFactory
{
    /// <summary>
    /// 反射工厂类创建实体对象
    /// 创建者:余洪
    /// 时间:2008-03
    /// </summary>
    public sealed class DataAccess
    {
        #region 获取配置文件中配置的数据库路径
        private static readonly string path =ConfigurationManager.AppSettings["StudentManagerDb"];
        #endregion

        #region 创建学生实体
        /// <summary>
        /// 创建学生实体
        /// </summary>
        /// <returns>学生实体</returns>
        public static StudentManager.IDAL.IStudent CreateStudent()
        {
            string className = path + ".Student";
            return (StudentManager.IDAL.IStudent)Assembly.Load(path).CreateInstance(className);
        }
        #endregion

        #region 创建教师实体
        /// <summary>
        /// 创建教师实体
        /// </summary>
        /// <returns>教师实体</returns>
        public static StudentManager.IDAL.ITeacher CreateTeacher()
        {
            string className = path + ".Teacher";
            return (StudentManager.IDAL.ITeacher)Assembly.Load(path).CreateInstance(className);
        }
        #endregion

        #region 创建部门(学院)实体
        /// <summary>
        /// 创建部门实体
        /// </summary>
        /// <returns>部门实体</returns>
        public static StudentManager.IDAL.IDepartment CreateDepartment()
        {
            string className = path + ".Department";
            return (StudentManager.IDAL.IDepartment)Assembly.Load(path).CreateInstance(className);
        }
        #endregion

        #region 创建公用信息实体
        /// <summary>
        /// 创建公用信息实体
        /// </summary>
        /// <returns>公共信息实体</returns>
        public static StudentManager.IDAL.ICommon CreateCommon()
        {
            string className = path + ".Common";
            return (StudentManager.IDAL.ICommon)Assembly.Load(path).CreateInstance(className);
        }
        #endregion

        #region 使用反射工厂创建公告实体
        /// <summary>
        /// 使用反射工厂创建公告实体
        /// </summary>
        /// <returns>公共信息实体</returns>
        public static StudentManager.IDAL.IAffiche CreateAffiche()
        {
            string className = path + ".Affiche";
            return (StudentManager.IDAL.IAffiche)Assembly.Load(path).CreateInstance(className);
        }
        #endregion

        #region 利用反射工厂创建专业实体
        public static StudentManager.IDAL.ISpeciality CreateSpeciality()
        {
            string className = path + ".Speciality";
            return (StudentManager.IDAL.ISpeciality)Assembly.Load(path).CreateInstance(className);
        }
        #endregion

        #region 使用反射工厂创建班级实体
        public static StudentManager.IDAL.IClass CreateClass()
        {
            string className = path + ".StuClass";
            return (StudentManager.IDAL.IClass)Assembly.Load(path).CreateInstance(className);
        }
        #endregion

        #region 使用反射工厂创建课程实体
        public static StudentManager.IDAL.ICourse CreateCourse()
        {
            string className = path + ".Course";
            return (StudentManager.IDAL.ICourse)Assembly.Load(path).CreateInstance(className);
        }
        #endregion

    }
}

