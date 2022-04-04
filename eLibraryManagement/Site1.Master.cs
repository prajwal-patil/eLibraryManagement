using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eLibraryManagement
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"] == null)
                {
                    LinkButton1.Visible = true; // user login page link
                    LinkButton2.Visible = true; // user sign up page link

                    LinkButton3.Visible = false; // logout button
                    LinkButton7.Visible = false; // user profile page link

                    LinkButton6.Visible = true; // admin login page link
                    LinkButton11.Visible = false; // admin author management
                    LinkButton12.Visible = false;
                    LinkButton8.Visible = false;
                    LinkButton9.Visible = false;
                    LinkButton10.Visible = false;
                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButton1.Visible = false; // user login page link
                    LinkButton2.Visible = false; // user sign up page link

                    LinkButton3.Visible = true; // logout button
                    LinkButton7.Visible = true; // user profile page link
                    LinkButton7.Text = "Hello " + Session["username"].ToString();

                    LinkButton6.Visible = true; // admin login page link
                    LinkButton11.Visible = false; // admin author management
                    LinkButton12.Visible = false;
                    LinkButton8.Visible = false;
                    LinkButton9.Visible = false;
                    LinkButton10.Visible = false;

                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false; // user login page link
                    LinkButton2.Visible = false; // user sign up page link

                    LinkButton3.Visible = true; // logout button
                    LinkButton7.Visible = true; // user profile page link
                    LinkButton7.Text = "Hello " + Session["username"].ToString();

                    LinkButton6.Visible = false; // admin login page link
                    LinkButton11.Visible = true; // admin author management
                    LinkButton12.Visible = true;
                    LinkButton8.Visible = true;
                    LinkButton9.Visible = true;
                    LinkButton10.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }


        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminauthormanagement.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminpublishermanagement.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookinventory.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookissuing.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminmembermanagement.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewbooks.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("userprofile.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] ="";

            LinkButton1.Visible = true; // user login page link
            LinkButton2.Visible = true; // user sign up page link

            LinkButton3.Visible = false; // logout button
            LinkButton7.Visible = false; // user profile page link

            LinkButton6.Visible = true; // admin login page link
            LinkButton11.Visible = false; // admin author management
            LinkButton12.Visible = false;
            LinkButton8.Visible = false;
            LinkButton9.Visible = false;
            LinkButton10.Visible = false;

            Response.Redirect("homepage.aspx");
        }
    }
}