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
    public partial class adminauthormanagement : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

            GridView1.DataBind();
        }

        // Adding author
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (CheckAuthorExsists())
            {
                Response.Write("<script>alert('Author with this id already Exsist.')</script>");
            }
            else
            {
                AddAuthor();
            }
        }

        // Updating author
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (CheckAuthorExsists())
            {
                UpdateAuthor();
            }
            else
            {
                Response.Write("<script>alert('Author with this id does not exsist.')</script>");
            }

        }

        // deleting author
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (CheckAuthorExsists())
            {
                DeleteAuthor();
            }
            else
            {
                Response.Write("<script>alert('Author with this id does not exsist.')</script>");
            }

        }

        // Go button click
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckAuthorExsists())
            {
                GetAuthorByID();
            }
            else
            {
                Response.Write("<script>alert('Author with this id does not exsist.')</script>");

            }
        }

        // User defined functions


        void GetAuthorByID()
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(cs))
                {
                    string query = "select * from author_master_tbl where author_id='" + TextBox1.Text.Trim() + "';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        TextBox2.Text = dt.Rows[0][1].ToString(); 
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

        void DeleteAuthor()
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(cs))
                {
                    string query = "delete author_master_tbl where author_id='" + TextBox1.Text.Trim() + "';";
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

        void UpdateAuthor()
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(cs))
                {
                    string query = "update author_master_tbl set author_name = @author_name where author_id='"+ TextBox1.Text.Trim() +"';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@author_name", TextBox2.Text.Trim());
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


        void AddAuthor()
        {
            SqlConnection conn = null;
            try
            {
                using(conn= new SqlConnection(cs))
                {
                    string query = "insert into author_master_tbl(author_id, author_name) values(@author_id, @author_name);";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@author_id", TextBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@author_name", TextBox2.Text.Trim());
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


        bool CheckAuthorExsists()
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(cs))
                {
                    string query = "select * from author_master_tbl where author_id='"+ TextBox1.Text.Trim() +"';";
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
            TextBox2.Text = "";
        }

    }
}