using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DustCollectorsPresentation.ServiceReference1;
namespace DustCollectorsPresentation
{
    public partial class genders : System.Web.UI.Page
    {
        private Service1Client client = new Service1Client();
        private List<GenderDTO> genderCategories;
        private int genderIndex;
        protected void Page_Load(object sender, EventArgs e)
        {
            genderCategories = (client.getGenders() != null) ? client.getGenders().ToList() : null;
            displayAllGenderCategories();
        }

     
        protected void btnDeactivate_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int i = int.Parse(button.ID.ToString());
            client.deteGenderCategory(i);
        }
        protected void btnReactivate_Click(object sender, EventArgs e)
        {

            var button = (Button)sender;
            int i = int.Parse(button.ID.ToString());
            client.activateGenderCategory(i);
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            var editBtnClick = (Button)sender;
            genderIndex = int.Parse(editBtnClick.ID);
            Response.Redirect("genderForm.aspx?ID=" + genderIndex);
         
        }
        protected void btnAdd_Click(object sender, EventArgs e) 
        {
            Response.Redirect("genderForm.aspx");
        }

        private void displayAllGenderCategories()
        {
            if (genderCategories == null)
                return;

            List<TableRow> rowsToRemove = new List<TableRow>();
            for (int i = shoeSizesTbl.Rows.Count - 1; i > 1; i--)
            {

                shoeSizesTbl.Rows.RemoveAt(i);


            }
            for (int i = 0; i < genderCategories.Count(); i++)
            {
                if (genderCategories[i] != null && i != genderIndex)
                {
                    TableRow tr = new TableRow();
                    tr.ID = genderCategories[i].name + "_" + genderCategories[i].ageGroup;
                    TableCell sizeTagCell = new TableCell();
                    sizeTagCell.Text = genderCategories[i].Id.ToString();
                    sizeTagCell.CssClass = "column-1";
                    tr.Cells.Add(sizeTagCell);

                    TableCell nameCell = new TableCell();
                    nameCell.Text = genderCategories[i].name;
                    nameCell.CssClass = "column-1";
                    tr.Cells.Add(nameCell);

                    TableCell ageGroupCell = new TableCell();
                    ageGroupCell.Text = genderCategories[i].ageGroup;
                    ageGroupCell.CssClass = "column-1";
                    tr.Cells.Add(ageGroupCell);

                   

                    TableCell editAndDeactivate = new TableCell();
                    Button edit = new Button();
                    edit.CssClass = "flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10";
                    edit.ID = i.ToString();

                    edit.Click += new EventHandler(btnEdit_Click);
                    edit.Text = "Edit";
                    editAndDeactivate.Controls.Add(edit);
                    if (genderCategories[i].isActive)
                    {
                        Button delete = new Button();
                        delete.CssClass = "flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10";
                        delete.Text = "Deactivate";
                        delete.ID = genderCategories[i].Id.ToString();
                        delete.Click += btnDeactivate_Click;
                        editAndDeactivate.Controls.Add(delete);
                    } else
                    {
                        Button reactivate = new Button();
                        reactivate.CssClass = "flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10";
                        reactivate.Text = "Reactivate";
                        reactivate.ID = genderCategories[i].Id.ToString();
                        reactivate.Click += btnReactivate_Click;
                        editAndDeactivate.Controls.Add(reactivate);
                    }
                    
                    tr.Cells.Add(editAndDeactivate);
                    shoeSizesTbl.Rows.Add(tr);
                }


            }
        }
    }
}