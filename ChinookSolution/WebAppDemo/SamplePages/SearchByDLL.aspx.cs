﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region Additional Namespaces
using ChinookSystem.BLL;
using ChinookSystem.ViewModels;
#endregion

namespace WebAppDemo.SamplePages
{
    public partial class SearchByDLL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //this is first time
                LoadArtistList();
            }
        }

        protected void LoadArtistList()
        {
            ArtistController sysmgr = new ArtistController();
            List<SelectionList> info = sysmgr.Artists_DDLList();

            info.Sort((x,y) => x.DisplayField.CompareTo(y.DisplayField));

            ArtistList.DataSource = info;
            ArtistList.DataTextField = nameof(SelectionList.DisplayField);
            ArtistList.DataValueField = nameof(SelectionList.ValueField);
            ArtistList.DataBind();

            //prompt line
            ArtistList.Items.Insert(0,new ListItem("select ...", "0"));
        }

        protected void SearchAlbums_Click(object sender, EventArgs e)
        {

        }
    }
}