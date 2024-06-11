using RegisterSubject.DataProviderAccess;
using RegisterSubject.DataProviderAccess.DataAccessObject;
using RegisterSubject.DataProviderAccess.Helpers;
using RegisterSubject.DataProviderAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace RegisterSubject.Imp.Teacher
{
    public class TeacherImp
    {
        private readonly ITeacherProvider<TeacherDAO> _TeacherAccess;
        
        #region Ctor
        public TeacherImp()
        {
            _TeacherAccess = new TeacherAccess();
        }
        public TeacherImp(ITeacherProvider<TeacherDAO> teacherAccess)
        {
            _TeacherAccess = teacherAccess;
        }
        #endregion

        /// <summary>
        /// Autor: Divier Bula
        /// Metodo para obtener todos los profesores
        /// </summary>
        /// <returns></returns>
        public List<TeacherDTO> GetTeacher()
        {
            return _TeacherAccess.Get().Mapper<TeacherDTO, TeacherDAO>();
        }

        /// <summary>
        /// Autor: Divier Bula
        /// Metodo para obtener un profesor un especifico
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TeacherDTO GetTeacherId(long id)
        {
            return _TeacherAccess.GetId(id).Mapper<TeacherDTO, TeacherDAO>();
        }

        /// <summary>
        /// Autor: Divier Bula
        /// Metodo para crear un profesor
        /// </summary>
        /// <param name="Teacher"></param>
        /// <returns></returns>
        public string NewTeacher(TeacherDTO Teacher)
        {
            var input = Teacher.Mapper<TeacherDAO, TeacherDTO>();
            _TeacherAccess.Insert(input);
            return "OK";
        }
    }
}
