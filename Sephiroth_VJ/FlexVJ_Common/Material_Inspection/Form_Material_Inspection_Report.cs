using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace FlexVJ_Common.Material_Inspection
{
    public partial class Form_Material_Inspection_Report : COM.VJ_CommonWinForm.Pop_Small
    {
        public Form_Material_Inspection_Report()
        {
            InitializeComponent();
        }

        #region "Event"
        private void btnPrint_Leave(object sender, EventArgs e)
        {
            Button l_Button = (Button)sender;
            l_Button.ImageIndex = 0;
        }

        private void btnPrint_Enter(object sender, EventArgs e)
        {
            Button l_Button = (Button)sender;
            l_Button.ImageIndex = 1;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (rbt_DailyInsp.Checked == false && rbt_WeeklyInsp.Checked == false && rbt_WeeklyRej.Checked == false)
            {
                COM.ComFunction.User_Message("Pls, Select one case to print!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ArrayList arr = new ArrayList();
            if (rbt_DailyInsp.Checked)
                arr.Add(1);
            if (rbt_WeeklyInsp.Checked)
                arr.Add(2);
            if (rbt_WeeklyRej.Checked)
                arr.Add(3);
            arr.Add(BuildPara());
            this.Tag = arr;
            DialogResult = DialogResult.OK;
        }
        
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Form_Material_Inspection_Report_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                InitForm();
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
                COM.ComFunction.User_Message(ex.Message, "Form_Material_Inspection_Report_Load");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void rbt_DailyInsp_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton l_RadioButton = (RadioButton)sender;
            if (l_RadioButton.Checked)
                dpk_DailyInsp.Enabled = true;
            else
                dpk_DailyInsp.Enabled = false;
        }

        private void rbt_WeeklyInsp_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton l_RadioButton = (RadioButton)sender;
            if (l_RadioButton.Checked)
                dpk_WeeklyInsp.Enabled = true;
            else
                dpk_WeeklyInsp.Enabled = false;
        }

        private void rbt_WeeklyRej_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton l_RadioButton = (RadioButton)sender;
            if (l_RadioButton.Checked)
                dpk_WeeklyRej.Enabled = true;
            else
                dpk_WeeklyRej.Enabled = false;
        }


        #endregion


        #region "Method"
        private void InitForm()
        {
            // factory set
            DataTable vDt = COM.ComFunction.Select_Factory_List();
            COM.ComCtl.Set_ComboList(vDt, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
            cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

        }

        private string BuildPara()
        {
            string Para = " ";

            int iCnt = 3;
            string[] aHead = new string[iCnt];
            aHead[0] = COM.ComFunction.Empty_Combo(cmb_Factory, string.Empty);
            if (rbt_DailyInsp.Checked)
                aHead[1] = dpk_DailyInsp.Value.ToString("yyyyMMdd");
            if (rbt_WeeklyInsp.Checked)
                aHead[1] = dpk_WeeklyInsp.Value.ToString("yyyyMMdd");
            if (rbt_WeeklyRej.Checked)
                aHead[1] = dpk_WeeklyRej.Value.ToString("yyyyMMdd");
            aHead[2] = "";

            Para = " /rp ";
            for (int i = 1; i <= iCnt; i++)
            {
                Para = Para + "[" + aHead[i - 1] + "] ";
            }
            return Para;
        }
        #endregion


    }
}