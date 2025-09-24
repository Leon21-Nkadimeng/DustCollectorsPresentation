using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DustCollectorsPresentation.ServiceReference1;
namespace DustCollectorsPresentation
{
    public partial class insertProduct : System.Web.UI.Page
    {
       
     
        private List<ProductSizeDTO> sizes;
        private Service1Client client = new Service1Client();

        private int sizeIndex;
   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserType"] == null || !Session["UserType"].Equals("admin"))
                Response.Redirect("index.aspx");

            sizeIndex = -1;
            if(Session["sizeIndex"] != null)
            {
                sizeIndex = int.Parse(Session["sizeIndex"].ToString());
            }
            if(Session["sizes"] == null)
            {
                sizes = new List<ProductSizeDTO>();
                Session["sizes"] = sizes;
            } 
            else
            {
                sizes = (List<ProductSizeDTO>)Session["sizes"];
            }
            if (!IsPostBack)
            {
                fillInBrandDopDownList();
                fillInCategoryDropDownList();
                fillColourwaysDropdownList();
                fillGendersDropdownList();
            }

            displayShoeSizes(sizeIndex);
        }
        private bool sizeExists(ProductSizeDTO size)
        {
            foreach(ProductSizeDTO s in sizes)
            {
                if(s.SizeTag.Equals(size.SizeTag) && s.System.ToLower().Equals(size.System.ToLower()))
                    return true;
            }
            return false;
        }
        protected void btnNewSize_Click(Object sender, EventArgs e)
        {
            newSizeRec.Visible = true;
        }

        protected void btnDone_Click(Object sender, EventArgs e)
        {
            if (sizeIndex > -1)
            {
                sizes[sizeIndex].SizeTag = txtShoeSizeTag.Text.ToString();
                sizes[sizeIndex].System = txtShoeSizeSystem.Text;
                sizes[sizeIndex].IsAvailable = isShoeSizeAvailable.Checked;
                sizes[sizeIndex].AmountInStock = int.Parse(txtAmountInStock.Text);

                sizeIndex = -1;
                Session["sizeIndex"] = null;
            }
            else
            {
                ProductSizeDTO size = new ProductSizeDTO()
                {
                    AmountInStock = int.Parse(txtAmountInStock.Text),
                    SizeTag = txtShoeSizeTag.Text,
                    System = txtShoeSizeSystem.Text,
                    IsAvailable = isShoeSizeAvailable.Checked
                };
               if(!sizeExists(size))
                    sizes.Add(size);
            }

           
            btnNewSize.Visible = true;
            newSizeRec.Visible = false;
          
            txtAmountInStock.Text = "";
            txtShoeSizeSystem.Text = "";
            txtShoeSizeTag.Text = "";
            isShoeSizeAvailable.Checked = false;
            displayShoeSizes(sizeIndex);
            
            Session["sizes"] = sizes;
            lblStatus.Text = "Rows: "+shoeSizesTbl.Rows.Count.ToString()+", Sizes: "+sizes.Count().ToString();
           
        }
        /** Editing a size */
        protected void btnEdit_Click(object sender, EventArgs e)
        {
           
            var editBtnClick = (Button)sender;
            sizeIndex = int.Parse(editBtnClick.ID);
            Session["sizeIndex"] = sizeIndex;
            newSizeRec.Visible = true;
            btnNewSize.Visible = false;
            txtShoeSizeSystem.Text = sizes[sizeIndex].System;
            txtShoeSizeTag.Text = sizes[sizeIndex].SizeTag;
            isShoeSizeAvailable.Checked = sizes[sizeIndex].IsAvailable;
            txtAmountInStock.Text = sizes[sizeIndex].AmountInStock.ToString();
            displayShoeSizes(sizeIndex);
        }

        /** display shoe sizes in a table */
        protected void displayShoeSizes(int sizeToEditIndex)
        {
            List<TableRow> rowsToRemove = new List<TableRow>();
            for(int i = shoeSizesTbl.Rows.Count - 1; i > 1; i--)
            {
               
                    shoeSizesTbl.Rows.RemoveAt(i);
                        
                
            }
            for(int i = 0; i < sizes.Count(); i++)
            {
                if (sizes[i] != null && i != sizeToEditIndex)
                {
                    TableRow tr = new TableRow();
                    tr.ID = sizes[i].SizeTag + "_" + sizes[i].System; 
                    TableCell sizeTagCell = new TableCell();
                    sizeTagCell.Text = sizes[i].SizeTag;
                    sizeTagCell.CssClass = "column-1";
                    tr.Cells.Add(sizeTagCell);

                    TableCell sizeSystemCell = new TableCell();
                    sizeSystemCell.Text = sizes[i].System;
                    sizeSystemCell.CssClass = "column-1";
                    tr.Cells.Add(sizeSystemCell);

                    TableCell amountInStock = new TableCell();
                    amountInStock.Text = sizes[i].AmountInStock.ToString();
                    amountInStock.CssClass = "column-1";
                    tr.Cells.Add(amountInStock);

                    TableCell isAvailable = new TableCell();
                    isAvailable.Text = (sizes[i].IsAvailable) ? "Yes" : "No";
                    isAvailable.CssClass = "column-1";
                    tr.Cells.Add(isAvailable);

                    TableCell editAndDeactivate = new TableCell();
                    Button edit = new Button();
                    edit.CssClass = "flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10";
                    edit.ID = i.ToString();
                    
                    edit.Click += new EventHandler(btnEdit_Click);
                    edit.Text = "Edit";
                    editAndDeactivate.Controls.Add(edit);

                    Button delete = new Button();
                    delete.CssClass = "flex-c-m stext-101 cl0 size-112 bg7 bor11 hov-btn3 p-lr-15 trans-04 m-b-10";
                    delete.ID = "Rmv"+i.ToString();
                    delete.Click += btnRemove_Click;
                    delete.Text = "Remove";

                    editAndDeactivate.Controls.Add(delete);
                    tr.Cells.Add(editAndDeactivate);
                    shoeSizesTbl.Rows.Add(tr);
                }

                
             }
            
        }
        /** Remove size button */
        protected void btnRemove_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int i = int.Parse(button.ID.Substring(3));
            sizes.RemoveAt(i);
            Session["sizes"] = sizes;
            displayShoeSizes(sizeIndex);
        }
        

        /** Submit button */
        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            var product = new ProductDTO()
            {
                Name = txtName.Text,
                BrandID = int.Parse(brandsList.SelectedValue),
                Description = txtDescription.Text,
                Price = decimal.Parse(txtPrice.Text),
                isActive = isAvailable.Checked ? true : false,
                CategoryID = int.Parse(categoriesList.SelectedValue),
                ColourwayID = int.Parse(colourwayList.SelectedValue),
                GenderID = int.Parse(gendersList.SelectedValue),
                MainImgURL = txtMainImgURl.Text
            };

            if (sizes.Count() > 0)
            {
                string isInserted = client.InsertProductAndSizes(product, sizes.ToArray());


                
                lblStatus.Text = isInserted + "\n";
                foreach(ProductSizeDTO s in sizes)
                {
                    lblStatus.Text += s.SizeTag +" " +s.System+ " " + s.AmountInStock.ToString()+"\n";
                }
                statusSection.Visible = true;
            }
            
        }


        // drop downlist methods
        private void fillInBrandDopDownList()
        {
            dynamic brands = client.getBrands(1);
            brandsList.Items.Clear();
            if (brands != null)
            {
                foreach (BrandDTO b in brands)
                {
                    ListItem item = new ListItem(b.name, b.Id.ToString());
                    
                    brandsList.Items.Add(item);
                }
            }
        }

        private void fillInCategoryDropDownList()
        {
            dynamic categories = client.getCategories(true);
            categoriesList.Items.Clear();
            if (categories != null)
            {
                foreach (CategoryDTO c in categories)
                {
                    ListItem item = new ListItem(c.name, c.id.ToString());
                    
                    categoriesList.Items.Add(item);
                }
            }
        }

        private void fillColourwaysDropdownList()
        {
            dynamic colourways = client.getColourways();
            colourwayList.Items.Clear();
            if (colourways != null)
            {
                foreach (ColourwayDTO c in colourways)
                {
                    ListItem item = new ListItem(c.name , c.id.ToString());

                    colourwayList.Items.Add(item);
                }
            }
        }
        private void fillGendersDropdownList()
        {
            dynamic genders = client.getGenders();
            gendersList.Items.Clear();
            if (genders != null)
            {
                foreach (GenderDTO g in genders)
                {
                    ListItem item = new ListItem(g.name + " ("+g.ageGroup+")", g.Id.ToString());

                    gendersList.Items.Add(item);
                }
            }
        }

        
    }
}