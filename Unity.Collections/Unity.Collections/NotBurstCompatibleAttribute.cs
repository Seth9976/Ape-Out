using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000007 RID: 7
	public class NotBurstCompatibleAttribute : Attribute
	{
		// Token: 0x0600002D RID: 45 RVA: 0x0000219B File Offset: 0x0000039B
		// Note: this type is marked as 'beforefieldinit'.
		static NotBurstCompatibleAttribute()
		{
			Il2CppClassPointerStore<NotBurstCompatibleAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "NotBurstCompatibleAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotBurstCompatibleAttribute>.NativeClassPtr);
			NotBurstCompatibleAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotBurstCompatibleAttribute>.NativeClassPtr, 100663377);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004020 File Offset: 0x00002220
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotBurstCompatibleAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotBurstCompatibleAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotBurstCompatibleAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000021D4 File Offset: 0x000003D4
		public NotBurstCompatibleAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
