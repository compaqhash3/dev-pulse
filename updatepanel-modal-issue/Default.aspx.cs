using System;

namespace UpdatePanelModalIssue
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            lblMessage.Text = $"Hello, {name}! Your UpdatePanel worked inside the modal.";
            
            // Re-open modal after postback
            ScriptManager.RegisterStartupScript(this, this.GetType(), "showModal", "$('#updLineModal').modal('show');", true);
        }
    }
}
