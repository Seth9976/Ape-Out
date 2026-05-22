using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001C8 RID: 456
	public class TrailerEnder : Glass
	{
		// Token: 0x0600323B RID: 12859 RVA: 0x000BE3A0 File Offset: 0x000BC5A0
		// Note: this type is marked as 'beforefieldinit'.
		static TrailerEnder()
		{
			Il2CppClassPointerStore<TrailerEnder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TrailerEnder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrailerEnder>.NativeClassPtr);
			TrailerEnder.NativeMethodInfoPtr_Break_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerEnder>.NativeClassPtr, 100667192);
			TrailerEnder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerEnder>.NativeClassPtr, 100667193);
		}

		// Token: 0x0600323C RID: 12860 RVA: 0x000BE3F8 File Offset: 0x000BC5F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85574, XrefRangeEnd = 85575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Break(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrailerEnder.NativeMethodInfoPtr_Break_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600323D RID: 12861 RVA: 0x000BE444 File Offset: 0x000BC644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrailerEnder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrailerEnder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerEnder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600323E RID: 12862 RVA: 0x000227B4 File Offset: 0x000209B4
		public TrailerEnder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D68 RID: 7528
		private static readonly IntPtr NativeMethodInfoPtr_Break_Public_Virtual_Void_Vector2_0;

		// Token: 0x04001D69 RID: 7529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
