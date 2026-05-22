using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200016E RID: 366
	public class RenderTextureResizer : MonoBehaviour
	{
		// Token: 0x06002BF7 RID: 11255 RVA: 0x000ADC44 File Offset: 0x000ABE44
		// Note: this type is marked as 'beforefieldinit'.
		static RenderTextureResizer()
		{
			Il2CppClassPointerStore<RenderTextureResizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RenderTextureResizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTextureResizer>.NativeClassPtr);
			RenderTextureResizer.NativeFieldInfoPtr_subMainCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureResizer>.NativeClassPtr, "subMainCam");
			RenderTextureResizer.NativeFieldInfoPtr_subMainQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureResizer>.NativeClassPtr, "subMainQuad");
			RenderTextureResizer.NativeFieldInfoPtr_smallRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureResizer>.NativeClassPtr, "smallRend");
			RenderTextureResizer.NativeFieldInfoPtr_bigRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureResizer>.NativeClassPtr, "bigRend");
			RenderTextureResizer.NativeFieldInfoPtr_mainMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureResizer>.NativeClassPtr, "mainMat");
			RenderTextureResizer.NativeFieldInfoPtr_m_is1080 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureResizer>.NativeClassPtr, "m_is1080");
			RenderTextureResizer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureResizer>.NativeClassPtr, 100666744);
			RenderTextureResizer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureResizer>.NativeClassPtr, 100666745);
			RenderTextureResizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureResizer>.NativeClassPtr, 100666746);
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x000ADD28 File Offset: 0x000ABF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79834, XrefRangeEnd = 79867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureResizer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x000ADD5C File Offset: 0x000ABF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79867, XrefRangeEnd = 79873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureResizer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x000ADD90 File Offset: 0x000ABF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureResizer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTextureResizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureResizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x0001E7C4 File Offset: 0x0001C9C4
		public RenderTextureResizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x06002BFC RID: 11260 RVA: 0x000ADDCC File Offset: 0x000ABFCC
		// (set) Token: 0x06002BFD RID: 11261 RVA: 0x0001E7CD File Offset: 0x0001C9CD
		public unsafe Camera subMainCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTextureResizer.NativeFieldInfoPtr_subMainCam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTextureResizer.NativeFieldInfoPtr_subMainCam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x06002BFE RID: 11262 RVA: 0x000ADDFC File Offset: 0x000ABFFC
		// (set) Token: 0x06002BFF RID: 11263 RVA: 0x0001E7EC File Offset: 0x0001C9EC
		public unsafe MeshRenderer subMainQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTextureResizer.NativeFieldInfoPtr_subMainQuad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTextureResizer.NativeFieldInfoPtr_subMainQuad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x06002C00 RID: 11264 RVA: 0x000ADE2C File Offset: 0x000AC02C
		// (set) Token: 0x06002C01 RID: 11265 RVA: 0x0001E80B File Offset: 0x0001CA0B
		public unsafe RenderTexture smallRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTextureResizer.NativeFieldInfoPtr_smallRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTextureResizer.NativeFieldInfoPtr_smallRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x06002C02 RID: 11266 RVA: 0x000ADE5C File Offset: 0x000AC05C
		// (set) Token: 0x06002C03 RID: 11267 RVA: 0x0001E82A File Offset: 0x0001CA2A
		public unsafe RenderTexture bigRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTextureResizer.NativeFieldInfoPtr_bigRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTextureResizer.NativeFieldInfoPtr_bigRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x06002C04 RID: 11268 RVA: 0x000ADE8C File Offset: 0x000AC08C
		// (set) Token: 0x06002C05 RID: 11269 RVA: 0x0001E849 File Offset: 0x0001CA49
		public unsafe Material mainMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTextureResizer.NativeFieldInfoPtr_mainMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTextureResizer.NativeFieldInfoPtr_mainMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x06002C06 RID: 11270 RVA: 0x000ADEBC File Offset: 0x000AC0BC
		// (set) Token: 0x06002C07 RID: 11271 RVA: 0x0001E868 File Offset: 0x0001CA68
		public unsafe static bool m_is1080
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(RenderTextureResizer.NativeFieldInfoPtr_m_is1080, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderTextureResizer.NativeFieldInfoPtr_m_is1080, (void*)(&value));
			}
		}

		// Token: 0x040019EA RID: 6634
		private static readonly IntPtr NativeFieldInfoPtr_subMainCam;

		// Token: 0x040019EB RID: 6635
		private static readonly IntPtr NativeFieldInfoPtr_subMainQuad;

		// Token: 0x040019EC RID: 6636
		private static readonly IntPtr NativeFieldInfoPtr_smallRend;

		// Token: 0x040019ED RID: 6637
		private static readonly IntPtr NativeFieldInfoPtr_bigRend;

		// Token: 0x040019EE RID: 6638
		private static readonly IntPtr NativeFieldInfoPtr_mainMat;

		// Token: 0x040019EF RID: 6639
		private static readonly IntPtr NativeFieldInfoPtr_m_is1080;

		// Token: 0x040019F0 RID: 6640
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040019F1 RID: 6641
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040019F2 RID: 6642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
