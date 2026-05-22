using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppLetterboxCamera
{
	// Token: 0x02000216 RID: 534
	[Serializable]
	public class ForceCameraRatio : MonoBehaviour
	{
		// Token: 0x06001E4A RID: 7754 RVA: 0x00087658 File Offset: 0x00085858
		// Note: this type is marked as 'beforefieldinit'.
		static ForceCameraRatio()
		{
			Il2CppClassPointerStore<ForceCameraRatio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "LetterboxCamera", "ForceCameraRatio");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForceCameraRatio>.NativeClassPtr);
			ForceCameraRatio.NativeFieldInfoPtr_ratio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceCameraRatio>.NativeClassPtr, "ratio");
			ForceCameraRatio.NativeFieldInfoPtr_forceRatioOnAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceCameraRatio>.NativeClassPtr, "forceRatioOnAwake");
			ForceCameraRatio.NativeFieldInfoPtr_listenForWindowChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceCameraRatio>.NativeClassPtr, "listenForWindowChanges");
			ForceCameraRatio.NativeFieldInfoPtr_createCameraForLetterBoxRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceCameraRatio>.NativeClassPtr, "createCameraForLetterBoxRendering");
			ForceCameraRatio.NativeFieldInfoPtr_findCamerasAutomatically = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceCameraRatio>.NativeClassPtr, "findCamerasAutomatically");
			ForceCameraRatio.NativeFieldInfoPtr_letterBoxCameraColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceCameraRatio>.NativeClassPtr, "letterBoxCameraColor");
			ForceCameraRatio.NativeFieldInfoPtr_cameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceCameraRatio>.NativeClassPtr, "cameras");
			ForceCameraRatio.NativeFieldInfoPtr_letterBoxCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceCameraRatio>.NativeClassPtr, "letterBoxCamera");
			ForceCameraRatio.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceCameraRatio>.NativeClassPtr, 100668186);
			ForceCameraRatio.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceCameraRatio>.NativeClassPtr, 100668187);
			ForceCameraRatio.NativeMethodInfoPtr_GetCameraRatioByCamera_Private_CameraRatio_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceCameraRatio>.NativeClassPtr, 100668188);
			ForceCameraRatio.NativeMethodInfoPtr_ValidateCameraArray_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceCameraRatio>.NativeClassPtr, 100668189);
			ForceCameraRatio.NativeMethodInfoPtr_FindAllCamerasInScene_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceCameraRatio>.NativeClassPtr, 100668190);
			ForceCameraRatio.NativeMethodInfoPtr_CalculateAndSetAllCameraRatios_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceCameraRatio>.NativeClassPtr, 100668191);
			ForceCameraRatio.NativeMethodInfoPtr_SetCameraAnchor_Public_Void_Camera_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceCameraRatio>.NativeClassPtr, 100668192);
			ForceCameraRatio.NativeMethodInfoPtr_GetCameras_Public_Il2CppReferenceArray_1_CameraRatio_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceCameraRatio>.NativeClassPtr, 100668193);
			ForceCameraRatio.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceCameraRatio>.NativeClassPtr, 100668194);
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x000877DC File Offset: 0x000859DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30043, XrefRangeEnd = 30099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceCameraRatio.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00087810 File Offset: 0x00085A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30099, XrefRangeEnd = 30114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceCameraRatio.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x00087844 File Offset: 0x00085A44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30139, XrefRangeStart = 30114, XrefRangeEnd = 30138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraRatio GetCameraRatioByCamera(Camera _camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceCameraRatio.NativeMethodInfoPtr_GetCameraRatioByCamera_Private_CameraRatio_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraRatio>(intPtr3) : null;
			}
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x00087894 File Offset: 0x00085A94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30159, RefRangeEnd = 30160, XrefRangeStart = 30139, XrefRangeEnd = 30159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateCameraArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceCameraRatio.NativeMethodInfoPtr_ValidateCameraArray_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x000878C8 File Offset: 0x00085AC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30200, RefRangeEnd = 30201, XrefRangeStart = 30160, XrefRangeEnd = 30200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FindAllCamerasInScene()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceCameraRatio.NativeMethodInfoPtr_FindAllCamerasInScene_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x000878FC File Offset: 0x00085AFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 30210, RefRangeEnd = 30212, XrefRangeStart = 30201, XrefRangeEnd = 30210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateAndSetAllCameraRatios()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceCameraRatio.NativeMethodInfoPtr_CalculateAndSetAllCameraRatios_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x00087930 File Offset: 0x00085B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30212, XrefRangeEnd = 30213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCameraAnchor(Camera _camera, Vector2 _anchor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _anchor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceCameraRatio.NativeMethodInfoPtr_SetCameraAnchor_Public_Void_Camera_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x00087980 File Offset: 0x00085B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30213, XrefRangeEnd = 30223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<CameraRatio> GetCameras()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceCameraRatio.NativeMethodInfoPtr_GetCameras_Public_Il2CppReferenceArray_1_CameraRatio_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CameraRatio>>(intPtr3) : null;
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x000879C0 File Offset: 0x00085BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30223, XrefRangeEnd = 30226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForceCameraRatio()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForceCameraRatio>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceCameraRatio.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x0000AFAC File Offset: 0x000091AC
		public ForceCameraRatio(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001E55 RID: 7765 RVA: 0x000879FC File Offset: 0x00085BFC
		// (set) Token: 0x06001E56 RID: 7766 RVA: 0x0000AFB5 File Offset: 0x000091B5
		public unsafe Vector2 ratio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceCameraRatio.NativeFieldInfoPtr_ratio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceCameraRatio.NativeFieldInfoPtr_ratio)) = value;
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001E57 RID: 7767 RVA: 0x00087A24 File Offset: 0x00085C24
		// (set) Token: 0x06001E58 RID: 7768 RVA: 0x0000AFD0 File Offset: 0x000091D0
		public unsafe bool forceRatioOnAwake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceCameraRatio.NativeFieldInfoPtr_forceRatioOnAwake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceCameraRatio.NativeFieldInfoPtr_forceRatioOnAwake)) = value;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001E59 RID: 7769 RVA: 0x00087A4C File Offset: 0x00085C4C
		// (set) Token: 0x06001E5A RID: 7770 RVA: 0x0000AFEB File Offset: 0x000091EB
		public unsafe bool listenForWindowChanges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceCameraRatio.NativeFieldInfoPtr_listenForWindowChanges);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceCameraRatio.NativeFieldInfoPtr_listenForWindowChanges)) = value;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001E5B RID: 7771 RVA: 0x00087A74 File Offset: 0x00085C74
		// (set) Token: 0x06001E5C RID: 7772 RVA: 0x0000B006 File Offset: 0x00009206
		public unsafe bool createCameraForLetterBoxRendering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceCameraRatio.NativeFieldInfoPtr_createCameraForLetterBoxRendering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceCameraRatio.NativeFieldInfoPtr_createCameraForLetterBoxRendering)) = value;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001E5D RID: 7773 RVA: 0x00087A9C File Offset: 0x00085C9C
		// (set) Token: 0x06001E5E RID: 7774 RVA: 0x0000B021 File Offset: 0x00009221
		public unsafe bool findCamerasAutomatically
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceCameraRatio.NativeFieldInfoPtr_findCamerasAutomatically);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceCameraRatio.NativeFieldInfoPtr_findCamerasAutomatically)) = value;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001E5F RID: 7775 RVA: 0x00087AC4 File Offset: 0x00085CC4
		// (set) Token: 0x06001E60 RID: 7776 RVA: 0x0000B03C File Offset: 0x0000923C
		public unsafe Color letterBoxCameraColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceCameraRatio.NativeFieldInfoPtr_letterBoxCameraColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceCameraRatio.NativeFieldInfoPtr_letterBoxCameraColor)) = value;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001E61 RID: 7777 RVA: 0x00087AEC File Offset: 0x00085CEC
		// (set) Token: 0x06001E62 RID: 7778 RVA: 0x0000B057 File Offset: 0x00009257
		public unsafe List<CameraRatio> cameras
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceCameraRatio.NativeFieldInfoPtr_cameras);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CameraRatio>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceCameraRatio.NativeFieldInfoPtr_cameras), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001E63 RID: 7779 RVA: 0x00087B1C File Offset: 0x00085D1C
		// (set) Token: 0x06001E64 RID: 7780 RVA: 0x0000B076 File Offset: 0x00009276
		public unsafe Camera letterBoxCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceCameraRatio.NativeFieldInfoPtr_letterBoxCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceCameraRatio.NativeFieldInfoPtr_letterBoxCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F3A RID: 7994
		private static readonly IntPtr NativeFieldInfoPtr_ratio;

		// Token: 0x04001F3B RID: 7995
		private static readonly IntPtr NativeFieldInfoPtr_forceRatioOnAwake;

		// Token: 0x04001F3C RID: 7996
		private static readonly IntPtr NativeFieldInfoPtr_listenForWindowChanges;

		// Token: 0x04001F3D RID: 7997
		private static readonly IntPtr NativeFieldInfoPtr_createCameraForLetterBoxRendering;

		// Token: 0x04001F3E RID: 7998
		private static readonly IntPtr NativeFieldInfoPtr_findCamerasAutomatically;

		// Token: 0x04001F3F RID: 7999
		private static readonly IntPtr NativeFieldInfoPtr_letterBoxCameraColor;

		// Token: 0x04001F40 RID: 8000
		private static readonly IntPtr NativeFieldInfoPtr_cameras;

		// Token: 0x04001F41 RID: 8001
		private static readonly IntPtr NativeFieldInfoPtr_letterBoxCamera;

		// Token: 0x04001F42 RID: 8002
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001F43 RID: 8003
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001F44 RID: 8004
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraRatioByCamera_Private_CameraRatio_Camera_0;

		// Token: 0x04001F45 RID: 8005
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCameraArray_Private_Void_0;

		// Token: 0x04001F46 RID: 8006
		private static readonly IntPtr NativeMethodInfoPtr_FindAllCamerasInScene_Public_Void_0;

		// Token: 0x04001F47 RID: 8007
		private static readonly IntPtr NativeMethodInfoPtr_CalculateAndSetAllCameraRatios_Public_Void_0;

		// Token: 0x04001F48 RID: 8008
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraAnchor_Public_Void_Camera_Vector2_0;

		// Token: 0x04001F49 RID: 8009
		private static readonly IntPtr NativeMethodInfoPtr_GetCameras_Public_Il2CppReferenceArray_1_CameraRatio_0;

		// Token: 0x04001F4A RID: 8010
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
