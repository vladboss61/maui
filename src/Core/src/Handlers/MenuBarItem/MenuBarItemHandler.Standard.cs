﻿using System;

namespace Microsoft.Maui.Handlers
{
	public partial class MenuBarItemHandler : ElementHandler<IMenuBarItem, object>, IMenuBarItemHandler
	{
		protected override object CreateNativeElement()
		{
			throw new NotImplementedException();
		}

		public void Add(IMenuFlyoutItemBase view)
		{
		}

		public void Remove(IMenuFlyoutItemBase view)
		{
		}

		public void Clear()
		{
		}

		public void Insert(int index, IMenuFlyoutItemBase view)
		{
		}
	}
}
