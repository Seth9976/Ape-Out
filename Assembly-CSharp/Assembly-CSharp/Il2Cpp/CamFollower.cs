using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200009F RID: 159
	public class CamFollower : MonoBehaviour
	{
		// Token: 0x060013BC RID: 5052 RVA: 0x0006C560 File Offset: 0x0006A760
		// Note: this type is marked as 'beforefieldinit'.
		static CamFollower()
		{
			Il2CppClassPointerStore<CamFollower>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CamFollower");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CamFollower>.NativeClassPtr);
			CamFollower.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamFollower>.NativeClassPtr, "cam");
			CamFollower.NativeFieldInfoPtr_dadCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamFollower>.NativeClassPtr, "dadCam");
			CamFollower.NativeFieldInfoPtr_quad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamFollower>.NativeClassPtr, "quad");
			CamFollower.NativeFieldInfoPtr_defSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamFollower>.NativeClassPtr, "defSize");
			CamFollower.NativeFieldInfoPtr_camSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamFollower>.NativeClassPtr, "camSize");
			CamFollower.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamFollower>.NativeClassPtr, 100664974);
			CamFollower.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamFollower>.NativeClassPtr, 100664975);
			CamFollower.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamFollower>.NativeClassPtr, 100664976);
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x0006C630 File Offset: 0x0006A830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51725, XrefRangeEnd = 51746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamFollower.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x0006C664 File Offset: 0x0006A864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51746, XrefRangeEnd = 51780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamFollower.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x0006C698 File Offset: 0x0006A898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51780, XrefRangeEnd = 51783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CamFollower()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CamFollower>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamFollower.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x0000E779 File Offset: 0x0000C979
		public CamFollower(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x0006C6D4 File Offset: 0x0006A8D4
		// (set) Token: 0x060013C2 RID: 5058 RVA: 0x0000E782 File Offset: 0x0000C982
		public unsafe Camera cam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamFollower.NativeFieldInfoPtr_cam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamFollower.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x0006C704 File Offset: 0x0006A904
		// (set) Token: 0x060013C4 RID: 5060 RVA: 0x0000E7A1 File Offset: 0x0000C9A1
		public unsafe Camera dadCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamFollower.NativeFieldInfoPtr_dadCam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamFollower.NativeFieldInfoPtr_dadCam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x0006C734 File Offset: 0x0006A934
		// (set) Token: 0x060013C6 RID: 5062 RVA: 0x0000E7C0 File Offset: 0x0000C9C0
		public unsafe GameObject quad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamFollower.NativeFieldInfoPtr_quad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamFollower.NativeFieldInfoPtr_quad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x0006C764 File Offset: 0x0006A964
		// (set) Token: 0x060013C8 RID: 5064 RVA: 0x0000E7DF File Offset: 0x0000C9DF
		public unsafe Vector2 defSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamFollower.NativeFieldInfoPtr_defSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamFollower.NativeFieldInfoPtr_defSize)) = value;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x0006C78C File Offset: 0x0006A98C
		// (set) Token: 0x060013CA RID: 5066 RVA: 0x0000E7FA File Offset: 0x0000C9FA
		public unsafe float camSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamFollower.NativeFieldInfoPtr_camSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamFollower.NativeFieldInfoPtr_camSize)) = value;
			}
		}

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeFieldInfoPtr_cam;

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeFieldInfoPtr_dadCam;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeFieldInfoPtr_quad;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeFieldInfoPtr_defSize;

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeFieldInfoPtr_camSize;

		// Token: 0x04000BD9 RID: 3033
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
