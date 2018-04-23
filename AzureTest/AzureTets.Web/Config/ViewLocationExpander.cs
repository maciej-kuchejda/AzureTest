using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Razor;

namespace AzureTets.Web.Config
{
    public class ViewLocationExpander : IViewLocationExpander
    {
        public void PopulateValues(ViewLocationExpanderContext context)
        {
            context.Values["customviewlocation"] = nameof(ViewLocationExpander);
        }

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            string[] locations = new string[] { "/Pages/{1}/{0}.cshtml" };
            return locations.Union(viewLocations);
        }
    }
}
