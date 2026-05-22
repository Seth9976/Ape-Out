using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x02000222 RID: 546
	public class Example_LocalizedString : MonoBehaviour
	{
		// Token: 0x06004249 RID: 16969 RVA: 0x000F645C File Offset: 0x000F465C
		// Note: this type is marked as 'beforefieldinit'.
		static Example_LocalizedString()
		{
			Il2CppClassPointerStore<Example_LocalizedString>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "Example_LocalizedString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Example_LocalizedString>.NativeClassPtr);
			Example_LocalizedString.NativeFieldInfoPtr__MyLocalizedString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Example_LocalizedString>.NativeClassPtr, "_MyLocalizedString");
			Example_LocalizedString.NativeFieldInfoPtr__NormalString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Example_LocalizedString>.NativeClassPtr, "_NormalString");
			Example_LocalizedString.NativeFieldInfoPtr__StringWithTermPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Example_LocalizedString>.NativeClassPtr, "_StringWithTermPopup");
			Example_LocalizedString.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Example_LocalizedString>.NativeClassPtr, 100669771);
			Example_LocalizedString.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Example_LocalizedString>.NativeClassPtr, 100669772);
		}

		// Token: 0x0600424A RID: 16970 RVA: 0x000F64F0 File Offset: 0x000F46F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106522, XrefRangeEnd = 106559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Example_LocalizedString.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600424B RID: 16971 RVA: 0x000F6524 File Offset: 0x000F4724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Example_LocalizedString()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Example_LocalizedString>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Example_LocalizedString.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600424C RID: 16972 RVA: 0x00028719 File Offset: 0x00026919
		public Example_LocalizedString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x0600424D RID: 16973 RVA: 0x000F6560 File Offset: 0x000F4760
		// (set) Token: 0x0600424E RID: 16974 RVA: 0x00028722 File Offset: 0x00026922
		public LocalizedString _MyLocalizedString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Example_LocalizedString.NativeFieldInfoPtr__MyLocalizedString);
				return new LocalizedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Example_LocalizedString.NativeFieldInfoPtr__MyLocalizedString), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x0600424F RID: 16975 RVA: 0x000F6590 File Offset: 0x000F4790
		// (set) Token: 0x06004250 RID: 16976 RVA: 0x00028750 File Offset: 0x00026950
		public unsafe string _NormalString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Example_LocalizedString.NativeFieldInfoPtr__NormalString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Example_LocalizedString.NativeFieldInfoPtr__NormalString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x06004251 RID: 16977 RVA: 0x000F65B8 File Offset: 0x000F47B8
		// (set) Token: 0x06004252 RID: 16978 RVA: 0x0002876F File Offset: 0x0002696F
		public unsafe string _StringWithTermPopup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Example_LocalizedString.NativeFieldInfoPtr__StringWithTermPopup);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Example_LocalizedString.NativeFieldInfoPtr__StringWithTermPopup), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040028B8 RID: 10424
		private static readonly IntPtr NativeFieldInfoPtr__MyLocalizedString;

		// Token: 0x040028B9 RID: 10425
		private static readonly IntPtr NativeFieldInfoPtr__NormalString;

		// Token: 0x040028BA RID: 10426
		private static readonly IntPtr NativeFieldInfoPtr__StringWithTermPopup;

		// Token: 0x040028BB RID: 10427
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040028BC RID: 10428
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
