using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x02000210 RID: 528
	public sealed class ValueWatcher<T> : ValueWatcher
	{
		// Token: 0x060036D1 RID: 14033 RVA: 0x0010F180 File Offset: 0x0010D380
		// Note: this type is marked as 'beforefieldinit'.
		static ValueWatcher()
		{
			Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "ValueWatcher`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr);
			ValueWatcher<T>.NativeFieldInfoPtr_swPhiFspKTFFmXiaFiXFbbjtzUt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr, "swPhiFspKTFFmXiaFiXFbbjtzUt");
			ValueWatcher<T>.NativeFieldInfoPtr_KViLsZeRmpCXegAnzzXviaybtUt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr, "KViLsZeRmpCXegAnzzXviaybtUt");
			ValueWatcher<T>.NativeFieldInfoPtr_cmXEZIVOUSgwaTxmjyvuuJloYvz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr, "cmXEZIVOUSgwaTxmjyvuuJloYvz");
			ValueWatcher<T>.NativeFieldInfoPtr_sTDAMuKAIGwcneqVAVaXVywbVSdG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr, "sTDAMuKAIGwcneqVAVaXVywbVSdG");
			ValueWatcher<T>.NativeFieldInfoPtr_TreTQUVhkjHdtjTvdDldaYUnVgyz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr, "TreTQUVhkjHdtjTvdDldaYUnVgyz");
			ValueWatcher<T>.NativeFieldInfoPtr_JIAHmXVZrcdeAWOJhZqYNHvtsqp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr, "JIAHmXVZrcdeAWOJhZqYNHvtsqp");
			ValueWatcher<T>.NativeMethodInfoPtr_get_changed_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr, 100676802);
			ValueWatcher<T>.NativeMethodInfoPtr_get_autoTriggerEvent_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr, 100676803);
			ValueWatcher<T>.NativeMethodInfoPtr_set_autoTriggerEvent_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr, 100676804);
			ValueWatcher<T>.NativeMethodInfoPtr_get_getValueDelegate_Public_get_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr, 100676805);
			ValueWatcher<T>.NativeMethodInfoPtr_set_getValueDelegate_Public_set_Void_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr, 100676806);
			ValueWatcher<T>.NativeMethodInfoPtr_get_value_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr, 100676807);
			ValueWatcher<T>.NativeMethodInfoPtr_add_ChangedEvent_Public_add_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr, 100676808);
			ValueWatcher<T>.NativeMethodInfoPtr_remove_ChangedEvent_Public_rem_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr, 100676809);
			ValueWatcher<T>.NativeMethodInfoPtr__ctor_Public_Void_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr, 100676810);
			ValueWatcher<T>.NativeMethodInfoPtr__ctor_Public_Void_T_Func_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr, 100676811);
			ValueWatcher<T>.NativeMethodInfoPtr_Update_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr, 100676812);
			ValueWatcher<T>.NativeMethodInfoPtr_Use_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr, 100676813);
			ValueWatcher<T>.NativeMethodInfoPtr_TriggerEvent_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr, 100676814);
			ValueWatcher<T>.NativeMethodInfoPtr_Set_Public_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr, 100676815);
			ValueWatcher<T>.NativeMethodInfoPtr_AddEventListener_Public_Virtual_Void_TyGXyaSQkKibFXAQOIezQJzuDUL_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr, 100676816);
			ValueWatcher<T>.NativeMethodInfoPtr_RemoveEventListener_Public_Virtual_Void_TyGXyaSQkKibFXAQOIezQJzuDUL_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr, 100676817);
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x060036D2 RID: 14034 RVA: 0x0010F3A4 File Offset: 0x0010D5A4
		public unsafe override bool changed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueWatcher<T>.NativeMethodInfoPtr_get_changed_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x060036D3 RID: 14035 RVA: 0x0010F3E0 File Offset: 0x0010D5E0
		// (set) Token: 0x060036D4 RID: 14036 RVA: 0x0010F41C File Offset: 0x0010D61C
		public unsafe override bool autoTriggerEvent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueWatcher<T>.NativeMethodInfoPtr_get_autoTriggerEvent_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueWatcher<T>.NativeMethodInfoPtr_set_autoTriggerEvent_Public_Virtual_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x060036D5 RID: 14037 RVA: 0x0010F45C File Offset: 0x0010D65C
		// (set) Token: 0x060036D6 RID: 14038 RVA: 0x0010F49C File Offset: 0x0010D69C
		public unsafe Func<T> getValueDelegate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueWatcher<T>.NativeMethodInfoPtr_get_getValueDelegate_Public_get_Func_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueWatcher<T>.NativeMethodInfoPtr_set_getValueDelegate_Public_set_Void_Func_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x060036D7 RID: 14039 RVA: 0x0010F4E0 File Offset: 0x0010D6E0
		public unsafe T value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueWatcher<T>.NativeMethodInfoPtr_get_value_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x0010F51C File Offset: 0x0010D71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346972, XrefRangeEnd = 346976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ChangedEvent(Action<T> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueWatcher<T>.NativeMethodInfoPtr_add_ChangedEvent_Public_add_Void_Action_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036D9 RID: 14041 RVA: 0x0010F560 File Offset: 0x0010D760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346976, XrefRangeEnd = 346980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ChangedEvent(Action<T> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueWatcher<T>.NativeMethodInfoPtr_remove_ChangedEvent_Public_rem_Void_Action_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036DA RID: 14042 RVA: 0x0010F5A4 File Offset: 0x0010D7A4
		[CallerCount(0)]
		public unsafe ValueWatcher(T initialValue, bool autoTriggerEvent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = initialValue;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
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
					ptr4 = ref initialValue;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoTriggerEvent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueWatcher<T>.NativeMethodInfoPtr__ctor_Public_Void_T_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x0010F648 File Offset: 0x0010D848
		[CallerCount(0)]
		public unsafe ValueWatcher(T initialValue, Func<T> getValueDelegate, bool autoTriggerEvent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueWatcher<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = initialValue;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
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
					ptr4 = ref initialValue;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getValueDelegate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoTriggerEvent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueWatcher<T>.NativeMethodInfoPtr__ctor_Public_Void_T_Func_1_T_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x0010F700 File Offset: 0x0010D900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346980, XrefRangeEnd = 346986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueWatcher<T>.NativeMethodInfoPtr_Update_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x0010F73C File Offset: 0x0010D93C
		[CallerCount(0)]
		public unsafe override bool Use()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueWatcher<T>.NativeMethodInfoPtr_Use_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x0010F778 File Offset: 0x0010D978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346986, XrefRangeEnd = 346992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TriggerEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueWatcher<T>.NativeMethodInfoPtr_TriggerEvent_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x0010F7B4 File Offset: 0x0010D9B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 346999, RefRangeEnd = 347003, XrefRangeStart = 346992, XrefRangeEnd = 346999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Set(T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
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
					ptr4 = ref value;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueWatcher<T>.NativeMethodInfoPtr_Set_Public_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x0010F84C File Offset: 0x0010DA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347003, XrefRangeEnd = 347030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddEventListener(ValueWatcher.TyGXyaSQkKibFXAQOIezQJzuDUL eventType, Delegate listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueWatcher<T>.NativeMethodInfoPtr_AddEventListener_Public_Virtual_Void_TyGXyaSQkKibFXAQOIezQJzuDUL_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x0010F89C File Offset: 0x0010DA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347030, XrefRangeEnd = 347061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RemoveEventListener(ValueWatcher.TyGXyaSQkKibFXAQOIezQJzuDUL eventType, Delegate listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueWatcher<T>.NativeMethodInfoPtr_RemoveEventListener_Public_Virtual_Void_TyGXyaSQkKibFXAQOIezQJzuDUL_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x00012E0A File Offset: 0x0001100A
		public ValueWatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x060036E3 RID: 14051 RVA: 0x0010F8EC File Offset: 0x0010DAEC
		// (set) Token: 0x060036E4 RID: 14052 RVA: 0x00012E13 File Offset: 0x00011013
		public unsafe static IEqualityComparer<T> swPhiFspKTFFmXiaFiXFbbjtzUt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ValueWatcher<T>.NativeFieldInfoPtr_swPhiFspKTFFmXiaFiXFbbjtzUt, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<T>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValueWatcher<T>.NativeFieldInfoPtr_swPhiFspKTFFmXiaFiXFbbjtzUt, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x060036E5 RID: 14053 RVA: 0x0010F914 File Offset: 0x0010DB14
		// (set) Token: 0x060036E6 RID: 14054 RVA: 0x00012E25 File Offset: 0x00011025
		public unsafe bool KViLsZeRmpCXegAnzzXviaybtUt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueWatcher<T>.NativeFieldInfoPtr_KViLsZeRmpCXegAnzzXviaybtUt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueWatcher<T>.NativeFieldInfoPtr_KViLsZeRmpCXegAnzzXviaybtUt)) = value;
			}
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x060036E7 RID: 14055 RVA: 0x0010F93C File Offset: 0x0010DB3C
		// (set) Token: 0x060036E8 RID: 14056 RVA: 0x0010F964 File Offset: 0x0010DB64
		public unsafe T cmXEZIVOUSgwaTxmjyvuuJloYvz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueWatcher<T>.NativeFieldInfoPtr_cmXEZIVOUSgwaTxmjyvuuJloYvz);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueWatcher<T>.NativeFieldInfoPtr_cmXEZIVOUSgwaTxmjyvuuJloYvz);
				Type typeFromHandle = typeof(T);
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

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x060036E9 RID: 14057 RVA: 0x0010FA0C File Offset: 0x0010DC0C
		// (set) Token: 0x060036EA RID: 14058 RVA: 0x00012E40 File Offset: 0x00011040
		public unsafe bool sTDAMuKAIGwcneqVAVaXVywbVSdG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueWatcher<T>.NativeFieldInfoPtr_sTDAMuKAIGwcneqVAVaXVywbVSdG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueWatcher<T>.NativeFieldInfoPtr_sTDAMuKAIGwcneqVAVaXVywbVSdG)) = value;
			}
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x060036EB RID: 14059 RVA: 0x0010FA34 File Offset: 0x0010DC34
		// (set) Token: 0x060036EC RID: 14060 RVA: 0x00012E5B File Offset: 0x0001105B
		public unsafe Func<T> TreTQUVhkjHdtjTvdDldaYUnVgyz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueWatcher<T>.NativeFieldInfoPtr_TreTQUVhkjHdtjTvdDldaYUnVgyz);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueWatcher<T>.NativeFieldInfoPtr_TreTQUVhkjHdtjTvdDldaYUnVgyz), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x060036ED RID: 14061 RVA: 0x0010FA64 File Offset: 0x0010DC64
		// (set) Token: 0x060036EE RID: 14062 RVA: 0x00012E7A File Offset: 0x0001107A
		public unsafe Action<T> JIAHmXVZrcdeAWOJhZqYNHvtsqp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueWatcher<T>.NativeFieldInfoPtr_JIAHmXVZrcdeAWOJhZqYNHvtsqp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueWatcher<T>.NativeFieldInfoPtr_JIAHmXVZrcdeAWOJhZqYNHvtsqp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002E74 RID: 11892
		private static readonly IntPtr NativeFieldInfoPtr_swPhiFspKTFFmXiaFiXFbbjtzUt;

		// Token: 0x04002E75 RID: 11893
		private static readonly IntPtr NativeFieldInfoPtr_KViLsZeRmpCXegAnzzXviaybtUt;

		// Token: 0x04002E76 RID: 11894
		private static readonly IntPtr NativeFieldInfoPtr_cmXEZIVOUSgwaTxmjyvuuJloYvz;

		// Token: 0x04002E77 RID: 11895
		private static readonly IntPtr NativeFieldInfoPtr_sTDAMuKAIGwcneqVAVaXVywbVSdG;

		// Token: 0x04002E78 RID: 11896
		private static readonly IntPtr NativeFieldInfoPtr_TreTQUVhkjHdtjTvdDldaYUnVgyz;

		// Token: 0x04002E79 RID: 11897
		private static readonly IntPtr NativeFieldInfoPtr_JIAHmXVZrcdeAWOJhZqYNHvtsqp;

		// Token: 0x04002E7A RID: 11898
		private static readonly IntPtr NativeMethodInfoPtr_get_changed_Public_Virtual_get_Boolean_0;

		// Token: 0x04002E7B RID: 11899
		private static readonly IntPtr NativeMethodInfoPtr_get_autoTriggerEvent_Public_Virtual_get_Boolean_0;

		// Token: 0x04002E7C RID: 11900
		private static readonly IntPtr NativeMethodInfoPtr_set_autoTriggerEvent_Public_Virtual_set_Void_Boolean_0;

		// Token: 0x04002E7D RID: 11901
		private static readonly IntPtr NativeMethodInfoPtr_get_getValueDelegate_Public_get_Func_1_T_0;

		// Token: 0x04002E7E RID: 11902
		private static readonly IntPtr NativeMethodInfoPtr_set_getValueDelegate_Public_set_Void_Func_1_T_0;

		// Token: 0x04002E7F RID: 11903
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_T_0;

		// Token: 0x04002E80 RID: 11904
		private static readonly IntPtr NativeMethodInfoPtr_add_ChangedEvent_Public_add_Void_Action_1_T_0;

		// Token: 0x04002E81 RID: 11905
		private static readonly IntPtr NativeMethodInfoPtr_remove_ChangedEvent_Public_rem_Void_Action_1_T_0;

		// Token: 0x04002E82 RID: 11906
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_Boolean_0;

		// Token: 0x04002E83 RID: 11907
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_Func_1_T_Boolean_0;

		// Token: 0x04002E84 RID: 11908
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Boolean_0;

		// Token: 0x04002E85 RID: 11909
		private static readonly IntPtr NativeMethodInfoPtr_Use_Public_Virtual_Boolean_0;

		// Token: 0x04002E86 RID: 11910
		private static readonly IntPtr NativeMethodInfoPtr_TriggerEvent_Public_Virtual_Boolean_0;

		// Token: 0x04002E87 RID: 11911
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Boolean_T_0;

		// Token: 0x04002E88 RID: 11912
		private static readonly IntPtr NativeMethodInfoPtr_AddEventListener_Public_Virtual_Void_TyGXyaSQkKibFXAQOIezQJzuDUL_Delegate_0;

		// Token: 0x04002E89 RID: 11913
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEventListener_Public_Virtual_Void_TyGXyaSQkKibFXAQOIezQJzuDUL_Delegate_0;
	}
}
