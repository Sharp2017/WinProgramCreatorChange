using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PowercasterV2.ProgramDataSet;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace WinProgramCreatorChange
{
    public partial class FrmUsers : DevExpress.XtraEditors.XtraForm
    {
        private UserInfo newUser = null;

        public UserInfo NewUser
        {
            get { return newUser; }
            set { newUser = value; }
        }
       
        public FrmUsers()
        {
            InitializeComponent();
        } 
        
        /// <summary>
        /// 根据登陆名获得用户信息
        /// </summary>
        /// <param name="LoginName"></param>
        /// <returns></returns>
        private List<UserInfo> GetUserInfoByLoginName(string LoginName)
        {
            List<UserInfo> _UserInfoList = null;
            try
            {
                DataTable taskDataTable = new DataTable();
                using (SqlConnection conn = new SqlConnection(Globals.X1Connection))
                {
                    string sql = "Select UserID , UserName,FullName From users where UserName like '%" + LoginName + "%'";
                    if (LoginName == null || LoginName.Length <= 0)
                    {
                        sql = "Select UserID , UserName,FullName From users  order by UserName ";
                    }
                    else
                    {
                        sql = "Select UserID , UserName,FullName From users where UserName='" + LoginName + "'";
                    } 
                    
                    using (SqlDataAdapter sd = new SqlDataAdapter(sql, conn))
                    {
                        sd.Fill(taskDataTable);
                    }
                    if (taskDataTable!=null)
                    {
                        _UserInfoList = new List<UserInfo>();
                        for (int i = 0; i < taskDataTable.Rows.Count; i++)
                        {
                            UserInfo UserInfo = new UserInfo();
                            UserInfo.FullName = taskDataTable.Rows[i]["FullName"].ToString();
                            UserInfo.UserID = taskDataTable.Rows[i]["UserID"].ToString();
                            UserInfo.UserName = taskDataTable.Rows[i]["UserName"].ToString();
                            _UserInfoList.Add(UserInfo);
                        } 
                    }
                    else
                    {
                        _UserInfoList = null;
                    }
                }
            }
            catch (Exception ex)
            {
                _UserInfoList = null;
            }
            return _UserInfoList;
        }

        private void btnQueryUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcUsers.DataSource = null;
            string userName = "";
            if (bItemUserName.EditValue != null)
            {
                userName = bItemUserName.EditValue.ToString().Trim();
            }
            else
            {
                userName = "";

            }
            gcUsers.DataSource = GetUserInfoByLoginName(userName);
            if (true)
            {
                this.gvUsers.FocusedRowHandle = 0;
            }
        }

       

        private void gvUsers_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvUsers.GetSelectedCells().Length == 0) return;
        }

        private void gcUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GridView gv = (sender as GridControl).MainView as GridView;
            if (gv == null) return;

            GridHitInfo ghi = gv.CalcHitInfo(e.Location);
            if (ghi == null || ghi.RowHandle < 0 || ghi.Column == null) return;

            newUser = gv.GetRow(ghi.RowHandle) as UserInfo;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            newUser = null;
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void gvUsers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            newUser = gvUsers.GetFocusedRow() as UserInfo;
            this.Text = "所选用户："+newUser.FullName;
        }

        private void FrmUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnQueryUsers_ItemClick(null, null);
            }
        } 
         
    }
}
