using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunarCalendar
{
    public partial class DateEntry : UserControl
    {
        #region Contructor
        public DateEntry()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        [Description("Ngày dương lịch"),
        Category("Behavior"),
        Browsable(true)]
        public int SolarDate
        {
            get { return int.Parse(lblSolarDate.Text); }
            set { lblSolarDate.Text = value.ToString(); }
        }

        [Description("Ngày âm lịch"),
        Category("Behavior"),
        Browsable(true)]
        public int LunarDate
        {
            get { return int.Parse(lblLunarDate.Text); }
            set { lblLunarDate.Text = value.ToString(); }
        }

        [Description("Tool tip"),
        Category("Behavior"),
        Browsable(true)]
        public string ToolTip
        {
            get { return toolTip1.GetToolTip(lblSolarDate); }
            set { toolTip1.SetToolTip(lblSolarDate, value); }
        }
        #endregion
    }
}
