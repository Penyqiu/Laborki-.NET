using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZAD5
{
    public partial class Calculator_Web : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        Calculator r = new Calculator();

        
        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "1";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "2";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "6";
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "0";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "3";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "4";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "5";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "7";
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "8";
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "9";
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == string.Empty)

            {

                Response.Write("<script>alert('No input values provided')</script>");

            }




            else

            {

                Session["Val"] = TextBox1.Text;

                Session["Sign"] = "add";

                TextBox1.Text = string.Empty;

            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == string.Empty)

            {

                Response.Write("<script>alert('No input values provided')</script>");

            }




            else

            {

                Session["Val"] = TextBox1.Text;

                Session["Sign"] = "subtract";

                TextBox1.Text = string.Empty;

            }

        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == string.Empty)

            {

                Response.Write("<script>alert('No input values provided')</script>");

            }




            else

            {

                Session["Val"] = TextBox1.Text;

                Session["Sign"] = "multiply";

                TextBox1.Text = string.Empty;

            }
        }

        protected void Divide_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == string.Empty)

            {

                Response.Write("<script>alert('No input values provided')</script>");

            }




            else

            {

                Session["Val"] = TextBox1.Text;

                Session["Sign"] = "divide";

                TextBox1.Text = string.Empty;

            }
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == string.Empty)

            {

                Response.Write("<script>alert('You did not specified inputs')</script>");

            }

            else

            {

                Session["Val1"] = TextBox1.Text;

                TextBox1.Text = string.Empty;



                if (Session["Sign"].ToString() == "add")

                {

                    TextBox1.Text = r.add(Convert.ToInt32(Session["Val"]), Convert.ToInt32(Session["Val1"])).ToString();

                }

                else if (Session["Sign"].ToString() == "subtract")

                {

                    TextBox1.Text = r.subtract(Convert.ToInt32(Session["Val"]), Convert.ToInt32(Session["Val1"])).ToString();



                }

                else if (Session["Sign"].ToString() == "multiply")

                {



                    TextBox1.Text = r.multiply(Convert.ToInt32(Session["Val"]), Convert.ToInt32(Session["Val1"])).ToString();



                }

                else if (Session["Sign"].ToString() == "divide")

                {

                    TextBox1.Text = r.divide(Convert.ToInt32(Session["Val"]), Convert.ToInt32(Session["Val1"])).ToString();



                }

                else

                {

                    Response.Write("<script>alert('No operation')</script>");

                }

            }
        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            TextBox1.Text = String.Empty;
        }
    }
}