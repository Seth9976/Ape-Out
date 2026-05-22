using System;
using Il2CppDG.Tweening.Core;
using Il2CppDG.Tweening.Plugins.Core.PathCore;
using Il2CppDG.Tweening.Plugins.Options;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppDG.Tweening
{
	// Token: 0x02000017 RID: 23
	public static class TweenSettingsExtensions : global::Il2CppSystem.Object
	{
		// Token: 0x060001A2 RID: 418 RVA: 0x0000DD78 File Offset: 0x0000BF78
		// Note: this type is marked as 'beforefieldinit'.
		static TweenSettingsExtensions()
		{
			Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening", "TweenSettingsExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetAutoKill_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663825);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetAutoKill_Public_Static_T_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663826);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetId_Public_Static_T_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663827);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetId_Public_Static_T_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663828);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetId_Public_Static_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663829);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetLink_Public_Static_T_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663830);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetLink_Public_Static_T_T_GameObject_LinkBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663831);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetTarget_Public_Static_T_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663832);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetLoops_Public_Static_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663833);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetLoops_Public_Static_T_T_Int32_LoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663834);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetEase_Public_Static_T_T_Ease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663835);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetEase_Public_Static_T_T_Ease_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663836);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetEase_Public_Static_T_T_Ease_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663837);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetEase_Public_Static_T_T_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663838);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetEase_Public_Static_T_T_EaseFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663839);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetRecyclable_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663840);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetRecyclable_Public_Static_T_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663841);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetUpdate_Public_Static_T_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663842);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetUpdate_Public_Static_T_T_UpdateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663843);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetUpdate_Public_Static_T_T_UpdateType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663844);
			TweenSettingsExtensions.NativeMethodInfoPtr_OnStart_Public_Static_T_T_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663845);
			TweenSettingsExtensions.NativeMethodInfoPtr_OnPlay_Public_Static_T_T_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663846);
			TweenSettingsExtensions.NativeMethodInfoPtr_OnPause_Public_Static_T_T_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663847);
			TweenSettingsExtensions.NativeMethodInfoPtr_OnRewind_Public_Static_T_T_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663848);
			TweenSettingsExtensions.NativeMethodInfoPtr_OnUpdate_Public_Static_T_T_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663849);
			TweenSettingsExtensions.NativeMethodInfoPtr_OnStepComplete_Public_Static_T_T_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663850);
			TweenSettingsExtensions.NativeMethodInfoPtr_OnComplete_Public_Static_T_T_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663851);
			TweenSettingsExtensions.NativeMethodInfoPtr_OnKill_Public_Static_T_T_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663852);
			TweenSettingsExtensions.NativeMethodInfoPtr_OnWaypointChange_Public_Static_T_T_TweenCallback_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663853);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetAs_Public_Static_T_T_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663854);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetAs_Public_Static_T_T_TweenParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663855);
			TweenSettingsExtensions.NativeMethodInfoPtr_Append_Public_Static_Sequence_Sequence_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663856);
			TweenSettingsExtensions.NativeMethodInfoPtr_Prepend_Public_Static_Sequence_Sequence_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663857);
			TweenSettingsExtensions.NativeMethodInfoPtr_Join_Public_Static_Sequence_Sequence_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663858);
			TweenSettingsExtensions.NativeMethodInfoPtr_Insert_Public_Static_Sequence_Sequence_Single_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663859);
			TweenSettingsExtensions.NativeMethodInfoPtr_AppendInterval_Public_Static_Sequence_Sequence_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663860);
			TweenSettingsExtensions.NativeMethodInfoPtr_PrependInterval_Public_Static_Sequence_Sequence_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663861);
			TweenSettingsExtensions.NativeMethodInfoPtr_AppendCallback_Public_Static_Sequence_Sequence_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663862);
			TweenSettingsExtensions.NativeMethodInfoPtr_PrependCallback_Public_Static_Sequence_Sequence_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663863);
			TweenSettingsExtensions.NativeMethodInfoPtr_InsertCallback_Public_Static_Sequence_Sequence_Single_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663864);
			TweenSettingsExtensions.NativeMethodInfoPtr_From_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663865);
			TweenSettingsExtensions.NativeMethodInfoPtr_From_Public_Static_T_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663866);
			TweenSettingsExtensions.NativeMethodInfoPtr_From_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_T2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663867);
			TweenSettingsExtensions.NativeMethodInfoPtr_From_Public_Static_TweenerCore_3_Color_Color_ColorOptions_TweenerCore_3_Color_Color_ColorOptions_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663868);
			TweenSettingsExtensions.NativeMethodInfoPtr_From_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_TweenerCore_3_Vector3_Vector3_VectorOptions_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663869);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetDelay_Public_Static_T_T_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663870);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetRelative_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663871);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetRelative_Public_Static_T_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663872);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetSpeedBased_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663873);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetSpeedBased_Public_Static_T_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663874);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Single_Single_FloatOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663875);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector2_Vector2_VectorOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663876);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector2_Vector2_VectorOptions_AxisConstraint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663877);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Vector3_VectorOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663878);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Vector3_VectorOptions_AxisConstraint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663879);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector4_Vector4_VectorOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663880);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector4_Vector4_VectorOptions_AxisConstraint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663881);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663882);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Color_Color_ColorOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663883);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Rect_Rect_RectOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663884);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_String_String_StringOptions_Boolean_ScrambleMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663885);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663886);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_AxisConstraint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663887);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_AxisConstraint_AxisConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663888);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Boolean_AxisConstraint_AxisConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663889);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetLookAt_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Vector3_Nullable_1_Vector3_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663890);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetLookAt_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Transform_Nullable_1_Vector3_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663891);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetLookAt_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Single_Nullable_1_Vector3_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663892);
			TweenSettingsExtensions.NativeMethodInfoPtr_SetPathForwardDirection_Private_Static_Void_TweenerCore_3_Vector3_Path_PathOptions_Nullable_1_Vector3_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr, 100663893);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000E30C File Offset: 0x0000C50C
		[CallerCount(0)]
		public unsafe static T SetAutoKill<T>(this T t) where T : Tween
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetAutoKill_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000E398 File Offset: 0x0000C598
		[CallerCount(0)]
		public unsafe static T SetAutoKill<T>(this T t, bool autoKillOnCompletion) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoKillOnCompletion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetAutoKill_Public_Static_T_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000E430 File Offset: 0x0000C630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122007, XrefRangeEnd = 122008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetId<T>(this T t, global::Il2CppSystem.Object objectId) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetId_Public_Static_T_T_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000E4CC File Offset: 0x0000C6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122008, XrefRangeEnd = 122009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetId<T>(this T t, string stringId) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stringId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetId_Public_Static_T_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000E568 File Offset: 0x0000C768
		[CallerCount(0)]
		public unsafe static T SetId<T>(this T t, int intId) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetId_Public_Static_T_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000E600 File Offset: 0x0000C800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122009, XrefRangeEnd = 122029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetLink<T>(this T t, GameObject gameObject) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetLink_Public_Static_T_T_GameObject_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000E69C File Offset: 0x0000C89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122029, XrefRangeEnd = 122049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetLink<T>(this T t, GameObject gameObject, LinkBehaviour behaviour) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviour;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetLink_Public_Static_T_T_GameObject_LinkBehaviour_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000E748 File Offset: 0x0000C948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122049, XrefRangeEnd = 122050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetTarget<T>(this T t, global::Il2CppSystem.Object target) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetTarget_Public_Static_T_T_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000E7E4 File Offset: 0x0000C9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122050, XrefRangeEnd = 122051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetLoops<T>(this T t, int loops) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loops;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetLoops_Public_Static_T_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000E87C File Offset: 0x0000CA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122051, XrefRangeEnd = 122052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetLoops<T>(this T t, int loops, LoopType loopType) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loops;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loopType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetLoops_Public_Static_T_T_Int32_LoopType_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000E924 File Offset: 0x0000CB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122052, XrefRangeEnd = 122053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetEase<T>(this T t, Ease ease) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ease;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetEase_Public_Static_T_T_Ease_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000E9BC File Offset: 0x0000CBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122053, XrefRangeEnd = 122054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetEase<T>(this T t, Ease ease, float overshoot) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ease;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshoot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetEase_Public_Static_T_T_Ease_Single_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000EA64 File Offset: 0x0000CC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122054, XrefRangeEnd = 122055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetEase<T>(this T t, Ease ease, float amplitude, float period) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ease;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amplitude;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetEase_Public_Static_T_T_Ease_Single_Single_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000EB18 File Offset: 0x0000CD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122055, XrefRangeEnd = 122065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetEase<T>(this T t, AnimationCurve animCurve) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(animCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetEase_Public_Static_T_T_AnimationCurve_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000EBB4 File Offset: 0x0000CDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122065, XrefRangeEnd = 122066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetEase<T>(this T t, EaseFunction customEase) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customEase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetEase_Public_Static_T_T_EaseFunction_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000EC50 File Offset: 0x0000CE50
		[CallerCount(0)]
		public unsafe static T SetRecyclable<T>(this T t) where T : Tween
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetRecyclable_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000ECDC File Offset: 0x0000CEDC
		[CallerCount(0)]
		public unsafe static T SetRecyclable<T>(this T t, bool recyclable) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recyclable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetRecyclable_Public_Static_T_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000ED74 File Offset: 0x0000CF74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122074, RefRangeEnd = 122076, XrefRangeStart = 122066, XrefRangeEnd = 122074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetUpdate<T>(this T t, bool isIndependentUpdate) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isIndependentUpdate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetUpdate_Public_Static_T_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000EE0C File Offset: 0x0000D00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122076, XrefRangeEnd = 122084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetUpdate<T>(this T t, UpdateType updateType) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetUpdate_Public_Static_T_T_UpdateType_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000EEA4 File Offset: 0x0000D0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122084, XrefRangeEnd = 122088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetUpdate<T>(this T t, UpdateType updateType, bool isIndependentUpdate) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isIndependentUpdate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetUpdate_Public_Static_T_T_UpdateType_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000EF4C File Offset: 0x0000D14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122088, XrefRangeEnd = 122089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T OnStart<T>(this T t, TweenCallback action) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_OnStart_Public_Static_T_T_TweenCallback_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122089, XrefRangeEnd = 122090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T OnPlay<T>(this T t, TweenCallback action) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_OnPlay_Public_Static_T_T_TweenCallback_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000F084 File Offset: 0x0000D284
		[CallerCount(0)]
		public unsafe static T OnPause<T>(this T t, TweenCallback action) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_OnPause_Public_Static_T_T_TweenCallback_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000F120 File Offset: 0x0000D320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122090, XrefRangeEnd = 122091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T OnRewind<T>(this T t, TweenCallback action) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_OnRewind_Public_Static_T_T_TweenCallback_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000F1BC File Offset: 0x0000D3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122091, XrefRangeEnd = 122092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T OnUpdate<T>(this T t, TweenCallback action) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_OnUpdate_Public_Static_T_T_TweenCallback_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000F258 File Offset: 0x0000D458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122092, XrefRangeEnd = 122093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T OnStepComplete<T>(this T t, TweenCallback action) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_OnStepComplete_Public_Static_T_T_TweenCallback_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000F2F4 File Offset: 0x0000D4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122093, XrefRangeEnd = 122094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T OnComplete<T>(this T t, TweenCallback action) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_OnComplete_Public_Static_T_T_TweenCallback_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000F390 File Offset: 0x0000D590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122094, XrefRangeEnd = 122095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T OnKill<T>(this T t, TweenCallback action) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_OnKill_Public_Static_T_T_TweenCallback_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000F42C File Offset: 0x0000D62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122095, XrefRangeEnd = 122096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T OnWaypointChange<T>(this T t, TweenCallback<int> action) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_OnWaypointChange_Public_Static_T_T_TweenCallback_1_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000F4C8 File Offset: 0x0000D6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122096, XrefRangeEnd = 122111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetAs<T>(this T t, Tween asTween) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asTween);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetAs_Public_Static_T_T_Tween_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000F564 File Offset: 0x0000D764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122111, XrefRangeEnd = 122131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetAs<T>(this T t, TweenParams tweenParams) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tweenParams);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetAs_Public_Static_T_T_TweenParams_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000F600 File Offset: 0x0000D800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122131, XrefRangeEnd = 122132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence Append(this Sequence s, Tween t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_Append_Public_Static_Sequence_Sequence_Tween_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000F658 File Offset: 0x0000D858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122132, XrefRangeEnd = 122135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence Prepend(this Sequence s, Tween t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_Prepend_Public_Static_Sequence_Sequence_Tween_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000F6B0 File Offset: 0x0000D8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122135, XrefRangeEnd = 122136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence Join(this Sequence s, Tween t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_Join_Public_Static_Sequence_Sequence_Tween_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000F708 File Offset: 0x0000D908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122136, XrefRangeEnd = 122137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence Insert(this Sequence s, float atPosition, Tween t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_Insert_Public_Static_Sequence_Sequence_Single_Tween_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000F76C File Offset: 0x0000D96C
		[CallerCount(0)]
		public unsafe static Sequence AppendInterval(this Sequence s, float interval)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_AppendInterval_Public_Static_Sequence_Sequence_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000F7C0 File Offset: 0x0000D9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122137, XrefRangeEnd = 122139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence PrependInterval(this Sequence s, float interval)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_PrependInterval_Public_Static_Sequence_Sequence_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000F814 File Offset: 0x0000DA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122139, XrefRangeEnd = 122140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence AppendCallback(this Sequence s, TweenCallback callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_AppendCallback_Public_Static_Sequence_Sequence_TweenCallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000F86C File Offset: 0x0000DA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122140, XrefRangeEnd = 122141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence PrependCallback(this Sequence s, TweenCallback callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_PrependCallback_Public_Static_Sequence_Sequence_TweenCallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000F8C4 File Offset: 0x0000DAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122141, XrefRangeEnd = 122142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence InsertCallback(this Sequence s, float atPosition, TweenCallback callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_InsertCallback_Public_Static_Sequence_Sequence_Single_TweenCallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000F928 File Offset: 0x0000DB28
		[CallerCount(0)]
		public unsafe static T From<T>(this T t) where T : Tweener
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_From_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000F9B4 File Offset: 0x0000DBB4
		[CallerCount(0)]
		public unsafe static T From<T>(this T t, bool isRelative) where T : Tweener
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRelative;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_From_Public_Static_T_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000FA4C File Offset: 0x0000DC4C
		[CallerCount(0)]
		public unsafe static TweenerCore<T1, T2, TPlugOptions> From<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately = true) where TPlugOptions : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T2 ptr4;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = fromValue;
				if (!(t2 is string))
				{
					ref T2 ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
					if ((ref ptr3) != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
				}
			}
			else
			{
				ptr4 = ref fromValue;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setImmediately;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_From_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_T2_Boolean_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<T1, T2, TPlugOptions>>(intPtr3) : null;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000FAFC File Offset: 0x0000DCFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122142, XrefRangeEnd = 122143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color, Color, ColorOptions> From(this TweenerCore<Color, Color, ColorOptions> t, float fromAlphaValue, bool setImmediately = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromAlphaValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setImmediately;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_From_Public_Static_TweenerCore_3_Color_Color_ColorOptions_TweenerCore_3_Color_Color_ColorOptions_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color, Color, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000FB5C File Offset: 0x0000DD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122143, XrefRangeEnd = 122144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> From(this TweenerCore<Vector3, Vector3, VectorOptions> t, float fromValue, bool setImmediately = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setImmediately;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_From_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_TweenerCore_3_Vector3_Vector3_VectorOptions_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000FBBC File Offset: 0x0000DDBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122144, XrefRangeEnd = 122145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T SetDelay<T>(this T t, float delay) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetDelay_Public_Static_T_T_Single_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000FC54 File Offset: 0x0000DE54
		[CallerCount(0)]
		public unsafe static T SetRelative<T>(this T t) where T : Tween
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetRelative_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000FCE0 File Offset: 0x0000DEE0
		[CallerCount(0)]
		public unsafe static T SetRelative<T>(this T t, bool isRelative) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRelative;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetRelative_Public_Static_T_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000FD78 File Offset: 0x0000DF78
		[CallerCount(0)]
		public unsafe static T SetSpeedBased<T>(this T t) where T : Tween
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetSpeedBased_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000FE04 File Offset: 0x0000E004
		[CallerCount(0)]
		public unsafe static T SetSpeedBased<T>(this T t, bool isSpeedBased) where T : Tween
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					if (!(t2 is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr4 = ref t;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSpeedBased;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.MethodInfoStoreGeneric_SetSpeedBased_Public_Static_T_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000FE9C File Offset: 0x0000E09C
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<float, float, FloatOptions> t, bool snapping)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Single_Single_FloatOptions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000FEF0 File Offset: 0x0000E0F0
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, bool snapping)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector2_Vector2_VectorOptions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000FF44 File Offset: 0x0000E144
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisConstraint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector2_Vector2_VectorOptions_AxisConstraint_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000FFA4 File Offset: 0x0000E1A4
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, bool snapping)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Vector3_VectorOptions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000FFF8 File Offset: 0x0000E1F8
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisConstraint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Vector3_VectorOptions_AxisConstraint_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00010058 File Offset: 0x0000E258
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, bool snapping)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector4_Vector4_VectorOptions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000100AC File Offset: 0x0000E2AC
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisConstraint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector4_Vector4_VectorOptions_AxisConstraint_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0001010C File Offset: 0x0000E30C
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool useShortest360Route = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useShortest360Route;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00010160 File Offset: 0x0000E360
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<Color, Color, ColorOptions> t, bool alphaOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alphaOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Color_Color_ColorOptions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000101B4 File Offset: 0x0000E3B4
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<Rect, Rect, RectOptions> t, bool snapping)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Rect_Rect_RectOptions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00010208 File Offset: 0x0000E408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122145, XrefRangeEnd = 122152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener SetOptions(this TweenerCore<string, string, StringOptions> t, bool richTextEnabled, ScrambleMode scrambleMode = ScrambleMode.None, string scrambleChars = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref richTextEnabled;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scrambleMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(scrambleChars);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_String_String_StringOptions_Boolean_ScrambleMode_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0001027C File Offset: 0x0000E47C
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> t, bool snapping)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000102D0 File Offset: 0x0000E4D0
		[CallerCount(0)]
		public unsafe static Tweener SetOptions(this TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisConstraint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_AxisConstraint_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00010330 File Offset: 0x0000E530
		[CallerCount(0)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, AxisConstraint lockPosition, AxisConstraint lockRotation = AxisConstraint.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_AxisConstraint_AxisConstraint_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00010390 File Offset: 0x0000E590
		[CallerCount(0)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, bool closePath, AxisConstraint lockPosition = AxisConstraint.None, AxisConstraint lockRotation = AxisConstraint.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref closePath;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockPosition;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetOptions_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Boolean_AxisConstraint_AxisConstraint_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00010400 File Offset: 0x0000E600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122152, XrefRangeEnd = 122153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, Nullable<Vector3> forwardDirection = null, Nullable<Vector3> up = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lookAtPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(forwardDirection));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(up));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetLookAt_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Vector3_Nullable_1_Vector3_Nullable_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00010480 File Offset: 0x0000E680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122153, XrefRangeEnd = 122155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, Nullable<Vector3> forwardDirection = null, Nullable<Vector3> up = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lookAtTransform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(forwardDirection));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(up));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetLookAt_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Transform_Nullable_1_Vector3_Nullable_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00010504 File Offset: 0x0000E704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122155, XrefRangeEnd = 122156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, Nullable<Vector3> forwardDirection = null, Nullable<Vector3> up = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lookAhead;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(forwardDirection));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(up));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetLookAt_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Single_Nullable_1_Vector3_Nullable_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00010584 File Offset: 0x0000E784
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 122181, RefRangeEnd = 122184, XrefRangeStart = 122156, XrefRangeEnd = 122181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPathForwardDirection(this TweenerCore<Vector3, Path, PathOptions> t, Nullable<Vector3> forwardDirection = null, Nullable<Vector3> up = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(forwardDirection));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(up));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenSettingsExtensions.NativeMethodInfoPtr_SetPathForwardDirection_Private_Static_Void_TweenerCore_3_Vector3_Path_PathOptions_Nullable_1_Vector3_Nullable_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000025F2 File Offset: 0x000007F2
		public TweenSettingsExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_SetAutoKill_Public_Static_T_T_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_SetAutoKill_Public_Static_T_T_Boolean_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_SetId_Public_Static_T_T_Object_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_SetId_Public_Static_T_T_String_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_SetId_Public_Static_T_T_Int32_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_SetLink_Public_Static_T_T_GameObject_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_SetLink_Public_Static_T_T_GameObject_LinkBehaviour_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_SetTarget_Public_Static_T_T_Object_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_SetLoops_Public_Static_T_T_Int32_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_SetLoops_Public_Static_T_T_Int32_LoopType_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_SetEase_Public_Static_T_T_Ease_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_SetEase_Public_Static_T_T_Ease_Single_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_SetEase_Public_Static_T_T_Ease_Single_Single_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_SetEase_Public_Static_T_T_AnimationCurve_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_SetEase_Public_Static_T_T_EaseFunction_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_SetRecyclable_Public_Static_T_T_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_SetRecyclable_Public_Static_T_T_Boolean_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_SetUpdate_Public_Static_T_T_Boolean_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_SetUpdate_Public_Static_T_T_UpdateType_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_SetUpdate_Public_Static_T_T_UpdateType_Boolean_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_OnStart_Public_Static_T_T_TweenCallback_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_OnPlay_Public_Static_T_T_TweenCallback_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_OnPause_Public_Static_T_T_TweenCallback_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_OnRewind_Public_Static_T_T_TweenCallback_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Public_Static_T_T_TweenCallback_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_OnStepComplete_Public_Static_T_T_TweenCallback_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_OnComplete_Public_Static_T_T_TweenCallback_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_OnKill_Public_Static_T_T_TweenCallback_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_OnWaypointChange_Public_Static_T_T_TweenCallback_1_Int32_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr_SetAs_Public_Static_T_T_Tween_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_SetAs_Public_Static_T_T_TweenParams_0;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Static_Sequence_Sequence_Tween_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_Prepend_Public_Static_Sequence_Sequence_Tween_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_Join_Public_Static_Sequence_Sequence_Tween_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Static_Sequence_Sequence_Single_Tween_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_AppendInterval_Public_Static_Sequence_Sequence_Single_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_PrependInterval_Public_Static_Sequence_Sequence_Single_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_AppendCallback_Public_Static_Sequence_Sequence_TweenCallback_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_PrependCallback_Public_Static_Sequence_Sequence_TweenCallback_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_InsertCallback_Public_Static_Sequence_Sequence_Single_TweenCallback_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_From_Public_Static_T_T_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_From_Public_Static_T_T_Boolean_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_From_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_T2_Boolean_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_From_Public_Static_TweenerCore_3_Color_Color_ColorOptions_TweenerCore_3_Color_Color_ColorOptions_Single_Boolean_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_From_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_TweenerCore_3_Vector3_Vector3_VectorOptions_Single_Boolean_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_SetDelay_Public_Static_T_T_Single_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_SetRelative_Public_Static_T_T_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_SetRelative_Public_Static_T_T_Boolean_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_SetSpeedBased_Public_Static_T_T_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_SetSpeedBased_Public_Static_T_T_Boolean_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Single_Single_FloatOptions_Boolean_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector2_Vector2_VectorOptions_Boolean_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector2_Vector2_VectorOptions_AxisConstraint_Boolean_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Vector3_VectorOptions_Boolean_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Vector3_VectorOptions_AxisConstraint_Boolean_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector4_Vector4_VectorOptions_Boolean_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector4_Vector4_VectorOptions_AxisConstraint_Boolean_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_Boolean_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Color_Color_ColorOptions_Boolean_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Rect_Rect_RectOptions_Boolean_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_String_String_StringOptions_Boolean_ScrambleMode_String_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_Boolean_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_Tweener_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_AxisConstraint_Boolean_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_AxisConstraint_AxisConstraint_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Boolean_AxisConstraint_AxisConstraint_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_SetLookAt_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Vector3_Nullable_1_Vector3_Nullable_1_Vector3_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_SetLookAt_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Transform_Nullable_1_Vector3_Nullable_1_Vector3_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_SetLookAt_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_TweenerCore_3_Vector3_Path_PathOptions_Single_Nullable_1_Vector3_Nullable_1_Vector3_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_SetPathForwardDirection_Private_Static_Void_TweenerCore_3_Vector3_Path_PathOptions_Nullable_1_Vector3_Nullable_1_Vector3_0;

		// Token: 0x020000B4 RID: 180
		private sealed class MethodInfoStoreGeneric_SetAutoKill_Public_Static_T_T_0<T>
		{
			// Token: 0x04000615 RID: 1557
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetAutoKill_Public_Static_T_T_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000B5 RID: 181
		private sealed class MethodInfoStoreGeneric_SetAutoKill_Public_Static_T_T_Boolean_0<T>
		{
			// Token: 0x04000616 RID: 1558
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetAutoKill_Public_Static_T_T_Boolean_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000B6 RID: 182
		private sealed class MethodInfoStoreGeneric_SetId_Public_Static_T_T_Object_0<T>
		{
			// Token: 0x04000617 RID: 1559
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetId_Public_Static_T_T_Object_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000B7 RID: 183
		private sealed class MethodInfoStoreGeneric_SetId_Public_Static_T_T_String_0<T>
		{
			// Token: 0x04000618 RID: 1560
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetId_Public_Static_T_T_String_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000B8 RID: 184
		private sealed class MethodInfoStoreGeneric_SetId_Public_Static_T_T_Int32_0<T>
		{
			// Token: 0x04000619 RID: 1561
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetId_Public_Static_T_T_Int32_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000B9 RID: 185
		private sealed class MethodInfoStoreGeneric_SetLink_Public_Static_T_T_GameObject_0<T>
		{
			// Token: 0x0400061A RID: 1562
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetLink_Public_Static_T_T_GameObject_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000BA RID: 186
		private sealed class MethodInfoStoreGeneric_SetLink_Public_Static_T_T_GameObject_LinkBehaviour_0<T>
		{
			// Token: 0x0400061B RID: 1563
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetLink_Public_Static_T_T_GameObject_LinkBehaviour_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000BB RID: 187
		private sealed class MethodInfoStoreGeneric_SetTarget_Public_Static_T_T_Object_0<T>
		{
			// Token: 0x0400061C RID: 1564
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetTarget_Public_Static_T_T_Object_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000BC RID: 188
		private sealed class MethodInfoStoreGeneric_SetLoops_Public_Static_T_T_Int32_0<T>
		{
			// Token: 0x0400061D RID: 1565
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetLoops_Public_Static_T_T_Int32_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000BD RID: 189
		private sealed class MethodInfoStoreGeneric_SetLoops_Public_Static_T_T_Int32_LoopType_0<T>
		{
			// Token: 0x0400061E RID: 1566
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetLoops_Public_Static_T_T_Int32_LoopType_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000BE RID: 190
		private sealed class MethodInfoStoreGeneric_SetEase_Public_Static_T_T_Ease_0<T>
		{
			// Token: 0x0400061F RID: 1567
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetEase_Public_Static_T_T_Ease_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000BF RID: 191
		private sealed class MethodInfoStoreGeneric_SetEase_Public_Static_T_T_Ease_Single_0<T>
		{
			// Token: 0x04000620 RID: 1568
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetEase_Public_Static_T_T_Ease_Single_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C0 RID: 192
		private sealed class MethodInfoStoreGeneric_SetEase_Public_Static_T_T_Ease_Single_Single_0<T>
		{
			// Token: 0x04000621 RID: 1569
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetEase_Public_Static_T_T_Ease_Single_Single_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C1 RID: 193
		private sealed class MethodInfoStoreGeneric_SetEase_Public_Static_T_T_AnimationCurve_0<T>
		{
			// Token: 0x04000622 RID: 1570
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetEase_Public_Static_T_T_AnimationCurve_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C2 RID: 194
		private sealed class MethodInfoStoreGeneric_SetEase_Public_Static_T_T_EaseFunction_0<T>
		{
			// Token: 0x04000623 RID: 1571
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetEase_Public_Static_T_T_EaseFunction_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C3 RID: 195
		private sealed class MethodInfoStoreGeneric_SetRecyclable_Public_Static_T_T_0<T>
		{
			// Token: 0x04000624 RID: 1572
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetRecyclable_Public_Static_T_T_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C4 RID: 196
		private sealed class MethodInfoStoreGeneric_SetRecyclable_Public_Static_T_T_Boolean_0<T>
		{
			// Token: 0x04000625 RID: 1573
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetRecyclable_Public_Static_T_T_Boolean_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C5 RID: 197
		private sealed class MethodInfoStoreGeneric_SetUpdate_Public_Static_T_T_Boolean_0<T>
		{
			// Token: 0x04000626 RID: 1574
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetUpdate_Public_Static_T_T_Boolean_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C6 RID: 198
		private sealed class MethodInfoStoreGeneric_SetUpdate_Public_Static_T_T_UpdateType_0<T>
		{
			// Token: 0x04000627 RID: 1575
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetUpdate_Public_Static_T_T_UpdateType_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C7 RID: 199
		private sealed class MethodInfoStoreGeneric_SetUpdate_Public_Static_T_T_UpdateType_Boolean_0<T>
		{
			// Token: 0x04000628 RID: 1576
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetUpdate_Public_Static_T_T_UpdateType_Boolean_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C8 RID: 200
		private sealed class MethodInfoStoreGeneric_OnStart_Public_Static_T_T_TweenCallback_0<T>
		{
			// Token: 0x04000629 RID: 1577
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_OnStart_Public_Static_T_T_TweenCallback_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000C9 RID: 201
		private sealed class MethodInfoStoreGeneric_OnPlay_Public_Static_T_T_TweenCallback_0<T>
		{
			// Token: 0x0400062A RID: 1578
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_OnPlay_Public_Static_T_T_TweenCallback_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000CA RID: 202
		private sealed class MethodInfoStoreGeneric_OnPause_Public_Static_T_T_TweenCallback_0<T>
		{
			// Token: 0x0400062B RID: 1579
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_OnPause_Public_Static_T_T_TweenCallback_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000CB RID: 203
		private sealed class MethodInfoStoreGeneric_OnRewind_Public_Static_T_T_TweenCallback_0<T>
		{
			// Token: 0x0400062C RID: 1580
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_OnRewind_Public_Static_T_T_TweenCallback_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000CC RID: 204
		private sealed class MethodInfoStoreGeneric_OnUpdate_Public_Static_T_T_TweenCallback_0<T>
		{
			// Token: 0x0400062D RID: 1581
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_OnUpdate_Public_Static_T_T_TweenCallback_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000CD RID: 205
		private sealed class MethodInfoStoreGeneric_OnStepComplete_Public_Static_T_T_TweenCallback_0<T>
		{
			// Token: 0x0400062E RID: 1582
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_OnStepComplete_Public_Static_T_T_TweenCallback_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000CE RID: 206
		private sealed class MethodInfoStoreGeneric_OnComplete_Public_Static_T_T_TweenCallback_0<T>
		{
			// Token: 0x0400062F RID: 1583
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_OnComplete_Public_Static_T_T_TweenCallback_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000CF RID: 207
		private sealed class MethodInfoStoreGeneric_OnKill_Public_Static_T_T_TweenCallback_0<T>
		{
			// Token: 0x04000630 RID: 1584
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_OnKill_Public_Static_T_T_TweenCallback_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D0 RID: 208
		private sealed class MethodInfoStoreGeneric_OnWaypointChange_Public_Static_T_T_TweenCallback_1_Int32_0<T>
		{
			// Token: 0x04000631 RID: 1585
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_OnWaypointChange_Public_Static_T_T_TweenCallback_1_Int32_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D1 RID: 209
		private sealed class MethodInfoStoreGeneric_SetAs_Public_Static_T_T_Tween_0<T>
		{
			// Token: 0x04000632 RID: 1586
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetAs_Public_Static_T_T_Tween_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D2 RID: 210
		private sealed class MethodInfoStoreGeneric_SetAs_Public_Static_T_T_TweenParams_0<T>
		{
			// Token: 0x04000633 RID: 1587
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetAs_Public_Static_T_T_TweenParams_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D3 RID: 211
		private sealed class MethodInfoStoreGeneric_From_Public_Static_T_T_0<T>
		{
			// Token: 0x04000634 RID: 1588
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_From_Public_Static_T_T_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D4 RID: 212
		private sealed class MethodInfoStoreGeneric_From_Public_Static_T_T_Boolean_0<T>
		{
			// Token: 0x04000635 RID: 1589
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_From_Public_Static_T_T_Boolean_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D5 RID: 213
		private sealed class MethodInfoStoreGeneric_From_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_T2_Boolean_0<T1, T2, TPlugOptions>
		{
			// Token: 0x04000636 RID: 1590
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_From_Public_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_T2_Boolean_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000D6 RID: 214
		private sealed class MethodInfoStoreGeneric_SetDelay_Public_Static_T_T_Single_0<T>
		{
			// Token: 0x04000637 RID: 1591
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetDelay_Public_Static_T_T_Single_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D7 RID: 215
		private sealed class MethodInfoStoreGeneric_SetRelative_Public_Static_T_T_0<T>
		{
			// Token: 0x04000638 RID: 1592
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetRelative_Public_Static_T_T_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D8 RID: 216
		private sealed class MethodInfoStoreGeneric_SetRelative_Public_Static_T_T_Boolean_0<T>
		{
			// Token: 0x04000639 RID: 1593
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetRelative_Public_Static_T_T_Boolean_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D9 RID: 217
		private sealed class MethodInfoStoreGeneric_SetSpeedBased_Public_Static_T_T_0<T>
		{
			// Token: 0x0400063A RID: 1594
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetSpeedBased_Public_Static_T_T_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000DA RID: 218
		private sealed class MethodInfoStoreGeneric_SetSpeedBased_Public_Static_T_T_Boolean_0<T>
		{
			// Token: 0x0400063B RID: 1595
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenSettingsExtensions.NativeMethodInfoPtr_SetSpeedBased_Public_Static_T_T_Boolean_0, Il2CppClassPointerStore<TweenSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
