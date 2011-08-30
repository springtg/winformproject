using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexEIS.EIS.Production
{
    public partial class Pop_Wait_UsingThread : Form
    {

        #region 생성자


        public Pop_Wait_UsingThread()
        {
            InitializeComponent();
        }


        #endregion 

        #region 변수 정의


        private bool _flag = true;
        private string _msg = "Processing...";


        #endregion

        #region 멤버 메서드


        public string Message
        {
            set
            {
                lbl_state.Text = value;
            }
        }

        public void Start()
        {
            timer.Start();
            Processing();
            this.ShowDialog();
        }

        public void Stop()
        {
            this.Close();
        }

        public void Loading()
        {
            lbl_state.Text = "Loading...";
        }

        public void Processing()
        {
            lbl_state.Text = "Processing...";
        }

        public void Complete()
        {
            lbl_state.Text = "Complete...";
        }

        public void Saveing()
        {
            lbl_state.Text = "Saving...";
        }


        #endregion

        #region 이벤트 처리


        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_state.Visible = _flag = !_flag;
        }


        private void Pop_Wait_UsingThread_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            this.Dispose(true);
        }


        #endregion

       


    }
}