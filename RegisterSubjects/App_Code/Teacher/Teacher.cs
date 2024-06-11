using RegisterSubject.Imp;
using RegisterSubject.Imp.Models;
using RegisterSubject.Imp.Teacher;
using System;
using System.Collections.Generic;

public class Teacher : ITeacher
{
    private readonly TeacherImp _TeacherImp;
    public Teacher()
    {
        _TeacherImp = new TeacherImp();
    }

    /// <summary>
    /// Autor: Divier Bula
    /// Esta es la puerta de entrada al servicio y controlador de errores
    /// </summary>
    /// <returns></returns>
    public List<TeacherDTO> GetTeacher()
    {
        try
        {
            return _TeacherImp.GetTeacher();
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
    public TeacherDTO GetTeacherId(long id)
    {
        try
        {
            return _TeacherImp.GetTeacherId(id);
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
    /// <param name="Teacher"></param>
    /// <returns></returns>
    public string NewTeacher(TeacherRequest Teacher)
    {
        try
        {   
            return _TeacherImp.NewTeacher(new TeacherDTO()
            {
                Nombre = Teacher.Nombre,
                Telefono = Teacher.Telefono
            });
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
