using RegisterSubject.Imp.Models;
using RegisterSubject.Imp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface ITeacher
{

    [OperationContract]
    List<TeacherDTO> GetTeacher();

    [OperationContract]
    TeacherDTO GetTeacherId(long id);

    [OperationContract]
    string NewTeacher(TeacherRequest student);
}