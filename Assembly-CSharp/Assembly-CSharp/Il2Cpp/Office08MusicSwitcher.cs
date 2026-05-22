using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200013F RID: 319
	public class Office08MusicSwitcher : MonoBehaviour
	{
		// Token: 0x060026B6 RID: 9910 RVA: 0x0009FDB8 File Offset: 0x0009DFB8
		// Note: this type is marked as 'beforefieldinit'.
		static Office08MusicSwitcher()
		{
			Il2CppClassPointerStore<Office08MusicSwitcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Office08MusicSwitcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Office08MusicSwitcher>.NativeClassPtr);
			Office08MusicSwitcher.NativeFieldInfoPtr_switched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Office08MusicSwitcher>.NativeClassPtr, "switched");
			Office08MusicSwitcher.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Office08MusicSwitcher>.NativeClassPtr, 100666393);
			Office08MusicSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Office08MusicSwitcher>.NativeClassPtr, 100666394);
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x0009FE24 File Offset: 0x0009E024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74895, XrefRangeEnd = 74905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Office08MusicSwitcher.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x0009FE58 File Offset: 0x0009E058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Office08MusicSwitcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Office08MusicSwitcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Office08MusicSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x0001AF6C File Offset: 0x0001916C
		public Office08MusicSwitcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x060026BA RID: 9914 RVA: 0x0009FE94 File Offset: 0x0009E094
		// (set) Token: 0x060026BB RID: 9915 RVA: 0x0001AF75 File Offset: 0x00019175
		public unsafe bool switched
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Office08MusicSwitcher.NativeFieldInfoPtr_switched);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Office08MusicSwitcher.NativeFieldInfoPtr_switched)) = value;
			}
		}

		// Token: 0x040016D9 RID: 5849
		private static readonly IntPtr NativeFieldInfoPtr_switched;

		// Token: 0x040016DA RID: 5850
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040016DB RID: 5851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
