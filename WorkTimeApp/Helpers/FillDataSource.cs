using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTimeApp.Helpers
{
    public static class FillDataSource
    {
        public static void Fill(IList data, ListControl listControl, string valueMember, string displayMember)
        {
            listControl.DataSource = data;
            listControl.DisplayMember = displayMember;
            listControl.ValueMember = valueMember;
        }
    }
}
