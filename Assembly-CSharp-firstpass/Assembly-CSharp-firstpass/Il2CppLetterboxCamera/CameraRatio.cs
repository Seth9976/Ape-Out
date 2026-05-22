using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppLetterboxCamera
{
	// Token: 0x02000215 RID: 533
	[Serializable]
	public class CameraRatio : global::Il2CppSystem.Object
	{
		// Token: 0x06001E3C RID: 7740 RVA: 0x000873B4 File Offset: 0x000855B4
		// Note: this type is marked as 'beforefieldinit'.
		static CameraRatio()
		{
			Il2CppClassPointerStore<CameraRatio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "LetterboxCamera", "CameraRatio");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraRatio>.NativeClassPtr);
			CameraRatio.NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRatio>.NativeClassPtr, "camera");
			CameraRatio.NativeFieldInfoPtr_anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRatio>.NativeClassPtr, "anchor");
			CameraRatio.NativeFieldInfoPtr_vectorAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRatio>.NativeClassPtr, "vectorAnchor");
			CameraRatio.NativeFieldInfoPtr_originViewPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRatio>.NativeClassPtr, "originViewPort");
			CameraRatio.NativeMethodInfoPtr__ctor_Public_Void_Camera_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRatio>.NativeClassPtr, 100668182);
			CameraRatio.NativeMethodInfoPtr_ResetOriginViewport_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRatio>.NativeClassPtr, 100668183);
			CameraRatio.NativeMethodInfoPtr_SetAnchorBasedOnEnum_Public_Void_CameraAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRatio>.NativeClassPtr, 100668184);
			CameraRatio.NativeMethodInfoPtr_CalculateAndSetCameraRatio_Public_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRatio>.NativeClassPtr, 100668185);
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x00087484 File Offset: 0x00085684
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30027, RefRangeEnd = 30028, XrefRangeStart = 30025, XrefRangeEnd = 30027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraRatio(Camera _camera, Vector2 _anchor)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraRatio>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _anchor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRatio.NativeMethodInfoPtr__ctor_Public_Void_Camera_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x000874E0 File Offset: 0x000856E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30028, XrefRangeEnd = 30034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetOriginViewport()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRatio.NativeMethodInfoPtr_ResetOriginViewport_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x00087514 File Offset: 0x00085714
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 30034, RefRangeEnd = 30037, XrefRangeStart = 30034, XrefRangeEnd = 30034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnchorBasedOnEnum(CameraRatio.CameraAnchor _anchor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _anchor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRatio.NativeMethodInfoPtr_SetAnchorBasedOnEnum_Public_Void_CameraAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x00087554 File Offset: 0x00085754
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30042, RefRangeEnd = 30043, XrefRangeStart = 30037, XrefRangeEnd = 30042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateAndSetCameraRatio(float _width, float _height, bool _horizontalLetterbox)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _horizontalLetterbox;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRatio.NativeMethodInfoPtr_CalculateAndSetCameraRatio_Public_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x0000AF33 File Offset: 0x00009133
		public CameraRatio(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x000875B0 File Offset: 0x000857B0
		// (set) Token: 0x06001E43 RID: 7747 RVA: 0x0000AF3C File Offset: 0x0000913C
		public unsafe Camera camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRatio.NativeFieldInfoPtr_camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRatio.NativeFieldInfoPtr_camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001E44 RID: 7748 RVA: 0x000875E0 File Offset: 0x000857E0
		// (set) Token: 0x06001E45 RID: 7749 RVA: 0x0000AF5B File Offset: 0x0000915B
		public unsafe CameraRatio.CameraAnchor anchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRatio.NativeFieldInfoPtr_anchor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRatio.NativeFieldInfoPtr_anchor)) = value;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x00087608 File Offset: 0x00085808
		// (set) Token: 0x06001E47 RID: 7751 RVA: 0x0000AF76 File Offset: 0x00009176
		public unsafe Vector2 vectorAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRatio.NativeFieldInfoPtr_vectorAnchor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRatio.NativeFieldInfoPtr_vectorAnchor)) = value;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001E48 RID: 7752 RVA: 0x00087630 File Offset: 0x00085830
		// (set) Token: 0x06001E49 RID: 7753 RVA: 0x0000AF91 File Offset: 0x00009191
		public unsafe Rect originViewPort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRatio.NativeFieldInfoPtr_originViewPort);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRatio.NativeFieldInfoPtr_originViewPort)) = value;
			}
		}

		// Token: 0x04001F32 RID: 7986
		private static readonly IntPtr NativeFieldInfoPtr_camera;

		// Token: 0x04001F33 RID: 7987
		private static readonly IntPtr NativeFieldInfoPtr_anchor;

		// Token: 0x04001F34 RID: 7988
		private static readonly IntPtr NativeFieldInfoPtr_vectorAnchor;

		// Token: 0x04001F35 RID: 7989
		private static readonly IntPtr NativeFieldInfoPtr_originViewPort;

		// Token: 0x04001F36 RID: 7990
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Camera_Vector2_0;

		// Token: 0x04001F37 RID: 7991
		private static readonly IntPtr NativeMethodInfoPtr_ResetOriginViewport_Public_Void_0;

		// Token: 0x04001F38 RID: 7992
		private static readonly IntPtr NativeMethodInfoPtr_SetAnchorBasedOnEnum_Public_Void_CameraAnchor_0;

		// Token: 0x04001F39 RID: 7993
		private static readonly IntPtr NativeMethodInfoPtr_CalculateAndSetCameraRatio_Public_Void_Single_Single_Boolean_0;

		// Token: 0x020002CA RID: 714
		[OriginalName("Assembly-CSharp-firstpass.dll", "", "CameraAnchor")]
		public enum CameraAnchor
		{
			// Token: 0x0400230C RID: 8972
			Center,
			// Token: 0x0400230D RID: 8973
			Top,
			// Token: 0x0400230E RID: 8974
			Bottom,
			// Token: 0x0400230F RID: 8975
			Left,
			// Token: 0x04002310 RID: 8976
			Right,
			// Token: 0x04002311 RID: 8977
			TopLeft,
			// Token: 0x04002312 RID: 8978
			TopRight,
			// Token: 0x04002313 RID: 8979
			BottomLeft,
			// Token: 0x04002314 RID: 8980
			BottomRight
		}
	}
}
