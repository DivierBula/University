using RegisterSubject.DataProviderAccess;
using RegisterSubject.DataProviderAccess.DataAccessObject;
using RegisterSubject.DataProviderAccess.Helpers;
using RegisterSubject.DataProviderAccess.Interfaces;
using RegisterSubject.Imp.Models;
using RegisterSubject.Imp.Program;
using System.Collections.Generic;
using System.Linq;

namespace RegisterSubject.Imp.Student
{
    public class StudentImp
    {
        private readonly IStudentProvider<StudentDAO> _studentAccess;
        private readonly IStudentAssociationProvider<StudentAssociationDAO> _studentAssociationAccess;
        private readonly ProgramImp _ProgramImp;

        #region Ctor
        public StudentImp()
        {
            _studentAccess = new StudentAccess();
            _studentAssociationAccess = new StudentAssociationAccess();
            _ProgramImp = new ProgramImp();
        }
        public StudentImp(IStudentProvider<StudentDAO> studentAccess, IStudentAssociationProvider<StudentAssociationDAO> studentAssociationAccess)
        {
            _studentAccess = studentAccess;
            _studentAssociationAccess = studentAssociationAccess;
            _ProgramImp = new ProgramImp();
        }
        #endregion

        /// <summary>
        /// Autor: Divier Bula
        /// Metodo para obtener los estudiantes existentes
        /// </summary>
        /// <param name="conProgramas"></param>
        /// <returns></returns>
        public List<StudentDTO> GetStudent(bool conProgramas)
        {
            List<StudentDTO> students = _studentAccess.Get().Mapper<StudentDTO, StudentDAO>();

            if (conProgramas)
            {
                students.ForEach(item =>
                {
                    item.Programa = _ProgramImp.GetProgramsXstudent(item.IdEstudiante);
                });
            }
            return students;
        }

        /// <summary>
        /// Autor: Divier Bula
        /// Metodo para obtener un estudiante especifico
        /// </summary>
        /// <param name="id"></param>
        /// <param name="conProgramas"></param>
        /// <returns></returns>
        public StudentDTO GetStudentId(long id, bool conProgramas)
        {
            StudentDTO student = _studentAccess.GetId(id).Mapper<StudentDTO, StudentDAO>();

            if (conProgramas)
            {
                student.Programa = _ProgramImp.GetProgramsXstudent(student.IdEstudiante);
            }
            return student;
        }

        /// <summary>
        /// Autor: Divier Bula
        /// Metodo para registrar una programa a un estudiante
        /// </summary>
        /// <param name="studentAssociation"></param>
        /// <returns></returns>
        public string EnrollProgram(StudentAssociationDTO studentAssociation)
        {
            StudentDTO student = this.GetStudentId(studentAssociation.IdEstudiante, true);

            #region ReglaDeNegocio: El Estudiente solo puede inscribirse a 3 materias
            if (student.Programa.Count >= 3)
            {
                return "El Estudiente solo puede inscribirse a 3 materias";
            }
            #endregion

            #region ReglaDeNegocio: El estudiante no puede tener clases con el mismo profesor
            ProgramDTO programSelected = _ProgramImp.GetProgramId(studentAssociation.IdPrograma);

             List<ProgramDTO> _programas = _ProgramImp.GetProgramsXstudent(studentAssociation.IdEstudiante);
            foreach (var item in _programas)
            {
                if(item.IdProfesor == programSelected.IdProfesor)
                {
                    return "El estudiante no puede tener clases con el mismo profesor";
                }
            }
            #endregion

            _studentAssociationAccess.Insert(studentAssociation.Mapper<StudentAssociationDAO, StudentAssociationDTO>());

            return "OK";
        }

        /// <summary>
        /// Autor: Divier Bula
        /// Metodo para obtener los estudiantes de un programa en especifico
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<StudentDTO> GetStudentxPrograms(long Id)
        {
            List<StudentDTO> listStudent = new List<StudentDTO>();
            List<StudentAssociationDTO> estudiantesDelPrograma = _studentAssociationAccess.GetStudentsxPrograms(Id).Mapper<StudentAssociationDTO, StudentAssociationDAO>();
            estudiantesDelPrograma.ForEach(x => listStudent.Add(x.Estudiante));
            return listStudent;
        }

        /// <summary>
        /// Autor: Divier  Bula
        /// Metodo para crear un estudiante
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public string NewStudent(StudentDTO student)
        {
            var input = student.Mapper<StudentDAO, StudentDTO>();
            _studentAccess.Insert(input);
            return "OK";
        }

        /// <summary>
        /// Autor: Divier  Bula
        /// Metodo para crear un estudiante
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public string UpdateStudent(StudentDTO student)
        {
            var input = student.Mapper<StudentDAO, StudentDTO>();
            _studentAccess.Update(input);
            return "OK";
        }

        /// <summary>
        /// Autor: Divier  Bula
        /// Metodo para crear un estudiante
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public string DeleteStudent(long id)
        {
            List<StudentAssociationDTO> _studentAssociation = _studentAssociationAccess.GetProgramsxStudent(id).Mapper<StudentAssociationDTO, StudentAssociationDAO>();
            _studentAssociation.ForEach(x => _studentAssociationAccess.Delete(x.IdAsignacionEstudiantil));

            _studentAccess.Delete(id);
            return "OK";
        }
    }
}
