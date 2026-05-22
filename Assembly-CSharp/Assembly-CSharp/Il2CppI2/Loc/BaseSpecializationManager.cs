using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppI2.Loc
{
	// Token: 0x0200022B RID: 555
	public class BaseSpecializationManager : Object
	{
		// Token: 0x06004296 RID: 17046 RVA: 0x000F77CC File Offset: 0x000F59CC
		// Note: this type is marked as 'beforefieldinit'.
		static BaseSpecializationManager()
		{
			Il2CppClassPointerStore<BaseSpecializationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "BaseSpecializationManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseSpecializationManager>.NativeClassPtr);
			BaseSpecializationManager.NativeFieldInfoPtr_mSpecializations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpecializationManager>.NativeClassPtr, "mSpecializations");
			BaseSpecializationManager.NativeFieldInfoPtr_mSpecializationsFallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpecializationManager>.NativeClassPtr, "mSpecializationsFallbacks");
			BaseSpecializationManager.NativeMethodInfoPtr_InitializeSpecializations_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpecializationManager>.NativeClassPtr, 100669816);
			BaseSpecializationManager.NativeMethodInfoPtr_GetCurrentSpecialization_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpecializationManager>.NativeClassPtr, 100669817);
			BaseSpecializationManager.NativeMethodInfoPtr_GetFallbackSpecialization_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpecializationManager>.NativeClassPtr, 100669818);
			BaseSpecializationManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpecializationManager>.NativeClassPtr, 100669819);
		}

		// Token: 0x06004297 RID: 17047 RVA: 0x000F7874 File Offset: 0x000F5A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107078, XrefRangeEnd = 107172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSpecializations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSpecializationManager.NativeMethodInfoPtr_InitializeSpecializations_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004298 RID: 17048 RVA: 0x000F78B0 File Offset: 0x000F5AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107172, XrefRangeEnd = 107174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetCurrentSpecialization()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSpecializationManager.NativeMethodInfoPtr_GetCurrentSpecialization_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004299 RID: 17049 RVA: 0x000F78F4 File Offset: 0x000F5AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107174, XrefRangeEnd = 107177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetFallbackSpecialization(string specialization)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(specialization);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSpecializationManager.NativeMethodInfoPtr_GetFallbackSpecialization_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600429A RID: 17050 RVA: 0x000F7948 File Offset: 0x000F5B48
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseSpecializationManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseSpecializationManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpecializationManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600429B RID: 17051 RVA: 0x000288B3 File Offset: 0x00026AB3
		public BaseSpecializationManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x0600429C RID: 17052 RVA: 0x000F7984 File Offset: 0x000F5B84
		// (set) Token: 0x0600429D RID: 17053 RVA: 0x000288BC File Offset: 0x00026ABC
		public unsafe Il2CppStringArray mSpecializations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpecializationManager.NativeFieldInfoPtr_mSpecializations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpecializationManager.NativeFieldInfoPtr_mSpecializations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x0600429E RID: 17054 RVA: 0x000F79B4 File Offset: 0x000F5BB4
		// (set) Token: 0x0600429F RID: 17055 RVA: 0x000288DB File Offset: 0x00026ADB
		public unsafe Dictionary<string, string> mSpecializationsFallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpecializationManager.NativeFieldInfoPtr_mSpecializationsFallbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpecializationManager.NativeFieldInfoPtr_mSpecializationsFallbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040028EC RID: 10476
		private static readonly IntPtr NativeFieldInfoPtr_mSpecializations;

		// Token: 0x040028ED RID: 10477
		private static readonly IntPtr NativeFieldInfoPtr_mSpecializationsFallbacks;

		// Token: 0x040028EE RID: 10478
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSpecializations_Public_Virtual_New_Void_0;

		// Token: 0x040028EF RID: 10479
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentSpecialization_Public_Virtual_New_String_0;

		// Token: 0x040028F0 RID: 10480
		private static readonly IntPtr NativeMethodInfoPtr_GetFallbackSpecialization_Public_Virtual_New_String_String_0;

		// Token: 0x040028F1 RID: 10481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
