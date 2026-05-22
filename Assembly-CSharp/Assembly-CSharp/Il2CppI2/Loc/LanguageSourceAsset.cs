using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x0200023B RID: 571
	public class LanguageSourceAsset : ScriptableObject
	{
		// Token: 0x06004388 RID: 17288 RVA: 0x000FAB0C File Offset: 0x000F8D0C
		// Note: this type is marked as 'beforefieldinit'.
		static LanguageSourceAsset()
		{
			Il2CppClassPointerStore<LanguageSourceAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "LanguageSourceAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LanguageSourceAsset>.NativeClassPtr);
			LanguageSourceAsset.NativeFieldInfoPtr_mSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSourceAsset>.NativeClassPtr, "mSource");
			LanguageSourceAsset.NativeMethodInfoPtr_get_SourceData_Public_Virtual_Final_New_get_LanguageSourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceAsset>.NativeClassPtr, 100669937);
			LanguageSourceAsset.NativeMethodInfoPtr_set_SourceData_Public_Virtual_Final_New_set_Void_LanguageSourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceAsset>.NativeClassPtr, 100669938);
			LanguageSourceAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSourceAsset>.NativeClassPtr, 100669939);
		}

		// Token: 0x1700193E RID: 6462
		// (get) Token: 0x06004389 RID: 17289 RVA: 0x000FAB8C File Offset: 0x000F8D8C
		// (set) Token: 0x0600438A RID: 17290 RVA: 0x000FABCC File Offset: 0x000F8DCC
		public unsafe virtual LanguageSourceData SourceData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceAsset.NativeMethodInfoPtr_get_SourceData_Public_Virtual_Final_New_get_LanguageSourceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LanguageSourceData>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceAsset.NativeMethodInfoPtr_set_SourceData_Public_Virtual_Final_New_set_Void_LanguageSourceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600438B RID: 17291 RVA: 0x000FAC10 File Offset: 0x000F8E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108826, XrefRangeEnd = 108831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LanguageSourceAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LanguageSourceAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSourceAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600438C RID: 17292 RVA: 0x0002901B File Offset: 0x0002721B
		public LanguageSourceAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700193D RID: 6461
		// (get) Token: 0x0600438D RID: 17293 RVA: 0x000FAC4C File Offset: 0x000F8E4C
		// (set) Token: 0x0600438E RID: 17294 RVA: 0x00029024 File Offset: 0x00027224
		public unsafe LanguageSourceData mSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceAsset.NativeFieldInfoPtr_mSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LanguageSourceData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSourceAsset.NativeFieldInfoPtr_mSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002990 RID: 10640
		private static readonly IntPtr NativeFieldInfoPtr_mSource;

		// Token: 0x04002991 RID: 10641
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceData_Public_Virtual_Final_New_get_LanguageSourceData_0;

		// Token: 0x04002992 RID: 10642
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceData_Public_Virtual_Final_New_set_Void_LanguageSourceData_0;

		// Token: 0x04002993 RID: 10643
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
