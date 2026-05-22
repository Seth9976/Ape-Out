using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200017B RID: 379
	public class ScaleToOrthoSize : MonoBehaviour
	{
		// Token: 0x06002D30 RID: 11568 RVA: 0x000B0E10 File Offset: 0x000AF010
		// Note: this type is marked as 'beforefieldinit'.
		static ScaleToOrthoSize()
		{
			Il2CppClassPointerStore<ScaleToOrthoSize>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ScaleToOrthoSize");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScaleToOrthoSize>.NativeClassPtr);
			ScaleToOrthoSize.NativeFieldInfoPtr_defScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleToOrthoSize>.NativeClassPtr, "defScale");
			ScaleToOrthoSize.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleToOrthoSize>.NativeClassPtr, "cam");
			ScaleToOrthoSize.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleToOrthoSize>.NativeClassPtr, 100666810);
			ScaleToOrthoSize.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleToOrthoSize>.NativeClassPtr, 100666811);
			ScaleToOrthoSize.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleToOrthoSize>.NativeClassPtr, 100666812);
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x000B0EA4 File Offset: 0x000AF0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81082, XrefRangeEnd = 81088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleToOrthoSize.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x000B0ED8 File Offset: 0x000AF0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81088, XrefRangeEnd = 81094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleToOrthoSize.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x000B0F0C File Offset: 0x000AF10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScaleToOrthoSize()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScaleToOrthoSize>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleToOrthoSize.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D34 RID: 11572 RVA: 0x0001F4B1 File Offset: 0x0001D6B1
		public ScaleToOrthoSize(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x06002D35 RID: 11573 RVA: 0x000B0F48 File Offset: 0x000AF148
		// (set) Token: 0x06002D36 RID: 11574 RVA: 0x0001F4BA File Offset: 0x0001D6BA
		public unsafe Vector3 defScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleToOrthoSize.NativeFieldInfoPtr_defScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleToOrthoSize.NativeFieldInfoPtr_defScale)) = value;
			}
		}

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x06002D37 RID: 11575 RVA: 0x000B0F70 File Offset: 0x000AF170
		// (set) Token: 0x06002D38 RID: 11576 RVA: 0x0001F4D5 File Offset: 0x0001D6D5
		public unsafe Camera cam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleToOrthoSize.NativeFieldInfoPtr_cam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleToOrthoSize.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A9A RID: 6810
		private static readonly IntPtr NativeFieldInfoPtr_defScale;

		// Token: 0x04001A9B RID: 6811
		private static readonly IntPtr NativeFieldInfoPtr_cam;

		// Token: 0x04001A9C RID: 6812
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001A9D RID: 6813
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001A9E RID: 6814
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
