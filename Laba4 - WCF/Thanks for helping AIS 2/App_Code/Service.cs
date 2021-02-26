using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Linq;

// ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Реструктуризация" можно использовать для одновременного изменения имени класса "Service" в коде, SVC-файле и файле конфигурации.
public class Service : IService
{
    string fileName = @"C:/Инст/Интерфейсы ИС/tasks.xml";
    private List<TaskRecord> tasks = new List<TaskRecord>();
    public List<TaskRecord> GetTasks()
    {
        tasks.Clear();
       
        XDocument doc;
        if (File.Exists(fileName))
        {
            doc = XDocument.Load(fileName);
            foreach (XElement el in doc.Element("tasks").Elements("task"))
            {
                tasks.Add(
                    new TaskRecord
                    {
                        id = el.Element("id").Value,
                        name = el.Element("name").Value,
                        surname = el.Element("surname").Value,
                        group = el.Element("group").Value,
                        task_name = el.Element("task_name").Value,
                        subject = el.Element("subject").Value,
                        discription = el.Element("discription").Value,
                    }
                    );
            }
        }
        return tasks;
    }
    public bool AddTask(TaskRecord record)
    {

        XDocument doc;
        if (File.Exists(fileName))
        {
            doc = XDocument.Load(fileName);
            int id = int.Parse(doc.Element("tasks").Elements("task").Last().Element("id").Value) + 1;
                doc.Element("tasks").Add(new XElement("task",
                new XElement("id", id),
                new XElement("name", record.name),
                new XElement("surname", record.surname),
                new XElement("group", record.group),
                new XElement("task_name", record.task_name),
                new XElement("subject", record.subject),
                new XElement("discription", record.discription)

                )
            );
            doc.Save(fileName);
            return true;
        } 
        else
        return false;
    }
    public bool DeleteTask(string id)
    {

        XDocument doc;
        if (File.Exists(fileName))
        {
            doc = XDocument.Load(fileName);
            XElement x = (from item in doc.Element("tasks").Elements("task") where item.Element("id").Value == id select item).First();
            x.Remove();
            var MoreID = (from item in doc.Element("tasks").Elements("task") where int.Parse(item.Element("id").Value.ToString()) > int.Parse(id) select item);
            foreach (var item in MoreID)
            {
                item.Element("id").Value = (int.Parse(item.Element("id").Value.ToString()) - 1).ToString();
            }
            doc.Save(fileName);
            return true;
        }
        else
            return false;
    }
    public bool EditTask(TaskRecord task)
    {
        string id = task.id;

        XDocument doc;
        if (File.Exists(fileName))
        {
            doc = XDocument.Load(fileName);
            XElement x = (from item in doc.Element("tasks").Elements("task") where item.Element("id").Value == id select item).First();
            x.Element("name").Value = task.name;
            x.Element("surname").Value = task.surname;
            x.Element("group").Value = task.group;
            x.Element("task_name").Value = task.task_name;
            x.Element("subject").Value = task.subject;
            x.Element("discription").Value = task.discription;
            doc.Save(fileName);
            return true;
        }
        else
            return false;
    }
    public List<TaskRecord> Search(TaskRecord task)
    {
        List<TaskRecord> selectedtasks = new List<TaskRecord>();
        
        XDocument doc = XDocument.Load(fileName);
        var dict = TaskToDictionary(task);
        string selectedCell = (from item in dict where item.Value != "" select item).First().Key;
        var selectedElements = (from item in doc.Element("tasks").Elements("task") where item.Element(selectedCell).Value == dict[selectedCell] select item).ToList();
        foreach (var el in selectedElements)
        {
            selectedtasks.Add(
                        new TaskRecord
                        {
                            id = el.Element("id").Value,
                            name = el.Element("name").Value,
                            surname = el.Element("surname").Value,
                            group = el.Element("group").Value,
                            task_name = el.Element("task_name").Value,
                            subject = el.Element("subject").Value,
                            discription = el.Element("discription").Value
                        }
                        );
        }
        return selectedtasks;
    }
    public string SearchLastID()
    {
        return XDocument.Load(fileName).Element("tasks").Elements("task").Count().ToString();
    }
    private Dictionary<string, string> TaskToDictionary(TaskRecord task)
    {
        Dictionary<string, string> Dict = new Dictionary<string, string>();
        Dict.Add("id", task.id);
        Dict.Add("name", task.name);
        Dict.Add("surname", task.surname);
        Dict.Add("group", task.group);
        Dict.Add("task_name", task.task_name);
        Dict.Add("subject", task.subject);
        Dict.Add("discription", task.discription);
        return Dict;
    }
}
