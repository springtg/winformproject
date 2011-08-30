using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexEIS.EIS.Report
{
    public partial class Form_RdViewer : Form
    {

        #region 积己磊


        public Form_RdViewer()
        {
            InitializeComponent();
        }


        private string txt_FileName = " ";
        private string mrd_FileName = " ";
        private string sParam = " ";

        public Form_RdViewer(string arg_TFilename, string arg_MrdFileName, string arg_param)
        {
            InitializeComponent();

            txt_FileName = arg_TFilename;
            mrd_FileName = arg_MrdFileName;
            sParam = arg_param;
        }

        public Form_RdViewer(string arg_MrdFileName, string arg_param)
        {

            InitializeComponent();


            mrd_FileName = arg_MrdFileName;
            sParam = arg_param;


        }


        #endregion 

        #region 捞亥飘 贸府


        private void Form_RdViewer_Load(object sender, EventArgs e)
        {
            try
            {
                axRdviewer401.FileOpen(@mrd_FileName, sParam);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion



    }
}