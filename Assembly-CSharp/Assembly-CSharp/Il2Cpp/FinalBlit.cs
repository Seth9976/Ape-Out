using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000D1 RID: 209
	public class FinalBlit : MonoBehaviour
	{
		// Token: 0x060018C4 RID: 6340 RVA: 0x00079E20 File Offset: 0x00078020
		// Note: this type is marked as 'beforefieldinit'.
		static FinalBlit()
		{
			Il2CppClassPointerStore<FinalBlit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FinalBlit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBlit>.NativeClassPtr);
			FinalBlit.NativeFieldInfoPtr_rt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlit>.NativeClassPtr, "rt");
			FinalBlit.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlit>.NativeClassPtr, "me");
			FinalBlit.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlit>.NativeClassPtr, "cam");
			FinalBlit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBlit>.NativeClassPtr, 100665333);
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00079EA0 File Offset: 0x000780A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FinalBlit()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalBlit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalBlit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x00011C09 File Offset: 0x0000FE09
		public FinalBlit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x060018C7 RID: 6343 RVA: 0x00079EDC File Offset: 0x000780DC
		// (set) Token: 0x060018C8 RID: 6344 RVA: 0x00011C12 File Offset: 0x0000FE12
		public unsafe RenderTexture rt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlit.NativeFieldInfoPtr_rt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlit.NativeFieldInfoPtr_rt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x060018C9 RID: 6345 RVA: 0x00079F0C File Offset: 0x0007810C
		// (set) Token: 0x060018CA RID: 6346 RVA: 0x00011C31 File Offset: 0x0000FE31
		public unsafe static FinalBlit me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FinalBlit.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FinalBlit>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FinalBlit.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x060018CB RID: 6347 RVA: 0x00079F34 File Offset: 0x00078134
		// (set) Token: 0x060018CC RID: 6348 RVA: 0x00011C43 File Offset: 0x0000FE43
		public unsafe Camera cam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlit.NativeFieldInfoPtr_cam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalBlit.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeFieldInfoPtr_rt;

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeFieldInfoPtr_cam;

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
