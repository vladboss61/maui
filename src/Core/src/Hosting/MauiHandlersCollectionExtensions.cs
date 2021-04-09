using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Maui.Hosting
{
	public static partial class MauiHandlersCollectionExtensions
	{
		public static IMauiHandlersCollection AddHandlers(this IMauiHandlersCollection handlersCollection, Dictionary<Type, Type> handlers)
		{
			foreach (var handler in handlers)
			{
				handlersCollection.AddTransient(handler.Key, handler.Value);
			}
			return handlersCollection;
		}

		public static IMauiHandlersCollection AddHandler(this IMauiHandlersCollection handlersCollection, Type viewType, Type handlerType)
		{
			handlersCollection.AddTransient(viewType, handlerType);
			return handlersCollection;
		}

		public static IMauiHandlersCollection AddHandler<TType, TTypeRender>(this IMauiHandlersCollection handlersCollection)
			where TType : IFrameworkElement
			where TTypeRender : IViewHandler
		{
			handlersCollection.AddTransient(typeof(TType), typeof(TTypeRender));
			return handlersCollection;
		}
	}
}