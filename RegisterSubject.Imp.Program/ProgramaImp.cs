using RegisterSubject.DataProviderAccess;
using RegisterSubject.DataProviderAccess.DataAccessObject;
using RegisterSubject.DataProviderAccess.Helpers;
using RegisterSubject.DataProviderAccess.Interfaces;
using RegisterSubject.Imp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace RegisterSubject.Imp.Program
{
    public class ProgramImp
    {
        private readonly IProgramProvider<ProgramDAO> _ProgramAccess;
        private readonly IStudentAssociationProvider<StudentAssociationDAO> _studentAssociationAccess;
        
        #region Ctor
        public ProgramImp()
        {
            _ProgramAccess = new ProgramAccess();
            _studentAssociationAccess = new StudentAssociationAccess();
        }
        public ProgramImp(IProgramProvider<ProgramDAO> programAccess, IStudentAssociationProvider<StudentAssociationDAO> studentAssociationAccess)
        {
            _ProgramAccess = programAccess;
            _studentAssociationAccess = studentAssociationAccess;
        }
        #endregion

        /// <summary>
        /// Autor: Divier Bula
        /// Metodo para obtener todos los programas
        /// </summary>
        /// <returns></returns>
        public List<ProgramDTO> GetProgram()
        {
            return _ProgramAccess.Get().Mapper<ProgramDTO, ProgramDAO>();
        }

        /// <summary>
        /// Autor: Divier Bula
        /// Metodo para obtener un programa especifico
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProgramDTO GetProgramId(long id)
        {
            return _ProgramAccess.GetId(id).Mapper<ProgramDTO, ProgramDAO>();
        }

        /// <summary>
        /// Autor: Divier Bula
        /// Metodo para obtener los programas de un estudiante
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<ProgramDTO> GetProgramsXstudent(long Id)
        {
            List<ProgramDTO> response = new List<ProgramDTO>();
            List<StudentAssociationDTO> programasDelEstudiante = _studentAssociationAccess.GetProgramsxStudent(Id).Mapper<StudentAssociationDTO, StudentAssociationDAO>();
            programasDelEstudiante.ForEach(x => response.Add(x.Programa));
            return response;
        }
        
        /// <summary>
        /// Autor: Divier Bula
        /// Metodo para crear un programa
        /// </summary>
        /// <param name="Program"></param>
        /// <returns></returns>
        public string NewProgram(ProgramDTO Program)
        {
            if (_ProgramAccess.GetProgramxProfesor(Program.IdProfesor).Count >= 2)
            {
                return "El profesor tiene mas de 2 programas ya asignados, por lo tanto debe seleccionar otro Profesor";
            }

            #region reglaDeNegocio: Las materias son de 3 Creditos
            if (Program.Creditos  != 3)
            {
                return "Los creditos de la materia no pueden ser diferentes a 3";
            }
            #endregion

            var input = Program.Mapper<ProgramDAO, ProgramDTO>();
            _ProgramAccess.Insert(input);
            return "OK";
        }
    }
}
