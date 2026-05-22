using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000033 RID: 51
	public class WriteAccessRequiredAttribute : Attribute
	{
		// Token: 0x0600016B RID: 363 RVA: 0x00002EFC File Offset: 0x000010FC
		// Note: this type is marked as 'beforefieldinit'.
		static WriteAccessRequiredAttribute()
		{
			Il2CppClassPointerStore<WriteAccessRequiredAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "WriteAccessRequiredAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WriteAccessRequiredAttribute>.NativeClassPtr);
			WriteAccessRequiredAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteAccessRequiredAttribute>.NativeClassPtr, 100663389);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00018760 File Offset: 0x00016960
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WriteAccessRequiredAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WriteAccessRequiredAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteAccessRequiredAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002F35 File Offset: 0x00001135
		public WriteAccessRequiredAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
