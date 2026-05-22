using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000113 RID: 275
	public class KeyboardTxtSwitcher : MonoBehaviour
	{
		// Token: 0x0600208E RID: 8334 RVA: 0x0008F570 File Offset: 0x0008D770
		// Note: this type is marked as 'beforefieldinit'.
		static KeyboardTxtSwitcher()
		{
			Il2CppClassPointerStore<KeyboardTxtSwitcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "KeyboardTxtSwitcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyboardTxtSwitcher>.NativeClassPtr);
			KeyboardTxtSwitcher.NativeFieldInfoPtr_controllerTextNonEnglish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardTxtSwitcher>.NativeClassPtr, "controllerTextNonEnglish");
			KeyboardTxtSwitcher.NativeFieldInfoPtr_controllerTxt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardTxtSwitcher>.NativeClassPtr, "controllerTxt");
			KeyboardTxtSwitcher.NativeFieldInfoPtr_keyboardTxt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardTxtSwitcher>.NativeClassPtr, "keyboardTxt");
			KeyboardTxtSwitcher.NativeFieldInfoPtr_langCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardTxtSwitcher>.NativeClassPtr, "langCode");
			KeyboardTxtSwitcher.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardTxtSwitcher>.NativeClassPtr, 100665863);
			KeyboardTxtSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardTxtSwitcher>.NativeClassPtr, 100665864);
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x0008F618 File Offset: 0x0008D818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67785, XrefRangeEnd = 67821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardTxtSwitcher.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x0008F64C File Offset: 0x0008D84C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67821, XrefRangeEnd = 67826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyboardTxtSwitcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyboardTxtSwitcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardTxtSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x00016C35 File Offset: 0x00014E35
		public KeyboardTxtSwitcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06002092 RID: 8338 RVA: 0x0008F688 File Offset: 0x0008D888
		// (set) Token: 0x06002093 RID: 8339 RVA: 0x00016C3E File Offset: 0x00014E3E
		public unsafe GameObject controllerTextNonEnglish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardTxtSwitcher.NativeFieldInfoPtr_controllerTextNonEnglish);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardTxtSwitcher.NativeFieldInfoPtr_controllerTextNonEnglish), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06002094 RID: 8340 RVA: 0x0008F6B8 File Offset: 0x0008D8B8
		// (set) Token: 0x06002095 RID: 8341 RVA: 0x00016C5D File Offset: 0x00014E5D
		public unsafe GameObject controllerTxt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardTxtSwitcher.NativeFieldInfoPtr_controllerTxt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardTxtSwitcher.NativeFieldInfoPtr_controllerTxt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06002096 RID: 8342 RVA: 0x0008F6E8 File Offset: 0x0008D8E8
		// (set) Token: 0x06002097 RID: 8343 RVA: 0x00016C7C File Offset: 0x00014E7C
		public unsafe GameObject keyboardTxt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardTxtSwitcher.NativeFieldInfoPtr_keyboardTxt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardTxtSwitcher.NativeFieldInfoPtr_keyboardTxt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06002098 RID: 8344 RVA: 0x0008F718 File Offset: 0x0008D918
		// (set) Token: 0x06002099 RID: 8345 RVA: 0x00016C9B File Offset: 0x00014E9B
		public unsafe string langCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardTxtSwitcher.NativeFieldInfoPtr_langCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardTxtSwitcher.NativeFieldInfoPtr_langCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400134A RID: 4938
		private static readonly IntPtr NativeFieldInfoPtr_controllerTextNonEnglish;

		// Token: 0x0400134B RID: 4939
		private static readonly IntPtr NativeFieldInfoPtr_controllerTxt;

		// Token: 0x0400134C RID: 4940
		private static readonly IntPtr NativeFieldInfoPtr_keyboardTxt;

		// Token: 0x0400134D RID: 4941
		private static readonly IntPtr NativeFieldInfoPtr_langCode;

		// Token: 0x0400134E RID: 4942
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400134F RID: 4943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
