using System;
using Il2CppDG.Tweening.Core;
using Il2CppDG.Tweening.Plugins.Core;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppDG.Tweening
{
	// Token: 0x0200001A RID: 26
	public class Tweener : Tween
	{
		// Token: 0x06000260 RID: 608 RVA: 0x0001193C File Offset: 0x0000FB3C
		// Note: this type is marked as 'beforefieldinit'.
		static Tweener()
		{
			Il2CppClassPointerStore<Tweener>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening", "Tweener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tweener>.NativeClassPtr);
			Tweener.NativeFieldInfoPtr_hasManuallySetStartValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tweener>.NativeClassPtr, "hasManuallySetStartValue");
			Tweener.NativeFieldInfoPtr_isFromAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tweener>.NativeClassPtr, "isFromAllowed");
			Tweener.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663913);
			Tweener.NativeMethodInfoPtr_ChangeStartValue_Public_Abstract_Virtual_New_Tweener_Object_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663914);
			Tweener.NativeMethodInfoPtr_ChangeEndValue_Public_Abstract_Virtual_New_Tweener_Object_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663915);
			Tweener.NativeMethodInfoPtr_ChangeEndValue_Public_Abstract_Virtual_New_Tweener_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663916);
			Tweener.NativeMethodInfoPtr_ChangeValues_Public_Abstract_Virtual_New_Tweener_Object_Object_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663917);
			Tweener.NativeMethodInfoPtr_SetFrom_Internal_Abstract_Virtual_New_Tweener_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663918);
			Tweener.NativeMethodInfoPtr_Setup_Internal_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_ABSTweenPlugin_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663919);
			Tweener.NativeMethodInfoPtr_DoUpdateDelay_Internal_Static_Single_TweenerCore_3_T1_T2_TPlugOptions_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663920);
			Tweener.NativeMethodInfoPtr_DoStartup_Internal_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663921);
			Tweener.NativeMethodInfoPtr_DoChangeStartValue_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663922);
			Tweener.NativeMethodInfoPtr_DoChangeEndValue_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663923);
			Tweener.NativeMethodInfoPtr_DoChangeValues_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_T2_T2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663924);
			Tweener.NativeMethodInfoPtr_DOStartupSpecials_Private_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663925);
			Tweener.NativeMethodInfoPtr_DOStartupDurationBased_Private_Static_Void_TweenerCore_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tweener>.NativeClassPtr, 100663926);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00011AAC File Offset: 0x0000FCAC
		[CallerCount(0)]
		public unsafe Tweener()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tweener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tweener.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00011AE8 File Offset: 0x0000FCE8
		[CallerCount(0)]
		public unsafe virtual Tweener ChangeStartValue(Object newStartValue, float newDuration = -1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newStartValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tweener.NativeMethodInfoPtr_ChangeStartValue_Public_Abstract_Virtual_New_Tweener_Object_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00011B54 File Offset: 0x0000FD54
		[CallerCount(0)]
		public unsafe virtual Tweener ChangeEndValue(Object newEndValue, float newDuration = -1f, bool snapStartValue = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newEndValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDuration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapStartValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tweener.NativeMethodInfoPtr_ChangeEndValue_Public_Abstract_Virtual_New_Tweener_Object_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00011BCC File Offset: 0x0000FDCC
		[CallerCount(0)]
		public unsafe virtual Tweener ChangeEndValue(Object newEndValue, bool snapStartValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newEndValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapStartValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tweener.NativeMethodInfoPtr_ChangeEndValue_Public_Abstract_Virtual_New_Tweener_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00011C38 File Offset: 0x0000FE38
		[CallerCount(0)]
		public unsafe virtual Tweener ChangeValues(Object newStartValue, Object newEndValue, float newDuration = -1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newStartValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newEndValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tweener.NativeMethodInfoPtr_ChangeValues_Public_Abstract_Virtual_New_Tweener_Object_Object_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00011CB4 File Offset: 0x0000FEB4
		[CallerCount(0)]
		public unsafe virtual Tweener SetFrom(bool relative)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref relative;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tweener.NativeMethodInfoPtr_SetFrom_Internal_Abstract_Virtual_New_Tweener_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00011D0C File Offset: 0x0000FF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122245, XrefRangeEnd = 122250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Setup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null) where TPlugOptions : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T2 ptr4;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = endValue;
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
				ptr4 = ref endValue;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(plugin);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tweener.MethodInfoStoreGeneric_Setup_Internal_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_ABSTweenPlugin_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00011DF0 File Offset: 0x0000FFF0
		[CallerCount(0)]
		public unsafe static float DoUpdateDelay<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, float elapsed) where TPlugOptions : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tweener.MethodInfoStoreGeneric_DoUpdateDelay_Internal_Static_Single_TweenerCore_3_T1_T2_TPlugOptions_Single_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00011E40 File Offset: 0x00010040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122250, XrefRangeEnd = 122254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoStartup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tweener.MethodInfoStoreGeneric_DoStartup_Internal_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00011E84 File Offset: 0x00010084
		[CallerCount(0)]
		public unsafe static TweenerCore<T1, T2, TPlugOptions> DoChangeStartValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, float newDuration) where TPlugOptions : new()
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
				T2 t2 = newStartValue;
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
				ptr4 = ref newStartValue;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tweener.MethodInfoStoreGeneric_DoChangeStartValue_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<T1, T2, TPlugOptions>>(intPtr3) : null;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00011F34 File Offset: 0x00010134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122254, XrefRangeEnd = 122259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<T1, T2, TPlugOptions> DoChangeEndValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newEndValue, float newDuration, bool snapStartValue) where TPlugOptions : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T2 ptr4;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = newEndValue;
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
				ptr4 = ref newEndValue;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDuration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapStartValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tweener.MethodInfoStoreGeneric_DoChangeEndValue_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_Boolean_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<T1, T2, TPlugOptions>>(intPtr3) : null;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00011FF4 File Offset: 0x000101F4
		[CallerCount(0)]
		public unsafe static TweenerCore<T1, T2, TPlugOptions> DoChangeValues<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, T2 newEndValue, float newDuration) where TPlugOptions : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T2 ptr4;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = newStartValue;
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
				ptr4 = ref newStartValue;
			}
			*ptr2 = ref ptr4;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T2 ptr7;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = newEndValue;
				if (!(t3 is string))
				{
					ref T2 ptr6 = (ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
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
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(t3 as string);
				}
			}
			else
			{
				ptr7 = ref newEndValue;
			}
			*ptr5 = ref ptr7;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tweener.MethodInfoStoreGeneric_DoChangeValues_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_T2_T2_Single_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<T1, T2, TPlugOptions>>(intPtr3) : null;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00012100 File Offset: 0x00010300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122259, XrefRangeEnd = 122279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DOStartupSpecials<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tweener.MethodInfoStoreGeneric_DOStartupSpecials_Private_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00012144 File Offset: 0x00010344
		[CallerCount(0)]
		public unsafe static void DOStartupDurationBased<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tweener.MethodInfoStoreGeneric_DOStartupDurationBased_Private_Static_Void_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002B6F File Offset: 0x00000D6F
		public Tweener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0001217C File Offset: 0x0001037C
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00002B78 File Offset: 0x00000D78
		public unsafe bool hasManuallySetStartValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tweener.NativeFieldInfoPtr_hasManuallySetStartValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tweener.NativeFieldInfoPtr_hasManuallySetStartValue)) = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000272 RID: 626 RVA: 0x000121A4 File Offset: 0x000103A4
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00002B93 File Offset: 0x00000D93
		public unsafe bool isFromAllowed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tweener.NativeFieldInfoPtr_isFromAllowed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tweener.NativeFieldInfoPtr_isFromAllowed)) = value;
			}
		}

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeFieldInfoPtr_hasManuallySetStartValue;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeFieldInfoPtr_isFromAllowed;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_ChangeStartValue_Public_Abstract_Virtual_New_Tweener_Object_Single_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_ChangeEndValue_Public_Abstract_Virtual_New_Tweener_Object_Single_Boolean_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_ChangeEndValue_Public_Abstract_Virtual_New_Tweener_Object_Boolean_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_ChangeValues_Public_Abstract_Virtual_New_Tweener_Object_Object_Single_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_SetFrom_Internal_Abstract_Virtual_New_Tweener_Boolean_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Internal_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_ABSTweenPlugin_3_T1_T2_TPlugOptions_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_DoUpdateDelay_Internal_Static_Single_TweenerCore_3_T1_T2_TPlugOptions_Single_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_DoStartup_Internal_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_DoChangeStartValue_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_DoChangeEndValue_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_Boolean_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_DoChangeValues_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_T2_T2_Single_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_DOStartupSpecials_Private_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_DOStartupDurationBased_Private_Static_Void_TweenerCore_3_T1_T2_TPlugOptions_0;

		// Token: 0x020000DC RID: 220
		private sealed class MethodInfoStoreGeneric_Setup_Internal_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_ABSTweenPlugin_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>
		{
			// Token: 0x0400063D RID: 1597
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Tweener.NativeMethodInfoPtr_Setup_Internal_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_DOGetter_1_T1_DOSetter_1_T1_T2_Single_ABSTweenPlugin_3_T1_T2_TPlugOptions_0, Il2CppClassPointerStore<Tweener>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000DD RID: 221
		private sealed class MethodInfoStoreGeneric_DoUpdateDelay_Internal_Static_Single_TweenerCore_3_T1_T2_TPlugOptions_Single_0<T1, T2, TPlugOptions>
		{
			// Token: 0x0400063E RID: 1598
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Tweener.NativeMethodInfoPtr_DoUpdateDelay_Internal_Static_Single_TweenerCore_3_T1_T2_TPlugOptions_Single_0, Il2CppClassPointerStore<Tweener>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000DE RID: 222
		private sealed class MethodInfoStoreGeneric_DoStartup_Internal_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>
		{
			// Token: 0x0400063F RID: 1599
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Tweener.NativeMethodInfoPtr_DoStartup_Internal_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_0, Il2CppClassPointerStore<Tweener>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000DF RID: 223
		private sealed class MethodInfoStoreGeneric_DoChangeStartValue_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_0<T1, T2, TPlugOptions>
		{
			// Token: 0x04000640 RID: 1600
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Tweener.NativeMethodInfoPtr_DoChangeStartValue_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_0, Il2CppClassPointerStore<Tweener>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000E0 RID: 224
		private sealed class MethodInfoStoreGeneric_DoChangeEndValue_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_Boolean_0<T1, T2, TPlugOptions>
		{
			// Token: 0x04000641 RID: 1601
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Tweener.NativeMethodInfoPtr_DoChangeEndValue_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_Boolean_0, Il2CppClassPointerStore<Tweener>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000E1 RID: 225
		private sealed class MethodInfoStoreGeneric_DoChangeValues_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_T2_T2_Single_0<T1, T2, TPlugOptions>
		{
			// Token: 0x04000642 RID: 1602
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Tweener.NativeMethodInfoPtr_DoChangeValues_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_TweenerCore_3_T1_T2_TPlugOptions_T2_T2_Single_0, Il2CppClassPointerStore<Tweener>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000E2 RID: 226
		private sealed class MethodInfoStoreGeneric_DOStartupSpecials_Private_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>
		{
			// Token: 0x04000643 RID: 1603
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Tweener.NativeMethodInfoPtr_DOStartupSpecials_Private_Static_Boolean_TweenerCore_3_T1_T2_TPlugOptions_0, Il2CppClassPointerStore<Tweener>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000E3 RID: 227
		private sealed class MethodInfoStoreGeneric_DOStartupDurationBased_Private_Static_Void_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>
		{
			// Token: 0x04000644 RID: 1604
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Tweener.NativeMethodInfoPtr_DOStartupDurationBased_Private_Static_Void_TweenerCore_3_T1_T2_TPlugOptions_0, Il2CppClassPointerStore<Tweener>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}
	}
}
