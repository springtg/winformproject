using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace FlexCDC.FOB.CBDExcel.V_1_220
{
    class XMLExporter
    {
        private string _factory, _obs_id, _obs_type, _style_cd;
        private string _season, _dev_name, _model_name, _bom_id, _fob_type, _round;

        private string _path;

        private DataTable _dt_header = null;
        private DataTable _dt_upper = null;
        private DataTable _dt_packing = null;
        private DataTable _dt_midsole = null;
        private DataTable _dt_outsole = null;
        private DataTable _dt_labor = null;
        private DataTable _dt_overhead = null;
        private DataTable _dt_sample_mold = null;
        private DataTable _dt_prod_mold = null;
        private DataTable _dt_5523 = null;
        private DataTable _dt_mold_toolcalc = null;

        //private DataTable _dt_etc = null;

        private int maxCnt = 1, nikeMoldCodeCnt = 1;

        public XMLExporter(string _factory, string _obs_id, string _obs_type, string _style_cd)
        {
            this._factory = _factory;
            this._obs_id = _obs_id;
            this._obs_type = _obs_type;
            this._style_cd = _style_cd;
        }

        #region Export

        public bool ExportXML()
        {
            if (!GetData())
                return false;

            System.IO.FileStream fsWriteXml = null;
            bool success = true;

            try
            {
                if (_dt_header != null && _dt_header.Rows.Count > 0)
                {
                    //string fileName = _factory + "_" + _obs_id + "_" + _obs_type + "_" + _style_cd + ".xml";
                    string fileName = _season + "-" + _dev_name + "-" + _model_name + "-" + _bom_id + "-" + _fob_type + ".xml";
                    string fullName = _path + "\\" + fileName;
                    string xmlnsNS = "http://www.w3.org/2000/xmlns/";
                    string namespaceURIOD = "urn:schemas-microsoft-com:officedata";
                    string namespaceURIXsi = "http://www.w3.org/2001/XMLSchema-instance";
                    string schemaLocation = "http://sephiroth.dskorea.com/NewCBDxmlSchema.xsd";

                    fsWriteXml = new System.IO.FileStream(fullName, System.IO.FileMode.Create, FileAccess.Write);

                    XmlDocument doc = new XmlDocument();
                    doc.AppendChild(doc.CreateXmlDeclaration("1.0", "utf-8", "yes"));
                    doc.AppendChild(doc.CreateComment("CBD Xml"));

                    XmlNode nRoot = doc.CreateNode(XmlNodeType.Element, "dataroot", String.Empty);

                    //XmlAttribute aSchema = doc.CreateAttribute("xsi", "noNamespaceSchemaLocation", namespaceURIXsi);
                    //aSchema.InnerText = schemaLocation;
                    //nRoot.Attributes.Append(aSchema);

                    XmlAttribute aOd = doc.CreateAttribute("xmlns", "od", xmlnsNS);
                    aOd.InnerText = namespaceURIOD;
                    nRoot.Attributes.Append(aOd);

                    XmlAttribute aXsi = doc.CreateAttribute("xmlns", "xsi", xmlnsNS);
                    aXsi.InnerText = namespaceURIXsi;
                    nRoot.Attributes.Append(aXsi);

                    XmlAttribute aGen = doc.CreateAttribute("generated");
                    aGen.InnerText = System.DateTime.Now.ToString("yyyy-MM-ddThh:mm:ss");
                    nRoot.Attributes.Append(aGen);

                    doc.AppendChild(nRoot);

                    XmlNode nHeader = MakeNodeHeader(doc, nRoot);
                    if (nHeader != null)
                    {
                        MakeNode5523(doc, nHeader); 
                        MakeNodeLabor(doc, nHeader);
                        MakeNodeMidSole(doc, nHeader);
                        MakeNodeMold(doc, nHeader, _dt_sample_mold);
                        MakeNodeMold(doc, nHeader, _dt_prod_mold);
                        MakeNodeOutSole(doc, nHeader);
                        MakeNodeOverhead(doc, nHeader);
                        MakeNodePacking(doc, nHeader);
                        MakeNodeUpper(doc, nHeader);
                    }

                    doc.Save(fsWriteXml);
                    success = true;
                }
                else // 검색된 결과가 없는 경우
                {
                    success = false;
                }
            }
            catch (Exception ex)
            {
                success = false;
                throw ex;
            }
            finally
            {
                if (fsWriteXml != null)
                    fsWriteXml.Close();
            }

            return success;
        }

        // Tbl_Imp_CBDHeader
        private XmlNode MakeNodeHeader(XmlDocument arg_doc, XmlNode arg_parent)
        {
            if (_dt_header == null || _dt_header.Rows.Count <= 0)
                return null;

            XmlNode nCBDHeader = arg_doc.CreateNode(XmlNodeType.Element, "Tbl_Imp_CBDHeader", String.Empty);

            for (int cIdx = 0; cIdx < _dt_header.Columns.Count; cIdx++)
            {
                string tagName = _dt_header.Columns[cIdx].ColumnName;
                string value = _dt_header.Rows[0].ItemArray[cIdx].ToString();

                XmlNode nNodeTemp = arg_doc.CreateNode(XmlNodeType.Element, tagName, String.Empty);
                if (!value.Trim().Equals(""))
                    nNodeTemp.InnerText = value;

                nCBDHeader.AppendChild(nNodeTemp);
            }

            arg_parent.AppendChild(nCBDHeader);

            return nCBDHeader;
        }

        // Tbl_Imp_Upper
        private bool MakeNodeUpper(XmlDocument arg_doc, XmlNode arg_parent)
        {
            if (_dt_upper == null)
                return false;

            for (int i = 0; i < _dt_upper.Rows.Count; i++)
            {
                XmlNode nUpper = arg_doc.CreateNode(XmlNodeType.Element, "Tbl_Imp_Upper", String.Empty);

                for (int cIdx = 0; cIdx < _dt_upper.Columns.Count; cIdx++)
                {
                    string tagName = _dt_upper.Columns[cIdx].ColumnName;
                    string value = _dt_upper.Rows[i].ItemArray[cIdx].ToString();

                    XmlNode nNodeTemp = arg_doc.CreateNode(XmlNodeType.Element, tagName, string.Empty);
                    if (!value.Trim().Equals(""))
                        nNodeTemp.InnerText = value;

                    nUpper.AppendChild(nNodeTemp);
                }

                arg_parent.AppendChild(nUpper);
            }

            return true;
        }

        // Tbl_Imp_Packing
        private bool MakeNodePacking(XmlDocument arg_doc, XmlNode arg_parent)
        {
            if (_dt_packing == null)
                return false;

            for (int i = 0; i < _dt_packing.Rows.Count; i++)
            {
                XmlNode nPacking = arg_doc.CreateNode(XmlNodeType.Element, "Tbl_Imp_Packaging", String.Empty);

                for (int cIdx = 0; cIdx < _dt_packing.Columns.Count; cIdx++)
                {
                    string tagName = _dt_packing.Columns[cIdx].ColumnName;
                    string value = _dt_packing.Rows[i].ItemArray[cIdx].ToString();

                    XmlNode nNodeTemp = arg_doc.CreateNode(XmlNodeType.Element, tagName, string.Empty);
                    if (!value.Trim().Equals(""))
                        nNodeTemp.InnerText = value;

                    nPacking.AppendChild(nNodeTemp);
                }

                arg_parent.AppendChild(nPacking);
            }

            return true;
        }

        // Tbl_Imp_Outsole
        private bool MakeNodeOutSole(XmlDocument arg_doc, XmlNode arg_parent)
        {
            if (_dt_outsole == null)
                return false;

            for (int i = 0; i < _dt_outsole.Rows.Count; i++)
            {
                XmlNode nOutsole = arg_doc.CreateNode(XmlNodeType.Element, "Tbl_Imp_Outsole", String.Empty);

                for (int cIdx = 0; cIdx < _dt_outsole.Columns.Count; cIdx++)
                {
                    string tagName = _dt_outsole.Columns[cIdx].ColumnName;
                    string value = _dt_outsole.Rows[i].ItemArray[cIdx].ToString();

                    XmlNode nNodeTemp = arg_doc.CreateNode(XmlNodeType.Element, tagName, string.Empty);
                    if (!value.Trim().Equals(""))
                        nNodeTemp.InnerText = value;

                    nOutsole.AppendChild(nNodeTemp);
                }

                arg_parent.AppendChild(nOutsole);
            }

            return true;
        }

        // Tbl_Imp_Outsole
        private bool MakeNodeMidSole(XmlDocument arg_doc, XmlNode arg_parent)
        {
            if (_dt_midsole == null)
                return false;

            for (int i = 0; i < _dt_midsole.Rows.Count; i++)
            {
                XmlNode nMidsole = arg_doc.CreateNode(XmlNodeType.Element, "Tbl_Imp_Midsole", String.Empty);

                for (int cIdx = 0; cIdx < _dt_midsole.Columns.Count; cIdx++)
                {
                    string tagName = _dt_midsole.Columns[cIdx].ColumnName;
                    string value = _dt_midsole.Rows[i].ItemArray[cIdx].ToString();

                    XmlNode nNodeTemp = arg_doc.CreateNode(XmlNodeType.Element, tagName, string.Empty);
                    if (!value.Trim().Equals(""))
                        nNodeTemp.InnerText = value;

                    nMidsole.AppendChild(nNodeTemp);
                }

                arg_parent.AppendChild(nMidsole);
            }

            return true;
        }


        // Tbl_Imp_Labor
        private bool MakeNodeLabor(XmlDocument arg_doc, XmlNode arg_parent)
        {
            if (_dt_labor == null)
                return false;

            for (int i = 0; i < _dt_labor.Rows.Count; i++)
            {
                XmlNode nLabor = arg_doc.CreateNode(XmlNodeType.Element, "Tbl_Imp_Labor", String.Empty);

                _dt_labor.Rows[i]["LaborKey"] = ++maxCnt;
                _dt_labor.Rows[i]["LaborID"] = maxCnt;

                for (int cIdx = 0; cIdx < _dt_labor.Columns.Count; cIdx++)
                {
                    string tagName = _dt_labor.Columns[cIdx].ColumnName;
                    string value = _dt_labor.Rows[i].ItemArray[cIdx].ToString();

                    XmlNode nNodeTemp = arg_doc.CreateNode(XmlNodeType.Element, tagName, string.Empty);
                    if (!value.Trim().Equals(""))
                        nNodeTemp.InnerText = value;

                    nLabor.AppendChild(nNodeTemp);
                }

                arg_parent.AppendChild(nLabor);
            }

            return true;
        }


        // Tbl_Imp_Mold
        private bool MakeNodeMold(XmlDocument arg_doc, XmlNode arg_parent, DataTable arg_dt)
        {
            if (arg_dt == null)
                return false;

            Random rnd = new Random();            

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                XmlNode nMold = arg_doc.CreateNode(XmlNodeType.Element, "Tbl_Imp_Mold", String.Empty);

                arg_dt.Rows[i]["MoldKey"] = ++maxCnt;
                arg_dt.Rows[i]["MoldID"] = maxCnt;

                arg_dt.Rows[i]["PccMoldType"] = (rnd.Next(2) == 0 ? "Aluminum" : "Steel");
                //arg_dt.Rows[i]["NikeMoldCode"] = "NIKECODE" + nikeMoldCodeCnt++;

                for (int cIdx = 0; cIdx < arg_dt.Columns.Count; cIdx++)
                {
                    string tagName = arg_dt.Columns[cIdx].ColumnName;

                    if (tagName.Equals("PIM_Seq"))
                    {
                        string value = arg_dt.Rows[i].ItemArray[cIdx].ToString();

                        if (!value.Trim().Equals(""))
                        {
                            string sMoldCost = arg_dt.Rows[i]["NikeMoldCode"].ToString(); ;
                            string sPIMSeq = arg_dt.Rows[i]["PIM_Seq"].ToString(); ;
                            MakeMoldToolCalc(arg_doc, nMold, sMoldCost, sPIMSeq);
                        }

                    }
                    else
                    {
                        string value = arg_dt.Rows[i].ItemArray[cIdx].ToString();

                        XmlNode nNodeTemp = arg_doc.CreateNode(XmlNodeType.Element, tagName, string.Empty);
                        if (!value.Trim().Equals(""))
                        {
                            nNodeTemp.InnerText = value;
                        }

                        nMold.AppendChild(nNodeTemp);
                    }
                }

                arg_parent.AppendChild(nMold);
            }

            return true;
        }


        // Tbl_Imp_Overhead
        private bool MakeNodeOverhead(XmlDocument arg_doc, XmlNode arg_parent)
        {
            if (_dt_overhead == null)
                return false;

            for (int i = 0; i < _dt_overhead.Rows.Count; i++)
            {
                XmlNode nOverhead = arg_doc.CreateNode(XmlNodeType.Element, "Tbl_Imp_Overhead", String.Empty);

                _dt_overhead.Rows[i]["OverheadKey"] = ++maxCnt;
                _dt_overhead.Rows[i]["OverheadID"] = maxCnt;

                for (int cIdx = 0; cIdx < _dt_overhead.Columns.Count; cIdx++)
                {
                    string tagName = _dt_overhead.Columns[cIdx].ColumnName;
                    string value = _dt_overhead.Rows[i].ItemArray[cIdx].ToString();

                    XmlNode nNodeTemp = arg_doc.CreateNode(XmlNodeType.Element, tagName, string.Empty);
                    if (!value.Trim().Equals(""))
                        nNodeTemp.InnerText = value;

                    nOverhead.AppendChild(nNodeTemp);
                }

                arg_parent.AppendChild(nOverhead);
            }

            return true;
        }

        // Tbl_Imp_5523
        private bool MakeNode5523(XmlDocument arg_doc, XmlNode arg_parent)
        {
            if (_dt_5523 == null)
                return false;

            for (int i = 0; i < _dt_5523.Rows.Count; i++)
            {
                XmlNode n5523 = arg_doc.CreateNode(XmlNodeType.Element, "Tbl_Imp_5523", String.Empty);

                for (int cIdx = 0; cIdx < _dt_5523.Columns.Count; cIdx++)
                {
                    string tagName = _dt_5523.Columns[cIdx].ColumnName;
                    string value = _dt_5523.Rows[i].ItemArray[cIdx].ToString();

                    XmlNode nNodeTemp = arg_doc.CreateNode(XmlNodeType.Element, tagName, string.Empty);
                    if (!value.Trim().Equals(""))
                        nNodeTemp.InnerText = value;

                    n5523.AppendChild(nNodeTemp);
                }

                arg_parent.AppendChild(n5523);
            }

            return true;
        }

        // Tbl_Imp_Mold_ToolCalc
        private bool MakeMoldToolCalc(XmlDocument arg_doc, XmlNode arg_parent, string arg_mold_cd, string arg_pim_seq)
        {
            if (_dt_mold_toolcalc == null)
                return false;

            DataRow[] vDRs = _dt_mold_toolcalc.Select("mold_code = '" + arg_mold_cd + "' and pim_seq = '" + arg_pim_seq + "'");

            foreach (DataRow vDR in vDRs)
            {
                XmlNode nMoldToolCalc = arg_doc.CreateNode(XmlNodeType.Element, "Tbl_Imp_Mold_ToolCalc", String.Empty);

                for (int cIdx = 0; cIdx < _dt_mold_toolcalc.Columns.Count - 2; cIdx++)
                {
                    string tagName = _dt_mold_toolcalc.Columns[cIdx].ColumnName;
                    string value = vDR[cIdx].ToString();

                    XmlNode nNodeTemp = arg_doc.CreateNode(XmlNodeType.Element, tagName, string.Empty);

                    if (tagName.Equals("Moldkey"))
                    {
                        nNodeTemp.InnerText = maxCnt.ToString();
                    }
                    else
                    {
                        if (!value.Trim().Equals(""))
                            nNodeTemp.InnerText = value;
                    }

                    nMoldToolCalc.AppendChild(nNodeTemp);
                }

                arg_parent.AppendChild(nMoldToolCalc);
            }


            //for (int i = 0; i < _dt_overhead.Rows.Count; i++)
            //{
            //    XmlNode nMoldToolCalc = arg_doc.CreateNode(XmlNodeType.Element, "Tbl_Imp_Mold_ToolCalc", String.Empty);

            //    for (int cIdx = 0; cIdx < _dt_overhead.Columns.Count; cIdx++)
            //    {
            //        string tagName = _dt_overhead.Columns[cIdx].ColumnName;
            //        string value = _dt_overhead.Rows[i].ItemArray[cIdx].ToString();

            //        XmlNode nNodeTemp = arg_doc.CreateNode(XmlNodeType.Element, tagName, string.Empty);

            //        if (tagName.Equals("MoldKey"))
            //        {
            //            nNodeTemp.InnerText = maxCnt;
            //        }
            //        else
            //        {
            //            if (!value.Trim().Equals(""))
            //                nNodeTemp.InnerText = value;
            //        }

            //        nMoldToolCalc.AppendChild(nNodeTemp);
            //    }

            //    arg_parent.AppendChild(nMoldToolCalc);
            //}

            return true;
        }

        private bool GetData()
        {
            DBMngr mgt = new DBMngr();

            System.Data.DataSet vDs = mgt.SELECT_EBM_FOB(_factory, _obs_id, _obs_type, _style_cd, 
                _dev_name, _bom_id, _fob_type, _round);

            if (vDs != null)
            {
                if (vDs.Tables.Count == 12)
                {
                    _dt_header = vDs.Tables[0];
                    _dt_upper = vDs.Tables[1];
                    _dt_packing = vDs.Tables[2];
                    _dt_midsole = vDs.Tables[3];
                    _dt_outsole = vDs.Tables[4];
                    _dt_labor = vDs.Tables[5];
                    _dt_overhead = vDs.Tables[6];
                    _dt_sample_mold = vDs.Tables[7];
                    _dt_prod_mold = vDs.Tables[8];
                    _dt_5523 = vDs.Tables[9];
                    _dt_mold_toolcalc = vDs.Tables[10];
                    //_dt_etc = vDs.Tables[9];

                    if (vDs.Tables[9].Rows.Count > 0)
                        maxCnt = Convert.ToInt32(vDs.Tables[11].Rows[0].ItemArray[0].ToString());

                    return true;
                }

                return false;
            }

            return false;
        }

        #endregion

        #region 프로퍼티

        public string Style_cd
        {
            get { return _style_cd; }
            set { _style_cd = value; }
        }

        public string Obs_type
        {
            get { return _obs_type; }
            set { _obs_type = value; }
        }

        public string Obs_id
        {
            get { return _obs_id; }
            set { _obs_id = value; }
        }

        public string Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }



        public string Fob_type
        {
            get { return _fob_type; }
            set { _fob_type = value; }
        }

        public string Bom_id
        {
            get { return _bom_id; }
            set { _bom_id = value; }
        }

        public string Model_name
        {
            get { return _model_name; }
            set { _model_name = value; }
        }

        public string Dev_name
        {
            get { return _dev_name; }
            set { _dev_name = value; }
        }

        public string Season
        {
            get { return _season; }
            set { _season = value; }
        }

        public string Round
        {
            get { return _round; }
            set { _round = value; }
        }

        #endregion

    }
}
