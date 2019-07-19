using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JTay.FrameWork;
using JTay.FrameWork.Enumerators;
using JTay.FrameWork.Interfaces;
using JTay.FrameWork.Support;
using JTay.NextGen;
using Microsoft.VisualBasic.Logging;

namespace NGDR_Workstation
{
    public partial class DR_Workstation : Form
    {

        private readonly string location;
        private readonly bool sameProvider;
        private readonly bool limitEnc;
        private readonly bool unZip;
        private readonly int limitNum;
        private static readonly IDataLayer ssDataLayer = DataLayerFactory.CreateDataLayer(DataSourceType.MySql, ConnectionStrings.ConnectionString("FT"));

        private readonly ArrayList LocationList = new ArrayList();


        public DR_Workstation()
        {
            InitializeComponent();
        }


    }
}
