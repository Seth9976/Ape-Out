using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x02000220 RID: 544
	public class CallbackNotification : MonoBehaviour
	{
		// Token: 0x0600423E RID: 16958 RVA: 0x000F61E4 File Offset: 0x000F43E4
		// Note: this type is marked as 'beforefieldinit'.
		static CallbackNotification()
		{
			Il2CppClassPointerStore<CallbackNotification>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "CallbackNotification");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackNotification>.NativeClassPtr);
			CallbackNotification.NativeMethodInfoPtr_OnModifyLocalization_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackNotification>.NativeClassPtr, 100669764);
			CallbackNotification.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackNotification>.NativeClassPtr, 100669765);
		}

		// Token: 0x0600423F RID: 16959 RVA: 0x000F623C File Offset: 0x000F443C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106488, XrefRangeEnd = 106503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnModifyLocalization()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackNotification.NativeMethodInfoPtr_OnModifyLocalization_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004240 RID: 16960 RVA: 0x000F6270 File Offset: 0x000F4470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallbackNotification()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallbackNotification>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackNotification.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004241 RID: 16961 RVA: 0x00028707 File Offset: 0x00026907
		public CallbackNotification(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040028B1 RID: 10417
		private static readonly IntPtr NativeMethodInfoPtr_OnModifyLocalization_Public_Void_0;

		// Token: 0x040028B2 RID: 10418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
