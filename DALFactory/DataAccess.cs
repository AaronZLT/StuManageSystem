using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Configuration;
//5_1_a_s_p_x.c_o_m

namespace StudentManager.DALFactory
{
    /// <summary>
    /// ���乤���ഴ��ʵ�����
    /// ������:���
    /// ʱ��:2008-03
    /// </summary>
    public sealed class DataAccess
    {
        #region ��ȡ�����ļ������õ����ݿ�·��
        private static readonly string path =ConfigurationManager.AppSettings["StudentManagerDb"];
        #endregion

        #region ����ѧ��ʵ��
        /// <summary>
        /// ����ѧ��ʵ��
        /// </summary>
        /// <returns>ѧ��ʵ��</returns>
        public static StudentManager.IDAL.IStudent CreateStudent()
        {
            string className = path + ".Student";
            return (StudentManager.IDAL.IStudent)Assembly.Load(path).CreateInstance(className);
        }
        #endregion

        #region ������ʦʵ��
        /// <summary>
        /// ������ʦʵ��
        /// </summary>
        /// <returns>��ʦʵ��</returns>
        public static StudentManager.IDAL.ITeacher CreateTeacher()
        {
            string className = path + ".Teacher";
            return (StudentManager.IDAL.ITeacher)Assembly.Load(path).CreateInstance(className);
        }
        #endregion

        #region ��������(ѧԺ)ʵ��
        /// <summary>
        /// ��������ʵ��
        /// </summary>
        /// <returns>����ʵ��</returns>
        public static StudentManager.IDAL.IDepartment CreateDepartment()
        {
            string className = path + ".Department";
            return (StudentManager.IDAL.IDepartment)Assembly.Load(path).CreateInstance(className);
        }
        #endregion

        #region ����������Ϣʵ��
        /// <summary>
        /// ����������Ϣʵ��
        /// </summary>
        /// <returns>������Ϣʵ��</returns>
        public static StudentManager.IDAL.ICommon CreateCommon()
        {
            string className = path + ".Common";
            return (StudentManager.IDAL.ICommon)Assembly.Load(path).CreateInstance(className);
        }
        #endregion

        #region ʹ�÷��乤����������ʵ��
        /// <summary>
        /// ʹ�÷��乤����������ʵ��
        /// </summary>
        /// <returns>������Ϣʵ��</returns>
        public static StudentManager.IDAL.IAffiche CreateAffiche()
        {
            string className = path + ".Affiche";
            return (StudentManager.IDAL.IAffiche)Assembly.Load(path).CreateInstance(className);
        }
        #endregion

        #region ���÷��乤������רҵʵ��
        public static StudentManager.IDAL.ISpeciality CreateSpeciality()
        {
            string className = path + ".Speciality";
            return (StudentManager.IDAL.ISpeciality)Assembly.Load(path).CreateInstance(className);
        }
        #endregion

        #region ʹ�÷��乤�������༶ʵ��
        public static StudentManager.IDAL.IClass CreateClass()
        {
            string className = path + ".StuClass";
            return (StudentManager.IDAL.IClass)Assembly.Load(path).CreateInstance(className);
        }
        #endregion

        #region ʹ�÷��乤�������γ�ʵ��
        public static StudentManager.IDAL.ICourse CreateCourse()
        {
            string className = path + ".Course";
            return (StudentManager.IDAL.ICourse)Assembly.Load(path).CreateInstance(className);
        }
        #endregion

    }
}

