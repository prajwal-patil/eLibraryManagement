using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace eLibraryManagement
{
    public partial class adminmembermanagement : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }

        // activate button
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            UpdateAccountStatusById("Active");
        }

        // pending button
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            UpdateAccountStatusById("Pending");

        }

        // deavtivate button
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            UpdateAccountStatusById("Deactive");

        }

        // GO Button
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckMemberExsists())
            {
                GetMemberByID();
            }
            else
            {
                Response.Write("<script>alert('Member with this id does not exsist.')</script>");

            }
        }

        // delete Member completely
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (CheckMemberExsists())
            {
                DeleteMember();
            }
            else
            {
                Response.Write("<script>alert('Member with this id does not exsist.')</script>");

            }
        }


        // User defined functions

        void DeleteMember()
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(cs))
                {
                    string query = "delete member_master_tbl where member_id='" + TextBox2.Text.Trim() + "';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    ClearForm();
                    GridView1.DataBind();
                }
                //Response.Redirect("<script> alert('Author added successfully') </script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
            finally
            {
                conn.Close();
            }
        }

        void UpdateAccountStatusById(string status)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(cs))
                {
                    string query = "update member_master_tbl set account_status='"+ status + "' where member_id='" + TextBox2.Text.Trim() + "';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    //TextBox3.Text = status;
     
                    GridView1.DataBind();

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }
            finally
            {
                conn.Close();
            }
        }

        void GetMemberByID()
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(cs))
                {
                    string query = "select * from member_master_tbl where member_id='" + TextBox2.Text.Trim() + "';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        TextBox1.Text = dt.Rows[0][0].ToString();
                        TextBox3.Text = dt.Rows[0][10].ToString();
                        TextBox7.Text = dt.Rows[0][1].ToString();
                        TextBox8.Text = dt.Rows[0][2].ToString();
                        TextBox9.Text = dt.Rows[0][3].ToString();
                        TextBox4.Text = dt.Rows[0][4].ToString();
                        TextBox5.Text = dt.Rows[0][5].ToString();
                        TextBox6.Text = dt.Rows[0][6].ToString();
                        TextBox10.Text = dt.Rows[0][7].ToString();
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }
            finally
            {
                conn.Close();
            }
        }

        bool CheckMemberExsists()
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(cs))
                {
                    string query = "select * from member_master_tbl where member_id='" + TextBox2.Text.Trim() + "';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
                return false;
            }
            finally
            {
                conn.Close();
            }

           
        }
        void ClearForm()
        {
            TextBox1.Text = "";
            TextBox3.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox10.Text = "";
            TextBox2.Text = "";
        }
    }
}