using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000059 RID: 89
	public class SECTR_FogDisable : MonoBehaviour
	{
		// Token: 0x06000CC5 RID: 3269 RVA: 0x0005A95C File Offset: 0x00058B5C
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_FogDisable()
		{
			Il2CppClassPointerStore<SECTR_FogDisable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_FogDisable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_FogDisable>.NativeClassPtr);
			SECTR_FogDisable.NativeFieldInfoPtr_previousFogState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_FogDisable>.NativeClassPtr, "previousFogState");
			SECTR_FogDisable.NativeMethodInfoPtr_OnPreRender_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_FogDisable>.NativeClassPtr, 100664431);
			SECTR_FogDisable.NativeMethodInfoPtr_OnPostRender_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_FogDisable>.NativeClassPtr, 100664432);
			SECTR_FogDisable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_FogDisable>.NativeClassPtr, 100664433);
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x0005A9DC File Offset: 0x00058BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43374, XrefRangeEnd = 43382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPreRender()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_FogDisable.NativeMethodInfoPtr_OnPreRender_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x0005AA10 File Offset: 0x00058C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43382, XrefRangeEnd = 43386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPostRender()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_FogDisable.NativeMethodInfoPtr_OnPostRender_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x0005AA44 File Offset: 0x00058C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_FogDisable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_FogDisable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_FogDisable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00009BCA File Offset: 0x00007DCA
		public SECTR_FogDisable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x0005AA80 File Offset: 0x00058C80
		// (set) Token: 0x06000CCB RID: 3275 RVA: 0x00009BD3 File Offset: 0x00007DD3
		public unsafe bool previousFogState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FogDisable.NativeFieldInfoPtr_previousFogState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FogDisable.NativeFieldInfoPtr_previousFogState)) = value;
			}
		}

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeFieldInfoPtr_previousFogState;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeMethodInfoPtr_OnPreRender_Private_Void_0;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr_OnPostRender_Private_Void_0;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
