using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid
{
    public class DataGridList
    {
        private BindingList<DataGridRaw> _rows = new BindingList<DataGridRaw>();
        private DataGridView _DataGridView;

        public DataGridList()
        {
            _rows.AllowNew = true;
            _rows.AllowRemove = false;
            _rows.RaiseListChangedEvents = true;
            _rows.AllowEdit = false;
        }

        public void AssignDataGridView(DataGridView view)
        {
            _DataGridView = view;
            _DataGridView.DataSource = _rows;
            _DataGridView.RowsAdded += OnRowsAddedEventHandler;
        }

        public void Add(DataGridRaw row)
        {
            _rows.Add(row);
        }

        public void ScrollToEnd()
        {
            if(_DataGridView.Rows.Count > 0)
            {
                _DataGridView.FirstDisplayedScrollingRowIndex = _DataGridView.Rows.Count - 1;
            }
        }

        private void OnRowsAddedEventHandler(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Task.Delay(100);
            if(e.RowIndex % 4 == 0)
            {
                _DataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
            }
            _DataGridView.FirstDisplayedScrollingRowIndex = _DataGridView.Rows.Count - 1;
        }
    }
}
