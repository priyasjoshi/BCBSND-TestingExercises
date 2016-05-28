using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String FirstName = Request.Form.Get("txtFirstName");
        String LastName = Request.Form.Get("txtLastName");
        String Address = Request.Form.Get("txtAreaAdd");
        Response.Write("<fieldset><legend>You have entered : </legend> first name as  " + "<b>"+ FirstName + "</b><br>" + "Last name as " + "<b>"+LastName +"</b><br>"+
            "Address is  " + "<b>"+Address+"</b><br></fieldset>");
    }
}