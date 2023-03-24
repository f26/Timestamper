using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Timestamper
{
    /// <summary>
    /// Simple wrapper for file info objects to facilitate viewing them in an ObjectListView
    /// </summary>
    public class FileItem
    {
        private FileInfo _finfo;
        private string _newName;
        public FileItem(FileInfo finfo, string newName)
        {
            _finfo = finfo;
            _newName = newName;
        }
        public string Name { get { return _finfo.Name; } set { } }
        public string NewName { get { return _newName; } set { } }
        public string Type
        {
            get
            {
                if (_finfo.Extension.Length == 0) return "(none)";
                else return _finfo.Extension;
            }
            set { }
        }
        public long Size { get { return ((FileInfo)_finfo).Length; } set { } }
        public DateTime DateModified { get { return _finfo.LastWriteTime; } set { } }
        public DateTime DateCreated { get { return _finfo.CreationTime; } set { } }
        public string FullNewName() { return Path.GetDirectoryName(_finfo.FullName) + "\\" + _newName; }
        public string FullName() { return _finfo.FullName; }
    }
}
