using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppI2.Loc
{
	// Token: 0x02000239 RID: 569
	[Serializable]
	public class LanguageData : Object
	{
		// Token: 0x06004341 RID: 17217 RVA: 0x000F9F54 File Offset: 0x000F8154
		// Note: this type is marked as 'beforefieldinit'.
		static LanguageData()
		{
			Il2CppClassPointerStore<LanguageData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "LanguageData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LanguageData>.NativeClassPtr);
			LanguageData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "Name");
			LanguageData.NativeFieldInfoPtr_Code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "Code");
			LanguageData.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "Flags");
			LanguageData.NativeFieldInfoPtr_Compressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "Compressed");
			LanguageData.NativeMethodInfoPtr_IsEnabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669916);
			LanguageData.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669917);
			LanguageData.NativeMethodInfoPtr_IsLoaded_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669918);
			LanguageData.NativeMethodInfoPtr_CanBeUnloaded_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669919);
			LanguageData.NativeMethodInfoPtr_SetLoaded_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669920);
			LanguageData.NativeMethodInfoPtr_SetCanBeUnLoaded_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669921);
			LanguageData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100669922);
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x000FA060 File Offset: 0x000F8260
		[CallerCount(0)]
		public unsafe bool IsEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageData.NativeMethodInfoPtr_IsEnabled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x000FA09C File Offset: 0x000F829C
		[CallerCount(0)]
		public unsafe void SetEnabled(bool bEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageData.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004344 RID: 17220 RVA: 0x000FA0DC File Offset: 0x000F82DC
		[CallerCount(0)]
		public unsafe bool IsLoaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageData.NativeMethodInfoPtr_IsLoaded_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x000FA118 File Offset: 0x000F8318
		[CallerCount(0)]
		public unsafe bool CanBeUnloaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageData.NativeMethodInfoPtr_CanBeUnloaded_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x000FA154 File Offset: 0x000F8354
		[CallerCount(0)]
		public unsafe void SetLoaded(bool loaded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref loaded;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageData.NativeMethodInfoPtr_SetLoaded_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x000FA194 File Offset: 0x000F8394
		[CallerCount(0)]
		public unsafe void SetCanBeUnLoaded(bool allowUnloading)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allowUnloading;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageData.NativeMethodInfoPtr_SetCanBeUnLoaded_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x000FA1D4 File Offset: 0x000F83D4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LanguageData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LanguageData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004349 RID: 17225 RVA: 0x00028D36 File Offset: 0x00026F36
		public LanguageData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x0600434A RID: 17226 RVA: 0x000FA210 File Offset: 0x000F8410
		// (set) Token: 0x0600434B RID: 17227 RVA: 0x00028D3F File Offset: 0x00026F3F
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x0600434C RID: 17228 RVA: 0x000FA238 File Offset: 0x000F8438
		// (set) Token: 0x0600434D RID: 17229 RVA: 0x00028D5E File Offset: 0x00026F5E
		public unsafe string Code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr_Code);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr_Code), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x0600434E RID: 17230 RVA: 0x000FA260 File Offset: 0x000F8460
		// (set) Token: 0x0600434F RID: 17231 RVA: 0x00028D7D File Offset: 0x00026F7D
		public unsafe byte Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr_Flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr_Flags)) = value;
			}
		}

		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x06004350 RID: 17232 RVA: 0x000FA288 File Offset: 0x000F8488
		// (set) Token: 0x06004351 RID: 17233 RVA: 0x00028D98 File Offset: 0x00026F98
		public unsafe bool Compressed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr_Compressed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageData.NativeFieldInfoPtr_Compressed)) = value;
			}
		}

		// Token: 0x04002966 RID: 10598
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04002967 RID: 10599
		private static readonly IntPtr NativeFieldInfoPtr_Code;

		// Token: 0x04002968 RID: 10600
		private static readonly IntPtr NativeFieldInfoPtr_Flags;

		// Token: 0x04002969 RID: 10601
		private static readonly IntPtr NativeFieldInfoPtr_Compressed;

		// Token: 0x0400296A RID: 10602
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabled_Public_Boolean_0;

		// Token: 0x0400296B RID: 10603
		private static readonly IntPtr NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0;

		// Token: 0x0400296C RID: 10604
		private static readonly IntPtr NativeMethodInfoPtr_IsLoaded_Public_Boolean_0;

		// Token: 0x0400296D RID: 10605
		private static readonly IntPtr NativeMethodInfoPtr_CanBeUnloaded_Public_Boolean_0;

		// Token: 0x0400296E RID: 10606
		private static readonly IntPtr NativeMethodInfoPtr_SetLoaded_Public_Void_Boolean_0;

		// Token: 0x0400296F RID: 10607
		private static readonly IntPtr NativeMethodInfoPtr_SetCanBeUnLoaded_Public_Void_Boolean_0;

		// Token: 0x04002970 RID: 10608
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
