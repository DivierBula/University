using RegisterSubject.Imp;
using RegisterSubject.Imp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IStudent
{

	[OperationContract]
    List<StudentDTO> GetStudent(bool conProgramas = true);

    [OperationContract]
    StudentDTO GetStudentId(long id, bool conProgramas = true );

    [OperationContract]
    string NewStudent(StudentRequest student);

    [OperationContract]
    string EnrollProgram(StudentAssociationRequest studentAssociation);

    [OperationContract]
    List<StudentDTO> GetStudentxPrograms(long Id);

    [OperationContract]
    string UpdateStudent(StudentRequest student);

    [OperationContract]
    string DeleteStudent(long id);
}
