using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x0200026D RID: 621
	public class SetLanguage : MonoBehaviour
	{
		// Token: 0x0600468F RID: 18063 RVA: 0x00107410 File Offset: 0x00105610
		// Note: this type is marked as 'beforefieldinit'.
		static SetLanguage()
		{
			Il2CppClassPointerStore<SetLanguage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "SetLanguage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetLanguage>.NativeClassPtr);
			SetLanguage.NativeFieldInfoPtr__Language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetLanguage>.NativeClassPtr, "_Language");
			SetLanguage.NativeMethodInfoPtr_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLanguage>.NativeClassPtr, 100670440);
			SetLanguage.NativeMethodInfoPtr_ApplyLanguage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLanguage>.NativeClassPtr, 100670441);
			SetLanguage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLanguage>.NativeClassPtr, 100670442);
		}

		// Token: 0x06004690 RID: 18064 RVA: 0x00107490 File Offset: 0x00105690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115533, XrefRangeEnd = 115540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetLanguage.NativeMethodInfoPtr_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004691 RID: 18065 RVA: 0x001074C4 File Offset: 0x001056C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyLanguage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetLanguage.NativeMethodInfoPtr_ApplyLanguage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004692 RID: 18066 RVA: 0x001074F8 File Offset: 0x001056F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetLanguage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetLanguage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetLanguage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004693 RID: 18067 RVA: 0x00029F01 File Offset: 0x00028101
		public SetLanguage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x06004694 RID: 18068 RVA: 0x00107534 File Offset: 0x00105734
		// (set) Token: 0x06004695 RID: 18069 RVA: 0x00029F0A File Offset: 0x0002810A
		public unsafe string _Language
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetLanguage.NativeFieldInfoPtr__Language);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetLanguage.NativeFieldInfoPtr__Language), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002C23 RID: 11299
		private static readonly IntPtr NativeFieldInfoPtr__Language;

		// Token: 0x04002C24 RID: 11300
		private static readonly IntPtr NativeMethodInfoPtr_OnClick_Private_Void_0;

		// Token: 0x04002C25 RID: 11301
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLanguage_Public_Void_0;

		// Token: 0x04002C26 RID: 11302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
