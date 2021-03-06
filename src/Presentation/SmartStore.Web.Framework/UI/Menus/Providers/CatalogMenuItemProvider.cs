﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartStore.Collections;
using SmartStore.Core.Domain.Cms;
using SmartStore.Core.Plugins;

namespace SmartStore.Web.Framework.UI
{
	[SystemName("catalog")]
	public class CatalogMenuItemProvider : MenuItemProviderBase
	{
		public override void Append(TreeNode<MenuItem> parent, MenuItemRecord entity)
		{
			// INFO: Replaces CatalogSiteMap to a large extent and appends 
			// all catalog nodes (without root) to the passed parent node.

			// TBD: Cache invalidation workflow changes, because the catalog tree 
			// is now contained within other menus. Invalidating the tree now means:
			// invalidate all containing menus also.

			// TBD: A MenuItemRecord with this provider assigned to it cannot have child nodes.
			// We must prevent this in the UI somehow.

			// TBD (if this provider is assigned to MenuItemRecord):
			// Some props are void: Title, ShortDescription, CssClass, HtmlId etc. These need to be hidden in the backend.
			// Some props are inheritable: NoFollow, NewWindow etc.
			// We need a mechanism to control those restrictions.
		}

		protected override void ApplyLink(TreeNode<MenuItem> node, MenuItemRecord entity)
		{
			// Void, does nothing here
		}
	}
}
