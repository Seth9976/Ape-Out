using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Serialization;

namespace UnityEngine.Serialization
{
	// Token: 0x0200027C RID: 636
	public class ListSerializationSurrogate
	{
		// Token: 0x06002291 RID: 8849 RVA: 0x000782D4 File Offset: 0x000764D4
		public void GetObjectData(Object obj, SerializationInfo info, StreamingContext context)
		{
			IList list = obj.Cast<IList>();
			info.AddValue("_size", list.Count);
			info.AddValue("_items", ListSerializationSurrogate.ArrayFromGenericList(list));
			info.AddValue("_version", 0);
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x0007831C File Offset: 0x0007651C
		public Object SetObjectData(Object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
		{
			IList list = Activator.CreateInstance(obj.GetType()).Cast<IList>();
			int @int = info.GetInt32("_size");
			bool flag = @int == 0;
			Object @object;
			if (flag)
			{
				@object = list;
			}
			else
			{
				IEnumerator enumerator = info.GetValue("_items", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<IEnumerable>())).Cast<IEnumerable>().GetEnumerator();
				for (int i = 0; i < @int; i++)
				{
					bool flag2 = !enumerator.MoveNext();
					if (flag2)
					{
						throw new InvalidOperationException();
					}
					list.Add(enumerator.Current);
				}
				@object = list;
			}
			return @object;
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x00012722 File Offset: 0x00010922
		public static Array ArrayFromGenericList(IList list)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
