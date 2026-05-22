using System;
using Il2CppDG.Tweening.Core.Enums;
using Il2CppDG.Tweening.Plugins.Core;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppDG.Tweening.Core
{
	// Token: 0x02000054 RID: 84
	public class TweenerCore<T1, T2, TPlugOptions> : Tweener where TPlugOptions : new()
	{
		// Token: 0x06000576 RID: 1398 RVA: 0x0001E1CC File Offset: 0x0001C3CC
		// Note: this type is marked as 'beforefieldinit'.
		static TweenerCore()
		{
			Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core", "TweenerCore`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr);
			TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_startValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, "startValue");
			TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_endValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, "endValue");
			TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_changeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, "changeValue");
			TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_plugOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, "plugOptions");
			TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_getter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, "getter");
			TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_setter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, "setter");
			TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_tweenPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, "tweenPlugin");
			TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr__TxtCantChangeSequencedValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, "_TxtCantChangeSequencedValues");
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664303);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeStartValue_Public_Virtual_Tweener_Object_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664304);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeEndValue_Public_Virtual_Tweener_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664305);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeEndValue_Public_Virtual_Tweener_Object_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664306);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeValues_Public_Virtual_Tweener_Object_Object_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664307);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeStartValue_Public_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664308);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeEndValue_Public_TweenerCore_3_T1_T2_TPlugOptions_T2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664309);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeEndValue_Public_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664310);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeValues_Public_TweenerCore_3_T1_T2_TPlugOptions_T2_T2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664311);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_SetFrom_Internal_Virtual_Tweener_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664312);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_SetFrom_Internal_Tweener_T2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664313);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_Reset_Internal_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664314);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_Validate_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664315);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_UpdateDelay_Internal_Virtual_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664316);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_Startup_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664317);
			TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ApplyTween_Internal_Virtual_Boolean_Single_Int32_Int32_Boolean_UpdateMode_UpdateNotice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr, 100664318);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0001E43C File Offset: 0x0001C63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125922, XrefRangeEnd = 125929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TweenerCore()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TweenerCore<T1, T2, TPlugOptions>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0001E478 File Offset: 0x0001C678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125929, XrefRangeEnd = 125962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Tweener ChangeStartValue(Object newStartValue, float newDuration = -1f)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeStartValue_Public_Virtual_Tweener_Object_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x0001E4E4 File Offset: 0x0001C6E4
		[CallerCount(0)]
		public unsafe override Tweener ChangeEndValue(Object newEndValue, bool snapStartValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeEndValue_Public_Virtual_Tweener_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0001E550 File Offset: 0x0001C750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125962, XrefRangeEnd = 125970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Tweener ChangeEndValue(Object newEndValue, float newDuration = -1f, bool snapStartValue = false)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeEndValue_Public_Virtual_Tweener_Object_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0001E5C8 File Offset: 0x0001C7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125970, XrefRangeEnd = 125980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Tweener ChangeValues(Object newStartValue, Object newEndValue, float newDuration = -1f)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeValues_Public_Virtual_Tweener_Object_Object_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0001E644 File Offset: 0x0001C844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125980, XrefRangeEnd = 125986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TweenerCore<T1, T2, TPlugOptions> ChangeStartValue(T2 newStartValue, float newDuration = -1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T2 ptr4;
				if (!typeof(T2).IsValueType)
				{
					T2 t = newStartValue;
					if (!(t is string))
					{
						ref T2 ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref newStartValue;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeStartValue_Public_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<T1, T2, TPlugOptions>>(intPtr3) : null;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0001E6F0 File Offset: 0x0001C8F0
		[CallerCount(0)]
		public unsafe TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, bool snapStartValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T2 ptr4;
				if (!typeof(T2).IsValueType)
				{
					T2 t = newEndValue;
					if (!(t is string))
					{
						ref T2 ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref newEndValue;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapStartValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeEndValue_Public_TweenerCore_3_T1_T2_TPlugOptions_T2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<T1, T2, TPlugOptions>>(intPtr3) : null;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0001E79C File Offset: 0x0001C99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125986, XrefRangeEnd = 125992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, float newDuration = -1f, bool snapStartValue = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T2 ptr4;
				if (!typeof(T2).IsValueType)
				{
					T2 t = newEndValue;
					if (!(t is string))
					{
						ref T2 ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref newEndValue;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDuration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapStartValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeEndValue_Public_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<T1, T2, TPlugOptions>>(intPtr3) : null;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0001E854 File Offset: 0x0001CA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125992, XrefRangeEnd = 125998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TweenerCore<T1, T2, TPlugOptions> ChangeValues(T2 newStartValue, T2 newEndValue, float newDuration = -1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T2 ptr4;
				if (!typeof(T2).IsValueType)
				{
					T2 t = newStartValue;
					if (!(t is string))
					{
						ref T2 ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref newStartValue;
				}
				*ptr2 = ref ptr4;
			}
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T2 ptr7;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = newEndValue;
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
				ptr7 = ref newEndValue;
			}
			*ptr5 = ref ptr7;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ChangeValues_Public_TweenerCore_3_T1_T2_TPlugOptions_T2_T2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<T1, T2, TPlugOptions>>(intPtr3) : null;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0001E95C File Offset: 0x0001CB5C
		[CallerCount(0)]
		public unsafe override Tweener SetFrom(bool relative)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref relative;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_SetFrom_Internal_Virtual_Tweener_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
			}
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0001E9B4 File Offset: 0x0001CBB4
		[CallerCount(0)]
		public unsafe Tweener SetFrom(T2 fromValue, bool setImmediately)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T2 ptr4;
				if (!typeof(T2).IsValueType)
				{
					T2 t = fromValue;
					if (!(t is string))
					{
						ref T2 ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref fromValue;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setImmediately;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_SetFrom_Internal_Tweener_T2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0001EA60 File Offset: 0x0001CC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125998, XrefRangeEnd = 125999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_Reset_Internal_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0001EA94 File Offset: 0x0001CC94
		[CallerCount(0)]
		public unsafe override bool Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_Validate_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0001EADC File Offset: 0x0001CCDC
		[CallerCount(0)]
		public unsafe override float UpdateDelay(float elapsed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elapsed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_UpdateDelay_Internal_Virtual_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0001EB30 File Offset: 0x0001CD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125999, XrefRangeEnd = 126007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Startup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_Startup_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0001EB78 File Offset: 0x0001CD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126007, XrefRangeEnd = 126013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref prevPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevCompletedLoops;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newCompletedSteps;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useInversePosition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateNotice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TweenerCore<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ApplyTween_Internal_Virtual_Boolean_Single_Int32_Int32_Boolean_UpdateMode_UpdateNotice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00003D0A File Offset: 0x00001F0A
		public TweenerCore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x0001EC14 File Offset: 0x0001CE14
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x0001EC3C File Offset: 0x0001CE3C
		public unsafe T2 startValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_startValue);
				return IL2CPP.PointerToValueGeneric<T2>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_startValue);
				Type typeFromHandle = typeof(T2);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x0001ECE4 File Offset: 0x0001CEE4
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x0001ED0C File Offset: 0x0001CF0C
		public unsafe T2 endValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_endValue);
				return IL2CPP.PointerToValueGeneric<T2>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_endValue);
				Type typeFromHandle = typeof(T2);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x0001EDB4 File Offset: 0x0001CFB4
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x0001EDDC File Offset: 0x0001CFDC
		public unsafe T2 changeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_changeValue);
				return IL2CPP.PointerToValueGeneric<T2>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_changeValue);
				Type typeFromHandle = typeof(T2);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x0001EE84 File Offset: 0x0001D084
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x0001EEAC File Offset: 0x0001D0AC
		public unsafe TPlugOptions plugOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_plugOptions);
				return IL2CPP.PointerToValueGeneric<TPlugOptions>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_plugOptions);
				Type typeFromHandle = typeof(TPlugOptions);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x0001EF54 File Offset: 0x0001D154
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x00003D13 File Offset: 0x00001F13
		public unsafe DOGetter<T1> getter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_getter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DOGetter<T1>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_getter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x0001EF84 File Offset: 0x0001D184
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x00003D32 File Offset: 0x00001F32
		public unsafe DOSetter<T1> setter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_setter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DOSetter<T1>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_setter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x0001EFB4 File Offset: 0x0001D1B4
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x00003D51 File Offset: 0x00001F51
		public unsafe ABSTweenPlugin<T1, T2, TPlugOptions> tweenPlugin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_tweenPlugin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ABSTweenPlugin<T1, T2, TPlugOptions>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr_tweenPlugin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x0001EFE4 File Offset: 0x0001D1E4
		// (set) Token: 0x06000597 RID: 1431 RVA: 0x00003D70 File Offset: 0x00001F70
		public unsafe static string _TxtCantChangeSequencedValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr__TxtCantChangeSequencedValues, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenerCore<T1, T2, TPlugOptions>.NativeFieldInfoPtr__TxtCantChangeSequencedValues, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeFieldInfoPtr_startValue;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeFieldInfoPtr_endValue;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeFieldInfoPtr_changeValue;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeFieldInfoPtr_plugOptions;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeFieldInfoPtr_getter;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeFieldInfoPtr_setter;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeFieldInfoPtr_tweenPlugin;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeFieldInfoPtr__TxtCantChangeSequencedValues;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_ChangeStartValue_Public_Virtual_Tweener_Object_Single_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_ChangeEndValue_Public_Virtual_Tweener_Object_Boolean_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr_ChangeEndValue_Public_Virtual_Tweener_Object_Single_Boolean_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_ChangeValues_Public_Virtual_Tweener_Object_Object_Single_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr_ChangeStartValue_Public_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_0;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_ChangeEndValue_Public_TweenerCore_3_T1_T2_TPlugOptions_T2_Boolean_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_ChangeEndValue_Public_TweenerCore_3_T1_T2_TPlugOptions_T2_Single_Boolean_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_ChangeValues_Public_TweenerCore_3_T1_T2_TPlugOptions_T2_T2_Single_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_SetFrom_Internal_Virtual_Tweener_Boolean_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_SetFrom_Internal_Tweener_T2_Boolean_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Virtual_Final_Void_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Internal_Virtual_Boolean_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDelay_Internal_Virtual_Single_Single_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_Startup_Internal_Virtual_Boolean_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr_ApplyTween_Internal_Virtual_Boolean_Single_Int32_Int32_Boolean_UpdateMode_UpdateNotice_0;
	}
}
