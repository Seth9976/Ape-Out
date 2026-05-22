using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000151 RID: 337
	public static class VisualElementFactoryRegistry
	{
		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x000071F8 File Offset: 0x000053F8
		public static Dictionary<string, List<IUxmlFactory>> factories
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x0000D870 File Offset: 0x0000BA70
		public static void RegisterFactory(IUxmlFactory factory)
		{
			List<IUxmlFactory> list;
			bool flag = VisualElementFactoryRegistry.factories.TryGetValue(factory.uxmlQualifiedName, out list);
			if (flag)
			{
				List<IUxmlFactory>.Enumerator enumerator = list.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						IUxmlFactory uxmlFactory = enumerator.Current;
						bool flag2 = uxmlFactory.GetType() == factory.GetType();
						if (flag2)
						{
							throw new ArgumentException(String.Concat("A factory for the type ", factory.GetType().FullName, " was already registered"));
						}
					}
				}
				finally
				{
					enumerator.Dispose();
				}
				list.Add(factory);
			}
			else
			{
				list = new List<IUxmlFactory>();
				list.Add(factory);
				VisualElementFactoryRegistry.factories.Add(factory.uxmlQualifiedName, list);
			}
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0000D938 File Offset: 0x0000BB38
		public static bool TryGetValue(string fullTypeName, out List<IUxmlFactory> factoryList)
		{
			factoryList = null;
			return VisualElementFactoryRegistry.factories.TryGetValue(fullTypeName, out factoryList);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00007205 File Offset: 0x00005405
		public static void RegisterEngineFactories()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
