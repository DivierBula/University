using RegisterSubject.DataProviderAccess;
using RegisterSubject.Imp;
using RegisterSubject.Imp.Models;
using RegisterSubject.Imp.Student;
using System;
using System.Collections.Generic;


public class Student : IStudent
{
	private readonly StudentImp _studentImp;
    public Student()
	{
		_studentImp = new StudentImp();
	}

    /// <summary>
    /// Autor: Divier Bula
    /// Esta es la puerta de entrada al servicio y controlador de errores
    /// </summary>
    /// <param name="conProgramas"></param>
    /// <returns></returns>
	public List<StudentDTO> GetStudent(bool conProgramas = true)
	{
		try
		{
            return _studentImp.GetStudent(conProgramas);
        }
		catch (Exception ex)
		{
			throw ex;
		}
	}

    /// <summary>
    /// Autor: Divier Bula
    /// Esta es la puerta de entrada al servicio y controlador de errores
    /// </summary>
    /// <param name="id"></param>
    /// <param name="conProgramas"></param>
    /// <returns></returns>
    public StudentDTO GetStudentId(long id, bool conProgramas = true)
    {
        try
        {
            return _studentImp.GetStudentId(id, conProgramas);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Autor: Divier Bula
    /// Esta es la puerta de entrada al servicio y controlador de errores
    /// </summary>
    /// <param name="studentAssociation"></param>
    /// <returns></returns>
    public string EnrollProgram(StudentAssociationRequest studentAssociation)
    {
        try
        {
            return _studentImp.EnrollProgram(new StudentAssociationDTO()
            {
                IdEstudiante = studentAssociation.IdEstudiante,
                IdPrograma = studentAssociation.IdProgram
            });
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    /// <summary>
    /// Autor: Divier Bula
    /// Esta es la puerta de entrada al servicio y controlador de errores
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    public List<StudentDTO> GetStudentxPrograms(long Id)
    {
        try
        {
            return _studentImp.GetStudentxPrograms(Id);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Autor: Divier Bula
    /// Esta es la puerta de entrada al servicio y controlador de errores
    /// </summary>
    /// <param name="student"></param>
    /// <returns></returns>
    public string NewStudent(StudentRequest student)
    {
        try
        {
            return _studentImp.NewStudent(new StudentDTO()
            {
                Nombre = student.Nombre,
                Telefono = student.Telefono
            });
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Autor: Divier Bula
    /// Esta es la puerta de entrada al servicio y controlador de errores
    /// </summary>
    /// <param name="student"></param>
    /// <returns></returns>
    public string UpdateStudent(StudentRequest student)
    {
        try
        {
            return _studentImp.UpdateStudent(new StudentDTO()
            {
                IdEstudiante =  student.IdEstudiante,
                Nombre = student.Nombre,
                Telefono = student.Telefono
            });
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Autor: Divier Bula
    /// Esta es la puerta de entrada al servicio y controlador de errores
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public string DeleteStudent(long id)
    {
        try
        {
            return _studentImp.DeleteStudent(id);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
