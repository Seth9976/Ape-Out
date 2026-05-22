using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Platforms;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.Data
{
	// Token: 0x020000BD RID: 189
	public class EditorPlatformData : ScriptableObject
	{
		// Token: 0x060015AA RID: 5546 RVA: 0x0007E194 File Offset: 0x0007C394
		// Note: this type is marked as 'beforefieldinit'.
		static EditorPlatformData()
		{
			Il2CppClassPointerStore<EditorPlatformData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data", "EditorPlatformData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditorPlatformData>.NativeClassPtr);
			EditorPlatformData.NativeFieldInfoPtr_windowsStandalone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorPlatformData>.NativeClassPtr, "windowsStandalone");
			EditorPlatformData.NativeFieldInfoPtr_windowsStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorPlatformData>.NativeClassPtr, "windowsStore");
			EditorPlatformData.NativeFieldInfoPtr_osxStandalone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorPlatformData>.NativeClassPtr, "osxStandalone");
			EditorPlatformData.NativeFieldInfoPtr_linuxStandalone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorPlatformData>.NativeClassPtr, "linuxStandalone");
			EditorPlatformData.NativeFieldInfoPtr_webplayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorPlatformData>.NativeClassPtr, "webplayer");
			EditorPlatformData.NativeFieldInfoPtr_fallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorPlatformData>.NativeClassPtr, "fallback");
			EditorPlatformData.NativeMethodInfoPtr_GetLibraries_Public_Il2CppReferenceArray_1_TextAsset_Platform_WebplayerPlatform_EditorPlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorPlatformData>.NativeClassPtr, 100668400);
			EditorPlatformData.NativeMethodInfoPtr_GetPlatform_Public_Platform_Platform_WebplayerPlatform_EditorPlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorPlatformData>.NativeClassPtr, 100668401);
			EditorPlatformData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorPlatformData>.NativeClassPtr, 100668402);
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x0007E278 File Offset: 0x0007C478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271498, XrefRangeEnd = 271503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<TextAsset> GetLibraries(Il2CppRewired.Platforms.Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref webplayerPlatform;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref editorPlatform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorPlatformData.NativeMethodInfoPtr_GetLibraries_Public_Il2CppReferenceArray_1_TextAsset_Platform_WebplayerPlatform_EditorPlatform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextAsset>>(intPtr3) : null;
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x0007E2E0 File Offset: 0x0007C4E0
		[CallerCount(0)]
		public unsafe EditorPlatformData.Platform GetPlatform(Il2CppRewired.Platforms.Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref webplayerPlatform;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref editorPlatform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorPlatformData.NativeMethodInfoPtr_GetPlatform_Public_Platform_Platform_WebplayerPlatform_EditorPlatform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EditorPlatformData.Platform>(intPtr3) : null;
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x0007E348 File Offset: 0x0007C548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EditorPlatformData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditorPlatformData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorPlatformData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x000097CB File Offset: 0x000079CB
		public EditorPlatformData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x0007E384 File Offset: 0x0007C584
		// (set) Token: 0x060015B0 RID: 5552 RVA: 0x000097D4 File Offset: 0x000079D4
		public unsafe EditorPlatformData.Platform windowsStandalone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPlatformData.NativeFieldInfoPtr_windowsStandalone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EditorPlatformData.Platform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPlatformData.NativeFieldInfoPtr_windowsStandalone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x0007E3B4 File Offset: 0x0007C5B4
		// (set) Token: 0x060015B2 RID: 5554 RVA: 0x000097F3 File Offset: 0x000079F3
		public unsafe EditorPlatformData.Platform windowsStore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPlatformData.NativeFieldInfoPtr_windowsStore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EditorPlatformData.Platform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPlatformData.NativeFieldInfoPtr_windowsStore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x0007E3E4 File Offset: 0x0007C5E4
		// (set) Token: 0x060015B4 RID: 5556 RVA: 0x00009812 File Offset: 0x00007A12
		public unsafe EditorPlatformData.Platform osxStandalone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPlatformData.NativeFieldInfoPtr_osxStandalone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EditorPlatformData.Platform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPlatformData.NativeFieldInfoPtr_osxStandalone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060015B5 RID: 5557 RVA: 0x0007E414 File Offset: 0x0007C614
		// (set) Token: 0x060015B6 RID: 5558 RVA: 0x00009831 File Offset: 0x00007A31
		public unsafe EditorPlatformData.Platform linuxStandalone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPlatformData.NativeFieldInfoPtr_linuxStandalone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EditorPlatformData.Platform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPlatformData.NativeFieldInfoPtr_linuxStandalone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060015B7 RID: 5559 RVA: 0x0007E444 File Offset: 0x0007C644
		// (set) Token: 0x060015B8 RID: 5560 RVA: 0x00009850 File Offset: 0x00007A50
		public unsafe EditorPlatformData.Platform webplayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPlatformData.NativeFieldInfoPtr_webplayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EditorPlatformData.Platform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPlatformData.NativeFieldInfoPtr_webplayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060015B9 RID: 5561 RVA: 0x0007E474 File Offset: 0x0007C674
		// (set) Token: 0x060015BA RID: 5562 RVA: 0x0000986F File Offset: 0x00007A6F
		public unsafe EditorPlatformData.Platform fallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPlatformData.NativeFieldInfoPtr_fallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EditorPlatformData.Platform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPlatformData.NativeFieldInfoPtr_fallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeFieldInfoPtr_windowsStandalone;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeFieldInfoPtr_windowsStore;

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeFieldInfoPtr_osxStandalone;

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeFieldInfoPtr_linuxStandalone;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeFieldInfoPtr_webplayer;

		// Token: 0x04001175 RID: 4469
		private static readonly IntPtr NativeFieldInfoPtr_fallback;

		// Token: 0x04001176 RID: 4470
		private static readonly IntPtr NativeMethodInfoPtr_GetLibraries_Public_Il2CppReferenceArray_1_TextAsset_Platform_WebplayerPlatform_EditorPlatform_0;

		// Token: 0x04001177 RID: 4471
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatform_Public_Platform_Platform_WebplayerPlatform_EditorPlatform_0;

		// Token: 0x04001178 RID: 4472
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200030D RID: 781
		[Serializable]
		public class Platform : global::Il2CppSystem.Object
		{
			// Token: 0x06004282 RID: 17026 RVA: 0x0013AFA4 File Offset: 0x001391A4
			// Note: this type is marked as 'beforefieldinit'.
			static Platform()
			{
				Il2CppClassPointerStore<EditorPlatformData.Platform>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EditorPlatformData>.NativeClassPtr, "Platform");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditorPlatformData.Platform>.NativeClassPtr);
				EditorPlatformData.Platform.NativeFieldInfoPtr_libraries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorPlatformData.Platform>.NativeClassPtr, "libraries");
				EditorPlatformData.Platform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorPlatformData.Platform>.NativeClassPtr, 100668403);
			}

			// Token: 0x06004283 RID: 17027 RVA: 0x0013AFF8 File Offset: 0x001391F8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Platform()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditorPlatformData.Platform>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorPlatformData.Platform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004284 RID: 17028 RVA: 0x000177E6 File Offset: 0x000159E6
			public Platform(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014A6 RID: 5286
			// (get) Token: 0x06004285 RID: 17029 RVA: 0x0013B034 File Offset: 0x00139234
			// (set) Token: 0x06004286 RID: 17030 RVA: 0x000177EF File Offset: 0x000159EF
			public unsafe Il2CppReferenceArray<TextAsset> libraries
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPlatformData.Platform.NativeFieldInfoPtr_libraries);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextAsset>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPlatformData.Platform.NativeFieldInfoPtr_libraries), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040036DA RID: 14042
			private static readonly IntPtr NativeFieldInfoPtr_libraries;

			// Token: 0x040036DB RID: 14043
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
