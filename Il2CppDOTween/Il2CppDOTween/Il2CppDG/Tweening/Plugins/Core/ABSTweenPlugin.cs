using System;
using Il2CppDG.Tweening.Core;
using Il2CppDG.Tweening.Core.Enums;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppDG.Tweening.Plugins.Core
{
	// Token: 0x0200003F RID: 63
	public class ABSTweenPlugin<T1, T2, TPlugOptions> : Object where TPlugOptions : new()
	{
		// Token: 0x060003AF RID: 943 RVA: 0x0001849C File Offset: 0x0001669C
		// Note: this type is marked as 'beforefieldinit'.
		static ABSTweenPlugin()
		{
			Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Core", "ABSTweenPlugin`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr);
			ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr, 100664108);
			ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_SetFrom_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr, 100664109);
			ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_SetFrom_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_T2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr, 100664110);
			ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ConvertToStartValue_Public_Abstract_Virtual_New_T2_TweenerCore_3_T1_T2_TPlugOptions_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr, 100664111);
			ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_SetRelativeEndValue_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr, 100664112);
			ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_SetChangeValue_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr, 100664113);
			ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Abstract_Virtual_New_Single_TPlugOptions_Single_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr, 100664114);
			ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_EvaluateAndApply_Public_Abstract_Virtual_New_Void_TPlugOptions_Tween_Boolean_DOGetter_1_T1_DOSetter_1_T1_Single_T2_T2_Single_Boolean_UpdateNotice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr, 100664115);
			ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr, 100664116);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x000185E0 File Offset: 0x000167E0
		[CallerCount(0)]
		public unsafe virtual void Reset(TweenerCore<T1, T2, TPlugOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00018630 File Offset: 0x00016830
		[CallerCount(0)]
		public unsafe virtual void SetFrom(TweenerCore<T1, T2, TPlugOptions> t, bool isRelative)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRelative;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_SetFrom_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0001868C File Offset: 0x0001688C
		[CallerCount(0)]
		public unsafe virtual void SetFrom(TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_SetFrom_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_T2_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00018744 File Offset: 0x00016944
		[CallerCount(0)]
		public unsafe virtual T2 ConvertToStartValue(TweenerCore<T1, T2, TPlugOptions> t, T1 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T1 ptr4;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = value;
				if (!(t2 is string))
				{
					ref T1 ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
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
				ptr4 = ref value;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ConvertToStartValue_Public_Abstract_Virtual_New_T2_TweenerCore_3_T1_T2_TPlugOptions_T1_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T2>(intPtr, false, true);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x000187F8 File Offset: 0x000169F8
		[CallerCount(0)]
		public unsafe virtual void SetRelativeEndValue(TweenerCore<T1, T2, TPlugOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_SetRelativeEndValue_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00018848 File Offset: 0x00016A48
		[CallerCount(0)]
		public unsafe virtual void SetChangeValue(TweenerCore<T1, T2, TPlugOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_SetChangeValue_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00018898 File Offset: 0x00016A98
		[CallerCount(0)]
		public unsafe virtual float GetSpeedBasedDuration(TPlugOptions options, float unitsXSecond, T2 changeValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref TPlugOptions ptr4;
				if (!typeof(TPlugOptions).IsValueType)
				{
					TPlugOptions tplugOptions = options;
					if (!(tplugOptions is string))
					{
						ref TPlugOptions ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tplugOptions as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(tplugOptions as string);
					}
				}
				else
				{
					ptr4 = ref options;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unitsXSecond;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T2 ptr7;
			if (!typeof(T2).IsValueType)
			{
				T2 t = changeValue;
				if (!(t is string))
				{
					ref T2 ptr6 = (ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr6) != null)
					{
						ptr7 = ref ptr6;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr6)))
						{
							ptr7 = IL2CPP.il2cpp_object_unbox(ref ptr6);
						}
					}
				}
				else
				{
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr7 = ref changeValue;
			}
			*ptr5 = ref ptr7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Abstract_Virtual_New_Single_TPlugOptions_Single_T2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x000189A8 File Offset: 0x00016BA8
		[CallerCount(0)]
		public unsafe virtual void EvaluateAndApply(TPlugOptions options, Tween t, bool isRelative, DOGetter<T1> getter, DOSetter<T1> setter, float elapsed, T2 startValue, T2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref TPlugOptions ptr4;
				if (!typeof(TPlugOptions).IsValueType)
				{
					TPlugOptions tplugOptions = options;
					if (!(tplugOptions is string))
					{
						ref TPlugOptions ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tplugOptions as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(tplugOptions as string);
					}
				}
				else
				{
					ptr4 = ref options;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRelative;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getter);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsed;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T2 ptr7;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = startValue;
				if (!(t2 is string))
				{
					ref T2 ptr6 = (ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
					if ((ref ptr6) != null)
					{
						ptr7 = ref ptr6;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr6)))
						{
							ptr7 = IL2CPP.il2cpp_object_unbox(ref ptr6);
						}
					}
				}
				else
				{
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
				}
			}
			else
			{
				ptr7 = ref startValue;
			}
			*ptr5 = ref ptr7;
			IntPtr* ptr8 = ptr + checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T2 ptr10;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = changeValue;
				if (!(t3 is string))
				{
					ref T2 ptr9 = (ptr10 = IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
					if ((ref ptr9) != null)
					{
						ptr10 = ref ptr9;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr9)))
						{
							ptr10 = IL2CPP.il2cpp_object_unbox(ref ptr9);
						}
					}
				}
				else
				{
					ptr10 = IL2CPP.ManagedStringToIl2Cpp(t3 as string);
				}
			}
			else
			{
				ptr10 = ref changeValue;
			}
			*ptr8 = ref ptr10;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usingInversePosition;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateNotice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_EvaluateAndApply_Public_Abstract_Virtual_New_Void_TPlugOptions_Tween_Boolean_DOGetter_1_T1_DOSetter_1_T1_Single_T2_T2_Single_Boolean_UpdateNotice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00018B80 File Offset: 0x00016D80
		[CallerCount(0)]
		public unsafe ABSTweenPlugin()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000311C File Offset: 0x0000131C
		public ABSTweenPlugin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_SetFrom_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_Boolean_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_SetFrom_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_T2_Boolean_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToStartValue_Public_Abstract_Virtual_New_T2_TweenerCore_3_T1_T2_TPlugOptions_T1_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_SetRelativeEndValue_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_SetChangeValue_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Abstract_Virtual_New_Single_TPlugOptions_Single_T2_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateAndApply_Public_Abstract_Virtual_New_Void_TPlugOptions_Tween_Boolean_DOGetter_1_T1_DOSetter_1_T1_Single_T2_T2_Single_Boolean_UpdateNotice_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
