using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001E6 RID: 486
	public sealed class SafeAction<T, T2> : SafeDelegate<Action<T, T2>>
	{
		// Token: 0x06003188 RID: 12680 RVA: 0x000F5EF8 File Offset: 0x000F40F8
		// Note: this type is marked as 'beforefieldinit'.
		static SafeAction()
		{
			Il2CppClassPointerStore<SafeAction<T, T2>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "SafeAction`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeAction<T, T2>>.NativeClassPtr);
			SafeAction<T, T2>.NativeFieldInfoPtr_gWfsLHmVjBrPGPYzUOZDaKhbKHa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeAction<T, T2>>.NativeClassPtr, "gWfsLHmVjBrPGPYzUOZDaKhbKHa");
			SafeAction<T, T2>.NativeFieldInfoPtr_RhVFaWIPlbqBUFLCAfvUTKyZmzOi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeAction<T, T2>>.NativeClassPtr, "RhVFaWIPlbqBUFLCAfvUTKyZmzOi");
			SafeAction<T, T2>.NativeFieldInfoPtr_gBHYUjlrgPpCcxohnMBNikgNzss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeAction<T, T2>>.NativeClassPtr, "gBHYUjlrgPpCcxohnMBNikgNzss");
			SafeAction<T, T2>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction<T, T2>>.NativeClassPtr, 100675849);
			SafeAction<T, T2>.NativeMethodInfoPtr__ctor_Public_Void_Action_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction<T, T2>>.NativeClassPtr, 100675850);
			SafeAction<T, T2>.NativeMethodInfoPtr__ctor_Protected_Void_SafeAction_2_T_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction<T, T2>>.NativeClassPtr, 100675851);
			SafeAction<T, T2>.NativeMethodInfoPtr_Invoke_Public_Void_T_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction<T, T2>>.NativeClassPtr, 100675852);
			SafeAction<T, T2>.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction<T, T2>>.NativeClassPtr, 100675853);
			SafeAction<T, T2>.NativeMethodInfoPtr_get_invokeDelegate_Private_Static_get_Action_2_Object_Action_2_T_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction<T, T2>>.NativeClassPtr, 100675854);
			SafeAction<T, T2>.NativeMethodInfoPtr_IeDiRNoROqgJggMJIWRwJAkyOMlt_Private_Static_Void_Object_Action_2_T_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction<T, T2>>.NativeClassPtr, 100675855);
			SafeAction<T, T2>.NativeMethodInfoPtr_op_Addition_Public_Static_SafeAction_2_T_T2_SafeAction_2_T_T2_Action_2_T_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction<T, T2>>.NativeClassPtr, 100675856);
			SafeAction<T, T2>.NativeMethodInfoPtr_op_Subtraction_Public_Static_SafeAction_2_T_T2_SafeAction_2_T_T2_Action_2_T_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction<T, T2>>.NativeClassPtr, 100675857);
			SafeAction<T, T2>.NativeMethodInfoPtr_op_Implicit_Public_Static_Action_2_T_T2_SafeAction_2_T_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction<T, T2>>.NativeClassPtr, 100675858);
			SafeAction<T, T2>.NativeMethodInfoPtr_op_Implicit_Public_Static_SafeAction_2_T_T2_Action_2_T_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction<T, T2>>.NativeClassPtr, 100675859);
		}

		// Token: 0x06003189 RID: 12681 RVA: 0x000F6090 File Offset: 0x000F4290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeAction<T, T2>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction<T, T2>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600318A RID: 12682 RVA: 0x000F60CC File Offset: 0x000F42CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeAction(Action<Exception> exceptionHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeAction<T, T2>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionHandler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction<T, T2>.NativeMethodInfoPtr__ctor_Public_Void_Action_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600318B RID: 12683 RVA: 0x000F6118 File Offset: 0x000F4318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeAction(SafeAction<T, T2> source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeAction<T, T2>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction<T, T2>.NativeMethodInfoPtr__ctor_Protected_Void_SafeAction_2_T_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600318C RID: 12684 RVA: 0x000F6164 File Offset: 0x000F4364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337248, XrefRangeEnd = 337251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(T arg0, T2 arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = arg0;
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
					ptr4 = ref arg0;
				}
				*ptr2 = ref ptr4;
			}
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T2 ptr7;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = arg1;
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
				ptr7 = ref arg1;
			}
			*ptr5 = ref ptr7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction<T, T2>.NativeMethodInfoPtr_Invoke_Public_Void_T_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x000F6250 File Offset: 0x000F4450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction<T, T2>.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x0600318E RID: 12686 RVA: 0x000F6290 File Offset: 0x000F4490
		public unsafe static Action<Object, Action<T, T2>> invokeDelegate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction<T, T2>.NativeMethodInfoPtr_get_invokeDelegate_Private_Static_get_Action_2_Object_Action_2_T_T2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<Object, Action<T, T2>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600318F RID: 12687 RVA: 0x000F62C4 File Offset: 0x000F44C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337251, XrefRangeEnd = 337256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IeDiRNoROqgJggMJIWRwJAkyOMlt(Object A_0, Action<T, T2> A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction<T, T2>.NativeMethodInfoPtr_IeDiRNoROqgJggMJIWRwJAkyOMlt_Private_Static_Void_Object_Action_2_T_T2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x000F630C File Offset: 0x000F450C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafeAction<T, T2>operator +(SafeAction<T, T2> eventList, Action<T, T2> listener)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction<T, T2>.NativeMethodInfoPtr_op_Addition_Public_Static_SafeAction_2_T_T2_SafeAction_2_T_T2_Action_2_T_T2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeAction<T, T2>>(intPtr3) : null;
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x000F6364 File Offset: 0x000F4564
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 337229, RefRangeEnd = 337239, XrefRangeStart = 337229, XrefRangeEnd = 337239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafeAction<T, T2>operator -(SafeAction<T, T2> eventList, Action<T, T2> listener)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction<T, T2>.NativeMethodInfoPtr_op_Subtraction_Public_Static_SafeAction_2_T_T2_SafeAction_2_T_T2_Action_2_T_T2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeAction<T, T2>>(intPtr3) : null;
		}

		// Token: 0x06003192 RID: 12690 RVA: 0x000F63BC File Offset: 0x000F45BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Action<T, T2>(SafeAction<T, T2> obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction<T, T2>.NativeMethodInfoPtr_op_Implicit_Public_Static_Action_2_T_T2_SafeAction_2_T_T2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<T, T2>>(intPtr3) : null;
			}
		}

		// Token: 0x06003193 RID: 12691 RVA: 0x000F6400 File Offset: 0x000F4600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SafeAction<T, T2>(Action<T, T2> obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction<T, T2>.NativeMethodInfoPtr_op_Implicit_Public_Static_SafeAction_2_T_T2_Action_2_T_T2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeAction<T, T2>>(intPtr3) : null;
			}
		}

		// Token: 0x06003194 RID: 12692 RVA: 0x00011BEF File Offset: 0x0000FDEF
		public SafeAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x06003195 RID: 12693 RVA: 0x000F6444 File Offset: 0x000F4644
		// (set) Token: 0x06003196 RID: 12694 RVA: 0x000F646C File Offset: 0x000F466C
		public unsafe T gWfsLHmVjBrPGPYzUOZDaKhbKHa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAction<T, T2>.NativeFieldInfoPtr_gWfsLHmVjBrPGPYzUOZDaKhbKHa);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAction<T, T2>.NativeFieldInfoPtr_gWfsLHmVjBrPGPYzUOZDaKhbKHa);
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

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06003197 RID: 12695 RVA: 0x000F6514 File Offset: 0x000F4714
		// (set) Token: 0x06003198 RID: 12696 RVA: 0x000F653C File Offset: 0x000F473C
		public unsafe T2 RhVFaWIPlbqBUFLCAfvUTKyZmzOi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAction<T, T2>.NativeFieldInfoPtr_RhVFaWIPlbqBUFLCAfvUTKyZmzOi);
				return IL2CPP.PointerToValueGeneric<T2>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAction<T, T2>.NativeFieldInfoPtr_RhVFaWIPlbqBUFLCAfvUTKyZmzOi);
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

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06003199 RID: 12697 RVA: 0x000F65E4 File Offset: 0x000F47E4
		// (set) Token: 0x0600319A RID: 12698 RVA: 0x00011BF8 File Offset: 0x0000FDF8
		public unsafe static Action<Object, Action<T, T2>> gBHYUjlrgPpCcxohnMBNikgNzss
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SafeAction<T, T2>.NativeFieldInfoPtr_gBHYUjlrgPpCcxohnMBNikgNzss, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object, Action<T, T2>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeAction<T, T2>.NativeFieldInfoPtr_gBHYUjlrgPpCcxohnMBNikgNzss, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A38 RID: 10808
		private static readonly IntPtr NativeFieldInfoPtr_gWfsLHmVjBrPGPYzUOZDaKhbKHa;

		// Token: 0x04002A39 RID: 10809
		private static readonly IntPtr NativeFieldInfoPtr_RhVFaWIPlbqBUFLCAfvUTKyZmzOi;

		// Token: 0x04002A3A RID: 10810
		private static readonly IntPtr NativeFieldInfoPtr_gBHYUjlrgPpCcxohnMBNikgNzss;

		// Token: 0x04002A3B RID: 10811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002A3C RID: 10812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_1_Exception_0;

		// Token: 0x04002A3D RID: 10813
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SafeAction_2_T_T2_0;

		// Token: 0x04002A3E RID: 10814
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_T_T2_0;

		// Token: 0x04002A3F RID: 10815
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

		// Token: 0x04002A40 RID: 10816
		private static readonly IntPtr NativeMethodInfoPtr_get_invokeDelegate_Private_Static_get_Action_2_Object_Action_2_T_T2_0;

		// Token: 0x04002A41 RID: 10817
		private static readonly IntPtr NativeMethodInfoPtr_IeDiRNoROqgJggMJIWRwJAkyOMlt_Private_Static_Void_Object_Action_2_T_T2_0;

		// Token: 0x04002A42 RID: 10818
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_SafeAction_2_T_T2_SafeAction_2_T_T2_Action_2_T_T2_0;

		// Token: 0x04002A43 RID: 10819
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_SafeAction_2_T_T2_SafeAction_2_T_T2_Action_2_T_T2_0;

		// Token: 0x04002A44 RID: 10820
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Action_2_T_T2_SafeAction_2_T_T2_0;

		// Token: 0x04002A45 RID: 10821
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SafeAction_2_T_T2_Action_2_T_T2_0;
	}
}
