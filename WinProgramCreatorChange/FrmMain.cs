using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PowercasterV2.ProgramDataSet;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;

namespace WinProgramCreatorChange
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region DBOperate
        /// <summary>
        /// 根据登陆名获得用户信息
        /// </summary>
        /// <param name="LoginName"></param>
        /// <returns></returns>
        private UserInfo GetUserInfoByLoginName(string LoginName)
        {
            UserInfo _UserInfo = null;
            try
            {
                DataTable taskDataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(Globals.X1Connection))
                {
                    string sql = "Select UserID , UserName,FullName From users where UserName='" + LoginName + "'";
                    using (SqlDataAdapter sd = new SqlDataAdapter(sql, conn))
                    {
                        sd.Fill(taskDataTable);
                    }
                    if (taskDataTable.Rows.Count > 0)
                    {
                        _UserInfo = new UserInfo();
                        _UserInfo.FullName = taskDataTable.Rows[0]["FullName"].ToString();
                        _UserInfo.UserID = taskDataTable.Rows[0]["UserID"].ToString();
                        _UserInfo.UserName = taskDataTable.Rows[0]["UserName"].ToString();

                    }
                    else
                    {
                        _UserInfo = null;
                    }
                }
            }
            catch (Exception ex)
            {
                _UserInfo = null;
            }
            return _UserInfo;
        }

        /// <summary>
        /// 根据创建者获得节目
        /// </summary>
        /// <param name="CreatorUserID"></param>
        /// <returns></returns>
        private DataTable GetProgramsByCreatorUserID(string CreatorUserID)
        {
            DataTable ProgramDataTable = new DataTable();
            try
            {

                using (SqlConnection conn = new SqlConnection(Globals.X1Connection))
                {
                    string sql = "Select P.ProgramID ,P.ProgramTitle,P.CreatorUser,P.CreatorUserName,PLb.ProgramLibName,F.FolderName  ,P.CreateDateTime  from Program P,ProgramLib PLb,Folder F where P.ProgramLibID=PLb.ProgramLibID and   P.FolderID=F.FoldID and P.CreatorUser='" + CreatorUserID + "' order by CreateDateTime DESC";
                    using (SqlDataAdapter sd = new SqlDataAdapter(sql, conn))
                    {
                        sd.Fill(ProgramDataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                ProgramDataTable = null;
            }
            return ProgramDataTable;
        }

        /// <summary>
        /// 更新节目的制作者
        /// </summary>
        /// <param name="ProgramID">节目ID</param>
        /// <param name="NewCreator">新的制作者</param>
        /// <returns></returns>
        private bool UpdateProgramCreator(string ProgramID, UserInfo NewCreator)
        {
            bool isOK = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(Globals.X1Connection))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            conn.Open();
                            cmd.Connection = conn;
                            cmd.Transaction = conn.BeginTransaction();
                            cmd.CommandText = "update   Program  set CreatorUser='" + NewCreator.UserID + "',CreatorUserName='" + NewCreator.UserName + "' where ProgramID='" + ProgramID + "'";
                            cmd.ExecuteNonQuery();
                            cmd.Transaction.Commit();
                            isOK = true;
                        }
                        catch
                        {
                            if (cmd.Transaction != null)
                            {
                                cmd.Transaction.Rollback();
                            }
                            isOK = false; ;
                        }
                    }
                }
            }
            catch (Exception)
            {

                isOK = false; ;
            }
            return isOK;
        }

        #endregion



        private void btnQueryPrograms_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string CreatorName = this.bItemUserName.EditValue.ToString().Trim();
            if (CreatorName == null || CreatorName.Length <= 0)
            {
                XtraMessageBox.Show("请输入用户名！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            gcPrograms.DataSource = null;
            UserInfo _UserInfo = GetUserInfoByLoginName(CreatorName);
            if (_UserInfo != null)
            {
                DevExpress.Utils.WaitDialogForm dlg = new DevExpress.Utils.WaitDialogForm("用户:" + CreatorName + " 的节目", "正在查询", new Size(150, 50), this);
                DataTable dt = GetProgramsByCreatorUserID(_UserInfo.UserID);
                gcPrograms.DataSource = dt;
                dlg.Close();
                if (dt != null && dt.Rows.Count > 0)
                {
                    lblQueryInfo.Visibility = BarItemVisibility.Always;
                    lblQueryInfo.Caption = "用户:" + _UserInfo.UserName + "(" + _UserInfo.FullName + ") 的节目数量为" + dt.Rows.Count;
                }
                else
                {
                    lblQueryInfo.Visibility = BarItemVisibility.Never;
                }

            }
            else
            {
                lblQueryInfo.Visibility = BarItemVisibility.Never;
                XtraMessageBox.Show("未找到用户:" + this.bItemUserName.EditValue.ToString().Trim(), "提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChangeCrator_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            string CreatorName = this.bItemUserName.EditValue.ToString().Trim();
            if (CreatorName == null || CreatorName.Length <= 0)
            {
                XtraMessageBox.Show("请输入用户名！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FrmUsers _FrmUsers = new FrmUsers())
            {

                if (_FrmUsers.ShowDialog() == DialogResult.OK)
                {
                    UserInfo newuser = _FrmUsers.NewUser;


                    UserInfo _UserInfo = GetUserInfoByLoginName(CreatorName);
                    DataTable dt;
                    if (_UserInfo != null)
                    {
                        int OKCount = 0;
                        int ErrorCount = 0;
                        DevExpress.Utils.WaitDialogForm dlgQuery = new DevExpress.Utils.WaitDialogForm("用户:" + CreatorName + " 的节目", "正在查询", new Size(300, 50), this);
                        dt = GetProgramsByCreatorUserID(_UserInfo.UserID);
                        dlgQuery.Close();
                        if (dt != null)
                        {

                            string call = "确定将用户:" + _UserInfo.UserName + "(" + _UserInfo.FullName + ")的 " + dt.Rows.Count + " 条 节目转给 用户：" + newuser.UserName + "(" + newuser.FullName + ")";

                            if (XtraMessageBox.Show(call, "提示！", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                                return;
                            using (DevExpress.Utils.WaitDialogForm dlg = new DevExpress.Utils.WaitDialogForm("用户:" + CreatorName + " 的节目", "正在转换节目", new Size(300, 50), this))
                            {
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    if (this.UpdateProgramCreator(dt.Rows[i]["ProgramID"].ToString(), newuser))
                                    {
                                        dlg.SetCaption("节目:" + dt.Rows[i]["ProgramTitle"].ToString() + "转换成功");

                                        string SuccessData = newuser.FullName + "," + newuser.UserID + "," + dt.Rows[i]["ProgramTitle"].ToString() + "," + dt.Rows[i]["ProgramID"].ToString() + "," + dt.Rows[i]["CreatorUserName"].ToString() + "," + dt.Rows[i]["CreatorUser"].ToString();
                                        LogService.WriteSuccessData(SuccessData);
                                        OKCount++;
                                    }
                                    else
                                    {
                                        dlg.SetCaption("节目:" + dt.Rows[i]["ProgramTitle"].ToString() + "转换失败");

                                        string FailData = dt.Rows[i]["ProgramID"].ToString() + "," + dt.Rows[i]["ProgramTitle"].ToString();
                                        LogService.WriteFailData(FailData);
                                        ErrorCount++;
                                    }
                                }
                            }
                        }
                        string info = "转换完成";
                        if (OKCount == dt.Rows.Count)
                        {
                            info = "转换完成，全部成功！";
                        }
                        else
                        {
                            info = "转换完成，成功：" + OKCount + "条，失败：" + ErrorCount + "";
                        }
                        XtraMessageBox.Show(this, info, "提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        XtraMessageBox.Show(this,"未找到用户:" + this.bItemUserName.EditValue.ToString().Trim(), "提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnQueryPrograms_ItemClick(null, null);
            }
        }


    }
}
