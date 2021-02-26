using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Реструктуризация" можно использовать для одновременного изменения имени интерфейса "IService" в коде и файле конфигурации.
[ServiceContract]
public interface IService
{
		[OperationContract]
		List<TaskRecord> GetTasks();

		[OperationContract]
		bool AddTask(TaskRecord record);

		[OperationContract]
		bool EditTask(TaskRecord task);

		[OperationContract]
		bool DeleteTask(string id);

		[OperationContract]
		List<TaskRecord> Search(TaskRecord task);

		[OperationContract]
		string SearchLastID();
}

// Используйте контракт данных, как показано в примере ниже, чтобы добавить составные типы к операциям служб.
[DataContract]
public class TaskRecord
{
	[DataMember]
	public string id;
	[DataMember]
	public string name;
	[DataMember]
	public string surname;
	[DataMember]
	public string group;
	[DataMember]
	public string task_name;
	[DataMember]
	public string subject;
	[DataMember]
	public string discription;

}

