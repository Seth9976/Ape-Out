using System;
using Il2CppDG.Tweening.Core;
using Il2CppDG.Tweening.Plugins.Core.PathCore;
using Il2CppDG.Tweening.Plugins.Options;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppDG.Tweening
{
	// Token: 0x020001EE RID: 494
	public static class DOTweenModulePhysics : global::Il2CppSystem.Object
	{
		// Token: 0x06001940 RID: 6464 RVA: 0x00071A2C File Offset: 0x0006FC2C
		// Note: this type is marked as 'beforefieldinit'.
		static DOTweenModulePhysics()
		{
			Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "DG.Tweening", "DOTweenModulePhysics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr);
			DOTweenModulePhysics.NativeMethodInfoPtr_DOMove_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Rigidbody_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr, 100667058);
			DOTweenModulePhysics.NativeMethodInfoPtr_DOMoveX_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Rigidbody_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr, 100667059);
			DOTweenModulePhysics.NativeMethodInfoPtr_DOMoveY_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Rigidbody_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr, 100667060);
			DOTweenModulePhysics.NativeMethodInfoPtr_DOMoveZ_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Rigidbody_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr, 100667061);
			DOTweenModulePhysics.NativeMethodInfoPtr_DORotate_Public_Static_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_Rigidbody_Vector3_Single_RotateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr, 100667062);
			DOTweenModulePhysics.NativeMethodInfoPtr_DOLookAt_Public_Static_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_Rigidbody_Vector3_Single_AxisConstraint_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr, 100667063);
			DOTweenModulePhysics.NativeMethodInfoPtr_DOJump_Public_Static_Sequence_Rigidbody_Vector3_Single_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr, 100667064);
			DOTweenModulePhysics.NativeMethodInfoPtr_DOPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr, 100667065);
			DOTweenModulePhysics.NativeMethodInfoPtr_DOLocalPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr, 100667066);
			DOTweenModulePhysics.NativeMethodInfoPtr_DOPath_Internal_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Path_Single_PathMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr, 100667067);
			DOTweenModulePhysics.NativeMethodInfoPtr_DOLocalPath_Internal_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Path_Single_PathMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr, 100667068);
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x00071B38 File Offset: 0x0006FD38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20881, XrefRangeEnd = 20907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.NativeMethodInfoPtr_DOMove_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Rigidbody_Vector3_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x00071BA8 File Offset: 0x0006FDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20907, XrefRangeEnd = 20933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.NativeMethodInfoPtr_DOMoveX_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Rigidbody_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x00071C18 File Offset: 0x0006FE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20933, XrefRangeEnd = 20959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.NativeMethodInfoPtr_DOMoveY_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Rigidbody_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x00071C88 File Offset: 0x0006FE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20959, XrefRangeEnd = 20985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.NativeMethodInfoPtr_DOMoveZ_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Rigidbody_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x00071CF8 File Offset: 0x0006FEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20985, XrefRangeEnd = 21006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.NativeMethodInfoPtr_DORotate_Public_Static_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_Rigidbody_Vector3_Single_RotateMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Quaternion, Vector3, QuaternionOptions>>(intPtr3) : null;
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x00071D68 File Offset: 0x0006FF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21006, XrefRangeEnd = 21033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, Nullable<Vector3> up = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref towards;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisConstraint;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(up));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.NativeMethodInfoPtr_DOLookAt_Public_Static_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_Rigidbody_Vector3_Single_AxisConstraint_Nullable_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Quaternion, Vector3, QuaternionOptions>>(intPtr3) : null;
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00071DF0 File Offset: 0x0006FFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21033, XrefRangeEnd = 21113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jumpPower;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numJumps;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.NativeMethodInfoPtr_DOJump_Public_Static_Sequence_Rigidbody_Vector3_Single_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00071E7C File Offset: 0x0007007C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21113, XrefRangeEnd = 21144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Il2CppStructArray<Vector3> path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Nullable<Color> gizmoColor = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resolution;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(gizmoColor));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.NativeMethodInfoPtr_DOPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00071F24 File Offset: 0x00070124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21144, XrefRangeEnd = 21177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Il2CppStructArray<Vector3> path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Nullable<Color> gizmoColor = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resolution;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(gizmoColor));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.NativeMethodInfoPtr_DOLocalPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00071FCC File Offset: 0x000701CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21177, XrefRangeEnd = 21202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.NativeMethodInfoPtr_DOPath_Internal_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Path_Single_PathMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00072040 File Offset: 0x00070240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21229, RefRangeEnd = 21230, XrefRangeStart = 21202, XrefRangeEnd = 21229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.NativeMethodInfoPtr_DOLocalPath_Internal_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Path_Single_PathMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x00009EF5 File Offset: 0x000080F5
		public DOTweenModulePhysics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A35 RID: 6709
		private static readonly IntPtr NativeMethodInfoPtr_DOMove_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Rigidbody_Vector3_Single_Boolean_0;

		// Token: 0x04001A36 RID: 6710
		private static readonly IntPtr NativeMethodInfoPtr_DOMoveX_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Rigidbody_Single_Single_Boolean_0;

		// Token: 0x04001A37 RID: 6711
		private static readonly IntPtr NativeMethodInfoPtr_DOMoveY_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Rigidbody_Single_Single_Boolean_0;

		// Token: 0x04001A38 RID: 6712
		private static readonly IntPtr NativeMethodInfoPtr_DOMoveZ_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_Rigidbody_Single_Single_Boolean_0;

		// Token: 0x04001A39 RID: 6713
		private static readonly IntPtr NativeMethodInfoPtr_DORotate_Public_Static_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_Rigidbody_Vector3_Single_RotateMode_0;

		// Token: 0x04001A3A RID: 6714
		private static readonly IntPtr NativeMethodInfoPtr_DOLookAt_Public_Static_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_Rigidbody_Vector3_Single_AxisConstraint_Nullable_1_Vector3_0;

		// Token: 0x04001A3B RID: 6715
		private static readonly IntPtr NativeMethodInfoPtr_DOJump_Public_Static_Sequence_Rigidbody_Vector3_Single_Int32_Single_Boolean_0;

		// Token: 0x04001A3C RID: 6716
		private static readonly IntPtr NativeMethodInfoPtr_DOPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0;

		// Token: 0x04001A3D RID: 6717
		private static readonly IntPtr NativeMethodInfoPtr_DOLocalPath_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Il2CppStructArray_1_Vector3_Single_PathType_PathMode_Int32_Nullable_1_Color_0;

		// Token: 0x04001A3E RID: 6718
		private static readonly IntPtr NativeMethodInfoPtr_DOPath_Internal_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Path_Single_PathMode_0;

		// Token: 0x04001A3F RID: 6719
		private static readonly IntPtr NativeMethodInfoPtr_DOLocalPath_Internal_Static_TweenerCore_3_Vector3_Path_PathOptions_Rigidbody_Path_Single_PathMode_0;

		// Token: 0x02000274 RID: 628
		[ObfuscatedName("DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002234 RID: 8756 RVA: 0x000945C8 File Offset: 0x000927C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass0_0>.NativeClassPtr);
				DOTweenModulePhysics.__c__DisplayClass0_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass0_0>.NativeClassPtr, "target");
				DOTweenModulePhysics.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass0_0>.NativeClassPtr, 100667069);
				DOTweenModulePhysics.__c__DisplayClass0_0.NativeMethodInfoPtr__DOMove_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass0_0>.NativeClassPtr, 100667070);
			}

			// Token: 0x06002235 RID: 8757 RVA: 0x00094630 File Offset: 0x00092830
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002236 RID: 8758 RVA: 0x0009466C File Offset: 0x0009286C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20825, XrefRangeEnd = 20827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOMove_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass0_0.NativeMethodInfoPtr__DOMove_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002237 RID: 8759 RVA: 0x0000CC0B File Offset: 0x0000AE0B
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F4 RID: 1780
			// (get) Token: 0x06002238 RID: 8760 RVA: 0x000946A8 File Offset: 0x000928A8
			// (set) Token: 0x06002239 RID: 8761 RVA: 0x0000CC14 File Offset: 0x0000AE14
			public unsafe Rigidbody target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass0_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass0_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002167 RID: 8551
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04002168 RID: 8552
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002169 RID: 8553
			private static readonly IntPtr NativeMethodInfoPtr__DOMove_b__0_Internal_Vector3_0;
		}

		// Token: 0x02000275 RID: 629
		[ObfuscatedName("DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600223A RID: 8762 RVA: 0x000946D8 File Offset: 0x000928D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass1_0>.NativeClassPtr);
				DOTweenModulePhysics.__c__DisplayClass1_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass1_0>.NativeClassPtr, "target");
				DOTweenModulePhysics.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass1_0>.NativeClassPtr, 100667071);
				DOTweenModulePhysics.__c__DisplayClass1_0.NativeMethodInfoPtr__DOMoveX_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass1_0>.NativeClassPtr, 100667072);
			}

			// Token: 0x0600223B RID: 8763 RVA: 0x00094740 File Offset: 0x00092940
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600223C RID: 8764 RVA: 0x0009477C File Offset: 0x0009297C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOMoveX_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass1_0.NativeMethodInfoPtr__DOMoveX_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600223D RID: 8765 RVA: 0x0000CC33 File Offset: 0x0000AE33
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F5 RID: 1781
			// (get) Token: 0x0600223E RID: 8766 RVA: 0x000947B8 File Offset: 0x000929B8
			// (set) Token: 0x0600223F RID: 8767 RVA: 0x0000CC3C File Offset: 0x0000AE3C
			public unsafe Rigidbody target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass1_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass1_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400216A RID: 8554
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400216B RID: 8555
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400216C RID: 8556
			private static readonly IntPtr NativeMethodInfoPtr__DOMoveX_b__0_Internal_Vector3_0;
		}

		// Token: 0x02000276 RID: 630
		[ObfuscatedName("DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002240 RID: 8768 RVA: 0x000947E8 File Offset: 0x000929E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass2_0>.NativeClassPtr);
				DOTweenModulePhysics.__c__DisplayClass2_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass2_0>.NativeClassPtr, "target");
				DOTweenModulePhysics.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass2_0>.NativeClassPtr, 100667073);
				DOTweenModulePhysics.__c__DisplayClass2_0.NativeMethodInfoPtr__DOMoveY_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass2_0>.NativeClassPtr, 100667074);
			}

			// Token: 0x06002241 RID: 8769 RVA: 0x00094850 File Offset: 0x00092A50
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002242 RID: 8770 RVA: 0x0009488C File Offset: 0x00092A8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOMoveY_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass2_0.NativeMethodInfoPtr__DOMoveY_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002243 RID: 8771 RVA: 0x0000CC5B File Offset: 0x0000AE5B
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F6 RID: 1782
			// (get) Token: 0x06002244 RID: 8772 RVA: 0x000948C8 File Offset: 0x00092AC8
			// (set) Token: 0x06002245 RID: 8773 RVA: 0x0000CC64 File Offset: 0x0000AE64
			public unsafe Rigidbody target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass2_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass2_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400216D RID: 8557
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400216E RID: 8558
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400216F RID: 8559
			private static readonly IntPtr NativeMethodInfoPtr__DOMoveY_b__0_Internal_Vector3_0;
		}

		// Token: 0x02000277 RID: 631
		[ObfuscatedName("DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002246 RID: 8774 RVA: 0x000948F8 File Offset: 0x00092AF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass3_0>.NativeClassPtr);
				DOTweenModulePhysics.__c__DisplayClass3_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass3_0>.NativeClassPtr, "target");
				DOTweenModulePhysics.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass3_0>.NativeClassPtr, 100667075);
				DOTweenModulePhysics.__c__DisplayClass3_0.NativeMethodInfoPtr__DOMoveZ_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass3_0>.NativeClassPtr, 100667076);
			}

			// Token: 0x06002247 RID: 8775 RVA: 0x00094960 File Offset: 0x00092B60
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002248 RID: 8776 RVA: 0x0009499C File Offset: 0x00092B9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOMoveZ_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass3_0.NativeMethodInfoPtr__DOMoveZ_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002249 RID: 8777 RVA: 0x0000CC83 File Offset: 0x0000AE83
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F7 RID: 1783
			// (get) Token: 0x0600224A RID: 8778 RVA: 0x000949D8 File Offset: 0x00092BD8
			// (set) Token: 0x0600224B RID: 8779 RVA: 0x0000CC8C File Offset: 0x0000AE8C
			public unsafe Rigidbody target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass3_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass3_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002170 RID: 8560
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04002171 RID: 8561
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002172 RID: 8562
			private static readonly IntPtr NativeMethodInfoPtr__DOMoveZ_b__0_Internal_Vector3_0;
		}

		// Token: 0x02000278 RID: 632
		[ObfuscatedName("DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600224C RID: 8780 RVA: 0x00094A08 File Offset: 0x00092C08
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass4_0>.NativeClassPtr);
				DOTweenModulePhysics.__c__DisplayClass4_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass4_0>.NativeClassPtr, "target");
				DOTweenModulePhysics.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass4_0>.NativeClassPtr, 100667077);
				DOTweenModulePhysics.__c__DisplayClass4_0.NativeMethodInfoPtr__DORotate_b__0_Internal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass4_0>.NativeClassPtr, 100667078);
			}

			// Token: 0x0600224D RID: 8781 RVA: 0x00094A70 File Offset: 0x00092C70
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600224E RID: 8782 RVA: 0x00094AAC File Offset: 0x00092CAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20827, XrefRangeEnd = 20829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Quaternion _DORotate_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass4_0.NativeMethodInfoPtr__DORotate_b__0_Internal_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600224F RID: 8783 RVA: 0x0000CCAB File Offset: 0x0000AEAB
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F8 RID: 1784
			// (get) Token: 0x06002250 RID: 8784 RVA: 0x00094AE8 File Offset: 0x00092CE8
			// (set) Token: 0x06002251 RID: 8785 RVA: 0x0000CCB4 File Offset: 0x0000AEB4
			public unsafe Rigidbody target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass4_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass4_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002173 RID: 8563
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04002174 RID: 8564
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002175 RID: 8565
			private static readonly IntPtr NativeMethodInfoPtr__DORotate_b__0_Internal_Quaternion_0;
		}

		// Token: 0x02000279 RID: 633
		[ObfuscatedName("DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002252 RID: 8786 RVA: 0x00094B18 File Offset: 0x00092D18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass5_0>.NativeClassPtr);
				DOTweenModulePhysics.__c__DisplayClass5_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass5_0>.NativeClassPtr, "target");
				DOTweenModulePhysics.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass5_0>.NativeClassPtr, 100667079);
				DOTweenModulePhysics.__c__DisplayClass5_0.NativeMethodInfoPtr__DOLookAt_b__0_Internal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass5_0>.NativeClassPtr, 100667080);
			}

			// Token: 0x06002253 RID: 8787 RVA: 0x00094B80 File Offset: 0x00092D80
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002254 RID: 8788 RVA: 0x00094BBC File Offset: 0x00092DBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Quaternion _DOLookAt_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass5_0.NativeMethodInfoPtr__DOLookAt_b__0_Internal_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002255 RID: 8789 RVA: 0x0000CCD3 File Offset: 0x0000AED3
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F9 RID: 1785
			// (get) Token: 0x06002256 RID: 8790 RVA: 0x00094BF8 File Offset: 0x00092DF8
			// (set) Token: 0x06002257 RID: 8791 RVA: 0x0000CCDC File Offset: 0x0000AEDC
			public unsafe Rigidbody target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass5_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass5_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002176 RID: 8566
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04002177 RID: 8567
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002178 RID: 8568
			private static readonly IntPtr NativeMethodInfoPtr__DOLookAt_b__0_Internal_Quaternion_0;
		}

		// Token: 0x0200027A RID: 634
		[ObfuscatedName("DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002258 RID: 8792 RVA: 0x00094C28 File Offset: 0x00092E28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass6_0>.NativeClassPtr);
				DOTweenModulePhysics.__c__DisplayClass6_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass6_0>.NativeClassPtr, "target");
				DOTweenModulePhysics.__c__DisplayClass6_0.NativeFieldInfoPtr_startPosY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass6_0>.NativeClassPtr, "startPosY");
				DOTweenModulePhysics.__c__DisplayClass6_0.NativeFieldInfoPtr_offsetYSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass6_0>.NativeClassPtr, "offsetYSet");
				DOTweenModulePhysics.__c__DisplayClass6_0.NativeFieldInfoPtr_offsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass6_0>.NativeClassPtr, "offsetY");
				DOTweenModulePhysics.__c__DisplayClass6_0.NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass6_0>.NativeClassPtr, "s");
				DOTweenModulePhysics.__c__DisplayClass6_0.NativeFieldInfoPtr_endValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass6_0>.NativeClassPtr, "endValue");
				DOTweenModulePhysics.__c__DisplayClass6_0.NativeFieldInfoPtr_yTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass6_0>.NativeClassPtr, "yTween");
				DOTweenModulePhysics.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass6_0>.NativeClassPtr, 100667081);
				DOTweenModulePhysics.__c__DisplayClass6_0.NativeMethodInfoPtr__DOJump_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass6_0>.NativeClassPtr, 100667082);
				DOTweenModulePhysics.__c__DisplayClass6_0.NativeMethodInfoPtr__DOJump_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass6_0>.NativeClassPtr, 100667083);
				DOTweenModulePhysics.__c__DisplayClass6_0.NativeMethodInfoPtr__DOJump_b__2_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass6_0>.NativeClassPtr, 100667084);
				DOTweenModulePhysics.__c__DisplayClass6_0.NativeMethodInfoPtr__DOJump_b__3_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass6_0>.NativeClassPtr, 100667085);
				DOTweenModulePhysics.__c__DisplayClass6_0.NativeMethodInfoPtr__DOJump_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass6_0>.NativeClassPtr, 100667086);
			}

			// Token: 0x06002259 RID: 8793 RVA: 0x00094D58 File Offset: 0x00092F58
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600225A RID: 8794 RVA: 0x00094D94 File Offset: 0x00092F94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOJump_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass6_0.NativeMethodInfoPtr__DOJump_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600225B RID: 8795 RVA: 0x00094DD0 File Offset: 0x00092FD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20829, XrefRangeEnd = 20831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOJump_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass6_0.NativeMethodInfoPtr__DOJump_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600225C RID: 8796 RVA: 0x00094E04 File Offset: 0x00093004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOJump_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass6_0.NativeMethodInfoPtr__DOJump_b__2_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600225D RID: 8797 RVA: 0x00094E40 File Offset: 0x00093040
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOJump_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass6_0.NativeMethodInfoPtr__DOJump_b__3_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600225E RID: 8798 RVA: 0x00094E7C File Offset: 0x0009307C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20831, XrefRangeEnd = 20837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOJump_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass6_0.NativeMethodInfoPtr__DOJump_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600225F RID: 8799 RVA: 0x0000CCFB File Offset: 0x0000AEFB
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006FA RID: 1786
			// (get) Token: 0x06002260 RID: 8800 RVA: 0x00094EB0 File Offset: 0x000930B0
			// (set) Token: 0x06002261 RID: 8801 RVA: 0x0000CD04 File Offset: 0x0000AF04
			public unsafe Rigidbody target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass6_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass6_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006FB RID: 1787
			// (get) Token: 0x06002262 RID: 8802 RVA: 0x00094EE0 File Offset: 0x000930E0
			// (set) Token: 0x06002263 RID: 8803 RVA: 0x0000CD23 File Offset: 0x0000AF23
			public unsafe float startPosY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass6_0.NativeFieldInfoPtr_startPosY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass6_0.NativeFieldInfoPtr_startPosY)) = value;
				}
			}

			// Token: 0x170006FC RID: 1788
			// (get) Token: 0x06002264 RID: 8804 RVA: 0x00094F08 File Offset: 0x00093108
			// (set) Token: 0x06002265 RID: 8805 RVA: 0x0000CD3E File Offset: 0x0000AF3E
			public unsafe bool offsetYSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass6_0.NativeFieldInfoPtr_offsetYSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass6_0.NativeFieldInfoPtr_offsetYSet)) = value;
				}
			}

			// Token: 0x170006FD RID: 1789
			// (get) Token: 0x06002266 RID: 8806 RVA: 0x00094F30 File Offset: 0x00093130
			// (set) Token: 0x06002267 RID: 8807 RVA: 0x0000CD59 File Offset: 0x0000AF59
			public unsafe float offsetY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass6_0.NativeFieldInfoPtr_offsetY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass6_0.NativeFieldInfoPtr_offsetY)) = value;
				}
			}

			// Token: 0x170006FE RID: 1790
			// (get) Token: 0x06002268 RID: 8808 RVA: 0x00094F58 File Offset: 0x00093158
			// (set) Token: 0x06002269 RID: 8809 RVA: 0x0000CD74 File Offset: 0x0000AF74
			public unsafe Sequence s
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass6_0.NativeFieldInfoPtr_s);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass6_0.NativeFieldInfoPtr_s), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006FF RID: 1791
			// (get) Token: 0x0600226A RID: 8810 RVA: 0x00094F88 File Offset: 0x00093188
			// (set) Token: 0x0600226B RID: 8811 RVA: 0x0000CD93 File Offset: 0x0000AF93
			public unsafe Vector3 endValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass6_0.NativeFieldInfoPtr_endValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass6_0.NativeFieldInfoPtr_endValue)) = value;
				}
			}

			// Token: 0x17000700 RID: 1792
			// (get) Token: 0x0600226C RID: 8812 RVA: 0x00094FB0 File Offset: 0x000931B0
			// (set) Token: 0x0600226D RID: 8813 RVA: 0x0000CDAE File Offset: 0x0000AFAE
			public unsafe Tween yTween
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass6_0.NativeFieldInfoPtr_yTween);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass6_0.NativeFieldInfoPtr_yTween), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002179 RID: 8569
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400217A RID: 8570
			private static readonly IntPtr NativeFieldInfoPtr_startPosY;

			// Token: 0x0400217B RID: 8571
			private static readonly IntPtr NativeFieldInfoPtr_offsetYSet;

			// Token: 0x0400217C RID: 8572
			private static readonly IntPtr NativeFieldInfoPtr_offsetY;

			// Token: 0x0400217D RID: 8573
			private static readonly IntPtr NativeFieldInfoPtr_s;

			// Token: 0x0400217E RID: 8574
			private static readonly IntPtr NativeFieldInfoPtr_endValue;

			// Token: 0x0400217F RID: 8575
			private static readonly IntPtr NativeFieldInfoPtr_yTween;

			// Token: 0x04002180 RID: 8576
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002181 RID: 8577
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__0_Internal_Vector3_0;

			// Token: 0x04002182 RID: 8578
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__1_Internal_Void_0;

			// Token: 0x04002183 RID: 8579
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__2_Internal_Vector3_0;

			// Token: 0x04002184 RID: 8580
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__3_Internal_Vector3_0;

			// Token: 0x04002185 RID: 8581
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__4_Internal_Void_0;
		}

		// Token: 0x0200027B RID: 635
		[ObfuscatedName("DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600226E RID: 8814 RVA: 0x00094FE0 File Offset: 0x000931E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass7_0>.NativeClassPtr);
				DOTweenModulePhysics.__c__DisplayClass7_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass7_0>.NativeClassPtr, "target");
				DOTweenModulePhysics.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass7_0>.NativeClassPtr, 100667087);
				DOTweenModulePhysics.__c__DisplayClass7_0.NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass7_0>.NativeClassPtr, 100667088);
			}

			// Token: 0x0600226F RID: 8815 RVA: 0x00095048 File Offset: 0x00093248
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002270 RID: 8816 RVA: 0x00095084 File Offset: 0x00093284
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOPath_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass7_0.NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002271 RID: 8817 RVA: 0x0000CDCD File Offset: 0x0000AFCD
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000701 RID: 1793
			// (get) Token: 0x06002272 RID: 8818 RVA: 0x000950C0 File Offset: 0x000932C0
			// (set) Token: 0x06002273 RID: 8819 RVA: 0x0000CDD6 File Offset: 0x0000AFD6
			public unsafe Rigidbody target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass7_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass7_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002186 RID: 8582
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04002187 RID: 8583
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002188 RID: 8584
			private static readonly IntPtr NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0;
		}

		// Token: 0x0200027C RID: 636
		[ObfuscatedName("DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002274 RID: 8820 RVA: 0x000950F0 File Offset: 0x000932F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass8_0>.NativeClassPtr);
				DOTweenModulePhysics.__c__DisplayClass8_0.NativeFieldInfoPtr_trans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass8_0>.NativeClassPtr, "trans");
				DOTweenModulePhysics.__c__DisplayClass8_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass8_0>.NativeClassPtr, "target");
				DOTweenModulePhysics.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass8_0>.NativeClassPtr, 100667089);
				DOTweenModulePhysics.__c__DisplayClass8_0.NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass8_0>.NativeClassPtr, 100667090);
				DOTweenModulePhysics.__c__DisplayClass8_0.NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass8_0>.NativeClassPtr, 100667091);
			}

			// Token: 0x06002275 RID: 8821 RVA: 0x00095180 File Offset: 0x00093380
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002276 RID: 8822 RVA: 0x000951BC File Offset: 0x000933BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20837, XrefRangeEnd = 20839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOLocalPath_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass8_0.NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002277 RID: 8823 RVA: 0x000951F8 File Offset: 0x000933F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20839, XrefRangeEnd = 20860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalPath_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass8_0.NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002278 RID: 8824 RVA: 0x0000CDF5 File Offset: 0x0000AFF5
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000702 RID: 1794
			// (get) Token: 0x06002279 RID: 8825 RVA: 0x00095238 File Offset: 0x00093438
			// (set) Token: 0x0600227A RID: 8826 RVA: 0x0000CDFE File Offset: 0x0000AFFE
			public unsafe Transform trans
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass8_0.NativeFieldInfoPtr_trans);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass8_0.NativeFieldInfoPtr_trans), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000703 RID: 1795
			// (get) Token: 0x0600227B RID: 8827 RVA: 0x00095268 File Offset: 0x00093468
			// (set) Token: 0x0600227C RID: 8828 RVA: 0x0000CE1D File Offset: 0x0000B01D
			public unsafe Rigidbody target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass8_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass8_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002189 RID: 8585
			private static readonly IntPtr NativeFieldInfoPtr_trans;

			// Token: 0x0400218A RID: 8586
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400218B RID: 8587
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400218C RID: 8588
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0;

			// Token: 0x0400218D RID: 8589
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200027D RID: 637
		[ObfuscatedName("DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600227D RID: 8829 RVA: 0x00095298 File Offset: 0x00093498
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass9_0>.NativeClassPtr);
				DOTweenModulePhysics.__c__DisplayClass9_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass9_0>.NativeClassPtr, "target");
				DOTweenModulePhysics.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass9_0>.NativeClassPtr, 100667092);
				DOTweenModulePhysics.__c__DisplayClass9_0.NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass9_0>.NativeClassPtr, 100667093);
			}

			// Token: 0x0600227E RID: 8830 RVA: 0x00095300 File Offset: 0x00093500
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600227F RID: 8831 RVA: 0x0009533C File Offset: 0x0009353C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOPath_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass9_0.NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002280 RID: 8832 RVA: 0x0000CE3C File Offset: 0x0000B03C
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000704 RID: 1796
			// (get) Token: 0x06002281 RID: 8833 RVA: 0x00095378 File Offset: 0x00093578
			// (set) Token: 0x06002282 RID: 8834 RVA: 0x0000CE45 File Offset: 0x0000B045
			public unsafe Rigidbody target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass9_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass9_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400218E RID: 8590
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400218F RID: 8591
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002190 RID: 8592
			private static readonly IntPtr NativeMethodInfoPtr__DOPath_b__0_Internal_Vector3_0;
		}

		// Token: 0x0200027E RID: 638
		[ObfuscatedName("DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002283 RID: 8835 RVA: 0x000953A8 File Offset: 0x000935A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModulePhysics>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass10_0>.NativeClassPtr);
				DOTweenModulePhysics.__c__DisplayClass10_0.NativeFieldInfoPtr_trans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass10_0>.NativeClassPtr, "trans");
				DOTweenModulePhysics.__c__DisplayClass10_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass10_0>.NativeClassPtr, "target");
				DOTweenModulePhysics.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass10_0>.NativeClassPtr, 100667094);
				DOTweenModulePhysics.__c__DisplayClass10_0.NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass10_0>.NativeClassPtr, 100667095);
				DOTweenModulePhysics.__c__DisplayClass10_0.NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass10_0>.NativeClassPtr, 100667096);
			}

			// Token: 0x06002284 RID: 8836 RVA: 0x00095438 File Offset: 0x00093638
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModulePhysics.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002285 RID: 8837 RVA: 0x00095474 File Offset: 0x00093674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOLocalPath_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass10_0.NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002286 RID: 8838 RVA: 0x000954B0 File Offset: 0x000936B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20860, XrefRangeEnd = 20881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOLocalPath_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics.__c__DisplayClass10_0.NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002287 RID: 8839 RVA: 0x0000CE64 File Offset: 0x0000B064
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000705 RID: 1797
			// (get) Token: 0x06002288 RID: 8840 RVA: 0x000954F0 File Offset: 0x000936F0
			// (set) Token: 0x06002289 RID: 8841 RVA: 0x0000CE6D File Offset: 0x0000B06D
			public unsafe Transform trans
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass10_0.NativeFieldInfoPtr_trans);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass10_0.NativeFieldInfoPtr_trans), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000706 RID: 1798
			// (get) Token: 0x0600228A RID: 8842 RVA: 0x00095520 File Offset: 0x00093720
			// (set) Token: 0x0600228B RID: 8843 RVA: 0x0000CE8C File Offset: 0x0000B08C
			public unsafe Rigidbody target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass10_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics.__c__DisplayClass10_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002191 RID: 8593
			private static readonly IntPtr NativeFieldInfoPtr_trans;

			// Token: 0x04002192 RID: 8594
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04002193 RID: 8595
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002194 RID: 8596
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalPath_b__0_Internal_Vector3_0;

			// Token: 0x04002195 RID: 8597
			private static readonly IntPtr NativeMethodInfoPtr__DOLocalPath_b__1_Internal_Void_Vector3_0;
		}
	}
}
