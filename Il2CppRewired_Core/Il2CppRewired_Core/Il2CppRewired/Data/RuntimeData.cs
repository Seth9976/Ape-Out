using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Platforms;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppRewired.Data
{
	// Token: 0x020000BC RID: 188
	public class RuntimeData : ScriptableObject
	{
		// Token: 0x0600159E RID: 5534 RVA: 0x0007DF98 File Offset: 0x0007C198
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeData()
		{
			Il2CppClassPointerStore<RuntimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data", "RuntimeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeData>.NativeClassPtr);
			RuntimeData.NativeFieldInfoPtr_platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeData>.NativeClassPtr, "platform");
			RuntimeData.NativeFieldInfoPtr_webplayerPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeData>.NativeClassPtr, "webplayerPlatform");
			RuntimeData.NativeFieldInfoPtr_editorPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeData>.NativeClassPtr, "editorPlatform");
			RuntimeData.NativeFieldInfoPtr_libraries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeData>.NativeClassPtr, "libraries");
			RuntimeData.NativeMethodInfoPtr_SetPlatform_Public_Void_Platform_WebplayerPlatform_EditorPlatform_List_1_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeData>.NativeClassPtr, 100668398);
			RuntimeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeData>.NativeClassPtr, 100668399);
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x0007E040 File Offset: 0x0007C240
		[CallerCount(0)]
		public unsafe void SetPlatform(Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform, List<TextAsset> libraries)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref webplayerPlatform;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref editorPlatform;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(libraries);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeData.NativeMethodInfoPtr_SetPlatform_Public_Void_Platform_WebplayerPlatform_EditorPlatform_List_1_TextAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x0007E0B0 File Offset: 0x0007C2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00009752 File Offset: 0x00007952
		public RuntimeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x0007E0EC File Offset: 0x0007C2EC
		// (set) Token: 0x060015A3 RID: 5539 RVA: 0x0000975B File Offset: 0x0000795B
		public unsafe Platform platform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeData.NativeFieldInfoPtr_platform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeData.NativeFieldInfoPtr_platform)) = value;
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x0007E114 File Offset: 0x0007C314
		// (set) Token: 0x060015A5 RID: 5541 RVA: 0x00009776 File Offset: 0x00007976
		public unsafe WebplayerPlatform webplayerPlatform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeData.NativeFieldInfoPtr_webplayerPlatform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeData.NativeFieldInfoPtr_webplayerPlatform)) = value;
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x0007E13C File Offset: 0x0007C33C
		// (set) Token: 0x060015A7 RID: 5543 RVA: 0x00009791 File Offset: 0x00007991
		public unsafe EditorPlatform editorPlatform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeData.NativeFieldInfoPtr_editorPlatform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeData.NativeFieldInfoPtr_editorPlatform)) = value;
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060015A8 RID: 5544 RVA: 0x0007E164 File Offset: 0x0007C364
		// (set) Token: 0x060015A9 RID: 5545 RVA: 0x000097AC File Offset: 0x000079AC
		public unsafe List<TextAsset> libraries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeData.NativeFieldInfoPtr_libraries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TextAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeData.NativeFieldInfoPtr_libraries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400116A RID: 4458
		private static readonly IntPtr NativeFieldInfoPtr_platform;

		// Token: 0x0400116B RID: 4459
		private static readonly IntPtr NativeFieldInfoPtr_webplayerPlatform;

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeFieldInfoPtr_editorPlatform;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeFieldInfoPtr_libraries;

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeMethodInfoPtr_SetPlatform_Public_Void_Platform_WebplayerPlatform_EditorPlatform_List_1_TextAsset_0;

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
