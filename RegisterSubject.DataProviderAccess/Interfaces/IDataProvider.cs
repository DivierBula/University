using RegisterSubject.DataProviderAccess.DataAccessObject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterSubject.DataProviderAccess.Interfaces
{
    public interface ITeacherProvider<T> :
        ICrudProvider<T> where T : class
    {
    }
    public interface IStudentProvider<T> :
        IDeleteProvider<T>,
        IUpdateProvider<T>,
        ICrudProvider<T> where T : class
    {
    }

    public interface IStudentAssociationProvider<T> :
        IGetProvider<T>,
        IDeleteProvider<T>,
        IInsertProvider<T>,
        IProgramsByStudentProvider<T>,
        IStudentsByProgramsProvider<T> where T : class
    {
    }

    public interface IProgramProvider<T> :
        ICrudProvider<T>,
        ITeacherAssociationProvider<T> where T : class
    {
    }

    public interface ICrudProvider<T> :
        IGetProvider<T>,
        IGetFilterProvider<T>,
        IInsertProvider<T> where T : class
    {
    }

    


    #region INTERFACES INDIVIDUALES
    public interface IGetProvider<T> where T : class
    {
        List<T> Get(int top = 0);
    }

    public interface IGetFilterProvider<T> where T : class
    {
        T GetId(long Id);
    }

    public interface IInsertProvider<T> where T : class
    {
        void Insert(T Dto);
    }

    public interface IDeleteProvider<T> where T : class
    {
        void Delete(long id);
    }
    
    public interface IUpdateProvider<T> where T : class
    {
        void Update(T Dto);
    }

    public interface IProgramsByStudentProvider<T> where T : class
    {
        List<T> GetProgramsxStudent(long Id);
    }

    public interface IStudentsByProgramsProvider<T> where T : class
    {
        List<T> GetStudentsxPrograms(long Id);
    }

    public interface ITeacherAssociationProvider<T> where T : class
    {
        List<T> GetProgramxProfesor(long Id);
    }
    
    #endregion
}
