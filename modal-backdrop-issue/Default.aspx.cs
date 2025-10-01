using System;

namespace ModalBackdropIssue
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnOpenModal_Click(object sender, EventArgs e)
        {
            // Trigger modal via ScriptManager
            ScriptManager.RegisterStartupScript(this, this.GetType(), "showModal", "$('#myModal').modal('show');", true);
        }
    }
}
