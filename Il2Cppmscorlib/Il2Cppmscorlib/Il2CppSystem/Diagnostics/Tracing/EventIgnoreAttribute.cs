using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004CD RID: 1229
	public class EventIgnoreAttribute : Attribute
	{
		// Token: 0x06004987 RID: 18823 RVA: 0x0001B891 File Offset: 0x00019A91
		// Note: this type is marked as 'beforefieldinit'.
		static EventIgnoreAttribute()
		{
			Il2CppClassPointerStore<EventIgnoreAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventIgnoreAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventIgnoreAttribute>.NativeClassPtr);
		}

		// Token: 0x06004988 RID: 18824 RVA: 0x0001B8B6 File Offset: 0x00019AB6
		public EventIgnoreAttribute(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
