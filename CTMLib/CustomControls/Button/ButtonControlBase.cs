﻿using System.Collections.Generic;
using System.Web.Mvc;

namespace CTMCustomControlLib.CustomControls.Button
{
    public abstract class ButtonControlBase : CustomControlBase,IButtonControl
    {

        public SizeOptions Size { get; set; }
        public ColorOptions BackgroundColor { get; set; }
        public string Text { get; set; }
        public bool IsLinkBtn { get; set; }
        public string MaterialIcon { get; set; }
        public bool IsSubmitBtn { get; set; }

        protected ButtonControlBase()
        {
            BackgroundColor = ColorOptions.Default;
           HtmlAttributes = new Dictionary<string, object>();
        }

        protected abstract override string Render();

        protected string RenderMaterialIcon(string materialIconName)
        {
            var builderI = new TagBuilder("i");
            builderI.AddCssClass("material-icons");
            builderI.InnerHtml = materialIconName;
            return builderI.ToString();
        }

    }
}
