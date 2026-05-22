using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppI2.Loc
{
	// Token: 0x0200022C RID: 556
	public class SpecializationManager : BaseSpecializationManager
	{
		// Token: 0x060042A0 RID: 17056 RVA: 0x000F79E4 File Offset: 0x000F5BE4
		// Note: this type is marked as 'beforefieldinit'.
		static SpecializationManager()
		{
			Il2CppClassPointerStore<SpecializationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "SpecializationManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecializationManager>.NativeClassPtr);
			SpecializationManager.NativeFieldInfoPtr_Singleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecializationManager>.NativeClassPtr, "Singleton");
			SpecializationManager.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecializationManager>.NativeClassPtr, 100669820);
			SpecializationManager.NativeMethodInfoPtr_GetSpecializedText_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecializationManager>.NativeClassPtr, 100669821);
			SpecializationManager.NativeMethodInfoPtr_SetSpecializedText_Public_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecializationManager>.NativeClassPtr, 100669822);
			SpecializationManager.NativeMethodInfoPtr_SetSpecializedText_Public_Static_String_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecializationManager>.NativeClassPtr, 100669823);
			SpecializationManager.NativeMethodInfoPtr_GetSpecializations_Public_Static_Dictionary_2_String_String_String_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecializationManager>.NativeClassPtr, 100669824);
			SpecializationManager.NativeMethodInfoPtr_AppendSpecializations_Public_Static_Void_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecializationManager>.NativeClassPtr, 100669825);
		}

		// Token: 0x060042A1 RID: 17057 RVA: 0x000F7AA0 File Offset: 0x000F5CA0
		[CallerCount(0)]
		public unsafe SpecializationManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecializationManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecializationManager.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042A2 RID: 17058 RVA: 0x000F7ADC File Offset: 0x000F5CDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107210, RefRangeEnd = 107212, XrefRangeStart = 107177, XrefRangeEnd = 107210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSpecializedText(string text, string specialization = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(specialization);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecializationManager.NativeMethodInfoPtr_GetSpecializedText_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060042A3 RID: 17059 RVA: 0x000F7B2C File Offset: 0x000F5D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107212, XrefRangeEnd = 107225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SetSpecializedText(string text, string newText, string specialization)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newText);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(specialization);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecializationManager.NativeMethodInfoPtr_SetSpecializedText_Public_Static_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060042A4 RID: 17060 RVA: 0x000F7B8C File Offset: 0x000F5D8C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 107265, RefRangeEnd = 107270, XrefRangeStart = 107225, XrefRangeEnd = 107265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SetSpecializedText(Dictionary<string, string> specializations)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(specializations);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecializationManager.NativeMethodInfoPtr_SetSpecializedText_Public_Static_String_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060042A5 RID: 17061 RVA: 0x000F7BC8 File Offset: 0x000F5DC8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 107311, RefRangeEnd = 107317, XrefRangeStart = 107270, XrefRangeEnd = 107311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, string> GetSpecializations(string text, Dictionary<string, string> buffer = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecializationManager.NativeMethodInfoPtr_GetSpecializations_Public_Static_Dictionary_2_String_String_String_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
		}

		// Token: 0x060042A6 RID: 17062 RVA: 0x000F7C20 File Offset: 0x000F5E20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107347, RefRangeEnd = 107348, XrefRangeStart = 107317, XrefRangeEnd = 107347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendSpecializations(string text, List<string> list = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(list);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecializationManager.NativeMethodInfoPtr_AppendSpecializations_Public_Static_Void_String_List_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042A7 RID: 17063 RVA: 0x000288FA File Offset: 0x00026AFA
		public SpecializationManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x060042A8 RID: 17064 RVA: 0x000F7C68 File Offset: 0x000F5E68
		// (set) Token: 0x060042A9 RID: 17065 RVA: 0x00028903 File Offset: 0x00026B03
		public unsafe static SpecializationManager Singleton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpecializationManager.NativeFieldInfoPtr_Singleton, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecializationManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpecializationManager.NativeFieldInfoPtr_Singleton, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040028F2 RID: 10482
		private static readonly IntPtr NativeFieldInfoPtr_Singleton;

		// Token: 0x040028F3 RID: 10483
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040028F4 RID: 10484
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecializedText_Public_Static_String_String_String_0;

		// Token: 0x040028F5 RID: 10485
		private static readonly IntPtr NativeMethodInfoPtr_SetSpecializedText_Public_Static_String_String_String_String_0;

		// Token: 0x040028F6 RID: 10486
		private static readonly IntPtr NativeMethodInfoPtr_SetSpecializedText_Public_Static_String_Dictionary_2_String_String_0;

		// Token: 0x040028F7 RID: 10487
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecializations_Public_Static_Dictionary_2_String_String_String_Dictionary_2_String_String_0;

		// Token: 0x040028F8 RID: 10488
		private static readonly IntPtr NativeMethodInfoPtr_AppendSpecializations_Public_Static_Void_String_List_1_String_0;
	}
}
