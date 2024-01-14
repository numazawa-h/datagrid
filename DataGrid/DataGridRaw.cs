using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DataGrid
{
    /// <summary>
    /// DataGridの1行データ
    /// </summary>
    /// <remarks>【参考】https://qiita.com/lusf/items/dcce573787e808ccb0ea</remarks>
    public class DataGridRaw
    {
        private int _id;
        private string _name;
        private string _description;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }


        public DataGridRaw(int id, string name, string description)
        {
            this._id = id;   
            this._name = name;   
            this._description = description;
        }
    }
}
