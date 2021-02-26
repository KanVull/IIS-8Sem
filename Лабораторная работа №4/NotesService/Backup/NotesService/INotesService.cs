using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NotesService
{
    [ServiceContract]
    public interface INotesService
    {
        [OperationContract]
        List<NoteRecord> GetNotes(string user);
        [OperationContract]
        bool AddNote(string user, NoteRecord record);
        [OperationContract]
        bool SetDone(string user, string id);
        [OperationContract]
        bool DeleteNote(string user, string id);
    }

    [DataContract]
    public class NoteRecord
    {
        [DataMember]
        public string id;
        [DataMember]
        public string record;
        [DataMember]
        public bool done;
    }
}
