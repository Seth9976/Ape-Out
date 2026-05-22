using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000E3 RID: 227
	public class SelectionBaseAttribute : Attribute
	{
		// Token: 0x0600136D RID: 4973 RVA: 0x0000AE73 File Offset: 0x00009073
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionBaseAttribute()
		{
			Il2CppClassPointerStore<SelectionBaseAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SelectionBaseAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionBaseAttribute>.NativeClassPtr);
			SelectionBaseAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionBaseAttribute>.NativeClassPtr, 100664980);
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x0004EE2C File Offset: 0x0004D02C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionBaseAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionBaseAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionBaseAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x0000AEAC File Offset: 0x000090AC
		public SelectionBaseAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F77 RID: 3959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
