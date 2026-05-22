using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace UnityEngine
{
	// Token: 0x02000105 RID: 261
	public class Transform : Component
	{
		// Token: 0x060015E7 RID: 5607 RVA: 0x00055AB0 File Offset: 0x00053CB0
		// Note: this type is marked as 'beforefieldinit'.
		static Transform()
		{
			Il2CppClassPointerStore<Transform>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Transform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Transform>.NativeClassPtr);
			Transform.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665208);
			Transform.NativeMethodInfoPtr_get_position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665209);
			Transform.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665210);
			Transform.NativeMethodInfoPtr_get_localPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665211);
			Transform.NativeMethodInfoPtr_set_localPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665212);
			Transform.NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665213);
			Transform.NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665214);
			Transform.NativeMethodInfoPtr_get_localEulerAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665215);
			Transform.NativeMethodInfoPtr_set_localEulerAngles_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665216);
			Transform.NativeMethodInfoPtr_get_right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665217);
			Transform.NativeMethodInfoPtr_get_up_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665218);
			Transform.NativeMethodInfoPtr_get_forward_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665219);
			Transform.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665220);
			Transform.NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665221);
			Transform.NativeMethodInfoPtr_get_localRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665222);
			Transform.NativeMethodInfoPtr_set_localRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665223);
			Transform.NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665224);
			Transform.NativeMethodInfoPtr_set_localScale_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665225);
			Transform.NativeMethodInfoPtr_get_parent_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665226);
			Transform.NativeMethodInfoPtr_set_parent_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665227);
			Transform.NativeMethodInfoPtr_get_parentInternal_Internal_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665228);
			Transform.NativeMethodInfoPtr_set_parentInternal_Internal_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665229);
			Transform.NativeMethodInfoPtr_GetParent_Private_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665230);
			Transform.NativeMethodInfoPtr_SetParent_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665231);
			Transform.NativeMethodInfoPtr_SetParent_Public_Void_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665232);
			Transform.NativeMethodInfoPtr_get_worldToLocalMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665233);
			Transform.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665234);
			Transform.NativeMethodInfoPtr_Translate_Public_Void_Vector3_Space_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665235);
			Transform.NativeMethodInfoPtr_Translate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665236);
			Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Space_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665237);
			Transform.NativeMethodInfoPtr_Rotate_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665238);
			Transform.NativeMethodInfoPtr_RotateAroundInternal_Internal_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665239);
			Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_Space_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665240);
			Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665241);
			Transform.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665242);
			Transform.NativeMethodInfoPtr_Internal_LookAt_Private_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665243);
			Transform.NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665244);
			Transform.NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665245);
			Transform.NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665246);
			Transform.NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665247);
			Transform.NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665248);
			Transform.NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665249);
			Transform.NativeMethodInfoPtr_get_root_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665250);
			Transform.NativeMethodInfoPtr_GetRoot_Private_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665251);
			Transform.NativeMethodInfoPtr_get_childCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665252);
			Transform.NativeMethodInfoPtr_SetAsFirstSibling_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665253);
			Transform.NativeMethodInfoPtr_SetAsLastSibling_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665254);
			Transform.NativeMethodInfoPtr_SetSiblingIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665255);
			Transform.NativeMethodInfoPtr_GetSiblingIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665256);
			Transform.NativeMethodInfoPtr_FindRelativeTransformWithPath_Private_Static_Transform_Transform_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665257);
			Transform.NativeMethodInfoPtr_Find_Public_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665258);
			Transform.NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665259);
			Transform.NativeMethodInfoPtr_IsChildOf_Public_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665260);
			Transform.NativeMethodInfoPtr_get_hasChanged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665261);
			Transform.NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665262);
			Transform.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665263);
			Transform.NativeMethodInfoPtr_GetChild_Public_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665264);
			Transform.NativeMethodInfoPtr_get_position_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665265);
			Transform.NativeMethodInfoPtr_set_position_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665266);
			Transform.NativeMethodInfoPtr_get_localPosition_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665267);
			Transform.NativeMethodInfoPtr_set_localPosition_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665268);
			Transform.NativeMethodInfoPtr_get_rotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665269);
			Transform.NativeMethodInfoPtr_set_rotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665270);
			Transform.NativeMethodInfoPtr_get_localRotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665271);
			Transform.NativeMethodInfoPtr_set_localRotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665272);
			Transform.NativeMethodInfoPtr_get_localScale_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665273);
			Transform.NativeMethodInfoPtr_set_localScale_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665274);
			Transform.NativeMethodInfoPtr_get_worldToLocalMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665275);
			Transform.NativeMethodInfoPtr_get_localToWorldMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665276);
			Transform.NativeMethodInfoPtr_RotateAroundInternal_Injected_Private_Void_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665277);
			Transform.NativeMethodInfoPtr_Internal_LookAt_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665278);
			Transform.NativeMethodInfoPtr_TransformDirection_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665279);
			Transform.NativeMethodInfoPtr_InverseTransformDirection_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665280);
			Transform.NativeMethodInfoPtr_TransformVector_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665281);
			Transform.NativeMethodInfoPtr_InverseTransformVector_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665282);
			Transform.NativeMethodInfoPtr_TransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665283);
			Transform.NativeMethodInfoPtr_InverseTransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665284);
			Transform.NativeMethodInfoPtr_get_lossyScale_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100665285);
			Transform.GetRotationOrderInternalDelegateField = IL2CPP.ResolveICall<Transform.GetRotationOrderInternalDelegate>("UnityEngine.Transform::GetRotationOrderInternal");
			Transform.SetRotationOrderInternalDelegateField = IL2CPP.ResolveICall<Transform.SetRotationOrderInternalDelegate>("UnityEngine.Transform::SetRotationOrderInternal");
			Transform.DetachChildrenDelegateField = IL2CPP.ResolveICall<Transform.DetachChildrenDelegate>("UnityEngine.Transform::DetachChildren");
			Transform.MoveAfterSiblingDelegateField = IL2CPP.ResolveICall<Transform.MoveAfterSiblingDelegate>("UnityEngine.Transform::MoveAfterSibling");
			Transform.SendTransformChangedScaleDelegateField = IL2CPP.ResolveICall<Transform.SendTransformChangedScaleDelegate>("UnityEngine.Transform::SendTransformChangedScale");
			Transform.GetChildCountDelegateField = IL2CPP.ResolveICall<Transform.GetChildCountDelegate>("UnityEngine.Transform::GetChildCount");
			Transform.internal_getHierarchyCapacityDelegateField = IL2CPP.ResolveICall<Transform.internal_getHierarchyCapacityDelegate>("UnityEngine.Transform::internal_getHierarchyCapacity");
			Transform.internal_setHierarchyCapacityDelegateField = IL2CPP.ResolveICall<Transform.internal_setHierarchyCapacityDelegate>("UnityEngine.Transform::internal_setHierarchyCapacity");
			Transform.internal_getHierarchyCountDelegateField = IL2CPP.ResolveICall<Transform.internal_getHierarchyCountDelegate>("UnityEngine.Transform::internal_getHierarchyCount");
			Transform.IsNonUniformScaleTransformDelegateField = IL2CPP.ResolveICall<Transform.IsNonUniformScaleTransformDelegate>("UnityEngine.Transform::IsNonUniformScaleTransform");
			Transform.GetLocalEulerAngles_InjectedDelegateField = IL2CPP.ResolveICall<Transform.GetLocalEulerAngles_InjectedDelegate>("UnityEngine.Transform::GetLocalEulerAngles_Injected");
			Transform.SetLocalEulerAngles_InjectedDelegateField = IL2CPP.ResolveICall<Transform.SetLocalEulerAngles_InjectedDelegate>("UnityEngine.Transform::SetLocalEulerAngles_Injected");
			Transform.SetLocalEulerHint_InjectedDelegateField = IL2CPP.ResolveICall<Transform.SetLocalEulerHint_InjectedDelegate>("UnityEngine.Transform::SetLocalEulerHint_Injected");
			Transform.SetPositionAndRotation_InjectedDelegateField = IL2CPP.ResolveICall<Transform.SetPositionAndRotation_InjectedDelegate>("UnityEngine.Transform::SetPositionAndRotation_Injected");
			Transform.RotateAround_InjectedDelegateField = IL2CPP.ResolveICall<Transform.RotateAround_InjectedDelegate>("UnityEngine.Transform::RotateAround_Injected");
			Transform.RotateAroundLocal_InjectedDelegateField = IL2CPP.ResolveICall<Transform.RotateAroundLocal_InjectedDelegate>("UnityEngine.Transform::RotateAroundLocal_Injected");
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x000561E8 File Offset: 0x000543E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Transform>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060015E9 RID: 5609 RVA: 0x00056224 File Offset: 0x00054424
		// (set) Token: 0x060015EA RID: 5610 RVA: 0x00056260 File Offset: 0x00054460
		public unsafe Vector3 position
		{
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 499366, RefRangeEnd = 499398, XrefRangeStart = 499364, XrefRangeEnd = 499366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 499400, RefRangeEnd = 499412, XrefRangeStart = 499398, XrefRangeEnd = 499400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060015EB RID: 5611 RVA: 0x000562A0 File Offset: 0x000544A0
		// (set) Token: 0x060015EC RID: 5612 RVA: 0x000562DC File Offset: 0x000544DC
		public unsafe Vector3 localPosition
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 499414, RefRangeEnd = 499418, XrefRangeStart = 499412, XrefRangeEnd = 499414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 499420, RefRangeEnd = 499423, XrefRangeStart = 499418, XrefRangeEnd = 499420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060015ED RID: 5613 RVA: 0x0005631C File Offset: 0x0005451C
		// (set) Token: 0x060015EE RID: 5614 RVA: 0x00056358 File Offset: 0x00054558
		public unsafe Vector3 eulerAngles
		{
			[CallerCount(49)]
			[CachedScanResults(RefRangeStart = 499426, RefRangeEnd = 499475, XrefRangeStart = 499423, XrefRangeEnd = 499426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(56)]
			[CachedScanResults(RefRangeStart = 499479, RefRangeEnd = 499535, XrefRangeStart = 499475, XrefRangeEnd = 499479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x00056398 File Offset: 0x00054598
		// (set) Token: 0x060015F0 RID: 5616 RVA: 0x000563D4 File Offset: 0x000545D4
		public unsafe Vector3 localEulerAngles
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 499538, RefRangeEnd = 499542, XrefRangeStart = 499535, XrefRangeEnd = 499538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localEulerAngles_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 499546, RefRangeEnd = 499566, XrefRangeStart = 499542, XrefRangeEnd = 499546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localEulerAngles_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x00056414 File Offset: 0x00054614
		// (set) Token: 0x0600163A RID: 5690 RVA: 0x0000BEA0 File Offset: 0x0000A0A0
		public unsafe Vector3 right
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 499571, RefRangeEnd = 499591, XrefRangeStart = 499566, XrefRangeEnd = 499571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_right_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.rotation = Quaternion.FromToRotation(Vector3.right, value);
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060015F2 RID: 5618 RVA: 0x00056450 File Offset: 0x00054650
		// (set) Token: 0x0600163B RID: 5691 RVA: 0x0000BEB5 File Offset: 0x0000A0B5
		public unsafe Vector3 up
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 499596, RefRangeEnd = 499608, XrefRangeStart = 499591, XrefRangeEnd = 499596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_up_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.rotation = Quaternion.FromToRotation(Vector3.up, value);
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060015F3 RID: 5619 RVA: 0x0005648C File Offset: 0x0005468C
		// (set) Token: 0x0600163C RID: 5692 RVA: 0x0000BECA File Offset: 0x0000A0CA
		public unsafe Vector3 forward
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 499613, RefRangeEnd = 499623, XrefRangeStart = 499608, XrefRangeEnd = 499613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_forward_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.rotation = Quaternion.LookRotation(value);
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060015F4 RID: 5620 RVA: 0x000564C8 File Offset: 0x000546C8
		// (set) Token: 0x060015F5 RID: 5621 RVA: 0x00056504 File Offset: 0x00054704
		public unsafe Quaternion rotation
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 499625, RefRangeEnd = 499627, XrefRangeStart = 499623, XrefRangeEnd = 499625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 499629, RefRangeEnd = 499631, XrefRangeStart = 499627, XrefRangeEnd = 499629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x00056544 File Offset: 0x00054744
		// (set) Token: 0x060015F7 RID: 5623 RVA: 0x00056580 File Offset: 0x00054780
		public unsafe Quaternion localRotation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499631, XrefRangeEnd = 499633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 499635, RefRangeEnd = 499636, XrefRangeStart = 499633, XrefRangeEnd = 499635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localRotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x000565C0 File Offset: 0x000547C0
		// (set) Token: 0x060015F9 RID: 5625 RVA: 0x000565FC File Offset: 0x000547FC
		public unsafe Vector3 localScale
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 499638, RefRangeEnd = 499639, XrefRangeStart = 499636, XrefRangeEnd = 499638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 499641, RefRangeEnd = 499644, XrefRangeStart = 499639, XrefRangeEnd = 499641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localScale_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x0005663C File Offset: 0x0005483C
		// (set) Token: 0x060015FB RID: 5627 RVA: 0x0005667C File Offset: 0x0005487C
		public unsafe Transform parent
		{
			[CallerCount(37)]
			[CachedScanResults(RefRangeStart = 499648, RefRangeEnd = 499685, XrefRangeStart = 499644, XrefRangeEnd = 499648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_parent_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
			[CallerCount(92)]
			[CachedScanResults(RefRangeStart = 499697, RefRangeEnd = 499789, XrefRangeStart = 499685, XrefRangeEnd = 499697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_parent_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060015FC RID: 5628 RVA: 0x000566C0 File Offset: 0x000548C0
		// (set) Token: 0x060015FD RID: 5629 RVA: 0x00056700 File Offset: 0x00054900
		public unsafe Transform parentInternal
		{
			[CallerCount(37)]
			[CachedScanResults(RefRangeStart = 499648, RefRangeEnd = 499685, XrefRangeStart = 499648, XrefRangeEnd = 499685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_parentInternal_Internal_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 499793, RefRangeEnd = 499797, XrefRangeStart = 499789, XrefRangeEnd = 499793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_parentInternal_Internal_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00056744 File Offset: 0x00054944
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 499648, RefRangeEnd = 499685, XrefRangeStart = 499648, XrefRangeEnd = 499685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetParent_Private_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00056784 File Offset: 0x00054984
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 499793, RefRangeEnd = 499797, XrefRangeStart = 499793, XrefRangeEnd = 499797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParent(Transform p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetParent_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x000567C8 File Offset: 0x000549C8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 499801, RefRangeEnd = 499809, XrefRangeStart = 499797, XrefRangeEnd = 499801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParent(Transform parent, bool worldPositionStays)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPositionStays;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetParent_Public_Void_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x00056818 File Offset: 0x00054A18
		public unsafe Matrix4x4 worldToLocalMatrix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499809, XrefRangeEnd = 499811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_worldToLocalMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001602 RID: 5634 RVA: 0x00056854 File Offset: 0x00054A54
		public unsafe Matrix4x4 localToWorldMatrix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499811, XrefRangeEnd = 499813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00056890 File Offset: 0x00054A90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 499823, RefRangeEnd = 499825, XrefRangeStart = 499813, XrefRangeEnd = 499823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Translate(Vector3 translation, Space relativeTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref translation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Translate_Public_Void_Vector3_Space_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x000568DC File Offset: 0x00054ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499825, XrefRangeEnd = 499826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Translate(Vector3 translation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref translation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Translate_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x0005691C File Offset: 0x00054B1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 499841, RefRangeEnd = 499843, XrefRangeStart = 499826, XrefRangeEnd = 499841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(Vector3 eulers, Space relativeTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eulers;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Space_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00056968 File Offset: 0x00054B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499843, XrefRangeEnd = 499844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(float xAngle, float yAngle, float zAngle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xAngle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Rotate_Public_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x000569C4 File Offset: 0x00054BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499844, XrefRangeEnd = 499846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateAroundInternal(Vector3 axis, float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_RotateAroundInternal_Internal_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x00056A10 File Offset: 0x00054C10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 499848, RefRangeEnd = 499851, XrefRangeStart = 499846, XrefRangeEnd = 499848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(Vector3 axis, float angle, Space relativeTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_Space_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00056A6C File Offset: 0x00054C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499851, XrefRangeEnd = 499852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(Vector3 axis, float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00056AB8 File Offset: 0x00054CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499852, XrefRangeEnd = 499856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 worldPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref worldPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00056AF8 File Offset: 0x00054CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499856, XrefRangeEnd = 499858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref worldPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Internal_LookAt_Private_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x00056B44 File Offset: 0x00054D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499858, XrefRangeEnd = 499860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformDirection(Vector3 direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x00056B90 File Offset: 0x00054D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499860, XrefRangeEnd = 499862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformDirection(Vector3 direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x00056BDC File Offset: 0x00054DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499862, XrefRangeEnd = 499864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformVector(Vector3 vector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x00056C28 File Offset: 0x00054E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499864, XrefRangeEnd = 499866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformVector(Vector3 vector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x00056C74 File Offset: 0x00054E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499866, XrefRangeEnd = 499868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x00056CC0 File Offset: 0x00054EC0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 499870, RefRangeEnd = 499875, XrefRangeStart = 499868, XrefRangeEnd = 499870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001612 RID: 5650 RVA: 0x00056D0C File Offset: 0x00054F0C
		public unsafe Transform root
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 499879, RefRangeEnd = 499885, XrefRangeStart = 499875, XrefRangeEnd = 499879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_root_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x00056D4C File Offset: 0x00054F4C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 499879, RefRangeEnd = 499885, XrefRangeStart = 499879, XrefRangeEnd = 499885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetRoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetRoot_Private_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001614 RID: 5652 RVA: 0x00056D8C File Offset: 0x00054F8C
		public unsafe int childCount
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 499889, RefRangeEnd = 499896, XrefRangeStart = 499885, XrefRangeEnd = 499889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_childCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00056DC8 File Offset: 0x00054FC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 499900, RefRangeEnd = 499902, XrefRangeStart = 499896, XrefRangeEnd = 499900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAsFirstSibling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetAsFirstSibling_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x00056DFC File Offset: 0x00054FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499902, XrefRangeEnd = 499906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAsLastSibling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetAsLastSibling_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x00056E30 File Offset: 0x00055030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499906, XrefRangeEnd = 499910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSiblingIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetSiblingIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00056E70 File Offset: 0x00055070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499910, XrefRangeEnd = 499914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSiblingIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetSiblingIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00056EAC File Offset: 0x000550AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499914, XrefRangeEnd = 499918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActiveOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_FindRelativeTransformWithPath_Private_Static_Transform_Transform_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00056F10 File Offset: 0x00055110
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 499928, RefRangeEnd = 499930, XrefRangeStart = 499918, XrefRangeEnd = 499928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform Find(string n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(n);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Find_Public_Transform_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x0600161B RID: 5659 RVA: 0x00056F60 File Offset: 0x00055160
		public unsafe Vector3 lossyScale
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499930, XrefRangeEnd = 499932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00056F9C File Offset: 0x0005519C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 499936, RefRangeEnd = 499940, XrefRangeStart = 499932, XrefRangeEnd = 499936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsChildOf(Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_IsChildOf_Public_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x0600161D RID: 5661 RVA: 0x00056FEC File Offset: 0x000551EC
		// (set) Token: 0x0600161E RID: 5662 RVA: 0x00057028 File Offset: 0x00055228
		public unsafe bool hasChanged
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499940, XrefRangeEnd = 499944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_hasChanged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499944, XrefRangeEnd = 499948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00057068 File Offset: 0x00055268
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 499951, RefRangeEnd = 499957, XrefRangeStart = 499948, XrefRangeEnd = 499951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x000570A8 File Offset: 0x000552A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 499961, RefRangeEnd = 499965, XrefRangeStart = 499957, XrefRangeEnd = 499961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetChild(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetChild_Public_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x000570F4 File Offset: 0x000552F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499965, XrefRangeEnd = 499969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_position_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_position_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00057134 File Offset: 0x00055334
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 499973, RefRangeEnd = 499974, XrefRangeStart = 499969, XrefRangeEnd = 499973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_position_Injected(ref Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_position_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x00057174 File Offset: 0x00055374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499974, XrefRangeEnd = 499978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_localPosition_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localPosition_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x000571B4 File Offset: 0x000553B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499978, XrefRangeEnd = 499982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_localPosition_Injected(ref Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localPosition_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x000571F4 File Offset: 0x000553F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499982, XrefRangeEnd = 499986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_rotation_Injected(out Quaternion ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_rotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00057234 File Offset: 0x00055434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 499990, RefRangeEnd = 499991, XrefRangeStart = 499986, XrefRangeEnd = 499990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_rotation_Injected(ref Quaternion value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_rotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00057274 File Offset: 0x00055474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499991, XrefRangeEnd = 499995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_localRotation_Injected(out Quaternion ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localRotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x000572B4 File Offset: 0x000554B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499995, XrefRangeEnd = 499999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_localRotation_Injected(ref Quaternion value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localRotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x000572F4 File Offset: 0x000554F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499999, XrefRangeEnd = 500003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_localScale_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localScale_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00057334 File Offset: 0x00055534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500003, XrefRangeEnd = 500007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_localScale_Injected(ref Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localScale_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00057374 File Offset: 0x00055574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500007, XrefRangeEnd = 500011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_worldToLocalMatrix_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_worldToLocalMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x000573B4 File Offset: 0x000555B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500011, XrefRangeEnd = 500015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_localToWorldMatrix_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localToWorldMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x000573F4 File Offset: 0x000555F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500015, XrefRangeEnd = 500019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateAroundInternal_Injected(ref Vector3 axis, float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_RotateAroundInternal_Injected_Private_Void_byref_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00057440 File Offset: 0x00055640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500019, XrefRangeEnd = 500023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &worldPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &worldUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Internal_LookAt_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x0005748C File Offset: 0x0005568C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500023, XrefRangeEnd = 500027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &direction;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformDirection_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x000574D8 File Offset: 0x000556D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500027, XrefRangeEnd = 500031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &direction;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformDirection_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00057524 File Offset: 0x00055724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500031, XrefRangeEnd = 500035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransformVector_Injected(ref Vector3 vector, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformVector_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00057570 File Offset: 0x00055770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500035, XrefRangeEnd = 500039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformVector_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x000575BC File Offset: 0x000557BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500039, XrefRangeEnd = 500043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransformPoint_Injected(ref Vector3 position, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00057608 File Offset: 0x00055808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500043, XrefRangeEnd = 500047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x00057654 File Offset: 0x00055854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500047, XrefRangeEnd = 500055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_lossyScale_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_lossyScale_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x0000BE82 File Offset: 0x0000A082
		public Transform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x00057694 File Offset: 0x00055894
		public Vector3 GetLocalEulerAngles(RotationOrder order)
		{
			Vector3 vector;
			this.GetLocalEulerAngles_Injected(order, out vector);
			return vector;
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x0000BE8B File Offset: 0x0000A08B
		public void SetLocalEulerAngles(Vector3 euler, RotationOrder order)
		{
			this.SetLocalEulerAngles_Injected(ref euler, order);
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x0000BE96 File Offset: 0x0000A096
		public void SetLocalEulerHint(Vector3 euler)
		{
			this.SetLocalEulerHint_Injected(ref euler);
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x000576AC File Offset: 0x000558AC
		// (set) Token: 0x0600163E RID: 5694 RVA: 0x0000BEDA File Offset: 0x0000A0DA
		public RotationOrder rotationOrder
		{
			get
			{
				return (RotationOrder)this.GetRotationOrderInternal();
			}
			set
			{
				this.SetRotationOrderInternal(value);
			}
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x0000BEE5 File Offset: 0x0000A0E5
		public int GetRotationOrderInternal()
		{
			return Transform.GetRotationOrderInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x0000BEF7 File Offset: 0x0000A0F7
		public void SetRotationOrderInternal(RotationOrder rotationOrder)
		{
			Transform.SetRotationOrderInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), rotationOrder);
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x0000BF0A File Offset: 0x0000A10A
		public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
		{
			this.SetPositionAndRotation_Injected(ref position, ref rotation);
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x0000BF16 File Offset: 0x0000A116
		public void Translate(float x, float y, float z, Space relativeTo)
		{
			this.Translate(new Vector3(x, y, z), relativeTo);
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x0000BF2A File Offset: 0x0000A12A
		public void Translate(float x, float y, float z)
		{
			this.Translate(new Vector3(x, y, z), Space.Self);
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x000576C4 File Offset: 0x000558C4
		public void Translate(Vector3 translation, Transform relativeTo)
		{
			bool flag = relativeTo;
			if (flag)
			{
				this.position += relativeTo.TransformDirection(translation);
			}
			else
			{
				this.position += translation;
			}
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x0000BF3D File Offset: 0x0000A13D
		public void Translate(float x, float y, float z, Transform relativeTo)
		{
			this.Translate(new Vector3(x, y, z), relativeTo);
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x0000BF51 File Offset: 0x0000A151
		public void Rotate(Vector3 eulers)
		{
			this.Rotate(eulers, Space.Self);
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x0000BF5D File Offset: 0x0000A15D
		public void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo)
		{
			this.Rotate(new Vector3(xAngle, yAngle, zAngle), relativeTo);
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x0005770C File Offset: 0x0005590C
		public void RotateAround(Vector3 point, Vector3 axis, float angle)
		{
			Vector3 vector = this.position;
			Quaternion quaternion = Quaternion.AngleAxis(angle, axis);
			Vector3 vector2 = vector - point;
			vector2 = quaternion * vector2;
			vector = point + vector2;
			this.position = vector;
			this.RotateAroundInternal(axis, angle * 0.017453292f);
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00057758 File Offset: 0x00055958
		public void LookAt(Transform target, Vector3 worldUp)
		{
			bool flag = target;
			if (flag)
			{
				this.LookAt(target.position, worldUp);
			}
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x00057780 File Offset: 0x00055980
		public void LookAt(Transform target)
		{
			bool flag = target;
			if (flag)
			{
				this.LookAt(target.position, Vector3.up);
			}
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x0000BF71 File Offset: 0x0000A171
		public void LookAt(Vector3 worldPosition, Vector3 worldUp)
		{
			this.Internal_LookAt(worldPosition, worldUp);
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x000577AC File Offset: 0x000559AC
		public Vector3 TransformDirection(float x, float y, float z)
		{
			return this.TransformDirection(new Vector3(x, y, z));
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x000577CC File Offset: 0x000559CC
		public Vector3 InverseTransformDirection(float x, float y, float z)
		{
			return this.InverseTransformDirection(new Vector3(x, y, z));
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x000577EC File Offset: 0x000559EC
		public Vector3 TransformVector(float x, float y, float z)
		{
			return this.TransformVector(new Vector3(x, y, z));
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x0005780C File Offset: 0x00055A0C
		public Vector3 InverseTransformVector(float x, float y, float z)
		{
			return this.InverseTransformVector(new Vector3(x, y, z));
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x0005782C File Offset: 0x00055A2C
		public Vector3 TransformPoint(float x, float y, float z)
		{
			return this.TransformPoint(new Vector3(x, y, z));
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x0005784C File Offset: 0x00055A4C
		public Vector3 InverseTransformPoint(float x, float y, float z)
		{
			return this.InverseTransformPoint(new Vector3(x, y, z));
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x0000BF7D File Offset: 0x0000A17D
		public void DetachChildren()
		{
			Transform.DetachChildrenDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x0000BF8F File Offset: 0x0000A18F
		public void MoveAfterSibling(Transform transform, bool notifyEditorAndMarkDirty)
		{
			Transform.MoveAfterSiblingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(transform), notifyEditorAndMarkDirty);
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x0000BFA8 File Offset: 0x0000A1A8
		public void SendTransformChangedScale()
		{
			Transform.SendTransformChangedScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x0005786C File Offset: 0x00055A6C
		public Transform FindChild(string n)
		{
			return this.Find(n);
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x0000BFBA File Offset: 0x0000A1BA
		public void RotateAround(Vector3 axis, float angle)
		{
			this.RotateAround_Injected(ref axis, angle);
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x0000BFC5 File Offset: 0x0000A1C5
		public void RotateAroundLocal(Vector3 axis, float angle)
		{
			this.RotateAroundLocal_Injected(ref axis, angle);
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		public int GetChildCount()
		{
			return Transform.GetChildCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x00057888 File Offset: 0x00055A88
		// (set) Token: 0x0600165A RID: 5722 RVA: 0x0000BFE2 File Offset: 0x0000A1E2
		public int hierarchyCapacity
		{
			get
			{
				return this.internal_getHierarchyCapacity();
			}
			set
			{
				this.internal_setHierarchyCapacity(value);
			}
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x0000BFED File Offset: 0x0000A1ED
		public int internal_getHierarchyCapacity()
		{
			return Transform.internal_getHierarchyCapacityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x0000BFFF File Offset: 0x0000A1FF
		public void internal_setHierarchyCapacity(int value)
		{
			Transform.internal_setHierarchyCapacityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x0600165D RID: 5725 RVA: 0x000578A0 File Offset: 0x00055AA0
		public int hierarchyCount
		{
			get
			{
				return this.internal_getHierarchyCount();
			}
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x0000C012 File Offset: 0x0000A212
		public int internal_getHierarchyCount()
		{
			return Transform.internal_getHierarchyCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x0000C024 File Offset: 0x0000A224
		public bool IsNonUniformScaleTransform()
		{
			return Transform.IsNonUniformScaleTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x0000C036 File Offset: 0x0000A236
		public void GetLocalEulerAngles_Injected(RotationOrder order, out Vector3 ret)
		{
			Transform.GetLocalEulerAngles_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), order, out ret);
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x0000C04A File Offset: 0x0000A24A
		public void SetLocalEulerAngles_Injected(ref Vector3 euler, RotationOrder order)
		{
			Transform.SetLocalEulerAngles_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref euler, order);
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x0000C05E File Offset: 0x0000A25E
		public void SetLocalEulerHint_Injected(ref Vector3 euler)
		{
			Transform.SetLocalEulerHint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref euler);
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x0000C071 File Offset: 0x0000A271
		public void SetPositionAndRotation_Injected(ref Vector3 position, ref Quaternion rotation)
		{
			Transform.SetPositionAndRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, ref rotation);
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x0000C085 File Offset: 0x0000A285
		public void RotateAround_Injected(ref Vector3 axis, float angle)
		{
			Transform.RotateAround_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref axis, angle);
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x0000C099 File Offset: 0x0000A299
		public void RotateAroundLocal_Injected(ref Vector3 axis, float angle)
		{
			Transform.RotateAroundLocal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref axis, angle);
		}

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector3_0;

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0;

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeMethodInfoPtr_get_localPosition_Public_get_Vector3_0;

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeMethodInfoPtr_set_localPosition_Public_set_Void_Vector3_0;

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0;

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0;

		// Token: 0x04001145 RID: 4421
		private static readonly IntPtr NativeMethodInfoPtr_get_localEulerAngles_Public_get_Vector3_0;

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeMethodInfoPtr_set_localEulerAngles_Public_set_Void_Vector3_0;

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeMethodInfoPtr_get_right_Public_get_Vector3_0;

		// Token: 0x04001148 RID: 4424
		private static readonly IntPtr NativeMethodInfoPtr_get_up_Public_get_Vector3_0;

		// Token: 0x04001149 RID: 4425
		private static readonly IntPtr NativeMethodInfoPtr_get_forward_Public_get_Vector3_0;

		// Token: 0x0400114A RID: 4426
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0;

		// Token: 0x0400114B RID: 4427
		private static readonly IntPtr NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0;

		// Token: 0x0400114C RID: 4428
		private static readonly IntPtr NativeMethodInfoPtr_get_localRotation_Public_get_Quaternion_0;

		// Token: 0x0400114D RID: 4429
		private static readonly IntPtr NativeMethodInfoPtr_set_localRotation_Public_set_Void_Quaternion_0;

		// Token: 0x0400114E RID: 4430
		private static readonly IntPtr NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0;

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeMethodInfoPtr_set_localScale_Public_set_Void_Vector3_0;

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeMethodInfoPtr_get_parent_Public_get_Transform_0;

		// Token: 0x04001151 RID: 4433
		private static readonly IntPtr NativeMethodInfoPtr_set_parent_Public_set_Void_Transform_0;

		// Token: 0x04001152 RID: 4434
		private static readonly IntPtr NativeMethodInfoPtr_get_parentInternal_Internal_get_Transform_0;

		// Token: 0x04001153 RID: 4435
		private static readonly IntPtr NativeMethodInfoPtr_set_parentInternal_Internal_set_Void_Transform_0;

		// Token: 0x04001154 RID: 4436
		private static readonly IntPtr NativeMethodInfoPtr_GetParent_Private_Transform_0;

		// Token: 0x04001155 RID: 4437
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Public_Void_Transform_0;

		// Token: 0x04001156 RID: 4438
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Public_Void_Transform_Boolean_0;

		// Token: 0x04001157 RID: 4439
		private static readonly IntPtr NativeMethodInfoPtr_get_worldToLocalMatrix_Public_get_Matrix4x4_0;

		// Token: 0x04001158 RID: 4440
		private static readonly IntPtr NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0;

		// Token: 0x04001159 RID: 4441
		private static readonly IntPtr NativeMethodInfoPtr_Translate_Public_Void_Vector3_Space_0;

		// Token: 0x0400115A RID: 4442
		private static readonly IntPtr NativeMethodInfoPtr_Translate_Public_Void_Vector3_0;

		// Token: 0x0400115B RID: 4443
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Space_0;

		// Token: 0x0400115C RID: 4444
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Single_Single_Single_0;

		// Token: 0x0400115D RID: 4445
		private static readonly IntPtr NativeMethodInfoPtr_RotateAroundInternal_Internal_Void_Vector3_Single_0;

		// Token: 0x0400115E RID: 4446
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_Space_0;

		// Token: 0x0400115F RID: 4447
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_0;

		// Token: 0x04001160 RID: 4448
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0;

		// Token: 0x04001161 RID: 4449
		private static readonly IntPtr NativeMethodInfoPtr_Internal_LookAt_Private_Void_Vector3_Vector3_0;

		// Token: 0x04001162 RID: 4450
		private static readonly IntPtr NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0;

		// Token: 0x04001163 RID: 4451
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Vector3_0;

		// Token: 0x04001164 RID: 4452
		private static readonly IntPtr NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0;

		// Token: 0x04001165 RID: 4453
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Vector3_0;

		// Token: 0x04001166 RID: 4454
		private static readonly IntPtr NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0;

		// Token: 0x04001167 RID: 4455
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0;

		// Token: 0x04001168 RID: 4456
		private static readonly IntPtr NativeMethodInfoPtr_get_root_Public_get_Transform_0;

		// Token: 0x04001169 RID: 4457
		private static readonly IntPtr NativeMethodInfoPtr_GetRoot_Private_Transform_0;

		// Token: 0x0400116A RID: 4458
		private static readonly IntPtr NativeMethodInfoPtr_get_childCount_Public_get_Int32_0;

		// Token: 0x0400116B RID: 4459
		private static readonly IntPtr NativeMethodInfoPtr_SetAsFirstSibling_Public_Void_0;

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeMethodInfoPtr_SetAsLastSibling_Public_Void_0;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeMethodInfoPtr_SetSiblingIndex_Public_Void_Int32_0;

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeMethodInfoPtr_GetSiblingIndex_Public_Int32_0;

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeMethodInfoPtr_FindRelativeTransformWithPath_Private_Static_Transform_Transform_String_Boolean_0;

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Transform_String_0;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0;

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeMethodInfoPtr_IsChildOf_Public_Boolean_Transform_0;

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeMethodInfoPtr_get_hasChanged_Public_get_Boolean_0;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0;

		// Token: 0x04001175 RID: 4469
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04001176 RID: 4470
		private static readonly IntPtr NativeMethodInfoPtr_GetChild_Public_Transform_Int32_0;

		// Token: 0x04001177 RID: 4471
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04001178 RID: 4472
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04001179 RID: 4473
		private static readonly IntPtr NativeMethodInfoPtr_get_localPosition_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x0400117A RID: 4474
		private static readonly IntPtr NativeMethodInfoPtr_set_localPosition_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x0400117B RID: 4475
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x0400117C RID: 4476
		private static readonly IntPtr NativeMethodInfoPtr_set_rotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x0400117D RID: 4477
		private static readonly IntPtr NativeMethodInfoPtr_get_localRotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x0400117E RID: 4478
		private static readonly IntPtr NativeMethodInfoPtr_set_localRotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x0400117F RID: 4479
		private static readonly IntPtr NativeMethodInfoPtr_get_localScale_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04001180 RID: 4480
		private static readonly IntPtr NativeMethodInfoPtr_set_localScale_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04001181 RID: 4481
		private static readonly IntPtr NativeMethodInfoPtr_get_worldToLocalMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x04001182 RID: 4482
		private static readonly IntPtr NativeMethodInfoPtr_get_localToWorldMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x04001183 RID: 4483
		private static readonly IntPtr NativeMethodInfoPtr_RotateAroundInternal_Injected_Private_Void_byref_Vector3_Single_0;

		// Token: 0x04001184 RID: 4484
		private static readonly IntPtr NativeMethodInfoPtr_Internal_LookAt_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x04001185 RID: 4485
		private static readonly IntPtr NativeMethodInfoPtr_TransformDirection_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x04001186 RID: 4486
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformDirection_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeMethodInfoPtr_TransformVector_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformVector_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeMethodInfoPtr_TransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeMethodInfoPtr_get_lossyScale_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x0400118C RID: 4492
		private static readonly Transform.GetRotationOrderInternalDelegate GetRotationOrderInternalDelegateField;

		// Token: 0x0400118D RID: 4493
		private static readonly Transform.SetRotationOrderInternalDelegate SetRotationOrderInternalDelegateField;

		// Token: 0x0400118E RID: 4494
		private static readonly Transform.DetachChildrenDelegate DetachChildrenDelegateField;

		// Token: 0x0400118F RID: 4495
		private static readonly Transform.MoveAfterSiblingDelegate MoveAfterSiblingDelegateField;

		// Token: 0x04001190 RID: 4496
		private static readonly Transform.SendTransformChangedScaleDelegate SendTransformChangedScaleDelegateField;

		// Token: 0x04001191 RID: 4497
		private static readonly Transform.GetChildCountDelegate GetChildCountDelegateField;

		// Token: 0x04001192 RID: 4498
		private static readonly Transform.internal_getHierarchyCapacityDelegate internal_getHierarchyCapacityDelegateField;

		// Token: 0x04001193 RID: 4499
		private static readonly Transform.internal_setHierarchyCapacityDelegate internal_setHierarchyCapacityDelegateField;

		// Token: 0x04001194 RID: 4500
		private static readonly Transform.internal_getHierarchyCountDelegate internal_getHierarchyCountDelegateField;

		// Token: 0x04001195 RID: 4501
		private static readonly Transform.IsNonUniformScaleTransformDelegate IsNonUniformScaleTransformDelegateField;

		// Token: 0x04001196 RID: 4502
		private static readonly Transform.GetLocalEulerAngles_InjectedDelegate GetLocalEulerAngles_InjectedDelegateField;

		// Token: 0x04001197 RID: 4503
		private static readonly Transform.SetLocalEulerAngles_InjectedDelegate SetLocalEulerAngles_InjectedDelegateField;

		// Token: 0x04001198 RID: 4504
		private static readonly Transform.SetLocalEulerHint_InjectedDelegate SetLocalEulerHint_InjectedDelegateField;

		// Token: 0x04001199 RID: 4505
		private static readonly Transform.SetPositionAndRotation_InjectedDelegate SetPositionAndRotation_InjectedDelegateField;

		// Token: 0x0400119A RID: 4506
		private static readonly Transform.RotateAround_InjectedDelegate RotateAround_InjectedDelegateField;

		// Token: 0x0400119B RID: 4507
		private static readonly Transform.RotateAroundLocal_InjectedDelegate RotateAroundLocal_InjectedDelegateField;

		// Token: 0x0200085C RID: 2140
		public class Enumerator : Object
		{
			// Token: 0x06002EB8 RID: 11960 RVA: 0x0007C8E4 File Offset: 0x0007AAE4
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Transform>.NativeClassPtr, "Enumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr);
				Transform.Enumerator.NativeFieldInfoPtr_outer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, "outer");
				Transform.Enumerator.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, "currentIndex");
				Transform.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, 100665286);
				Transform.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, 100665287);
				Transform.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, 100665288);
				Transform.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, 100665289);
			}

			// Token: 0x06002EB9 RID: 11961 RVA: 0x0007C988 File Offset: 0x0007AB88
			[CallerCount(0)]
			public unsafe Enumerator(Transform outer)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(outer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000731 RID: 1841
			// (get) Token: 0x06002EBA RID: 11962 RVA: 0x0007C9D4 File Offset: 0x0007ABD4
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499357, XrefRangeEnd = 499362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002EBB RID: 11963 RVA: 0x0007CA14 File Offset: 0x0007AC14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499362, XrefRangeEnd = 499364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002EBC RID: 11964 RVA: 0x0007CA50 File Offset: 0x0007AC50
			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EBD RID: 11965 RVA: 0x000138F1 File Offset: 0x00011AF1
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700072F RID: 1839
			// (get) Token: 0x06002EBE RID: 11966 RVA: 0x0007CA84 File Offset: 0x0007AC84
			// (set) Token: 0x06002EBF RID: 11967 RVA: 0x000138FA File Offset: 0x00011AFA
			public unsafe Transform outer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transform.Enumerator.NativeFieldInfoPtr_outer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transform.Enumerator.NativeFieldInfoPtr_outer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000730 RID: 1840
			// (get) Token: 0x06002EC0 RID: 11968 RVA: 0x0007CAB4 File Offset: 0x0007ACB4
			// (set) Token: 0x06002EC1 RID: 11969 RVA: 0x00013919 File Offset: 0x00011B19
			public unsafe int currentIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transform.Enumerator.NativeFieldInfoPtr_currentIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transform.Enumerator.NativeFieldInfoPtr_currentIndex)) = value;
				}
			}

			// Token: 0x04001F46 RID: 8006
			private static readonly IntPtr NativeFieldInfoPtr_outer;

			// Token: 0x04001F47 RID: 8007
			private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

			// Token: 0x04001F48 RID: 8008
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Transform_0;

			// Token: 0x04001F49 RID: 8009
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04001F4A RID: 8010
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04001F4B RID: 8011
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x0200085D RID: 2141
		// (Invoke) Token: 0x06002EC3 RID: 11971
		private delegate int GetRotationOrderInternalDelegate(IntPtr @this);

		// Token: 0x0200085E RID: 2142
		// (Invoke) Token: 0x06002EC5 RID: 11973
		private delegate void SetRotationOrderInternalDelegate(IntPtr @this, RotationOrder rotationOrder);

		// Token: 0x0200085F RID: 2143
		// (Invoke) Token: 0x06002EC7 RID: 11975
		private delegate void DetachChildrenDelegate(IntPtr @this);

		// Token: 0x02000860 RID: 2144
		// (Invoke) Token: 0x06002EC9 RID: 11977
		private delegate void MoveAfterSiblingDelegate(IntPtr @this, IntPtr transform, bool notifyEditorAndMarkDirty);

		// Token: 0x02000861 RID: 2145
		// (Invoke) Token: 0x06002ECB RID: 11979
		private delegate void SendTransformChangedScaleDelegate(IntPtr @this);

		// Token: 0x02000862 RID: 2146
		// (Invoke) Token: 0x06002ECD RID: 11981
		private delegate int GetChildCountDelegate(IntPtr @this);

		// Token: 0x02000863 RID: 2147
		// (Invoke) Token: 0x06002ECF RID: 11983
		private delegate int internal_getHierarchyCapacityDelegate(IntPtr @this);

		// Token: 0x02000864 RID: 2148
		// (Invoke) Token: 0x06002ED1 RID: 11985
		private delegate void internal_setHierarchyCapacityDelegate(IntPtr @this, int value);

		// Token: 0x02000865 RID: 2149
		// (Invoke) Token: 0x06002ED3 RID: 11987
		private delegate int internal_getHierarchyCountDelegate(IntPtr @this);

		// Token: 0x02000866 RID: 2150
		// (Invoke) Token: 0x06002ED5 RID: 11989
		private delegate bool IsNonUniformScaleTransformDelegate(IntPtr @this);

		// Token: 0x02000867 RID: 2151
		// (Invoke) Token: 0x06002ED7 RID: 11991
		private delegate void GetLocalEulerAngles_InjectedDelegate(IntPtr @this, RotationOrder order, [Out] IntPtr ret);

		// Token: 0x02000868 RID: 2152
		// (Invoke) Token: 0x06002ED9 RID: 11993
		private delegate void SetLocalEulerAngles_InjectedDelegate(IntPtr @this, IntPtr euler, RotationOrder order);

		// Token: 0x02000869 RID: 2153
		// (Invoke) Token: 0x06002EDB RID: 11995
		private delegate void SetLocalEulerHint_InjectedDelegate(IntPtr @this, IntPtr euler);

		// Token: 0x0200086A RID: 2154
		// (Invoke) Token: 0x06002EDD RID: 11997
		private delegate void SetPositionAndRotation_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr rotation);

		// Token: 0x0200086B RID: 2155
		// (Invoke) Token: 0x06002EDF RID: 11999
		private delegate void RotateAround_InjectedDelegate(IntPtr @this, IntPtr axis, float angle);

		// Token: 0x0200086C RID: 2156
		// (Invoke) Token: 0x06002EE1 RID: 12001
		private delegate void RotateAroundLocal_InjectedDelegate(IntPtr @this, IntPtr axis, float angle);
	}
}
