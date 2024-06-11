using RegisterSubject.Imp;
using RegisterSubject.Imp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProgram" in both code and config file together.
[ServiceContract]
public interface IProgram
{
    [OperationContract]
    List<ProgramDTO> GetProgram();

    [OperationContract]
    ProgramDTO GetProgramId(long id);

    [OperationContract]
    string NewProgram(ProgramRequest Program);

    [OperationContract]
    List<ProgramDTO> GetProgramsXstudent(long Id);


}
