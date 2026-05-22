using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Networking;

namespace Il2CppI2.Loc
{
	// Token: 0x02000233 RID: 563
	public class TranslationJob_WWW : TranslationJob
	{
		// Token: 0x060042FD RID: 17149 RVA: 0x000F928C File Offset: 0x000F748C
		// Note: this type is marked as 'beforefieldinit'.
		static TranslationJob_WWW()
		{
			Il2CppClassPointerStore<TranslationJob_WWW>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "TranslationJob_WWW");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TranslationJob_WWW>.NativeClassPtr);
			TranslationJob_WWW.NativeFieldInfoPtr_www = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationJob_WWW>.NativeClassPtr, "www");
			TranslationJob_WWW.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob_WWW>.NativeClassPtr, 100669893);
			TranslationJob_WWW.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranslationJob_WWW>.NativeClassPtr, 100669894);
		}

		// Token: 0x060042FE RID: 17150 RVA: 0x000F92F8 File Offset: 0x000F74F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108372, XrefRangeEnd = 108373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TranslationJob_WWW.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x000F9334 File Offset: 0x000F7534
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TranslationJob_WWW()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TranslationJob_WWW>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranslationJob_WWW.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004300 RID: 17152 RVA: 0x00028A9D File Offset: 0x00026C9D
		public TranslationJob_WWW(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x06004301 RID: 17153 RVA: 0x000F9370 File Offset: 0x000F7570
		// (set) Token: 0x06004302 RID: 17154 RVA: 0x00028AA6 File Offset: 0x00026CA6
		public unsafe UnityWebRequest www
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_WWW.NativeFieldInfoPtr_www);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationJob_WWW.NativeFieldInfoPtr_www), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400293C RID: 10556
		private static readonly IntPtr NativeFieldInfoPtr_www;

		// Token: 0x0400293D RID: 10557
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

		// Token: 0x0400293E RID: 10558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
