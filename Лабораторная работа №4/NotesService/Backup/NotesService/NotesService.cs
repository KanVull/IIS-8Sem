using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using System.Xml.Linq;

namespace NotesService
{
    public class NotesService : INotesService
    {
        private List<NoteRecord> notes = new List<NoteRecord>();

        public List<NoteRecord> GetNotes(string user)
        {
            notes.Clear();

            string fileName = "D:\\" + user + ".xml";

            XDocument doc;
            if (File.Exists(fileName))
            {
                doc = XDocument.Load(fileName);
                foreach (XElement el in doc.Element("notes").Elements("note"))
                {
                    notes.Add(
                        new NoteRecord
                        {
                            id = el.Attribute("id").Value,
                            record = el.Attribute("record").Value,
                            done = Convert.ToBoolean(el.Attribute("done").Value)
                        }
                        );
                }
            }

            return notes;
        }

        public bool AddNote(string user, NoteRecord record)
        {
            string fileName = "D:\\" + user + ".xml";

            XDocument doc;
            if (File.Exists(fileName))
            {
                doc = XDocument.Load(fileName);
                doc.Element("notes").Add(
                    new XElement("note",
                        new XAttribute("id", record.id),
                        new XAttribute("record", record.record),
                        new XAttribute("done", record.done)
                        )
                    );
            }
            else
            {
                doc = new XDocument(
                    new XElement("notes",
                        new XElement("note",
                            new XAttribute("id", record.id),
                            new XAttribute("record", record.record),
                            new XAttribute("done", record.done)
                            )
                        )
                    );
            }

            try
            {
                doc.Save(fileName);
            }
            catch 
            {
                return false;
            }

            return true;
        }

        public bool SetDone(string user, string id)
        {
            string fileName = "D:\\" + user + ".xml";

            XDocument doc;
            if (File.Exists(fileName))
            {
                doc = XDocument.Load(fileName);
                foreach (XElement el in doc.Element("notes").Elements("note"))
                {
                    if (el.Attribute("id").Value == id)
                        el.SetAttributeValue("done", true);
                }

                try
                {
                    doc.Save(fileName);
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }

        public bool DeleteNote(string user, string id)
        {
            string fileName = "D:\\" + user + ".xml";

            XDocument doc;
            if (File.Exists(fileName))
            {
                doc = XDocument.Load(fileName);
                foreach (XElement el in doc.Element("notes").Elements("note"))
                {
                    if (el.Attribute("id").Value == id)
                        el.Remove();
                }

                try
                {
                    doc.Save(fileName);
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }
    }
}
