using RegisterSubject.Imp;
using RegisterSubject.Imp.Models;
using RegisterSubject.Imp.Program;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Program" in code, svc and config file together.
public class Program : IProgram
{
    private readonly ProgramImp _ProgramImp;
    public Program()
    {
        _ProgramImp = new ProgramImp();
    }

    /// <summary>
    /// Autor: Divier Bula
    /// Esta es la puerta de entrada al servicio y controlador de errores
    /// </summary>
    /// <returns></returns>
    public List<ProgramDTO> GetProgram()
    {
        try
        {
            return _ProgramImp.GetProgram();
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
    public ProgramDTO GetProgramId(long id)
    {
        try
        {
            return _ProgramImp.GetProgramId(id);
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
    public List<ProgramDTO> GetProgramsXstudent(long Id)
    {
        try
        {
            return _ProgramImp.GetProgramsXstudent(Id);
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
    /// <param name="Program"></param>
    /// <returns></returns>
    public string NewProgram(ProgramRequest Program)
    {
        try
        {
            return _ProgramImp.NewProgram(new ProgramDTO()
            {
                Nombre = Program.Nombre,
                DuracionEnDias = Program.DuracionEnDiás,
                Creditos = Program.Creditos,
                IdProfesor = Program.IdProfesor
            });
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
