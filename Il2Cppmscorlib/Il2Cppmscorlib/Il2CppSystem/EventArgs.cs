using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000A1 RID: 161
	[Serializable]
	public class EventArgs : Object
	{
		// Token: 0x06000B95 RID: 2965 RVA: 0x00058260 File Offset: 0x00056460
		// Note: this type is marked as 'beforefieldinit'.
		static EventArgs()
		{
			Il2CppClassPointerStore<EventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "EventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventArgs>.NativeClassPtr);
			EventArgs.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventArgs>.NativeClassPtr, "Empty");
			EventArgs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventArgs>.NativeClassPtr, 100665277);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x000582B8 File Offset: 0x000564B8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventArgs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventArgs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00004E66 File Offset: 0x00003066
		public EventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x000582F4 File Offset: 0x000564F4
		// (set) Token: 0x06000B99 RID: 2969 RVA: 0x00004E6F File Offset: 0x0000306F
		public unsafe static EventArgs Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventArgs.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventArgs>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventArgs.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
