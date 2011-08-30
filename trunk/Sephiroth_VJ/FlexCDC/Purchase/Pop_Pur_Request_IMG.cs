using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using Lassalle.Flow;
using System.IO;


namespace FlexCDC.Purchase
{
    public partial class Pop_Pur_Request_IMG : COM.PCHWinForm.Pop_Large_B
    {
        #region ����� ���� ����
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService ���� ��ü ����
        private float _MaxImageWidth = 792;
        private float _MaxImageHeight = 341;
        private int click_count = 1;        
        private Form_Pur_Request _main_form = null;
        private string _factory = "";
        private string _req_no  = "";
        private string _req_seq = "";
        private string _img_chk = "";

        public bool save_flg = false;
        #endregion

        #region ������
        public Pop_Pur_Request_IMG()
        {
            InitializeComponent();
        }
        public Pop_Pur_Request_IMG(Form_Pur_Request arg_form)
        {
            _main_form = arg_form;
            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Pop_Pur_Request_IMG_Load(object sender, EventArgs e)
        {
            try
            {
                Init_Form();
            }
            catch
            {

            }
            finally
            {
 
            }
        }

        private void Init_Form()
        {
            this.Text = "Submaterial Image";
            this.lbl_MainTitle.Text = "Submaterial Image";
                        
            tbtn_New.Enabled     = true;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = false;
            tbtn_Conform.Enabled = false;
            tbtn_Create.Enabled  = false;

            int sct_row = _main_form.fgrid_detail.Selection.r1;

            _factory = _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxFACTORY].ToString().Trim();
            _req_no  = _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxREQ_NO].ToString().Trim();
            _req_seq = _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxREQ_SEQ].ToString().Trim();
            _img_chk = _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxIMG_YN].ToString().Trim().ToUpper();

            
            addflow.DefLinkProp.AdjustOrg = true;
            addflow.DefLinkProp.AdjustDst = true;

            tbtn_Search_Click(null, null);


        }        
        #endregion

        #region Image Control
        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                click_count++;
                Lassalle.Flow.Node node = new Lassalle.Flow.Node(click_count * 10, click_count * 10, 100, 40, "");
                                
                node.Tag = "";
                node.Shape.Style = ShapeStyle.Rectangle;
                node.Font = new Font("Verdana", 7);

                addflow.Nodes.Add(node);
            }
            catch
            {

            }
        }
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                int sct_row = _main_form.fgrid_detail.Selection.r1;
                string img_chk = _main_form.fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxIMG_YN].ToString().Trim().ToUpper();
                
                Set_Addflow();

                if (img_chk.Equals("TRUE"))
                    Image_Loading_Data();
                else
                    Image_Loading_File();
            }
            catch
            {
 
            }
        }
        private void addflow_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button.Equals(MouseButtons.Left))
                {
                    //Set_Editable_Node((Lassalle.Flow.AddFlow)sender);
                }
                else if (e.Button.Equals(MouseButtons.Right))
                {
                    Display_Property_Page((Lassalle.Flow.AddFlow)sender);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "addflow_Img_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addflow_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    Lassalle.Flow.Item item = addflow.PointedItem;

                    if (item != null)
                    {
                        Lassalle.DlgFlow.DlgFlow dlgflow = new Lassalle.DlgFlow.DlgFlow();

                        if (item.GetType() == typeof(Lassalle.Flow.Node))
                        {
                            Lassalle.Flow.Node node = (Lassalle.Flow.Node)item;
                            node.Remove();
                        }
                        else if (item.GetType() == typeof(Lassalle.Flow.Link))
                        {
                            Lassalle.Flow.Link link = (Lassalle.Flow.Link)item;
                            link.Remove();
                        }
                    }
                }
            }
            catch
            {

            }
        }
        private void addflow_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Set_Editable_Node((Lassalle.Flow.AddFlow)sender);
            }
            catch
            {

            }
        }        

        private void Image_Loading_File()
        {
            string m_strPath = null;
            OpenFileDialog openDlg = new OpenFileDialog();

            // ���Ͽ��¿� ���� ����ȯ�� ���� �κ� >> ����
            // ���� ���ε�Ǵ� ������ "gif, jpg" �� �����ϸ�, �߰� �����ϴ�.
            openDlg.InitialDirectory = "c:\\";
            openDlg.DefaultExt = "jpg, gif";
            openDlg.Filter = "Image File (*.jpg)|*.jpg|Image File(*.gif)|*.gif";
            openDlg.RestoreDirectory = false;
            // ���Ͽ��¿� ���� ����ȯ�� �����κ� >> ��

            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                m_strPath = openDlg.FileName;

                // �̹��� Resource �߰�.
                addflow.Images.Add(m_strPath);
                
                // ȣ��� �̹��� Resource �� Size ���ϴ� �κ�
                Image img = Image.FromFile(m_strPath);
                float imgFwidth = float.Parse(img.Width.ToString());
                float imgFheight = float.Parse(img.Height.ToString());

                // Create nodes

                // �̹��� ũ�Ⱑ �⺻ addflow �������� Ŭ ���� �ٿ��� load
                imgFheight = (imgFheight < _MaxImageHeight) ? imgFheight : _MaxImageHeight;
                imgFwidth = (imgFwidth < _MaxImageWidth) ? imgFwidth : _MaxImageWidth;
                Lassalle.Flow.Node node1 = new Lassalle.Flow.Node(10, 10, imgFwidth, imgFheight);


                // �̹��� ����� ���λ�
                node1.DrawColor = Color.Transparent;
                // �̹��� ����� ����ȭ
                node1.FillColor = Color.Transparent;
                node1.Shape.Style = Lassalle.Flow.ShapeStyle.Rectangle;
                node1.AutoSize = Lassalle.Flow.AutoSize.ImageToNode;

                // ��� �±װ� -1 �̸� �̹��� ����� �����ϰ�, edit ���ϵ��� ó��
                node1.Tag = "-1";

                int imgIndex = addflow.Images.Count;

                if (imgIndex <= 0)
                {
                    node1.ImageIndex = 0;
                }
                else
                {
                    node1.ImageIndex = (imgIndex - 1);
                }

                addflow.DefLinkProp.AdjustOrg = true;
                addflow.DefLinkProp.AdjustDst = true;

                addflow.Nodes.Add(node1);
            }
        }
        private void Image_Loading_Data()
        {
            DataTable dt = SELECT_REQ_IMAGE();

            int dt_rows = dt.Rows.Count;
            int dt_cols = dt.Columns.Count;

            for (int i = 0; i < dt_rows; i++)
            {
                byte[] MyData = null;
                MyData = (byte[])dt.Rows[i].ItemArray[0];
                                
                MemoryStream ms = new MemoryStream(MyData);
                System.Drawing.Bitmap true_image = new System.Drawing.Bitmap(ms);

                Image img = true_image;
                float imgFwidth = float.Parse(img.Width.ToString());
                float imgFheight = float.Parse(img.Height.ToString());

                Rectangle rect = new Rectangle(1, 1, Convert.ToInt32(imgFwidth - 2), Convert.ToInt32(imgFheight - 2)); // �߶� �������� ���  
                //Rectangle rect = new Rectangle(1, 1, Convert.ToInt32(imgFwidth), Convert.ToInt32(imgFheight)); // �߶� �������� ���  
                PixelFormat pixf = img.PixelFormat; // �̹����� �ȼ����� 
                Bitmap bt_img = ((Bitmap)img).Clone(rect, pixf);
                img = (Image)bt_img;

                imgFwidth = float.Parse(img.Width.ToString());
                imgFheight = float.Parse(img.Height.ToString());
                
                addflow.Images.Add(img);
                // Create nodes
                // �̹��� ũ�Ⱑ �⺻ addflow �������� Ŭ ���� �ٿ��� load
                imgFheight = (imgFheight < _MaxImageHeight) ? imgFheight : _MaxImageHeight;
                imgFwidth = (imgFwidth < _MaxImageWidth) ? imgFwidth : _MaxImageWidth;                

                Lassalle.Flow.Node node1 = new Lassalle.Flow.Node(0, 0, true_image.Width, true_image.Height);

                // �̹��� ����� ���λ�
                node1.DrawColor = Color.Transparent;
                // �̹��� ����� ����ȭ
                node1.FillColor = Color.Transparent;
                node1.Shape.Style = Lassalle.Flow.ShapeStyle.Rectangle;
                //node1.AutoSize = Lassalle.Flow.AutoSize.ImageToNode;
                node1.Font = new Font("Verdana", 7);


                // ��� �±װ� -1 �̸� �̹��� ����� �����ϰ�, edit ���ϵ��� ó��
                node1.Tag = "-1";

                int imgIndex = addflow.Images.Count;

                if (imgIndex <= 0)
                {
                    node1.ImageIndex = 0;
                }
                else
                {
                    node1.ImageIndex = (imgIndex - 1);                    
                }

                addflow.DefLinkProp.AdjustOrg = true;
                addflow.DefLinkProp.AdjustDst = true;

                addflow.Nodes.Add(node1);
            }
        }
        public void Set_Addflow()
        {            
            addflow.Items.Clear();
            addflow.ResetDefNodeProp();
            addflow.ResetDefLinkProp();
            addflow.ResetGrid();
            addflow.ResetText();
            //addflow.Alignment = Alignment.CenterMIDDLE;
            //addflow.Nodes.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            //addflow.DrawColor = Color.Black;
            //addflow.DrawWidth = 1;
            //addflow.FillColor = Color.White;
            //addflow.Font = new Font("Verdana", 7);
            //addflow.Gradient = false;
            //addflow.Shape.Style = ShapeStyle.Connector;
            //addflow.TextColor = Color.Black;
            //addflow.DrawColor = Color.Gray;

            addflow.DefNodeProp.Shape.Style = ShapeStyle.Rectangle;                        
        }
        private void Set_Editable_Node(Lassalle.Flow.AddFlow arg_addflow)
        {
            Item item = arg_addflow.PointedItem;
            Lassalle.Flow.Node node = null;

            if (item is Lassalle.Flow.Node)
            {
                node = (Lassalle.Flow.Node)item;

                // �̹��� ���
                if (node.Tag.ToString() == "-1")
                {
                    node.LabelEdit = false;
                    addflow.CanDrawLink = false;
                }
                else
                {
                    node.LabelEdit = true;
                    addflow.CanDrawLink = true;
                }
            }
        }
        private void Display_Property_Page(Lassalle.Flow.AddFlow arg_addflow)
        {
            Item item = arg_addflow.PointedItem;

            Lassalle.DlgFlow.DlgFlow dlgflow = new Lassalle.DlgFlow.DlgFlow();
            if (item is Lassalle.Flow.Node)
            {
                Lassalle.Flow.Node node = (Lassalle.Flow.Node)item;
                dlgflow.NodePropertyPage(addflow, node);
            }
            else if (item is Lassalle.Flow.Link)
            {
                Lassalle.Flow.Link link = (Lassalle.Flow.Link)item;
                dlgflow.LinkPropertyPage(addflow, link);
            }
        }

        private DataTable SELECT_REQ_IMAGE()
        {
            MyOraDB.ReDim_Parameter(4);
            MyOraDB.Process_Name = "PKG_SXP_REQ_01_SELECT.SELECT_REQ_IMAGE";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_REQ_NO";
            MyOraDB.Parameter_Name[2] = "ARG_REQ_SEQ";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = _factory;
            MyOraDB.Parameter_Values[1] = _req_no;
            MyOraDB.Parameter_Values[2] = _req_seq;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Save Image
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                
                if (_main_form != null)
                {
                    Metafile mf = addflow.ExportMetafile(false, true, false, false, false);
                    string targetPath = Application.StartupPath + @"\" + _req_no + _req_seq;
                    mf.Save(targetPath, ImageFormat.Jpeg);

                    if (_img_chk.Equals("TRUE"))
                    {
                        if (DialogResult.Yes == MessageBox.Show("Old image delete...\r\nDo you want to continue?", "Information", MessageBoxButtons.YesNo))
                        {
                            SAVE_REQ_IMAGE("U", _factory, _req_no, _req_seq, targetPath);
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        SAVE_REQ_IMAGE("I", _factory, _req_no, _req_seq, targetPath); 
                    }

                    FileInfo fi = new FileInfo(targetPath);
                    if (fi.Exists)
                    {
                        fi.Delete();
                    }

                    save_flg = true;
                }

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private bool SAVE_REQ_IMAGE(string arg_division, string arg_factory, string arg_req_no, string arg_req_seq, string arg_file_name)
        {
            try
            {
                bool ret;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE��
                MyOraDB.Process_Name = "PKG_SXP_REQ_01.SAVE_SXP_REQ_IMAGE";

                //02.ARGURMENT ��
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_REQ_NO";
                MyOraDB.Parameter_Name[3] = "ARG_REQ_SEQ";
                MyOraDB.Parameter_Name[4] = "ARG_IMAGE";
                MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";

                //03.DATA TYPE ����
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Blob;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;

                //04.DATA ����
                MyOraDB.Parameter_Values[0] = arg_division;
                MyOraDB.Parameter_Values[1] = arg_factory;
                MyOraDB.Parameter_Values[2] = arg_req_no;
                MyOraDB.Parameter_Values[3] = arg_req_seq;
                MyOraDB.Parameter_Values[4] = " ";
                MyOraDB.Parameter_Values[5] = ClassLib.ComVar.This_User;

                byte[] photo = null;
                photo = GetPhoto(arg_file_name);
                ret = MyOraDB.Exe_Modify_Procedure_Blob(photo);
                return ret;                
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Save_Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private byte[] GetPhoto(string arg_filename)
        {
            FileStream fs = new FileStream(arg_filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            byte[] photo = br.ReadBytes((int)fs.Length);

            br.Close();
            fs.Close();

            return photo;

        }
        #endregion

        #region ContextMenu Event
        private void mnu_add_text_Click(object sender, EventArgs e)
        {
            try
            {
                click_count++;
                Lassalle.Flow.Node node = new Lassalle.Flow.Node(click_count * 10, click_count * 10, 100, 40, "");
                                
                node.Tag = "";
                node.Shape.Style = ShapeStyle.Rectangle;
                node.Font = new Font("Verdana", 9);               

                addflow.Nodes.Add(node);
            }
            catch
            {

            }
        }

        private void mnu_add_image_Click(object sender, EventArgs e)
        {
            try
            {
                Image_Loading_File();
            }
            catch
            {
 
            }
        }
        #endregion
                
    }
}

